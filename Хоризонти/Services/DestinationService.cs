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

        public async Task<Destination?> GetDestinationByIdAsync(int id)
        {
            return await context.Destinations
                .FirstOrDefaultAsync(d => d.Id == id && !d.IsDeleted);
        }

        public async Task<DestinationDetailsViewModel?> GetDestinationDetailsAsync(int id, string userId)
        {
            var destination = await context.Destinations
                .Include(d => d.Publisher)
                .FirstOrDefaultAsync(d => d.Id == id && !d.IsDeleted);

            if (destination == null)
                return null;

            return new DestinationDetailsViewModel
            {
                Id = destination.Id,
                Name = destination.Name,
                Description = destination.Description,
                ImageUrl = destination.ImageUrl,
                Location = destination.Location,
                LocationUrl = destination.LocationUrl,
                Publisher = destination.Publisher.UserName!,
                TicketPrice = destination.TicketPrice,
                PublishedOn = destination.PublishedOn.ToString("dd-MM-yyyy"),
                Season = destination.Season,
                IsPublisher = destination.PublisherId == userId
            };
        }

        public async Task<IEnumerable<DestinationListViewModel>> GetAllDestinationsAsync(string userId)
        {
            return await context.Destinations
                .Where(d => !d.IsDeleted)
                .Select(d => new DestinationListViewModel
                {
                    Id = d.Id,
                    Name = d.Name,
                    ImageUrl = d.ImageUrl,
                    TerrainId = d.TerrainId,
                    TicketPrice = d.TicketPrice,
                    Season = d.Season,
                    IsPublisher = d.PublisherId == userId
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<DestinationListViewModel>> GetAllAsync()
        {
            return await context.Destinations
                .Where(d => !d.IsDeleted)
                .Select(d => new DestinationListViewModel
                {
                    Id = d.Id,
                    Name = d.Name,
                    ImageUrl = d.ImageUrl,
                    TerrainId = d.TerrainId,
                    TicketPrice = d.TicketPrice,
                    Season = d.Season
                })
                .ToListAsync();
        }

        public async Task<DestinationEditViewModel?> GetEditModelAsync(int id)
        {
            var destination = await context.Destinations
                .FirstOrDefaultAsync(d => d.Id == id && !d.IsDeleted);

            if (destination == null)
                return null;

            return new DestinationEditViewModel
            {
                Id = destination.Id,
                Name = destination.Name,
                Description = destination.Description,
                ImageUrl = destination.ImageUrl,
                Location = destination.Location,
                LocationUrl = destination.LocationUrl,
                PublishedOn = destination.PublishedOn.ToString("dd-MM-yyyy"),
                TerrainId = destination.TerrainId,
                TicketPrice = destination.TicketPrice,
                Season = destination.Season,
                PublisherId = destination.PublisherId
            };
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
                .Where(x => x.UserId == userId)
                .Select(x => new FavoriteDestinationViewModel
                {
                    Id = x.Destination.Id,
                    Name = x.Destination.Name,
                    ImageUrl = x.Destination.ImageUrl,
                    TicketPrice = x.Destination.TicketPrice
                })
                .ToListAsync();
        }

        public async Task AddRatingAsync(string userId, int destinationId, int stars, string comment)
        {
            var rating = new Rating
            {
                UserId = userId,
                DestinationId = destinationId,
                Stars = stars,
                Comment = comment,
                CreatedOn = DateTime.Now
            };

            await context.Ratings.AddAsync(rating);
            await context.SaveChangesAsync();
        }
    }
}