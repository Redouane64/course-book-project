namespace CourseBook.WebApi.Faculties.Data
{
    using System;
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
                .WithOne(e => e.Faculty);

            builder.Property(e => e.Name)
                .IsRequired();

            builder.HasData(
                new FacultyEntity
                {
                    Id = Guid.Parse("6b3957c3-d16e-4620-8d2c-b26239a7a2a8"),
                    Name = "Institute of Arts and Culture"
                },
                new FacultyEntity
                {
                    Id = Guid.Parse("e05d5966-b197-4bd1-92d4-800f66b352fe"),
                    Name = "Faculty of Physics"
                },
                new FacultyEntity
                {
                    Id = Guid.Parse("b0d09040-c5ea-492d-936f-488b9f3115a2"),
                    Name = "Faculty of Radiophysics"
                },
                new FacultyEntity
                {
                    Id = Guid.Parse("4a823069-9673-403c-8ea0-59b225e5491c"),
                    Name = "Faculty of Chemistry"
                }
            );
        }
    }
}
