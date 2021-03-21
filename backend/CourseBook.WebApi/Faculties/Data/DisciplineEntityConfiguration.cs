namespace CourseBook.WebApi.Faculties.Data
{
    using System;
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class DisciplineEntityConfiguration : IEntityTypeConfiguration<DisciplineEntity>
    {
        public void Configure(EntityTypeBuilder<DisciplineEntity> builder)
        {
            builder.ToTable("disciplines");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Literatures)
                .HasMaxLength(4096);

            builder.HasData(
               //Culturology
               new DisciplineEntity
               {
                   Id = Guid.Parse("986d7006-65c4-4246-b99a-2d390e1ae4f7"),
                   Name = "Art history"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("b0a130ae-8d09-4cec-8814-24c811028771"),
                   Name = "Composition"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("fee99c99-831c-4f29-acd0-5eb5ad0ca7e2"),
                   Name = "Sociology of media"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("d12b6e66-e758-48ca-af31-102aa991bdc0"),
                   Name = "History of material culture"
               },

               //Pedagogy
               new DisciplineEntity
               {
                   Id = Guid.Parse("0142a5ca-e2ab-423a-a03f-d2c3092a0339"),
                   Name = "Information law"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("09da399f-d269-4333-b3a9-c7203dee1a01"),
                   Name = "Copyright"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("d4e27800-46bd-48d4-b320-92380548f689"),
                   Name = "Quantitative methods in scientific research"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("f333c6ac-530c-4092-8160-a336bafb4d6c"),
                   Name = "Strategic management in the library"
               },

               //Design
               new DisciplineEntity
               {
                   Id = Guid.Parse("8e518999-5273-4789-9978-dac4baa4e74c"),
                   Name = "Foreign language"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("e1de5ca1-58dd-4a15-8544-0b370db9f2bb"),
                   Name = "Academic writing"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("f5a8d4f5-a85c-4141-be24-7ba4d2bae6ce"),
                   Name = "Museology, conservation and restoration of historical and cultural objects"
               },


               //Astronomy and Space Geodesy
               new DisciplineEntity
               {
                   Id = Guid.Parse("1b773c45-0a73-43f9-94d6-af576c52cf9f"),
                   Name = "Modern problems of physics of the microworld and cosmology"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("5b63a570-f5b2-47e7-8b2f-a79ca090797a"),
                   Name = "Foreign language in the field of professional communication"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("5687210f-0fe3-4111-b0c6-a4764c3ad27c"),
                   Name = "Waves and layers in plasma"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("bc957929-f744-4315-a4ed-08530c7f0f3e"),
                   Name = "Plasma physics problems"
               },


               //Quantum Field Theory
               new DisciplineEntity
               {
                   Id = Guid.Parse("45a4ac18-d257-4bbf-8c90-959c5222aecf"),
                   Name = "Military training"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("a02c08b7-bd53-43e7-8a83-ead1185fbdd0"),
                   Name = "Information systems design"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("db2a6fec-1be3-4e5a-9dc2-71e0104c150d"),
                   Name = "Laboratories specializing in satellite dynamics"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("211181c7-ef7c-4de0-b382-70e0eb9c89d3"),
                   Name = "Global Positioning Technologies"
               },

               //General and Experimental Physics
               new DisciplineEntity
               {
                   Id = Guid.Parse("d6b13c5b-cabf-4034-af31-f3c30d344393"),
                   Name = "Modern problems of physics of the microworld and cosmology"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("ad97d079-2037-4dd7-abfd-f23befa01df2"),
                   Name = "Physics of intermolecular interactions"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("d80697b7-aa62-49e2-86e8-2a83e2e71004"),
                   Name = "The theory of elementary particles"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("9fe893d9-19e8-4ca5-99a1-09c165918e8b"),
                   Name = "Topical issues of theory and teaching methods in physics"
               },

               //Optics and Spectroscopy
               new DisciplineEntity
               {
                   Id = Guid.Parse("bc5bc711-5718-4b9c-a6cf-3d08a00f157c"),
                   Name = "Fundamentals of Atomic and Molecular Spectroscopy"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("bf026a3f-9e2a-4506-a411-8bda85002c36"),
                   Name = "Foreign language in the field of professional communication"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("4f4ffe1d-b54c-45f7-9e34-a0cc26df4ddd"),
                   Name = "Analysis of complex biophysical signals"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("4bd00c26-498f-439e-b269-5052091dc53f"),
                   Name = "Biomedical laser technology"
               },


               //Radiophysics
               new DisciplineEntity
               {
                   Id = Guid.Parse("eeccea9a-ebaa-4660-b2f2-8fad550b38bb"),
                   Name = "Linear Algebra"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("2f9785fd-34f2-47dd-8b5b-e520047213fb"),
                   Name = "Physics"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("f532bb4b-725b-4b00-8643-a335a4c3fe2f"),
                   Name = "Mathematical analysis"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("96e8af39-7453-49cb-af5a-28d1e64e001a"),
                   Name = "Foreign language"
               },

               //Radio electronics
               new DisciplineEntity
               {
                   Id = Guid.Parse("0af79477-a80e-4eb6-b156-97bc4cb47315"),
                   Name = "Microprocessors"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("a5f99e5d-a6a6-4a15-96b0-b2c3f54ce06c"),
                   Name = "Electronics"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("1faf9ce2-d392-4097-af23-2d962b90e9d6"),
                   Name = "Optics Basics"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("ac542825-f958-4103-91ec-89e6363f0d43"),
                   Name = "Military training"
               },

               //Semiconductor Electronics
               new DisciplineEntity
               {
                   Id = Guid.Parse("7131c3a2-4bc4-4195-859a-f5af9bd7d144"),
                   Name = "	Mobile communication systems"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("9f160c04-c98b-4d58-a631-cdec4a04e316"),
                   Name = "Metrology"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("fef757f5-8653-4ac3-814d-b60af590ce5a"),
                   Name = "Digital spectral analysis of signals and fields"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("075486bf-0147-4bf7-97ca-e83191675bfb"),
                   Name = "	Standardization and certification"
               },

               // Optoelectronic systems and remote sensing
               new DisciplineEntity
               {
                   Id = Guid.Parse("96cd27bd-dcff-496b-9984-4489b11a2712"),
                   Name = "Waveguide Photonics"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("b46cc5bc-6fc4-4f1e-9b2a-ff68b3f1234d"),
                   Name = "Atomic and Nuclear Physics"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("3ac05f7b-8ee9-4bf5-a37b-692eb9670c35"),
                   Name = "Elective disciplines in physical culture and sports"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("aad3f967-7158-46ca-9b8a-405581f207a4"),
                   Name = "Study Practice"
               },

               //Analytical Chemistry
               new DisciplineEntity
               {
                   Id = Guid.Parse("e55051fc-17a6-41ec-b76e-fe6d98a15058"),
                   Name = "Analytical chemistry"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("65830d5c-c0b3-46b6-8bea-b3dd2ce6e1dd"),
                   Name = "Foreign language"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("54f742d3-a89d-4e4a-bd39-d233e0c34395"),
                   Name = "Quantum chemistry"
               },

               //Macromolecular compounds
               new DisciplineEntity
               {
                   Id = Guid.Parse("27bedee0-3b3e-4ab2-9bab-7f910ea12df2"),
                   Name = "Pedagogy"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("f3a05565-4293-47b4-8799-78a7e0d8787f"),
                   Name = "Polymer solutions"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("abc7d661-c1c4-4bd7-b767-d88ce7b748e5"),
                   Name = "Chemical modification of polymers"
               },

               //Petrochemistry
               new DisciplineEntity
               {
                   Id = Guid.Parse("7798ec77-2078-410b-9a47-3ecb1f17b100"),
                   Name = "Chemical foundations of biological processes"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("5f926e12-86e0-4c9f-9f99-734ef39575ca"),
                   Name = "Polymer synthesis methods"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("0a89c092-a7df-4570-b7a4-1042d4a08b04"),
                   Name = "Analysis of the quality of hydrocarbon raw materials and products of its processing"
               },

               //Physical chemistry
               new DisciplineEntity
               {
                   Id = Guid.Parse("579e5d9d-cf33-41d4-a172-56853419f169"),
                   Name = "Theoretical foundations of oil refining"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("c43c64b6-d37d-44b6-a6cc-ad890e942b1b"),
                   Name = "Methods for the transmission of scientific information"
               },
               new DisciplineEntity
               {
                   Id = Guid.Parse("ff28aa68-df77-4829-a2ce-f322d4b15a2b"),
                   Name = "Theoretical foundations of oil refining"
               }

           );
        }
    }
}
