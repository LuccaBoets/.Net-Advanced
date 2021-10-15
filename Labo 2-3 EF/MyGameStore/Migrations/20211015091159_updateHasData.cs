using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGameStore.Migrations
{
    public partial class updateHasData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Place",
                schema: "Store",
                table: "tblStores",
                newName: "PlaceTest");

            migrationBuilder.InsertData(
                schema: "Person",
                table: "tblPeople",
                columns: new[] { "id", "BirthDate", "EmailAddress", "FirstName", "Gender", "LastName", "StoreWhereEmployeeId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lucca@itest.be", "Lucca", 0, "Boets", null });

            migrationBuilder.InsertData(
                schema: "Person",
                table: "tblPeople",
                columns: new[] { "id", "BirthDate", "EmailAddress", "FirstName", "Gender", "LastName", "StoreWhereEmployeeId" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C@itest.be", "Cedric", 0, "Martel", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "PlaceTest",
                schema: "Store",
                table: "tblStores",
                newName: "Place");
        }
    }
}
