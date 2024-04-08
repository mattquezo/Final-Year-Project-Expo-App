using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DCUExpoApp.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentProgrammes",
                columns: table => new
                {
                    StudentProgrammeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentProgrammeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentProgrammes", x => x.StudentProgrammeId);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    ProjectTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectSummary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupervisorsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentProgrammeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_StudentProgrammes_StudentProgrammeId",
                        column: x => x.StudentProgrammeId,
                        principalTable: "StudentProgrammes",
                        principalColumn: "StudentProgrammeId");
                });

            migrationBuilder.CreateTable(
                name: "ProjectAreas",
                columns: table => new
                {
                    ProjectAreaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectAreaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpoProjectId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectAreas", x => x.ProjectAreaId);
                    table.ForeignKey(
                        name: "FK_ProjectAreas_Projects_ExpoProjectId",
                        column: x => x.ExpoProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProjectTechnologies",
                columns: table => new
                {
                    ProjectTechnologyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectTechnologyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpoProjectId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTechnologies", x => x.ProjectTechnologyId);
                    table.ForeignKey(
                        name: "FK_ProjectTechnologies_Projects_ExpoProjectId",
                        column: x => x.ExpoProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    StudentEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpoProjectId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Projects_ExpoProjectId",
                        column: x => x.ExpoProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectAreas_ExpoProjectId",
                table: "ProjectAreas",
                column: "ExpoProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_StudentProgrammeId",
                table: "Projects",
                column: "StudentProgrammeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTechnologies_ExpoProjectId",
                table: "ProjectTechnologies",
                column: "ExpoProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ExpoProjectId",
                table: "Students",
                column: "ExpoProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectAreas");

            migrationBuilder.DropTable(
                name: "ProjectTechnologies");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "StudentProgrammes");
        }
    }
}
