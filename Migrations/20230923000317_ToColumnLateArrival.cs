using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Late_Staff.Migrations
{
    /// <inheritdoc />
    public partial class ToColumnLateArrival : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "LateArrivals",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "StaffId",
                table: "StaffMembers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "Islate",
                table: "LateArrivals",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "StaffId",
                table: "LateArrivals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Islate",
                table: "LateArrivals");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "LateArrivals");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "LateArrivals",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "StaffId",
                table: "StaffMembers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
