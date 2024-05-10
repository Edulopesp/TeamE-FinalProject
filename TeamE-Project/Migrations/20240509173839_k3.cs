using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamE_Project.Migrations
{
    /// <inheritdoc />
    public partial class k3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Formacao_FormadorId",
                table: "Formacao",
                column: "FormadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Formacao_Formador_FormadorId",
                table: "Formacao",
                column: "FormadorId",
                principalTable: "Formador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Formacao_Formador_FormadorId",
                table: "Formacao");

            migrationBuilder.DropIndex(
                name: "IX_Formacao_FormadorId",
                table: "Formacao");
        }
    }
}
