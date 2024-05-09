using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamE_Project.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaçãocolunasdaclasseArea : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CodigoArea",
                table: "Area",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Designacao",
                table: "Area",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Calendario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendario", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calendario");

            migrationBuilder.DropColumn(
                name: "CodigoArea",
                table: "Area");

            migrationBuilder.DropColumn(
                name: "Designacao",
                table: "Area");
        }
    }
}
