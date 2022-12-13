using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class UpdatedCourseCategoryRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseCategoryId",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseCategoryId",
                table: "Blogs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_CourseCategoryId",
                table: "Events",
                column: "CourseCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CourseCategoryId",
                table: "Blogs",
                column: "CourseCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_CourseCategories_CourseCategoryId",
                table: "Blogs",
                column: "CourseCategoryId",
                principalTable: "CourseCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_CourseCategories_CourseCategoryId",
                table: "Events",
                column: "CourseCategoryId",
                principalTable: "CourseCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_CourseCategories_CourseCategoryId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_CourseCategories_CourseCategoryId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_CourseCategoryId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_CourseCategoryId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "CourseCategoryId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "CourseCategoryId",
                table: "Blogs");
        }
    }
}
