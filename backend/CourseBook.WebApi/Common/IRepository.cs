using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CourseBook.WebApi.Common
{
    internal interface IRepository<T> where T : Entity, IAggregateRoot
    {
        Task<T> CreateAsync(T entity, CancellationToken cancellationToken = default);

        Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default);

        Task<IEnumerable<T>> GetAsync(CancellationToken cancellationToken = default);
    }
}
