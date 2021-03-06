namespace CourseBook.WebApi.Services
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;

    using Models;

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

        public async Task<ProfileEntity> UpdateProfile(string userId, UpdateProfile profileData, CancellationToken cancellationToken = default)
        {
            IdentityUser user = await this._userManager.FindByIdAsync(userId);

            if (user is null)
            {
                throw new Exception("Incorrect or unauthorized user.");
            }

            if (profileData.Email is not null)
            {
                if (!String.Equals(user.Email, profileData.Email, StringComparison.InvariantCultureIgnoreCase))
                {
                    await this._userManager.UpdateNormalizedEmailAsync(user);
                }
            }

            var profile = await this._profilesRepository.GetProfileByUserId(userId);

            if (profile is null)
            {
                throw new Exception("Incorrect or unauthorized user.");
            }

            profile.FullName = profileData.FullName;
            profile.BirthDay = profileData.BirthDay;
            profile.AdmissionYear = profileData.AdmissionYear;

            var profileEntity = await this._profilesRepository.UpdateAsync(profile, cancellationToken);
            profileEntity.User = user;

            return profileEntity;
        }
    }
}
