using Microsoft.EntityFrameworkCore.Migrations;

namespace fridaytest.Migrations
{
  public partial class udpatedTheModel : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropForeignKey(
          name: "FK_Locations_Destinations_DestinationId",
          table: "Locations");

      migrationBuilder.DropIndex(
          name: "IX_Locations_DestinationId",
          table: "Locations");

      migrationBuilder.DropColumn(
          name: "DestinationId",
          table: "Locations");

      migrationBuilder.AddColumn<int>(
          name: "LocationId",
          table: "Destinations",
          nullable: true);

      migrationBuilder.CreateIndex(
          name: "IX_Destinations_LocationId",
          table: "Destinations",
          column: "LocationId");

      migrationBuilder.AddForeignKey(
          name: "FK_Destinations_Locations_LocationId",
          table: "Destinations",
          column: "LocationId",
          principalTable: "Locations",
          principalColumn: "Id",
          onDelete: ReferentialAction.Restrict);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropForeignKey(
          name: "FK_Destinations_Locations_LocationId",
          table: "Destinations");

      migrationBuilder.DropIndex(
          name: "IX_Destinations_LocationId",
          table: "Destinations");

      migrationBuilder.DropColumn(
          name: "LocationId",
          table: "Destinations");

      migrationBuilder.AddColumn<int>(
          name: "DestinationId",
          table: "Locations",
          nullable: true);

      migrationBuilder.CreateIndex(
          name: "IX_Locations_DestinationId",
          table: "Locations",
          column: "DestinationId");

      migrationBuilder.AddForeignKey(
          name: "FK_Locations_Destinations_DestinationId",
          table: "Locations",
          column: "DestinationId",
          principalTable: "Destinations",
          principalColumn: "Id",
          onDelete: ReferentialAction.Restrict);
    }
  }
}
