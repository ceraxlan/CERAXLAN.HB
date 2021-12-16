using Microsoft.EntityFrameworkCore.Migrations;

namespace CERAXLAN.HB.DataAccess.Migrations
{
    public partial class DateTime2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CampaignStartDate",
                table: "Campaigns",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CampaignStartDate",
                table: "Campaigns");
        }
    }
}
