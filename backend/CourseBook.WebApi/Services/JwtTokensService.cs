namespace CourseBook.WebApi.Services
{
    using System;
    using System.Collections.Generic;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Text;
    using System.Threading.Tasks;

    using CourseBook.WebApi.Exceptions;
    using CourseBook.WebApi.Profiles.Constants;
    using CourseBook.WebApi.Profiles.Entities;
    using Infrastructure;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.Options;
    using Microsoft.IdentityModel.Tokens;

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

        public async Task<(string Token, string RefreshToken)> RefreshToken(string refreshToken, UserEntity user)
        {
            if (refreshToken == null)
            {
                throw new ArgumentNullException(nameof(refreshToken));
            }

            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            var isValid = await this._jwtRefreshTokenProvider.ValidateAsync(JwtRefreshTokenProvider.Purpose, refreshToken, _userManager, user);

            if (!isValid)
            {
                throw new Exception("Invalid refresh token.");
            }

            // TODO: refactor this

            var roles = await this._userManager.GetRolesAsync(user);

            var claims = new List<Claim>(new Claim[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Role, Roles.StudentRoleName),
            });

            if(roles.Contains(Roles.TeacherRoleName)) {
                claims.Add(new Claim(ClaimTypes.Role, Roles.TeacherRoleName));
            }

            return await this.GenerateToken(claims, user);
        }

        public async Task<(string Token, string RefreshToken)> RefreshToken(string refreshToken, string Id)
        {
            if (refreshToken == null)
            {
                throw new ArgumentNullException(nameof(refreshToken));
            }

            if (Id == null)
            {
                throw new ArgumentNullException(nameof(Id));
            }

            var user = await this._userManager.FindByIdAsync(Id);

            if (user is null)
            {
                throw new InvalidOperationException("Incorrect or unauthorized user.");
            }

            var isValid = await this._jwtRefreshTokenProvider.ValidateAsync(JwtRefreshTokenProvider.Purpose, refreshToken, _userManager, user);

            if (!isValid)
            {
                throw new InvalidRefreshTokenException("Invalid refresh token.");
            }

            // TODO: refactor this

            var roles = await this._userManager.GetRolesAsync(user);

            var claims = new List<Claim>(new Claim[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Role, Roles.StudentRoleName),
            });

            if(roles.Contains(Roles.TeacherRoleName)) {
                claims.Add(new Claim(ClaimTypes.Role, Roles.TeacherRoleName));
            }

            return await this.GenerateToken(claims, user);
        }

    }
}
