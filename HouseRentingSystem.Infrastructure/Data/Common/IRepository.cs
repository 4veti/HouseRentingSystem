namespace HouseRentingSystem.Infrastructure.Data.Contracts
{
    public interface IRepository 
    {
        public IQueryable<T> AllAsync<T>() where T : class; 
        public IQueryable<T> AllAsReadOnlyAsync<T>() where T : class;
    }
}
