namespace CourseBook.WebApi.Extensions
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using CourseBook.WebApi.Profiles.Entities;

    using Identity.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;

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

        public static async Task<IHost> SeedTeacherUsers(this IHost webHost)
        {
            using (var scope = webHost.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var logger = services.GetRequiredService<ILogger<Program>>();

                try
                {
                    /* teacher seed account */
                    var userManager = services.GetRequiredService<UserManager<UserEntity>>();

                    var user = await userManager.FindByIdAsync("b19d2ff1-efe2-4fd4-a721-3444f2c9888c");

                    await userManager.AddPasswordAsync(user, "john.doe.01");
                    await userManager.SetEmailAsync(user, "john.doe@mail.com");
                    await userManager.SetUserNameAsync(user, "john.doe");
                    await userManager.SetPhoneNumberAsync(user, "+1888999123");

                    user.BirthDay = new DateTime(1993, 10, 23);
                    user.FullName = "John Doe";

                    await userManager.UpdateAsync(user);

                    await userManager.AddToRoleAsync(user, AccountType.Teacher.ToString());

                    /* student seed account */
                    var student = new UserEntity() {
                        Email = "jcosto@example.com",
                        FullName = "Jack Costo",
                        UserName = "jack.costo",
                        BirthDay = new DateTime(1993, 7, 26),
                        PhoneNumber = "+78889991111",
                        GroupId = Guid.Parse("bbf4d1b7-5dd6-4737-b78c-e865cbe4adc0"),
                        AdmissionYear = 2020,
                    };

                    await userManager.CreateAsync(student, "qwerty@1234");
                    await userManager.AddToRoleAsync(student, AccountType.Student.ToString());
                }
                catch(Exception ex) {
                    logger.LogError(ex, "Sonething went wrong when seeding test users.");
                }

            }

            return webHost;
        }
    }
}
