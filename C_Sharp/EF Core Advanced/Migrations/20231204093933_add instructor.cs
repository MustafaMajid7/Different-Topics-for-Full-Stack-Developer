using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core_Advanced.Migrations
{
    /// <inheritdoc />
    public partial class addinstructor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InstructorID",
                schema: "University",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Instructors",
                schema: "University",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_InstructorID",
                schema: "University",
                table: "Students",
                column: "InstructorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Instructors_InstructorID",
                schema: "University",
                table: "Students",
                column: "InstructorID",
                principalSchema: "University",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Instructors_InstructorID",
                schema: "University",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Instructors",
                schema: "University");

            migrationBuilder.DropIndex(
                name: "IX_Students_InstructorID",
                schema: "University",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "InstructorID",
                schema: "University",
                table: "Students");
        }
    }
}
