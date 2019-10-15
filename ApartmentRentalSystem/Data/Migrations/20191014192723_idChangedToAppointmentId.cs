using Microsoft.EntityFrameworkCore.Migrations;

namespace ApartmentRentalSystem.Data.Migrations
{
    public partial class idChangedToAppointmentId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Appointments",
                newName: "AppointmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AppointmentId",
                table: "Appointments",
                newName: "Id");
        }
    }
}
