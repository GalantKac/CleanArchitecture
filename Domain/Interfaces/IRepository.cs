using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRepository<T> where T: class
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> GetEntityWithSpecification(ISpecification<T> specification);
        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> specification);
        Task<int> CountAsync(ISpecification<T> specification);
    }
}
