using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseBook.WebApi.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "disciplines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Literatures = table.Column<string>(type: "TEXT", maxLength: 4096, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_disciplines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "faculties",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_faculties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "directions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    FacultyId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_directions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_directions_faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "role_claims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role_claims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_role_claims_roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "directions_disciplines",
                columns: table => new
                {
                    DirectionId = table.Column<Guid>(type: "TEXT", nullable: false),
                    DisciplineId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_directions_disciplines", x => new { x.DirectionId, x.DisciplineId });
                    table.ForeignKey(
                        name: "FK_directions_disciplines_directions_DirectionId",
                        column: x => x.DirectionId,
                        principalTable: "directions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_directions_disciplines_disciplines_DisciplineId",
                        column: x => x.DisciplineId,
                        principalTable: "disciplines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "groups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    DirectionId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_groups_directions_DirectionId",
                        column: x => x.DirectionId,
                        principalTable: "directions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FullName = table.Column<string>(type: "TEXT", nullable: true),
                    BirthDay = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AdmissionYear = table.Column<int>(type: "INTEGER", nullable: false),
                    GroupId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_users_groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "groups_disciplines",
                columns: table => new
                {
                    GroupId = table.Column<Guid>(type: "TEXT", nullable: false),
                    DisciplineId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    Semester = table.Column<int>(type: "INTEGER", nullable: false),
                    TeacherId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_groups_disciplines", x => new { x.GroupId, x.DisciplineId });
                    table.ForeignKey(
                        name: "FK_groups_disciplines_disciplines_DisciplineId",
                        column: x => x.DisciplineId,
                        principalTable: "disciplines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_groups_disciplines_groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_groups_disciplines_users_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "user_claims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_claims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_user_claims_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_roles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_roles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_user_roles_roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_roles_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_tokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_tokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_user_tokens_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("986d7006-65c4-4246-b99a-2d390e1ae4f7"), null, "Art history" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("0af79477-a80e-4eb6-b156-97bc4cb47315"), null, "Microprocessors" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("a5f99e5d-a6a6-4a15-96b0-b2c3f54ce06c"), null, "Electronics" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("1faf9ce2-d392-4097-af23-2d962b90e9d6"), null, "Optics Basics" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("ac542825-f958-4103-91ec-89e6363f0d43"), null, "Military training" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("7131c3a2-4bc4-4195-859a-f5af9bd7d144"), null, "	Mobile communication systems" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("9f160c04-c98b-4d58-a631-cdec4a04e316"), null, "Metrology" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("fef757f5-8653-4ac3-814d-b60af590ce5a"), null, "Digital spectral analysis of signals and fields" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("075486bf-0147-4bf7-97ca-e83191675bfb"), null, "	Standardization and certification" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("96cd27bd-dcff-496b-9984-4489b11a2712"), null, "Waveguide Photonics" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("b46cc5bc-6fc4-4f1e-9b2a-ff68b3f1234d"), null, "Atomic and Nuclear Physics" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("3ac05f7b-8ee9-4bf5-a37b-692eb9670c35"), null, "Elective disciplines in physical culture and sports" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("96e8af39-7453-49cb-af5a-28d1e64e001a"), null, "Foreign language" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("aad3f967-7158-46ca-9b8a-405581f207a4"), null, "Study Practice" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("65830d5c-c0b3-46b6-8bea-b3dd2ce6e1dd"), null, "Foreign language" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("54f742d3-a89d-4e4a-bd39-d233e0c34395"), null, "Quantum chemistry" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("27bedee0-3b3e-4ab2-9bab-7f910ea12df2"), null, "Pedagogy" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("f3a05565-4293-47b4-8799-78a7e0d8787f"), null, "Polymer solutions" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("abc7d661-c1c4-4bd7-b767-d88ce7b748e5"), null, "Chemical modification of polymers" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("7798ec77-2078-410b-9a47-3ecb1f17b100"), null, "Chemical foundations of biological processes" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("5f926e12-86e0-4c9f-9f99-734ef39575ca"), null, "Polymer synthesis methods" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("0a89c092-a7df-4570-b7a4-1042d4a08b04"), null, "Analysis of the quality of hydrocarbon raw materials and products of its processing" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("579e5d9d-cf33-41d4-a172-56853419f169"), null, "Theoretical foundations of oil refining" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("c43c64b6-d37d-44b6-a6cc-ad890e942b1b"), null, "Methods for the transmission of scientific information" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("ff28aa68-df77-4829-a2ce-f322d4b15a2b"), null, "Theoretical foundations of oil refining" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("e55051fc-17a6-41ec-b76e-fe6d98a15058"), null, "Analytical chemistry" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("2f9785fd-34f2-47dd-8b5b-e520047213fb"), null, "Physics" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("f532bb4b-725b-4b00-8643-a335a4c3fe2f"), null, "Mathematical analysis" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("4bd00c26-498f-439e-b269-5052091dc53f"), null, "Biomedical laser technology" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("b0a130ae-8d09-4cec-8814-24c811028771"), null, "Composition" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("fee99c99-831c-4f29-acd0-5eb5ad0ca7e2"), null, "Sociology of media" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("d12b6e66-e758-48ca-af31-102aa991bdc0"), null, "History of material culture" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("0142a5ca-e2ab-423a-a03f-d2c3092a0339"), null, "Information law" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("09da399f-d269-4333-b3a9-c7203dee1a01"), null, "Copyright" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("d4e27800-46bd-48d4-b320-92380548f689"), null, "Quantitative methods in scientific research" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("f333c6ac-530c-4092-8160-a336bafb4d6c"), null, "Strategic management in the library" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("8e518999-5273-4789-9978-dac4baa4e74c"), null, "Foreign language" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("e1de5ca1-58dd-4a15-8544-0b370db9f2bb"), null, "Academic writing" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("f5a8d4f5-a85c-4141-be24-7ba4d2bae6ce"), null, "Museology, conservation and restoration of historical and cultural objects" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("1b773c45-0a73-43f9-94d6-af576c52cf9f"), null, "Modern problems of physics of the microworld and cosmology" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("eeccea9a-ebaa-4660-b2f2-8fad550b38bb"), null, "Linear Algebra" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("5687210f-0fe3-4111-b0c6-a4764c3ad27c"), null, "Waves and layers in plasma" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("5b63a570-f5b2-47e7-8b2f-a79ca090797a"), null, "Foreign language in the field of professional communication" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("45a4ac18-d257-4bbf-8c90-959c5222aecf"), null, "Military training" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("a02c08b7-bd53-43e7-8a83-ead1185fbdd0"), null, "Information systems design" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("db2a6fec-1be3-4e5a-9dc2-71e0104c150d"), null, "Laboratories specializing in satellite dynamics" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("211181c7-ef7c-4de0-b382-70e0eb9c89d3"), null, "Global Positioning Technologies" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("d6b13c5b-cabf-4034-af31-f3c30d344393"), null, "Modern problems of physics of the microworld and cosmology" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("ad97d079-2037-4dd7-abfd-f23befa01df2"), null, "Physics of intermolecular interactions" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("d80697b7-aa62-49e2-86e8-2a83e2e71004"), null, "The theory of elementary particles" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("9fe893d9-19e8-4ca5-99a1-09c165918e8b"), null, "Topical issues of theory and teaching methods in physics" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("bc5bc711-5718-4b9c-a6cf-3d08a00f157c"), null, "Fundamentals of Atomic and Molecular Spectroscopy" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("bf026a3f-9e2a-4506-a411-8bda85002c36"), null, "Foreign language in the field of professional communication" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("4f4ffe1d-b54c-45f7-9e34-a0cc26df4ddd"), null, "Analysis of complex biophysical signals" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("bc957929-f744-4315-a4ed-08530c7f0f3e"), null, "Plasma physics problems" });

            migrationBuilder.InsertData(
                table: "faculties",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("b0d09040-c5ea-492d-936f-488b9f3115a2"), "Faculty of Radiophysics" });

            migrationBuilder.InsertData(
                table: "faculties",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("6b3957c3-d16e-4620-8d2c-b26239a7a2a8"), "Institute of Arts and Culture" });

            migrationBuilder.InsertData(
                table: "faculties",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("e05d5966-b197-4bd1-92d4-800f66b352fe"), "Faculty of Physics" });

            migrationBuilder.InsertData(
                table: "faculties",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("4a823069-9673-403c-8ea0-59b225e5491c"), "Faculty of Chemistry" });

            migrationBuilder.InsertData(
                table: "directions",
                columns: new[] { "Id", "FacultyId", "Name" },
                values: new object[] { new Guid("aaa504f9-b3ad-4854-9820-90cdcbd27322"), new Guid("6b3957c3-d16e-4620-8d2c-b26239a7a2a8"), "Culturology" });

            migrationBuilder.InsertData(
                table: "directions",
                columns: new[] { "Id", "FacultyId", "Name" },
                values: new object[] { new Guid("0efe92d1-4959-4cf5-8969-56bce0e8558c"), new Guid("6b3957c3-d16e-4620-8d2c-b26239a7a2a8"), "Pedagogy" });

            migrationBuilder.InsertData(
                table: "directions",
                columns: new[] { "Id", "FacultyId", "Name" },
                values: new object[] { new Guid("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"), new Guid("6b3957c3-d16e-4620-8d2c-b26239a7a2a8"), "Design" });

            migrationBuilder.InsertData(
                table: "directions",
                columns: new[] { "Id", "FacultyId", "Name" },
                values: new object[] { new Guid("fa2a6596-0f78-42c8-8f3f-56430aa50087"), new Guid("6b3957c3-d16e-4620-8d2c-b26239a7a2a8"), "Library and Information Activities" });

            migrationBuilder.InsertData(
                table: "directions",
                columns: new[] { "Id", "FacultyId", "Name" },
                values: new object[] { new Guid("fb92cb9d-c54c-4882-8a84-d357392586b7"), new Guid("e05d5966-b197-4bd1-92d4-800f66b352fe"), "Astronomy and Space Geodesy" });

            migrationBuilder.InsertData(
                table: "directions",
                columns: new[] { "Id", "FacultyId", "Name" },
                values: new object[] { new Guid("46c6bba6-91be-4b95-b9c9-812fbdce601e"), new Guid("e05d5966-b197-4bd1-92d4-800f66b352fe"), "Quantum Field Theory" });

            migrationBuilder.InsertData(
                table: "directions",
                columns: new[] { "Id", "FacultyId", "Name" },
                values: new object[] { new Guid("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"), new Guid("e05d5966-b197-4bd1-92d4-800f66b352fe"), "General and Experimental Physics" });

            migrationBuilder.InsertData(
                table: "directions",
                columns: new[] { "Id", "FacultyId", "Name" },
                values: new object[] { new Guid("f1db86a1-2647-44ff-81df-6e4781239dcc"), new Guid("e05d5966-b197-4bd1-92d4-800f66b352fe"), "Optics and Spectroscopy" });

            migrationBuilder.InsertData(
                table: "directions",
                columns: new[] { "Id", "FacultyId", "Name" },
                values: new object[] { new Guid("435557fa-35a0-4f35-9efa-7aba31755b46"), new Guid("b0d09040-c5ea-492d-936f-488b9f3115a2"), "Radiophysics" });

            migrationBuilder.InsertData(
                table: "directions",
                columns: new[] { "Id", "FacultyId", "Name" },
                values: new object[] { new Guid("bc4dd321-36ee-4050-905e-b1aa3fa01182"), new Guid("b0d09040-c5ea-492d-936f-488b9f3115a2"), "Radio electronics" });

            migrationBuilder.InsertData(
                table: "directions",
                columns: new[] { "Id", "FacultyId", "Name" },
                values: new object[] { new Guid("ae4d9db2-9358-4a51-9928-888d5338a78e"), new Guid("b0d09040-c5ea-492d-936f-488b9f3115a2"), "Semiconductor Electronics" });

            migrationBuilder.InsertData(
                table: "directions",
                columns: new[] { "Id", "FacultyId", "Name" },
                values: new object[] { new Guid("de2a66b0-56ea-44e3-b202-c1b4754b1721"), new Guid("b0d09040-c5ea-492d-936f-488b9f3115a2"), "Optoelectronic systems and remote sensing" });

            migrationBuilder.InsertData(
                table: "directions",
                columns: new[] { "Id", "FacultyId", "Name" },
                values: new object[] { new Guid("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"), new Guid("4a823069-9673-403c-8ea0-59b225e5491c"), "Analytical Chemistry" });

            migrationBuilder.InsertData(
                table: "directions",
                columns: new[] { "Id", "FacultyId", "Name" },
                values: new object[] { new Guid("37dd1e11-b958-45ef-ab51-09650b3d43d4"), new Guid("4a823069-9673-403c-8ea0-59b225e5491c"), "Macromolecular compounds" });

            migrationBuilder.InsertData(
                table: "directions",
                columns: new[] { "Id", "FacultyId", "Name" },
                values: new object[] { new Guid("afdfcc0a-ffdd-41e1-ab01-a712574e289a"), new Guid("4a823069-9673-403c-8ea0-59b225e5491c"), "Petrochemistry" });

            migrationBuilder.InsertData(
                table: "directions",
                columns: new[] { "Id", "FacultyId", "Name" },
                values: new object[] { new Guid("70b17a41-5128-4bde-83dd-f727554ea6b0"), new Guid("4a823069-9673-403c-8ea0-59b225e5491c"), "Physical chemistry" });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("aaa504f9-b3ad-4854-9820-90cdcbd27322"), new Guid("986d7006-65c4-4246-b99a-2d390e1ae4f7") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("bc4dd321-36ee-4050-905e-b1aa3fa01182"), new Guid("a5f99e5d-a6a6-4a15-96b0-b2c3f54ce06c") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("bc4dd321-36ee-4050-905e-b1aa3fa01182"), new Guid("0af79477-a80e-4eb6-b156-97bc4cb47315") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("435557fa-35a0-4f35-9efa-7aba31755b46"), new Guid("96e8af39-7453-49cb-af5a-28d1e64e001a") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("435557fa-35a0-4f35-9efa-7aba31755b46"), new Guid("f532bb4b-725b-4b00-8643-a335a4c3fe2f") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("435557fa-35a0-4f35-9efa-7aba31755b46"), new Guid("2f9785fd-34f2-47dd-8b5b-e520047213fb") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("f1db86a1-2647-44ff-81df-6e4781239dcc"), new Guid("4bd00c26-498f-439e-b269-5052091dc53f") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("f1db86a1-2647-44ff-81df-6e4781239dcc"), new Guid("4f4ffe1d-b54c-45f7-9e34-a0cc26df4ddd") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("f1db86a1-2647-44ff-81df-6e4781239dcc"), new Guid("bf026a3f-9e2a-4506-a411-8bda85002c36") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("bc4dd321-36ee-4050-905e-b1aa3fa01182"), new Guid("1faf9ce2-d392-4097-af23-2d962b90e9d6") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("f1db86a1-2647-44ff-81df-6e4781239dcc"), new Guid("bc5bc711-5718-4b9c-a6cf-3d08a00f157c") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"), new Guid("d80697b7-aa62-49e2-86e8-2a83e2e71004") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"), new Guid("ad97d079-2037-4dd7-abfd-f23befa01df2") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"), new Guid("d6b13c5b-cabf-4034-af31-f3c30d344393") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("46c6bba6-91be-4b95-b9c9-812fbdce601e"), new Guid("211181c7-ef7c-4de0-b382-70e0eb9c89d3") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("46c6bba6-91be-4b95-b9c9-812fbdce601e"), new Guid("db2a6fec-1be3-4e5a-9dc2-71e0104c150d") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("46c6bba6-91be-4b95-b9c9-812fbdce601e"), new Guid("a02c08b7-bd53-43e7-8a83-ead1185fbdd0") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("46c6bba6-91be-4b95-b9c9-812fbdce601e"), new Guid("45a4ac18-d257-4bbf-8c90-959c5222aecf") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("fb92cb9d-c54c-4882-8a84-d357392586b7"), new Guid("bc957929-f744-4315-a4ed-08530c7f0f3e") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"), new Guid("9fe893d9-19e8-4ca5-99a1-09c165918e8b") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("fb92cb9d-c54c-4882-8a84-d357392586b7"), new Guid("5687210f-0fe3-4111-b0c6-a4764c3ad27c") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("bc4dd321-36ee-4050-905e-b1aa3fa01182"), new Guid("ac542825-f958-4103-91ec-89e6363f0d43") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("ae4d9db2-9358-4a51-9928-888d5338a78e"), new Guid("9f160c04-c98b-4d58-a631-cdec4a04e316") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("70b17a41-5128-4bde-83dd-f727554ea6b0"), new Guid("ff28aa68-df77-4829-a2ce-f322d4b15a2b") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("70b17a41-5128-4bde-83dd-f727554ea6b0"), new Guid("c43c64b6-d37d-44b6-a6cc-ad890e942b1b") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("70b17a41-5128-4bde-83dd-f727554ea6b0"), new Guid("579e5d9d-cf33-41d4-a172-56853419f169") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("afdfcc0a-ffdd-41e1-ab01-a712574e289a"), new Guid("0a89c092-a7df-4570-b7a4-1042d4a08b04") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("afdfcc0a-ffdd-41e1-ab01-a712574e289a"), new Guid("5f926e12-86e0-4c9f-9f99-734ef39575ca") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("afdfcc0a-ffdd-41e1-ab01-a712574e289a"), new Guid("7798ec77-2078-410b-9a47-3ecb1f17b100") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("37dd1e11-b958-45ef-ab51-09650b3d43d4"), new Guid("abc7d661-c1c4-4bd7-b767-d88ce7b748e5") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("37dd1e11-b958-45ef-ab51-09650b3d43d4"), new Guid("f3a05565-4293-47b4-8799-78a7e0d8787f") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("ae4d9db2-9358-4a51-9928-888d5338a78e"), new Guid("7131c3a2-4bc4-4195-859a-f5af9bd7d144") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("37dd1e11-b958-45ef-ab51-09650b3d43d4"), new Guid("27bedee0-3b3e-4ab2-9bab-7f910ea12df2") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"), new Guid("65830d5c-c0b3-46b6-8bea-b3dd2ce6e1dd") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"), new Guid("e55051fc-17a6-41ec-b76e-fe6d98a15058") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("de2a66b0-56ea-44e3-b202-c1b4754b1721"), new Guid("aad3f967-7158-46ca-9b8a-405581f207a4") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("de2a66b0-56ea-44e3-b202-c1b4754b1721"), new Guid("3ac05f7b-8ee9-4bf5-a37b-692eb9670c35") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("de2a66b0-56ea-44e3-b202-c1b4754b1721"), new Guid("b46cc5bc-6fc4-4f1e-9b2a-ff68b3f1234d") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("de2a66b0-56ea-44e3-b202-c1b4754b1721"), new Guid("96cd27bd-dcff-496b-9984-4489b11a2712") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("ae4d9db2-9358-4a51-9928-888d5338a78e"), new Guid("075486bf-0147-4bf7-97ca-e83191675bfb") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("ae4d9db2-9358-4a51-9928-888d5338a78e"), new Guid("fef757f5-8653-4ac3-814d-b60af590ce5a") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"), new Guid("54f742d3-a89d-4e4a-bd39-d233e0c34395") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("fb92cb9d-c54c-4882-8a84-d357392586b7"), new Guid("5b63a570-f5b2-47e7-8b2f-a79ca090797a") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("435557fa-35a0-4f35-9efa-7aba31755b46"), new Guid("eeccea9a-ebaa-4660-b2f2-8fad550b38bb") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("0efe92d1-4959-4cf5-8969-56bce0e8558c"), new Guid("d4e27800-46bd-48d4-b320-92380548f689") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("fb92cb9d-c54c-4882-8a84-d357392586b7"), new Guid("1b773c45-0a73-43f9-94d6-af576c52cf9f") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("0efe92d1-4959-4cf5-8969-56bce0e8558c"), new Guid("f333c6ac-530c-4092-8160-a336bafb4d6c") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"), new Guid("f5a8d4f5-a85c-4141-be24-7ba4d2bae6ce") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"), new Guid("8e518999-5273-4789-9978-dac4baa4e74c") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("0efe92d1-4959-4cf5-8969-56bce0e8558c"), new Guid("09da399f-d269-4333-b3a9-c7203dee1a01") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("aaa504f9-b3ad-4854-9820-90cdcbd27322"), new Guid("d12b6e66-e758-48ca-af31-102aa991bdc0") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("aaa504f9-b3ad-4854-9820-90cdcbd27322"), new Guid("fee99c99-831c-4f29-acd0-5eb5ad0ca7e2") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"), new Guid("e1de5ca1-58dd-4a15-8544-0b370db9f2bb") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("0efe92d1-4959-4cf5-8969-56bce0e8558c"), new Guid("0142a5ca-e2ab-423a-a03f-d2c3092a0339") });

            migrationBuilder.InsertData(
                table: "directions_disciplines",
                columns: new[] { "DirectionId", "DisciplineId" },
                values: new object[] { new Guid("aaa504f9-b3ad-4854-9820-90cdcbd27322"), new Guid("b0a130ae-8d09-4cec-8814-24c811028771") });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("fa09fced-f0ec-4f86-8635-548169c085d2"), new Guid("de2a66b0-56ea-44e3-b202-c1b4754b1721"), "50004" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("80e4da28-2726-484b-98d3-acf2f685f110"), new Guid("de2a66b0-56ea-44e3-b202-c1b4754b1721"), "50002" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("66bfc87e-0176-48b8-86f7-d6bb27145544"), new Guid("de2a66b0-56ea-44e3-b202-c1b4754b1721"), "50001" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("590eb367-5fcf-4b67-a350-e2f87a688ef4"), new Guid("aaa504f9-b3ad-4854-9820-90cdcbd27322"), "931928" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("21e70871-00c4-435f-a58f-e5ee217c9daf"), new Guid("de2a66b0-56ea-44e3-b202-c1b4754b1721"), "50004" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("6600b84a-46d6-4457-b553-2bc76cf429b1"), new Guid("de2a66b0-56ea-44e3-b202-c1b4754b1721"), "50003" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("dc0a6e03-06ab-4f32-8714-841367f13739"), new Guid("aaa504f9-b3ad-4854-9820-90cdcbd27322"), "932028" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("53b46c40-973d-4011-96bd-88b6d6d2f266"), new Guid("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"), "60001" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("0c9e1c5b-b73c-4761-9e8b-3fac8fe1ec39"), new Guid("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"), "60002" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("d76d264f-afb3-43e8-ba47-78a12d6630e7"), new Guid("de2a66b0-56ea-44e3-b202-c1b4754b1721"), "50003" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("569b3af3-11b3-4c14-a365-3444136317c9"), new Guid("fa2a6596-0f78-42c8-8f3f-56430aa50087"), "93203" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("301db25d-27bc-4fdd-9422-76161b433222"), new Guid("de2a66b0-56ea-44e3-b202-c1b4754b1721"), "50001" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("b719e956-a46c-41b5-93bd-81bd4e12c7ed"), new Guid("0efe92d1-4959-4cf5-8969-56bce0e8558c"), "93180" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("d054363e-9ac6-471c-927a-44ede49e14b9"), new Guid("ae4d9db2-9358-4a51-9928-888d5338a78e"), "40004" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("92560e1e-10b6-4e22-a3c7-4b44b57a4c2d"), new Guid("ae4d9db2-9358-4a51-9928-888d5338a78e"), "40003" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("a7d2019d-db79-4e4e-9142-4fd7e5595210"), new Guid("ae4d9db2-9358-4a51-9928-888d5338a78e"), "40002" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("9f02f059-f663-4c89-a803-30c0913c6095"), new Guid("ae4d9db2-9358-4a51-9928-888d5338a78e"), "40001" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("f12316e7-00a1-44d1-8cd4-f130cb1549d7"), new Guid("ae4d9db2-9358-4a51-9928-888d5338a78e"), "40004" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("8d22e5be-874c-4467-a8a6-10ec4be05940"), new Guid("ae4d9db2-9358-4a51-9928-888d5338a78e"), "40003" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("d47f6ceb-be52-4d14-94c2-3891dae8524d"), new Guid("ae4d9db2-9358-4a51-9928-888d5338a78e"), "40002" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("bc6f600e-3c90-4fd2-a650-7fe8496d6b99"), new Guid("ae4d9db2-9358-4a51-9928-888d5338a78e"), "40001" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("d85b1c42-f9b2-4fbb-bc35-1e93c4f311be"), new Guid("0efe92d1-4959-4cf5-8969-56bce0e8558c"), "931802" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("11f1a4ae-64ef-4708-945f-001ec13475cb"), new Guid("0efe92d1-4959-4cf5-8969-56bce0e8558c"), "931804" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("150043db-fafd-47af-a367-1865429a3b06"), new Guid("0efe92d1-4959-4cf5-8969-56bce0e8558c"), "931803" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("61779bbf-e712-4c4f-9c1c-cfde792f8123"), new Guid("de2a66b0-56ea-44e3-b202-c1b4754b1721"), "50002" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("0d4c5368-15a1-46a4-9605-723c91d725bc"), new Guid("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"), "60003" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("9b28da7a-9b71-4f57-a682-977f6a6592ab"), new Guid("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"), "60001" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("10ea97d6-aebe-4ef3-bc5a-0d3410762d17"), new Guid("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"), "60002" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("85b6e537-c106-41df-9ec4-5bc8e3b9be17"), new Guid("70b17a41-5128-4bde-83dd-f727554ea6b0"), "90002" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("6d4c1ffe-3caa-472c-82e7-040fa3081142"), new Guid("70b17a41-5128-4bde-83dd-f727554ea6b0"), "90001" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("4af28876-24b2-4f33-ac7b-4c4c95385ab3"), new Guid("70b17a41-5128-4bde-83dd-f727554ea6b0"), "90004" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("deea0a5c-fb24-4994-9384-fabe85e4a76a"), new Guid("70b17a41-5128-4bde-83dd-f727554ea6b0"), "90003" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("24b4ee8d-c599-41b2-be5c-b27597cf278b"), new Guid("70b17a41-5128-4bde-83dd-f727554ea6b0"), "90002" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("7e311ede-5d6c-4df4-9c64-192e00f65cf9"), new Guid("70b17a41-5128-4bde-83dd-f727554ea6b0"), "90001" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("04172373-df80-4d60-90df-a4efa8e74941"), new Guid("afdfcc0a-ffdd-41e1-ab01-a712574e289a"), "80004" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("0b7978c5-8e25-45a4-902c-9f6ff5d53b87"), new Guid("afdfcc0a-ffdd-41e1-ab01-a712574e289a"), "80003" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("ae0242e1-8c6e-4e6d-99a5-2f55b6e44a47"), new Guid("afdfcc0a-ffdd-41e1-ab01-a712574e289a"), "80002" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("b129f3e3-a379-45a3-953c-ce69bcf097d5"), new Guid("afdfcc0a-ffdd-41e1-ab01-a712574e289a"), "80001" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("462afa34-c206-4761-bd96-b87e72d1d243"), new Guid("afdfcc0a-ffdd-41e1-ab01-a712574e289a"), "80004" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("4320ca86-9aaf-42fb-8832-35c9076e5b05"), new Guid("afdfcc0a-ffdd-41e1-ab01-a712574e289a"), "80003" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("a06269e9-85a7-4108-b199-0a5f81b9dedd"), new Guid("afdfcc0a-ffdd-41e1-ab01-a712574e289a"), "80002" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("78b0c8a8-02d4-476d-a201-667cd79d0557"), new Guid("afdfcc0a-ffdd-41e1-ab01-a712574e289a"), "80001" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("d6382f9d-4e4c-45b3-8b34-4a63e69de09f"), new Guid("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"), "60004" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("bbf4d1b7-5dd6-4737-b78c-e865cbe4adc0"), new Guid("aaa504f9-b3ad-4854-9820-90cdcbd27322"), "931910" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("c06d5b88-917b-42ad-a032-224cf2cbb34b"), new Guid("aaa504f9-b3ad-4854-9820-90cdcbd27322"), "932028" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("eb781120-10cf-4161-a235-726b23c3a6c6"), new Guid("37dd1e11-b958-45ef-ab51-09650b3d43d4"), "70004" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("41178a4d-8d1d-49e4-a0ee-80965e1df5ab"), new Guid("37dd1e11-b958-45ef-ab51-09650b3d43d4"), "70003" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("eeb1dd57-104c-40ca-b6ea-e64ecfdc55d4"), new Guid("37dd1e11-b958-45ef-ab51-09650b3d43d4"), "70002" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("cbd62f90-c44d-47e1-a049-ae1d5b94e3e7"), new Guid("37dd1e11-b958-45ef-ab51-09650b3d43d4"), "70001" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("0ccaf237-249b-49a2-91bf-4e13199f0ed8"), new Guid("37dd1e11-b958-45ef-ab51-09650b3d43d4"), "70004" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("0d80b63a-50d1-4c0f-b1f7-0a351d57192e"), new Guid("37dd1e11-b958-45ef-ab51-09650b3d43d4"), "70003" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("e9880029-92c6-4143-a680-00c06e6347d3"), new Guid("37dd1e11-b958-45ef-ab51-09650b3d43d4"), "70002" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("deff19d1-bf42-4d14-9ac1-5c21b2a18a5c"), new Guid("37dd1e11-b958-45ef-ab51-09650b3d43d4"), "70001" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("995fefec-b444-4755-9e70-bee240d47c9e"), new Guid("aaa504f9-b3ad-4854-9820-90cdcbd27322"), "931928" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("26441b22-1be9-432f-a06a-ebc9e4222f6e"), new Guid("aaa504f9-b3ad-4854-9820-90cdcbd27322"), "931910" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("c4ba2c3f-6f86-41a2-b79e-0288e25b5d06"), new Guid("aaa504f9-b3ad-4854-9820-90cdcbd27322"), "932010" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("70eccf2a-b381-413e-b58e-c1850d09d638"), new Guid("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"), "60004" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("a0c045de-a8a9-4261-b3f6-6f933ea0a2f3"), new Guid("eb9b5b37-07f2-4e86-a4f0-cc54f186a24a"), "60003" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("bfd64d63-203b-47f1-86c4-c483b6cb48ac"), new Guid("aaa504f9-b3ad-4854-9820-90cdcbd27322"), "932010" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("69626a13-91ce-4281-bb74-2dac4c1a6db8"), new Guid("0efe92d1-4959-4cf5-8969-56bce0e8558c"), "93180" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("7b9a7b18-b25f-43dd-be9b-6b11cb6a629b"), new Guid("bc4dd321-36ee-4050-905e-b1aa3fa01182"), "30003" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("70f6eee6-cc82-4b56-8e36-f0855858cc25"), new Guid("bc4dd321-36ee-4050-905e-b1aa3fa01182"), "30002" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("c0ef4a72-dac8-4ea8-a9b5-78f8865e9ad9"), new Guid("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"), "24203" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("55d59cff-8589-454f-92d3-bfc3862567fc"), new Guid("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"), "24202" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("3a8fecd3-ef58-4894-a716-851ba1955172"), new Guid("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"), "24201" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("375f4cd0-0dfe-4549-a250-b038a30badd5"), new Guid("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"), "24200" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("43559fcb-8bae-4cc0-9576-f2835a3061f9"), new Guid("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"), "931901" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("ae932456-b33f-486a-93dc-adb27c290296"), new Guid("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"), "931902" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("43017bdf-3026-4607-a266-30948c613f0d"), new Guid("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"), "931903" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("99cee655-2eb3-49a1-8b7b-98f5cdf27dc0"), new Guid("fa2a6596-0f78-42c8-8f3f-56430aa50087"), "93200" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("7b328e66-8d7f-4677-adf6-32d296aef412"), new Guid("46c6bba6-91be-4b95-b9c9-812fbdce601e"), "121904" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("7f21c712-e107-4dc5-8bcc-8c8d3e29611b"), new Guid("46c6bba6-91be-4b95-b9c9-812fbdce601e"), "121903" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("d37e2391-3b24-4258-8543-25cb3e8e6021"), new Guid("46c6bba6-91be-4b95-b9c9-812fbdce601e"), "121902" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("be0b569f-4f07-4b32-98d6-90580e55f4bd"), new Guid("46c6bba6-91be-4b95-b9c9-812fbdce601e"), "121901" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("3898a741-3487-4cff-bb0c-833730a7bfb5"), new Guid("46c6bba6-91be-4b95-b9c9-812fbdce601e"), "121904" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("2bc26348-3840-4d75-b5b8-307b5664d9d8"), new Guid("46c6bba6-91be-4b95-b9c9-812fbdce601e"), "121903" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("a2df678d-7461-4453-be7f-b854eb2eb0b1"), new Guid("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"), "24200" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("0ea53180-ed44-4898-a892-c40077d05e65"), new Guid("46c6bba6-91be-4b95-b9c9-812fbdce601e"), "121902" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("f18a4b0e-bf34-4038-aa35-961ee944fc62"), new Guid("fa2a6596-0f78-42c8-8f3f-56430aa50087"), "93201" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("1d31e987-c3b7-4e79-8aa8-61482da3987e"), new Guid("fa2a6596-0f78-42c8-8f3f-56430aa50087"), "93202" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("65ca36aa-54f8-4384-af13-f16779251686"), new Guid("fa2a6596-0f78-42c8-8f3f-56430aa50087"), "93203" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("8ce7c591-597d-4e4a-9702-78410cc91fbe"), new Guid("fa2a6596-0f78-42c8-8f3f-56430aa50087"), "93200" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("714b27cd-c133-459c-91ea-d4be6879f6df"), new Guid("fb92cb9d-c54c-4882-8a84-d357392586b7"), "122004" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("a17b86b9-9e59-47be-b497-ac7e681a6490"), new Guid("fb92cb9d-c54c-4882-8a84-d357392586b7"), "122003" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("fb9fb634-5a7a-4975-93c5-13c47e2d7a88"), new Guid("fb92cb9d-c54c-4882-8a84-d357392586b7"), "122002" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("4e9a677c-03a0-4a67-b0fd-6c23560297be"), new Guid("fb92cb9d-c54c-4882-8a84-d357392586b7"), "122001" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("9ae4c644-778d-4358-90cf-7fdd895018c5"), new Guid("fb92cb9d-c54c-4882-8a84-d357392586b7"), "122004" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("97d0822d-49aa-47df-b483-6f9d8ee29804"), new Guid("fb92cb9d-c54c-4882-8a84-d357392586b7"), "122003" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("177aca2d-65d7-4d69-88bf-95488732d0c5"), new Guid("fb92cb9d-c54c-4882-8a84-d357392586b7"), "122002" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("2e596386-82f0-422c-a0d1-6c9325b2b8c5"), new Guid("fb92cb9d-c54c-4882-8a84-d357392586b7"), "122001" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("3b541a3e-1e89-48e0-8283-d46fe573bab0"), new Guid("fa2a6596-0f78-42c8-8f3f-56430aa50087"), "93201" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("6fec86e7-be04-4daf-889a-8fb9e048f935"), new Guid("fa2a6596-0f78-42c8-8f3f-56430aa50087"), "93202" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("de67b121-67e1-4daf-afce-cd7f5fcd73f0"), new Guid("46c6bba6-91be-4b95-b9c9-812fbdce601e"), "121901" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("c6f70945-fc4e-4637-a90f-ad9a859c0b3a"), new Guid("bc4dd321-36ee-4050-905e-b1aa3fa01182"), "30004" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("6e2c0941-ecf1-4f9c-a2fc-71b498926a25"), new Guid("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"), "24201" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("49de0fc1-fd7a-4f99-82c1-2bdc4051d6c6"), new Guid("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"), "24203" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("954ada8e-3081-4c7a-8cb9-6486ca9c0c78"), new Guid("bc4dd321-36ee-4050-905e-b1aa3fa01182"), "30001" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("baa44940-e055-4097-9d35-23ff36c24ece"), new Guid("bc4dd321-36ee-4050-905e-b1aa3fa01182"), "30004" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("97f0b426-f8bd-496c-b8af-7b5432c35eca"), new Guid("bc4dd321-36ee-4050-905e-b1aa3fa01182"), "30003" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("bc28bb75-ec40-4118-a652-4dfda2189c42"), new Guid("bc4dd321-36ee-4050-905e-b1aa3fa01182"), "30002" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("ef31ca1b-8b5c-497f-b4a6-c9c602ce3e17"), new Guid("bc4dd321-36ee-4050-905e-b1aa3fa01182"), "30001" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("ee357e08-2b26-4e71-97cc-a4a9aeb7b94e"), new Guid("0efe92d1-4959-4cf5-8969-56bce0e8558c"), "931802" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("d37caba8-8a5e-43f5-bdf7-96f8d4ee437c"), new Guid("0efe92d1-4959-4cf5-8969-56bce0e8558c"), "931804" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("e90ec78b-115f-4d45-af21-1f6e89b3ea62"), new Guid("0efe92d1-4959-4cf5-8969-56bce0e8558c"), "931803" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("bbcd32b0-eee0-4528-9a98-2bd190050b1a"), new Guid("435557fa-35a0-4f35-9efa-7aba31755b46"), "25304" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("16b4c772-5ef3-48d6-9380-ca6b371a0a29"), new Guid("435557fa-35a0-4f35-9efa-7aba31755b46"), "25303" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("04422cad-54f1-48d7-ae30-f5bfefb085fa"), new Guid("435557fa-35a0-4f35-9efa-7aba31755b46"), "25302" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("63904fb7-50a7-4d97-a012-82cb80e8bf1e"), new Guid("435557fa-35a0-4f35-9efa-7aba31755b46"), "25301" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("0aece601-4a7e-4b22-809f-c7a3f560e7ae"), new Guid("435557fa-35a0-4f35-9efa-7aba31755b46"), "25304" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("085e3eb8-a9d8-4b04-ac37-3b3c8e417330"), new Guid("435557fa-35a0-4f35-9efa-7aba31755b46"), "25303" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("adcfeb4f-e104-4619-ab33-13bdb9603d6a"), new Guid("d3c7313e-0e11-4f9e-94fe-0b96a66bffa9"), "24202" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("1d667208-71cd-4ffc-8edf-ce6b71121da8"), new Guid("435557fa-35a0-4f35-9efa-7aba31755b46"), "25302" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("6b5539c4-5008-489f-bee7-d10063412727"), new Guid("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"), "93190" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("500c28c8-fcb8-4f56-9e35-4956e579e63d"), new Guid("70b17a41-5128-4bde-83dd-f727554ea6b0"), "90003" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("796b3f0f-15aa-4a44-83d1-eb0d004e6ba9"), new Guid("f1db86a1-2647-44ff-81df-6e4781239dcc"), "24304" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("f5a97d11-9036-4a51-ac76-44ff3cccdced"), new Guid("f1db86a1-2647-44ff-81df-6e4781239dcc"), "24303" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("ab5461c6-6b82-4ec0-b106-7c649c30aa4e"), new Guid("f1db86a1-2647-44ff-81df-6e4781239dcc"), "24302" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("6e6f8434-5155-41bc-9186-01e9a4ea2c2e"), new Guid("f1db86a1-2647-44ff-81df-6e4781239dcc"), "24301" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("adb7bc56-69ad-401a-9f98-ca7237712022"), new Guid("f1db86a1-2647-44ff-81df-6e4781239dcc"), "24304" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("f2d957fa-c1fd-47a4-b0c0-f316dbeda20f"), new Guid("f1db86a1-2647-44ff-81df-6e4781239dcc"), "24303" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("b6ac4a85-9cfb-426e-9b0c-1bea922f4567"), new Guid("f1db86a1-2647-44ff-81df-6e4781239dcc"), "24302" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("89767b3d-6327-4125-97c4-b9a2b84854b8"), new Guid("f1db86a1-2647-44ff-81df-6e4781239dcc"), "24301" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("4779771c-16be-49ad-af93-d2c3af799ffa"), new Guid("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"), "931901" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("c894f7d5-102f-454c-87c9-ff00086f43c4"), new Guid("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"), "931902" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("e55a88ef-d73f-40f6-941a-6ebd51d0df33"), new Guid("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"), "931903" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("a1c8530c-7aca-463b-a2cb-4c18c72957ec"), new Guid("9c4684ec-04ab-4da9-9fa2-6ddebb7a5a40"), "93190" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("63f903de-5162-45f1-90fe-68e1b1375431"), new Guid("435557fa-35a0-4f35-9efa-7aba31755b46"), "25301" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "Id", "DirectionId", "Name" },
                values: new object[] { new Guid("b8810aca-e66d-4055-9335-8b5560a9200b"), new Guid("70b17a41-5128-4bde-83dd-f727554ea6b0"), "90004" });

            migrationBuilder.CreateIndex(
                name: "IX_directions_FacultyId",
                table: "directions",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_directions_disciplines_DisciplineId",
                table: "directions_disciplines",
                column: "DisciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_groups_DirectionId",
                table: "groups",
                column: "DirectionId");

            migrationBuilder.CreateIndex(
                name: "IX_groups_disciplines_DisciplineId",
                table: "groups_disciplines",
                column: "DisciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_groups_disciplines_TeacherId",
                table: "groups_disciplines",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_role_claims_RoleId",
                table: "role_claims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "roles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_claims_UserId",
                table: "user_claims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_user_roles_RoleId",
                table: "user_roles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_users_GroupId",
                table: "users",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "users",
                column: "NormalizedUserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "directions_disciplines");

            migrationBuilder.DropTable(
                name: "groups_disciplines");

            migrationBuilder.DropTable(
                name: "role_claims");

            migrationBuilder.DropTable(
                name: "user_claims");

            migrationBuilder.DropTable(
                name: "user_roles");

            migrationBuilder.DropTable(
                name: "user_tokens");

            migrationBuilder.DropTable(
                name: "disciplines");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "groups");

            migrationBuilder.DropTable(
                name: "directions");

            migrationBuilder.DropTable(
                name: "faculties");
        }
    }
}
