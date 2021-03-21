using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseBook.WebApi.Migrations
{
    public partial class add_profile_details : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "profiles",
                newName: "Group");

            migrationBuilder.AddColumn<string>(
                name: "Direction",
                table: "profiles",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Faculty",
                table: "profiles",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "profiles",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Direction",
                table: "profiles");

            migrationBuilder.DropColumn(
                name: "Faculty",
                table: "profiles");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "profiles");

            migrationBuilder.RenameColumn(
                name: "Group",
                table: "profiles",
                newName: "Name");
        }
    }
}
