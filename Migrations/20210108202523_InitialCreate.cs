using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pop_Simona_Proiect.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProgramareMedic",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeMedic = table.Column<string>(nullable: true),
                    Specializare = table.Column<string>(nullable: true),
                    PretConsult = table.Column<decimal>(nullable: false),
                    DataConsult = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramareMedic", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProgramareMedic");
        }
    }
}
