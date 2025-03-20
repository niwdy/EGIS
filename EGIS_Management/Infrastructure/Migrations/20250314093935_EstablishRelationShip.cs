using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EstablishRelationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MasterTableCodesId",
                table: "MasterTableSubCodes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MasterTableSubCodes_MasterTableCodesId",
                table: "MasterTableSubCodes",
                column: "MasterTableCodesId");

            migrationBuilder.AddForeignKey(
                name: "FK_MasterTableSubCodes_MasterTableCodes_MasterTableCodesId",
                table: "MasterTableSubCodes",
                column: "MasterTableCodesId",
                principalTable: "MasterTableCodes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MasterTableSubCodes_MasterTableCodes_MasterTableCodesId",
                table: "MasterTableSubCodes");

            migrationBuilder.DropIndex(
                name: "IX_MasterTableSubCodes_MasterTableCodesId",
                table: "MasterTableSubCodes");

            migrationBuilder.DropColumn(
                name: "MasterTableCodesId",
                table: "MasterTableSubCodes");
        }
    }
}
