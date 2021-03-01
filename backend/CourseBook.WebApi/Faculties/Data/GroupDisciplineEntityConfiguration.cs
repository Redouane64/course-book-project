namespace CourseBook.WebApi.Faculties.Data
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class GroupDisciplineEntityConfiguration : IEntityTypeConfiguration<GroupDisciplineEntity>
    {
        public void Configure(EntityTypeBuilder<GroupDisciplineEntity> builder)
        {
            builder.ToTable("groups_disciplines");

            builder.HasKey(e => new {e.Group, e.Discipline});

            builder.HasOne(e => e.Group)
                .WithMany(e => e.Disciplines)
                .HasForeignKey("group_id");

            builder.HasOne(e => e.Discipline)
                .WithMany(e => e.Groups)
                .HasForeignKey("discipline_id");

            builder.Property(e => e.Year)
                .IsRequired();

            builder.Property(e => e.Semester)
                .IsRequired();
        }
    }
}
