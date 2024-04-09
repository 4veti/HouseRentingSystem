using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.House;
using HouseRentingSystem.Infrastructure.Data.Contracts;
using HouseRentingSystem.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Core.Services
{
    public class HouseService : IHouseService
    {
        private IRepository _repository;

        public HouseService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<HouseCategoryServiceModel>> AllCategories()
        {
            return await _repository
                .AllAsReadOnlyAsync<Category>()
                .Select(c => new HouseCategoryServiceModel
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();
        }

        public async Task<bool> CategoryExists(int categoryId)
            => await _repository.AllAsync<Category>().AnyAsync(c => c.Id == categoryId);

        public async Task<int> Create(HouseFormModel model, int agentId)
        {
            House house = new House
            {
                Title = model.Title,
                Address = model.Address,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                PricePerMonth = model.PricePerMonth,
                CategoryId = model.CategoryId,
                AgentId = agentId
            };

            await _repository.AddAsync(house);
            await _repository.SaveChangesAsync();

            return house.Id;
        }

        public async Task<IEnumerable<HouseIndexServiceModel>> LastThreeHouses()
        {
            return await _repository.AllAsReadOnlyAsync<House>()
                .OrderByDescending(h => h.Id)
                .Take(3)
                .Select(h => new HouseIndexServiceModel
                {
                    Id = h.Id,
                    Title = h.Title,
                    ImageUrl = h.ImageUrl
                })
                .ToListAsync();
        }
    }
}
