using Microsoft.EntityFrameworkCore.Migrations;

namespace Cotix.Infrastructure.Migrations
{
    public partial class Updated_Quotation_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "SubTotal",
                table: "Quotations",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubTotal",
                table: "Quotations");
        }
    }
}
