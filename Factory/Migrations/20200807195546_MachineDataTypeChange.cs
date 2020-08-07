using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class MachineDataTypeChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastInspected",
                table: "Machines",
                newName: "LastInspection");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Machines",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastInspection",
                table: "Machines",
                newName: "LastInspected");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Machines",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
