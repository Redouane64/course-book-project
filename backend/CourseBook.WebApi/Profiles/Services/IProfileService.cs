namespace CourseBook.WebApi.Profiles.Services
{
    using System.Threading;
    using System.Threading.Tasks;

    using Models;

    using Profiles.Entities;

    public interface IProfileService
    {
        Task<UserEntity> GetProfile(string Id, CancellationToken cancellationToken = default);

        Task<UserEntity> UpdateProfile(string Id, UpdateProfile profileData,
            CancellationToken cancellationToken = default);
    }
}
