using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NZWalk.Api.Migrations
{
    /// <inheritdoc />
    public partial class initialModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "difficalties",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_difficalties", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "regions",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    regionImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_regions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "walks",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    walkImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lengthInKm = table.Column<double>(type: "float", nullable: false),
                    difficltyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    regionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    difficaltyid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_walks", x => x.id);
                    table.ForeignKey(
                        name: "FK_walks_difficalties_difficaltyid",
                        column: x => x.difficaltyid,
                        principalTable: "difficalties",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_walks_regions_regionId",
                        column: x => x.regionId,
                        principalTable: "regions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_walks_difficaltyid",
                table: "walks",
                column: "difficaltyid");

            migrationBuilder.CreateIndex(
                name: "IX_walks_regionId",
                table: "walks",
                column: "regionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "walks");

            migrationBuilder.DropTable(
                name: "difficalties");

            migrationBuilder.DropTable(
                name: "regions");
        }
    }
}
