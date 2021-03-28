namespace CourseBook.WebApi.Common.Entities
{

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class GroupDisciplineEntityConfiguration : IEntityTypeConfiguration<GroupDisciplineEntity>
    {
        public void Configure(EntityTypeBuilder<GroupDisciplineEntity> builder)
        {
            builder.ToTable("groups_disciplines");

            builder.HasKey(e => new { e.GroupId, e.DisciplineId });

            builder.HasOne(e => e.Group)
                .WithMany(e => e.Disciplines);

            builder.HasOne(e => e.Discipline)
                .WithMany(e => e.Groups);

            builder.Property(e => e.Year)
                .IsRequired();

            builder.Property(e => e.Semester)
                .IsRequired();

        }
    }
}
