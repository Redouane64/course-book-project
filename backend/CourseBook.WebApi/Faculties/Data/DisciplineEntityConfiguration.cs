namespace CourseBook.WebApi.Faculties.Data
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class DisciplineEntityConfiguration : IEntityTypeConfiguration<DisciplineEntity>
    {
        public void Configure(EntityTypeBuilder<DisciplineEntity> builder)
        {
            builder.ToTable("disciplines");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.Literatures)
                .HasMaxLength(4096);

        }
    }
}
