using System;
using System.Linq;
using System.Threading.Tasks;
using CourseBook.WebApi.Profiles.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CourseBook.WebApi.Extensions
{
    public static partial class HostExtensions
    {
        public static async Task<IHost> SeedDefaultIdentityRoles(this IHost webHost)
        {
            using (var scope = webHost.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var logger = services.GetRequiredService<ILogger<Program>>();

                try
                {
                    var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
                    // seed Student role:
                    if ((await roleManager.FindByNameAsync(Roles.StudentRoleName)) is null)
                    {
                        var result = await roleManager.CreateAsync(new IdentityRole(Roles.StudentRoleName));
                        if (result.Errors.Any())
                        {
                            throw new Exception($"Failed to create `Student` role: {result.Errors.First().Description}");
                        }

                        logger.LogInformation("Created `Student` role successfully.");
                    }

                    // seed Teacher role:
                    if ((await roleManager.FindByNameAsync(Roles.TeacherRoleName)) is null)
                    {
                        var result = await roleManager.CreateAsync(new IdentityRole(Roles.TeacherRoleName));
                        if (result.Errors.Any())
                        {
                            throw new Exception($"Failed to create `Teacher` role: {result.Errors.First().Description}");
                        }

                        logger.LogInformation("Created `Teacher` role successfully.");
                    }

                    // seed Admin role:
                    if ((await roleManager.FindByNameAsync(Roles.AdministratorRoleName)) is null)
                    {
                        var result = await roleManager.CreateAsync(new IdentityRole(Roles.AdministratorRoleName));
                        if (result.Errors.Any())
                        {
                            throw new Exception($"Failed to create `Administrator` role: {result.Errors.First().Description}");
                        }

                        logger.LogInformation("Created `Administrator` role successfully.");
                    }

                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "An error occurred while adding default identity roles to database.");
                }
            }
            return webHost;
        }
    }
}
