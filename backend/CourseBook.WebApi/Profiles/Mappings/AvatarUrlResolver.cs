namespace CourseBook.WebApi.Profiles.Mappings
{

    using AutoMapper;

    using CourseBook.WebApi.Controllers;
    using CourseBook.WebApi.Profiles.Entities;
    using CourseBook.WebApi.Profiles.ViewModels;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Infrastructure;
    using Microsoft.AspNetCore.Mvc.Routing;

    public class AvatarUrlResolver : IMemberValueResolver<UserEntity, ProfileViewModel, string, string>
    {
        private readonly IUrlHelper urlHelper;

        public AvatarUrlResolver(IActionContextAccessor actionContextAccessor)
        {
            this.urlHelper = new UrlHelperFactory()
                .GetUrlHelper(actionContextAccessor.ActionContext);
        }

        public string Resolve(UserEntity source, ProfileViewModel destination, string sourceMember, string destMember, ResolutionContext context)
        {
            return urlHelper.Link(nameof(ProfilesController.GetAvatar), new { id = source.Id });
        }
    }
}
