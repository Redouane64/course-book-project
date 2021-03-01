namespace CourseBook.WebApi.Faculties.Data
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class DirectionDisciplineEntityConfiguration /* : IEntityTypeConfiguration<DirectionDisciplineEntity> */
    {
        public void Configure(EntityTypeBuilder<DirectionDisciplineEntity> builder)
        {
            builder.ToTable("directions_disciplines");

            builder.HasKey(e => new {e.Direction, e.Discipline});

            /*
            builder.HasOne(e => e.Direction)
                .WithMany(e => e.Disciplines)
                .HasForeignKey(e => e.DirectionId);

            builder.HasOne(e => e.Discipline)
                .WithMany(e => e.Directions)
                .HasForeignKey(e => e.DisciplineId);
            */

        }
    }
}
