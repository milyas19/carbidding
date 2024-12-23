using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuctionService.Data.Migrations
{
    /// <inheritdoc />
    public partial class TableNameChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Aunctions_AuctionId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Aunctions",
                table: "Aunctions");

            migrationBuilder.RenameTable(
                name: "Aunctions",
                newName: "Auctions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Auctions",
                table: "Auctions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Auctions_AuctionId",
                table: "Items",
                column: "AuctionId",
                principalTable: "Auctions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Auctions_AuctionId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Auctions",
                table: "Auctions");

            migrationBuilder.RenameTable(
                name: "Auctions",
                newName: "Aunctions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Aunctions",
                table: "Aunctions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Aunctions_AuctionId",
                table: "Items",
                column: "AuctionId",
                principalTable: "Aunctions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
