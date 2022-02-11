using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Noisy.Migrations
{
    public partial class SupplaierIdNullAble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Suppliers_SupplierId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_SupplierId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SupplierId",
                table: "Users",
                column: "SupplierId",
                unique: true,
                filter: "[SupplierId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Suppliers_SupplierId",
                table: "Users",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Suppliers_SupplierId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_SupplierId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_SupplierId",
                table: "Users",
                column: "SupplierId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Suppliers_SupplierId",
                table: "Users",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
