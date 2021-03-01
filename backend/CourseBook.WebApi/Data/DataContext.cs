namespace CourseBook.WebApi.Data
{
    using Faculties.Data;
    using Faculties.Entities;
    using Microsoft.EntityFrameworkCore;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<FacultyEntity> Faculties { get; set; }

        public DbSet<DirectionEntity> Directions { get; set; }

        public DbSet<DisciplineEntity> Disciplines { get; set; }

        public DbSet<GroupEntity> Groups { get; set; }
    }
}
