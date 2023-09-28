using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComancheSocialNetwork.Migrations
{
    /// <inheritdoc />
    public partial class Init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_posts_attachments_AttachmentId",
                table: "posts");

            migrationBuilder.DropIndex(
                name: "IX_posts_AttachmentId",
                table: "posts");

            migrationBuilder.DropColumn(
                name: "AttachmentId",
                table: "posts");

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "attachments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_attachments_PostId",
                table: "attachments",
                column: "PostId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_attachments_posts_PostId",
                table: "attachments",
                column: "PostId",
                principalTable: "posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_attachments_posts_PostId",
                table: "attachments");

            migrationBuilder.DropIndex(
                name: "IX_attachments_PostId",
                table: "attachments");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "attachments");

            migrationBuilder.AddColumn<int>(
                name: "AttachmentId",
                table: "posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_posts_AttachmentId",
                table: "posts",
                column: "AttachmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_posts_attachments_AttachmentId",
                table: "posts",
                column: "AttachmentId",
                principalTable: "attachments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
