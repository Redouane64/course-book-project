namespace CourseBook.WebApi.Profiles.Commands
{
    using System.Security.Claims;
    using System.Threading;
    using System.Threading.Tasks;

    using MediatR;

    using Microsoft.AspNetCore.Http;

    using Services;


    public class LogOutRequest : IRequest
    { }

    public class LogOutRequestHandler : IRequestHandler<LogOutRequest>
    {
        private readonly ITokensService _tokensService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LogOutRequestHandler(ITokensService tokensService, IHttpContextAccessor httpContextAccessor)
        {
            _tokensService = tokensService;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<Unit> Handle(LogOutRequest request, CancellationToken cancellationToken)
        {
            var userId = this._httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            await this._tokensService.Invalidate(userId);
            return await Task.FromResult(Unit.Value);
        }
    }
}
