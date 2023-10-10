using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Late_Staff.Migrations
{
    /// <inheritdoc />
    public partial class ToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LateArrivals_StaffMembers_StaffMemberID",
                table: "LateArrivals");

            migrationBuilder.DropColumn(
                name: "ArrivalTime",
                table: "StaffMembers");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "LateArrivals");

            migrationBuilder.RenameColumn(
                name: "StaffMemberID",
                table: "LateArrivals",
                newName: "StaffMemberId");

            migrationBuilder.RenameIndex(
                name: "IX_LateArrivals_StaffMemberID",
                table: "LateArrivals",
                newName: "IX_LateArrivals_StaffMemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_LateArrivals_StaffMembers_StaffMemberId",
                table: "LateArrivals",
                column: "StaffMemberId",
                principalTable: "StaffMembers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LateArrivals_StaffMembers_StaffMemberId",
                table: "LateArrivals");

            migrationBuilder.RenameColumn(
                name: "StaffMemberId",
                table: "LateArrivals",
                newName: "StaffMemberID");

            migrationBuilder.RenameIndex(
                name: "IX_LateArrivals_StaffMemberId",
                table: "LateArrivals",
                newName: "IX_LateArrivals_StaffMemberID");

            migrationBuilder.AddColumn<DateTime>(
                name: "ArrivalTime",
                table: "StaffMembers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "StaffId",
                table: "LateArrivals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_LateArrivals_StaffMembers_StaffMemberID",
                table: "LateArrivals",
                column: "StaffMemberID",
                principalTable: "StaffMembers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
