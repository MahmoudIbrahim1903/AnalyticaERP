

namespace AnalyticaERP.Infra.Data.Repositories.BaseRepo
{
    public interface IBaseRepo<T> where T : class
    {
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task<IQueryable<T>> GetAllAsync();
        Task<IQueryable<T>> GetByIdAsync(long id);
        Task DeleteAsync(long id);
    }
}
