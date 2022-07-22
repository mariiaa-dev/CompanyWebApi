using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyWebApi.Migrations
{
    public partial class AddCompanyDirectorRequiredMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_Employee_DirectorId",
                table: "Company");

            migrationBuilder.AlterColumn<int>(
                name: "DirectorId",
                table: "Company",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Employee_DirectorId",
                table: "Company",
                column: "DirectorId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_Employee_DirectorId",
                table: "Company");

            migrationBuilder.AlterColumn<int>(
                name: "DirectorId",
                table: "Company",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Employee_DirectorId",
                table: "Company",
                column: "DirectorId",
                principalTable: "Employee",
                principalColumn: "Id");
        }
    }
}
