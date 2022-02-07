using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppCRUD.Migrations
{
    public partial class EdctionUpdte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Education_Employees_EmployeeInfoEmployeeId",
                table: "Education");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeInfoEmployeeId",
                table: "Education",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Education",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Education_Employees_EmployeeInfoEmployeeId",
                table: "Education",
                column: "EmployeeInfoEmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Education_Employees_EmployeeInfoEmployeeId",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Education");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeInfoEmployeeId",
                table: "Education",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Education_Employees_EmployeeInfoEmployeeId",
                table: "Education",
                column: "EmployeeInfoEmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId");
        }
    }
}
