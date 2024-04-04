using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Infrastructure.Data.Contracts;
using HouseRentingSystem.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Core.Services
{
    public class AgentService : IAgentService
    {
        private IRepository repository;

        public AgentService(IRepository _repository)
        {
            repository = _repository;
        }

        public Task<bool> ExistsById(string userId)
            => repository.AllAsReadOnlyAsync<Agent>().AnyAsync(a => a.UserId == userId);
    }
}
