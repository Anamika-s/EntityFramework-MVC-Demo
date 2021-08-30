using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameWork_MVCDemo.Migrations
{
    public partial class UpdatedStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name:StudentAddress",
                table: "tblStudent",
                newName: "StudentAddress");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentAddress",
                table: "tblStudent",
                newName: "name:StudentAddress");
        }
    }
}
