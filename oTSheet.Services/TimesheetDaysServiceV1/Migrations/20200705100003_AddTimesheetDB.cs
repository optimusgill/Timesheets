using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TimesheetDaysService.Migrations
{
    public partial class AddTimesheetDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeData",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeGuid = table.Column<Guid>(nullable: false),
                    EmployeeIdentifier = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeData", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "EntryAudit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntryAudit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TImeSheetDayItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TimeSheetID = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: true),
                    Start = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false),
                    IsApproved = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    EntryAuditId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TImeSheetDayItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TImeSheetDayItems_EmployeeData_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "EmployeeData",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TImeSheetDayItems_EntryAudit_EntryAuditId",
                        column: x => x.EntryAuditId,
                        principalTable: "EntryAudit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventData",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(nullable: true),
                    Start = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false),
                    TimesheetDayId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventData", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_EventData_TImeSheetDayItems_TimesheetDayId",
                        column: x => x.TimesheetDayId,
                        principalTable: "TImeSheetDayItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HrAmount",
                columns: table => new
                {
                    MultiplierID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Hours = table.Column<float>(nullable: false),
                    TimesheetDayId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HrAmount", x => x.MultiplierID);
                    table.ForeignKey(
                        name: "FK_HrAmount_TImeSheetDayItems_TimesheetDayId",
                        column: x => x.TimesheetDayId,
                        principalTable: "TImeSheetDayItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventData_TimesheetDayId",
                table: "EventData",
                column: "TimesheetDayId");

            migrationBuilder.CreateIndex(
                name: "IX_HrAmount_TimesheetDayId",
                table: "HrAmount",
                column: "TimesheetDayId");

            migrationBuilder.CreateIndex(
                name: "IX_TImeSheetDayItems_EmployeeId",
                table: "TImeSheetDayItems",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TImeSheetDayItems_EntryAuditId",
                table: "TImeSheetDayItems",
                column: "EntryAuditId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventData");

            migrationBuilder.DropTable(
                name: "HrAmount");

            migrationBuilder.DropTable(
                name: "TImeSheetDayItems");

            migrationBuilder.DropTable(
                name: "EmployeeData");

            migrationBuilder.DropTable(
                name: "EntryAudit");
        }
    }
}
