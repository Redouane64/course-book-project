using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseBook.WebApi.Migrations
{
    public partial class updatefknames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_directions_faculties_FacultyId",
                table: "directions");

            migrationBuilder.DropForeignKey(
                name: "FK_groups_directions_DirectionId",
                table: "groups");

            migrationBuilder.DropIndex(
                name: "IX_groups_DirectionId",
                table: "groups");

            migrationBuilder.DropIndex(
                name: "IX_directions_FacultyId",
                table: "directions");

            migrationBuilder.AddColumn<Guid>(
                name: "direction_id",
                table: "groups",
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
                name: "IX_groups_direction_id",
                table: "groups",
                column: "direction_id");

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
                name: "FK_groups_directions_direction_id",
                table: "groups",
                column: "direction_id",
                principalTable: "directions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_directions_faculties_faculty_id",
                table: "directions");

            migrationBuilder.DropForeignKey(
                name: "FK_groups_directions_direction_id",
                table: "groups");

            migrationBuilder.DropIndex(
                name: "IX_groups_direction_id",
                table: "groups");

            migrationBuilder.DropIndex(
                name: "IX_directions_faculty_id",
                table: "directions");

            migrationBuilder.DropColumn(
                name: "direction_id",
                table: "groups");

            migrationBuilder.DropColumn(
                name: "faculty_id",
                table: "directions");

            migrationBuilder.CreateIndex(
                name: "IX_groups_DirectionId",
                table: "groups",
                column: "DirectionId");

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
                name: "FK_groups_directions_DirectionId",
                table: "groups",
                column: "DirectionId",
                principalTable: "directions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
