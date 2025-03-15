using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnocaApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarrierId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CarriersId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CarrierId",
                table: "CarrierConfigurations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CarriersId",
                table: "CarrierConfigurations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CarriersId",
                table: "Orders",
                column: "CarriersId");

            migrationBuilder.CreateIndex(
                name: "IX_CarrierConfigurations_CarriersId",
                table: "CarrierConfigurations",
                column: "CarriersId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarrierConfigurations_Carriers_CarriersId",
                table: "CarrierConfigurations",
                column: "CarriersId",
                principalTable: "Carriers",
                principalColumn: "CarriersId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Carriers_CarriersId",
                table: "Orders",
                column: "CarriersId",
                principalTable: "Carriers",
                principalColumn: "CarriersId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarrierConfigurations_Carriers_CarriersId",
                table: "CarrierConfigurations");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Carriers_CarriersId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CarriersId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_CarrierConfigurations_CarriersId",
                table: "CarrierConfigurations");

            migrationBuilder.DropColumn(
                name: "CarrierId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CarriersId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CarrierId",
                table: "CarrierConfigurations");

            migrationBuilder.DropColumn(
                name: "CarriersId",
                table: "CarrierConfigurations");
        }
    }
}
