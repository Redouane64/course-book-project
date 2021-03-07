namespace CourseBook.WebApi.Services
{
    using System.IO;
    using System.Threading.Tasks;

    public interface IFileService
    {
        Task<string> CreateAsync(string filename, Stream contents);
        Task DeleteAsync(string filename);
    }

    public class FilesService : IFileService
    {
        public static readonly string UPLOAD_PATH = Path.Combine(Directory.GetCurrentDirectory(), "upload");

        public async Task<string> CreateAsync(string filename, Stream contents)
        {
            Directory.CreateDirectory(UPLOAD_PATH);
            var file = Path.Combine(UPLOAD_PATH, filename);

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
