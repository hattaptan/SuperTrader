using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SuperTrader.DataAccess.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Share",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    shareCode = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    shareName = table.Column<string>(type: "text", nullable: false),
                    price = table.Column<int>(type: "integer", nullable: false),
                    percent = table.Column<decimal>(type: "numeric", nullable: false),
                    updatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Share", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Traders",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    firstName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    lastName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traders", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Buy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    shareId = table.Column<int>(type: "integer", nullable: false),
                    traderId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Buy_Share_shareId",
                        column: x => x.shareId,
                        principalTable: "Share",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Buy_Traders_traderId",
                        column: x => x.traderId,
                        principalTable: "Traders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sell",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    shareId = table.Column<int>(type: "integer", nullable: false),
                    traderId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sell", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sell_Share_shareId",
                        column: x => x.shareId,
                        principalTable: "Share",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sell_Traders_traderId",
                        column: x => x.traderId,
                        principalTable: "Traders",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Portfolio",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    traderId = table.Column<int>(type: "integer", nullable: false),
                    sellId = table.Column<int>(type: "integer", nullable: false),
                    buyId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolio", x => x.id);
                    table.ForeignKey(
                        name: "FK_Portfolio_Buy_buyId",
                        column: x => x.buyId,
                        principalTable: "Buy",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Portfolio_Sell_sellId",
                        column: x => x.sellId,
                        principalTable: "Sell",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Portfolio_Traders_traderId",
                        column: x => x.traderId,
                        principalTable: "Traders",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Buy_shareId",
                table: "Buy",
                column: "shareId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Buy_traderId",
                table: "Buy",
                column: "traderId");

            migrationBuilder.CreateIndex(
                name: "IX_Portfolio_buyId",
                table: "Portfolio",
                column: "buyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Portfolio_sellId",
                table: "Portfolio",
                column: "sellId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Portfolio_traderId",
                table: "Portfolio",
                column: "traderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sell_shareId",
                table: "Sell",
                column: "shareId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sell_traderId",
                table: "Sell",
                column: "traderId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Portfolio");

            migrationBuilder.DropTable(
                name: "Buy");

            migrationBuilder.DropTable(
                name: "Sell");

            migrationBuilder.DropTable(
                name: "Share");

            migrationBuilder.DropTable(
                name: "Traders");
        }
    }
}
