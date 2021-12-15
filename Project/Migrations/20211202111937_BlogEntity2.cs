using Microsoft.EntityFrameworkCore.Migrations;

namespace blog_net_core.Migrations
{
    public partial class BlogEntity2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blogs_POSTS_PostId",
                table: "blogs");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "blogs",
                newName: "postId");

            migrationBuilder.RenameIndex(
                name: "IX_blogs_PostId",
                table: "blogs",
                newName: "IX_blogs_postId");

            migrationBuilder.AlterColumn<int>(
                name: "postId",
                table: "blogs",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_blogs_POSTS_postId",
                table: "blogs",
                column: "postId",
                principalTable: "POSTS",
                principalColumn: "postId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blogs_POSTS_postId",
                table: "blogs");

            migrationBuilder.RenameColumn(
                name: "postId",
                table: "blogs",
                newName: "PostId");

            migrationBuilder.RenameIndex(
                name: "IX_blogs_postId",
                table: "blogs",
                newName: "IX_blogs_PostId");

            migrationBuilder.AlterColumn<int>(
                name: "PostId",
                table: "blogs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_blogs_POSTS_PostId",
                table: "blogs",
                column: "PostId",
                principalTable: "POSTS",
                principalColumn: "postId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
