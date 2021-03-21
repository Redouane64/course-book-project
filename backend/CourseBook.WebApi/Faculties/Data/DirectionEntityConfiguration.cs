namespace CourseBook.WebApi.Faculties.Data
{
    using System;
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

            builder.HasData(
               //Institute of Arts and Culture
               new DirectionEntity
               {
                   Id = Guid.Parse("aaa504f9-b3ad-4854-9820-90cdcbd27322"),
                   FacultyId = Guid.Parse("6b3957c3-d16e-4620-8d2c-b26239a7a2a8"),
                   Name = "Culturology"
               },
               new DirectionEntity
               {
                   Id = Guid.Parse("0efe92d1-4959-4cf5-8969-56bce0e8558c"),
                   FacultyId = Guid.Parse("6b3957c3-d16e-4620-8d2c-b26239a7a2a8"),
                   Name = "Pedagogy"
               },
               new DirectionEntity
               {
                   Id = Guid.Parse("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"),
                   FacultyId = Guid.Parse("6b3957c3-d16e-4620-8d2c-b26239a7a2a8"),
                   Name = "Design"
               },
               new DirectionEntity
               {
                   Id = Guid.Parse("fa2a6596-0f78-42c8-8f3f-56430aa50087"),
                   FacultyId = Guid.Parse("6b3957c3-d16e-4620-8d2c-b26239a7a2a8"),
                   Name = "Library and Information Activities"
               },

               //Faculty of Physics
               new DirectionEntity
               {
                   Id = Guid.Parse("fb92cb9d-c54c-4882-8a84-d357392586b7"),
                   FacultyId = Guid.Parse("e05d5966-b197-4bd1-92d4-800f66b352fe"),
                   Name = "Astronomy and Space Geodesy"
               },
               new DirectionEntity
               {
                   Id = Guid.Parse("46c6bba6-91be-4b95-b9c9-812fbdce601e"),
                   FacultyId = Guid.Parse("e05d5966-b197-4bd1-92d4-800f66b352fe"),
                   Name = "Quantum Field Theory"
               },
               new DirectionEntity
               {
                   Id = Guid.Parse("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"),
                   FacultyId = Guid.Parse("e05d5966-b197-4bd1-92d4-800f66b352fe"),
                   Name = "General and Experimental Physics"
               },
               new DirectionEntity
               {
                   Id = Guid.Parse("f1db86a1-2647-44ff-81df-6e4781239dcc"),
                   FacultyId = Guid.Parse("e05d5966-b197-4bd1-92d4-800f66b352fe"),
                   Name = "Optics and Spectroscopy"
               },

               //Faculty of Radiophysics
               new DirectionEntity
               {
                   Id = Guid.Parse("435557fa-35a0-4f35-9efa-7aba31755b46"),
                   FacultyId = Guid.Parse("b0d09040-c5ea-492d-936f-488b9f3115a2"),
                   Name = "Radiophysics"
               },
               new DirectionEntity
               {
                   Id = Guid.Parse("bc4dd321-36ee-4050-905e-b1aa3fa01182"),
                   FacultyId = Guid.Parse("b0d09040-c5ea-492d-936f-488b9f3115a2"),
                   Name = "Radio electronics"
               },
               new DirectionEntity
               {
                   Id = Guid.Parse("ae4d9db2-9358-4a51-9928-888d5338a78e"),
                   FacultyId = Guid.Parse("b0d09040-c5ea-492d-936f-488b9f3115a2"),
                   Name = "Semiconductor Electronics"
               },
               new DirectionEntity
               {
                   Id = Guid.Parse("de2a66b0-56ea-44e3-b202-c1b4754b1721"),
                   FacultyId = Guid.Parse("b0d09040-c5ea-492d-936f-488b9f3115a2"),
                   Name = "Optoelectronic systems and remote sensing"
               },

               //Faculty of Chemistry
               new DirectionEntity
               {
                   Id = Guid.Parse("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"),
                   FacultyId = Guid.Parse("4a823069-9673-403c-8ea0-59b225e5491c"),
                   Name = "Analytical Chemistry"
               },
               new DirectionEntity
               {
                   Id = Guid.Parse("37dd1e11-b958-45ef-ab51-09650b3d43d4"),
                   FacultyId = Guid.Parse("4a823069-9673-403c-8ea0-59b225e5491c"),
                   Name = "Macromolecular compounds"
               },
               new DirectionEntity
               {
                   Id = Guid.Parse("afdfcc0a-ffdd-41e1-ab01-a712574e289a"),
                   FacultyId = Guid.Parse("4a823069-9673-403c-8ea0-59b225e5491c"),
                   Name = "Petrochemistry"
               },
               new DirectionEntity
               {
                   Id = Guid.Parse("70b17a41-5128-4bde-83dd-f727554ea6b0"),
                   FacultyId = Guid.Parse("4a823069-9673-403c-8ea0-59b225e5491c"),
                   Name = "Physical chemistry"
               }

           );

        }
    }
}
