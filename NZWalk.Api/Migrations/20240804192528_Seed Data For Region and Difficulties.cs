using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalk.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataForRegionandDifficulties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "difficalties",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { new Guid("3b4d0475-2317-4889-bf97-4fed0a7bcc1c"), "Medium" },
                    { new Guid("4fa8dfb5-2007-40fa-a240-e68d2d34f4f3"), "Easy" },
                    { new Guid("7c581fc3-2a82-4e2f-9b37-8fc0e1a06279"), "Hard" }
                });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "id", "code", "name", "regionImageUrl" },
                values: new object[,]
                {
                    { new Guid("6d83e31a-d6b2-4b58-a9be-2d3a5823ff8c"), "CHC", "Christchurch", "https://pixabay.com/images/search/christchurch/" },
                    { new Guid("9d9e2b79-93cb-4a9d-81a6-3a72e3c4b8f2"), "HLZ", "Hamilton", "https://pixabay.com/images/search/hamilton/" },
                    { new Guid("a1f2c3d4-e5f6-7a8b-9c0d-e1f2a3b4c5d6"), "DUD", "Dunedin", "https://pixabay.com/images/search/dunedin/" },
                    { new Guid("b2c3d4e5-f6a7-8b9c-0d1e-f2a3b4c5d6e7"), "TRG", "Tauranga", "https://pixabay.com/images/search/tauranga/" },
                    { new Guid("bb9add6b-74b9-4803-bcdc-1df37cbee169"), "AKL", "Auckland", "https://pixabay.com/images/search/auckland/" },
                    { new Guid("c3d4e5f6-a7b8-9c0d-1e2f-a3b4c5d6e7f8"), "NPE", "Napier", "https://pixabay.com/images/search/napier/" },
                    { new Guid("d4e5f6a7-b8c9-0d1e-2f3a-b4c5d6e7f8a9"), "ROT", "Rotorua", "https://pixabay.com/images/search/rotorua/" },
                    { new Guid("e3b0c442-98fc-1c14-9af7-1a1768dfefaa"), "WLG", "Wellington", "https://pixabay.com/images/search/wellington/" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "difficalties",
                keyColumn: "id",
                keyValue: new Guid("3b4d0475-2317-4889-bf97-4fed0a7bcc1c"));

            migrationBuilder.DeleteData(
                table: "difficalties",
                keyColumn: "id",
                keyValue: new Guid("4fa8dfb5-2007-40fa-a240-e68d2d34f4f3"));

            migrationBuilder.DeleteData(
                table: "difficalties",
                keyColumn: "id",
                keyValue: new Guid("7c581fc3-2a82-4e2f-9b37-8fc0e1a06279"));

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "id",
                keyValue: new Guid("6d83e31a-d6b2-4b58-a9be-2d3a5823ff8c"));

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "id",
                keyValue: new Guid("9d9e2b79-93cb-4a9d-81a6-3a72e3c4b8f2"));

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "id",
                keyValue: new Guid("a1f2c3d4-e5f6-7a8b-9c0d-e1f2a3b4c5d6"));

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "id",
                keyValue: new Guid("b2c3d4e5-f6a7-8b9c-0d1e-f2a3b4c5d6e7"));

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "id",
                keyValue: new Guid("bb9add6b-74b9-4803-bcdc-1df37cbee169"));

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "id",
                keyValue: new Guid("c3d4e5f6-a7b8-9c0d-1e2f-a3b4c5d6e7f8"));

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "id",
                keyValue: new Guid("d4e5f6a7-b8c9-0d1e-2f3a-b4c5d6e7f8a9"));

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "id",
                keyValue: new Guid("e3b0c442-98fc-1c14-9af7-1a1768dfefaa"));
        }
    }
}
