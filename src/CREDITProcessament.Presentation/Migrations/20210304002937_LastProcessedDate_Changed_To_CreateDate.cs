using Microsoft.EntityFrameworkCore.Migrations;

namespace CREDITProcessament.Presentation.Migrations
{
    public partial class LastProcessedDate_Changed_To_CreateDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastProcessedDate",
                table: "Tbl_Processament",
                newName: "CreateDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Tbl_Processament",
                newName: "LastProcessedDate");
        }
    }
}
