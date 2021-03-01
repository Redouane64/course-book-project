namespace CourseBook.WebApi.Faculties.Data
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class FacultyEntityConfiguration : IEntityTypeConfiguration<FacultyEntity>
    {
        public void Configure(EntityTypeBuilder<FacultyEntity> builder)
        {
            builder.ToTable("faculties");

            builder.HasKey(e => e.Id);

            builder.HasMany(e => e.Directions)
                .WithOne(e => e.Faculty)
                .HasForeignKey(e => e.Faculty)
                .HasConstraintName("faculty");

            builder.Property(e => e.Name)
                .HasColumnName("name")
                .IsRequired();
        }
    }
}
