using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Code1st.Data.Migrations
{
    public partial class Manager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Manager",
                table: "Teams",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Manager",
                table: "Teams");
        }
    }
}
