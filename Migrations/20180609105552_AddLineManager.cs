using Microsoft.EntityFrameworkCore.Migrations;

namespace aspnetcore13.Migrations
{
    public partial class AddLineManager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LineManager",
                table: "Attendees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LineManager",
                table: "Attendees");
        }
    }
}
