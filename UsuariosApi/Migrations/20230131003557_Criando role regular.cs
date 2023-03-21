using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class Criandoroleregular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "c186fda9-72f7-474b-b12e-8f2de4c52da9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99997, "82c8f4e0-11fe-4187-9d3d-8150a5b74480", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20ae0694-02ec-42ed-a180-f1e4246dd22a", "AQAAAAEAACcQAAAAEKS1AOvA5czOS97rKf0kZW+siIzB0Cak/40uHfqURtkYtxshQXxL60mFihw6RJBZtA==", "0979900a-750a-46bd-8f5d-f32735dc645a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "0b75b9f6-5815-4135-91f0-31f1cd4f7f10");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bc0807a-a369-40d9-bd36-17c795edd118", "AQAAAAEAACcQAAAAEPF0SAMT9xiOvMyLHmQxKdiZm8Nj2ClLmS+6ecrT2SNScK2NOzLVd3LYpCHBbkPx/w==", "0d331304-9016-4970-a956-c87b4d7214ec" });
        }
    }
}
