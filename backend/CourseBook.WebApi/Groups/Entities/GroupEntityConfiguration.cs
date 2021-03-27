namespace CourseBook.WebApi.Groups.Entities
{
    using System;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class GroupEntityConfiguration : IEntityTypeConfiguration<GroupEntity>
    {
        public void Configure(EntityTypeBuilder<GroupEntity> builder)
        {
            builder.ToTable("groups");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id);

            builder.HasMany(e => e.Students)
                   .WithOne(e => e.Group);

            builder.HasData(
                //Culturology
                new GroupEntity
                {
                    Id = Guid.Parse("bbf4d1b7-5dd6-4737-b78c-e865cbe4adc0"),
                    DirectionId = Guid.Parse("aaa504f9-b3ad-4854-9820-90cdcbd27322"),
                    Name = "931910"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("bfd64d63-203b-47f1-86c4-c483b6cb48ac"),
                    DirectionId = Guid.Parse("aaa504f9-b3ad-4854-9820-90cdcbd27322"),
                    Name = "932010"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("c06d5b88-917b-42ad-a032-224cf2cbb34b"),
                    DirectionId = Guid.Parse("aaa504f9-b3ad-4854-9820-90cdcbd27322"),
                    Name = "932028"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("995fefec-b444-4755-9e70-bee240d47c9e"),
                    DirectionId = Guid.Parse("aaa504f9-b3ad-4854-9820-90cdcbd27322"),
                    Name = "931928"
                },

                //Pedagogy
                new GroupEntity
                {
                    Id = Guid.Parse("b719e956-a46c-41b5-93bd-81bd4e12c7ed"),
                    DirectionId = Guid.Parse("0efe92d1-4959-4cf5-8969-56bce0e8558c"),
                    Name = "93180"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("d85b1c42-f9b2-4fbb-bc35-1e93c4f311be"),
                    DirectionId = Guid.Parse("0efe92d1-4959-4cf5-8969-56bce0e8558c"),
                    Name = "931802"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("11f1a4ae-64ef-4708-945f-001ec13475cb"),
                    DirectionId = Guid.Parse("0efe92d1-4959-4cf5-8969-56bce0e8558c"),
                    Name = "931804"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("150043db-fafd-47af-a367-1865429a3b06"),
                    DirectionId = Guid.Parse("0efe92d1-4959-4cf5-8969-56bce0e8558c"),
                    Name = "931803"
                },

                //Design
                new GroupEntity
                {
                    Id = Guid.Parse("6b5539c4-5008-489f-bee7-d10063412727"),
                    DirectionId = Guid.Parse("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"),
                    Name = "93190"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("4779771c-16be-49ad-af93-d2c3af799ffa"),
                    DirectionId = Guid.Parse("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"),
                    Name = "931901"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("c894f7d5-102f-454c-87c9-ff00086f43c4"),
                    DirectionId = Guid.Parse("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"),
                    Name = "931902"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("e55a88ef-d73f-40f6-941a-6ebd51d0df33"),
                    DirectionId = Guid.Parse("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"),
                    Name = "931903"
                },

                //Library and Information Activities
                new GroupEntity
                {
                    Id = Guid.Parse("99cee655-2eb3-49a1-8b7b-98f5cdf27dc0"),
                    DirectionId = Guid.Parse("fa2a6596-0f78-42c8-8f3f-56430aa50087"),
                    Name = "93200"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("f18a4b0e-bf34-4038-aa35-961ee944fc62"),
                    DirectionId = Guid.Parse("fa2a6596-0f78-42c8-8f3f-56430aa50087"),
                    Name = "93201"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("1d31e987-c3b7-4e79-8aa8-61482da3987e"),
                    DirectionId = Guid.Parse("fa2a6596-0f78-42c8-8f3f-56430aa50087"),
                    Name = "93202"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("65ca36aa-54f8-4384-af13-f16779251686"),
                    DirectionId = Guid.Parse("fa2a6596-0f78-42c8-8f3f-56430aa50087"),
                    Name = "93203"
                },


                //Astronomy and Space Geodesy
                new GroupEntity
                {
                    Id = Guid.Parse("2e596386-82f0-422c-a0d1-6c9325b2b8c5"),
                    DirectionId = Guid.Parse("fb92cb9d-c54c-4882-8a84-d357392586b7"),
                    Name = "122001"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("177aca2d-65d7-4d69-88bf-95488732d0c5"),
                    DirectionId = Guid.Parse("fb92cb9d-c54c-4882-8a84-d357392586b7"),
                    Name = "122002"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("97d0822d-49aa-47df-b483-6f9d8ee29804"),
                    DirectionId = Guid.Parse("fb92cb9d-c54c-4882-8a84-d357392586b7"),
                    Name = "122003"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("9ae4c644-778d-4358-90cf-7fdd895018c5"),
                    DirectionId = Guid.Parse("fb92cb9d-c54c-4882-8a84-d357392586b7"),
                    Name = "122004"
                },

                //Quantum Field Theory
                new GroupEntity
                {
                    Id = Guid.Parse("de67b121-67e1-4daf-afce-cd7f5fcd73f0"),
                    DirectionId = Guid.Parse("46c6bba6-91be-4b95-b9c9-812fbdce601e"),
                    Name = "121901"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("0ea53180-ed44-4898-a892-c40077d05e65"),
                    DirectionId = Guid.Parse("46c6bba6-91be-4b95-b9c9-812fbdce601e"),
                    Name = "121902"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("2bc26348-3840-4d75-b5b8-307b5664d9d8"),
                    DirectionId = Guid.Parse("46c6bba6-91be-4b95-b9c9-812fbdce601e"),
                    Name = "121903"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("3898a741-3487-4cff-bb0c-833730a7bfb5"),
                    DirectionId = Guid.Parse("46c6bba6-91be-4b95-b9c9-812fbdce601e"),
                    Name = "121904"
                },

                //General and Experimental Physics
                new GroupEntity
                {
                    Id = Guid.Parse("375f4cd0-0dfe-4549-a250-b038a30badd5"),
                    DirectionId = Guid.Parse("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"),
                    Name = "24200"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("3a8fecd3-ef58-4894-a716-851ba1955172"),
                    DirectionId = Guid.Parse("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"),
                    Name = "24201"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("55d59cff-8589-454f-92d3-bfc3862567fc"),
                    DirectionId = Guid.Parse("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"),
                    Name = "24202"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("c0ef4a72-dac8-4ea8-a9b5-78f8865e9ad9"),
                    DirectionId = Guid.Parse("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"),
                    Name = "24203"
                },

                //Optics and Spectroscopy
                new GroupEntity
                {
                    Id = Guid.Parse("89767b3d-6327-4125-97c4-b9a2b84854b8"),
                    DirectionId = Guid.Parse("f1db86a1-2647-44ff-81df-6e4781239dcc"),
                    Name = "24301"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("b6ac4a85-9cfb-426e-9b0c-1bea922f4567"),
                    DirectionId = Guid.Parse("f1db86a1-2647-44ff-81df-6e4781239dcc"),
                    Name = "24302"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("f2d957fa-c1fd-47a4-b0c0-f316dbeda20f"),
                    DirectionId = Guid.Parse("f1db86a1-2647-44ff-81df-6e4781239dcc"),
                    Name = "24303"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("adb7bc56-69ad-401a-9f98-ca7237712022"),
                    DirectionId = Guid.Parse("f1db86a1-2647-44ff-81df-6e4781239dcc"),
                    Name = "24304"
                },

                //Radiophysics
                new GroupEntity
                {
                    Id = Guid.Parse("63f903de-5162-45f1-90fe-68e1b1375431"),
                    DirectionId = Guid.Parse("435557fa-35a0-4f35-9efa-7aba31755b46"),
                    Name = "25301"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("1d667208-71cd-4ffc-8edf-ce6b71121da8"),
                    DirectionId = Guid.Parse("435557fa-35a0-4f35-9efa-7aba31755b46"),
                    Name = "25302"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("085e3eb8-a9d8-4b04-ac37-3b3c8e417330"),
                    DirectionId = Guid.Parse("435557fa-35a0-4f35-9efa-7aba31755b46"),
                    Name = "25303"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("0aece601-4a7e-4b22-809f-c7a3f560e7ae"),
                    DirectionId = Guid.Parse("435557fa-35a0-4f35-9efa-7aba31755b46"),
                    Name = "25304"
                },

                //Radio electronics
                new GroupEntity
                {
                    Id = Guid.Parse("ef31ca1b-8b5c-497f-b4a6-c9c602ce3e17"),
                    DirectionId = Guid.Parse("bc4dd321-36ee-4050-905e-b1aa3fa01182"),
                    Name = "30001"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("bc28bb75-ec40-4118-a652-4dfda2189c42"),
                    DirectionId = Guid.Parse("bc4dd321-36ee-4050-905e-b1aa3fa01182"),
                    Name = "30002"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("97f0b426-f8bd-496c-b8af-7b5432c35eca"),
                    DirectionId = Guid.Parse("bc4dd321-36ee-4050-905e-b1aa3fa01182"),
                    Name = "30003"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("baa44940-e055-4097-9d35-23ff36c24ece"),
                    DirectionId = Guid.Parse("bc4dd321-36ee-4050-905e-b1aa3fa01182"),
                    Name = "30004"
                },

                //Semiconductor Electronics
                new GroupEntity
                {
                    Id = Guid.Parse("bc6f600e-3c90-4fd2-a650-7fe8496d6b99"),
                    DirectionId = Guid.Parse("ae4d9db2-9358-4a51-9928-888d5338a78e"),
                    Name = "40001"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("d47f6ceb-be52-4d14-94c2-3891dae8524d"),
                    DirectionId = Guid.Parse("ae4d9db2-9358-4a51-9928-888d5338a78e"),
                    Name = "40002"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("8d22e5be-874c-4467-a8a6-10ec4be05940"),
                    DirectionId = Guid.Parse("ae4d9db2-9358-4a51-9928-888d5338a78e"),
                    Name = "40003"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("f12316e7-00a1-44d1-8cd4-f130cb1549d7"),
                    DirectionId = Guid.Parse("ae4d9db2-9358-4a51-9928-888d5338a78e"),
                    Name = "40004"
                },

                //Optoelectronic systems and remote sensing
                new GroupEntity
                {
                    Id = Guid.Parse("301db25d-27bc-4fdd-9422-76161b433222"),
                    DirectionId = Guid.Parse("de2a66b0-56ea-44e3-b202-c1b4754b1721"),
                    Name = "50001"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("61779bbf-e712-4c4f-9c1c-cfde792f8123"),
                    DirectionId = Guid.Parse("de2a66b0-56ea-44e3-b202-c1b4754b1721"),
                    Name = "50002"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("6600b84a-46d6-4457-b553-2bc76cf429b1"),
                    DirectionId = Guid.Parse("de2a66b0-56ea-44e3-b202-c1b4754b1721"),
                    Name = "50003"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("21e70871-00c4-435f-a58f-e5ee217c9daf"),
                    DirectionId = Guid.Parse("de2a66b0-56ea-44e3-b202-c1b4754b1721"),
                    Name = "50004"
                },

                //Analytical Chemistry
                new GroupEntity
                {
                    Id = Guid.Parse("53b46c40-973d-4011-96bd-88b6d6d2f266"),
                    DirectionId = Guid.Parse("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"),
                    Name = "60001"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("0c9e1c5b-b73c-4761-9e8b-3fac8fe1ec39"),
                    DirectionId = Guid.Parse("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"),
                    Name = "60002"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("0d4c5368-15a1-46a4-9605-723c91d725bc"),
                    DirectionId = Guid.Parse("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"),
                    Name = "60003"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("d6382f9d-4e4c-45b3-8b34-4a63e69de09f"),
                    DirectionId = Guid.Parse("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"),
                    Name = "60004"
                },

                //Macromolecular compounds
                new GroupEntity
                {
                    Id = Guid.Parse("deff19d1-bf42-4d14-9ac1-5c21b2a18a5c"),
                    DirectionId = Guid.Parse("37dd1e11-b958-45ef-ab51-09650b3d43d4"),
                    Name = "70001"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("e9880029-92c6-4143-a680-00c06e6347d3"),
                    DirectionId = Guid.Parse("37dd1e11-b958-45ef-ab51-09650b3d43d4"),
                    Name = "70002"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("0d80b63a-50d1-4c0f-b1f7-0a351d57192e"),
                    DirectionId = Guid.Parse("37dd1e11-b958-45ef-ab51-09650b3d43d4"),
                    Name = "70003"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("0ccaf237-249b-49a2-91bf-4e13199f0ed8"),
                    DirectionId = Guid.Parse("37dd1e11-b958-45ef-ab51-09650b3d43d4"),
                    Name = "70004"
                },

                //Petrochemistry
                new GroupEntity
                {
                    Id = Guid.Parse("78b0c8a8-02d4-476d-a201-667cd79d0557"),
                    DirectionId = Guid.Parse("afdfcc0a-ffdd-41e1-ab01-a712574e289a"),
                    Name = "80001"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("a06269e9-85a7-4108-b199-0a5f81b9dedd"),
                    DirectionId = Guid.Parse("afdfcc0a-ffdd-41e1-ab01-a712574e289a"),
                    Name = "80002"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("4320ca86-9aaf-42fb-8832-35c9076e5b05"),
                    DirectionId = Guid.Parse("afdfcc0a-ffdd-41e1-ab01-a712574e289a"),
                    Name = "80003"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("462afa34-c206-4761-bd96-b87e72d1d243"),
                    DirectionId = Guid.Parse("afdfcc0a-ffdd-41e1-ab01-a712574e289a"),
                    Name = "80004"
                },

                //Physical chemistry
                new GroupEntity
                {
                    Id = Guid.Parse("7e311ede-5d6c-4df4-9c64-192e00f65cf9"),
                    DirectionId = Guid.Parse("70b17a41-5128-4bde-83dd-f727554ea6b0"),
                    Name = "90001"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("24b4ee8d-c599-41b2-be5c-b27597cf278b"),
                    DirectionId = Guid.Parse("70b17a41-5128-4bde-83dd-f727554ea6b0"),
                    Name = "90002"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("deea0a5c-fb24-4994-9384-fabe85e4a76a"),
                    DirectionId = Guid.Parse("70b17a41-5128-4bde-83dd-f727554ea6b0"),
                    Name = "90003"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("4af28876-24b2-4f33-ac7b-4c4c95385ab3"),
                    DirectionId = Guid.Parse("70b17a41-5128-4bde-83dd-f727554ea6b0"),
                    Name = "90004"
                }
            );

            builder.HasData(
                //Culturology
                new GroupEntity
                {
                    Id = Guid.Parse("26441b22-1be9-432f-a06a-ebc9e4222f6e"),
                    DirectionId = Guid.Parse("aaa504f9-b3ad-4854-9820-90cdcbd27322"),
                    Name = "931910"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("c4ba2c3f-6f86-41a2-b79e-0288e25b5d06"),
                    DirectionId = Guid.Parse("aaa504f9-b3ad-4854-9820-90cdcbd27322"),
                    Name = "932010"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("dc0a6e03-06ab-4f32-8714-841367f13739"),
                    DirectionId = Guid.Parse("aaa504f9-b3ad-4854-9820-90cdcbd27322"),
                    Name = "932028"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("590eb367-5fcf-4b67-a350-e2f87a688ef4"),
                    DirectionId = Guid.Parse("aaa504f9-b3ad-4854-9820-90cdcbd27322"),
                    Name = "931928"
                },

                //Pedagogy
                new GroupEntity
                {
                    Id = Guid.Parse("69626a13-91ce-4281-bb74-2dac4c1a6db8"),
                    DirectionId = Guid.Parse("0efe92d1-4959-4cf5-8969-56bce0e8558c"),
                    Name = "93180"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("ee357e08-2b26-4e71-97cc-a4a9aeb7b94e"),
                    DirectionId = Guid.Parse("0efe92d1-4959-4cf5-8969-56bce0e8558c"),
                    Name = "931802"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("d37caba8-8a5e-43f5-bdf7-96f8d4ee437c"),
                    DirectionId = Guid.Parse("0efe92d1-4959-4cf5-8969-56bce0e8558c"),
                    Name = "931804"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("e90ec78b-115f-4d45-af21-1f6e89b3ea62"),
                    DirectionId = Guid.Parse("0efe92d1-4959-4cf5-8969-56bce0e8558c"),
                    Name = "931803"
                },

                //Design
                new GroupEntity
                {
                    Id = Guid.Parse("a1c8530c-7aca-463b-a2cb-4c18c72957ec"),
                    DirectionId = Guid.Parse("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"),
                    Name = "93190"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("43559fcb-8bae-4cc0-9576-f2835a3061f9"),
                    DirectionId = Guid.Parse("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"),
                    Name = "931901"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("ae932456-b33f-486a-93dc-adb27c290296"),
                    DirectionId = Guid.Parse("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"),
                    Name = "931902"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("43017bdf-3026-4607-a266-30948c613f0d"),
                    DirectionId = Guid.Parse("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"),
                    Name = "931903"
                },

                //Library and Information Activities
                new GroupEntity
                {
                    Id = Guid.Parse("8ce7c591-597d-4e4a-9702-78410cc91fbe"),
                    DirectionId = Guid.Parse("fa2a6596-0f78-42c8-8f3f-56430aa50087"),
                    Name = "93200"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("3b541a3e-1e89-48e0-8283-d46fe573bab0"),
                    DirectionId = Guid.Parse("fa2a6596-0f78-42c8-8f3f-56430aa50087"),
                    Name = "93201"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("6fec86e7-be04-4daf-889a-8fb9e048f935"),
                    DirectionId = Guid.Parse("fa2a6596-0f78-42c8-8f3f-56430aa50087"),
                    Name = "93202"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("569b3af3-11b3-4c14-a365-3444136317c9"),
                    DirectionId = Guid.Parse("fa2a6596-0f78-42c8-8f3f-56430aa50087"),
                    Name = "93203"
                },


                //Astronomy and Space Geodesy
                new GroupEntity
                {
                    Id = Guid.Parse("4e9a677c-03a0-4a67-b0fd-6c23560297be"),
                    DirectionId = Guid.Parse("fb92cb9d-c54c-4882-8a84-d357392586b7"),
                    Name = "122001"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("fb9fb634-5a7a-4975-93c5-13c47e2d7a88"),
                    DirectionId = Guid.Parse("fb92cb9d-c54c-4882-8a84-d357392586b7"),
                    Name = "122002"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("a17b86b9-9e59-47be-b497-ac7e681a6490"),
                    DirectionId = Guid.Parse("fb92cb9d-c54c-4882-8a84-d357392586b7"),
                    Name = "122003"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("714b27cd-c133-459c-91ea-d4be6879f6df"),
                    DirectionId = Guid.Parse("fb92cb9d-c54c-4882-8a84-d357392586b7"),
                    Name = "122004"
                },

                //Quantum Field Theory
                new GroupEntity
                {
                    Id = Guid.Parse("be0b569f-4f07-4b32-98d6-90580e55f4bd"),
                    DirectionId = Guid.Parse("46c6bba6-91be-4b95-b9c9-812fbdce601e"),
                    Name = "121901"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("d37e2391-3b24-4258-8543-25cb3e8e6021"),
                    DirectionId = Guid.Parse("46c6bba6-91be-4b95-b9c9-812fbdce601e"),
                    Name = "121902"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("7f21c712-e107-4dc5-8bcc-8c8d3e29611b"),
                    DirectionId = Guid.Parse("46c6bba6-91be-4b95-b9c9-812fbdce601e"),
                    Name = "121903"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("7b328e66-8d7f-4677-adf6-32d296aef412"),
                    DirectionId = Guid.Parse("46c6bba6-91be-4b95-b9c9-812fbdce601e"),
                    Name = "121904"
                },

                //General and Experimental Physics
                new GroupEntity
                {
                    Id = Guid.Parse("a2df678d-7461-4453-be7f-b854eb2eb0b1"),
                    DirectionId = Guid.Parse("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"),
                    Name = "24200"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("6e2c0941-ecf1-4f9c-a2fc-71b498926a25"),
                    DirectionId = Guid.Parse("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"),
                    Name = "24201"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("adcfeb4f-e104-4619-ab33-13bdb9603d6a"),
                    DirectionId = Guid.Parse("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"),
                    Name = "24202"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("49de0fc1-fd7a-4f99-82c1-2bdc4051d6c6"),
                    DirectionId = Guid.Parse("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"),
                    Name = "24203"
                },

                //Optics and Spectroscopy
                new GroupEntity
                {
                    Id = Guid.Parse("6e6f8434-5155-41bc-9186-01e9a4ea2c2e"),
                    DirectionId = Guid.Parse("f1db86a1-2647-44ff-81df-6e4781239dcc"),
                    Name = "24301"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("ab5461c6-6b82-4ec0-b106-7c649c30aa4e"),
                    DirectionId = Guid.Parse("f1db86a1-2647-44ff-81df-6e4781239dcc"),
                    Name = "24302"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("f5a97d11-9036-4a51-ac76-44ff3cccdced"),
                    DirectionId = Guid.Parse("f1db86a1-2647-44ff-81df-6e4781239dcc"),
                    Name = "24303"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("796b3f0f-15aa-4a44-83d1-eb0d004e6ba9"),
                    DirectionId = Guid.Parse("f1db86a1-2647-44ff-81df-6e4781239dcc"),
                    Name = "24304"
                },

                //Radiophysics
                new GroupEntity
                {
                    Id = Guid.Parse("63904fb7-50a7-4d97-a012-82cb80e8bf1e"),
                    DirectionId = Guid.Parse("435557fa-35a0-4f35-9efa-7aba31755b46"),
                    Name = "25301"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("04422cad-54f1-48d7-ae30-f5bfefb085fa"),
                    DirectionId = Guid.Parse("435557fa-35a0-4f35-9efa-7aba31755b46"),
                    Name = "25302"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("16b4c772-5ef3-48d6-9380-ca6b371a0a29"),
                    DirectionId = Guid.Parse("435557fa-35a0-4f35-9efa-7aba31755b46"),
                    Name = "25303"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("bbcd32b0-eee0-4528-9a98-2bd190050b1a"),
                    DirectionId = Guid.Parse("435557fa-35a0-4f35-9efa-7aba31755b46"),
                    Name = "25304"
                },

                //Radio electronics
                new GroupEntity
                {
                    Id = Guid.Parse("954ada8e-3081-4c7a-8cb9-6486ca9c0c78"),
                    DirectionId = Guid.Parse("bc4dd321-36ee-4050-905e-b1aa3fa01182"),
                    Name = "30001"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("70f6eee6-cc82-4b56-8e36-f0855858cc25"),
                    DirectionId = Guid.Parse("bc4dd321-36ee-4050-905e-b1aa3fa01182"),
                    Name = "30002"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("7b9a7b18-b25f-43dd-be9b-6b11cb6a629b"),
                    DirectionId = Guid.Parse("bc4dd321-36ee-4050-905e-b1aa3fa01182"),
                    Name = "30003"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("c6f70945-fc4e-4637-a90f-ad9a859c0b3a"),
                    DirectionId = Guid.Parse("bc4dd321-36ee-4050-905e-b1aa3fa01182"),
                    Name = "30004"
                },

                //Semiconductor Electronics
                new GroupEntity
                {
                    Id = Guid.Parse("9f02f059-f663-4c89-a803-30c0913c6095"),
                    DirectionId = Guid.Parse("ae4d9db2-9358-4a51-9928-888d5338a78e"),
                    Name = "40001"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("a7d2019d-db79-4e4e-9142-4fd7e5595210"),
                    DirectionId = Guid.Parse("ae4d9db2-9358-4a51-9928-888d5338a78e"),
                    Name = "40002"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("92560e1e-10b6-4e22-a3c7-4b44b57a4c2d"),
                    DirectionId = Guid.Parse("ae4d9db2-9358-4a51-9928-888d5338a78e"),
                    Name = "40003"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("d054363e-9ac6-471c-927a-44ede49e14b9"),
                    DirectionId = Guid.Parse("ae4d9db2-9358-4a51-9928-888d5338a78e"),
                    Name = "40004"
                },

                //Optoelectronic systems and remote sensing
                new GroupEntity
                {
                    Id = Guid.Parse("66bfc87e-0176-48b8-86f7-d6bb27145544"),
                    DirectionId = Guid.Parse("de2a66b0-56ea-44e3-b202-c1b4754b1721"),
                    Name = "50001"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("80e4da28-2726-484b-98d3-acf2f685f110"),
                    DirectionId = Guid.Parse("de2a66b0-56ea-44e3-b202-c1b4754b1721"),
                    Name = "50002"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("d76d264f-afb3-43e8-ba47-78a12d6630e7"),
                    DirectionId = Guid.Parse("de2a66b0-56ea-44e3-b202-c1b4754b1721"),
                    Name = "50003"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("fa09fced-f0ec-4f86-8635-548169c085d2"),
                    DirectionId = Guid.Parse("de2a66b0-56ea-44e3-b202-c1b4754b1721"),
                    Name = "50004"
                },

                //Analytical Chemistry
                new GroupEntity
                {
                    Id = Guid.Parse("9b28da7a-9b71-4f57-a682-977f6a6592ab"),
                    DirectionId = Guid.Parse("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"),
                    Name = "60001"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("10ea97d6-aebe-4ef3-bc5a-0d3410762d17"),
                    DirectionId = Guid.Parse("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"),
                    Name = "60002"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("a0c045de-a8a9-4261-b3f6-6f933ea0a2f3"),
                    DirectionId = Guid.Parse("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"),
                    Name = "60003"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("70eccf2a-b381-413e-b58e-c1850d09d638"),
                    DirectionId = Guid.Parse("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"),
                    Name = "60004"
                },

                //Macromolecular compounds
                new GroupEntity
                {
                    Id = Guid.Parse("cbd62f90-c44d-47e1-a049-ae1d5b94e3e7"),
                    DirectionId = Guid.Parse("37dd1e11-b958-45ef-ab51-09650b3d43d4"),
                    Name = "70001"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("eeb1dd57-104c-40ca-b6ea-e64ecfdc55d4"),
                    DirectionId = Guid.Parse("37dd1e11-b958-45ef-ab51-09650b3d43d4"),
                    Name = "70002"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("41178a4d-8d1d-49e4-a0ee-80965e1df5ab"),
                    DirectionId = Guid.Parse("37dd1e11-b958-45ef-ab51-09650b3d43d4"),
                    Name = "70003"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("eb781120-10cf-4161-a235-726b23c3a6c6"),
                    DirectionId = Guid.Parse("37dd1e11-b958-45ef-ab51-09650b3d43d4"),
                    Name = "70004"
                },

                //Petrochemistry
                new GroupEntity
                {
                    Id = Guid.Parse("b129f3e3-a379-45a3-953c-ce69bcf097d5"),
                    DirectionId = Guid.Parse("afdfcc0a-ffdd-41e1-ab01-a712574e289a"),
                    Name = "80001"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("ae0242e1-8c6e-4e6d-99a5-2f55b6e44a47"),
                    DirectionId = Guid.Parse("afdfcc0a-ffdd-41e1-ab01-a712574e289a"),
                    Name = "80002"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("0b7978c5-8e25-45a4-902c-9f6ff5d53b87"),
                    DirectionId = Guid.Parse("afdfcc0a-ffdd-41e1-ab01-a712574e289a"),
                    Name = "80003"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("04172373-df80-4d60-90df-a4efa8e74941"),
                    DirectionId = Guid.Parse("afdfcc0a-ffdd-41e1-ab01-a712574e289a"),
                    Name = "80004"
                },

                //Physical chemistry
                new GroupEntity
                {
                    Id = Guid.Parse("6d4c1ffe-3caa-472c-82e7-040fa3081142"),
                    DirectionId = Guid.Parse("70b17a41-5128-4bde-83dd-f727554ea6b0"),
                    Name = "90001"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("85b6e537-c106-41df-9ec4-5bc8e3b9be17"),
                    DirectionId = Guid.Parse("70b17a41-5128-4bde-83dd-f727554ea6b0"),
                    Name = "90002"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("500c28c8-fcb8-4f56-9e35-4956e579e63d"),
                    DirectionId = Guid.Parse("70b17a41-5128-4bde-83dd-f727554ea6b0"),
                    Name = "90003"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("b8810aca-e66d-4055-9335-8b5560a9200b"),
                    DirectionId = Guid.Parse("70b17a41-5128-4bde-83dd-f727554ea6b0"),
                    Name = "90004"
                }
            );

        }
    }
}
