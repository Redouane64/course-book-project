namespace CourseBook.WebApi.Services
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;

    using Profiles.Entities;
    using Profiles.Repositories;

    public sealed class ProfilesService : IProfileService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IProfilesRepository _profilesRepository;

        public ProfilesService(UserManager<IdentityUser> userManager, IProfilesRepository profilesRepository)
        {
            _userManager = userManager;
            _profilesRepository = profilesRepository;
        }

        public async Task<ProfileEntity> GetProfile(string userId, CancellationToken cancellationToken = default)
        {
            var user = await this._userManager.FindByIdAsync(userId);

            if (user is null)
            {
                throw new Exception("User does not exist.");
            }

            var profileEntity = await this._profilesRepository.GetProfileByUserId(userId);

            if (profileEntity is null)
            {
                throw new InvalidOperationException("User does not exist.");
            }

            profileEntity.User = user;

            return profileEntity;
        }
    }
}
