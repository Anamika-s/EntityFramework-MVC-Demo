using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameWork_MVCDemo.Migrations
{
    public partial class SeededCourseData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.EnsureSchema(
                name: "Admin");

            migrationBuilder.RenameTable(
                name: "tblStudent",
                newName: "tblStudent",
                newSchema: "Admin");

            migrationBuilder.RenameTable(
                name: "Batches",
                newName: "Batches",
                newSchema: "Admin");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "tblCourse",
                newSchema: "Admin");

            migrationBuilder.AlterColumn<string>(
                name: "CourseName",
                schema: "Admin",
                table: "tblCourse",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblCourse",
                schema: "Admin",
                table: "tblCourse",
                column: "CourseId");

            migrationBuilder.InsertData(
                schema: "Admin",
                table: "tblCourse",
                columns: new[] { "CourseId", "CourseDuration", "CourseName" },
                values: new object[] { 1, 10, "C#" });

            migrationBuilder.InsertData(
                schema: "Admin",
                table: "tblCourse",
                columns: new[] { "CourseId", "CourseDuration", "CourseName" },
                values: new object[] { 2, 40, "DOtNet" });

            migrationBuilder.InsertData(
                schema: "Admin",
                table: "tblCourse",
                columns: new[] { "CourseId", "CourseDuration", "CourseName" },
                values: new object[] { 3, 20, "Java" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tblCourse",
                schema: "Admin",
                table: "tblCourse");

            migrationBuilder.DeleteData(
                schema: "Admin",
                table: "tblCourse",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Admin",
                table: "tblCourse",
                keyColumn: "CourseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Admin",
                table: "tblCourse",
                keyColumn: "CourseId",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "tblStudent",
                schema: "Admin",
                newName: "tblStudent");

            migrationBuilder.RenameTable(
                name: "Batches",
                schema: "Admin",
                newName: "Batches");

            migrationBuilder.RenameTable(
                name: "tblCourse",
                schema: "Admin",
                newName: "Courses");

            migrationBuilder.AlterColumn<string>(
                name: "CourseName",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "CourseId");
        }
    }
}
