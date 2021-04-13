namespace CourseBook.WebApi.Admin.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Profiles.Entities;

    public interface IAdminService
    {
        Task<IEnumerable<UserEntity>> GetUsers(CancellationToken cancellationToken);

        Task DeleteUser(string Id, CancellationToken cancellationToken);

        Task SetRoles(string Id, CancellationToken cancellationToken);

    }
}
