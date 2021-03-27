namespace CourseBook.WebApi.Data
{
    using CourseBook.WebApi.Directions.Entities;
    using CourseBook.WebApi.Disciplines.Entities;
    using CourseBook.WebApi.Groups.Entities;

    using Faculties.Entities;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using Profiles.Entities;

    public class DataContext : IdentityDbContext<UserEntity>
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            // This is important for Identity setup
            base.OnModelCreating(modelBuilder);

            // Ignore unnecessary auto-generated identity tables
            // Keep only necessary tables and columns for this project.
            modelBuilder
                .Ignore<IdentityUserLogin<string>>();

            modelBuilder.Entity<UserEntity>()
                .ToTable("users")
                .Ignore(e => e.AccessFailedCount)
                .Ignore(e => e.ConcurrencyStamp)
                .Ignore(e => e.EmailConfirmed)
                .Ignore(e => e.LockoutEnabled)
                .Ignore(e => e.LockoutEnd)
                .Ignore(e => e.PhoneNumberConfirmed)
                .Ignore(e => e.TwoFactorEnabled)
                .HasOne(e => e.Group)
                .WithMany(e => e.Students)
                .IsRequired(required: false)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<IdentityRole>()
                .ToTable("roles");

            modelBuilder.Entity<IdentityUserRole<string>>()
                .ToTable("user_roles");

            modelBuilder.Entity<IdentityRoleClaim<string>>()
                .ToTable("role_claims");

            modelBuilder.Entity<IdentityUserClaim<string>>()
                .ToTable("user_claims");

            modelBuilder.Entity<IdentityUserToken<string>>()
                .ToTable("user_tokens");
        }

        public DbSet<FacultyEntity> Faculties { get; set; }

        public DbSet<DirectionEntity> Directions { get; set; }

        public DbSet<DisciplineEntity> Disciplines { get; set; }

        public DbSet<GroupEntity> Groups { get; set; }

        public DbSet<UserEntity> Profiles { get; set; }
    }
}
