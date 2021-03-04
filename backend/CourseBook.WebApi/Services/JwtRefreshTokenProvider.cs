namespace CourseBook.WebApi.Services
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.DataProtection;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;

    public sealed class JwtRefreshTokenProviderOptions : DataProtectionTokenProviderOptions
    { }

    public sealed class JwtRefreshTokenProvider : DataProtectorTokenProvider<IdentityUser>
    {
        public const string ProviderName = nameof(JwtRefreshTokenProvider);
        public const string Purpose = "RefershJwtAccessToken";

        public JwtRefreshTokenProvider(
            IDataProtectionProvider dataProtectionProvider,
            IOptions<JwtRefreshTokenProviderOptions> options,
            ILogger<DataProtectorTokenProvider<IdentityUser>> logger
        ) :  base(dataProtectionProvider, options, logger)
        {
        }

        public override Task<bool> CanGenerateTwoFactorTokenAsync(UserManager<IdentityUser> manager, IdentityUser user)
        {
            return Task.FromResult(false);
        }

    }
}
