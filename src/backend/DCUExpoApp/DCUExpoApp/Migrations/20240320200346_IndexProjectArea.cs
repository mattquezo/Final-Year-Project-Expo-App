using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DCUExpoApp.Migrations
{
    /// <inheritdoc />
    public partial class IndexProjectArea : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProjectAreaName",
                table: "ProjectAreas",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectAreas_ProjectAreaName",
                table: "ProjectAreas",
                column: "ProjectAreaName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProjectAreas_ProjectAreaName",
                table: "ProjectAreas");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectAreaName",
                table: "ProjectAreas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
