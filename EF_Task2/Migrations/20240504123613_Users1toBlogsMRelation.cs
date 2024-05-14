using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Task2.Migrations
{
    /// <inheritdoc />
    public partial class Users1toBlogsMRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_blogs_UsersId",
                table: "blogs",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_blogs_users_UsersId",
                table: "blogs",
                column: "UsersId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blogs_users_UsersId",
                table: "blogs");

            migrationBuilder.DropIndex(
                name: "IX_blogs_UsersId",
                table: "blogs");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "blogs");
        }
    }
}
