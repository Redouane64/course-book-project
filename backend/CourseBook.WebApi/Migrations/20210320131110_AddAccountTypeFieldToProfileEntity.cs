using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseBook.WebApi.Migrations
{
    public partial class AddAccountTypeFieldToProfileEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountType",
                table: "profiles",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountType",
                table: "profiles");
        }
    }
}
