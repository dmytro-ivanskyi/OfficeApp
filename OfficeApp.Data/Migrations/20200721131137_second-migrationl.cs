using Microsoft.EntityFrameworkCore.Migrations;

namespace OfficeApp.Data.Migrations
{
    public partial class secondmigrationl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Offices_OfficeId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "OfficeId",
                table: "Users",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Offices_OfficeId",
                table: "Users",
                column: "OfficeId",
                principalTable: "Offices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Offices_OfficeId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "OfficeId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Offices_OfficeId",
                table: "Users",
                column: "OfficeId",
                principalTable: "Offices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
