namespace CourseBook.WebApi.Identity.Commands
{
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;
    using Services;

    public class LogoutRequest : IRequest
    { }

    public class LogoutRequestHandler : IRequestHandler<LogoutRequest>
    {
        private readonly ITokensService _tokensService;

        public LogoutRequestHandler(ITokensService tokensService)
        {
            _tokensService = tokensService;
        }

        public async Task<Unit> Handle(LogoutRequest request, CancellationToken cancellationToken)
        {
            // TODO: clear old JWT token
            return await Task.FromResult(Unit.Value);
        }
    }
}
