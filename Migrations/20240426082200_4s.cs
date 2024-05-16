using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sommelio.Migrations
{
    /// <inheritdoc />
    public partial class _4s : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_Addresses_AddressId",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_User_Userid",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyProduct_Company_CompanyId",
                table: "CompanyProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyProduct_Product_ProductId",
                table: "CompanyProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_DelicaciesWine_Delicacies_DelicaciesId",
                table: "DelicaciesWine");

            migrationBuilder.DropForeignKey(
                name: "FK_DelicaciesWine_Wine_WineId",
                table: "DelicaciesWine");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Company_CompanyId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_FavEvents_User_ParticularId",
                table: "FavEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Beer_BeerId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Wine_WineId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Region_Country_CountryId",
                table: "Region");

            migrationBuilder.DropForeignKey(
                name: "FK_ScannedUser_Company_CompanyId",
                table: "ScannedUser");

            migrationBuilder.DropForeignKey(
                name: "FK_ScannedUser_User_ParticularId",
                table: "ScannedUser");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Addresses_AddressId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_FidelityRank_FidelityGradeId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_ProfessionalType_ProfessionalTypeId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_Wine_Cepage_CepageId",
                table: "Wine");

            migrationBuilder.DropForeignKey(
                name: "FK_Wine_Region_RegionId",
                table: "Wine");

            migrationBuilder.DropForeignKey(
                name: "FK_Wine_TypeApellation_TypeAppellationId",
                table: "Wine");

            migrationBuilder.DropForeignKey(
                name: "FK_Wine_WineType_WineTypeId",
                table: "Wine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WineType",
                table: "WineType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Wine",
                table: "Wine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ScannedUser",
                table: "ScannedUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Region",
                table: "Region");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProfessionalType",
                table: "ProfessionalType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FidelityRank",
                table: "FidelityRank");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DelicaciesWine",
                table: "DelicaciesWine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyProduct",
                table: "CompanyProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Company",
                table: "Company");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cepage",
                table: "Cepage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Beer",
                table: "Beer");

            migrationBuilder.RenameTable(
                name: "WineType",
                newName: "WineTypes");

            migrationBuilder.RenameTable(
                name: "Wine",
                newName: "Wines");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "ScannedUser",
                newName: "ScannedUsers");

            migrationBuilder.RenameTable(
                name: "Region",
                newName: "Regions");

            migrationBuilder.RenameTable(
                name: "ProfessionalType",
                newName: "ProfessionalTypes");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "FidelityRank",
                newName: "FidelityRanks");

            migrationBuilder.RenameTable(
                name: "DelicaciesWine",
                newName: "DelicaciesWines");

            migrationBuilder.RenameTable(
                name: "CompanyProduct",
                newName: "CompanyProducts");

            migrationBuilder.RenameTable(
                name: "Company",
                newName: "Companies");

            migrationBuilder.RenameTable(
                name: "Cepage",
                newName: "Cepages");

            migrationBuilder.RenameTable(
                name: "Beer",
                newName: "Beers");

            migrationBuilder.RenameIndex(
                name: "IX_Wine_WineTypeId",
                table: "Wines",
                newName: "IX_Wines_WineTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Wine_TypeAppellationId",
                table: "Wines",
                newName: "IX_Wines_TypeAppellationId");

            migrationBuilder.RenameIndex(
                name: "IX_Wine_RegionId",
                table: "Wines",
                newName: "IX_Wines_RegionId");

            migrationBuilder.RenameIndex(
                name: "IX_Wine_CepageId",
                table: "Wines",
                newName: "IX_Wines_CepageId");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Users",
                newName: "Surname");

            migrationBuilder.RenameIndex(
                name: "IX_User_ProfessionalTypeId",
                table: "Users",
                newName: "IX_Users_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_User_FidelityGradeId",
                table: "Users",
                newName: "IX_Users_FidelityGradeId");

            migrationBuilder.RenameIndex(
                name: "IX_User_AddressId",
                table: "Users",
                newName: "IX_Users_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_ScannedUser_ParticularId",
                table: "ScannedUsers",
                newName: "IX_ScannedUsers_ParticularId");

            migrationBuilder.RenameIndex(
                name: "IX_Region_CountryId",
                table: "Regions",
                newName: "IX_Regions_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_WineId",
                table: "Products",
                newName: "IX_Products_WineId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_BeerId",
                table: "Products",
                newName: "IX_Products_BeerId");

            migrationBuilder.RenameIndex(
                name: "IX_DelicaciesWine_DelicaciesId",
                table: "DelicaciesWines",
                newName: "IX_DelicaciesWines_DelicaciesId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyProduct_ProductId",
                table: "CompanyProducts",
                newName: "IX_CompanyProducts_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Company_Userid",
                table: "Companies",
                newName: "IX_Companies_Userid");

            migrationBuilder.RenameIndex(
                name: "IX_Company_AddressId",
                table: "Companies",
                newName: "IX_Companies_AddressId");

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePictureUrl",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WineTypes",
                table: "WineTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Wines",
                table: "Wines",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ScannedUsers",
                table: "ScannedUsers",
                columns: new[] { "CompanyId", "ParticularId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Regions",
                table: "Regions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProfessionalTypes",
                table: "ProfessionalTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FidelityRanks",
                table: "FidelityRanks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DelicaciesWines",
                table: "DelicaciesWines",
                columns: new[] { "WineId", "DelicaciesId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyProducts",
                table: "CompanyProducts",
                columns: new[] { "CompanyId", "ProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cepages",
                table: "Cepages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Beers",
                table: "Beers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Addresses_AddressId",
                table: "Companies",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Users_Userid",
                table: "Companies",
                column: "Userid",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyProducts_Companies_CompanyId",
                table: "CompanyProducts",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyProducts_Products_ProductId",
                table: "CompanyProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DelicaciesWines_Delicacies_DelicaciesId",
                table: "DelicaciesWines",
                column: "DelicaciesId",
                principalTable: "Delicacies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DelicaciesWines_Wines_WineId",
                table: "DelicaciesWines",
                column: "WineId",
                principalTable: "Wines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Companies_CompanyId",
                table: "Events",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FavEvents_Users_ParticularId",
                table: "FavEvents",
                column: "ParticularId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Beers_BeerId",
                table: "Products",
                column: "BeerId",
                principalTable: "Beers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Wines_WineId",
                table: "Products",
                column: "WineId",
                principalTable: "Wines",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Regions_Country_CountryId",
                table: "Regions",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ScannedUsers_Companies_CompanyId",
                table: "ScannedUsers",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ScannedUsers_Users_ParticularId",
                table: "ScannedUsers",
                column: "ParticularId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Addresses_AddressId",
                table: "Users",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_FidelityRanks_FidelityGradeId",
                table: "Users",
                column: "FidelityGradeId",
                principalTable: "FidelityRanks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_ProfessionalTypes_ProfessionalTypeId",
                table: "Users",
                column: "ProfessionalTypeId",
                principalTable: "ProfessionalTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wines_Cepages_CepageId",
                table: "Wines",
                column: "CepageId",
                principalTable: "Cepages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Wines_Regions_RegionId",
                table: "Wines",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Wines_TypeApellation_TypeAppellationId",
                table: "Wines",
                column: "TypeAppellationId",
                principalTable: "TypeApellation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Wines_WineTypes_WineTypeId",
                table: "Wines",
                column: "WineTypeId",
                principalTable: "WineTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Addresses_AddressId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Users_Userid",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyProducts_Companies_CompanyId",
                table: "CompanyProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyProducts_Products_ProductId",
                table: "CompanyProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_DelicaciesWines_Delicacies_DelicaciesId",
                table: "DelicaciesWines");

            migrationBuilder.DropForeignKey(
                name: "FK_DelicaciesWines_Wines_WineId",
                table: "DelicaciesWines");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Companies_CompanyId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_FavEvents_Users_ParticularId",
                table: "FavEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Beers_BeerId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Wines_WineId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Regions_Country_CountryId",
                table: "Regions");

            migrationBuilder.DropForeignKey(
                name: "FK_ScannedUsers_Companies_CompanyId",
                table: "ScannedUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ScannedUsers_Users_ParticularId",
                table: "ScannedUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Addresses_AddressId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_FidelityRanks_FidelityGradeId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_ProfessionalTypes_ProfessionalTypeId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Wines_Cepages_CepageId",
                table: "Wines");

            migrationBuilder.DropForeignKey(
                name: "FK_Wines_Regions_RegionId",
                table: "Wines");

            migrationBuilder.DropForeignKey(
                name: "FK_Wines_TypeApellation_TypeAppellationId",
                table: "Wines");

            migrationBuilder.DropForeignKey(
                name: "FK_Wines_WineTypes_WineTypeId",
                table: "Wines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WineTypes",
                table: "WineTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Wines",
                table: "Wines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ScannedUsers",
                table: "ScannedUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Regions",
                table: "Regions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProfessionalTypes",
                table: "ProfessionalTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FidelityRanks",
                table: "FidelityRanks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DelicaciesWines",
                table: "DelicaciesWines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyProducts",
                table: "CompanyProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cepages",
                table: "Cepages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Beers",
                table: "Beers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "WineTypes",
                newName: "WineType");

            migrationBuilder.RenameTable(
                name: "Wines",
                newName: "Wine");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "ScannedUsers",
                newName: "ScannedUser");

            migrationBuilder.RenameTable(
                name: "Regions",
                newName: "Region");

            migrationBuilder.RenameTable(
                name: "ProfessionalTypes",
                newName: "ProfessionalType");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "FidelityRanks",
                newName: "FidelityRank");

            migrationBuilder.RenameTable(
                name: "DelicaciesWines",
                newName: "DelicaciesWine");

            migrationBuilder.RenameTable(
                name: "CompanyProducts",
                newName: "CompanyProduct");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "Company");

            migrationBuilder.RenameTable(
                name: "Cepages",
                newName: "Cepage");

            migrationBuilder.RenameTable(
                name: "Beers",
                newName: "Beer");

            migrationBuilder.RenameIndex(
                name: "IX_Wines_WineTypeId",
                table: "Wine",
                newName: "IX_Wine_WineTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Wines_TypeAppellationId",
                table: "Wine",
                newName: "IX_Wine_TypeAppellationId");

            migrationBuilder.RenameIndex(
                name: "IX_Wines_RegionId",
                table: "Wine",
                newName: "IX_Wine_RegionId");

            migrationBuilder.RenameIndex(
                name: "IX_Wines_CepageId",
                table: "Wine",
                newName: "IX_Wine_CepageId");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "User",
                newName: "Username");

            migrationBuilder.RenameIndex(
                name: "IX_Users_ProfessionalTypeId",
                table: "User",
                newName: "IX_User_ProfessionalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_FidelityGradeId",
                table: "User",
                newName: "IX_User_FidelityGradeId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_AddressId",
                table: "User",
                newName: "IX_User_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_ScannedUsers_ParticularId",
                table: "ScannedUser",
                newName: "IX_ScannedUser_ParticularId");

            migrationBuilder.RenameIndex(
                name: "IX_Regions_CountryId",
                table: "Region",
                newName: "IX_Region_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_WineId",
                table: "Product",
                newName: "IX_Product_WineId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_BeerId",
                table: "Product",
                newName: "IX_Product_BeerId");

            migrationBuilder.RenameIndex(
                name: "IX_DelicaciesWines_DelicaciesId",
                table: "DelicaciesWine",
                newName: "IX_DelicaciesWine_DelicaciesId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyProducts_ProductId",
                table: "CompanyProduct",
                newName: "IX_CompanyProduct_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Companies_Userid",
                table: "Company",
                newName: "IX_Company_Userid");

            migrationBuilder.RenameIndex(
                name: "IX_Companies_AddressId",
                table: "Company",
                newName: "IX_Company_AddressId");

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePictureUrl",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WineType",
                table: "WineType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Wine",
                table: "Wine",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ScannedUser",
                table: "ScannedUser",
                columns: new[] { "CompanyId", "ParticularId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Region",
                table: "Region",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProfessionalType",
                table: "ProfessionalType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FidelityRank",
                table: "FidelityRank",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DelicaciesWine",
                table: "DelicaciesWine",
                columns: new[] { "WineId", "DelicaciesId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyProduct",
                table: "CompanyProduct",
                columns: new[] { "CompanyId", "ProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Company",
                table: "Company",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cepage",
                table: "Cepage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Beer",
                table: "Beer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Addresses_AddressId",
                table: "Company",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_User_Userid",
                table: "Company",
                column: "Userid",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyProduct_Company_CompanyId",
                table: "CompanyProduct",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyProduct_Product_ProductId",
                table: "CompanyProduct",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DelicaciesWine_Delicacies_DelicaciesId",
                table: "DelicaciesWine",
                column: "DelicaciesId",
                principalTable: "Delicacies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DelicaciesWine_Wine_WineId",
                table: "DelicaciesWine",
                column: "WineId",
                principalTable: "Wine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Company_CompanyId",
                table: "Events",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FavEvents_User_ParticularId",
                table: "FavEvents",
                column: "ParticularId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Beer_BeerId",
                table: "Product",
                column: "BeerId",
                principalTable: "Beer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Wine_WineId",
                table: "Product",
                column: "WineId",
                principalTable: "Wine",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Region_Country_CountryId",
                table: "Region",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ScannedUser_Company_CompanyId",
                table: "ScannedUser",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ScannedUser_User_ParticularId",
                table: "ScannedUser",
                column: "ParticularId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Addresses_AddressId",
                table: "User",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_FidelityRank_FidelityGradeId",
                table: "User",
                column: "FidelityGradeId",
                principalTable: "FidelityRank",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_ProfessionalType_ProfessionalTypeId",
                table: "User",
                column: "ProfessionalTypeId",
                principalTable: "ProfessionalType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wine_Cepage_CepageId",
                table: "Wine",
                column: "CepageId",
                principalTable: "Cepage",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Wine_Region_RegionId",
                table: "Wine",
                column: "RegionId",
                principalTable: "Region",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Wine_TypeApellation_TypeAppellationId",
                table: "Wine",
                column: "TypeAppellationId",
                principalTable: "TypeApellation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Wine_WineType_WineTypeId",
                table: "Wine",
                column: "WineTypeId",
                principalTable: "WineType",
                principalColumn: "Id");
        }
    }
}
