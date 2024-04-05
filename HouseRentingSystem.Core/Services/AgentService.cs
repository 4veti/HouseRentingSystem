﻿using HouseRentingSystem.Core.Contracts;
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

        public async Task<bool> ExistsById(string userId)
            => await repository.AllAsReadOnlyAsync<Agent>()
                .AnyAsync(a => a.UserId == userId);

        public async Task<bool> UserHasRents(string userId)
            => await repository.AllAsReadOnlyAsync<House>()
                .AnyAsync(h => h.RenterId == userId);

        public async Task<bool> UserWithPhoneNumberExists(string phoneNumber)
            => await repository.AllAsReadOnlyAsync<Agent>()
                .AnyAsync(a => a.PhoneNumber == phoneNumber);

        public async Task Create(string userId, string phoneNumber)
        {
            Agent agent = new Agent
            {
                UserId = userId,
                PhoneNumber = phoneNumber
            };

            await repository.AddAsync(agent);
            await repository.SaveChangesAsync();
        }
    }
}
