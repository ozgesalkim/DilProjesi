using Microsoft.EntityFrameworkCore.Migrations;

namespace DilProjesi.DAL.Migrations
{
    public partial class ilkmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dil",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(maxLength: 200, nullable: false),
                    Anahtar = table.Column<string>(maxLength: 100, nullable: false),
                    Aciklama = table.Column<string>(maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proje",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proje", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sozcuk",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(maxLength: 100, nullable: false),
                    FkProjeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sozcuk", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sozcuk_Proje_FkProjeId",
                        column: x => x.FkProjeId,
                        principalTable: "Proje",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tercume",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkSozcukId = table.Column<int>(nullable: false),
                    FkDilId = table.Column<int>(nullable: false),
                    Ceviri = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tercume", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tercume_Dil_FkDilId",
                        column: x => x.FkDilId,
                        principalTable: "Dil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tercume_Sozcuk_FkSozcukId",
                        column: x => x.FkSozcukId,
                        principalTable: "Sozcuk",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sozcuk_FkProjeId",
                table: "Sozcuk",
                column: "FkProjeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tercume_FkDilId",
                table: "Tercume",
                column: "FkDilId");

            migrationBuilder.CreateIndex(
                name: "IX_Tercume_FkSozcukId",
                table: "Tercume",
                column: "FkSozcukId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tercume");

            migrationBuilder.DropTable(
                name: "Dil");

            migrationBuilder.DropTable(
                name: "Sozcuk");

            migrationBuilder.DropTable(
                name: "Proje");
        }
    }
}
