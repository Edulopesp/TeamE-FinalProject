using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamE_Project.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaçãoKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Utilizador",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Utilizador",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Utilizador",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Telefone",
                table: "Utilizador",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Designacao",
                table: "Tipo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Responsavel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Responsavel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sobrenome",
                table: "Responsavel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Telefone",
                table: "Responsavel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Designacao",
                table: "Regime",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CodigoPrograma",
                table: "Programa",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Designacao",
                table: "Programa",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AreaId",
                table: "Nome",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DesignacaoCurso",
                table: "Nome",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Formador",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Formador",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sobrenome",
                table: "Formador",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateOnly>(
                name: "DataFPCT",
                table: "Formacao",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<DateOnly>(
                name: "DataFim",
                table: "Formacao",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<DateOnly>(
                name: "DataInicio",
                table: "Formacao",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<int>(
                name: "DelegacaoId",
                table: "Formacao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DescricaoId",
                table: "Formacao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Formacao",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "FormadorId",
                table: "Formacao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Horario",
                table: "Formacao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Horas",
                table: "Formacao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProgramaId",
                table: "Formacao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RegimeId",
                table: "Formacao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ResponsavelId",
                table: "Formacao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoId",
                table: "Formacao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Distrito",
                table: "Cidade",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Localidade",
                table: "Cidade",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Cidade",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Utilizador");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Utilizador");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Utilizador");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Utilizador");

            migrationBuilder.DropColumn(
                name: "Designacao",
                table: "Tipo");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "Sobrenome",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "Designacao",
                table: "Regime");

            migrationBuilder.DropColumn(
                name: "CodigoPrograma",
                table: "Programa");

            migrationBuilder.DropColumn(
                name: "Designacao",
                table: "Programa");

            migrationBuilder.DropColumn(
                name: "AreaId",
                table: "Nome");

            migrationBuilder.DropColumn(
                name: "DesignacaoCurso",
                table: "Nome");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Formador");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Formador");

            migrationBuilder.DropColumn(
                name: "Sobrenome",
                table: "Formador");

            migrationBuilder.DropColumn(
                name: "DataFPCT",
                table: "Formacao");

            migrationBuilder.DropColumn(
                name: "DataFim",
                table: "Formacao");

            migrationBuilder.DropColumn(
                name: "DataInicio",
                table: "Formacao");

            migrationBuilder.DropColumn(
                name: "DelegacaoId",
                table: "Formacao");

            migrationBuilder.DropColumn(
                name: "DescricaoId",
                table: "Formacao");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Formacao");

            migrationBuilder.DropColumn(
                name: "FormadorId",
                table: "Formacao");

            migrationBuilder.DropColumn(
                name: "Horario",
                table: "Formacao");

            migrationBuilder.DropColumn(
                name: "Horas",
                table: "Formacao");

            migrationBuilder.DropColumn(
                name: "ProgramaId",
                table: "Formacao");

            migrationBuilder.DropColumn(
                name: "RegimeId",
                table: "Formacao");

            migrationBuilder.DropColumn(
                name: "ResponsavelId",
                table: "Formacao");

            migrationBuilder.DropColumn(
                name: "TipoId",
                table: "Formacao");

            migrationBuilder.DropColumn(
                name: "Distrito",
                table: "Cidade");

            migrationBuilder.DropColumn(
                name: "Localidade",
                table: "Cidade");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Cidade");
        }
    }
}
