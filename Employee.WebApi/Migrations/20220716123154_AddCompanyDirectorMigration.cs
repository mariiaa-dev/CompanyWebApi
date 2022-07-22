using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyWebApi.Migrations
{
    public partial class AddCompanyDirectorMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DirectorId",
                table: "Company",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Company_DirectorId",
                table: "Company",
                column: "DirectorId");

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

            migrationBuilder.DropIndex(
                name: "IX_Company_DirectorId",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "DirectorId",
                table: "Company");
        }
    }
}
