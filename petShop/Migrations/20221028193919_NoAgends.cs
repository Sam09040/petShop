using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace petShop.Migrations
{
    public partial class NoAgends : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agends");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agends",
                columns: table => new
                {
                    idAgend = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PetidPet = table.Column<int>(type: "int", nullable: false),
                    descrição = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dtAgend = table.Column<DateTime>(type: "DateTime", nullable: false),
                    idPet = table.Column<int>(type: "int", nullable: false),
                    tipoAgend = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agends", x => x.idAgend);
                    table.ForeignKey(
                        name: "FK_Agends_Pets_PetidPet",
                        column: x => x.PetidPet,
                        principalTable: "Pets",
                        principalColumn: "idPet",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Agends_PetidPet",
                table: "Agends",
                column: "PetidPet");
        }
    }
}
