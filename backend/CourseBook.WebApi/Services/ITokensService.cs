namespace CourseBook.WebApi.Services
{
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;

    public interface ITokensService
    {
        Task<string> GenerateToken(IEnumerable<Claim> claims);
    }
}
