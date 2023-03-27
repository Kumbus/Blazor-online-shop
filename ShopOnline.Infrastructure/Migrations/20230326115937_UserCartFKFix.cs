using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopOnline.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UserCartFKFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AspNetUsers_UserId1",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_UserId1",
                table: "Carts");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b8467f2-1899-4aef-9e78-62847fc26c80");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb89a675-259c-4f39-bd85-a90cd70fe63e");

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("9a04c83f-ea42-4da1-be0d-249c02e4fa51"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("ae697fd9-f08f-4668-a07b-744054056683"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("496646a1-62cc-4fbc-8887-2368958692f3"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("7b329c63-1a70-4c43-a0f1-d7b290e69235"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("ac99e5ef-c4ba-4967-8455-e808e25fda39"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("f8f90557-97d4-4f77-bec2-89a8590af933"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a9db661-31a7-42df-a109-205db145e0e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b8f7575-7795-4c0a-a136-f233597d21e4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("272d9b13-2c87-48b7-b92a-9e34007ae21f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2cc97d40-f9e4-45a0-9aa0-b11fa5b8eab5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2d7d9894-e59d-4a57-b12c-277aa6571d8a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3fa7b9ac-d574-4b9f-ac8c-524de1fa6b82"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("432bfb54-08db-4774-8c1b-93b862f0e68a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a692279-4757-4042-bb3a-fd7a7b51c43e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e40f1e0-74f8-4238-a275-8863a3c9c092"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7312f689-9895-4aa5-94d2-05579ac622e6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("86d5add8-f0da-4420-a9ac-aff37266f150"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a72c10a-90e6-4302-acfd-90c31197844f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8dafeb36-42d8-4d88-8e8d-e1df5b064b2a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a014943-1359-4fb4-b145-b91b2ddb40d8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a87834bc-1ef7-40b2-851a-84377daf0ad2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad9c9cba-6b7b-4314-b664-2833eac5cd3e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb3a3325-d18f-45db-b538-90e3a0fdacf1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d44de529-b06a-4da9-b453-c52508879ea4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d888fc24-120d-4ad0-a4db-acfcbabd0ce7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("daba467e-c951-4701-9821-1e4762b0f88b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dacf974b-aa2a-4aee-befb-fa1d003c7fbf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e3e76f10-964b-4f3a-b17e-af680aa1cef8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef9bca5b-9fc0-4a5b-b444-bfca62afc3bb"));

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Carts");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Carts",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2b147016-beb2-4f3f-a311-1bfc036fe047", 0, "e1a5ffbd-dfb2-4d48-8937-04ab9e37bb1b", null, false, false, null, null, null, null, null, false, "1d6e824f-3b4c-4ea9-82cc-e6f378e422d6", false, "Sarah" },
                    { "67733d2a-8a33-4d14-abd8-46ec36d517e1", 0, "95ae943d-7d10-4ef0-895d-c7ea01a17190", null, false, false, null, null, null, null, null, false, "40b9bfc4-5d3c-4ef6-9282-dbbbb59942d5", false, "Bob" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5eeb2e0a-b18c-4dcd-b8ab-8f2183f9c45d"), "Shoes" },
                    { new Guid("9441a0c6-9261-478b-b220-80b749501a2e"), "Electronics" },
                    { new Guid("99dd637c-3d3f-41f3-b758-58f0f73dc785"), "Beauty" },
                    { new Guid("da1394f6-52fc-41e7-8c18-8045630be4c2"), "Furniture" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price", "ProductCategoryId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("0d38d872-4b13-466a-99ce-476a2d354953"), new Guid("5eeb2e0a-b18c-4dcd-b8ab-8f2183f9c45d"), "Colorful Hummel Trainers - available in most sizes", "/Images/Shoes/Shoes4.png", "Colorful Hummel Trainers", 120m, null, 120 },
                    { new Guid("0fdbe91c-7322-4188-ad03-13007495338e"), new Guid("9441a0c6-9261-478b-b220-80b749501a2e"), "Canon Digital Camera - High quality digital camera provided by Canon", "/Images/Electronic/Electronic5.png", "Canon Digital Camera", 500m, null, 15 },
                    { new Guid("259a2650-c2f6-4e18-814f-90c87bbe983d"), new Guid("5eeb2e0a-b18c-4dcd-b8ab-8f2183f9c45d"), "Red Nike Trainers - available in most sizes", "/Images/Shoes/Shoes5.png", "Red Nike Trainers", 200m, null, 100 },
                    { new Guid("26e5871a-a025-471d-842e-cf4c2ba72ba4"), new Guid("9441a0c6-9261-478b-b220-80b749501a2e"), "On-ear Golden Headphones - these headphones are not wireless", "/Images/Electronic/Electronics2.png", "On-ear Golden Headphones", 40m, null, 200 },
                    { new Guid("2a55b583-3879-4ec8-a0ba-e89395e6ec65"), new Guid("da1394f6-52fc-41e7-8c18-8045630be4c2"), "White and blue Porcelain Table Lamp", "/Images/Furniture/Furniture6.png", "Porcelain Table Lamp", 15m, null, 100 },
                    { new Guid("2feb6dc1-ae15-4df4-af55-b20c4190034b"), new Guid("99dd637c-3d3f-41f3-b758-58f0f73dc785"), "A kit provided by Schwarzkopf, containing skin care and hair care products", "/Images/Beauty/Beauty4.png", "Schwarzkopf - Hair Care and Skin Care Kit", 50m, null, 60 },
                    { new Guid("343bd352-842a-41d9-9c50-6916a4b66166"), new Guid("9441a0c6-9261-478b-b220-80b749501a2e"), "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod", "/Images/Electronic/Electronic4.png", "Sennheiser Digital Camera with Tripod", 600m, null, 20 },
                    { new Guid("4e8f5215-7dda-4683-9bd3-ba4d71943248"), new Guid("5eeb2e0a-b18c-4dcd-b8ab-8f2183f9c45d"), "Birkenstock Sandles - available in most sizes", "/Images/Shoes/Shoes6.png", "Birkenstock Sandles", 50m, null, 150 },
                    { new Guid("6debf193-3cad-4a33-8118-ac1badf645a7"), new Guid("da1394f6-52fc-41e7-8c18-8045630be4c2"), "Very comfortable lounge chair", "/Images/Furniture/Furniture3.png", "Lounge Chair", 70m, null, 90 },
                    { new Guid("722c5d42-0fc4-427f-ad4d-7c269550f65e"), new Guid("99dd637c-3d3f-41f3-b758-58f0f73dc785"), "A kit provided by Curology, containing skin care products", "/Images/Beauty/Beauty2.png", "Curology - Skin Care Kit", 50m, null, 45 },
                    { new Guid("7e685b06-f522-42b1-b274-ab6c17be6984"), new Guid("5eeb2e0a-b18c-4dcd-b8ab-8f2183f9c45d"), "Colorful trainsers - available in most sizes", "/Images/Shoes/Shoes2.png", "Colorful Trainers", 150m, null, 60 },
                    { new Guid("887a3178-ad38-4cbd-aa01-9dc677b3ebe9"), new Guid("da1394f6-52fc-41e7-8c18-8045630be4c2"), "Office Table Lamp", "/Images/Furniture/Furniture7.png", "Office Table Lamp", 20m, null, 73 },
                    { new Guid("adc33eae-276f-4b9f-b6a8-071a1deb0472"), new Guid("99dd637c-3d3f-41f3-b758-58f0f73dc785"), "A kit provided by Curology, containing skin care products", "/Images/Beauty/Beauty3.png", "Cocooil - Organic Coconut Oil", 20m, null, 30 },
                    { new Guid("b2f1ea77-5295-4435-8fc7-4ba3a0ca0879"), new Guid("da1394f6-52fc-41e7-8c18-8045630be4c2"), "Very comfortable black leather office chair", "/Images/Furniture/Furniture1.png", "Black Leather Office Chair", 50m, null, 212 },
                    { new Guid("c1564685-ddd7-4b06-88dd-23510ccc5c69"), new Guid("5eeb2e0a-b18c-4dcd-b8ab-8f2183f9c45d"), "Blue Nike Trainers - available in most sizes", "/Images/Shoes/Shoes3.png", "Blue Nike Trainers", 200m, null, 70 },
                    { new Guid("c7dedd51-977b-45d2-a9fa-197236689747"), new Guid("99dd637c-3d3f-41f3-b758-58f0f73dc785"), "Skin Care Kit, containing skin care and hair care products", "/Images/Beauty/Beauty5.png", "Skin Care Kit", 30m, null, 85 },
                    { new Guid("ce44fabf-a73f-4b0f-b1c0-002e182746e4"), new Guid("9441a0c6-9261-478b-b220-80b749501a2e"), "Air Pods - in-ear wireless headphones", "/Images/Electronic/Electronics1.png", "Air Pods", 100m, null, 120 },
                    { new Guid("d499c4e8-1a41-42b1-9c99-ba481fd13855"), new Guid("5eeb2e0a-b18c-4dcd-b8ab-8f2183f9c45d"), "Comfortable Puma Sneakers in most sizes", "/Images/Shoes/Shoes1.png", "Puma Sneakers", 100m, null, 50 },
                    { new Guid("d4a09638-d779-4b06-aa06-951352f063c5"), new Guid("9441a0c6-9261-478b-b220-80b749501a2e"), "Gameboy - Provided by Nintendo", "/Images/Electronic/technology6.png", "Nintendo Gameboy", 100m, null, 60 },
                    { new Guid("e403be6b-9f30-4d4e-bac4-af7e865f6c5b"), new Guid("da1394f6-52fc-41e7-8c18-8045630be4c2"), "Very comfortable pink leather office chair", "/Images/Furniture/Furniture2.png", "Pink Leather Office Chair", 50m, null, 112 },
                    { new Guid("e772f601-4086-49eb-9467-e1d22b44f899"), new Guid("9441a0c6-9261-478b-b220-80b749501a2e"), "On-ear Black Headphones - these headphones are not wireless", "/Images/Electronic/Electronics3.png", "On-ear Black Headphones", 40m, null, 300 },
                    { new Guid("ee4c0dd3-dfc2-4c8c-8e2e-9cfcef46d088"), new Guid("da1394f6-52fc-41e7-8c18-8045630be4c2"), "Very comfortable Silver lounge chair", "/Images/Furniture/Furniture4.png", "Silver Lounge Chair", 120m, null, 95 },
                    { new Guid("f13eb3e6-1d6d-45ad-93e6-2045d019d304"), new Guid("99dd637c-3d3f-41f3-b758-58f0f73dc785"), "A kit provided by Glossier, containing skin care, hair care and makeup products", "/Images/Beauty/Beauty1.png", "Glossier - Beauty Kit", 100m, null, 100 }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("d6fc526f-dc03-4050-9a2d-f4206fd0f9b7"), "67733d2a-8a33-4d14-abd8-46ec36d517e1" },
                    { new Guid("ed267a7b-1def-4d0b-ac9e-2821f2db577b"), "2b147016-beb2-4f3f-a311-1bfc036fe047" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_AspNetUsers_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AspNetUsers_UserId",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_UserId",
                table: "Carts");

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("d6fc526f-dc03-4050-9a2d-f4206fd0f9b7"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("ed267a7b-1def-4d0b-ac9e-2821f2db577b"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5eeb2e0a-b18c-4dcd-b8ab-8f2183f9c45d"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("9441a0c6-9261-478b-b220-80b749501a2e"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("99dd637c-3d3f-41f3-b758-58f0f73dc785"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("da1394f6-52fc-41e7-8c18-8045630be4c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d38d872-4b13-466a-99ce-476a2d354953"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0fdbe91c-7322-4188-ad03-13007495338e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("259a2650-c2f6-4e18-814f-90c87bbe983d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26e5871a-a025-471d-842e-cf4c2ba72ba4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a55b583-3879-4ec8-a0ba-e89395e6ec65"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2feb6dc1-ae15-4df4-af55-b20c4190034b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("343bd352-842a-41d9-9c50-6916a4b66166"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e8f5215-7dda-4683-9bd3-ba4d71943248"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6debf193-3cad-4a33-8118-ac1badf645a7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("722c5d42-0fc4-427f-ad4d-7c269550f65e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e685b06-f522-42b1-b274-ab6c17be6984"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("887a3178-ad38-4cbd-aa01-9dc677b3ebe9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("adc33eae-276f-4b9f-b6a8-071a1deb0472"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2f1ea77-5295-4435-8fc7-4ba3a0ca0879"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c1564685-ddd7-4b06-88dd-23510ccc5c69"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c7dedd51-977b-45d2-a9fa-197236689747"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ce44fabf-a73f-4b0f-b1c0-002e182746e4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d499c4e8-1a41-42b1-9c99-ba481fd13855"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d4a09638-d779-4b06-aa06-951352f063c5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e403be6b-9f30-4d4e-bac4-af7e865f6c5b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e772f601-4086-49eb-9467-e1d22b44f899"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee4c0dd3-dfc2-4c8c-8e2e-9cfcef46d088"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f13eb3e6-1d6d-45ad-93e6-2045d019d304"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b147016-beb2-4f3f-a311-1bfc036fe047");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67733d2a-8a33-4d14-abd8-46ec36d517e1");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Carts",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Carts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9b8467f2-1899-4aef-9e78-62847fc26c80", 0, "31ff8998-2d72-4351-a161-6a69a6961bc7", null, false, false, null, null, null, null, null, false, "6f765927-f4d8-4d64-8734-da929a8bd2a4", false, "Sarah" },
                    { "cb89a675-259c-4f39-bd85-a90cd70fe63e", 0, "0c5db0ba-86f3-46b5-bd3a-91acd234f642", null, false, false, null, null, null, null, null, false, "afe404b7-dcd2-405d-b543-13baecc440fe", false, "Bob" }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId", "UserId1" },
                values: new object[,]
                {
                    { new Guid("9a04c83f-ea42-4da1-be0d-249c02e4fa51"), new Guid("9b8467f2-1899-4aef-9e78-62847fc26c80"), null },
                    { new Guid("ae697fd9-f08f-4668-a07b-744054056683"), new Guid("cb89a675-259c-4f39-bd85-a90cd70fe63e"), null }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("496646a1-62cc-4fbc-8887-2368958692f3"), "Furniture" },
                    { new Guid("7b329c63-1a70-4c43-a0f1-d7b290e69235"), "Beauty" },
                    { new Guid("ac99e5ef-c4ba-4967-8455-e808e25fda39"), "Shoes" },
                    { new Guid("f8f90557-97d4-4f77-bec2-89a8590af933"), "Electronics" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price", "ProductCategoryId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("1a9db661-31a7-42df-a109-205db145e0e2"), new Guid("f8f90557-97d4-4f77-bec2-89a8590af933"), "On-ear Black Headphones - these headphones are not wireless", "/Images/Electronic/Electronics3.png", "On-ear Black Headphones", 40m, null, 300 },
                    { new Guid("1b8f7575-7795-4c0a-a136-f233597d21e4"), new Guid("ac99e5ef-c4ba-4967-8455-e808e25fda39"), "Red Nike Trainers - available in most sizes", "/Images/Shoes/Shoes5.png", "Red Nike Trainers", 200m, null, 100 },
                    { new Guid("272d9b13-2c87-48b7-b92a-9e34007ae21f"), new Guid("7b329c63-1a70-4c43-a0f1-d7b290e69235"), "Skin Care Kit, containing skin care and hair care products", "/Images/Beauty/Beauty5.png", "Skin Care Kit", 30m, null, 85 },
                    { new Guid("2cc97d40-f9e4-45a0-9aa0-b11fa5b8eab5"), new Guid("f8f90557-97d4-4f77-bec2-89a8590af933"), "Canon Digital Camera - High quality digital camera provided by Canon", "/Images/Electronic/Electronic5.png", "Canon Digital Camera", 500m, null, 15 },
                    { new Guid("2d7d9894-e59d-4a57-b12c-277aa6571d8a"), new Guid("496646a1-62cc-4fbc-8887-2368958692f3"), "Very comfortable pink leather office chair", "/Images/Furniture/Furniture2.png", "Pink Leather Office Chair", 50m, null, 112 },
                    { new Guid("3fa7b9ac-d574-4b9f-ac8c-524de1fa6b82"), new Guid("ac99e5ef-c4ba-4967-8455-e808e25fda39"), "Birkenstock Sandles - available in most sizes", "/Images/Shoes/Shoes6.png", "Birkenstock Sandles", 50m, null, 150 },
                    { new Guid("432bfb54-08db-4774-8c1b-93b862f0e68a"), new Guid("496646a1-62cc-4fbc-8887-2368958692f3"), "White and blue Porcelain Table Lamp", "/Images/Furniture/Furniture6.png", "Porcelain Table Lamp", 15m, null, 100 },
                    { new Guid("4a692279-4757-4042-bb3a-fd7a7b51c43e"), new Guid("f8f90557-97d4-4f77-bec2-89a8590af933"), "Air Pods - in-ear wireless headphones", "/Images/Electronic/Electronics1.png", "Air Pods", 100m, null, 120 },
                    { new Guid("6e40f1e0-74f8-4238-a275-8863a3c9c092"), new Guid("7b329c63-1a70-4c43-a0f1-d7b290e69235"), "A kit provided by Glossier, containing skin care, hair care and makeup products", "/Images/Beauty/Beauty1.png", "Glossier - Beauty Kit", 100m, null, 100 },
                    { new Guid("7312f689-9895-4aa5-94d2-05579ac622e6"), new Guid("ac99e5ef-c4ba-4967-8455-e808e25fda39"), "Colorful Hummel Trainers - available in most sizes", "/Images/Shoes/Shoes4.png", "Colorful Hummel Trainers", 120m, null, 120 },
                    { new Guid("86d5add8-f0da-4420-a9ac-aff37266f150"), new Guid("f8f90557-97d4-4f77-bec2-89a8590af933"), "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod", "/Images/Electronic/Electronic4.png", "Sennheiser Digital Camera with Tripod", 600m, null, 20 },
                    { new Guid("8a72c10a-90e6-4302-acfd-90c31197844f"), new Guid("496646a1-62cc-4fbc-8887-2368958692f3"), "Very comfortable black leather office chair", "/Images/Furniture/Furniture1.png", "Black Leather Office Chair", 50m, null, 212 },
                    { new Guid("8dafeb36-42d8-4d88-8e8d-e1df5b064b2a"), new Guid("7b329c63-1a70-4c43-a0f1-d7b290e69235"), "A kit provided by Schwarzkopf, containing skin care and hair care products", "/Images/Beauty/Beauty4.png", "Schwarzkopf - Hair Care and Skin Care Kit", 50m, null, 60 },
                    { new Guid("9a014943-1359-4fb4-b145-b91b2ddb40d8"), new Guid("7b329c63-1a70-4c43-a0f1-d7b290e69235"), "A kit provided by Curology, containing skin care products", "/Images/Beauty/Beauty3.png", "Cocooil - Organic Coconut Oil", 20m, null, 30 },
                    { new Guid("a87834bc-1ef7-40b2-851a-84377daf0ad2"), new Guid("f8f90557-97d4-4f77-bec2-89a8590af933"), "On-ear Golden Headphones - these headphones are not wireless", "/Images/Electronic/Electronics2.png", "On-ear Golden Headphones", 40m, null, 200 },
                    { new Guid("ad9c9cba-6b7b-4314-b664-2833eac5cd3e"), new Guid("7b329c63-1a70-4c43-a0f1-d7b290e69235"), "A kit provided by Curology, containing skin care products", "/Images/Beauty/Beauty2.png", "Curology - Skin Care Kit", 50m, null, 45 },
                    { new Guid("cb3a3325-d18f-45db-b538-90e3a0fdacf1"), new Guid("ac99e5ef-c4ba-4967-8455-e808e25fda39"), "Comfortable Puma Sneakers in most sizes", "/Images/Shoes/Shoes1.png", "Puma Sneakers", 100m, null, 50 },
                    { new Guid("d44de529-b06a-4da9-b453-c52508879ea4"), new Guid("496646a1-62cc-4fbc-8887-2368958692f3"), "Office Table Lamp", "/Images/Furniture/Furniture7.png", "Office Table Lamp", 20m, null, 73 },
                    { new Guid("d888fc24-120d-4ad0-a4db-acfcbabd0ce7"), new Guid("ac99e5ef-c4ba-4967-8455-e808e25fda39"), "Blue Nike Trainers - available in most sizes", "/Images/Shoes/Shoes3.png", "Blue Nike Trainers", 200m, null, 70 },
                    { new Guid("daba467e-c951-4701-9821-1e4762b0f88b"), new Guid("496646a1-62cc-4fbc-8887-2368958692f3"), "Very comfortable lounge chair", "/Images/Furniture/Furniture3.png", "Lounge Chair", 70m, null, 90 },
                    { new Guid("dacf974b-aa2a-4aee-befb-fa1d003c7fbf"), new Guid("496646a1-62cc-4fbc-8887-2368958692f3"), "Very comfortable Silver lounge chair", "/Images/Furniture/Furniture4.png", "Silver Lounge Chair", 120m, null, 95 },
                    { new Guid("e3e76f10-964b-4f3a-b17e-af680aa1cef8"), new Guid("ac99e5ef-c4ba-4967-8455-e808e25fda39"), "Colorful trainsers - available in most sizes", "/Images/Shoes/Shoes2.png", "Colorful Trainers", 150m, null, 60 },
                    { new Guid("ef9bca5b-9fc0-4a5b-b444-bfca62afc3bb"), new Guid("f8f90557-97d4-4f77-bec2-89a8590af933"), "Gameboy - Provided by Nintendo", "/Images/Electronic/technology6.png", "Nintendo Gameboy", 100m, null, 60 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId1",
                table: "Carts",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_AspNetUsers_UserId1",
                table: "Carts",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
