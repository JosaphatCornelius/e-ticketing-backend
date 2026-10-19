using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Container_Testing.Migrations
{
    /// <inheritdoc />
    public partial class FirstInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AirlinesTable",
                columns: table => new
                {
                    AirlineID = table.Column<string>(type: "text", nullable: false),
                    TicketSold = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirlinesTable", x => x.AirlineID);
                });

            migrationBuilder.CreateTable(
                name: "BookingsTable",
                columns: table => new
                {
                    BookingID = table.Column<string>(type: "text", nullable: false),
                    UserID = table.Column<string>(type: "text", nullable: true),
                    FlightID = table.Column<string>(type: "text", nullable: true),
                    BookingPrice = table.Column<int>(type: "integer", nullable: true),
                    SeatAmount = table.Column<int>(type: "integer", nullable: true),
                    PaymentStatus = table.Column<string>(type: "text", nullable: true),
                    BookingConfirmation = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingsTable", x => x.BookingID);
                });

            migrationBuilder.CreateTable(
                name: "FlightsTable",
                columns: table => new
                {
                    FlightID = table.Column<string>(type: "text", nullable: false),
                    FlightDestination = table.Column<string>(type: "text", nullable: true),
                    FlightTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    FlightArrival = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    FlightFrom = table.Column<string>(type: "text", nullable: true),
                    AirlineID = table.Column<string>(type: "text", nullable: true),
                    FlightPrice = table.Column<int>(type: "integer", nullable: true),
                    FlightSeat = table.Column<int>(type: "integer", nullable: true),
                    BookedSeat = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightsTable", x => x.FlightID);
                });

            migrationBuilder.CreateTable(
                name: "UserTable",
                columns: table => new
                {
                    UserID = table.Column<string>(type: "text", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: true),
                    UserPassword = table.Column<string>(type: "text", nullable: true),
                    UserRole = table.Column<string>(type: "text", nullable: true),
                    UserEmail = table.Column<string>(type: "text", nullable: true),
                    UserAddress = table.Column<string>(type: "text", nullable: true),
                    Birthday = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTable", x => x.UserID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AirlinesTable");

            migrationBuilder.DropTable(
                name: "BookingsTable");

            migrationBuilder.DropTable(
                name: "FlightsTable");

            migrationBuilder.DropTable(
                name: "UserTable");
        }
    }
}
