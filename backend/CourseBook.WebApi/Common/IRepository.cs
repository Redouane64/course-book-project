namespace CourseBook.WebApi.Common
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IRepository<T> where T : IAggregateRoot
    {
        Task<T> CreateAsync(T entity, CancellationToken cancellationToken = default);

        Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default);

        Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default);
    }
}
