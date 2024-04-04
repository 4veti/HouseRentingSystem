using HouseRentingSystem.Infrastructure.Data.Contracts;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Infrastructure.Data.Common
{
    public class Repository : IRepository
    {
        private DbContext context;

        public Repository(ApplicationDbContext _context)
        {
            context = _context;
        }

        public IQueryable<T> AllAsync<T>() where T : class
        {
            return DbSet<T>();
        }

        public IQueryable<T> AllAsReadOnlyAsync<T>() where T : class
        {
            return DbSet<T>()
                .AsNoTracking();
        }

        private DbSet<T> DbSet<T>() where T : class
            => context.Set<T>();
    }

}