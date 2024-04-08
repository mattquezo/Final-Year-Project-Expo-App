using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DCUExpoApp.Migrations
{
    /// <inheritdoc />
    public partial class AddProjectLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProjectLocation",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectLocation",
                table: "Projects");
        }
    }
}
