namespace CourseBook.WebApi.Common.Entities
{
    using System;
    using Entities;
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

            builder.HasData(
                //group 931910
                new GroupDisciplineEntity
                {
                    GroupId = Guid.Parse("bbf4d1b7-5dd6-4737-b78c-e865cbe4adc0"),
                    DisciplineId = Guid.Parse("986d7006-65c4-4246-b99a-2d390e1ae4f7"),
                    Year = DateTime.Now.Year,
                    Semester = 0
                },
                new GroupDisciplineEntity
                {
                    GroupId = Guid.Parse("bbf4d1b7-5dd6-4737-b78c-e865cbe4adc0"),
                    DisciplineId = Guid.Parse("b0a130ae-8d09-4cec-8814-24c811028771"),
                    Year = DateTime.Now.Year + 1,
                    Semester = 0
                },
                new GroupDisciplineEntity
                {
                    GroupId = Guid.Parse("bbf4d1b7-5dd6-4737-b78c-e865cbe4adc0"),
                    DisciplineId = Guid.Parse("fee99c99-831c-4f29-acd0-5eb5ad0ca7e2"),
                    Year = DateTime.Now.Year,
                    Semester = 1
                },
                new GroupDisciplineEntity
                {
                    GroupId = Guid.Parse("bbf4d1b7-5dd6-4737-b78c-e865cbe4adc0"),
                    DisciplineId = Guid.Parse("d12b6e66-e758-48ca-af31-102aa991bdc0"),
                    Year = DateTime.Now.Year + 1,
                    Semester = 1
                },

                //group93180
                new GroupDisciplineEntity
                {
                    GroupId = Guid.Parse("b719e956-a46c-41b5-93bd-81bd4e12c7ed"),
                    DisciplineId = Guid.Parse("0142a5ca-e2ab-423a-a03f-d2c3092a0339"),
                    Year = DateTime.Now.Year,
                    Semester = 0
                },
                new GroupDisciplineEntity
                {
                    GroupId = Guid.Parse("b719e956-a46c-41b5-93bd-81bd4e12c7ed"),
                    DisciplineId = Guid.Parse("d4e27800-46bd-48d4-b320-92380548f689"),
                    Year = DateTime.Now.Year + 1,
                    Semester = 1
                }
            );

        }
    }
}
