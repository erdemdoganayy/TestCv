using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppCRUD.Migrations
{
    public partial class SchoolDependencyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SchoolId",
                table: "Educations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Educations_SchoolId",
                table: "Educations",
                column: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Schools_SchoolId",
                table: "Educations",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Schools_SchoolId",
                table: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_Educations_SchoolId",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "Educations");
        }
    }
}
