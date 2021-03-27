namespace CourseBook.WebApi.Profiles.Queries
{
    using System.Threading;
    using System.Threading.Tasks;

    using CourseBook.WebApi.Profiles.ViewModels;

    using MediatR;

    using Services;

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

        public GetProfileRequestHandler(IProfileService profileService)
        {
            _profileService = profileService;
        }

        public async Task<ProfileViewModel> Handle(GetProfileRequest request, CancellationToken cancellationToken)
        {
            var user = await this._profileService.GetProfile(request.Id, cancellationToken);

            return new ProfileViewModel()
            {
                Id = user.Id.ToString(),
                Name = user.FullName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Birthday = user.BirthDay,
                AdmissionYear = user.AdmissionYear,
            };
        }
    }
}
