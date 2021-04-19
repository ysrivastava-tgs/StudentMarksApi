using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class firstmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MarksModel",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    StudId = table.Column<string>(nullable: true),
                    Subjid = table.Column<string>(nullable: true),
                    Marks = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarksModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentModel",
                columns: table => new
                {
                    StudId = table.Column<string>(nullable: false),
                    StudName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentModel", x => x.StudId);
                });

            migrationBuilder.CreateTable(
                name: "SubjectModel",
                columns: table => new
                {
                    SubjId = table.Column<string>(nullable: false),
                    SubjName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectModel", x => x.SubjId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MarksModel");

            migrationBuilder.DropTable(
                name: "StudentModel");

            migrationBuilder.DropTable(
                name: "SubjectModel");
        }
    }
}
