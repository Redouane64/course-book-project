namespace CourseBook.WebApi.Services
{
    using System.IO;
    using System.Threading.Tasks;

    public class FilesService : IUserFileService
    {
        public static readonly string UPLOAD_PATH = Path.Combine(Directory.GetCurrentDirectory(), "upload");

        public Task<(string contentType, FileStream contents)> GetAsync(string Id)
        {
            var jpegAvatar = Path.Combine(UPLOAD_PATH, $"{Id}.jpg");
            var pngAvatar = Path.Combine(UPLOAD_PATH, $"{Id}.png");

            if (File.Exists(jpegAvatar))
            {
                return Task.FromResult((contentType: "image/jpeg", contents: File.OpenRead(jpegAvatar)));
            }

            if (File.Exists(pngAvatar))
            {
                return Task.FromResult((contentType: "image/jpeg", contents: File.OpenRead(pngAvatar)));
            }

            return Task.FromResult<(string contentType, FileStream contents)>((contentType: null, contents: null));
        }

        public async Task<string> CreateAsync(string filename, Stream contents)
        {
            Directory.CreateDirectory(UPLOAD_PATH);
            var file = Path.Combine(UPLOAD_PATH, filename);

            if (File.Exists(file))
            {
                File.Delete(file);
            }

            using (var output = File.Create(file))
            {
                await contents.CopyToAsync(output);
            }

            return file;
        }

        public Task DeleteAsync(string filename)
        {
            throw new System.NotImplementedException();
        }
    }
}
