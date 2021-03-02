using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseBook.WebApi.Migrations
{
    public partial class fix_fk_names : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_directions_disciplines_directions_DirectionId",
                table: "directions_disciplines");

            migrationBuilder.DropForeignKey(
                name: "FK_directions_disciplines_disciplines_DisciplineId",
                table: "directions_disciplines");

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
                name: "IX_directions_disciplines_DisciplineId",
                table: "directions_disciplines");

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

            migrationBuilder.CreateIndex(
                name: "IX_groups_disciplines_discipline_id",
                table: "groups_disciplines",
                column: "discipline_id");

            migrationBuilder.CreateIndex(
                name: "IX_groups_disciplines_group_id",
                table: "groups_disciplines",
                column: "group_id");

            migrationBuilder.CreateIndex(
                name: "IX_directions_disciplines_direction_id",
                table: "directions_disciplines",
                column: "direction_id");

            migrationBuilder.CreateIndex(
                name: "IX_directions_disciplines_discipline_id",
                table: "directions_disciplines",
                column: "discipline_id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_directions_disciplines_directions_direction_id",
                table: "directions_disciplines");

            migrationBuilder.DropForeignKey(
                name: "FK_directions_disciplines_disciplines_discipline_id",
                table: "directions_disciplines");

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
                name: "IX_directions_disciplines_direction_id",
                table: "directions_disciplines");

            migrationBuilder.DropIndex(
                name: "IX_directions_disciplines_discipline_id",
                table: "directions_disciplines");

            migrationBuilder.DropColumn(
                name: "discipline_id",
                table: "groups_disciplines");

            migrationBuilder.DropColumn(
                name: "group_id",
                table: "groups_disciplines");

            migrationBuilder.DropColumn(
                name: "direction_id",
                table: "directions_disciplines");

            migrationBuilder.DropColumn(
                name: "discipline_id",
                table: "directions_disciplines");

            migrationBuilder.CreateIndex(
                name: "IX_groups_disciplines_DisciplineId",
                table: "groups_disciplines",
                column: "DisciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_directions_disciplines_DisciplineId",
                table: "directions_disciplines",
                column: "DisciplineId");

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
    }
}
