using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HymnStocks.Migrations
{
    /// <inheritdoc />
    public partial class initizationDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HymnInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HymnName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CopyRight = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    HymnLanguage = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PublishDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HymnInfo", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HymnInfo");
        }
    }
}
