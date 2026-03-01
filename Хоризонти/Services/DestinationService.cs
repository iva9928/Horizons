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

        // ================= ADD =================

        public async Task AddDestinationAsync(DestinationAddViewModel model, string userId)
        {
            var destination = new Destination
            {
                Name = model.Name,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                Location = model.Location ?? "",
                LocationUrl = model.LocationUrl,
                PublishedOn = DateTime.Parse(model.PublishedOn),
                TerrainId = model.TerrainId,
                PublisherId = userId,
                TicketPrice = model.TicketPrice,
                Season = model.Season,
                IsDeleted = false
            };

            await context.Destinations.AddAsync(destination);
            await context.SaveChangesAsync();
        }

        // ================= EDIT =================

        public async Task EditDestinationAsync(DestinationEditViewModel model, string userId)
        {
            var destination = await context.Destinations
                .FirstOrDefaultAsync(d => d.Id == model.Id && !d.IsDeleted);

            if (destination == null)
                throw new InvalidOperationException();

            if (destination.PublisherId != userId)
                throw new UnauthorizedAccessException();

            destination.Name = model.Name;
            destination.Description = model.Description;
            destination.ImageUrl = model.ImageUrl;
            destination.Location = model.Location;
            destination.LocationUrl = model.LocationUrl;
            destination.PublishedOn = DateTime.Parse(model.PublishedOn);
            destination.TerrainId = model.TerrainId;
            destination.TicketPrice = model.TicketPrice;
            destination.Season = model.Season;

            await context.SaveChangesAsync();
        }

        // ================= DELETE =================

        public async Task DeleteDestinationAsync(int id, string userId)
        {
            var destination = await context.Destinations
                .FirstOrDefaultAsync(d => d.Id == id && !d.IsDeleted);

            if (destination == null)
                throw new InvalidOperationException();

            if (destination.PublisherId != userId)
                throw new UnauthorizedAccessException();

            destination.IsDeleted = true;

            await context.SaveChangesAsync();
        }

        // ================= DETAILS =================

        public async Task<DestinationDetailsViewModel?> GetDestinationDetailsAsync(int id, string userId)
        {
            var destination = await context.Destinations
                .Include(d => d.Terrain)
                .Include(d => d.Publisher)
                .FirstOrDefaultAsync(d => d.Id == id && !d.IsDeleted);

            if (destination == null)
                return null;

            var ratings = await context.Ratings
                .Where(r => r.DestinationId == id)
                .Include(r => r.User)
                .ToListAsync();

            double average = ratings.Any() ? ratings.Average(r => r.Stars) : 0;

            bool isFavorite = false;

            if (!string.IsNullOrEmpty(userId))
            {
                isFavorite = await context.UserDestinations
                    .AnyAsync(x => x.UserId == userId && x.DestinationId == id);
            }

            return new DestinationDetailsViewModel
            {
                Id = destination.Id,
                Name = destination.Name,
                Description = destination.Description,
                ImageUrl = destination.ImageUrl,
                Location = destination.Location,
                LocationUrl = destination.LocationUrl,
                Publisher = destination.Publisher.UserName!,
                Terrain = destination.Terrain.Name,
                TicketPrice = destination.TicketPrice,
                PublishedOn = destination.PublishedOn.ToString("dd-MM-yyyy"),
                Season = destination.Season,
                IsPublisher = destination.PublisherId == userId,
                IsFavorite = isFavorite,
                AverageRating = average,
                HasRated = ratings.Any(r => r.UserId == userId),
                VideoUrl = destination.VideoUrl,
                Ratings = ratings.Select(r => new RatingViewModel
                {
                    Stars = r.Stars,
                    Comment = r.Comment,
                    User = r.User.UserName!,
                    CreatedOn = r.CreatedOn.ToString("dd-MM-yyyy")
                }).ToList()
            };
        }

        // ================= LIST WITH USER CONTEXT =================

        public async Task<IEnumerable<DestinationListViewModel>> GetAllDestinationsAsync(string userId)
        {
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
                    Season = d.Season,
                    IsPublisher = d.PublisherId == userId,
                    IsFavorite = context.UserDestinations
                        .Any(ud => ud.UserId == userId && ud.DestinationId == d.Id),
                    FavoritesCount = context.UserDestinations
                        .Count(ud => ud.DestinationId == d.Id)
                })
                .ToListAsync();
        }

        // ================= LIST WITHOUT USER =================

        public async Task<IEnumerable<DestinationListViewModel>> GetAllAsync()
        {
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
                    Season = d.Season
                })
                .ToListAsync();
        }

        // ================= GET BY ID =================

        public async Task<Destination?> GetDestinationByIdAsync(int id)
        {
            return await context.Destinations
                .Include(d => d.Publisher)
                .Include(d => d.Terrain)
                .FirstOrDefaultAsync(d => d.Id == id && !d.IsDeleted);
        }

        // ================= FAVORITES =================

        public async Task AddToFavoritesAsync(int destinationId, string userId)
        {
            bool exists = await context.UserDestinations
                .AnyAsync(x => x.UserId == userId && x.DestinationId == destinationId);

            if (!exists)
            {
                await context.UserDestinations.AddAsync(new UserDestination
                {
                    UserId = userId,
                    DestinationId = destinationId
                });

                await context.SaveChangesAsync();
            }
        }

        public async Task RemoveFromFavoritesAsync(int destinationId, string userId)
        {
            var favorite = await context.UserDestinations
                .FirstOrDefaultAsync(x => x.UserId == userId && x.DestinationId == destinationId);

            if (favorite != null)
            {
                context.UserDestinations.Remove(favorite);
                await context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<FavoriteDestinationViewModel>> GetFavoriteDestinationsAsync(string userId)
        {
            return await context.UserDestinations
                .Where(x => x.UserId == userId && !x.Destination.IsDeleted)
                .Select(x => new FavoriteDestinationViewModel
                {
                    Id = x.Destination.Id,
                    Name = x.Destination.Name,
                    ImageUrl = x.Destination.ImageUrl,
                    Terrain = x.Destination.Terrain.Name
                })
                .ToListAsync();
        }

        // ================= TERRAIN =================

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

        // ================= EDIT MODEL =================

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
                    Season = d.Season,
                    PublisherId = d.PublisherId,
                    Terrains = context.Terrains
                        .Select(t => new TerrainViewModel
                        {
                            Id = t.Id,
                            Name = t.Name
                        }).ToList()
                })
                .FirstOrDefaultAsync();
        }

        // ================= RATING =================

        public async Task AddRatingAsync(string userId, int destinationId, int stars, string comment)
        {
            var existing = await context.Ratings
                .FirstOrDefaultAsync(r => r.UserId == userId && r.DestinationId == destinationId);

            if (existing != null)
            {
                existing.Stars = stars;
                existing.Comment = comment;
                existing.CreatedOn = DateTime.Now;
            }
            else
            {
                await context.Ratings.AddAsync(new Rating
                {
                    UserId = userId,
                    DestinationId = destinationId,
                    Stars = stars,
                    Comment = comment,
                    CreatedOn = DateTime.Now
                });
            }

            await context.SaveChangesAsync();
        }
    }
}