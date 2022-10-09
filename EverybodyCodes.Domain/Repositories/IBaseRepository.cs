using EverybodyCodes.Domain.Entities;

namespace EverybodyCodes.Domain.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
	{
		Task<IReadOnlyList<T>> GetAllAsync();
		Task<T> GetByIdAsync(int id);
		Task<T> AddAsync(T entity);
		Task UpdateAsync(T entity);
		Task DeleteAsync(T entity);


	}
}
