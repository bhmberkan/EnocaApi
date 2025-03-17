using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnocaApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Carriers_CarriersId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CarrierId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "CarriersId",
                table: "Orders",
                newName: "carriersId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CarriersId",
                table: "Orders",
                newName: "IX_Orders_carriersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Carriers_carriersId",
                table: "Orders",
                column: "carriersId",
                principalTable: "Carriers",
                principalColumn: "CarriersId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Carriers_carriersId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "carriersId",
                table: "Orders",
                newName: "CarriersId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_carriersId",
                table: "Orders",
                newName: "IX_Orders_CarriersId");

            migrationBuilder.AddColumn<int>(
                name: "CarrierId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Carriers_CarriersId",
                table: "Orders",
                column: "CarriersId",
                principalTable: "Carriers",
                principalColumn: "CarriersId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
