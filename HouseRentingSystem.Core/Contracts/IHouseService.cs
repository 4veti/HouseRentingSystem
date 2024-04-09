using HouseRentingSystem.Core.Models.House;

namespace HouseRentingSystem.Core.Contracts
{
    public interface IHouseService
    {
        public Task<IEnumerable<HouseIndexServiceModel>> LastThreeHouses();

        public Task<IEnumerable<HouseCategoryServiceModel>> AllCategories();

        public Task<bool> CategoryExists(int categoryId);

        public Task<int> Create(HouseFormModel model, int agentId);
    }
}
