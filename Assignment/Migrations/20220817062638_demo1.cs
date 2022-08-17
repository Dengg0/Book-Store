using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Migrations
{
    public partial class demo1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "e236255f-f82f-41ea-8924-34204ef8c897");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "9c0438de-5a67-4c28-ad86-e3a26dd133fd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "6f59b46c-dcf9-461b-9103-7c4acd589739");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8457f147-fb75-47ee-8646-57caff57ae6f", "AQAAAAEAACcQAAAAEOhQ18Al7Sfl/kJ83PTnMX0yVpatbdUUh02QmWGCCgJMPinrg57nTRr3v5cMVLIADA==", "b4c7add3-6edd-4dd7-a91a-4acfe8bdeca3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ec6a67a-453e-41d1-b34d-a4ea7206ea1d", "AQAAAAEAACcQAAAAEKRX9Q9H6qeWmr/SoKFYSw0JilNmrBjQ/v3tgxjKI4NDownvA1h/RgvxQed2PyubkQ==", "5c157e35-6f7f-4ab6-8ef4-0299ddbbb284" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "354240fe-370d-45be-ba25-590cb1b7382f", "AQAAAAEAACcQAAAAEBNXMTaxc/QXldF+N0isIJEXcZxr0QIOn7E/MhX5hfHgLFNTdyWHbPCKusy9PCo9Ug==", "309591e0-8e9c-4a9e-9efd-cc0a0c94c54c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d5263e06-18f8-48b4-8e42-3dafab91eabc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "7a0fb392-920e-447c-ad36-f8d342ff6f18");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "7a9c23f1-1c7d-42d8-ad01-54582f87c333");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a9fbbf2-38ca-4632-900e-8f99fb911290", "AQAAAAEAACcQAAAAEFDuGBbO2NFA2PMF820tvsgeLUBONUw9DeLaZagKbEQfoUokGBepuG8VFgLPxW0wpg==", "f5709cf9-6030-4e52-bf94-6de2409a641c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c9fe43a-5d0c-41d5-adac-3d80307e0775", "AQAAAAEAACcQAAAAELikSjaHHLI0DVx2sCWcKmw7dS7kv8roqsPKkJNfp1a2MvVnVhBwA3LJBAtV1wuowg==", "3556af29-02c1-4a8c-bf81-97549b027218" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db398bfb-7899-485f-a268-d0a99ece4caa", "AQAAAAEAACcQAAAAEGTi2aRmZEl7nr5NCy/T1LijX0WQsBk0IXeeJxjVnO4iLvD+UOlfSYtM76qhPidhdQ==", "883164c0-6c43-49f3-8193-93903fc21e6e" });
        }
    }
}
