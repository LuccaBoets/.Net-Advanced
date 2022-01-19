using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonApi.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "People",
                newName: "tblPerson",
                newSchema: "dbo");

            migrationBuilder.RenameColumn(
                name: "mail",
                schema: "dbo",
                table: "tblPerson",
                newName: "Mail");

            migrationBuilder.RenameColumn(
                name: "gender",
                schema: "dbo",
                table: "tblPerson",
                newName: "Gender");

            migrationBuilder.AlterColumn<string>(
                name: "Mail",
                schema: "dbo",
                table: "tblPerson",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                schema: "dbo",
                table: "tblPerson",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblPerson",
                schema: "dbo",
                table: "tblPerson",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tblPerson",
                schema: "dbo",
                table: "tblPerson");

            migrationBuilder.RenameTable(
                name: "tblPerson",
                schema: "dbo",
                newName: "People");

            migrationBuilder.RenameColumn(
                name: "Mail",
                table: "People",
                newName: "mail");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "People",
                newName: "gender");

            migrationBuilder.AlterColumn<string>(
                name: "mail",
                table: "People",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "People",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<int>(
                name: "gender",
                table: "People",
                type: "int",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "People",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80);

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "People",
                column: "id");
        }
    }
}
