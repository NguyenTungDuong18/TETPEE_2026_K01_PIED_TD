using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TetPee.Repository.Migrations
{
    /// <inheritdoc />
    public partial class TestOnModelCreating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Sellers_SellerId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_SellerId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Users",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "User",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "character varying(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Users",
                type: "character varying(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HashedPassword",
                table: "Users",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "CompanyAddress",
                table: "Sellers",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Sellers",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreateAt",
                table: "Sellers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Sellers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "TaxCode",
                table: "Sellers",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "UpdateAt",
                table: "Sellers",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Sellers",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Orders",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Orders",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreateAt",
                table: "Orders",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Orders",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Orders",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "Orders",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "UpdateAt",
                table: "Orders",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ParentId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    UrlImage = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    SellerId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreateAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    CreateAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TotalSell = table.Column<int>(type: "integer", nullable: false),
                    TotalInStock = table.Column<int>(type: "integer", nullable: false),
                    ProGuidId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreateAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventories_Products_ProGuidId",
                        column: x => x.ProGuidId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    CreateAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreateAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductStorages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    StorageId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreateAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStorages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductStorages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductStorages_Storages_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "IsDeleted", "Name", "ParentId", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("76607dce-928a-4cbd-8c12-f70d7541d530"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần", null, null },
                    { new Guid("9c68c104-0ddc-4f5f-bb20-69e54a2d6a76"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreateAt", "DateOfBirth", "Email", "FirstName", "HashedPassword", "ImageUrl", "IsDeleted", "IsVerified", "LastName", "PhoneNumber", "Role", "UpdateAt", "VerifiedCode" },
                values: new object[,]
                {
                    { new Guid("00022283-a3d2-449d-865a-2db62858443a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan344@gmail.com", "Tuan", "hashed_password_1344", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("00411e8b-61a4-4b42-8e84-ca157e327d95"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan856@gmail.com", "Tuan", "hashed_password_1856", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("00495ea1-89ed-4e44-824f-6e9bbc3e4fb6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan998@gmail.com", "Tuan", "hashed_password_1998", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("005c0abb-3f27-47a5-b99f-37a1f2ed9588"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan170@gmail.com", "Tuan", "hashed_password_1170", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("00966d70-d354-4ffa-ba8b-91a45d518a52"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan451@gmail.com", "Tuan", "hashed_password_1451", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("00e80dd2-3720-4f0a-8c69-0139a96057c9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan223@gmail.com", "Tuan", "hashed_password_1223", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("01262607-45c7-451f-b131-888c6943bb00"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan929@gmail.com", "Tuan", "hashed_password_1929", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("013421d4-e440-4632-acc9-c82f7eb47ef3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan1@gmail.com", "Tuan", "hashed_password_11", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("01a88e67-96c7-4a75-a67c-5fc836d70136"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan241@gmail.com", "Tuan", "hashed_password_1241", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("02976a88-2e14-420b-9f84-7f9b55a2f267"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan220@gmail.com", "Tuan", "hashed_password_1220", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("034b88d4-c9fe-4dda-a9d5-536f45ca9edb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan30@gmail.com", "Tuan", "hashed_password_130", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("039ca4e7-cdd3-4bdd-8925-573a33a0bf2d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan640@gmail.com", "Tuan", "hashed_password_1640", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("03a4ff38-9ed5-485c-be1b-b52e1822a9cb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan93@gmail.com", "Tuan", "hashed_password_193", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("03e014cb-cd45-4901-a3a0-fc3e61edb16a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan866@gmail.com", "Tuan", "hashed_password_1866", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("041d2f6f-3cc6-49c9-ad3a-feb12ed72e12"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan639@gmail.com", "Tuan", "hashed_password_1639", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0444e67d-cf8d-489e-9a5d-02f61e7c359b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan797@gmail.com", "Tuan", "hashed_password_1797", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("04612ada-146e-4af0-aa39-fe84ed74c430"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan469@gmail.com", "Tuan", "hashed_password_1469", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("048169d8-acd7-44b5-abb0-04a38bd3d42d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan217@gmail.com", "Tuan", "hashed_password_1217", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("04fdde23-a378-4b3c-b4a3-23502161e936"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan236@gmail.com", "Tuan", "hashed_password_1236", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0529504e-08c4-44a7-9c3f-c0a9dae8b832"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan881@gmail.com", "Tuan", "hashed_password_1881", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0543605c-debe-4624-9a30-c268a3e7cd74"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan627@gmail.com", "Tuan", "hashed_password_1627", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("05464473-af06-4895-804b-99e38e940aa9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan101@gmail.com", "Tuan", "hashed_password_1101", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("057a6939-3572-4dbb-bbd0-e63e646df50d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan924@gmail.com", "Tuan", "hashed_password_1924", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("06795e70-aa7a-4a24-b42d-df3090d368f2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan16@gmail.com", "Tuan", "hashed_password_116", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("06ef5bbe-a678-4449-bdb5-d218aeef85f2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan491@gmail.com", "Tuan", "hashed_password_1491", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("06f6234b-79f7-4d6a-b149-e24978e34a73"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan288@gmail.com", "Tuan", "hashed_password_1288", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("072a89f5-8f5d-49fd-9fdf-43404700eeb3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan723@gmail.com", "Tuan", "hashed_password_1723", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("072f189a-4b93-4e64-9dfa-37d0abebf6b8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan3@gmail.com", "Tuan", "hashed_password_13", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("076967f2-9010-4479-9195-10999f4a58d1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan307@gmail.com", "Tuan", "hashed_password_1307", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("077dd9d4-6513-42e8-986c-c180c1bc0de9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan851@gmail.com", "Tuan", "hashed_password_1851", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("07ab4365-4734-4096-a79c-4ce4ea14039b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan263@gmail.com", "Tuan", "hashed_password_1263", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("07df24b9-e12d-44b3-b862-6491921736f8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan119@gmail.com", "Tuan", "hashed_password_1119", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0832c153-56de-49ef-83bb-3d5bf8f2e879"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan399@gmail.com", "Tuan", "hashed_password_1399", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0835e0c7-8f6c-4f6b-94c5-0a3c25f180cb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan341@gmail.com", "Tuan", "hashed_password_1341", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("088502e8-10bc-4be5-abf9-6be62a724dd1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan431@gmail.com", "Tuan", "hashed_password_1431", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("08d80885-2b7f-46d0-9e72-0c9b18f74082"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan914@gmail.com", "Tuan", "hashed_password_1914", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("098fccfe-393d-420e-9f81-afaa7d75f4a7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan650@gmail.com", "Tuan", "hashed_password_1650", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("09d46a91-ba28-459a-a159-42baf397102b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan809@gmail.com", "Tuan", "hashed_password_1809", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0a3adcef-fc42-439c-9903-14912c11ac7f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan670@gmail.com", "Tuan", "hashed_password_1670", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0a4bf449-efe8-4a5c-9f75-60b2a51a1dde"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan135@gmail.com", "Tuan", "hashed_password_1135", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0bafecca-9b0a-4e22-aa54-c54b64d02760"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan222@gmail.com", "Tuan", "hashed_password_1222", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0be8de04-cdae-41c3-82f6-f8086bf98843"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan963@gmail.com", "Tuan", "hashed_password_1963", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0c5cedbc-0973-47d9-b6e6-6cdb746ca77a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan911@gmail.com", "Tuan", "hashed_password_1911", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0ce590a2-0d5f-49a8-8fe8-fdf959bc1f73"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan315@gmail.com", "Tuan", "hashed_password_1315", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0d3d7ee5-45f1-445d-acd1-40330a6d75ef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan283@gmail.com", "Tuan", "hashed_password_1283", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0d71c6c4-16a7-4922-bc08-ebc9f45602b4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan767@gmail.com", "Tuan", "hashed_password_1767", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0d834c69-4cb1-4066-8fa8-c6d3ac9285ba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan185@gmail.com", "Tuan", "hashed_password_1185", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0dbd4518-20b4-4eeb-a5b2-a3c309eb97eb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan908@gmail.com", "Tuan", "hashed_password_1908", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0dcebe96-f412-45b4-a5fc-b6fbbf63b604"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan579@gmail.com", "Tuan", "hashed_password_1579", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0dedaa7b-ccb2-41be-9373-cbee832026f4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan693@gmail.com", "Tuan", "hashed_password_1693", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0e008f47-5a6a-42f2-8bea-fa794917b308"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan587@gmail.com", "Tuan", "hashed_password_1587", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0e1fa222-79b6-408e-a893-fb6591889e3c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan581@gmail.com", "Tuan", "hashed_password_1581", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0ecbff55-6f24-43be-bb0a-c4cd753c938f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan925@gmail.com", "Tuan", "hashed_password_1925", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0f36c09f-52f0-4d92-b461-e60a41117cbd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan663@gmail.com", "Tuan", "hashed_password_1663", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0f72b8c7-a134-46f1-b523-6e4f072001d9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan769@gmail.com", "Tuan", "hashed_password_1769", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0f90fbc6-3966-43cf-a0a5-6e5570e47b9b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan634@gmail.com", "Tuan", "hashed_password_1634", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0fbafa1e-3d5e-4077-889c-ad5e4d6003aa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan699@gmail.com", "Tuan", "hashed_password_1699", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("102ffabd-6e69-4be2-9526-757b9b42efd0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan638@gmail.com", "Tuan", "hashed_password_1638", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("107ba4ce-0fa7-4bab-9cc2-2698b8f1f4f0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan463@gmail.com", "Tuan", "hashed_password_1463", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("10f87abc-e9ea-4775-a459-4e00a9cf1d77"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan624@gmail.com", "Tuan", "hashed_password_1624", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("112c4443-54d7-42c9-b276-6c9ba75788b2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan528@gmail.com", "Tuan", "hashed_password_1528", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("114d3ef7-0f9c-4816-b42c-f05ce4a9f368"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan726@gmail.com", "Tuan", "hashed_password_1726", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("116c4de7-850b-47ce-a5b3-5ac7bc3a4148"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan55@gmail.com", "Tuan", "hashed_password_155", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("117504f5-3be0-4d1f-b681-0f45a117eb5d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan554@gmail.com", "Tuan", "hashed_password_1554", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("11f5e180-7a83-4530-a835-fb47fe444616"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan150@gmail.com", "Tuan", "hashed_password_1150", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("120b7ccd-cc71-418e-80e4-8e8c08fa6763"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan179@gmail.com", "Tuan", "hashed_password_1179", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("124bf99c-e24e-4a0b-b1c8-9681db4d90df"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan509@gmail.com", "Tuan", "hashed_password_1509", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("124cf00f-2e64-4dfa-afc9-b4ac75fcc748"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan814@gmail.com", "Tuan", "hashed_password_1814", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1280d495-7139-4d46-a3c5-3c194fa52e8d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan282@gmail.com", "Tuan", "hashed_password_1282", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("129aed73-7a20-480b-86d4-da96de0b2144"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan949@gmail.com", "Tuan", "hashed_password_1949", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("12a1257c-e7fa-41ae-b8d7-16653ce0db0e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan219@gmail.com", "Tuan", "hashed_password_1219", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("12a8e47f-f4d8-4a03-bbe6-f4217da51d5d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan364@gmail.com", "Tuan", "hashed_password_1364", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("12ec43bb-aa50-492c-8a5d-5c5a67463b5e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan74@gmail.com", "Tuan", "hashed_password_174", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("13632b41-076f-483e-a8bd-c090ce6a3920"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan68@gmail.com", "Tuan", "hashed_password_168", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1369aa45-ee0a-45f1-9211-ec35a49f50fd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan206@gmail.com", "Tuan", "hashed_password_1206", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("139152b4-9a82-4c93-89cf-242fa6729edd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan35@gmail.com", "Tuan", "hashed_password_135", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("13dc97b9-9e3e-4d2d-89ff-9bba8710bb90"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan232@gmail.com", "Tuan", "hashed_password_1232", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1442b633-744a-406d-8f8d-9acd5a8a118c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan788@gmail.com", "Tuan", "hashed_password_1788", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("146b177e-d605-4546-b29a-4f29a87acc7b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan267@gmail.com", "Tuan", "hashed_password_1267", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("14c23ca8-4bd8-48a8-8af2-6525070b7cae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan335@gmail.com", "Tuan", "hashed_password_1335", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("14df97a1-eff8-4ae0-851e-28dd4f0264de"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan468@gmail.com", "Tuan", "hashed_password_1468", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("15b109d3-ea5e-430a-b7fd-633275f191fa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan844@gmail.com", "Tuan", "hashed_password_1844", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("15b507fb-3090-40a7-af95-24660e4892f7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan869@gmail.com", "Tuan", "hashed_password_1869", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("15bfae38-75a0-488e-9efb-45382376ef36"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan992@gmail.com", "Tuan", "hashed_password_1992", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("171dc373-1912-49dd-9500-6b0aeb16f1c1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan828@gmail.com", "Tuan", "hashed_password_1828", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("176f81db-a939-4059-aa61-fe408343a90d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan313@gmail.com", "Tuan", "hashed_password_1313", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("17d756b6-5b16-4161-b400-fbdecf375677"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan831@gmail.com", "Tuan", "hashed_password_1831", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("18088875-38b5-464f-a7aa-ec4be032948e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan756@gmail.com", "Tuan", "hashed_password_1756", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1829eb81-3da2-467f-b834-d32cef711fd4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan255@gmail.com", "Tuan", "hashed_password_1255", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("183dff50-2c80-4915-b27b-b9eab633e22c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan512@gmail.com", "Tuan", "hashed_password_1512", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("184418f4-7419-413f-9cde-7f2afa6b1329"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan704@gmail.com", "Tuan", "hashed_password_1704", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("188c866c-91fd-40ea-b12a-3b9981ff8240"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan574@gmail.com", "Tuan", "hashed_password_1574", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("18c0eecb-9090-4393-88e6-37650be81720"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan374@gmail.com", "Tuan", "hashed_password_1374", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("18c4d53f-98fe-4860-ae2c-767d232b9aad"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan485@gmail.com", "Tuan", "hashed_password_1485", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("19019f25-1649-414b-b572-45a8fb935f41"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan718@gmail.com", "Tuan", "hashed_password_1718", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1935732c-d63b-4ca4-87ca-62b5c3b8204e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan559@gmail.com", "Tuan", "hashed_password_1559", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("194fad18-9682-4fcf-bf06-d2572f1df955"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan671@gmail.com", "Tuan", "hashed_password_1671", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1966c7ca-8ca8-4df4-aa3b-c101df601b42"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan660@gmail.com", "Tuan", "hashed_password_1660", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("19926021-3c08-49d1-8286-7204288c8344"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan369@gmail.com", "Tuan", "hashed_password_1369", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("19a949d3-8bb6-4ea8-83f1-65813a3b00a5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan196@gmail.com", "Tuan", "hashed_password_1196", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("19c4c3a8-9eb1-40ef-9984-9789f5549ca9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan651@gmail.com", "Tuan", "hashed_password_1651", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1aed3400-d51e-499e-b48f-20ecfd55905d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan63@gmail.com", "Tuan", "hashed_password_163", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1af0a7de-767d-4b0a-b1e7-e256ee29a45f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan896@gmail.com", "Tuan", "hashed_password_1896", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1b17bc99-e23e-44e0-a4e5-ce6974f2aba5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan154@gmail.com", "Tuan", "hashed_password_1154", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1b2a2edf-1743-4df2-885f-c1e3f867d580"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan33@gmail.com", "Tuan", "hashed_password_133", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1b391ca9-0d31-4635-8466-c2d14b71b8e8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan702@gmail.com", "Tuan", "hashed_password_1702", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1b4e1565-149f-470a-9610-88a7c8084cb2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan420@gmail.com", "Tuan", "hashed_password_1420", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1b650fb8-11a9-4a75-b185-3157e09a53c6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan126@gmail.com", "Tuan", "hashed_password_1126", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1baa1e47-09da-4ac4-8fd2-13981282c79d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan173@gmail.com", "Tuan", "hashed_password_1173", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1c473ca7-e28d-4d7d-8117-505e386fa7b4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan688@gmail.com", "Tuan", "hashed_password_1688", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1c520d76-a62e-4bf3-841c-35cec6a068fc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan960@gmail.com", "Tuan", "hashed_password_1960", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1c9ba7d9-8693-4909-ad50-6deba6622955"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan807@gmail.com", "Tuan", "hashed_password_1807", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1ca3f28f-c539-4dba-b69e-c4ca76055710"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan544@gmail.com", "Tuan", "hashed_password_1544", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1cac9970-0dee-4371-8b9a-283d2e207c4e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan270@gmail.com", "Tuan", "hashed_password_1270", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1cd23702-715c-4473-8493-d84e278910dd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan677@gmail.com", "Tuan", "hashed_password_1677", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1cff6873-7308-4047-a370-19ade6955c44"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan762@gmail.com", "Tuan", "hashed_password_1762", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1d3c88cb-1369-47d7-9e37-f2c7d3784c8f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan633@gmail.com", "Tuan", "hashed_password_1633", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1df405ba-a52d-42fe-8c68-2bae27b55a10"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan613@gmail.com", "Tuan", "hashed_password_1613", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1e007032-0419-41ff-8609-0af0aa8dc07c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan237@gmail.com", "Tuan", "hashed_password_1237", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1e26490a-2675-45eb-804e-3a480cce9568"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan56@gmail.com", "Tuan", "hashed_password_156", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1e3af1ab-f25e-4fdd-83c0-e957a5aa8bd5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan776@gmail.com", "Tuan", "hashed_password_1776", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1e4af14a-96b6-4454-a1d2-8e71e830690d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan329@gmail.com", "Tuan", "hashed_password_1329", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1ecef09d-d613-4879-88ea-32e01148e4ab"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan470@gmail.com", "Tuan", "hashed_password_1470", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1f7e7f08-7dd4-46b1-9c54-e445db1a7b52"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan646@gmail.com", "Tuan", "hashed_password_1646", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1f8220b9-d93f-41f7-b4b3-ff18a58f732a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan700@gmail.com", "Tuan", "hashed_password_1700", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1fd4c7e9-a06e-49ef-9e11-68022da0dd84"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan576@gmail.com", "Tuan", "hashed_password_1576", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("201a0438-ac66-42fc-964d-6548fae4916b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan360@gmail.com", "Tuan", "hashed_password_1360", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("207f22b8-63f1-43a7-8eda-0749a03a2f43"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan946@gmail.com", "Tuan", "hashed_password_1946", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("20ab1f41-9b84-42d7-8bb3-183d17fe7423"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan389@gmail.com", "Tuan", "hashed_password_1389", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("20fa63d2-c9c6-457c-8a68-5787eab8ab7b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan5@gmail.com", "Tuan", "hashed_password_15", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("212478f7-b440-412e-83fa-1f52f587341f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan444@gmail.com", "Tuan", "hashed_password_1444", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("217a8586-256a-4ab1-8e21-89feb48ed002"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan50@gmail.com", "Tuan", "hashed_password_150", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("217ba630-2813-4627-8311-946ab526201a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan87@gmail.com", "Tuan", "hashed_password_187", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("219a5997-3f30-4cf7-b698-34ea7c9dd233"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan323@gmail.com", "Tuan", "hashed_password_1323", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("21b9e2c8-d1a7-4787-a5b1-70f2405717e2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan233@gmail.com", "Tuan", "hashed_password_1233", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("21d8861e-0e73-4bdb-a8d5-f67e0cce0d68"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan299@gmail.com", "Tuan", "hashed_password_1299", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("21f49582-70f1-407d-9cb9-f13654c5bea4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan497@gmail.com", "Tuan", "hashed_password_1497", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2259ef78-448b-48b3-8a60-c293abd065b0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan773@gmail.com", "Tuan", "hashed_password_1773", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("227f089c-85eb-49df-a24b-d5bf826218e6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan837@gmail.com", "Tuan", "hashed_password_1837", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2298224b-a704-4da3-9874-454e61856f2a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan379@gmail.com", "Tuan", "hashed_password_1379", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2329975b-b1fd-4f8b-afb8-834980cef79d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan157@gmail.com", "Tuan", "hashed_password_1157", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("233f85d7-4a4a-4787-ad62-8b7b56ea9ce2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan275@gmail.com", "Tuan", "hashed_password_1275", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("237159a8-a3a9-4071-9265-df36bc71174f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan200@gmail.com", "Tuan", "hashed_password_1200", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2385b6fd-a969-4701-a916-eebc3d5e3759"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan882@gmail.com", "Tuan", "hashed_password_1882", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("23f427c9-da13-4fd3-a9c5-50364e058bf7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan585@gmail.com", "Tuan", "hashed_password_1585", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("23f7e592-62a0-4273-aa0d-e5d18561b8e3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan102@gmail.com", "Tuan", "hashed_password_1102", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("248c3e4e-d5f7-47cf-b8f9-d13641e158eb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan778@gmail.com", "Tuan", "hashed_password_1778", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("249e2534-57c5-45fb-b4a6-54b075b21522"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan945@gmail.com", "Tuan", "hashed_password_1945", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("24ef06b0-c7d7-43e9-9abd-a53741fce78f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan874@gmail.com", "Tuan", "hashed_password_1874", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("24f9a5a0-a5ba-4c02-8eae-8da71bc6459f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan876@gmail.com", "Tuan", "hashed_password_1876", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("251c485d-7338-4881-858b-620403f45ad6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan252@gmail.com", "Tuan", "hashed_password_1252", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("256791f4-e088-4546-8548-d5c76f78b29c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan739@gmail.com", "Tuan", "hashed_password_1739", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("25915cc6-1693-4fc5-a665-c7fd3fd13b03"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuanle17062k6@gmail.com", "Tuan", "hashed_password_1", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2594ef2a-64cf-4710-a6c3-0a07b1612d22"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan545@gmail.com", "Tuan", "hashed_password_1545", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("25c95a83-3dd5-4217-ad15-26eaea3f4d89"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan599@gmail.com", "Tuan", "hashed_password_1599", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("261a068f-3a79-4f47-8164-21c5b5b4b28a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan305@gmail.com", "Tuan", "hashed_password_1305", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("26517699-1f17-4061-b757-75a7bfda1751"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan793@gmail.com", "Tuan", "hashed_password_1793", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("268ce2dc-efa7-4328-b457-f3ec344b3dc3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan48@gmail.com", "Tuan", "hashed_password_148", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("26aad548-62b6-43d5-bd4b-a7188f266b8b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan383@gmail.com", "Tuan", "hashed_password_1383", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("26d5b188-0f3c-4782-90c5-fd2d963ba6ae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan371@gmail.com", "Tuan", "hashed_password_1371", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("26dfd908-8dbf-481f-8096-5b93d44ca863"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan34@gmail.com", "Tuan", "hashed_password_134", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2705ff0d-d276-4118-bc25-302c8cb55799"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan494@gmail.com", "Tuan", "hashed_password_1494", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("270f946b-827e-4dd9-a47d-b9da75005592"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan406@gmail.com", "Tuan", "hashed_password_1406", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("272548a3-ca3d-4ba1-b8bd-f969d24f76f3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan432@gmail.com", "Tuan", "hashed_password_1432", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("272cd1f4-2d7e-4a02-9802-a65604e97d7f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan57@gmail.com", "Tuan", "hashed_password_157", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2749ea5d-e8e9-4558-b9df-4a4015e28e08"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan441@gmail.com", "Tuan", "hashed_password_1441", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2878cc43-0a79-4b83-bff6-258c602358c2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan654@gmail.com", "Tuan", "hashed_password_1654", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("289f2e1b-d34b-451e-a722-177cff7373a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan849@gmail.com", "Tuan", "hashed_password_1849", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("28c577cd-4528-4675-8d59-c6450e23850f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan261@gmail.com", "Tuan", "hashed_password_1261", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("28c5f3dc-9165-47f8-88e0-2a777df415c7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan82@gmail.com", "Tuan", "hashed_password_182", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("28e161e7-3047-4efd-9d5b-6b9f7aebe264"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan664@gmail.com", "Tuan", "hashed_password_1664", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("28efef4f-ed56-4d9f-99b1-2a0a056118db"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan310@gmail.com", "Tuan", "hashed_password_1310", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("297ebf47-91a8-4cc7-bc4e-6b133bfc71bf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan473@gmail.com", "Tuan", "hashed_password_1473", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("29c12ae1-b4c4-4355-976b-cb6e81a20f3a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan839@gmail.com", "Tuan", "hashed_password_1839", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2a4bbdfd-12e6-4da3-aefe-2e59eb72c1b3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan915@gmail.com", "Tuan", "hashed_password_1915", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2abe5c04-3b6b-4af3-8133-0ccd36a32d20"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan985@gmail.com", "Tuan", "hashed_password_1985", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2b38f276-2f0b-4f95-9c1e-4523f77d59f5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan166@gmail.com", "Tuan", "hashed_password_1166", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2b84a16c-1ae1-48aa-bb97-f7a188c9e8ec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan719@gmail.com", "Tuan", "hashed_password_1719", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2bbd6704-dcd0-476d-a47d-f1067ebadf76"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan711@gmail.com", "Tuan", "hashed_password_1711", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2be5cbd5-cca1-46b1-9484-3c20d28db1bb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan920@gmail.com", "Tuan", "hashed_password_1920", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2c5cca97-6e5b-4f2f-a5e8-4b185f9bfea5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan49@gmail.com", "Tuan", "hashed_password_149", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2c890f6f-dee9-43ec-899f-042bd16e5c5d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan75@gmail.com", "Tuan", "hashed_password_175", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2ca1bead-6e24-4657-ae62-f56282227807"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan873@gmail.com", "Tuan", "hashed_password_1873", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2cadf817-0b9b-40cb-aaba-8d8a5efe8a73"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan782@gmail.com", "Tuan", "hashed_password_1782", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2cbe2837-49ed-4175-b807-a0fb4eab7a9f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan626@gmail.com", "Tuan", "hashed_password_1626", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2d17316f-dd7d-4c50-b9c0-4f42a5e9395a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan966@gmail.com", "Tuan", "hashed_password_1966", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2d2dbbf3-43c7-46e5-a0e1-385a20ca1322"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan59@gmail.com", "Tuan", "hashed_password_159", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2d509515-4b37-4674-ad9e-9860e5d930e4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan413@gmail.com", "Tuan", "hashed_password_1413", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2d980228-dbea-465a-bdeb-ca6a2db14f8b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan332@gmail.com", "Tuan", "hashed_password_1332", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2da23581-451f-40fe-ae65-521287bfcc49"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan614@gmail.com", "Tuan", "hashed_password_1614", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2dde4cf4-1fb2-4eaf-8b82-7b5de45b6283"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan106@gmail.com", "Tuan", "hashed_password_1106", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2e51760a-d31e-403e-af73-a12c5184a54e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan279@gmail.com", "Tuan", "hashed_password_1279", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2ea092d0-541b-458d-bf28-cb2718b73232"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan817@gmail.com", "Tuan", "hashed_password_1817", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2ea322cc-3447-409e-8e38-1cc6966f5157"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan564@gmail.com", "Tuan", "hashed_password_1564", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2ec8bbf6-c149-47d8-8c6a-d25515520b58"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan789@gmail.com", "Tuan", "hashed_password_1789", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2ef42661-4b2a-43f7-9d6e-81d152a6d648"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan265@gmail.com", "Tuan", "hashed_password_1265", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2f2aa29f-43cd-4457-b981-4bec273aa484"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan304@gmail.com", "Tuan", "hashed_password_1304", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2f4c12b4-9716-46b8-8cf9-4deeac0a0b7a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan919@gmail.com", "Tuan", "hashed_password_1919", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2f9220f8-c384-4b35-9d50-68a116c3bf60"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan366@gmail.com", "Tuan", "hashed_password_1366", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2f938c26-3e31-4e75-912a-e6aa1202e49d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan848@gmail.com", "Tuan", "hashed_password_1848", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2fe3d80a-50d7-4b94-b919-7f927542494c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan24@gmail.com", "Tuan", "hashed_password_124", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3006a5ea-c5d5-429b-9459-56c392ae2dab"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan336@gmail.com", "Tuan", "hashed_password_1336", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3026ade7-9399-4e85-b87d-c533c021b69b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan351@gmail.com", "Tuan", "hashed_password_1351", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("303e8a55-7716-4266-8289-de27f1005610"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan715@gmail.com", "Tuan", "hashed_password_1715", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("30bdbbc7-a5c6-4413-a392-3ea2a3c29928"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan972@gmail.com", "Tuan", "hashed_password_1972", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("30cdae53-43a8-47f5-822f-d53b973ec2aa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan164@gmail.com", "Tuan", "hashed_password_1164", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("30e696a0-f58a-45fa-b288-1effe5ee1f37"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan213@gmail.com", "Tuan", "hashed_password_1213", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("310e6f3f-d954-4ac2-b9fe-e9be58dba7c3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan407@gmail.com", "Tuan", "hashed_password_1407", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("31153374-e7db-423b-acfb-082ddd1f8108"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan259@gmail.com", "Tuan", "hashed_password_1259", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("31a80968-14fa-429a-8c8a-3f402911602a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan522@gmail.com", "Tuan", "hashed_password_1522", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("31c63dcd-5ad8-4d99-9c9a-01b623f34005"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan78@gmail.com", "Tuan", "hashed_password_178", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("31e41a43-fda9-41c8-941b-594caccfcc19"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan453@gmail.com", "Tuan", "hashed_password_1453", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("31f6579a-fede-4b6b-96ea-37ce1abac83e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan986@gmail.com", "Tuan", "hashed_password_1986", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("321ae414-9fa0-4e64-bf50-f1ceb2c7483e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan499@gmail.com", "Tuan", "hashed_password_1499", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3267b076-cd10-4a70-a5b1-5fa25916a26c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan994@gmail.com", "Tuan", "hashed_password_1994", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("32779d19-bd00-4943-8578-659d892467fd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan890@gmail.com", "Tuan", "hashed_password_1890", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("32c7fe38-5126-4047-98e5-01008659ef09"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan488@gmail.com", "Tuan", "hashed_password_1488", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("33171397-b05e-4fd0-80d8-d733df3d8296"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan94@gmail.com", "Tuan", "hashed_password_194", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3398871d-152d-4f6d-9d3f-01091e781e8a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan995@gmail.com", "Tuan", "hashed_password_1995", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("33aa51f4-8530-4470-ab9a-9eb0058fccb3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan234@gmail.com", "Tuan", "hashed_password_1234", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("33e4bfab-07c6-432d-8f55-47f83110ff4c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan368@gmail.com", "Tuan", "hashed_password_1368", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("34199a8d-4819-415c-acc3-435eacf05e8c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan997@gmail.com", "Tuan", "hashed_password_1997", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("34214dec-b06e-46cd-816d-aeae587829f7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan467@gmail.com", "Tuan", "hashed_password_1467", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("344608ba-7559-4585-af27-96080cab5d96"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan887@gmail.com", "Tuan", "hashed_password_1887", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("345eedb2-355f-45b8-a986-6afbee298b34"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan15@gmail.com", "Tuan", "hashed_password_115", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("34efa49f-0fb7-41f7-84e7-d9a35a9974f1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan408@gmail.com", "Tuan", "hashed_password_1408", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("34f1cfa9-e749-4cd9-be63-ddac7bccd785"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan774@gmail.com", "Tuan", "hashed_password_1774", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("34f2515a-9a68-4127-8276-88b48135a418"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan885@gmail.com", "Tuan", "hashed_password_1885", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("34ff5618-ef0b-4f6e-ad3a-0f64771e9b05"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan755@gmail.com", "Tuan", "hashed_password_1755", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("35a21218-ff1a-4a33-a53f-eaf284d5722a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan712@gmail.com", "Tuan", "hashed_password_1712", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("35e88f9d-f19a-497a-a031-c70fd844066a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan904@gmail.com", "Tuan", "hashed_password_1904", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3616e12e-085a-44e6-8443-697a1773c2ee"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan382@gmail.com", "Tuan", "hashed_password_1382", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3617adf2-d124-47e1-802a-dcc0754e918e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan212@gmail.com", "Tuan", "hashed_password_1212", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("36403590-f3c6-4b26-bbaa-4cecc5289a77"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan899@gmail.com", "Tuan", "hashed_password_1899", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3670d9b7-009c-4dad-93ce-ad374478a35c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan339@gmail.com", "Tuan", "hashed_password_1339", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("36782b81-6ac1-4382-9fcc-b678f993b468"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan708@gmail.com", "Tuan", "hashed_password_1708", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3696f8dd-809c-44a6-b10c-c232dc12835d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan29@gmail.com", "Tuan", "hashed_password_129", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("36f25780-c731-494b-bd8e-d001d4dba200"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan511@gmail.com", "Tuan", "hashed_password_1511", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("37275a90-7521-4608-b397-9c6e73fa8b08"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan716@gmail.com", "Tuan", "hashed_password_1716", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3763acf7-12d4-4ae1-b09d-4340a4a09898"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan124@gmail.com", "Tuan", "hashed_password_1124", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("37af0761-451b-47ac-9845-9c1ce778cd21"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan673@gmail.com", "Tuan", "hashed_password_1673", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("38d7bd4e-4ff9-4f17-9432-697d3d401e07"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan931@gmail.com", "Tuan", "hashed_password_1931", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("38df8a62-c3c7-4051-b3d8-fea09276c2af"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan375@gmail.com", "Tuan", "hashed_password_1375", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3927e6c2-0715-4dbc-9c2d-27635f8193c9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan748@gmail.com", "Tuan", "hashed_password_1748", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("39a147aa-bb30-4f1b-ae24-8e19f84958be"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan342@gmail.com", "Tuan", "hashed_password_1342", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("39fc7af3-fca8-455b-b0b5-49439327a823"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan500@gmail.com", "Tuan", "hashed_password_1500", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3a7f36b0-d418-4ce4-bbcb-ea2f1e55383f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan855@gmail.com", "Tuan", "hashed_password_1855", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3a892f75-15ec-440b-ad6f-459e085ecc06"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan596@gmail.com", "Tuan", "hashed_password_1596", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3ab34d5b-d96f-48c1-b378-f078d9fdbde5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan857@gmail.com", "Tuan", "hashed_password_1857", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3b0a2bbb-c3d6-465a-8b97-f634cdda8016"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan962@gmail.com", "Tuan", "hashed_password_1962", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3b1eca25-139c-4fbd-8461-398bb3331163"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan416@gmail.com", "Tuan", "hashed_password_1416", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3b2284bf-7d3c-478c-9859-092fcb26f3d6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan754@gmail.com", "Tuan", "hashed_password_1754", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3b5cda15-2ef9-4f86-9d10-88d180b3a794"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan345@gmail.com", "Tuan", "hashed_password_1345", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3b636552-cef4-4f2d-9f74-2903e8ed21ef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan501@gmail.com", "Tuan", "hashed_password_1501", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3b9205a0-a84f-4c41-bec6-7cfa012e554e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan592@gmail.com", "Tuan", "hashed_password_1592", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3b99433e-8330-4c27-a824-6e4dbae4f0e8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan629@gmail.com", "Tuan", "hashed_password_1629", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3bb9227a-2dd0-485a-961b-4680501a6e72"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan922@gmail.com", "Tuan", "hashed_password_1922", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3bff5d92-ac37-402d-975b-fb853f5ed90f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan250@gmail.com", "Tuan", "hashed_password_1250", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3c2dd90a-d5db-4614-a8ef-c88e87ac10d4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan991@gmail.com", "Tuan", "hashed_password_1991", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3c5235d0-957f-4b69-b685-298f6aeca90f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan320@gmail.com", "Tuan", "hashed_password_1320", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3d14e7da-4e63-420c-8833-b16bd55f6cb8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan40@gmail.com", "Tuan", "hashed_password_140", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3d9011a5-cc2a-4baa-901f-2306957507c4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan973@gmail.com", "Tuan", "hashed_password_1973", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3e2b2923-c0d7-42f0-8415-4e26be0d2a53"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan442@gmail.com", "Tuan", "hashed_password_1442", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3e43e173-0328-4290-895c-4a7d9138e6a6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan228@gmail.com", "Tuan", "hashed_password_1228", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3e6e5c93-0afb-43ff-b079-c8d99dbfec3d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan884@gmail.com", "Tuan", "hashed_password_1884", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3e926c96-dcfa-4bcf-acf6-35c02608385c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan883@gmail.com", "Tuan", "hashed_password_1883", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3ed776ef-f4f2-4d01-be38-34eacd766995"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan918@gmail.com", "Tuan", "hashed_password_1918", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3ee5d198-de83-497c-abdf-8c909f00ea5c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan460@gmail.com", "Tuan", "hashed_password_1460", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3ee898f4-1609-419e-a434-f1b9d5370a6a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan155@gmail.com", "Tuan", "hashed_password_1155", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3f13c62f-f228-4b8e-a28b-c15fe5b46b78"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan435@gmail.com", "Tuan", "hashed_password_1435", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3f457203-6f77-4b2e-9491-62dcd7a5d32f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan177@gmail.com", "Tuan", "hashed_password_1177", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3f566049-136e-4451-9f81-1f067ad3d88a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan649@gmail.com", "Tuan", "hashed_password_1649", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3f828030-ae8d-4f9e-8670-3ff962c514fa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan471@gmail.com", "Tuan", "hashed_password_1471", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("405117b8-f1e9-41e7-b935-2627b70bf793"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan274@gmail.com", "Tuan", "hashed_password_1274", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("40762976-a37b-4501-86f1-57e66f85828c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan193@gmail.com", "Tuan", "hashed_password_1193", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("40ab5213-22fb-47a5-83b1-37f3e0889c00"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan109@gmail.com", "Tuan", "hashed_password_1109", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("40f30bef-de6b-4fd6-885c-7857e5ffaeb9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan573@gmail.com", "Tuan", "hashed_password_1573", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("41a0f7d1-4284-45ab-9b6d-c0e8c74225a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan510@gmail.com", "Tuan", "hashed_password_1510", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("41acb8a4-575c-418f-86b4-3577a6fa252e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan311@gmail.com", "Tuan", "hashed_password_1311", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("41f3fd34-4fea-435d-b8a4-624cbeaa37e9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan129@gmail.com", "Tuan", "hashed_password_1129", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("42205b86-4344-4805-89c0-1abfe8c51de5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan284@gmail.com", "Tuan", "hashed_password_1284", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4280a3c1-c5c5-4d41-9d43-2c30f6d9efd4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan175@gmail.com", "Tuan", "hashed_password_1175", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("42a59805-6eb4-4cc8-ae78-cdaff2d3fae4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan996@gmail.com", "Tuan", "hashed_password_1996", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("43194712-06b4-4be6-af68-0e08bc232d8d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan405@gmail.com", "Tuan", "hashed_password_1405", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("432a41bb-4113-4a1a-85df-6faf8bdc3d1d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan156@gmail.com", "Tuan", "hashed_password_1156", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("433501c8-7874-4e7b-a3f0-74102f686fa2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan429@gmail.com", "Tuan", "hashed_password_1429", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4340c0c3-086a-468c-a286-3e1a7f230d08"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan558@gmail.com", "Tuan", "hashed_password_1558", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4482307c-56ea-4420-9e52-a42987dfd416"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan590@gmail.com", "Tuan", "hashed_password_1590", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("44e5c1c4-6423-4b03-8a47-22583685d54e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan358@gmail.com", "Tuan", "hashed_password_1358", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("450232a1-1cf6-4949-b693-7e3e95f2ac1f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan990@gmail.com", "Tuan", "hashed_password_1990", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4555c0b4-77fc-4853-8619-424b16dad0de"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan605@gmail.com", "Tuan", "hashed_password_1605", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("45a5cf8b-6ffa-4542-9ed8-6a616cda4c5e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan772@gmail.com", "Tuan", "hashed_password_1772", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("45b18040-eae9-4676-a312-dae7cbbb580d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan148@gmail.com", "Tuan", "hashed_password_1148", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("45c8e7ac-7a47-4c40-ac5c-8abbc482cfac"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan118@gmail.com", "Tuan", "hashed_password_1118", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("467a183f-2b49-4675-b275-7c686fbf3215"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan565@gmail.com", "Tuan", "hashed_password_1565", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("46a6baae-ad9d-44e4-84e7-351863941560"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan551@gmail.com", "Tuan", "hashed_password_1551", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("46c39e77-122a-442e-94af-c697bb322a1b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan657@gmail.com", "Tuan", "hashed_password_1657", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4755226f-09ca-455b-b180-fb99268029c6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan487@gmail.com", "Tuan", "hashed_password_1487", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("47c3a62a-e3c5-47f6-9e61-437661cf0643"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan314@gmail.com", "Tuan", "hashed_password_1314", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("47d657e6-6496-4e16-a908-72b76408daa0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan476@gmail.com", "Tuan", "hashed_password_1476", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4851bb31-985d-43c2-aad7-587183ffd964"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan281@gmail.com", "Tuan", "hashed_password_1281", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("486105bd-a84d-444d-b7d3-d2dfb250a804"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan957@gmail.com", "Tuan", "hashed_password_1957", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("48f63de8-f520-4c07-96b4-4db57f6b6cea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan668@gmail.com", "Tuan", "hashed_password_1668", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4923d7a0-14dd-4e1f-bb52-70656028fd6f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan211@gmail.com", "Tuan", "hashed_password_1211", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("498d5cfb-6fa0-4859-8e86-00dbd4fda8f1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan956@gmail.com", "Tuan", "hashed_password_1956", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("49987883-3aef-4572-b847-329953600402"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan539@gmail.com", "Tuan", "hashed_password_1539", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("49e01e1a-6d53-4e6d-901b-36de7878bd52"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan868@gmail.com", "Tuan", "hashed_password_1868", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4a57400c-48c0-43de-a68c-72fbd8cae1a5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan841@gmail.com", "Tuan", "hashed_password_1841", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4a84afc3-a089-4f94-b95c-4e45e96c96a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan447@gmail.com", "Tuan", "hashed_password_1447", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4a85650e-0a6c-460f-88ec-db278dcac6e9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan698@gmail.com", "Tuan", "hashed_password_1698", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4a9f19c6-464f-4235-829a-756d213cfdac"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan560@gmail.com", "Tuan", "hashed_password_1560", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4aa9d0e0-d96a-47a5-a93a-b2afb7210179"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan273@gmail.com", "Tuan", "hashed_password_1273", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4ad4c062-2433-416e-ae6a-d650df80e4b5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan423@gmail.com", "Tuan", "hashed_password_1423", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4b22eba2-3e1b-47e2-b15f-94c4dc6c5a75"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan980@gmail.com", "Tuan", "hashed_password_1980", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4b2dfbb0-3df1-42c7-aed9-9ab7becb9799"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan136@gmail.com", "Tuan", "hashed_password_1136", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4b2eb7f2-5fda-44ad-9fbf-9f848f73ebfd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan31@gmail.com", "Tuan", "hashed_password_131", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4b3666b3-8935-4ebc-bd70-9ea2332ce0cd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan477@gmail.com", "Tuan", "hashed_password_1477", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4bc28402-016c-4b77-a624-23f4533b0d6e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan162@gmail.com", "Tuan", "hashed_password_1162", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4bd1f362-9737-4178-a0f2-3576315fa884"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan958@gmail.com", "Tuan", "hashed_password_1958", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4c697c7e-c1b3-42b6-935c-c4dfe306891b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan478@gmail.com", "Tuan", "hashed_password_1478", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4c6d4f66-49e3-47f2-9605-6e83bfefd519"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan11@gmail.com", "Tuan", "hashed_password_111", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4c7e32bb-62bd-41a9-8fae-e307d263b386"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan761@gmail.com", "Tuan", "hashed_password_1761", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4c9b06a5-f9c5-4d41-8f4d-8a70fa7cc7c0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan461@gmail.com", "Tuan", "hashed_password_1461", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4cb790f5-8d1e-44c9-b26c-b841b7fea4f3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan262@gmail.com", "Tuan", "hashed_password_1262", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4cd8b8c5-89af-4496-9d96-2b9f58dd0547"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan619@gmail.com", "Tuan", "hashed_password_1619", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4d26ed86-6b15-4901-9101-ce88ac0e8626"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan142@gmail.com", "Tuan", "hashed_password_1142", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4d33c2d9-2790-4e5b-ba76-589b4c750c77"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan594@gmail.com", "Tuan", "hashed_password_1594", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4d641585-fd43-4b09-b0c9-6a3fdc5fd743"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan943@gmail.com", "Tuan", "hashed_password_1943", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4d734a4b-969e-4572-9208-232beaddf070"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan62@gmail.com", "Tuan", "hashed_password_162", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4dd5e362-e7ae-4266-87a8-d5c32d388039"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan54@gmail.com", "Tuan", "hashed_password_154", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4e17a482-6bfa-42a1-a353-662923ad112b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan683@gmail.com", "Tuan", "hashed_password_1683", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4e1a7978-ecc9-4e68-839b-36943e066887"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan659@gmail.com", "Tuan", "hashed_password_1659", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4e6e983b-370a-4fe5-a26d-86a62728a579"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan249@gmail.com", "Tuan", "hashed_password_1249", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4ed13bd1-4c04-4380-8ebb-53da1a1e848f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan199@gmail.com", "Tuan", "hashed_password_1199", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4f10aeee-21eb-41e6-8c27-1cf6cfa1e81b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan289@gmail.com", "Tuan", "hashed_password_1289", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4f8be2bd-52e0-42df-94d9-2a1e9ae3cd83"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan557@gmail.com", "Tuan", "hashed_password_1557", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4fbb3077-dd54-44a7-8c9d-2531497db2ec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan377@gmail.com", "Tuan", "hashed_password_1377", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4fe5f7df-60aa-43ce-ae77-860f3b197f54"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan412@gmail.com", "Tuan", "hashed_password_1412", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("501ae11d-32a0-4cec-bd3b-571fbbfa1593"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan752@gmail.com", "Tuan", "hashed_password_1752", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("502a493d-6196-4ef4-89a6-8d794fc8f2e8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan538@gmail.com", "Tuan", "hashed_password_1538", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("505fbae9-7def-43e9-b6cb-8ad93c64cad5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan190@gmail.com", "Tuan", "hashed_password_1190", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("50850cb2-c22a-4227-bf38-a9508213a127"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan44@gmail.com", "Tuan", "hashed_password_144", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("50e15808-b0b9-4dd8-967a-7c0e45f5caa9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan968@gmail.com", "Tuan", "hashed_password_1968", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("51234dbd-8018-42df-a571-51722b57978d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan400@gmail.com", "Tuan", "hashed_password_1400", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("517aaaf1-0ddc-47ff-bfeb-80a58f00a282"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan791@gmail.com", "Tuan", "hashed_password_1791", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("519437cb-ad9c-4660-8424-7bfae5de0b28"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan411@gmail.com", "Tuan", "hashed_password_1411", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("51a78cd5-4e38-420b-8dcb-265995a67ddc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan921@gmail.com", "Tuan", "hashed_password_1921", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("51d42ca0-be38-447c-ac12-f2bc01ffde12"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan354@gmail.com", "Tuan", "hashed_password_1354", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5206fe0b-4ffd-4559-a19c-d21855706254"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan46@gmail.com", "Tuan", "hashed_password_146", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("52143010-da91-4a93-8623-9ec29de435d5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan443@gmail.com", "Tuan", "hashed_password_1443", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("52bbbc09-7641-4eca-b283-945d328f1bce"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan258@gmail.com", "Tuan", "hashed_password_1258", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("533da057-8aeb-43a6-8b55-db15d4f6c4a6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan115@gmail.com", "Tuan", "hashed_password_1115", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("53dfc636-c1cf-4170-a276-7e58ab48c8b8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan815@gmail.com", "Tuan", "hashed_password_1815", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("54685fa8-666c-43c9-ae5c-096602401666"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan390@gmail.com", "Tuan", "hashed_password_1390", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("54fabec2-1fcf-4067-ae77-7b60acccfc97"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan802@gmail.com", "Tuan", "hashed_password_1802", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("551d3c2f-c0fb-4daf-9160-bfb20c3ec979"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan343@gmail.com", "Tuan", "hashed_password_1343", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("55396d14-8367-45e8-858e-2539054272e1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan902@gmail.com", "Tuan", "hashed_password_1902", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("553c67cf-521f-43ad-a34b-3f437f298906"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan907@gmail.com", "Tuan", "hashed_password_1907", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("556bc190-bbff-4bef-aa3b-40a32c7611b9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan912@gmail.com", "Tuan", "hashed_password_1912", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("56ae5f3e-9b65-467a-a587-c9ea67317cec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan829@gmail.com", "Tuan", "hashed_password_1829", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("56cf2000-f39c-49fe-acd0-e90856872127"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan327@gmail.com", "Tuan", "hashed_password_1327", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("56f0cc43-f17e-4ddf-a70d-cea63c5fa46b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan20@gmail.com", "Tuan", "hashed_password_120", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("57480253-73e3-4487-9c67-8917963e4120"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan475@gmail.com", "Tuan", "hashed_password_1475", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("57a8d55c-f482-4c3a-8720-46228817e5c7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan597@gmail.com", "Tuan", "hashed_password_1597", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("581e21bc-37d5-4b0d-8cd3-5dff3383e02a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan706@gmail.com", "Tuan", "hashed_password_1706", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("583a77fc-1649-424b-856d-66dd9d84f22c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan89@gmail.com", "Tuan", "hashed_password_189", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5858fe85-6223-49a8-bb6c-bb6255befc2d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan144@gmail.com", "Tuan", "hashed_password_1144", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5897080d-cd92-446c-a527-638173986487"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan906@gmail.com", "Tuan", "hashed_password_1906", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("59c7e0d2-0fbd-4735-966b-c9b7af7e167c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan445@gmail.com", "Tuan", "hashed_password_1445", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5a440bd4-5124-4b50-ba57-137b689c499a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan285@gmail.com", "Tuan", "hashed_password_1285", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5a7b2848-ed85-4139-bd71-ce680ad5b7af"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan582@gmail.com", "Tuan", "hashed_password_1582", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5a90bc00-50cc-44ac-86d2-18ca08a3cf25"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan803@gmail.com", "Tuan", "hashed_password_1803", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5aa9731f-76cc-422d-ba4e-7dc338af1d18"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan321@gmail.com", "Tuan", "hashed_password_1321", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5aaf3f78-c9ef-4d74-b790-46158ff88e27"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan905@gmail.com", "Tuan", "hashed_password_1905", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5aeae7df-abf0-4da0-823f-89cb7b37c4aa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan903@gmail.com", "Tuan", "hashed_password_1903", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5b0f6e59-1ab8-41bb-bbe2-6f2d2aa6a975"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan863@gmail.com", "Tuan", "hashed_password_1863", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5b1893f3-d41b-4cde-94a2-9d00bf5f88cd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan516@gmail.com", "Tuan", "hashed_password_1516", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5b8519aa-7209-4238-b098-f08dc026a122"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan753@gmail.com", "Tuan", "hashed_password_1753", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5ba7f9df-3e4d-41d9-91d0-18d4d7c7a497"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan334@gmail.com", "Tuan", "hashed_password_1334", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5bad744e-4044-4af1-825c-3f69f2532b16"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan623@gmail.com", "Tuan", "hashed_password_1623", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5bfc30e2-48fa-4ac4-a6e4-714232e18d32"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan519@gmail.com", "Tuan", "hashed_password_1519", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5c001ba7-cced-40a2-b381-bcf1968a78e9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan18@gmail.com", "Tuan", "hashed_password_118", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5c0d5ea4-ed5d-429e-90b4-9e3f40656eb2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan648@gmail.com", "Tuan", "hashed_password_1648", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5ce1beaa-330d-4af9-b8ac-a571d84ae2e8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan134@gmail.com", "Tuan", "hashed_password_1134", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5cfb43b9-f8a3-4f27-b420-ad4df45bade9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan694@gmail.com", "Tuan", "hashed_password_1694", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5d6a01cf-5046-49a8-8ee0-79fa68302031"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan607@gmail.com", "Tuan", "hashed_password_1607", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5d70cb87-78c7-4490-8886-6e876b545308"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan472@gmail.com", "Tuan", "hashed_password_1472", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5d8e2661-b830-4975-bff3-518316cd66bd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan189@gmail.com", "Tuan", "hashed_password_1189", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5dd47259-472b-4abf-a129-485d6741f2e0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan845@gmail.com", "Tuan", "hashed_password_1845", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5defc6d5-14d9-4155-b792-5d2b439ee333"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan872@gmail.com", "Tuan", "hashed_password_1872", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5e967cac-236d-4716-8340-13c34a008fac"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan666@gmail.com", "Tuan", "hashed_password_1666", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5ea61eb5-283b-4a22-9342-25b72705d444"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan730@gmail.com", "Tuan", "hashed_password_1730", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5ed648a1-5f3a-437c-8fa2-a83cf3791bc9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan637@gmail.com", "Tuan", "hashed_password_1637", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5f300404-1059-4c95-bd9d-e18632eb47b1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan45@gmail.com", "Tuan", "hashed_password_145", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5f5805a6-0855-49a8-928a-b21734348057"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan195@gmail.com", "Tuan", "hashed_password_1195", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5f5f95da-9812-4c0f-9296-e5c862bd4ca5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan303@gmail.com", "Tuan", "hashed_password_1303", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5feb4f64-fe64-4370-a9d4-1bce2ac7d628"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan218@gmail.com", "Tuan", "hashed_password_1218", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5ffb3029-b929-4294-a2ec-e5b5ae939cc0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan695@gmail.com", "Tuan", "hashed_password_1695", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6017e759-ab7b-4301-9da6-2ceac4b91087"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan112@gmail.com", "Tuan", "hashed_password_1112", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("60917991-1ad3-4246-839a-7e02974cc744"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan391@gmail.com", "Tuan", "hashed_password_1391", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("61652dec-0aa1-4f42-a7a8-34622fb62c2e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan675@gmail.com", "Tuan", "hashed_password_1675", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("61916ad7-4e72-426c-a1b3-3e2539539081"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan417@gmail.com", "Tuan", "hashed_password_1417", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("61f201a2-4dc4-4371-9963-c37d59d04e55"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan819@gmail.com", "Tuan", "hashed_password_1819", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("62394659-d186-428a-b09c-dd51d76f15ec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan977@gmail.com", "Tuan", "hashed_password_1977", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("623ff6b3-f424-46c2-9df1-220934af8b05"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan745@gmail.com", "Tuan", "hashed_password_1745", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("62503455-76c8-4b8d-ac90-fa60d0620b01"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan149@gmail.com", "Tuan", "hashed_password_1149", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("625fc6fe-7941-4fb0-803a-fe99809b5a13"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan975@gmail.com", "Tuan", "hashed_password_1975", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("629c902e-1b81-412f-b302-ace999223e66"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan251@gmail.com", "Tuan", "hashed_password_1251", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("62cfc471-ac01-466f-b252-a088eec0f265"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan278@gmail.com", "Tuan", "hashed_password_1278", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("62f023dc-a4e9-4332-bb5a-2be3b4f86a9f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan479@gmail.com", "Tuan", "hashed_password_1479", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("62fce807-4bc5-4f6e-aafd-5215c4ed6c88"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan113@gmail.com", "Tuan", "hashed_password_1113", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("63399667-5a02-4ab0-9573-2557ead0d64d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan892@gmail.com", "Tuan", "hashed_password_1892", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("63582fc0-868f-4306-9d1c-0007b9a8208c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan138@gmail.com", "Tuan", "hashed_password_1138", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("639aca41-a8d8-44f1-9f30-11b528ad6c19"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan508@gmail.com", "Tuan", "hashed_password_1508", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("63f10d76-43fd-4482-81d4-8319d655eb01"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan338@gmail.com", "Tuan", "hashed_password_1338", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("646ab336-31f6-4f83-bc2e-c57fcb90fd36"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan244@gmail.com", "Tuan", "hashed_password_1244", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("64a7ba47-9b40-44c5-a740-8f835cc455bc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan971@gmail.com", "Tuan", "hashed_password_1971", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("64fb6b4b-9ffc-49f7-9517-0f90d9b9d6f6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan950@gmail.com", "Tuan", "hashed_password_1950", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("65466459-593a-4a02-b9bb-219061944186"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan98@gmail.com", "Tuan", "hashed_password_198", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("656187c6-8ed4-4650-9045-cf7271758397"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan981@gmail.com", "Tuan", "hashed_password_1981", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("65bebffd-b1bf-456b-8be0-7863aa1124e4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan325@gmail.com", "Tuan", "hashed_password_1325", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("65f779ed-85a9-4e34-9cf3-39e9a36f8d1d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan608@gmail.com", "Tuan", "hashed_password_1608", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6625b936-5619-45be-9952-5609d7db15f9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan900@gmail.com", "Tuan", "hashed_password_1900", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("664f01fa-8bff-4778-8ac3-fa00881d571b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan362@gmail.com", "Tuan", "hashed_password_1362", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("66f724f2-db1e-41d2-bb24-8ef60fe69164"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan235@gmail.com", "Tuan", "hashed_password_1235", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6717e73b-de86-4cb4-8266-b753bdf64ff7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan728@gmail.com", "Tuan", "hashed_password_1728", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("67755393-0ed6-42b4-88ce-c97693e153a9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan584@gmail.com", "Tuan", "hashed_password_1584", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("677a6f6e-5f7a-441e-89e2-b2226234b80b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan928@gmail.com", "Tuan", "hashed_password_1928", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("67d762b3-8e17-43b8-acd3-d4bc42a21943"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan988@gmail.com", "Tuan", "hashed_password_1988", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("681943aa-4e97-4458-8ecc-a23a13b381b8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan813@gmail.com", "Tuan", "hashed_password_1813", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6860634b-add2-4d17-864e-840acd4fd52c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan229@gmail.com", "Tuan", "hashed_password_1229", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("688b6bef-0a85-4790-9e85-f69d8bb589de"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan13@gmail.com", "Tuan", "hashed_password_113", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("68c167f4-5ad5-4003-88bf-baa4a5dd1492"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan643@gmail.com", "Tuan", "hashed_password_1643", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("69459e59-c4d5-4c1a-bfcc-3268893025d0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan61@gmail.com", "Tuan", "hashed_password_161", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6a0297d9-7fd2-423b-b657-9d3676eeae65"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan534@gmail.com", "Tuan", "hashed_password_1534", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6a293db9-4e9d-4913-9b7d-2795c124ff35"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan860@gmail.com", "Tuan", "hashed_password_1860", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6a2ef470-60e2-4f43-a2ad-fd01da61aa21"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan22@gmail.com", "Tuan", "hashed_password_122", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6a60817a-d59f-4bd1-aa3a-967d629f1322"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan248@gmail.com", "Tuan", "hashed_password_1248", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6a9fe7f3-85fe-4d6d-b1f5-78093f7e25c7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan256@gmail.com", "Tuan", "hashed_password_1256", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6ab46129-c49d-49aa-b462-13b1a333b37e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan577@gmail.com", "Tuan", "hashed_password_1577", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6afed492-6be7-41d5-bc52-7c216856283d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan243@gmail.com", "Tuan", "hashed_password_1243", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6b612c78-aa69-4edc-86c0-6919bcaa3660"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan758@gmail.com", "Tuan", "hashed_password_1758", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6bb6a3bf-e268-4cf6-b742-14d9a628c28f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan122@gmail.com", "Tuan", "hashed_password_1122", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6be37639-4692-4981-8d87-a7f3ff05a019"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan674@gmail.com", "Tuan", "hashed_password_1674", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6c0ea081-84b4-45a8-937e-3cc94cb8fcc6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan527@gmail.com", "Tuan", "hashed_password_1527", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6c37128e-c82f-447c-a089-f75c911f4103"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan853@gmail.com", "Tuan", "hashed_password_1853", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6c757c04-9083-4220-beea-b7cd437d3796"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan799@gmail.com", "Tuan", "hashed_password_1799", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6ca47f3f-05f9-4e22-9544-8608bb5e32eb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan356@gmail.com", "Tuan", "hashed_password_1356", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6ca62912-b098-4188-a162-7b780a128b08"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan630@gmail.com", "Tuan", "hashed_password_1630", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6cb669ff-2759-43f9-8407-90a1a9153e2c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan927@gmail.com", "Tuan", "hashed_password_1927", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6d3a4f9e-18df-4e1b-a528-7041fd4d171e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan446@gmail.com", "Tuan", "hashed_password_1446", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6d6de9c5-f3d6-4c23-bc71-7eb1ddb283a0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan600@gmail.com", "Tuan", "hashed_password_1600", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6d9ee6ac-3311-41ba-882b-8861e283d477"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan961@gmail.com", "Tuan", "hashed_password_1961", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6e2a3029-bac1-42e4-a022-6aaf3fe798a1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan738@gmail.com", "Tuan", "hashed_password_1738", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6e573545-0010-4ab5-8275-780a8835bedd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan290@gmail.com", "Tuan", "hashed_password_1290", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6e836c38-64b8-4502-ba4f-6c53f78f7800"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan462@gmail.com", "Tuan", "hashed_password_1462", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6e8f474b-0a22-494e-bf96-c0b91ec14671"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan734@gmail.com", "Tuan", "hashed_password_1734", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6ea38b83-1fb1-47b2-9cf5-1b283518b713"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan9@gmail.com", "Tuan", "hashed_password_19", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6eb7fa61-a9e9-4ce0-be4c-0d81115f125f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan979@gmail.com", "Tuan", "hashed_password_1979", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6edc5bf7-290b-44e8-8323-bc748043d775"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan43@gmail.com", "Tuan", "hashed_password_143", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6f4b52d6-fe96-4350-aa28-483a6b6a1cc4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan457@gmail.com", "Tuan", "hashed_password_1457", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6f4fc7e6-4131-4092-b82b-8237ebfa817f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan595@gmail.com", "Tuan", "hashed_password_1595", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6fa1d370-0d6d-4752-a696-22d215bf11c1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan570@gmail.com", "Tuan", "hashed_password_1570", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6ff50aff-5029-4fde-8fb5-6fd373500948"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan610@gmail.com", "Tuan", "hashed_password_1610", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6ffdf97c-ba3a-4901-bfc8-fa0698e8fe0d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan440@gmail.com", "Tuan", "hashed_password_1440", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("70190a80-4edb-482c-a569-b3b47fd909c6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan430@gmail.com", "Tuan", "hashed_password_1430", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("701b6bf3-a33b-496d-9eb4-0fd0ecfdf297"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan318@gmail.com", "Tuan", "hashed_password_1318", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("70b9cb06-dd7e-4923-826f-527c145b7de1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan525@gmail.com", "Tuan", "hashed_password_1525", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("70bac3a6-08d3-499a-ab47-3c41c2f00de0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan967@gmail.com", "Tuan", "hashed_password_1967", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("70bfebae-e888-44f2-9a3e-22a975918075"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan398@gmail.com", "Tuan", "hashed_password_1398", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("70ddeaf2-d365-4742-a401-218e94ac8d1d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan532@gmail.com", "Tuan", "hashed_password_1532", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("711dbab0-07b2-4085-901c-cf44ac7a7ce9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan238@gmail.com", "Tuan", "hashed_password_1238", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7147e926-cb22-46a9-bb5d-a9be2c4ea102"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan132@gmail.com", "Tuan", "hashed_password_1132", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("720874cf-feb4-4e58-a2ac-d8eb56141c6f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan359@gmail.com", "Tuan", "hashed_password_1359", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("723f7ee9-dd39-486b-85b0-8e0b15f35223"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan330@gmail.com", "Tuan", "hashed_password_1330", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("72482586-0d6e-4ee4-b268-368cb73dfa37"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan951@gmail.com", "Tuan", "hashed_password_1951", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7288e78d-fc21-4329-921e-36d0138cfa49"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan622@gmail.com", "Tuan", "hashed_password_1622", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("728b9bb4-f2b7-427e-9106-453b1ae45a29"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan183@gmail.com", "Tuan", "hashed_password_1183", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("72b51fdc-422c-4ce1-a4d6-d605783c2f58"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan591@gmail.com", "Tuan", "hashed_password_1591", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("72cc196d-59ce-4f6e-9c14-0870d76a5c41"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan775@gmail.com", "Tuan", "hashed_password_1775", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("736a3c71-bce1-425b-8a24-ef3a31ef54f7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan114@gmail.com", "Tuan", "hashed_password_1114", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7377e43a-8b83-411e-b077-d6cec1ceea61"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan810@gmail.com", "Tuan", "hashed_password_1810", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("739544df-045c-427f-a3cc-9559610eccd3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan842@gmail.com", "Tuan", "hashed_password_1842", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("741d112e-0bc9-4cba-a836-6f570988daa0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan6@gmail.com", "Tuan", "hashed_password_16", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("74629e44-0105-4109-ac0d-2d4ada5985d0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan846@gmail.com", "Tuan", "hashed_password_1846", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7467c5e3-0b25-438c-a83b-b98a3c278b05"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan12@gmail.com", "Tuan", "hashed_password_112", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7480a4a2-fe17-4d9f-89c8-0976ff87602b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan806@gmail.com", "Tuan", "hashed_password_1806", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("75b064e5-a6b0-40ba-aa4e-90e2a99ff716"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan923@gmail.com", "Tuan", "hashed_password_1923", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("75c29989-cdba-43b3-b6a5-c63e33e2923a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan437@gmail.com", "Tuan", "hashed_password_1437", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("75fde20d-735f-4b13-9f9b-2c11feec8c73"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan386@gmail.com", "Tuan", "hashed_password_1386", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7645dda4-4acc-43f7-84c2-b9052162e820"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan202@gmail.com", "Tuan", "hashed_password_1202", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("76f4c25b-5c5e-4ebc-9ef2-bff8ab9231b7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan27@gmail.com", "Tuan", "hashed_password_127", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("77593a24-f093-4a47-92db-40fbaa0d270f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan452@gmail.com", "Tuan", "hashed_password_1452", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("77c8d2f2-2279-43a0-9525-56c0505b143c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan257@gmail.com", "Tuan", "hashed_password_1257", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7815ebf3-92cc-4ac0-b946-a9cbac29f5d2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan763@gmail.com", "Tuan", "hashed_password_1763", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("78f8de76-1157-41cf-bfc3-45921da65f28"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan465@gmail.com", "Tuan", "hashed_password_1465", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("792d376e-f482-43e9-ad18-130e482cdc54"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan909@gmail.com", "Tuan", "hashed_password_1909", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("79c05f98-7fe0-412d-9846-cb97f33da800"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan606@gmail.com", "Tuan", "hashed_password_1606", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7af3414e-f68d-4382-b076-af94c905ca62"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan987@gmail.com", "Tuan", "hashed_password_1987", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7b79bdd4-3932-4a7c-83c6-be05295e3638"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan481@gmail.com", "Tuan", "hashed_password_1481", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7bae3a73-53f5-484c-bf19-1cd901ff2655"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan352@gmail.com", "Tuan", "hashed_password_1352", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7bbba1a0-d38f-4872-bb2d-9cf7beec4bcf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan47@gmail.com", "Tuan", "hashed_password_147", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7bbee3cd-b307-4dfb-91bf-2e6e94e53677"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan865@gmail.com", "Tuan", "hashed_password_1865", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7c554dfe-beef-4804-9514-4cfe411b1771"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan495@gmail.com", "Tuan", "hashed_password_1495", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7c57d68b-0ee7-4cfb-9536-21484d94ac44"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan780@gmail.com", "Tuan", "hashed_password_1780", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7c71d736-1a71-4dc7-b909-61c13489fe82"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan486@gmail.com", "Tuan", "hashed_password_1486", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7ce2df2b-e938-4ea0-8bfd-c6b3f1bda278"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan355@gmail.com", "Tuan", "hashed_password_1355", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7cf4f3cf-8914-454a-9c27-59d93bc91764"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan880@gmail.com", "Tuan", "hashed_password_1880", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7cf6f263-77b4-4462-9add-34e3f398122e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan757@gmail.com", "Tuan", "hashed_password_1757", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7d6936dd-d36a-4596-b461-cf75423dbe00"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan847@gmail.com", "Tuan", "hashed_password_1847", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7dbed169-1952-4e5f-be21-9fe681d62481"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan680@gmail.com", "Tuan", "hashed_password_1680", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7dcc7cd9-dd07-4f92-b2a7-583beeee5ecc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan978@gmail.com", "Tuan", "hashed_password_1978", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7e80a1d2-30d7-42f6-aa00-83e4812e8c60"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan394@gmail.com", "Tuan", "hashed_password_1394", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7e908f6d-fc47-49b4-86de-9fc6ffa984d5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan117@gmail.com", "Tuan", "hashed_password_1117", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7f1b8a1b-4fb3-4ded-aa4f-080fd3f402ba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan710@gmail.com", "Tuan", "hashed_password_1710", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7f2288a4-fb28-45cb-9c98-d242a88cc9b6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan300@gmail.com", "Tuan", "hashed_password_1300", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7fe1e71b-b144-42f5-8093-60abb0ee7651"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan269@gmail.com", "Tuan", "hashed_password_1269", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7fe7f8a4-8a13-4a23-9aa7-e8d6fd3e05a9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan100@gmail.com", "Tuan", "hashed_password_1100", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("802f8768-7fd8-4aad-b5fb-789d6e6169d4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan42@gmail.com", "Tuan", "hashed_password_142", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8082c47a-6d5d-459c-b443-1b62664aff53"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan916@gmail.com", "Tuan", "hashed_password_1916", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("808e6fd5-5f49-4290-8c11-db277378c2ce"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan938@gmail.com", "Tuan", "hashed_password_1938", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("80fd0b44-7c93-4cae-96a8-b25ab14da976"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan759@gmail.com", "Tuan", "hashed_password_1759", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("81502e14-8463-497e-a935-ddf854d2d8b8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan424@gmail.com", "Tuan", "hashed_password_1424", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("818d0750-757b-431a-9382-66703680bfca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan689@gmail.com", "Tuan", "hashed_password_1689", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("81900fe4-a6e1-4238-873c-1eb3ac0e2e89"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan798@gmail.com", "Tuan", "hashed_password_1798", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8218008d-4aba-493b-88f5-e9b5e38bbbd2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan572@gmail.com", "Tuan", "hashed_password_1572", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("823c1dfe-afe9-4dde-be28-811c9d9e86a9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan116@gmail.com", "Tuan", "hashed_password_1116", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("824efe8d-8e68-4f76-b9f9-2850156c3a63"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan504@gmail.com", "Tuan", "hashed_password_1504", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8272d831-f939-4f98-a53f-75a6c0ae4061"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan7@gmail.com", "Tuan", "hashed_password_17", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("829bc44d-2141-4503-9cf7-2a4a0109811a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan65@gmail.com", "Tuan", "hashed_password_165", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("82effdfc-29e1-477f-af32-3e3a7526f613"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan737@gmail.com", "Tuan", "hashed_password_1737", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("83453c4f-46cf-464b-a931-27e2be753fdd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan253@gmail.com", "Tuan", "hashed_password_1253", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("834f664d-43b0-44f3-8324-b2946091c875"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan422@gmail.com", "Tuan", "hashed_password_1422", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("843f2fbe-3abe-444a-a35a-44e8edc5ecaa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan766@gmail.com", "Tuan", "hashed_password_1766", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("845c0a46-d6c7-4644-bf1a-8346f16e5e90"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan294@gmail.com", "Tuan", "hashed_password_1294", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("84845907-d0dd-4a62-a9a9-c816fc811006"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan227@gmail.com", "Tuan", "hashed_password_1227", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("858bd144-7871-4325-aae4-c3e22499251b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan669@gmail.com", "Tuan", "hashed_password_1669", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("85b470c8-8eb0-42f1-929e-bce1cc80530d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan697@gmail.com", "Tuan", "hashed_password_1697", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("865890c9-4f59-4428-8c45-a829d781bf18"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan2@gmail.com", "Tuan", "hashed_password_12", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8661537f-5595-4026-9c53-e7774cc86088"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan184@gmail.com", "Tuan", "hashed_password_1184", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("86e0eb2b-333a-4469-bc60-cac091424f7a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan365@gmail.com", "Tuan", "hashed_password_1365", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("86e19994-9671-44e7-b1ec-9c6486eaedaa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan455@gmail.com", "Tuan", "hashed_password_1455", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("86e35a67-86ff-4e44-a144-c2632f798f8b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan295@gmail.com", "Tuan", "hashed_password_1295", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("870ad78b-3f01-40fa-8ed3-c8d6f7194fdb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan540@gmail.com", "Tuan", "hashed_password_1540", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("877b6cf0-b613-4b62-b9f9-928778117b8f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan287@gmail.com", "Tuan", "hashed_password_1287", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("87d3f9b8-0daf-4232-b00e-eaa5e529a3aa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan19@gmail.com", "Tuan", "hashed_password_119", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("87e53189-cc87-4aff-be95-0392fb2f4ba7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan548@gmail.com", "Tuan", "hashed_password_1548", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("87ea53c0-d6bc-46a8-8bd8-efdc1785a857"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan41@gmail.com", "Tuan", "hashed_password_141", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("882cd351-e85a-4bb9-9554-4ed123c042dc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan21@gmail.com", "Tuan", "hashed_password_121", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("88567553-a677-4976-b434-36d37323e8a0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan349@gmail.com", "Tuan", "hashed_password_1349", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8914df3e-6064-4829-9cac-37f30b4dcbee"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan348@gmail.com", "Tuan", "hashed_password_1348", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("891795f5-259f-490f-9d4c-0f87c7e3e383"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan691@gmail.com", "Tuan", "hashed_password_1691", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("893a2d6e-4b35-4c63-9347-5e1caf6ab160"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan385@gmail.com", "Tuan", "hashed_password_1385", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8949285a-365a-42a1-8c87-874c162f5e78"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan450@gmail.com", "Tuan", "hashed_password_1450", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("894efc74-84d9-401e-a93e-de51f43bdd96"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan895@gmail.com", "Tuan", "hashed_password_1895", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("89576a64-b040-4f3a-b3f9-26a924fabaf7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan276@gmail.com", "Tuan", "hashed_password_1276", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("895c1362-9068-4cec-8bfe-a246d79b6bfb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan506@gmail.com", "Tuan", "hashed_password_1506", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("897d324d-af26-43d2-ba48-74c061825f2e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan609@gmail.com", "Tuan", "hashed_password_1609", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("89dc45c3-79a9-4115-aaa5-900cae7eb423"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan260@gmail.com", "Tuan", "hashed_password_1260", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8a15e11e-73e1-4cba-937e-55f0dd2ee453"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan871@gmail.com", "Tuan", "hashed_password_1871", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8a25e941-2bf7-428e-b6b4-3c53a37ee79f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan537@gmail.com", "Tuan", "hashed_password_1537", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8a54e45b-4f3a-4e4e-8848-375bc0d0473d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan372@gmail.com", "Tuan", "hashed_password_1372", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8a5979ef-df31-4486-90a0-38c4c9061c3c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan174@gmail.com", "Tuan", "hashed_password_1174", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8a7e29ff-b77e-443d-960e-4bf5ceb5b6fc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan36@gmail.com", "Tuan", "hashed_password_136", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8aa63380-10a7-4c17-817e-a897e0a77175"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan685@gmail.com", "Tuan", "hashed_password_1685", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8abdd8cd-7f2e-4458-b08f-e3109dd08f47"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan96@gmail.com", "Tuan", "hashed_password_196", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8ac801c8-ea0d-449f-adb0-6be2110fc93b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan827@gmail.com", "Tuan", "hashed_password_1827", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8ad0bb92-ad5f-4ce8-9cd6-8c62d8b7ade8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan433@gmail.com", "Tuan", "hashed_password_1433", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8b08b79f-422c-4f3f-8452-966a0f6952af"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan380@gmail.com", "Tuan", "hashed_password_1380", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8b3e1833-0097-4605-a67e-989a260be2fd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan92@gmail.com", "Tuan", "hashed_password_192", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8b871525-2d24-4b9b-bbb2-34f66f4c36ff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan505@gmail.com", "Tuan", "hashed_password_1505", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8ba0bb30-fac2-4d46-a618-5f6d67204988"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan555@gmail.com", "Tuan", "hashed_password_1555", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8bb9798c-f06d-4c6a-be63-ec503c802c33"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan201@gmail.com", "Tuan", "hashed_password_1201", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8c9f07dd-534b-4368-94e1-cfbb9f5f6bd1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan526@gmail.com", "Tuan", "hashed_password_1526", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8cc6905c-12f8-4d57-b78a-e1bd3438e44f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan631@gmail.com", "Tuan", "hashed_password_1631", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8d26fda1-37d7-4846-aa34-9dd8772e8e20"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan546@gmail.com", "Tuan", "hashed_password_1546", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8d3e7f6a-97cd-4a85-af5f-915d9d6e2534"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan746@gmail.com", "Tuan", "hashed_password_1746", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8da0a7dd-ea8f-4d43-9134-e70c511ecbfd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan678@gmail.com", "Tuan", "hashed_password_1678", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8de36915-a57f-4f07-aea8-5786079dee85"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan214@gmail.com", "Tuan", "hashed_password_1214", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8e34ade5-31af-4bff-b680-6dca00ab1f72"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan73@gmail.com", "Tuan", "hashed_password_173", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8e472c79-5e52-4cbb-ba62-3e52053055f1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan867@gmail.com", "Tuan", "hashed_password_1867", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8ed3566a-f085-46e9-bbd5-8a327f96f06d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan489@gmail.com", "Tuan", "hashed_password_1489", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8f6d64e7-b364-4f69-b8e6-2a3ea5988c21"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan843@gmail.com", "Tuan", "hashed_password_1843", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8f90ae04-ffb9-4be0-9435-e526e1eee112"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan503@gmail.com", "Tuan", "hashed_password_1503", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8f94da87-da62-4013-b24e-dc0b5b1fea79"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan740@gmail.com", "Tuan", "hashed_password_1740", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8fff73c2-cdf4-4787-86e0-7085995e7116"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan852@gmail.com", "Tuan", "hashed_password_1852", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("900ffcc0-8584-45c0-927e-62caf6ca9fdd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan875@gmail.com", "Tuan", "hashed_password_1875", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9016e3be-b4c4-4a3f-b78a-0dbfe96fd1e8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan976@gmail.com", "Tuan", "hashed_password_1976", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9045a202-2077-422f-916f-6562237df2af"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan180@gmail.com", "Tuan", "hashed_password_1180", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("90aefeea-66a9-437a-9bf7-1566fd4753cd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan783@gmail.com", "Tuan", "hashed_password_1783", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9114ba5c-8388-4544-9d5c-ff6dbfb48e51"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan940@gmail.com", "Tuan", "hashed_password_1940", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9170ad8f-b297-4b9f-8c97-8450614946ba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan66@gmail.com", "Tuan", "hashed_password_166", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("91c422a1-bfec-48aa-b8ad-24b4ee3658a5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan181@gmail.com", "Tuan", "hashed_password_1181", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("91c72b70-1ca7-425a-8de0-fbd3d4787657"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan879@gmail.com", "Tuan", "hashed_password_1879", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("921f8600-db35-4b50-9812-396f3368d67a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan982@gmail.com", "Tuan", "hashed_password_1982", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("92254204-371b-4d44-8b22-2a3be9496580"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan889@gmail.com", "Tuan", "hashed_password_1889", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("922b4f1d-ee89-416c-b0e1-e16b46b957d7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan404@gmail.com", "Tuan", "hashed_password_1404", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("92953faf-6fc5-4f30-91d0-e98a9fced3fa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan836@gmail.com", "Tuan", "hashed_password_1836", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("92d11b84-5929-43ed-88c5-e8a3729e74d9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan792@gmail.com", "Tuan", "hashed_password_1792", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("93172122-8f80-466b-a853-396e8309e26f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan531@gmail.com", "Tuan", "hashed_password_1531", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9357f0e7-0c60-44e1-9639-cd344d9118ef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan0@gmail.com", "Tuan", "hashed_password_10", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("93582320-3c74-4ea3-9602-c01a1a69af73"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan438@gmail.com", "Tuan", "hashed_password_1438", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9365e701-777c-4be2-840c-1302e07c6d1b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan459@gmail.com", "Tuan", "hashed_password_1459", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9404266e-0010-4726-a5f2-38ff290639a8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan543@gmail.com", "Tuan", "hashed_password_1543", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9446996a-3420-4c7e-9c54-1b18204f25ac"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan598@gmail.com", "Tuan", "hashed_password_1598", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("947eddc2-0587-47a0-afd0-efe0ff9a1196"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan133@gmail.com", "Tuan", "hashed_password_1133", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("948f127a-a52f-4104-9712-c863236b6e3a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan628@gmail.com", "Tuan", "hashed_password_1628", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("94d694ed-8ef1-4595-ae2f-66db1802420f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan84@gmail.com", "Tuan", "hashed_password_184", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9537d123-31ba-46ad-b9b9-ac10f84dd03d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan936@gmail.com", "Tuan", "hashed_password_1936", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("95a18610-e41d-4ef3-befe-daa5a5a40242"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan242@gmail.com", "Tuan", "hashed_password_1242", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("95c2fc90-d362-4394-b322-c794befb583e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan725@gmail.com", "Tuan", "hashed_password_1725", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("95e6c9fc-080f-4074-9507-5e9566957510"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan569@gmail.com", "Tuan", "hashed_password_1569", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("95f040a0-a33c-413b-b253-f5c9c2b663c3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan864@gmail.com", "Tuan", "hashed_password_1864", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("95fb6a77-c5c8-423e-a684-bc4e924ae5c0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan152@gmail.com", "Tuan", "hashed_password_1152", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9735c764-2f8d-4d9a-abad-0656a5188760"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan306@gmail.com", "Tuan", "hashed_password_1306", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9790a898-a015-4808-8ae3-9792c0e3e37c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan556@gmail.com", "Tuan", "hashed_password_1556", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("97929a63-a532-496e-b027-28f37be46722"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan787@gmail.com", "Tuan", "hashed_password_1787", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9796ec37-2d15-48bd-a655-3fc3256636e0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan426@gmail.com", "Tuan", "hashed_password_1426", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("979b737a-ef19-44c9-ad73-5733ada4b2f5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan292@gmail.com", "Tuan", "hashed_password_1292", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("97bba113-60e8-4ad7-917d-a88e7f0be9e7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan701@gmail.com", "Tuan", "hashed_password_1701", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("981e3c76-d320-4983-87e4-4979cf1f8ec5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan127@gmail.com", "Tuan", "hashed_password_1127", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("983f3e16-26d6-4b36-896f-b781db8fafb7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan454@gmail.com", "Tuan", "hashed_password_1454", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("984f5f51-3968-4dbc-a49c-153b52044494"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan298@gmail.com", "Tuan", "hashed_password_1298", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("98e11692-e388-4aa4-b18f-1589f0e01d7b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan90@gmail.com", "Tuan", "hashed_password_190", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9987e637-65f8-4650-8041-48011f2a2afb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan108@gmail.com", "Tuan", "hashed_password_1108", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("99a1f8a9-4d97-4cf5-8c2a-b4bc3318d710"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan324@gmail.com", "Tuan", "hashed_password_1324", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9aa26026-0232-4102-8010-1e891fde02d7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan168@gmail.com", "Tuan", "hashed_password_1168", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9ae7bed2-c21b-4a45-b593-97aa5367c255"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan507@gmail.com", "Tuan", "hashed_password_1507", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9b9f9705-e827-47f2-94af-44b04504e04b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan744@gmail.com", "Tuan", "hashed_password_1744", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9c41b425-817a-459d-ad68-a82af9472109"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan143@gmail.com", "Tuan", "hashed_password_1143", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9c5bc101-0931-4823-99b2-76e4b560a6d4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan800@gmail.com", "Tuan", "hashed_password_1800", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9ca6ad9a-388f-483d-ac24-f46613ff7367"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan474@gmail.com", "Tuan", "hashed_password_1474", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9cebf19d-8dce-440c-bf9a-4b147ef5df34"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan393@gmail.com", "Tuan", "hashed_password_1393", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9cfe59da-fc65-4e4a-8cf8-6f67e40eb81a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan337@gmail.com", "Tuan", "hashed_password_1337", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9d1bba44-2f55-489f-8f08-add6ca2a9c99"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan197@gmail.com", "Tuan", "hashed_password_1197", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9d2a15be-46af-4836-be8f-c07496a45a25"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan953@gmail.com", "Tuan", "hashed_password_1953", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9da98e2a-833e-4e6d-b287-dbb6f2978ee9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan151@gmail.com", "Tuan", "hashed_password_1151", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9dae930e-5eec-40df-a30d-8f051ad3df61"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan588@gmail.com", "Tuan", "hashed_password_1588", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9dc4e616-ed2e-4d88-b135-8ae46607af02"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan483@gmail.com", "Tuan", "hashed_password_1483", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9dc53543-68f3-48d6-b8d9-641d4afabb41"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan331@gmail.com", "Tuan", "hashed_password_1331", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9dd51c24-8cc4-453e-9e8b-c5a31836690f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan297@gmail.com", "Tuan", "hashed_password_1297", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9de6f6a7-6e93-4d91-a244-8dacc4945850"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan363@gmail.com", "Tuan", "hashed_password_1363", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9e0f6bca-d6b5-488a-9e8d-6fe91db20126"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan373@gmail.com", "Tuan", "hashed_password_1373", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9e1d31e2-4ab7-4561-b12c-616c6b5fa04f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan272@gmail.com", "Tuan", "hashed_password_1272", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9eaf43c1-c345-42af-82b7-9b7c0bb241e7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan121@gmail.com", "Tuan", "hashed_password_1121", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9f1ff516-2b35-4d1a-a5e9-f22dba22c649"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan944@gmail.com", "Tuan", "hashed_password_1944", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9fb90baa-1ed5-4c59-a3fb-7314a3e98596"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan656@gmail.com", "Tuan", "hashed_password_1656", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9fe4a8b5-3c4a-4782-ba84-8fcce5435855"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan690@gmail.com", "Tuan", "hashed_password_1690", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a0164e1e-44da-4cc1-8a5d-a79e68dd1256"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan91@gmail.com", "Tuan", "hashed_password_191", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a052a009-f9c6-493c-a08e-653dda156cef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan999@gmail.com", "Tuan", "hashed_password_1999", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a0854eac-285a-4dd6-b96d-8ccc859e5686"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan515@gmail.com", "Tuan", "hashed_password_1515", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a0d99f71-4d6e-4d3d-9cb0-db36475adba6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan822@gmail.com", "Tuan", "hashed_password_1822", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a127e4f8-e699-4c67-b36a-912caed453bb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan709@gmail.com", "Tuan", "hashed_password_1709", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a1bfa1cd-e503-46c6-97b7-8adcf5b50542"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan652@gmail.com", "Tuan", "hashed_password_1652", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a24605ca-5548-4834-bd9a-1ea589762a0a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan64@gmail.com", "Tuan", "hashed_password_164", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a27d638c-2e0b-48cf-b7b6-4950dd57d0ae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan188@gmail.com", "Tuan", "hashed_password_1188", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a2aeb5ca-d75a-4a33-98bf-835161b01eac"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan128@gmail.com", "Tuan", "hashed_password_1128", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a2af560c-5426-4e0f-b202-35060c72bf68"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan941@gmail.com", "Tuan", "hashed_password_1941", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a3a776e4-7c8c-4343-ade1-482719578c43"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan514@gmail.com", "Tuan", "hashed_password_1514", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a3b68817-44bb-48a4-8176-4b748ab58326"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan952@gmail.com", "Tuan", "hashed_password_1952", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a598dbb4-4380-4ac9-8373-c18fb199074e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan580@gmail.com", "Tuan", "hashed_password_1580", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a64e9e11-29dc-492d-88a3-a928f2fd58c7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan302@gmail.com", "Tuan", "hashed_password_1302", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a6aa493d-55ba-4895-a6d4-a79dad19cefd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan930@gmail.com", "Tuan", "hashed_password_1930", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a74b4ed0-75c0-4e81-bd37-8f4c5c48694c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan158@gmail.com", "Tuan", "hashed_password_1158", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a76648b7-007e-46d6-a48c-463335cd758d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan524@gmail.com", "Tuan", "hashed_password_1524", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a7eaf24b-72c5-4863-ba74-8911df2c42dc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan347@gmail.com", "Tuan", "hashed_password_1347", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a892939f-5289-432d-93b4-fd39db6beec4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan266@gmail.com", "Tuan", "hashed_password_1266", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a89b3067-54ea-4c33-a9a5-da7a60f900bd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan805@gmail.com", "Tuan", "hashed_password_1805", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a8ebb5a9-aa38-4ee2-99a0-54a98faf5b05"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan676@gmail.com", "Tuan", "hashed_password_1676", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a8f44631-441b-4ed2-9d12-da237562cda7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan833@gmail.com", "Tuan", "hashed_password_1833", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a9192418-a15b-4b6a-aeb9-69bb448cdc3c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan751@gmail.com", "Tuan", "hashed_password_1751", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a9b3b68d-9180-4f72-a041-7750e4414f41"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan410@gmail.com", "Tuan", "hashed_password_1410", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("aa968236-7f24-4cdb-a145-e876da500420"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan286@gmail.com", "Tuan", "hashed_password_1286", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("aaa91f73-212a-450a-b960-c633d29dd923"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan130@gmail.com", "Tuan", "hashed_password_1130", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ab020f81-e806-4c15-8af6-6fb61792b49d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan147@gmail.com", "Tuan", "hashed_password_1147", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ab1d06b9-843b-4c85-9232-39287ae0b4e1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan23@gmail.com", "Tuan", "hashed_password_123", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ab25e064-fe29-4adc-9671-e8f25e42936d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan658@gmail.com", "Tuan", "hashed_password_1658", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ab7a2926-b766-43c7-9903-6d536f024c66"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan616@gmail.com", "Tuan", "hashed_password_1616", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("abe79655-122b-4dbb-9342-a5085eeaefb9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan110@gmail.com", "Tuan", "hashed_password_1110", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("abf55415-769c-4b42-94ad-a7518615990e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan439@gmail.com", "Tuan", "hashed_password_1439", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ac7def8f-55a4-47ff-a3bd-0c57f6272b15"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan705@gmail.com", "Tuan", "hashed_password_1705", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ac7f93ec-e4d0-40af-827a-3a3f6262e9a2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan312@gmail.com", "Tuan", "hashed_password_1312", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("aca8e557-25b8-4610-9342-a3e3dd2467f3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan409@gmail.com", "Tuan", "hashed_password_1409", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("acba2bc7-fb0b-40ca-ac09-13021db0b69a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan824@gmail.com", "Tuan", "hashed_password_1824", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("acc06dfb-00cb-43f9-b930-b59cf94898d7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan70@gmail.com", "Tuan", "hashed_password_170", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("acee2b57-558a-4191-893e-39b586f610e3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan105@gmail.com", "Tuan", "hashed_password_1105", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ad2db7ad-dbd3-4d51-ae44-0016e5db3f69"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan727@gmail.com", "Tuan", "hashed_password_1727", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ad3d7445-e6e2-4638-8241-309b3d9590f3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan161@gmail.com", "Tuan", "hashed_password_1161", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ae525afa-6c86-4d42-8289-a409694002b3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan611@gmail.com", "Tuan", "hashed_password_1611", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ae5ef77a-12c8-4099-8068-afe21bc3c269"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan703@gmail.com", "Tuan", "hashed_password_1703", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ae83279c-7c2d-4414-8377-19048b1c8691"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan203@gmail.com", "Tuan", "hashed_password_1203", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("aeca7553-57b8-4995-96c0-50e4c9b8681d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan765@gmail.com", "Tuan", "hashed_password_1765", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("aee39d7f-b761-4fad-ae9b-228773aac649"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan530@gmail.com", "Tuan", "hashed_password_1530", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("aee3ebc2-eb8d-4e28-8e3a-47934b549e0d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan888@gmail.com", "Tuan", "hashed_password_1888", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("aee59f83-e02e-49a9-88c9-eab5e66aba03"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan621@gmail.com", "Tuan", "hashed_password_1621", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("af77ee29-ca81-4792-9bc7-2ff037c99e47"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan785@gmail.com", "Tuan", "hashed_password_1785", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("afada25d-3c6d-4b59-a63d-63cf323edf79"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan246@gmail.com", "Tuan", "hashed_password_1246", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("afb98318-0208-4e38-84c7-015bf39fa2bd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan425@gmail.com", "Tuan", "hashed_password_1425", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("afc54e5d-767f-4e9b-adac-66c6fff984ae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan747@gmail.com", "Tuan", "hashed_password_1747", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("afde3a69-9665-4f99-a506-b4165fd0c784"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan877@gmail.com", "Tuan", "hashed_password_1877", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("afee4df2-3dee-4587-b055-9524ebd3876c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan466@gmail.com", "Tuan", "hashed_password_1466", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b0163944-dbaf-4ac6-86db-9c5d00450c41"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan720@gmail.com", "Tuan", "hashed_password_1720", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b04ac5f7-7a99-49e2-862e-9e8232bed384"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan862@gmail.com", "Tuan", "hashed_password_1862", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b079ce6d-3a8c-47dd-82ea-7371a577950e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan764@gmail.com", "Tuan", "hashed_password_1764", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b07c4ed0-0dba-46e7-b06d-1a1ac2b29c4d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan672@gmail.com", "Tuan", "hashed_password_1672", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b0ae152b-2897-47be-ad65-6ff7f90857ef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan549@gmail.com", "Tuan", "hashed_password_1549", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b0eb0844-05f4-4c0d-ada8-0c126a5029f8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan37@gmail.com", "Tuan", "hashed_password_137", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b0fe6c45-de32-41a5-af04-4c7bff44b78c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan840@gmail.com", "Tuan", "hashed_password_1840", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b27f8602-fb2d-4ee1-b797-0d06308ecf28"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan801@gmail.com", "Tuan", "hashed_password_1801", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b2e293c6-a276-4797-b3c6-63d798b2f065"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan615@gmail.com", "Tuan", "hashed_password_1615", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b3142530-89bd-4912-ad3d-b0f99c0ab9e2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan53@gmail.com", "Tuan", "hashed_password_153", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b33bb388-21a7-4668-916c-dcbb178aea23"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan561@gmail.com", "Tuan", "hashed_password_1561", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b380cd06-dcbd-44d5-a861-b5af1c0ed3f6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan436@gmail.com", "Tuan", "hashed_password_1436", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b39b32e8-7699-411f-8b78-be89a298cfa5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan969@gmail.com", "Tuan", "hashed_password_1969", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b3c27091-e765-4bd8-b7d8-3c61d834c533"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan140@gmail.com", "Tuan", "hashed_password_1140", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b47585a8-08a8-4eba-91b1-0b96b8507881"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan139@gmail.com", "Tuan", "hashed_password_1139", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b4e3ad89-5342-4d51-89f8-e35b78825197"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan498@gmail.com", "Tuan", "hashed_password_1498", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b58b8450-6e98-4d69-a32e-66288d17320a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan886@gmail.com", "Tuan", "hashed_password_1886", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b59bf289-cb34-415c-acc0-cd58331f28c6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan583@gmail.com", "Tuan", "hashed_password_1583", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b5fd2feb-517a-4827-a799-795bc9d8a2b4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan111@gmail.com", "Tuan", "hashed_password_1111", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b621331d-2e13-4ab8-a252-8d2123a5b1a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan167@gmail.com", "Tuan", "hashed_password_1167", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b6ad0c57-8dd4-4345-b337-27007f0830ff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan397@gmail.com", "Tuan", "hashed_password_1397", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b6adf0bd-bd97-49f6-be43-992351de2240"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan575@gmail.com", "Tuan", "hashed_password_1575", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b6fd56af-5802-4b8c-a85d-86629d70a334"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan309@gmail.com", "Tuan", "hashed_password_1309", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b73ca8b9-71b3-4d55-89b5-f82479fdf52c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan983@gmail.com", "Tuan", "hashed_password_1983", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b75049ec-aafb-4eca-bdd7-4a27a3eb7694"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan418@gmail.com", "Tuan", "hashed_password_1418", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b75ebf98-5ceb-4608-a55d-14feac81e72c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan939@gmail.com", "Tuan", "hashed_password_1939", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b771338a-8b43-4d82-bcfc-3965e00f6bea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan641@gmail.com", "Tuan", "hashed_password_1641", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b776a98d-36f9-45a2-a988-e0f32bce1c22"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan812@gmail.com", "Tuan", "hashed_password_1812", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b7778b02-891d-45d9-af77-7475b35ffc2b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan679@gmail.com", "Tuan", "hashed_password_1679", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b8181062-9584-4a22-bf3b-4ce71d3a6787"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan160@gmail.com", "Tuan", "hashed_password_1160", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b81e445b-0a24-4c36-be04-45598f9d547b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan932@gmail.com", "Tuan", "hashed_password_1932", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b85f3a78-48d1-4697-9d4c-46220c36dbe3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan403@gmail.com", "Tuan", "hashed_password_1403", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b8c664ad-9141-4647-8d9c-a081030d41b6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan194@gmail.com", "Tuan", "hashed_password_1194", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b956acd8-597d-4e83-a2ef-c352d454caaa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan760@gmail.com", "Tuan", "hashed_password_1760", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b95eaffa-d791-46b4-8220-a41399550ff9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan69@gmail.com", "Tuan", "hashed_password_169", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b963cfc8-dd31-4734-860b-0ce2109b3bfc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan240@gmail.com", "Tuan", "hashed_password_1240", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ba26472d-bcd1-47de-86bf-a8809bde8130"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan301@gmail.com", "Tuan", "hashed_password_1301", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ba77cd55-234a-4680-a7bf-909a3676e09a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan612@gmail.com", "Tuan", "hashed_password_1612", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ba926183-b045-4c25-87df-9fa6cce6b4d0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan942@gmail.com", "Tuan", "hashed_password_1942", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ba98f33c-be01-433b-9062-7a1b394ab298"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan578@gmail.com", "Tuan", "hashed_password_1578", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("baffbc5f-475e-4185-8455-05120fe73bd8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan954@gmail.com", "Tuan", "hashed_password_1954", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bb22e34a-5a61-40e5-8fb0-ec4034a81ae3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan80@gmail.com", "Tuan", "hashed_password_180", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bb7fe048-7620-4f67-a770-e1fbcce11daf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan770@gmail.com", "Tuan", "hashed_password_1770", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bbccf667-e4f7-4dd7-a37b-abeabeb77d11"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan221@gmail.com", "Tuan", "hashed_password_1221", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bbdb3db3-bb3b-4cf1-8f15-f9e53c117d02"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan79@gmail.com", "Tuan", "hashed_password_179", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bbea8020-5a78-4a80-84cf-f03d68b25187"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan618@gmail.com", "Tuan", "hashed_password_1618", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bc2c1a3e-1512-462c-9560-44b06dbf7d89"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan207@gmail.com", "Tuan", "hashed_password_1207", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bc58efc8-8025-4b36-9967-eacac1d7e822"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan535@gmail.com", "Tuan", "hashed_password_1535", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bc9012e8-7d6d-46a6-a435-f340b84fc7ca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan898@gmail.com", "Tuan", "hashed_password_1898", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bd60cf75-a7b1-4d38-b8b8-77cab6153dda"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan328@gmail.com", "Tuan", "hashed_password_1328", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bd701825-b30b-4bb0-9bce-095791806fca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan83@gmail.com", "Tuan", "hashed_password_183", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bde32bb5-3d9b-434c-822c-18a616c12f15"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan370@gmail.com", "Tuan", "hashed_password_1370", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("be009857-5bec-4ffc-8a29-1787356dc983"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan291@gmail.com", "Tuan", "hashed_password_1291", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("be8a8bfd-2d6a-4512-98d3-eea370ecc0e6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan176@gmail.com", "Tuan", "hashed_password_1176", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("beeea68b-de00-4a37-bbcd-0e5abe343fed"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan245@gmail.com", "Tuan", "hashed_password_1245", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bf5ac720-9e56-473b-a290-4698e5b7a107"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan635@gmail.com", "Tuan", "hashed_password_1635", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bf7f8a1f-1c42-4fd4-bd20-b0a0e363634a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan350@gmail.com", "Tuan", "hashed_password_1350", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c00f505c-87c9-49cc-989c-f78675c7f4e3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan593@gmail.com", "Tuan", "hashed_password_1593", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c0506dab-2d1b-412a-ab25-7e12ae3f8bc1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan39@gmail.com", "Tuan", "hashed_password_139", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c0bc5d95-e5d5-4a89-bea5-349ea2b4f17d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan159@gmail.com", "Tuan", "hashed_password_1159", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c108a708-8b1e-4569-9dd3-fadeba2ce862"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan141@gmail.com", "Tuan", "hashed_password_1141", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c125ed1c-19a9-40c2-aef4-b87355a01d21"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan897@gmail.com", "Tuan", "hashed_password_1897", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c145648c-0877-4f49-adc5-8bcf870487b7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan830@gmail.com", "Tuan", "hashed_password_1830", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c14bf796-977d-410a-99d6-07309107ea66"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan326@gmail.com", "Tuan", "hashed_password_1326", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c15a011a-377a-443a-aa34-bd8a0432b56c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan784@gmail.com", "Tuan", "hashed_password_1784", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c160aa4d-8e67-4b9d-b2ac-02b1164b91f8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan948@gmail.com", "Tuan", "hashed_password_1948", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c1a25035-fcaf-4b12-a357-d7c1b171a1de"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan662@gmail.com", "Tuan", "hashed_password_1662", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c1ea9ad0-ad3c-4e2c-be0b-3f9188751484"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan60@gmail.com", "Tuan", "hashed_password_160", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c255e74c-e34d-4f92-810c-e5be8a6031ee"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan563@gmail.com", "Tuan", "hashed_password_1563", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c27b7f90-884a-475b-adb6-113a31507ed4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan779@gmail.com", "Tuan", "hashed_password_1779", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c2af85d4-4d8d-4e55-9570-16e87a61d79b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan103@gmail.com", "Tuan", "hashed_password_1103", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c2debdd7-4984-48d8-8993-974fa5887458"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan434@gmail.com", "Tuan", "hashed_password_1434", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c2e01496-420c-4925-9fa4-5aa77ee8f15d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan264@gmail.com", "Tuan", "hashed_password_1264", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c3155d06-ec0b-4a75-83b3-e5e97e2e92e6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan492@gmail.com", "Tuan", "hashed_password_1492", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c31624da-198d-4613-99c1-090e8f207114"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan521@gmail.com", "Tuan", "hashed_password_1521", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c3b01ea1-581c-4fad-91b3-8399af6426f3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan367@gmail.com", "Tuan", "hashed_password_1367", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c3c49eb9-15b0-4bef-887e-df043c77ae16"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan811@gmail.com", "Tuan", "hashed_password_1811", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c3d9420f-7d69-47ed-b3b1-d64506af28cd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan178@gmail.com", "Tuan", "hashed_password_1178", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c572001c-2eec-49bf-b94d-a80f61cc231f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan414@gmail.com", "Tuan", "hashed_password_1414", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c573fcaa-1d4f-471d-8cad-70524d4e54ba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan333@gmail.com", "Tuan", "hashed_password_1333", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c5b72af5-6da6-4ef0-9b9a-542c68aaaf31"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan449@gmail.com", "Tuan", "hashed_password_1449", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c5cc784d-4fda-408c-92bd-98b6f4762202"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan95@gmail.com", "Tuan", "hashed_password_195", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c63d8437-f4d5-4b6d-b5a7-ba4302983cff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan553@gmail.com", "Tuan", "hashed_password_1553", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c67c4545-f873-4e67-b322-2dbe6eb9018a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan120@gmail.com", "Tuan", "hashed_password_1120", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c6f95904-3824-4476-966a-680dea12a908"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan464@gmail.com", "Tuan", "hashed_password_1464", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c7250613-0bff-47c3-96a4-2337cfde6525"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan125@gmail.com", "Tuan", "hashed_password_1125", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c78b533d-1233-42e8-b965-b81a5020cc48"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan655@gmail.com", "Tuan", "hashed_password_1655", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c7b384b6-cfa3-4889-830a-e6b170825d37"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan586@gmail.com", "Tuan", "hashed_password_1586", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c7ccd63c-bf64-4d61-ad4b-865b378d33ee"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan750@gmail.com", "Tuan", "hashed_password_1750", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c85fd815-8d9f-431a-ba2d-10df5c9186f2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan742@gmail.com", "Tuan", "hashed_password_1742", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c88e1a54-56cb-42ed-93c4-21cc59c06357"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan894@gmail.com", "Tuan", "hashed_password_1894", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c8a2de6d-1fa9-4b53-9c36-18edf7de0351"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan239@gmail.com", "Tuan", "hashed_password_1239", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c8a8e3aa-a116-4906-9c7c-489e70e63653"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan322@gmail.com", "Tuan", "hashed_password_1322", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c8ccad2c-4904-4e73-9ee3-fe526fc99439"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan230@gmail.com", "Tuan", "hashed_password_1230", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c8d03777-7c82-48d0-885e-2f30c148c505"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan567@gmail.com", "Tuan", "hashed_password_1567", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c8d907f0-b279-4b2e-a823-5ee123631896"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan984@gmail.com", "Tuan", "hashed_password_1984", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c94f01f5-2301-4d9e-a4e8-b0913f3eac07"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan632@gmail.com", "Tuan", "hashed_password_1632", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c98cf551-f5e0-4ca4-9797-333c537b92cb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan209@gmail.com", "Tuan", "hashed_password_1209", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ca48774c-517f-4414-904d-f60851832521"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan870@gmail.com", "Tuan", "hashed_password_1870", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ca8f3af2-29d5-4ef2-acbc-ee8237981502"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan964@gmail.com", "Tuan", "hashed_password_1964", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cad0e484-b725-4dc4-a786-e22ee67a6606"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan684@gmail.com", "Tuan", "hashed_password_1684", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cae52b3d-ab97-4d42-b197-d8cf136a3c49"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan77@gmail.com", "Tuan", "hashed_password_177", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("caf75303-26f9-4e10-9b6f-f225167d6b17"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan340@gmail.com", "Tuan", "hashed_password_1340", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cb0a1d73-519f-4c5e-b9e4-a2d2a179ad64"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan937@gmail.com", "Tuan", "hashed_password_1937", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cb34e74d-c275-4ff7-aa6f-070ea3c1be2f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan636@gmail.com", "Tuan", "hashed_password_1636", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cb65d86b-966c-49da-93e7-47df482e230f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan552@gmail.com", "Tuan", "hashed_password_1552", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cbbafff4-b0de-4f6c-992d-eb7caf2194a4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan794@gmail.com", "Tuan", "hashed_password_1794", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cbd5ade3-73aa-4eb3-bf0a-b4808f06d8c1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan58@gmail.com", "Tuan", "hashed_password_158", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cbd5ed52-3f97-41ec-a515-1e7d310536c3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan820@gmail.com", "Tuan", "hashed_password_1820", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cc18067d-09bd-4de7-aaa3-a04cc8dec0a7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan625@gmail.com", "Tuan", "hashed_password_1625", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cc976e44-84ac-4575-a022-d85d554659b4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan72@gmail.com", "Tuan", "hashed_password_172", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ccbdde1f-7cac-4ebd-b1f3-1b6e7fd2f2c7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan617@gmail.com", "Tuan", "hashed_password_1617", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cd4b0fba-b8b5-4366-8781-5682d3252b81"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan502@gmail.com", "Tuan", "hashed_password_1502", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cd687ed7-b287-4e0e-b1ed-cb637c99ca29"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan955@gmail.com", "Tuan", "hashed_password_1955", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cda49cbc-c2c2-4ab7-accd-b19a0651ad37"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan38@gmail.com", "Tuan", "hashed_password_138", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ce639c3b-c77b-4b4d-971c-b29aec77593c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan419@gmail.com", "Tuan", "hashed_password_1419", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ce7b0a95-96d4-4862-9bff-e155d4d89512"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan786@gmail.com", "Tuan", "hashed_password_1786", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cf549498-49bd-4c6a-bf34-195b61c8656c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan714@gmail.com", "Tuan", "hashed_password_1714", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cfe56994-f252-402b-8b68-24f36eba40ba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan665@gmail.com", "Tuan", "hashed_password_1665", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d001f761-6f68-4944-9778-f99ec91c450d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan935@gmail.com", "Tuan", "hashed_password_1935", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d0237fb1-6ca4-4f61-89c8-961830d0ddba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan913@gmail.com", "Tuan", "hashed_password_1913", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d03020c1-3d1c-4c0c-a081-019d04e2334e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan493@gmail.com", "Tuan", "hashed_password_1493", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d0cb459d-22e4-4068-959f-92679cd6db5e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan146@gmail.com", "Tuan", "hashed_password_1146", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d0e5b361-530d-4d18-8a77-de5ce508c5a4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan518@gmail.com", "Tuan", "hashed_password_1518", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d0e6e027-d4ca-4e41-b82a-2da4f580cdcf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan182@gmail.com", "Tuan", "hashed_password_1182", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d0edaf61-91e1-4aaa-9f40-a309c70ea5a7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan603@gmail.com", "Tuan", "hashed_password_1603", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d1236f98-ff79-4414-9fb2-4ccf1868a460"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan808@gmail.com", "Tuan", "hashed_password_1808", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d134090c-a091-46d7-b7af-9f453c2b531f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan381@gmail.com", "Tuan", "hashed_password_1381", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d16b45c4-297b-4fdd-9210-859205ccf4af"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan107@gmail.com", "Tuan", "hashed_password_1107", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d2158159-718b-4be4-ab2c-fe394c1dc4fc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan687@gmail.com", "Tuan", "hashed_password_1687", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d23f4ff3-3baf-4648-99b0-595349581ca6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan280@gmail.com", "Tuan", "hashed_password_1280", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d25ef427-fe78-4eef-8d74-6be85e3fea97"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan878@gmail.com", "Tuan", "hashed_password_1878", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d2803e76-94ba-4549-9005-9792a158cf82"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan85@gmail.com", "Tuan", "hashed_password_185", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d327487d-2f53-4a96-8b5b-31ad347cbb61"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan458@gmail.com", "Tuan", "hashed_password_1458", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d35a8648-bc3c-49d2-9e8f-9d22e3182f49"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan826@gmail.com", "Tuan", "hashed_password_1826", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d3aadc1c-066a-4483-b8a5-b8d18ad1b899"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan768@gmail.com", "Tuan", "hashed_password_1768", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d3e9a0e9-1ceb-4297-8370-e2b32cefcbd2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan682@gmail.com", "Tuan", "hashed_password_1682", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d3f35f5c-9520-4e49-a259-b74ef57b8eca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan547@gmail.com", "Tuan", "hashed_password_1547", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d4509c14-4d8b-4b39-8679-f04b6d3554d5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan620@gmail.com", "Tuan", "hashed_password_1620", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d45ba68a-5ce4-43a8-884a-1e6355309f13"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan52@gmail.com", "Tuan", "hashed_password_152", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d48eeb5e-a535-418e-90a8-82b871d59317"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan989@gmail.com", "Tuan", "hashed_password_1989", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d4ab8e8c-9ad1-41d8-8196-761b5aef3fcd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan153@gmail.com", "Tuan", "hashed_password_1153", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d520d53d-3401-421d-a535-2b06a4e93ba1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan384@gmail.com", "Tuan", "hashed_password_1384", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d57862b6-299c-44bd-b2cc-8a6e9f8d4fb4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan523@gmail.com", "Tuan", "hashed_password_1523", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d5950363-f61c-4d72-bd5a-88588da3338c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan482@gmail.com", "Tuan", "hashed_password_1482", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d63e67b3-f12d-4a5f-8681-19b7abb44f46"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan818@gmail.com", "Tuan", "hashed_password_1818", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d659afcf-bd17-467e-a04e-7118b406d386"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan198@gmail.com", "Tuan", "hashed_password_1198", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d66431c4-cff8-4972-b42d-a2b27e2031a8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan838@gmail.com", "Tuan", "hashed_password_1838", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d67206c8-d644-4d60-a483-57d8d480826f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan187@gmail.com", "Tuan", "hashed_password_1187", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d73a7f44-3ab9-4a6d-9958-d8d6bca6f07d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan741@gmail.com", "Tuan", "hashed_password_1741", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d744d5a3-1c81-4ad6-a74d-10acd0320680"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan81@gmail.com", "Tuan", "hashed_password_181", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d7e160b9-5e68-4e7f-8aba-26474abbd796"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan713@gmail.com", "Tuan", "hashed_password_1713", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d7e6a498-fbee-492c-be54-ee072dbc83eb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan137@gmail.com", "Tuan", "hashed_password_1137", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d7f9ce84-adc7-4678-b92e-942f8581c613"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan781@gmail.com", "Tuan", "hashed_password_1781", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d85b75bd-05f8-4ad7-bb75-65b6b704d04d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan346@gmail.com", "Tuan", "hashed_password_1346", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d8762e71-88ca-4037-be81-9b66ad8032cd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan296@gmail.com", "Tuan", "hashed_password_1296", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d8c6421d-613c-425a-8f65-c99fca97ec6c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan388@gmail.com", "Tuan", "hashed_password_1388", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d9186fc5-9d6b-4b94-b647-7f035d29d1ce"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan823@gmail.com", "Tuan", "hashed_password_1823", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d9469bca-8e79-4efd-81dd-f0f9d01c99cd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan568@gmail.com", "Tuan", "hashed_password_1568", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d9d61cd4-6c0f-4104-8ffa-6fb121e57ffa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan215@gmail.com", "Tuan", "hashed_password_1215", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d9e5f73d-8576-4f79-8236-65aadb61dff0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan541@gmail.com", "Tuan", "hashed_password_1541", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d9fb573e-3493-4787-9230-d90cd2845ea8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan205@gmail.com", "Tuan", "hashed_password_1205", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("da242a95-bb75-4949-9ddc-5991bc735f3f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan293@gmail.com", "Tuan", "hashed_password_1293", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("db642779-eb68-40dd-9c3f-e79a415f780b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan965@gmail.com", "Tuan", "hashed_password_1965", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("db866f37-d9db-4760-99b4-9665cc9a77ef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan993@gmail.com", "Tuan", "hashed_password_1993", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("db96f613-0c37-47b1-8d0e-d201f7c2d087"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan271@gmail.com", "Tuan", "hashed_password_1271", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dbefadf3-1602-457b-a15a-d1fe03d4f975"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan51@gmail.com", "Tuan", "hashed_password_151", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dc023921-dfa9-484d-8b62-6124eb35e4b3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan88@gmail.com", "Tuan", "hashed_password_188", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dc2efa26-7686-4a41-9f18-e20edb0f55ef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan387@gmail.com", "Tuan", "hashed_password_1387", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dd083de3-41cf-46b7-b1e9-5aa288030f0f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan891@gmail.com", "Tuan", "hashed_password_1891", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dd648e4e-bbd2-4703-a64e-82e455e862fb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan804@gmail.com", "Tuan", "hashed_password_1804", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dd70fffb-0836-4d52-8411-04b8089bbac2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan835@gmail.com", "Tuan", "hashed_password_1835", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ddb5b493-27ff-4c1a-904b-8039eb1a3451"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan647@gmail.com", "Tuan", "hashed_password_1647", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("de16a9dc-d7f7-45bb-994a-53391ed6f3c2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan604@gmail.com", "Tuan", "hashed_password_1604", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("de47e808-bd25-4b55-a0d0-2f8debfa44da"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan529@gmail.com", "Tuan", "hashed_password_1529", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("de57fe2c-b51a-4092-a6a8-2b9342059c93"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan428@gmail.com", "Tuan", "hashed_password_1428", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dea31b32-3962-4ce4-82fe-d45a6aa1e7ec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan415@gmail.com", "Tuan", "hashed_password_1415", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("deb2b4f9-821d-445f-83a7-f857a9e2ee83"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan376@gmail.com", "Tuan", "hashed_password_1376", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("df2a8e7f-4ac6-42de-8206-dfe01e38b0f2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan104@gmail.com", "Tuan", "hashed_password_1104", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("df2d563a-a435-478d-95d1-6683b8ff1633"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan224@gmail.com", "Tuan", "hashed_password_1224", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("df5a3d1b-8abc-4ffb-a46f-56eebbdb8341"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan601@gmail.com", "Tuan", "hashed_password_1601", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("df76adb4-d58b-4e27-a390-dd97900c2899"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan661@gmail.com", "Tuan", "hashed_password_1661", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("df786baf-2ac1-45e9-8a3d-9aa3ae17f151"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan861@gmail.com", "Tuan", "hashed_password_1861", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dfa45256-c1f8-4e77-8250-0cc6c18ceb3b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan308@gmail.com", "Tuan", "hashed_password_1308", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e05d0d17-63d4-43a3-960d-86335d1573ca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuanle17062k5@gmail.com", "Tuan", "hashed_password_1", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e0c57aae-990f-4c68-abaf-7b6a68760116"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan231@gmail.com", "Tuan", "hashed_password_1231", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e0c8c960-bdc0-47e7-9ccd-42b8a4d0f25d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan277@gmail.com", "Tuan", "hashed_password_1277", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e0da940a-f039-4550-92f9-bff174dc164b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan208@gmail.com", "Tuan", "hashed_password_1208", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e0ef9556-184b-4e3e-b52c-4b279d1d1e69"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan513@gmail.com", "Tuan", "hashed_password_1513", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e179822b-c04a-41e5-9d94-ebe4d1b39c18"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan86@gmail.com", "Tuan", "hashed_password_186", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e1fe4df0-898a-479d-873c-92a2c6a16bc9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan165@gmail.com", "Tuan", "hashed_password_1165", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e2412b7b-8b60-4b25-b38e-9ad29bde02eb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan319@gmail.com", "Tuan", "hashed_password_1319", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e25cb41e-ce6c-472d-8738-3c4f12f59e0c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan933@gmail.com", "Tuan", "hashed_password_1933", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e2a98e59-f7b0-44c9-a881-719db1ba6edf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan67@gmail.com", "Tuan", "hashed_password_167", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e2d56ded-d396-4798-a851-1f9959a1c780"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan268@gmail.com", "Tuan", "hashed_password_1268", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e2ee670c-f15c-4d78-bc29-634c56c59def"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan795@gmail.com", "Tuan", "hashed_password_1795", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e37033b8-a94d-4d4d-90ee-6ffd60289c98"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan169@gmail.com", "Tuan", "hashed_password_1169", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e428015b-d196-4b20-a38a-2b038511d2ae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan71@gmail.com", "Tuan", "hashed_password_171", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e466d813-d51e-439e-bfc0-9d8738efdd15"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan743@gmail.com", "Tuan", "hashed_password_1743", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e4e4a74c-c494-4728-9543-a75f8cad1f7e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan707@gmail.com", "Tuan", "hashed_password_1707", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e51dfb42-04a9-4ec5-b00b-a9be59300d4c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan653@gmail.com", "Tuan", "hashed_password_1653", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e52cbabb-3873-4d33-b765-e32730f785c3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan14@gmail.com", "Tuan", "hashed_password_114", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e5509e37-7d8d-42a7-bd71-8dabcfacaceb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan729@gmail.com", "Tuan", "hashed_password_1729", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e624e89f-102e-4976-9185-a2778193f62a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan192@gmail.com", "Tuan", "hashed_password_1192", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e6e768fe-634e-43de-b9ce-d4d7d2e3abe0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan396@gmail.com", "Tuan", "hashed_password_1396", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e710f9b2-f401-42b5-9a63-fc7c0aaea1fb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan517@gmail.com", "Tuan", "hashed_password_1517", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e74e73d5-3d30-40ca-aa7c-113eca195f45"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan392@gmail.com", "Tuan", "hashed_password_1392", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e76b76f6-2d93-4c98-aa19-762413764df2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan163@gmail.com", "Tuan", "hashed_password_1163", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e789a8f1-b6ad-4d6a-8bf0-23d159e146bf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan247@gmail.com", "Tuan", "hashed_password_1247", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e78c9aea-2b12-4d1f-93e0-3558be02d349"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan542@gmail.com", "Tuan", "hashed_password_1542", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e7a87b03-2f71-4bbf-9639-d4931a7d0c3d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan99@gmail.com", "Tuan", "hashed_password_199", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e8331852-ba4d-4823-826a-53fddc53afc9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan717@gmail.com", "Tuan", "hashed_password_1717", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e83ebea8-ed59-4561-9833-7f4c306280ed"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan8@gmail.com", "Tuan", "hashed_password_18", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e86db0fa-6ef0-427f-8488-b6c1cd2e0d55"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan686@gmail.com", "Tuan", "hashed_password_1686", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e8c05f81-5be5-47e0-8185-e76e077bd716"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan947@gmail.com", "Tuan", "hashed_password_1947", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e8dbe2c6-f71f-49ef-8d82-468ad08f8cae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan210@gmail.com", "Tuan", "hashed_password_1210", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e910eb52-1996-4b02-8a78-6e8c392c125d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan421@gmail.com", "Tuan", "hashed_password_1421", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e92efaeb-3155-42cd-9cef-92b51ce4aeff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan361@gmail.com", "Tuan", "hashed_password_1361", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e9862b22-6175-4de7-ba8c-f2046d9e8e5a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan172@gmail.com", "Tuan", "hashed_password_1172", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e9a7710f-7742-49e1-8dc3-c09f06165e2a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan721@gmail.com", "Tuan", "hashed_password_1721", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e9bf04d4-5268-4219-b4b0-5920af05df31"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan32@gmail.com", "Tuan", "hashed_password_132", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e9ed6a2c-7413-4256-82c7-2f87a49847e1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan644@gmail.com", "Tuan", "hashed_password_1644", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ea12d547-cea4-46ba-9b08-8ca86fc2c574"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan566@gmail.com", "Tuan", "hashed_password_1566", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("eb42970b-6a8d-4e60-a6bb-93df500ab167"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan749@gmail.com", "Tuan", "hashed_password_1749", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("eb69a70e-efcb-4f75-9ce1-f1d9ba5115ce"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan790@gmail.com", "Tuan", "hashed_password_1790", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("eb8ff028-68b3-4b37-a8e4-7b722797e9b8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan448@gmail.com", "Tuan", "hashed_password_1448", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ec34ae39-0090-46e9-8055-2a737a1da0dd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan735@gmail.com", "Tuan", "hashed_password_1735", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ec57a405-de4c-4573-9b7b-ec706e585ee6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan731@gmail.com", "Tuan", "hashed_password_1731", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ec5f30be-5716-4083-b96b-ab6741361f42"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan724@gmail.com", "Tuan", "hashed_password_1724", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ecca5b68-c6a2-4669-b91f-f3269ee534b3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan28@gmail.com", "Tuan", "hashed_password_128", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ecdb2817-cbfd-46a8-983d-cbac7421e221"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan225@gmail.com", "Tuan", "hashed_password_1225", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("eda2ad12-89e1-478e-bf21-dca73ea93cfc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan562@gmail.com", "Tuan", "hashed_password_1562", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("edb078d9-b515-4597-b74c-e8868eacc8cb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan816@gmail.com", "Tuan", "hashed_password_1816", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("edbcea27-1b14-4f37-a803-291135050c44"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan131@gmail.com", "Tuan", "hashed_password_1131", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("edebb8de-e881-45ad-a600-ab1640ff9b41"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan25@gmail.com", "Tuan", "hashed_password_125", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ee46bf4a-4fbb-48e6-b31c-b760f2c52ba6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan550@gmail.com", "Tuan", "hashed_password_1550", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ee91a2e9-0c24-4425-9526-2fe5255b7887"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan427@gmail.com", "Tuan", "hashed_password_1427", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("eead36c8-7a92-4f20-a67b-1a98ee5cf4ec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan191@gmail.com", "Tuan", "hashed_password_1191", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("eead4992-ba54-44cb-ba75-e6bc5d5d3469"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan4@gmail.com", "Tuan", "hashed_password_14", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("eeb6a02c-5082-46e0-a336-2cf0b0bddd7e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan832@gmail.com", "Tuan", "hashed_password_1832", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ef407ece-1452-4b89-a02b-428a8e47f7b7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan970@gmail.com", "Tuan", "hashed_password_1970", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ef9de3de-952a-4c59-afac-197036095972"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan216@gmail.com", "Tuan", "hashed_password_1216", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("efb13e25-16d6-4fe2-99ae-1c743202b718"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan536@gmail.com", "Tuan", "hashed_password_1536", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("efbb482e-4f3f-4444-999f-326c73ddbc3a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan520@gmail.com", "Tuan", "hashed_password_1520", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("efcdf7ba-99d2-4ee7-a5f0-a162f8eadccd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan496@gmail.com", "Tuan", "hashed_password_1496", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("eff49ac1-ed6e-4d47-837a-3756883b8f5d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan850@gmail.com", "Tuan", "hashed_password_1850", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("effe6f68-3c52-4033-b204-e1fe23bfe717"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan145@gmail.com", "Tuan", "hashed_password_1145", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f0052410-ec53-44e4-a676-04fca80466c9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan732@gmail.com", "Tuan", "hashed_password_1732", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f05b95c1-d04f-4a94-b618-ce79d7efd0e9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan378@gmail.com", "Tuan", "hashed_password_1378", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f0d7f213-1962-495a-9870-8338e748d396"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan204@gmail.com", "Tuan", "hashed_password_1204", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f0eb986d-9265-4a68-934a-f700915efbd8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan226@gmail.com", "Tuan", "hashed_password_1226", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f0fec2d6-a3c9-40e2-9d08-ec189bb99297"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan722@gmail.com", "Tuan", "hashed_password_1722", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f1216de4-d341-4ce6-9cd5-505da67e6df5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan777@gmail.com", "Tuan", "hashed_password_1777", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f14bced2-17cb-4802-80dd-bbd37df09f9f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan76@gmail.com", "Tuan", "hashed_password_176", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f1841b59-55f0-42ac-8b1d-936c3dd37176"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan480@gmail.com", "Tuan", "hashed_password_1480", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f1b88a7e-875e-47a1-8a1b-3dcd9fbd410a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan401@gmail.com", "Tuan", "hashed_password_1401", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f1e3a37f-2a51-43e9-9252-474e8d861a9f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan858@gmail.com", "Tuan", "hashed_password_1858", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f23251fa-2f5b-4bf3-a717-633667d6a998"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan571@gmail.com", "Tuan", "hashed_password_1571", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f2c6e414-2c02-408e-a9cb-f05ad2c436a0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan934@gmail.com", "Tuan", "hashed_password_1934", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f2cf9119-e35d-43e0-8718-2ea84d382e0b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan667@gmail.com", "Tuan", "hashed_password_1667", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f39155cb-7aaf-436b-9191-1510c13a335a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan602@gmail.com", "Tuan", "hashed_password_1602", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f3c0e5d9-2aa7-4f4e-9d35-149c6092640b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan696@gmail.com", "Tuan", "hashed_password_1696", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f46800e0-deaf-4789-9c69-26e7dfc99f98"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan642@gmail.com", "Tuan", "hashed_password_1642", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f4e82359-fecc-4a36-8027-d654c50fd1b7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan490@gmail.com", "Tuan", "hashed_password_1490", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f5498a7c-ed79-4e48-b31c-4696c802f018"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan893@gmail.com", "Tuan", "hashed_password_1893", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f5d0269a-072c-4541-8958-0e38b013d5d1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan186@gmail.com", "Tuan", "hashed_password_1186", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f6463685-fc61-42ae-ba1e-058d1e10f8ac"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan402@gmail.com", "Tuan", "hashed_password_1402", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f6b60a19-cc6c-43a1-bf65-1c51b46c88c1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan796@gmail.com", "Tuan", "hashed_password_1796", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f6f1bbbb-fbae-4317-997f-cb20d2694f1a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan316@gmail.com", "Tuan", "hashed_password_1316", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f75527e2-67bd-454c-a8df-0c7325da3405"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan859@gmail.com", "Tuan", "hashed_password_1859", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f75a73ef-3d10-4ce0-bdd0-443b8fe0e7d5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan901@gmail.com", "Tuan", "hashed_password_1901", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f7b4d173-7d90-40d5-9fb4-e079b446f38b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan854@gmail.com", "Tuan", "hashed_password_1854", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f7c552bd-2fb0-407b-ae06-20908a7f5d88"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan395@gmail.com", "Tuan", "hashed_password_1395", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f7de0019-3288-4b27-8696-75e25c595de7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan353@gmail.com", "Tuan", "hashed_password_1353", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f8229b63-f8d6-44dd-b016-242c9e425dac"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan736@gmail.com", "Tuan", "hashed_password_1736", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f885e143-cffe-4981-a2bd-2cfdb0e5024c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan681@gmail.com", "Tuan", "hashed_password_1681", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f97f4db2-ccaf-4aa7-ae15-5eb38d978643"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan926@gmail.com", "Tuan", "hashed_password_1926", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f9a59d33-bce4-4eb4-9d35-424a121ccd99"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan171@gmail.com", "Tuan", "hashed_password_1171", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f9e43451-a51a-40ba-b890-dd840ac06db0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan959@gmail.com", "Tuan", "hashed_password_1959", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f9ea55ce-e13f-43a1-bfaf-52f2e4b4c210"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan771@gmail.com", "Tuan", "hashed_password_1771", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fa801dfe-4320-464d-bdb1-6af93f72129e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan484@gmail.com", "Tuan", "hashed_password_1484", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fa8c7931-be84-4fcd-80ea-74bbdf611927"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan692@gmail.com", "Tuan", "hashed_password_1692", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fb5af793-2b3c-44e5-8297-1d238df2c82a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan917@gmail.com", "Tuan", "hashed_password_1917", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fb716b00-51d8-4bd9-adfd-19c231dc3695"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan357@gmail.com", "Tuan", "hashed_password_1357", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fb84e6c9-2c4c-421c-969f-814e9c6372f7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan97@gmail.com", "Tuan", "hashed_password_197", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fb98ecae-c526-4aea-8eb8-3e1a1b7d3095"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan825@gmail.com", "Tuan", "hashed_password_1825", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fbd1a728-c20e-4860-86e0-37b33e9bc3c5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan589@gmail.com", "Tuan", "hashed_password_1589", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fc0dda84-ab86-49bd-be02-849f9fba1e92"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan910@gmail.com", "Tuan", "hashed_password_1910", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fc8f65fc-73b7-4981-92b4-e3fe126554fb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan17@gmail.com", "Tuan", "hashed_password_117", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fcfc9957-96da-4608-ac75-099901aee2e3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan533@gmail.com", "Tuan", "hashed_password_1533", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fcfeaddf-391a-4373-9b0e-ed42e9f26298"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan974@gmail.com", "Tuan", "hashed_password_1974", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fd89ed21-b663-4e8c-b71e-3db5f7a01788"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan456@gmail.com", "Tuan", "hashed_password_1456", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fd8f6085-cc96-4b82-8578-9e2eaec25e88"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan733@gmail.com", "Tuan", "hashed_password_1733", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fdcaba22-3e25-4933-a729-68ff43afc2cd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan26@gmail.com", "Tuan", "hashed_password_126", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fe0e1304-3b68-414d-8d2a-b76050bcf210"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan123@gmail.com", "Tuan", "hashed_password_1123", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fe475de6-532a-41ca-87a2-a8b21d95877d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan254@gmail.com", "Tuan", "hashed_password_1254", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fe5480aa-c37a-4e55-86f2-66ccbc3d7b79"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan821@gmail.com", "Tuan", "hashed_password_1821", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fe66133f-e3a9-4878-ab78-2f453a7808a8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan645@gmail.com", "Tuan", "hashed_password_1645", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fee1038a-2d9d-4781-826c-5c4dcbbe7737"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan10@gmail.com", "Tuan", "hashed_password_110", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ffa9ddc3-a2ca-4556-b71d-9b5eefaeef2c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan317@gmail.com", "Tuan", "hashed_password_1317", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ffb91c28-b263-41ee-869f-c20e2192ea5d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan834@gmail.com", "Tuan", "hashed_password_1834", null, false, false, "Le", null, "User", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "IsDeleted", "Name", "ParentId", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("2301629b-eb65-4d47-bdeb-2975fb1ea580"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao", new Guid("9c68c104-0ddc-4f5f-bb20-69e54a2d6a76"), null },
                    { new Guid("5dcc4ccd-25a8-4e7c-ae15-27405805f567"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean", new Guid("76607dce-928a-4cbd-8c12-f70d7541d530"), null },
                    { new Guid("c0c7178d-4e04-48ac-aa16-05d1fa59a1bc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo ba lỗ", new Guid("9c68c104-0ddc-4f5f-bb20-69e54a2d6a76"), null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "CreateAt", "IsDeleted", "Status", "TotalAmount", "UpdateAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("6c3215ef-8516-4fb3-904d-ed6257fa549f"), "Bien Hoa, Dong Nai", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed", 100000m, null, new Guid("25915cc6-1693-4fc5-a665-c7fd3fd13b03") },
                    { new Guid("8be92b0c-580b-49cd-a7c3-6447d6985dd9"), "Bien Hoa, Dong Nai", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed", 100000m, null, new Guid("25915cc6-1693-4fc5-a665-c7fd3fd13b03") }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "CompanyAddress", "CompanyName", "CreateAt", "IsDeleted", "TaxCode", "UpdateAt", "UserId" },
                values: new object[] { new Guid("bac690d3-9e19-4560-a6a0-118562c7b2c1"), "123 Main St, Cityville", "ABC Company", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE123", null, new Guid("e05d0d17-63d4-43a3-960d-86335d1573ca") });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreateAt", "Description", "IsDeleted", "Name", "Price", "SellerId", "UpdateAt", "UrlImage" },
                values: new object[,]
                {
                    { new Guid("13a36d82-ed91-4360-a955-6549365a491f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quần jeans nữa dáng ôm, tôn dáng, chất liệu denim co dãn, phù hợp cho mọi dịp.", false, "Quần Jeans Nữ", 399000m, new Guid("bac690d3-9e19-4560-a6a0-118562c7b2c1"), null, "https://example.com/images/quan_jeans_nu.jpg" },
                    { new Guid("6f74af01-ecea-4c0c-9ed0-9839182f23cd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Chân váy nữ xòe, thiết kế trẻ trung, chất liệu vải mềm mại, phù hợp cho mọi dịp.", false, "Chân Váy Nữ", 249000m, new Guid("bac690d3-9e19-4560-a6a0-118562c7b2c1"), null, "https://example.com/images/chan_vay_nu.jpg" },
                    { new Guid("74883d09-e73a-446f-94c5-725ffe81f34e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Áo sơ mi nam công sở, thiết kế hiện đại, chất liệu vải cao cấp, thoáng mát.", false, "Áo Sơ Mi Nam", 299000m, new Guid("bac690d3-9e19-4560-a6a0-118562c7b2c1"), null, "https://example.com/images/ao_so_mi_nam.jpg" },
                    { new Guid("96bd24ab-8378-40c8-ac14-e79078f8a679"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Áo thun nam chất liệu cotton cấp cao, thoáng mát, phù hợp cho mọi hoạt động hằng ngày.", false, "Áo Thun Nam", 199000m, new Guid("bac690d3-9e19-4560-a6a0-118562c7b2c1"), null, "https://example.com/images/ao_thun_nam.jpg" }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "CreateAt", "IsDeleted", "OrderId", "ProductId", "Quantity", "UnitPrice", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("42db41db-0f40-4988-be16-cb32bcce7304"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("6c3215ef-8516-4fb3-904d-ed6257fa549f"), new Guid("74883d09-e73a-446f-94c5-725ffe81f34e"), 2, 299000m, null },
                    { new Guid("8e5bb41c-f774-431a-81ea-4028be44a6f7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("8be92b0c-580b-49cd-a7c3-6447d6985dd9"), new Guid("13a36d82-ed91-4360-a955-6549365a491f"), 2, 399000m, null },
                    { new Guid("97310c7f-148f-46d3-a4d5-49e7f9bce3b8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("8be92b0c-580b-49cd-a7c3-6447d6985dd9"), new Guid("96bd24ab-8378-40c8-ac14-e79078f8a679"), 2, 199000m, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sellers_UserId",
                table: "Sellers",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentId",
                table: "Categories",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_ProGuidId",
                table: "Inventories",
                column: "ProGuidId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_ProductId",
                table: "ProductCategories",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SellerId",
                table: "Products",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStorages_ProductId",
                table: "ProductStorages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStorages_StorageId",
                table: "ProductStorages",
                column: "StorageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sellers_Users_UserId",
                table: "Sellers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Sellers_Users_UserId",
                table: "Sellers");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ProductStorages");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Storages");

            migrationBuilder.DropIndex(
                name: "IX_Users_Email",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Sellers_UserId",
                table: "Sellers");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6c3215ef-8516-4fb3-904d-ed6257fa549f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8be92b0c-580b-49cd-a7c3-6447d6985dd9"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("bac690d3-9e19-4560-a6a0-118562c7b2c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00022283-a3d2-449d-865a-2db62858443a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00411e8b-61a4-4b42-8e84-ca157e327d95"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00495ea1-89ed-4e44-824f-6e9bbc3e4fb6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("005c0abb-3f27-47a5-b99f-37a1f2ed9588"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00966d70-d354-4ffa-ba8b-91a45d518a52"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00e80dd2-3720-4f0a-8c69-0139a96057c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("01262607-45c7-451f-b131-888c6943bb00"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("013421d4-e440-4632-acc9-c82f7eb47ef3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("01a88e67-96c7-4a75-a67c-5fc836d70136"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("02976a88-2e14-420b-9f84-7f9b55a2f267"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("034b88d4-c9fe-4dda-a9d5-536f45ca9edb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("039ca4e7-cdd3-4bdd-8925-573a33a0bf2d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("03a4ff38-9ed5-485c-be1b-b52e1822a9cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("03e014cb-cd45-4901-a3a0-fc3e61edb16a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("041d2f6f-3cc6-49c9-ad3a-feb12ed72e12"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0444e67d-cf8d-489e-9a5d-02f61e7c359b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("04612ada-146e-4af0-aa39-fe84ed74c430"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("048169d8-acd7-44b5-abb0-04a38bd3d42d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("04fdde23-a378-4b3c-b4a3-23502161e936"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0529504e-08c4-44a7-9c3f-c0a9dae8b832"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0543605c-debe-4624-9a30-c268a3e7cd74"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("05464473-af06-4895-804b-99e38e940aa9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("057a6939-3572-4dbb-bbd0-e63e646df50d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("06795e70-aa7a-4a24-b42d-df3090d368f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("06ef5bbe-a678-4449-bdb5-d218aeef85f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("06f6234b-79f7-4d6a-b149-e24978e34a73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("072a89f5-8f5d-49fd-9fdf-43404700eeb3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("072f189a-4b93-4e64-9dfa-37d0abebf6b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("076967f2-9010-4479-9195-10999f4a58d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("077dd9d4-6513-42e8-986c-c180c1bc0de9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07ab4365-4734-4096-a79c-4ce4ea14039b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07df24b9-e12d-44b3-b862-6491921736f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0832c153-56de-49ef-83bb-3d5bf8f2e879"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0835e0c7-8f6c-4f6b-94c5-0a3c25f180cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("088502e8-10bc-4be5-abf9-6be62a724dd1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("08d80885-2b7f-46d0-9e72-0c9b18f74082"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("098fccfe-393d-420e-9f81-afaa7d75f4a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09d46a91-ba28-459a-a159-42baf397102b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0a3adcef-fc42-439c-9903-14912c11ac7f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0a4bf449-efe8-4a5c-9f75-60b2a51a1dde"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0bafecca-9b0a-4e22-aa54-c54b64d02760"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0be8de04-cdae-41c3-82f6-f8086bf98843"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0c5cedbc-0973-47d9-b6e6-6cdb746ca77a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ce590a2-0d5f-49a8-8fe8-fdf959bc1f73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0d3d7ee5-45f1-445d-acd1-40330a6d75ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0d71c6c4-16a7-4922-bc08-ebc9f45602b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0d834c69-4cb1-4066-8fa8-c6d3ac9285ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0dbd4518-20b4-4eeb-a5b2-a3c309eb97eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0dcebe96-f412-45b4-a5fc-b6fbbf63b604"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0dedaa7b-ccb2-41be-9373-cbee832026f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e008f47-5a6a-42f2-8bea-fa794917b308"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e1fa222-79b6-408e-a893-fb6591889e3c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ecbff55-6f24-43be-bb0a-c4cd753c938f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f36c09f-52f0-4d92-b461-e60a41117cbd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f72b8c7-a134-46f1-b523-6e4f072001d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f90fbc6-3966-43cf-a0a5-6e5570e47b9b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0fbafa1e-3d5e-4077-889c-ad5e4d6003aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("102ffabd-6e69-4be2-9526-757b9b42efd0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("107ba4ce-0fa7-4bab-9cc2-2698b8f1f4f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10f87abc-e9ea-4775-a459-4e00a9cf1d77"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("112c4443-54d7-42c9-b276-6c9ba75788b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("114d3ef7-0f9c-4816-b42c-f05ce4a9f368"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("116c4de7-850b-47ce-a5b3-5ac7bc3a4148"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("117504f5-3be0-4d1f-b681-0f45a117eb5d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11f5e180-7a83-4530-a835-fb47fe444616"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("120b7ccd-cc71-418e-80e4-8e8c08fa6763"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("124bf99c-e24e-4a0b-b1c8-9681db4d90df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("124cf00f-2e64-4dfa-afc9-b4ac75fcc748"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1280d495-7139-4d46-a3c5-3c194fa52e8d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("129aed73-7a20-480b-86d4-da96de0b2144"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("12a1257c-e7fa-41ae-b8d7-16653ce0db0e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("12a8e47f-f4d8-4a03-bbe6-f4217da51d5d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("12ec43bb-aa50-492c-8a5d-5c5a67463b5e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13632b41-076f-483e-a8bd-c090ce6a3920"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1369aa45-ee0a-45f1-9211-ec35a49f50fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("139152b4-9a82-4c93-89cf-242fa6729edd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13dc97b9-9e3e-4d2d-89ff-9bba8710bb90"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1442b633-744a-406d-8f8d-9acd5a8a118c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("146b177e-d605-4546-b29a-4f29a87acc7b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("14c23ca8-4bd8-48a8-8af2-6525070b7cae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("14df97a1-eff8-4ae0-851e-28dd4f0264de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("15b109d3-ea5e-430a-b7fd-633275f191fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("15b507fb-3090-40a7-af95-24660e4892f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("15bfae38-75a0-488e-9efb-45382376ef36"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("171dc373-1912-49dd-9500-6b0aeb16f1c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("176f81db-a939-4059-aa61-fe408343a90d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17d756b6-5b16-4161-b400-fbdecf375677"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18088875-38b5-464f-a7aa-ec4be032948e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1829eb81-3da2-467f-b834-d32cef711fd4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("183dff50-2c80-4915-b27b-b9eab633e22c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("184418f4-7419-413f-9cde-7f2afa6b1329"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("188c866c-91fd-40ea-b12a-3b9981ff8240"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18c0eecb-9090-4393-88e6-37650be81720"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18c4d53f-98fe-4860-ae2c-767d232b9aad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("19019f25-1649-414b-b572-45a8fb935f41"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1935732c-d63b-4ca4-87ca-62b5c3b8204e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("194fad18-9682-4fcf-bf06-d2572f1df955"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1966c7ca-8ca8-4df4-aa3b-c101df601b42"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("19926021-3c08-49d1-8286-7204288c8344"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("19a949d3-8bb6-4ea8-83f1-65813a3b00a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("19c4c3a8-9eb1-40ef-9984-9789f5549ca9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1aed3400-d51e-499e-b48f-20ecfd55905d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1af0a7de-767d-4b0a-b1e7-e256ee29a45f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b17bc99-e23e-44e0-a4e5-ce6974f2aba5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b2a2edf-1743-4df2-885f-c1e3f867d580"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b391ca9-0d31-4635-8466-c2d14b71b8e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b4e1565-149f-470a-9610-88a7c8084cb2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b650fb8-11a9-4a75-b185-3157e09a53c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1baa1e47-09da-4ac4-8fd2-13981282c79d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c473ca7-e28d-4d7d-8117-505e386fa7b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c520d76-a62e-4bf3-841c-35cec6a068fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c9ba7d9-8693-4909-ad50-6deba6622955"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1ca3f28f-c539-4dba-b69e-c4ca76055710"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1cac9970-0dee-4371-8b9a-283d2e207c4e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1cd23702-715c-4473-8493-d84e278910dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1cff6873-7308-4047-a370-19ade6955c44"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d3c88cb-1369-47d7-9e37-f2c7d3784c8f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1df405ba-a52d-42fe-8c68-2bae27b55a10"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e007032-0419-41ff-8609-0af0aa8dc07c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e26490a-2675-45eb-804e-3a480cce9568"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e3af1ab-f25e-4fdd-83c0-e957a5aa8bd5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e4af14a-96b6-4454-a1d2-8e71e830690d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1ecef09d-d613-4879-88ea-32e01148e4ab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1f7e7f08-7dd4-46b1-9c54-e445db1a7b52"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1f8220b9-d93f-41f7-b4b3-ff18a58f732a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1fd4c7e9-a06e-49ef-9e11-68022da0dd84"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("201a0438-ac66-42fc-964d-6548fae4916b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("207f22b8-63f1-43a7-8eda-0749a03a2f43"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20ab1f41-9b84-42d7-8bb3-183d17fe7423"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20fa63d2-c9c6-457c-8a68-5787eab8ab7b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("212478f7-b440-412e-83fa-1f52f587341f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("217a8586-256a-4ab1-8e21-89feb48ed002"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("217ba630-2813-4627-8311-946ab526201a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("219a5997-3f30-4cf7-b698-34ea7c9dd233"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("21b9e2c8-d1a7-4787-a5b1-70f2405717e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("21d8861e-0e73-4bdb-a8d5-f67e0cce0d68"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("21f49582-70f1-407d-9cb9-f13654c5bea4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2259ef78-448b-48b3-8a60-c293abd065b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("227f089c-85eb-49df-a24b-d5bf826218e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2298224b-a704-4da3-9874-454e61856f2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2329975b-b1fd-4f8b-afb8-834980cef79d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("233f85d7-4a4a-4787-ad62-8b7b56ea9ce2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("237159a8-a3a9-4071-9265-df36bc71174f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2385b6fd-a969-4701-a916-eebc3d5e3759"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23f427c9-da13-4fd3-a9c5-50364e058bf7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23f7e592-62a0-4273-aa0d-e5d18561b8e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("248c3e4e-d5f7-47cf-b8f9-d13641e158eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("249e2534-57c5-45fb-b4a6-54b075b21522"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24ef06b0-c7d7-43e9-9abd-a53741fce78f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24f9a5a0-a5ba-4c02-8eae-8da71bc6459f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("251c485d-7338-4881-858b-620403f45ad6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("256791f4-e088-4546-8548-d5c76f78b29c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2594ef2a-64cf-4710-a6c3-0a07b1612d22"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("25c95a83-3dd5-4217-ad15-26eaea3f4d89"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("261a068f-3a79-4f47-8164-21c5b5b4b28a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26517699-1f17-4061-b757-75a7bfda1751"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("268ce2dc-efa7-4328-b457-f3ec344b3dc3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26aad548-62b6-43d5-bd4b-a7188f266b8b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26d5b188-0f3c-4782-90c5-fd2d963ba6ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26dfd908-8dbf-481f-8096-5b93d44ca863"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2705ff0d-d276-4118-bc25-302c8cb55799"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("270f946b-827e-4dd9-a47d-b9da75005592"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("272548a3-ca3d-4ba1-b8bd-f969d24f76f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("272cd1f4-2d7e-4a02-9802-a65604e97d7f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2749ea5d-e8e9-4558-b9df-4a4015e28e08"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2878cc43-0a79-4b83-bff6-258c602358c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("289f2e1b-d34b-451e-a722-177cff7373a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("28c577cd-4528-4675-8d59-c6450e23850f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("28c5f3dc-9165-47f8-88e0-2a777df415c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("28e161e7-3047-4efd-9d5b-6b9f7aebe264"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("28efef4f-ed56-4d9f-99b1-2a0a056118db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("297ebf47-91a8-4cc7-bc4e-6b133bfc71bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("29c12ae1-b4c4-4355-976b-cb6e81a20f3a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a4bbdfd-12e6-4da3-aefe-2e59eb72c1b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2abe5c04-3b6b-4af3-8133-0ccd36a32d20"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2b38f276-2f0b-4f95-9c1e-4523f77d59f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2b84a16c-1ae1-48aa-bb97-f7a188c9e8ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2bbd6704-dcd0-476d-a47d-f1067ebadf76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2be5cbd5-cca1-46b1-9484-3c20d28db1bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2c5cca97-6e5b-4f2f-a5e8-4b185f9bfea5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2c890f6f-dee9-43ec-899f-042bd16e5c5d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ca1bead-6e24-4657-ae62-f56282227807"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2cadf817-0b9b-40cb-aaba-8d8a5efe8a73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2cbe2837-49ed-4175-b807-a0fb4eab7a9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2d17316f-dd7d-4c50-b9c0-4f42a5e9395a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2d2dbbf3-43c7-46e5-a0e1-385a20ca1322"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2d509515-4b37-4674-ad9e-9860e5d930e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2d980228-dbea-465a-bdeb-ca6a2db14f8b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2da23581-451f-40fe-ae65-521287bfcc49"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2dde4cf4-1fb2-4eaf-8b82-7b5de45b6283"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e51760a-d31e-403e-af73-a12c5184a54e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ea092d0-541b-458d-bf28-cb2718b73232"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ea322cc-3447-409e-8e38-1cc6966f5157"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ec8bbf6-c149-47d8-8c6a-d25515520b58"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ef42661-4b2a-43f7-9d6e-81d152a6d648"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f2aa29f-43cd-4457-b981-4bec273aa484"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f4c12b4-9716-46b8-8cf9-4deeac0a0b7a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f9220f8-c384-4b35-9d50-68a116c3bf60"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f938c26-3e31-4e75-912a-e6aa1202e49d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2fe3d80a-50d7-4b94-b919-7f927542494c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3006a5ea-c5d5-429b-9459-56c392ae2dab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3026ade7-9399-4e85-b87d-c533c021b69b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("303e8a55-7716-4266-8289-de27f1005610"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30bdbbc7-a5c6-4413-a392-3ea2a3c29928"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30cdae53-43a8-47f5-822f-d53b973ec2aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30e696a0-f58a-45fa-b288-1effe5ee1f37"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("310e6f3f-d954-4ac2-b9fe-e9be58dba7c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31153374-e7db-423b-acfb-082ddd1f8108"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31a80968-14fa-429a-8c8a-3f402911602a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31c63dcd-5ad8-4d99-9c9a-01b623f34005"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31e41a43-fda9-41c8-941b-594caccfcc19"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31f6579a-fede-4b6b-96ea-37ce1abac83e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("321ae414-9fa0-4e64-bf50-f1ceb2c7483e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3267b076-cd10-4a70-a5b1-5fa25916a26c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("32779d19-bd00-4943-8578-659d892467fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("32c7fe38-5126-4047-98e5-01008659ef09"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33171397-b05e-4fd0-80d8-d733df3d8296"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3398871d-152d-4f6d-9d3f-01091e781e8a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33aa51f4-8530-4470-ab9a-9eb0058fccb3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33e4bfab-07c6-432d-8f55-47f83110ff4c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34199a8d-4819-415c-acc3-435eacf05e8c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34214dec-b06e-46cd-816d-aeae587829f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("344608ba-7559-4585-af27-96080cab5d96"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("345eedb2-355f-45b8-a986-6afbee298b34"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34efa49f-0fb7-41f7-84e7-d9a35a9974f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34f1cfa9-e749-4cd9-be63-ddac7bccd785"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34f2515a-9a68-4127-8276-88b48135a418"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34ff5618-ef0b-4f6e-ad3a-0f64771e9b05"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("35a21218-ff1a-4a33-a53f-eaf284d5722a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("35e88f9d-f19a-497a-a031-c70fd844066a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3616e12e-085a-44e6-8443-697a1773c2ee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3617adf2-d124-47e1-802a-dcc0754e918e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36403590-f3c6-4b26-bbaa-4cecc5289a77"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3670d9b7-009c-4dad-93ce-ad374478a35c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36782b81-6ac1-4382-9fcc-b678f993b468"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3696f8dd-809c-44a6-b10c-c232dc12835d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36f25780-c731-494b-bd8e-d001d4dba200"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("37275a90-7521-4608-b397-9c6e73fa8b08"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3763acf7-12d4-4ae1-b09d-4340a4a09898"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("37af0761-451b-47ac-9845-9c1ce778cd21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("38d7bd4e-4ff9-4f17-9432-697d3d401e07"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("38df8a62-c3c7-4051-b3d8-fea09276c2af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3927e6c2-0715-4dbc-9c2d-27635f8193c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39a147aa-bb30-4f1b-ae24-8e19f84958be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39fc7af3-fca8-455b-b0b5-49439327a823"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a7f36b0-d418-4ce4-bbcb-ea2f1e55383f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a892f75-15ec-440b-ad6f-459e085ecc06"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ab34d5b-d96f-48c1-b378-f078d9fdbde5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b0a2bbb-c3d6-465a-8b97-f634cdda8016"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b1eca25-139c-4fbd-8461-398bb3331163"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b2284bf-7d3c-478c-9859-092fcb26f3d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b5cda15-2ef9-4f86-9d10-88d180b3a794"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b636552-cef4-4f2d-9f74-2903e8ed21ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b9205a0-a84f-4c41-bec6-7cfa012e554e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b99433e-8330-4c27-a824-6e4dbae4f0e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3bb9227a-2dd0-485a-961b-4680501a6e72"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3bff5d92-ac37-402d-975b-fb853f5ed90f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3c2dd90a-d5db-4614-a8ef-c88e87ac10d4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3c5235d0-957f-4b69-b685-298f6aeca90f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3d14e7da-4e63-420c-8833-b16bd55f6cb8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3d9011a5-cc2a-4baa-901f-2306957507c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e2b2923-c0d7-42f0-8415-4e26be0d2a53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e43e173-0328-4290-895c-4a7d9138e6a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e6e5c93-0afb-43ff-b079-c8d99dbfec3d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e926c96-dcfa-4bcf-acf6-35c02608385c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ed776ef-f4f2-4d01-be38-34eacd766995"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ee5d198-de83-497c-abdf-8c909f00ea5c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ee898f4-1609-419e-a434-f1b9d5370a6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3f13c62f-f228-4b8e-a28b-c15fe5b46b78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3f457203-6f77-4b2e-9491-62dcd7a5d32f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3f566049-136e-4451-9f81-1f067ad3d88a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3f828030-ae8d-4f9e-8670-3ff962c514fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("405117b8-f1e9-41e7-b935-2627b70bf793"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40762976-a37b-4501-86f1-57e66f85828c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40ab5213-22fb-47a5-83b1-37f3e0889c00"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40f30bef-de6b-4fd6-885c-7857e5ffaeb9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41a0f7d1-4284-45ab-9b6d-c0e8c74225a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41acb8a4-575c-418f-86b4-3577a6fa252e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41f3fd34-4fea-435d-b8a4-624cbeaa37e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("42205b86-4344-4805-89c0-1abfe8c51de5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4280a3c1-c5c5-4d41-9d43-2c30f6d9efd4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("42a59805-6eb4-4cc8-ae78-cdaff2d3fae4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("43194712-06b4-4be6-af68-0e08bc232d8d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("432a41bb-4113-4a1a-85df-6faf8bdc3d1d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("433501c8-7874-4e7b-a3f0-74102f686fa2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4340c0c3-086a-468c-a286-3e1a7f230d08"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4482307c-56ea-4420-9e52-a42987dfd416"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44e5c1c4-6423-4b03-8a47-22583685d54e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("450232a1-1cf6-4949-b693-7e3e95f2ac1f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4555c0b4-77fc-4853-8619-424b16dad0de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45a5cf8b-6ffa-4542-9ed8-6a616cda4c5e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45b18040-eae9-4676-a312-dae7cbbb580d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45c8e7ac-7a47-4c40-ac5c-8abbc482cfac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("467a183f-2b49-4675-b275-7c686fbf3215"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("46a6baae-ad9d-44e4-84e7-351863941560"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("46c39e77-122a-442e-94af-c697bb322a1b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4755226f-09ca-455b-b180-fb99268029c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("47c3a62a-e3c5-47f6-9e61-437661cf0643"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("47d657e6-6496-4e16-a908-72b76408daa0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4851bb31-985d-43c2-aad7-587183ffd964"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("486105bd-a84d-444d-b7d3-d2dfb250a804"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("48f63de8-f520-4c07-96b4-4db57f6b6cea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4923d7a0-14dd-4e1f-bb52-70656028fd6f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("498d5cfb-6fa0-4859-8e86-00dbd4fda8f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("49987883-3aef-4572-b847-329953600402"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("49e01e1a-6d53-4e6d-901b-36de7878bd52"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4a57400c-48c0-43de-a68c-72fbd8cae1a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4a84afc3-a089-4f94-b95c-4e45e96c96a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4a85650e-0a6c-460f-88ec-db278dcac6e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4a9f19c6-464f-4235-829a-756d213cfdac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4aa9d0e0-d96a-47a5-a93a-b2afb7210179"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ad4c062-2433-416e-ae6a-d650df80e4b5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4b22eba2-3e1b-47e2-b15f-94c4dc6c5a75"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4b2dfbb0-3df1-42c7-aed9-9ab7becb9799"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4b2eb7f2-5fda-44ad-9fbf-9f848f73ebfd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4b3666b3-8935-4ebc-bd70-9ea2332ce0cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4bc28402-016c-4b77-a624-23f4533b0d6e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4bd1f362-9737-4178-a0f2-3576315fa884"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c697c7e-c1b3-42b6-935c-c4dfe306891b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c6d4f66-49e3-47f2-9605-6e83bfefd519"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c7e32bb-62bd-41a9-8fae-e307d263b386"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c9b06a5-f9c5-4d41-8f4d-8a70fa7cc7c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4cb790f5-8d1e-44c9-b26c-b841b7fea4f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4cd8b8c5-89af-4496-9d96-2b9f58dd0547"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4d26ed86-6b15-4901-9101-ce88ac0e8626"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4d33c2d9-2790-4e5b-ba76-589b4c750c77"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4d641585-fd43-4b09-b0c9-6a3fdc5fd743"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4d734a4b-969e-4572-9208-232beaddf070"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4dd5e362-e7ae-4266-87a8-d5c32d388039"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4e17a482-6bfa-42a1-a353-662923ad112b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4e1a7978-ecc9-4e68-839b-36943e066887"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4e6e983b-370a-4fe5-a26d-86a62728a579"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ed13bd1-4c04-4380-8ebb-53da1a1e848f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4f10aeee-21eb-41e6-8c27-1cf6cfa1e81b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4f8be2bd-52e0-42df-94d9-2a1e9ae3cd83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4fbb3077-dd54-44a7-8c9d-2531497db2ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4fe5f7df-60aa-43ce-ae77-860f3b197f54"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("501ae11d-32a0-4cec-bd3b-571fbbfa1593"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("502a493d-6196-4ef4-89a6-8d794fc8f2e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("505fbae9-7def-43e9-b6cb-8ad93c64cad5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50850cb2-c22a-4227-bf38-a9508213a127"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50e15808-b0b9-4dd8-967a-7c0e45f5caa9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51234dbd-8018-42df-a571-51722b57978d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("517aaaf1-0ddc-47ff-bfeb-80a58f00a282"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("519437cb-ad9c-4660-8424-7bfae5de0b28"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51a78cd5-4e38-420b-8dcb-265995a67ddc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51d42ca0-be38-447c-ac12-f2bc01ffde12"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5206fe0b-4ffd-4559-a19c-d21855706254"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("52143010-da91-4a93-8623-9ec29de435d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("52bbbc09-7641-4eca-b283-945d328f1bce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("533da057-8aeb-43a6-8b55-db15d4f6c4a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("53dfc636-c1cf-4170-a276-7e58ab48c8b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("54685fa8-666c-43c9-ae5c-096602401666"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("54fabec2-1fcf-4067-ae77-7b60acccfc97"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("551d3c2f-c0fb-4daf-9160-bfb20c3ec979"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55396d14-8367-45e8-858e-2539054272e1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("553c67cf-521f-43ad-a34b-3f437f298906"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("556bc190-bbff-4bef-aa3b-40a32c7611b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56ae5f3e-9b65-467a-a587-c9ea67317cec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56cf2000-f39c-49fe-acd0-e90856872127"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56f0cc43-f17e-4ddf-a70d-cea63c5fa46b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("57480253-73e3-4487-9c67-8917963e4120"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("57a8d55c-f482-4c3a-8720-46228817e5c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("581e21bc-37d5-4b0d-8cd3-5dff3383e02a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("583a77fc-1649-424b-856d-66dd9d84f22c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5858fe85-6223-49a8-bb6c-bb6255befc2d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5897080d-cd92-446c-a527-638173986487"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59c7e0d2-0fbd-4735-966b-c9b7af7e167c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a440bd4-5124-4b50-ba57-137b689c499a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a7b2848-ed85-4139-bd71-ce680ad5b7af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a90bc00-50cc-44ac-86d2-18ca08a3cf25"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5aa9731f-76cc-422d-ba4e-7dc338af1d18"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5aaf3f78-c9ef-4d74-b790-46158ff88e27"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5aeae7df-abf0-4da0-823f-89cb7b37c4aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b0f6e59-1ab8-41bb-bbe2-6f2d2aa6a975"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b1893f3-d41b-4cde-94a2-9d00bf5f88cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b8519aa-7209-4238-b098-f08dc026a122"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ba7f9df-3e4d-41d9-91d0-18d4d7c7a497"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5bad744e-4044-4af1-825c-3f69f2532b16"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5bfc30e2-48fa-4ac4-a6e4-714232e18d32"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5c001ba7-cced-40a2-b381-bcf1968a78e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5c0d5ea4-ed5d-429e-90b4-9e3f40656eb2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ce1beaa-330d-4af9-b8ac-a571d84ae2e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5cfb43b9-f8a3-4f27-b420-ad4df45bade9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d6a01cf-5046-49a8-8ee0-79fa68302031"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d70cb87-78c7-4490-8886-6e876b545308"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d8e2661-b830-4975-bff3-518316cd66bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5dd47259-472b-4abf-a129-485d6741f2e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5defc6d5-14d9-4155-b792-5d2b439ee333"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5e967cac-236d-4716-8340-13c34a008fac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ea61eb5-283b-4a22-9342-25b72705d444"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ed648a1-5f3a-437c-8fa2-a83cf3791bc9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f300404-1059-4c95-bd9d-e18632eb47b1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f5805a6-0855-49a8-928a-b21734348057"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f5f95da-9812-4c0f-9296-e5c862bd4ca5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5feb4f64-fe64-4370-a9d4-1bce2ac7d628"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ffb3029-b929-4294-a2ec-e5b5ae939cc0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6017e759-ab7b-4301-9da6-2ceac4b91087"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("60917991-1ad3-4246-839a-7e02974cc744"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("61652dec-0aa1-4f42-a7a8-34622fb62c2e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("61916ad7-4e72-426c-a1b3-3e2539539081"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("61f201a2-4dc4-4371-9963-c37d59d04e55"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62394659-d186-428a-b09c-dd51d76f15ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("623ff6b3-f424-46c2-9df1-220934af8b05"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62503455-76c8-4b8d-ac90-fa60d0620b01"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("625fc6fe-7941-4fb0-803a-fe99809b5a13"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("629c902e-1b81-412f-b302-ace999223e66"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62cfc471-ac01-466f-b252-a088eec0f265"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62f023dc-a4e9-4332-bb5a-2be3b4f86a9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62fce807-4bc5-4f6e-aafd-5215c4ed6c88"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("63399667-5a02-4ab0-9573-2557ead0d64d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("63582fc0-868f-4306-9d1c-0007b9a8208c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("639aca41-a8d8-44f1-9f30-11b528ad6c19"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("63f10d76-43fd-4482-81d4-8319d655eb01"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("646ab336-31f6-4f83-bc2e-c57fcb90fd36"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("64a7ba47-9b40-44c5-a740-8f835cc455bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("64fb6b4b-9ffc-49f7-9517-0f90d9b9d6f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("65466459-593a-4a02-b9bb-219061944186"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("656187c6-8ed4-4650-9045-cf7271758397"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("65bebffd-b1bf-456b-8be0-7863aa1124e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("65f779ed-85a9-4e34-9cf3-39e9a36f8d1d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6625b936-5619-45be-9952-5609d7db15f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("664f01fa-8bff-4778-8ac3-fa00881d571b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66f724f2-db1e-41d2-bb24-8ef60fe69164"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6717e73b-de86-4cb4-8266-b753bdf64ff7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("67755393-0ed6-42b4-88ce-c97693e153a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("677a6f6e-5f7a-441e-89e2-b2226234b80b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("67d762b3-8e17-43b8-acd3-d4bc42a21943"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("681943aa-4e97-4458-8ecc-a23a13b381b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6860634b-add2-4d17-864e-840acd4fd52c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("688b6bef-0a85-4790-9e85-f69d8bb589de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68c167f4-5ad5-4003-88bf-baa4a5dd1492"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69459e59-c4d5-4c1a-bfcc-3268893025d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a0297d9-7fd2-423b-b657-9d3676eeae65"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a293db9-4e9d-4913-9b7d-2795c124ff35"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a2ef470-60e2-4f43-a2ad-fd01da61aa21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a60817a-d59f-4bd1-aa3a-967d629f1322"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a9fe7f3-85fe-4d6d-b1f5-78093f7e25c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ab46129-c49d-49aa-b462-13b1a333b37e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6afed492-6be7-41d5-bc52-7c216856283d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6b612c78-aa69-4edc-86c0-6919bcaa3660"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6bb6a3bf-e268-4cf6-b742-14d9a628c28f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6be37639-4692-4981-8d87-a7f3ff05a019"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c0ea081-84b4-45a8-937e-3cc94cb8fcc6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c37128e-c82f-447c-a089-f75c911f4103"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c757c04-9083-4220-beea-b7cd437d3796"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ca47f3f-05f9-4e22-9544-8608bb5e32eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ca62912-b098-4188-a162-7b780a128b08"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6cb669ff-2759-43f9-8407-90a1a9153e2c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d3a4f9e-18df-4e1b-a528-7041fd4d171e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d6de9c5-f3d6-4c23-bc71-7eb1ddb283a0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d9ee6ac-3311-41ba-882b-8861e283d477"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e2a3029-bac1-42e4-a022-6aaf3fe798a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e573545-0010-4ab5-8275-780a8835bedd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e836c38-64b8-4502-ba4f-6c53f78f7800"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e8f474b-0a22-494e-bf96-c0b91ec14671"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ea38b83-1fb1-47b2-9cf5-1b283518b713"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6eb7fa61-a9e9-4ce0-be4c-0d81115f125f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6edc5bf7-290b-44e8-8323-bc748043d775"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f4b52d6-fe96-4350-aa28-483a6b6a1cc4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f4fc7e6-4131-4092-b82b-8237ebfa817f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6fa1d370-0d6d-4752-a696-22d215bf11c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ff50aff-5029-4fde-8fb5-6fd373500948"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ffdf97c-ba3a-4901-bfc8-fa0698e8fe0d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("70190a80-4edb-482c-a569-b3b47fd909c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("701b6bf3-a33b-496d-9eb4-0fd0ecfdf297"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("70b9cb06-dd7e-4923-826f-527c145b7de1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("70bac3a6-08d3-499a-ab47-3c41c2f00de0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("70bfebae-e888-44f2-9a3e-22a975918075"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("70ddeaf2-d365-4742-a401-218e94ac8d1d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("711dbab0-07b2-4085-901c-cf44ac7a7ce9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7147e926-cb22-46a9-bb5d-a9be2c4ea102"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("720874cf-feb4-4e58-a2ac-d8eb56141c6f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("723f7ee9-dd39-486b-85b0-8e0b15f35223"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72482586-0d6e-4ee4-b268-368cb73dfa37"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7288e78d-fc21-4329-921e-36d0138cfa49"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("728b9bb4-f2b7-427e-9106-453b1ae45a29"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72b51fdc-422c-4ce1-a4d6-d605783c2f58"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72cc196d-59ce-4f6e-9c14-0870d76a5c41"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("736a3c71-bce1-425b-8a24-ef3a31ef54f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7377e43a-8b83-411e-b077-d6cec1ceea61"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("739544df-045c-427f-a3cc-9559610eccd3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("741d112e-0bc9-4cba-a836-6f570988daa0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74629e44-0105-4109-ac0d-2d4ada5985d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7467c5e3-0b25-438c-a83b-b98a3c278b05"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7480a4a2-fe17-4d9f-89c8-0976ff87602b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("75b064e5-a6b0-40ba-aa4e-90e2a99ff716"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("75c29989-cdba-43b3-b6a5-c63e33e2923a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("75fde20d-735f-4b13-9f9b-2c11feec8c73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7645dda4-4acc-43f7-84c2-b9052162e820"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("76f4c25b-5c5e-4ebc-9ef2-bff8ab9231b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("77593a24-f093-4a47-92db-40fbaa0d270f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("77c8d2f2-2279-43a0-9525-56c0505b143c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7815ebf3-92cc-4ac0-b946-a9cbac29f5d2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78f8de76-1157-41cf-bfc3-45921da65f28"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("792d376e-f482-43e9-ad18-130e482cdc54"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("79c05f98-7fe0-412d-9846-cb97f33da800"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7af3414e-f68d-4382-b076-af94c905ca62"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7b79bdd4-3932-4a7c-83c6-be05295e3638"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7bae3a73-53f5-484c-bf19-1cd901ff2655"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7bbba1a0-d38f-4872-bb2d-9cf7beec4bcf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7bbee3cd-b307-4dfb-91bf-2e6e94e53677"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c554dfe-beef-4804-9514-4cfe411b1771"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c57d68b-0ee7-4cfb-9536-21484d94ac44"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c71d736-1a71-4dc7-b909-61c13489fe82"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ce2df2b-e938-4ea0-8bfd-c6b3f1bda278"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7cf4f3cf-8914-454a-9c27-59d93bc91764"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7cf6f263-77b4-4462-9add-34e3f398122e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d6936dd-d36a-4596-b461-cf75423dbe00"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7dbed169-1952-4e5f-be21-9fe681d62481"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7dcc7cd9-dd07-4f92-b2a7-583beeee5ecc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7e80a1d2-30d7-42f6-aa00-83e4812e8c60"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7e908f6d-fc47-49b4-86de-9fc6ffa984d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f1b8a1b-4fb3-4ded-aa4f-080fd3f402ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f2288a4-fb28-45cb-9c98-d242a88cc9b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fe1e71b-b144-42f5-8093-60abb0ee7651"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fe7f8a4-8a13-4a23-9aa7-e8d6fd3e05a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("802f8768-7fd8-4aad-b5fb-789d6e6169d4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8082c47a-6d5d-459c-b443-1b62664aff53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("808e6fd5-5f49-4290-8c11-db277378c2ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("80fd0b44-7c93-4cae-96a8-b25ab14da976"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81502e14-8463-497e-a935-ddf854d2d8b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("818d0750-757b-431a-9382-66703680bfca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81900fe4-a6e1-4238-873c-1eb3ac0e2e89"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8218008d-4aba-493b-88f5-e9b5e38bbbd2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("823c1dfe-afe9-4dde-be28-811c9d9e86a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("824efe8d-8e68-4f76-b9f9-2850156c3a63"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8272d831-f939-4f98-a53f-75a6c0ae4061"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("829bc44d-2141-4503-9cf7-2a4a0109811a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82effdfc-29e1-477f-af32-3e3a7526f613"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("83453c4f-46cf-464b-a931-27e2be753fdd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("834f664d-43b0-44f3-8324-b2946091c875"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("843f2fbe-3abe-444a-a35a-44e8edc5ecaa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("845c0a46-d6c7-4644-bf1a-8346f16e5e90"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84845907-d0dd-4a62-a9a9-c816fc811006"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("858bd144-7871-4325-aae4-c3e22499251b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("85b470c8-8eb0-42f1-929e-bce1cc80530d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("865890c9-4f59-4428-8c45-a829d781bf18"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8661537f-5595-4026-9c53-e7774cc86088"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86e0eb2b-333a-4469-bc60-cac091424f7a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86e19994-9671-44e7-b1ec-9c6486eaedaa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86e35a67-86ff-4e44-a144-c2632f798f8b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("870ad78b-3f01-40fa-8ed3-c8d6f7194fdb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("877b6cf0-b613-4b62-b9f9-928778117b8f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("87d3f9b8-0daf-4232-b00e-eaa5e529a3aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("87e53189-cc87-4aff-be95-0392fb2f4ba7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("87ea53c0-d6bc-46a8-8bd8-efdc1785a857"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("882cd351-e85a-4bb9-9554-4ed123c042dc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("88567553-a677-4976-b434-36d37323e8a0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8914df3e-6064-4829-9cac-37f30b4dcbee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("891795f5-259f-490f-9d4c-0f87c7e3e383"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("893a2d6e-4b35-4c63-9347-5e1caf6ab160"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8949285a-365a-42a1-8c87-874c162f5e78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("894efc74-84d9-401e-a93e-de51f43bdd96"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("89576a64-b040-4f3a-b3f9-26a924fabaf7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("895c1362-9068-4cec-8bfe-a246d79b6bfb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("897d324d-af26-43d2-ba48-74c061825f2e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("89dc45c3-79a9-4115-aaa5-900cae7eb423"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a15e11e-73e1-4cba-937e-55f0dd2ee453"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a25e941-2bf7-428e-b6b4-3c53a37ee79f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a54e45b-4f3a-4e4e-8848-375bc0d0473d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a5979ef-df31-4486-90a0-38c4c9061c3c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a7e29ff-b77e-443d-960e-4bf5ceb5b6fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8aa63380-10a7-4c17-817e-a897e0a77175"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8abdd8cd-7f2e-4458-b08f-e3109dd08f47"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ac801c8-ea0d-449f-adb0-6be2110fc93b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ad0bb92-ad5f-4ce8-9cd6-8c62d8b7ade8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b08b79f-422c-4f3f-8452-966a0f6952af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b3e1833-0097-4605-a67e-989a260be2fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b871525-2d24-4b9b-bbb2-34f66f4c36ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ba0bb30-fac2-4d46-a618-5f6d67204988"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8bb9798c-f06d-4c6a-be63-ec503c802c33"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8c9f07dd-534b-4368-94e1-cfbb9f5f6bd1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8cc6905c-12f8-4d57-b78a-e1bd3438e44f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d26fda1-37d7-4846-aa34-9dd8772e8e20"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d3e7f6a-97cd-4a85-af5f-915d9d6e2534"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8da0a7dd-ea8f-4d43-9134-e70c511ecbfd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8de36915-a57f-4f07-aea8-5786079dee85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e34ade5-31af-4bff-b680-6dca00ab1f72"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e472c79-5e52-4cbb-ba62-3e52053055f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ed3566a-f085-46e9-bbd5-8a327f96f06d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f6d64e7-b364-4f69-b8e6-2a3ea5988c21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f90ae04-ffb9-4be0-9435-e526e1eee112"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f94da87-da62-4013-b24e-dc0b5b1fea79"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8fff73c2-cdf4-4787-86e0-7085995e7116"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("900ffcc0-8584-45c0-927e-62caf6ca9fdd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9016e3be-b4c4-4a3f-b78a-0dbfe96fd1e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9045a202-2077-422f-916f-6562237df2af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("90aefeea-66a9-437a-9bf7-1566fd4753cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9114ba5c-8388-4544-9d5c-ff6dbfb48e51"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9170ad8f-b297-4b9f-8c97-8450614946ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("91c422a1-bfec-48aa-b8ad-24b4ee3658a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("91c72b70-1ca7-425a-8de0-fbd3d4787657"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("921f8600-db35-4b50-9812-396f3368d67a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("92254204-371b-4d44-8b22-2a3be9496580"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("922b4f1d-ee89-416c-b0e1-e16b46b957d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("92953faf-6fc5-4f30-91d0-e98a9fced3fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("92d11b84-5929-43ed-88c5-e8a3729e74d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("93172122-8f80-466b-a853-396e8309e26f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9357f0e7-0c60-44e1-9639-cd344d9118ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("93582320-3c74-4ea3-9602-c01a1a69af73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9365e701-777c-4be2-840c-1302e07c6d1b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9404266e-0010-4726-a5f2-38ff290639a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9446996a-3420-4c7e-9c54-1b18204f25ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("947eddc2-0587-47a0-afd0-efe0ff9a1196"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("948f127a-a52f-4104-9712-c863236b6e3a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("94d694ed-8ef1-4595-ae2f-66db1802420f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9537d123-31ba-46ad-b9b9-ac10f84dd03d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95a18610-e41d-4ef3-befe-daa5a5a40242"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95c2fc90-d362-4394-b322-c794befb583e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95e6c9fc-080f-4074-9507-5e9566957510"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95f040a0-a33c-413b-b253-f5c9c2b663c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95fb6a77-c5c8-423e-a684-bc4e924ae5c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9735c764-2f8d-4d9a-abad-0656a5188760"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9790a898-a015-4808-8ae3-9792c0e3e37c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("97929a63-a532-496e-b027-28f37be46722"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9796ec37-2d15-48bd-a655-3fc3256636e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("979b737a-ef19-44c9-ad73-5733ada4b2f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("97bba113-60e8-4ad7-917d-a88e7f0be9e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("981e3c76-d320-4983-87e4-4979cf1f8ec5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("983f3e16-26d6-4b36-896f-b781db8fafb7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("984f5f51-3968-4dbc-a49c-153b52044494"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("98e11692-e388-4aa4-b18f-1589f0e01d7b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9987e637-65f8-4650-8041-48011f2a2afb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99a1f8a9-4d97-4cf5-8c2a-b4bc3318d710"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9aa26026-0232-4102-8010-1e891fde02d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ae7bed2-c21b-4a45-b593-97aa5367c255"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b9f9705-e827-47f2-94af-44b04504e04b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c41b425-817a-459d-ad68-a82af9472109"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c5bc101-0931-4823-99b2-76e4b560a6d4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ca6ad9a-388f-483d-ac24-f46613ff7367"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9cebf19d-8dce-440c-bf9a-4b147ef5df34"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9cfe59da-fc65-4e4a-8cf8-6f67e40eb81a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d1bba44-2f55-489f-8f08-add6ca2a9c99"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d2a15be-46af-4836-be8f-c07496a45a25"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9da98e2a-833e-4e6d-b287-dbb6f2978ee9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9dae930e-5eec-40df-a30d-8f051ad3df61"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9dc4e616-ed2e-4d88-b135-8ae46607af02"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9dc53543-68f3-48d6-b8d9-641d4afabb41"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9dd51c24-8cc4-453e-9e8b-c5a31836690f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9de6f6a7-6e93-4d91-a244-8dacc4945850"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9e0f6bca-d6b5-488a-9e8d-6fe91db20126"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9e1d31e2-4ab7-4561-b12c-616c6b5fa04f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9eaf43c1-c345-42af-82b7-9b7c0bb241e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9f1ff516-2b35-4d1a-a5e9-f22dba22c649"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9fb90baa-1ed5-4c59-a3fb-7314a3e98596"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9fe4a8b5-3c4a-4782-ba84-8fcce5435855"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0164e1e-44da-4cc1-8a5d-a79e68dd1256"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a052a009-f9c6-493c-a08e-653dda156cef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0854eac-285a-4dd6-b96d-8ccc859e5686"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0d99f71-4d6e-4d3d-9cb0-db36475adba6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a127e4f8-e699-4c67-b36a-912caed453bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1bfa1cd-e503-46c6-97b7-8adcf5b50542"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a24605ca-5548-4834-bd9a-1ea589762a0a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a27d638c-2e0b-48cf-b7b6-4950dd57d0ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a2aeb5ca-d75a-4a33-98bf-835161b01eac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a2af560c-5426-4e0f-b202-35060c72bf68"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a3a776e4-7c8c-4343-ade1-482719578c43"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a3b68817-44bb-48a4-8176-4b748ab58326"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a598dbb4-4380-4ac9-8373-c18fb199074e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a64e9e11-29dc-492d-88a3-a928f2fd58c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6aa493d-55ba-4895-a6d4-a79dad19cefd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a74b4ed0-75c0-4e81-bd37-8f4c5c48694c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a76648b7-007e-46d6-a48c-463335cd758d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a7eaf24b-72c5-4863-ba74-8911df2c42dc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a892939f-5289-432d-93b4-fd39db6beec4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a89b3067-54ea-4c33-a9a5-da7a60f900bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a8ebb5a9-aa38-4ee2-99a0-54a98faf5b05"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a8f44631-441b-4ed2-9d12-da237562cda7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a9192418-a15b-4b6a-aeb9-69bb448cdc3c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a9b3b68d-9180-4f72-a041-7750e4414f41"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa968236-7f24-4cdb-a145-e876da500420"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aaa91f73-212a-450a-b960-c633d29dd923"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ab020f81-e806-4c15-8af6-6fb61792b49d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ab1d06b9-843b-4c85-9232-39287ae0b4e1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ab25e064-fe29-4adc-9671-e8f25e42936d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ab7a2926-b766-43c7-9903-6d536f024c66"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abe79655-122b-4dbb-9342-a5085eeaefb9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abf55415-769c-4b42-94ad-a7518615990e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ac7def8f-55a4-47ff-a3bd-0c57f6272b15"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ac7f93ec-e4d0-40af-827a-3a3f6262e9a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aca8e557-25b8-4610-9342-a3e3dd2467f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("acba2bc7-fb0b-40ca-ac09-13021db0b69a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("acc06dfb-00cb-43f9-b930-b59cf94898d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("acee2b57-558a-4191-893e-39b586f610e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad2db7ad-dbd3-4d51-ae44-0016e5db3f69"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad3d7445-e6e2-4638-8241-309b3d9590f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae525afa-6c86-4d42-8289-a409694002b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae5ef77a-12c8-4099-8068-afe21bc3c269"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae83279c-7c2d-4414-8377-19048b1c8691"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aeca7553-57b8-4995-96c0-50e4c9b8681d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aee39d7f-b761-4fad-ae9b-228773aac649"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aee3ebc2-eb8d-4e28-8e3a-47934b549e0d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aee59f83-e02e-49a9-88c9-eab5e66aba03"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("af77ee29-ca81-4792-9bc7-2ff037c99e47"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afada25d-3c6d-4b59-a63d-63cf323edf79"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afb98318-0208-4e38-84c7-015bf39fa2bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afc54e5d-767f-4e9b-adac-66c6fff984ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afde3a69-9665-4f99-a506-b4165fd0c784"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afee4df2-3dee-4587-b055-9524ebd3876c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0163944-dbaf-4ac6-86db-9c5d00450c41"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b04ac5f7-7a99-49e2-862e-9e8232bed384"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b079ce6d-3a8c-47dd-82ea-7371a577950e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b07c4ed0-0dba-46e7-b06d-1a1ac2b29c4d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0ae152b-2897-47be-ad65-6ff7f90857ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0eb0844-05f4-4c0d-ada8-0c126a5029f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0fe6c45-de32-41a5-af04-4c7bff44b78c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b27f8602-fb2d-4ee1-b797-0d06308ecf28"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b2e293c6-a276-4797-b3c6-63d798b2f065"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3142530-89bd-4912-ad3d-b0f99c0ab9e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b33bb388-21a7-4668-916c-dcbb178aea23"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b380cd06-dcbd-44d5-a861-b5af1c0ed3f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b39b32e8-7699-411f-8b78-be89a298cfa5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3c27091-e765-4bd8-b7d8-3c61d834c533"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b47585a8-08a8-4eba-91b1-0b96b8507881"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b4e3ad89-5342-4d51-89f8-e35b78825197"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b58b8450-6e98-4d69-a32e-66288d17320a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b59bf289-cb34-415c-acc0-cd58331f28c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5fd2feb-517a-4827-a799-795bc9d8a2b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b621331d-2e13-4ab8-a252-8d2123a5b1a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6ad0c57-8dd4-4345-b337-27007f0830ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6adf0bd-bd97-49f6-be43-992351de2240"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6fd56af-5802-4b8c-a85d-86629d70a334"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b73ca8b9-71b3-4d55-89b5-f82479fdf52c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b75049ec-aafb-4eca-bdd7-4a27a3eb7694"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b75ebf98-5ceb-4608-a55d-14feac81e72c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b771338a-8b43-4d82-bcfc-3965e00f6bea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b776a98d-36f9-45a2-a988-e0f32bce1c22"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b7778b02-891d-45d9-af77-7475b35ffc2b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8181062-9584-4a22-bf3b-4ce71d3a6787"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b81e445b-0a24-4c36-be04-45598f9d547b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b85f3a78-48d1-4697-9d4c-46220c36dbe3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8c664ad-9141-4647-8d9c-a081030d41b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b956acd8-597d-4e83-a2ef-c352d454caaa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b95eaffa-d791-46b4-8220-a41399550ff9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b963cfc8-dd31-4734-860b-0ce2109b3bfc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ba26472d-bcd1-47de-86bf-a8809bde8130"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ba77cd55-234a-4680-a7bf-909a3676e09a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ba926183-b045-4c25-87df-9fa6cce6b4d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ba98f33c-be01-433b-9062-7a1b394ab298"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("baffbc5f-475e-4185-8455-05120fe73bd8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bb22e34a-5a61-40e5-8fb0-ec4034a81ae3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bb7fe048-7620-4f67-a770-e1fbcce11daf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bbccf667-e4f7-4dd7-a37b-abeabeb77d11"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bbdb3db3-bb3b-4cf1-8f15-f9e53c117d02"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bbea8020-5a78-4a80-84cf-f03d68b25187"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bc2c1a3e-1512-462c-9560-44b06dbf7d89"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bc58efc8-8025-4b36-9967-eacac1d7e822"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bc9012e8-7d6d-46a6-a435-f340b84fc7ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd60cf75-a7b1-4d38-b8b8-77cab6153dda"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd701825-b30b-4bb0-9bce-095791806fca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bde32bb5-3d9b-434c-822c-18a616c12f15"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be009857-5bec-4ffc-8a29-1787356dc983"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be8a8bfd-2d6a-4512-98d3-eea370ecc0e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("beeea68b-de00-4a37-bbcd-0e5abe343fed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf5ac720-9e56-473b-a290-4698e5b7a107"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf7f8a1f-1c42-4fd4-bd20-b0a0e363634a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c00f505c-87c9-49cc-989c-f78675c7f4e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c0506dab-2d1b-412a-ab25-7e12ae3f8bc1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c0bc5d95-e5d5-4a89-bea5-349ea2b4f17d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c108a708-8b1e-4569-9dd3-fadeba2ce862"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c125ed1c-19a9-40c2-aef4-b87355a01d21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c145648c-0877-4f49-adc5-8bcf870487b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c14bf796-977d-410a-99d6-07309107ea66"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c15a011a-377a-443a-aa34-bd8a0432b56c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c160aa4d-8e67-4b9d-b2ac-02b1164b91f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c1a25035-fcaf-4b12-a357-d7c1b171a1de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c1ea9ad0-ad3c-4e2c-be0b-3f9188751484"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c255e74c-e34d-4f92-810c-e5be8a6031ee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c27b7f90-884a-475b-adb6-113a31507ed4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c2af85d4-4d8d-4e55-9570-16e87a61d79b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c2debdd7-4984-48d8-8993-974fa5887458"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c2e01496-420c-4925-9fa4-5aa77ee8f15d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3155d06-ec0b-4a75-83b3-e5e97e2e92e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c31624da-198d-4613-99c1-090e8f207114"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3b01ea1-581c-4fad-91b3-8399af6426f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3c49eb9-15b0-4bef-887e-df043c77ae16"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3d9420f-7d69-47ed-b3b1-d64506af28cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c572001c-2eec-49bf-b94d-a80f61cc231f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c573fcaa-1d4f-471d-8cad-70524d4e54ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5b72af5-6da6-4ef0-9b9a-542c68aaaf31"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5cc784d-4fda-408c-92bd-98b6f4762202"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c63d8437-f4d5-4b6d-b5a7-ba4302983cff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c67c4545-f873-4e67-b322-2dbe6eb9018a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6f95904-3824-4476-966a-680dea12a908"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7250613-0bff-47c3-96a4-2337cfde6525"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c78b533d-1233-42e8-b965-b81a5020cc48"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7b384b6-cfa3-4889-830a-e6b170825d37"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7ccd63c-bf64-4d61-ad4b-865b378d33ee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c85fd815-8d9f-431a-ba2d-10df5c9186f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c88e1a54-56cb-42ed-93c4-21cc59c06357"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c8a2de6d-1fa9-4b53-9c36-18edf7de0351"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c8a8e3aa-a116-4906-9c7c-489e70e63653"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c8ccad2c-4904-4e73-9ee3-fe526fc99439"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c8d03777-7c82-48d0-885e-2f30c148c505"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c8d907f0-b279-4b2e-a823-5ee123631896"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c94f01f5-2301-4d9e-a4e8-b0913f3eac07"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c98cf551-f5e0-4ca4-9797-333c537b92cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca48774c-517f-4414-904d-f60851832521"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca8f3af2-29d5-4ef2-acbc-ee8237981502"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cad0e484-b725-4dc4-a786-e22ee67a6606"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cae52b3d-ab97-4d42-b197-d8cf136a3c49"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("caf75303-26f9-4e10-9b6f-f225167d6b17"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb0a1d73-519f-4c5e-b9e4-a2d2a179ad64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb34e74d-c275-4ff7-aa6f-070ea3c1be2f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb65d86b-966c-49da-93e7-47df482e230f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cbbafff4-b0de-4f6c-992d-eb7caf2194a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cbd5ade3-73aa-4eb3-bf0a-b4808f06d8c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cbd5ed52-3f97-41ec-a515-1e7d310536c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cc18067d-09bd-4de7-aaa3-a04cc8dec0a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cc976e44-84ac-4575-a022-d85d554659b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ccbdde1f-7cac-4ebd-b1f3-1b6e7fd2f2c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd4b0fba-b8b5-4366-8781-5682d3252b81"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd687ed7-b287-4e0e-b1ed-cb637c99ca29"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cda49cbc-c2c2-4ab7-accd-b19a0651ad37"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ce639c3b-c77b-4b4d-971c-b29aec77593c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ce7b0a95-96d4-4862-9bff-e155d4d89512"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cf549498-49bd-4c6a-bf34-195b61c8656c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cfe56994-f252-402b-8b68-24f36eba40ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d001f761-6f68-4944-9778-f99ec91c450d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0237fb1-6ca4-4f61-89c8-961830d0ddba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d03020c1-3d1c-4c0c-a081-019d04e2334e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0cb459d-22e4-4068-959f-92679cd6db5e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0e5b361-530d-4d18-8a77-de5ce508c5a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0e6e027-d4ca-4e41-b82a-2da4f580cdcf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0edaf61-91e1-4aaa-9f40-a309c70ea5a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d1236f98-ff79-4414-9fb2-4ccf1868a460"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d134090c-a091-46d7-b7af-9f453c2b531f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d16b45c4-297b-4fdd-9210-859205ccf4af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d2158159-718b-4be4-ab2c-fe394c1dc4fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d23f4ff3-3baf-4648-99b0-595349581ca6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d25ef427-fe78-4eef-8d74-6be85e3fea97"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d2803e76-94ba-4549-9005-9792a158cf82"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d327487d-2f53-4a96-8b5b-31ad347cbb61"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d35a8648-bc3c-49d2-9e8f-9d22e3182f49"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3aadc1c-066a-4483-b8a5-b8d18ad1b899"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3e9a0e9-1ceb-4297-8370-e2b32cefcbd2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3f35f5c-9520-4e49-a259-b74ef57b8eca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d4509c14-4d8b-4b39-8679-f04b6d3554d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d45ba68a-5ce4-43a8-884a-1e6355309f13"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d48eeb5e-a535-418e-90a8-82b871d59317"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d4ab8e8c-9ad1-41d8-8196-761b5aef3fcd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d520d53d-3401-421d-a535-2b06a4e93ba1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d57862b6-299c-44bd-b2cc-8a6e9f8d4fb4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5950363-f61c-4d72-bd5a-88588da3338c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d63e67b3-f12d-4a5f-8681-19b7abb44f46"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d659afcf-bd17-467e-a04e-7118b406d386"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d66431c4-cff8-4972-b42d-a2b27e2031a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d67206c8-d644-4d60-a483-57d8d480826f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d73a7f44-3ab9-4a6d-9958-d8d6bca6f07d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d744d5a3-1c81-4ad6-a74d-10acd0320680"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7e160b9-5e68-4e7f-8aba-26474abbd796"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7e6a498-fbee-492c-be54-ee072dbc83eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7f9ce84-adc7-4678-b92e-942f8581c613"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d85b75bd-05f8-4ad7-bb75-65b6b704d04d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8762e71-88ca-4037-be81-9b66ad8032cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8c6421d-613c-425a-8f65-c99fca97ec6c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d9186fc5-9d6b-4b94-b647-7f035d29d1ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d9469bca-8e79-4efd-81dd-f0f9d01c99cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d9d61cd4-6c0f-4104-8ffa-6fb121e57ffa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d9e5f73d-8576-4f79-8236-65aadb61dff0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d9fb573e-3493-4787-9230-d90cd2845ea8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("da242a95-bb75-4949-9ddc-5991bc735f3f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("db642779-eb68-40dd-9c3f-e79a415f780b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("db866f37-d9db-4760-99b4-9665cc9a77ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("db96f613-0c37-47b1-8d0e-d201f7c2d087"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dbefadf3-1602-457b-a15a-d1fe03d4f975"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc023921-dfa9-484d-8b62-6124eb35e4b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc2efa26-7686-4a41-9f18-e20edb0f55ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dd083de3-41cf-46b7-b1e9-5aa288030f0f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dd648e4e-bbd2-4703-a64e-82e455e862fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dd70fffb-0836-4d52-8411-04b8089bbac2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ddb5b493-27ff-4c1a-904b-8039eb1a3451"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("de16a9dc-d7f7-45bb-994a-53391ed6f3c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("de47e808-bd25-4b55-a0d0-2f8debfa44da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("de57fe2c-b51a-4092-a6a8-2b9342059c93"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dea31b32-3962-4ce4-82fe-d45a6aa1e7ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("deb2b4f9-821d-445f-83a7-f857a9e2ee83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("df2a8e7f-4ac6-42de-8206-dfe01e38b0f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("df2d563a-a435-478d-95d1-6683b8ff1633"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("df5a3d1b-8abc-4ffb-a46f-56eebbdb8341"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("df76adb4-d58b-4e27-a390-dd97900c2899"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("df786baf-2ac1-45e9-8a3d-9aa3ae17f151"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dfa45256-c1f8-4e77-8250-0cc6c18ceb3b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e0c57aae-990f-4c68-abaf-7b6a68760116"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e0c8c960-bdc0-47e7-9ccd-42b8a4d0f25d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e0da940a-f039-4550-92f9-bff174dc164b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e0ef9556-184b-4e3e-b52c-4b279d1d1e69"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e179822b-c04a-41e5-9d94-ebe4d1b39c18"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e1fe4df0-898a-479d-873c-92a2c6a16bc9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e2412b7b-8b60-4b25-b38e-9ad29bde02eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e25cb41e-ce6c-472d-8738-3c4f12f59e0c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e2a98e59-f7b0-44c9-a881-719db1ba6edf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e2d56ded-d396-4798-a851-1f9959a1c780"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e2ee670c-f15c-4d78-bc29-634c56c59def"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e37033b8-a94d-4d4d-90ee-6ffd60289c98"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e428015b-d196-4b20-a38a-2b038511d2ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e466d813-d51e-439e-bfc0-9d8738efdd15"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4e4a74c-c494-4728-9543-a75f8cad1f7e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e51dfb42-04a9-4ec5-b00b-a9be59300d4c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e52cbabb-3873-4d33-b765-e32730f785c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5509e37-7d8d-42a7-bd71-8dabcfacaceb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e624e89f-102e-4976-9185-a2778193f62a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e6e768fe-634e-43de-b9ce-d4d7d2e3abe0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e710f9b2-f401-42b5-9a63-fc7c0aaea1fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e74e73d5-3d30-40ca-aa7c-113eca195f45"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e76b76f6-2d93-4c98-aa19-762413764df2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e789a8f1-b6ad-4d6a-8bf0-23d159e146bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e78c9aea-2b12-4d1f-93e0-3558be02d349"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e7a87b03-2f71-4bbf-9639-d4931a7d0c3d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8331852-ba4d-4823-826a-53fddc53afc9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e83ebea8-ed59-4561-9833-7f4c306280ed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e86db0fa-6ef0-427f-8488-b6c1cd2e0d55"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8c05f81-5be5-47e0-8185-e76e077bd716"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8dbe2c6-f71f-49ef-8d82-468ad08f8cae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e910eb52-1996-4b02-8a78-6e8c392c125d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e92efaeb-3155-42cd-9cef-92b51ce4aeff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e9862b22-6175-4de7-ba8c-f2046d9e8e5a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e9a7710f-7742-49e1-8dc3-c09f06165e2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e9bf04d4-5268-4219-b4b0-5920af05df31"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e9ed6a2c-7413-4256-82c7-2f87a49847e1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ea12d547-cea4-46ba-9b08-8ca86fc2c574"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb42970b-6a8d-4e60-a6bb-93df500ab167"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb69a70e-efcb-4f75-9ce1-f1d9ba5115ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb8ff028-68b3-4b37-a8e4-7b722797e9b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ec34ae39-0090-46e9-8055-2a737a1da0dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ec57a405-de4c-4573-9b7b-ec706e585ee6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ec5f30be-5716-4083-b96b-ab6741361f42"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ecca5b68-c6a2-4669-b91f-f3269ee534b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ecdb2817-cbfd-46a8-983d-cbac7421e221"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eda2ad12-89e1-478e-bf21-dca73ea93cfc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("edb078d9-b515-4597-b74c-e8868eacc8cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("edbcea27-1b14-4f37-a803-291135050c44"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("edebb8de-e881-45ad-a600-ab1640ff9b41"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ee46bf4a-4fbb-48e6-b31c-b760f2c52ba6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ee91a2e9-0c24-4425-9526-2fe5255b7887"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eead36c8-7a92-4f20-a67b-1a98ee5cf4ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eead4992-ba54-44cb-ba75-e6bc5d5d3469"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eeb6a02c-5082-46e0-a336-2cf0b0bddd7e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ef407ece-1452-4b89-a02b-428a8e47f7b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ef9de3de-952a-4c59-afac-197036095972"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("efb13e25-16d6-4fe2-99ae-1c743202b718"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("efbb482e-4f3f-4444-999f-326c73ddbc3a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("efcdf7ba-99d2-4ee7-a5f0-a162f8eadccd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eff49ac1-ed6e-4d47-837a-3756883b8f5d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("effe6f68-3c52-4033-b204-e1fe23bfe717"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0052410-ec53-44e4-a676-04fca80466c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f05b95c1-d04f-4a94-b618-ce79d7efd0e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0d7f213-1962-495a-9870-8338e748d396"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0eb986d-9265-4a68-934a-f700915efbd8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0fec2d6-a3c9-40e2-9d08-ec189bb99297"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f1216de4-d341-4ce6-9cd5-505da67e6df5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f14bced2-17cb-4802-80dd-bbd37df09f9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f1841b59-55f0-42ac-8b1d-936c3dd37176"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f1b88a7e-875e-47a1-8a1b-3dcd9fbd410a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f1e3a37f-2a51-43e9-9252-474e8d861a9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f23251fa-2f5b-4bf3-a717-633667d6a998"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2c6e414-2c02-408e-a9cb-f05ad2c436a0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2cf9119-e35d-43e0-8718-2ea84d382e0b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f39155cb-7aaf-436b-9191-1510c13a335a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f3c0e5d9-2aa7-4f4e-9d35-149c6092640b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f46800e0-deaf-4789-9c69-26e7dfc99f98"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f4e82359-fecc-4a36-8027-d654c50fd1b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5498a7c-ed79-4e48-b31c-4696c802f018"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5d0269a-072c-4541-8958-0e38b013d5d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f6463685-fc61-42ae-ba1e-058d1e10f8ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f6b60a19-cc6c-43a1-bf65-1c51b46c88c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f6f1bbbb-fbae-4317-997f-cb20d2694f1a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f75527e2-67bd-454c-a8df-0c7325da3405"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f75a73ef-3d10-4ce0-bdd0-443b8fe0e7d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f7b4d173-7d90-40d5-9fb4-e079b446f38b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f7c552bd-2fb0-407b-ae06-20908a7f5d88"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f7de0019-3288-4b27-8696-75e25c595de7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f8229b63-f8d6-44dd-b016-242c9e425dac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f885e143-cffe-4981-a2bd-2cfdb0e5024c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f97f4db2-ccaf-4aa7-ae15-5eb38d978643"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f9a59d33-bce4-4eb4-9d35-424a121ccd99"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f9e43451-a51a-40ba-b890-dd840ac06db0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f9ea55ce-e13f-43a1-bfaf-52f2e4b4c210"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa801dfe-4320-464d-bdb1-6af93f72129e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa8c7931-be84-4fcd-80ea-74bbdf611927"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb5af793-2b3c-44e5-8297-1d238df2c82a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb716b00-51d8-4bd9-adfd-19c231dc3695"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb84e6c9-2c4c-421c-969f-814e9c6372f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb98ecae-c526-4aea-8eb8-3e1a1b7d3095"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fbd1a728-c20e-4860-86e0-37b33e9bc3c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc0dda84-ab86-49bd-be02-849f9fba1e92"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc8f65fc-73b7-4981-92b4-e3fe126554fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fcfc9957-96da-4608-ac75-099901aee2e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fcfeaddf-391a-4373-9b0e-ed42e9f26298"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fd89ed21-b663-4e8c-b71e-3db5f7a01788"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fd8f6085-cc96-4b82-8578-9e2eaec25e88"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fdcaba22-3e25-4933-a729-68ff43afc2cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe0e1304-3b68-414d-8d2a-b76050bcf210"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe475de6-532a-41ca-87a2-a8b21d95877d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe5480aa-c37a-4e55-86f2-66ccbc3d7b79"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe66133f-e3a9-4878-ab78-2f453a7808a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fee1038a-2d9d-4781-826c-5c4dcbbe7737"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ffa9ddc3-a2ca-4556-b71d-9b5eefaeef2c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ffb91c28-b263-41ee-869f-c20e2192ea5d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("25915cc6-1693-4fc5-a665-c7fd3fd13b03"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e05d0d17-63d4-43a3-960d-86335d1573ca"));

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CompanyAddress",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "TaxCode",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Users",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20,
                oldDefaultValue: "User");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HashedPassword",
                table: "Users",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<Guid>(
                name: "SellerId",
                table: "Users",
                type: "uuid",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Orders",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SellerId",
                table: "Users",
                column: "SellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Sellers_SellerId",
                table: "Users",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id");
        }
    }
}
