using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class ReAddPhoneNumberConfirmedToAspNetUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
    name: "PhoneNumberConfirmed",
    table: "AspNetUsers",
    nullable: false,
    defaultValue: false);  // Varsayılan değeri ihtiyaca göre ayarlayın

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
