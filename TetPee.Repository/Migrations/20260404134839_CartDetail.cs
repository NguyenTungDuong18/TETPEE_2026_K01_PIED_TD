using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TetPee.Repository.Migrations
{
    /// <inheritdoc />
    public partial class CartDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("12e11df5-6b30-4f9f-a0d9-b997d1af17e1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("78d98f98-4002-42fb-ba3f-f7ceedab9639"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3b69ae0-5c80-43c0-9873-8fdaf4d24c0b"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("101743e8-1bc6-43a9-b95b-8609414f7cf8"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("54ca6061-8aa8-46c9-9908-b9f9558901aa"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("65c0693c-8580-4c6b-82fe-b986cd0208a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bb1636be-8f4d-4a44-b8e8-fa6306137f4f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("005ee863-e1b9-47c1-8d24-ff150dc72fd5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00776e68-b440-4a37-9246-9ca528f1e099"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("01850874-5137-49da-8e84-56faeeecbb18"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("01aa7bd5-b3f2-433f-94f7-82d2014ae4cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("025cc720-7660-4d96-8660-8238e7c4e0da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("02bb8d4a-fb55-4b78-af16-77e90b3a70f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("02ce703a-7c6a-4e84-b906-cd1ef0979541"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0372657a-05d9-47ce-977c-a9785cf9c6dc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0373e5b3-b571-4c0a-82e7-f86af99dbb0b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("037ff405-9370-49cd-828e-7d425d64fbcd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("03889ec4-c4a5-4ad4-a079-458a69035d9a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("04113478-baeb-4ae0-894d-d7f0e168408f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("043e53b1-4c41-4b03-9461-3593396656e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("04725dd3-7637-4ce1-af0e-fb0033e2c948"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0483d32b-100b-4c3b-a1a7-5b67bf27518b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("04c011b5-86c0-4be7-9f82-1552e885250c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("052f5363-e85c-4673-9261-61ae753b58d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("05cce953-4e2e-4f49-a019-1773580058ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0654559b-59cb-4134-90f5-6f7d35db07ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0676aa2b-419b-4906-86c4-f5505c988064"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("06ab2392-7fe7-428d-82a3-3c0e96f6e19a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("06d8e660-12e7-4044-8dbc-d7a787c1c65f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07505503-c4a0-4c0a-8d99-2df1b8e9de9d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07a731a4-62c7-4332-94fd-5dc0ad91977a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07b43fb7-5aea-4c82-bb42-1efd5c08371a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07ecc2d2-9b0d-426a-adb1-fd8bb6301c29"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0803d97d-9c4b-4154-a56f-9d6ef9170b4e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("08334bf0-b095-453b-9295-dc26cba5a0dc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0882fbcc-ca56-48a5-b866-c6e19b6b3a6e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0892b260-e266-4e79-a3cd-41042f3d993a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("089cd38b-bceb-4035-a4f4-fac613983ab8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("08e485a3-46bb-4d5c-a1b9-01cebf940898"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09bb47d2-6465-4da3-bb64-a74af27d81f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09e879de-82eb-4955-90b2-b3d32091e352"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09f6bdfa-cecb-4e04-9fe7-2866d76d3c18"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09fe4256-447d-4a47-a3b8-3a62bc31fd14"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ab82223-57e1-4803-9138-e8ccd32c8544"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0abc7954-9c99-4ecc-be14-e923c178f5db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ac7620f-d0a7-423e-970b-9a1f2067a47a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b3d8da3-e3f8-4cbf-be42-b85ffada5b8d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b790495-f9d3-4cb9-bf53-d0b58c2f81c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b8a4e08-8da3-434b-ac1c-839ee6e04b70"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b932dd4-6358-4c75-995c-57c15fbeb200"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0bfd822b-e5ff-492e-b94d-2bcbea9e411e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0c596b9c-8fa2-4cc0-8b9f-13beb125991c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0c6f02ba-b7c7-4145-95d5-2c078d42bd4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0cd82ae4-c1ec-4f0c-a323-6b6720f274fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0cf9afd8-bac6-4af2-9b56-5bbd4c24a46c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0dd699fd-f477-44ad-8ee2-9400189e62c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0de66c02-ccfb-4499-a238-d2d52523d0da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e100965-f8a2-4707-ab37-9c29c18bf63d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e23d86a-bca6-4a9e-bb93-b8f705635c3a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ecc75ee-d0ef-4f2a-8a50-4e3972eba659"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0eeb6911-679f-4144-a7a9-5001158fedb0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0efafa40-052b-454b-b954-f7c1f33faa47"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f03fea4-e6cd-41e3-a2d3-b0e3a84ca1e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f041267-263e-470f-9770-de730c818536"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f662c69-3ee4-42ac-b472-44ded59497f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("109f6d05-ea4a-41fa-ad0d-3ea2d542ab4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10bb0f3b-b362-44ad-b002-69b50c126231"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("111cc4b7-a9e5-4c5f-bdc7-0d7d259486f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("117610b2-44ba-4b11-a0e4-0176151ea119"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11c04ad9-dabb-45a5-9a06-68d22c184e78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11c680df-d56c-4c3f-97d8-ff30d19bdebf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("122fcc82-0ac5-4f9d-9fcb-b24240aeb158"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("123fa5c9-ba87-462c-bbfb-8724735404ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("126370c8-0cb5-4359-8a73-729c13cf6f56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("128d4a11-2c40-42dc-9a8a-838bf10bc289"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1298ffe3-221b-40b6-87bc-6d30c79e5281"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("12e36191-aabd-4735-9b3c-19450cd3cb2f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("132b0680-aee8-4f97-8ae3-874ce57beddb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("145b22d4-de30-4d94-b08a-2b9613aff832"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("149d602a-7a10-4a4f-83cf-9021f058c176"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("14c2e699-7d5e-4c5b-b6a1-53de2a633927"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("14c9bf30-12fb-4f22-ae69-fb7defd5555e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1514a432-a42b-47ee-8920-08149ed875f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1538cb24-18ff-45a2-b28d-2f5c6cb7d07a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1550647d-f0ac-40cb-a4cf-9ad1e4976410"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("15679b72-f539-4f21-8e21-a6d91751cdd0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("159fd0d4-ab50-437b-9717-6e5fd73219ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("15b866af-ab33-4d5f-b501-eaa384b04cea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("15c41d4f-e6ee-404b-9c44-7121525525e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("15ccf1ba-8177-4c40-b49c-656b7ec115e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("15d72bbf-88a9-4438-8c94-af8191d73aa3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("162e4cce-1e38-483a-ae7d-3f5891461b6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("163086b1-8edb-4c8d-b67d-9f1bce291666"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("16ab468d-4272-4df4-8d55-29ed2e8bd63e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("16c57b8f-a9f8-4a5c-a6c3-d780aa5d1cb7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1767be34-46e1-4aef-9cc8-336a48e38ba4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17eb11aa-076e-49ee-889f-4021a2ff7410"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17fe519a-d126-40de-83f6-21f9fa2dcc67"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("183f3ccd-80b9-4f7b-aadb-14f7197fcc51"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1875cb1a-5f43-4d9b-8ae6-3c967643f7a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18950b65-5511-495e-b5f2-b326411f58a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18b47411-fa89-45dc-9448-0dd953d5a8a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18ee2faa-af6e-434b-8a70-765a11ffa34b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("19034da4-4f40-48e2-8dab-8b5bc7c9ee73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("195f0aa8-ddd2-4879-8c7c-b622071d8c96"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("19608de9-6927-4daf-81bb-a2e5bf9b8dd3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("19bf0771-980d-482f-a8e6-7892a21aa755"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a10ae3a-3525-4f8d-a390-626544074fcc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a3325a3-fc50-4229-9935-30d4626a8666"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1ab2c0b9-6075-4fa9-94f3-0d66d3bf66d4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b1d5e99-7051-40d0-befc-52e16cd3f5fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1ba67b2f-039f-4cd3-8699-0b757106b384"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1baf87de-bd2b-4791-8241-6776f3a30d95"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c00deaa-5d6e-4668-a3a5-81cf5669abc1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c0ffa35-6f6b-46e3-a895-bbd7950a1970"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c472e3a-7ef9-4ffe-9d4b-3ec77d02dba8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c78c784-7d61-4992-9667-9996158b619b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1cc38ec3-5aa8-4fac-8221-862fdb9b26d2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1ccd8adf-25c5-4eeb-b0a7-4546ff5565c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d0a5d34-1d0b-4fa4-8f0b-7bd33d938a3d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d410b01-fed1-4be4-ad36-facf9240b3fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d9477bc-4a16-45bc-8a27-a7efc69fadf3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e4610ec-f650-439e-baa2-fd2c04421f20"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1f132845-bfa1-4399-866d-a699a9f98975"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1f5ef9b2-9bae-4dac-b9e1-c526dd3e3304"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1fbf4335-27a1-4600-9d40-42154a8cbd5d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20abebab-e121-4ec4-be4a-5d9decb992f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20b09b17-0888-40f7-823c-cc5aa6d7d7bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20b93ff2-2ff2-433f-a25a-c7b5500f1e46"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("218b1435-bec1-4030-a3e8-0d6e02d94e11"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("21da8819-7b19-4cb4-bfaf-48a3671b660f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("21edd4f3-b52d-47e1-bbf6-2f9ffa7e64a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("223192b6-c559-44dc-a18a-bd1865c993ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("225aad86-26ec-4069-ab29-3919ded18300"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2264069e-8cbf-4aec-a08b-154c75b1635f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("227b7335-a452-490a-93c1-588a9f54226f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("227ff68e-7fe8-4cb8-b95c-3da2e44f6d43"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22ead8f1-ad5c-47d2-991f-7a75d2a96323"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("239dac97-a9d2-47e9-8949-14e1ed4e6dba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23f9be09-d1b0-4c38-baf4-dbb2f78883fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2418119a-3267-433b-972b-ab6291fc58e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24312693-1e13-4984-b7be-dafde9d28ad7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2446b078-f25d-45af-8177-472dc865ef1e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2477c322-e026-4621-88e0-d986f82f2847"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2482a828-c474-48e8-8b92-24de2db26c5a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24978dd4-371b-4914-b41b-ec6e0670af2e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24e0ee95-1e8f-415d-a956-fa335d61fa6d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24e9b3d1-231a-473b-bc0b-bc70a5cff114"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2510abd5-f25d-4373-98bb-cb29697fcb52"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("25d2d3b2-5eec-49b4-90aa-91ddeba6a89e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("25d9efa3-39d3-451f-a6ad-58bad8260408"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("25f7ec75-065b-4b27-9801-94a504ac9609"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("264a4805-63e5-44dd-9ae5-7fd2d04b7b98"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("269866c2-7f9e-4d8d-b5c4-5413ce02530c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("269d0552-dcaa-4fa7-95f4-a9049376f2fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("269dc664-3cb4-4ca3-93a8-a2e058d8d68a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26cd42bd-344f-46e9-9ddf-c6f195d77e9d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26e1bb76-499b-49c1-af35-3584993e3cd4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26f20286-5be0-4bd0-9a73-7f46278a8379"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("27195056-180a-4238-ae25-d37929e80322"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("273ecbff-2b60-4154-9970-8ecc89619153"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("27766563-7f8e-4012-9e4a-aa81181fd7a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("27add9c0-8f34-4ccb-9b33-e1fbc9ff3296"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("27b294a6-f4e0-4ad9-bc31-5b202ac6b915"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("27ba5108-a569-4d0a-9261-b58055c4bd54"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("27bd7c1c-547b-41c9-ac2c-07ad3930101e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("27d813d8-7d6b-43d2-b119-63df592b7d01"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("280a9a50-e4da-453f-aad6-acff60b8480e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2851e794-d537-4be5-b8bb-e247e3f616a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("28fd4935-705b-416a-b103-61176f71308a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("290d67be-a6a9-4b90-987b-b4c36c165869"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2912f4ca-2fbd-4de6-bf33-0bf50179bb82"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2934f7cb-9c96-4665-a8e0-92be260c9a91"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("29575605-482b-413a-8df8-48d98699e791"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("29ce15d2-5d4c-42d8-b661-0267bb99f566"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a001fbe-8a11-45e0-86a2-25398b2bec1b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a3f4ba6-6f02-4a07-a46e-84ad8762c33c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a60bf59-bcfb-4f3f-bd66-450b75f6f95f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a70d017-7323-4e0c-a31c-d7afbb327a1b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a9fad32-86ec-4ba3-9598-ed25d7b87de8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2b537da7-1db7-4c76-8cd2-85339f849046"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2b61b320-1f63-4ebe-b9c2-1c355b9978d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2c4b1828-f532-4410-8e2f-e863025e2f18"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2c73a1e3-eef9-4648-b98f-a527197df9bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2cfd7c00-9373-4a52-847e-33efd7abeed0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2dcdc404-eaf8-46fc-9688-828fec3536aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2dee5efc-7474-45e0-a2b4-07535c22bee6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2dee6af6-57df-4c5c-b450-e809ec97627f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e0a08b8-3b7c-4d3c-b9c4-caf2c669a8cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e18ce01-78cd-45da-b176-617c40023a42"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e86ad6e-7fb4-44b5-97e2-c70ec0bf7d16"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ef29957-5e32-46af-bb46-54a6f5a5ccf0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ef41f8f-067d-40cb-a4d6-ce07f603981f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ff55643-6db8-48d0-8d78-2f6afea9f9f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ff98a32-779f-4bb6-a5df-3881f6a2fa19"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31629eed-e23e-4ac5-bd81-3384851d8917"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31786154-03a9-4dde-888d-8cee68df8d5a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31d2b1b1-8513-4a23-ac27-fbc0ca1a8b27"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("323c5bbf-90cf-42b6-ba69-a0e63d7fe21c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3258dfd5-ac59-43e2-a52c-ae067c9f54f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("32627927-fe6a-4b34-ab40-97facea7d238"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("326879e3-9025-4c15-8ab1-1e638b455793"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("326d0c30-8dd4-45a9-89fa-b78a3c2c86d2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("326f496d-137e-4fb2-ad2a-f710d8e3b912"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("328dc2e7-62a6-44d8-848b-6e56987e7952"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("32b2f036-bb4b-4d4d-b1c5-dea760ae08df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3335cae2-94b8-47a5-a35e-96e0d18b045d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("339f9eb1-3be0-43d9-ace9-6ef08535b940"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33f6090b-641c-4c14-bde5-b1feda599752"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("348696da-cedf-4d0f-bf9b-ea0974ac1648"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("349f7a81-36d0-4735-91db-fe53fc1b622f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34ed7209-ffc2-45cc-9e7d-09b122ea8969"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3518a022-f3fe-43fa-9219-43c85d4aaa43"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3563f4e3-60ec-42e8-8fe0-ea2d89bea728"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("35df7455-f694-4171-8ae2-8ba97c83937e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("363e6a0a-80ce-4903-82cc-011094e61427"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("37643684-62b4-43cd-9ef1-1ea2db778e29"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("379ae450-8634-4d87-81f8-efe4d430d559"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("380550c2-f579-45d1-9ca0-f9f2362cc70c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("38327828-7770-4b7a-8b4c-5b57607ca11e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3896a623-5a5b-45fa-97f4-d0c6e67aa5eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("395bc27a-0da2-4452-829a-31539541f160"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("399b7f01-658c-4cd7-ba80-f6df117ccdfa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39ba387d-0dea-44a7-bee4-e57f2a22770d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39ced0b1-7181-4209-b835-174c415bb4ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a4a5431-1a8e-4174-9735-353178ffd032"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3af67983-fa45-4742-a7df-2171d0a222ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b1010a9-458e-44d2-9a22-139ccd88a6e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b217938-cff9-4ae8-91cb-d388dcf4d4d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b6bc4e5-1998-407e-ba27-36fa168cacd1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3bb30070-e9d5-4573-bc67-726e5ea90f8a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3c343461-108b-44d7-b593-c928c61ecd17"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3c3c4732-ad4a-490d-8d33-2ef386a6acb1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3c482e65-1aa4-4378-aa77-96f118e840ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3caab6f5-ee9b-4b24-aaeb-ad9b48c65045"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3cf945d0-bed2-41c7-be85-c533e60e96f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3d11acb9-42b7-46c4-8f05-95f6a26e82db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3d9965d5-d3f3-414b-812c-c5c015a11c62"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3d9d6174-1868-409c-94e7-3b712141c19a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3db2036f-6d8c-4669-8c55-56f806482182"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3db65e45-b2eb-4b22-a140-f79d2421e788"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3de70009-aa95-4dd3-95b1-1758cc054a2d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3f25dc14-1f6c-4ab7-8960-951b762ded70"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3f8f1280-25fe-4e56-bc80-4b0eb71e7d80"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3fb5c57f-37e7-46bb-84ee-fa81818c7f5c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3fbbc24b-587c-4c18-9adf-bcff2b99d2e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3fc151ee-188c-4f9e-8ef6-012e424954bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3fe047b8-ea1b-434c-941a-887a3a2f84c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ff85f7e-19c0-466e-8eb7-4e4c464baa3f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40398041-68d8-4f00-91cf-9db453d9e9ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("404c093a-2009-4471-881e-9f969292932d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4061838d-f663-4595-92dd-1ce85ed4bc9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("407638c3-d466-40f4-9310-b581f807b7af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("409adcb8-f17a-43bc-9f2f-fc01cd32a70b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40dcd646-fd81-4a0e-b7fd-ea10c5905841"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4134a08f-a222-4977-b9ea-9f75dcec5bed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41660694-d20d-4f41-bcd0-7f82cf069b36"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("426ed6ed-1e50-4f1c-8df0-ca89bff4480b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("42714ad7-b8f4-4b8d-a14c-8791ee0696af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4272b339-ea24-488f-9d99-ca7fb4c4d155"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("42d71d05-f9e4-47b2-ae21-64aa957512d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("43c9e90e-858f-4846-9bd7-441948b73998"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44269f57-defb-4e9c-ba3e-6c73953f8dc3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44e491cb-96fc-434a-a9d5-262d110cc368"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4564de01-f1e2-4763-9450-d7248b5d65e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("459b32b5-28f6-4abf-97ff-e47fa2a6fac4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45ec3c83-7fbe-49d6-86ed-b46447078fee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4637abeb-89ff-4121-a58b-0bdb945082ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("466d3038-bdac-4841-9c1f-f23bca30b574"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("46860a90-4e83-4e97-a5b5-4c2e1751e511"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("468db1d9-fa9d-4f1a-9f4f-43031a3a6339"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("472dbff8-1408-4820-9109-11979a84e942"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("47750981-3246-427b-a41c-4072b8364a46"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("47f65f12-0bf9-4708-8a3d-81fad453d8c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4807988b-d713-47dd-b382-3d8762f5fb54"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("483232c3-dc5c-4996-b846-fb5e6a45d125"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("48986219-0219-4273-9973-6c26aed5a5dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("48a5c9b3-5e14-4c3d-8645-0dd751b0af6f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("48c061a6-b8ca-453b-8664-12c1127432bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("494b7e73-22c4-436c-b8b3-64e7d10f6b37"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("49c07370-5cbd-4e18-9eea-fe00be28c5c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("49d87860-4319-4ce3-b27c-b5e6a16cdc35"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4a166aca-6aa2-4dda-a9af-6559db1ccd4e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4acc14cb-1cab-46e1-b504-2798c3bdff21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4b290a58-7044-4fad-9531-86bef9f5ed84"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4b733d93-862a-4bb9-a8db-81891b920be2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4bca41d4-bcf7-4e16-9e4e-a22bf283a33a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c5a12f9-3eb6-4077-a911-c1f595980494"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4cad6d9b-a111-4d74-9685-b1be5634bbea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4cb3671b-45f6-4363-9af9-2b9e81141f15"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4cd88f28-241d-473c-ba1d-60b6f4e5c64b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4cda95cd-e39b-4b6d-b5cb-addb432f9979"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4d11263a-3ffb-477e-8d96-238635b28d04"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4d6b98ee-b59d-4b0d-becd-6e4fedf94232"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4dc8f66f-bbb8-4951-b597-96dcbfc68d16"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4dd5f7c8-ea0b-49a3-9995-019bed620b01"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4dff9742-3295-444f-9fb4-d168cb43d7b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ea94d90-b496-43f1-9c90-a5b6f0c8e3b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4eaa69f7-50d3-4796-873b-186b0e560125"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ef90a81-d7e5-4954-8a5e-759c9979ba45"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4f84e859-c1a4-44ef-a214-a576182a421f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4f8c4982-4046-41ef-bb08-1daa34a38905"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ff61382-dfb1-4742-8700-bc95498248c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5033f2cd-224e-4b01-8a85-64e335475603"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50d7a133-41ba-425a-b984-e7506839d311"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5113b7c3-44c9-45ed-8aa9-4cb678899fd5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("511da089-550f-4ba4-96c1-46c6e7bb1e31"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51efc3ad-cbaa-4296-ae7d-1b4b840f4962"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("522363b1-3c74-4c16-866d-08bd046fb694"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("52bc8cdf-6339-4901-bed2-9600631e4ee8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("52c6434a-ce05-4272-84b0-2b6c1764c01b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("530fdce1-1c58-41bf-a615-5cb6413f74e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5314d2be-34b7-4b21-8620-bf0e060b14bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("53305e77-fb33-46d3-8dad-122aeb33f32e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("54296f4c-4d04-4168-9b97-0dd0a8a60f64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5451231f-e5f2-491c-99eb-e212933c1cf4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5451af28-a542-4225-9adf-f6bb489524b1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("548233eb-4628-4dc0-86cb-030e61e47a16"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("54ff8611-ac22-46c9-a2ca-cf42feb47c4a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("551b5aea-1710-466a-a69c-8b4d7c7253dc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("553271e4-8f58-4fba-84ae-e8833b08c3f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55ee5470-43e0-49fa-808d-bc2aeaddc579"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("560c70c5-2466-4abb-8e0c-26c01f0c3f9a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56e4dde9-6e3f-48e4-97c0-7c4bc0d9f571"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56e858e0-9679-48ce-89db-ebb45735c6dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("570ebf6e-a9fc-44fc-a9e3-5667db236e44"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("57235e2f-ec95-4456-91b8-aba8af7f8e1a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5753d5d3-1910-4846-aded-e0d08d77db8b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("578c27b7-a9e7-4c52-ac5f-684ee04cf90c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("57974fdc-5f10-40ca-95e5-31b5ae731f7f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("57b9a274-14a4-4ed4-af83-f566b0184311"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("581b140e-74a3-4f07-b71a-e5c48c9acbff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5859e86d-4c3c-4b0c-9420-c446597c81b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("58658bea-c777-401d-a119-0e75c36b3abb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("589a63ae-7603-47aa-a2a8-f853a66e64ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("58ec385b-ff0b-47f5-b5e1-20eabfcc7535"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59245101-4ae1-4a39-a936-aad78cffaae5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("594a376f-07a6-4646-88dc-0f06dc6c9cca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59f6b253-dc1d-4452-9354-915582fdfc7f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a510f77-562b-4346-bd9b-98e88c22e5cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a782c6e-a50d-4b63-b2cc-8d2f726c5d20"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ac419d0-09f6-4de2-8cd0-f83f8fbde0ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b56d9c7-6207-4ecd-8563-ec8a7fc95a96"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b613756-c87b-4769-9c47-be9d5d533abc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5bdc8882-701b-4614-9bc5-a7a783509b81"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5caada8e-cf62-418a-b31a-ed92ce4a05fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d21e044-6842-451a-994a-0d6581777f46"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d7a1d56-acbd-45a5-a6e6-8e2bf70aff51"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5dad4d56-664f-469c-ae35-44115188d0d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5e05c2f5-0894-41c0-b441-078c85dc98fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5e95d546-ed52-418f-bba1-b6ce50954e3e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ea10b9b-ede2-45a2-9e2f-a1e1ca4c249c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ec3c0f7-648d-449a-99de-0964a420de54"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f417747-2e9e-425d-a88c-10c8a81b8654"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f5e7f7c-6ea3-4154-ab9d-0d3662950479"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f6476f0-8e59-439b-b701-5673cd1d284d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f8702a2-84ad-4495-b722-ac9e144d23b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6009895e-8724-40e8-a1d5-0c4a6d119195"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("60168a18-0d3a-40df-9d2f-ce466c9a5e07"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("603fd2e1-1e04-4378-887a-d9aa8883a0f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6044ab42-f89f-498f-9120-2d89ed746065"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("60760abd-d79d-40ab-9ff7-12b3e8827eae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("60a0ae21-b397-43b0-a00f-6a5cd118e41b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("60bb4f94-370a-433c-a78d-45a53eace3e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("61c1405b-508d-4349-8cf6-261019cff675"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("61e7167a-93c0-4643-b3dd-8995940da860"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62179716-7cb5-4c77-9a1c-da1800feff53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62896215-729a-4378-8dd7-24e3b9bafccb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62aad954-3590-4998-bcc8-6a6ba68d3901"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62bb0cb6-e44c-4d35-a348-5d7d27c15951"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("635bb69b-e153-4916-9a0c-a8c964c60238"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6390b89d-a4d6-46f6-9a30-f00ebde5cd05"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("63edd17c-9c57-4f85-be25-ba0f511c167f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6417e430-9dfe-4ad4-8df1-57b783c81ee9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("64719704-828b-4858-a38d-14487eb1a086"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("64af7d05-69e8-44d4-b0ca-e662d59d3185"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("651d4e5a-ce7e-4aae-ad23-cf8b38065dac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6527eaa0-b9fb-4adf-995c-b4b45b1fd246"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("653c86f6-e43e-43b7-9fe0-023d7a58ba60"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("656c8146-0916-4bd2-994e-5d353426dc92"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("65bbb8df-a49b-4ec0-aa43-c3a227b1d0a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("65cea127-4d63-4d4c-82ec-93e0021d4b13"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("660ab204-418a-4ea5-91a2-580ec1b46e44"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("664a2c84-4225-4633-9801-fb0cc384c0f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66645405-d368-4ca8-a806-567fc4cd9ec4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66acd44f-7f13-437d-ae21-337172cbbbe8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("677da3ad-8e71-4bb8-9a2c-901b831e64b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68228995-1bc6-436f-bc49-e555e395a216"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("682e8f94-1a86-40ff-bfbe-121707325f78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6839f6c5-f6ec-4c20-80ee-0f0bcc1ebbd7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("686d0150-2416-4f97-a838-590b6120ecc9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68db50f1-59da-45ad-9897-2608a85dd9d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69302959-77ae-470a-bcfd-64c8adf144d4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6986bf6a-fe60-4aa6-9baa-c16c6c115d9e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a346fe2-5816-49a3-beca-fbe6fe7b59b5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a74d1d9-240f-4e83-ab39-1c0f1a592110"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a7fbc8a-14d6-4545-8b82-b9ceaed641b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ac2adbe-1823-4051-9d35-4bd26e135996"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6b40f9f1-5e12-4387-980f-d699c1c81aca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c9ba27a-d69d-4921-ba50-8c63efc339ee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6cb15972-960e-4c81-973a-3834016f56b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6cd76940-6e53-49d3-ac75-3cf7863574da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ce922c2-7295-4e6b-baa5-aeeb8760d56d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6cef1af9-b985-4a0a-acb7-bb97011387c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d460154-30f6-4ef1-9e12-a62b34f8ad02"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d61fa25-b02a-4a49-9c95-3a0b9b987545"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6db4a090-279e-4c21-ba6d-ea2a090d5ab9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6df8794a-d667-4a57-b3e6-da9d72ba3a89"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e31eec1-6312-429c-b84f-a6f7e837e2ab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e5a6309-3e88-47b3-a215-7d0c5c5e7f0e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e9d6f89-673a-48a9-9b26-fe74fe662d7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f197d69-c21f-4598-991b-1cfaa8ea9dd7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f324327-768b-4e31-89c2-0e2bb0c64304"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6fab99e7-9006-4c0a-aa49-93f9f2fa07a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ff55046-3e1e-4ce8-bad3-ca1f0f1a5803"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7029d7ea-4e30-4c49-be7c-9a4bd446c28a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7036494a-d83c-41e7-95a1-7d5055450f44"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("705bea85-c8f0-4f77-bb10-6112d88aacf1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("70b3458c-e579-4f04-9454-5d1d61957738"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("711ac726-07db-4dc9-b56b-10d12df53eed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7148700b-cb02-4242-b90e-4f8be66e43ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7221e3da-5cf7-4eea-b05f-7cfe2f6f622c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7274ee08-d715-4b00-8309-f25256d7b068"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72a782ab-2679-49d4-a65e-da8bd4c84aa8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72ad47c5-c803-44f9-bc67-1bafb9fd6da9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72ba0070-909a-4aa4-915f-5da046669e8f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72cb3929-32db-4934-b154-12777eaf33aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7308f373-fa16-48ca-825a-b8f4034342be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7395a519-5a11-48ed-93b1-7a086b23da02"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("739b3679-83d3-4d3e-a56d-d6eb32081367"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("73ad8fe3-46a3-404a-84c3-a08ced039111"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74ad6bfc-4b92-4982-80ad-d0c3cbe931db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74c5139f-5385-43d6-ab4f-4a9c875c0c2f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7505840e-a419-45c6-9aa3-042a0d29ac51"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7508cc80-9e37-4cf3-b40a-238d1c5bf25a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7594a539-f1a0-4786-bbc6-49783ed3341e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("762c8869-a10f-4293-ac4e-5ae833ec056a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("763277fa-90da-4ae5-9969-bcfa42c196e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("763a6db4-8f6f-4453-8065-792a7264d826"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7640044e-fb5a-4261-b29b-09c86d3cd6d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("769a6bda-76d4-4dcb-b210-c2645cca328c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("76d72a02-c20c-4499-b0a2-54a5a44525b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("76ea901c-c271-4026-8546-3e1bff8f9c38"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("76f1ddca-1ec1-471b-8968-4fde038db43f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("770d6d98-5eac-470a-b360-4522e015f2da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("77188519-42ac-4984-bc96-8886eb76444f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7751853f-da43-44da-82bf-99b869197100"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("777eee8e-29b3-4a96-8f43-3148d09ce296"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("77da9aee-e6ca-49f6-a5f9-7dfa66d1a91f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("788e68c5-be15-40e4-a2e9-92fc9b8c05e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78a628e2-fe47-45fe-9528-e2f391d7c26d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78a7a547-d349-407f-9029-2a09e16ea08c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78a8fe15-402a-47df-a1f4-99b1d9cf86b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78b3a94c-aba8-41fc-bc02-3866cf37b2cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78e98071-e71f-4c8e-a9d5-9cdcd6654c9a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("79955865-3229-4f32-b376-2dd1777455a0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("79d2c6af-3468-456a-88f9-47c731c48c07"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a20bbaa-df99-4ed8-acdf-4fa7025fd5fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ac645a1-e2c8-4cde-9623-d5fc509f06c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7b28464f-68bd-4893-a43a-bded8e000575"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7b4cfddf-81aa-4e51-861c-ec6734321d71"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7b78e08b-5e19-441e-abae-d56e8edd0664"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7bac2d52-d4ed-4b8c-856b-20315f11d516"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c0e7341-e786-4ea2-9bfe-b542c6422284"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c162db8-4303-41ce-b43d-434d83215ad3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7cbb42ae-048e-4cbb-999a-1e34613db841"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d63f68b-7792-4860-84a3-b324819ce2ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d74af75-bb9d-44e0-b0fb-ba2023b598cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7dfea93c-10a7-452b-b32a-572952e0bc26"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7e5f750a-fcc1-408e-bc20-009539fb1e15"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f338215-5725-4325-8c43-b1ec2c2f5dca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f81ce13-b672-4cd5-be4e-6e34194d039f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("803df189-97c6-41ba-844a-abfd5558329f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("807dc624-a5fd-4964-93c5-f41b47985b83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("809595eb-2b63-4a7a-ac81-b210ac175c86"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("813cb026-5fc0-4a2c-a389-ff3967acfc0e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8150d138-e5bf-40f4-9077-e0a7bb04f41a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("815da1f8-5046-440f-a89e-0e84840fcab7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("817be0e3-0cfc-4425-9ed9-15bae6029774"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a17ad5-8293-4d52-ae0d-d9f11eba1a23"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("825cd9a7-76a5-4cc4-af7d-6c6b341bc1d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82b5ed80-6caf-455b-89aa-6fd302a8d105"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82c7dd26-e26d-455a-9917-bcecfbd74e47"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82cd45eb-5849-46c6-b162-ed55bfccbdab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82e24665-4c18-4c3b-86b3-6626e7468fa9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8330701b-8a51-41fe-8b8b-80a11aef5808"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("83618447-785a-4229-b763-bc48a9ff6ebd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("839cf250-8c8f-49ab-859f-842f47a76724"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("841782f9-7960-4f7b-a3e0-2191e9616440"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("842fc41f-1c45-47e5-b117-5482b3af91d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84341791-03e1-46d1-8c4a-adc926572c11"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84766456-d3f0-4c97-8d28-9bf496bf132d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("850a11ef-675b-4470-955e-89d4c72a7917"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("851e6048-ec27-4389-9263-6e4cf6bd9272"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("857fa71a-a779-4632-adee-23f3dabffa60"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("85817ded-6be5-426e-8c54-6486dcff6506"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("85aa79d8-94ef-4432-b62c-1a3a57481879"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("85ed404d-1889-4cd8-8ec2-82b3c8cd3862"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("860d21ab-3e6f-4c28-853b-ea4d189f81af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8622d544-2f59-4042-b75a-7962bed3383b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("862f6ea3-ded9-4122-ab19-8b65e6f69e24"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86313b67-c712-4a18-bace-b9588cdb168e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86730cb3-c014-4d3d-9176-0576b3bda3ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86946737-b4b5-449f-83dd-5f850c4dc4aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86d472aa-9fc1-4b31-a710-32f75bad4dad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86efa8e7-ef58-4f2e-9bc6-d3de5bf05b48"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("870920ab-4acf-49bc-85a6-f78324c0b5c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("874d12f2-95b9-489b-be60-e6b385aa729b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("876daae3-6b17-4251-b600-375c865f9c0f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("879d5d7a-7ae5-4e61-b72d-77c9aba8466a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("87b5f6a4-e1fc-40ba-ba94-89571425cfc8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("88171431-882d-4577-9754-f3b0567bb84f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8818dcf7-20a6-4a13-a03b-a89d1dc9e852"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("882a0388-91ec-4c52-86b1-0a7e2b5b5d97"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("88609f0d-92e2-4f6c-8e69-fd2f91ea4b1c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("887a0693-d7a3-4b4b-a207-5124cac2e459"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("887cfb33-dabf-4ab8-9930-9436af4964e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("888d05d1-e979-4fa5-9e3c-18f1c3323a29"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("88a50169-d559-4706-9a8d-ad5b77d881a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("88ce2080-dd3a-4dd3-8e06-3946e9714301"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("88f731e3-deae-43fc-af30-34b1afe922f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("88fc5622-47a3-411e-b094-219d6b7d2a8b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("893cacd0-5fca-4e54-8367-30625534b86c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8973d534-b794-49fa-b601-c1756640fcec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("89955f66-c197-427f-92be-9dd1781043c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a3a90da-2570-43f2-85dc-d47e2e114ff9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a4114b2-e63b-4bdc-9a98-8f77f70b34c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a691abf-76f6-43c2-8423-83c080720168"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8abe0c23-fcff-4da5-8e3b-6fb5d67c1f34"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b3320ec-6efb-4d3b-92ed-c5150668bd3f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b3bafba-5566-46a3-bbeb-7e26670e1bfc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b77a6f5-d794-477e-8682-7c6a6f76165b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b9e0ccc-6588-487d-b018-6b373c4ef53e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8beb1b79-9fb2-4379-b392-3c608aebd588"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8c21bd2c-3217-437a-a698-74c172b29b80"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8c29b9f6-fbab-47f8-b947-4766568d8137"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8c54a304-5076-4731-8b55-869fb7d4a36b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8caaaf8f-6cc3-4056-8f7d-0c7edd4abc9b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d80ba91-068e-4d6d-a8f1-6c18897870a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8da93228-6abb-414b-aac0-17985cd887bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8dc7199e-498f-4072-9d1a-a95a388aeb87"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e28b16f-3e82-4890-a42b-baddcc037918"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e3d2fe1-12c9-472e-a8ed-a73fa2773377"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e559212-b7f3-44fc-bdcb-48ce8c308b5b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e6bcd72-6617-4c97-8e89-d35a3b431da3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ec4640d-e665-44ac-a49a-c39343bdc6d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ec52062-71ff-4818-8522-8d492c036c75"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ef55850-00e0-4358-9381-0c1f8274491c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f069b23-96d9-4ce7-93c0-73fff3280780"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f31aa84-a678-4387-8410-eadab3b109cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f72ddcb-b319-462b-a2ae-2dbd432aced4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f973376-43ac-4f62-8e3f-fb18aefe1abf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8fd562b3-3c59-4907-bd4f-f1db881bcf55"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8fe6e8a9-9b21-4f3e-ad7b-f73165bdf31c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("905c12ca-f3e9-4b53-98fc-0603afb159fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("90b4f5b1-72c1-454e-9ce4-cf03248263af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("90e9389f-b65b-42b5-9b10-a3d14d2ee042"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("919380e2-a930-4364-946e-cf2668c678c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("91ca3907-b655-41d4-9756-438842b61a50"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("922774c0-2b2f-474a-8346-0a34fb0eaca4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("924c0bb6-f2a0-4dd0-9e96-dd6d55a1ec09"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("936153f0-03ba-4e5c-89fc-568c2d1a73c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("937fee4d-2ee6-413f-99e6-1de14d524f32"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("93963c89-8b2d-4689-9401-c71f68622561"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("93a09c72-caf6-4ed7-9bad-548e8777b21e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("93a58344-51cf-4a84-9115-0c4e1dc6de8f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("93c66bdd-7ebd-4185-bd2b-7f1a3ae17148"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9400b003-7f10-4b45-b6e7-b8557d3dc146"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("941f50d6-29f6-41b7-ba67-bda9ec633f00"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("94277cbc-ac2d-48cc-8896-d7f22b1c7eab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("94501fd6-f18f-44d4-9232-230a45ded004"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("94b88df0-98a1-4b81-b660-e1ed836a1c06"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95083c9b-881d-41b4-b905-a0e745755822"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("950a6729-82ed-42ed-96d7-e31f80b5c00c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95342d5e-2d4c-4e70-8729-9bfe3cceb83b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9570c198-fa1c-43a0-8862-4e8fdb12c9b5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95795613-1774-4b70-a643-e50acf6ffca2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95913638-f0b1-43fb-8fa7-8a562fdb0198"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95ac4461-ebdf-487f-9e91-82f8288ea4da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95c35731-57ad-43b9-a496-5e0ba207f397"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("960e7ddc-d100-4150-88e0-80aa35dbb115"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96fa1d68-105f-43f0-9bae-8c9084863d3e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("97091764-628d-4d89-8721-0a979241f387"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("97354615-85f5-4c87-9af7-42a44f2c3fdf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("97aaeb79-df71-4605-b4af-dbed9ebffdfd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("985bd27e-11fd-44c1-b6bf-de7d34f6a348"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("98ada1a2-58ce-4579-8daa-ae98f88cf8be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("98c806b0-c716-4db9-a763-5910402cff27"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9922e514-0195-4a15-bcd9-16c59a9f4804"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99402a12-e28b-408e-b9ec-38f0b97de415"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99cc3a38-3999-4731-9355-02f4df2a8b41"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99d2ade6-ddee-42f7-807f-231d7bf13278"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99d9f050-81e0-4669-ae55-a49951435ff1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9a11068b-9197-425f-b9b8-383c3b60d97d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9a1fc6a7-05fd-4b7f-9cee-bd703ede8055"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9a20df4c-2eab-487d-aad6-548f7ceab349"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9a27dc6b-0a6d-4946-9fce-0fb16f92f7e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9a6a2037-da5f-41ce-aae4-0f2ce506bb9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9a84c901-5d25-4f84-87d6-7a023575fca0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9aa6c17c-074a-4dc8-b25e-a5329d10a8fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ad267e7-8f97-478e-a2d1-511b918bc7ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b08ada7-6460-414a-8492-e02bdb23a4d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b1b44ec-9ef7-414f-ad4f-30c3f5b9ed59"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b2fd9e1-e106-442d-9e1e-d75032e2a013"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b5ea53e-f89f-4137-8d18-d3997cc65de5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9bafbf76-7f78-46c1-a12e-2254c4f9fed2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c10d4ba-0338-4408-bd31-1e8c1f78fe07"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9cb40b3f-6079-462c-8aa2-ff3d8d3dada0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d0eeb87-3929-4a17-a4ac-e98e9d74309a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d198a38-b5e7-4415-92d1-e9c2080f127a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d27cfa9-0230-4c80-a392-79d5538b5e18"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d33564c-e10b-415f-afe9-2b06cb49f96c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d35f86d-7b38-4b4e-8a9f-d9e240cc0eac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d534726-b0fd-4505-a3f7-17278fd3bc17"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d748ecc-01d5-4a3b-a0fc-26b9dbfdc71e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9db6a7b9-5cff-41f1-8566-8ddd98e9e583"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9eaf741d-cbf3-4783-a8fe-c6e3c140114b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9efdddef-e28c-47f7-9ec9-77ace67214a0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9f33a214-e6cb-47dd-96aa-117da2f85d4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9f3e43b1-423b-4014-9fea-06e688504b0b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9f7158bc-2bf7-4cd1-becb-08b155a11bba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9f821b10-6f7b-44d9-b194-7953a7cf80cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9fb85a71-76eb-4adc-af61-e960372d79da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9fd2fd79-7c07-4511-971f-2327267123aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a011b61a-a0a8-4307-8b88-67ffd8f49680"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a09df6ac-88e1-43b5-924f-2bb3748b79df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0a8f9ee-7f38-4f19-828f-eb666eefe9a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0c09c6c-5028-4368-b982-69c328f6c91c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0c38b67-4e6d-4dcf-8c7c-865c1eea7383"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a13334b1-f5d0-4a30-9063-74bc8aced3c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a228a28d-5b04-4f87-8357-3aa84ea4d788"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a24496b4-22f9-46a6-a846-6e4c1af001fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a29f4601-656d-445b-a9f5-505ec480c50a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a2b8b7bd-9dc1-411c-9e28-7bd479801b86"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a2f95c48-f694-440a-83e5-0eff5f145eae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4ccb6f2-45d6-463f-a198-93b5619e4160"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a5b43f92-c31a-464b-bb1b-426493b69ff9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a5c0666c-3211-4e82-afd4-b5d2d2de2eea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a61c6446-5e3d-40ac-9ef6-e10927cddf69"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a62795d0-043f-4c2a-ba6d-8f66b639c91f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a658cf55-8c8a-4c96-a9ac-4c951f4111df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6725b47-c53d-4eee-b897-424ed3e4a972"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a698dda8-b96a-4e38-abf8-b982fa731b2f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6a2287c-94c4-41cd-861d-ca18a3854561"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6a961c1-27a7-4a5f-aef6-0003170f85ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a74480dd-4aa4-4273-9247-fd02f42fd6e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a744fa1b-8d64-4cf6-8d50-499f7b0bfaa1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a7d94b95-8bca-4a98-b004-68c1418a60c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a7dd8112-d949-4e23-a461-318b5e9c50e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a80272dc-8ba2-4bc5-aa4f-a1cec0720c4a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a8f91183-fd6a-4fbc-a0a5-2e733e5c5f29"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a950fe7b-5601-433c-a37e-805836c9d23d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a97151be-7ec2-49dd-877d-ccbfe541e5ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a974db2b-322d-4570-9b4f-baa7803abd1d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a9778399-2755-4df7-8d32-11e709c07f94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa149cac-27c2-4f47-9751-e3c60e13d2a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa55ebfa-83aa-480b-b1e1-26f3af1b4209"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aac9772b-deef-4364-a48f-78ab798e8a00"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ab28ba2d-6500-47fa-9b55-3e88b2be831a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ab60c088-e610-4088-89d4-61c2e4e5a944"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ab7df06f-3bfa-4ac4-8be8-63caa3b6b17c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abc7f26a-c685-4e6f-afc7-a59cecea820c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abce6fa8-7aec-4300-ac93-230a12d12594"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abfa508a-fcdd-416a-9cb6-2e019d038127"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ac296ada-7214-4bf7-9653-501b28785ef0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ac980a6e-436d-4d20-98ab-5ac9087fc35a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("acb470f9-1422-47da-a595-b4c464ffa964"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad023aae-245b-4a87-8d7a-3c283a66240e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad360bfe-a105-4147-a265-eb5f25806fcb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad79df53-0ae5-42a6-9431-b5250ecd3f9d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("adb7b448-a44a-44ba-8061-b4442c04badf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae09f4cb-febf-40b7-a753-9da3911fe229"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae866f0a-d429-4135-8e56-7266a3fe7318"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aece74d6-2bfa-4cbf-8636-240a6c1284c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("af56e74e-3421-4008-9261-4d49a4bd53fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("af9a6f89-c257-4a14-9499-73ea7be5ad6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afd0a31c-1a04-4021-8152-be9f6127f770"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("affd56e0-f619-4ab6-b399-a1416e5c47f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b01ec066-4618-429c-8c5b-743da84e256f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0a286bd-acb1-47cf-a815-003ff5e09b2f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0aaa327-1c07-428a-a298-0994f7cf0ea9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0acac91-560d-423f-861a-6bf4e732586e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0d59694-cd82-44a2-a83f-2a548737ea47"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1280a47-ac8b-4607-82be-74e4adb27f6d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b135cbd6-05b4-41d8-8e42-22d96bd477ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1599a56-9904-43e9-8a55-240904df6bf9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1ef7ec1-3432-4b30-b98e-76059de4d0b5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b2421405-530f-41c7-be3b-904611c505ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b2662d0b-522a-4742-8e64-1681deb3dde9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b26952d1-e8fb-45a5-a6bd-70e8c6b7d077"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b2e28755-172a-4066-8b02-335c3b3c3638"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b357e192-486b-4ff8-bac2-233d23e530d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3844dad-e261-41d5-9b4f-d7a8bdfd3e82"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b400dfc7-f117-45b8-9719-8a71b32522ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b401d535-ab93-40c2-b07a-303043a7f5cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b40c80ad-65d0-4dab-9ea4-9bfa1120e931"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b45546f9-514a-4b17-be9f-48845bf149c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b45aab92-57d3-4ee3-b26d-c9d696f44999"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b485f490-df57-4e06-bd5a-6b24b05e3f4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b4d77c6f-de67-4cdf-86e6-bc08616c873c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b50f3313-9fd0-47e2-bc0e-a994fcd3cace"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b51863e5-cde8-4698-8d0e-9d43909bf5e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b59c3507-4ee5-4de9-8c01-5c83bb261722"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5cf6d87-5c7d-412e-8535-cd096e9079a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6222afe-ce6d-4bf7-a14c-3b637b444a90"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b62ab2ff-475b-4400-a3f2-20a75f932ee8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b64acd11-133d-4dca-9e54-fdb9b24d2a04"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6c7af8d-5f1f-4b02-bf69-d08403bfb1e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6e64ece-86eb-47d6-b5b3-d099faa5cba2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b7633804-163f-4432-b99c-a690326cf03f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b76df999-1a24-49db-b914-2742518f9573"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b7a7ea2e-231b-428a-8261-c1b3eee957a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b7ae11ae-3f84-44c9-ad98-ecd2e91db5d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b7fdfef4-45fd-45d0-837c-420d961cd6ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8240d88-d292-477b-afc9-d2c7b10dba49"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b84400b7-06da-4afe-a6fd-ba21959322c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b87ad64b-29cd-4b8f-87b3-a88b0a7a92a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8f78dcc-dd84-4e88-ade1-d99283c48997"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8fa8312-2ca2-44ea-9457-9ae0e69bc7cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b97c884f-f369-4a58-b537-d4220d9805c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b97daff0-25ed-4a2d-ac07-dd11e09cc855"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b97e1869-369d-4a38-9c51-7d70ae5d5330"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b989993f-0f56-4d8c-a163-7569b9e6c1ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b9a5ff25-a4d1-4c74-9fa2-d58e4c3722ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ba17b82b-dbdf-47d7-a6ed-9acfa3185f17"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ba2e01d9-4e87-4510-8f60-4f03a2bee936"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ba96e6b5-30dd-45b2-9b9c-49c9b3dafbe6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("baaeaf66-e7ea-42a3-887c-178ebac235c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bb2f9b5d-3b3c-4efa-9ab2-17bfa22301d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bb68a7ec-de53-44b4-bc02-b0dada5e6160"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bba849bc-8887-4d81-8d77-009d99d17002"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bc4d087b-e844-4c13-b6b5-31a55516aa77"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bca3be5a-72df-4e6b-a5f3-4d5350c0c3bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd4a3d61-1da2-4883-b52b-853b18876ee9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd58f0fa-7bb3-4b86-be61-244dc00de961"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bdd51be2-37f6-4867-8f00-590b72e5ff20"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bdeb5920-e0f0-4471-bea0-b7b379943436"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be061d74-daf3-41b4-bb52-b5b2d3472fbc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf0b9296-d2bf-4a5e-86f1-accd19d75d05"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf14c0ac-629f-4534-9416-dc9613bd69ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf1ed704-d489-43a6-a6b9-2676d86c917f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf6fb75d-d36a-4c78-b6c6-54e02e7df120"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf96e327-09d6-4abc-ab56-c84b935d9f23"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf96e4bb-26a6-4a13-9f44-930da636af0d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bfc49e41-756c-4f24-8cfb-ef76e9ba84a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c04d4b70-b2b5-4501-8bff-00b1747a3584"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c080a312-cce7-43f0-9040-5922506b03b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c0e31686-36eb-48cc-8f03-9c8794d9fc60"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c10fa97d-9145-4869-a965-093955bf41e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c14a277c-28a1-498b-98a1-9a3b5ee94eec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c225712b-a14e-40dd-9f58-2fe7cc023d00"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c22a296a-3ccf-4251-abea-9eee71114f43"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c22ba857-4f0e-4bf3-8248-63d93fb02028"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c247759c-c1f0-4317-9431-4f99a4960660"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c258d979-cdab-459e-b84e-f0cb93274231"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c27826ee-897a-48d5-943f-673b3745370f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c278fbd7-cbcb-45e6-9b85-6bfc6ead560b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c2f4ef37-8789-43f4-980e-47ba43c399c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3088ef7-bd8b-44c5-bd59-0a192630975c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c30b5420-ed27-41bb-95f9-16d9b250e66e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c32ef463-16b8-4325-9ad5-91c29f35de19"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3b4f65f-24d2-4bd2-b7d8-41742ec6b57f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3e654c9-24b6-45b6-9037-4eb5df185cff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3fc9ebb-b46c-49de-b7f6-ff95b4419cee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c40fbd89-5350-405a-9432-074f11a93574"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4d11450-5ec8-432d-864e-17b316f7d583"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5119c9c-2fee-4309-8236-1744b0d36baa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c53b2dd2-9b6d-4e12-b35e-e3b25e5f340b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6056833-50f2-4e11-ae1c-efd4ba39dfb2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6219392-eda1-477b-8c5d-1fd65ca95083"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c696f1f9-80c8-454f-87bb-94b4c76102a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6a2184d-ac48-4eb9-a639-ae83076685fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6abd229-dc94-4f44-a1ee-3971918aec6b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c76293d9-5153-49b9-a778-3d38b82cc07d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7bb2695-92c1-4013-95e3-adb232c8a1c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c83c5ee9-78ea-473a-a31d-2127eb0f15c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c8b18a1e-ff10-4bfe-a727-0d0b11b3c3a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c91d9b31-b488-4f88-afc6-61be29439a39"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c98a1540-c3a6-483b-b4dc-8d546f751f20"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c9b17f1b-d6e2-48f3-89b4-c248e6c06869"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c9c33a41-5905-46c3-82da-38ee7031657e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c9fc7aa7-a70f-4dfb-91a1-004a3a2d71de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca347bb9-50ce-4587-88b7-7157d2f26788"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca3535e5-8dc3-40db-81c7-ed70d369884c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca40691c-fd11-4acb-a223-273bafe535de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca51c177-c544-4e3f-9dd9-d6aec2490482"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca663a5b-5602-4edb-9bac-e059d4848950"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cadcb71e-0945-4822-9172-061fb7a15459"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb838fda-3afe-4dbf-9616-3d2bbb42fe46"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cbf3cd37-4bf3-4c83-b13f-142ad4d2fd21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ccb22259-fc17-4c63-832d-c44f42e5a9d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ccb4ecbc-c24e-4091-8f53-60f31e01692a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd1ba508-39c1-4a5a-9f01-6b44154d94a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd3889ef-1c52-44fb-bc85-23e5d6d9d5a0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd482442-0f3c-4f9a-ac27-7e69321f1ded"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd4ac4df-40ac-4b3a-bf99-a17adf99fa85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd4ffa4d-0c4d-4013-a832-a7a5700bcbb3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cf5918dd-e61a-404c-a31d-0078faf12078"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cf7fb7f1-56e7-4124-b0a9-b75dee7e020a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cfff201b-3fa0-44b5-a645-73bd667566f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0136690-b799-408d-81e3-9979c09f4633"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0169625-a62d-42b5-8570-5ca4904b845e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d02739d0-00de-4b59-89ad-b5198f2ffc8c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d041cad0-c966-4da2-9542-b09a2226821e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d04d33be-2a64-4d91-a6ce-06408b916bbc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0d2aed6-e1af-42a8-9092-8a8e29bdef85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d1570dd0-7b3e-40ca-ac45-a7ab012fc102"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d18b0f8e-f29d-4abf-a1f4-f417ed952afa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d1b7cc44-bce7-4b19-89c8-4f577bc40f2d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d25380fe-9b23-48c0-94fa-8c1b28e802e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d29cd840-862e-467f-8629-aa57eaf397ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d2ab5574-2ba0-4209-943b-1233af735a76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d2cba5b0-06a9-416c-9af1-0b3691aaead5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d2e0fad4-6687-4d3a-8725-339b0a3ab6fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d2f7548b-2d2b-43f6-a1cb-cf9228c64667"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3229bb2-83e1-47bd-a78f-f2a6426125a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d343ccf4-a251-4d63-9614-e4856ca9d230"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3585c6b-69a7-4f64-bdad-fa078b2128fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d359343a-9b4d-4e21-bf20-2c6f659e9bc2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3b3f821-210e-4042-84f3-0c500747064f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3cfe728-6db9-4067-8cd8-3581fd70f65a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3d779d7-8b86-4cd7-a700-fe35b635fb55"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3dfa5dc-d196-4a74-95b7-356cfc293e6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d4206eb2-6910-4bcb-a7a4-927c64e7d1c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d477e06a-350b-4c10-91bd-5cad91bbffcb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d47d7bbc-2139-4083-b304-ab5e303a99f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d4bb6775-4e60-4bbb-9447-65888e22ca80"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d4c5988d-4208-4e79-b065-b15ec1d8f543"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d4cf426f-6f96-41be-a6e9-c19f8f81a842"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5b02e9e-7705-42c4-8a27-709ff21907fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5d78051-3325-48bb-95a0-64b497f23d02"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e82c7e-183e-4387-92d9-a5df68e93968"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d63ab0f1-28d0-4279-a03f-8b3ddd735150"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d64520a8-20b2-4e3c-a7b8-64f59e1bf5f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d66aaf4a-0391-4969-b05c-4afcc422d8f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d68cc4dd-4ff8-4bf2-9380-303299f437ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d6b28ee9-5092-418c-812f-ad68355f7ffc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d6e1bc83-b0ee-4566-8d19-67eb8165be84"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d71acfad-18d6-4064-9817-db4a7241a4fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d745512b-a4b7-414c-a85b-2475007fbc48"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d74a4f57-8189-401f-819e-efc45dd0dc44"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d84acf32-ec67-463a-8fe9-7b5355c3e89d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d89b394c-51f0-43e2-9827-876f42158ea6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8daac0a-3147-49d6-960d-90dcf143c558"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8eed42c-586f-4ac6-acda-45d1c7fdc598"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d913c728-f140-4d6d-a3a4-6c9c3a2eebf0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d919c394-c778-4ed3-aeef-f6308fcd2fb8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d9348373-1320-4de1-b7fe-7b21db43e835"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d93b2af8-f03f-4245-8887-29f4978167bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d9d440ac-bb9d-47d9-840e-e2fee174a85d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("da0957ec-f526-44db-8ed6-95103070e9dc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("da2726be-7326-475c-b3f1-acc7f009af36"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dad8889f-c13e-4898-999d-19ff92684c66"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dae0b0d1-f9d0-492e-bb66-3932d3f38d00"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("db37c176-cdd3-4e95-ba65-957b519a05f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("db490c07-3033-412f-bc56-a9ff5be06fe8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("db848ddc-20b5-4ab4-93dc-09a08ddcf777"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dbc729cb-07da-4136-b08a-3e4925f14bfb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dbe52cb5-e81c-49d0-8a89-47f272243c23"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc15acea-57d5-4bb5-83d7-52b0b5896290"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc249b40-4932-45b8-8eae-8f867b02c711"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc33da69-e156-4648-ad61-7f3463f5c868"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc4298ad-ccbb-4279-826c-cb129bf3fe47"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dcff17c8-9d9d-4f68-9cac-a085e3c946a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dd626b24-15e2-4136-b3a9-b2d38933f92b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dd79f96c-6893-421d-9f6b-54b3b3119623"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dd87268f-2f69-44d8-84db-eefa1df33fed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ddaa50c0-00af-42c3-9baf-b2468fced027"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ddb8983d-9424-4dd1-b71f-213593bff953"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ddc58dac-3832-4516-a31a-d56895969ab3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dde6efef-433f-4bc5-a057-44796fab2f09"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ddfae1ce-843f-45e5-b78a-0c26b23d787e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("de19bcd5-446a-4a3d-94a6-2b1845b0d05f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("de208fcb-2485-46a1-b215-1885cf9d37ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("de366ffa-231e-4077-81fa-8b91a8be44fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("de906220-2e13-42c0-93f6-866953111c47"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ded31a02-10e3-4db0-b722-d7461c84cbc5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("deecf160-f337-45fd-ac97-7b038a82fbf7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("deefa240-8a83-4097-a62f-8d664d5e6938"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("df81019b-b015-4fcb-8c0b-4c116d34d8c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e00a80bb-7af9-4280-8d35-c793b646926b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e05f6eeb-9ea8-4e85-9747-ca37df791021"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e0749270-7958-49e7-967f-6a07562c9e8b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e0dd5072-a769-4df5-b2b9-80a2aa8dda72"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e1596a3d-0306-4f8a-8ebf-9c5dc9a0c2f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e184b209-6c0f-45e6-b024-3a5c63f5e8f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e1a7c70c-f0ca-4445-a368-28e45cd8ff62"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e210f296-13c5-4d28-99e3-d70f472dbf29"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e2738c7c-3fe6-4d48-96c9-fcc499771aeb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e2c8ec9d-bf81-42af-acd1-751fb425a536"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e2f18c0c-dfef-4314-8e84-ca6cae86bddd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e34f3dc7-971c-4bc9-8f5f-3e7805f513b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3e5f5f9-e6ea-434a-a336-7503df607ebd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e43359b9-caa8-499d-96c7-c95af1331ccc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e47a8205-c4de-4a96-b593-f8def19efd10"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e47fd1a4-ccef-4b11-96d9-8716796035e1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4dd102f-1f64-4284-aeeb-0d2a4795bdb8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4fdb775-6c2c-41ce-86eb-eaa3f3050af0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e516a4c7-bcc4-4d66-8531-287f209f1418"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e53ba952-8bdf-44a4-a032-adbddcedb96f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5750e6f-3eb1-4519-bb1b-3ecf3ab2a3d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5c34400-3906-4480-8070-174aaf483d76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5d79b81-8b0d-48ae-97ca-ea8c1b0f2e13"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5ffc25a-e7c4-424c-b942-f23c9a5cdeb2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e61c1772-9f3a-4219-851f-3899a03502be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e643e409-f223-4d41-8a2b-a403b0cea928"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e676f778-ab4f-4748-9317-5d93d34db0f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e684831d-ffae-4df3-b372-8718b40f4269"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e6d6cf18-bf52-4ed1-b4c4-e73eb559b352"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e6dd8d83-7674-41d9-ae87-9f7cc4b993c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e6e7652d-941c-4528-a1f6-fc0941bd1148"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e7131273-d5f8-467a-8274-728b73117363"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e7672bae-c786-41ac-a158-fd2af81edaa7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e79e1ec2-9568-4992-996f-0a46bf5d2019"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8b3fa2f-c083-4275-bb11-83f42f499ae6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8d74f21-9812-4eee-85e0-63efe9147cb2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e921fc5f-ff52-4bcb-a6f2-c97f95bda290"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e92ee0a6-df1e-477d-b8da-29c7e8bab5c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e947a7b8-3c8a-4fb4-bd35-4225eb338808"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e96f2f39-f605-49db-8c8f-2c6e996effb9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e970ed35-c32d-4bd1-8cdd-1cee148ceb7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e9c40189-613b-4707-bca7-c0853be774ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e9e89371-759b-4667-a087-8ff72fc5cfcb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ea37d67e-b56e-45fc-9326-b13861c93f98"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ea3edc44-831e-4ce6-bae0-c9db7d824020"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ea583798-63a2-4fa0-a237-0772d08b294b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ea96a101-f147-40e2-bc2d-fabdcfb691c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eac88579-a243-4845-8084-f8bb5aba0302"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ead90f42-bc89-487c-bf75-88381a4f4a53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb80885f-c0e8-4a61-8b1b-811372ce6f1d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb91ac04-27f4-4398-8e63-15f969d76e00"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ec85d331-c2f3-466f-9554-ffd3d805647e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eccd0d80-1375-422d-b42a-bb5f564f9470"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ecd686c7-1594-49c1-81bf-cf0b3e205af2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed521ad2-c248-4f13-9861-d1b24980f28a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eda6e60c-5383-4bdd-b280-22379df2ab4f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("edb23fa4-c38a-4c43-a62a-c010d961ab7b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("edb6689f-00c1-4bea-a3f2-d7d69c2c39b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eddcf6af-d463-4605-b349-e5ca83850c43"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ee078b9f-0723-4fb0-87c2-974ebc4100f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ee7e51ac-045e-4e1d-b347-31dfdd86ce43"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eef848a0-538b-45e5-bd17-163c1069e580"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ef571ba0-fe4e-48e2-935c-d736d591ece6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("efc36dea-e365-4ae9-bc4d-9d3c3913a9e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eff90a34-160c-48c6-91a7-264ca8550a6f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0010010-8220-40e5-8e1a-13dd1fb2ee16"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0235b86-d8c2-4361-93ef-29448815fc64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f02a6334-88c9-40d2-a35e-eeeca14027aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f063b89f-979c-49a2-9bc9-98fbf4c31539"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0bac15c-a2d2-4642-9159-ff7ab6c9241f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0bfb0d4-cf5d-43f9-86bc-02c438187533"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f1043ffc-42c8-4b98-ac62-924baf228f92"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f1063e5d-bde7-4d05-a453-ddf8f60314b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f1527f11-3250-4d13-881e-cdc0d554fd8d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f202c3af-0e16-458b-bcd3-36de131d400a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2604030-cde2-4807-964d-cd226df02cf0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2990416-d8d7-46f4-aca7-18a9617d6710"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f35d58e4-16df-4f5d-9d35-544b3f3148e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f3adabf1-ced0-4dd4-ab6b-ba10691020d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f45ce05c-bad3-4b1a-b6e5-be9fd57058b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f4eff91c-7a35-4f98-9ff8-f32d819cf8cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f4f85dbc-3966-42d2-ac0f-df491b7e2eec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5712845-c7b0-4a28-a5cf-5dd1905171f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f574139c-b374-4059-8aaf-7969099544fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5a54f23-dbe8-494d-908e-76c28d7592eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5ba1d21-9a54-47c9-8045-358c9c9d6d83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5efa5de-ff99-41b3-91b0-ee4a6ad11ed0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f64d24a9-59f8-40bd-b4e6-012ed77a0dd4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f65c3cfb-bfff-4591-bcae-81d731abc5e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f6961525-d78e-45fa-b5e9-77a6e7b784b5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f6e1e0fd-6c21-4172-9688-727a8aa074bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f6fc309a-292b-454c-b64b-9c8a5a48038f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f73d8b07-fc33-47f4-88d9-63d2abe9aaaf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f756c1db-b660-4d70-b2de-58038d937163"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f75ec5c2-adde-4bec-af40-c4a17d349d7a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f7826859-cea7-4f55-9b81-521ad02a35ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f7913c40-f0d4-4141-9c72-d3e27f9934b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f79aa9eb-b037-45a7-9db2-ac1dce920892"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f79fafbe-70f2-42d5-9170-2352a98bc49c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f7c79766-41ba-47ad-9af2-38e7a360731d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f86527af-05da-4415-8e9b-098e6b87b950"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f890795d-a83f-411b-a7d1-1184c2b46867"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f89a8f36-dd02-469e-abe0-af87498d5e27"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f901d4ac-cf7d-4bb7-87ef-10ac1d56b690"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f9abc7bf-2713-4fd2-8c2e-1e225c0c8ff0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa05e47a-a8e5-45d5-97eb-a9bdf8819b1e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa1bf0e9-9506-408f-96e0-298976eb6d4f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa67e0d9-27dd-4a2c-b138-0b302106134a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fae0ab06-cb4b-48a4-b16d-49335da885f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fae684c1-8c4b-4af2-8fcd-046bc163be18"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb72de3c-8ec6-452c-bc05-ea02a255c657"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb866da0-967f-405b-a642-081fd3995b99"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb87a556-24e5-431f-acb5-0b103b54ccdc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb899d21-7888-434c-997e-ddb0d6c73aa3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb95921b-8ec4-47a2-8de8-1708134f101f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fbdaf342-6e54-4cac-accd-db197f41c194"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fbedc01a-ed13-47d3-88b4-8c3c20fd9d68"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc1a9501-2c0c-4745-8295-147d64cce977"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc31a842-2dbc-4018-8382-1c065811dc9c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc60d603-e65f-46b9-bf38-119f8ddf91bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fd3a2325-bc11-4b10-9317-cae869755fcc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fd736ec5-e11b-4b39-8ac4-5f1860ac41b5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe13fe28-b244-435a-9da2-ff38e04d8634"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fec3e319-6189-449b-95ba-9ab580d587bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ff21597e-9ef4-48f6-a764-3eda1d3fa21e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ff4135bb-27d5-4542-9a47-df1437cea4bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ff8d9439-e297-40c0-be48-02f1cc5f3ba1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2cd22a14-8388-4e0a-b7e6-c22eec0eb647"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3b8b0b0-20d6-4dcf-bf20-fef2f8eb7d94"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6700e3ba-cdbc-4dca-a3f0-bd0195b47c1a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ee2a6607-55e0-4000-8859-db96ceb59690"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3c28eb5d-2f47-4968-9049-6a5143e3dfa6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("76e433c3-fcea-477a-be19-66c662912c71"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8d5c0b06-a000-48a9-8266-55a82cae6b89"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("475e1512-4241-4abf-8f91-f91e4e0d6ffb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69514928-4364-4b79-bae5-b7b466528f20"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ffe41c68-f4d9-4e3c-9e7d-0699c7f78a47"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Carts",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "CartDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CartId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    CreateAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartDetails_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "IsDeleted", "Name", "ParentId", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("59444e0f-3831-4437-a4ce-3872216b92bd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo", null, null },
                    { new Guid("6388590b-fc99-4c55-86ee-49d5c3b45d01"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreateAt", "DateOfBirth", "Email", "FirstName", "HashedPassword", "ImageUrl", "IsDeleted", "IsVerified", "LastName", "PhoneNumber", "Role", "UpdateAt", "VerifiedCode" },
                values: new object[,]
                {
                    { new Guid("009a44b7-4f07-4685-b21d-6aa2cbdcc563"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan633@gmail.com", "Tuan", "hashed_password_1633", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("00b1d73a-0037-4262-89dc-ca2b387224e8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan574@gmail.com", "Tuan", "hashed_password_1574", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0102b7a3-8fec-4e47-bbeb-c715dce4c128"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan2@gmail.com", "Tuan", "hashed_password_12", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0117ee56-1b42-46b0-9725-ec2620f0b9e0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan385@gmail.com", "Tuan", "hashed_password_1385", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0125b07a-7a02-4b42-aad2-d16194d05bdb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan316@gmail.com", "Tuan", "hashed_password_1316", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("019e028c-fa98-4c20-b4ee-530ad670ddcb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan973@gmail.com", "Tuan", "hashed_password_1973", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("01d7b08b-9f96-4fdf-a8f3-17583ea9d59f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan874@gmail.com", "Tuan", "hashed_password_1874", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("01e65569-60d6-439e-a52b-9e033867b52d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan59@gmail.com", "Tuan", "hashed_password_159", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("01ebaa41-ecf6-4fff-b2d1-69ca86297db9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan579@gmail.com", "Tuan", "hashed_password_1579", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("024959b4-013e-44ab-94ac-66c559929c29"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan550@gmail.com", "Tuan", "hashed_password_1550", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("026070db-7191-4e86-b5a6-021048fb84c3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan658@gmail.com", "Tuan", "hashed_password_1658", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("033932d6-4018-42fb-bbe5-89346fc1e1e7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan583@gmail.com", "Tuan", "hashed_password_1583", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("034da90e-fc2f-4cf2-a765-458bc83e4ccf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan396@gmail.com", "Tuan", "hashed_password_1396", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("03b1eecd-3def-4de9-b4e0-7f075ca03946"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan303@gmail.com", "Tuan", "hashed_password_1303", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("04220721-64d5-4cd7-9ab2-f82862b26d1a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan328@gmail.com", "Tuan", "hashed_password_1328", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("043f7dd8-0da3-4449-b215-d9ec9c59ebc1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan744@gmail.com", "Tuan", "hashed_password_1744", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("04bddb3e-1032-4a89-8de2-15be700f1940"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan602@gmail.com", "Tuan", "hashed_password_1602", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("053294cf-1d5d-4b1d-844a-5c4cf5838783"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan674@gmail.com", "Tuan", "hashed_password_1674", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("05ca3926-25de-4340-b9fd-2c653a2b7937"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan945@gmail.com", "Tuan", "hashed_password_1945", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("05db156f-9212-425a-826e-4c694ff1d9d1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan794@gmail.com", "Tuan", "hashed_password_1794", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("05f0c8ec-0290-48a2-866c-61b5f63248d8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan480@gmail.com", "Tuan", "hashed_password_1480", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0604f60f-7008-4461-830f-c279ebebf7c4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan239@gmail.com", "Tuan", "hashed_password_1239", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("063b43b1-d1f8-4392-b3ef-9d9828354517"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan496@gmail.com", "Tuan", "hashed_password_1496", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("063d36d1-594c-43d5-a81b-bde64aa4dfd3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan591@gmail.com", "Tuan", "hashed_password_1591", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("06608ced-9292-4e7f-91f6-e119726f7d4b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan502@gmail.com", "Tuan", "hashed_password_1502", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("06ff49df-81ad-46d2-9d86-fc65eba90b98"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan785@gmail.com", "Tuan", "hashed_password_1785", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("075ba062-cd6a-4a7e-9c1f-b7e3ce39616e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan145@gmail.com", "Tuan", "hashed_password_1145", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("07cfccab-0b27-477d-9ea4-ef4b81c4499c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan29@gmail.com", "Tuan", "hashed_password_129", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("07f126de-54af-4877-b864-e00a61cb22f3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan868@gmail.com", "Tuan", "hashed_password_1868", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("080b6e15-e9b1-45f8-be4b-1c13751f47f1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan601@gmail.com", "Tuan", "hashed_password_1601", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("080ed3e1-59f1-4b5a-ab52-cb9ed998cc90"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan929@gmail.com", "Tuan", "hashed_password_1929", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("086bc450-d583-4a2d-9c53-e9da752ff568"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan423@gmail.com", "Tuan", "hashed_password_1423", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("08ed2fb6-1a92-4eaa-a3aa-da2fb9ea6c64"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan211@gmail.com", "Tuan", "hashed_password_1211", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("08f10d9c-0fe1-4b04-b4c1-77e73c3c7c09"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan592@gmail.com", "Tuan", "hashed_password_1592", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("090237b6-7d1c-4faf-8465-a56c6725661c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan728@gmail.com", "Tuan", "hashed_password_1728", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("090cb41f-b911-46a7-9007-323ddb9d1bcc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan804@gmail.com", "Tuan", "hashed_password_1804", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("090f0244-e967-4e1b-8756-66dddb9ab788"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan696@gmail.com", "Tuan", "hashed_password_1696", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("094cae33-13bf-4f4d-8d51-8fe6e2baf94a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan528@gmail.com", "Tuan", "hashed_password_1528", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("096035d8-7152-4131-9bac-444e2aa3adb3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan584@gmail.com", "Tuan", "hashed_password_1584", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0976b21f-6cfe-43f3-a587-e022a8ca9398"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan94@gmail.com", "Tuan", "hashed_password_194", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0985b7f9-86e6-41fe-9b77-b0dfb797bff6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan740@gmail.com", "Tuan", "hashed_password_1740", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("09a55886-ae41-400f-bee0-88c099e4c110"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan101@gmail.com", "Tuan", "hashed_password_1101", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("09f7dc55-d5d3-40dd-9d3c-74cd5a1ac517"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan823@gmail.com", "Tuan", "hashed_password_1823", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0a296fb4-a42b-48c9-a717-ad0120ce540f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan349@gmail.com", "Tuan", "hashed_password_1349", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0a786e6a-029e-45e9-b115-67dd8ccf11bc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan210@gmail.com", "Tuan", "hashed_password_1210", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0a7ce0aa-9275-4300-984f-6d220ef70b9f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan68@gmail.com", "Tuan", "hashed_password_168", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0a815b72-a0de-449d-818e-d5ec02ac56a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan614@gmail.com", "Tuan", "hashed_password_1614", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0aa59381-067c-4958-be40-daf75183ef09"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan10@gmail.com", "Tuan", "hashed_password_110", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0af8afec-233a-42a2-987f-1912ab1d2655"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan389@gmail.com", "Tuan", "hashed_password_1389", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0afadd2f-bb24-4563-9cd5-80e124a192f7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan382@gmail.com", "Tuan", "hashed_password_1382", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0afd9866-b5c7-4206-bab0-f563116572ab"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan451@gmail.com", "Tuan", "hashed_password_1451", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0b0ab7c5-ee86-4108-be1e-696a6c388d47"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan815@gmail.com", "Tuan", "hashed_password_1815", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0b5234b0-a684-425c-b2b9-9af59ab7127b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan189@gmail.com", "Tuan", "hashed_password_1189", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0baec8d2-a9bd-4961-b436-9c1e6d04c31a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan492@gmail.com", "Tuan", "hashed_password_1492", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0c47dc63-adf2-4cc5-87e5-7abe0f71de46"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan710@gmail.com", "Tuan", "hashed_password_1710", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0cad1bd7-cc41-4bb3-9e0a-1519b5a701fc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan243@gmail.com", "Tuan", "hashed_password_1243", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0cc153cd-b49c-490f-a203-8bf19155bd88"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan13@gmail.com", "Tuan", "hashed_password_113", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0cd7c39f-2d82-4ee1-8c4b-97d2045d9938"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan54@gmail.com", "Tuan", "hashed_password_154", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0d33d100-029c-4feb-a261-191609f65547"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan828@gmail.com", "Tuan", "hashed_password_1828", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0e11a0e3-fe6c-4160-953d-d8ad46bbd77d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan603@gmail.com", "Tuan", "hashed_password_1603", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0e46654d-857b-4a90-add7-e29fa70da067"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan616@gmail.com", "Tuan", "hashed_password_1616", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0e900056-3e13-4adc-bc97-d040b654d805"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan311@gmail.com", "Tuan", "hashed_password_1311", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0e971189-1e1c-4d1d-abf0-3669559966b9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan426@gmail.com", "Tuan", "hashed_password_1426", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0eb85bc2-0685-4861-ac7b-775fe888dd07"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan552@gmail.com", "Tuan", "hashed_password_1552", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0edb8cd0-0a21-48e3-99f0-caef58725144"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan516@gmail.com", "Tuan", "hashed_password_1516", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0f8608f1-8f73-453d-a6c1-0b4502c5643d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan383@gmail.com", "Tuan", "hashed_password_1383", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0f926c5f-3ca4-449d-8440-4e96ff5d5d49"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan553@gmail.com", "Tuan", "hashed_password_1553", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0faccacc-db12-40cf-a72b-44d486019cdd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan245@gmail.com", "Tuan", "hashed_password_1245", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0ff75e7b-4ad5-401c-96dd-aa7b48c46d1c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan801@gmail.com", "Tuan", "hashed_password_1801", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("10575cff-7739-4b0d-a3a8-a56e028f9829"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan454@gmail.com", "Tuan", "hashed_password_1454", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("10944aa0-ae4d-451b-8957-a11d9c1acf17"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan589@gmail.com", "Tuan", "hashed_password_1589", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1098d0b4-1470-4e48-8c97-866ee47749a1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan225@gmail.com", "Tuan", "hashed_password_1225", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("10c9da6c-ea6d-473c-8d23-4d9686ba06a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan116@gmail.com", "Tuan", "hashed_password_1116", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("10ef8202-13bf-4b79-962e-98d5a30e4906"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan527@gmail.com", "Tuan", "hashed_password_1527", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1101f936-f551-4f83-8568-ca0a75313345"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan247@gmail.com", "Tuan", "hashed_password_1247", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1139498d-3d8f-4b26-adc9-50ddfc548d50"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan901@gmail.com", "Tuan", "hashed_password_1901", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("118f872f-aa30-41c9-a191-ed60477e050f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan99@gmail.com", "Tuan", "hashed_password_199", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("119ad8af-4707-4774-8963-fc38436dd654"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan205@gmail.com", "Tuan", "hashed_password_1205", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("123aee03-f228-4352-8631-2e752040ad39"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan668@gmail.com", "Tuan", "hashed_password_1668", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1254051a-e994-406f-b156-cdee95b299d8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan272@gmail.com", "Tuan", "hashed_password_1272", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("125b0cc0-d148-462e-a09a-0e0ddbca7dfb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan648@gmail.com", "Tuan", "hashed_password_1648", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1327952a-bdb0-4c01-ab4a-17f68e1196d0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan83@gmail.com", "Tuan", "hashed_password_183", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("13395adb-ba01-4caa-a9bc-a62ffe8e5d41"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan954@gmail.com", "Tuan", "hashed_password_1954", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("13484c8e-a495-4599-82db-812e0d07b362"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan619@gmail.com", "Tuan", "hashed_password_1619", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("138c3a4c-1983-47b5-a1d6-81801c50937a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan802@gmail.com", "Tuan", "hashed_password_1802", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("138f849a-a867-459f-acb4-73017c40d629"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan651@gmail.com", "Tuan", "hashed_password_1651", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("13bc240a-b708-49b2-b3fb-2acef95a59aa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan164@gmail.com", "Tuan", "hashed_password_1164", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("14535e05-12cf-43e9-bf86-719c3ab549de"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan799@gmail.com", "Tuan", "hashed_password_1799", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("14c1e9ea-77e4-4d12-9d96-c549c7d66c20"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan514@gmail.com", "Tuan", "hashed_password_1514", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("14eccbeb-b3d9-4dd6-a2f2-221b53e2c75b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan136@gmail.com", "Tuan", "hashed_password_1136", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("152e070a-27ad-4398-ba31-63c9c60cc86a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan317@gmail.com", "Tuan", "hashed_password_1317", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("154e247c-5eca-496b-b0e6-3e9346157f0b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan403@gmail.com", "Tuan", "hashed_password_1403", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("156161fa-d66e-4299-b22a-17df8d240c93"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan471@gmail.com", "Tuan", "hashed_password_1471", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("15ae8579-7d14-4866-8763-967f0959bf29"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan969@gmail.com", "Tuan", "hashed_password_1969", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("161aa65e-bb59-4694-aa53-2d2fca18ad04"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan357@gmail.com", "Tuan", "hashed_password_1357", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1714b86a-5f0f-4060-807e-4f29ce5a4aa2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan313@gmail.com", "Tuan", "hashed_password_1313", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("17bdcf19-8d15-4b04-8b19-948314bd58df"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan533@gmail.com", "Tuan", "hashed_password_1533", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("17ca607b-c2fd-4705-b810-5807ba5c3cff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan359@gmail.com", "Tuan", "hashed_password_1359", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("17cb5958-c7c2-4abd-bf88-285bd665f166"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan386@gmail.com", "Tuan", "hashed_password_1386", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("184eb9ae-4bf5-46f7-89d6-ad3f63f8cb12"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan146@gmail.com", "Tuan", "hashed_password_1146", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("184f6085-d548-47e5-9805-78225164b55b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan244@gmail.com", "Tuan", "hashed_password_1244", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("18662229-cf1e-4469-a793-5912a824ea4d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan691@gmail.com", "Tuan", "hashed_password_1691", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1877959d-5e76-4cf1-9713-43a9ccd0b685"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan690@gmail.com", "Tuan", "hashed_password_1690", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("18c239a8-0c94-4a40-af3c-adfa3e187f62"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan411@gmail.com", "Tuan", "hashed_password_1411", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("18e019f7-1137-4b3c-b1bd-03dcd56fd3d7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan187@gmail.com", "Tuan", "hashed_password_1187", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("18e56cd1-8e6b-404d-a6df-79f467c60b85"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan773@gmail.com", "Tuan", "hashed_password_1773", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1907f122-fab1-42e0-8fe5-4eb008a18588"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan196@gmail.com", "Tuan", "hashed_password_1196", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1968c7db-a6f2-43fa-9662-dc406517f8a2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan810@gmail.com", "Tuan", "hashed_password_1810", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("197f5e20-2db4-4e26-ac09-4499dc15802b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan342@gmail.com", "Tuan", "hashed_password_1342", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("19977834-5249-44bd-b365-5d83167eb4b2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan433@gmail.com", "Tuan", "hashed_password_1433", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("19dc7a7f-3e55-4c07-ae5a-c12cabc900b4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan34@gmail.com", "Tuan", "hashed_password_134", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("19fa178f-7e35-4641-aa9b-a3dc459d0b9f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan132@gmail.com", "Tuan", "hashed_password_1132", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1a656af8-8b02-4c26-ab78-d77cb3b6ff93"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan971@gmail.com", "Tuan", "hashed_password_1971", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1a9133a9-b996-4277-b998-f817ecfa181e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan967@gmail.com", "Tuan", "hashed_password_1967", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1a9f15a3-4479-4fed-ada1-45f0efe19d91"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan987@gmail.com", "Tuan", "hashed_password_1987", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1af7188d-886f-4244-ab3d-9f5d5a9d9620"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan395@gmail.com", "Tuan", "hashed_password_1395", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1b501207-cb4a-4d8c-a7dd-ce0945b5132f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan354@gmail.com", "Tuan", "hashed_password_1354", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1baad8a2-f7a1-4df7-9580-99171b78e291"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan92@gmail.com", "Tuan", "hashed_password_192", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1bc0e1b1-81ef-4d16-a7ba-6947186d2505"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan556@gmail.com", "Tuan", "hashed_password_1556", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1bf50403-3877-41ef-8cfa-e6c0a9e908e6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan743@gmail.com", "Tuan", "hashed_password_1743", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1c6926a8-6853-4c6d-86a4-5bc8d0ef21ff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan477@gmail.com", "Tuan", "hashed_password_1477", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1c7c516f-9c88-44e0-8193-1fbd7dd9b72e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan405@gmail.com", "Tuan", "hashed_password_1405", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1cc44263-ad50-42a9-9f3e-ad5b6379ddc0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan960@gmail.com", "Tuan", "hashed_password_1960", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1cca9e7e-f974-4d47-a7be-33adf21f94cc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan562@gmail.com", "Tuan", "hashed_password_1562", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1d5b39ba-817c-483e-92ae-42cc2e34063f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan503@gmail.com", "Tuan", "hashed_password_1503", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1d73ea71-52d6-453f-b714-27ca9b3b837d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan112@gmail.com", "Tuan", "hashed_password_1112", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1d755fac-5c97-4249-ad80-b0934b24b613"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan851@gmail.com", "Tuan", "hashed_password_1851", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1da10b9f-638d-4043-9253-0d9a63350fef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan108@gmail.com", "Tuan", "hashed_password_1108", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1e01fc8d-5331-4821-9e06-53f51df04a39"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan590@gmail.com", "Tuan", "hashed_password_1590", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1e5522bd-81c1-4feb-8189-a9238266bf35"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan845@gmail.com", "Tuan", "hashed_password_1845", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1e5be460-263c-4321-9565-0eb7abe55397"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan235@gmail.com", "Tuan", "hashed_password_1235", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1ed6ff7a-82ce-4e5a-8030-bdfb560b9996"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan194@gmail.com", "Tuan", "hashed_password_1194", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1f3b3cfc-7820-4e91-9134-c078faf4a6a1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan730@gmail.com", "Tuan", "hashed_password_1730", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("204a92c5-7e0d-4ce9-8bbc-1828e4d4a350"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan900@gmail.com", "Tuan", "hashed_password_1900", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("20a1bcc5-4e28-41de-899e-51eafd71508a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan918@gmail.com", "Tuan", "hashed_password_1918", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("20e0a3e6-4ffa-45a1-94a1-e1e4f62ba29f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan974@gmail.com", "Tuan", "hashed_password_1974", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2134cfa4-3837-4a26-9a98-8cac70b388b4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan422@gmail.com", "Tuan", "hashed_password_1422", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2201b50a-c1b9-49d5-abba-365813144704"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan450@gmail.com", "Tuan", "hashed_password_1450", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("220f2b04-a4ee-4cd3-9b00-396c0c9166e3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan449@gmail.com", "Tuan", "hashed_password_1449", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("224d8c82-c862-46ca-a9b9-65a040411958"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan587@gmail.com", "Tuan", "hashed_password_1587", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("22bb50e4-6248-4dc5-a5a1-86a32c669d2b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan962@gmail.com", "Tuan", "hashed_password_1962", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("22bc7973-209a-4bf8-97cb-48596cd5d5d6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan292@gmail.com", "Tuan", "hashed_password_1292", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("22daa8c3-4732-4a2c-8fe5-68dc5fd239e3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan154@gmail.com", "Tuan", "hashed_password_1154", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("232b16ab-3f7e-42dc-b0f3-093a3232aa7e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan486@gmail.com", "Tuan", "hashed_password_1486", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("23f654d7-48e9-45c6-b67c-1b0f98a53b07"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan431@gmail.com", "Tuan", "hashed_password_1431", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("24084888-5b56-4d12-91f7-b9ab439ad28d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan369@gmail.com", "Tuan", "hashed_password_1369", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("24250518-6e2e-423b-b933-5eb0f69f5e32"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan89@gmail.com", "Tuan", "hashed_password_189", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("242a918e-eb9a-45c0-8f9a-a593987a3168"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan689@gmail.com", "Tuan", "hashed_password_1689", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2451bed0-3d77-483b-b80d-3e043d340c52"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan711@gmail.com", "Tuan", "hashed_password_1711", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("245248f8-5d95-4a12-ae4d-f14dcb1d9c4a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan200@gmail.com", "Tuan", "hashed_password_1200", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2474abb9-8b2c-4fc2-8c32-27d9cf261a4a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan752@gmail.com", "Tuan", "hashed_password_1752", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("24bd6ff9-91a4-4f1f-9162-43b3b67f0565"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan456@gmail.com", "Tuan", "hashed_password_1456", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("24cb594e-4701-499b-a743-3537de75a135"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan391@gmail.com", "Tuan", "hashed_password_1391", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("24d17e23-cbfe-40e8-9deb-1815e5e2c786"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan817@gmail.com", "Tuan", "hashed_password_1817", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("24e3fa39-7443-42ed-98ac-5ec326bf01d7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan956@gmail.com", "Tuan", "hashed_password_1956", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("25088be7-fdc8-4ca3-88d2-ea912fc44f32"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan78@gmail.com", "Tuan", "hashed_password_178", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("256766d3-d2f6-4c70-86c7-1e1a6ea2b186"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan0@gmail.com", "Tuan", "hashed_password_10", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("25ce8414-d77b-45c4-a89e-a213171b5ce8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan509@gmail.com", "Tuan", "hashed_password_1509", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("263b9592-ae01-4291-ba97-d4049beb2fde"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan344@gmail.com", "Tuan", "hashed_password_1344", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("26448178-d263-4be6-a57a-ba6921707176"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan564@gmail.com", "Tuan", "hashed_password_1564", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2648f1d3-7da6-486d-ad78-865b88fdfc00"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan498@gmail.com", "Tuan", "hashed_password_1498", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2658f0db-2c5d-44db-a1ca-7477ea6983f0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan129@gmail.com", "Tuan", "hashed_password_1129", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("26b7cba3-4fc2-4c27-845d-7c275d141003"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan35@gmail.com", "Tuan", "hashed_password_135", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("26f258fb-e5c2-484f-abe1-5217e9b21894"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan853@gmail.com", "Tuan", "hashed_password_1853", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("270cf51a-9563-4dd9-bb25-fd140aa699d1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan681@gmail.com", "Tuan", "hashed_password_1681", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2718a211-ce4d-4980-88a6-f231e67f724d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan623@gmail.com", "Tuan", "hashed_password_1623", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("27400cb3-1f58-41d0-8803-7566715537da"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan231@gmail.com", "Tuan", "hashed_password_1231", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2750048f-9803-4896-8b89-8c5febacd2dc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan624@gmail.com", "Tuan", "hashed_password_1624", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2751620f-9a7e-4bf3-b4f4-203063067629"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan355@gmail.com", "Tuan", "hashed_password_1355", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2789bc61-1da5-4b4b-ab7c-5c883e741e2c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan621@gmail.com", "Tuan", "hashed_password_1621", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("278a59c7-d14d-4a31-9667-be7282a83ca6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan733@gmail.com", "Tuan", "hashed_password_1733", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("27a3b7cd-cba7-49c4-83d2-dd8b697fff9d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan523@gmail.com", "Tuan", "hashed_password_1523", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("28f29c6a-c831-4ba2-809d-f22090c4fe0a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan421@gmail.com", "Tuan", "hashed_password_1421", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2911cb23-7dd5-4056-af9e-01b1c98c0a72"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan286@gmail.com", "Tuan", "hashed_password_1286", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("29515443-d72c-4928-b3e8-458f9920dc0e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan60@gmail.com", "Tuan", "hashed_password_160", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("29645acd-dfb8-4950-903d-a2bb762c69a6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan104@gmail.com", "Tuan", "hashed_password_1104", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("29f95cb0-7071-4d76-88ec-1ecac268349f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan69@gmail.com", "Tuan", "hashed_password_169", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2a01ba86-7646-401b-a881-804be5b2db48"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan788@gmail.com", "Tuan", "hashed_password_1788", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2a91ecb8-93e5-400a-af50-e6d01eaf0b7f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan649@gmail.com", "Tuan", "hashed_password_1649", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2b1e1113-266f-497f-be88-8d21a54a5afc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan934@gmail.com", "Tuan", "hashed_password_1934", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2b850762-ecd1-4631-bfa3-d635d8bf2028"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan28@gmail.com", "Tuan", "hashed_password_128", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2bde927b-76d0-48d8-92b6-db8bc1dcb902"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan986@gmail.com", "Tuan", "hashed_password_1986", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2c762619-826b-441d-b298-30da4fd8c820"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan47@gmail.com", "Tuan", "hashed_password_147", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2c9f21b2-8809-4272-a1d7-3196757170b6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan946@gmail.com", "Tuan", "hashed_password_1946", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2cd90c75-ea27-4d4b-8b1a-182494e83389"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan586@gmail.com", "Tuan", "hashed_password_1586", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2d0bf7a5-dac7-4f0c-8c9f-887bf9692058"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan343@gmail.com", "Tuan", "hashed_password_1343", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2d161df6-266e-4e49-8593-d88f8d6d7d69"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan680@gmail.com", "Tuan", "hashed_password_1680", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2d24a7f2-1dde-41af-b034-4c3fda954fad"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan275@gmail.com", "Tuan", "hashed_password_1275", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2d288b97-28f5-4b4b-89f5-0727b97d2ee9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan72@gmail.com", "Tuan", "hashed_password_172", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2d6d6dc4-f820-4599-a51a-ee51665712eb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan646@gmail.com", "Tuan", "hashed_password_1646", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2da5983d-b41c-4ec4-83ae-7a8a3f72074d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan921@gmail.com", "Tuan", "hashed_password_1921", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2ddec3e1-8887-46fe-84d8-7079df3b779c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan867@gmail.com", "Tuan", "hashed_password_1867", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2df2e338-e729-4c62-94ae-846b5ff1ba7a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan895@gmail.com", "Tuan", "hashed_password_1895", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2e0aae5d-4a1f-499e-b56f-a46170bac48c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan437@gmail.com", "Tuan", "hashed_password_1437", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2e652949-405e-4f87-90a7-8ed2eaa75acd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan951@gmail.com", "Tuan", "hashed_password_1951", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2e76b3e5-b4fa-432d-a977-a886a4282f85"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan318@gmail.com", "Tuan", "hashed_password_1318", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2e7f86ca-41e5-4bc1-a80a-f47440f23226"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan717@gmail.com", "Tuan", "hashed_password_1717", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2e8dda59-2d34-4a78-a4de-f83273c14ba4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan911@gmail.com", "Tuan", "hashed_password_1911", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2eca6980-06ee-4b27-ac2f-4f55dabb5d3f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan220@gmail.com", "Tuan", "hashed_password_1220", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2f253ced-6fcd-4700-8fe9-e48afa6f23fd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan677@gmail.com", "Tuan", "hashed_password_1677", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2f3b83fc-6330-4f08-a2de-4ac7b775cea7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan545@gmail.com", "Tuan", "hashed_password_1545", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2facb1b8-03db-4ea3-bc8c-de00ab70d4c9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan414@gmail.com", "Tuan", "hashed_password_1414", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2feb0456-91ed-4a9b-843f-ed371df0e452"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan457@gmail.com", "Tuan", "hashed_password_1457", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3035fc90-cbc0-40cf-a68e-0740c6a1b58f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan554@gmail.com", "Tuan", "hashed_password_1554", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("305fe164-5896-46ad-bed3-19cc5ce64384"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan963@gmail.com", "Tuan", "hashed_password_1963", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("308eed15-8a65-4ca9-b2e7-97764e111ca4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan775@gmail.com", "Tuan", "hashed_password_1775", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("309999f1-f31c-4fa3-aefe-ee9756143790"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan980@gmail.com", "Tuan", "hashed_password_1980", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("30b06d80-9c71-4cf0-946c-4b4f427ad437"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan259@gmail.com", "Tuan", "hashed_password_1259", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("30c355c6-2ad4-41d4-88ca-ba2365ad5cae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan475@gmail.com", "Tuan", "hashed_password_1475", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("31161e87-1374-4b80-a4f1-fc09c737b586"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan188@gmail.com", "Tuan", "hashed_password_1188", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("312c4253-cc93-4c71-af15-c7d653e6f09e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan175@gmail.com", "Tuan", "hashed_password_1175", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("313237ad-b208-40ef-ab55-5b3aebeb0528"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan947@gmail.com", "Tuan", "hashed_password_1947", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("318ab285-73b2-4d29-b36a-e62b0a2cf360"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan14@gmail.com", "Tuan", "hashed_password_114", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("31a469aa-c4f5-4f12-91ad-90e5cda226f0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan755@gmail.com", "Tuan", "hashed_password_1755", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("31e713a2-bfcf-438c-a89e-f086d0ce319f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan635@gmail.com", "Tuan", "hashed_password_1635", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("32abbe8b-45c3-469f-853a-f6e45b050ea2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan546@gmail.com", "Tuan", "hashed_password_1546", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("32bf9187-d482-47b8-903e-465fbca6268a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan106@gmail.com", "Tuan", "hashed_password_1106", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("33c5cacb-4363-4981-b5d5-d42b177f5c8b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan252@gmail.com", "Tuan", "hashed_password_1252", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3450c85f-fcc3-45c4-970b-b0e7239130d3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan892@gmail.com", "Tuan", "hashed_password_1892", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3452eaf2-3b0a-4d63-8bdf-aca8cd583938"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan936@gmail.com", "Tuan", "hashed_password_1936", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3452fa5c-b5a4-43d9-b5cf-8dfece156bdb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan408@gmail.com", "Tuan", "hashed_password_1408", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("34808a00-1b6e-4071-87e2-769a138e21b5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan735@gmail.com", "Tuan", "hashed_password_1735", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3482a42f-4ab1-4759-bf53-ec36cce2cae3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan863@gmail.com", "Tuan", "hashed_password_1863", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("35265e86-5c7b-49d2-9737-028e3cc785e5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan442@gmail.com", "Tuan", "hashed_password_1442", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3542913e-c071-4ef2-be9f-f2a906ed4a26"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan88@gmail.com", "Tuan", "hashed_password_188", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("356cb5e0-979b-4afe-a390-7fa02c0e2ffd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan521@gmail.com", "Tuan", "hashed_password_1521", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("357b7209-f446-407d-990a-f861d444fc5b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan296@gmail.com", "Tuan", "hashed_password_1296", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("35825b12-a865-4d9e-a5a9-e5cb9e657047"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan955@gmail.com", "Tuan", "hashed_password_1955", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("35c4ab52-72d5-4dbe-a84c-5b789db2129a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan323@gmail.com", "Tuan", "hashed_password_1323", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("35f36f46-947a-4c80-9928-d6cfd7ee9ec5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan358@gmail.com", "Tuan", "hashed_password_1358", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("35f7b039-405b-49cd-87b5-0a082cd074ea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan273@gmail.com", "Tuan", "hashed_password_1273", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3609788f-d388-4069-882a-27e5da4f32fe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan873@gmail.com", "Tuan", "hashed_password_1873", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("364e9caf-741b-4edb-a8f5-372cc273006a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan169@gmail.com", "Tuan", "hashed_password_1169", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("366b656e-5f56-4ec1-a8be-95b32c6b5a47"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan240@gmail.com", "Tuan", "hashed_password_1240", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("367ecb69-3928-44d3-86ea-95cd2d2eb748"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan940@gmail.com", "Tuan", "hashed_password_1940", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("368950e5-ed88-485b-9250-24f0a1d8dd64"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan809@gmail.com", "Tuan", "hashed_password_1809", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("36afe926-1f11-4460-9d8a-f31071e05aa5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan165@gmail.com", "Tuan", "hashed_password_1165", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("36d067eb-0e98-4870-a7b7-e6370e6471c4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan500@gmail.com", "Tuan", "hashed_password_1500", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("36e5579d-0b79-4384-ab1e-e6b40c540001"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan151@gmail.com", "Tuan", "hashed_password_1151", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3772d58e-69a7-46c7-a397-1dad8c3cf845"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan184@gmail.com", "Tuan", "hashed_password_1184", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("38293c35-60ed-4ffb-973d-2cafcc1813dd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan300@gmail.com", "Tuan", "hashed_password_1300", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("382cf3f8-3824-4a53-979c-46c9184b787e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan803@gmail.com", "Tuan", "hashed_password_1803", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("388882cf-c161-4c3b-a61f-6f3097eae904"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan255@gmail.com", "Tuan", "hashed_password_1255", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("38a621fb-3ca5-42e3-9e50-bc191df8d3d9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan481@gmail.com", "Tuan", "hashed_password_1481", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("38d51864-9faa-48d8-91fc-800db777a825"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan654@gmail.com", "Tuan", "hashed_password_1654", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("38ee2801-0f1c-4eaf-9a47-43e073f52743"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan368@gmail.com", "Tuan", "hashed_password_1368", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("394188b9-8982-4cb1-a0fe-26c286a1bc98"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan241@gmail.com", "Tuan", "hashed_password_1241", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3955440c-ac67-4e2d-b5c7-3c2ebeed6db0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan549@gmail.com", "Tuan", "hashed_password_1549", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3989fb12-005e-48d4-839f-8fa74570b502"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan127@gmail.com", "Tuan", "hashed_password_1127", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("399c4dc1-fffc-4a9c-a872-2f0c742cbaf7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan812@gmail.com", "Tuan", "hashed_password_1812", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("39a0398f-f372-48b8-9d43-2b8b3189bbee"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan988@gmail.com", "Tuan", "hashed_password_1988", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("39c39ed4-9da5-4a80-afa8-480a24de7d53"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan232@gmail.com", "Tuan", "hashed_password_1232", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("39fecb45-a460-48d1-b68e-a219ac2b8da9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan415@gmail.com", "Tuan", "hashed_password_1415", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3a2e0b3f-606b-4cbc-ac18-1483d32b873a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan573@gmail.com", "Tuan", "hashed_password_1573", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3a314297-ed81-44de-a39c-6b55993ff4f9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan144@gmail.com", "Tuan", "hashed_password_1144", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3a434fac-1eaf-4de0-a8b6-676043477c0b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan257@gmail.com", "Tuan", "hashed_password_1257", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3a5e05f5-4115-4ca5-a386-def5ccf0f5e7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan941@gmail.com", "Tuan", "hashed_password_1941", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3aa20cee-fbf8-4877-811f-56f965793006"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan798@gmail.com", "Tuan", "hashed_password_1798", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3ac67eca-ec17-45a7-b218-6a7055de60a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan620@gmail.com", "Tuan", "hashed_password_1620", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3ac6a506-d8aa-4e99-a196-39ae24ccc74e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan937@gmail.com", "Tuan", "hashed_password_1937", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3b940f62-a4c1-42a1-94e8-0a8fcc374f6b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan898@gmail.com", "Tuan", "hashed_password_1898", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3bc9a3de-e79c-42d8-acbf-9b36e107e31f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan618@gmail.com", "Tuan", "hashed_password_1618", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3bd26b5b-cfb2-4a43-9092-e38f8d42ec48"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan52@gmail.com", "Tuan", "hashed_password_152", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3c0059e7-0197-49a6-9a70-6cffead59f02"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan107@gmail.com", "Tuan", "hashed_password_1107", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3cbafa67-42fb-4c15-9ad3-39e5890709c6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan688@gmail.com", "Tuan", "hashed_password_1688", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3d014c9e-7434-429a-bcc6-ff7a050ae0e6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan308@gmail.com", "Tuan", "hashed_password_1308", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3d1804ae-cb76-4576-a589-f3f8572a7767"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan692@gmail.com", "Tuan", "hashed_password_1692", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3d89d2e8-b738-4532-b26c-0263276014c3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan822@gmail.com", "Tuan", "hashed_password_1822", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3da6bf18-ee89-47a9-b74d-8baf4a23ea3b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan826@gmail.com", "Tuan", "hashed_password_1826", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3da97515-d01f-4ef2-9b54-d177487fd791"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan982@gmail.com", "Tuan", "hashed_password_1982", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3dd71ffb-b470-4a52-8022-9e3ff48abca4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan634@gmail.com", "Tuan", "hashed_password_1634", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3e5072b3-f93c-4fdc-8b64-dcf1f32b99ce"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan38@gmail.com", "Tuan", "hashed_password_138", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3e810a93-d4ce-4f5b-bb8c-c8e9240d2f85"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan119@gmail.com", "Tuan", "hashed_password_1119", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3f2be770-c09d-4171-8a6e-6ca820d77868"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan31@gmail.com", "Tuan", "hashed_password_131", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3f8ddee6-657e-4b21-a9a5-f19de74313f6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan714@gmail.com", "Tuan", "hashed_password_1714", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3ff103b8-a6c3-441d-8b24-0e7ee87d616c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan724@gmail.com", "Tuan", "hashed_password_1724", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("401676d8-ee75-4fb4-bd45-645689d136b6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan6@gmail.com", "Tuan", "hashed_password_16", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("401b85cd-5511-46c7-8a6f-4cb04693aa15"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan762@gmail.com", "Tuan", "hashed_password_1762", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("41090a97-9878-4532-b7ab-2f07aa00ab30"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan491@gmail.com", "Tuan", "hashed_password_1491", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("41277147-3223-47fe-baee-cf17190ef25b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan557@gmail.com", "Tuan", "hashed_password_1557", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("41d0651f-ae98-48ee-9430-ba8b1e7f3d73"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan880@gmail.com", "Tuan", "hashed_password_1880", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("41e4fa23-79cc-4f94-b794-3c1f309e667c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan939@gmail.com", "Tuan", "hashed_password_1939", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4245822a-e9de-4c0f-8ad2-5fb6f9a39936"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan81@gmail.com", "Tuan", "hashed_password_181", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("425ad0d1-9ae3-4e84-9875-fc3784ba2be3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan669@gmail.com", "Tuan", "hashed_password_1669", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("42c2165e-528b-4b01-8d1a-064324e07c42"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan884@gmail.com", "Tuan", "hashed_password_1884", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("42f3b8bc-7525-4f01-8e96-839b4247fc72"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan479@gmail.com", "Tuan", "hashed_password_1479", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("42f8627f-d5a5-4b19-966c-55c6c250e082"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan366@gmail.com", "Tuan", "hashed_password_1366", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("42fbbf12-437c-4701-9d18-5c6b4a4365af"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan904@gmail.com", "Tuan", "hashed_password_1904", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4325b1f6-8a7a-4e6a-b95c-b85e6803f7fc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan202@gmail.com", "Tuan", "hashed_password_1202", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("43ea3727-ddfd-4415-a047-02aae7a4812b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan363@gmail.com", "Tuan", "hashed_password_1363", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("44fde28c-284e-41ae-9ca8-523ba4d9d540"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan568@gmail.com", "Tuan", "hashed_password_1568", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4504b7c3-20ba-436b-8549-00ba49712ecf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan831@gmail.com", "Tuan", "hashed_password_1831", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("45973238-77c4-4842-87e8-6d5b4bd4733e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan919@gmail.com", "Tuan", "hashed_password_1919", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("45a84dd3-5c9c-41f1-a007-54e13c33e08b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan233@gmail.com", "Tuan", "hashed_password_1233", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("45cef68e-6a6d-4bc8-ae55-8d59c39c655d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan139@gmail.com", "Tuan", "hashed_password_1139", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("45de2608-20d1-4799-a371-e655ed43a0c2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan55@gmail.com", "Tuan", "hashed_password_155", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("46139e69-4789-466c-aec6-62e7e7a4d6d7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan749@gmail.com", "Tuan", "hashed_password_1749", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("467682fe-4b1c-43e8-a425-feec428613e2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan97@gmail.com", "Tuan", "hashed_password_197", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("467b1fde-fa0e-454f-b918-e5d2984c31ec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan657@gmail.com", "Tuan", "hashed_password_1657", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("48378692-4849-46aa-a5db-0b1555e9c6c5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan322@gmail.com", "Tuan", "hashed_password_1322", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("48d46676-a91a-4bc5-ae2d-b318961f92cf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan605@gmail.com", "Tuan", "hashed_password_1605", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4945c4f5-3355-4986-a0e2-7c7e4140fdf5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan246@gmail.com", "Tuan", "hashed_password_1246", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("49488fb0-6664-4d13-8814-02a831d2dcb8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan430@gmail.com", "Tuan", "hashed_password_1430", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("495aa64c-b42b-4102-810a-899f2fcdf3c4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan747@gmail.com", "Tuan", "hashed_password_1747", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("49964fc6-9a74-4d2f-bfa3-dccf674062e6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan525@gmail.com", "Tuan", "hashed_password_1525", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("49c397a1-30a6-4746-9828-4e4c108d11ea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan776@gmail.com", "Tuan", "hashed_password_1776", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("49c6e4ac-063d-4540-baf2-62a6045bc46e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan854@gmail.com", "Tuan", "hashed_password_1854", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4a14c8a9-447f-4f70-acb1-5360eb93f111"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan367@gmail.com", "Tuan", "hashed_password_1367", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4a19eadd-5889-4cfc-a67e-f98939a2ae0a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan325@gmail.com", "Tuan", "hashed_password_1325", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4a30f379-b346-4415-aefe-2c297d5a59db"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan829@gmail.com", "Tuan", "hashed_password_1829", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4a5f085f-e7a6-4986-8148-379a1593107d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan686@gmail.com", "Tuan", "hashed_password_1686", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4a7ccb83-24c2-452b-b3e4-83583fafcb3f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan995@gmail.com", "Tuan", "hashed_password_1995", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4a887ace-e946-48b3-912a-8e74192697e0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan968@gmail.com", "Tuan", "hashed_password_1968", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4aa04e82-515c-4118-847a-46d11635a048"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan271@gmail.com", "Tuan", "hashed_password_1271", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4acd54e8-e8db-4aef-8f44-190e05a1a2b3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan434@gmail.com", "Tuan", "hashed_password_1434", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4ad09d72-5e60-4639-928c-996b4dc7c3c6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan630@gmail.com", "Tuan", "hashed_password_1630", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4ad449c9-46ca-4bf7-b7ee-f28c12818aed"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan636@gmail.com", "Tuan", "hashed_password_1636", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4ad896b0-f7ef-4b16-8396-5b9bb3a94dec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan364@gmail.com", "Tuan", "hashed_password_1364", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4b2120a0-971b-43dd-a412-52a505be8e80"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan159@gmail.com", "Tuan", "hashed_password_1159", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4b2e5a4a-d206-4fdd-a272-3a1bff633c6f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan513@gmail.com", "Tuan", "hashed_password_1513", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4b5c9154-d9fe-43ba-aae3-08efcdaad5cf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan576@gmail.com", "Tuan", "hashed_password_1576", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4b5fc487-376f-479d-9752-e37e719171b1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan532@gmail.com", "Tuan", "hashed_password_1532", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4b800371-1cda-46ff-adcc-ee29a9604f6e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan461@gmail.com", "Tuan", "hashed_password_1461", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4b8cbfea-2c22-4fc2-b4b4-2e3d9c2bc36f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan45@gmail.com", "Tuan", "hashed_password_145", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4bbd9f6a-8165-446c-b427-d4f7f145f738"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan464@gmail.com", "Tuan", "hashed_password_1464", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4bd10977-b97a-4d98-9f84-d667a32c1170"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan501@gmail.com", "Tuan", "hashed_password_1501", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4bf687d7-f4ff-4a0d-a1f1-532c213810a4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan227@gmail.com", "Tuan", "hashed_password_1227", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4c4c7b18-5bea-4de1-8154-eae67eb344a0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan37@gmail.com", "Tuan", "hashed_password_137", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4c963bd3-2422-46cf-9890-513e236582e3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan390@gmail.com", "Tuan", "hashed_password_1390", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4d460d72-a9db-467a-b665-2c03dc76fed4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan920@gmail.com", "Tuan", "hashed_password_1920", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4d535239-d113-4190-b871-473652608eec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan215@gmail.com", "Tuan", "hashed_password_1215", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4d6d4d5a-684c-4b7a-9191-07886c62aaee"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan181@gmail.com", "Tuan", "hashed_password_1181", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4dd8d825-34df-4950-93c2-7e0a23fcf0cb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan397@gmail.com", "Tuan", "hashed_password_1397", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4e09354b-ef8e-48db-9478-dbbd8260e420"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan49@gmail.com", "Tuan", "hashed_password_149", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4e0f6f88-83b9-408a-9982-f0a6b1bc785c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan32@gmail.com", "Tuan", "hashed_password_132", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4e247b12-13f8-4b20-a02d-cb1b5925f222"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan563@gmail.com", "Tuan", "hashed_password_1563", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4ecbdad7-b40d-4545-aa6f-825488285540"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan467@gmail.com", "Tuan", "hashed_password_1467", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4fb5bf68-505a-4ecd-8d41-465f1b9b68b3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan445@gmail.com", "Tuan", "hashed_password_1445", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("505f1298-2bf5-4a5d-8e48-c29e66bda564"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan712@gmail.com", "Tuan", "hashed_password_1712", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("509c7ba6-1242-4623-9f30-d10aee076848"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan212@gmail.com", "Tuan", "hashed_password_1212", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("509e2683-c1cf-4ade-8ac6-ea3dc42d2ae0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan468@gmail.com", "Tuan", "hashed_password_1468", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("50a88310-932d-40aa-811b-6cd6df5d7272"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan51@gmail.com", "Tuan", "hashed_password_151", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("50c585c4-6bac-4ae9-9dfb-b5a7359e1d67"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan351@gmail.com", "Tuan", "hashed_password_1351", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("50fee46f-814d-4a8e-bbf6-c1f411505bb7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan64@gmail.com", "Tuan", "hashed_password_164", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("51060fd1-dc4a-4a48-b33c-af018cf185a9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan197@gmail.com", "Tuan", "hashed_password_1197", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("51b2af77-1fd6-4d23-9939-6467b53821c9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan19@gmail.com", "Tuan", "hashed_password_119", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("51caf85d-1ec1-4820-b8d7-59fafe8bca41"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan839@gmail.com", "Tuan", "hashed_password_1839", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5243df0d-8247-47c2-bb5a-92526a875ccd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan506@gmail.com", "Tuan", "hashed_password_1506", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("52c0b555-622b-4bb4-a83e-3898e5842695"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan846@gmail.com", "Tuan", "hashed_password_1846", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("52da5240-69ee-44e6-819c-cfc59d782ba9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan100@gmail.com", "Tuan", "hashed_password_1100", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("53026f79-0c79-473b-9ff8-385410d6d42a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan894@gmail.com", "Tuan", "hashed_password_1894", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("530374a1-d480-4529-aa13-bf649f762566"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan768@gmail.com", "Tuan", "hashed_password_1768", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("53968a68-cac1-4a22-9db6-14a332d808ba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan825@gmail.com", "Tuan", "hashed_password_1825", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("53982a8a-96b4-4419-bc43-3fe5d715d99a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan453@gmail.com", "Tuan", "hashed_password_1453", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("539d6084-a6b7-481e-8aad-230095f30b68"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan459@gmail.com", "Tuan", "hashed_password_1459", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("53c21514-3570-4d16-877b-9df5f95065be"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan842@gmail.com", "Tuan", "hashed_password_1842", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("53e07ae1-dcd8-4c5c-aae0-f150b0584a95"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan989@gmail.com", "Tuan", "hashed_password_1989", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("541d78a8-5fc9-464d-bed1-a11fbb67d1d6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan495@gmail.com", "Tuan", "hashed_password_1495", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("542599df-4ee0-458f-b0f5-671370c43e70"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan529@gmail.com", "Tuan", "hashed_password_1529", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("54709c22-034d-4544-a697-d292e45c328f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan727@gmail.com", "Tuan", "hashed_password_1727", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("549b42ea-dcaf-4f40-bf4b-06628dbbecfb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan860@gmail.com", "Tuan", "hashed_password_1860", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("550941c9-81b2-4b34-a3b5-6b474d8690fb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan852@gmail.com", "Tuan", "hashed_password_1852", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("551b0fc9-ec30-4328-a144-0fac16870c21"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan699@gmail.com", "Tuan", "hashed_password_1699", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("552b971d-5ed7-4f99-a536-d5076eaefb5c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan996@gmail.com", "Tuan", "hashed_password_1996", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("55923e7d-51a8-454f-9a9f-d0c5cf7d9bee"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan757@gmail.com", "Tuan", "hashed_password_1757", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("56a1fe78-df10-4a67-8fb3-c8976cea611d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan871@gmail.com", "Tuan", "hashed_password_1871", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("56ab0240-911a-4bc2-a6a5-44c63f8aac20"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan63@gmail.com", "Tuan", "hashed_password_163", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("56bf318f-47bb-4323-a317-55c1b852f3ae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan856@gmail.com", "Tuan", "hashed_password_1856", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5755d1f1-9402-445a-86ce-d08677ffa0d7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan726@gmail.com", "Tuan", "hashed_password_1726", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("57b03805-3765-4b90-9045-9138b7bcbf16"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan512@gmail.com", "Tuan", "hashed_password_1512", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("57bb97cd-7f2d-463b-b812-e94f36cf6610"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan827@gmail.com", "Tuan", "hashed_password_1827", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5802344b-4da5-43af-a87e-0910dd39b666"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan24@gmail.com", "Tuan", "hashed_password_124", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("583f6e87-ff00-43c9-b970-d9ed37946411"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan847@gmail.com", "Tuan", "hashed_password_1847", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("585aec0b-48b7-4c07-b94a-4b4b517c0179"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan855@gmail.com", "Tuan", "hashed_password_1855", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("58aaffe0-5a5d-47e3-a0c1-e0b45748c1d9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan338@gmail.com", "Tuan", "hashed_password_1338", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("58b515ca-3e0d-4be2-9ee3-f7daa5476090"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan673@gmail.com", "Tuan", "hashed_password_1673", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("58c485a4-fdde-4f6e-a96c-bcaf08df633a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan163@gmail.com", "Tuan", "hashed_password_1163", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("59396186-0f89-48e5-a067-54fe7aa3c5e8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan118@gmail.com", "Tuan", "hashed_password_1118", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("599858f3-b13c-4a2c-873e-ac5662b9a6d6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan850@gmail.com", "Tuan", "hashed_password_1850", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("59c9a9c7-8d2b-4914-a40a-a14fcc0f4abe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan266@gmail.com", "Tuan", "hashed_password_1266", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("59dd1712-ac69-4611-9877-2eb423a0e63e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan655@gmail.com", "Tuan", "hashed_password_1655", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5a03637f-b210-4124-9a1d-51f13fdc122f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan670@gmail.com", "Tuan", "hashed_password_1670", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5a1cdad8-6693-40b2-8eb1-9ee1afa11f1e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan520@gmail.com", "Tuan", "hashed_password_1520", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5a2c84b9-65d4-47ad-8c18-0c4d812bdc42"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan958@gmail.com", "Tuan", "hashed_password_1958", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5a33bbb7-b44b-47cb-b722-2c99c2f30e15"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan935@gmail.com", "Tuan", "hashed_password_1935", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5add45e1-2da1-412a-9692-ef995b3b56d5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan56@gmail.com", "Tuan", "hashed_password_156", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5aea7a58-481d-4867-bb6d-a691a692e168"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan191@gmail.com", "Tuan", "hashed_password_1191", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5b329883-a290-432a-8adf-0d31b8b38b45"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan607@gmail.com", "Tuan", "hashed_password_1607", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5b32f780-7a81-4878-873e-64f12b06ec5a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan186@gmail.com", "Tuan", "hashed_password_1186", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5b4e6215-3d84-4990-9b86-bf3bb65b59af"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan310@gmail.com", "Tuan", "hashed_password_1310", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5bec1325-63b8-4a9c-b855-ebebec80e5be"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan558@gmail.com", "Tuan", "hashed_password_1558", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5becaf4c-de79-487c-a4a1-ce7278def0d0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan671@gmail.com", "Tuan", "hashed_password_1671", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5c9fae50-7af8-47e7-bde6-a25e3111cea1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan198@gmail.com", "Tuan", "hashed_password_1198", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5caf8bae-dec0-426b-9c68-4c35f9acc5f5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan961@gmail.com", "Tuan", "hashed_password_1961", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5cdf41d4-b321-4852-98f1-b4377415af07"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan791@gmail.com", "Tuan", "hashed_password_1791", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5cefcaec-e83a-4f13-8a5d-9388e25acccc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan778@gmail.com", "Tuan", "hashed_password_1778", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5cf5942b-3b3b-45b4-a94c-f912ff110e5a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan543@gmail.com", "Tuan", "hashed_password_1543", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5d0a73df-c7fe-4bc5-b780-516914e18f0c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan117@gmail.com", "Tuan", "hashed_password_1117", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5d9f8da0-dffd-4b78-bda4-ae4501bcfdea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan990@gmail.com", "Tuan", "hashed_password_1990", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5dc8b8b3-dc69-4e86-852b-ea4279f3f8c3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan698@gmail.com", "Tuan", "hashed_password_1698", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5ec77c4d-261f-40eb-8aa4-a5f7884bc657"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan57@gmail.com", "Tuan", "hashed_password_157", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5ede7bf5-6a1f-4281-8355-eb72deb76411"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan705@gmail.com", "Tuan", "hashed_password_1705", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5edf5362-eb64-401e-8bf7-3e8cbcdcd5b9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan959@gmail.com", "Tuan", "hashed_password_1959", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5f42d7c4-5c7b-4d7d-a304-724563619c83"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan98@gmail.com", "Tuan", "hashed_password_198", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5f474b3a-b23d-4de4-9b7a-0f9fb1598277"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan179@gmail.com", "Tuan", "hashed_password_1179", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5f57a44d-4f61-4a20-8701-67289a8d4b98"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan387@gmail.com", "Tuan", "hashed_password_1387", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5f8db21e-9512-4cf8-9c55-7aa50ccf37e6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan236@gmail.com", "Tuan", "hashed_password_1236", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5fa5283b-ad31-479c-b991-54cef2ad5348"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan180@gmail.com", "Tuan", "hashed_password_1180", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5ff6620c-1908-4e05-ab60-740fecc045bc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan700@gmail.com", "Tuan", "hashed_password_1700", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("600e56c2-581d-41fc-9f39-130cbcb021ec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan214@gmail.com", "Tuan", "hashed_password_1214", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("607b567b-b348-44d5-aa4f-d2df790e322c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan650@gmail.com", "Tuan", "hashed_password_1650", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("60c933b2-e144-43f1-9a58-c88b08ed0eb7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan890@gmail.com", "Tuan", "hashed_password_1890", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("61cd4ebc-8a9d-4481-b716-4cffe21b853a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan679@gmail.com", "Tuan", "hashed_password_1679", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("621f6c81-234e-41fd-a813-6d273d009d70"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan39@gmail.com", "Tuan", "hashed_password_139", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("629acff5-ae8c-499c-affe-c901da9f03e2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan115@gmail.com", "Tuan", "hashed_password_1115", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("62b25ca3-f16d-4e72-a824-5c0ce2f25f66"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan612@gmail.com", "Tuan", "hashed_password_1612", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("62f08aac-2fa8-451a-8ca6-3de5312c1935"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan675@gmail.com", "Tuan", "hashed_password_1675", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("62f58655-4eeb-4df8-958c-6bd270e1eec4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan443@gmail.com", "Tuan", "hashed_password_1443", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("63b0c941-066d-4c51-aee7-572df83af082"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan269@gmail.com", "Tuan", "hashed_password_1269", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("63b8a1d5-4cc7-4fbb-8c7a-da7ae00d42db"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan870@gmail.com", "Tuan", "hashed_password_1870", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("63be2638-4090-4ae0-acb8-7af185bba10c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan765@gmail.com", "Tuan", "hashed_password_1765", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("63d659d0-5c43-4e90-9383-e084fa666fb4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan637@gmail.com", "Tuan", "hashed_password_1637", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("63ec1013-73cd-49d6-9e9d-c6d47f201944"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan283@gmail.com", "Tuan", "hashed_password_1283", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("63f13a78-5f04-445a-8455-8e3644bb8a07"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan979@gmail.com", "Tuan", "hashed_password_1979", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("64001ae4-4402-4f7f-a007-295147d3ebbf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan942@gmail.com", "Tuan", "hashed_password_1942", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("640cc5e8-9659-4fac-a8fa-e848146fd040"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan653@gmail.com", "Tuan", "hashed_password_1653", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("64200406-4c7f-4f08-b9c5-337efb9e4a63"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan515@gmail.com", "Tuan", "hashed_password_1515", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("644991d3-aa7b-4da5-9b7b-b6513b4196c0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan738@gmail.com", "Tuan", "hashed_password_1738", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6454d2a1-076f-4ac7-add0-86ee692a973a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan207@gmail.com", "Tuan", "hashed_password_1207", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("64afe375-588c-450f-8571-cdef2b8584b0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan566@gmail.com", "Tuan", "hashed_password_1566", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("64ba3551-951d-47be-b75b-e52e51157c8d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan976@gmail.com", "Tuan", "hashed_password_1976", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("65028abf-d554-4d83-b51f-b58bbf958e2c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan858@gmail.com", "Tuan", "hashed_password_1858", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("650e6a1f-d3ca-4792-a121-53e25b5fb930"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan392@gmail.com", "Tuan", "hashed_password_1392", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6524e961-b58e-4111-86c2-a6eefcb2106a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan672@gmail.com", "Tuan", "hashed_password_1672", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("657042f7-cb01-4c43-87fc-f49f98d80b49"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan975@gmail.com", "Tuan", "hashed_password_1975", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("661c2fc4-dfee-4ecb-a8e2-106f24613afb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan278@gmail.com", "Tuan", "hashed_password_1278", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("661ce3df-f5f9-4116-8c99-d7d7d702c917"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan970@gmail.com", "Tuan", "hashed_password_1970", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6649b4ed-9db2-42bc-8983-e8caca18ef28"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan178@gmail.com", "Tuan", "hashed_password_1178", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("669d1302-ce14-45e8-bc7a-e97458ae8c95"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan301@gmail.com", "Tuan", "hashed_password_1301", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("66cc80cf-e1b0-4028-913c-732daa87cfa0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan819@gmail.com", "Tuan", "hashed_password_1819", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("67402eb9-dc8d-44ee-bc5c-b188f636e7d6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan79@gmail.com", "Tuan", "hashed_password_179", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("67cda767-ea3b-40f5-88d8-c5c1e15298c4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan780@gmail.com", "Tuan", "hashed_password_1780", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6802d646-c192-4028-a373-99363276de0b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan435@gmail.com", "Tuan", "hashed_password_1435", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("68130c2e-f27e-44cc-a103-316c55cb6141"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan438@gmail.com", "Tuan", "hashed_password_1438", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("68142f51-7351-4d8b-a070-e3a19f1434a7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan340@gmail.com", "Tuan", "hashed_password_1340", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("68389741-8536-4236-b4c3-b8d9ff45876a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan928@gmail.com", "Tuan", "hashed_password_1928", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("685ba98f-f622-4d9b-943e-5f56e5b681fe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan628@gmail.com", "Tuan", "hashed_password_1628", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("687aa918-4988-4539-bf21-9af27d76076d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan192@gmail.com", "Tuan", "hashed_password_1192", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("68c89e4b-4d6a-42da-852c-c792b8d42720"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan781@gmail.com", "Tuan", "hashed_password_1781", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("68efc816-f41a-4119-a073-eab2508ecd7d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan321@gmail.com", "Tuan", "hashed_password_1321", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6a0b33fa-e8e4-4fb2-afd5-fbf10bc29dae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan224@gmail.com", "Tuan", "hashed_password_1224", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6a2860f3-987a-4cfb-952c-b7f2fa402d32"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan487@gmail.com", "Tuan", "hashed_password_1487", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6a5f6c15-2a64-47a8-a73e-57bbac076f26"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan84@gmail.com", "Tuan", "hashed_password_184", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6a938e40-f4ef-49a8-89db-a9ed8b9336ea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan173@gmail.com", "Tuan", "hashed_password_1173", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6aca0c2d-1f6f-4c9f-98ab-a03ab108264b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan326@gmail.com", "Tuan", "hashed_password_1326", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6ad645d3-86e9-4250-843c-9f313ee7f7c6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan517@gmail.com", "Tuan", "hashed_password_1517", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6ade0f23-018c-425f-8bb5-3d44060f0c4a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan27@gmail.com", "Tuan", "hashed_password_127", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6b9058ca-62df-43a4-8e34-13b76e22c9c3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan997@gmail.com", "Tuan", "hashed_password_1997", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6bbdeb3b-3c4a-497a-9428-704c1a6275f9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan401@gmail.com", "Tuan", "hashed_password_1401", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6c2af558-03c2-4d16-9e02-6cb25d99d3cc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan158@gmail.com", "Tuan", "hashed_password_1158", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6c377da6-4898-4a5e-99a0-2c3104240a3a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan263@gmail.com", "Tuan", "hashed_password_1263", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6c560de6-0fbe-4b7a-89d5-e5dcc86da35a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuanle17062k6@gmail.com", "Tuan", "hashed_password_1", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6c8d0ab1-2567-453f-8588-dbceb5ba7939"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan885@gmail.com", "Tuan", "hashed_password_1885", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6d07e0f2-1688-4aef-9a66-7921fdcd7661"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan406@gmail.com", "Tuan", "hashed_password_1406", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6d275be9-923a-4f33-83b7-4488ce9920ec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan141@gmail.com", "Tuan", "hashed_password_1141", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6d761106-9847-4061-897f-39d87be47fd6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan931@gmail.com", "Tuan", "hashed_password_1931", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6d87ea65-bf97-4048-b84c-560bedcf388d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan268@gmail.com", "Tuan", "hashed_password_1268", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6d92368a-9648-4273-8de1-18fd0979428c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan925@gmail.com", "Tuan", "hashed_password_1925", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6e9daced-cb8f-45a6-9ec2-d877031424e8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan306@gmail.com", "Tuan", "hashed_password_1306", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6eba078a-82ae-474f-80d0-bf2061ba4fcf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan30@gmail.com", "Tuan", "hashed_password_130", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6f2ff25c-5f3f-47c8-a436-0c999c145733"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan647@gmail.com", "Tuan", "hashed_password_1647", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6f5cbca2-d4cb-4eda-839d-7f07b34c053b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan297@gmail.com", "Tuan", "hashed_password_1297", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6f6c01ed-2370-442d-b3c3-88200f915889"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan168@gmail.com", "Tuan", "hashed_password_1168", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6f8abe00-e895-4a74-b15c-5b492cca826d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan585@gmail.com", "Tuan", "hashed_password_1585", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6f9ee627-aef4-4c78-9a97-a4d59bb68872"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan893@gmail.com", "Tuan", "hashed_password_1893", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("700e87eb-2706-408e-b843-b3ec618f57aa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan615@gmail.com", "Tuan", "hashed_password_1615", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("702a7e62-ad49-41a3-b49a-dad8a51ad210"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan571@gmail.com", "Tuan", "hashed_password_1571", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("70aaba2b-9be3-4c33-8835-d3e8fc842f20"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan490@gmail.com", "Tuan", "hashed_password_1490", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("70d22466-372b-4216-b432-3c40dc37e141"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan334@gmail.com", "Tuan", "hashed_password_1334", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("70f02ede-db55-416a-8187-265df9fef3f5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan122@gmail.com", "Tuan", "hashed_password_1122", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("718098fe-56cb-44ca-aa37-ca5b135d9044"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan764@gmail.com", "Tuan", "hashed_password_1764", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("71c15bab-e1dc-49be-bf68-0e29bb035210"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan424@gmail.com", "Tuan", "hashed_password_1424", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("725ec42b-1000-4827-91de-064d79b01aca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan538@gmail.com", "Tuan", "hashed_password_1538", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("725fc269-c156-42ce-a35e-54f80fe4b3d3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan530@gmail.com", "Tuan", "hashed_password_1530", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("72d0149b-5220-47d6-a6ba-e267bafd48fc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan73@gmail.com", "Tuan", "hashed_password_173", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("72de92f9-a655-4ea8-bf7f-a376582cbd03"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan596@gmail.com", "Tuan", "hashed_password_1596", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7332e6cb-3d51-4004-a6f3-fc8545168027"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan43@gmail.com", "Tuan", "hashed_password_143", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("73628efb-00f4-43b9-8cae-96e0bcbbcaf8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan818@gmail.com", "Tuan", "hashed_password_1818", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("73780bab-8276-4955-a190-83ff712f8d55"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan604@gmail.com", "Tuan", "hashed_password_1604", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("737dbab8-0289-4155-90eb-ed5c868b41be"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan746@gmail.com", "Tuan", "hashed_password_1746", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("73c034e7-2fa3-4f42-8735-bc7c11acb62a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan58@gmail.com", "Tuan", "hashed_password_158", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7473c3ac-d85e-4306-96a7-3bf5054581b4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan816@gmail.com", "Tuan", "hashed_password_1816", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("749e5fa5-81a6-443f-a3f7-8c55f316327a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan593@gmail.com", "Tuan", "hashed_password_1593", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("752555a5-a1ae-44bb-9800-370d3b2f521f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan40@gmail.com", "Tuan", "hashed_password_140", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("75926091-efe9-41ae-ae72-986104098517"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan599@gmail.com", "Tuan", "hashed_password_1599", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("75ad2afb-5f64-4427-a11d-3003835b259a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan7@gmail.com", "Tuan", "hashed_password_17", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("75c85df1-9d4e-4d58-b967-311473ccd19e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan577@gmail.com", "Tuan", "hashed_password_1577", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("75eca885-29d4-4ca1-b475-9a24ee23c18a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan519@gmail.com", "Tuan", "hashed_password_1519", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("75f4ee68-a92b-4e20-80e1-1fff65441ac2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan767@gmail.com", "Tuan", "hashed_password_1767", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7612d885-4700-4500-b6a4-d13d0abbdb16"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan62@gmail.com", "Tuan", "hashed_password_162", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("763f61e9-bc32-483b-a5ff-d1ae71c08a6e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan183@gmail.com", "Tuan", "hashed_password_1183", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("76cbbf8d-98ac-4222-852a-e09259bcebdb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan142@gmail.com", "Tuan", "hashed_password_1142", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7725390f-c03a-496c-a0f9-f79d76b281ca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan678@gmail.com", "Tuan", "hashed_password_1678", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("773b1ad3-47d4-4528-b1af-c84928c73f0c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan729@gmail.com", "Tuan", "hashed_password_1729", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("77659b18-4ead-4824-a20c-639e41ef24f2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan288@gmail.com", "Tuan", "hashed_password_1288", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("777039a9-0791-4f36-86e5-f0b7e7046f04"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan741@gmail.com", "Tuan", "hashed_password_1741", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("77edfc3a-e475-41a7-b8fe-59b6940f72fc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan329@gmail.com", "Tuan", "hashed_password_1329", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("783abff3-415e-49b8-8f76-f51726eb0229"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan499@gmail.com", "Tuan", "hashed_password_1499", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("78b86998-48a3-4701-8f4b-81bb306f3d31"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan693@gmail.com", "Tuan", "hashed_password_1693", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7903b74e-a412-4bf6-bf14-0f3a94b68f70"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan229@gmail.com", "Tuan", "hashed_password_1229", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7915d9fa-18b8-4b0e-8252-42ee82010721"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan930@gmail.com", "Tuan", "hashed_password_1930", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("79822bf1-29ae-41e2-8e3a-adc16da1ca8e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan943@gmail.com", "Tuan", "hashed_password_1943", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7a5ea3e7-5111-4619-b4d4-eea65407033f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan287@gmail.com", "Tuan", "hashed_password_1287", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7a97a727-495f-4c4f-b1e4-0d7cf54ca5ed"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan298@gmail.com", "Tuan", "hashed_password_1298", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7af0eae0-a5c9-4627-958a-d1dbe66da757"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan981@gmail.com", "Tuan", "hashed_password_1981", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7b9d8cb9-bab2-4f6a-a38d-b38f852dbf86"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan872@gmail.com", "Tuan", "hashed_password_1872", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7bc5e951-3fce-475b-8ff0-e3f30798bf19"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan998@gmail.com", "Tuan", "hashed_password_1998", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7bda50d5-844c-42f1-82f9-76aa911a2000"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan575@gmail.com", "Tuan", "hashed_password_1575", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7c12bf22-56c5-4528-b37d-62badd5501d6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan834@gmail.com", "Tuan", "hashed_password_1834", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7c27fd41-41cc-4196-9853-215439cb21ec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan162@gmail.com", "Tuan", "hashed_password_1162", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7c78c6d5-ece3-4307-b664-470261fc41f2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan441@gmail.com", "Tuan", "hashed_password_1441", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7d0c735d-af2f-4961-bb26-a7e2a5abe09e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan305@gmail.com", "Tuan", "hashed_password_1305", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7d1e1230-b48a-4c26-88c8-eba3254a4e8e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan335@gmail.com", "Tuan", "hashed_password_1335", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7d27ff2f-1661-464f-a0a5-154cceb39e05"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan293@gmail.com", "Tuan", "hashed_password_1293", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7d7825f4-cad0-4aa9-ad48-229796dc3df5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan685@gmail.com", "Tuan", "hashed_password_1685", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7dab1d48-d585-4940-acee-1ee0dbf59958"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan65@gmail.com", "Tuan", "hashed_password_165", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7e194b5f-e35f-4c48-8c66-6be544f988e6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan572@gmail.com", "Tuan", "hashed_password_1572", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7e4e59cc-e97d-4e78-91b0-829b96dfa8df"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan600@gmail.com", "Tuan", "hashed_password_1600", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7e5e58f8-c95e-4c0b-8512-050b592741c0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan44@gmail.com", "Tuan", "hashed_password_144", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7ecedc9e-cde4-4d0b-bb52-394c81d06289"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan350@gmail.com", "Tuan", "hashed_password_1350", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7f02804b-a49f-4257-a517-85c612f2a9c7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan156@gmail.com", "Tuan", "hashed_password_1156", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7f43836b-9209-40b0-9636-b42eb267dda2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan82@gmail.com", "Tuan", "hashed_password_182", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7f4b2825-f58b-46b9-aa9f-488562ac47aa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan346@gmail.com", "Tuan", "hashed_password_1346", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7f8b06b5-15cc-461e-9e1f-06db765b2d37"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan837@gmail.com", "Tuan", "hashed_password_1837", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7fa6f430-ce06-4ecb-8cc3-55f1258dd9ad"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan242@gmail.com", "Tuan", "hashed_password_1242", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7fac599d-b02d-4e84-a570-6b8a007ac709"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan258@gmail.com", "Tuan", "hashed_password_1258", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7fb01a19-f927-4c84-b78d-4507d918ed54"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan917@gmail.com", "Tuan", "hashed_password_1917", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("803c2f82-fce4-4d0e-be76-ac4561f6d9d4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan908@gmail.com", "Tuan", "hashed_password_1908", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("80c278aa-88b2-4249-babb-47b5dcaab03c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan42@gmail.com", "Tuan", "hashed_password_142", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("814281f1-8b24-4e7c-9fc0-59580d4e5459"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan991@gmail.com", "Tuan", "hashed_password_1991", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8189d667-c718-4ad2-bf84-69c65272f08c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan206@gmail.com", "Tuan", "hashed_password_1206", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("81aed105-7fa2-4bcb-a5fb-d067d1a5028c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan256@gmail.com", "Tuan", "hashed_password_1256", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("81e8dee8-cae6-46b4-8490-fefc501a89f5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan786@gmail.com", "Tuan", "hashed_password_1786", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("820969ba-214e-4e7c-a99e-2981a2bb3b2d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan565@gmail.com", "Tuan", "hashed_password_1565", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("821f6dc6-a245-4a79-94e7-59074a639cd8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan793@gmail.com", "Tuan", "hashed_password_1793", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("82955597-5c90-48fb-bdb2-511d43505c85"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan643@gmail.com", "Tuan", "hashed_password_1643", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("83272256-73d0-4ec3-9e74-04abf05ca2ae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan849@gmail.com", "Tuan", "hashed_password_1849", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8327b482-ed9f-4f34-9b20-be17f5380265"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan697@gmail.com", "Tuan", "hashed_password_1697", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("83448cd6-e42d-49b2-b141-24d08874626f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan581@gmail.com", "Tuan", "hashed_password_1581", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("835a45e2-d4c1-4668-a577-bf479ba16e27"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan953@gmail.com", "Tuan", "hashed_password_1953", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("83bab315-e107-4c0f-b459-14115875a2b0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan761@gmail.com", "Tuan", "hashed_password_1761", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("83c8a4c8-6140-48e9-848e-7b2e53868062"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan193@gmail.com", "Tuan", "hashed_password_1193", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("83d60bb5-f4b5-4138-a692-b5bec7457f37"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan336@gmail.com", "Tuan", "hashed_password_1336", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8425305e-9103-43a1-b02e-b619d2d3ba20"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan952@gmail.com", "Tuan", "hashed_password_1952", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8429b260-6695-4f09-9034-c240a8898479"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan314@gmail.com", "Tuan", "hashed_password_1314", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("846c6a2c-a0c5-45b3-bacf-e7dfeae7acb8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan844@gmail.com", "Tuan", "hashed_password_1844", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("848eaaa4-10a2-4d91-83a3-0e2ead358a04"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan176@gmail.com", "Tuan", "hashed_password_1176", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("84e608bb-ebab-4b82-9546-72b749a5a298"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan170@gmail.com", "Tuan", "hashed_password_1170", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8573dea2-4142-4b02-834c-836e029fe201"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan977@gmail.com", "Tuan", "hashed_password_1977", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("85ba0f65-918b-4f2d-b2f5-997c8339bed1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan483@gmail.com", "Tuan", "hashed_password_1483", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("86012e51-d6c2-4ddf-8a8a-496e69247081"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan906@gmail.com", "Tuan", "hashed_password_1906", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("86126120-68b3-4ad3-8303-f6cf7ff03bfb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan598@gmail.com", "Tuan", "hashed_password_1598", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8617f374-d303-42d2-921d-b388e86909d1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan994@gmail.com", "Tuan", "hashed_password_1994", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("86a2c45d-2be3-42b5-8b4d-bb7346ca5f58"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan319@gmail.com", "Tuan", "hashed_password_1319", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("86bf7cd8-d802-4f4b-adf6-721f4ec7ca08"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan46@gmail.com", "Tuan", "hashed_password_146", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("86d12578-f205-4300-af3d-f983d6c6da79"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan482@gmail.com", "Tuan", "hashed_password_1482", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("872068b1-0188-43e2-b054-0d18378b8260"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan185@gmail.com", "Tuan", "hashed_password_1185", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("87255510-b9ef-4cf9-976c-c848114bf454"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan927@gmail.com", "Tuan", "hashed_password_1927", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("87c559be-8c65-42c2-8100-d1e76a2125d5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan808@gmail.com", "Tuan", "hashed_password_1808", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("881993dc-d7b7-4aaa-8627-76747e05d1f3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan4@gmail.com", "Tuan", "hashed_password_14", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("883d8794-aa41-4e8d-bb0a-263fa0e37abe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan718@gmail.com", "Tuan", "hashed_password_1718", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("891cc79f-203a-42ef-b6c9-3f5e349c8ac6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan137@gmail.com", "Tuan", "hashed_password_1137", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("896051ed-82b9-418d-a7ed-3b440c6cd3e7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan617@gmail.com", "Tuan", "hashed_password_1617", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8961dc03-5b4c-42dc-a7f5-ae9d65d224d4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan41@gmail.com", "Tuan", "hashed_password_141", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8a3831ed-7938-4402-91f5-bad7e0a3cd15"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan606@gmail.com", "Tuan", "hashed_password_1606", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8a60380b-f725-4541-94a8-ff07cbe637f4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan561@gmail.com", "Tuan", "hashed_password_1561", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8a73d2c0-dad3-4c2e-a660-f0d616dc5da8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan907@gmail.com", "Tuan", "hashed_password_1907", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8ab07a4f-7b8f-4124-8164-703992b5153d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan201@gmail.com", "Tuan", "hashed_password_1201", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8b3a78e2-56d5-4e4c-bea2-55a56f093971"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan897@gmail.com", "Tuan", "hashed_password_1897", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8bc8e38d-3f1c-43f5-a390-308f558d709d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan570@gmail.com", "Tuan", "hashed_password_1570", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8c2382b5-32a7-48ce-af1e-829fb15a5f5f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan295@gmail.com", "Tuan", "hashed_password_1295", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8c341f34-4f8d-4fb2-b8db-af1e33c86874"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan138@gmail.com", "Tuan", "hashed_password_1138", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8c88aded-6d38-4d44-b24a-02983bd33a6f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan578@gmail.com", "Tuan", "hashed_password_1578", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8ce515b8-272c-4d92-91a5-11120d58e2c4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan9@gmail.com", "Tuan", "hashed_password_19", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8d0e23f1-6bcb-47f1-8746-95588142866a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan80@gmail.com", "Tuan", "hashed_password_180", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8d71a4e3-f1fd-452f-bf7a-e3f67ee10c29"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan289@gmail.com", "Tuan", "hashed_password_1289", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8dd9efe8-b7c2-403c-80da-dabe452c414a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan174@gmail.com", "Tuan", "hashed_password_1174", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8e1d6491-e0cd-441c-bd76-47561c338d01"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan687@gmail.com", "Tuan", "hashed_password_1687", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8e999760-76ed-4522-9b70-4630b90aa33d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan472@gmail.com", "Tuan", "hashed_password_1472", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8ec5a782-fd54-48c8-8134-399e3813896b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan131@gmail.com", "Tuan", "hashed_password_1131", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9022318e-cf9e-4802-a0c9-c0d71093599b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan463@gmail.com", "Tuan", "hashed_password_1463", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("90844faa-7031-411d-b9ff-946f3b9e1a6d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan719@gmail.com", "Tuan", "hashed_password_1719", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9087bc24-3a6e-47b7-82bc-6b5b9dd61c56"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan373@gmail.com", "Tuan", "hashed_password_1373", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("90a7707b-2ab5-47b3-a02c-7c6b6d1e9ad5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan531@gmail.com", "Tuan", "hashed_password_1531", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("90acb455-b846-4a34-ab32-fc52fe9731c7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan551@gmail.com", "Tuan", "hashed_password_1551", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("925451a8-6d78-484b-b9a4-8fd07225f5c5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan440@gmail.com", "Tuan", "hashed_password_1440", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9266d540-613a-46c9-b4fa-f8ca3bceaeb8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan966@gmail.com", "Tuan", "hashed_password_1966", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9273d397-5aaa-4594-9b86-8b34bff16637"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan667@gmail.com", "Tuan", "hashed_password_1667", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("931509a2-1c45-4257-a833-fd7746d6a97f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan380@gmail.com", "Tuan", "hashed_password_1380", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("932b96f6-2c5e-461a-b9af-44a7b80505b8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan150@gmail.com", "Tuan", "hashed_password_1150", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9378c422-08e4-4f76-8ecf-b4f3f0e9098a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan265@gmail.com", "Tuan", "hashed_password_1265", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("939ce94b-b9a9-40f5-8b1d-e367e5bca4d4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan771@gmail.com", "Tuan", "hashed_password_1771", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("944b392e-773f-4a78-8c12-d7e954e7b63d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan542@gmail.com", "Tuan", "hashed_password_1542", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9475e48d-3d34-40d1-809d-0f2b4ef44859"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan541@gmail.com", "Tuan", "hashed_password_1541", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("94ec1541-5200-4276-bca0-232b4f62ce31"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan922@gmail.com", "Tuan", "hashed_password_1922", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9591021e-f281-40cc-90a0-f8df145687c9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan756@gmail.com", "Tuan", "hashed_password_1756", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("95f34d6f-dec9-4da0-9a8e-490b11fa1e1d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan703@gmail.com", "Tuan", "hashed_password_1703", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("963f94b2-74e0-4c0d-92ef-65f766206bf6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan706@gmail.com", "Tuan", "hashed_password_1706", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("96552daa-6bac-4a55-bc86-2501a00e8887"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan555@gmail.com", "Tuan", "hashed_password_1555", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("96920f04-cb21-4000-8399-38e0277f3d04"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan841@gmail.com", "Tuan", "hashed_password_1841", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9695b8b0-41b3-4df0-9b4f-6800b887bcb8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan694@gmail.com", "Tuan", "hashed_password_1694", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("96aa42d3-f69d-4e20-ac79-9ca987ab0c4e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan983@gmail.com", "Tuan", "hashed_password_1983", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("972654f9-ee02-432a-abed-9915a396892a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan267@gmail.com", "Tuan", "hashed_password_1267", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("97a786d0-726a-46c8-bbf7-a0aaf97c6991"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan120@gmail.com", "Tuan", "hashed_password_1120", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("97a83c82-edb7-4364-8dd8-7754819bd1a4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan869@gmail.com", "Tuan", "hashed_password_1869", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9883c26e-81fa-4798-a836-b971435034a5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan787@gmail.com", "Tuan", "hashed_password_1787", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9885dd16-2682-49fc-8198-59e1d662f208"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan878@gmail.com", "Tuan", "hashed_password_1878", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("989be3c5-1528-4b6e-b293-8c0eef7c08c7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan447@gmail.com", "Tuan", "hashed_password_1447", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("98a523eb-c0b3-4201-a758-6f98aed21e2a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan859@gmail.com", "Tuan", "hashed_password_1859", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("98c907f1-8141-4128-8a44-5885664d9960"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan460@gmail.com", "Tuan", "hashed_password_1460", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("991ede39-3960-4bb1-b441-4954b714c060"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan769@gmail.com", "Tuan", "hashed_password_1769", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("99290f4f-4bbd-4931-9b2d-9908b0ad1975"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan548@gmail.com", "Tuan", "hashed_password_1548", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("996ecc35-91e9-4150-b06b-10bd5d612e3b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan865@gmail.com", "Tuan", "hashed_password_1865", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("99f5b08a-6bc7-4cd3-b479-25499be125c6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan582@gmail.com", "Tuan", "hashed_password_1582", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9a0c5ad0-f764-418d-853f-bfaaa61ae595"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan708@gmail.com", "Tuan", "hashed_password_1708", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9a5dc9f1-1102-4d7b-bad7-518184f4bcb0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan307@gmail.com", "Tuan", "hashed_password_1307", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9aa2c128-8300-4857-a081-48cafa9119ce"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan713@gmail.com", "Tuan", "hashed_password_1713", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9aa9c71b-370d-49b0-a1e9-f523204b7cdd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan720@gmail.com", "Tuan", "hashed_password_1720", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9abd3b71-e39b-444e-910c-1e04136723fc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan140@gmail.com", "Tuan", "hashed_password_1140", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9acd92bf-a587-4aa4-989b-4ab2ac63cfec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan721@gmail.com", "Tuan", "hashed_password_1721", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9acf01bb-1bde-4cb0-a82e-810447eefb49"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan419@gmail.com", "Tuan", "hashed_password_1419", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9aec1b79-8924-410d-9529-0a4b810a19a5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan384@gmail.com", "Tuan", "hashed_password_1384", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9b50fb87-29d3-430f-8329-5ad6f45918f2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan370@gmail.com", "Tuan", "hashed_password_1370", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9b6d4b07-6554-4c16-9960-c3228161a148"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan90@gmail.com", "Tuan", "hashed_password_190", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9c7d9c81-d645-4eaf-ad39-a8845a4df7f3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan790@gmail.com", "Tuan", "hashed_password_1790", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9cc9f4fa-8f54-4014-955c-e48a14e0e390"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan950@gmail.com", "Tuan", "hashed_password_1950", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9ce1e490-c568-4467-935d-d662813a3afb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan862@gmail.com", "Tuan", "hashed_password_1862", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9cecd02f-66a6-4d6a-aaa2-e1307c7793f0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan748@gmail.com", "Tuan", "hashed_password_1748", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9d0ef5c0-13bc-4de6-8c5f-3d8e349c5f24"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan504@gmail.com", "Tuan", "hashed_password_1504", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9d2f4d52-a9eb-4130-8320-3af7cca33cc8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan439@gmail.com", "Tuan", "hashed_password_1439", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9d6036bc-6363-4549-a5bb-5d1dbf660414"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan17@gmail.com", "Tuan", "hashed_password_117", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9d952c05-153a-4912-8874-9884053b95e9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan984@gmail.com", "Tuan", "hashed_password_1984", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9d99694e-cbdf-4bce-8b0a-5f8b5e074813"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan770@gmail.com", "Tuan", "hashed_password_1770", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9db661d7-76b2-449e-bc7f-6f32b977591d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan814@gmail.com", "Tuan", "hashed_password_1814", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9dc508c4-9733-4b01-817e-4c1922c8acda"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan290@gmail.com", "Tuan", "hashed_password_1290", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9de8fc3b-af63-4d68-b3d3-444e20c63928"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuanle17062k5@gmail.com", "Tuan", "hashed_password_1", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9e172b50-ad2b-45a5-90bc-3d3f82b2aeef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan861@gmail.com", "Tuan", "hashed_password_1861", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9e2472ee-bab4-4b6c-be1c-262ce47e6a7c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan234@gmail.com", "Tuan", "hashed_password_1234", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9e3622a7-7990-4e83-a436-3c9ec555609b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan640@gmail.com", "Tuan", "hashed_password_1640", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9e3be7f0-f834-4bba-a8c1-90668cb72b83"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan282@gmail.com", "Tuan", "hashed_password_1282", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9e57f33f-eae3-4013-98b0-28c41d772b46"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan508@gmail.com", "Tuan", "hashed_password_1508", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9ea8f2e8-130b-49a2-86e9-f7866e3ef18f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan497@gmail.com", "Tuan", "hashed_password_1497", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9ebf03f7-5b94-49f2-ae2c-b95d84c38c70"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan923@gmail.com", "Tuan", "hashed_password_1923", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9fc9a413-e5b5-4d59-b6e2-a58640040ffa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan978@gmail.com", "Tuan", "hashed_password_1978", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9fe7f46c-49e9-40d1-85b3-d3d04f69d640"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan526@gmail.com", "Tuan", "hashed_password_1526", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a005e41b-dfc6-409d-862e-bea5645a1815"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan632@gmail.com", "Tuan", "hashed_password_1632", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a06e1120-3bcc-44df-b934-c673cfbfb87f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan544@gmail.com", "Tuan", "hashed_password_1544", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a09e6bc0-5971-438b-b56c-87cb29418ea4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan374@gmail.com", "Tuan", "hashed_password_1374", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a0beba05-004e-4cb6-8775-e1401e4adf82"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan840@gmail.com", "Tuan", "hashed_password_1840", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a0e0caa2-b024-4d7e-a688-fe5381c5bf5d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan332@gmail.com", "Tuan", "hashed_password_1332", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a0e18ca8-2c8e-4777-a88a-543a32a71d75"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan67@gmail.com", "Tuan", "hashed_password_167", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a0f03ae4-017d-4c9d-98af-fa34ac545cca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan22@gmail.com", "Tuan", "hashed_password_122", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a104923d-92df-4350-8cb8-de07cf5fc45d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan889@gmail.com", "Tuan", "hashed_password_1889", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a10b85f2-0889-4621-848b-af46a5d05bae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan209@gmail.com", "Tuan", "hashed_password_1209", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a1114d43-6e6c-430b-8590-a16685ef1e36"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan875@gmail.com", "Tuan", "hashed_password_1875", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a11cefd7-8805-4a9d-80fe-43c99dc60c45"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan177@gmail.com", "Tuan", "hashed_password_1177", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a13fe3c6-d429-49d1-aabd-b45f04b33744"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan356@gmail.com", "Tuan", "hashed_password_1356", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a1573f41-2633-4f59-95fa-309efd182de8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan933@gmail.com", "Tuan", "hashed_password_1933", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a1934526-fbee-470a-98d0-22cf5a1af77d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan484@gmail.com", "Tuan", "hashed_password_1484", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a1df6cb8-5959-4ff9-acd9-1f33f9ce4fce"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan832@gmail.com", "Tuan", "hashed_password_1832", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a2781e9d-21fe-47e5-9ba7-732b68c53e7f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan337@gmail.com", "Tuan", "hashed_password_1337", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a2d73d8e-a189-4451-9509-e8cebb487376"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan474@gmail.com", "Tuan", "hashed_password_1474", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a3382ed5-62f7-4d24-9cce-5ba1ec411abc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan660@gmail.com", "Tuan", "hashed_password_1660", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a3809856-4ace-47e8-bb56-cf6c8eb0c14d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan905@gmail.com", "Tuan", "hashed_password_1905", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a386f7a3-63c6-444d-8a4f-d8a39b721481"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan665@gmail.com", "Tuan", "hashed_password_1665", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a3add529-a483-4575-b053-276e9bf57d83"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan91@gmail.com", "Tuan", "hashed_password_191", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a43bdb22-c2a6-4de6-9ab9-6c2dc6ffd6fd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan87@gmail.com", "Tuan", "hashed_password_187", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a486f826-0bf6-4c1b-a274-51037d0fae27"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan182@gmail.com", "Tuan", "hashed_password_1182", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a52380de-14d8-4646-9afe-afd459997c43"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan309@gmail.com", "Tuan", "hashed_password_1309", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a53be5fe-4437-48ed-9e10-d54973d481a7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan659@gmail.com", "Tuan", "hashed_password_1659", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a54b0daf-2adb-4bfd-b539-b1592c3bde28"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan820@gmail.com", "Tuan", "hashed_password_1820", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a5746d6d-e9ef-4e16-8178-7ca531292acb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan70@gmail.com", "Tuan", "hashed_password_170", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a578a902-3588-4e3e-aff4-69589f199b43"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan609@gmail.com", "Tuan", "hashed_password_1609", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a717bbd9-3f9a-48da-b647-827abc7554bf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan664@gmail.com", "Tuan", "hashed_password_1664", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a78f0073-9cd8-4eb3-9bb6-28cbcfb3befb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan345@gmail.com", "Tuan", "hashed_password_1345", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a79e705f-c6e8-4d00-98e2-e78a3cb2f83d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan253@gmail.com", "Tuan", "hashed_password_1253", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a7b17474-9c0e-4ac6-814e-13067dcc2f15"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan536@gmail.com", "Tuan", "hashed_password_1536", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a80b9e2d-4be6-4b54-815c-69bcc945348a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan204@gmail.com", "Tuan", "hashed_password_1204", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a85e9016-68ec-44bd-8aa0-a54618f92923"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan339@gmail.com", "Tuan", "hashed_password_1339", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a8b307aa-5991-45eb-ab04-636731937907"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan398@gmail.com", "Tuan", "hashed_password_1398", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a8f25797-39ba-4421-894e-fe6d1bfe3c16"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan652@gmail.com", "Tuan", "hashed_password_1652", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a8f81b1d-8598-44cd-87c5-226996a4ec0e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan330@gmail.com", "Tuan", "hashed_password_1330", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a908c628-ab72-4460-a9d2-dd7b08960c9a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan152@gmail.com", "Tuan", "hashed_password_1152", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a93bb1d5-aee4-427d-bc3b-ab427cb6492b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan595@gmail.com", "Tuan", "hashed_password_1595", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("aa2c9f7d-5ba4-4196-993e-4fd8cd328a01"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan93@gmail.com", "Tuan", "hashed_password_193", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("aa622c42-478a-41a8-8a0f-d5b09edb25b4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan626@gmail.com", "Tuan", "hashed_password_1626", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("aaa7573a-f694-4fd4-bad7-bdf769446c28"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan221@gmail.com", "Tuan", "hashed_password_1221", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("aad34f93-e312-4204-a144-40c0a7f0de1b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan148@gmail.com", "Tuan", "hashed_password_1148", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("aad7633d-af02-4ea9-9f3d-b19f3a99badd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan281@gmail.com", "Tuan", "hashed_password_1281", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ab789f23-61b7-4701-b315-167fcc48b3f4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan866@gmail.com", "Tuan", "hashed_password_1866", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("abafacb4-299b-4d89-b569-4db1377146ec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan16@gmail.com", "Tuan", "hashed_password_116", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("abbcd84e-93ca-4cee-9415-2e8dbfef1687"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan725@gmail.com", "Tuan", "hashed_password_1725", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("abca67cd-5fbb-477f-a09b-3806b79c80dd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan631@gmail.com", "Tuan", "hashed_password_1631", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ac2b146a-31b6-4c30-a1e0-b73f6d3f8dfc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan102@gmail.com", "Tuan", "hashed_password_1102", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ac76029c-3a89-4f4b-b5cc-50d5c795e96c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan381@gmail.com", "Tuan", "hashed_password_1381", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ade2f503-90ec-47be-880f-6141cb1f418b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan362@gmail.com", "Tuan", "hashed_password_1362", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ae651802-b66d-4b70-a82f-2feb3974563a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan378@gmail.com", "Tuan", "hashed_password_1378", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ae9fe4cc-6b22-44df-be78-1b8391a44514"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan833@gmail.com", "Tuan", "hashed_password_1833", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("aebbe175-d899-4050-90d6-05b3e2164d8d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan883@gmail.com", "Tuan", "hashed_password_1883", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("aee65a70-1645-4732-9dbb-e5cb7424f01f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan656@gmail.com", "Tuan", "hashed_password_1656", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("af2ccb0b-d1b5-4003-8d09-1c33d2a933ee"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan534@gmail.com", "Tuan", "hashed_password_1534", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("af37d43a-f78b-49a0-a829-9cf7fa181768"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan402@gmail.com", "Tuan", "hashed_password_1402", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("af9bd601-bfab-4265-929b-c54133b77e79"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan811@gmail.com", "Tuan", "hashed_password_1811", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("afcaf200-a29a-4407-9288-38f5b9763a08"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan493@gmail.com", "Tuan", "hashed_password_1493", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("afe51ae4-a891-4bfc-a611-03741e422435"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan882@gmail.com", "Tuan", "hashed_password_1882", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("aff022b8-5986-4f11-93ab-a30ce0d4b9c8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan105@gmail.com", "Tuan", "hashed_password_1105", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b0605fff-d551-44c9-87e7-18bf823df05c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan223@gmail.com", "Tuan", "hashed_password_1223", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b08b4e6b-1b22-4d03-ae82-86e9a4bf6352"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan96@gmail.com", "Tuan", "hashed_password_196", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b0e51d0e-55d2-41c4-be58-fce1c5e65be4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan376@gmail.com", "Tuan", "hashed_password_1376", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b1e2ec2a-999d-48e5-9e9a-852e295af66f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan505@gmail.com", "Tuan", "hashed_password_1505", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b23c900e-d2f4-42b8-99f7-0c0ad2f20ddd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan77@gmail.com", "Tuan", "hashed_password_177", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b25c4ad5-f676-4b41-9853-2808bc91cf97"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan48@gmail.com", "Tuan", "hashed_password_148", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b28bf93b-8bde-4cfa-8dc3-607aa7272cbe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan627@gmail.com", "Tuan", "hashed_password_1627", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b312a6df-cb34-4e49-adaa-73d5d3c73763"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan488@gmail.com", "Tuan", "hashed_password_1488", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b31a75d0-628c-44ae-b517-08c44c91033a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan877@gmail.com", "Tuan", "hashed_password_1877", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b34dc9cb-6197-4482-af05-721bb6adcb45"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan315@gmail.com", "Tuan", "hashed_password_1315", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b3aaa13b-a9c0-42f8-be57-3e5e45ba8084"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan734@gmail.com", "Tuan", "hashed_password_1734", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b3c5e826-7e40-458f-a913-d8a2eb01ca65"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan707@gmail.com", "Tuan", "hashed_password_1707", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b435809e-d344-4d3d-abea-13362cc56c94"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan779@gmail.com", "Tuan", "hashed_password_1779", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b447a3da-2945-4516-8d71-08b29fcc8d97"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan208@gmail.com", "Tuan", "hashed_password_1208", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b44ed7e6-072b-4a3d-8d24-103a79bddc37"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan18@gmail.com", "Tuan", "hashed_password_118", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b4d5354f-767c-48c6-b866-634d78516c2d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan121@gmail.com", "Tuan", "hashed_password_1121", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b4e7c788-9fdb-4bf3-a136-8a14c4d36219"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan416@gmail.com", "Tuan", "hashed_password_1416", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b536b40b-912e-4f22-a9c7-4ccafe75b626"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan172@gmail.com", "Tuan", "hashed_password_1172", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b56d320f-6b11-4929-a5a8-69b79d560ab9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan613@gmail.com", "Tuan", "hashed_password_1613", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b56e8347-051b-49ee-b5a9-5cd962cbb1d8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan123@gmail.com", "Tuan", "hashed_password_1123", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b5bc818e-1147-48af-9d4e-5f46168b78bf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan110@gmail.com", "Tuan", "hashed_password_1110", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b5d20059-f970-4389-8405-383cdf4a86d5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan388@gmail.com", "Tuan", "hashed_password_1388", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b6108f1d-8b19-416f-89b5-50e59674f2fd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan476@gmail.com", "Tuan", "hashed_password_1476", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b6c91617-be78-4a1f-866c-21a138535716"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan916@gmail.com", "Tuan", "hashed_password_1916", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b6e03228-c85c-4517-8e6d-5569f9fb2833"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan452@gmail.com", "Tuan", "hashed_password_1452", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b7008423-9f32-4edd-a299-696981009631"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan806@gmail.com", "Tuan", "hashed_password_1806", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b7649fab-69cb-4b8d-a990-fb34c21b305f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan857@gmail.com", "Tuan", "hashed_password_1857", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b7ff0c71-413d-442f-9714-dab583fa336b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan254@gmail.com", "Tuan", "hashed_password_1254", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b8034da3-171c-46ff-9910-096fbfdcc3f4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan203@gmail.com", "Tuan", "hashed_password_1203", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b837b6e3-98d7-448d-8393-7655a073400f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan723@gmail.com", "Tuan", "hashed_password_1723", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b86f0a20-048b-4eef-8062-46379b7396ec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan320@gmail.com", "Tuan", "hashed_password_1320", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b8849938-1ee7-4ed1-95d6-6869a95a3d08"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan661@gmail.com", "Tuan", "hashed_password_1661", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b8a9ac7f-fa71-4fc4-be92-f65cea20d54a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan915@gmail.com", "Tuan", "hashed_password_1915", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b8ce813e-1e56-4348-bad6-d8cc7212fdc2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan926@gmail.com", "Tuan", "hashed_password_1926", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b9202da6-c203-4943-8129-072482b538a4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan50@gmail.com", "Tuan", "hashed_password_150", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b93df4eb-f3fc-4836-be61-d912cf4ff6ab"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan489@gmail.com", "Tuan", "hashed_password_1489", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b96e4e31-814e-4f9a-9b4d-4d29465aa304"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan522@gmail.com", "Tuan", "hashed_password_1522", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b9e48e2b-ac8a-40fe-bde5-825c646f2d37"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan881@gmail.com", "Tuan", "hashed_password_1881", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ba603abf-5312-4aaa-b13d-9c9eb54a09e3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan11@gmail.com", "Tuan", "hashed_password_111", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ba7a8ba3-5b9a-4c6b-ae4f-f3e029c260cc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan629@gmail.com", "Tuan", "hashed_password_1629", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ba7ae2cc-f628-44b1-8993-4867c8a588ab"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan85@gmail.com", "Tuan", "hashed_password_185", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bac8ff0a-23c5-4f61-9811-186fa3c5c196"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan124@gmail.com", "Tuan", "hashed_password_1124", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bb3f6e0a-d9bd-4806-9ea2-92f836778057"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan393@gmail.com", "Tuan", "hashed_password_1393", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bcce15d7-9679-4e7f-aabf-a2b182fe03c0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan26@gmail.com", "Tuan", "hashed_password_126", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bcfc3618-a5cf-4a3e-a4a0-b75fe0f0233c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan333@gmail.com", "Tuan", "hashed_password_1333", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bd1ca831-3d5a-4a91-842a-6925012ab1ec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan407@gmail.com", "Tuan", "hashed_password_1407", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bd7d5678-eeba-430f-bcfe-c9ab47acdb11"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan157@gmail.com", "Tuan", "hashed_password_1157", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bdc59b41-6357-401c-85e4-f18c3528e71c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan789@gmail.com", "Tuan", "hashed_password_1789", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bdd26070-eeab-4a50-8db7-311b8d5371f8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan879@gmail.com", "Tuan", "hashed_password_1879", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bdd5f183-2da9-4013-8675-281aeaf82087"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan444@gmail.com", "Tuan", "hashed_password_1444", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bdfdfd7d-fe84-486d-95d3-88f61b11569b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan1@gmail.com", "Tuan", "hashed_password_11", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("be0c60c2-9905-480e-af33-8f2e46de1b0b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan824@gmail.com", "Tuan", "hashed_password_1824", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("be186533-3cca-4888-95bd-ac0f33eedf9f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan216@gmail.com", "Tuan", "hashed_password_1216", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("be71d8c8-4d28-45b2-868a-e2ce5645c9a5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan418@gmail.com", "Tuan", "hashed_password_1418", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("beb876de-956a-4241-9645-984c5ec14054"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan510@gmail.com", "Tuan", "hashed_password_1510", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("becae2b6-c0f2-4dfb-ab2e-687f091304b6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan360@gmail.com", "Tuan", "hashed_password_1360", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bf2e6024-606a-4f1d-a0c2-4740f0039e35"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan701@gmail.com", "Tuan", "hashed_password_1701", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bf71a637-c728-4929-a79e-34a60ed3a5d2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan702@gmail.com", "Tuan", "hashed_password_1702", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bfdb716f-7c7f-4661-be1d-5197389f58df"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan417@gmail.com", "Tuan", "hashed_password_1417", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bffe897c-fd79-4317-9fa9-c0ed76135822"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan222@gmail.com", "Tuan", "hashed_password_1222", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c04598ef-434f-489c-9ce0-b72ccde7f0b3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan964@gmail.com", "Tuan", "hashed_password_1964", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c08adff0-8fa9-48eb-b030-9337e1f193f9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan126@gmail.com", "Tuan", "hashed_password_1126", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c0acb6b9-cb44-44a3-b076-0c54524c87de"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan478@gmail.com", "Tuan", "hashed_password_1478", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c10ee3da-cdc0-4af4-a3c3-c8824f684d79"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan792@gmail.com", "Tuan", "hashed_password_1792", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c151e279-2ea5-47f6-9e04-2398b3faa14b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan507@gmail.com", "Tuan", "hashed_password_1507", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c15a6d7b-3945-4da1-87af-2c0e0a655ed2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan625@gmail.com", "Tuan", "hashed_password_1625", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c3185745-a732-4cc2-b16f-7ec683fa8300"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan103@gmail.com", "Tuan", "hashed_password_1103", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c38db4b7-82d0-44b7-a127-2a6e965ab74d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan331@gmail.com", "Tuan", "hashed_password_1331", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c39d3d94-0108-412a-804f-1dc0c6ace79e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan219@gmail.com", "Tuan", "hashed_password_1219", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c40b50f0-078b-4c59-9c1b-55d0c88da014"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan992@gmail.com", "Tuan", "hashed_password_1992", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c495eb83-25e1-4f77-b193-d0d5205924fa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan413@gmail.com", "Tuan", "hashed_password_1413", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c4d02267-1151-4491-b51a-ba2549e3425a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan95@gmail.com", "Tuan", "hashed_password_195", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c4d70cbe-086b-4bde-bdeb-0e8f6e90e400"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan399@gmail.com", "Tuan", "hashed_password_1399", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c4ea5f13-dccb-4482-b38d-9437460a94e9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan71@gmail.com", "Tuan", "hashed_password_171", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c4ecbee0-48af-41d6-addf-bf0a609f42e0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan261@gmail.com", "Tuan", "hashed_password_1261", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c525b11a-bfdb-442a-89a5-c41c2510b3f7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan375@gmail.com", "Tuan", "hashed_password_1375", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c5f8a7db-6786-413e-b535-829ff1b1b313"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan262@gmail.com", "Tuan", "hashed_password_1262", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c6305a6f-6f13-4f3a-bb44-f9e85e68ca02"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan807@gmail.com", "Tuan", "hashed_password_1807", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c7385bcf-a2f6-4e20-8bc5-a4a380407b8a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan891@gmail.com", "Tuan", "hashed_password_1891", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c79b192e-fa61-47ea-9bd7-843bf970c2c9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan569@gmail.com", "Tuan", "hashed_password_1569", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c80e1549-fd84-4b6c-aac1-619ab53316c6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan766@gmail.com", "Tuan", "hashed_password_1766", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c8791ac8-dab8-483b-a63e-d63d6fdec1f5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan903@gmail.com", "Tuan", "hashed_password_1903", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c8842805-7e4d-4886-b58c-3ba285b2e603"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan782@gmail.com", "Tuan", "hashed_password_1782", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c88e6316-16f6-46a1-a82b-e2de485d7fe8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan639@gmail.com", "Tuan", "hashed_password_1639", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c8e46f41-77a1-418d-b500-65bc472e51b0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan540@gmail.com", "Tuan", "hashed_password_1540", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c977c73c-0aec-4582-93da-f645e8d025d5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan147@gmail.com", "Tuan", "hashed_password_1147", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c9893327-e2fd-4b41-a19a-7e44c9e385e7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan327@gmail.com", "Tuan", "hashed_password_1327", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c9f9a2e8-7599-45fb-8c7d-665f374586d0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan993@gmail.com", "Tuan", "hashed_password_1993", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ca4495be-1014-4705-b379-b6555a9bdc2a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan109@gmail.com", "Tuan", "hashed_password_1109", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ca9e20af-1221-4580-ac2d-27c3c529f3ec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan8@gmail.com", "Tuan", "hashed_password_18", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("caa97eed-319e-42cc-aa75-f0d57423522c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan276@gmail.com", "Tuan", "hashed_password_1276", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cae7e33d-3021-4e3d-8026-d8bb092dd028"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan777@gmail.com", "Tuan", "hashed_password_1777", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cb0dfd1f-3c9d-4e28-ab50-fff4a26f3f5e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan291@gmail.com", "Tuan", "hashed_password_1291", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cbc698fd-bc31-4b52-9cf3-074b290f3e42"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan347@gmail.com", "Tuan", "hashed_password_1347", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cbf9ca4c-6023-4898-8561-3a993cef4612"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan264@gmail.com", "Tuan", "hashed_password_1264", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cc02392e-5638-42d1-8f91-2fb22b351072"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan23@gmail.com", "Tuan", "hashed_password_123", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cc193a6d-6e10-4c59-b0d4-cd131d479e3a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan902@gmail.com", "Tuan", "hashed_password_1902", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ccd0a246-7e49-4f00-b79e-de464d442c89"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan641@gmail.com", "Tuan", "hashed_password_1641", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ccf3d780-6352-4bc9-a40c-b811d2480f55"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan638@gmail.com", "Tuan", "hashed_password_1638", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cd7c8bd9-94eb-4305-9dfc-f12b0d328308"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan709@gmail.com", "Tuan", "hashed_password_1709", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cd8c1541-ba55-481b-81dd-8589af7a548d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan400@gmail.com", "Tuan", "hashed_password_1400", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ce51a4f4-ffe3-4a80-b738-ed1421122b5f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan53@gmail.com", "Tuan", "hashed_password_153", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ce856b28-e367-4ebc-96e2-8ec5ae627234"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan237@gmail.com", "Tuan", "hashed_password_1237", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ceb21ced-497f-44fa-8945-afaf915f6e2e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan135@gmail.com", "Tuan", "hashed_password_1135", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cf40a562-550f-4fbe-b763-87eed2479170"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan312@gmail.com", "Tuan", "hashed_password_1312", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cf912351-4392-401f-bfb4-b030b48cfc2e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan465@gmail.com", "Tuan", "hashed_password_1465", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d0205d0c-44ca-43cc-bb02-a44a8e5e146a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan838@gmail.com", "Tuan", "hashed_password_1838", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d06467c5-3bf9-4c11-ba26-eed708e9df40"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan238@gmail.com", "Tuan", "hashed_password_1238", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d0895336-ec83-4fe6-8336-471d89ae620d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan377@gmail.com", "Tuan", "hashed_password_1377", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d0cec545-651f-45a6-a3ea-8718d51bf321"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan759@gmail.com", "Tuan", "hashed_password_1759", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d164e248-4ce6-4f20-86b2-833ae2cd4008"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan134@gmail.com", "Tuan", "hashed_password_1134", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d16ccf8b-a789-4e98-b024-b83735072100"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan821@gmail.com", "Tuan", "hashed_password_1821", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d20964d3-0f67-4c81-b9e0-ceff5c87db54"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan36@gmail.com", "Tuan", "hashed_password_136", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d31dc539-605e-4ce2-96bf-a71db560bd50"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan428@gmail.com", "Tuan", "hashed_password_1428", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d34464fc-7fd8-49aa-9a23-498874eb504a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan5@gmail.com", "Tuan", "hashed_password_15", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d35d31af-ce02-4ad3-8048-a3c6d90a8f75"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan864@gmail.com", "Tuan", "hashed_password_1864", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d38770f7-4812-4547-acb6-0d5f450894af"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan912@gmail.com", "Tuan", "hashed_password_1912", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d3ffe1bb-4ab5-41ed-a564-f6481e02ceec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan805@gmail.com", "Tuan", "hashed_password_1805", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d45d27aa-9d7b-4995-9ad5-c56a8b8e4b0d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan594@gmail.com", "Tuan", "hashed_password_1594", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d4a394b3-6996-4aa1-ba18-a9b0c6ba00ce"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan458@gmail.com", "Tuan", "hashed_password_1458", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d4b4c891-9ca0-45b7-afbd-017cada61bc0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan371@gmail.com", "Tuan", "hashed_password_1371", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d4eb5f9e-500a-4af1-a6d9-d2b59e94033f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan876@gmail.com", "Tuan", "hashed_password_1876", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d51ebb9b-b297-4d5b-9bfc-328068c61b4a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan797@gmail.com", "Tuan", "hashed_password_1797", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d632ca36-ec29-4ca7-a383-7cf8caad72c6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan86@gmail.com", "Tuan", "hashed_password_186", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d6445bbf-fd0b-42e6-876e-3f68cc146d4c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan394@gmail.com", "Tuan", "hashed_password_1394", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d652252b-4707-4a50-bece-1ca0cab4792d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan365@gmail.com", "Tuan", "hashed_password_1365", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d69c7f85-2ad3-4756-a301-337d4a2ed775"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan739@gmail.com", "Tuan", "hashed_password_1739", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d767d725-afe2-481f-92cc-26199681c0b0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan250@gmail.com", "Tuan", "hashed_password_1250", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d7963708-9c60-4ef3-b857-1847ce9d37d9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan610@gmail.com", "Tuan", "hashed_password_1610", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d8dc6d23-a624-40e7-b074-fb3fb8e544b1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan353@gmail.com", "Tuan", "hashed_password_1353", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d8e1e96c-2c64-4d81-9968-b0fd5d308ee7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan412@gmail.com", "Tuan", "hashed_password_1412", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d8e9e731-20c1-49e6-8660-57e62d07a1a4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan774@gmail.com", "Tuan", "hashed_password_1774", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d93b83aa-eb2c-426f-ba08-065708d8229d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan446@gmail.com", "Tuan", "hashed_password_1446", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d9580d15-0bf8-426d-86b5-1223191c3f60"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan155@gmail.com", "Tuan", "hashed_password_1155", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d99d073e-be85-4d77-b283-428192729048"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan274@gmail.com", "Tuan", "hashed_password_1274", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d9a4c27a-6816-40a1-9967-3dbb0e71aada"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan294@gmail.com", "Tuan", "hashed_password_1294", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d9dcfcf4-1d10-457c-8e9f-fd0b72f25954"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan12@gmail.com", "Tuan", "hashed_password_112", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d9e319e4-b799-434c-a95e-37f4e6302227"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan888@gmail.com", "Tuan", "hashed_password_1888", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("da5d33b9-6af0-4e3f-b658-677cfd044e8d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan795@gmail.com", "Tuan", "hashed_password_1795", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dae8725c-2e25-4d3f-80ed-bde8126ed5fe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan324@gmail.com", "Tuan", "hashed_password_1324", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("daf13765-c71f-4199-b013-d7ca86107ffc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan372@gmail.com", "Tuan", "hashed_password_1372", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("db77a47a-a3a7-4784-b2c0-12d0a074420b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan485@gmail.com", "Tuan", "hashed_password_1485", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("db7cfdac-e064-475b-97b9-18dc4a13ef97"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan896@gmail.com", "Tuan", "hashed_password_1896", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dbc250dc-b1e6-45a5-a96d-a1fe86ddf193"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan409@gmail.com", "Tuan", "hashed_password_1409", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dbee2aec-c8f1-4ad4-bc25-14e181b25cc4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan270@gmail.com", "Tuan", "hashed_password_1270", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dc01573b-c2f8-4877-8407-5c66868a65e9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan588@gmail.com", "Tuan", "hashed_password_1588", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dc3dfdd1-561e-4a25-a38b-7b51ea914f64"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan684@gmail.com", "Tuan", "hashed_password_1684", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dc5de012-45f8-4cbb-89cb-e012665e9523"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan61@gmail.com", "Tuan", "hashed_password_161", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dc715d3f-c0c9-4b02-ada1-7e678f8a3e36"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan195@gmail.com", "Tuan", "hashed_password_1195", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dd0ec217-fe7e-41e1-b3df-638bafcd3a7f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan559@gmail.com", "Tuan", "hashed_password_1559", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dd6e7044-4899-4adf-a011-bf58e6cfdb1a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan280@gmail.com", "Tuan", "hashed_password_1280", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dd73f0b9-db0e-4736-abd9-c8011e6588e9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan800@gmail.com", "Tuan", "hashed_password_1800", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("de4eb126-0910-4a00-8838-94618d154ed8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan763@gmail.com", "Tuan", "hashed_password_1763", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dec7e649-7b8d-42fd-a01b-b23f358e3fa5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan249@gmail.com", "Tuan", "hashed_password_1249", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dedc3cf3-8e9f-4687-9c17-02f6c6d2bb8f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan783@gmail.com", "Tuan", "hashed_password_1783", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("df03c5d8-22ba-47cd-8951-ebf838df1178"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan21@gmail.com", "Tuan", "hashed_password_121", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("df807239-96bd-4277-b859-0b436b4b475c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan352@gmail.com", "Tuan", "hashed_password_1352", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dfd9386e-0233-4b68-9707-c51d448f1d12"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan20@gmail.com", "Tuan", "hashed_password_120", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e07ea79b-54d1-498e-adef-c3716240f4eb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan753@gmail.com", "Tuan", "hashed_password_1753", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e0a7db4b-42df-4713-861d-a7abf5d8458a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan217@gmail.com", "Tuan", "hashed_password_1217", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e0c30119-16d9-4d84-b3e9-435816bc3d7f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan887@gmail.com", "Tuan", "hashed_password_1887", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e0d997fb-cab1-4557-a6c5-c344dbebb112"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan754@gmail.com", "Tuan", "hashed_password_1754", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e0f54e60-5726-48bc-bb8c-e43f220fdadb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan153@gmail.com", "Tuan", "hashed_password_1153", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e10493b6-7f25-4825-8fa7-ecddcc877b06"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan716@gmail.com", "Tuan", "hashed_password_1716", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e15cc843-a191-445d-b54b-20f45795db94"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan66@gmail.com", "Tuan", "hashed_password_166", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e1718666-952d-48b9-9c27-c52bdab68934"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan455@gmail.com", "Tuan", "hashed_password_1455", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e1a14137-1acb-4f37-a806-465b56413a60"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan15@gmail.com", "Tuan", "hashed_password_115", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e1de07ac-edc1-4bc4-87dc-7f45a6379de7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan379@gmail.com", "Tuan", "hashed_password_1379", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e2612e4d-6d0a-4e43-bbb0-75ce157821d6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan580@gmail.com", "Tuan", "hashed_password_1580", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e2c5cd29-fb6e-4a0c-bef7-156008c25511"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan171@gmail.com", "Tuan", "hashed_password_1171", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e2cec62f-7299-4364-b156-5878c010967b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan886@gmail.com", "Tuan", "hashed_password_1886", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e2e19e46-1a1c-4a1e-b210-e10e24d14799"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan909@gmail.com", "Tuan", "hashed_password_1909", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e2f775d4-a403-476a-aa6b-553c526433e9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan404@gmail.com", "Tuan", "hashed_password_1404", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e335abd4-a33f-4268-8849-97b7f566b122"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan547@gmail.com", "Tuan", "hashed_password_1547", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e3a7df61-cb6b-4aba-be71-312c9bd52674"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan732@gmail.com", "Tuan", "hashed_password_1732", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e3ac7827-754b-436b-b53d-e2216a018e9b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan25@gmail.com", "Tuan", "hashed_password_125", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e3ac9cad-c339-4ff8-9f97-b99f968ef572"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan722@gmail.com", "Tuan", "hashed_password_1722", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e3e64b47-bf60-43a9-bfa2-95e164995176"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan213@gmail.com", "Tuan", "hashed_password_1213", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e43f9aa7-0cb5-480d-9003-4bf65d194e85"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan448@gmail.com", "Tuan", "hashed_password_1448", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e48f0bdd-6e91-487e-b85b-39fed756ee7d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan76@gmail.com", "Tuan", "hashed_password_176", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e4ab09ec-e577-4c65-aacc-1b8b0eb26671"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan248@gmail.com", "Tuan", "hashed_password_1248", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e4ecf47f-d1ad-46a9-ae06-6b1bd5e224ca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan466@gmail.com", "Tuan", "hashed_password_1466", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e5127497-baaf-43ec-a2a9-179173608a5e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan999@gmail.com", "Tuan", "hashed_password_1999", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e56a685b-a7f4-48ff-a8e4-e5b41ea3dc98"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan302@gmail.com", "Tuan", "hashed_password_1302", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e5746eb8-01b7-4f7c-8bf8-111cf89be9ff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan462@gmail.com", "Tuan", "hashed_password_1462", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e5ff6130-d01a-4b29-b5d0-665405e36acd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan348@gmail.com", "Tuan", "hashed_password_1348", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e610a952-08e1-48b3-9ce8-8c553f7156e7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan511@gmail.com", "Tuan", "hashed_password_1511", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e6486225-a30b-4e06-9f3f-3073d710d59d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan436@gmail.com", "Tuan", "hashed_password_1436", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e6f96ff7-2349-4d6f-ad11-e8827ac72f45"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan949@gmail.com", "Tuan", "hashed_password_1949", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e6fc7df6-c6a2-4a02-96c9-cefb7874c64f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan913@gmail.com", "Tuan", "hashed_password_1913", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e7211178-5058-4309-b7b6-33b9d61bafa3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan160@gmail.com", "Tuan", "hashed_password_1160", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e7484cc6-ad4f-4807-96ac-2d0af3d90e70"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan758@gmail.com", "Tuan", "hashed_password_1758", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e784db10-0ac6-4df0-97c1-6dd4fd47ad5d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan304@gmail.com", "Tuan", "hashed_password_1304", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e7e0aa40-fec2-414a-9a84-e068e39232ef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan125@gmail.com", "Tuan", "hashed_password_1125", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e7e82beb-66a1-4cff-82a0-294bea88a752"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan473@gmail.com", "Tuan", "hashed_password_1473", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e836b6c3-4a47-470a-a610-742ce35a085e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan836@gmail.com", "Tuan", "hashed_password_1836", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e929b5be-ae30-4e2e-bfcc-136275fbf749"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan111@gmail.com", "Tuan", "hashed_password_1111", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e930b531-743c-4709-a0a8-f2fb38509ba7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan835@gmail.com", "Tuan", "hashed_password_1835", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e943ba90-c63d-4f81-8065-d73647a09c90"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan760@gmail.com", "Tuan", "hashed_password_1760", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e9639d9a-2295-4cc7-a12f-9c2ab0706ce4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan622@gmail.com", "Tuan", "hashed_password_1622", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e9a91942-d168-4ff6-bbf1-d2d34ad0f35d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan924@gmail.com", "Tuan", "hashed_password_1924", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ea2db460-7b7d-449a-a815-f3a5e4df3dc6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan676@gmail.com", "Tuan", "hashed_password_1676", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ea7ead6c-7fac-47d1-b1c3-4723cf74d917"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan284@gmail.com", "Tuan", "hashed_password_1284", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ea84455d-4fa7-4567-a8e9-f106de243871"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan161@gmail.com", "Tuan", "hashed_password_1161", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ead9a4cf-a6e8-4199-abde-340ae055ff9c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan813@gmail.com", "Tuan", "hashed_password_1813", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("eae17b80-7b37-4142-a6ca-4bb817b72ef9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan751@gmail.com", "Tuan", "hashed_password_1751", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("eb194539-47c6-4f16-a3ec-73c0e3045c2a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan251@gmail.com", "Tuan", "hashed_password_1251", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("eb7a3dee-b046-4ecc-8c4f-99a806914771"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan567@gmail.com", "Tuan", "hashed_password_1567", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("eb95140f-cead-4ff0-85d3-41e957a24f88"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan432@gmail.com", "Tuan", "hashed_password_1432", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ebba5b1f-487b-4ec6-9107-1c9262794adf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan128@gmail.com", "Tuan", "hashed_password_1128", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ec394509-4b7c-46d0-b7fd-80e5218b0e73"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan938@gmail.com", "Tuan", "hashed_password_1938", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ec4f132c-ffbc-4af9-b009-443ab72a2ce8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan848@gmail.com", "Tuan", "hashed_password_1848", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ec50d925-f880-4f4b-8cf1-5234dd84b8ee"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan260@gmail.com", "Tuan", "hashed_password_1260", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ed4c3b80-876c-4323-9b9d-3a1bd782d25d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan113@gmail.com", "Tuan", "hashed_password_1113", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ed5fb9c1-ac4f-4075-a950-ca23a1cb242a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan715@gmail.com", "Tuan", "hashed_password_1715", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ed642144-41ee-4ab1-a474-d1a0c8deb443"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan742@gmail.com", "Tuan", "hashed_password_1742", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ed83d4a0-0ec0-4cd7-9a20-159d29a432d8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan750@gmail.com", "Tuan", "hashed_password_1750", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ed85e830-90b1-47d5-ba37-ffb579a9ec56"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan737@gmail.com", "Tuan", "hashed_password_1737", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("edd27673-4506-461e-9f3d-2b040372f4a2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan361@gmail.com", "Tuan", "hashed_password_1361", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ee3ef38d-7118-45e4-9d5c-314a5b617031"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan285@gmail.com", "Tuan", "hashed_password_1285", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ee867baa-ea71-4fb0-b155-f67edef76b65"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan972@gmail.com", "Tuan", "hashed_password_1972", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ee92fc0c-e779-4f25-b12f-223a22f8273e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan948@gmail.com", "Tuan", "hashed_password_1948", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("eea394fe-91fa-4a07-971d-bd40a38c8d31"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan645@gmail.com", "Tuan", "hashed_password_1645", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("eef228e1-5f2c-4f91-bb9d-a136d1881593"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan166@gmail.com", "Tuan", "hashed_password_1166", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ef1ab5e9-12ac-4d6a-9088-0a0ff333ad2a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan299@gmail.com", "Tuan", "hashed_password_1299", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ef2549f8-d417-40f1-b7e6-9c25799c69ff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan736@gmail.com", "Tuan", "hashed_password_1736", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ef62d130-3ca1-4916-ab6f-f2d021454c69"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan914@gmail.com", "Tuan", "hashed_password_1914", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ef7ee6e4-158e-44f7-99e7-531066d57f9a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan199@gmail.com", "Tuan", "hashed_password_1199", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ef8114b6-14d5-434c-8ac7-e6f125bd4562"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan228@gmail.com", "Tuan", "hashed_password_1228", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ef822701-996c-48fc-b9ea-048b11719cd9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan784@gmail.com", "Tuan", "hashed_password_1784", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ef98c3ca-5336-41d5-8d0c-71a7ae4c5dc8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan666@gmail.com", "Tuan", "hashed_password_1666", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("efaa1bc4-5be6-49b6-992c-b0d3f28863e4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan644@gmail.com", "Tuan", "hashed_password_1644", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("efc98243-59b9-4071-b2d4-c93d3da29461"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan537@gmail.com", "Tuan", "hashed_password_1537", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f01e7edb-9d5e-464a-a696-ac01fc83ec51"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan539@gmail.com", "Tuan", "hashed_password_1539", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f04195d8-275b-4444-9058-e0dc85aecdc1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan944@gmail.com", "Tuan", "hashed_password_1944", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f042b79d-66d0-4146-9ced-29dd6026e9c4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan114@gmail.com", "Tuan", "hashed_password_1114", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f04e37c0-9bcd-431d-bf6f-c66740fbf001"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan731@gmail.com", "Tuan", "hashed_password_1731", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f087a0d8-8ff3-49a3-81a5-cf8f8a1b13b9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan226@gmail.com", "Tuan", "hashed_password_1226", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f133e349-a0ae-4667-8c94-bb0dbee45111"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan470@gmail.com", "Tuan", "hashed_password_1470", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f156b577-b0b2-49e9-a9c2-60a1db0d1646"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan75@gmail.com", "Tuan", "hashed_password_175", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f1f6d7f1-2f37-4673-ac00-0d95a05af823"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan695@gmail.com", "Tuan", "hashed_password_1695", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f22502ac-7366-407a-a2b5-17cefb764548"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan279@gmail.com", "Tuan", "hashed_password_1279", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f2380feb-6ac1-4d8d-a806-81768ff30591"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan662@gmail.com", "Tuan", "hashed_password_1662", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f277a0c4-41bf-4701-af60-1ed1dee854ca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan149@gmail.com", "Tuan", "hashed_password_1149", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f2c71c8a-96e2-40b7-bbb2-d4f992026bb6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan494@gmail.com", "Tuan", "hashed_password_1494", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f2c868e9-a978-4e43-a85d-2d072e9ad3a9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan469@gmail.com", "Tuan", "hashed_password_1469", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f2fe859a-b8f2-4de1-9ae1-f7decccce9b7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan796@gmail.com", "Tuan", "hashed_password_1796", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f30cb31a-1f7f-4fc0-92d0-bec18c058dc4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan957@gmail.com", "Tuan", "hashed_password_1957", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f376e635-1b8e-4031-b564-aa3ee038f849"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan518@gmail.com", "Tuan", "hashed_password_1518", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f38ccc42-18bb-4284-ab03-3d80ab7d3ca3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan560@gmail.com", "Tuan", "hashed_password_1560", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f39b88d5-c146-4ca8-8383-3b7dd1328691"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan524@gmail.com", "Tuan", "hashed_password_1524", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f3cc6b7e-1d6f-4b6b-b282-4164c352cbcd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan429@gmail.com", "Tuan", "hashed_password_1429", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f3e5ab88-aebe-4000-8ec7-3f1d4c87ee1d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan341@gmail.com", "Tuan", "hashed_password_1341", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f43e71f5-0d9a-40a1-bfd3-105600acaddb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan704@gmail.com", "Tuan", "hashed_password_1704", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f5af1f48-be71-4f68-8067-54d509fee6c0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan683@gmail.com", "Tuan", "hashed_password_1683", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f5c325ff-8a98-47ef-92d9-a2895167c4ff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan33@gmail.com", "Tuan", "hashed_password_133", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f5c482b8-c36e-48d3-8334-acc5d4631e73"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan190@gmail.com", "Tuan", "hashed_password_1190", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f5c9c586-4240-458e-bac0-4d2294f498f2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan843@gmail.com", "Tuan", "hashed_password_1843", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f5cd1c68-5415-4346-87c8-1b1264ccbd26"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan420@gmail.com", "Tuan", "hashed_password_1420", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f5d8d62a-613a-4c3e-86b1-a96ac991c3bd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan74@gmail.com", "Tuan", "hashed_password_174", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f611979c-fa6e-4012-ac5f-0c1acb582d12"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan745@gmail.com", "Tuan", "hashed_password_1745", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f660a9bf-02e3-44a2-8f93-924915fe3f2b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan218@gmail.com", "Tuan", "hashed_password_1218", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f66690c9-1499-40fc-9308-1360c98fc34e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan427@gmail.com", "Tuan", "hashed_password_1427", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f72e1292-1460-4aa1-9c7a-d50306112e04"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan410@gmail.com", "Tuan", "hashed_password_1410", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f72e1b6a-b13c-4746-be7d-82b2037da1f9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan830@gmail.com", "Tuan", "hashed_password_1830", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f78e21d7-6232-4efc-a4c7-4d8149473817"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan277@gmail.com", "Tuan", "hashed_password_1277", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f7b9aac4-3b20-4bfd-91f9-632b1996f607"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan682@gmail.com", "Tuan", "hashed_password_1682", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f8efbc02-589e-4a1c-a580-77823ebfc23e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan535@gmail.com", "Tuan", "hashed_password_1535", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f9693c32-abaf-43ca-9a26-2ea6d28941dc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan910@gmail.com", "Tuan", "hashed_password_1910", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f9d48c82-81e7-449b-8eb4-b0be77adc342"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan133@gmail.com", "Tuan", "hashed_password_1133", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fa492861-c6b6-4612-8f23-6709a3543a2d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan608@gmail.com", "Tuan", "hashed_password_1608", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fa5d3e98-1fd6-4fed-9ffc-0fc0a7371e4a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan3@gmail.com", "Tuan", "hashed_password_13", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fa73bb3f-5c7b-4ad4-a4fe-825bdbc0e06b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan965@gmail.com", "Tuan", "hashed_password_1965", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fa7694d7-b2c9-442c-90e4-340cce439bc6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan932@gmail.com", "Tuan", "hashed_password_1932", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("facedd6c-09b8-4010-ab09-0ddf20cb86f3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan642@gmail.com", "Tuan", "hashed_password_1642", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fb46878b-e00e-455a-ac82-813925d292b5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan597@gmail.com", "Tuan", "hashed_password_1597", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fb89d624-29a0-423e-a964-7138fecf6173"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan985@gmail.com", "Tuan", "hashed_password_1985", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fbd923a2-72eb-428a-8b88-051a275ee8e6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan425@gmail.com", "Tuan", "hashed_password_1425", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fc03387c-019c-48f6-84f6-989f28379a01"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan167@gmail.com", "Tuan", "hashed_password_1167", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fc079564-46dd-4440-a388-2dc924116a0e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan143@gmail.com", "Tuan", "hashed_password_1143", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fd42f492-5c8e-4261-b965-bc83000e7aa7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan899@gmail.com", "Tuan", "hashed_password_1899", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fdeb3bc7-4557-485d-8582-51eed1e1615f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan663@gmail.com", "Tuan", "hashed_password_1663", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fe8a0cd0-9bc6-4a86-8ad7-10b7c702672e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan611@gmail.com", "Tuan", "hashed_password_1611", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fe9eec82-08b6-40fa-99d2-e0d95ba52a19"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan772@gmail.com", "Tuan", "hashed_password_1772", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fead98c5-1622-46ee-801a-ced13a00b756"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan130@gmail.com", "Tuan", "hashed_password_1130", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ffd76a9d-5b78-4100-b5ab-c56fa6250166"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan230@gmail.com", "Tuan", "hashed_password_1230", null, false, false, "Le", null, "User", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "IsDeleted", "Name", "ParentId", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("6fea26cc-6046-4ce4-837d-e0d0184441cd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean", new Guid("6388590b-fc99-4c55-86ee-49d5c3b45d01"), null },
                    { new Guid("f2b06d2e-f33c-49a3-984b-93d0e4035b4a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao", new Guid("59444e0f-3831-4437-a4ce-3872216b92bd"), null },
                    { new Guid("f533cb9c-feea-451f-81b4-6eb0f114ebac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo ba lỗ", new Guid("59444e0f-3831-4437-a4ce-3872216b92bd"), null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "CreateAt", "IsDeleted", "Status", "TotalAmount", "UpdateAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("009f1097-0d04-4a13-b03d-f635d561314a"), "Bien Hoa, Dong Nai", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed", 100000m, null, new Guid("6c560de6-0fbe-4b7a-89d5-e5dcc86da35a") },
                    { new Guid("d3391f68-985e-4ed0-9550-8b957a03b7aa"), "Bien Hoa, Dong Nai", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed", 100000m, null, new Guid("6c560de6-0fbe-4b7a-89d5-e5dcc86da35a") }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "CompanyAddress", "CompanyName", "CreateAt", "IsDeleted", "TaxCode", "UpdateAt", "UserId" },
                values: new object[] { new Guid("7c486ee8-be32-4d29-a5d1-716d6de179bb"), "123 Main St, Cityville", "ABC Company", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE123", null, new Guid("9de8fc3b-af63-4d68-b3d3-444e20c63928") });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreateAt", "Description", "IsDeleted", "Name", "Price", "SellerId", "UpdateAt", "UrlImage" },
                values: new object[,]
                {
                    { new Guid("16ea53e5-8491-4ac1-bb5a-d5debc7431b2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Chân váy nữ xòe, thiết kế trẻ trung, chất liệu vải mềm mại, phù hợp cho mọi dịp.", false, "Chân Váy Nữ", 249000m, new Guid("7c486ee8-be32-4d29-a5d1-716d6de179bb"), null, "https://example.com/images/chan_vay_nu.jpg" },
                    { new Guid("176217b1-f0f1-4931-858f-ae7892ad08b6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Áo thun nam chất liệu cotton cấp cao, thoáng mát, phù hợp cho mọi hoạt động hằng ngày.", false, "Áo Thun Nam", 199000m, new Guid("7c486ee8-be32-4d29-a5d1-716d6de179bb"), null, "https://example.com/images/ao_thun_nam.jpg" },
                    { new Guid("d903855a-9ae7-4a4e-9788-16bd2beadb32"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Áo sơ mi nam công sở, thiết kế hiện đại, chất liệu vải cao cấp, thoáng mát.", false, "Áo Sơ Mi Nam", 299000m, new Guid("7c486ee8-be32-4d29-a5d1-716d6de179bb"), null, "https://example.com/images/ao_so_mi_nam.jpg" },
                    { new Guid("dab8ee5b-1305-4f42-a249-67c55a9ff054"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quần jeans nữa dáng ôm, tôn dáng, chất liệu denim co dãn, phù hợp cho mọi dịp.", false, "Quần Jeans Nữ", 399000m, new Guid("7c486ee8-be32-4d29-a5d1-716d6de179bb"), null, "https://example.com/images/quan_jeans_nu.jpg" }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "CreateAt", "IsDeleted", "OrderId", "ProductId", "Quantity", "UnitPrice", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("0a1b7a6d-0adf-41d1-acec-25d65e2df1c4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("009f1097-0d04-4a13-b03d-f635d561314a"), new Guid("dab8ee5b-1305-4f42-a249-67c55a9ff054"), 2, 399000m, null },
                    { new Guid("5dc1c4e6-fd94-425f-bd06-91811e42c488"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("d3391f68-985e-4ed0-9550-8b957a03b7aa"), new Guid("d903855a-9ae7-4a4e-9788-16bd2beadb32"), 2, 299000m, null },
                    { new Guid("f0d6aef9-dfba-4f14-a3f3-b001f8e68e52"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("009f1097-0d04-4a13-b03d-f635d561314a"), new Guid("176217b1-f0f1-4931-858f-ae7892ad08b6"), 2, 199000m, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_CartId",
                table: "CartDetails",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_ProductId",
                table: "CartDetails",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts");

            migrationBuilder.DropTable(
                name: "CartDetails");

            migrationBuilder.DropIndex(
                name: "IX_Carts_UserId",
                table: "Carts");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6fea26cc-6046-4ce4-837d-e0d0184441cd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f2b06d2e-f33c-49a3-984b-93d0e4035b4a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f533cb9c-feea-451f-81b4-6eb0f114ebac"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("0a1b7a6d-0adf-41d1-acec-25d65e2df1c4"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("5dc1c4e6-fd94-425f-bd06-91811e42c488"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("f0d6aef9-dfba-4f14-a3f3-b001f8e68e52"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("16ea53e5-8491-4ac1-bb5a-d5debc7431b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("009a44b7-4f07-4685-b21d-6aa2cbdcc563"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00b1d73a-0037-4262-89dc-ca2b387224e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0102b7a3-8fec-4e47-bbeb-c715dce4c128"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0117ee56-1b42-46b0-9725-ec2620f0b9e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0125b07a-7a02-4b42-aad2-d16194d05bdb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("019e028c-fa98-4c20-b4ee-530ad670ddcb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("01d7b08b-9f96-4fdf-a8f3-17583ea9d59f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("01e65569-60d6-439e-a52b-9e033867b52d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("01ebaa41-ecf6-4fff-b2d1-69ca86297db9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("024959b4-013e-44ab-94ac-66c559929c29"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("026070db-7191-4e86-b5a6-021048fb84c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("033932d6-4018-42fb-bbe5-89346fc1e1e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("034da90e-fc2f-4cf2-a765-458bc83e4ccf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("03b1eecd-3def-4de9-b4e0-7f075ca03946"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("04220721-64d5-4cd7-9ab2-f82862b26d1a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("043f7dd8-0da3-4449-b215-d9ec9c59ebc1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("04bddb3e-1032-4a89-8de2-15be700f1940"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("053294cf-1d5d-4b1d-844a-5c4cf5838783"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("05ca3926-25de-4340-b9fd-2c653a2b7937"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("05db156f-9212-425a-826e-4c694ff1d9d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("05f0c8ec-0290-48a2-866c-61b5f63248d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0604f60f-7008-4461-830f-c279ebebf7c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("063b43b1-d1f8-4392-b3ef-9d9828354517"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("063d36d1-594c-43d5-a81b-bde64aa4dfd3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("06608ced-9292-4e7f-91f6-e119726f7d4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("06ff49df-81ad-46d2-9d86-fc65eba90b98"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("075ba062-cd6a-4a7e-9c1f-b7e3ce39616e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07cfccab-0b27-477d-9ea4-ef4b81c4499c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07f126de-54af-4877-b864-e00a61cb22f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("080b6e15-e9b1-45f8-be4b-1c13751f47f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("080ed3e1-59f1-4b5a-ab52-cb9ed998cc90"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("086bc450-d583-4a2d-9c53-e9da752ff568"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("08ed2fb6-1a92-4eaa-a3aa-da2fb9ea6c64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("08f10d9c-0fe1-4b04-b4c1-77e73c3c7c09"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("090237b6-7d1c-4faf-8465-a56c6725661c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("090cb41f-b911-46a7-9007-323ddb9d1bcc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("090f0244-e967-4e1b-8756-66dddb9ab788"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("094cae33-13bf-4f4d-8d51-8fe6e2baf94a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("096035d8-7152-4131-9bac-444e2aa3adb3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0976b21f-6cfe-43f3-a587-e022a8ca9398"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0985b7f9-86e6-41fe-9b77-b0dfb797bff6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09a55886-ae41-400f-bee0-88c099e4c110"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09f7dc55-d5d3-40dd-9d3c-74cd5a1ac517"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0a296fb4-a42b-48c9-a717-ad0120ce540f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0a786e6a-029e-45e9-b115-67dd8ccf11bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0a7ce0aa-9275-4300-984f-6d220ef70b9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0a815b72-a0de-449d-818e-d5ec02ac56a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0aa59381-067c-4958-be40-daf75183ef09"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0af8afec-233a-42a2-987f-1912ab1d2655"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0afadd2f-bb24-4563-9cd5-80e124a192f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0afd9866-b5c7-4206-bab0-f563116572ab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b0ab7c5-ee86-4108-be1e-696a6c388d47"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b5234b0-a684-425c-b2b9-9af59ab7127b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0baec8d2-a9bd-4961-b436-9c1e6d04c31a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0c47dc63-adf2-4cc5-87e5-7abe0f71de46"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0cad1bd7-cc41-4bb3-9e0a-1519b5a701fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0cc153cd-b49c-490f-a203-8bf19155bd88"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0cd7c39f-2d82-4ee1-8c4b-97d2045d9938"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0d33d100-029c-4feb-a261-191609f65547"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e11a0e3-fe6c-4160-953d-d8ad46bbd77d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e46654d-857b-4a90-add7-e29fa70da067"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e900056-3e13-4adc-bc97-d040b654d805"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e971189-1e1c-4d1d-abf0-3669559966b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0eb85bc2-0685-4861-ac7b-775fe888dd07"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0edb8cd0-0a21-48e3-99f0-caef58725144"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f8608f1-8f73-453d-a6c1-0b4502c5643d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f926c5f-3ca4-449d-8440-4e96ff5d5d49"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0faccacc-db12-40cf-a72b-44d486019cdd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ff75e7b-4ad5-401c-96dd-aa7b48c46d1c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10575cff-7739-4b0d-a3a8-a56e028f9829"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10944aa0-ae4d-451b-8957-a11d9c1acf17"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1098d0b4-1470-4e48-8c97-866ee47749a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10c9da6c-ea6d-473c-8d23-4d9686ba06a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10ef8202-13bf-4b79-962e-98d5a30e4906"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1101f936-f551-4f83-8568-ca0a75313345"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1139498d-3d8f-4b26-adc9-50ddfc548d50"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("118f872f-aa30-41c9-a191-ed60477e050f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("119ad8af-4707-4774-8963-fc38436dd654"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("123aee03-f228-4352-8631-2e752040ad39"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1254051a-e994-406f-b156-cdee95b299d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("125b0cc0-d148-462e-a09a-0e0ddbca7dfb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1327952a-bdb0-4c01-ab4a-17f68e1196d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13395adb-ba01-4caa-a9bc-a62ffe8e5d41"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13484c8e-a495-4599-82db-812e0d07b362"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("138c3a4c-1983-47b5-a1d6-81801c50937a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("138f849a-a867-459f-acb4-73017c40d629"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13bc240a-b708-49b2-b3fb-2acef95a59aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("14535e05-12cf-43e9-bf86-719c3ab549de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("14c1e9ea-77e4-4d12-9d96-c549c7d66c20"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("14eccbeb-b3d9-4dd6-a2f2-221b53e2c75b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("152e070a-27ad-4398-ba31-63c9c60cc86a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("154e247c-5eca-496b-b0e6-3e9346157f0b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("156161fa-d66e-4299-b22a-17df8d240c93"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("15ae8579-7d14-4866-8763-967f0959bf29"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("161aa65e-bb59-4694-aa53-2d2fca18ad04"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1714b86a-5f0f-4060-807e-4f29ce5a4aa2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17bdcf19-8d15-4b04-8b19-948314bd58df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17ca607b-c2fd-4705-b810-5807ba5c3cff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17cb5958-c7c2-4abd-bf88-285bd665f166"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("184eb9ae-4bf5-46f7-89d6-ad3f63f8cb12"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("184f6085-d548-47e5-9805-78225164b55b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18662229-cf1e-4469-a793-5912a824ea4d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1877959d-5e76-4cf1-9713-43a9ccd0b685"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18c239a8-0c94-4a40-af3c-adfa3e187f62"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18e019f7-1137-4b3c-b1bd-03dcd56fd3d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18e56cd1-8e6b-404d-a6df-79f467c60b85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1907f122-fab1-42e0-8fe5-4eb008a18588"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1968c7db-a6f2-43fa-9662-dc406517f8a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("197f5e20-2db4-4e26-ac09-4499dc15802b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("19977834-5249-44bd-b365-5d83167eb4b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("19dc7a7f-3e55-4c07-ae5a-c12cabc900b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("19fa178f-7e35-4641-aa9b-a3dc459d0b9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a656af8-8b02-4c26-ab78-d77cb3b6ff93"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a9133a9-b996-4277-b998-f817ecfa181e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a9f15a3-4479-4fed-ada1-45f0efe19d91"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1af7188d-886f-4244-ab3d-9f5d5a9d9620"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b501207-cb4a-4d8c-a7dd-ce0945b5132f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1baad8a2-f7a1-4df7-9580-99171b78e291"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1bc0e1b1-81ef-4d16-a7ba-6947186d2505"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1bf50403-3877-41ef-8cfa-e6c0a9e908e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c6926a8-6853-4c6d-86a4-5bc8d0ef21ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c7c516f-9c88-44e0-8193-1fbd7dd9b72e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1cc44263-ad50-42a9-9f3e-ad5b6379ddc0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1cca9e7e-f974-4d47-a7be-33adf21f94cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d5b39ba-817c-483e-92ae-42cc2e34063f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d73ea71-52d6-453f-b714-27ca9b3b837d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d755fac-5c97-4249-ad80-b0934b24b613"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1da10b9f-638d-4043-9253-0d9a63350fef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e01fc8d-5331-4821-9e06-53f51df04a39"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e5522bd-81c1-4feb-8189-a9238266bf35"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e5be460-263c-4321-9565-0eb7abe55397"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1ed6ff7a-82ce-4e5a-8030-bdfb560b9996"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1f3b3cfc-7820-4e91-9134-c078faf4a6a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("204a92c5-7e0d-4ce9-8bbc-1828e4d4a350"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20a1bcc5-4e28-41de-899e-51eafd71508a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20e0a3e6-4ffa-45a1-94a1-e1e4f62ba29f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2134cfa4-3837-4a26-9a98-8cac70b388b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2201b50a-c1b9-49d5-abba-365813144704"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("220f2b04-a4ee-4cd3-9b00-396c0c9166e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("224d8c82-c862-46ca-a9b9-65a040411958"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22bb50e4-6248-4dc5-a5a1-86a32c669d2b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22bc7973-209a-4bf8-97cb-48596cd5d5d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22daa8c3-4732-4a2c-8fe5-68dc5fd239e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("232b16ab-3f7e-42dc-b0f3-093a3232aa7e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23f654d7-48e9-45c6-b67c-1b0f98a53b07"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24084888-5b56-4d12-91f7-b9ab439ad28d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24250518-6e2e-423b-b933-5eb0f69f5e32"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("242a918e-eb9a-45c0-8f9a-a593987a3168"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2451bed0-3d77-483b-b80d-3e043d340c52"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("245248f8-5d95-4a12-ae4d-f14dcb1d9c4a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2474abb9-8b2c-4fc2-8c32-27d9cf261a4a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24bd6ff9-91a4-4f1f-9162-43b3b67f0565"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24cb594e-4701-499b-a743-3537de75a135"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24d17e23-cbfe-40e8-9deb-1815e5e2c786"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24e3fa39-7443-42ed-98ac-5ec326bf01d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("25088be7-fdc8-4ca3-88d2-ea912fc44f32"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("256766d3-d2f6-4c70-86c7-1e1a6ea2b186"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("25ce8414-d77b-45c4-a89e-a213171b5ce8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("263b9592-ae01-4291-ba97-d4049beb2fde"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26448178-d263-4be6-a57a-ba6921707176"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2648f1d3-7da6-486d-ad78-865b88fdfc00"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2658f0db-2c5d-44db-a1ca-7477ea6983f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26b7cba3-4fc2-4c27-845d-7c275d141003"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26f258fb-e5c2-484f-abe1-5217e9b21894"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("270cf51a-9563-4dd9-bb25-fd140aa699d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2718a211-ce4d-4980-88a6-f231e67f724d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("27400cb3-1f58-41d0-8803-7566715537da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2750048f-9803-4896-8b89-8c5febacd2dc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2751620f-9a7e-4bf3-b4f4-203063067629"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2789bc61-1da5-4b4b-ab7c-5c883e741e2c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("278a59c7-d14d-4a31-9667-be7282a83ca6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("27a3b7cd-cba7-49c4-83d2-dd8b697fff9d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("28f29c6a-c831-4ba2-809d-f22090c4fe0a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2911cb23-7dd5-4056-af9e-01b1c98c0a72"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("29515443-d72c-4928-b3e8-458f9920dc0e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("29645acd-dfb8-4950-903d-a2bb762c69a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("29f95cb0-7071-4d76-88ec-1ecac268349f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a01ba86-7646-401b-a881-804be5b2db48"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a91ecb8-93e5-400a-af50-e6d01eaf0b7f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2b1e1113-266f-497f-be88-8d21a54a5afc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2b850762-ecd1-4631-bfa3-d635d8bf2028"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2bde927b-76d0-48d8-92b6-db8bc1dcb902"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2c762619-826b-441d-b298-30da4fd8c820"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2c9f21b2-8809-4272-a1d7-3196757170b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2cd90c75-ea27-4d4b-8b1a-182494e83389"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2d0bf7a5-dac7-4f0c-8c9f-887bf9692058"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2d161df6-266e-4e49-8593-d88f8d6d7d69"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2d24a7f2-1dde-41af-b034-4c3fda954fad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2d288b97-28f5-4b4b-89f5-0727b97d2ee9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2d6d6dc4-f820-4599-a51a-ee51665712eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2da5983d-b41c-4ec4-83ae-7a8a3f72074d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ddec3e1-8887-46fe-84d8-7079df3b779c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df2e338-e729-4c62-94ae-846b5ff1ba7a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e0aae5d-4a1f-499e-b56f-a46170bac48c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e652949-405e-4f87-90a7-8ed2eaa75acd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e76b3e5-b4fa-432d-a977-a886a4282f85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e7f86ca-41e5-4bc1-a80a-f47440f23226"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e8dda59-2d34-4a78-a4de-f83273c14ba4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2eca6980-06ee-4b27-ac2f-4f55dabb5d3f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f253ced-6fcd-4700-8fe9-e48afa6f23fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f3b83fc-6330-4f08-a2de-4ac7b775cea7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2facb1b8-03db-4ea3-bc8c-de00ab70d4c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2feb0456-91ed-4a9b-843f-ed371df0e452"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3035fc90-cbc0-40cf-a68e-0740c6a1b58f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("305fe164-5896-46ad-bed3-19cc5ce64384"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("308eed15-8a65-4ca9-b2e7-97764e111ca4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("309999f1-f31c-4fa3-aefe-ee9756143790"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30b06d80-9c71-4cf0-946c-4b4f427ad437"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30c355c6-2ad4-41d4-88ca-ba2365ad5cae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31161e87-1374-4b80-a4f1-fc09c737b586"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("312c4253-cc93-4c71-af15-c7d653e6f09e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("313237ad-b208-40ef-ab55-5b3aebeb0528"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("318ab285-73b2-4d29-b36a-e62b0a2cf360"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31a469aa-c4f5-4f12-91ad-90e5cda226f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31e713a2-bfcf-438c-a89e-f086d0ce319f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("32abbe8b-45c3-469f-853a-f6e45b050ea2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("32bf9187-d482-47b8-903e-465fbca6268a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33c5cacb-4363-4981-b5d5-d42b177f5c8b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3450c85f-fcc3-45c4-970b-b0e7239130d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3452eaf2-3b0a-4d63-8bdf-aca8cd583938"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3452fa5c-b5a4-43d9-b5cf-8dfece156bdb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34808a00-1b6e-4071-87e2-769a138e21b5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3482a42f-4ab1-4759-bf53-ec36cce2cae3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("35265e86-5c7b-49d2-9737-028e3cc785e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3542913e-c071-4ef2-be9f-f2a906ed4a26"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("356cb5e0-979b-4afe-a390-7fa02c0e2ffd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("357b7209-f446-407d-990a-f861d444fc5b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("35825b12-a865-4d9e-a5a9-e5cb9e657047"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("35c4ab52-72d5-4dbe-a84c-5b789db2129a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("35f36f46-947a-4c80-9928-d6cfd7ee9ec5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("35f7b039-405b-49cd-87b5-0a082cd074ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3609788f-d388-4069-882a-27e5da4f32fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("364e9caf-741b-4edb-a8f5-372cc273006a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("366b656e-5f56-4ec1-a8be-95b32c6b5a47"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("367ecb69-3928-44d3-86ea-95cd2d2eb748"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("368950e5-ed88-485b-9250-24f0a1d8dd64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36afe926-1f11-4460-9d8a-f31071e05aa5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36d067eb-0e98-4870-a7b7-e6370e6471c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36e5579d-0b79-4384-ab1e-e6b40c540001"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3772d58e-69a7-46c7-a397-1dad8c3cf845"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("38293c35-60ed-4ffb-973d-2cafcc1813dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("382cf3f8-3824-4a53-979c-46c9184b787e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("388882cf-c161-4c3b-a61f-6f3097eae904"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("38a621fb-3ca5-42e3-9e50-bc191df8d3d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("38d51864-9faa-48d8-91fc-800db777a825"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("38ee2801-0f1c-4eaf-9a47-43e073f52743"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("394188b9-8982-4cb1-a0fe-26c286a1bc98"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3955440c-ac67-4e2d-b5c7-3c2ebeed6db0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3989fb12-005e-48d4-839f-8fa74570b502"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("399c4dc1-fffc-4a9c-a872-2f0c742cbaf7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39a0398f-f372-48b8-9d43-2b8b3189bbee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39c39ed4-9da5-4a80-afa8-480a24de7d53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39fecb45-a460-48d1-b68e-a219ac2b8da9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a2e0b3f-606b-4cbc-ac18-1483d32b873a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a314297-ed81-44de-a39c-6b55993ff4f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a434fac-1eaf-4de0-a8b6-676043477c0b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a5e05f5-4115-4ca5-a386-def5ccf0f5e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3aa20cee-fbf8-4877-811f-56f965793006"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ac67eca-ec17-45a7-b218-6a7055de60a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ac6a506-d8aa-4e99-a196-39ae24ccc74e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b940f62-a4c1-42a1-94e8-0a8fcc374f6b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3bc9a3de-e79c-42d8-acbf-9b36e107e31f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3bd26b5b-cfb2-4a43-9092-e38f8d42ec48"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3c0059e7-0197-49a6-9a70-6cffead59f02"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3cbafa67-42fb-4c15-9ad3-39e5890709c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3d014c9e-7434-429a-bcc6-ff7a050ae0e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3d1804ae-cb76-4576-a589-f3f8572a7767"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3d89d2e8-b738-4532-b26c-0263276014c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3da6bf18-ee89-47a9-b74d-8baf4a23ea3b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3da97515-d01f-4ef2-9b54-d177487fd791"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3dd71ffb-b470-4a52-8022-9e3ff48abca4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e5072b3-f93c-4fdc-8b64-dcf1f32b99ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e810a93-d4ce-4f5b-bb8c-c8e9240d2f85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3f2be770-c09d-4171-8a6e-6ca820d77868"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3f8ddee6-657e-4b21-a9a5-f19de74313f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ff103b8-a6c3-441d-8b24-0e7ee87d616c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("401676d8-ee75-4fb4-bd45-645689d136b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("401b85cd-5511-46c7-8a6f-4cb04693aa15"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41090a97-9878-4532-b7ab-2f07aa00ab30"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41277147-3223-47fe-baee-cf17190ef25b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41d0651f-ae98-48ee-9430-ba8b1e7f3d73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41e4fa23-79cc-4f94-b794-3c1f309e667c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4245822a-e9de-4c0f-8ad2-5fb6f9a39936"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("425ad0d1-9ae3-4e84-9875-fc3784ba2be3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("42c2165e-528b-4b01-8d1a-064324e07c42"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("42f3b8bc-7525-4f01-8e96-839b4247fc72"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("42f8627f-d5a5-4b19-966c-55c6c250e082"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("42fbbf12-437c-4701-9d18-5c6b4a4365af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4325b1f6-8a7a-4e6a-b95c-b85e6803f7fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("43ea3727-ddfd-4415-a047-02aae7a4812b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44fde28c-284e-41ae-9ca8-523ba4d9d540"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4504b7c3-20ba-436b-8549-00ba49712ecf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45973238-77c4-4842-87e8-6d5b4bd4733e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45a84dd3-5c9c-41f1-a007-54e13c33e08b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45cef68e-6a6d-4bc8-ae55-8d59c39c655d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45de2608-20d1-4799-a371-e655ed43a0c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("46139e69-4789-466c-aec6-62e7e7a4d6d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("467682fe-4b1c-43e8-a425-feec428613e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("467b1fde-fa0e-454f-b918-e5d2984c31ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("48378692-4849-46aa-a5db-0b1555e9c6c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("48d46676-a91a-4bc5-ae2d-b318961f92cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4945c4f5-3355-4986-a0e2-7c7e4140fdf5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("49488fb0-6664-4d13-8814-02a831d2dcb8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("495aa64c-b42b-4102-810a-899f2fcdf3c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("49964fc6-9a74-4d2f-bfa3-dccf674062e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("49c397a1-30a6-4746-9828-4e4c108d11ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("49c6e4ac-063d-4540-baf2-62a6045bc46e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4a14c8a9-447f-4f70-acb1-5360eb93f111"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4a19eadd-5889-4cfc-a67e-f98939a2ae0a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4a30f379-b346-4415-aefe-2c297d5a59db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4a5f085f-e7a6-4986-8148-379a1593107d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4a7ccb83-24c2-452b-b3e4-83583fafcb3f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4a887ace-e946-48b3-912a-8e74192697e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4aa04e82-515c-4118-847a-46d11635a048"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4acd54e8-e8db-4aef-8f44-190e05a1a2b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ad09d72-5e60-4639-928c-996b4dc7c3c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ad449c9-46ca-4bf7-b7ee-f28c12818aed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ad896b0-f7ef-4b16-8396-5b9bb3a94dec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4b2120a0-971b-43dd-a412-52a505be8e80"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4b2e5a4a-d206-4fdd-a272-3a1bff633c6f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4b5c9154-d9fe-43ba-aae3-08efcdaad5cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4b5fc487-376f-479d-9752-e37e719171b1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4b800371-1cda-46ff-adcc-ee29a9604f6e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4b8cbfea-2c22-4fc2-b4b4-2e3d9c2bc36f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4bbd9f6a-8165-446c-b427-d4f7f145f738"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4bd10977-b97a-4d98-9f84-d667a32c1170"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4bf687d7-f4ff-4a0d-a1f1-532c213810a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c4c7b18-5bea-4de1-8154-eae67eb344a0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c963bd3-2422-46cf-9890-513e236582e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4d460d72-a9db-467a-b665-2c03dc76fed4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4d535239-d113-4190-b871-473652608eec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4d6d4d5a-684c-4b7a-9191-07886c62aaee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4dd8d825-34df-4950-93c2-7e0a23fcf0cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4e09354b-ef8e-48db-9478-dbbd8260e420"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4e0f6f88-83b9-408a-9982-f0a6b1bc785c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4e247b12-13f8-4b20-a02d-cb1b5925f222"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ecbdad7-b40d-4545-aa6f-825488285540"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4fb5bf68-505a-4ecd-8d41-465f1b9b68b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("505f1298-2bf5-4a5d-8e48-c29e66bda564"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("509c7ba6-1242-4623-9f30-d10aee076848"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("509e2683-c1cf-4ade-8ac6-ea3dc42d2ae0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50a88310-932d-40aa-811b-6cd6df5d7272"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50c585c4-6bac-4ae9-9dfb-b5a7359e1d67"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50fee46f-814d-4a8e-bbf6-c1f411505bb7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51060fd1-dc4a-4a48-b33c-af018cf185a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51b2af77-1fd6-4d23-9939-6467b53821c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51caf85d-1ec1-4820-b8d7-59fafe8bca41"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5243df0d-8247-47c2-bb5a-92526a875ccd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("52c0b555-622b-4bb4-a83e-3898e5842695"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("52da5240-69ee-44e6-819c-cfc59d782ba9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("53026f79-0c79-473b-9ff8-385410d6d42a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("530374a1-d480-4529-aa13-bf649f762566"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("53968a68-cac1-4a22-9db6-14a332d808ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("53982a8a-96b4-4419-bc43-3fe5d715d99a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("539d6084-a6b7-481e-8aad-230095f30b68"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("53c21514-3570-4d16-877b-9df5f95065be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("53e07ae1-dcd8-4c5c-aae0-f150b0584a95"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("541d78a8-5fc9-464d-bed1-a11fbb67d1d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("542599df-4ee0-458f-b0f5-671370c43e70"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("54709c22-034d-4544-a697-d292e45c328f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("549b42ea-dcaf-4f40-bf4b-06628dbbecfb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("550941c9-81b2-4b34-a3b5-6b474d8690fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("551b0fc9-ec30-4328-a144-0fac16870c21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("552b971d-5ed7-4f99-a536-d5076eaefb5c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55923e7d-51a8-454f-9a9f-d0c5cf7d9bee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56a1fe78-df10-4a67-8fb3-c8976cea611d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56ab0240-911a-4bc2-a6a5-44c63f8aac20"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56bf318f-47bb-4323-a317-55c1b852f3ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5755d1f1-9402-445a-86ce-d08677ffa0d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("57b03805-3765-4b90-9045-9138b7bcbf16"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("57bb97cd-7f2d-463b-b812-e94f36cf6610"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5802344b-4da5-43af-a87e-0910dd39b666"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("583f6e87-ff00-43c9-b970-d9ed37946411"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("585aec0b-48b7-4c07-b94a-4b4b517c0179"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("58aaffe0-5a5d-47e3-a0c1-e0b45748c1d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("58b515ca-3e0d-4be2-9ee3-f7daa5476090"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("58c485a4-fdde-4f6e-a96c-bcaf08df633a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59396186-0f89-48e5-a067-54fe7aa3c5e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("599858f3-b13c-4a2c-873e-ac5662b9a6d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59c9a9c7-8d2b-4914-a40a-a14fcc0f4abe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59dd1712-ac69-4611-9877-2eb423a0e63e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a03637f-b210-4124-9a1d-51f13fdc122f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a1cdad8-6693-40b2-8eb1-9ee1afa11f1e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a2c84b9-65d4-47ad-8c18-0c4d812bdc42"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a33bbb7-b44b-47cb-b722-2c99c2f30e15"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5add45e1-2da1-412a-9692-ef995b3b56d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5aea7a58-481d-4867-bb6d-a691a692e168"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b329883-a290-432a-8adf-0d31b8b38b45"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b32f780-7a81-4878-873e-64f12b06ec5a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b4e6215-3d84-4990-9b86-bf3bb65b59af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5bec1325-63b8-4a9c-b855-ebebec80e5be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5becaf4c-de79-487c-a4a1-ce7278def0d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5c9fae50-7af8-47e7-bde6-a25e3111cea1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5caf8bae-dec0-426b-9c68-4c35f9acc5f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5cdf41d4-b321-4852-98f1-b4377415af07"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5cefcaec-e83a-4f13-8a5d-9388e25acccc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5cf5942b-3b3b-45b4-a94c-f912ff110e5a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d0a73df-c7fe-4bc5-b780-516914e18f0c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d9f8da0-dffd-4b78-bda4-ae4501bcfdea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5dc8b8b3-dc69-4e86-852b-ea4279f3f8c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ec77c4d-261f-40eb-8aa4-a5f7884bc657"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ede7bf5-6a1f-4281-8355-eb72deb76411"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5edf5362-eb64-401e-8bf7-3e8cbcdcd5b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f42d7c4-5c7b-4d7d-a304-724563619c83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f474b3a-b23d-4de4-9b7a-0f9fb1598277"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f57a44d-4f61-4a20-8701-67289a8d4b98"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f8db21e-9512-4cf8-9c55-7aa50ccf37e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fa5283b-ad31-479c-b991-54cef2ad5348"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ff6620c-1908-4e05-ab60-740fecc045bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("600e56c2-581d-41fc-9f39-130cbcb021ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("607b567b-b348-44d5-aa4f-d2df790e322c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("60c933b2-e144-43f1-9a58-c88b08ed0eb7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("61cd4ebc-8a9d-4481-b716-4cffe21b853a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("621f6c81-234e-41fd-a813-6d273d009d70"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("629acff5-ae8c-499c-affe-c901da9f03e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62b25ca3-f16d-4e72-a824-5c0ce2f25f66"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62f08aac-2fa8-451a-8ca6-3de5312c1935"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62f58655-4eeb-4df8-958c-6bd270e1eec4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("63b0c941-066d-4c51-aee7-572df83af082"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("63b8a1d5-4cc7-4fbb-8c7a-da7ae00d42db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("63be2638-4090-4ae0-acb8-7af185bba10c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("63d659d0-5c43-4e90-9383-e084fa666fb4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("63ec1013-73cd-49d6-9e9d-c6d47f201944"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("63f13a78-5f04-445a-8455-8e3644bb8a07"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("64001ae4-4402-4f7f-a007-295147d3ebbf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("640cc5e8-9659-4fac-a8fa-e848146fd040"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("64200406-4c7f-4f08-b9c5-337efb9e4a63"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("644991d3-aa7b-4da5-9b7b-b6513b4196c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6454d2a1-076f-4ac7-add0-86ee692a973a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("64afe375-588c-450f-8571-cdef2b8584b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("64ba3551-951d-47be-b75b-e52e51157c8d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("65028abf-d554-4d83-b51f-b58bbf958e2c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("650e6a1f-d3ca-4792-a121-53e25b5fb930"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6524e961-b58e-4111-86c2-a6eefcb2106a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("657042f7-cb01-4c43-87fc-f49f98d80b49"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("661c2fc4-dfee-4ecb-a8e2-106f24613afb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("661ce3df-f5f9-4116-8c99-d7d7d702c917"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6649b4ed-9db2-42bc-8983-e8caca18ef28"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("669d1302-ce14-45e8-bc7a-e97458ae8c95"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66cc80cf-e1b0-4028-913c-732daa87cfa0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("67402eb9-dc8d-44ee-bc5c-b188f636e7d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("67cda767-ea3b-40f5-88d8-c5c1e15298c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6802d646-c192-4028-a373-99363276de0b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68130c2e-f27e-44cc-a103-316c55cb6141"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68142f51-7351-4d8b-a070-e3a19f1434a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68389741-8536-4236-b4c3-b8d9ff45876a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("685ba98f-f622-4d9b-943e-5f56e5b681fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("687aa918-4988-4539-bf21-9af27d76076d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68c89e4b-4d6a-42da-852c-c792b8d42720"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68efc816-f41a-4119-a073-eab2508ecd7d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a0b33fa-e8e4-4fb2-afd5-fbf10bc29dae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a2860f3-987a-4cfb-952c-b7f2fa402d32"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a5f6c15-2a64-47a8-a73e-57bbac076f26"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a938e40-f4ef-49a8-89db-a9ed8b9336ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6aca0c2d-1f6f-4c9f-98ab-a03ab108264b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ad645d3-86e9-4250-843c-9f313ee7f7c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ade0f23-018c-425f-8bb5-3d44060f0c4a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6b9058ca-62df-43a4-8e34-13b76e22c9c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6bbdeb3b-3c4a-497a-9428-704c1a6275f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c2af558-03c2-4d16-9e02-6cb25d99d3cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c377da6-4898-4a5e-99a0-2c3104240a3a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c8d0ab1-2567-453f-8588-dbceb5ba7939"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d07e0f2-1688-4aef-9a66-7921fdcd7661"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d275be9-923a-4f33-83b7-4488ce9920ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d761106-9847-4061-897f-39d87be47fd6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d87ea65-bf97-4048-b84c-560bedcf388d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d92368a-9648-4273-8de1-18fd0979428c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e9daced-cb8f-45a6-9ec2-d877031424e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6eba078a-82ae-474f-80d0-bf2061ba4fcf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f2ff25c-5f3f-47c8-a436-0c999c145733"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f5cbca2-d4cb-4eda-839d-7f07b34c053b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f6c01ed-2370-442d-b3c3-88200f915889"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f8abe00-e895-4a74-b15c-5b492cca826d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f9ee627-aef4-4c78-9a97-a4d59bb68872"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("700e87eb-2706-408e-b843-b3ec618f57aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("702a7e62-ad49-41a3-b49a-dad8a51ad210"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("70aaba2b-9be3-4c33-8835-d3e8fc842f20"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("70d22466-372b-4216-b432-3c40dc37e141"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("70f02ede-db55-416a-8187-265df9fef3f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("718098fe-56cb-44ca-aa37-ca5b135d9044"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71c15bab-e1dc-49be-bf68-0e29bb035210"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("725ec42b-1000-4827-91de-064d79b01aca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("725fc269-c156-42ce-a35e-54f80fe4b3d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72d0149b-5220-47d6-a6ba-e267bafd48fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72de92f9-a655-4ea8-bf7f-a376582cbd03"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7332e6cb-3d51-4004-a6f3-fc8545168027"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("73628efb-00f4-43b9-8cae-96e0bcbbcaf8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("73780bab-8276-4955-a190-83ff712f8d55"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("737dbab8-0289-4155-90eb-ed5c868b41be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("73c034e7-2fa3-4f42-8735-bc7c11acb62a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7473c3ac-d85e-4306-96a7-3bf5054581b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("749e5fa5-81a6-443f-a3f7-8c55f316327a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("752555a5-a1ae-44bb-9800-370d3b2f521f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("75926091-efe9-41ae-ae72-986104098517"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("75ad2afb-5f64-4427-a11d-3003835b259a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("75c85df1-9d4e-4d58-b967-311473ccd19e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("75eca885-29d4-4ca1-b475-9a24ee23c18a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("75f4ee68-a92b-4e20-80e1-1fff65441ac2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7612d885-4700-4500-b6a4-d13d0abbdb16"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("763f61e9-bc32-483b-a5ff-d1ae71c08a6e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("76cbbf8d-98ac-4222-852a-e09259bcebdb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7725390f-c03a-496c-a0f9-f79d76b281ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("773b1ad3-47d4-4528-b1af-c84928c73f0c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("77659b18-4ead-4824-a20c-639e41ef24f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("777039a9-0791-4f36-86e5-f0b7e7046f04"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("77edfc3a-e475-41a7-b8fe-59b6940f72fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("783abff3-415e-49b8-8f76-f51726eb0229"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78b86998-48a3-4701-8f4b-81bb306f3d31"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7903b74e-a412-4bf6-bf14-0f3a94b68f70"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7915d9fa-18b8-4b0e-8252-42ee82010721"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("79822bf1-29ae-41e2-8e3a-adc16da1ca8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a5ea3e7-5111-4619-b4d4-eea65407033f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a97a727-495f-4c4f-b1e4-0d7cf54ca5ed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7af0eae0-a5c9-4627-958a-d1dbe66da757"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7b9d8cb9-bab2-4f6a-a38d-b38f852dbf86"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7bc5e951-3fce-475b-8ff0-e3f30798bf19"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7bda50d5-844c-42f1-82f9-76aa911a2000"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c12bf22-56c5-4528-b37d-62badd5501d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c27fd41-41cc-4196-9853-215439cb21ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c78c6d5-ece3-4307-b664-470261fc41f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d0c735d-af2f-4961-bb26-a7e2a5abe09e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d1e1230-b48a-4c26-88c8-eba3254a4e8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d27ff2f-1661-464f-a0a5-154cceb39e05"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d7825f4-cad0-4aa9-ad48-229796dc3df5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7dab1d48-d585-4940-acee-1ee0dbf59958"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7e194b5f-e35f-4c48-8c66-6be544f988e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7e4e59cc-e97d-4e78-91b0-829b96dfa8df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7e5e58f8-c95e-4c0b-8512-050b592741c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ecedc9e-cde4-4d0b-bb52-394c81d06289"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f02804b-a49f-4257-a517-85c612f2a9c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f43836b-9209-40b0-9636-b42eb267dda2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f4b2825-f58b-46b9-aa9f-488562ac47aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f8b06b5-15cc-461e-9e1f-06db765b2d37"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fa6f430-ce06-4ecb-8cc3-55f1258dd9ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fac599d-b02d-4e84-a570-6b8a007ac709"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb01a19-f927-4c84-b78d-4507d918ed54"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("803c2f82-fce4-4d0e-be76-ac4561f6d9d4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("80c278aa-88b2-4249-babb-47b5dcaab03c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("814281f1-8b24-4e7c-9fc0-59580d4e5459"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8189d667-c718-4ad2-bf84-69c65272f08c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81aed105-7fa2-4bcb-a5fb-d067d1a5028c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81e8dee8-cae6-46b4-8490-fefc501a89f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("820969ba-214e-4e7c-a99e-2981a2bb3b2d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("821f6dc6-a245-4a79-94e7-59074a639cd8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82955597-5c90-48fb-bdb2-511d43505c85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("83272256-73d0-4ec3-9e74-04abf05ca2ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8327b482-ed9f-4f34-9b20-be17f5380265"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("83448cd6-e42d-49b2-b141-24d08874626f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("835a45e2-d4c1-4668-a577-bf479ba16e27"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("83bab315-e107-4c0f-b459-14115875a2b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("83c8a4c8-6140-48e9-848e-7b2e53868062"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("83d60bb5-f4b5-4138-a692-b5bec7457f37"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8425305e-9103-43a1-b02e-b619d2d3ba20"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8429b260-6695-4f09-9034-c240a8898479"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("846c6a2c-a0c5-45b3-bacf-e7dfeae7acb8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("848eaaa4-10a2-4d91-83a3-0e2ead358a04"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84e608bb-ebab-4b82-9546-72b749a5a298"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8573dea2-4142-4b02-834c-836e029fe201"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("85ba0f65-918b-4f2d-b2f5-997c8339bed1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86012e51-d6c2-4ddf-8a8a-496e69247081"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86126120-68b3-4ad3-8303-f6cf7ff03bfb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8617f374-d303-42d2-921d-b388e86909d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86a2c45d-2be3-42b5-8b4d-bb7346ca5f58"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86bf7cd8-d802-4f4b-adf6-721f4ec7ca08"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86d12578-f205-4300-af3d-f983d6c6da79"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("872068b1-0188-43e2-b054-0d18378b8260"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("87255510-b9ef-4cf9-976c-c848114bf454"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("87c559be-8c65-42c2-8100-d1e76a2125d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("881993dc-d7b7-4aaa-8627-76747e05d1f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("883d8794-aa41-4e8d-bb0a-263fa0e37abe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("891cc79f-203a-42ef-b6c9-3f5e349c8ac6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("896051ed-82b9-418d-a7ed-3b440c6cd3e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8961dc03-5b4c-42dc-a7f5-ae9d65d224d4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a3831ed-7938-4402-91f5-bad7e0a3cd15"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a60380b-f725-4541-94a8-ff07cbe637f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a73d2c0-dad3-4c2e-a660-f0d616dc5da8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ab07a4f-7b8f-4124-8164-703992b5153d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b3a78e2-56d5-4e4c-bea2-55a56f093971"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8bc8e38d-3f1c-43f5-a390-308f558d709d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8c2382b5-32a7-48ce-af1e-829fb15a5f5f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8c341f34-4f8d-4fb2-b8db-af1e33c86874"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8c88aded-6d38-4d44-b24a-02983bd33a6f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ce515b8-272c-4d92-91a5-11120d58e2c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d0e23f1-6bcb-47f1-8746-95588142866a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d71a4e3-f1fd-452f-bf7a-e3f67ee10c29"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8dd9efe8-b7c2-403c-80da-dabe452c414a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e1d6491-e0cd-441c-bd76-47561c338d01"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e999760-76ed-4522-9b70-4630b90aa33d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ec5a782-fd54-48c8-8134-399e3813896b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9022318e-cf9e-4802-a0c9-c0d71093599b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("90844faa-7031-411d-b9ff-946f3b9e1a6d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9087bc24-3a6e-47b7-82bc-6b5b9dd61c56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("90a7707b-2ab5-47b3-a02c-7c6b6d1e9ad5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("90acb455-b846-4a34-ab32-fc52fe9731c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("925451a8-6d78-484b-b9a4-8fd07225f5c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9266d540-613a-46c9-b4fa-f8ca3bceaeb8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9273d397-5aaa-4594-9b86-8b34bff16637"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("931509a2-1c45-4257-a833-fd7746d6a97f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("932b96f6-2c5e-461a-b9af-44a7b80505b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9378c422-08e4-4f76-8ecf-b4f3f0e9098a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("939ce94b-b9a9-40f5-8b1d-e367e5bca4d4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("944b392e-773f-4a78-8c12-d7e954e7b63d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9475e48d-3d34-40d1-809d-0f2b4ef44859"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("94ec1541-5200-4276-bca0-232b4f62ce31"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9591021e-f281-40cc-90a0-f8df145687c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95f34d6f-dec9-4da0-9a8e-490b11fa1e1d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("963f94b2-74e0-4c0d-92ef-65f766206bf6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96552daa-6bac-4a55-bc86-2501a00e8887"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96920f04-cb21-4000-8399-38e0277f3d04"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9695b8b0-41b3-4df0-9b4f-6800b887bcb8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96aa42d3-f69d-4e20-ac79-9ca987ab0c4e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("972654f9-ee02-432a-abed-9915a396892a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("97a786d0-726a-46c8-bbf7-a0aaf97c6991"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("97a83c82-edb7-4364-8dd8-7754819bd1a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9883c26e-81fa-4798-a836-b971435034a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9885dd16-2682-49fc-8198-59e1d662f208"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("989be3c5-1528-4b6e-b293-8c0eef7c08c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("98a523eb-c0b3-4201-a758-6f98aed21e2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("98c907f1-8141-4128-8a44-5885664d9960"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("991ede39-3960-4bb1-b441-4954b714c060"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99290f4f-4bbd-4931-9b2d-9908b0ad1975"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("996ecc35-91e9-4150-b06b-10bd5d612e3b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99f5b08a-6bc7-4cd3-b479-25499be125c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9a0c5ad0-f764-418d-853f-bfaaa61ae595"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9a5dc9f1-1102-4d7b-bad7-518184f4bcb0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9aa2c128-8300-4857-a081-48cafa9119ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9aa9c71b-370d-49b0-a1e9-f523204b7cdd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9abd3b71-e39b-444e-910c-1e04136723fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9acd92bf-a587-4aa4-989b-4ab2ac63cfec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9acf01bb-1bde-4cb0-a82e-810447eefb49"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9aec1b79-8924-410d-9529-0a4b810a19a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b50fb87-29d3-430f-8329-5ad6f45918f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b6d4b07-6554-4c16-9960-c3228161a148"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c7d9c81-d645-4eaf-ad39-a8845a4df7f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9cc9f4fa-8f54-4014-955c-e48a14e0e390"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ce1e490-c568-4467-935d-d662813a3afb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9cecd02f-66a6-4d6a-aaa2-e1307c7793f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d0ef5c0-13bc-4de6-8c5f-3d8e349c5f24"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d2f4d52-a9eb-4130-8320-3af7cca33cc8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d6036bc-6363-4549-a5bb-5d1dbf660414"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d952c05-153a-4912-8874-9884053b95e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d99694e-cbdf-4bce-8b0a-5f8b5e074813"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9db661d7-76b2-449e-bc7f-6f32b977591d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9dc508c4-9733-4b01-817e-4c1922c8acda"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9e172b50-ad2b-45a5-90bc-3d3f82b2aeef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9e2472ee-bab4-4b6c-be1c-262ce47e6a7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9e3622a7-7990-4e83-a436-3c9ec555609b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9e3be7f0-f834-4bba-a8c1-90668cb72b83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9e57f33f-eae3-4013-98b0-28c41d772b46"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ea8f2e8-130b-49a2-86e9-f7866e3ef18f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ebf03f7-5b94-49f2-ae2c-b95d84c38c70"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9fc9a413-e5b5-4d59-b6e2-a58640040ffa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9fe7f46c-49e9-40d1-85b3-d3d04f69d640"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a005e41b-dfc6-409d-862e-bea5645a1815"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a06e1120-3bcc-44df-b934-c673cfbfb87f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a09e6bc0-5971-438b-b56c-87cb29418ea4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0beba05-004e-4cb6-8775-e1401e4adf82"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0e0caa2-b024-4d7e-a688-fe5381c5bf5d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0e18ca8-2c8e-4777-a88a-543a32a71d75"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0f03ae4-017d-4c9d-98af-fa34ac545cca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a104923d-92df-4350-8cb8-de07cf5fc45d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a10b85f2-0889-4621-848b-af46a5d05bae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1114d43-6e6c-430b-8590-a16685ef1e36"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a11cefd7-8805-4a9d-80fe-43c99dc60c45"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a13fe3c6-d429-49d1-aabd-b45f04b33744"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1573f41-2633-4f59-95fa-309efd182de8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1934526-fbee-470a-98d0-22cf5a1af77d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1df6cb8-5959-4ff9-acd9-1f33f9ce4fce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a2781e9d-21fe-47e5-9ba7-732b68c53e7f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a2d73d8e-a189-4451-9509-e8cebb487376"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a3382ed5-62f7-4d24-9cce-5ba1ec411abc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a3809856-4ace-47e8-bb56-cf6c8eb0c14d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a386f7a3-63c6-444d-8a4f-d8a39b721481"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a3add529-a483-4575-b053-276e9bf57d83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a43bdb22-c2a6-4de6-9ab9-6c2dc6ffd6fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a486f826-0bf6-4c1b-a274-51037d0fae27"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a52380de-14d8-4646-9afe-afd459997c43"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a53be5fe-4437-48ed-9e10-d54973d481a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a54b0daf-2adb-4bfd-b539-b1592c3bde28"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a5746d6d-e9ef-4e16-8178-7ca531292acb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a578a902-3588-4e3e-aff4-69589f199b43"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a717bbd9-3f9a-48da-b647-827abc7554bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a78f0073-9cd8-4eb3-9bb6-28cbcfb3befb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a79e705f-c6e8-4d00-98e2-e78a3cb2f83d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a7b17474-9c0e-4ac6-814e-13067dcc2f15"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a80b9e2d-4be6-4b54-815c-69bcc945348a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a85e9016-68ec-44bd-8aa0-a54618f92923"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a8b307aa-5991-45eb-ab04-636731937907"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a8f25797-39ba-4421-894e-fe6d1bfe3c16"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a8f81b1d-8598-44cd-87c5-226996a4ec0e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a908c628-ab72-4460-a9d2-dd7b08960c9a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a93bb1d5-aee4-427d-bc3b-ab427cb6492b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa2c9f7d-5ba4-4196-993e-4fd8cd328a01"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa622c42-478a-41a8-8a0f-d5b09edb25b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aaa7573a-f694-4fd4-bad7-bdf769446c28"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aad34f93-e312-4204-a144-40c0a7f0de1b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aad7633d-af02-4ea9-9f3d-b19f3a99badd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ab789f23-61b7-4701-b315-167fcc48b3f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abafacb4-299b-4d89-b569-4db1377146ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abbcd84e-93ca-4cee-9415-2e8dbfef1687"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abca67cd-5fbb-477f-a09b-3806b79c80dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ac2b146a-31b6-4c30-a1e0-b73f6d3f8dfc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ac76029c-3a89-4f4b-b5cc-50d5c795e96c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ade2f503-90ec-47be-880f-6141cb1f418b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae651802-b66d-4b70-a82f-2feb3974563a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae9fe4cc-6b22-44df-be78-1b8391a44514"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aebbe175-d899-4050-90d6-05b3e2164d8d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aee65a70-1645-4732-9dbb-e5cb7424f01f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("af2ccb0b-d1b5-4003-8d09-1c33d2a933ee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("af37d43a-f78b-49a0-a829-9cf7fa181768"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("af9bd601-bfab-4265-929b-c54133b77e79"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afcaf200-a29a-4407-9288-38f5b9763a08"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afe51ae4-a891-4bfc-a611-03741e422435"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aff022b8-5986-4f11-93ab-a30ce0d4b9c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0605fff-d551-44c9-87e7-18bf823df05c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b08b4e6b-1b22-4d03-ae82-86e9a4bf6352"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0e51d0e-55d2-41c4-be58-fce1c5e65be4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1e2ec2a-999d-48e5-9e9a-852e295af66f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b23c900e-d2f4-42b8-99f7-0c0ad2f20ddd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b25c4ad5-f676-4b41-9853-2808bc91cf97"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b28bf93b-8bde-4cfa-8dc3-607aa7272cbe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b312a6df-cb34-4e49-adaa-73d5d3c73763"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b31a75d0-628c-44ae-b517-08c44c91033a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b34dc9cb-6197-4482-af05-721bb6adcb45"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3aaa13b-a9c0-42f8-be57-3e5e45ba8084"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3c5e826-7e40-458f-a913-d8a2eb01ca65"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b435809e-d344-4d3d-abea-13362cc56c94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b447a3da-2945-4516-8d71-08b29fcc8d97"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b44ed7e6-072b-4a3d-8d24-103a79bddc37"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b4d5354f-767c-48c6-b866-634d78516c2d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b4e7c788-9fdb-4bf3-a136-8a14c4d36219"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b536b40b-912e-4f22-a9c7-4ccafe75b626"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b56d320f-6b11-4929-a5a8-69b79d560ab9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b56e8347-051b-49ee-b5a9-5cd962cbb1d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5bc818e-1147-48af-9d4e-5f46168b78bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5d20059-f970-4389-8405-383cdf4a86d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6108f1d-8b19-416f-89b5-50e59674f2fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6c91617-be78-4a1f-866c-21a138535716"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6e03228-c85c-4517-8e6d-5569f9fb2833"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b7008423-9f32-4edd-a299-696981009631"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b7649fab-69cb-4b8d-a990-fb34c21b305f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b7ff0c71-413d-442f-9714-dab583fa336b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8034da3-171c-46ff-9910-096fbfdcc3f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b837b6e3-98d7-448d-8393-7655a073400f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b86f0a20-048b-4eef-8062-46379b7396ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8849938-1ee7-4ed1-95d6-6869a95a3d08"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8a9ac7f-fa71-4fc4-be92-f65cea20d54a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8ce813e-1e56-4348-bad6-d8cc7212fdc2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b9202da6-c203-4943-8129-072482b538a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b93df4eb-f3fc-4836-be61-d912cf4ff6ab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b96e4e31-814e-4f9a-9b4d-4d29465aa304"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b9e48e2b-ac8a-40fe-bde5-825c646f2d37"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ba603abf-5312-4aaa-b13d-9c9eb54a09e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ba7a8ba3-5b9a-4c6b-ae4f-f3e029c260cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ba7ae2cc-f628-44b1-8993-4867c8a588ab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bac8ff0a-23c5-4f61-9811-186fa3c5c196"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bb3f6e0a-d9bd-4806-9ea2-92f836778057"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bcce15d7-9679-4e7f-aabf-a2b182fe03c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bcfc3618-a5cf-4a3e-a4a0-b75fe0f0233c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd1ca831-3d5a-4a91-842a-6925012ab1ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd7d5678-eeba-430f-bcfe-c9ab47acdb11"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bdc59b41-6357-401c-85e4-f18c3528e71c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bdd26070-eeab-4a50-8db7-311b8d5371f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bdd5f183-2da9-4013-8675-281aeaf82087"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bdfdfd7d-fe84-486d-95d3-88f61b11569b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be0c60c2-9905-480e-af33-8f2e46de1b0b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be186533-3cca-4888-95bd-ac0f33eedf9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be71d8c8-4d28-45b2-868a-e2ce5645c9a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("beb876de-956a-4241-9645-984c5ec14054"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("becae2b6-c0f2-4dfb-ab2e-687f091304b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf2e6024-606a-4f1d-a0c2-4740f0039e35"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf71a637-c728-4929-a79e-34a60ed3a5d2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bfdb716f-7c7f-4661-be1d-5197389f58df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bffe897c-fd79-4317-9fa9-c0ed76135822"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c04598ef-434f-489c-9ce0-b72ccde7f0b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c08adff0-8fa9-48eb-b030-9337e1f193f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c0acb6b9-cb44-44a3-b076-0c54524c87de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c10ee3da-cdc0-4af4-a3c3-c8824f684d79"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c151e279-2ea5-47f6-9e04-2398b3faa14b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c15a6d7b-3945-4da1-87af-2c0e0a655ed2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3185745-a732-4cc2-b16f-7ec683fa8300"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c38db4b7-82d0-44b7-a127-2a6e965ab74d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c39d3d94-0108-412a-804f-1dc0c6ace79e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c40b50f0-078b-4c59-9c1b-55d0c88da014"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c495eb83-25e1-4f77-b193-d0d5205924fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4d02267-1151-4491-b51a-ba2549e3425a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4d70cbe-086b-4bde-bdeb-0e8f6e90e400"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4ea5f13-dccb-4482-b38d-9437460a94e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4ecbee0-48af-41d6-addf-bf0a609f42e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c525b11a-bfdb-442a-89a5-c41c2510b3f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5f8a7db-6786-413e-b535-829ff1b1b313"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6305a6f-6f13-4f3a-bb44-f9e85e68ca02"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7385bcf-a2f6-4e20-8bc5-a4a380407b8a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c79b192e-fa61-47ea-9bd7-843bf970c2c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c80e1549-fd84-4b6c-aac1-619ab53316c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c8791ac8-dab8-483b-a63e-d63d6fdec1f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c8842805-7e4d-4886-b58c-3ba285b2e603"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c88e6316-16f6-46a1-a82b-e2de485d7fe8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c8e46f41-77a1-418d-b500-65bc472e51b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c977c73c-0aec-4582-93da-f645e8d025d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c9893327-e2fd-4b41-a19a-7e44c9e385e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c9f9a2e8-7599-45fb-8c7d-665f374586d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca4495be-1014-4705-b379-b6555a9bdc2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca9e20af-1221-4580-ac2d-27c3c529f3ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("caa97eed-319e-42cc-aa75-f0d57423522c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cae7e33d-3021-4e3d-8026-d8bb092dd028"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb0dfd1f-3c9d-4e28-ab50-fff4a26f3f5e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cbc698fd-bc31-4b52-9cf3-074b290f3e42"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cbf9ca4c-6023-4898-8561-3a993cef4612"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cc02392e-5638-42d1-8f91-2fb22b351072"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cc193a6d-6e10-4c59-b0d4-cd131d479e3a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ccd0a246-7e49-4f00-b79e-de464d442c89"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ccf3d780-6352-4bc9-a40c-b811d2480f55"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd7c8bd9-94eb-4305-9dfc-f12b0d328308"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd8c1541-ba55-481b-81dd-8589af7a548d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ce51a4f4-ffe3-4a80-b738-ed1421122b5f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ce856b28-e367-4ebc-96e2-8ec5ae627234"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ceb21ced-497f-44fa-8945-afaf915f6e2e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cf40a562-550f-4fbe-b763-87eed2479170"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cf912351-4392-401f-bfb4-b030b48cfc2e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0205d0c-44ca-43cc-bb02-a44a8e5e146a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d06467c5-3bf9-4c11-ba26-eed708e9df40"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0895336-ec83-4fe6-8336-471d89ae620d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0cec545-651f-45a6-a3ea-8718d51bf321"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d164e248-4ce6-4f20-86b2-833ae2cd4008"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d16ccf8b-a789-4e98-b024-b83735072100"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d20964d3-0f67-4c81-b9e0-ceff5c87db54"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d31dc539-605e-4ce2-96bf-a71db560bd50"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d34464fc-7fd8-49aa-9a23-498874eb504a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d35d31af-ce02-4ad3-8048-a3c6d90a8f75"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d38770f7-4812-4547-acb6-0d5f450894af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3ffe1bb-4ab5-41ed-a564-f6481e02ceec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d45d27aa-9d7b-4995-9ad5-c56a8b8e4b0d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d4a394b3-6996-4aa1-ba18-a9b0c6ba00ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d4b4c891-9ca0-45b7-afbd-017cada61bc0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d4eb5f9e-500a-4af1-a6d9-d2b59e94033f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d51ebb9b-b297-4d5b-9bfc-328068c61b4a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d632ca36-ec29-4ca7-a383-7cf8caad72c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d6445bbf-fd0b-42e6-876e-3f68cc146d4c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d652252b-4707-4a50-bece-1ca0cab4792d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d69c7f85-2ad3-4756-a301-337d4a2ed775"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d767d725-afe2-481f-92cc-26199681c0b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7963708-9c60-4ef3-b857-1847ce9d37d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8dc6d23-a624-40e7-b074-fb3fb8e544b1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8e1e96c-2c64-4d81-9968-b0fd5d308ee7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8e9e731-20c1-49e6-8660-57e62d07a1a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d93b83aa-eb2c-426f-ba08-065708d8229d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d9580d15-0bf8-426d-86b5-1223191c3f60"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d99d073e-be85-4d77-b283-428192729048"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d9a4c27a-6816-40a1-9967-3dbb0e71aada"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d9dcfcf4-1d10-457c-8e9f-fd0b72f25954"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d9e319e4-b799-434c-a95e-37f4e6302227"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("da5d33b9-6af0-4e3f-b658-677cfd044e8d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dae8725c-2e25-4d3f-80ed-bde8126ed5fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("daf13765-c71f-4199-b013-d7ca86107ffc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("db77a47a-a3a7-4784-b2c0-12d0a074420b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("db7cfdac-e064-475b-97b9-18dc4a13ef97"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dbc250dc-b1e6-45a5-a96d-a1fe86ddf193"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dbee2aec-c8f1-4ad4-bc25-14e181b25cc4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc01573b-c2f8-4877-8407-5c66868a65e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc3dfdd1-561e-4a25-a38b-7b51ea914f64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc5de012-45f8-4cbb-89cb-e012665e9523"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc715d3f-c0c9-4b02-ada1-7e678f8a3e36"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dd0ec217-fe7e-41e1-b3df-638bafcd3a7f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dd6e7044-4899-4adf-a011-bf58e6cfdb1a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dd73f0b9-db0e-4736-abd9-c8011e6588e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("de4eb126-0910-4a00-8838-94618d154ed8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dec7e649-7b8d-42fd-a01b-b23f358e3fa5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dedc3cf3-8e9f-4687-9c17-02f6c6d2bb8f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("df03c5d8-22ba-47cd-8951-ebf838df1178"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("df807239-96bd-4277-b859-0b436b4b475c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dfd9386e-0233-4b68-9707-c51d448f1d12"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e07ea79b-54d1-498e-adef-c3716240f4eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e0a7db4b-42df-4713-861d-a7abf5d8458a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e0c30119-16d9-4d84-b3e9-435816bc3d7f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e0d997fb-cab1-4557-a6c5-c344dbebb112"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e0f54e60-5726-48bc-bb8c-e43f220fdadb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e10493b6-7f25-4825-8fa7-ecddcc877b06"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e15cc843-a191-445d-b54b-20f45795db94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e1718666-952d-48b9-9c27-c52bdab68934"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e1a14137-1acb-4f37-a806-465b56413a60"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e1de07ac-edc1-4bc4-87dc-7f45a6379de7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e2612e4d-6d0a-4e43-bbb0-75ce157821d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e2c5cd29-fb6e-4a0c-bef7-156008c25511"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e2cec62f-7299-4364-b156-5878c010967b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e2e19e46-1a1c-4a1e-b210-e10e24d14799"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e2f775d4-a403-476a-aa6b-553c526433e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e335abd4-a33f-4268-8849-97b7f566b122"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3a7df61-cb6b-4aba-be71-312c9bd52674"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3ac7827-754b-436b-b53d-e2216a018e9b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3ac9cad-c339-4ff8-9f97-b99f968ef572"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3e64b47-bf60-43a9-bfa2-95e164995176"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e43f9aa7-0cb5-480d-9003-4bf65d194e85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e48f0bdd-6e91-487e-b85b-39fed756ee7d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4ab09ec-e577-4c65-aacc-1b8b0eb26671"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4ecf47f-d1ad-46a9-ae06-6b1bd5e224ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5127497-baaf-43ec-a2a9-179173608a5e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e56a685b-a7f4-48ff-a8e4-e5b41ea3dc98"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5746eb8-01b7-4f7c-8bf8-111cf89be9ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5ff6130-d01a-4b29-b5d0-665405e36acd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e610a952-08e1-48b3-9ce8-8c553f7156e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e6486225-a30b-4e06-9f3f-3073d710d59d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e6f96ff7-2349-4d6f-ad11-e8827ac72f45"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e6fc7df6-c6a2-4a02-96c9-cefb7874c64f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e7211178-5058-4309-b7b6-33b9d61bafa3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e7484cc6-ad4f-4807-96ac-2d0af3d90e70"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e784db10-0ac6-4df0-97c1-6dd4fd47ad5d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e7e0aa40-fec2-414a-9a84-e068e39232ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e7e82beb-66a1-4cff-82a0-294bea88a752"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e836b6c3-4a47-470a-a610-742ce35a085e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e929b5be-ae30-4e2e-bfcc-136275fbf749"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e930b531-743c-4709-a0a8-f2fb38509ba7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e943ba90-c63d-4f81-8065-d73647a09c90"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e9639d9a-2295-4cc7-a12f-9c2ab0706ce4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e9a91942-d168-4ff6-bbf1-d2d34ad0f35d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ea2db460-7b7d-449a-a815-f3a5e4df3dc6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ea7ead6c-7fac-47d1-b1c3-4723cf74d917"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ea84455d-4fa7-4567-a8e9-f106de243871"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ead9a4cf-a6e8-4199-abde-340ae055ff9c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eae17b80-7b37-4142-a6ca-4bb817b72ef9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb194539-47c6-4f16-a3ec-73c0e3045c2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb7a3dee-b046-4ecc-8c4f-99a806914771"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb95140f-cead-4ff0-85d3-41e957a24f88"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ebba5b1f-487b-4ec6-9107-1c9262794adf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ec394509-4b7c-46d0-b7fd-80e5218b0e73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ec4f132c-ffbc-4af9-b009-443ab72a2ce8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ec50d925-f880-4f4b-8cf1-5234dd84b8ee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed4c3b80-876c-4323-9b9d-3a1bd782d25d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed5fb9c1-ac4f-4075-a950-ca23a1cb242a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed642144-41ee-4ab1-a474-d1a0c8deb443"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed83d4a0-0ec0-4cd7-9a20-159d29a432d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed85e830-90b1-47d5-ba37-ffb579a9ec56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("edd27673-4506-461e-9f3d-2b040372f4a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ee3ef38d-7118-45e4-9d5c-314a5b617031"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ee867baa-ea71-4fb0-b155-f67edef76b65"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ee92fc0c-e779-4f25-b12f-223a22f8273e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eea394fe-91fa-4a07-971d-bd40a38c8d31"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eef228e1-5f2c-4f91-bb9d-a136d1881593"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ef1ab5e9-12ac-4d6a-9088-0a0ff333ad2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ef2549f8-d417-40f1-b7e6-9c25799c69ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ef62d130-3ca1-4916-ab6f-f2d021454c69"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ef7ee6e4-158e-44f7-99e7-531066d57f9a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ef8114b6-14d5-434c-8ac7-e6f125bd4562"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ef822701-996c-48fc-b9ea-048b11719cd9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ef98c3ca-5336-41d5-8d0c-71a7ae4c5dc8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("efaa1bc4-5be6-49b6-992c-b0d3f28863e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("efc98243-59b9-4071-b2d4-c93d3da29461"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f01e7edb-9d5e-464a-a696-ac01fc83ec51"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f04195d8-275b-4444-9058-e0dc85aecdc1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f042b79d-66d0-4146-9ced-29dd6026e9c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f04e37c0-9bcd-431d-bf6f-c66740fbf001"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f087a0d8-8ff3-49a3-81a5-cf8f8a1b13b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f133e349-a0ae-4667-8c94-bb0dbee45111"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f156b577-b0b2-49e9-a9c2-60a1db0d1646"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f1f6d7f1-2f37-4673-ac00-0d95a05af823"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f22502ac-7366-407a-a2b5-17cefb764548"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2380feb-6ac1-4d8d-a806-81768ff30591"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f277a0c4-41bf-4701-af60-1ed1dee854ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2c71c8a-96e2-40b7-bbb2-d4f992026bb6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2c868e9-a978-4e43-a85d-2d072e9ad3a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2fe859a-b8f2-4de1-9ae1-f7decccce9b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f30cb31a-1f7f-4fc0-92d0-bec18c058dc4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f376e635-1b8e-4031-b564-aa3ee038f849"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f38ccc42-18bb-4284-ab03-3d80ab7d3ca3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f39b88d5-c146-4ca8-8383-3b7dd1328691"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f3cc6b7e-1d6f-4b6b-b282-4164c352cbcd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f3e5ab88-aebe-4000-8ec7-3f1d4c87ee1d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f43e71f5-0d9a-40a1-bfd3-105600acaddb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5af1f48-be71-4f68-8067-54d509fee6c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5c325ff-8a98-47ef-92d9-a2895167c4ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5c482b8-c36e-48d3-8334-acc5d4631e73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5c9c586-4240-458e-bac0-4d2294f498f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5cd1c68-5415-4346-87c8-1b1264ccbd26"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5d8d62a-613a-4c3e-86b1-a96ac991c3bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f611979c-fa6e-4012-ac5f-0c1acb582d12"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f660a9bf-02e3-44a2-8f93-924915fe3f2b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f66690c9-1499-40fc-9308-1360c98fc34e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f72e1292-1460-4aa1-9c7a-d50306112e04"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f72e1b6a-b13c-4746-be7d-82b2037da1f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f78e21d7-6232-4efc-a4c7-4d8149473817"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f7b9aac4-3b20-4bfd-91f9-632b1996f607"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f8efbc02-589e-4a1c-a580-77823ebfc23e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f9693c32-abaf-43ca-9a26-2ea6d28941dc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f9d48c82-81e7-449b-8eb4-b0be77adc342"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa492861-c6b6-4612-8f23-6709a3543a2d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa5d3e98-1fd6-4fed-9ffc-0fc0a7371e4a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa73bb3f-5c7b-4ad4-a4fe-825bdbc0e06b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa7694d7-b2c9-442c-90e4-340cce439bc6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("facedd6c-09b8-4010-ab09-0ddf20cb86f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb46878b-e00e-455a-ac82-813925d292b5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb89d624-29a0-423e-a964-7138fecf6173"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fbd923a2-72eb-428a-8b88-051a275ee8e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc03387c-019c-48f6-84f6-989f28379a01"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc079564-46dd-4440-a388-2dc924116a0e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fd42f492-5c8e-4261-b965-bc83000e7aa7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fdeb3bc7-4557-485d-8582-51eed1e1615f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe8a0cd0-9bc6-4a86-8ad7-10b7c702672e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe9eec82-08b6-40fa-99d2-e0d95ba52a19"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fead98c5-1622-46ee-801a-ced13a00b756"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ffd76a9d-5b78-4100-b5ab-c56fa6250166"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("59444e0f-3831-4437-a4ce-3872216b92bd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6388590b-fc99-4c55-86ee-49d5c3b45d01"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("009f1097-0d04-4a13-b03d-f635d561314a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d3391f68-985e-4ed0-9550-8b957a03b7aa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("176217b1-f0f1-4931-858f-ae7892ad08b6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d903855a-9ae7-4a4e-9788-16bd2beadb32"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dab8ee5b-1305-4f42-a249-67c55a9ff054"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("7c486ee8-be32-4d29-a5d1-716d6de179bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c560de6-0fbe-4b7a-89d5-e5dcc86da35a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9de8fc3b-af63-4d68-b3d3-444e20c63928"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Carts");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "IsDeleted", "Name", "ParentId", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("2cd22a14-8388-4e0a-b7e6-c22eec0eb647"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần", null, null },
                    { new Guid("b3b8b0b0-20d6-4dcf-bf20-fef2f8eb7d94"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreateAt", "DateOfBirth", "Email", "FirstName", "HashedPassword", "ImageUrl", "IsDeleted", "IsVerified", "LastName", "PhoneNumber", "Role", "UpdateAt", "VerifiedCode" },
                values: new object[,]
                {
                    { new Guid("005ee863-e1b9-47c1-8d24-ff150dc72fd5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan689@gmail.com", "Tuan", "hashed_password_1689", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("00776e68-b440-4a37-9246-9ca528f1e099"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan30@gmail.com", "Tuan", "hashed_password_130", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("01850874-5137-49da-8e84-56faeeecbb18"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan837@gmail.com", "Tuan", "hashed_password_1837", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("01aa7bd5-b3f2-433f-94f7-82d2014ae4cd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan984@gmail.com", "Tuan", "hashed_password_1984", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("025cc720-7660-4d96-8660-8238e7c4e0da"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan142@gmail.com", "Tuan", "hashed_password_1142", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("02bb8d4a-fb55-4b78-af16-77e90b3a70f0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan786@gmail.com", "Tuan", "hashed_password_1786", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("02ce703a-7c6a-4e84-b906-cd1ef0979541"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan563@gmail.com", "Tuan", "hashed_password_1563", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0372657a-05d9-47ce-977c-a9785cf9c6dc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan954@gmail.com", "Tuan", "hashed_password_1954", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0373e5b3-b571-4c0a-82e7-f86af99dbb0b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan441@gmail.com", "Tuan", "hashed_password_1441", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("037ff405-9370-49cd-828e-7d425d64fbcd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan814@gmail.com", "Tuan", "hashed_password_1814", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("03889ec4-c4a5-4ad4-a079-458a69035d9a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan91@gmail.com", "Tuan", "hashed_password_191", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("04113478-baeb-4ae0-894d-d7f0e168408f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan761@gmail.com", "Tuan", "hashed_password_1761", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("043e53b1-4c41-4b03-9461-3593396656e0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan418@gmail.com", "Tuan", "hashed_password_1418", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("04725dd3-7637-4ce1-af0e-fb0033e2c948"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan258@gmail.com", "Tuan", "hashed_password_1258", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0483d32b-100b-4c3b-a1a7-5b67bf27518b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan454@gmail.com", "Tuan", "hashed_password_1454", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("04c011b5-86c0-4be7-9f82-1552e885250c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan331@gmail.com", "Tuan", "hashed_password_1331", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("052f5363-e85c-4673-9261-61ae753b58d1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan959@gmail.com", "Tuan", "hashed_password_1959", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("05cce953-4e2e-4f49-a019-1773580058ca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan852@gmail.com", "Tuan", "hashed_password_1852", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0654559b-59cb-4134-90f5-6f7d35db07ca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan542@gmail.com", "Tuan", "hashed_password_1542", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0676aa2b-419b-4906-86c4-f5505c988064"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan978@gmail.com", "Tuan", "hashed_password_1978", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("06ab2392-7fe7-428d-82a3-3c0e96f6e19a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan967@gmail.com", "Tuan", "hashed_password_1967", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("06d8e660-12e7-4044-8dbc-d7a787c1c65f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan127@gmail.com", "Tuan", "hashed_password_1127", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("07505503-c4a0-4c0a-8d99-2df1b8e9de9d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan955@gmail.com", "Tuan", "hashed_password_1955", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("07a731a4-62c7-4332-94fd-5dc0ad91977a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan253@gmail.com", "Tuan", "hashed_password_1253", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("07b43fb7-5aea-4c82-bb42-1efd5c08371a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan487@gmail.com", "Tuan", "hashed_password_1487", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("07ecc2d2-9b0d-426a-adb1-fd8bb6301c29"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan52@gmail.com", "Tuan", "hashed_password_152", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0803d97d-9c4b-4154-a56f-9d6ef9170b4e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan247@gmail.com", "Tuan", "hashed_password_1247", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("08334bf0-b095-453b-9295-dc26cba5a0dc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan226@gmail.com", "Tuan", "hashed_password_1226", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0882fbcc-ca56-48a5-b866-c6e19b6b3a6e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan82@gmail.com", "Tuan", "hashed_password_182", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0892b260-e266-4e79-a3cd-41042f3d993a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan799@gmail.com", "Tuan", "hashed_password_1799", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("089cd38b-bceb-4035-a4f4-fac613983ab8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan25@gmail.com", "Tuan", "hashed_password_125", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("08e485a3-46bb-4d5c-a1b9-01cebf940898"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan43@gmail.com", "Tuan", "hashed_password_143", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("09bb47d2-6465-4da3-bb64-a74af27d81f1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan645@gmail.com", "Tuan", "hashed_password_1645", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("09e879de-82eb-4955-90b2-b3d32091e352"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan712@gmail.com", "Tuan", "hashed_password_1712", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("09f6bdfa-cecb-4e04-9fe7-2866d76d3c18"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan241@gmail.com", "Tuan", "hashed_password_1241", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("09fe4256-447d-4a47-a3b8-3a62bc31fd14"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan665@gmail.com", "Tuan", "hashed_password_1665", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0ab82223-57e1-4803-9138-e8ccd32c8544"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan672@gmail.com", "Tuan", "hashed_password_1672", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0abc7954-9c99-4ecc-be14-e923c178f5db"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan917@gmail.com", "Tuan", "hashed_password_1917", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0ac7620f-d0a7-423e-970b-9a1f2067a47a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan633@gmail.com", "Tuan", "hashed_password_1633", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0b3d8da3-e3f8-4cbf-be42-b85ffada5b8d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan540@gmail.com", "Tuan", "hashed_password_1540", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0b790495-f9d3-4cb9-bf53-d0b58c2f81c3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan386@gmail.com", "Tuan", "hashed_password_1386", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0b8a4e08-8da3-434b-ac1c-839ee6e04b70"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan681@gmail.com", "Tuan", "hashed_password_1681", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0b932dd4-6358-4c75-995c-57c15fbeb200"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan218@gmail.com", "Tuan", "hashed_password_1218", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0bfd822b-e5ff-492e-b94d-2bcbea9e411e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan913@gmail.com", "Tuan", "hashed_password_1913", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0c596b9c-8fa2-4cc0-8b9f-13beb125991c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan264@gmail.com", "Tuan", "hashed_password_1264", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0c6f02ba-b7c7-4145-95d5-2c078d42bd4b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan549@gmail.com", "Tuan", "hashed_password_1549", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0cd82ae4-c1ec-4f0c-a323-6b6720f274fe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan313@gmail.com", "Tuan", "hashed_password_1313", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0cf9afd8-bac6-4af2-9b56-5bbd4c24a46c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan533@gmail.com", "Tuan", "hashed_password_1533", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0dd699fd-f477-44ad-8ee2-9400189e62c9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan594@gmail.com", "Tuan", "hashed_password_1594", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0de66c02-ccfb-4499-a238-d2d52523d0da"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan317@gmail.com", "Tuan", "hashed_password_1317", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0e100965-f8a2-4707-ab37-9c29c18bf63d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan929@gmail.com", "Tuan", "hashed_password_1929", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0e23d86a-bca6-4a9e-bb93-b8f705635c3a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan333@gmail.com", "Tuan", "hashed_password_1333", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0ecc75ee-d0ef-4f2a-8a50-4e3972eba659"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan172@gmail.com", "Tuan", "hashed_password_1172", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0eeb6911-679f-4144-a7a9-5001158fedb0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan364@gmail.com", "Tuan", "hashed_password_1364", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0efafa40-052b-454b-b954-f7c1f33faa47"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan46@gmail.com", "Tuan", "hashed_password_146", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0f03fea4-e6cd-41e3-a2d3-b0e3a84ca1e4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan634@gmail.com", "Tuan", "hashed_password_1634", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0f041267-263e-470f-9770-de730c818536"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan871@gmail.com", "Tuan", "hashed_password_1871", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("0f662c69-3ee4-42ac-b472-44ded59497f0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan801@gmail.com", "Tuan", "hashed_password_1801", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("109f6d05-ea4a-41fa-ad0d-3ea2d542ab4b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan738@gmail.com", "Tuan", "hashed_password_1738", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("10bb0f3b-b362-44ad-b002-69b50c126231"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan423@gmail.com", "Tuan", "hashed_password_1423", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("111cc4b7-a9e5-4c5f-bdc7-0d7d259486f3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan528@gmail.com", "Tuan", "hashed_password_1528", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("117610b2-44ba-4b11-a0e4-0176151ea119"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan367@gmail.com", "Tuan", "hashed_password_1367", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("11c04ad9-dabb-45a5-9a06-68d22c184e78"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan112@gmail.com", "Tuan", "hashed_password_1112", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("11c680df-d56c-4c3f-97d8-ff30d19bdebf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan44@gmail.com", "Tuan", "hashed_password_144", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("122fcc82-0ac5-4f9d-9fcb-b24240aeb158"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan523@gmail.com", "Tuan", "hashed_password_1523", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("123fa5c9-ba87-462c-bbfb-8724735404ff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan729@gmail.com", "Tuan", "hashed_password_1729", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("126370c8-0cb5-4359-8a73-729c13cf6f56"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan655@gmail.com", "Tuan", "hashed_password_1655", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("128d4a11-2c40-42dc-9a8a-838bf10bc289"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan257@gmail.com", "Tuan", "hashed_password_1257", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1298ffe3-221b-40b6-87bc-6d30c79e5281"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan776@gmail.com", "Tuan", "hashed_password_1776", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("12e36191-aabd-4735-9b3c-19450cd3cb2f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan515@gmail.com", "Tuan", "hashed_password_1515", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("132b0680-aee8-4f97-8ae3-874ce57beddb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan511@gmail.com", "Tuan", "hashed_password_1511", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("145b22d4-de30-4d94-b08a-2b9613aff832"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan365@gmail.com", "Tuan", "hashed_password_1365", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("149d602a-7a10-4a4f-83cf-9021f058c176"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan945@gmail.com", "Tuan", "hashed_password_1945", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("14c2e699-7d5e-4c5b-b6a1-53de2a633927"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan215@gmail.com", "Tuan", "hashed_password_1215", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("14c9bf30-12fb-4f22-ae69-fb7defd5555e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan238@gmail.com", "Tuan", "hashed_password_1238", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1514a432-a42b-47ee-8920-08149ed875f5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan944@gmail.com", "Tuan", "hashed_password_1944", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1538cb24-18ff-45a2-b28d-2f5c6cb7d07a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan552@gmail.com", "Tuan", "hashed_password_1552", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1550647d-f0ac-40cb-a4cf-9ad1e4976410"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan943@gmail.com", "Tuan", "hashed_password_1943", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("15679b72-f539-4f21-8e21-a6d91751cdd0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan975@gmail.com", "Tuan", "hashed_password_1975", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("159fd0d4-ab50-437b-9717-6e5fd73219ba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan953@gmail.com", "Tuan", "hashed_password_1953", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("15b866af-ab33-4d5f-b501-eaa384b04cea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan207@gmail.com", "Tuan", "hashed_password_1207", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("15c41d4f-e6ee-404b-9c44-7121525525e5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan128@gmail.com", "Tuan", "hashed_password_1128", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("15ccf1ba-8177-4c40-b49c-656b7ec115e6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan259@gmail.com", "Tuan", "hashed_password_1259", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("15d72bbf-88a9-4438-8c94-af8191d73aa3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan9@gmail.com", "Tuan", "hashed_password_19", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("162e4cce-1e38-483a-ae7d-3f5891461b6a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan482@gmail.com", "Tuan", "hashed_password_1482", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("163086b1-8edb-4c8d-b67d-9f1bce291666"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan125@gmail.com", "Tuan", "hashed_password_1125", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("16ab468d-4272-4df4-8d55-29ed2e8bd63e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan725@gmail.com", "Tuan", "hashed_password_1725", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("16c57b8f-a9f8-4a5c-a6c3-d780aa5d1cb7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan660@gmail.com", "Tuan", "hashed_password_1660", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1767be34-46e1-4aef-9cc8-336a48e38ba4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan749@gmail.com", "Tuan", "hashed_password_1749", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("17eb11aa-076e-49ee-889f-4021a2ff7410"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan858@gmail.com", "Tuan", "hashed_password_1858", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("17fe519a-d126-40de-83f6-21f9fa2dcc67"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan744@gmail.com", "Tuan", "hashed_password_1744", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("183f3ccd-80b9-4f7b-aadb-14f7197fcc51"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan203@gmail.com", "Tuan", "hashed_password_1203", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1875cb1a-5f43-4d9b-8ae6-3c967643f7a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan350@gmail.com", "Tuan", "hashed_password_1350", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("18950b65-5511-495e-b5f2-b326411f58a6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan797@gmail.com", "Tuan", "hashed_password_1797", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("18b47411-fa89-45dc-9448-0dd953d5a8a7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan509@gmail.com", "Tuan", "hashed_password_1509", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("18ee2faa-af6e-434b-8a70-765a11ffa34b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan952@gmail.com", "Tuan", "hashed_password_1952", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("19034da4-4f40-48e2-8dab-8b5bc7c9ee73"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan461@gmail.com", "Tuan", "hashed_password_1461", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("195f0aa8-ddd2-4879-8c7c-b622071d8c96"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan831@gmail.com", "Tuan", "hashed_password_1831", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("19608de9-6927-4daf-81bb-a2e5bf9b8dd3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan490@gmail.com", "Tuan", "hashed_password_1490", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("19bf0771-980d-482f-a8e6-7892a21aa755"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan512@gmail.com", "Tuan", "hashed_password_1512", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1a10ae3a-3525-4f8d-a390-626544074fcc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan697@gmail.com", "Tuan", "hashed_password_1697", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1a3325a3-fc50-4229-9935-30d4626a8666"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan78@gmail.com", "Tuan", "hashed_password_178", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1ab2c0b9-6075-4fa9-94f3-0d66d3bf66d4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan653@gmail.com", "Tuan", "hashed_password_1653", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1b1d5e99-7051-40d0-befc-52e16cd3f5fa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan173@gmail.com", "Tuan", "hashed_password_1173", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1ba67b2f-039f-4cd3-8699-0b757106b384"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan236@gmail.com", "Tuan", "hashed_password_1236", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1baf87de-bd2b-4791-8241-6776f3a30d95"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan285@gmail.com", "Tuan", "hashed_password_1285", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1c00deaa-5d6e-4668-a3a5-81cf5669abc1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan439@gmail.com", "Tuan", "hashed_password_1439", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1c0ffa35-6f6b-46e3-a895-bbd7950a1970"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan398@gmail.com", "Tuan", "hashed_password_1398", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1c472e3a-7ef9-4ffe-9d4b-3ec77d02dba8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan686@gmail.com", "Tuan", "hashed_password_1686", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1c78c784-7d61-4992-9667-9996158b619b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan342@gmail.com", "Tuan", "hashed_password_1342", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1cc38ec3-5aa8-4fac-8221-862fdb9b26d2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan87@gmail.com", "Tuan", "hashed_password_187", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1ccd8adf-25c5-4eeb-b0a7-4546ff5565c7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan812@gmail.com", "Tuan", "hashed_password_1812", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1d0a5d34-1d0b-4fa4-8f0b-7bd33d938a3d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan14@gmail.com", "Tuan", "hashed_password_114", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1d410b01-fed1-4be4-ad36-facf9240b3fd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan374@gmail.com", "Tuan", "hashed_password_1374", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1d9477bc-4a16-45bc-8a27-a7efc69fadf3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan251@gmail.com", "Tuan", "hashed_password_1251", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1e4610ec-f650-439e-baa2-fd2c04421f20"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan896@gmail.com", "Tuan", "hashed_password_1896", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1f132845-bfa1-4399-866d-a699a9f98975"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan890@gmail.com", "Tuan", "hashed_password_1890", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1f5ef9b2-9bae-4dac-b9e1-c526dd3e3304"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan514@gmail.com", "Tuan", "hashed_password_1514", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("1fbf4335-27a1-4600-9d40-42154a8cbd5d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan325@gmail.com", "Tuan", "hashed_password_1325", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("20abebab-e121-4ec4-be4a-5d9decb992f4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan778@gmail.com", "Tuan", "hashed_password_1778", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("20b09b17-0888-40f7-823c-cc5aa6d7d7bb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan772@gmail.com", "Tuan", "hashed_password_1772", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("20b93ff2-2ff2-433f-a25a-c7b5500f1e46"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan223@gmail.com", "Tuan", "hashed_password_1223", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("218b1435-bec1-4030-a3e8-0d6e02d94e11"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan229@gmail.com", "Tuan", "hashed_password_1229", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("21da8819-7b19-4cb4-bfaf-48a3671b660f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan848@gmail.com", "Tuan", "hashed_password_1848", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("21edd4f3-b52d-47e1-bbf6-2f9ffa7e64a7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan846@gmail.com", "Tuan", "hashed_password_1846", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("223192b6-c559-44dc-a18a-bd1865c993ec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan641@gmail.com", "Tuan", "hashed_password_1641", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("225aad86-26ec-4069-ab29-3919ded18300"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan151@gmail.com", "Tuan", "hashed_password_1151", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2264069e-8cbf-4aec-a08b-154c75b1635f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan639@gmail.com", "Tuan", "hashed_password_1639", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("227b7335-a452-490a-93c1-588a9f54226f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan499@gmail.com", "Tuan", "hashed_password_1499", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("227ff68e-7fe8-4cb8-b95c-3da2e44f6d43"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan300@gmail.com", "Tuan", "hashed_password_1300", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("22ead8f1-ad5c-47d2-991f-7a75d2a96323"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan106@gmail.com", "Tuan", "hashed_password_1106", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("239dac97-a9d2-47e9-8949-14e1ed4e6dba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan334@gmail.com", "Tuan", "hashed_password_1334", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("23f9be09-d1b0-4c38-baf4-dbb2f78883fc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan894@gmail.com", "Tuan", "hashed_password_1894", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2418119a-3267-433b-972b-ab6291fc58e2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan719@gmail.com", "Tuan", "hashed_password_1719", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("24312693-1e13-4984-b7be-dafde9d28ad7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan573@gmail.com", "Tuan", "hashed_password_1573", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2446b078-f25d-45af-8177-472dc865ef1e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan856@gmail.com", "Tuan", "hashed_password_1856", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2477c322-e026-4621-88e0-d986f82f2847"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan911@gmail.com", "Tuan", "hashed_password_1911", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2482a828-c474-48e8-8b92-24de2db26c5a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan354@gmail.com", "Tuan", "hashed_password_1354", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("24978dd4-371b-4914-b41b-ec6e0670af2e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan640@gmail.com", "Tuan", "hashed_password_1640", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("24e0ee95-1e8f-415d-a956-fa335d61fa6d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan924@gmail.com", "Tuan", "hashed_password_1924", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("24e9b3d1-231a-473b-bc0b-bc70a5cff114"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan706@gmail.com", "Tuan", "hashed_password_1706", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2510abd5-f25d-4373-98bb-cb29697fcb52"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan290@gmail.com", "Tuan", "hashed_password_1290", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("25d2d3b2-5eec-49b4-90aa-91ddeba6a89e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan245@gmail.com", "Tuan", "hashed_password_1245", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("25d9efa3-39d3-451f-a6ad-58bad8260408"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan877@gmail.com", "Tuan", "hashed_password_1877", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("25f7ec75-065b-4b27-9801-94a504ac9609"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan670@gmail.com", "Tuan", "hashed_password_1670", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("264a4805-63e5-44dd-9ae5-7fd2d04b7b98"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan121@gmail.com", "Tuan", "hashed_password_1121", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("269866c2-7f9e-4d8d-b5c4-5413ce02530c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan60@gmail.com", "Tuan", "hashed_password_160", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("269d0552-dcaa-4fa7-95f4-a9049376f2fd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan912@gmail.com", "Tuan", "hashed_password_1912", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("269dc664-3cb4-4ca3-93a8-a2e058d8d68a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan891@gmail.com", "Tuan", "hashed_password_1891", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("26cd42bd-344f-46e9-9ddf-c6f195d77e9d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan470@gmail.com", "Tuan", "hashed_password_1470", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("26e1bb76-499b-49c1-af35-3584993e3cd4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan371@gmail.com", "Tuan", "hashed_password_1371", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("26f20286-5be0-4bd0-9a73-7f46278a8379"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan918@gmail.com", "Tuan", "hashed_password_1918", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("27195056-180a-4238-ae25-d37929e80322"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan430@gmail.com", "Tuan", "hashed_password_1430", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("273ecbff-2b60-4154-9970-8ecc89619153"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan597@gmail.com", "Tuan", "hashed_password_1597", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("27766563-7f8e-4012-9e4a-aa81181fd7a2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan392@gmail.com", "Tuan", "hashed_password_1392", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("27add9c0-8f34-4ccb-9b33-e1fbc9ff3296"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan63@gmail.com", "Tuan", "hashed_password_163", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("27b294a6-f4e0-4ad9-bc31-5b202ac6b915"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan635@gmail.com", "Tuan", "hashed_password_1635", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("27ba5108-a569-4d0a-9261-b58055c4bd54"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan451@gmail.com", "Tuan", "hashed_password_1451", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("27bd7c1c-547b-41c9-ac2c-07ad3930101e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan966@gmail.com", "Tuan", "hashed_password_1966", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("27d813d8-7d6b-43d2-b119-63df592b7d01"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan642@gmail.com", "Tuan", "hashed_password_1642", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("280a9a50-e4da-453f-aad6-acff60b8480e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan243@gmail.com", "Tuan", "hashed_password_1243", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2851e794-d537-4be5-b8bb-e247e3f616a1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan508@gmail.com", "Tuan", "hashed_password_1508", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("28fd4935-705b-416a-b103-61176f71308a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan283@gmail.com", "Tuan", "hashed_password_1283", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("290d67be-a6a9-4b90-987b-b4c36c165869"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan383@gmail.com", "Tuan", "hashed_password_1383", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2912f4ca-2fbd-4de6-bf33-0bf50179bb82"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan916@gmail.com", "Tuan", "hashed_password_1916", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2934f7cb-9c96-4665-a8e0-92be260c9a91"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan348@gmail.com", "Tuan", "hashed_password_1348", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("29575605-482b-413a-8df8-48d98699e791"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan507@gmail.com", "Tuan", "hashed_password_1507", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("29ce15d2-5d4c-42d8-b661-0267bb99f566"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan628@gmail.com", "Tuan", "hashed_password_1628", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2a001fbe-8a11-45e0-86a2-25398b2bec1b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan219@gmail.com", "Tuan", "hashed_password_1219", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2a3f4ba6-6f02-4a07-a46e-84ad8762c33c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan289@gmail.com", "Tuan", "hashed_password_1289", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2a60bf59-bcfb-4f3f-bd66-450b75f6f95f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan794@gmail.com", "Tuan", "hashed_password_1794", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2a70d017-7323-4e0c-a31c-d7afbb327a1b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan968@gmail.com", "Tuan", "hashed_password_1968", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2a9fad32-86ec-4ba3-9598-ed25d7b87de8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan460@gmail.com", "Tuan", "hashed_password_1460", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2b537da7-1db7-4c76-8cd2-85339f849046"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan510@gmail.com", "Tuan", "hashed_password_1510", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2b61b320-1f63-4ebe-b9c2-1c355b9978d8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan754@gmail.com", "Tuan", "hashed_password_1754", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2c4b1828-f532-4410-8e2f-e863025e2f18"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan625@gmail.com", "Tuan", "hashed_password_1625", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2c73a1e3-eef9-4648-b98f-a527197df9bb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan319@gmail.com", "Tuan", "hashed_password_1319", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2cfd7c00-9373-4a52-847e-33efd7abeed0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan630@gmail.com", "Tuan", "hashed_password_1630", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2dcdc404-eaf8-46fc-9688-828fec3536aa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan231@gmail.com", "Tuan", "hashed_password_1231", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2dee5efc-7474-45e0-a2b4-07535c22bee6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan687@gmail.com", "Tuan", "hashed_password_1687", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2dee6af6-57df-4c5c-b450-e809ec97627f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan983@gmail.com", "Tuan", "hashed_password_1983", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2e0a08b8-3b7c-4d3c-b9c4-caf2c669a8cb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan192@gmail.com", "Tuan", "hashed_password_1192", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2e18ce01-78cd-45da-b176-617c40023a42"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan444@gmail.com", "Tuan", "hashed_password_1444", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2e86ad6e-7fb4-44b5-97e2-c70ec0bf7d16"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan118@gmail.com", "Tuan", "hashed_password_1118", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2ef29957-5e32-46af-bb46-54a6f5a5ccf0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan632@gmail.com", "Tuan", "hashed_password_1632", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2ef41f8f-067d-40cb-a4d6-ce07f603981f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan982@gmail.com", "Tuan", "hashed_password_1982", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2ff55643-6db8-48d0-8d78-2f6afea9f9f3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan347@gmail.com", "Tuan", "hashed_password_1347", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("2ff98a32-779f-4bb6-a5df-3881f6a2fa19"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan521@gmail.com", "Tuan", "hashed_password_1521", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("31629eed-e23e-4ac5-bd81-3384851d8917"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan330@gmail.com", "Tuan", "hashed_password_1330", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("31786154-03a9-4dde-888d-8cee68df8d5a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan489@gmail.com", "Tuan", "hashed_password_1489", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("31d2b1b1-8513-4a23-ac27-fbc0ca1a8b27"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan453@gmail.com", "Tuan", "hashed_password_1453", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("323c5bbf-90cf-42b6-ba69-a0e63d7fe21c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan678@gmail.com", "Tuan", "hashed_password_1678", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3258dfd5-ac59-43e2-a52c-ae067c9f54f6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan493@gmail.com", "Tuan", "hashed_password_1493", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("32627927-fe6a-4b34-ab40-97facea7d238"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan195@gmail.com", "Tuan", "hashed_password_1195", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("326879e3-9025-4c15-8ab1-1e638b455793"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan923@gmail.com", "Tuan", "hashed_password_1923", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("326d0c30-8dd4-45a9-89fa-b78a3c2c86d2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan281@gmail.com", "Tuan", "hashed_password_1281", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("326f496d-137e-4fb2-ad2a-f710d8e3b912"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan942@gmail.com", "Tuan", "hashed_password_1942", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("328dc2e7-62a6-44d8-848b-6e56987e7952"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan98@gmail.com", "Tuan", "hashed_password_198", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("32b2f036-bb4b-4d4d-b1c5-dea760ae08df"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan709@gmail.com", "Tuan", "hashed_password_1709", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3335cae2-94b8-47a5-a35e-96e0d18b045d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan409@gmail.com", "Tuan", "hashed_password_1409", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("339f9eb1-3be0-43d9-ace9-6ef08535b940"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan809@gmail.com", "Tuan", "hashed_password_1809", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("33f6090b-641c-4c14-bde5-b1feda599752"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan471@gmail.com", "Tuan", "hashed_password_1471", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("348696da-cedf-4d0f-bf9b-ea0974ac1648"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan116@gmail.com", "Tuan", "hashed_password_1116", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("349f7a81-36d0-4735-91db-fe53fc1b622f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan276@gmail.com", "Tuan", "hashed_password_1276", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("34ed7209-ffc2-45cc-9e7d-09b122ea8969"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan931@gmail.com", "Tuan", "hashed_password_1931", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3518a022-f3fe-43fa-9219-43c85d4aaa43"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan40@gmail.com", "Tuan", "hashed_password_140", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3563f4e3-60ec-42e8-8fe0-ea2d89bea728"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan883@gmail.com", "Tuan", "hashed_password_1883", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("35df7455-f694-4171-8ae2-8ba97c83937e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan329@gmail.com", "Tuan", "hashed_password_1329", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("363e6a0a-80ce-4903-82cc-011094e61427"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan161@gmail.com", "Tuan", "hashed_password_1161", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("37643684-62b4-43cd-9ef1-1ea2db778e29"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan539@gmail.com", "Tuan", "hashed_password_1539", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("379ae450-8634-4d87-81f8-efe4d430d559"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan723@gmail.com", "Tuan", "hashed_password_1723", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("380550c2-f579-45d1-9ca0-f9f2362cc70c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan174@gmail.com", "Tuan", "hashed_password_1174", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("38327828-7770-4b7a-8b4c-5b57607ca11e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan139@gmail.com", "Tuan", "hashed_password_1139", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3896a623-5a5b-45fa-97f4-d0c6e67aa5eb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan96@gmail.com", "Tuan", "hashed_password_196", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("395bc27a-0da2-4452-829a-31539541f160"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan839@gmail.com", "Tuan", "hashed_password_1839", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("399b7f01-658c-4cd7-ba80-f6df117ccdfa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan819@gmail.com", "Tuan", "hashed_password_1819", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("39ba387d-0dea-44a7-bee4-e57f2a22770d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan971@gmail.com", "Tuan", "hashed_password_1971", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("39ced0b1-7181-4209-b835-174c415bb4ca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan407@gmail.com", "Tuan", "hashed_password_1407", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3a4a5431-1a8e-4174-9735-353178ffd032"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan385@gmail.com", "Tuan", "hashed_password_1385", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3af67983-fa45-4742-a7df-2171d0a222ea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan312@gmail.com", "Tuan", "hashed_password_1312", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3b1010a9-458e-44d2-9a22-139ccd88a6e5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan763@gmail.com", "Tuan", "hashed_password_1763", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3b217938-cff9-4ae8-91cb-d388dcf4d4d9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan527@gmail.com", "Tuan", "hashed_password_1527", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3b6bc4e5-1998-407e-ba27-36fa168cacd1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan485@gmail.com", "Tuan", "hashed_password_1485", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3bb30070-e9d5-4573-bc67-726e5ea90f8a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan252@gmail.com", "Tuan", "hashed_password_1252", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3c343461-108b-44d7-b593-c928c61ecd17"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan977@gmail.com", "Tuan", "hashed_password_1977", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3c3c4732-ad4a-490d-8d33-2ef386a6acb1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan123@gmail.com", "Tuan", "hashed_password_1123", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3c482e65-1aa4-4378-aa77-96f118e840ef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan892@gmail.com", "Tuan", "hashed_password_1892", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3caab6f5-ee9b-4b24-aaeb-ad9b48c65045"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan519@gmail.com", "Tuan", "hashed_password_1519", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3cf945d0-bed2-41c7-be85-c533e60e96f9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan900@gmail.com", "Tuan", "hashed_password_1900", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3d11acb9-42b7-46c4-8f05-95f6a26e82db"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan711@gmail.com", "Tuan", "hashed_password_1711", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3d9965d5-d3f3-414b-812c-c5c015a11c62"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan5@gmail.com", "Tuan", "hashed_password_15", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3d9d6174-1868-409c-94e7-3b712141c19a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan143@gmail.com", "Tuan", "hashed_password_1143", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3db2036f-6d8c-4669-8c55-56f806482182"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan732@gmail.com", "Tuan", "hashed_password_1732", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3db65e45-b2eb-4b22-a140-f79d2421e788"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan802@gmail.com", "Tuan", "hashed_password_1802", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3de70009-aa95-4dd3-95b1-1758cc054a2d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan964@gmail.com", "Tuan", "hashed_password_1964", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3f25dc14-1f6c-4ab7-8960-951b762ded70"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan0@gmail.com", "Tuan", "hashed_password_10", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3f8f1280-25fe-4e56-bc80-4b0eb71e7d80"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan951@gmail.com", "Tuan", "hashed_password_1951", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3fb5c57f-37e7-46bb-84ee-fa81818c7f5c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan596@gmail.com", "Tuan", "hashed_password_1596", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3fbbc24b-587c-4c18-9adf-bcff2b99d2e4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan516@gmail.com", "Tuan", "hashed_password_1516", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3fc151ee-188c-4f9e-8ef6-012e424954bb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan210@gmail.com", "Tuan", "hashed_password_1210", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3fe047b8-ea1b-434c-941a-887a3a2f84c9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan865@gmail.com", "Tuan", "hashed_password_1865", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("3ff85f7e-19c0-466e-8eb7-4e4c464baa3f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan965@gmail.com", "Tuan", "hashed_password_1965", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("40398041-68d8-4f00-91cf-9db453d9e9ae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan114@gmail.com", "Tuan", "hashed_password_1114", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("404c093a-2009-4471-881e-9f969292932d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan67@gmail.com", "Tuan", "hashed_password_167", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4061838d-f663-4595-92dd-1ce85ed4bc9f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan469@gmail.com", "Tuan", "hashed_password_1469", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("407638c3-d466-40f4-9310-b581f807b7af"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan614@gmail.com", "Tuan", "hashed_password_1614", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("409adcb8-f17a-43bc-9f2f-fc01cd32a70b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan3@gmail.com", "Tuan", "hashed_password_13", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("40dcd646-fd81-4a0e-b7fd-ea10c5905841"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan742@gmail.com", "Tuan", "hashed_password_1742", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4134a08f-a222-4977-b9ea-9f75dcec5bed"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan224@gmail.com", "Tuan", "hashed_password_1224", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("41660694-d20d-4f41-bcd0-7f82cf069b36"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan897@gmail.com", "Tuan", "hashed_password_1897", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("426ed6ed-1e50-4f1c-8df0-ca89bff4480b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan926@gmail.com", "Tuan", "hashed_password_1926", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("42714ad7-b8f4-4b8d-a14c-8791ee0696af"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan820@gmail.com", "Tuan", "hashed_password_1820", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4272b339-ea24-488f-9d99-ca7fb4c4d155"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan29@gmail.com", "Tuan", "hashed_password_129", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("42d71d05-f9e4-47b2-ae21-64aa957512d1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan65@gmail.com", "Tuan", "hashed_password_165", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("43c9e90e-858f-4846-9bd7-441948b73998"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan790@gmail.com", "Tuan", "hashed_password_1790", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("44269f57-defb-4e9c-ba3e-6c73953f8dc3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan646@gmail.com", "Tuan", "hashed_password_1646", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("44e491cb-96fc-434a-a9d5-262d110cc368"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan53@gmail.com", "Tuan", "hashed_password_153", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4564de01-f1e2-4763-9450-d7248b5d65e3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan696@gmail.com", "Tuan", "hashed_password_1696", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("459b32b5-28f6-4abf-97ff-e47fa2a6fac4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan337@gmail.com", "Tuan", "hashed_password_1337", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("45ec3c83-7fbe-49d6-86ed-b46447078fee"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan274@gmail.com", "Tuan", "hashed_password_1274", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4637abeb-89ff-4121-a58b-0bdb945082ad"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan381@gmail.com", "Tuan", "hashed_password_1381", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("466d3038-bdac-4841-9c1f-f23bca30b574"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan925@gmail.com", "Tuan", "hashed_password_1925", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("46860a90-4e83-4e97-a5b5-4c2e1751e511"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan17@gmail.com", "Tuan", "hashed_password_117", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("468db1d9-fa9d-4f1a-9f4f-43031a3a6339"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan19@gmail.com", "Tuan", "hashed_password_119", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("472dbff8-1408-4820-9109-11979a84e942"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan881@gmail.com", "Tuan", "hashed_password_1881", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("47750981-3246-427b-a41c-4072b8364a46"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan874@gmail.com", "Tuan", "hashed_password_1874", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("47f65f12-0bf9-4708-8a3d-81fad453d8c5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan767@gmail.com", "Tuan", "hashed_password_1767", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4807988b-d713-47dd-b382-3d8762f5fb54"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan757@gmail.com", "Tuan", "hashed_password_1757", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("483232c3-dc5c-4996-b846-fb5e6a45d125"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan476@gmail.com", "Tuan", "hashed_password_1476", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("48986219-0219-4273-9973-6c26aed5a5dd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan384@gmail.com", "Tuan", "hashed_password_1384", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("48a5c9b3-5e14-4c3d-8645-0dd751b0af6f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan80@gmail.com", "Tuan", "hashed_password_180", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("48c061a6-b8ca-453b-8664-12c1127432bc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan452@gmail.com", "Tuan", "hashed_password_1452", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("494b7e73-22c4-436c-b8b3-64e7d10f6b37"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan963@gmail.com", "Tuan", "hashed_password_1963", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("49c07370-5cbd-4e18-9eea-fe00be28c5c4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan7@gmail.com", "Tuan", "hashed_password_17", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("49d87860-4319-4ce3-b27c-b5e6a16cdc35"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan97@gmail.com", "Tuan", "hashed_password_197", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4a166aca-6aa2-4dda-a9af-6559db1ccd4e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan162@gmail.com", "Tuan", "hashed_password_1162", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4acc14cb-1cab-46e1-b504-2798c3bdff21"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan718@gmail.com", "Tuan", "hashed_password_1718", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4b290a58-7044-4fad-9531-86bef9f5ed84"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan79@gmail.com", "Tuan", "hashed_password_179", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4b733d93-862a-4bb9-a8db-81891b920be2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan27@gmail.com", "Tuan", "hashed_password_127", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4bca41d4-bcf7-4e16-9e4e-a22bf283a33a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan198@gmail.com", "Tuan", "hashed_password_1198", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4c5a12f9-3eb6-4077-a911-c1f595980494"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan676@gmail.com", "Tuan", "hashed_password_1676", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4cad6d9b-a111-4d74-9685-b1be5634bbea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan841@gmail.com", "Tuan", "hashed_password_1841", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4cb3671b-45f6-4363-9af9-2b9e81141f15"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan876@gmail.com", "Tuan", "hashed_password_1876", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4cd88f28-241d-473c-ba1d-60b6f4e5c64b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan700@gmail.com", "Tuan", "hashed_password_1700", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4cda95cd-e39b-4b6d-b5cb-addb432f9979"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan185@gmail.com", "Tuan", "hashed_password_1185", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4d11263a-3ffb-477e-8d96-238635b28d04"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan187@gmail.com", "Tuan", "hashed_password_1187", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4d6b98ee-b59d-4b0d-becd-6e4fedf94232"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan295@gmail.com", "Tuan", "hashed_password_1295", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4dc8f66f-bbb8-4951-b597-96dcbfc68d16"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan189@gmail.com", "Tuan", "hashed_password_1189", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4dd5f7c8-ea0b-49a3-9995-019bed620b01"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan233@gmail.com", "Tuan", "hashed_password_1233", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4dff9742-3295-444f-9fb4-d168cb43d7b3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan160@gmail.com", "Tuan", "hashed_password_1160", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4ea94d90-b496-43f1-9c90-a5b6f0c8e3b7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan937@gmail.com", "Tuan", "hashed_password_1937", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4eaa69f7-50d3-4796-873b-186b0e560125"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan609@gmail.com", "Tuan", "hashed_password_1609", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4ef90a81-d7e5-4954-8a5e-759c9979ba45"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan340@gmail.com", "Tuan", "hashed_password_1340", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4f84e859-c1a4-44ef-a214-a576182a421f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan769@gmail.com", "Tuan", "hashed_password_1769", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4f8c4982-4046-41ef-bb08-1daa34a38905"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan442@gmail.com", "Tuan", "hashed_password_1442", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("4ff61382-dfb1-4742-8700-bc95498248c5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan411@gmail.com", "Tuan", "hashed_password_1411", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5033f2cd-224e-4b01-8a85-64e335475603"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan587@gmail.com", "Tuan", "hashed_password_1587", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("50d7a133-41ba-425a-b984-e7506839d311"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan74@gmail.com", "Tuan", "hashed_password_174", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5113b7c3-44c9-45ed-8aa9-4cb678899fd5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan391@gmail.com", "Tuan", "hashed_password_1391", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("511da089-550f-4ba4-96c1-46c6e7bb1e31"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan234@gmail.com", "Tuan", "hashed_password_1234", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("51efc3ad-cbaa-4296-ae7d-1b4b840f4962"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan722@gmail.com", "Tuan", "hashed_password_1722", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("522363b1-3c74-4c16-866d-08bd046fb694"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan34@gmail.com", "Tuan", "hashed_password_134", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("52bc8cdf-6339-4901-bed2-9600631e4ee8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan134@gmail.com", "Tuan", "hashed_password_1134", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("52c6434a-ce05-4272-84b0-2b6c1764c01b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan49@gmail.com", "Tuan", "hashed_password_149", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("530fdce1-1c58-41bf-a615-5cb6413f74e8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan204@gmail.com", "Tuan", "hashed_password_1204", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5314d2be-34b7-4b21-8620-bf0e060b14bf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan152@gmail.com", "Tuan", "hashed_password_1152", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("53305e77-fb33-46d3-8dad-122aeb33f32e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan396@gmail.com", "Tuan", "hashed_password_1396", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("54296f4c-4d04-4168-9b97-0dd0a8a60f64"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan668@gmail.com", "Tuan", "hashed_password_1668", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5451231f-e5f2-491c-99eb-e212933c1cf4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan524@gmail.com", "Tuan", "hashed_password_1524", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5451af28-a542-4225-9adf-f6bb489524b1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan586@gmail.com", "Tuan", "hashed_password_1586", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("548233eb-4628-4dc0-86cb-030e61e47a16"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan369@gmail.com", "Tuan", "hashed_password_1369", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("54ff8611-ac22-46c9-a2ca-cf42feb47c4a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan534@gmail.com", "Tuan", "hashed_password_1534", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("551b5aea-1710-466a-a69c-8b4d7c7253dc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan541@gmail.com", "Tuan", "hashed_password_1541", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("553271e4-8f58-4fba-84ae-e8833b08c3f9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan880@gmail.com", "Tuan", "hashed_password_1880", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("55ee5470-43e0-49fa-808d-bc2aeaddc579"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan100@gmail.com", "Tuan", "hashed_password_1100", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("560c70c5-2466-4abb-8e0c-26c01f0c3f9a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan263@gmail.com", "Tuan", "hashed_password_1263", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("56e4dde9-6e3f-48e4-97c0-7c4bc0d9f571"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan863@gmail.com", "Tuan", "hashed_password_1863", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("56e858e0-9679-48ce-89db-ebb45735c6dd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan181@gmail.com", "Tuan", "hashed_password_1181", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("570ebf6e-a9fc-44fc-a9e3-5667db236e44"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan141@gmail.com", "Tuan", "hashed_password_1141", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("57235e2f-ec95-4456-91b8-aba8af7f8e1a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan946@gmail.com", "Tuan", "hashed_password_1946", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5753d5d3-1910-4846-aded-e0d08d77db8b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan468@gmail.com", "Tuan", "hashed_password_1468", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("578c27b7-a9e7-4c52-ac5f-684ee04cf90c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan255@gmail.com", "Tuan", "hashed_password_1255", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("57974fdc-5f10-40ca-95e5-31b5ae731f7f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan137@gmail.com", "Tuan", "hashed_password_1137", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("57b9a274-14a4-4ed4-af83-f566b0184311"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan486@gmail.com", "Tuan", "hashed_password_1486", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("581b140e-74a3-4f07-b71a-e5c48c9acbff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan604@gmail.com", "Tuan", "hashed_password_1604", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5859e86d-4c3c-4b0c-9420-c446597c81b9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan825@gmail.com", "Tuan", "hashed_password_1825", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("58658bea-c777-401d-a119-0e75c36b3abb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan388@gmail.com", "Tuan", "hashed_password_1388", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("589a63ae-7603-47aa-a2a8-f853a66e64ff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan557@gmail.com", "Tuan", "hashed_password_1557", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("58ec385b-ff0b-47f5-b5e1-20eabfcc7535"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan99@gmail.com", "Tuan", "hashed_password_199", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("59245101-4ae1-4a39-a936-aad78cffaae5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan683@gmail.com", "Tuan", "hashed_password_1683", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("594a376f-07a6-4646-88dc-0f06dc6c9cca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan393@gmail.com", "Tuan", "hashed_password_1393", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("59f6b253-dc1d-4452-9354-915582fdfc7f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan8@gmail.com", "Tuan", "hashed_password_18", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5a510f77-562b-4346-bd9b-98e88c22e5cc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan222@gmail.com", "Tuan", "hashed_password_1222", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5a782c6e-a50d-4b63-b2cc-8d2f726c5d20"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan446@gmail.com", "Tuan", "hashed_password_1446", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5ac419d0-09f6-4de2-8cd0-f83f8fbde0ac"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan382@gmail.com", "Tuan", "hashed_password_1382", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5b56d9c7-6207-4ecd-8563-ec8a7fc95a96"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan565@gmail.com", "Tuan", "hashed_password_1565", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5b613756-c87b-4769-9c47-be9d5d533abc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan948@gmail.com", "Tuan", "hashed_password_1948", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5bdc8882-701b-4614-9bc5-a7a783509b81"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan254@gmail.com", "Tuan", "hashed_password_1254", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5caada8e-cf62-418a-b31a-ed92ce4a05fa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan590@gmail.com", "Tuan", "hashed_password_1590", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5d21e044-6842-451a-994a-0d6581777f46"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan520@gmail.com", "Tuan", "hashed_password_1520", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5d7a1d56-acbd-45a5-a6e6-8e2bf70aff51"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan618@gmail.com", "Tuan", "hashed_password_1618", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5dad4d56-664f-469c-ae35-44115188d0d1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan483@gmail.com", "Tuan", "hashed_password_1483", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5e05c2f5-0894-41c0-b441-078c85dc98fe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan935@gmail.com", "Tuan", "hashed_password_1935", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5e95d546-ed52-418f-bba1-b6ce50954e3e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan888@gmail.com", "Tuan", "hashed_password_1888", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5ea10b9b-ede2-45a2-9e2f-a1e1ca4c249c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan206@gmail.com", "Tuan", "hashed_password_1206", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5ec3c0f7-648d-449a-99de-0964a420de54"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan969@gmail.com", "Tuan", "hashed_password_1969", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5f417747-2e9e-425d-a88c-10c8a81b8654"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan455@gmail.com", "Tuan", "hashed_password_1455", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5f5e7f7c-6ea3-4154-ab9d-0d3662950479"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan859@gmail.com", "Tuan", "hashed_password_1859", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5f6476f0-8e59-439b-b701-5673cd1d284d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan574@gmail.com", "Tuan", "hashed_password_1574", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("5f8702a2-84ad-4495-b722-ac9e144d23b8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan190@gmail.com", "Tuan", "hashed_password_1190", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6009895e-8724-40e8-a1d5-0c4a6d119195"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan751@gmail.com", "Tuan", "hashed_password_1751", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("60168a18-0d3a-40df-9d2f-ce466c9a5e07"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan346@gmail.com", "Tuan", "hashed_password_1346", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("603fd2e1-1e04-4378-887a-d9aa8883a0f3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan305@gmail.com", "Tuan", "hashed_password_1305", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6044ab42-f89f-498f-9120-2d89ed746065"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan322@gmail.com", "Tuan", "hashed_password_1322", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("60760abd-d79d-40ab-9ff7-12b3e8827eae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan626@gmail.com", "Tuan", "hashed_password_1626", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("60a0ae21-b397-43b0-a00f-6a5cd118e41b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan37@gmail.com", "Tuan", "hashed_password_137", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("60bb4f94-370a-433c-a78d-45a53eace3e6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan857@gmail.com", "Tuan", "hashed_password_1857", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("61c1405b-508d-4349-8cf6-261019cff675"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan13@gmail.com", "Tuan", "hashed_password_113", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("61e7167a-93c0-4643-b3dd-8995940da860"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan994@gmail.com", "Tuan", "hashed_password_1994", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("62179716-7cb5-4c77-9a1c-da1800feff53"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan920@gmail.com", "Tuan", "hashed_password_1920", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("62896215-729a-4378-8dd7-24e3b9bafccb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan262@gmail.com", "Tuan", "hashed_password_1262", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("62aad954-3590-4998-bcc8-6a6ba68d3901"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan592@gmail.com", "Tuan", "hashed_password_1592", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("62bb0cb6-e44c-4d35-a348-5d7d27c15951"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan284@gmail.com", "Tuan", "hashed_password_1284", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("635bb69b-e153-4916-9a0c-a8c964c60238"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan378@gmail.com", "Tuan", "hashed_password_1378", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6390b89d-a4d6-46f6-9a30-f00ebde5cd05"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan474@gmail.com", "Tuan", "hashed_password_1474", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("63edd17c-9c57-4f85-be25-ba0f511c167f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan86@gmail.com", "Tuan", "hashed_password_186", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6417e430-9dfe-4ad4-8df1-57b783c81ee9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan309@gmail.com", "Tuan", "hashed_password_1309", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("64719704-828b-4858-a38d-14487eb1a086"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan580@gmail.com", "Tuan", "hashed_password_1580", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("64af7d05-69e8-44d4-b0ca-e662d59d3185"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan932@gmail.com", "Tuan", "hashed_password_1932", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("651d4e5a-ce7e-4aae-ad23-cf8b38065dac"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan947@gmail.com", "Tuan", "hashed_password_1947", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6527eaa0-b9fb-4adf-995c-b4b45b1fd246"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan15@gmail.com", "Tuan", "hashed_password_115", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("653c86f6-e43e-43b7-9fe0-023d7a58ba60"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan817@gmail.com", "Tuan", "hashed_password_1817", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("656c8146-0916-4bd2-994e-5d353426dc92"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan605@gmail.com", "Tuan", "hashed_password_1605", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("65bbb8df-a49b-4ec0-aa43-c3a227b1d0a8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan117@gmail.com", "Tuan", "hashed_password_1117", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("65cea127-4d63-4d4c-82ec-93e0021d4b13"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan310@gmail.com", "Tuan", "hashed_password_1310", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("660ab204-418a-4ea5-91a2-580ec1b46e44"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan297@gmail.com", "Tuan", "hashed_password_1297", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("664a2c84-4225-4633-9801-fb0cc384c0f9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan798@gmail.com", "Tuan", "hashed_password_1798", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("66645405-d368-4ca8-a806-567fc4cd9ec4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan577@gmail.com", "Tuan", "hashed_password_1577", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("66acd44f-7f13-437d-ae21-337172cbbbe8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan495@gmail.com", "Tuan", "hashed_password_1495", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("677da3ad-8e71-4bb8-9a2c-901b831e64b0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan986@gmail.com", "Tuan", "hashed_password_1986", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("68228995-1bc6-436f-bc49-e555e395a216"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan835@gmail.com", "Tuan", "hashed_password_1835", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("682e8f94-1a86-40ff-bfbe-121707325f78"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan588@gmail.com", "Tuan", "hashed_password_1588", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6839f6c5-f6ec-4c20-80ee-0f0bcc1ebbd7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan480@gmail.com", "Tuan", "hashed_password_1480", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("686d0150-2416-4f97-a838-590b6120ecc9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan875@gmail.com", "Tuan", "hashed_password_1875", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("68db50f1-59da-45ad-9897-2608a85dd9d0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan606@gmail.com", "Tuan", "hashed_password_1606", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("69302959-77ae-470a-bcfd-64c8adf144d4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan914@gmail.com", "Tuan", "hashed_password_1914", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("69514928-4364-4b79-bae5-b7b466528f20"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuanle17062k6@gmail.com", "Tuan", "hashed_password_1", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6986bf6a-fe60-4aa6-9baa-c16c6c115d9e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan260@gmail.com", "Tuan", "hashed_password_1260", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6a346fe2-5816-49a3-beca-fbe6fe7b59b5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan602@gmail.com", "Tuan", "hashed_password_1602", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6a74d1d9-240f-4e83-ab39-1c0f1a592110"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan196@gmail.com", "Tuan", "hashed_password_1196", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6a7fbc8a-14d6-4545-8b82-b9ceaed641b2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan899@gmail.com", "Tuan", "hashed_password_1899", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6ac2adbe-1823-4051-9d35-4bd26e135996"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan568@gmail.com", "Tuan", "hashed_password_1568", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6b40f9f1-5e12-4387-980f-d699c1c81aca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan538@gmail.com", "Tuan", "hashed_password_1538", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6c9ba27a-d69d-4921-ba50-8c63efc339ee"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan758@gmail.com", "Tuan", "hashed_password_1758", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6cb15972-960e-4c81-973a-3834016f56b7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan191@gmail.com", "Tuan", "hashed_password_1191", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6cd76940-6e53-49d3-ac75-3cf7863574da"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan209@gmail.com", "Tuan", "hashed_password_1209", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6ce922c2-7295-4e6b-baa5-aeeb8760d56d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan89@gmail.com", "Tuan", "hashed_password_189", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6cef1af9-b985-4a0a-acb7-bb97011387c6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan249@gmail.com", "Tuan", "hashed_password_1249", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6d460154-30f6-4ef1-9e12-a62b34f8ad02"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan163@gmail.com", "Tuan", "hashed_password_1163", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6d61fa25-b02a-4a49-9c95-3a0b9b987545"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan479@gmail.com", "Tuan", "hashed_password_1479", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6db4a090-279e-4c21-ba6d-ea2a090d5ab9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan627@gmail.com", "Tuan", "hashed_password_1627", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6df8794a-d667-4a57-b3e6-da9d72ba3a89"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan440@gmail.com", "Tuan", "hashed_password_1440", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6e31eec1-6312-429c-b84f-a6f7e837e2ab"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan613@gmail.com", "Tuan", "hashed_password_1613", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6e5a6309-3e88-47b3-a215-7d0c5c5e7f0e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan861@gmail.com", "Tuan", "hashed_password_1861", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6e9d6f89-673a-48a9-9b26-fe74fe662d7c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan399@gmail.com", "Tuan", "hashed_password_1399", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6f197d69-c21f-4598-991b-1cfaa8ea9dd7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan760@gmail.com", "Tuan", "hashed_password_1760", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6f324327-768b-4e31-89c2-0e2bb0c64304"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan358@gmail.com", "Tuan", "hashed_password_1358", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6fab99e7-9006-4c0a-aa49-93f9f2fa07a1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan61@gmail.com", "Tuan", "hashed_password_161", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("6ff55046-3e1e-4ce8-bad3-ca1f0f1a5803"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan741@gmail.com", "Tuan", "hashed_password_1741", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7029d7ea-4e30-4c49-be7c-9a4bd446c28a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan773@gmail.com", "Tuan", "hashed_password_1773", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7036494a-d83c-41e7-95a1-7d5055450f44"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan178@gmail.com", "Tuan", "hashed_password_1178", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("705bea85-c8f0-4f77-bb10-6112d88aacf1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan306@gmail.com", "Tuan", "hashed_password_1306", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("70b3458c-e579-4f04-9454-5d1d61957738"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan731@gmail.com", "Tuan", "hashed_password_1731", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("711ac726-07db-4dc9-b56b-10d12df53eed"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan922@gmail.com", "Tuan", "hashed_password_1922", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7148700b-cb02-4242-b90e-4f8be66e43ba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan637@gmail.com", "Tuan", "hashed_password_1637", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7221e3da-5cf7-4eea-b05f-7cfe2f6f622c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan462@gmail.com", "Tuan", "hashed_password_1462", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7274ee08-d715-4b00-8309-f25256d7b068"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan90@gmail.com", "Tuan", "hashed_password_190", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("72a782ab-2679-49d4-a65e-da8bd4c84aa8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan703@gmail.com", "Tuan", "hashed_password_1703", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("72ad47c5-c803-44f9-bc67-1bafb9fd6da9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan717@gmail.com", "Tuan", "hashed_password_1717", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("72ba0070-909a-4aa4-915f-5da046669e8f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan884@gmail.com", "Tuan", "hashed_password_1884", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("72cb3929-32db-4934-b154-12777eaf33aa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan32@gmail.com", "Tuan", "hashed_password_132", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7308f373-fa16-48ca-825a-b8f4034342be"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan366@gmail.com", "Tuan", "hashed_password_1366", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7395a519-5a11-48ed-93b1-7a086b23da02"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan673@gmail.com", "Tuan", "hashed_password_1673", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("739b3679-83d3-4d3e-a56d-d6eb32081367"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan165@gmail.com", "Tuan", "hashed_password_1165", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("73ad8fe3-46a3-404a-84c3-a08ced039111"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan405@gmail.com", "Tuan", "hashed_password_1405", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("74ad6bfc-4b92-4982-80ad-d0c3cbe931db"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan102@gmail.com", "Tuan", "hashed_password_1102", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("74c5139f-5385-43d6-ab4f-4a9c875c0c2f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan443@gmail.com", "Tuan", "hashed_password_1443", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7505840e-a419-45c6-9aa3-042a0d29ac51"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan202@gmail.com", "Tuan", "hashed_password_1202", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7508cc80-9e37-4cf3-b40a-238d1c5bf25a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan940@gmail.com", "Tuan", "hashed_password_1940", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7594a539-f1a0-4786-bbc6-49783ed3341e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan714@gmail.com", "Tuan", "hashed_password_1714", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("762c8869-a10f-4293-ac4e-5ae833ec056a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan784@gmail.com", "Tuan", "hashed_password_1784", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("763277fa-90da-4ae5-9969-bcfa42c196e4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan120@gmail.com", "Tuan", "hashed_password_1120", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("763a6db4-8f6f-4453-8065-792a7264d826"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan680@gmail.com", "Tuan", "hashed_password_1680", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7640044e-fb5a-4261-b29b-09c86d3cd6d6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan561@gmail.com", "Tuan", "hashed_password_1561", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("769a6bda-76d4-4dcb-b210-c2645cca328c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan311@gmail.com", "Tuan", "hashed_password_1311", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("76d72a02-c20c-4499-b0a2-54a5a44525b3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan779@gmail.com", "Tuan", "hashed_password_1779", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("76ea901c-c271-4026-8546-3e1bff8f9c38"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan81@gmail.com", "Tuan", "hashed_password_181", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("76f1ddca-1ec1-471b-8968-4fde038db43f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan20@gmail.com", "Tuan", "hashed_password_120", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("770d6d98-5eac-470a-b360-4522e015f2da"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan338@gmail.com", "Tuan", "hashed_password_1338", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("77188519-42ac-4984-bc96-8886eb76444f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan177@gmail.com", "Tuan", "hashed_password_1177", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7751853f-da43-44da-82bf-99b869197100"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan4@gmail.com", "Tuan", "hashed_password_14", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("777eee8e-29b3-4a96-8f43-3148d09ce296"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan813@gmail.com", "Tuan", "hashed_password_1813", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("77da9aee-e6ca-49f6-a5f9-7dfa66d1a91f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan716@gmail.com", "Tuan", "hashed_password_1716", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("788e68c5-be15-40e4-a2e9-92fc9b8c05e5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan208@gmail.com", "Tuan", "hashed_password_1208", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("78a628e2-fe47-45fe-9528-e2f391d7c26d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan225@gmail.com", "Tuan", "hashed_password_1225", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("78a7a547-d349-407f-9029-2a09e16ea08c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan998@gmail.com", "Tuan", "hashed_password_1998", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("78a8fe15-402a-47df-a1f4-99b1d9cf86b7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan995@gmail.com", "Tuan", "hashed_password_1995", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("78b3a94c-aba8-41fc-bc02-3866cf37b2cf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan589@gmail.com", "Tuan", "hashed_password_1589", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("78e98071-e71f-4c8e-a9d5-9cdcd6654c9a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan332@gmail.com", "Tuan", "hashed_password_1332", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("79955865-3229-4f32-b376-2dd1777455a0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan379@gmail.com", "Tuan", "hashed_password_1379", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("79d2c6af-3468-456a-88f9-47c731c48c07"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan301@gmail.com", "Tuan", "hashed_password_1301", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7a20bbaa-df99-4ed8-acdf-4fa7025fd5fb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan326@gmail.com", "Tuan", "hashed_password_1326", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7ac645a1-e2c8-4cde-9623-d5fc509f06c6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan737@gmail.com", "Tuan", "hashed_password_1737", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7b28464f-68bd-4893-a43a-bded8e000575"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan103@gmail.com", "Tuan", "hashed_password_1103", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7b4cfddf-81aa-4e51-861c-ec6734321d71"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan401@gmail.com", "Tuan", "hashed_password_1401", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7b78e08b-5e19-441e-abae-d56e8edd0664"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan246@gmail.com", "Tuan", "hashed_password_1246", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7bac2d52-d4ed-4b8c-856b-20315f11d516"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan679@gmail.com", "Tuan", "hashed_password_1679", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7c0e7341-e786-4ea2-9bfe-b542c6422284"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan607@gmail.com", "Tuan", "hashed_password_1607", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7c162db8-4303-41ce-b43d-434d83215ad3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan1@gmail.com", "Tuan", "hashed_password_11", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7cbb42ae-048e-4cbb-999a-1e34613db841"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan845@gmail.com", "Tuan", "hashed_password_1845", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7d63f68b-7792-4860-84a3-b324819ce2ff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan728@gmail.com", "Tuan", "hashed_password_1728", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7d74af75-bb9d-44e0-b0fb-ba2023b598cf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan531@gmail.com", "Tuan", "hashed_password_1531", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7dfea93c-10a7-452b-b32a-572952e0bc26"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan740@gmail.com", "Tuan", "hashed_password_1740", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7e5f750a-fcc1-408e-bc20-009539fb1e15"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan45@gmail.com", "Tuan", "hashed_password_145", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7f338215-5725-4325-8c43-b1ec2c2f5dca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan867@gmail.com", "Tuan", "hashed_password_1867", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("7f81ce13-b672-4cd5-be4e-6e34194d039f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan421@gmail.com", "Tuan", "hashed_password_1421", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("803df189-97c6-41ba-844a-abfd5558329f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan389@gmail.com", "Tuan", "hashed_password_1389", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("807dc624-a5fd-4964-93c5-f41b47985b83"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan265@gmail.com", "Tuan", "hashed_password_1265", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("809595eb-2b63-4a7a-ac81-b210ac175c86"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan840@gmail.com", "Tuan", "hashed_password_1840", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("813cb026-5fc0-4a2c-a389-ff3967acfc0e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan546@gmail.com", "Tuan", "hashed_password_1546", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8150d138-e5bf-40f4-9077-e0a7bb04f41a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan42@gmail.com", "Tuan", "hashed_password_142", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("815da1f8-5046-440f-a89e-0e84840fcab7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan699@gmail.com", "Tuan", "hashed_password_1699", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("817be0e3-0cfc-4425-9ed9-15bae6029774"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan833@gmail.com", "Tuan", "hashed_password_1833", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("81a17ad5-8293-4d52-ae0d-d9f11eba1a23"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan707@gmail.com", "Tuan", "hashed_password_1707", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("825cd9a7-76a5-4cc4-af7d-6c6b341bc1d6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan991@gmail.com", "Tuan", "hashed_password_1991", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("82b5ed80-6caf-455b-89aa-6fd302a8d105"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan280@gmail.com", "Tuan", "hashed_password_1280", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("82c7dd26-e26d-455a-9917-bcecfbd74e47"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan518@gmail.com", "Tuan", "hashed_password_1518", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("82cd45eb-5849-46c6-b162-ed55bfccbdab"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan905@gmail.com", "Tuan", "hashed_password_1905", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("82e24665-4c18-4c3b-86b3-6626e7468fa9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan431@gmail.com", "Tuan", "hashed_password_1431", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8330701b-8a51-41fe-8b8b-80a11aef5808"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan811@gmail.com", "Tuan", "hashed_password_1811", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("83618447-785a-4229-b763-bc48a9ff6ebd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan928@gmail.com", "Tuan", "hashed_password_1928", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("839cf250-8c8f-49ab-859f-842f47a76724"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan435@gmail.com", "Tuan", "hashed_password_1435", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("841782f9-7960-4f7b-a3e0-2191e9616440"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan416@gmail.com", "Tuan", "hashed_password_1416", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("842fc41f-1c45-47e5-b117-5482b3af91d9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan584@gmail.com", "Tuan", "hashed_password_1584", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("84341791-03e1-46d1-8c4a-adc926572c11"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan359@gmail.com", "Tuan", "hashed_password_1359", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("84766456-d3f0-4c97-8d28-9bf496bf132d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan569@gmail.com", "Tuan", "hashed_password_1569", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("850a11ef-675b-4470-955e-89d4c72a7917"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan477@gmail.com", "Tuan", "hashed_password_1477", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("851e6048-ec27-4389-9263-6e4cf6bd9272"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan193@gmail.com", "Tuan", "hashed_password_1193", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("857fa71a-a779-4632-adee-23f3dabffa60"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan101@gmail.com", "Tuan", "hashed_password_1101", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("85817ded-6be5-426e-8c54-6486dcff6506"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan960@gmail.com", "Tuan", "hashed_password_1960", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("85aa79d8-94ef-4432-b62c-1a3a57481879"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan496@gmail.com", "Tuan", "hashed_password_1496", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("85ed404d-1889-4cd8-8ec2-82b3c8cd3862"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan843@gmail.com", "Tuan", "hashed_password_1843", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("860d21ab-3e6f-4c28-853b-ea4d189f81af"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan787@gmail.com", "Tuan", "hashed_password_1787", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8622d544-2f59-4042-b75a-7962bed3383b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan345@gmail.com", "Tuan", "hashed_password_1345", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("862f6ea3-ded9-4122-ab19-8b65e6f69e24"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan256@gmail.com", "Tuan", "hashed_password_1256", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("86313b67-c712-4a18-bace-b9588cdb168e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan941@gmail.com", "Tuan", "hashed_password_1941", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("86730cb3-c014-4d3d-9176-0576b3bda3ce"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan503@gmail.com", "Tuan", "hashed_password_1503", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("86946737-b4b5-449f-83dd-5f850c4dc4aa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan159@gmail.com", "Tuan", "hashed_password_1159", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("86d472aa-9fc1-4b31-a710-32f75bad4dad"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan228@gmail.com", "Tuan", "hashed_password_1228", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("86efa8e7-ef58-4f2e-9bc6-d3de5bf05b48"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan675@gmail.com", "Tuan", "hashed_password_1675", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("870920ab-4acf-49bc-85a6-f78324c0b5c1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan854@gmail.com", "Tuan", "hashed_password_1854", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("874d12f2-95b9-489b-be60-e6b385aa729b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan148@gmail.com", "Tuan", "hashed_password_1148", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("876daae3-6b17-4251-b600-375c865f9c0f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan394@gmail.com", "Tuan", "hashed_password_1394", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("879d5d7a-7ae5-4e61-b72d-77c9aba8466a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan878@gmail.com", "Tuan", "hashed_password_1878", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("87b5f6a4-e1fc-40ba-ba94-89571425cfc8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan764@gmail.com", "Tuan", "hashed_password_1764", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("88171431-882d-4577-9754-f3b0567bb84f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan438@gmail.com", "Tuan", "hashed_password_1438", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8818dcf7-20a6-4a13-a03b-a89d1dc9e852"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan363@gmail.com", "Tuan", "hashed_password_1363", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("882a0388-91ec-4c52-86b1-0a7e2b5b5d97"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan167@gmail.com", "Tuan", "hashed_password_1167", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("88609f0d-92e2-4f6c-8e69-fd2f91ea4b1c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan997@gmail.com", "Tuan", "hashed_password_1997", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("887a0693-d7a3-4b4b-a207-5124cac2e459"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan647@gmail.com", "Tuan", "hashed_password_1647", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("887cfb33-dabf-4ab8-9930-9436af4964e8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan115@gmail.com", "Tuan", "hashed_password_1115", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("888d05d1-e979-4fa5-9e3c-18f1c3323a29"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan11@gmail.com", "Tuan", "hashed_password_111", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("88a50169-d559-4706-9a8d-ad5b77d881a6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan235@gmail.com", "Tuan", "hashed_password_1235", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("88ce2080-dd3a-4dd3-8e06-3946e9714301"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan962@gmail.com", "Tuan", "hashed_password_1962", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("88f731e3-deae-43fc-af30-34b1afe922f9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan643@gmail.com", "Tuan", "hashed_password_1643", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("88fc5622-47a3-411e-b094-219d6b7d2a8b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan368@gmail.com", "Tuan", "hashed_password_1368", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("893cacd0-5fca-4e54-8367-30625534b86c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan108@gmail.com", "Tuan", "hashed_password_1108", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8973d534-b794-49fa-b601-c1756640fcec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan214@gmail.com", "Tuan", "hashed_password_1214", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("89955f66-c197-427f-92be-9dd1781043c3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan705@gmail.com", "Tuan", "hashed_password_1705", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8a3a90da-2570-43f2-85dc-d47e2e114ff9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan400@gmail.com", "Tuan", "hashed_password_1400", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8a4114b2-e63b-4bdc-9a98-8f77f70b34c7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan921@gmail.com", "Tuan", "hashed_password_1921", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8a691abf-76f6-43c2-8423-83c080720168"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan201@gmail.com", "Tuan", "hashed_password_1201", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8abe0c23-fcff-4da5-8e3b-6fb5d67c1f34"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan992@gmail.com", "Tuan", "hashed_password_1992", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8b3320ec-6efb-4d3b-92ed-c5150668bd3f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan481@gmail.com", "Tuan", "hashed_password_1481", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8b3bafba-5566-46a3-bbeb-7e26670e1bfc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan353@gmail.com", "Tuan", "hashed_password_1353", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8b77a6f5-d794-477e-8682-7c6a6f76165b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan467@gmail.com", "Tuan", "hashed_password_1467", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8b9e0ccc-6588-487d-b018-6b373c4ef53e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan83@gmail.com", "Tuan", "hashed_password_183", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8beb1b79-9fb2-4379-b392-3c608aebd588"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan988@gmail.com", "Tuan", "hashed_password_1988", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8c21bd2c-3217-437a-a698-74c172b29b80"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan829@gmail.com", "Tuan", "hashed_password_1829", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8c29b9f6-fbab-47f8-b947-4766568d8137"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan617@gmail.com", "Tuan", "hashed_password_1617", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8c54a304-5076-4731-8b55-869fb7d4a36b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan601@gmail.com", "Tuan", "hashed_password_1601", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8caaaf8f-6cc3-4056-8f7d-0c7edd4abc9b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan387@gmail.com", "Tuan", "hashed_password_1387", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8d80ba91-068e-4d6d-a8f1-6c18897870a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan771@gmail.com", "Tuan", "hashed_password_1771", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8da93228-6abb-414b-aac0-17985cd887bd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan307@gmail.com", "Tuan", "hashed_password_1307", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8dc7199e-498f-4072-9d1a-a95a388aeb87"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan795@gmail.com", "Tuan", "hashed_password_1795", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8e28b16f-3e82-4890-a42b-baddcc037918"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan227@gmail.com", "Tuan", "hashed_password_1227", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8e3d2fe1-12c9-472e-a8ed-a73fa2773377"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan286@gmail.com", "Tuan", "hashed_password_1286", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8e559212-b7f3-44fc-bdcb-48ce8c308b5b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan933@gmail.com", "Tuan", "hashed_password_1933", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8e6bcd72-6617-4c97-8e89-d35a3b431da3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan821@gmail.com", "Tuan", "hashed_password_1821", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8ec4640d-e665-44ac-a49a-c39343bdc6d3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan901@gmail.com", "Tuan", "hashed_password_1901", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8ec52062-71ff-4818-8522-8d492c036c75"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan147@gmail.com", "Tuan", "hashed_password_1147", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8ef55850-00e0-4358-9381-0c1f8274491c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan410@gmail.com", "Tuan", "hashed_password_1410", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8f069b23-96d9-4ce7-93c0-73fff3280780"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan864@gmail.com", "Tuan", "hashed_password_1864", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8f31aa84-a678-4387-8410-eadab3b109cc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan530@gmail.com", "Tuan", "hashed_password_1530", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8f72ddcb-b319-462b-a2ae-2dbd432aced4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan669@gmail.com", "Tuan", "hashed_password_1669", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8f973376-43ac-4f62-8e3f-fb18aefe1abf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan710@gmail.com", "Tuan", "hashed_password_1710", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8fd562b3-3c59-4907-bd4f-f1db881bcf55"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan48@gmail.com", "Tuan", "hashed_password_148", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("8fe6e8a9-9b21-4f3e-ad7b-f73165bdf31c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan402@gmail.com", "Tuan", "hashed_password_1402", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("905c12ca-f3e9-4b53-98fc-0603afb159fd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan623@gmail.com", "Tuan", "hashed_password_1623", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("90b4f5b1-72c1-454e-9ce4-cf03248263af"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan434@gmail.com", "Tuan", "hashed_password_1434", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("90e9389f-b65b-42b5-9b10-a3d14d2ee042"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan447@gmail.com", "Tuan", "hashed_password_1447", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("919380e2-a930-4364-946e-cf2668c678c8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan168@gmail.com", "Tuan", "hashed_password_1168", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("91ca3907-b655-41d4-9756-438842b61a50"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan600@gmail.com", "Tuan", "hashed_password_1600", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("922774c0-2b2f-474a-8346-0a34fb0eaca4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan272@gmail.com", "Tuan", "hashed_password_1272", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("924c0bb6-f2a0-4dd0-9e96-dd6d55a1ec09"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan21@gmail.com", "Tuan", "hashed_password_121", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("936153f0-03ba-4e5c-89fc-568c2d1a73c3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan56@gmail.com", "Tuan", "hashed_password_156", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("937fee4d-2ee6-413f-99e6-1de14d524f32"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan910@gmail.com", "Tuan", "hashed_password_1910", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("93963c89-8b2d-4689-9401-c71f68622561"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan818@gmail.com", "Tuan", "hashed_password_1818", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("93a09c72-caf6-4ed7-9bad-548e8777b21e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan886@gmail.com", "Tuan", "hashed_password_1886", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("93a58344-51cf-4a84-9115-0c4e1dc6de8f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan961@gmail.com", "Tuan", "hashed_password_1961", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("93c66bdd-7ebd-4185-bd2b-7f1a3ae17148"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan770@gmail.com", "Tuan", "hashed_password_1770", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9400b003-7f10-4b45-b6e7-b8557d3dc146"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan599@gmail.com", "Tuan", "hashed_password_1599", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("941f50d6-29f6-41b7-ba67-bda9ec633f00"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan869@gmail.com", "Tuan", "hashed_password_1869", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("94277cbc-ac2d-48cc-8896-d7f22b1c7eab"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan314@gmail.com", "Tuan", "hashed_password_1314", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("94501fd6-f18f-44d4-9232-230a45ded004"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan351@gmail.com", "Tuan", "hashed_password_1351", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("94b88df0-98a1-4b81-b660-e1ed836a1c06"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan149@gmail.com", "Tuan", "hashed_password_1149", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("95083c9b-881d-41b4-b905-a0e745755822"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan199@gmail.com", "Tuan", "hashed_password_1199", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("950a6729-82ed-42ed-96d7-e31f80b5c00c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan688@gmail.com", "Tuan", "hashed_password_1688", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("95342d5e-2d4c-4e70-8729-9bfe3cceb83b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan800@gmail.com", "Tuan", "hashed_password_1800", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9570c198-fa1c-43a0-8862-4e8fdb12c9b5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan575@gmail.com", "Tuan", "hashed_password_1575", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("95795613-1774-4b70-a643-e50acf6ffca2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan885@gmail.com", "Tuan", "hashed_password_1885", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("95913638-f0b1-43fb-8fa7-8a562fdb0198"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan221@gmail.com", "Tuan", "hashed_password_1221", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("95ac4461-ebdf-487f-9e91-82f8288ea4da"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan868@gmail.com", "Tuan", "hashed_password_1868", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("95c35731-57ad-43b9-a496-5e0ba207f397"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan239@gmail.com", "Tuan", "hashed_password_1239", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("960e7ddc-d100-4150-88e0-80aa35dbb115"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan726@gmail.com", "Tuan", "hashed_password_1726", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("96fa1d68-105f-43f0-9bae-8c9084863d3e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan993@gmail.com", "Tuan", "hashed_password_1993", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("97091764-628d-4d89-8721-0a979241f387"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan475@gmail.com", "Tuan", "hashed_password_1475", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("97354615-85f5-4c87-9af7-42a44f2c3fdf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan724@gmail.com", "Tuan", "hashed_password_1724", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("97aaeb79-df71-4605-b4af-dbed9ebffdfd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan927@gmail.com", "Tuan", "hashed_password_1927", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("985bd27e-11fd-44c1-b6bf-de7d34f6a348"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan327@gmail.com", "Tuan", "hashed_password_1327", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("98ada1a2-58ce-4579-8daa-ae98f88cf8be"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan682@gmail.com", "Tuan", "hashed_password_1682", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("98c806b0-c716-4db9-a763-5910402cff27"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan666@gmail.com", "Tuan", "hashed_password_1666", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9922e514-0195-4a15-bcd9-16c59a9f4804"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan58@gmail.com", "Tuan", "hashed_password_158", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("99402a12-e28b-408e-b9ec-38f0b97de415"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan887@gmail.com", "Tuan", "hashed_password_1887", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("99cc3a38-3999-4731-9355-02f4df2a8b41"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan308@gmail.com", "Tuan", "hashed_password_1308", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("99d2ade6-ddee-42f7-807f-231d7bf13278"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan155@gmail.com", "Tuan", "hashed_password_1155", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("99d9f050-81e0-4669-ae55-a49951435ff1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan677@gmail.com", "Tuan", "hashed_password_1677", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9a11068b-9197-425f-b9b8-383c3b60d97d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan376@gmail.com", "Tuan", "hashed_password_1376", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9a1fc6a7-05fd-4b7f-9cee-bd703ede8055"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan701@gmail.com", "Tuan", "hashed_password_1701", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9a20df4c-2eab-487d-aad6-548f7ceab349"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan747@gmail.com", "Tuan", "hashed_password_1747", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9a27dc6b-0a6d-4946-9fce-0fb16f92f7e4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan721@gmail.com", "Tuan", "hashed_password_1721", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9a6a2037-da5f-41ce-aae4-0f2ce506bb9f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan140@gmail.com", "Tuan", "hashed_password_1140", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9a84c901-5d25-4f84-87d6-7a023575fca0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan279@gmail.com", "Tuan", "hashed_password_1279", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9aa6c17c-074a-4dc8-b25e-a5329d10a8fd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan422@gmail.com", "Tuan", "hashed_password_1422", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9ad267e7-8f97-478e-a2d1-511b918bc7ce"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan748@gmail.com", "Tuan", "hashed_password_1748", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9b08ada7-6460-414a-8492-e02bdb23a4d0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan595@gmail.com", "Tuan", "hashed_password_1595", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9b1b44ec-9ef7-414f-ad4f-30c3f5b9ed59"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan417@gmail.com", "Tuan", "hashed_password_1417", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9b2fd9e1-e106-442d-9e1e-d75032e2a013"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan492@gmail.com", "Tuan", "hashed_password_1492", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9b5ea53e-f89f-4137-8d18-d3997cc65de5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan667@gmail.com", "Tuan", "hashed_password_1667", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9bafbf76-7f78-46c1-a12e-2254c4f9fed2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan631@gmail.com", "Tuan", "hashed_password_1631", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9c10d4ba-0338-4408-bd31-1e8c1f78fe07"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan616@gmail.com", "Tuan", "hashed_password_1616", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9cb40b3f-6079-462c-8aa2-ff3d8d3dada0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan356@gmail.com", "Tuan", "hashed_password_1356", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9d0eeb87-3929-4a17-a4ac-e98e9d74309a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan504@gmail.com", "Tuan", "hashed_password_1504", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9d198a38-b5e7-4415-92d1-e9c2080f127a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan93@gmail.com", "Tuan", "hashed_password_193", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9d27cfa9-0230-4c80-a392-79d5538b5e18"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan26@gmail.com", "Tuan", "hashed_password_126", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9d33564c-e10b-415f-afe9-2b06cb49f96c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan836@gmail.com", "Tuan", "hashed_password_1836", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9d35f86d-7b38-4b4e-8a9f-d9e240cc0eac"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan578@gmail.com", "Tuan", "hashed_password_1578", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9d534726-b0fd-4505-a3f7-17278fd3bc17"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan138@gmail.com", "Tuan", "hashed_password_1138", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9d748ecc-01d5-4a3b-a0fc-26b9dbfdc71e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan70@gmail.com", "Tuan", "hashed_password_170", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9db6a7b9-5cff-41f1-8566-8ddd98e9e583"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan6@gmail.com", "Tuan", "hashed_password_16", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9eaf741d-cbf3-4783-a8fe-c6e3c140114b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan783@gmail.com", "Tuan", "hashed_password_1783", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9efdddef-e28c-47f7-9ec9-77ace67214a0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan132@gmail.com", "Tuan", "hashed_password_1132", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9f33a214-e6cb-47dd-96aa-117da2f85d4b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan879@gmail.com", "Tuan", "hashed_password_1879", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9f3e43b1-423b-4014-9fea-06e688504b0b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan827@gmail.com", "Tuan", "hashed_password_1827", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9f7158bc-2bf7-4cd1-becb-08b155a11bba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan793@gmail.com", "Tuan", "hashed_password_1793", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9f821b10-6f7b-44d9-b194-7953a7cf80cf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan581@gmail.com", "Tuan", "hashed_password_1581", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9fb85a71-76eb-4adc-af61-e960372d79da"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan824@gmail.com", "Tuan", "hashed_password_1824", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("9fd2fd79-7c07-4511-971f-2327267123aa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan708@gmail.com", "Tuan", "hashed_password_1708", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a011b61a-a0a8-4307-8b88-67ffd8f49680"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan217@gmail.com", "Tuan", "hashed_password_1217", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a09df6ac-88e1-43b5-924f-2bb3748b79df"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan909@gmail.com", "Tuan", "hashed_password_1909", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a0a8f9ee-7f38-4f19-828f-eb666eefe9a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan372@gmail.com", "Tuan", "hashed_password_1372", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a0c09c6c-5028-4368-b982-69c328f6c91c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan445@gmail.com", "Tuan", "hashed_password_1445", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a0c38b67-4e6d-4dcf-8c7c-865c1eea7383"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan636@gmail.com", "Tuan", "hashed_password_1636", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a13334b1-f5d0-4a30-9063-74bc8aced3c3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan66@gmail.com", "Tuan", "hashed_password_166", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a228a28d-5b04-4f87-8357-3aa84ea4d788"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan57@gmail.com", "Tuan", "hashed_password_157", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a24496b4-22f9-46a6-a846-6e4c1af001fd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan77@gmail.com", "Tuan", "hashed_password_177", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a29f4601-656d-445b-a9f5-505ec480c50a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan691@gmail.com", "Tuan", "hashed_password_1691", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a2b8b7bd-9dc1-411c-9e28-7bd479801b86"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan361@gmail.com", "Tuan", "hashed_password_1361", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a2f95c48-f694-440a-83e5-0eff5f145eae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan494@gmail.com", "Tuan", "hashed_password_1494", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a4ccb6f2-45d6-463f-a198-93b5619e4160"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan153@gmail.com", "Tuan", "hashed_password_1153", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a5b43f92-c31a-464b-bb1b-426493b69ff9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan849@gmail.com", "Tuan", "hashed_password_1849", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a5c0666c-3211-4e82-afd4-b5d2d2de2eea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan537@gmail.com", "Tuan", "hashed_password_1537", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a61c6446-5e3d-40ac-9ef6-e10927cddf69"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan69@gmail.com", "Tuan", "hashed_password_169", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a62795d0-043f-4c2a-ba6d-8f66b639c91f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan472@gmail.com", "Tuan", "hashed_password_1472", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a658cf55-8c8a-4c96-a9ac-4c951f4111df"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan736@gmail.com", "Tuan", "hashed_password_1736", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a6725b47-c53d-4eee-b897-424ed3e4a972"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan497@gmail.com", "Tuan", "hashed_password_1497", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a698dda8-b96a-4e38-abf8-b982fa731b2f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan182@gmail.com", "Tuan", "hashed_password_1182", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a6a2287c-94c4-41cd-861d-ca18a3854561"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan349@gmail.com", "Tuan", "hashed_password_1349", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a6a961c1-27a7-4a5f-aef6-0003170f85ad"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan456@gmail.com", "Tuan", "hashed_password_1456", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a74480dd-4aa4-4273-9247-fd02f42fd6e7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan775@gmail.com", "Tuan", "hashed_password_1775", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a744fa1b-8d64-4cf6-8d50-499f7b0bfaa1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan84@gmail.com", "Tuan", "hashed_password_184", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a7d94b95-8bca-4a98-b004-68c1418a60c4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan404@gmail.com", "Tuan", "hashed_password_1404", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a7dd8112-d949-4e23-a461-318b5e9c50e7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan663@gmail.com", "Tuan", "hashed_password_1663", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a80272dc-8ba2-4bc5-aa4f-a1cec0720c4a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan176@gmail.com", "Tuan", "hashed_password_1176", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a8f91183-fd6a-4fbc-a0a5-2e733e5c5f29"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan18@gmail.com", "Tuan", "hashed_password_118", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a950fe7b-5601-433c-a37e-805836c9d23d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan194@gmail.com", "Tuan", "hashed_password_1194", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a97151be-7ec2-49dd-877d-ccbfe541e5ec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan727@gmail.com", "Tuan", "hashed_password_1727", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a974db2b-322d-4570-9b4f-baa7803abd1d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan713@gmail.com", "Tuan", "hashed_password_1713", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("a9778399-2755-4df7-8d32-11e709c07f94"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan466@gmail.com", "Tuan", "hashed_password_1466", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("aa149cac-27c2-4f47-9751-e3c60e13d2a9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan694@gmail.com", "Tuan", "hashed_password_1694", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("aa55ebfa-83aa-480b-b1e1-26f3af1b4209"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan834@gmail.com", "Tuan", "hashed_password_1834", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("aac9772b-deef-4364-a48f-78ab798e8a00"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan970@gmail.com", "Tuan", "hashed_password_1970", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ab28ba2d-6500-47fa-9b55-3e88b2be831a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan579@gmail.com", "Tuan", "hashed_password_1579", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ab60c088-e610-4088-89d4-61c2e4e5a944"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan343@gmail.com", "Tuan", "hashed_password_1343", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ab7df06f-3bfa-4ac4-8be8-63caa3b6b17c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan463@gmail.com", "Tuan", "hashed_password_1463", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("abc7f26a-c685-4e6f-afc7-a59cecea820c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan543@gmail.com", "Tuan", "hashed_password_1543", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("abce6fa8-7aec-4300-ac93-230a12d12594"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan119@gmail.com", "Tuan", "hashed_password_1119", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("abfa508a-fcdd-416a-9cb6-2e019d038127"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan273@gmail.com", "Tuan", "hashed_password_1273", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ac296ada-7214-4bf7-9653-501b28785ef0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan154@gmail.com", "Tuan", "hashed_password_1154", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ac980a6e-436d-4d20-98ab-5ac9087fc35a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan200@gmail.com", "Tuan", "hashed_password_1200", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("acb470f9-1422-47da-a595-b4c464ffa964"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan715@gmail.com", "Tuan", "hashed_password_1715", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ad023aae-245b-4a87-8d7a-3c283a66240e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan449@gmail.com", "Tuan", "hashed_password_1449", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ad360bfe-a105-4147-a265-eb5f25806fcb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan73@gmail.com", "Tuan", "hashed_password_173", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ad79df53-0ae5-42a6-9431-b5250ecd3f9d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan622@gmail.com", "Tuan", "hashed_password_1622", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("adb7b448-a44a-44ba-8061-b4442c04badf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan535@gmail.com", "Tuan", "hashed_password_1535", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ae09f4cb-febf-40b7-a753-9da3911fe229"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan298@gmail.com", "Tuan", "hashed_password_1298", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ae866f0a-d429-4135-8e56-7266a3fe7318"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan684@gmail.com", "Tuan", "hashed_password_1684", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("aece74d6-2bfa-4cbf-8636-240a6c1284c5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan695@gmail.com", "Tuan", "hashed_password_1695", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("af56e74e-3421-4008-9261-4d49a4bd53fa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan484@gmail.com", "Tuan", "hashed_password_1484", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("af9a6f89-c257-4a14-9499-73ea7be5ad6a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan323@gmail.com", "Tuan", "hashed_password_1323", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("afd0a31c-1a04-4021-8152-be9f6127f770"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan517@gmail.com", "Tuan", "hashed_password_1517", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("affd56e0-f619-4ab6-b399-a1416e5c47f7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan735@gmail.com", "Tuan", "hashed_password_1735", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b01ec066-4618-429c-8c5b-743da84e256f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan355@gmail.com", "Tuan", "hashed_password_1355", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b0a286bd-acb1-47cf-a815-003ff5e09b2f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan59@gmail.com", "Tuan", "hashed_password_159", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b0aaa327-1c07-428a-a298-0994f7cf0ea9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan55@gmail.com", "Tuan", "hashed_password_155", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b0acac91-560d-423f-861a-6bf4e732586e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan291@gmail.com", "Tuan", "hashed_password_1291", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b0d59694-cd82-44a2-a83f-2a548737ea47"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan571@gmail.com", "Tuan", "hashed_password_1571", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b1280a47-ac8b-4607-82be-74e4adb27f6d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan336@gmail.com", "Tuan", "hashed_password_1336", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b135cbd6-05b4-41d8-8e42-22d96bd477ea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan205@gmail.com", "Tuan", "hashed_password_1205", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b1599a56-9904-43e9-8a55-240904df6bf9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan815@gmail.com", "Tuan", "hashed_password_1815", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b1ef7ec1-3432-4b30-b98e-76059de4d0b5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan762@gmail.com", "Tuan", "hashed_password_1762", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b2421405-530f-41c7-be3b-904611c505ad"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan242@gmail.com", "Tuan", "hashed_password_1242", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b2662d0b-522a-4742-8e64-1681deb3dde9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan768@gmail.com", "Tuan", "hashed_password_1768", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b26952d1-e8fb-45a5-a6bd-70e8c6b7d077"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan373@gmail.com", "Tuan", "hashed_password_1373", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b2e28755-172a-4066-8b02-335c3b3c3638"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan832@gmail.com", "Tuan", "hashed_password_1832", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b357e192-486b-4ff8-bac2-233d23e530d5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan842@gmail.com", "Tuan", "hashed_password_1842", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b3844dad-e261-41d5-9b4f-d7a8bdfd3e82"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan321@gmail.com", "Tuan", "hashed_password_1321", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b400dfc7-f117-45b8-9719-8a71b32522ca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan213@gmail.com", "Tuan", "hashed_password_1213", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b401d535-ab93-40c2-b07a-303043a7f5cc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan903@gmail.com", "Tuan", "hashed_password_1903", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b40c80ad-65d0-4dab-9ea4-9bfa1120e931"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan958@gmail.com", "Tuan", "hashed_password_1958", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b45546f9-514a-4b17-be9f-48845bf149c5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan341@gmail.com", "Tuan", "hashed_password_1341", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b45aab92-57d3-4ee3-b26d-c9d696f44999"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan216@gmail.com", "Tuan", "hashed_password_1216", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b485f490-df57-4e06-bd5a-6b24b05e3f4b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan76@gmail.com", "Tuan", "hashed_password_176", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b4d77c6f-de67-4cdf-86e6-bc08616c873c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan558@gmail.com", "Tuan", "hashed_password_1558", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b50f3313-9fd0-47e2-bc0e-a994fcd3cace"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan269@gmail.com", "Tuan", "hashed_password_1269", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b51863e5-cde8-4698-8d0e-9d43909bf5e6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan872@gmail.com", "Tuan", "hashed_password_1872", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b59c3507-4ee5-4de9-8c01-5c83bb261722"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan898@gmail.com", "Tuan", "hashed_password_1898", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b5cf6d87-5c7d-412e-8535-cd096e9079a4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan277@gmail.com", "Tuan", "hashed_password_1277", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b6222afe-ce6d-4bf7-a14c-3b637b444a90"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan122@gmail.com", "Tuan", "hashed_password_1122", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b62ab2ff-475b-4400-a3f2-20a75f932ee8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan136@gmail.com", "Tuan", "hashed_password_1136", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b64acd11-133d-4dca-9e54-fdb9b24d2a04"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan179@gmail.com", "Tuan", "hashed_password_1179", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b6c7af8d-5f1f-4b02-bf69-d08403bfb1e9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan498@gmail.com", "Tuan", "hashed_password_1498", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b6e64ece-86eb-47d6-b5b3-d099faa5cba2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan506@gmail.com", "Tuan", "hashed_password_1506", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b7633804-163f-4432-b99c-a690326cf03f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan420@gmail.com", "Tuan", "hashed_password_1420", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b76df999-1a24-49db-b914-2742518f9573"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan328@gmail.com", "Tuan", "hashed_password_1328", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b7a7ea2e-231b-428a-8261-c1b3eee957a8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan250@gmail.com", "Tuan", "hashed_password_1250", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b7ae11ae-3f84-44c9-ad98-ecd2e91db5d0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan649@gmail.com", "Tuan", "hashed_password_1649", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b7fdfef4-45fd-45d0-837c-420d961cd6ca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan316@gmail.com", "Tuan", "hashed_password_1316", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b8240d88-d292-477b-afc9-d2c7b10dba49"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan808@gmail.com", "Tuan", "hashed_password_1808", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b84400b7-06da-4afe-a6fd-ba21959322c6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan64@gmail.com", "Tuan", "hashed_password_164", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b87ad64b-29cd-4b8f-87b3-a88b0a7a92a5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan513@gmail.com", "Tuan", "hashed_password_1513", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b8f78dcc-dd84-4e88-ade1-d99283c48997"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan629@gmail.com", "Tuan", "hashed_password_1629", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b8fa8312-2ca2-44ea-9457-9ae0e69bc7cb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan433@gmail.com", "Tuan", "hashed_password_1433", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b97c884f-f369-4a58-b537-d4220d9805c8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan936@gmail.com", "Tuan", "hashed_password_1936", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b97daff0-25ed-4a2d-ac07-dd11e09cc855"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan810@gmail.com", "Tuan", "hashed_password_1810", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b97e1869-369d-4a38-9c51-7d70ae5d5330"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan791@gmail.com", "Tuan", "hashed_password_1791", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b989993f-0f56-4d8c-a163-7569b9e6c1ac"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan171@gmail.com", "Tuan", "hashed_password_1171", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("b9a5ff25-a4d1-4c74-9fa2-d58e4c3722ce"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan981@gmail.com", "Tuan", "hashed_password_1981", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ba17b82b-dbdf-47d7-a6ed-9acfa3185f17"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan652@gmail.com", "Tuan", "hashed_password_1652", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ba2e01d9-4e87-4510-8f60-4f03a2bee936"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan693@gmail.com", "Tuan", "hashed_password_1693", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ba96e6b5-30dd-45b2-9b9c-49c9b3dafbe6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan853@gmail.com", "Tuan", "hashed_password_1853", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("baaeaf66-e7ea-42a3-887c-178ebac235c3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan529@gmail.com", "Tuan", "hashed_password_1529", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bb2f9b5d-3b3c-4efa-9ab2-17bfa22301d9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan870@gmail.com", "Tuan", "hashed_password_1870", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bb68a7ec-de53-44b4-bc02-b0dada5e6160"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan996@gmail.com", "Tuan", "hashed_password_1996", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bba849bc-8887-4d81-8d77-009d99d17002"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan950@gmail.com", "Tuan", "hashed_password_1950", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bc4d087b-e844-4c13-b6b5-31a55516aa77"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan889@gmail.com", "Tuan", "hashed_password_1889", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bca3be5a-72df-4e6b-a5f3-4d5350c0c3bf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan553@gmail.com", "Tuan", "hashed_password_1553", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bd4a3d61-1da2-4883-b52b-853b18876ee9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan158@gmail.com", "Tuan", "hashed_password_1158", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bd58f0fa-7bb3-4b86-be61-244dc00de961"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan555@gmail.com", "Tuan", "hashed_password_1555", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bdd51be2-37f6-4867-8f00-590b72e5ff20"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan188@gmail.com", "Tuan", "hashed_password_1188", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bdeb5920-e0f0-4471-bea0-b7b379943436"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan658@gmail.com", "Tuan", "hashed_password_1658", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("be061d74-daf3-41b4-bb52-b5b2d3472fbc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan662@gmail.com", "Tuan", "hashed_password_1662", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bf0b9296-d2bf-4a5e-86f1-accd19d75d05"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan2@gmail.com", "Tuan", "hashed_password_12", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bf14c0ac-629f-4534-9416-dc9613bd69ba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan145@gmail.com", "Tuan", "hashed_password_1145", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bf1ed704-d489-43a6-a6b9-2676d86c917f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan408@gmail.com", "Tuan", "hashed_password_1408", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bf6fb75d-d36a-4c78-b6c6-54e02e7df120"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan375@gmail.com", "Tuan", "hashed_password_1375", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bf96e327-09d6-4abc-ab56-c84b935d9f23"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan999@gmail.com", "Tuan", "hashed_password_1999", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bf96e4bb-26a6-4a13-9f44-930da636af0d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan28@gmail.com", "Tuan", "hashed_password_128", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("bfc49e41-756c-4f24-8cfb-ef76e9ba84a2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan38@gmail.com", "Tuan", "hashed_password_138", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c04d4b70-b2b5-4501-8bff-00b1747a3584"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan130@gmail.com", "Tuan", "hashed_password_1130", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c080a312-cce7-43f0-9040-5922506b03b6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan428@gmail.com", "Tuan", "hashed_password_1428", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c0e31686-36eb-48cc-8f03-9c8794d9fc60"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan150@gmail.com", "Tuan", "hashed_password_1150", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c10fa97d-9145-4869-a965-093955bf41e0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan324@gmail.com", "Tuan", "hashed_password_1324", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c14a277c-28a1-498b-98a1-9a3b5ee94eec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan10@gmail.com", "Tuan", "hashed_password_110", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c225712b-a14e-40dd-9f58-2fe7cc023d00"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan425@gmail.com", "Tuan", "hashed_password_1425", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c22a296a-3ccf-4251-abea-9eee71114f43"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan156@gmail.com", "Tuan", "hashed_password_1156", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c22ba857-4f0e-4bf3-8248-63d93fb02028"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan608@gmail.com", "Tuan", "hashed_password_1608", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c247759c-c1f0-4317-9431-4f99a4960660"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan780@gmail.com", "Tuan", "hashed_password_1780", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c258d979-cdab-459e-b84e-f0cb93274231"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan415@gmail.com", "Tuan", "hashed_password_1415", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c27826ee-897a-48d5-943f-673b3745370f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan559@gmail.com", "Tuan", "hashed_password_1559", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c278fbd7-cbcb-45e6-9b85-6bfc6ead560b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan972@gmail.com", "Tuan", "hashed_password_1972", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c2f4ef37-8789-43f4-980e-47ba43c399c8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan702@gmail.com", "Tuan", "hashed_password_1702", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c3088ef7-bd8b-44c5-bd59-0a192630975c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan620@gmail.com", "Tuan", "hashed_password_1620", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c30b5420-ed27-41bb-95f9-16d9b250e66e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan698@gmail.com", "Tuan", "hashed_password_1698", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c32ef463-16b8-4325-9ad5-91c29f35de19"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan211@gmail.com", "Tuan", "hashed_password_1211", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c3b4f65f-24d2-4bd2-b7d8-41742ec6b57f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan915@gmail.com", "Tuan", "hashed_password_1915", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c3e654c9-24b6-45b6-9037-4eb5df185cff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan750@gmail.com", "Tuan", "hashed_password_1750", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c3fc9ebb-b46c-49de-b7f6-ff95b4419cee"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan956@gmail.com", "Tuan", "hashed_password_1956", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c40fbd89-5350-405a-9432-074f11a93574"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan743@gmail.com", "Tuan", "hashed_password_1743", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c4d11450-5ec8-432d-864e-17b316f7d583"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan24@gmail.com", "Tuan", "hashed_password_124", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c5119c9c-2fee-4309-8236-1744b0d36baa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan844@gmail.com", "Tuan", "hashed_password_1844", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c53b2dd2-9b6d-4e12-b35e-e3b25e5f340b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan785@gmail.com", "Tuan", "hashed_password_1785", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c6056833-50f2-4e11-ae1c-efd4ba39dfb2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan823@gmail.com", "Tuan", "hashed_password_1823", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c6219392-eda1-477b-8c5d-1fd65ca95083"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan164@gmail.com", "Tuan", "hashed_password_1164", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c696f1f9-80c8-454f-87bb-94b4c76102a2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan432@gmail.com", "Tuan", "hashed_password_1432", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c6a2184d-ac48-4eb9-a639-ae83076685fc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan424@gmail.com", "Tuan", "hashed_password_1424", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c6abd229-dc94-4f44-a1ee-3971918aec6b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan129@gmail.com", "Tuan", "hashed_password_1129", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c76293d9-5153-49b9-a778-3d38b82cc07d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan934@gmail.com", "Tuan", "hashed_password_1934", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c7bb2695-92c1-4013-95e3-adb232c8a1c2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan548@gmail.com", "Tuan", "hashed_password_1548", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c83c5ee9-78ea-473a-a31d-2127eb0f15c1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan526@gmail.com", "Tuan", "hashed_password_1526", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c8b18a1e-ff10-4bfe-a727-0d0b11b3c3a6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan807@gmail.com", "Tuan", "hashed_password_1807", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c91d9b31-b488-4f88-afc6-61be29439a39"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan429@gmail.com", "Tuan", "hashed_password_1429", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c98a1540-c3a6-483b-b4dc-8d546f751f20"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan95@gmail.com", "Tuan", "hashed_password_195", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c9b17f1b-d6e2-48f3-89b4-c248e6c06869"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan908@gmail.com", "Tuan", "hashed_password_1908", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c9c33a41-5905-46c3-82da-38ee7031657e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan54@gmail.com", "Tuan", "hashed_password_154", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("c9fc7aa7-a70f-4dfb-91a1-004a3a2d71de"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan457@gmail.com", "Tuan", "hashed_password_1457", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ca347bb9-50ce-4587-88b7-7157d2f26788"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan615@gmail.com", "Tuan", "hashed_password_1615", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ca3535e5-8dc3-40db-81c7-ed70d369884c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan566@gmail.com", "Tuan", "hashed_password_1566", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ca40691c-fd11-4acb-a223-273bafe535de"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan551@gmail.com", "Tuan", "hashed_password_1551", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ca51c177-c544-4e3f-9dd9-d6aec2490482"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan107@gmail.com", "Tuan", "hashed_password_1107", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ca663a5b-5602-4edb-9bac-e059d4848950"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan23@gmail.com", "Tuan", "hashed_password_123", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cadcb71e-0945-4822-9172-061fb7a15459"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan270@gmail.com", "Tuan", "hashed_password_1270", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cb838fda-3afe-4dbf-9616-3d2bbb42fe46"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan12@gmail.com", "Tuan", "hashed_password_112", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cbf3cd37-4bf3-4c83-b13f-142ad4d2fd21"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan183@gmail.com", "Tuan", "hashed_password_1183", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ccb22259-fc17-4c63-832d-c44f42e5a9d1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan105@gmail.com", "Tuan", "hashed_password_1105", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ccb4ecbc-c24e-4091-8f53-60f31e01692a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan71@gmail.com", "Tuan", "hashed_password_171", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cd1ba508-39c1-4a5a-9f01-6b44154d94a1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan22@gmail.com", "Tuan", "hashed_password_122", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cd3889ef-1c52-44fb-bc85-23e5d6d9d5a0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan51@gmail.com", "Tuan", "hashed_password_151", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cd482442-0f3c-4f9a-ac27-7e69321f1ded"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan501@gmail.com", "Tuan", "hashed_password_1501", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cd4ac4df-40ac-4b3a-bf99-a17adf99fa85"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan720@gmail.com", "Tuan", "hashed_password_1720", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cd4ffa4d-0c4d-4013-a832-a7a5700bcbb3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan650@gmail.com", "Tuan", "hashed_password_1650", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cf5918dd-e61a-404c-a31d-0078faf12078"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan266@gmail.com", "Tuan", "hashed_password_1266", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cf7fb7f1-56e7-4124-b0a9-b75dee7e020a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan335@gmail.com", "Tuan", "hashed_password_1335", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("cfff201b-3fa0-44b5-a645-73bd667566f9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan777@gmail.com", "Tuan", "hashed_password_1777", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d0136690-b799-408d-81e3-9979c09f4633"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan35@gmail.com", "Tuan", "hashed_password_135", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d0169625-a62d-42b5-8570-5ca4904b845e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan756@gmail.com", "Tuan", "hashed_password_1756", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d02739d0-00de-4b59-89ad-b5198f2ffc8c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan170@gmail.com", "Tuan", "hashed_password_1170", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d041cad0-c966-4da2-9542-b09a2226821e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan536@gmail.com", "Tuan", "hashed_password_1536", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d04d33be-2a64-4d91-a6ce-06408b916bbc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan610@gmail.com", "Tuan", "hashed_password_1610", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d0d2aed6-e1af-42a8-9092-8a8e29bdef85"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan522@gmail.com", "Tuan", "hashed_password_1522", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d1570dd0-7b3e-40ca-ac45-a7ab012fc102"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan16@gmail.com", "Tuan", "hashed_password_116", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d18b0f8e-f29d-4abf-a1f4-f417ed952afa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan804@gmail.com", "Tuan", "hashed_password_1804", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d1b7cc44-bce7-4b19-89c8-4f577bc40f2d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan766@gmail.com", "Tuan", "hashed_password_1766", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d25380fe-9b23-48c0-94fa-8c1b28e802e8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan41@gmail.com", "Tuan", "hashed_password_141", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d29cd840-862e-467f-8629-aa57eaf397ec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan567@gmail.com", "Tuan", "hashed_password_1567", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d2ab5574-2ba0-4209-943b-1233af735a76"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan287@gmail.com", "Tuan", "hashed_password_1287", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d2cba5b0-06a9-416c-9af1-0b3691aaead5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan902@gmail.com", "Tuan", "hashed_password_1902", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d2e0fad4-6687-4d3a-8725-339b0a3ab6fc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan765@gmail.com", "Tuan", "hashed_password_1765", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d2f7548b-2d2b-43f6-a1cb-cf9228c64667"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan866@gmail.com", "Tuan", "hashed_password_1866", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d3229bb2-83e1-47bd-a78f-f2a6426125a1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan169@gmail.com", "Tuan", "hashed_password_1169", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d343ccf4-a251-4d63-9614-e4856ca9d230"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan357@gmail.com", "Tuan", "hashed_password_1357", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d3585c6b-69a7-4f64-bdad-fa078b2128fa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan826@gmail.com", "Tuan", "hashed_password_1826", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d359343a-9b4d-4e21-bf20-2c6f659e9bc2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan598@gmail.com", "Tuan", "hashed_password_1598", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d3b3f821-210e-4042-84f3-0c500747064f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan582@gmail.com", "Tuan", "hashed_password_1582", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d3cfe728-6db9-4067-8cd8-3581fd70f65a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan275@gmail.com", "Tuan", "hashed_password_1275", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d3d779d7-8b86-4cd7-a700-fe35b635fb55"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan33@gmail.com", "Tuan", "hashed_password_133", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d3dfa5dc-d196-4a74-95b7-356cfc293e6a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan525@gmail.com", "Tuan", "hashed_password_1525", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d4206eb2-6910-4bcb-a7a4-927c64e7d1c8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan648@gmail.com", "Tuan", "hashed_password_1648", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d477e06a-350b-4c10-91bd-5cad91bbffcb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan75@gmail.com", "Tuan", "hashed_password_175", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d47d7bbc-2139-4083-b304-ab5e303a99f3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan232@gmail.com", "Tuan", "hashed_password_1232", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d4bb6775-4e60-4bbb-9447-65888e22ca80"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan862@gmail.com", "Tuan", "hashed_password_1862", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d4c5988d-4208-4e79-b065-b15ec1d8f543"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan166@gmail.com", "Tuan", "hashed_password_1166", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d4cf426f-6f96-41be-a6e9-c19f8f81a842"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan395@gmail.com", "Tuan", "hashed_password_1395", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d5b02e9e-7705-42c4-8a27-709ff21907fb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan360@gmail.com", "Tuan", "hashed_password_1360", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d5d78051-3325-48bb-95a0-64b497f23d02"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan882@gmail.com", "Tuan", "hashed_password_1882", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d5e82c7e-183e-4387-92d9-a5df68e93968"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan437@gmail.com", "Tuan", "hashed_password_1437", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d63ab0f1-28d0-4279-a03f-8b3ddd735150"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan85@gmail.com", "Tuan", "hashed_password_185", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d64520a8-20b2-4e3c-a7b8-64f59e1bf5f3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan822@gmail.com", "Tuan", "hashed_password_1822", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d66aaf4a-0391-4969-b05c-4afcc422d8f6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan500@gmail.com", "Tuan", "hashed_password_1500", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d68cc4dd-4ff8-4bf2-9380-303299f437ce"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan293@gmail.com", "Tuan", "hashed_password_1293", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d6b28ee9-5092-418c-812f-ad68355f7ffc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan803@gmail.com", "Tuan", "hashed_password_1803", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d6e1bc83-b0ee-4566-8d19-67eb8165be84"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan556@gmail.com", "Tuan", "hashed_password_1556", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d71acfad-18d6-4064-9817-db4a7241a4fe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan906@gmail.com", "Tuan", "hashed_password_1906", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d745512b-a4b7-414c-a85b-2475007fbc48"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan304@gmail.com", "Tuan", "hashed_password_1304", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d74a4f57-8189-401f-819e-efc45dd0dc44"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan816@gmail.com", "Tuan", "hashed_password_1816", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d84acf32-ec67-463a-8fe9-7b5355c3e89d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan370@gmail.com", "Tuan", "hashed_password_1370", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d89b394c-51f0-43e2-9827-876f42158ea6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan88@gmail.com", "Tuan", "hashed_password_188", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d8daac0a-3147-49d6-960d-90dcf143c558"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan603@gmail.com", "Tuan", "hashed_password_1603", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d8eed42c-586f-4ac6-acda-45d1c7fdc598"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan230@gmail.com", "Tuan", "hashed_password_1230", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d913c728-f140-4d6d-a3a4-6c9c3a2eebf0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan692@gmail.com", "Tuan", "hashed_password_1692", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d919c394-c778-4ed3-aeef-f6308fcd2fb8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan989@gmail.com", "Tuan", "hashed_password_1989", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d9348373-1320-4de1-b7fe-7b21db43e835"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan502@gmail.com", "Tuan", "hashed_password_1502", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d93b2af8-f03f-4245-8887-29f4978167bd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan464@gmail.com", "Tuan", "hashed_password_1464", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("d9d440ac-bb9d-47d9-840e-e2fee174a85d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan31@gmail.com", "Tuan", "hashed_password_131", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("da0957ec-f526-44db-8ed6-95103070e9dc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan979@gmail.com", "Tuan", "hashed_password_1979", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("da2726be-7326-475c-b3f1-acc7f009af36"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan685@gmail.com", "Tuan", "hashed_password_1685", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dad8889f-c13e-4898-999d-19ff92684c66"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan380@gmail.com", "Tuan", "hashed_password_1380", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dae0b0d1-f9d0-492e-bb66-3932d3f38d00"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan237@gmail.com", "Tuan", "hashed_password_1237", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("db37c176-cdd3-4e95-ba65-957b519a05f8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan271@gmail.com", "Tuan", "hashed_password_1271", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("db490c07-3033-412f-bc56-a9ff5be06fe8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan240@gmail.com", "Tuan", "hashed_password_1240", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("db848ddc-20b5-4ab4-93dc-09a08ddcf777"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan212@gmail.com", "Tuan", "hashed_password_1212", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dbc729cb-07da-4136-b08a-3e4925f14bfb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan774@gmail.com", "Tuan", "hashed_password_1774", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dbe52cb5-e81c-49d0-8a89-47f272243c23"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan752@gmail.com", "Tuan", "hashed_password_1752", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dc15acea-57d5-4bb5-83d7-52b0b5896290"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan851@gmail.com", "Tuan", "hashed_password_1851", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dc249b40-4932-45b8-8eae-8f867b02c711"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan344@gmail.com", "Tuan", "hashed_password_1344", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dc33da69-e156-4648-ad61-7f3463f5c868"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan611@gmail.com", "Tuan", "hashed_password_1611", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dc4298ad-ccbb-4279-826c-cb129bf3fe47"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan302@gmail.com", "Tuan", "hashed_password_1302", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dcff17c8-9d9d-4f68-9cac-a085e3c946a1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan957@gmail.com", "Tuan", "hashed_password_1957", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dd626b24-15e2-4136-b3a9-b2d38933f92b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan850@gmail.com", "Tuan", "hashed_password_1850", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dd79f96c-6893-421d-9f6b-54b3b3119623"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan390@gmail.com", "Tuan", "hashed_password_1390", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dd87268f-2f69-44d8-84db-eefa1df33fed"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan50@gmail.com", "Tuan", "hashed_password_150", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ddaa50c0-00af-42c3-9baf-b2468fced027"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan465@gmail.com", "Tuan", "hashed_password_1465", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ddb8983d-9424-4dd1-b71f-213593bff953"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan806@gmail.com", "Tuan", "hashed_password_1806", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ddc58dac-3832-4516-a31a-d56895969ab3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan299@gmail.com", "Tuan", "hashed_password_1299", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("dde6efef-433f-4bc5-a057-44796fab2f09"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan638@gmail.com", "Tuan", "hashed_password_1638", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ddfae1ce-843f-45e5-b78a-0c26b23d787e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan403@gmail.com", "Tuan", "hashed_password_1403", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("de19bcd5-446a-4a3d-94a6-2b1845b0d05f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan459@gmail.com", "Tuan", "hashed_password_1459", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("de208fcb-2485-46a1-b215-1885cf9d37ef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan288@gmail.com", "Tuan", "hashed_password_1288", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("de366ffa-231e-4077-81fa-8b91a8be44fe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan974@gmail.com", "Tuan", "hashed_password_1974", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("de906220-2e13-42c0-93f6-866953111c47"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan904@gmail.com", "Tuan", "hashed_password_1904", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ded31a02-10e3-4db0-b722-d7461c84cbc5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan746@gmail.com", "Tuan", "hashed_password_1746", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("deecf160-f337-45fd-ac97-7b038a82fbf7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan278@gmail.com", "Tuan", "hashed_password_1278", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("deefa240-8a83-4097-a62f-8d664d5e6938"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan184@gmail.com", "Tuan", "hashed_password_1184", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("df81019b-b015-4fcb-8c0b-4c116d34d8c7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan739@gmail.com", "Tuan", "hashed_password_1739", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e00a80bb-7af9-4280-8d35-c793b646926b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan838@gmail.com", "Tuan", "hashed_password_1838", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e05f6eeb-9ea8-4e85-9747-ca37df791021"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan450@gmail.com", "Tuan", "hashed_password_1450", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e0749270-7958-49e7-967f-6a07562c9e8b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan294@gmail.com", "Tuan", "hashed_password_1294", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e0dd5072-a769-4df5-b2b9-80a2aa8dda72"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan828@gmail.com", "Tuan", "hashed_password_1828", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e1596a3d-0306-4f8a-8ebf-9c5dc9a0c2f8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan131@gmail.com", "Tuan", "hashed_password_1131", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e184b209-6c0f-45e6-b024-3a5c63f5e8f9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan661@gmail.com", "Tuan", "hashed_password_1661", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e1a7c70c-f0ca-4445-a368-28e45cd8ff62"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan796@gmail.com", "Tuan", "hashed_password_1796", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e210f296-13c5-4d28-99e3-d70f472dbf29"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan550@gmail.com", "Tuan", "hashed_password_1550", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e2738c7c-3fe6-4d48-96c9-fcc499771aeb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan406@gmail.com", "Tuan", "hashed_password_1406", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e2c8ec9d-bf81-42af-acd1-751fb425a536"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan62@gmail.com", "Tuan", "hashed_password_162", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e2f18c0c-dfef-4314-8e84-ca6cae86bddd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan733@gmail.com", "Tuan", "hashed_password_1733", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e34f3dc7-971c-4bc9-8f5f-3e7805f513b3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan545@gmail.com", "Tuan", "hashed_password_1545", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e3e5f5f9-e6ea-434a-a336-7503df607ebd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan690@gmail.com", "Tuan", "hashed_password_1690", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e43359b9-caa8-499d-96c7-c95af1331ccc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan987@gmail.com", "Tuan", "hashed_password_1987", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e47a8205-c4de-4a96-b593-f8def19efd10"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan318@gmail.com", "Tuan", "hashed_password_1318", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e47fd1a4-ccef-4b11-96d9-8716796035e1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan320@gmail.com", "Tuan", "hashed_password_1320", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e4dd102f-1f64-4284-aeeb-0d2a4795bdb8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan734@gmail.com", "Tuan", "hashed_password_1734", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e4fdb775-6c2c-41ce-86eb-eaa3f3050af0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan261@gmail.com", "Tuan", "hashed_password_1261", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e516a4c7-bcc4-4d66-8531-287f209f1418"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan175@gmail.com", "Tuan", "hashed_password_1175", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e53ba952-8bdf-44a4-a032-adbddcedb96f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan146@gmail.com", "Tuan", "hashed_password_1146", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e5750e6f-3eb1-4519-bb1b-3ecf3ab2a3d1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan855@gmail.com", "Tuan", "hashed_password_1855", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e5c34400-3906-4480-8070-174aaf483d76"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan985@gmail.com", "Tuan", "hashed_password_1985", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e5d79b81-8b0d-48ae-97ca-ea8c1b0f2e13"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan562@gmail.com", "Tuan", "hashed_password_1562", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e5ffc25a-e7c4-424c-b942-f23c9a5cdeb2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan612@gmail.com", "Tuan", "hashed_password_1612", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e61c1772-9f3a-4219-851f-3899a03502be"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan267@gmail.com", "Tuan", "hashed_password_1267", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e643e409-f223-4d41-8a2b-a403b0cea928"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan651@gmail.com", "Tuan", "hashed_password_1651", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e676f778-ab4f-4748-9317-5d93d34db0f9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan180@gmail.com", "Tuan", "hashed_password_1180", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e684831d-ffae-4df3-b372-8718b40f4269"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan572@gmail.com", "Tuan", "hashed_password_1572", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e6d6cf18-bf52-4ed1-b4c4-e73eb559b352"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan919@gmail.com", "Tuan", "hashed_password_1919", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e6dd8d83-7674-41d9-ae87-9f7cc4b993c1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan644@gmail.com", "Tuan", "hashed_password_1644", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e6e7652d-941c-4528-a1f6-fc0941bd1148"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan564@gmail.com", "Tuan", "hashed_password_1564", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e7131273-d5f8-467a-8274-728b73117363"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan532@gmail.com", "Tuan", "hashed_password_1532", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e7672bae-c786-41ac-a158-fd2af81edaa7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan133@gmail.com", "Tuan", "hashed_password_1133", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e79e1ec2-9568-4992-996f-0a46bf5d2019"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan591@gmail.com", "Tuan", "hashed_password_1591", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e8b3fa2f-c083-4275-bb11-83f42f499ae6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan47@gmail.com", "Tuan", "hashed_password_147", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e8d74f21-9812-4eee-85e0-63efe9147cb2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan893@gmail.com", "Tuan", "hashed_password_1893", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e921fc5f-ff52-4bcb-a6f2-c97f95bda290"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan907@gmail.com", "Tuan", "hashed_password_1907", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e92ee0a6-df1e-477d-b8da-29c7e8bab5c8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan576@gmail.com", "Tuan", "hashed_password_1576", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e947a7b8-3c8a-4fb4-bd35-4225eb338808"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan759@gmail.com", "Tuan", "hashed_password_1759", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e96f2f39-f605-49db-8c8f-2c6e996effb9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan413@gmail.com", "Tuan", "hashed_password_1413", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e970ed35-c32d-4bd1-8cdd-1cee148ceb7c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan973@gmail.com", "Tuan", "hashed_password_1973", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e9c40189-613b-4707-bca7-c0853be774ae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan377@gmail.com", "Tuan", "hashed_password_1377", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("e9e89371-759b-4667-a087-8ff72fc5cfcb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan397@gmail.com", "Tuan", "hashed_password_1397", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ea37d67e-b56e-45fc-9326-b13861c93f98"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan292@gmail.com", "Tuan", "hashed_password_1292", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ea3edc44-831e-4ce6-bae0-c9db7d824020"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan491@gmail.com", "Tuan", "hashed_password_1491", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ea583798-63a2-4fa0-a237-0772d08b294b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan282@gmail.com", "Tuan", "hashed_password_1282", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ea96a101-f147-40e2-bc2d-fabdcfb691c2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan303@gmail.com", "Tuan", "hashed_password_1303", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("eac88579-a243-4845-8084-f8bb5aba0302"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan544@gmail.com", "Tuan", "hashed_password_1544", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ead90f42-bc89-487c-bf75-88381a4f4a53"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan781@gmail.com", "Tuan", "hashed_password_1781", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("eb80885f-c0e8-4a61-8b1b-811372ce6f1d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan792@gmail.com", "Tuan", "hashed_password_1792", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("eb91ac04-27f4-4398-8e63-15f969d76e00"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan268@gmail.com", "Tuan", "hashed_password_1268", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ec85d331-c2f3-466f-9554-ffd3d805647e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan664@gmail.com", "Tuan", "hashed_password_1664", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("eccd0d80-1375-422d-b42a-bb5f564f9470"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan126@gmail.com", "Tuan", "hashed_password_1126", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ecd686c7-1594-49c1-81bf-cf0b3e205af2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan113@gmail.com", "Tuan", "hashed_password_1113", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ed521ad2-c248-4f13-9861-d1b24980f28a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan220@gmail.com", "Tuan", "hashed_password_1220", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("eda6e60c-5383-4bdd-b280-22379df2ab4f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan593@gmail.com", "Tuan", "hashed_password_1593", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("edb23fa4-c38a-4c43-a62a-c010d961ab7b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan72@gmail.com", "Tuan", "hashed_password_172", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("edb6689f-00c1-4bea-a3f2-d7d69c2c39b9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan419@gmail.com", "Tuan", "hashed_password_1419", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("eddcf6af-d463-4605-b349-e5ca83850c43"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan144@gmail.com", "Tuan", "hashed_password_1144", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ee078b9f-0723-4fb0-87c2-974ebc4100f2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan930@gmail.com", "Tuan", "hashed_password_1930", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ee7e51ac-045e-4e1d-b347-31dfdd86ce43"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan671@gmail.com", "Tuan", "hashed_password_1671", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("eef848a0-538b-45e5-bd17-163c1069e580"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan448@gmail.com", "Tuan", "hashed_password_1448", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ef571ba0-fe4e-48e2-935c-d736d591ece6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan458@gmail.com", "Tuan", "hashed_password_1458", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("efc36dea-e365-4ae9-bc4d-9d3c3913a9e7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan488@gmail.com", "Tuan", "hashed_password_1488", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("eff90a34-160c-48c6-91a7-264ca8550a6f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan949@gmail.com", "Tuan", "hashed_password_1949", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f0010010-8220-40e5-8e1a-13dd1fb2ee16"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan110@gmail.com", "Tuan", "hashed_password_1110", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f0235b86-d8c2-4361-93ef-29448815fc64"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan805@gmail.com", "Tuan", "hashed_password_1805", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f02a6334-88c9-40d2-a35e-eeeca14027aa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan755@gmail.com", "Tuan", "hashed_password_1755", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f063b89f-979c-49a2-9bc9-98fbf4c31539"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan847@gmail.com", "Tuan", "hashed_password_1847", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f0bac15c-a2d2-4642-9159-ff7ab6c9241f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan412@gmail.com", "Tuan", "hashed_password_1412", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f0bfb0d4-cf5d-43f9-86bc-02c438187533"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan583@gmail.com", "Tuan", "hashed_password_1583", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f1043ffc-42c8-4b98-ac62-924baf228f92"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan939@gmail.com", "Tuan", "hashed_password_1939", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f1063e5d-bde7-4d05-a453-ddf8f60314b4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan745@gmail.com", "Tuan", "hashed_password_1745", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f1527f11-3250-4d13-881e-cdc0d554fd8d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan674@gmail.com", "Tuan", "hashed_password_1674", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f202c3af-0e16-458b-bcd3-36de131d400a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan352@gmail.com", "Tuan", "hashed_password_1352", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f2604030-cde2-4807-964d-cd226df02cf0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan362@gmail.com", "Tuan", "hashed_password_1362", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f2990416-d8d7-46f4-aca7-18a9617d6710"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan36@gmail.com", "Tuan", "hashed_password_136", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f35d58e4-16df-4f5d-9d35-544b3f3148e5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan109@gmail.com", "Tuan", "hashed_password_1109", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f3adabf1-ced0-4dd4-ab6b-ba10691020d1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan619@gmail.com", "Tuan", "hashed_password_1619", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f45ce05c-bad3-4b1a-b6e5-be9fd57058b2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan414@gmail.com", "Tuan", "hashed_password_1414", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f4eff91c-7a35-4f98-9ff8-f32d819cf8cc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan788@gmail.com", "Tuan", "hashed_password_1788", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f4f85dbc-3966-42d2-ac0f-df491b7e2eec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan730@gmail.com", "Tuan", "hashed_password_1730", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f5712845-c7b0-4a28-a5cf-5dd1905171f6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan554@gmail.com", "Tuan", "hashed_password_1554", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f574139c-b374-4059-8aaf-7969099544fb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan585@gmail.com", "Tuan", "hashed_password_1585", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f5a54f23-dbe8-494d-908e-76c28d7592eb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan111@gmail.com", "Tuan", "hashed_password_1111", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f5ba1d21-9a54-47c9-8045-358c9c9d6d83"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan560@gmail.com", "Tuan", "hashed_password_1560", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f5efa5de-ff99-41b3-91b0-ee4a6ad11ed0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan624@gmail.com", "Tuan", "hashed_password_1624", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f64d24a9-59f8-40bd-b4e6-012ed77a0dd4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan659@gmail.com", "Tuan", "hashed_password_1659", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f65c3cfb-bfff-4591-bcae-81d731abc5e7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan621@gmail.com", "Tuan", "hashed_password_1621", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f6961525-d78e-45fa-b5e9-77a6e7b784b5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan296@gmail.com", "Tuan", "hashed_password_1296", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f6e1e0fd-6c21-4172-9688-727a8aa074bd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan427@gmail.com", "Tuan", "hashed_password_1427", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f6fc309a-292b-454c-b64b-9c8a5a48038f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan157@gmail.com", "Tuan", "hashed_password_1157", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f73d8b07-fc33-47f4-88d9-63d2abe9aaaf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan656@gmail.com", "Tuan", "hashed_password_1656", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f756c1db-b660-4d70-b2de-58038d937163"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan197@gmail.com", "Tuan", "hashed_password_1197", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f75ec5c2-adde-4bec-af40-c4a17d349d7a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan789@gmail.com", "Tuan", "hashed_password_1789", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f7826859-cea7-4f55-9b81-521ad02a35ae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan426@gmail.com", "Tuan", "hashed_password_1426", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f7913c40-f0d4-4141-9c72-d3e27f9934b2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan976@gmail.com", "Tuan", "hashed_password_1976", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f79aa9eb-b037-45a7-9db2-ac1dce920892"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan124@gmail.com", "Tuan", "hashed_password_1124", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f79fafbe-70f2-42d5-9170-2352a98bc49c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan657@gmail.com", "Tuan", "hashed_password_1657", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f7c79766-41ba-47ad-9af2-38e7a360731d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan980@gmail.com", "Tuan", "hashed_password_1980", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f86527af-05da-4415-8e9b-098e6b87b950"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan339@gmail.com", "Tuan", "hashed_password_1339", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f890795d-a83f-411b-a7d1-1184c2b46867"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan436@gmail.com", "Tuan", "hashed_password_1436", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f89a8f36-dd02-469e-abe0-af87498d5e27"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan860@gmail.com", "Tuan", "hashed_password_1860", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f901d4ac-cf7d-4bb7-87ef-10ac1d56b690"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan753@gmail.com", "Tuan", "hashed_password_1753", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("f9abc7bf-2713-4fd2-8c2e-1e225c0c8ff0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan873@gmail.com", "Tuan", "hashed_password_1873", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fa05e47a-a8e5-45d5-97eb-a9bdf8819b1e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan505@gmail.com", "Tuan", "hashed_password_1505", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fa1bf0e9-9506-408f-96e0-298976eb6d4f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan990@gmail.com", "Tuan", "hashed_password_1990", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fa67e0d9-27dd-4a2c-b138-0b302106134a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan895@gmail.com", "Tuan", "hashed_password_1895", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fae0ab06-cb4b-48a4-b16d-49335da885f0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan830@gmail.com", "Tuan", "hashed_password_1830", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fae684c1-8c4b-4af2-8fcd-046bc163be18"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan547@gmail.com", "Tuan", "hashed_password_1547", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fb72de3c-8ec6-452c-bc05-ea02a255c657"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan315@gmail.com", "Tuan", "hashed_password_1315", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fb866da0-967f-405b-a642-081fd3995b99"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan104@gmail.com", "Tuan", "hashed_password_1104", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fb87a556-24e5-431f-acb5-0b103b54ccdc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan68@gmail.com", "Tuan", "hashed_password_168", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fb899d21-7888-434c-997e-ddb0d6c73aa3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan135@gmail.com", "Tuan", "hashed_password_1135", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fb95921b-8ec4-47a2-8de8-1708134f101f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan938@gmail.com", "Tuan", "hashed_password_1938", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fbdaf342-6e54-4cac-accd-db197f41c194"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan570@gmail.com", "Tuan", "hashed_password_1570", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fbedc01a-ed13-47d3-88b4-8c3c20fd9d68"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan248@gmail.com", "Tuan", "hashed_password_1248", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fc1a9501-2c0c-4745-8295-147d64cce977"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan704@gmail.com", "Tuan", "hashed_password_1704", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fc31a842-2dbc-4018-8382-1c065811dc9c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan39@gmail.com", "Tuan", "hashed_password_139", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fc60d603-e65f-46b9-bf38-119f8ddf91bd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan92@gmail.com", "Tuan", "hashed_password_192", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fd3a2325-bc11-4b10-9317-cae869755fcc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan654@gmail.com", "Tuan", "hashed_password_1654", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fd736ec5-e11b-4b39-8ac4-5f1860ac41b5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan94@gmail.com", "Tuan", "hashed_password_194", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fe13fe28-b244-435a-9da2-ff38e04d8634"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan478@gmail.com", "Tuan", "hashed_password_1478", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("fec3e319-6189-449b-95ba-9ab580d587bc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan782@gmail.com", "Tuan", "hashed_password_1782", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ff21597e-9ef4-48f6-a764-3eda1d3fa21e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan473@gmail.com", "Tuan", "hashed_password_1473", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ff4135bb-27d5-4542-9a47-df1437cea4bb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan244@gmail.com", "Tuan", "hashed_password_1244", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ff8d9439-e297-40c0-be48-02f1cc5f3ba1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuan186@gmail.com", "Tuan", "hashed_password_1186", null, false, false, "Le", null, "User", null, 0 },
                    { new Guid("ffe41c68-f4d9-4e3c-9e7d-0699c7f78a47"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tuanle17062k5@gmail.com", "Tuan", "hashed_password_1", null, false, false, "Le", null, "User", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "IsDeleted", "Name", "ParentId", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("12e11df5-6b30-4f9f-a0d9-b997d1af17e1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean", new Guid("2cd22a14-8388-4e0a-b7e6-c22eec0eb647"), null },
                    { new Guid("78d98f98-4002-42fb-ba3f-f7ceedab9639"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao", new Guid("b3b8b0b0-20d6-4dcf-bf20-fef2f8eb7d94"), null },
                    { new Guid("b3b69ae0-5c80-43c0-9873-8fdaf4d24c0b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo ba lỗ", new Guid("b3b8b0b0-20d6-4dcf-bf20-fef2f8eb7d94"), null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "CreateAt", "IsDeleted", "Status", "TotalAmount", "UpdateAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("6700e3ba-cdbc-4dca-a3f0-bd0195b47c1a"), "Bien Hoa, Dong Nai", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed", 100000m, null, new Guid("69514928-4364-4b79-bae5-b7b466528f20") },
                    { new Guid("ee2a6607-55e0-4000-8859-db96ceb59690"), "Bien Hoa, Dong Nai", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed", 100000m, null, new Guid("69514928-4364-4b79-bae5-b7b466528f20") }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "CompanyAddress", "CompanyName", "CreateAt", "IsDeleted", "TaxCode", "UpdateAt", "UserId" },
                values: new object[] { new Guid("475e1512-4241-4abf-8f91-f91e4e0d6ffb"), "123 Main St, Cityville", "ABC Company", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE123", null, new Guid("ffe41c68-f4d9-4e3c-9e7d-0699c7f78a47") });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreateAt", "Description", "IsDeleted", "Name", "Price", "SellerId", "UpdateAt", "UrlImage" },
                values: new object[,]
                {
                    { new Guid("3c28eb5d-2f47-4968-9049-6a5143e3dfa6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Áo thun nam chất liệu cotton cấp cao, thoáng mát, phù hợp cho mọi hoạt động hằng ngày.", false, "Áo Thun Nam", 199000m, new Guid("475e1512-4241-4abf-8f91-f91e4e0d6ffb"), null, "https://example.com/images/ao_thun_nam.jpg" },
                    { new Guid("76e433c3-fcea-477a-be19-66c662912c71"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quần jeans nữa dáng ôm, tôn dáng, chất liệu denim co dãn, phù hợp cho mọi dịp.", false, "Quần Jeans Nữ", 399000m, new Guid("475e1512-4241-4abf-8f91-f91e4e0d6ffb"), null, "https://example.com/images/quan_jeans_nu.jpg" },
                    { new Guid("8d5c0b06-a000-48a9-8266-55a82cae6b89"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Áo sơ mi nam công sở, thiết kế hiện đại, chất liệu vải cao cấp, thoáng mát.", false, "Áo Sơ Mi Nam", 299000m, new Guid("475e1512-4241-4abf-8f91-f91e4e0d6ffb"), null, "https://example.com/images/ao_so_mi_nam.jpg" },
                    { new Guid("bb1636be-8f4d-4a44-b8e8-fa6306137f4f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Chân váy nữ xòe, thiết kế trẻ trung, chất liệu vải mềm mại, phù hợp cho mọi dịp.", false, "Chân Váy Nữ", 249000m, new Guid("475e1512-4241-4abf-8f91-f91e4e0d6ffb"), null, "https://example.com/images/chan_vay_nu.jpg" }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "CreateAt", "IsDeleted", "OrderId", "ProductId", "Quantity", "UnitPrice", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("101743e8-1bc6-43a9-b95b-8609414f7cf8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("ee2a6607-55e0-4000-8859-db96ceb59690"), new Guid("76e433c3-fcea-477a-be19-66c662912c71"), 2, 399000m, null },
                    { new Guid("54ca6061-8aa8-46c9-9908-b9f9558901aa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("6700e3ba-cdbc-4dca-a3f0-bd0195b47c1a"), new Guid("8d5c0b06-a000-48a9-8266-55a82cae6b89"), 2, 299000m, null },
                    { new Guid("65c0693c-8580-4c6b-82fe-b986cd0208a4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("ee2a6607-55e0-4000-8859-db96ceb59690"), new Guid("3c28eb5d-2f47-4968-9049-6a5143e3dfa6"), 2, 199000m, null }
                });
        }
    }
}
