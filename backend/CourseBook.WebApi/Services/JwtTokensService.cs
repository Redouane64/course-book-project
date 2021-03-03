namespace CourseBook.WebApi.Services
{
    using System;
    using System.Collections.Generic;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Text;
    using System.Threading.Tasks;

    using Infrastructure;

    using Microsoft.Extensions.Options;
    using Microsoft.IdentityModel.Tokens;

    public sealed class JwtTokensService : ITokensService
    {
        private readonly JwtTokenParameters _jwtTokenOptions;

        public JwtTokensService(IOptions<JwtTokenParameters> jwtTokenOptions)
        {
            _jwtTokenOptions = jwtTokenOptions.Value;
        }

        public Task<string> GenerateToken(IEnumerable<Claim> claims)
        {
            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this._jwtTokenOptions.Secret));
            SigningCredentials signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            JwtSecurityToken token = new JwtSecurityToken(
                issuer: this._jwtTokenOptions.Issuer,
                audience: this._jwtTokenOptions.Audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(this._jwtTokenOptions.LifeTime),
                signingCredentials: signingCredentials
            );

            return Task.FromResult(new JwtSecurityTokenHandler().WriteToken(token));
        }

    }
}
