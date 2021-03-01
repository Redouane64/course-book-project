namespace CourseBook.WebApi.Faculties.Data
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class GroupDisciplineEntityConfiguration /* : IEntityTypeConfiguration<GroupDisciplineEntity> */
    {
        public void Configure(EntityTypeBuilder<GroupDisciplineEntity> builder)
        {
            builder.ToTable("groups_disciplines");

            builder.HasKey(e => new {e.Group, e.Discipline});

            /*
            builder.HasOne(e => e.Group)
                .WithMany(e => e.Disciplines)
                .HasForeignKey(e => e.GroupId);

            builder.HasOne(e => e.Discipline)
                .WithMany(e => e.Groups)
                .HasForeignKey(e => e.DisciplineId);
            */

            builder.Property(e => e.Year)
                .IsRequired();

            builder.Property(e => e.Semester)
                .IsRequired();

        }
    }
}
