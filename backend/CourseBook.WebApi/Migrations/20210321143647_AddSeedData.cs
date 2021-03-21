using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseBook.WebApi.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_directions_faculties_faculty_id",
                table: "directions");

            migrationBuilder.DropForeignKey(
                name: "FK_directions_disciplines_directions_direction_id",
                table: "directions_disciplines");

            migrationBuilder.DropForeignKey(
                name: "FK_directions_disciplines_disciplines_discipline_id",
                table: "directions_disciplines");

            migrationBuilder.DropForeignKey(
                name: "FK_groups_directions_direction_id",
                table: "groups");

            migrationBuilder.DropForeignKey(
                name: "FK_groups_disciplines_disciplines_discipline_id",
                table: "groups_disciplines");

            migrationBuilder.DropForeignKey(
                name: "FK_groups_disciplines_groups_group_id",
                table: "groups_disciplines");

            migrationBuilder.DropIndex(
                name: "IX_groups_disciplines_discipline_id",
                table: "groups_disciplines");

            migrationBuilder.DropIndex(
                name: "IX_groups_disciplines_group_id",
                table: "groups_disciplines");

            migrationBuilder.DropIndex(
                name: "IX_groups_direction_id",
                table: "groups");

            migrationBuilder.DropIndex(
                name: "IX_directions_disciplines_direction_id",
                table: "directions_disciplines");

            migrationBuilder.DropIndex(
                name: "IX_directions_disciplines_discipline_id",
                table: "directions_disciplines");

            migrationBuilder.DropIndex(
                name: "IX_directions_faculty_id",
                table: "directions");

            migrationBuilder.DropColumn(
                name: "discipline_id",
                table: "groups_disciplines");

            migrationBuilder.DropColumn(
                name: "group_id",
                table: "groups_disciplines");

            migrationBuilder.DropColumn(
                name: "direction_id",
                table: "groups");

            migrationBuilder.DropColumn(
                name: "direction_id",
                table: "directions_disciplines");

            migrationBuilder.DropColumn(
                name: "discipline_id",
                table: "directions_disciplines");

            migrationBuilder.DropColumn(
                name: "faculty_id",
                table: "directions");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "faculties",
                newName: "Name");

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[,]
                {
                    { new Guid("986d7006-65c4-4246-b99a-2d390e1ae4f7"), null, "Art history" },
                    { new Guid("0af79477-a80e-4eb6-b156-97bc4cb47315"), null, "Microprocessors" },
                    { new Guid("a5f99e5d-a6a6-4a15-96b0-b2c3f54ce06c"), null, "Electronics" },
                    { new Guid("1faf9ce2-d392-4097-af23-2d962b90e9d6"), null, "Optics Basics" },
                    { new Guid("ac542825-f958-4103-91ec-89e6363f0d43"), null, "Military training" },
                    { new Guid("7131c3a2-4bc4-4195-859a-f5af9bd7d144"), null, "	Mobile communication systems" },
                    { new Guid("9f160c04-c98b-4d58-a631-cdec4a04e316"), null, "Metrology" },
                    { new Guid("fef757f5-8653-4ac3-814d-b60af590ce5a"), null, "Digital spectral analysis of signals and fields" },
                    { new Guid("075486bf-0147-4bf7-97ca-e83191675bfb"), null, "	Standardization and certification" },
                    { new Guid("96cd27bd-dcff-496b-9984-4489b11a2712"), null, "Waveguide Photonics" },
                    { new Guid("b46cc5bc-6fc4-4f1e-9b2a-ff68b3f1234d"), null, "Atomic and Nuclear Physics" },
                    { new Guid("3ac05f7b-8ee9-4bf5-a37b-692eb9670c35"), null, "Elective disciplines in physical culture and sports" },
                    { new Guid("96e8af39-7453-49cb-af5a-28d1e64e001a"), null, "Foreign language" },
                    { new Guid("aad3f967-7158-46ca-9b8a-405581f207a4"), null, "Study Practice" },
                    { new Guid("65830d5c-c0b3-46b6-8bea-b3dd2ce6e1dd"), null, "Foreign language" },
                    { new Guid("54f742d3-a89d-4e4a-bd39-d233e0c34395"), null, "Quantum chemistry" },
                    { new Guid("27bedee0-3b3e-4ab2-9bab-7f910ea12df2"), null, "Pedagogy" },
                    { new Guid("f3a05565-4293-47b4-8799-78a7e0d8787f"), null, "Polymer solutions" },
                    { new Guid("abc7d661-c1c4-4bd7-b767-d88ce7b748e5"), null, "Chemical modification of polymers" },
                    { new Guid("7798ec77-2078-410b-9a47-3ecb1f17b100"), null, "Chemical foundations of biological processes" },
                    { new Guid("5f926e12-86e0-4c9f-9f99-734ef39575ca"), null, "Polymer synthesis methods" },
                    { new Guid("0a89c092-a7df-4570-b7a4-1042d4a08b04"), null, "Analysis of the quality of hydrocarbon raw materials and products of its processing" },
                    { new Guid("579e5d9d-cf33-41d4-a172-56853419f169"), null, "Theoretical foundations of oil refining" },
                    { new Guid("c43c64b6-d37d-44b6-a6cc-ad890e942b1b"), null, "Methods for the transmission of scientific information" },
                    { new Guid("ff28aa68-df77-4829-a2ce-f322d4b15a2b"), null, "Theoretical foundations of oil refining" },
                    { new Guid("e55051fc-17a6-41ec-b76e-fe6d98a15058"), null, "Analytical chemistry" },
                    { new Guid("2f9785fd-34f2-47dd-8b5b-e520047213fb"), null, "Physics" },
                    { new Guid("f532bb4b-725b-4b00-8643-a335a4c3fe2f"), null, "Mathematical analysis" },
                    { new Guid("4bd00c26-498f-439e-b269-5052091dc53f"), null, "Biomedical laser technology" },
                    { new Guid("b0a130ae-8d09-4cec-8814-24c811028771"), null, "Composition" },
                    { new Guid("fee99c99-831c-4f29-acd0-5eb5ad0ca7e2"), null, "Sociology of media" },
                    { new Guid("d12b6e66-e758-48ca-af31-102aa991bdc0"), null, "History of material culture" },
                    { new Guid("0142a5ca-e2ab-423a-a03f-d2c3092a0339"), null, "Information law" },
                    { new Guid("09da399f-d269-4333-b3a9-c7203dee1a01"), null, "Copyright" },
                    { new Guid("d4e27800-46bd-48d4-b320-92380548f689"), null, "Quantitative methods in scientific research" },
                    { new Guid("f333c6ac-530c-4092-8160-a336bafb4d6c"), null, "Strategic management in the library" },
                    { new Guid("8e518999-5273-4789-9978-dac4baa4e74c"), null, "Foreign language" },
                    { new Guid("e1de5ca1-58dd-4a15-8544-0b370db9f2bb"), null, "Academic writing" },
                    { new Guid("f5a8d4f5-a85c-4141-be24-7ba4d2bae6ce"), null, "Museology, conservation and restoration of historical and cultural objects" },
                    { new Guid("1b773c45-0a73-43f9-94d6-af576c52cf9f"), null, "Modern problems of physics of the microworld and cosmology" },
                    { new Guid("eeccea9a-ebaa-4660-b2f2-8fad550b38bb"), null, "Linear Algebra" },
                    { new Guid("5687210f-0fe3-4111-b0c6-a4764c3ad27c"), null, "Waves and layers in plasma" },
                    { new Guid("5b63a570-f5b2-47e7-8b2f-a79ca090797a"), null, "Foreign language in the field of professional communication" },
                    { new Guid("45a4ac18-d257-4bbf-8c90-959c5222aecf"), null, "Military training" },
                    { new Guid("a02c08b7-bd53-43e7-8a83-ead1185fbdd0"), null, "Information systems design" },
                    { new Guid("db2a6fec-1be3-4e5a-9dc2-71e0104c150d"), null, "Laboratories specializing in satellite dynamics" },
                    { new Guid("211181c7-ef7c-4de0-b382-70e0eb9c89d3"), null, "Global Positioning Technologies" },
                    { new Guid("d6b13c5b-cabf-4034-af31-f3c30d344393"), null, "Modern problems of physics of the microworld and cosmology" },
                    { new Guid("ad97d079-2037-4dd7-abfd-f23befa01df2"), null, "Physics of intermolecular interactions" },
                    { new Guid("d80697b7-aa62-49e2-86e8-2a83e2e71004"), null, "The theory of elementary particles" },
                    { new Guid("9fe893d9-19e8-4ca5-99a1-09c165918e8b"), null, "Topical issues of theory and teaching methods in physics" },
                    { new Guid("bc5bc711-5718-4b9c-a6cf-3d08a00f157c"), null, "Fundamentals of Atomic and Molecular Spectroscopy" },
                    { new Guid("bf026a3f-9e2a-4506-a411-8bda85002c36"), null, "Foreign language in the field of professional communication" },
                    { new Guid("4f4ffe1d-b54c-45f7-9e34-a0cc26df4ddd"), null, "Analysis of complex biophysical signals" },
                    { new Guid("bc957929-f744-4315-a4ed-08530c7f0f3e"), null, "Plasma physics problems" }
                });

            migrationBuilder.InsertData(
                table: "faculties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("b0d09040-c5ea-492d-936f-488b9f3115a2"), "Faculty of Radiophysics" },
                    { new Guid("6b3957c3-d16e-4620-8d2c-b26239a7a2a8"), "Institute of Arts and Culture" },
                    { new Guid("e05d5966-b197-4bd1-92d4-800f66b352fe"), "Faculty of Physics" },
                    { new Guid("4a823069-9673-403c-8ea0-59b225e5491c"), "Faculty of Chemistry" }
                });

            migrationBuilder.InsertData(
                table: "directions",
                columns: new[] { "Id", "FacultyId", "Name" },
                values: new object[,]
                {
                    { new Guid("aaa504f9-b3ad-4854-9820-90cdcbd27322"), new Guid("6b3957c3-d16e-4620-8d2c-b26239a7a2a8"), "Culturology" },
                    { new Guid("0efe92d1-4959-4cf5-8969-56bce0e8558c"), new Guid("6b3957c3-d16e-4620-8d2c-b26239a7a2a8"), "Pedagogy" },
                    { new Guid("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"), new Guid("6b3957c3-d16e-4620-8d2c-b26239a7a2a8"), "Design" },
                    { new Guid("fa2a6596-0f78-42c8-8f3f-56430aa50087"), new Guid("6b3957c3-d16e-4620-8d2c-b26239a7a2a8"), "Library and Information Activities" },
                    { new Guid("fb92cb9d-c54c-4882-8a84-d357392586b7"), new Guid("e05d5966-b197-4bd1-92d4-800f66b352fe"), "Astronomy and Space Geodesy" },
                    { new Guid("46c6bba6-91be-4b95-b9c9-812fbdce601e"), new Guid("e05d5966-b197-4bd1-92d4-800f66b352fe"), "Quantum Field Theory" },
                    { new Guid("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"), new Guid("e05d5966-b197-4bd1-92d4-800f66b352fe"), "General and Experimental Physics" },
                    { new Guid("f1db86a1-2647-44ff-81df-6e4781239dcc"), new Guid("e05d5966-b197-4bd1-92d4-800f66b352fe"), "Optics and Spectroscopy" },
                    { new Guid("435557fa-35a0-4f35-9efa-7aba31755b46"), new Guid("b0d09040-c5ea-492d-936f-488b9f3115a2"), "Radiophysics" },
                    { new Guid("bc4dd321-36ee-4050-905e-b1aa3fa01182"), new Guid("b0d09040-c5ea-492d-936f-488b9f3115a2"), "Radio electronics" },
                    { new Guid("ae4d9db2-9358-4a51-9928-888d5338a78e"), new Guid("b0d09040-c5ea-492d-936f-488b9f3115a2"), "Semiconductor Electronics" },
                    { new Guid("de2a66b0-56ea-44e3-b202-c1b4754b1721"), new Guid("b0d09040-c5ea-492d-936f-488b9f3115a2"), "Optoelectronic systems and remote sensing" },
                    { new Guid("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"), new Guid("4a823069-9673-403c-8ea0-59b225e5491c"), "Analytical Chemistry" },
                    { new Guid("37dd1e11-b958-45ef-ab51-09650b3d43d4"), new Guid("4a823069-9673-403c-8ea0-59b225e5491c"), "Macromolecular compounds" },
                    { new Guid("afdfcc0a-ffdd-41e1-ab01-a712574e289a"), new Guid("4a823069-9673-403c-8ea0-59b225e5491c"), "Petrochemistry" },
                    { new Guid("70b17a41-5128-4bde-83dd-f727554ea6b0"), new Guid("4a823069-9673-403c-8ea0-59b225e5491c"), "Physical chemistry" }
                });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[,]
                {
                    { new Guid("aaa504f9-b3ad-4854-9820-90cdcbd27322"), new Guid("986d7006-65c4-4246-b99a-2d390e1ae4f7") },
                    { new Guid("435557fa-35a0-4f35-9efa-7aba31755b46"), new Guid("f532bb4b-725b-4b00-8643-a335a4c3fe2f") },
                    { new Guid("435557fa-35a0-4f35-9efa-7aba31755b46"), new Guid("96e8af39-7453-49cb-af5a-28d1e64e001a") },
                    { new Guid("bc4dd321-36ee-4050-905e-b1aa3fa01182"), new Guid("0af79477-a80e-4eb6-b156-97bc4cb47315") },
                    { new Guid("bc4dd321-36ee-4050-905e-b1aa3fa01182"), new Guid("a5f99e5d-a6a6-4a15-96b0-b2c3f54ce06c") },
                    { new Guid("bc4dd321-36ee-4050-905e-b1aa3fa01182"), new Guid("1faf9ce2-d392-4097-af23-2d962b90e9d6") },
                    { new Guid("bc4dd321-36ee-4050-905e-b1aa3fa01182"), new Guid("ac542825-f958-4103-91ec-89e6363f0d43") },
                    { new Guid("ae4d9db2-9358-4a51-9928-888d5338a78e"), new Guid("7131c3a2-4bc4-4195-859a-f5af9bd7d144") },
                    { new Guid("ae4d9db2-9358-4a51-9928-888d5338a78e"), new Guid("9f160c04-c98b-4d58-a631-cdec4a04e316") },
                    { new Guid("ae4d9db2-9358-4a51-9928-888d5338a78e"), new Guid("fef757f5-8653-4ac3-814d-b60af590ce5a") },
                    { new Guid("ae4d9db2-9358-4a51-9928-888d5338a78e"), new Guid("075486bf-0147-4bf7-97ca-e83191675bfb") },
                    { new Guid("de2a66b0-56ea-44e3-b202-c1b4754b1721"), new Guid("96cd27bd-dcff-496b-9984-4489b11a2712") },
                    { new Guid("435557fa-35a0-4f35-9efa-7aba31755b46"), new Guid("2f9785fd-34f2-47dd-8b5b-e520047213fb") },
                    { new Guid("de2a66b0-56ea-44e3-b202-c1b4754b1721"), new Guid("b46cc5bc-6fc4-4f1e-9b2a-ff68b3f1234d") },
                    { new Guid("de2a66b0-56ea-44e3-b202-c1b4754b1721"), new Guid("aad3f967-7158-46ca-9b8a-405581f207a4") },
                    { new Guid("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"), new Guid("e55051fc-17a6-41ec-b76e-fe6d98a15058") },
                    { new Guid("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"), new Guid("65830d5c-c0b3-46b6-8bea-b3dd2ce6e1dd") },
                    { new Guid("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"), new Guid("54f742d3-a89d-4e4a-bd39-d233e0c34395") },
                    { new Guid("37dd1e11-b958-45ef-ab51-09650b3d43d4"), new Guid("27bedee0-3b3e-4ab2-9bab-7f910ea12df2") },
                    { new Guid("37dd1e11-b958-45ef-ab51-09650b3d43d4"), new Guid("f3a05565-4293-47b4-8799-78a7e0d8787f") },
                    { new Guid("37dd1e11-b958-45ef-ab51-09650b3d43d4"), new Guid("abc7d661-c1c4-4bd7-b767-d88ce7b748e5") },
                    { new Guid("afdfcc0a-ffdd-41e1-ab01-a712574e289a"), new Guid("7798ec77-2078-410b-9a47-3ecb1f17b100") },
                    { new Guid("afdfcc0a-ffdd-41e1-ab01-a712574e289a"), new Guid("5f926e12-86e0-4c9f-9f99-734ef39575ca") },
                    { new Guid("afdfcc0a-ffdd-41e1-ab01-a712574e289a"), new Guid("0a89c092-a7df-4570-b7a4-1042d4a08b04") },
                    { new Guid("70b17a41-5128-4bde-83dd-f727554ea6b0"), new Guid("579e5d9d-cf33-41d4-a172-56853419f169") },
                    { new Guid("de2a66b0-56ea-44e3-b202-c1b4754b1721"), new Guid("3ac05f7b-8ee9-4bf5-a37b-692eb9670c35") },
                    { new Guid("70b17a41-5128-4bde-83dd-f727554ea6b0"), new Guid("c43c64b6-d37d-44b6-a6cc-ad890e942b1b") },
                    { new Guid("435557fa-35a0-4f35-9efa-7aba31755b46"), new Guid("eeccea9a-ebaa-4660-b2f2-8fad550b38bb") },
                    { new Guid("f1db86a1-2647-44ff-81df-6e4781239dcc"), new Guid("4f4ffe1d-b54c-45f7-9e34-a0cc26df4ddd") },
                    { new Guid("aaa504f9-b3ad-4854-9820-90cdcbd27322"), new Guid("b0a130ae-8d09-4cec-8814-24c811028771") },
                    { new Guid("aaa504f9-b3ad-4854-9820-90cdcbd27322"), new Guid("fee99c99-831c-4f29-acd0-5eb5ad0ca7e2") },
                    { new Guid("aaa504f9-b3ad-4854-9820-90cdcbd27322"), new Guid("d12b6e66-e758-48ca-af31-102aa991bdc0") },
                    { new Guid("0efe92d1-4959-4cf5-8969-56bce0e8558c"), new Guid("0142a5ca-e2ab-423a-a03f-d2c3092a0339") },
                    { new Guid("0efe92d1-4959-4cf5-8969-56bce0e8558c"), new Guid("09da399f-d269-4333-b3a9-c7203dee1a01") },
                    { new Guid("0efe92d1-4959-4cf5-8969-56bce0e8558c"), new Guid("d4e27800-46bd-48d4-b320-92380548f689") },
                    { new Guid("0efe92d1-4959-4cf5-8969-56bce0e8558c"), new Guid("f333c6ac-530c-4092-8160-a336bafb4d6c") },
                    { new Guid("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"), new Guid("8e518999-5273-4789-9978-dac4baa4e74c") },
                    { new Guid("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"), new Guid("e1de5ca1-58dd-4a15-8544-0b370db9f2bb") },
                    { new Guid("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"), new Guid("f5a8d4f5-a85c-4141-be24-7ba4d2bae6ce") },
                    { new Guid("fb92cb9d-c54c-4882-8a84-d357392586b7"), new Guid("1b773c45-0a73-43f9-94d6-af576c52cf9f") },
                    { new Guid("f1db86a1-2647-44ff-81df-6e4781239dcc"), new Guid("4bd00c26-498f-439e-b269-5052091dc53f") },
                    { new Guid("fb92cb9d-c54c-4882-8a84-d357392586b7"), new Guid("5b63a570-f5b2-47e7-8b2f-a79ca090797a") },
                    { new Guid("fb92cb9d-c54c-4882-8a84-d357392586b7"), new Guid("bc957929-f744-4315-a4ed-08530c7f0f3e") },
                    { new Guid("46c6bba6-91be-4b95-b9c9-812fbdce601e"), new Guid("45a4ac18-d257-4bbf-8c90-959c5222aecf") },
                    { new Guid("46c6bba6-91be-4b95-b9c9-812fbdce601e"), new Guid("a02c08b7-bd53-43e7-8a83-ead1185fbdd0") },
                    { new Guid("46c6bba6-91be-4b95-b9c9-812fbdce601e"), new Guid("db2a6fec-1be3-4e5a-9dc2-71e0104c150d") },
                    { new Guid("46c6bba6-91be-4b95-b9c9-812fbdce601e"), new Guid("211181c7-ef7c-4de0-b382-70e0eb9c89d3") },
                    { new Guid("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"), new Guid("d6b13c5b-cabf-4034-af31-f3c30d344393") },
                    { new Guid("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"), new Guid("ad97d079-2037-4dd7-abfd-f23befa01df2") },
                    { new Guid("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"), new Guid("d80697b7-aa62-49e2-86e8-2a83e2e71004") },
                    { new Guid("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"), new Guid("9fe893d9-19e8-4ca5-99a1-09c165918e8b") },
                    { new Guid("f1db86a1-2647-44ff-81df-6e4781239dcc"), new Guid("bc5bc711-5718-4b9c-a6cf-3d08a00f157c") },
                    { new Guid("f1db86a1-2647-44ff-81df-6e4781239dcc"), new Guid("bf026a3f-9e2a-4506-a411-8bda85002c36") },
                    { new Guid("fb92cb9d-c54c-4882-8a84-d357392586b7"), new Guid("5687210f-0fe3-4111-b0c6-a4764c3ad27c") },
                    { new Guid("70b17a41-5128-4bde-83dd-f727554ea6b0"), new Guid("ff28aa68-df77-4829-a2ce-f322d4b15a2b") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_groups_disciplines_DisciplineId",
                table: "groups_disciplines",
                column: "DisciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_groups_DirectionId",
                table: "groups",
                column: "DirectionId");

            migrationBuilder.CreateIndex(
                name: "IX_directions_disciplines_DisciplineId",
                table: "directions_disciplines",
                column: "DisciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_directions_FacultyId",
                table: "directions",
                column: "FacultyId");

            migrationBuilder.AddForeignKey(
                name: "FK_directions_faculties_FacultyId",
                table: "directions",
                column: "FacultyId",
                principalTable: "faculties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_directions_disciplines_directions_DirectionId",
                table: "directions_disciplines",
                column: "DirectionId",
                principalTable: "directions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_directions_disciplines_disciplines_DisciplineId",
                table: "directions_disciplines",
                column: "DisciplineId",
                principalTable: "disciplines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_groups_directions_DirectionId",
                table: "groups",
                column: "DirectionId",
                principalTable: "directions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_groups_disciplines_disciplines_DisciplineId",
                table: "groups_disciplines",
                column: "DisciplineId",
                principalTable: "disciplines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_groups_disciplines_groups_GroupId",
                table: "groups_disciplines",
                column: "GroupId",
                principalTable: "groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_directions_faculties_FacultyId",
                table: "directions");

            migrationBuilder.DropForeignKey(
                name: "FK_directions_disciplines_directions_DirectionId",
                table: "directions_disciplines");

            migrationBuilder.DropForeignKey(
                name: "FK_directions_disciplines_disciplines_DisciplineId",
                table: "directions_disciplines");

            migrationBuilder.DropForeignKey(
                name: "FK_groups_directions_DirectionId",
                table: "groups");

            migrationBuilder.DropForeignKey(
                name: "FK_groups_disciplines_disciplines_DisciplineId",
                table: "groups_disciplines");

            migrationBuilder.DropForeignKey(
                name: "FK_groups_disciplines_groups_GroupId",
                table: "groups_disciplines");

            migrationBuilder.DropIndex(
                name: "IX_groups_disciplines_DisciplineId",
                table: "groups_disciplines");

            migrationBuilder.DropIndex(
                name: "IX_groups_DirectionId",
                table: "groups");

            migrationBuilder.DropIndex(
                name: "IX_directions_disciplines_DisciplineId",
                table: "directions_disciplines");

            migrationBuilder.DropIndex(
                name: "IX_directions_FacultyId",
                table: "directions");

            migrationBuilder.DeleteData(
                table: "directions",
                keyColumn: "Id",
                keyValue: new Guid("fa2a6596-0f78-42c8-8f3f-56430aa50087"));

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("0efe92d1-4959-4cf5-8969-56bce0e8558c"), new Guid("0142a5ca-e2ab-423a-a03f-d2c3092a0339") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("0efe92d1-4959-4cf5-8969-56bce0e8558c"), new Guid("09da399f-d269-4333-b3a9-c7203dee1a01") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("0efe92d1-4959-4cf5-8969-56bce0e8558c"), new Guid("d4e27800-46bd-48d4-b320-92380548f689") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("0efe92d1-4959-4cf5-8969-56bce0e8558c"), new Guid("f333c6ac-530c-4092-8160-a336bafb4d6c") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("37dd1e11-b958-45ef-ab51-09650b3d43d4"), new Guid("27bedee0-3b3e-4ab2-9bab-7f910ea12df2") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("37dd1e11-b958-45ef-ab51-09650b3d43d4"), new Guid("abc7d661-c1c4-4bd7-b767-d88ce7b748e5") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("37dd1e11-b958-45ef-ab51-09650b3d43d4"), new Guid("f3a05565-4293-47b4-8799-78a7e0d8787f") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("435557fa-35a0-4f35-9efa-7aba31755b46"), new Guid("2f9785fd-34f2-47dd-8b5b-e520047213fb") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("435557fa-35a0-4f35-9efa-7aba31755b46"), new Guid("96e8af39-7453-49cb-af5a-28d1e64e001a") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("435557fa-35a0-4f35-9efa-7aba31755b46"), new Guid("eeccea9a-ebaa-4660-b2f2-8fad550b38bb") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("435557fa-35a0-4f35-9efa-7aba31755b46"), new Guid("f532bb4b-725b-4b00-8643-a335a4c3fe2f") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("46c6bba6-91be-4b95-b9c9-812fbdce601e"), new Guid("211181c7-ef7c-4de0-b382-70e0eb9c89d3") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("46c6bba6-91be-4b95-b9c9-812fbdce601e"), new Guid("45a4ac18-d257-4bbf-8c90-959c5222aecf") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("46c6bba6-91be-4b95-b9c9-812fbdce601e"), new Guid("a02c08b7-bd53-43e7-8a83-ead1185fbdd0") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("46c6bba6-91be-4b95-b9c9-812fbdce601e"), new Guid("db2a6fec-1be3-4e5a-9dc2-71e0104c150d") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("70b17a41-5128-4bde-83dd-f727554ea6b0"), new Guid("579e5d9d-cf33-41d4-a172-56853419f169") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("70b17a41-5128-4bde-83dd-f727554ea6b0"), new Guid("c43c64b6-d37d-44b6-a6cc-ad890e942b1b") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("70b17a41-5128-4bde-83dd-f727554ea6b0"), new Guid("ff28aa68-df77-4829-a2ce-f322d4b15a2b") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"), new Guid("8e518999-5273-4789-9978-dac4baa4e74c") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"), new Guid("e1de5ca1-58dd-4a15-8544-0b370db9f2bb") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"), new Guid("f5a8d4f5-a85c-4141-be24-7ba4d2bae6ce") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("aaa504f9-b3ad-4854-9820-90cdcbd27322"), new Guid("986d7006-65c4-4246-b99a-2d390e1ae4f7") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("aaa504f9-b3ad-4854-9820-90cdcbd27322"), new Guid("b0a130ae-8d09-4cec-8814-24c811028771") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("aaa504f9-b3ad-4854-9820-90cdcbd27322"), new Guid("d12b6e66-e758-48ca-af31-102aa991bdc0") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("aaa504f9-b3ad-4854-9820-90cdcbd27322"), new Guid("fee99c99-831c-4f29-acd0-5eb5ad0ca7e2") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("ae4d9db2-9358-4a51-9928-888d5338a78e"), new Guid("075486bf-0147-4bf7-97ca-e83191675bfb") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("ae4d9db2-9358-4a51-9928-888d5338a78e"), new Guid("7131c3a2-4bc4-4195-859a-f5af9bd7d144") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("ae4d9db2-9358-4a51-9928-888d5338a78e"), new Guid("9f160c04-c98b-4d58-a631-cdec4a04e316") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("ae4d9db2-9358-4a51-9928-888d5338a78e"), new Guid("fef757f5-8653-4ac3-814d-b60af590ce5a") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("afdfcc0a-ffdd-41e1-ab01-a712574e289a"), new Guid("0a89c092-a7df-4570-b7a4-1042d4a08b04") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("afdfcc0a-ffdd-41e1-ab01-a712574e289a"), new Guid("5f926e12-86e0-4c9f-9f99-734ef39575ca") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("afdfcc0a-ffdd-41e1-ab01-a712574e289a"), new Guid("7798ec77-2078-410b-9a47-3ecb1f17b100") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("bc4dd321-36ee-4050-905e-b1aa3fa01182"), new Guid("0af79477-a80e-4eb6-b156-97bc4cb47315") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("bc4dd321-36ee-4050-905e-b1aa3fa01182"), new Guid("1faf9ce2-d392-4097-af23-2d962b90e9d6") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("bc4dd321-36ee-4050-905e-b1aa3fa01182"), new Guid("a5f99e5d-a6a6-4a15-96b0-b2c3f54ce06c") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("bc4dd321-36ee-4050-905e-b1aa3fa01182"), new Guid("ac542825-f958-4103-91ec-89e6363f0d43") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"), new Guid("9fe893d9-19e8-4ca5-99a1-09c165918e8b") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"), new Guid("ad97d079-2037-4dd7-abfd-f23befa01df2") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"), new Guid("d6b13c5b-cabf-4034-af31-f3c30d344393") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"), new Guid("d80697b7-aa62-49e2-86e8-2a83e2e71004") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("de2a66b0-56ea-44e3-b202-c1b4754b1721"), new Guid("3ac05f7b-8ee9-4bf5-a37b-692eb9670c35") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("de2a66b0-56ea-44e3-b202-c1b4754b1721"), new Guid("96cd27bd-dcff-496b-9984-4489b11a2712") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("de2a66b0-56ea-44e3-b202-c1b4754b1721"), new Guid("aad3f967-7158-46ca-9b8a-405581f207a4") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("de2a66b0-56ea-44e3-b202-c1b4754b1721"), new Guid("b46cc5bc-6fc4-4f1e-9b2a-ff68b3f1234d") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"), new Guid("54f742d3-a89d-4e4a-bd39-d233e0c34395") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"), new Guid("65830d5c-c0b3-46b6-8bea-b3dd2ce6e1dd") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"), new Guid("e55051fc-17a6-41ec-b76e-fe6d98a15058") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("f1db86a1-2647-44ff-81df-6e4781239dcc"), new Guid("4bd00c26-498f-439e-b269-5052091dc53f") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("f1db86a1-2647-44ff-81df-6e4781239dcc"), new Guid("4f4ffe1d-b54c-45f7-9e34-a0cc26df4ddd") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("f1db86a1-2647-44ff-81df-6e4781239dcc"), new Guid("bc5bc711-5718-4b9c-a6cf-3d08a00f157c") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("f1db86a1-2647-44ff-81df-6e4781239dcc"), new Guid("bf026a3f-9e2a-4506-a411-8bda85002c36") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("fb92cb9d-c54c-4882-8a84-d357392586b7"), new Guid("1b773c45-0a73-43f9-94d6-af576c52cf9f") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("fb92cb9d-c54c-4882-8a84-d357392586b7"), new Guid("5687210f-0fe3-4111-b0c6-a4764c3ad27c") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("fb92cb9d-c54c-4882-8a84-d357392586b7"), new Guid("5b63a570-f5b2-47e7-8b2f-a79ca090797a") });

            migrationBuilder.DeleteData(
                table: "directions_disciplines",
                keyColumns: new[] { "DirectionId", "DisciplineId" },
                keyValues: new object[] { new Guid("fb92cb9d-c54c-4882-8a84-d357392586b7"), new Guid("bc957929-f744-4315-a4ed-08530c7f0f3e") });

            migrationBuilder.DeleteData(
                table: "directions",
                keyColumn: "Id",
                keyValue: new Guid("0efe92d1-4959-4cf5-8969-56bce0e8558c"));

            migrationBuilder.DeleteData(
                table: "directions",
                keyColumn: "Id",
                keyValue: new Guid("37dd1e11-b958-45ef-ab51-09650b3d43d4"));

            migrationBuilder.DeleteData(
                table: "directions",
                keyColumn: "Id",
                keyValue: new Guid("435557fa-35a0-4f35-9efa-7aba31755b46"));

            migrationBuilder.DeleteData(
                table: "directions",
                keyColumn: "Id",
                keyValue: new Guid("46c6bba6-91be-4b95-b9c9-812fbdce601e"));

            migrationBuilder.DeleteData(
                table: "directions",
                keyColumn: "Id",
                keyValue: new Guid("70b17a41-5128-4bde-83dd-f727554ea6b0"));

            migrationBuilder.DeleteData(
                table: "directions",
                keyColumn: "Id",
                keyValue: new Guid("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"));

            migrationBuilder.DeleteData(
                table: "directions",
                keyColumn: "Id",
                keyValue: new Guid("aaa504f9-b3ad-4854-9820-90cdcbd27322"));

            migrationBuilder.DeleteData(
                table: "directions",
                keyColumn: "Id",
                keyValue: new Guid("ae4d9db2-9358-4a51-9928-888d5338a78e"));

            migrationBuilder.DeleteData(
                table: "directions",
                keyColumn: "Id",
                keyValue: new Guid("afdfcc0a-ffdd-41e1-ab01-a712574e289a"));

            migrationBuilder.DeleteData(
                table: "directions",
                keyColumn: "Id",
                keyValue: new Guid("bc4dd321-36ee-4050-905e-b1aa3fa01182"));

            migrationBuilder.DeleteData(
                table: "directions",
                keyColumn: "Id",
                keyValue: new Guid("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"));

            migrationBuilder.DeleteData(
                table: "directions",
                keyColumn: "Id",
                keyValue: new Guid("de2a66b0-56ea-44e3-b202-c1b4754b1721"));

            migrationBuilder.DeleteData(
                table: "directions",
                keyColumn: "Id",
                keyValue: new Guid("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"));

            migrationBuilder.DeleteData(
                table: "directions",
                keyColumn: "Id",
                keyValue: new Guid("f1db86a1-2647-44ff-81df-6e4781239dcc"));

            migrationBuilder.DeleteData(
                table: "directions",
                keyColumn: "Id",
                keyValue: new Guid("fb92cb9d-c54c-4882-8a84-d357392586b7"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("0142a5ca-e2ab-423a-a03f-d2c3092a0339"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("075486bf-0147-4bf7-97ca-e83191675bfb"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("09da399f-d269-4333-b3a9-c7203dee1a01"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("0a89c092-a7df-4570-b7a4-1042d4a08b04"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("0af79477-a80e-4eb6-b156-97bc4cb47315"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("1b773c45-0a73-43f9-94d6-af576c52cf9f"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("1faf9ce2-d392-4097-af23-2d962b90e9d6"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("211181c7-ef7c-4de0-b382-70e0eb9c89d3"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("27bedee0-3b3e-4ab2-9bab-7f910ea12df2"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("2f9785fd-34f2-47dd-8b5b-e520047213fb"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("3ac05f7b-8ee9-4bf5-a37b-692eb9670c35"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("45a4ac18-d257-4bbf-8c90-959c5222aecf"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("4bd00c26-498f-439e-b269-5052091dc53f"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("4f4ffe1d-b54c-45f7-9e34-a0cc26df4ddd"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("54f742d3-a89d-4e4a-bd39-d233e0c34395"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("5687210f-0fe3-4111-b0c6-a4764c3ad27c"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("579e5d9d-cf33-41d4-a172-56853419f169"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("5b63a570-f5b2-47e7-8b2f-a79ca090797a"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("5f926e12-86e0-4c9f-9f99-734ef39575ca"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("65830d5c-c0b3-46b6-8bea-b3dd2ce6e1dd"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("7131c3a2-4bc4-4195-859a-f5af9bd7d144"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("7798ec77-2078-410b-9a47-3ecb1f17b100"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("8e518999-5273-4789-9978-dac4baa4e74c"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("96cd27bd-dcff-496b-9984-4489b11a2712"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("96e8af39-7453-49cb-af5a-28d1e64e001a"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("986d7006-65c4-4246-b99a-2d390e1ae4f7"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("9f160c04-c98b-4d58-a631-cdec4a04e316"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("9fe893d9-19e8-4ca5-99a1-09c165918e8b"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("a02c08b7-bd53-43e7-8a83-ead1185fbdd0"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("a5f99e5d-a6a6-4a15-96b0-b2c3f54ce06c"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("aad3f967-7158-46ca-9b8a-405581f207a4"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("abc7d661-c1c4-4bd7-b767-d88ce7b748e5"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("ac542825-f958-4103-91ec-89e6363f0d43"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("ad97d079-2037-4dd7-abfd-f23befa01df2"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("b0a130ae-8d09-4cec-8814-24c811028771"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("b46cc5bc-6fc4-4f1e-9b2a-ff68b3f1234d"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("bc5bc711-5718-4b9c-a6cf-3d08a00f157c"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("bc957929-f744-4315-a4ed-08530c7f0f3e"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("bf026a3f-9e2a-4506-a411-8bda85002c36"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("c43c64b6-d37d-44b6-a6cc-ad890e942b1b"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("d12b6e66-e758-48ca-af31-102aa991bdc0"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("d4e27800-46bd-48d4-b320-92380548f689"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("d6b13c5b-cabf-4034-af31-f3c30d344393"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("d80697b7-aa62-49e2-86e8-2a83e2e71004"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("db2a6fec-1be3-4e5a-9dc2-71e0104c150d"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("e1de5ca1-58dd-4a15-8544-0b370db9f2bb"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("e55051fc-17a6-41ec-b76e-fe6d98a15058"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("eeccea9a-ebaa-4660-b2f2-8fad550b38bb"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("f333c6ac-530c-4092-8160-a336bafb4d6c"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("f3a05565-4293-47b4-8799-78a7e0d8787f"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("f532bb4b-725b-4b00-8643-a335a4c3fe2f"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("f5a8d4f5-a85c-4141-be24-7ba4d2bae6ce"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("fee99c99-831c-4f29-acd0-5eb5ad0ca7e2"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("fef757f5-8653-4ac3-814d-b60af590ce5a"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("ff28aa68-df77-4829-a2ce-f322d4b15a2b"));

            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "Id",
                keyValue: new Guid("4a823069-9673-403c-8ea0-59b225e5491c"));

            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "Id",
                keyValue: new Guid("6b3957c3-d16e-4620-8d2c-b26239a7a2a8"));

            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "Id",
                keyValue: new Guid("b0d09040-c5ea-492d-936f-488b9f3115a2"));

            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "Id",
                keyValue: new Guid("e05d5966-b197-4bd1-92d4-800f66b352fe"));

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "faculties",
                newName: "name");

            migrationBuilder.AddColumn<Guid>(
                name: "discipline_id",
                table: "groups_disciplines",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "group_id",
                table: "groups_disciplines",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "direction_id",
                table: "groups",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "direction_id",
                table: "directions_disciplines",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "discipline_id",
                table: "directions_disciplines",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "faculty_id",
                table: "directions",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_groups_disciplines_discipline_id",
                table: "groups_disciplines",
                column: "discipline_id");

            migrationBuilder.CreateIndex(
                name: "IX_groups_disciplines_group_id",
                table: "groups_disciplines",
                column: "group_id");

            migrationBuilder.CreateIndex(
                name: "IX_groups_direction_id",
                table: "groups",
                column: "direction_id");

            migrationBuilder.CreateIndex(
                name: "IX_directions_disciplines_direction_id",
                table: "directions_disciplines",
                column: "direction_id");

            migrationBuilder.CreateIndex(
                name: "IX_directions_disciplines_discipline_id",
                table: "directions_disciplines",
                column: "discipline_id");

            migrationBuilder.CreateIndex(
                name: "IX_directions_faculty_id",
                table: "directions",
                column: "faculty_id");

            migrationBuilder.AddForeignKey(
                name: "FK_directions_faculties_faculty_id",
                table: "directions",
                column: "faculty_id",
                principalTable: "faculties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_directions_disciplines_directions_direction_id",
                table: "directions_disciplines",
                column: "direction_id",
                principalTable: "directions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_directions_disciplines_disciplines_discipline_id",
                table: "directions_disciplines",
                column: "discipline_id",
                principalTable: "disciplines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_groups_directions_direction_id",
                table: "groups",
                column: "direction_id",
                principalTable: "directions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_groups_disciplines_disciplines_discipline_id",
                table: "groups_disciplines",
                column: "discipline_id",
                principalTable: "disciplines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_groups_disciplines_groups_group_id",
                table: "groups_disciplines",
                column: "group_id",
                principalTable: "groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
