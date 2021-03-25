namespace CourseBook.WebApi.Profiles.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Authentication;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Profiles.Constants;
    using CourseBook.WebApi.Profiles.Entities;
    using Microsoft.AspNetCore.Identity;
    using Models;

    public class UsersService
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UsersService(
            UserManager<UserEntity> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<UserEntity> CreateUserAsync(RegistrationForm form, CancellationToken cancellationToken = default)
        {
            /*
             * create user name from Name property, replace space with dot
             * example: John Doe => john.doe
             */
            var username = form.Name.Replace(" ", ".").ToLowerInvariant();

            var user = new UserEntity { UserName = username, Email = form.Email };

            var result = await this._userManager.CreateAsync(user, form.Password);

            if (!result.Succeeded)
            {
                var message = result.Errors.Select(error => error.Description).First();
                throw new Exception(message);
            }

            var userRoles = new List<string>();

            if (form.AccountType == AccountType.Student) {
                userRoles.Add(Roles.StudentRoleName);
            }

            if (form.AccountType == AccountType.Teacher) {
                userRoles.Add(Roles.TeacherRoleName);
            }

            // assign roles
            var roleResult = await this._userManager.AddToRolesAsync(user, userRoles);

            if(!roleResult.Succeeded)
            {
                await this._userManager.DeleteAsync(user);

                var message = result.Errors.Select(error => error.Description).First();
                throw new Exception(message);
            }

            return user;
        }

        public async Task<UserEntity> GetUserAsync(LoginCredentials credentials,
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

            return user;
        }

        public async Task<IEnumerable<string>> GetUserRolesAsync(UserEntity user)
        {
            return await this._userManager.GetRolesAsync(user);
        }
    }
}
