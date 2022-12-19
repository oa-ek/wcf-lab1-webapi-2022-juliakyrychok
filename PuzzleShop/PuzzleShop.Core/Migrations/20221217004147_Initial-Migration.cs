using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PuzzleShop.Core.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6ed25511-7b94-4ba2-8b52-5463f67ea8e9", "a2b9b5c5-2232-454f-807b-25d18c28b604" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "886ad836-6686-4415-91eb-becdda0eb429", "a2b9b5c5-2232-454f-807b-25d18c28b604" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a730139b-0f1c-44b0-be07-6a8e169a6118", "a2b9b5c5-2232-454f-807b-25d18c28b604" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "886ad836-6686-4415-91eb-becdda0eb429", "b8bab7fd-5340-4712-9f93-32dfd6456bf8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "886ad836-6686-4415-91eb-becdda0eb429", "bf8e4923-67fe-4625-bc6a-06e8954a045f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a730139b-0f1c-44b0-be07-6a8e169a6118", "bf8e4923-67fe-4625-bc6a-06e8954a045f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ed25511-7b94-4ba2-8b52-5463f67ea8e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "886ad836-6686-4415-91eb-becdda0eb429");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a730139b-0f1c-44b0-be07-6a8e169a6118");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2b9b5c5-2232-454f-807b-25d18c28b604");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8bab7fd-5340-4712-9f93-32dfd6456bf8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf8e4923-67fe-4625-bc6a-06e8954a045f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a34e2b01-e71a-4251-a03c-9560f04e6ffd", "6832ad40-21c7-4356-8e84-727e11c7a13b", "Manager", "MANAGER" },
                    { "df467946-d378-4b71-9fc6-e5b0d33516e6", "32327385-acee-42d2-be0d-82d1f2375dc6", "Admin", "ADMIN" },
                    { "f25b4593-3002-48f9-abe3-f6faa39e84db", "ab676a92-79ef-4fb1-a1f7-0943b56cd8b0", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "34cc9d80-1862-4101-8a21-003a1de0be01", 0, "ab652c8b-6112-47dc-8d1d-4467b55c514c", "customer@puzzleshop.com", true, null, null, false, null, "CUSTOMER@PUZZLESHOP.COM", "CUSTOMER@PUZZLESHOP.COM", "AQAAAAEAACcQAAAAEI5GJOviYp07+xOjthCKiJ/r6jirZEo3s6YksJpX36DbSMoL8/LhK4RzV9g64V2koA==", null, false, "95c963c6-98cb-4847-b0ea-0e1b10b383aa", false, "customer@puzzleshop.com" },
                    { "b519530c-c711-4ba5-9967-100fd98fa58a", 0, "e38107ab-6bce-4bcf-96cd-ceb5c5ad1727", "admin@puzzleshop.com", true, null, null, false, null, "ADMIN@PUZZLESHOP.COM", "ADMIN@PUZZLESHOP.COM", "AQAAAAEAACcQAAAAEPdolfZYXa81SDI7PUcA89XPA4qyEdQtNGxTRBvoEIoKf+dCM67N6bCTI9yv7lE+6w==", null, false, "f9b244a5-9040-4077-a88a-2a872e36906f", false, "admin@puzzleshop.com" },
                    { "c9b8973a-dfeb-4c94-87f0-cc20ac5c8880", 0, "78a4785c-0b5d-45b8-9c7c-72e24fcd6367", "manager@puzzleshop.com", true, null, null, false, null, "MANAGER@PUZZLESHOP.COM", "MANAGER@PUZZLESHOP.COM", "AQAAAAEAACcQAAAAEEtPd3dBgotWDtoAUy3azTW5Qr10KPv7rrB+7x6ZkM8f1NQIc6FH0Fh4iFc1pZyo7Q==", null, false, "e1fcece5-8b87-4eea-877e-2656e14c7fa9", false, "manager@puzzleshop.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f25b4593-3002-48f9-abe3-f6faa39e84db", "34cc9d80-1862-4101-8a21-003a1de0be01" },
                    { "a34e2b01-e71a-4251-a03c-9560f04e6ffd", "b519530c-c711-4ba5-9967-100fd98fa58a" },
                    { "df467946-d378-4b71-9fc6-e5b0d33516e6", "b519530c-c711-4ba5-9967-100fd98fa58a" },
                    { "f25b4593-3002-48f9-abe3-f6faa39e84db", "b519530c-c711-4ba5-9967-100fd98fa58a" },
                    { "a34e2b01-e71a-4251-a03c-9560f04e6ffd", "c9b8973a-dfeb-4c94-87f0-cc20ac5c8880" },
                    { "f25b4593-3002-48f9-abe3-f6faa39e84db", "c9b8973a-dfeb-4c94-87f0-cc20ac5c8880" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f25b4593-3002-48f9-abe3-f6faa39e84db", "34cc9d80-1862-4101-8a21-003a1de0be01" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a34e2b01-e71a-4251-a03c-9560f04e6ffd", "b519530c-c711-4ba5-9967-100fd98fa58a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "df467946-d378-4b71-9fc6-e5b0d33516e6", "b519530c-c711-4ba5-9967-100fd98fa58a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f25b4593-3002-48f9-abe3-f6faa39e84db", "b519530c-c711-4ba5-9967-100fd98fa58a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a34e2b01-e71a-4251-a03c-9560f04e6ffd", "c9b8973a-dfeb-4c94-87f0-cc20ac5c8880" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f25b4593-3002-48f9-abe3-f6faa39e84db", "c9b8973a-dfeb-4c94-87f0-cc20ac5c8880" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a34e2b01-e71a-4251-a03c-9560f04e6ffd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df467946-d378-4b71-9fc6-e5b0d33516e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f25b4593-3002-48f9-abe3-f6faa39e84db");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34cc9d80-1862-4101-8a21-003a1de0be01");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b519530c-c711-4ba5-9967-100fd98fa58a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9b8973a-dfeb-4c94-87f0-cc20ac5c8880");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6ed25511-7b94-4ba2-8b52-5463f67ea8e9", "11603511-406e-4c34-8d33-34246b10befc", "Admin", "ADMIN" },
                    { "886ad836-6686-4415-91eb-becdda0eb429", "f5c48721-c745-4eaa-9279-6d4447245d32", "Customer", "CUSTOMER" },
                    { "a730139b-0f1c-44b0-be07-6a8e169a6118", "52991ef8-0364-494c-88c2-6e77d5f8b919", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a2b9b5c5-2232-454f-807b-25d18c28b604", 0, "bd941e71-a08b-4fcb-b57d-ef3498217084", "admin@puzzleshop.com", true, null, null, false, null, "ADMIN@PUZZLESHOP.COM", "ADMIN@PUZZLESHOP.COM", "AQAAAAEAACcQAAAAEGqcd989Af4dJJvs8yFfyrdqjieZzWrQfTZGSlCapIWPs7hBCNQbVrekp2919pqUHQ==", null, false, "8b8cc471-453d-45e6-a1ac-0d07ef9d223f", false, "admin@puzzleshop.com" },
                    { "b8bab7fd-5340-4712-9f93-32dfd6456bf8", 0, "cab3427e-45cb-4f46-8873-d1ea77457f4d", "customer@puzzleshop.com", true, null, null, false, null, "CUSTOMER@PUZZLESHOP.COM", "CUSTOMER@PUZZLESHOP.COM", "AQAAAAEAACcQAAAAEJF2FebjHs+HHq4kmxNiZP/R3ks3dcljw4Buf3iRJTkIfozanrozdidFfQ0oiNslBA==", null, false, "5fad0ae4-844f-4b60-8460-f9107c4145d4", false, "customer@puzzleshop.com" },
                    { "bf8e4923-67fe-4625-bc6a-06e8954a045f", 0, "bce94d17-86a5-4ff9-aa54-b372b822541d", "manager@puzzleshop.com", true, null, null, false, null, "MANAGER@PUZZLESHOP.COM", "MANAGER@PUZZLESHOP.COM", "AQAAAAEAACcQAAAAEM8OxC+7ZLHVeiMzLFZMfX/QDPcxwNPL8KK4c1q1mmG7owapjKyji4jHzw8eRA3oCQ==", null, false, "895066f0-50d4-4729-83f6-28cdcaf56ecd", false, "manager@puzzleshop.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6ed25511-7b94-4ba2-8b52-5463f67ea8e9", "a2b9b5c5-2232-454f-807b-25d18c28b604" },
                    { "886ad836-6686-4415-91eb-becdda0eb429", "a2b9b5c5-2232-454f-807b-25d18c28b604" },
                    { "a730139b-0f1c-44b0-be07-6a8e169a6118", "a2b9b5c5-2232-454f-807b-25d18c28b604" },
                    { "886ad836-6686-4415-91eb-becdda0eb429", "b8bab7fd-5340-4712-9f93-32dfd6456bf8" },
                    { "886ad836-6686-4415-91eb-becdda0eb429", "bf8e4923-67fe-4625-bc6a-06e8954a045f" },
                    { "a730139b-0f1c-44b0-be07-6a8e169a6118", "bf8e4923-67fe-4625-bc6a-06e8954a045f" }
                });
        }
    }
}
