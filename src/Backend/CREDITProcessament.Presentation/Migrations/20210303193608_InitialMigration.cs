using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CREDITProcessament.Presentation.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_User",
                columns: table => new
                {
                    CPF = table.Column<string>(type: "nchar(11)", fixedLength: true, maxLength: 11, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_User", x => x.CPF);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Processament",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    UserCPF = table.Column<string>(type: "nchar(11)", fixedLength: true, maxLength: 11, nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    IsProcessed = table.Column<bool>(type: "bit", nullable: false),
                    LastProcessedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Processament", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Processament_Tbl_User_UserCPF",
                        column: x => x.UserCPF,
                        principalTable: "Tbl_User",
                        principalColumn: "CPF",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Processament_UserCPF",
                table: "Tbl_Processament",
                column: "UserCPF",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Processament");

            migrationBuilder.DropTable(
                name: "Tbl_User");
        }
    }
}
