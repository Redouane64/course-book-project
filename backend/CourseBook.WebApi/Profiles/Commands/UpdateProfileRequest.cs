namespace CourseBook.WebApi.Profiles.Commands
{
    using System.Security.Claims;
    using System.Threading;
    using System.Threading.Tasks;

    using AutoMapper;

    using CourseBook.WebApi.Profiles.Models;
    using CourseBook.WebApi.Profiles.ViewModels;

    using MediatR;

    using Microsoft.AspNetCore.Http;

    using Services;

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
        private readonly IMapper mapper;

        public UpdateProfileRequestHandler(IHttpContextAccessor httpContextAccessor, IProfileService profileService, IMapper mapper)
        {
            _httpContextAccessor = httpContextAccessor;
            _profileService = profileService;
            this.mapper = mapper;
        }

        public async Task<ProfileViewModel> Handle(UpdateProfileRequest request, CancellationToken cancellationToken)
        {
            var Id = this._httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await this._profileService.UpdateProfile(Id, request.Profile, cancellationToken);
            return this.mapper.Map<ProfileViewModel>(user);
        }
    }
}
