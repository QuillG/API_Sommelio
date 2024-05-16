using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sommelio.Migrations
{
    /// <inheritdoc />
    public partial class _7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "WineTypes");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Delicacies");

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "WineTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "Delicacies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ColorsBtn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorsBtn", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WineTypes_ColorId",
                table: "WineTypes",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Delicacies_ColorId",
                table: "Delicacies",
                column: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Delicacies_ColorsBtn_ColorId",
                table: "Delicacies",
                column: "ColorId",
                principalTable: "ColorsBtn",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WineTypes_ColorsBtn_ColorId",
                table: "WineTypes",
                column: "ColorId",
                principalTable: "ColorsBtn",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Delicacies_ColorsBtn_ColorId",
                table: "Delicacies");

            migrationBuilder.DropForeignKey(
                name: "FK_WineTypes_ColorsBtn_ColorId",
                table: "WineTypes");

            migrationBuilder.DropTable(
                name: "ColorsBtn");

            migrationBuilder.DropIndex(
                name: "IX_WineTypes_ColorId",
                table: "WineTypes");

            migrationBuilder.DropIndex(
                name: "IX_Delicacies_ColorId",
                table: "Delicacies");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "WineTypes");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "Delicacies");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "WineTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Delicacies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
