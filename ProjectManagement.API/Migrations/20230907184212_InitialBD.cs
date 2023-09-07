using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectManagement.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialBD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InvestigationProjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameProject = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StartDate = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EndDate = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Area = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvestigationProjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Investigators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameInvestigador = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    InstitutionalAffiliation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investigators", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvestigationProjects_NameProject",
                table: "InvestigationProjects",
                column: "NameProject",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Investigators_NameInvestigador",
                table: "Investigators",
                column: "NameInvestigador",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvestigationProjects");

            migrationBuilder.DropTable(
                name: "Investigators");
        }
    }
}
