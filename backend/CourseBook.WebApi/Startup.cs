namespace CourseBook.WebApi
{
    using System;
    using System.Text;
    using System.Text.Json.Serialization;

    using CourseBook.WebApi.Directions.Entities;
    using CourseBook.WebApi.Directions.ViewModels;
    using CourseBook.WebApi.Disciplines.Entities;
    using CourseBook.WebApi.Disciplines.ViewModels;
    using CourseBook.WebApi.Faculties.Entities;
    using CourseBook.WebApi.Faculties.Repositories;
    using CourseBook.WebApi.Faculties.ViewModels;
    using CourseBook.WebApi.Files.Services;
    using CourseBook.WebApi.Groups.Entities;
    using CourseBook.WebApi.Groups.ViewModels;
    using CourseBook.WebApi.Profiles.Entities;
    using CourseBook.WebApi.Profiles.Services;

    using Data;

    using Identity.Services;

    using Infrastructure;

    using MediatR;

    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.IdentityModel.Tokens;
    using Microsoft.OpenApi.Models;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
            }).AddMvcOptions(options => options.Filters.Add<JsonExceptionFilter>());

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Course Book API", Version = "v1" });
            });

            services.AddDbContext<DataContext>(config =>
            {
                config.UseSqlite(Configuration.GetConnectionString("localhost"));
                config.EnableDetailedErrors();
                config.EnableSensitiveDataLogging();
            });


            services.AddIdentityCore<UserEntity>(options =>
                {
                    options.User.RequireUniqueEmail = true;
                    options.SignIn.RequireConfirmedPhoneNumber = false;
                    options.SignIn.RequireConfirmedAccount = false;
                    options.SignIn.RequireConfirmedEmail = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = false;
                })
                .AddRoles<IdentityRole>()
                .AddUserManager<UserManager<UserEntity>>()
                .AddRoleManager<RoleManager<IdentityRole>>()
                .AddEntityFrameworkStores<DataContext>()
                .AddTokenProvider<JwtRefreshTokenProvider>(JwtRefreshTokenProvider.ProviderName);

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                // Get token parameters from configuration.
                var jwtOptions = Configuration.GetSection(nameof(JwtTokenParameters)).Get<JwtTokenParameters>();
                options.RequireHttpsMetadata = false; // TODO: enable on production environment
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateAudience = true,
                    ValidateIssuer = true,
                    ValidateLifetime = true,

                    ClockSkew = TimeSpan.Zero,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions.Secret)),
                    ValidAudience = jwtOptions.Audience,
                    ValidIssuer = jwtOptions.Issuer,
                };
            });

            services.Configure<JwtTokenParameters>(Configuration.GetSection(nameof(JwtTokenParameters)));

            services.Configure<JwtRefreshTokenProviderOptions>(options =>
            {
                options.TokenLifespan = TimeSpan.FromMinutes(Configuration.GetValue<double>("JwtTokenParameters:LifeTime") * 2);
                options.Name = JwtRefreshTokenProvider.ProviderName;
            });

            services.AddScoped<ITokensService, JwtTokensService>();
            services.AddScoped<IProfileService, ProfilesService>();
            services.AddScoped<IUserFileService, FilesService>();

            services.AddScoped<IFacultiesRepository, FacultiesRepository>();

            services.AddAutoMapper(options =>
            {
                options.CreateMap<FacultyEntity, FacultyViewModel>();
                options.CreateMap<DirectionEntity, DirectionViewModel>();
                options.CreateMap<GroupEntity, GroupViewModel>();
                options.CreateMap<DisciplineEntity, DisciplineViewModel>();

                options.CreateMap<FacultyEntity, FacultyDetailsViewModel>();

                options.CreateMap<DirectionEntity, DirectionDetailsViewModel>()
                        // TODO: fix
                        .ForMember(x => x.Disciplines, mapper => mapper.Ignore())
                        .ForMember(x => x.Groups, mapper => mapper.Ignore());

                options.CreateMap<GroupEntity, GroupDetailsViewModel>();
                options.CreateMap<DisciplineEntity, DisciplineDetailsViewModel>();
            });


            services.AddAuthorization();

            services.AddMediatR(typeof(Startup));

            services.AddHttpContextAccessor();

            services.AddCors();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CourseBook.WebApi v1"));
            }


            app.UseRouting();

            app.UseCors(options =>
            {
                options.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
            });

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
