using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGameStore.Migrations
{
    public partial class updateFluentApi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblPeople_TblStores_StoreWhereEmployeeId",
                schema: "Person",
                table: "TblPeople");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblStores",
                schema: "Store",
                table: "TblStores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblPeople",
                schema: "Person",
                table: "TblPeople");

            migrationBuilder.RenameTable(
                name: "TblStores",
                schema: "Store",
                newName: "tblStores",
                newSchema: "Store");

            migrationBuilder.RenameTable(
                name: "TblPeople",
                schema: "Person",
                newName: "tblPeople",
                newSchema: "Person");

            migrationBuilder.RenameIndex(
                name: "IX_TblPeople_StoreWhereEmployeeId",
                schema: "Person",
                table: "tblPeople",
                newName: "IX_tblPeople_StoreWhereEmployeeId");

            migrationBuilder.AlterColumn<string>(
                name: "Place",
                schema: "Store",
                table: "tblStores",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "Addition",
                schema: "Store",
                table: "tblStores",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                schema: "Person",
                table: "tblPeople",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                schema: "Person",
                table: "tblPeople",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                schema: "Person",
                table: "tblPeople",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblStores",
                schema: "Store",
                table: "tblStores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblPeople",
                schema: "Person",
                table: "tblPeople",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_tblPeople_tblStores_StoreWhereEmployeeId",
                schema: "Person",
                table: "tblPeople",
                column: "StoreWhereEmployeeId",
                principalSchema: "Store",
                principalTable: "tblStores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblPeople_tblStores_StoreWhereEmployeeId",
                schema: "Person",
                table: "tblPeople");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblStores",
                schema: "Store",
                table: "tblStores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblPeople",
                schema: "Person",
                table: "tblPeople");

            migrationBuilder.RenameTable(
                name: "tblStores",
                schema: "Store",
                newName: "TblStores",
                newSchema: "Store");

            migrationBuilder.RenameTable(
                name: "tblPeople",
                schema: "Person",
                newName: "TblPeople",
                newSchema: "Person");

            migrationBuilder.RenameIndex(
                name: "IX_tblPeople_StoreWhereEmployeeId",
                schema: "Person",
                table: "TblPeople",
                newName: "IX_TblPeople_StoreWhereEmployeeId");

            migrationBuilder.AlterColumn<string>(
                name: "Place",
                schema: "Store",
                table: "TblStores",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Addition",
                schema: "Store",
                table: "TblStores",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                schema: "Person",
                table: "TblPeople",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                schema: "Person",
                table: "TblPeople",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                schema: "Person",
                table: "TblPeople",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblStores",
                schema: "Store",
                table: "TblStores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblPeople",
                schema: "Person",
                table: "TblPeople",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_TblPeople_TblStores_StoreWhereEmployeeId",
                schema: "Person",
                table: "TblPeople",
                column: "StoreWhereEmployeeId",
                principalSchema: "Store",
                principalTable: "TblStores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
