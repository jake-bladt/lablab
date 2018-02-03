using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CalendarKittenStudios.Data.Migrations
{
    public partial class m2m : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kittens_CalendarPage_CalendarPageID",
                table: "Kittens");

            migrationBuilder.DropIndex(
                name: "IX_Kittens_CalendarPageID",
                table: "Kittens");

            migrationBuilder.DropColumn(
                name: "CalendarPageID",
                table: "Kittens");

            migrationBuilder.CreateTable(
                name: "ModelingEngagement",
                columns: table => new
                {
                    KittenID = table.Column<int>(nullable: false),
                    CalendarPageID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelingEngagement", x => new { x.KittenID, x.CalendarPageID });
                    table.ForeignKey(
                        name: "FK_ModelingEngagement_CalendarPage_CalendarPageID",
                        column: x => x.CalendarPageID,
                        principalTable: "CalendarPage",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModelingEngagement_Kittens_KittenID",
                        column: x => x.KittenID,
                        principalTable: "Kittens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ModelingEngagement_CalendarPageID",
                table: "ModelingEngagement",
                column: "CalendarPageID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModelingEngagement");

            migrationBuilder.AddColumn<int>(
                name: "CalendarPageID",
                table: "Kittens",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kittens_CalendarPageID",
                table: "Kittens",
                column: "CalendarPageID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kittens_CalendarPage_CalendarPageID",
                table: "Kittens",
                column: "CalendarPageID",
                principalTable: "CalendarPage",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
