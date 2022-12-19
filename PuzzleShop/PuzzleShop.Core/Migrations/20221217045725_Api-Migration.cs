using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PuzzleShop.Core.Migrations
{
    public partial class ApiMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "68bc449a-5312-4ef2-8ce5-9576e3ccb98c", null, "Manager", "MANAGER" },
                    { "8850294a-b7c2-4cd9-9385-8bc1f931deb4", null, "Customer", "CUSTOMER" },
                    { "f6ec4c0b-08d9-437e-823c-76c3f0fa394a", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "228af38a-a94c-4dcf-b754-9855fcbe8e78", 0, "3ea0e21d-33dd-441e-8e88-6836ebc31078", "admin@puzzleshop.com", true, null, null, false, null, "ADMIN@PUZZLESHOP.COM", "ADMIN@PUZZLESHOP.COM", "AQAAAAIAAYagAAAAEFz1lg2RuM4RoJ7mJkGCzN67HzhHZIdj5+HRYOTKsY7qcoD9lzyfnj0Y19MosiW+gg==", null, false, "b15be083-6414-4bc1-8a7a-be654d56cc5d", false, "admin@puzzleshop.com" },
                    { "56b5b8a0-a5ce-476d-961c-1d7519402ed7", 0, "f201d635-090d-40ff-9415-0cfefbc12eff", "customer@puzzleshop.com", true, null, null, false, null, "CUSTOMER@PUZZLESHOP.COM", "CUSTOMER@PUZZLESHOP.COM", "AQAAAAIAAYagAAAAEPJ+pupqp3bj9ysHasz2WOVTdnVSlzd10qsGUgfms471Bu3/UirYmqdyC160fI89hQ==", null, false, "97dc1063-9071-4993-81fc-aa13c46517fc", false, "customer@puzzleshop.com" },
                    { "dffa4fa9-d128-43af-8e8c-1d9625809b61", 0, "c90bd263-315d-47dd-8ce0-5df3c26f5ca7", "manager@puzzleshop.com", true, null, null, false, null, "MANAGER@PUZZLESHOP.COM", "MANAGER@PUZZLESHOP.COM", "AQAAAAIAAYagAAAAEBVo1d86v9PIYWNM7KDlPx352tiYxzRjfvjtzHmCsfMDXs1IhtAAfTo6v2svwC6FFw==", null, false, "9179d822-e4e9-4d1e-85b3-04930fb4e756", false, "manager@puzzleshop.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "68bc449a-5312-4ef2-8ce5-9576e3ccb98c", "228af38a-a94c-4dcf-b754-9855fcbe8e78" },
                    { "8850294a-b7c2-4cd9-9385-8bc1f931deb4", "228af38a-a94c-4dcf-b754-9855fcbe8e78" },
                    { "f6ec4c0b-08d9-437e-823c-76c3f0fa394a", "228af38a-a94c-4dcf-b754-9855fcbe8e78" },
                    { "8850294a-b7c2-4cd9-9385-8bc1f931deb4", "56b5b8a0-a5ce-476d-961c-1d7519402ed7" },
                    { "68bc449a-5312-4ef2-8ce5-9576e3ccb98c", "dffa4fa9-d128-43af-8e8c-1d9625809b61" },
                    { "8850294a-b7c2-4cd9-9385-8bc1f931deb4", "dffa4fa9-d128-43af-8e8c-1d9625809b61" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "68bc449a-5312-4ef2-8ce5-9576e3ccb98c", "228af38a-a94c-4dcf-b754-9855fcbe8e78" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8850294a-b7c2-4cd9-9385-8bc1f931deb4", "228af38a-a94c-4dcf-b754-9855fcbe8e78" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f6ec4c0b-08d9-437e-823c-76c3f0fa394a", "228af38a-a94c-4dcf-b754-9855fcbe8e78" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8850294a-b7c2-4cd9-9385-8bc1f931deb4", "56b5b8a0-a5ce-476d-961c-1d7519402ed7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "68bc449a-5312-4ef2-8ce5-9576e3ccb98c", "dffa4fa9-d128-43af-8e8c-1d9625809b61" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8850294a-b7c2-4cd9-9385-8bc1f931deb4", "dffa4fa9-d128-43af-8e8c-1d9625809b61" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68bc449a-5312-4ef2-8ce5-9576e3ccb98c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8850294a-b7c2-4cd9-9385-8bc1f931deb4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6ec4c0b-08d9-437e-823c-76c3f0fa394a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "228af38a-a94c-4dcf-b754-9855fcbe8e78");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56b5b8a0-a5ce-476d-961c-1d7519402ed7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dffa4fa9-d128-43af-8e8c-1d9625809b61");

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
    }
}
