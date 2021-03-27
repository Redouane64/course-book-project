namespace CourseBook.WebApi.Identity.Services
{
    using System;
    using System.Collections.Generic;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Text;
    using System.Threading.Tasks;
    using Infrastructure;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.Options;
    using Microsoft.IdentityModel.Tokens;
    using Profiles.Entities;

    public sealed class JwtTokensService : ITokensService
    {
        private readonly JwtRefreshTokenProvider _jwtRefreshTokenProvider;
        private readonly UserManager<UserEntity> _userManager;
        private readonly JwtTokenParameters _jwtTokenOptions;

        public JwtTokensService(
            IOptions<JwtTokenParameters> jwtTokenOptions,
            JwtRefreshTokenProvider jwtRefreshTokenProvider,
            UserManager<UserEntity> userManager
            )
        {
            _jwtRefreshTokenProvider = jwtRefreshTokenProvider;
            _userManager = userManager;
            _jwtTokenOptions = jwtTokenOptions.Value;
        }

        public async Task<(string Token, string RefreshToken)> GenerateToken(IEnumerable<Claim> claims, UserEntity user)
        {
            if (claims == null)
            {
                throw new ArgumentNullException(nameof(claims));
            }

            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this._jwtTokenOptions.Secret));
            SigningCredentials signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            JwtSecurityToken token = new JwtSecurityToken(
                issuer: this._jwtTokenOptions.Issuer,
                audience: this._jwtTokenOptions.Audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(this._jwtTokenOptions.LifeTime),
                signingCredentials: signingCredentials
            );

            var refreshToken = await this._jwtRefreshTokenProvider.GenerateAsync(JwtRefreshTokenProvider.Purpose, _userManager, user);

            var stringifiedToken = new JwtSecurityTokenHandler().WriteToken(token);

            return (Token: stringifiedToken, RefreshToken: refreshToken);
        }

        public async Task<(string Token, string RefreshToken)> RefreshToken(string refreshToken, string userId)
        {
            if (refreshToken == null)
            {
                throw new ArgumentNullException(nameof(refreshToken));
            }

            if (userId == null)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            var user = await this._userManager.FindByIdAsync(userId);

            var isValid = await this._jwtRefreshTokenProvider.ValidateAsync(JwtRefreshTokenProvider.Purpose, refreshToken, _userManager, user);

            if (!isValid)
            {
                throw new Exception("Invalid refresh token.");
            }

            var roles = await this._userManager.GetRolesAsync(user);

            var claims = new Claim[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Role, roles[0])
            };

            return await this.GenerateToken(claims, user);
        }

    }
}
