namespace CourseBook.WebApi.Faculties.Data
{
    using System;
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class DirectionDisciplineEntityConfiguration : IEntityTypeConfiguration<DirectionDisciplineEntity>
    {
        public void Configure(EntityTypeBuilder<DirectionDisciplineEntity> builder)
        {
            builder.ToTable("directions_disciplines");

            builder.HasKey(e => new { e.DirectionId, e.DisciplineId });

            builder.HasOne(e => e.Direction)
                .WithMany(e => e.Disciplines)
                .HasForeignKey("direction_id");

            builder.HasOne(e => e.Discipline)
                .WithMany(e => e.Directions)
                .HasForeignKey("discipline_id");

            builder.HasData(new DirectionDisciplineEntity[] {
                //Culturology
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("aaa504f9-b3ad-4854-9820-90cdcbd27322"),
                    DisciplineId = Guid.Parse("986d7006-65c4-4246-b99a-2d390e1ae4f7")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("aaa504f9-b3ad-4854-9820-90cdcbd27322"),
                    DisciplineId = Guid.Parse("b0a130ae-8d09-4cec-8814-24c811028771")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("aaa504f9-b3ad-4854-9820-90cdcbd27322"),
                    DisciplineId = Guid.Parse("fee99c99-831c-4f29-acd0-5eb5ad0ca7e2")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("aaa504f9-b3ad-4854-9820-90cdcbd27322"),
                    DisciplineId = Guid.Parse("d12b6e66-e758-48ca-af31-102aa991bdc0")
                },
                //Pedagogy
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("0efe92d1-4959-4cf5-8969-56bce0e8558c"),
                    DisciplineId = Guid.Parse("0142a5ca-e2ab-423a-a03f-d2c3092a0339")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("0efe92d1-4959-4cf5-8969-56bce0e8558c"),
                    DisciplineId = Guid.Parse("09da399f-d269-4333-b3a9-c7203dee1a01")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("0efe92d1-4959-4cf5-8969-56bce0e8558c"),
                    DisciplineId = Guid.Parse("d4e27800-46bd-48d4-b320-92380548f689")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("0efe92d1-4959-4cf5-8969-56bce0e8558c"),
                    DisciplineId = Guid.Parse("f333c6ac-530c-4092-8160-a336bafb4d6c")
                },
                //Design
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"),
                    DisciplineId = Guid.Parse("8e518999-5273-4789-9978-dac4baa4e74c")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"),
                    DisciplineId = Guid.Parse("e1de5ca1-58dd-4a15-8544-0b370db9f2bb")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"),
                    DisciplineId = Guid.Parse("f5a8d4f5-a85c-4141-be24-7ba4d2bae6ce")
                },
                // Library and Information Activities
                /*
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("fa2a6596-0f78-42c8-8f3f-56430aa50087"),
                    DisciplineId = Guid.Parse("f5a8d4f5-a85c-4141-be24-7ba4d2bae6ce")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("fa2a6596-0f78-42c8-8f3f-56430aa50087"),
                    DisciplineId = Guid.Parse("f5a8d4f5-a85c-4141-be24-7ba4d2bae6ce")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("fa2a6596-0f78-42c8-8f3f-56430aa50087"),
                    DisciplineId = Guid.Parse("f5a8d4f5-a85c-4141-be24-7ba4d2bae6ce")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("fa2a6596-0f78-42c8-8f3f-56430aa50087"),
                    DisciplineId = Guid.Parse("f5a8d4f5-a85c-4141-be24-7ba4d2bae6ce")
                },
                */
                // Astronomy and Space Geodesy
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("fb92cb9d-c54c-4882-8a84-d357392586b7"),
                    DisciplineId = Guid.Parse("1b773c45-0a73-43f9-94d6-af576c52cf9f")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("fb92cb9d-c54c-4882-8a84-d357392586b7"),
                    DisciplineId = Guid.Parse("5b63a570-f5b2-47e7-8b2f-a79ca090797a")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("fb92cb9d-c54c-4882-8a84-d357392586b7"),
                    DisciplineId = Guid.Parse("5687210f-0fe3-4111-b0c6-a4764c3ad27c")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("fb92cb9d-c54c-4882-8a84-d357392586b7"),
                    DisciplineId = Guid.Parse("bc957929-f744-4315-a4ed-08530c7f0f3e")
                },
                //General and Experimental Physics
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"),
                    DisciplineId = Guid.Parse("d6b13c5b-cabf-4034-af31-f3c30d344393")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"),
                    DisciplineId = Guid.Parse("ad97d079-2037-4dd7-abfd-f23befa01df2")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"),
                    DisciplineId = Guid.Parse("d80697b7-aa62-49e2-86e8-2a83e2e71004")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"),
                    DisciplineId = Guid.Parse("9fe893d9-19e8-4ca5-99a1-09c165918e8b")
                },
                // Quantum Field Theory
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("46c6bba6-91be-4b95-b9c9-812fbdce601e"),
                    DisciplineId = Guid.Parse("45a4ac18-d257-4bbf-8c90-959c5222aecf")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("46c6bba6-91be-4b95-b9c9-812fbdce601e"),
                    DisciplineId = Guid.Parse("a02c08b7-bd53-43e7-8a83-ead1185fbdd0")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("46c6bba6-91be-4b95-b9c9-812fbdce601e"),
                    DisciplineId = Guid.Parse("db2a6fec-1be3-4e5a-9dc2-71e0104c150d")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("46c6bba6-91be-4b95-b9c9-812fbdce601e"),
                    DisciplineId = Guid.Parse("211181c7-ef7c-4de0-b382-70e0eb9c89d3")
                },
                // General and Experimental Physics
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"),
                    DisciplineId = Guid.Parse("d6b13c5b-cabf-4034-af31-f3c30d344393")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"),
                    DisciplineId = Guid.Parse("ad97d079-2037-4dd7-abfd-f23befa01df2")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"),
                    DisciplineId = Guid.Parse("d80697b7-aa62-49e2-86e8-2a83e2e71004")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"),
                    DisciplineId = Guid.Parse("9fe893d9-19e8-4ca5-99a1-09c165918e8b")
                },
                // Optics and Spectroscopy
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("f1db86a1-2647-44ff-81df-6e4781239dcc"),
                    DisciplineId = Guid.Parse("bc5bc711-5718-4b9c-a6cf-3d08a00f157c")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("f1db86a1-2647-44ff-81df-6e4781239dcc"),
                    DisciplineId = Guid.Parse("bf026a3f-9e2a-4506-a411-8bda85002c36")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("f1db86a1-2647-44ff-81df-6e4781239dcc"),
                    DisciplineId = Guid.Parse("4f4ffe1d-b54c-45f7-9e34-a0cc26df4ddd")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("f1db86a1-2647-44ff-81df-6e4781239dcc"),
                    DisciplineId = Guid.Parse("4bd00c26-498f-439e-b269-5052091dc53f")
                },
                // Radiophysics
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("435557fa-35a0-4f35-9efa-7aba31755b46"),
                    DisciplineId = Guid.Parse("eeccea9a-ebaa-4660-b2f2-8fad550b38bb")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("435557fa-35a0-4f35-9efa-7aba31755b46"),
                    DisciplineId = Guid.Parse("2f9785fd-34f2-47dd-8b5b-e520047213fb")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("435557fa-35a0-4f35-9efa-7aba31755b46"),
                    DisciplineId = Guid.Parse("f532bb4b-725b-4b00-8643-a335a4c3fe2f")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("435557fa-35a0-4f35-9efa-7aba31755b46"),
                    DisciplineId = Guid.Parse("96e8af39-7453-49cb-af5a-28d1e64e001a")
                },
                // Radio electronics
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("bc4dd321-36ee-4050-905e-b1aa3fa01182"),
                    DisciplineId = Guid.Parse("0af79477-a80e-4eb6-b156-97bc4cb47315")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("bc4dd321-36ee-4050-905e-b1aa3fa01182"),
                    DisciplineId = Guid.Parse("a5f99e5d-a6a6-4a15-96b0-b2c3f54ce06c")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("bc4dd321-36ee-4050-905e-b1aa3fa01182"),
                    DisciplineId = Guid.Parse("1faf9ce2-d392-4097-af23-2d962b90e9d6")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("bc4dd321-36ee-4050-905e-b1aa3fa01182"),
                    DisciplineId = Guid.Parse("ac542825-f958-4103-91ec-89e6363f0d43")
                },
                // Semiconductor Electronics
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("ae4d9db2-9358-4a51-9928-888d5338a78e"),
                    DisciplineId = Guid.Parse("7131c3a2-4bc4-4195-859a-f5af9bd7d144")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("ae4d9db2-9358-4a51-9928-888d5338a78e"),
                    DisciplineId = Guid.Parse("9f160c04-c98b-4d58-a631-cdec4a04e316")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("ae4d9db2-9358-4a51-9928-888d5338a78e"),
                    DisciplineId = Guid.Parse("fef757f5-8653-4ac3-814d-b60af590ce5a")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("ae4d9db2-9358-4a51-9928-888d5338a78e"),
                    DisciplineId = Guid.Parse("075486bf-0147-4bf7-97ca-e83191675bfb")
                },
                // Optoelectronic systems and remote sensing
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("de2a66b0-56ea-44e3-b202-c1b4754b1721"),
                    DisciplineId = Guid.Parse("96cd27bd-dcff-496b-9984-4489b11a2712")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("de2a66b0-56ea-44e3-b202-c1b4754b1721"),
                    DisciplineId = Guid.Parse("b46cc5bc-6fc4-4f1e-9b2a-ff68b3f1234d")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("de2a66b0-56ea-44e3-b202-c1b4754b1721"),
                    DisciplineId = Guid.Parse("3ac05f7b-8ee9-4bf5-a37b-692eb9670c35")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("de2a66b0-56ea-44e3-b202-c1b4754b1721"),
                    DisciplineId = Guid.Parse("aad3f967-7158-46ca-9b8a-405581f207a4")
                },
                // Analytical chemistry
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"),
                    DisciplineId = Guid.Parse("e55051fc-17a6-41ec-b76e-fe6d98a15058")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"),
                    DisciplineId = Guid.Parse("65830d5c-c0b3-46b6-8bea-b3dd2ce6e1dd")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"),
                    DisciplineId = Guid.Parse("54f742d3-a89d-4e4a-bd39-d233e0c34395")
                },
                // Macromolecular compounds
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("37dd1e11-b958-45ef-ab51-09650b3d43d4"),
                    DisciplineId = Guid.Parse("27bedee0-3b3e-4ab2-9bab-7f910ea12df2")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("37dd1e11-b958-45ef-ab51-09650b3d43d4"),
                    DisciplineId = Guid.Parse("f3a05565-4293-47b4-8799-78a7e0d8787f")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("37dd1e11-b958-45ef-ab51-09650b3d43d4"),
                    DisciplineId = Guid.Parse("abc7d661-c1c4-4bd7-b767-d88ce7b748e5")
                },
                // Petrochemistry
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("afdfcc0a-ffdd-41e1-ab01-a712574e289a"),
                    DisciplineId = Guid.Parse("7798ec77-2078-410b-9a47-3ecb1f17b100")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("afdfcc0a-ffdd-41e1-ab01-a712574e289a"),
                    DisciplineId = Guid.Parse("5f926e12-86e0-4c9f-9f99-734ef39575ca")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("afdfcc0a-ffdd-41e1-ab01-a712574e289a"),
                    DisciplineId = Guid.Parse("0a89c092-a7df-4570-b7a4-1042d4a08b04")
                },
                // Physical chemistry
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("70b17a41-5128-4bde-83dd-f727554ea6b0"),
                    DisciplineId = Guid.Parse("579e5d9d-cf33-41d4-a172-56853419f169")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("70b17a41-5128-4bde-83dd-f727554ea6b0"),
                    DisciplineId = Guid.Parse("c43c64b6-d37d-44b6-a6cc-ad890e942b1b")
                },
                new DirectionDisciplineEntity {
                    DirectionId = Guid.Parse("70b17a41-5128-4bde-83dd-f727554ea6b0"),
                    DisciplineId = Guid.Parse("ff28aa68-df77-4829-a2ce-f322d4b15a2b")
                },
            });
        }
    }
}
