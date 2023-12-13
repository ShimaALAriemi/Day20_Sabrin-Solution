using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day20_Sabrin.Migrations
{
    public partial class RelationSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Projects_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Projects_Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProjects",
                columns: table => new
                {
                    EmplyeeProjectEmployee_Id = table.Column<int>(type: "int", nullable: false),
                    Projects_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProjects", x => new { x.EmplyeeProjectEmployee_Id, x.Projects_Id });
                    table.ForeignKey(
                        name: "FK_EmployeeProjects_Employees_EmplyeeProjectEmployee_Id",
                        column: x => x.EmplyeeProjectEmployee_Id,
                        principalTable: "Employees",
                        principalColumn: "Employee_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProjects_Project_Projects_Id",
                        column: x => x.Projects_Id,
                        principalTable: "Project",
                        principalColumn: "Projects_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepId",
                table: "Employees",
                column: "DepId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProjects_Projects_Id",
                table: "EmployeeProjects",
                column: "Projects_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepId",
                table: "Employees",
                column: "DepId",
                principalTable: "Departments",
                principalColumn: "Dep_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "EmployeeProjects");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepId",
                table: "Employees");
        }
    }
}
