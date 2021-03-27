namespace CourseBook.WebApi.Identity.Services
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.DataProtection;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;
    using Profiles.Entities;

    public sealed class JwtRefreshTokenProviderOptions : DataProtectionTokenProviderOptions
    { }

    public sealed class JwtRefreshTokenProvider : DataProtectorTokenProvider<UserEntity>
    {
        public const string ProviderName = nameof(JwtRefreshTokenProvider);
        public const string Purpose = "RefershJwtAccessToken";

        public JwtRefreshTokenProvider(
            IDataProtectionProvider dataProtectionProvider,
            IOptions<JwtRefreshTokenProviderOptions> options,
            ILogger<DataProtectorTokenProvider<UserEntity>> logger
        ) : base(dataProtectionProvider, options, logger)
        {
        }

        public override Task<bool> CanGenerateTwoFactorTokenAsync(UserManager<UserEntity> manager, UserEntity user)
        {
            return Task.FromResult(false);
        }

    }
}
