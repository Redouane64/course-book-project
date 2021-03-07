namespace CourseBook.WebApi.Profiles.Queries
{
    using System.Threading;
    using System.Threading.Tasks;

    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Routing;
    using Services;

    using ViewModels;

    public class GetProfileRequest : IRequest<ProfileViewModel>
    {
        public string Id { get; }

        public GetProfileRequest(string id)
        {
            Id = id;
        }
    }

    public class GetProfileRequestHandler : IRequestHandler<GetProfileRequest, ProfileViewModel>
    {
        private readonly IProfileService _profileService;
        private readonly IUrlHelperFactory _urlHelperFactory;

        public GetProfileRequestHandler(IProfileService profileService)
        {
            _profileService = profileService;
        }

        public async Task<ProfileViewModel> Handle(GetProfileRequest request, CancellationToken cancellationToken)
        {
            var profile = await this._profileService.GetProfile(request.Id, cancellationToken);

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
