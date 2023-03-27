using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopOnline.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UserCartFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
