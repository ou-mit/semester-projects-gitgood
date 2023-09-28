using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TACalender.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Subject = table.Column<int>(type: "INTEGER", nullable: false),
                    CourseNo = table.Column<int>(type: "INTEGER", nullable: false),
                    NumSections = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseID);
                });

            migrationBuilder.CreateTable(
                name: "Educators",
                columns: table => new
                {
                    EduID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FName = table.Column<string>(type: "TEXT", nullable: false),
                    MName = table.Column<string>(type: "TEXT", nullable: false),
                    LName = table.Column<string>(type: "TEXT", nullable: false),
                    PrefName = table.Column<string>(type: "TEXT", nullable: false),
                    PersonalEmail = table.Column<string>(type: "TEXT", nullable: false),
                    OUEmail = table.Column<string>(type: "TEXT", nullable: false),
                    NumSection = table.Column<int>(type: "INTEGER", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educators", x => x.EduID);
                });

            migrationBuilder.CreateTable(
                name: "Time",
                columns: table => new
                {
                    TimeID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Hours = table.Column<int>(type: "INTEGER", nullable: false),
                    Minutes = table.Column<int>(type: "INTEGER", nullable: false),
                    AMorPM = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Time", x => x.TimeID);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    SectionID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EduID = table.Column<int>(type: "INTEGER", nullable: false),
                    CourseID = table.Column<int>(type: "INTEGER", nullable: false),
                    SectionNo = table.Column<int>(type: "INTEGER", nullable: false),
                    NumTas = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.SectionID);
                    table.ForeignKey(
                        name: "FK_Sections_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    RID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EduID = table.Column<int>(type: "INTEGER", nullable: false),
                    timeOfRequest = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Weekday = table.Column<string>(type: "TEXT", nullable: false),
                    StartTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Approved = table.Column<bool>(type: "INTEGER", nullable: false),
                    TAEduID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.RID);
                    table.ForeignKey(
                        name: "FK_Requests_Educators_TAEduID",
                        column: x => x.TAEduID,
                        principalTable: "Educators",
                        principalColumn: "EduID");
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    TID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Weekday = table.Column<string>(type: "TEXT", nullable: false),
                    StartTimeTimeID = table.Column<int>(type: "INTEGER", nullable: false),
                    EndTimeTimeID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.TID);
                    table.ForeignKey(
                        name: "FK_Tasks_Time_EndTimeTimeID",
                        column: x => x.EndTimeTimeID,
                        principalTable: "Time",
                        principalColumn: "TimeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_Time_StartTimeTimeID",
                        column: x => x.StartTimeTimeID,
                        principalTable: "Time",
                        principalColumn: "TimeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SectionTAs",
                columns: table => new
                {
                    SecTAID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SectionID = table.Column<int>(type: "INTEGER", nullable: false),
                    TAID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionTAs", x => x.SecTAID);
                    table.ForeignKey(
                        name: "FK_SectionTAs_Educators_TAID",
                        column: x => x.TAID,
                        principalTable: "Educators",
                        principalColumn: "EduID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SectionTAs_Sections_SectionID",
                        column: x => x.SectionID,
                        principalTable: "Sections",
                        principalColumn: "SectionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TATasks",
                columns: table => new
                {
                    TATaskID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EduID = table.Column<int>(type: "INTEGER", nullable: false),
                    TID = table.Column<int>(type: "INTEGER", nullable: false),
                    date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Cancel = table.Column<bool>(type: "INTEGER", nullable: false),
                    TAEduID = table.Column<int>(type: "INTEGER", nullable: true),
                    TaskTID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TATasks", x => x.TATaskID);
                    table.ForeignKey(
                        name: "FK_TATasks_Educators_TAEduID",
                        column: x => x.TAEduID,
                        principalTable: "Educators",
                        principalColumn: "EduID");
                    table.ForeignKey(
                        name: "FK_TATasks_Tasks_TaskTID",
                        column: x => x.TaskTID,
                        principalTable: "Tasks",
                        principalColumn: "TID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Requests_TAEduID",
                table: "Requests",
                column: "TAEduID");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_CourseID",
                table: "Sections",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionTAs_SectionID",
                table: "SectionTAs",
                column: "SectionID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionTAs_TAID",
                table: "SectionTAs",
                column: "TAID");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_EndTimeTimeID",
                table: "Tasks",
                column: "EndTimeTimeID");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_StartTimeTimeID",
                table: "Tasks",
                column: "StartTimeTimeID");

            migrationBuilder.CreateIndex(
                name: "IX_TATasks_TAEduID",
                table: "TATasks",
                column: "TAEduID");

            migrationBuilder.CreateIndex(
                name: "IX_TATasks_TaskTID",
                table: "TATasks",
                column: "TaskTID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "SectionTAs");

            migrationBuilder.DropTable(
                name: "TATasks");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "Educators");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Time");
        }
    }
}
