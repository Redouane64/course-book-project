namespace CourseBook.WebApi.Profiles.Queries
{
    using System.IO;
    using System.Security.Claims;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;
    using Microsoft.AspNetCore.Http;
    using Services;

    public class GetAvatarRequest : IRequest<(string contentType, Stream contents)>
    {
        public string UserId { get; }

        public GetAvatarRequest(string userId)
        {
            UserId = userId;
        }
    }

    public class GetAvatarRequestHandler : IRequestHandler<GetAvatarRequest, (string contentType, Stream contents)>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserFileService _fileService;

        public GetAvatarRequestHandler(IHttpContextAccessor httpContextAccessor, IUserFileService fileService)
        {
            _httpContextAccessor = httpContextAccessor;
            _fileService = fileService;
        }

        public async Task<(string contentType, Stream contents)> Handle(GetAvatarRequest request, CancellationToken cancellationToken)
        {
            // var userId = this._httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);

            return await this._fileService.GetAsync(request.UserId);
        }
    }
}
