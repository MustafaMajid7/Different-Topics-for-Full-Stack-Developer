using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YieldReturn.Migrations
{
    /// <inheritdoc />
    public partial class addisDeletedtocourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                schema: "University",
                table: "Courses",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isDeleted",
                schema: "University",
                table: "Courses");
        }
    }
}
