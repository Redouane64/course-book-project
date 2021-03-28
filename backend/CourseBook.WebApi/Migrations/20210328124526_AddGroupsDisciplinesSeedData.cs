using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseBook.WebApi.Migrations
{
    public partial class AddGroupsDisciplinesSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("45842fa6-5b8b-4a31-ad6e-e5038340ab5d"), null, "Professional communication in a foreign language" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("39400eb6-3c42-4527-a444-519ef1987e06"), null, "Leadership and leadership of teamwork" });

            migrationBuilder.InsertData(
                table: "disciplines",
                columns: new[] { "Id", "Literatures", "Name" },
                values: new object[] { new Guid("0675ed9c-788d-4301-8b97-558992d04f20"), null, "Modern problems of the humanities and natural sciences" });

            migrationBuilder.InsertData(
                table: "groups_disciplines",
                columns: new[] { "DisciplineId", "GroupId", "Semester", "TeacherId", "Year" },
                values: new object[] { new Guid("986d7006-65c4-4246-b99a-2d390e1ae4f7"), new Guid("bbf4d1b7-5dd6-4737-b78c-e865cbe4adc0"), 0, "b19d2ff1-efe2-4fd4-a721-3444f2c9888c", 2021 });

            migrationBuilder.InsertData(
                table: "groups_disciplines",
                columns: new[] { "DisciplineId", "GroupId", "Semester", "TeacherId", "Year" },
                values: new object[] { new Guid("b0a130ae-8d09-4cec-8814-24c811028771"), new Guid("bbf4d1b7-5dd6-4737-b78c-e865cbe4adc0"), 0, "b19d2ff1-efe2-4fd4-a721-3444f2c9888c", 2022 });

            migrationBuilder.InsertData(
                table: "groups_disciplines",
                columns: new[] { "DisciplineId", "GroupId", "Semester", "TeacherId", "Year" },
                values: new object[] { new Guid("fee99c99-831c-4f29-acd0-5eb5ad0ca7e2"), new Guid("bbf4d1b7-5dd6-4737-b78c-e865cbe4adc0"), 1, "b19d2ff1-efe2-4fd4-a721-3444f2c9888c", 2021 });

            migrationBuilder.InsertData(
                table: "groups_disciplines",
                columns: new[] { "DisciplineId", "GroupId", "Semester", "TeacherId", "Year" },
                values: new object[] { new Guid("d12b6e66-e758-48ca-af31-102aa991bdc0"), new Guid("bbf4d1b7-5dd6-4737-b78c-e865cbe4adc0"), 1, "b19d2ff1-efe2-4fd4-a721-3444f2c9888c", 2022 });

            migrationBuilder.InsertData(
                table: "groups_disciplines",
                columns: new[] { "DisciplineId", "GroupId", "Semester", "TeacherId", "Year" },
                values: new object[] { new Guid("0142a5ca-e2ab-423a-a03f-d2c3092a0339"), new Guid("b719e956-a46c-41b5-93bd-81bd4e12c7ed"), 0, "b19d2ff1-efe2-4fd4-a721-3444f2c9888c", 2021 });

            migrationBuilder.InsertData(
                table: "groups_disciplines",
                columns: new[] { "DisciplineId", "GroupId", "Semester", "TeacherId", "Year" },
                values: new object[] { new Guid("09da399f-d269-4333-b3a9-c7203dee1a01"), new Guid("b719e956-a46c-41b5-93bd-81bd4e12c7ed"), 0, "b19d2ff1-efe2-4fd4-a721-3444f2c9888c", 2022 });

            migrationBuilder.InsertData(
                table: "groups_disciplines",
                columns: new[] { "DisciplineId", "GroupId", "Semester", "TeacherId", "Year" },
                values: new object[] { new Guid("d4e27800-46bd-48d4-b320-92380548f689"), new Guid("b719e956-a46c-41b5-93bd-81bd4e12c7ed"), 1, "b19d2ff1-efe2-4fd4-a721-3444f2c9888c", 2022 });

            migrationBuilder.InsertData(
                table: "groups_disciplines",
                columns: new[] { "DisciplineId", "GroupId", "Semester", "TeacherId", "Year" },
                values: new object[] { new Guid("f333c6ac-530c-4092-8160-a336bafb4d6c"), new Guid("b719e956-a46c-41b5-93bd-81bd4e12c7ed"), 1, "b19d2ff1-efe2-4fd4-a721-3444f2c9888c", 2022 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("0675ed9c-788d-4301-8b97-558992d04f20"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("39400eb6-3c42-4527-a444-519ef1987e06"));

            migrationBuilder.DeleteData(
                table: "disciplines",
                keyColumn: "Id",
                keyValue: new Guid("45842fa6-5b8b-4a31-ad6e-e5038340ab5d"));

            migrationBuilder.DeleteData(
                table: "groups_disciplines",
                keyColumns: new[] { "DisciplineId", "GroupId" },
                keyValues: new object[] { new Guid("0142a5ca-e2ab-423a-a03f-d2c3092a0339"), new Guid("b719e956-a46c-41b5-93bd-81bd4e12c7ed") });

            migrationBuilder.DeleteData(
                table: "groups_disciplines",
                keyColumns: new[] { "DisciplineId", "GroupId" },
                keyValues: new object[] { new Guid("09da399f-d269-4333-b3a9-c7203dee1a01"), new Guid("b719e956-a46c-41b5-93bd-81bd4e12c7ed") });

            migrationBuilder.DeleteData(
                table: "groups_disciplines",
                keyColumns: new[] { "DisciplineId", "GroupId" },
                keyValues: new object[] { new Guid("d4e27800-46bd-48d4-b320-92380548f689"), new Guid("b719e956-a46c-41b5-93bd-81bd4e12c7ed") });

            migrationBuilder.DeleteData(
                table: "groups_disciplines",
                keyColumns: new[] { "DisciplineId", "GroupId" },
                keyValues: new object[] { new Guid("f333c6ac-530c-4092-8160-a336bafb4d6c"), new Guid("b719e956-a46c-41b5-93bd-81bd4e12c7ed") });

            migrationBuilder.DeleteData(
                table: "groups_disciplines",
                keyColumns: new[] { "DisciplineId", "GroupId" },
                keyValues: new object[] { new Guid("986d7006-65c4-4246-b99a-2d390e1ae4f7"), new Guid("bbf4d1b7-5dd6-4737-b78c-e865cbe4adc0") });

            migrationBuilder.DeleteData(
                table: "groups_disciplines",
                keyColumns: new[] { "DisciplineId", "GroupId" },
                keyValues: new object[] { new Guid("b0a130ae-8d09-4cec-8814-24c811028771"), new Guid("bbf4d1b7-5dd6-4737-b78c-e865cbe4adc0") });

            migrationBuilder.DeleteData(
                table: "groups_disciplines",
                keyColumns: new[] { "DisciplineId", "GroupId" },
                keyValues: new object[] { new Guid("d12b6e66-e758-48ca-af31-102aa991bdc0"), new Guid("bbf4d1b7-5dd6-4737-b78c-e865cbe4adc0") });

            migrationBuilder.DeleteData(
                table: "groups_disciplines",
                keyColumns: new[] { "DisciplineId", "GroupId" },
                keyValues: new object[] { new Guid("fee99c99-831c-4f29-acd0-5eb5ad0ca7e2"), new Guid("bbf4d1b7-5dd6-4737-b78c-e865cbe4adc0") });
        }
    }
}
