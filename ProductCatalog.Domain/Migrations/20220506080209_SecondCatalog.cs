using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductCatalog.Domain.Migrations
{
    public partial class SecondCatalog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserDetails_User_UserDetailsId",
                table: "UserDetails");

            migrationBuilder.RenameColumn(
                name: "UserDetailsId",
                table: "UserDetails",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserDetails_UserDetailsId",
                table: "UserDetails",
                newName: "IX_UserDetails_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetails_User_UserId",
                table: "UserDetails",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserDetails_User_UserId",
                table: "UserDetails");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserDetails",
                newName: "UserDetailsId");

            migrationBuilder.RenameIndex(
                name: "IX_UserDetails_UserId",
                table: "UserDetails",
                newName: "IX_UserDetails_UserDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetails_User_UserDetailsId",
                table: "UserDetails",
                column: "UserDetailsId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
