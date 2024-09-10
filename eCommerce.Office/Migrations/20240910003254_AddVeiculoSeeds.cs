using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eCommerce.Office.Migrations
{
    /// <inheritdoc />
    public partial class AddVeiculoSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColaboradorVeiculo_Colaboradores_ColaboradoresId",
                table: "ColaboradorVeiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_ColaboradorVeiculo_Veiculos_VeiculosId",
                table: "ColaboradorVeiculo");

            migrationBuilder.RenameColumn(
                name: "VeiculosId",
                table: "ColaboradorVeiculo",
                newName: "VeiculoId");

            migrationBuilder.RenameColumn(
                name: "ColaboradoresId",
                table: "ColaboradorVeiculo",
                newName: "ColaboradorId");

            migrationBuilder.RenameIndex(
                name: "IX_ColaboradorVeiculo_VeiculosId",
                table: "ColaboradorVeiculo",
                newName: "IX_ColaboradorVeiculo_VeiculoId");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DataInicioDeVinculo",
                table: "ColaboradorVeiculo",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 1, 1 },
                column: "DataRegistroCriado",
                value: new DateTimeOffset(new DateTime(2024, 9, 9, 21, 32, 53, 671, DateTimeKind.Unspecified).AddTicks(7308), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 2, 1 },
                column: "DataRegistroCriado",
                value: new DateTimeOffset(new DateTime(2024, 9, 9, 21, 32, 53, 671, DateTimeKind.Unspecified).AddTicks(7365), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 3, 2 },
                column: "DataRegistroCriado",
                value: new DateTimeOffset(new DateTime(2024, 9, 9, 21, 32, 53, 671, DateTimeKind.Unspecified).AddTicks(7368), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 4, 2 },
                column: "DataRegistroCriado",
                value: new DateTimeOffset(new DateTime(2024, 9, 9, 21, 32, 53, 671, DateTimeKind.Unspecified).AddTicks(7371), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 5, 3 },
                column: "DataRegistroCriado",
                value: new DateTimeOffset(new DateTime(2024, 9, 9, 21, 32, 53, 671, DateTimeKind.Unspecified).AddTicks(7373), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 6, 3 },
                column: "DataRegistroCriado",
                value: new DateTimeOffset(new DateTime(2024, 9, 9, 21, 32, 53, 671, DateTimeKind.Unspecified).AddTicks(7375), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Veiculos",
                columns: new[] { "Id", "Nome", "Placa" },
                values: new object[,]
                {
                    { 1, "Fiat - Argo", "ABC-1111" },
                    { 2, "Fiat - Mobi", "ABC-2222" },
                    { 3, "Fiat - Sienna", "ABC-3333" },
                    { 4, "Fiat - Idea", "ABC-4444" },
                    { 5, "Fiat - Toro", "ABC-5555" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ColaboradorVeiculo_Colaboradores_VeiculoId",
                table: "ColaboradorVeiculo",
                column: "VeiculoId",
                principalTable: "Colaboradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ColaboradorVeiculo_Veiculos_VeiculoId",
                table: "ColaboradorVeiculo",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColaboradorVeiculo_Colaboradores_VeiculoId",
                table: "ColaboradorVeiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_ColaboradorVeiculo_Veiculos_VeiculoId",
                table: "ColaboradorVeiculo");

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "DataInicioDeVinculo",
                table: "ColaboradorVeiculo");

            migrationBuilder.RenameColumn(
                name: "VeiculoId",
                table: "ColaboradorVeiculo",
                newName: "VeiculosId");

            migrationBuilder.RenameColumn(
                name: "ColaboradorId",
                table: "ColaboradorVeiculo",
                newName: "ColaboradoresId");

            migrationBuilder.RenameIndex(
                name: "IX_ColaboradorVeiculo_VeiculoId",
                table: "ColaboradorVeiculo",
                newName: "IX_ColaboradorVeiculo_VeiculosId");

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 1, 1 },
                column: "DataRegistroCriado",
                value: new DateTimeOffset(new DateTime(2024, 9, 9, 14, 7, 32, 768, DateTimeKind.Unspecified).AddTicks(1528), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 2, 1 },
                column: "DataRegistroCriado",
                value: new DateTimeOffset(new DateTime(2024, 9, 9, 14, 7, 32, 768, DateTimeKind.Unspecified).AddTicks(1590), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 3, 2 },
                column: "DataRegistroCriado",
                value: new DateTimeOffset(new DateTime(2024, 9, 9, 14, 7, 32, 768, DateTimeKind.Unspecified).AddTicks(1595), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 4, 2 },
                column: "DataRegistroCriado",
                value: new DateTimeOffset(new DateTime(2024, 9, 9, 14, 7, 32, 768, DateTimeKind.Unspecified).AddTicks(1599), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 5, 3 },
                column: "DataRegistroCriado",
                value: new DateTimeOffset(new DateTime(2024, 9, 9, 14, 7, 32, 768, DateTimeKind.Unspecified).AddTicks(1604), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 6, 3 },
                column: "DataRegistroCriado",
                value: new DateTimeOffset(new DateTime(2024, 9, 9, 14, 7, 32, 768, DateTimeKind.Unspecified).AddTicks(1607), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AddForeignKey(
                name: "FK_ColaboradorVeiculo_Colaboradores_ColaboradoresId",
                table: "ColaboradorVeiculo",
                column: "ColaboradoresId",
                principalTable: "Colaboradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ColaboradorVeiculo_Veiculos_VeiculosId",
                table: "ColaboradorVeiculo",
                column: "VeiculosId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
