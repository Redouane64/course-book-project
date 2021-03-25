namespace CourseBook.WebApi.Faculties.Data
{
    using System;
    using Entities;
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
                    Id = Guid.Parse("ea5900f5-e7a9-4bd2-bad7-dda5cb2ff042"),
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
                    Id = Guid.Parse("e30e8b99-d2c0-4d7a-8d7f-1d3b092447b2"),
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
                    Id = Guid.Parse("bc7fa160-02a9-45b9-9484-8337801f5fd9"),
                    DirectionId = Guid.Parse("0efe92d1-4959-4cf5-8969-56bce0e8558c"),
                    Name = "93180"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("fdc3519e-1e1b-4c30-909f-89872df9aab4"),
                    DirectionId = Guid.Parse("0efe92d1-4959-4cf5-8969-56bce0e8558c"),
                    Name = "931802"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("06808fe5-9a1f-46d6-be33-46ee2554a185"),
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
                    Id = Guid.Parse("db6ffaaf-ac89-41cc-9e05-bb27942fc255"),
                    DirectionId = Guid.Parse("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"),
                    Name = "93190"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("b4c4b62f-9530-4f18-84e9-05ec8b254076"),
                    DirectionId = Guid.Parse("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"),
                    Name = "931901"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("7725cdb7-17cd-430a-90be-56efb1c25b9c"),
                    DirectionId = Guid.Parse("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"),
                    Name = "931902"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("a46d545a-6367-4ecc-a667-d7b197e7e130"),
                    DirectionId = Guid.Parse("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"),
                    Name = "931903"
                },

                //Library and Information Activities
                new GroupEntity
                {
                    Id = Guid.Parse("5290a552-09dd-499b-af03-700b898e89e2"),
                    DirectionId = Guid.Parse("fa2a6596-0f78-42c8-8f3f-56430aa50087"),
                    Name = "93200"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("ddd9e772-9cf6-401a-9cc5-33bfc63ae010"),
                    DirectionId = Guid.Parse("fa2a6596-0f78-42c8-8f3f-56430aa50087"),
                    Name = "93201"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("a5403b73-62c8-4c36-9921-2986fb3c107b"),
                    DirectionId = Guid.Parse("fa2a6596-0f78-42c8-8f3f-56430aa50087"),
                    Name = "93202"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("b71701e8-361a-4d91-a661-6942b7a2cca1"),
                    DirectionId = Guid.Parse("fa2a6596-0f78-42c8-8f3f-56430aa50087"),
                    Name = "93203"
                },


                //Astronomy and Space Geodesy
                new GroupEntity
                {
                    Id = Guid.Parse("7f4c4a85-799f-44d8-ad90-dca1da9d1a96"),
                    DirectionId = Guid.Parse("fb92cb9d-c54c-4882-8a84-d357392586b7"),
                    Name = "122001"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("1c09799d-904a-4e2f-9d5f-6535f83ef4b8"),
                    DirectionId = Guid.Parse("fb92cb9d-c54c-4882-8a84-d357392586b7"),
                    Name = "122002"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("9e74ca38-96a8-4af5-aaeb-002b5e1f3599"),
                    DirectionId = Guid.Parse("fb92cb9d-c54c-4882-8a84-d357392586b7"),
                    Name = "122003"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("4d46156f-7e51-47ea-b795-3f0c2d8a10b7"),
                    DirectionId = Guid.Parse("fb92cb9d-c54c-4882-8a84-d357392586b7"),
                    Name = "122004"
                },

                //Quantum Field Theory
                new GroupEntity
                {
                    Id = Guid.Parse("129fd25d-edf9-411e-8b20-d36bf904957b"),
                    DirectionId = Guid.Parse("46c6bba6-91be-4b95-b9c9-812fbdce601e"),
                    Name = "121901"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("86b80b67-14e7-4954-8e1d-972c73e44235"),
                    DirectionId = Guid.Parse("46c6bba6-91be-4b95-b9c9-812fbdce601e"),
                    Name = "121902"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("e1fdc8b3-8047-4087-a2c5-1ca79446b8d2"),
                    DirectionId = Guid.Parse("46c6bba6-91be-4b95-b9c9-812fbdce601e"),
                    Name = "121903"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("1faa2450-cf27-48b9-8626-f2135a08f606"),
                    DirectionId = Guid.Parse("46c6bba6-91be-4b95-b9c9-812fbdce601e"),
                    Name = "121904"
                },

                //General and Experimental Physics
                new GroupEntity
                {
                    Id = Guid.Parse("4cb1a0ae-b7d9-4cbc-8c93-4489bdfd7cda"),
                    DirectionId = Guid.Parse("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"),
                    Name = "24200"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("f9fced79-70b6-4ef0-b059-7548cd6cb491"),
                    DirectionId = Guid.Parse("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"),
                    Name = "24201"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("2566b128-cc7a-4b94-a3a4-19872999ef43"),
                    DirectionId = Guid.Parse("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"),
                    Name = "24202"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("1ada8e8d-fe48-4ea2-af87-714b00dac914"),
                    DirectionId = Guid.Parse("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"),
                    Name = "24203"
                },

                //Optics and Spectroscopy
                new GroupEntity
                {
                    Id = Guid.Parse("2190b991-f0f8-41fe-81bc-f6cf8f8dfd37"),
                    DirectionId = Guid.Parse("f1db86a1-2647-44ff-81df-6e4781239dcc"),
                    Name = "24301"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("86c6eee1-a591-4933-9c10-4c26db8de2ef"),
                    DirectionId = Guid.Parse("f1db86a1-2647-44ff-81df-6e4781239dcc"),
                    Name = "24302"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("1ddedb89-1269-402c-b860-b29fd56d7f5d"),
                    DirectionId = Guid.Parse("f1db86a1-2647-44ff-81df-6e4781239dcc"),
                    Name = "24303"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("1a4bd82f-b1f1-4a3c-ae90-11e4871d7630"),
                    DirectionId = Guid.Parse("f1db86a1-2647-44ff-81df-6e4781239dcc"),
                    Name = "24304"
                },

                //Radiophysics
                new GroupEntity
                {
                    Id = Guid.Parse("f6b933a0-b715-40c5-8640-113fcaacb996"),
                    DirectionId = Guid.Parse("435557fa-35a0-4f35-9efa-7aba31755b46"),
                    Name = "25301"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("c91ae9e0-0b7e-4ec8-936b-450bde57a01d"),
                    DirectionId = Guid.Parse("435557fa-35a0-4f35-9efa-7aba31755b46"),
                    Name = "25302"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("939cee3d-00d0-452a-b727-bbedc1cd10ba"),
                    DirectionId = Guid.Parse("435557fa-35a0-4f35-9efa-7aba31755b46"),
                    Name = "25303"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("e5a9ade9-7a00-4d12-894f-a5bd991a4273"),
                    DirectionId = Guid.Parse("435557fa-35a0-4f35-9efa-7aba31755b46"),
                    Name = "25304"
                },

                //Radio electronics
                new GroupEntity
                {
                    Id = Guid.Parse("bcfd2592-c830-431d-9cc8-ee99ea0f6062"),
                    DirectionId = Guid.Parse("bc4dd321-36ee-4050-905e-b1aa3fa01182"),
                    Name = "30001"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("63d7a7f2-a1ad-47f0-9e98-49adf64a7bdb"),
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
                    Id = Guid.Parse("ea5900f5-e7a9-4bd2-bad7-dda5cb2ff042"),
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
                    Id = Guid.Parse("e30e8b99-d2c0-4d7a-8d7f-1d3b092447b2"),
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
                    Id = Guid.Parse("bc7fa160-02a9-45b9-9484-8337801f5fd9"),
                    DirectionId = Guid.Parse("0efe92d1-4959-4cf5-8969-56bce0e8558c"),
                    Name = "93180"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("fdc3519e-1e1b-4c30-909f-89872df9aab4"),
                    DirectionId = Guid.Parse("0efe92d1-4959-4cf5-8969-56bce0e8558c"),
                    Name = "931802"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("06808fe5-9a1f-46d6-be33-46ee2554a185"),
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
                    Id = Guid.Parse("db6ffaaf-ac89-41cc-9e05-bb27942fc255"),
                    DirectionId = Guid.Parse("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"),
                    Name = "93190"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("b4c4b62f-9530-4f18-84e9-05ec8b254076"),
                    DirectionId = Guid.Parse("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"),
                    Name = "931901"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("7725cdb7-17cd-430a-90be-56efb1c25b9c"),
                    DirectionId = Guid.Parse("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"),
                    Name = "931902"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("a46d545a-6367-4ecc-a667-d7b197e7e130"),
                    DirectionId = Guid.Parse("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"),
                    Name = "931903"
                },

                //Library and Information Activities
                new GroupEntity
                {
                    Id = Guid.Parse("5290a552-09dd-499b-af03-700b898e89e2"),
                    DirectionId = Guid.Parse("fa2a6596-0f78-42c8-8f3f-56430aa50087"),
                    Name = "93200"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("ddd9e772-9cf6-401a-9cc5-33bfc63ae010"),
                    DirectionId = Guid.Parse("fa2a6596-0f78-42c8-8f3f-56430aa50087"),
                    Name = "93201"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("a5403b73-62c8-4c36-9921-2986fb3c107b"),
                    DirectionId = Guid.Parse("fa2a6596-0f78-42c8-8f3f-56430aa50087"),
                    Name = "93202"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("b71701e8-361a-4d91-a661-6942b7a2cca1"),
                    DirectionId = Guid.Parse("fa2a6596-0f78-42c8-8f3f-56430aa50087"),
                    Name = "93203"
                },


                //Astronomy and Space Geodesy
                new GroupEntity
                {
                    Id = Guid.Parse("7f4c4a85-799f-44d8-ad90-dca1da9d1a96"),
                    DirectionId = Guid.Parse("fb92cb9d-c54c-4882-8a84-d357392586b7"),
                    Name = "122001"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("1c09799d-904a-4e2f-9d5f-6535f83ef4b8"),
                    DirectionId = Guid.Parse("fb92cb9d-c54c-4882-8a84-d357392586b7"),
                    Name = "122002"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("9e74ca38-96a8-4af5-aaeb-002b5e1f3599"),
                    DirectionId = Guid.Parse("fb92cb9d-c54c-4882-8a84-d357392586b7"),
                    Name = "122003"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("4d46156f-7e51-47ea-b795-3f0c2d8a10b7"),
                    DirectionId = Guid.Parse("fb92cb9d-c54c-4882-8a84-d357392586b7"),
                    Name = "122004"
                },

                //Quantum Field Theory
                new GroupEntity
                {
                    Id = Guid.Parse("129fd25d-edf9-411e-8b20-d36bf904957b"),
                    DirectionId = Guid.Parse("46c6bba6-91be-4b95-b9c9-812fbdce601e"),
                    Name = "121901"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("86b80b67-14e7-4954-8e1d-972c73e44235"),
                    DirectionId = Guid.Parse("46c6bba6-91be-4b95-b9c9-812fbdce601e"),
                    Name = "121902"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("e1fdc8b3-8047-4087-a2c5-1ca79446b8d2"),
                    DirectionId = Guid.Parse("46c6bba6-91be-4b95-b9c9-812fbdce601e"),
                    Name = "121903"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("1faa2450-cf27-48b9-8626-f2135a08f606"),
                    DirectionId = Guid.Parse("46c6bba6-91be-4b95-b9c9-812fbdce601e"),
                    Name = "121904"
                },

                //General and Experimental Physics
                new GroupEntity
                {
                    Id = Guid.Parse("4cb1a0ae-b7d9-4cbc-8c93-4489bdfd7cda"),
                    DirectionId = Guid.Parse("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"),
                    Name = "24200"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("f9fced79-70b6-4ef0-b059-7548cd6cb491"),
                    DirectionId = Guid.Parse("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"),
                    Name = "24201"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("2566b128-cc7a-4b94-a3a4-19872999ef43"),
                    DirectionId = Guid.Parse("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"),
                    Name = "24202"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("1ada8e8d-fe48-4ea2-af87-714b00dac914"),
                    DirectionId = Guid.Parse("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"),
                    Name = "24203"
                },

                //Optics and Spectroscopy
                new GroupEntity
                {
                    Id = Guid.Parse("2190b991-f0f8-41fe-81bc-f6cf8f8dfd37"),
                    DirectionId = Guid.Parse("f1db86a1-2647-44ff-81df-6e4781239dcc"),
                    Name = "24301"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("86c6eee1-a591-4933-9c10-4c26db8de2ef"),
                    DirectionId = Guid.Parse("f1db86a1-2647-44ff-81df-6e4781239dcc"),
                    Name = "24302"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("1ddedb89-1269-402c-b860-b29fd56d7f5d"),
                    DirectionId = Guid.Parse("f1db86a1-2647-44ff-81df-6e4781239dcc"),
                    Name = "24303"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("1a4bd82f-b1f1-4a3c-ae90-11e4871d7630"),
                    DirectionId = Guid.Parse("f1db86a1-2647-44ff-81df-6e4781239dcc"),
                    Name = "24304"
                },

                //Radiophysics
                new GroupEntity
                {
                    Id = Guid.Parse("f6b933a0-b715-40c5-8640-113fcaacb996"),
                    DirectionId = Guid.Parse("435557fa-35a0-4f35-9efa-7aba31755b46"),
                    Name = "25301"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("c91ae9e0-0b7e-4ec8-936b-450bde57a01d"),
                    DirectionId = Guid.Parse("435557fa-35a0-4f35-9efa-7aba31755b46"),
                    Name = "25302"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("939cee3d-00d0-452a-b727-bbedc1cd10ba"),
                    DirectionId = Guid.Parse("435557fa-35a0-4f35-9efa-7aba31755b46"),
                    Name = "25303"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("e5a9ade9-7a00-4d12-894f-a5bd991a4273"),
                    DirectionId = Guid.Parse("435557fa-35a0-4f35-9efa-7aba31755b46"),
                    Name = "25304"
                },

                //Radio electronics
                new GroupEntity
                {
                    Id = Guid.Parse("bcfd2592-c830-431d-9cc8-ee99ea0f6062"),
                    DirectionId = Guid.Parse("bc4dd321-36ee-4050-905e-b1aa3fa01182"),
                    Name = "30001"
                },
                new GroupEntity
                {
                    Id = Guid.Parse("63d7a7f2-a1ad-47f0-9e98-49adf64a7bdb"),
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

        }
    }
}
