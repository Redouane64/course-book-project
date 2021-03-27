namespace CourseBook.WebApi.Profiles.Queries
{
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    using CourseBook.WebApi.Files.Services;

    using MediatR;

    using Microsoft.AspNetCore.Http;

    public class GetAvatarRequest : IRequest<(string contentType, Stream contents)>
    {
        public string Id { get; }

        public GetAvatarRequest(string id)
        {
            Id = id;
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
            // TODO: fix and refactor
            // var Id = this._httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            return await this._fileService.GetAsync(request.Id);
        }
    }
}
