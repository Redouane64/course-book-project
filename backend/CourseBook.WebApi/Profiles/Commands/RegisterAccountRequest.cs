namespace CourseBook.WebApi.Profiles.Commands
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Security.Claims;
    using System.Threading;
    using System.Threading.Tasks;

    using MediatR;

    using Models;

    using Repositories;

    using Services;

    using ViewModels;

    public class RegisterAccountRequest : IRequest<TokenViewModel>
    {
        public RegistrationForm Form { get; }

        public RegisterAccountRequest(RegistrationForm form)
        {
            Form = form;
        }
    }

    public class RegisterAccountRequestHandler : IRequestHandler<RegisterAccountRequest, TokenViewModel>
    {
        private readonly UsersService _usersService;
        private readonly ITokensService _tokensService;

        public RegisterAccountRequestHandler(UsersService usersService, ITokensService tokensService)
        {
            _usersService = usersService;
            _tokensService = tokensService;
        }

        public async Task<TokenViewModel> Handle(RegisterAccountRequest request, CancellationToken cancellationToken)
        {
            var profile = await this._usersService.CreateUserAsync(request.Form, cancellationToken);

            Debug.Assert(profile.User is not null);

            var claims = new List<Claim>(new Claim[]
            {
                new Claim(ClaimTypes.NameIdentifier, profile.UserId),
            });

            var (Token, RefreshToken) = await this._tokensService.GenerateToken(claims, profile.User);

            return new TokenViewModel(Token, RefreshToken, profile.UserId);
        }
    }
}
