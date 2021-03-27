namespace CourseBook.WebApi.Services
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;

    using Models;

    using Profiles.Entities;

    public sealed class ProfilesService : IProfileService
    {
        private readonly UserManager<UserEntity> _userManager;

        public ProfilesService(UserManager<UserEntity> userManager)
        {
            _userManager = userManager;
        }

        public async Task<UserEntity> GetProfile(string id, CancellationToken cancellationToken = default)
        {
            var user = await this._userManager.FindByIdAsync(id);

            if (user is null)
            {
                throw new Exception("User does not exist.");
            }

            return user;
        }

        public async Task<UserEntity> UpdateProfile(string id, UpdateProfile data, CancellationToken cancellationToken = default)
        {
            UserEntity user = await this._userManager.FindByIdAsync(id);

            if (user is null)
            {
                throw new Exception("User does not exist.");
            }

            if (data.Email is not null)
            {
                if (!String.Equals(user.Email, data.Email, StringComparison.InvariantCultureIgnoreCase))
                {
                    await this._userManager.UpdateNormalizedEmailAsync(user);
                }
            }

            user.FullName = data.FullName;
            user.BirthDay = data.BirthDay;
            user.AdmissionYear = data.AdmissionYear;
            user.PhoneNumber = data.PhoneNumber;

            _ = await this._userManager.UpdateAsync(user);

            return user;
        }
    }
}
