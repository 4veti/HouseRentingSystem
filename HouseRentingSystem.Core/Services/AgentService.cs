using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Infrastructure.Data.Common;
using HouseRentingSystem.Infrastructure.Data.Contracts;
using HouseRentingSystem.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Core.Services
{
    public class AgentService : IAgentService
    {
        private IRepository _repository;

        public AgentService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> ExistsByIdAsync(string userId)
            => await _repository.AllAsReadOnlyAsync<Agent>()
                .AnyAsync(a => a.UserId == userId);

        public async Task<bool> UserHasRentsAsync(string userId)
            => await _repository.AllAsReadOnlyAsync<House>()
                .AnyAsync(h => h.RenterId == userId);

        public async Task<bool> UserWithPhoneNumberExistsAsync(string phoneNumber)
            => await _repository.AllAsReadOnlyAsync<Agent>()
                .AnyAsync(a => a.PhoneNumber == phoneNumber);

        public async Task CreateAsync(string userId, string phoneNumber)
        {
            Agent agent = new Agent
            {
                UserId = userId,
                PhoneNumber = phoneNumber
            };

            await _repository.AddAsync(agent);
            await _repository.SaveChangesAsync();
        }
        public async Task<int> GetId(string userId)
        {
            Agent agentId = await _repository.AllAsReadOnlyAsync<Agent>()
                                 .FirstAsync(a => a.UserId == userId);

            return agentId.Id;
        }
    }
}
