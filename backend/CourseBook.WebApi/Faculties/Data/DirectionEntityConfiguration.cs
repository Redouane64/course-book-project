namespace CourseBook.WebApi.Faculties.Data
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class DirectionEntityConfiguration : IEntityTypeConfiguration<DirectionEntity>
    {
        public void Configure(EntityTypeBuilder<DirectionEntity> builder)
        {
            builder.ToTable("directions");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.HasMany(e => e.Groups)
                .WithOne(e => e.Direction)
                .HasForeignKey("direction_id");

        }
    }
}
