namespace CourseBook.WebApi
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.Json.Serialization;
    using CourseBook.WebApi.Admin.Services;
    using CourseBook.WebApi.Common.Entities;
    using CourseBook.WebApi.Directions.Entities;
    using CourseBook.WebApi.Directions.ViewModels;
    using CourseBook.WebApi.Disciplines.Entities;
    using CourseBook.WebApi.Disciplines.Repositories;
    using CourseBook.WebApi.Disciplines.ViewModels;
    using CourseBook.WebApi.Faculties.Entities;
    using CourseBook.WebApi.Faculties.Repositories;
    using CourseBook.WebApi.Faculties.ViewModels;
    using CourseBook.WebApi.Files.Services;
    using CourseBook.WebApi.Groups.Entities;
    using CourseBook.WebApi.Groups.ViewModels;
    using CourseBook.WebApi.Profiles.Entities;
    using CourseBook.WebApi.Profiles.Mappings;
    using CourseBook.WebApi.Profiles.Services;
    using CourseBook.WebApi.Profiles.ViewModels;

    using Data;

    using Identity.Services;

    using Infrastructure;

    using MediatR;

    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc.Infrastructure;
    using Microsoft.AspNetCore.Mvc.Routing;
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
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Description = "Bearer Token",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement() {
                    {
                        new OpenApiSecurityScheme() {
                            Reference = new OpenApiReference() {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header
                        }, new List<string>()
                    }
                });
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
            services.AddScoped<ITeachersRepository, TeachersRepository>();
            services.AddScoped<IAdminService, AdminService>();

            services.AddAutoMapper(options =>
            {
                options.CreateMap<FacultyEntity, FacultyViewModel>();
                options.CreateMap<DirectionEntity, DirectionViewModel>();
                options.CreateMap<GroupEntity, GroupViewModel>();
                options.CreateMap<DisciplineEntity, DisciplineViewModel>();
                options.CreateMap<UserEntity, UserViewModel>();

                options.CreateMap<GroupDisciplineEntity, TeacherDisciplineViewModel>();

                options.CreateMap<FacultyEntity, FacultyDetailsViewModel>();

                /* */
                options.CreateMap<DirectionDisciplineEntity, DirectionViewModel>()
                        .ForMember(d => d.Id, mapper => mapper.MapFrom(s => s.DisciplineId))
                        .ForMember(d => d.Name, mapper => mapper.MapFrom(s => s.Discipline.Name));

                options.CreateMap<GroupDisciplineEntity, GroupViewModel>()
                        .ForMember(d => d.Id, mapper => mapper.MapFrom(s => s.GroupId))
                        .ForMember(d => d.Name, mapper => mapper.MapFrom(s => s.Group.Name));

                options.CreateMap<DisciplineEntity, DisciplineDetailsViewModel>()
                        .ForMember(d => d.Teachers,
                            mapper => mapper.MapFrom(s => s.Groups.Select(g => g.Teacher))
                        );
                /* */

                options.CreateMap<DirectionDisciplineEntity, DisciplineViewModel>()
                        .ForMember(d => d.Id, mapper => mapper.MapFrom(s => s.DisciplineId))
                        .ForMember(d => d.Name, mapper => mapper.MapFrom(s => s.Discipline.Name));

                options.CreateMap<DirectionEntity, DirectionDetailsViewModel>()
                        .ForMember(x => x.Disciplines, mapper => mapper.MapFrom(s => s.Disciplines))
                        .ForMember(x => x.Groups, mapper => mapper.MapFrom(s => s.Groups))
                        .ForMember(x => x.Faculty, mapper => mapper.MapFrom(s => s.Faculty.Name));

                options.CreateMap<GroupEntity, GroupDetailsViewModel>();

                options.CreateMap<UserEntity, ProfileViewModel>()
                        .ForMember(d => d.Name, o => o.MapFrom(s => s.FullName))
                        .ForMember(d => d.Avatar, o => o.MapFrom<AvatarUrlResolver, string>(s => s.Id));
            }, typeof(Startup).Assembly);


            services.AddAuthorization();

            services.AddMediatR(typeof(Startup));

            services.AddHttpContextAccessor();
            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
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
