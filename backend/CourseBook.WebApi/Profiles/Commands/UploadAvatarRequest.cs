namespace CourseBook.WebApi.Profiles.Commands
{
    using System.IO;
    using System.Security.Claims;
    using System.Threading;
    using System.Threading.Tasks;

    using CourseBook.WebApi.Files.Services;

    using MediatR;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc.ModelBinding;

    public class UploadAvatarRequest : IRequest
    {
        public Stream ImageStream { get; }
        public string ContentType { get; }

        public UploadAvatarRequest(Stream imageStream, string contentType)
        {
            ImageStream = imageStream;
            ContentType = contentType;
        }
    }

    public class UploadAvatarRequestHandler : IRequestHandler<UploadAvatarRequest, Unit>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserFileService _fileService;

        public UploadAvatarRequestHandler(IHttpContextAccessor httpContextAccessor, IUserFileService fileService)
        {
            _httpContextAccessor = httpContextAccessor;
            _fileService = fileService;
        }

        public async Task<Unit> Handle(UploadAvatarRequest request, CancellationToken cancellationToken)
        {
            var Id = this._httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var extension = request.ContentType switch
            {
                "image/png" => "png",
                "image/jpeg" => "jpg",
                _ => throw new UnsupportedContentTypeException("Only JPEG and PNG format are supported.")
            };

            await this._fileService.CreateAsync($"{Id}.{extension}", request.ImageStream);

            return await Unit.Task;
        }
    }
}
