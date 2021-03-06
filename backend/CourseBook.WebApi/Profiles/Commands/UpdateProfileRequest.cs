namespace CourseBook.WebApi.Profiles.Commands
{
    using System.Diagnostics;
    using System.Security.Claims;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Models;
    using Services;
    using ViewModels;

    public class UpdateProfileRequest : IRequest<ProfileViewModel>
    {
        public UpdateProfile Profile { get; }

        public UpdateProfileRequest(UpdateProfile profile)
        {
            Profile = profile;
        }
    }

    public class UpdateProfileRequestHandler : IRequestHandler<UpdateProfileRequest, ProfileViewModel>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IProfileService _profileService;

        public UpdateProfileRequestHandler(IHttpContextAccessor httpContextAccessor, IProfileService profileService)
        {
            _httpContextAccessor = httpContextAccessor;
            _profileService = profileService;
        }

        public async Task<ProfileViewModel> Handle(UpdateProfileRequest request, CancellationToken cancellationToken)
        {
            var userId = this._httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            Debug.Assert(userId is not null);
            var profile = await this._profileService.UpdateProfile(userId, request.Profile, cancellationToken);

            return new ProfileViewModel()
            {
                Id = profile.UserId,
                Name = profile.FullName,
                Email = profile.User.Email,
                Birthday = profile.BirthDay,
                AdmissionYear = profile.AdmissionYear,
                Faculty = profile.Faculty,
                Direction = profile.Direction,
                Group = profile.Group
            };
        }
    }
}
