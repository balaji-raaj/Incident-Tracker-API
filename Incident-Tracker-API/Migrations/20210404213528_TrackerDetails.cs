using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Incident_Tracker_API.Migrations
{
    [ExcludeFromCodeCoverage]
    public partial class TrackerDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbTracker",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Severity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbTracker", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "tbTracker",
                columns: new[] { "Id", "CreatedDate", "Description", "Severity", "Status", "UpdateDate" },
                values: new object[] { 1, new DateTime(2021, 4, 5, 3, 5, 27, 773, DateTimeKind.Local).AddTicks(3377), "Test1", "High", "inprogress", new DateTime(2021, 4, 5, 3, 5, 27, 775, DateTimeKind.Local).AddTicks(2326) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbTracker");
        }
    }
}
