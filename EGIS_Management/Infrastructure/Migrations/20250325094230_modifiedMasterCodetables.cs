using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class modifiedMasterCodetables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodeRequired",
                table: "MasterTableSubCodes");

            migrationBuilder.DropColumn(
                name: "ColumnPosition",
                table: "MasterTableSubCodes");

            migrationBuilder.DropColumn(
                name: "Description1",
                table: "MasterTableSubCodes");

            migrationBuilder.DropColumn(
                name: "Description2",
                table: "MasterTableSubCodes");

            migrationBuilder.DropColumn(
                name: "Description3",
                table: "MasterTableSubCodes");

            migrationBuilder.DropColumn(
                name: "Description4",
                table: "MasterTableSubCodes");

            migrationBuilder.DropColumn(
                name: "Description5",
                table: "MasterTableSubCodes");

            migrationBuilder.DropColumn(
                name: "Description6",
                table: "MasterTableSubCodes");

            migrationBuilder.DropColumn(
                name: "Description7",
                table: "MasterTableSubCodes");

            migrationBuilder.DropColumn(
                name: "Heading1",
                table: "MasterTableSubCodes");

            migrationBuilder.RenameColumn(
                name: "PageNo",
                table: "MasterTableSubCodes",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "Heading2",
                table: "MasterTableSubCodes",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Subcode",
                table: "MasterTableCodes",
                newName: "Code");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "MasterTableSubCodes",
                newName: "Heading2");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "MasterTableSubCodes",
                newName: "PageNo");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "MasterTableCodes",
                newName: "Subcode");

            migrationBuilder.AddColumn<string>(
                name: "CodeRequired",
                table: "MasterTableSubCodes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ColumnPosition",
                table: "MasterTableSubCodes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description1",
                table: "MasterTableSubCodes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description2",
                table: "MasterTableSubCodes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description3",
                table: "MasterTableSubCodes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description4",
                table: "MasterTableSubCodes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description5",
                table: "MasterTableSubCodes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description6",
                table: "MasterTableSubCodes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description7",
                table: "MasterTableSubCodes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Heading1",
                table: "MasterTableSubCodes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
