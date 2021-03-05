namespace CourseBook.WebApi.Services
{
    using System.Threading;
    using System.Threading.Tasks;

    using Profiles.Entities;

    public interface IProfileService
    {
        Task<ProfileEntity> GetProfile(string userId, CancellationToken cancellationToken = default);
    }
}
