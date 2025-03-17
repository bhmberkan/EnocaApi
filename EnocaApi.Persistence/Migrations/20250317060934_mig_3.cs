using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnocaApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarrierConfigurations_Carriers_CarriersId",
                table: "CarrierConfigurations");

            migrationBuilder.DropColumn(
                name: "CarrierId",
                table: "CarrierConfigurations");

            migrationBuilder.RenameColumn(
                name: "ORderCarrierCost",
                table: "Orders",
                newName: "OrderCarrierCost");

            migrationBuilder.RenameColumn(
                name: "CarriersId",
                table: "CarrierConfigurations",
                newName: "carriersId");

            migrationBuilder.RenameIndex(
                name: "IX_CarrierConfigurations_CarriersId",
                table: "CarrierConfigurations",
                newName: "IX_CarrierConfigurations_carriersId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarrierConfigurations_Carriers_carriersId",
                table: "CarrierConfigurations",
                column: "carriersId",
                principalTable: "Carriers",
                principalColumn: "CarriersId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarrierConfigurations_Carriers_carriersId",
                table: "CarrierConfigurations");

            migrationBuilder.RenameColumn(
                name: "OrderCarrierCost",
                table: "Orders",
                newName: "ORderCarrierCost");

            migrationBuilder.RenameColumn(
                name: "carriersId",
                table: "CarrierConfigurations",
                newName: "CarriersId");

            migrationBuilder.RenameIndex(
                name: "IX_CarrierConfigurations_carriersId",
                table: "CarrierConfigurations",
                newName: "IX_CarrierConfigurations_CarriersId");

            migrationBuilder.AddColumn<int>(
                name: "CarrierId",
                table: "CarrierConfigurations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_CarrierConfigurations_Carriers_CarriersId",
                table: "CarrierConfigurations",
                column: "CarriersId",
                principalTable: "Carriers",
                principalColumn: "CarriersId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
