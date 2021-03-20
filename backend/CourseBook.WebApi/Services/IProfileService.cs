namespace CourseBook.WebApi.Services
{
    using System.Threading;
    using System.Threading.Tasks;
    using Models;
    using Profiles.Entities;

    public interface IProfileService
    {
        Task<ProfileEntity> GetProfile(string userId, CancellationToken cancellationToken = default);

        Task<ProfileEntity> UpdateProfile(string userId, UpdateProfile profileData,
            CancellationToken cancellationToken = default);
    }
}
