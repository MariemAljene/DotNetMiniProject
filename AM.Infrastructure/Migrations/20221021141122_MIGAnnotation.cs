using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    public partial class MIGAnnotation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Passengers_PassengersListId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Planes_MyPlanePlaneId",
                table: "Flights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger");

            migrationBuilder.DropIndex(
                name: "IX_FlightPassenger_PassengersListId",
                table: "FlightPassenger");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "PassengersListId",
                table: "FlightPassenger");

            migrationBuilder.RenameColumn(
                name: "MyPlanePlaneId",
                table: "Flights",
                newName: "PlaneId");

            migrationBuilder.RenameColumn(
                name: "AirlineLogo",
                table: "Flights",
                newName: "Airline");

            migrationBuilder.RenameIndex(
                name: "IX_Flights_MyPlanePlaneId",
                table: "Flights",
                newName: "IX_Flights_PlaneId");

            migrationBuilder.AlterColumn<string>(
                name: "TelNumber",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PasseportNumber",
                table: "Passengers",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Passengers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PassengersListPasseportNumber",
                table: "FlightPassenger",
                type: "nvarchar(7)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers",
                column: "PasseportNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger",
                columns: new[] { "FlightsFlightId", "PassengersListPasseportNumber" });

            migrationBuilder.CreateIndex(
                name: "IX_FlightPassenger_PassengersListPasseportNumber",
                table: "FlightPassenger",
                column: "PassengersListPasseportNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Passengers_PassengersListPasseportNumber",
                table: "FlightPassenger",
                column: "PassengersListPasseportNumber",
                principalTable: "Passengers",
                principalColumn: "PasseportNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Planes_PlaneId",
                table: "Flights",
                column: "PlaneId",
                principalTable: "Planes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Passengers_PassengersListPasseportNumber",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Planes_PlaneId",
                table: "Flights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger");

            migrationBuilder.DropIndex(
                name: "IX_FlightPassenger_PassengersListPasseportNumber",
                table: "FlightPassenger");

            migrationBuilder.DropColumn(
                name: "PassengersListPasseportNumber",
                table: "FlightPassenger");

            migrationBuilder.RenameColumn(
                name: "PlaneId",
                table: "Flights",
                newName: "MyPlanePlaneId");

            migrationBuilder.RenameColumn(
                name: "Airline",
                table: "Flights",
                newName: "AirlineLogo");

            migrationBuilder.RenameIndex(
                name: "IX_Flights_PlaneId",
                table: "Flights",
                newName: "IX_Flights_MyPlanePlaneId");

            migrationBuilder.AlterColumn<int>(
                name: "TelNumber",
                table: "Passengers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PasseportNumber",
                table: "Passengers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Passengers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "PassengersListId",
                table: "FlightPassenger",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger",
                columns: new[] { "FlightsFlightId", "PassengersListId" });

            migrationBuilder.CreateIndex(
                name: "IX_FlightPassenger_PassengersListId",
                table: "FlightPassenger",
                column: "PassengersListId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Passengers_PassengersListId",
                table: "FlightPassenger",
                column: "PassengersListId",
                principalTable: "Passengers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Planes_MyPlanePlaneId",
                table: "Flights",
                column: "MyPlanePlaneId",
                principalTable: "Planes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
