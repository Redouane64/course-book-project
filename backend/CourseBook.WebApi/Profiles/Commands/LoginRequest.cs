namespace CourseBook.WebApi.Profiles.Commands
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Profiles.Constants;
    using MediatR;
    using Models;
    using Repositories;
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
        private readonly UsersService _usersService;
        private readonly ITokensService _tokensService;

        public LoginRequestHandler(UsersService usersService, ITokensService tokensService)
        {
            _usersService = usersService;
            _tokensService = tokensService;
        }

        async public Task<TokenViewModel> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
            var user = await this._usersService.GetUserAsync(request.Credentials, cancellationToken);
            var roles = await this._usersService.GetUserRolesAsync(user);

            var claims = new List<Claim>(new Claim[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Role, Roles.StudentRoleName),
            });

            if(roles.Contains(Roles.TeacherRoleName)) {
                claims.Add(new Claim(ClaimTypes.Role, Roles.TeacherRoleName));
            }

            var (Token, RefreshToken) = await this._tokensService.GenerateToken(claims, user);

            return new TokenViewModel(Token, RefreshToken);
        }
    }
}
