using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eCommerce.Office.Migrations
{
    /// <inheritdoc />
    public partial class AddTurmaSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Turmas",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Turma A1" },
                    { 2, "Turma A2" },
                    { 3, "Turma A3" },
                    { 4, "Turma A4" },
                    { 5, "Turma A5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Turmas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Turmas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Turmas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Turmas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Turmas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 1, 1 },
                column: "DataRegistroCriado",
                value: new DateTimeOffset(new DateTime(2024, 9, 9, 11, 37, 35, 886, DateTimeKind.Unspecified).AddTicks(4405), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 2, 1 },
                column: "DataRegistroCriado",
                value: new DateTimeOffset(new DateTime(2024, 9, 9, 11, 37, 35, 886, DateTimeKind.Unspecified).AddTicks(4457), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 3, 2 },
                column: "DataRegistroCriado",
                value: new DateTimeOffset(new DateTime(2024, 9, 9, 11, 37, 35, 886, DateTimeKind.Unspecified).AddTicks(4461), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 4, 2 },
                column: "DataRegistroCriado",
                value: new DateTimeOffset(new DateTime(2024, 9, 9, 11, 37, 35, 886, DateTimeKind.Unspecified).AddTicks(4464), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 5, 3 },
                column: "DataRegistroCriado",
                value: new DateTimeOffset(new DateTime(2024, 9, 9, 11, 37, 35, 886, DateTimeKind.Unspecified).AddTicks(4467), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 6, 3 },
                column: "DataRegistroCriado",
                value: new DateTimeOffset(new DateTime(2024, 9, 9, 11, 37, 35, 886, DateTimeKind.Unspecified).AddTicks(4469), new TimeSpan(0, -3, 0, 0, 0)));
        }
    }
}
