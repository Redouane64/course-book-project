namespace CourseBook.WebApi.Services
{
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Profiles.Entities;

    public interface ITokensService
    {
        Task<(string Token, string RefreshToken)> GenerateToken(IEnumerable<Claim> claims, UserEntity user);

        Task<(string Token, string RefreshToken)> RefreshToken(string refreshToken, UserEntity user);

        Task<(string Token, string RefreshToken)> RefreshToken(string refreshToken, string Id);
    }
}
