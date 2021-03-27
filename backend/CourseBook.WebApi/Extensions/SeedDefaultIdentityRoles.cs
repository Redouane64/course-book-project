namespace CourseBook.WebApi.Extensions
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;
    using Identity.Models;

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
                    var student = AccountType.Student.ToString();
                    if ((await roleManager.FindByNameAsync(student)) is null)
                    {
                        var result = await roleManager.CreateAsync(new IdentityRole(student));
                        if (result.Errors.Any())
                        {
                            throw new Exception($"Failed to create `Student` role: {result.Errors.First().Description}");
                        }

                        logger.LogInformation("Created `Student` role successfully.");
                    }

                    // seed Teacher role:
                    var teacher = AccountType.Teacher.ToString();
                    if ((await roleManager.FindByNameAsync(teacher)) is null)
                    {
                        var result = await roleManager.CreateAsync(new IdentityRole(teacher));
                        if (result.Errors.Any())
                        {
                            throw new Exception($"Failed to create `Teacher` role: {result.Errors.First().Description}");
                        }

                        logger.LogInformation("Created `Teacher` role successfully.");
                    }

                    // seed Admin role:
                    var admin = AccountType.StudentTeacher.ToString();
                    if ((await roleManager.FindByNameAsync(admin)) is null)
                    {
                        var result = await roleManager.CreateAsync(new IdentityRole(admin));
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
