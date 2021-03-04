namespace CourseBook.WebApi.Profiles.Repositories
{
    using System.Threading.Tasks;

    using CourseBook.WebApi.Common;
    using CourseBook.WebApi.Profiles.Entities;

    public interface IProfilesRepository : IRepository<ProfileEntity>
    {
        Task<ProfileEntity> GetProfileByUserId(string userId);
    }
}
