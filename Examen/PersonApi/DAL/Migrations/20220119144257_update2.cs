using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonApi.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tblPerson",
                schema: "dbo",
                table: "tblPerson");

            migrationBuilder.RenameTable(
                name: "tblPerson",
                schema: "dbo",
                newName: "TblPeople",
                newSchema: "dbo");

            migrationBuilder.RenameColumn(
                name: "Gender",
                schema: "dbo",
                table: "TblPeople",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "Mail",
                schema: "dbo",
                table: "TblPeople",
                newName: "EmailAddress");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                schema: "dbo",
                table: "TblPeople",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<int>(
                name: "gender",
                schema: "dbo",
                table: "TblPeople",
                type: "int",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                schema: "dbo",
                table: "TblPeople",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                schema: "dbo",
                table: "TblPeople",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblPeople",
                schema: "dbo",
                table: "TblPeople",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TblPeople",
                schema: "dbo",
                table: "TblPeople");

            migrationBuilder.RenameTable(
                name: "TblPeople",
                schema: "dbo",
                newName: "tblPerson",
                newSchema: "dbo");

            migrationBuilder.RenameColumn(
                name: "gender",
                schema: "dbo",
                table: "tblPerson",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                schema: "dbo",
                table: "tblPerson",
                newName: "Mail");

            migrationBuilder.AlterColumn<short>(
                name: "Gender",
                schema: "dbo",
                table: "tblPerson",
                type: "smallint",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                schema: "dbo",
                table: "tblPerson",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                schema: "dbo",
                table: "tblPerson",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Mail",
                schema: "dbo",
                table: "tblPerson",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblPerson",
                schema: "dbo",
                table: "tblPerson",
                column: "id");
        }
    }
}
