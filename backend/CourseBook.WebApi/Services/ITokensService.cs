namespace CourseBook.WebApi.Services
{
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;

    public interface ITokensService
    {
        Task<(string Token, string RefreshToken)> GenerateToken(IEnumerable<Claim> claims, IdentityUser user);

        Task<(string Token, string RefreshToken)> RefreshToken(string refreshToken, IdentityUser user);

        Task<(string Token, string RefreshToken)> RefreshToken(string refreshToken, string userId);

        Task Invalidate(string userId);
    }
}
