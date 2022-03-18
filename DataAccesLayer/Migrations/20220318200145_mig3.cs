using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "CommentStatus",
                table: "Commnets",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BlogID",
                table: "Commnets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Commnets_BlogID",
                table: "Commnets",
                column: "BlogID");

            migrationBuilder.AddForeignKey(
                name: "FK_Commnets_Blogs_BlogID",
                table: "Commnets",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commnets_Blogs_BlogID",
                table: "Commnets");

            migrationBuilder.DropIndex(
                name: "IX_Commnets_BlogID",
                table: "Commnets");

            migrationBuilder.DropColumn(
                name: "BlogID",
                table: "Commnets");

            migrationBuilder.AlterColumn<string>(
                name: "CommentStatus",
                table: "Commnets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
