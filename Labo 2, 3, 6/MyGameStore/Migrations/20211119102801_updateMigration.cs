using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGameStore.Migrations
{
    public partial class updateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlaceTest",
                schema: "Store",
                table: "tblStores",
                newName: "Place");

            migrationBuilder.UpdateData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "EmailAddress", "FirstName", "LastName" },
                values: new object[] { "alfonso.nitzsche@abernathy.biz", "Angelita", "Haag" });

            migrationBuilder.UpdateData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "EmailAddress", "FirstName", "LastName" },
                values: new object[] { "rosie_murray@shields.uk", "Shayne", "Gleason" });

            migrationBuilder.InsertData(
                schema: "Person",
                table: "tblPeople",
                columns: new[] { "id", "BirthDate", "EmailAddress", "FirstName", "Gender", "LastName", "StoreWhereEmployeeId" },
                values: new object[,]
                {
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "walker@graham.biz", "Tanya", 0, "Langworth", null },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ulises@conroy.co.uk", "Heloise", 0, "McClure", null },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "megane.rogahn@heaney.name", "Myrtie", 0, "Crist", null },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ada_keebler@zieme.us", "Wilfrid", 0, "Emmerich", null },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "irving_ondricka@kulaswehner.ca", "Leanna", 0, "Durgan", null },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "joey@hettinger.biz", "Walker", 0, "Nicolas", null },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "javonte@kris.uk", "Chad", 0, "Larkin", null },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kianna@wiza.info", "Chad", 0, "Mayert", null },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "francis_denesik@wehnerrunolfsson.co.uk", "Lorenz", 0, "Witting", null },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "matilda.gibson@mitchell.co.uk", "Terry", 0, "Hartmann", null },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "verlie.hand@wiza.com", "Kari", 0, "Erdman", null },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "letha@fahey.biz", "Nikolas", 0, "Miller", null },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "theresa@anderson.biz", "Rosalia", 0, "Harvey", null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lavern@douglas.info", "Morton", 0, "Armstrong", null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lucio_shields@gottlieb.biz", "Jadon", 0, "Price", null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kyla_ebert@koeppprice.ca", "Alva", 0, "Kulas", null },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "clara@gradygulgowski.com", "Abby", 0, "Howell", null },
                    { 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "astrid@wittingkulas.name", "Korbin", 0, "Littel", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "id",
                keyValue: 0);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.RenameColumn(
                name: "Place",
                schema: "Store",
                table: "tblStores",
                newName: "PlaceTest");

            migrationBuilder.UpdateData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "EmailAddress", "FirstName", "LastName" },
                values: new object[] { "lucca@itest.be", "Lucca", "Boets" });

            migrationBuilder.UpdateData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "EmailAddress", "FirstName", "LastName" },
                values: new object[] { "C@itest.be", "Cedric", "Martel" });
        }
    }
}
