using Microsoft.EntityFrameworkCore.Migrations;

namespace ArmySchoolEntityFramework.Migrations
{
    public partial class AddAdmis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Subject",
                newName: "Subjects");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Phone",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "Subjects",
                table: "Subject",
                newName: "Title");
        }
    }
}
