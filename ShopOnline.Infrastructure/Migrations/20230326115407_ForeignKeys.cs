using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopOnline.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43ac8246-472c-4263-b085-e12d47cc115b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bf3a0e0-df9d-4338-90ab-c19f2a1c6279");

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("0dc09460-475c-4274-a846-8fe876212f03"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("1884945d-82c1-4be0-bebf-07761a395f33"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("0843dbae-92f3-42bc-9856-c54c9cf86e2a"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("37cbd601-0056-415a-b6db-184b8c530fa2"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("592c22f1-104c-4b12-b4f1-f7277d24d165"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("90ab4e02-8e5f-4ea3-9713-36fd5b1bb731"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08bdc3c7-1f1b-427d-90db-81051f89dc11"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1941c186-6615-4d0b-8ad3-be81d1fdf1ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b48ccd2-9e25-470a-8fe6-846ee51ad77d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("29706979-db8d-44b4-a140-2a01ad58fb96"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("39eced0b-ce46-4e00-b4e5-97436996feda"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("41eeb414-68a3-413d-9a15-302ca49ba49b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("54f4cb74-dd30-4040-ae87-ed7fb26792ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d07b5d8-a473-443b-bdcb-ddea33828fc0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("806926a6-77fa-42c4-a500-0f73464d914b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8dbcfc8d-ee17-4261-a9e2-6dc20b0cbf9b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("90128652-8dea-4d6c-874f-9714c049e45e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b0aa2408-127d-4290-b9ae-774d88d2930b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6ae07a4-38b9-4084-bf77-8b53a03c5896"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bb96398b-5adb-4940-a474-394d9e4da26c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c436ce7e-9701-413c-aaaa-46d94c9e4329"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c89fbebf-357b-4bda-8d09-b5d2b9acd31a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd5a03ea-7993-4dea-b12d-8cbcc393dab7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e46a4b0f-a21b-4069-a8b8-cb603bd9dba4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e720c6f5-d92d-4004-a9ef-a60d770f2f94"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee362270-839f-49e4-96b7-cd068dd4ac27"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee71b1d2-72fc-47d7-82dd-9000912de572"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5228e50-f432-4d9c-b5e0-86d613a30a34"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ffb85d8f-1ab2-4362-a49d-3c6da8fd7d2f"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProductCategoryId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b5a069d1-f27e-4bed-9713-76e9c84bd2d6", 0, "717b293c-1681-4bc1-af91-c86a0f3dd64e", null, false, false, null, null, null, null, null, false, "31e474b7-58a7-4297-89d6-dd2139dac87b", false, "Bob" },
                    { "ed4b8d68-5d3a-4e03-9089-df6228668b86", 0, "44b5a858-d4c2-4692-a159-136e077fa9e0", null, false, false, null, null, null, null, null, false, "3f16fdff-1e67-493c-a791-e30dca6ee1ee", false, "Sarah" }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("0246a39b-d044-4b95-8fff-a336a5d534f4"), new Guid("b5a069d1-f27e-4bed-9713-76e9c84bd2d6") },
                    { new Guid("28d71a78-25eb-44e0-92dd-c4a57500c566"), new Guid("ed4b8d68-5d3a-4e03-9089-df6228668b86") }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("720f4698-b9e2-4b3d-addf-420f6bdc8088"), "Furniture" },
                    { new Guid("aba74681-d207-4312-a5dd-6e607bd95ec6"), "Electronics" },
                    { new Guid("bb89601e-1281-480f-a537-5f76b7f133ed"), "Beauty" },
                    { new Guid("ef5a969c-7c00-4e90-afee-44601d62431f"), "Shoes" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price", "ProductCategoryId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("1993d36a-7840-4625-a74e-b354d34f30e4"), new Guid("aba74681-d207-4312-a5dd-6e607bd95ec6"), "Canon Digital Camera - High quality digital camera provided by Canon", "/Images/Electronic/Electronic5.png", "Canon Digital Camera", 500m, null, 15 },
                    { new Guid("2d22477b-ad4e-442e-8af4-59296621aed8"), new Guid("720f4698-b9e2-4b3d-addf-420f6bdc8088"), "Very comfortable black leather office chair", "/Images/Furniture/Furniture1.png", "Black Leather Office Chair", 50m, null, 212 },
                    { new Guid("34c65cfd-f449-4e03-b659-b1bd1bc0c185"), new Guid("ef5a969c-7c00-4e90-afee-44601d62431f"), "Colorful trainsers - available in most sizes", "/Images/Shoes/Shoes2.png", "Colorful Trainers", 150m, null, 60 },
                    { new Guid("4ae7c9be-54e9-484f-bd6d-3bb71dabdbef"), new Guid("720f4698-b9e2-4b3d-addf-420f6bdc8088"), "Office Table Lamp", "/Images/Furniture/Furniture7.png", "Office Table Lamp", 20m, null, 73 },
                    { new Guid("555eee14-5cfa-40ba-a8da-09c633eb42d8"), new Guid("ef5a969c-7c00-4e90-afee-44601d62431f"), "Blue Nike Trainers - available in most sizes", "/Images/Shoes/Shoes3.png", "Blue Nike Trainers", 200m, null, 70 },
                    { new Guid("5784a5a2-1704-4b1f-b2f7-e8618eaa5bca"), new Guid("720f4698-b9e2-4b3d-addf-420f6bdc8088"), "Very comfortable Silver lounge chair", "/Images/Furniture/Furniture4.png", "Silver Lounge Chair", 120m, null, 95 },
                    { new Guid("5c5f007f-eae9-4096-8719-d18c002d1d25"), new Guid("aba74681-d207-4312-a5dd-6e607bd95ec6"), "On-ear Golden Headphones - these headphones are not wireless", "/Images/Electronic/Electronics2.png", "On-ear Golden Headphones", 40m, null, 200 },
                    { new Guid("5f3ada26-5d41-40dd-8201-cb0ab2c2a16c"), new Guid("ef5a969c-7c00-4e90-afee-44601d62431f"), "Birkenstock Sandles - available in most sizes", "/Images/Shoes/Shoes6.png", "Birkenstock Sandles", 50m, null, 150 },
                    { new Guid("620e3d84-50e0-4c3d-af61-b7d67375272f"), new Guid("aba74681-d207-4312-a5dd-6e607bd95ec6"), "Gameboy - Provided by Nintendo", "/Images/Electronic/technology6.png", "Nintendo Gameboy", 100m, null, 60 },
                    { new Guid("63054d6a-b714-47df-985f-dc874fb872a4"), new Guid("ef5a969c-7c00-4e90-afee-44601d62431f"), "Colorful Hummel Trainers - available in most sizes", "/Images/Shoes/Shoes4.png", "Colorful Hummel Trainers", 120m, null, 120 },
                    { new Guid("6a938cd7-a277-40e9-b328-92bb5c9ab383"), new Guid("bb89601e-1281-480f-a537-5f76b7f133ed"), "A kit provided by Glossier, containing skin care, hair care and makeup products", "/Images/Beauty/Beauty1.png", "Glossier - Beauty Kit", 100m, null, 100 },
                    { new Guid("719c248f-12b5-48cf-8ebc-cd224970f40f"), new Guid("720f4698-b9e2-4b3d-addf-420f6bdc8088"), "Very comfortable pink leather office chair", "/Images/Furniture/Furniture2.png", "Pink Leather Office Chair", 50m, null, 112 },
                    { new Guid("725c3357-6b3f-416d-b6bc-a56a8bab8073"), new Guid("aba74681-d207-4312-a5dd-6e607bd95ec6"), "Air Pods - in-ear wireless headphones", "/Images/Electronic/Electronics1.png", "Air Pods", 100m, null, 120 },
                    { new Guid("8e601a8b-9f92-4580-ac6d-e9dc9416ea2c"), new Guid("720f4698-b9e2-4b3d-addf-420f6bdc8088"), "Very comfortable lounge chair", "/Images/Furniture/Furniture3.png", "Lounge Chair", 70m, null, 90 },
                    { new Guid("a4f551d4-6cd7-4ba3-95ee-9e18dc248944"), new Guid("bb89601e-1281-480f-a537-5f76b7f133ed"), "Skin Care Kit, containing skin care and hair care products", "/Images/Beauty/Beauty5.png", "Skin Care Kit", 30m, null, 85 },
                    { new Guid("a7571390-c2a3-4c9a-bba7-4e3368bdff51"), new Guid("aba74681-d207-4312-a5dd-6e607bd95ec6"), "On-ear Black Headphones - these headphones are not wireless", "/Images/Electronic/Electronics3.png", "On-ear Black Headphones", 40m, null, 300 },
                    { new Guid("aa93d2a3-c9fb-4f00-ae49-9cf50cbfa669"), new Guid("bb89601e-1281-480f-a537-5f76b7f133ed"), "A kit provided by Schwarzkopf, containing skin care and hair care products", "/Images/Beauty/Beauty4.png", "Schwarzkopf - Hair Care and Skin Care Kit", 50m, null, 60 },
                    { new Guid("c66d826c-26fe-4011-b9f6-381bde9db906"), new Guid("bb89601e-1281-480f-a537-5f76b7f133ed"), "A kit provided by Curology, containing skin care products", "/Images/Beauty/Beauty3.png", "Cocooil - Organic Coconut Oil", 20m, null, 30 },
                    { new Guid("cd81d66c-4369-4f5d-ab72-906b5da68238"), new Guid("bb89601e-1281-480f-a537-5f76b7f133ed"), "A kit provided by Curology, containing skin care products", "/Images/Beauty/Beauty2.png", "Curology - Skin Care Kit", 50m, null, 45 },
                    { new Guid("d4e901e2-132d-4b9e-908b-7dc3108ae101"), new Guid("ef5a969c-7c00-4e90-afee-44601d62431f"), "Comfortable Puma Sneakers in most sizes", "/Images/Shoes/Shoes1.png", "Puma Sneakers", 100m, null, 50 },
                    { new Guid("e98a8d32-0f6a-4f31-a587-0c5d15c55ceb"), new Guid("aba74681-d207-4312-a5dd-6e607bd95ec6"), "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod", "/Images/Electronic/Electronic4.png", "Sennheiser Digital Camera with Tripod", 600m, null, 20 },
                    { new Guid("f57f2237-8a76-4179-ac13-13758c4c088c"), new Guid("720f4698-b9e2-4b3d-addf-420f6bdc8088"), "White and blue Porcelain Table Lamp", "/Images/Furniture/Furniture6.png", "Porcelain Table Lamp", 15m, null, 100 },
                    { new Guid("f8e6bc93-9aff-4857-87e1-f9bbdee8fb0c"), new Guid("ef5a969c-7c00-4e90-afee-44601d62431f"), "Red Nike Trainers - available in most sizes", "/Images/Shoes/Shoes5.png", "Red Nike Trainers", 200m, null, 100 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Carts_CartId",
                table: "CartItems",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Products_ProductId",
                table: "CartItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Carts_CartId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Products_ProductId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5a069d1-f27e-4bed-9713-76e9c84bd2d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed4b8d68-5d3a-4e03-9089-df6228668b86");

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("0246a39b-d044-4b95-8fff-a336a5d534f4"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("28d71a78-25eb-44e0-92dd-c4a57500c566"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("720f4698-b9e2-4b3d-addf-420f6bdc8088"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("aba74681-d207-4312-a5dd-6e607bd95ec6"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("bb89601e-1281-480f-a537-5f76b7f133ed"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("ef5a969c-7c00-4e90-afee-44601d62431f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1993d36a-7840-4625-a74e-b354d34f30e4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2d22477b-ad4e-442e-8af4-59296621aed8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34c65cfd-f449-4e03-b659-b1bd1bc0c185"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ae7c9be-54e9-484f-bd6d-3bb71dabdbef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("555eee14-5cfa-40ba-a8da-09c633eb42d8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5784a5a2-1704-4b1f-b2f7-e8618eaa5bca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c5f007f-eae9-4096-8719-d18c002d1d25"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f3ada26-5d41-40dd-8201-cb0ab2c2a16c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("620e3d84-50e0-4c3d-af61-b7d67375272f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("63054d6a-b714-47df-985f-dc874fb872a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6a938cd7-a277-40e9-b328-92bb5c9ab383"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("719c248f-12b5-48cf-8ebc-cd224970f40f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("725c3357-6b3f-416d-b6bc-a56a8bab8073"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e601a8b-9f92-4580-ac6d-e9dc9416ea2c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4f551d4-6cd7-4ba3-95ee-9e18dc248944"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a7571390-c2a3-4c9a-bba7-4e3368bdff51"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa93d2a3-c9fb-4f00-ae49-9cf50cbfa669"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c66d826c-26fe-4011-b9f6-381bde9db906"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd81d66c-4369-4f5d-ab72-906b5da68238"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d4e901e2-132d-4b9e-908b-7dc3108ae101"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e98a8d32-0f6a-4f31-a587-0c5d15c55ceb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f57f2237-8a76-4179-ac13-13758c4c088c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f8e6bc93-9aff-4857-87e1-f9bbdee8fb0c"));

            migrationBuilder.DropColumn(
                name: "ProductCategoryId",
                table: "Products");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "43ac8246-472c-4263-b085-e12d47cc115b", 0, "7afb5117-6b84-4b69-bb2a-6efd807dd505", null, false, false, null, null, null, null, null, false, "51b84263-284f-4a1a-b740-c1c0b665d2f2", false, "Bob" },
                    { "6bf3a0e0-df9d-4338-90ab-c19f2a1c6279", 0, "7d505759-95af-44e0-9068-94e41c114a78", null, false, false, null, null, null, null, null, false, "ff3a02e4-fa34-4cc6-a85c-f09abca6e505", false, "Sarah" }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("0dc09460-475c-4274-a846-8fe876212f03"), new Guid("6bf3a0e0-df9d-4338-90ab-c19f2a1c6279") },
                    { new Guid("1884945d-82c1-4be0-bebf-07761a395f33"), new Guid("43ac8246-472c-4263-b085-e12d47cc115b") }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0843dbae-92f3-42bc-9856-c54c9cf86e2a"), "Beauty" },
                    { new Guid("37cbd601-0056-415a-b6db-184b8c530fa2"), "Shoes" },
                    { new Guid("592c22f1-104c-4b12-b4f1-f7277d24d165"), "Electronics" },
                    { new Guid("90ab4e02-8e5f-4ea3-9713-36fd5b1bb731"), "Furniture" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("08bdc3c7-1f1b-427d-90db-81051f89dc11"), new Guid("0843dbae-92f3-42bc-9856-c54c9cf86e2a"), "A kit provided by Glossier, containing skin care, hair care and makeup products", "/Images/Beauty/Beauty1.png", "Glossier - Beauty Kit", 100m, 100 },
                    { new Guid("1941c186-6615-4d0b-8ad3-be81d1fdf1ac"), new Guid("37cbd601-0056-415a-b6db-184b8c530fa2"), "Colorful trainsers - available in most sizes", "/Images/Shoes/Shoes2.png", "Colorful Trainers", 150m, 60 },
                    { new Guid("1b48ccd2-9e25-470a-8fe6-846ee51ad77d"), new Guid("90ab4e02-8e5f-4ea3-9713-36fd5b1bb731"), "Very comfortable Silver lounge chair", "/Images/Furniture/Furniture4.png", "Silver Lounge Chair", 120m, 95 },
                    { new Guid("29706979-db8d-44b4-a140-2a01ad58fb96"), new Guid("37cbd601-0056-415a-b6db-184b8c530fa2"), "Birkenstock Sandles - available in most sizes", "/Images/Shoes/Shoes6.png", "Birkenstock Sandles", 50m, 150 },
                    { new Guid("39eced0b-ce46-4e00-b4e5-97436996feda"), new Guid("0843dbae-92f3-42bc-9856-c54c9cf86e2a"), "A kit provided by Curology, containing skin care products", "/Images/Beauty/Beauty2.png", "Curology - Skin Care Kit", 50m, 45 },
                    { new Guid("41eeb414-68a3-413d-9a15-302ca49ba49b"), new Guid("0843dbae-92f3-42bc-9856-c54c9cf86e2a"), "A kit provided by Schwarzkopf, containing skin care and hair care products", "/Images/Beauty/Beauty4.png", "Schwarzkopf - Hair Care and Skin Care Kit", 50m, 60 },
                    { new Guid("54f4cb74-dd30-4040-ae87-ed7fb26792ea"), new Guid("90ab4e02-8e5f-4ea3-9713-36fd5b1bb731"), "Very comfortable lounge chair", "/Images/Furniture/Furniture3.png", "Lounge Chair", 70m, 90 },
                    { new Guid("6d07b5d8-a473-443b-bdcb-ddea33828fc0"), new Guid("592c22f1-104c-4b12-b4f1-f7277d24d165"), "Air Pods - in-ear wireless headphones", "/Images/Electronic/Electronics1.png", "Air Pods", 100m, 120 },
                    { new Guid("806926a6-77fa-42c4-a500-0f73464d914b"), new Guid("90ab4e02-8e5f-4ea3-9713-36fd5b1bb731"), "Office Table Lamp", "/Images/Furniture/Furniture7.png", "Office Table Lamp", 20m, 73 },
                    { new Guid("8dbcfc8d-ee17-4261-a9e2-6dc20b0cbf9b"), new Guid("90ab4e02-8e5f-4ea3-9713-36fd5b1bb731"), "White and blue Porcelain Table Lamp", "/Images/Furniture/Furniture6.png", "Porcelain Table Lamp", 15m, 100 },
                    { new Guid("90128652-8dea-4d6c-874f-9714c049e45e"), new Guid("592c22f1-104c-4b12-b4f1-f7277d24d165"), "On-ear Golden Headphones - these headphones are not wireless", "/Images/Electronic/Electronics2.png", "On-ear Golden Headphones", 40m, 200 },
                    { new Guid("b0aa2408-127d-4290-b9ae-774d88d2930b"), new Guid("0843dbae-92f3-42bc-9856-c54c9cf86e2a"), "A kit provided by Curology, containing skin care products", "/Images/Beauty/Beauty3.png", "Cocooil - Organic Coconut Oil", 20m, 30 },
                    { new Guid("b6ae07a4-38b9-4084-bf77-8b53a03c5896"), new Guid("592c22f1-104c-4b12-b4f1-f7277d24d165"), "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod", "/Images/Electronic/Electronic4.png", "Sennheiser Digital Camera with Tripod", 600m, 20 },
                    { new Guid("bb96398b-5adb-4940-a474-394d9e4da26c"), new Guid("37cbd601-0056-415a-b6db-184b8c530fa2"), "Red Nike Trainers - available in most sizes", "/Images/Shoes/Shoes5.png", "Red Nike Trainers", 200m, 100 },
                    { new Guid("c436ce7e-9701-413c-aaaa-46d94c9e4329"), new Guid("37cbd601-0056-415a-b6db-184b8c530fa2"), "Colorful Hummel Trainers - available in most sizes", "/Images/Shoes/Shoes4.png", "Colorful Hummel Trainers", 120m, 120 },
                    { new Guid("c89fbebf-357b-4bda-8d09-b5d2b9acd31a"), new Guid("592c22f1-104c-4b12-b4f1-f7277d24d165"), "On-ear Black Headphones - these headphones are not wireless", "/Images/Electronic/Electronics3.png", "On-ear Black Headphones", 40m, 300 },
                    { new Guid("cd5a03ea-7993-4dea-b12d-8cbcc393dab7"), new Guid("0843dbae-92f3-42bc-9856-c54c9cf86e2a"), "Skin Care Kit, containing skin care and hair care products", "/Images/Beauty/Beauty5.png", "Skin Care Kit", 30m, 85 },
                    { new Guid("e46a4b0f-a21b-4069-a8b8-cb603bd9dba4"), new Guid("37cbd601-0056-415a-b6db-184b8c530fa2"), "Comfortable Puma Sneakers in most sizes", "/Images/Shoes/Shoes1.png", "Puma Sneakers", 100m, 50 },
                    { new Guid("e720c6f5-d92d-4004-a9ef-a60d770f2f94"), new Guid("37cbd601-0056-415a-b6db-184b8c530fa2"), "Blue Nike Trainers - available in most sizes", "/Images/Shoes/Shoes3.png", "Blue Nike Trainers", 200m, 70 },
                    { new Guid("ee362270-839f-49e4-96b7-cd068dd4ac27"), new Guid("592c22f1-104c-4b12-b4f1-f7277d24d165"), "Gameboy - Provided by Nintendo", "/Images/Electronic/technology6.png", "Nintendo Gameboy", 100m, 60 },
                    { new Guid("ee71b1d2-72fc-47d7-82dd-9000912de572"), new Guid("592c22f1-104c-4b12-b4f1-f7277d24d165"), "Canon Digital Camera - High quality digital camera provided by Canon", "/Images/Electronic/Electronic5.png", "Canon Digital Camera", 500m, 15 },
                    { new Guid("f5228e50-f432-4d9c-b5e0-86d613a30a34"), new Guid("90ab4e02-8e5f-4ea3-9713-36fd5b1bb731"), "Very comfortable pink leather office chair", "/Images/Furniture/Furniture2.png", "Pink Leather Office Chair", 50m, 112 },
                    { new Guid("ffb85d8f-1ab2-4362-a49d-3c6da8fd7d2f"), new Guid("90ab4e02-8e5f-4ea3-9713-36fd5b1bb731"), "Very comfortable black leather office chair", "/Images/Furniture/Furniture1.png", "Black Leather Office Chair", 50m, 212 }
                });
        }
    }
}
