using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppCRUD.Migrations
{
    public partial class UpdatedEducations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Educations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Educations_CountryId",
                table: "Educations",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Countries_CountryId",
                table: "Educations",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Countries_CountryId",
                table: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_Educations_CountryId",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Educations");
        }
    }
}
