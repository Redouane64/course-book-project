namespace CourseBook.WebApi.Data
{
    using Faculties.Data;
    using Faculties.Entities;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class DataContext : IdentityDbContext<IdentityUser>
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            // This is important for Identity setup
            base.OnModelCreating(modelBuilder);

            // Ignore unecessary auto-generated identity tables
            // Keep only necessary tables and columns for this project.
            modelBuilder
                .Ignore<IdentityUserLogin<string>>()
                .Ignore<IdentityUserToken<string>>();

            modelBuilder.Entity<IdentityUser>()
                .ToTable("users")
                .Ignore(e => e.AccessFailedCount)
                .Ignore(e => e.ConcurrencyStamp)
                .Ignore(e => e.EmailConfirmed)
                .Ignore(e => e.LockoutEnabled)
                .Ignore(e => e.LockoutEnd)
                .Ignore(e => e.PhoneNumber)
                .Ignore(e => e.PhoneNumberConfirmed)
                .Ignore(e => e.TwoFactorEnabled);

            modelBuilder.Entity<IdentityRole>()
                .ToTable("roles");

            modelBuilder.Entity<IdentityUserRole<string>>()
                .ToTable("user_roles");

            modelBuilder.Entity<IdentityRoleClaim<string>>()
                .ToTable("role_claims");

            modelBuilder.Entity<IdentityUserClaim<string>>()
                .ToTable("user_claims");
        }

        public DbSet<FacultyEntity> Faculties { get; set; }

        public DbSet<DirectionEntity> Directions { get; set; }

        public DbSet<DisciplineEntity> Disciplines { get; set; }

        public DbSet<GroupEntity> Groups { get; set; }
    }
}
