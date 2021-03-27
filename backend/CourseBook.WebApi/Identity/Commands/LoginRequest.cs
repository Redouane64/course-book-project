namespace CourseBook.WebApi.Identity.Commands
{
    using System.Security.Authentication;
    using System.Security.Claims;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Profiles.Entities;
    using MediatR;
    using Microsoft.AspNetCore.Identity;
    using Models;
    using Services;
    using ViewModels;

    public class LoginRequest : IRequest<TokenViewModel>
    {
        public LoginCredentials Credentials { get; }

        public LoginRequest(LoginCredentials credentials)
        {
            Credentials = credentials;
        }
    }

    public class LoginRequestHandler : IRequestHandler<LoginRequest, TokenViewModel>
    {
        private readonly ITokensService _tokensService;
        private readonly UserManager<UserEntity> _userManager;

        public LoginRequestHandler(
            UserManager<UserEntity> userManager,
            ITokensService tokensService)
        {
            this._userManager = userManager;
            this._tokensService = tokensService;
        }

        public async Task<TokenViewModel> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
            var user = await this._userManager.FindByEmailAsync(request.Credentials.Email);

            if (user is null)
            {
                throw new InvalidCredentialException("Invalid user credentials.");
            }

            var isValidPassword = await this._userManager.CheckPasswordAsync(user, request.Credentials.Password);

            if (!isValidPassword)
            {
                throw new InvalidCredentialException("Invalid user credentials.");
            }

            var roles = await this._userManager.GetRolesAsync(user);

            var claims = new Claim[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Role, roles[0])
            };

            var (Token, RefreshToken) = await this._tokensService.GenerateToken(claims, user);

            return new TokenViewModel(Token, RefreshToken);
        }
    }
}
