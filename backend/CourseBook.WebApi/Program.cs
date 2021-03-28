namespace CourseBook.WebApi
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Data;
    using CourseBook.WebApi.Extensions;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Hosting;

    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = await CreateHostBuilder(args).Build()
                .MigrateDatabase<DataContext>()
                .SeedDefaultIdentityRoles();

            host = await host.SeedTeacherUsers();

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
