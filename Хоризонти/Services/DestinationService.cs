using Horizons.Data;
using Horizons.Data.Models;
using Horizons.Models;
using Microsoft.EntityFrameworkCore;

namespace Horizons.Services
{
    public class DestinationService : IDestinationService
    {
        private readonly ApplicationDbContext context;

        public DestinationService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task AddDestinationAsync(DestinationAddViewModel model, string userId)
        {
            var destination = new Destination
            {
                Name = model.Name,
                Description = model.Description,
                ImageUrl = model.ImageUrl,

                Location = model.Location?.Trim() ?? "",
                LocationUrl = string.IsNullOrWhiteSpace(model.LocationUrl) ? null : model.LocationUrl.Trim(),

                PublishedOn = DateTime.Parse(model.PublishedOn),
                TerrainId = model.TerrainId,
                PublisherId = userId,
                TicketPrice = model.TicketPrice,
                IsDeleted = false
            };

            await context.Destinations.AddAsync(destination);
            await context.SaveChangesAsync();
        }


        public async Task EditDestinationAsync(DestinationEditViewModel model, string userId)
        {
            var destination = await context.Destinations
                .FirstOrDefaultAsync(d => d.Id == model.Id && !d.IsDeleted);

            if (destination == null)
                throw new InvalidOperationException("Destination not found.");

            if (destination.PublisherId != userId)
                throw new UnauthorizedAccessException("You are not the publisher.");

            destination.Name = model.Name;
            destination.Description = model.Description;
            destination.ImageUrl = model.ImageUrl;
            destination.Location = model.Location;
            destination.LocationUrl = model.LocationUrl;
            destination.PublishedOn = DateTime.Parse(model.PublishedOn);
            destination.TerrainId = model.TerrainId;
            destination.TicketPrice = model.TicketPrice;

            await context.SaveChangesAsync();
        }

        public async Task<DestinationDetailsViewModel?> GetDestinationDetailsAsync(int id, string userId)
        {
            var d = await context.Destinations
                .Include(x => x.Terrain)
                .Include(x => x.Publisher)
                .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

            if (d == null)
                return null;

            bool isFavorite = await context.UserDestinations
                .AnyAsync(ud => ud.UserId == userId && ud.DestinationId == id);

            var ratings = await context.Ratings
                .Where(r => r.DestinationId == id)
                .Include(r => r.User)
                .ToListAsync();

            double avg = ratings.Any() ? ratings.Average(r => r.Stars) : 0;
            bool hasRated = ratings.Any(r => r.UserId == userId);

            return new DestinationDetailsViewModel
            {
                Id = d.Id,
                Name = d.Name,
                Description = d.Description,
                ImageUrl = d.ImageUrl,

                // ❤️ ЗАРЕЖДА ЛОКАЦИЯТА КОРЕКТНО
                Location = d.Location,
                LocationUrl = d.LocationUrl,

                Publisher = d.Publisher.UserName,
                Terrain = d.Terrain.Name,
                TicketPrice = d.TicketPrice,
                PublishedOn = d.PublishedOn.ToString("dd-MM-yyyy"),
                IsPublisher = d.PublisherId == userId,
                IsFavorite = isFavorite,

                AverageRating = avg,
                HasRated = hasRated,

                Ratings = ratings.Select(r => new RatingViewModel
                {
                    Stars = r.Stars,
                    Comment = r.Comment,
                    User = r.User.UserName!,
                    CreatedOn = r.CreatedOn.ToString("dd-MM-yyyy")
                }).ToList()
            };
        }

        public async Task<IEnumerable<DestinationListViewModel>> GetAllDestinationsAsync(string userId)
        {
            var userDest = context.UserDestinations.AsQueryable();

            return await context.Destinations
                .Include(d => d.Terrain)
                .Where(d => !d.IsDeleted)
                .Select(d => new DestinationListViewModel
                {
                    Id = d.Id,
                    Name = d.Name,
                    ImageUrl = d.ImageUrl,
                    Terrain = d.Terrain.Name,
                    TicketPrice = d.TicketPrice,
                    FavoritesCount = userDest.Count(ud => ud.DestinationId == d.Id),
                    IsPublisher = d.PublisherId == userId,
                    IsFavorite = userDest.Any(ud => ud.UserId == userId && ud.DestinationId == d.Id)
                })
                .ToListAsync();
        }

        public async Task<Destination?> GetDestinationByIdAsync(int id)
        {
            return await context.Destinations
                .Include(d => d.Publisher)
                .Include(d => d.Terrain)
                .FirstOrDefaultAsync(d => d.Id == id && !d.IsDeleted);
        }


        public async Task<IEnumerable<FavoriteDestinationViewModel>> GetFavoriteDestinationsAsync(string userId)
        {
            return await context.UserDestinations
                .Where(ud => ud.UserId == userId && !ud.Destination.IsDeleted)
                .Select(ud => new FavoriteDestinationViewModel
                {
                    Id = ud.Destination.Id,
                    Name = ud.Destination.Name,
                    ImageUrl = ud.Destination.ImageUrl,
                    Terrain = ud.Destination.Terrain.Name
                })
                .ToListAsync();
        }

        public async Task AddToFavoritesAsync(string userId, int destinationId)
        {
            if (!await context.UserDestinations
                .AnyAsync(ud => ud.UserId == userId && ud.DestinationId == destinationId))
            {
                await context.UserDestinations.AddAsync(new UserDestination
                {
                    UserId = userId,
                    DestinationId = destinationId
                });

                await context.SaveChangesAsync();
            }
        }

        public async Task RemoveFromFavoritesAsync(string userId, int destinationId)
        {
            var fav = await context.UserDestinations
                .FirstOrDefaultAsync(ud => ud.UserId == userId && ud.DestinationId == destinationId);

            if (fav != null)
            {
                context.UserDestinations.Remove(fav);
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteDestinationAsync(int id, string userId)
        {
            var destination = await context.Destinations
                .FirstOrDefaultAsync(d => d.Id == id && !d.IsDeleted);

            if (destination == null)
                throw new InvalidOperationException("Destination not found.");

            if (destination.PublisherId != userId)
                throw new UnauthorizedAccessException("Not allowed.");

            destination.IsDeleted = true;
            await context.SaveChangesAsync();
        }


        public async Task<IEnumerable<TerrainViewModel>> GetAllTerrainsAsync()
        {
            return await context.Terrains
                .Select(t => new TerrainViewModel
                {
                    Id = t.Id,
                    Name = t.Name
                })
                .ToListAsync();
        }

        public async Task<DestinationEditViewModel?> GetEditModelAsync(int id)
        {
            return await context.Destinations
                .Where(d => d.Id == id && !d.IsDeleted)
                .Select(d => new DestinationEditViewModel
                {
                    Id = d.Id,
                    Name = d.Name,
                    Description = d.Description,
                    ImageUrl = d.ImageUrl,
                    Location = d.Location,
                    LocationUrl = d.LocationUrl,
                    PublishedOn = d.PublishedOn.ToString("dd-MM-yyyy"),
                    TerrainId = d.TerrainId,
                    TicketPrice = d.TicketPrice,
                    PublisherId = d.PublisherId,
                    Terrains = context.Terrains
                        .Select(t => new TerrainViewModel { Id = t.Id, Name = t.Name })
                        .ToList()
                })
                .FirstOrDefaultAsync();
        }

        public async Task AddRatingAsync(string userId, int destinationId, int stars, string comment)
        {
            var exists = await context.Ratings
                .FirstOrDefaultAsync(r => r.UserId == userId && r.DestinationId == destinationId);

            if (exists != null)
            {
                exists.Stars = stars;
                exists.Comment = comment;
                exists.CreatedOn = DateTime.Now;
            }
            else
            {
                await context.Ratings.AddAsync(new Rating
                {
                    UserId = userId,
                    DestinationId = destinationId,
                    Stars = stars,
                    Comment = comment
                });
            }

            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<DestinationListViewModel>> GetAllAsync()
        {
            return await context.Destinations
                .Select(d => new DestinationListViewModel
                {
                    Id = d.Id,
                    Name = d.Name,
                    ImageUrl = d.ImageUrl,
                    Terrain = d.Terrain.Name,
                    TicketPrice = d.TicketPrice
                })
                .ToListAsync();
        }

    }
}
