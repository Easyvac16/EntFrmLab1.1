using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntFrmLab1._1.DAL.Migrations
{
    public partial class Add2Rows : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CopiesSold",
                table: "Games",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsMultiplayer",
                table: "Games",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CopiesSold",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "IsMultiplayer",
                table: "Games");
        }
    }
}
