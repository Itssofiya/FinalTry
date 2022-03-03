using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSeeker.DataLayer.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Contact = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    IdProofNumber = table.Column<string>(nullable: true),
                    Enabled = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobSeekerSessions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sessionid = table.Column<int>(nullable: false),
                    MentorId = table.Column<int>(nullable: false),
                    JobseekerId = table.Column<int>(nullable: false),
                    JobSeekerName = table.Column<string>(nullable: true),
                    CourseId = table.Column<int>(nullable: false),
                    CourseName = table.Column<string>(nullable: true),
                    RequestedSessionId = table.Column<int>(nullable: false),
                    RequestedSessionDate = table.Column<DateTime>(nullable: false),
                    RequestedSessionCourse = table.Column<string>(nullable: true),
                    Missedsessionid = table.Column<int>(nullable: false),
                    MissedSessionDate = table.Column<DateTime>(nullable: false),
                    MissedSessionCourse = table.Column<string>(nullable: true),
                    MissedReason = table.Column<string>(nullable: true),
                    Attendedsessisonid = table.Column<int>(nullable: false),
                    AttendedCourse = table.Column<string>(nullable: true),
                    AttendedSessionDate = table.Column<DateTime>(nullable: false),
                    PaidAmount = table.Column<double>(nullable: false),
                    Sessionstart = table.Column<DateTime>(nullable: false),
                    Sessionend = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSeekerSessions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobSeekerSkills",
                columns: table => new
                {
                    SId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillId = table.Column<int>(nullable: false),
                    JobSeekerId = table.Column<int>(nullable: false),
                    Qualification = table.Column<string>(nullable: true),
                    SkillAreas = table.Column<string>(nullable: true),
                    SkillExperience = table.Column<string>(nullable: true),
                    UpdeatedDate = table.Column<DateTime>(nullable: false),
                    ExpectedSalary = table.Column<long>(nullable: false),
                    PreferdLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSeekerSkills", x => x.SId);
                });

            migrationBuilder.CreateTable(
                name: "JSCourses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(nullable: false),
                    MentorId = table.Column<int>(nullable: false),
                    JobSeekerId = table.Column<int>(nullable: false),
                    JobSeekerName = table.Column<string>(nullable: true),
                    CourseName = table.Column<string>(nullable: true),
                    RequestedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JSCourses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JSJobs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobId = table.Column<int>(nullable: false),
                    JobSeekerId = table.Column<int>(nullable: false),
                    AppliedJobs = table.Column<int>(nullable: false),
                    Jobappliedfor = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    AppliedDate = table.Column<DateTime>(nullable: false),
                    Jobtypes = table.Column<string>(nullable: true),
                    JobTitle = table.Column<string>(nullable: true),
                    Joblocation = table.Column<string>(nullable: true),
                    WorkPLace = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JSJobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JSProfiles",
                columns: table => new
                {
                    ProfileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobSeekerId = table.Column<int>(nullable: false),
                    JobSeekerName = table.Column<string>(nullable: true),
                    TotalExperience = table.Column<decimal>(nullable: false),
                    RelevantExp = table.Column<decimal>(nullable: false),
                    NoticePeriod = table.Column<int>(nullable: false),
                    AvailableFrom = table.Column<DateTime>(nullable: false),
                    AvailableTo = table.Column<DateTime>(nullable: false),
                    CurrentEmployer = table.Column<string>(nullable: true),
                    CurrentLocation = table.Column<string>(nullable: true),
                    PrefferdLocation = table.Column<string>(nullable: true),
                    CostToCompany = table.Column<decimal>(nullable: false),
                    EmployeerCtC = table.Column<decimal>(nullable: false),
                    Skills = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    AddedBy = table.Column<string>(nullable: true),
                    AddedOn = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JSProfiles", x => x.ProfileId);
                });

            migrationBuilder.CreateTable(
                name: "JSRegistrations",
                columns: table => new
                {
                    RID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Mobile = table.Column<long>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JSRegistrations", x => x.RID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "JobSeekerSessions");

            migrationBuilder.DropTable(
                name: "JobSeekerSkills");

            migrationBuilder.DropTable(
                name: "JSCourses");

            migrationBuilder.DropTable(
                name: "JSJobs");

            migrationBuilder.DropTable(
                name: "JSProfiles");

            migrationBuilder.DropTable(
                name: "JSRegistrations");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
