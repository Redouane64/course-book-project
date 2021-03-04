namespace CourseBook.WebApi.Profiles.Commands
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Security.Claims;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;
    using Microsoft.AspNetCore.Http;
    using Models;
    using Repositories;
    using Services;
    using ViewModels;

    public class RefreshTokenRequest : IRequest<TokenViewModel>
    {
        public TokenModel Tokens { get; }

        public RefreshTokenRequest(TokenModel tokens)
        {
            Tokens = tokens;
        }
    }

    public class RefreshTokenRequestHandler : IRequestHandler<RefreshTokenRequest, TokenViewModel>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ITokensService _tokensService;

        public RefreshTokenRequestHandler(IHttpContextAccessor httpContextAccessor, ITokensService tokensService)
        {
            _httpContextAccessor = httpContextAccessor;
            _tokensService = tokensService;
        }

        public async Task<TokenViewModel> Handle(RefreshTokenRequest request, CancellationToken cancellationToken)
        {
            var (Token, RefreshToken) = await this._tokensService.RefreshToken(
                request.Tokens.RefreshToken,
                this._httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier)
            );

            return new TokenViewModel(Token, RefreshToken);        }
    }
}
