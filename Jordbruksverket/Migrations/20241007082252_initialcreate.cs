using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Jordbruksverket.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    OwnerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.OwnerId);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    ChipId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfChip = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChipLoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Species = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.ChipId);
                    table.ForeignKey(
                        name: "FK_Pets_Owners_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owners",
                        principalColumn: "OwnerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "OwnerId", "Address", "City", "Country", "FirstName", "LastName", "PhoneNumber", "PostCode" },
                values: new object[] { 1, "Storgatan 31", "Varberg", "Sweden", "Sixten", "Svensson", "1234567890", "43245" });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "ChipId", "Breed", "ChipLoc", "Color", "DateOfBirth", "DateOfChip", "OwnerId", "PetName", "Sex", "Species" },
                values: new object[,]
                {
                    { 1001, "Golden Retriever", "Left Shoulder", "Golden", new DateTime(2019, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Archie", "Male", "Dog" },
                    { 1002, "Siamese", "Right Shoulder", "Cream and Brown", new DateTime(2018, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Luna", "Female", "Cat" },
                    { 1003, "Beagle", "Neck", "Tricolor", new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Charlie", "Male", "Dog" },
                    { 1004, "Labrador Retriever", "Left Leg", "Black", new DateTime(2017, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Bella", "Female", "Dog" },
                    { 1005, "Maine Coon", "Back", "Gray", new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Max", "Male", "Cat" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pets_OwnerId",
                table: "Pets",
                column: "OwnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "Owners");
        }
    }
}
