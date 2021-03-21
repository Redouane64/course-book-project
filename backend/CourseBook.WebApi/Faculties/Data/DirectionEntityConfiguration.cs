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

            builder.HasData(
               //Institute of Arts and Culture
               new DirectionEntity
               {
                   Name = "Culturology"
               },
               new DirectionEntity
               {
                   Name = "Pedagogy"
               },
               new DirectionEntity
               {
                   Name = "Design"
               },
               new DirectionEntity
               {
                   Name = "Library and Information Activities"
               },

               //Faculty of Physics
               new DirectionEntity
               {
                   Name = "Astronomy and Space Geodesy"
               },
               new DirectionEntity
               {
                   Name = "Quantum Field Theory"
               },
               new DirectionEntity
               {
                   Name = "General and Experimental Physics"
               },
               new DirectionEntity
               {
                   Name = "Optics and Spectroscopy"
               },

               //Faculty of Radiophysics
               new DirectionEntity
               {
                   Name = "Radiophysics"
               },
               new DirectionEntity
               {
                   Name = "Radio electronics"
               },
               new DirectionEntity
               {
                   Name = "Semiconductor Electronics"
               },
               new DirectionEntity
               {
                   Name = "Optoelectronic systems and remote sensing"
               },

               //Faculty of Chemistry
               new DirectionEntity
               {
                   Name = "Analytical Chemistry"
               },
               new DirectionEntity
               {
                   Name = "Macromolecular compounds"
               },
               new DirectionEntity
               {
                   Name = "Petrochemistry"
               },
               new DirectionEntity
               {
                   Name = "Physical chemistry"
               }

           );

        }
    }
}
