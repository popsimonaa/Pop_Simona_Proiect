using Microsoft.EntityFrameworkCore.Migrations;

namespace Pop_Simona_Proiect.Migrations
{
    public partial class TipConsultatie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PretConsult",
                table: "ProgramareMedic",
                type: "decimal(6, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "SpitalID",
                table: "ProgramareMedic",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Consultatie",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DenumireConsultatie = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultatie", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Spital",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeSpital = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spital", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TipConsultatie",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipID = table.Column<int>(nullable: false),
                    ProgramareMedicID = table.Column<int>(nullable: true),
                    CategoryID = table.Column<int>(nullable: false),
                    ConsultatieID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipConsultatie", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TipConsultatie_Consultatie_ConsultatieID",
                        column: x => x.ConsultatieID,
                        principalTable: "Consultatie",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TipConsultatie_ProgramareMedic_ProgramareMedicID",
                        column: x => x.ProgramareMedicID,
                        principalTable: "ProgramareMedic",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProgramareMedic_SpitalID",
                table: "ProgramareMedic",
                column: "SpitalID");

            migrationBuilder.CreateIndex(
                name: "IX_TipConsultatie_ConsultatieID",
                table: "TipConsultatie",
                column: "ConsultatieID");

            migrationBuilder.CreateIndex(
                name: "IX_TipConsultatie_ProgramareMedicID",
                table: "TipConsultatie",
                column: "ProgramareMedicID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProgramareMedic_Spital_SpitalID",
                table: "ProgramareMedic",
                column: "SpitalID",
                principalTable: "Spital",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProgramareMedic_Spital_SpitalID",
                table: "ProgramareMedic");

            migrationBuilder.DropTable(
                name: "Spital");

            migrationBuilder.DropTable(
                name: "TipConsultatie");

            migrationBuilder.DropTable(
                name: "Consultatie");

            migrationBuilder.DropIndex(
                name: "IX_ProgramareMedic_SpitalID",
                table: "ProgramareMedic");

            migrationBuilder.DropColumn(
                name: "SpitalID",
                table: "ProgramareMedic");

            migrationBuilder.AlterColumn<decimal>(
                name: "PretConsult",
                table: "ProgramareMedic",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6, 2)");
        }
    }
}
