using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class AddedUniqueConstraintToAgentPhone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de70b72a-f4d9-4b4f-925b-8731ae92473a", "AQAAAAEAACcQAAAAEK6fbEHB7SJBTPIkAwVpaa+lmPgcDdfLUbvmGShAJxiGMwAlypcuzzwQNh1F9zBfgw==", "40591901-685c-496e-bc17-9ba504e0609b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d951228-8c6f-490c-85f3-e9c705e07d8a", "AQAAAAEAACcQAAAAELQUr36YCOYRxpdbY0+rD1lUVC2IMBTtXH4hASGb796TTA9yMvMuHeKS8Q861OlPaQ==", "0c115934-6628-4e7b-8091-fc79e2c73ca0" });

            migrationBuilder.CreateIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents",
                column: "PhoneNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa83906e-b363-40ff-b5ca-6f0f8d0057b5", "AQAAAAEAACcQAAAAEBRJpBOkbnewoMAaliY5JJJjjcfTZ3ub5K0sdGuFPSyq+35FnX1OFLp51rgPow5EqA==", "c2c3cfc6-8e31-4827-871f-d4922455ba6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "818df4f6-1b67-487a-ac3c-431b76a15d2a", "AQAAAAEAACcQAAAAELUUyZHhgAf5UTmg0kV0u92PnCUTw4YShVL4i1V+Y0ADZhhtmgSw25hsm1dEgXNAmg==", "e9e65333-99a5-430b-b408-2837fa5ec22a" });
        }
    }
}
