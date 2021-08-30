using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameWork_MVCDemo.Migrations
{
    public partial class AddedForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BatchId",
                table: "tblStudent",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tblStudent_BatchId",
                table: "tblStudent",
                column: "BatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblStudent_Batches_BatchId",
                table: "tblStudent",
                column: "BatchId",
                principalTable: "Batches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblStudent_Batches_BatchId",
                table: "tblStudent");

            migrationBuilder.DropIndex(
                name: "IX_tblStudent_BatchId",
                table: "tblStudent");

            migrationBuilder.DropColumn(
                name: "BatchId",
                table: "tblStudent");
        }
    }
}
