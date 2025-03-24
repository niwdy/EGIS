using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class modifymastercodemodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubCode",
                table: "MasterTableCodes",
                newName: "Subcode");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "MasterTableCodes",
                newName: "Createdat");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Subcode",
                table: "MasterTableCodes",
                newName: "SubCode");

            migrationBuilder.RenameColumn(
                name: "Createdat",
                table: "MasterTableCodes",
                newName: "CreatedAt");
        }
    }
}
