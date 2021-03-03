namespace CourseBook.WebApi.Profiles.Commands
{
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading;
    using System.Threading.Tasks;

    using Entities;

    using MediatR;

    using Models;

    using Repositories;

    using Services;

    public class CreateProfileRequest : IRequest<RegistrationForm>
    {

    }

    public class CreateProfileRequestHandler : IRequestHandler<CreateProfileRequest, object>
    {
        private readonly IProfilesRepository _profilesRepository;
        private readonly ITokensService _tokensService;

        public CreateProfileRequestHandler(IProfilesRepository profilesRepository, ITokensService tokensService)
        {
            _profilesRepository = profilesRepository;
            _tokensService = tokensService;
        }

        public async Task<object> Handle(CreateProfileRequest request, CancellationToken cancellationToken)
        {
            var profile = new ProfileEntity();

            var entity = await this._profilesRepository.Create(profile);

            var claims = new List<Claim>(new Claim[]
            {
                new Claim(ClaimTypes.NameIdentifier, entity.Id),
                new Claim(ClaimTypes.Name, entity.Name),
                new Claim(ClaimTypes.Email, entity.Email),
            });

            return null; // TODO:
        }
    }
}
