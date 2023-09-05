using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Late_Staff.Migrations
{
    /// <inheritdoc />
    public partial class AddToMyDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LateArrivals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArrivalTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StaffMemberID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LateArrivals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LateArrivals_StaffMembers_StaffMemberID",
                        column: x => x.StaffMemberID,
                        principalTable: "StaffMembers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LateArrivals_StaffMemberID",
                table: "LateArrivals",
                column: "StaffMemberID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LateArrivals");
        }
    }
}
