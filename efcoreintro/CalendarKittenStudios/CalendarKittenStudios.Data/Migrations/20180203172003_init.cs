using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CalendarKittenStudios.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calenders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EndDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calenders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Photographers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photographers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CalendarPage",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CalendarID = table.Column<int>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: false),
                    PhotographerID = table.Column<int>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalendarPage", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CalendarPage_Calenders_CalendarID",
                        column: x => x.CalendarID,
                        principalTable: "Calenders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CalendarPage_Photographers_PhotographerID",
                        column: x => x.PhotographerID,
                        principalTable: "Photographers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kittens",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Born = table.Column<DateTime>(nullable: false),
                    Breed = table.Column<string>(nullable: true),
                    CalendarPageID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kittens", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Kittens_CalendarPage_CalendarPageID",
                        column: x => x.CalendarPageID,
                        principalTable: "CalendarPage",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CalendarPage_CalendarID",
                table: "CalendarPage",
                column: "CalendarID");

            migrationBuilder.CreateIndex(
                name: "IX_CalendarPage_PhotographerID",
                table: "CalendarPage",
                column: "PhotographerID");

            migrationBuilder.CreateIndex(
                name: "IX_Kittens_CalendarPageID",
                table: "Kittens",
                column: "CalendarPageID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kittens");

            migrationBuilder.DropTable(
                name: "CalendarPage");

            migrationBuilder.DropTable(
                name: "Calenders");

            migrationBuilder.DropTable(
                name: "Photographers");
        }
    }
}
