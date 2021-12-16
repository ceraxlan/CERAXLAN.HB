using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CERAXLAN.HB.DataAccess.Migrations
{
    public partial class DateTime5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CampaignStartDate",
                table: "Campaigns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CampaignStartDate",
                table: "Campaigns");
        }
    }
}
