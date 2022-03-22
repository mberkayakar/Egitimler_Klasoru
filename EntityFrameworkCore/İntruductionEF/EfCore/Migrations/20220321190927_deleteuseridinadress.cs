using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCore.Migrations
{
    public partial class deleteuseridinadress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_Users_UserId",
                table: "Adresses");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Adresses",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Adresses_UserId",
                table: "Adresses",
                newName: "IX_Adresses_UserID");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Adresses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_Users_UserID",
                table: "Adresses",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_Users_UserID",
                table: "Adresses");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Adresses",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Adresses_UserID",
                table: "Adresses",
                newName: "IX_Adresses_UserId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Adresses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_Users_UserId",
                table: "Adresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
