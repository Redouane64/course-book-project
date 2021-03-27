namespace CourseBook.WebApi.Profiles.Services
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    using CourseBook.WebApi.Models;
    using CourseBook.WebApi.Profiles.Entities;

    using Microsoft.AspNetCore.Identity;

    public sealed class ProfilesService : IProfileService
    {
        private readonly UserManager<UserEntity> _userManager;

        public ProfilesService(UserManager<UserEntity> userManager)
        {
            _userManager = userManager;
        }

        public async Task<UserEntity> GetProfile(string id, CancellationToken cancellationToken = default)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user is null)
            {
                throw new Exception("User does not exist.");
            }

            return user;
        }

        public async Task<UserEntity> UpdateProfile(string id, UpdateProfile data, CancellationToken cancellationToken = default)
        {
            UserEntity user = await _userManager.FindByIdAsync(id);

            if (user is null)
            {
                throw new Exception("User does not exist.");
            }

            if (data.Email is not null)
            {
                if (!string.Equals(user.Email, data.Email, StringComparison.InvariantCultureIgnoreCase))
                {
                    await _userManager.UpdateNormalizedEmailAsync(user);
                }
            }

            user.FullName = data.FullName;
            user.BirthDay = data.BirthDay;
            user.AdmissionYear = data.AdmissionYear;
            user.PhoneNumber = data.PhoneNumber;

            _ = await _userManager.UpdateAsync(user);

            return user;
        }
    }
}
