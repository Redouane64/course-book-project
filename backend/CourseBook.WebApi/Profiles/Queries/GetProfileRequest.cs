namespace CourseBook.WebApi.Profiles.Queries
{
    using System.Threading;
    using System.Threading.Tasks;

    using AutoMapper;

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
        private readonly IMapper mapper;

        public GetProfileRequestHandler(IProfileService profileService, IMapper mapper)
        {
            _profileService = profileService;
            this.mapper = mapper;
        }

        public async Task<ProfileViewModel> Handle(GetProfileRequest request, CancellationToken cancellationToken)
        {
            var user = await this._profileService.GetProfile(request.Id, cancellationToken);
            return this.mapper.Map<ProfileViewModel>(user);
        }
    }
}
