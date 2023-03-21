using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class Adicionandocustomidentityuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "AspNetUsers",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "ba627e77-1101-43f7-8c57-96cc8c4c347a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "06127125-2433-46d3-b880-f5e4d7d2f763");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9cb2adc-d283-420d-8abc-4fd904dfccc9", "AQAAAAEAACcQAAAAEJB00zdnom6+4Cli0N7mlWHdlSOcdsRcFMwl8CZppLWPHOJFCjGnfeFOxAwbEpus6A==", "617d38ff-d12c-456c-bfeb-47c369b1f418" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "82c8f4e0-11fe-4187-9d3d-8150a5b74480");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "c186fda9-72f7-474b-b12e-8f2de4c52da9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20ae0694-02ec-42ed-a180-f1e4246dd22a", "AQAAAAEAACcQAAAAEKS1AOvA5czOS97rKf0kZW+siIzB0Cak/40uHfqURtkYtxshQXxL60mFihw6RJBZtA==", "0979900a-750a-46bd-8f5d-f32735dc645a" });
        }
    }
}
