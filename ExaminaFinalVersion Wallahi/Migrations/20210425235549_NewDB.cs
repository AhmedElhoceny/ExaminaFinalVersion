using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExaminaFinalVersion_Wallahi.Migrations
{
    public partial class NewDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Course_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Course_Name = table.Column<string>(nullable: true),
                    Course_Image = table.Column<string>(nullable: true),
                    Professor_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Course_ID);
                });

            migrationBuilder.CreateTable(
                name: "CourseStudentRelationship",
                columns: table => new
                {
                    CourseStudentRelationshipID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentID = table.Column<int>(nullable: false),
                    CourseID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudentRelationship", x => x.CourseStudentRelationshipID);
                });

            migrationBuilder.CreateTable(
                name: "Exam",
                columns: table => new
                {
                    Exam_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Exam_Title = table.Column<string>(nullable: true),
                    Exam_Script = table.Column<string>(nullable: true),
                    Exam_Image = table.Column<string>(nullable: true),
                    Exam_Distenation = table.Column<string>(nullable: true),
                    Course_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam", x => x.Exam_ID);
                });

            migrationBuilder.CreateTable(
                name: "Picture",
                columns: table => new
                {
                    Picture_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Picture_Title = table.Column<string>(nullable: true),
                    Picture_Script = table.Column<string>(nullable: true),
                    Picture_Image = table.Column<string>(nullable: true),
                    Picture_Distenation = table.Column<string>(nullable: true),
                    Course_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Picture", x => x.Picture_ID);
                });

            migrationBuilder.CreateTable(
                name: "Professor",
                columns: table => new
                {
                    Professor_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Professor_FullName = table.Column<string>(nullable: true),
                    Professor_Email = table.Column<string>(nullable: true),
                    Professor_Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professor", x => x.Professor_ID);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Project_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Project_Title = table.Column<string>(nullable: true),
                    Project_Script = table.Column<string>(nullable: true),
                    Project_Image = table.Column<string>(nullable: true),
                    Project_Distenation = table.Column<string>(nullable: true),
                    Course_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Project_ID);
                });

            migrationBuilder.CreateTable(
                name: "Reading",
                columns: table => new
                {
                    Reading_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Readings_Reading_Title = table.Column<string>(nullable: true),
                    Readings_Script = table.Column<string>(nullable: true),
                    Readings_Image = table.Column<string>(nullable: true),
                    Readings_Content = table.Column<string>(nullable: true),
                    Course_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reading", x => x.Reading_ID);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    RequestID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Request_StudentID = table.Column<int>(nullable: false),
                    Request_CourseID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.RequestID);
                });

            migrationBuilder.CreateTable(
                name: "Sheet",
                columns: table => new
                {
                    Sheet_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sheet_Title = table.Column<string>(nullable: true),
                    Sheet_Script = table.Column<string>(nullable: true),
                    Sheet_Image = table.Column<string>(nullable: true),
                    Sheet_Distenation = table.Column<string>(nullable: true),
                    Course_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sheet", x => x.Sheet_ID);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Student_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Student_FullName = table.Column<string>(nullable: true),
                    Student_Email = table.Column<string>(nullable: true),
                    Student_PassWord = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Student_ID);
                });

            migrationBuilder.CreateTable(
                name: "Video",
                columns: table => new
                {
                    Video_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Video_Title = table.Column<string>(nullable: true),
                    Video_script = table.Column<int>(nullable: false),
                    Video_Image = table.Column<string>(nullable: true),
                    Video_Distenation = table.Column<string>(nullable: true),
                    Course_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Video", x => x.Video_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "CourseStudentRelationship");

            migrationBuilder.DropTable(
                name: "Exam");

            migrationBuilder.DropTable(
                name: "Picture");

            migrationBuilder.DropTable(
                name: "Professor");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Reading");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Sheet");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Video");
        }
    }
}
