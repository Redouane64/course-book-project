namespace CourseBook.WebApi.Profiles.Repositories
{
    using System;
    using System.Linq;
    using System.Security.Authentication;
    using System.Threading;
    using System.Threading.Tasks;

    using CourseBook.WebApi.Profiles.Entities;

    using Microsoft.AspNetCore.Identity;

    using Models;

    public class UsersService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IProfilesRepository _profilesRepository;

        public UsersService(
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IProfilesRepository profilesRepository)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _profilesRepository = profilesRepository;
        }

        public async Task<ProfileEntity> CreateUserAsync(RegistrationForm form, CancellationToken cancellationToken = default)
        {
            /*
             * create user name from Name property, replace space with dot
             * example: John Doe => john.doe
             */
            var username = form.Name.Replace(" ", ".").ToLowerInvariant();

            var user = new IdentityUser(username) { Email = form.Email };

            var result = await this._userManager.CreateAsync(user, form.Password);

            if (!result.Succeeded)
            {
                var message = result.Errors.Select(error => error.Description).First();
                throw new Exception(message);
            }

            var profileEntity = new ProfileEntity()
            {
                UserId = user.Id,
                FullName = form.Name,
                BirthDay = form.Birthday,
                AdmissionYear = form.AdmissionYear,
                Direction = form.Direction,
                Faculty = form.Faculty,
                Group = form.Group
            };

            // TODO: assign roles

            var saved = await this._profilesRepository.CreateAsync(profileEntity, cancellationToken);
            saved.User = user;

            return saved;
        }

        public async Task<ProfileEntity> GetUserAsync(LoginCredentials credentials,
            CancellationToken cancellationToken = default)
        {
            var user = await this._userManager.FindByEmailAsync(credentials.Email);

            if (user is null)
            {
                throw new InvalidCredentialException("Invalid user credentials.");
            }

            var isValidPassword = await this._userManager.CheckPasswordAsync(user, credentials.Password);

            if (!isValidPassword)
            {
                throw new InvalidCredentialException("Invalid user credentials.");
            }

            var profileEntity = await this._profilesRepository.GetProfileByUserId(user.Id);

            if (profileEntity is null)
            {
                throw new InvalidCredentialException("Invalid user credentials.");
            }

            profileEntity.User = user;

            return profileEntity;
        }
    }
}
