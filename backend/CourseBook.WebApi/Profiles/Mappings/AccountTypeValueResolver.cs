namespace CourseBook.WebApi.Profiles.Mappings
{
    using System;

    using AutoMapper;

    using CourseBook.WebApi.Identity.Models;
    using CourseBook.WebApi.Profiles.Entities;
    using CourseBook.WebApi.Profiles.ViewModels;

    using Microsoft.AspNetCore.Identity;

    public class AccountTypeValueResolver : IValueResolver<UserEntity, ProfileViewModel, AccountType>
    {
        private readonly UserManager<UserEntity> userManager;

        public AccountTypeValueResolver(UserManager<UserEntity> userManager)
        {
            this.userManager = userManager;
        }

        public AccountType Resolve(UserEntity source, ProfileViewModel destination, AccountType destMember, ResolutionContext context)
        {
            var role = this.userManager.GetRolesAsync(source).GetAwaiter().GetResult();

            return Enum.Parse<AccountType>(role[0]);
        }
    }
}
