using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sommelio.Migrations
{
    /// <inheritdoc />
    public partial class _8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "parentId",
                table: "Delicacies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Delicacies_parentId",
                table: "Delicacies",
                column: "parentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Delicacies_Delicacies_parentId",
                table: "Delicacies",
                column: "parentId",
                principalTable: "Delicacies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Delicacies_Delicacies_parentId",
                table: "Delicacies");

            migrationBuilder.DropIndex(
                name: "IX_Delicacies_parentId",
                table: "Delicacies");

            migrationBuilder.DropColumn(
                name: "parentId",
                table: "Delicacies");
        }
    }
}
