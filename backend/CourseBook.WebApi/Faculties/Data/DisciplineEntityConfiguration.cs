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

            builder.HasData(
               //Culturology
               new DisciplineEntity
               {
                   Name = "Art history"
               },
               new DisciplineEntity
               {
                   Name = "Composition"
               },
               new DisciplineEntity
               {
                   Name = "Sociology of media"
               },
               new DisciplineEntity
               {
                   Name = "History of material culture"
               },

               //Pedagogy
               new DisciplineEntity
               {
                   Name = "Information law	"
               },
               new DisciplineEntity
               {
                   Name = "Copyright"
               },
               new DisciplineEntity
               {
                   Name = "Quantitative methods in scientific research"
               },
               new DisciplineEntity
               {
                   Name = "Strategic management in the library"
               },

               //Design
               new DisciplineEntity
               {
                   Name = "Foreign language"
               },
               new DisciplineEntity
               {
                   Name = "Academic writing"
               },
               new DisciplineEntity
               {
                   Name = "Museology, conservation and restoration of historical and cultural objects"
               },


               //Astronomy and Space Geodesy
               new DisciplineEntity
               {
                   Name = "Modern problems of physics of the microworld and cosmology"
               },
               new DisciplineEntity
               {
                   Name = "Foreign language in the field of professional communication"
               },
               new DisciplineEntity
               {
                   Name = "Waves and layers in plasma"
               },
               new DisciplineEntity
               {
                   Name = "Plasma physics problems"
               },


               //Quantum Field Theory
               new DisciplineEntity
               {
                   Name = "Military training"
               },
               new DisciplineEntity
               {
                   Name = "Information systems design"
               },
               new DisciplineEntity
               {
                   Name = "Laboratories specializing in satellite dynamics"
               },
               new DisciplineEntity
               {
                   Name = "Global Positioning Technologies"
               },

               //General and Experimental Physics
               new DisciplineEntity
               {
                   Name = "Modern problems of physics of the microworld and cosmology"
               },
               new DisciplineEntity
               {
                   Name = "Physics of intermolecular interactions"
               },
               new DisciplineEntity
               {
                   Name = "The theory of elementary particles"
               },
               new DisciplineEntity
               {
                   Name = "Topical issues of theory and teaching methods in physics"
               },

               //Optics and Spectroscopy
               new DisciplineEntity
               {
                   Name = "Fundamentals of Atomic and Molecular Spectroscopy"
               },
               new DisciplineEntity
               {
                   Name = "Foreign language in the field of professional communication"
               },
               new DisciplineEntity
               {
                   Name = "Analysis of complex biophysical signals"
               },
               new DisciplineEntity
               {
                   Name = "Biomedical laser technology"
               },


               //Radiophysics
               new DisciplineEntity
               {
                   Name = "Linear Algebra"
               },
               new DisciplineEntity
               {
                   Name = "Physics"
               },
               new DisciplineEntity
               {
                   Name = "Mathematical analysis"
               },
               new DisciplineEntity
               {
                   Name = "Foreign language"
               },

               //Radio electronics
               new DisciplineEntity
               {
                   Name = "Microprocessors"
               },
               new DisciplineEntity
               {
                   Name = "Electronics"
               },
               new DisciplineEntity
               {
                   Name = "Optics Basics"
               },
               new DisciplineEntity
               {
                   Name = "Military training"
               },

               //Semiconductor Electronics
               new DisciplineEntity
               {
                   Name = "	Mobile communication systems"
               },
               new DisciplineEntity
               {
                   Name = "	Metrology"
               },
               new DisciplineEntity
               {
                   Name = "Digital spectral analysis of signals and fields"
               },
               new DisciplineEntity
               {
                   Name = "	Standardization and certification"
               },

               //Optoelectronic systems and remote sensing
               new DisciplineEntity
               {
                   Name = "Waveguide Photonics"
               },
               new DisciplineEntity
               {
                   Name = "Atomic and Nuclear Physics"
               },
               new DisciplineEntity
               {
                   Name = "Elective disciplines in physical culture and sports"
               },
               new DisciplineEntity
               {
                   Name = "Study Practice"
               },

               //Analytical Chemistry
               new DisciplineEntity
               {
                   Name = "Analytical chemistry"
               },
               new DisciplineEntity
               {
                   Name = "Foreign language"
               },
               new DisciplineEntity
               {
                   Name = "Quantum chemistry"
               },

               //Macromolecular compounds
               new DisciplineEntity
               {
                   Name = "Pedagogy"
               },
               new DisciplineEntity
               {
                   Name = "Polymer solutions"
               },
               new DisciplineEntity
               {
                   Name = "Chemical modification of polymers"
               },

               //Petrochemistry
               new DisciplineEntity
               {
                   Name = "Chemical foundations of biological processes"
               },
               new DisciplineEntity
               {
                   Name = "Polymer synthesis methods"
               },
               new DisciplineEntity
               {
                   Name = "Analysis of the quality of hydrocarbon raw materials and products of its processing"
               },

               //Physical chemistry
               new DisciplineEntity
               {
                   Name = "Theoretical foundations of oil refining"
               },
               new DisciplineEntity
               {
                   Name = "Methods for the transmission of scientific information"
               },
               new DisciplineEntity
               {
                   Name = "Theoretical foundations of oil refining"
               }

           );
        }
    }
}
