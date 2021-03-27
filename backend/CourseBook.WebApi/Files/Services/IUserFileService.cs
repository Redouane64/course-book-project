namespace CourseBook.WebApi.Files.Services
{
    using System.IO;
    using System.Threading.Tasks;

    public interface IUserFileService
    {
        Task<(string contentType, FileStream contents)> GetAsync(string Id);
        Task<string> CreateAsync(string filename, Stream contents);
        Task DeleteAsync(string filename);
    }
}
