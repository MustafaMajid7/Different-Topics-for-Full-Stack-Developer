using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YieldReturn.Migrations
{
    /// <inheritdoc />
    public partial class modifycourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                schema: "University",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "degree",
                schema: "University",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "degree",
                schema: "University",
                table: "Courses");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "University",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
