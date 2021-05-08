using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asserts",
                columns: table => new
                {
                    AssertID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asserts", x => x.AssertID);
                });

            migrationBuilder.CreateTable(
                name: "BankAccountTypes",
                columns: table => new
                {
                    BankAccountTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccountTypes", x => x.BankAccountTypeID);
                });

            migrationBuilder.CreateTable(
                name: "ContactTypes",
                columns: table => new
                {
                    ContactTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactTypes", x => x.ContactTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseID);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    CurrencyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.CurrencyID);
                });

            migrationBuilder.CreateTable(
                name: "CustomSettingTypes",
                columns: table => new
                {
                    CustomSettingTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomSettingTypes", x => x.CustomSettingTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "DocumentFormats",
                columns: table => new
                {
                    DocumentFormatID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentFormats", x => x.DocumentFormatID);
                });

            migrationBuilder.CreateTable(
                name: "EmailTypes",
                columns: table => new
                {
                    EmailTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTypes", x => x.EmailTypeID);
                });

            migrationBuilder.CreateTable(
                name: "ErrorLogging",
                columns: table => new
                {
                    ErrorLogID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SourceID = table.Column<int>(nullable: false),
                    StackTrace = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    LoggedBy = table.Column<string>(nullable: true),
                    DateGenerated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorLogging", x => x.ErrorLogID);
                });

            migrationBuilder.CreateTable(
                name: "FeatureFlags",
                columns: table => new
                {
                    FeatureFlagID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureFlags", x => x.FeatureFlagID);
                });

            migrationBuilder.CreateTable(
                name: "Frequencies",
                columns: table => new
                {
                    FrequencyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frequencies", x => x.FrequencyID);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    GenderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.GenderID);
                });

            migrationBuilder.CreateTable(
                name: "MenuGroups",
                columns: table => new
                {
                    MenuGroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    DisplayName = table.Column<string>(nullable: true),
                    ControllerName = table.Column<string>(nullable: true),
                    ActionName = table.Column<string>(nullable: true),
                    CSSClass = table.Column<string>(nullable: true),
                    OrderNo = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsActiveMenu = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuGroups", x => x.MenuGroupID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentStatus",
                columns: table => new
                {
                    PaymentStatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentStatus", x => x.PaymentStatusID);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    PermissionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.PermissionID);
                });

            migrationBuilder.CreateTable(
                name: "PriorityRanks",
                columns: table => new
                {
                    PriorityRankID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriorityRanks", x => x.PriorityRankID);
                });

            migrationBuilder.CreateTable(
                name: "RelationshipTypes",
                columns: table => new
                {
                    RelationshipTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelationshipTypes", x => x.RelationshipTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "StatementLists",
                columns: table => new
                {
                    StatementID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatementLists", x => x.StatementID);
                });

            migrationBuilder.CreateTable(
                name: "SystemVariableTypes",
                columns: table => new
                {
                    CustomVariableTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemVariableTypes", x => x.CustomVariableTypeID);
                });

            migrationBuilder.CreateTable(
                name: "TransactionStatus",
                columns: table => new
                {
                    TransactionStatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionStatus", x => x.TransactionStatusID);
                });

            migrationBuilder.CreateTable(
                name: "UserTypes",
                columns: table => new
                {
                    UserTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypes", x => x.UserTypeID);
                });

            migrationBuilder.CreateTable(
                name: "WeekDays",
                columns: table => new
                {
                    WeekDayID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeekDays", x => x.WeekDayID);
                });

            migrationBuilder.CreateTable(
                name: "AssertCategories",
                columns: table => new
                {
                    AssertCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    AssertID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssertCategories", x => x.AssertCategoryID);
                    table.ForeignKey(
                        name: "FK_AssertCategories_Asserts_AssertID",
                        column: x => x.AssertID,
                        principalTable: "Asserts",
                        principalColumn: "AssertID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    CountryID = table.Column<int>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CompanyLogo = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyID);
                    table.ForeignKey(
                        name: "FK_Companies_Countries_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseOutlines",
                columns: table => new
                {
                    CourseOutlineID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    CourseID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseOutlines", x => x.CourseOutlineID);
                    table.ForeignKey(
                        name: "FK_CourseOutlines_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BankAccounts",
                columns: table => new
                {
                    BankAccountID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    BankAccountTypeID = table.Column<int>(nullable: false),
                    AccountCode = table.Column<string>(nullable: true),
                    AccountName = table.Column<string>(nullable: true),
                    AccountNumber = table.Column<string>(nullable: true),
                    CurrencyID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccounts", x => x.BankAccountID);
                    table.ForeignKey(
                        name: "FK_BankAccounts_BankAccountTypes_BankAccountTypeID",
                        column: x => x.BankAccountTypeID,
                        principalTable: "BankAccountTypes",
                        principalColumn: "BankAccountTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BankAccounts_Currencies_CurrencyID",
                        column: x => x.CurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "CurrencyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    DocumentTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    DocumentFormatID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.DocumentTypeID);
                    table.ForeignKey(
                        name: "FK_DocumentTypes_DocumentFormats_DocumentFormatID",
                        column: x => x.DocumentFormatID,
                        principalTable: "DocumentFormats",
                        principalColumn: "DocumentFormatID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseFeeHistory",
                columns: table => new
                {
                    CourseFeeHistoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CourseFeeID = table.Column<int>(nullable: false),
                    CourseID = table.Column<int>(nullable: false),
                    FrequencyID = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseFeeHistory", x => x.CourseFeeHistoryID);
                    table.ForeignKey(
                        name: "FK_CourseFeeHistory_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseFeeHistory_Frequencies_FrequencyID",
                        column: x => x.FrequencyID,
                        principalTable: "Frequencies",
                        principalColumn: "FrequencyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseFees",
                columns: table => new
                {
                    CourseFeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CourseID = table.Column<int>(nullable: false),
                    FrequencyID = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseFees", x => x.CourseFeeID);
                    table.ForeignKey(
                        name: "FK_CourseFees_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseFees_Frequencies_FrequencyID",
                        column: x => x.FrequencyID,
                        principalTable: "Frequencies",
                        principalColumn: "FrequencyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    MenuGroupID = table.Column<int>(nullable: false),
                    DisplayName = table.Column<string>(nullable: true),
                    ControllerName = table.Column<string>(nullable: true),
                    ActionName = table.Column<string>(nullable: true),
                    CSSClass = table.Column<string>(nullable: true),
                    OrderNo = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuID);
                    table.ForeignKey(
                        name: "FK_Menus_MenuGroups_MenuGroupID",
                        column: x => x.MenuGroupID,
                        principalTable: "MenuGroups",
                        principalColumn: "MenuGroupID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmailTemplates",
                columns: table => new
                {
                    EmailTemplateID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    EmailTypeID = table.Column<int>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    PriorityRankID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTemplates", x => x.EmailTemplateID);
                    table.ForeignKey(
                        name: "FK_EmailTemplates_EmailTypes_EmailTypeID",
                        column: x => x.EmailTypeID,
                        principalTable: "EmailTypes",
                        principalColumn: "EmailTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmailTemplates_PriorityRanks_PriorityRankID",
                        column: x => x.PriorityRankID,
                        principalTable: "PriorityRanks",
                        principalColumn: "PriorityRankID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NoticeBoard",
                columns: table => new
                {
                    NoticeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: false),
                    Details = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    PriorityRankID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoticeBoard", x => x.NoticeID);
                    table.ForeignKey(
                        name: "FK_NoticeBoard_PriorityRanks_PriorityRankID",
                        column: x => x.PriorityRankID,
                        principalTable: "PriorityRanks",
                        principalColumn: "PriorityRankID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                columns: table => new
                {
                    RolePermissionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    PermissionID = table.Column<int>(nullable: false),
                    RoleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => x.RolePermissionID);
                    table.ForeignKey(
                        name: "FK_RolePermissions_Permissions_PermissionID",
                        column: x => x.PermissionID,
                        principalTable: "Permissions",
                        principalColumn: "PermissionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermissions_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomSettings",
                columns: table => new
                {
                    CustomSettingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CustomVariableTypeID = table.Column<int>(nullable: false),
                    CustomSettingTypeID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomSettings", x => x.CustomSettingID);
                    table.ForeignKey(
                        name: "FK_CustomSettings_CustomSettingTypes_CustomSettingTypeID",
                        column: x => x.CustomSettingTypeID,
                        principalTable: "CustomSettingTypes",
                        principalColumn: "CustomSettingTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomSettings_SystemVariableTypes_CustomVariableTypeID",
                        column: x => x.CustomVariableTypeID,
                        principalTable: "SystemVariableTypes",
                        principalColumn: "CustomVariableTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransactionType",
                columns: table => new
                {
                    TransactionTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    TransactionStatusID = table.Column<int>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionType", x => x.TransactionTypeID);
                    table.ForeignKey(
                        name: "FK_TransactionType_TransactionStatus_TransactionStatusID",
                        column: x => x.TransactionStatusID,
                        principalTable: "TransactionStatus",
                        principalColumn: "TransactionStatusID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    UserTypeID = table.Column<int>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    IDNumber = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    PasswordExpiryDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Users_UserTypes_UserTypeID",
                        column: x => x.UserTypeID,
                        principalTable: "UserTypes",
                        principalColumn: "UserTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ProductCode = table.Column<string>(nullable: true),
                    DeductionPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IncreamentPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CompanyID = table.Column<int>(nullable: false),
                    CountryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Countries_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleMenus",
                columns: table => new
                {
                    RoleMenuID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    MenuID = table.Column<int>(nullable: false),
                    RoleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleMenus", x => x.RoleMenuID);
                    table.ForeignKey(
                        name: "FK_RoleMenus_Menus_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menus",
                        principalColumn: "MenuID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleMenus_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAuthenticationCodes",
                columns: table => new
                {
                    UserPinID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(nullable: false),
                    PinCode = table.Column<string>(nullable: true),
                    DateRequested = table.Column<DateTime>(nullable: false),
                    ExpiryDate = table.Column<DateTime>(nullable: false),
                    IsAccountCreation = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAuthenticationCodes", x => x.UserPinID);
                    table.ForeignKey(
                        name: "FK_UserAuthenticationCodes_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false),
                    RoleID = table.Column<int>(nullable: false),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    UserRoleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserID, x.RoleID });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    AccountNumber = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    IDNumber = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    CountryID = table.Column<int>(nullable: true),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    GenderID = table.Column<int>(nullable: false),
                    DepartmentID = table.Column<int>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientID);
                    table.ForeignKey(
                        name: "FK_Clients_Countries_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clients_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clients_Genders_GenderID",
                        column: x => x.GenderID,
                        principalTable: "Genders",
                        principalColumn: "GenderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_Products_ProductID1",
                        column: x => x.ProductID1,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductAssertCategory",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    ProductID = table.Column<int>(nullable: false),
                    AssertCategoryID = table.Column<int>(nullable: false),
                    DateRegistered = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAssertCategory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductAssertCategory_AssertCategories_AssertCategoryID",
                        column: x => x.AssertCategoryID,
                        principalTable: "AssertCategories",
                        principalColumn: "AssertCategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductAssertCategory_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductAsserts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    ProductID = table.Column<int>(nullable: false),
                    AssertID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAsserts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductAsserts_Asserts_AssertID",
                        column: x => x.AssertID,
                        principalTable: "Asserts",
                        principalColumn: "AssertID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductAsserts_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductFeeHistory",
                columns: table => new
                {
                    ProductFeeHistoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ProductFeeID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    FrequencyID = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeeHistory", x => x.ProductFeeHistoryID);
                    table.ForeignKey(
                        name: "FK_ProductFeeHistory_Frequencies_FrequencyID",
                        column: x => x.FrequencyID,
                        principalTable: "Frequencies",
                        principalColumn: "FrequencyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductFeeHistory_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductFees",
                columns: table => new
                {
                    ProductFeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ProductID = table.Column<int>(nullable: false),
                    FrequencyID = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFees", x => x.ProductFeeID);
                    table.ForeignKey(
                        name: "FK_ProductFees_Frequencies_FrequencyID",
                        column: x => x.FrequencyID,
                        principalTable: "Frequencies",
                        principalColumn: "FrequencyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductFees_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductHistory",
                columns: table => new
                {
                    ProductHistoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    ProductID = table.Column<int>(nullable: false),
                    DeductionPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IncreamentPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductHistory", x => x.ProductHistoryID);
                    table.ForeignKey(
                        name: "FK_ProductHistory_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientContacts",
                columns: table => new
                {
                    ClientContactID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    ClientID = table.Column<int>(nullable: false),
                    ContactTypeID = table.Column<int>(nullable: false),
                    ContactPerson = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true),
                    RelationshipTypeID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientContacts", x => x.ClientContactID);
                    table.ForeignKey(
                        name: "FK_ClientContacts_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientContacts_ContactTypes_ContactTypeID",
                        column: x => x.ContactTypeID,
                        principalTable: "ContactTypes",
                        principalColumn: "ContactTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientContacts_RelationshipTypes_RelationshipTypeID",
                        column: x => x.RelationshipTypeID,
                        principalTable: "RelationshipTypes",
                        principalColumn: "RelationshipTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientCourses",
                columns: table => new
                {
                    ClientCourseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    ClientID = table.Column<int>(nullable: false),
                    CourseID = table.Column<int>(nullable: false),
                    DateRegistered = table.Column<DateTime>(nullable: false),
                    DateCompleted = table.Column<DateTime>(nullable: true),
                    IsDeRegistered = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientCourses", x => x.ClientCourseID);
                    table.ForeignKey(
                        name: "FK_ClientCourses_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientCourses_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientDeductions",
                columns: table => new
                {
                    ClientDeductionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    ClientID = table.Column<int>(nullable: false),
                    InvoiceNumber = table.Column<int>(nullable: false),
                    ClientProductID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    DeductedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeductionPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AdditionalDeductionPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalDeductionPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InvoiceDate = table.Column<DateTime>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    DatePaid = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientDeductions", x => x.ClientDeductionID);
                    table.ForeignKey(
                        name: "FK_ClientDeductions_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientDeductions_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientDependents",
                columns: table => new
                {
                    ClientDependentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    ClientID = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    IDNumber = table.Column<string>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    GenderID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientDependents", x => x.ClientDependentID);
                    table.ForeignKey(
                        name: "FK_ClientDependents_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientDocuments",
                columns: table => new
                {
                    ClientDocumentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    DocumentTypeID = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    DateUploaded = table.Column<DateTime>(nullable: false),
                    UploadedBy = table.Column<string>(nullable: true),
                    FileBytes = table.Column<byte[]>(nullable: true),
                    FileType = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    ClientID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientDocuments", x => x.ClientDocumentID);
                    table.ForeignKey(
                        name: "FK_ClientDocuments_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientDocuments_DocumentTypes_DocumentTypeID",
                        column: x => x.DocumentTypeID,
                        principalTable: "DocumentTypes",
                        principalColumn: "DocumentTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientMedicalDetails",
                columns: table => new
                {
                    ClientMedicalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    ClientID = table.Column<int>(nullable: false),
                    Doctor = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    MedicalAid = table.Column<string>(nullable: true),
                    MedicalAidNo = table.Column<string>(nullable: true),
                    Allergies = table.Column<string>(nullable: true),
                    PrescribedMedication = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true),
                    Hospital = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientMedicalDetails", x => x.ClientMedicalID);
                    table.ForeignKey(
                        name: "FK_ClientMedicalDetails_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientNotes",
                columns: table => new
                {
                    ClientNoteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: false),
                    UserTypeID = table.Column<int>(nullable: false),
                    DateUploaded = table.Column<DateTime>(nullable: false),
                    DateClosed = table.Column<DateTime>(nullable: true),
                    DueDate = table.Column<DateTime>(nullable: false),
                    UploadedBy = table.Column<string>(nullable: true),
                    ClientID = table.Column<int>(nullable: false),
                    VisibleToAdminOnly = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientNotes", x => x.ClientNoteID);
                    table.ForeignKey(
                        name: "FK_ClientNotes_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientNotes_UserTypes_UserTypeID",
                        column: x => x.UserTypeID,
                        principalTable: "UserTypes",
                        principalColumn: "UserTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientOccupationHistory",
                columns: table => new
                {
                    ClientOccupationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    ClientID = table.Column<int>(nullable: false),
                    Occupation = table.Column<string>(nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientOccupationHistory", x => x.ClientOccupationID);
                    table.ForeignKey(
                        name: "FK_ClientOccupationHistory_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientProducts",
                columns: table => new
                {
                    ClientProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    ClientID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientProducts", x => x.ClientProductID);
                    table.ForeignKey(
                        name: "FK_ClientProducts_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientProducts_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    TransRef = table.Column<string>(nullable: true),
                    Narration = table.Column<string>(nullable: true),
                    ClientID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: true),
                    CourseID = table.Column<int>(nullable: true),
                    AssertID = table.Column<int>(nullable: false),
                    AssertCategoryID = table.Column<int>(nullable: false),
                    BankAccountID = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Month = table.Column<int>(nullable: false),
                    TransactionTypeID = table.Column<int>(nullable: false),
                    PaymentStatusID = table.Column<int>(nullable: false),
                    ClientFeeID = table.Column<int>(nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountExclVAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(nullable: false),
                    TransactionDate = table.Column<DateTime>(nullable: false),
                    ParentPaymentID = table.Column<int>(nullable: true),
                    Reason = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_Transactions_BankAccounts_BankAccountID",
                        column: x => x.BankAccountID,
                        principalTable: "BankAccounts",
                        principalColumn: "BankAccountID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transactions_PaymentStatus_PaymentStatusID",
                        column: x => x.PaymentStatusID,
                        principalTable: "PaymentStatus",
                        principalColumn: "PaymentStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transactions_TransactionType_TransactionTypeID",
                        column: x => x.TransactionTypeID,
                        principalTable: "TransactionType",
                        principalColumn: "TransactionTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientFees",
                columns: table => new
                {
                    ClientFeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    ClientID = table.Column<int>(nullable: false),
                    ClientProductID = table.Column<int>(nullable: true),
                    ProductFeeID = table.Column<int>(nullable: true),
                    ClientCourseID = table.Column<int>(nullable: true),
                    CourseFeeID = table.Column<int>(nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    DatePaid = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientFees", x => x.ClientFeeID);
                    table.ForeignKey(
                        name: "FK_ClientFees_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientFees_CourseFees_CourseFeeID",
                        column: x => x.CourseFeeID,
                        principalTable: "CourseFees",
                        principalColumn: "CourseFeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientFees_ProductFees_ProductFeeID",
                        column: x => x.ProductFeeID,
                        principalTable: "ProductFees",
                        principalColumn: "ProductFeeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClientTranscripts",
                columns: table => new
                {
                    ClientTranscriptID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    ClientCourseID = table.Column<int>(nullable: false),
                    CourseOutlineID = table.Column<int>(nullable: false),
                    DateRegistered = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTranscripts", x => x.ClientTranscriptID);
                    table.ForeignKey(
                        name: "FK_ClientTranscripts_ClientCourses_ClientCourseID",
                        column: x => x.ClientCourseID,
                        principalTable: "ClientCourses",
                        principalColumn: "ClientCourseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BankAccountTypes",
                columns: new[] { "BankAccountTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 563, DateTimeKind.Local).AddTicks(5482), "Savings" },
                    { 2, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 563, DateTimeKind.Local).AddTicks(5875), "Cheque" },
                    { 3, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 563, DateTimeKind.Local).AddTicks(5883), "Credit" },
                    { 4, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 563, DateTimeKind.Local).AddTicks(5886), "Cash" }
                });

            migrationBuilder.InsertData(
                table: "ContactTypes",
                columns: new[] { "ContactTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 4, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 574, DateTimeKind.Local).AddTicks(45), "Cell Phone" },
                    { 3, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 574, DateTimeKind.Local).AddTicks(171), "Email Address" },
                    { 2, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 574, DateTimeKind.Local).AddTicks(179), "Postal Address" },
                    { 1, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 574, DateTimeKind.Local).AddTicks(184), "Residential Address" },
                    { 5, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 574, DateTimeKind.Local).AddTicks(189), "Telephone" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 156, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7149), "Norway" },
                    { 155, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7145), "N Mariana Islands" },
                    { 154, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7140), "Nigeria" },
                    { 153, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7137), "Niger" },
                    { 152, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7133), "Nicaragua" },
                    { 147, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7111), "Nepal" },
                    { 149, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7120), "Netherlands Antilles" },
                    { 148, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7115), "Netherlands" },
                    { 157, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7153), "Oman" },
                    { 146, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7107), "Nauru" },
                    { 151, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7129), "New Zealand" },
                    { 158, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7157), "Pakistan" },
                    { 162, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7173), "Paraguay" },
                    { 160, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7164), "Panama" },
                    { 161, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7169), "Papua New Guinea" },
                    { 145, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7104), "Namibia" },
                    { 163, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7176), "Peru" },
                    { 164, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7180), "Philippines" },
                    { 165, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7184), "Poland" },
                    { 166, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7187), "Portugal" },
                    { 167, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7191), "Puerto Rico" },
                    { 168, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7195), "Qatar" },
                    { 169, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7199), "Reunion" },
                    { 170, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7203), "Romania" },
                    { 159, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7160), "Palau" },
                    { 144, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7100), "Mozambique" },
                    { 139, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7079), "Moldova" },
                    { 142, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7089), "Montserrat" },
                    { 117, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6984), "Lebanon" },
                    { 118, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6988), "Lesotho" },
                    { 119, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6991), "Liberia" },
                    { 120, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6995), "Libya" },
                    { 121, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6998), "Liechtenstein" },
                    { 122, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7002), "Lithuania" },
                    { 123, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7006), "Luxembourg" },
                    { 124, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7010), "Macau" },
                    { 125, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7014), "Macedonia" },
                    { 126, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7017), "Madagascar" },
                    { 127, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7021), "Malawi" },
                    { 128, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7025), "Malaysia" },
                    { 129, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7028), "Maldives" },
                    { 130, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7042), "Mali" },
                    { 131, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7046), "Malta" },
                    { 132, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7051), "Marshall Islands" },
                    { 133, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7055), "Martinique" },
                    { 134, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7058), "Mauritania" },
                    { 135, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7062), "Mauritius" },
                    { 136, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7066), "Mayotte" },
                    { 137, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7070), "Mexico" },
                    { 138, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7075), "Micronesia Fed St" },
                    { 171, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7206), "Russia" },
                    { 140, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7082), "Monaco" },
                    { 141, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7086), "Mongolia" },
                    { 143, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7095), "Morocco" },
                    { 172, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7210), "Rwanda" },
                    { 177, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7235), "Saint Vincent and the Grenadines" },
                    { 174, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7220), "Saint Kitts Nevis" },
                    { 204, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7434), "Togo" },
                    { 205, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7438), "Tonga" },
                    { 206, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7443), "Trinidad Tobago" },
                    { 207, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7446), "Tunisia" },
                    { 208, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7450), "Turkey" },
                    { 209, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7454), "Turkmenistan" },
                    { 210, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7459), "Turks Caicos Is" },
                    { 211, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7462), "Tuvalu" },
                    { 212, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7466), "Uganda" },
                    { 213, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7470), "Ukraine" },
                    { 214, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7474), "United Arab Emirates" },
                    { 215, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7479), "United Kingdom" },
                    { 216, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7483), "United States" },
                    { 217, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7487), "Uruguay" },
                    { 218, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7491), "Uzbekistan" },
                    { 219, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7495), "Vanuatu" },
                    { 220, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7498), "Venezuela" },
                    { 221, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7502), "Vietnam" },
                    { 222, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7506), "Virgin Islands" },
                    { 223, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7511), "Wallis Futuna" },
                    { 224, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7515), "West Bank" },
                    { 225, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7519), "Western Sahara" },
                    { 226, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7523), "Yemen" },
                    { 227, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7527), "Zambia" },
                    { 228, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7530), "Zimbabwe" },
                    { 203, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7431), "Thailand" },
                    { 173, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7215), "Saint Helena" },
                    { 202, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7427), "Tanzania" },
                    { 200, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7419), "Taiwan" },
                    { 175, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7224), "Saint Lucia" },
                    { 176, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7229), "St Pierre Miquelon" },
                    { 116, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6980), "Latvia" },
                    { 178, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7239), "Samoa" },
                    { 179, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7243), "San Marino" },
                    { 180, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7248), "Sao Tome Principe" },
                    { 181, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7252), "Saudi Arabia" },
                    { 182, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7256), "Senegal" },
                    { 183, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7260), "Serbia" },
                    { 184, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7264), "Seychelles" },
                    { 185, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7268), "Sierra Leone" },
                    { 186, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7272), "Singapore" },
                    { 187, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7276), "Slovakia" },
                    { 188, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7371), "Slovenia" },
                    { 189, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7377), "Solomon Islands" },
                    { 190, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7380), "Somalia" },
                    { 191, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7385), "South Africa" },
                    { 192, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7388), "Spain" },
                    { 193, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7393), "Sri Lanka" },
                    { 194, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7397), "Sudan" },
                    { 195, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7400), "Suriname" },
                    { 196, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7404), "Swaziland" },
                    { 197, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7408), "Sweden" },
                    { 198, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7412), "Switzerland" },
                    { 199, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7415), "Syria" },
                    { 201, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7423), "Tajikistan" },
                    { 115, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6976), "Laos" },
                    { 150, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(7124), "New Caledonia" },
                    { 113, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6968), "Kuwait" },
                    { 30, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6623), "British Virgin Is" },
                    { 31, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6626), "Brunei" },
                    { 32, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6630), "Bulgaria" },
                    { 33, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6635), "Burkina Faso" },
                    { 34, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6641), "Burma" },
                    { 35, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6645), "Burundi" },
                    { 36, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6648), "Cambodia" },
                    { 37, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6652), "Cameroon" },
                    { 38, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6656), "Canada" },
                    { 39, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6661), "Cape Verde" },
                    { 40, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6665), "Cayman Islands" },
                    { 41, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6670), "Central African Rep" },
                    { 42, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6674), "Chad" },
                    { 43, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6678), "Chile" },
                    { 44, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6682), "China" },
                    { 45, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6686), "Colombia" },
                    { 46, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6689), "Comoros" },
                    { 47, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6694), "Congo Dem Rep" },
                    { 48, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6700), "Congo Repub of the" },
                    { 49, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6704), "Cook Islands" },
                    { 50, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6709), "Costa Rica" },
                    { 51, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6713), "Cote dIvoire" },
                    { 52, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6717), "Croatia" },
                    { 53, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6721), "Cuba" },
                    { 54, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6724), "Cyprus" },
                    { 29, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6617), "Brazil" },
                    { 55, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6730), "Czech Republic" },
                    { 28, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6613), "Botswana" },
                    { 26, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6604), "Bolivia" },
                    { 1, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6012), "Afghanistan" },
                    { 2, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6471), "Albania" },
                    { 3, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6480), "Algeria" },
                    { 4, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6491), "American Samoa" },
                    { 5, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6496), "Andorra" },
                    { 6, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6506), "Angola" },
                    { 7, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6510), "Anguilla" },
                    { 8, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6515), "Antigua Barbuda" },
                    { 9, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6519), "Argentina" },
                    { 10, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6524), "Armenia" },
                    { 11, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6527), "Aruba" },
                    { 12, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6547), "Australia" },
                    { 13, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6552), "Austria" },
                    { 14, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6555), "Azerbaijan" },
                    { 15, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6559), "Bahamas" },
                    { 16, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6564), " The" },
                    { 114, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6972), "Kyrgyzstan" },
                    { 18, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6574), "Bangladesh" },
                    { 19, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6578), "Barbados" },
                    { 20, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6582), "Belarus" },
                    { 21, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6586), "Belgium" },
                    { 22, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6590), "Belize" },
                    { 23, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6593), "Benin" },
                    { 24, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6597), "Bermuda" },
                    { 25, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6601), "Bhutan" },
                    { 27, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6609), "Bosnia Herzegovina" },
                    { 56, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6734), "Denmark" },
                    { 17, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6568), "Bahrain" },
                    { 58, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6742), "Dominica" },
                    { 88, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6873), "Guinea" },
                    { 89, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6878), "Guinea Bissau" },
                    { 90, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6881), "Guyana" },
                    { 91, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6885), "Haiti" },
                    { 92, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6888), "Honduras" },
                    { 93, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6893), "Hong Kong" },
                    { 94, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6896), "Hungary" },
                    { 95, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6900), "Iceland" },
                    { 96, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6903), "India" },
                    { 97, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6907), "Indonesia" },
                    { 98, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6911), "Iran" },
                    { 99, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6914), "Iraq" },
                    { 100, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6918), "Ireland" },
                    { 101, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6923), "Isle of Man" },
                    { 102, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6927), "Israel" },
                    { 103, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6930), "Italy" },
                    { 105, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6937), "Japan" },
                    { 106, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6941), "Jersey" },
                    { 107, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6945), "Jordan" },
                    { 108, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6949), "Kazakhstan" },
                    { 109, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6952), "Kenya" },
                    { 110, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6956), "Kiribati" },
                    { 111, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6960), "Korea North" },
                    { 112, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6965), "Korea South" },
                    { 57, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6737), "Djibouti" },
                    { 87, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6869), "Guernsey" },
                    { 86, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6866), "Guatemala" },
                    { 104, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6934), "Jamaica" },
                    { 84, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6858), "Guadeloupe" },
                    { 59, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6747), "Dominican Republic" },
                    { 85, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6861), "Guam" },
                    { 60, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6751), "East Timor" },
                    { 61, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6755), "Ecuador" },
                    { 62, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6759), "Egypt" },
                    { 63, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6764), "El Salvador" },
                    { 65, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6772), "Eritrea" },
                    { 66, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6788), "Estonia" },
                    { 67, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6791), "Ethiopia" },
                    { 68, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6796), "Faroe Islands" },
                    { 69, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6800), "Fiji" },
                    { 70, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6803), "Finland" },
                    { 71, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6807), "France" },
                    { 64, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6768), "Equatorial Guinea" },
                    { 73, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6817), "French Polynesia" },
                    { 72, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6812), "French Guiana" },
                    { 83, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6854), "Grenada" },
                    { 81, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6847), "Greece" },
                    { 80, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6843), "Gibraltar" },
                    { 82, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6851), "Greenland" },
                    { 79, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6840), "Ghana" },
                    { 77, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6833), "Georgia" },
                    { 76, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6829), "Gaza Strip" },
                    { 75, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6825), "Gambia The" },
                    { 74, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6820), "Gabon" },
                    { 78, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 581, DateTimeKind.Local).AddTicks(6836), "Germany" }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "CurrencyID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 106, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1140), "NZD" },
                    { 107, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1143), "OMR" },
                    { 105, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1137), "NPR" },
                    { 108, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1146), "PAB" },
                    { 109, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1149), "PEN" },
                    { 110, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1151), "PGK" },
                    { 111, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1154), "PHP" },
                    { 116, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1169), "RON" },
                    { 113, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1160), "PLN" },
                    { 114, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1164), "PYG" },
                    { 115, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1167), "QAR" },
                    { 117, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1173), "RSD" },
                    { 118, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1176), "RUB" },
                    { 120, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1181), "SAR" },
                    { 104, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1134), "NOK" },
                    { 119, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1178), "RWF" },
                    { 112, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1157), "PKR" },
                    { 103, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1130), "NIO" },
                    { 90, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1058), "MKD" },
                    { 101, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1123), "NAD" },
                    { 84, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1040), "LRD" },
                    { 121, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1185), "SBD" },
                    { 85, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1043), "LSL" },
                    { 86, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1046), "LYD" },
                    { 87, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1049), "MAD" },
                    { 88, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1052), "MDL" },
                    { 89, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1055), "MGA" },
                    { 91, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1061), "MMK" },
                    { 92, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1064), "MNT" },
                    { 93, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1067), "MOP" },
                    { 94, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1070), "MRU" },
                    { 95, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1073), "MUR" },
                    { 96, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1076), "MVR" },
                    { 97, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1079), "MWK" },
                    { 98, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1082), "MXN" },
                    { 99, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1085), "MYR" },
                    { 100, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1088), "MZN" },
                    { 102, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1127), "NGN" },
                    { 122, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1187), "SCR" },
                    { 150, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1275), "VEF" },
                    { 124, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1194), "SEK" },
                    { 146, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1263), "UGX" },
                    { 147, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1265), "USD" },
                    { 148, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1269), "UYU" },
                    { 149, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1271), "UZS" },
                    { 151, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1278), "VND" },
                    { 152, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1280), "VUV" },
                    { 153, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1283), "WST" },
                    { 154, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1286), "XAF" },
                    { 155, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1289), "XCD" },
                    { 156, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1292), "XDR" },
                    { 157, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1295), "XOF" },
                    { 158, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1298), "XPF" },
                    { 159, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1301), "YER" },
                    { 160, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1339), "ZAR" },
                    { 161, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1342), "ZMW" },
                    { 162, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1345), "ZWD" },
                    { 83, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1037), "LKR" },
                    { 145, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1260), "UAH" },
                    { 123, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1191), "SDG" },
                    { 144, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1256), "TZS" },
                    { 142, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1250), "TVD" },
                    { 125, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1197), "SGD" },
                    { 126, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1200), "SHP" },
                    { 127, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1203), "SLL" },
                    { 128, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1206), "SOS" },
                    { 129, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1209), "SPL" },
                    { 130, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1215), "SRD" },
                    { 131, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1218), "STN" },
                    { 132, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1221), "SVC" },
                    { 133, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1224), "SYP" },
                    { 134, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1227), "SZL" },
                    { 135, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1230), "THB" },
                    { 136, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1232), "TJS" },
                    { 137, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1235), "TMT" },
                    { 138, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1238), "TND" },
                    { 139, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1241), "TOP" },
                    { 140, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1244), "TRY" },
                    { 141, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1247), "TTD" },
                    { 143, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1254), "TWD" },
                    { 82, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1034), "LBP" },
                    { 55, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(950), "GYD" },
                    { 80, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1028), "KZT" },
                    { 22, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(699), "BTN" },
                    { 23, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(702), "BWP" },
                    { 24, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(705), "BYN" },
                    { 25, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(708), "BZD" },
                    { 26, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(711), "CAD" },
                    { 27, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(714), "CDF" },
                    { 28, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(717), "CHF" },
                    { 21, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(696), "BSD" },
                    { 29, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(720), "CLP" },
                    { 31, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(726), "COP" },
                    { 32, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(729), "CRC" },
                    { 33, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(732), "CUC" },
                    { 34, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(887), "CUP" },
                    { 35, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(890), "CVE" },
                    { 36, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(893), "CZK" },
                    { 37, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(896), "DJF" },
                    { 30, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(723), "CNY" },
                    { 20, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(693), "BRL" },
                    { 19, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(690), "BOB" },
                    { 18, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(687), "BND" },
                    { 81, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1030), "LAK" },
                    { 1, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(203), "AED" },
                    { 2, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(623), "AFN" },
                    { 3, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(631), "ALL" },
                    { 4, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(635), "AMD" },
                    { 5, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(638), "ANG" },
                    { 6, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(647), "AOA" },
                    { 7, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(650), "ARS" },
                    { 8, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(653), "AUD" },
                    { 10, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(660), "AZN" },
                    { 11, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(664), "BAM" },
                    { 12, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(667), "BBD" },
                    { 13, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(670), "BDT" },
                    { 14, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(673), "BGN" },
                    { 15, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(676), "BHD" },
                    { 16, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(679), "BIF" },
                    { 17, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(682), "BMD" },
                    { 38, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(899), "DKK" },
                    { 39, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(902), "DOP" },
                    { 9, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(656), "AWG" },
                    { 41, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(908), "EGP" },
                    { 63, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(975), "IMP" },
                    { 64, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(977), "INR" },
                    { 65, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(980), "IQD" },
                    { 66, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(986), "IRR" },
                    { 67, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(989), "ISK" },
                    { 68, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(992), "JEP" },
                    { 69, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(995), "JMD" },
                    { 62, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(972), "ILS" },
                    { 70, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(998), "JOD" },
                    { 71, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1001), "JPY" },
                    { 72, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1004), "KES" },
                    { 73, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1007), "KGS" },
                    { 74, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1010), "KHR" },
                    { 75, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1013), "KMF" },
                    { 76, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1016), "KPW" },
                    { 77, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1019), "KRW" },
                    { 79, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1025), "KYD" },
                    { 61, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(969), "IDR" },
                    { 60, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(965), "HUF" },
                    { 59, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(962), "HTG" },
                    { 42, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(912), "ERN" },
                    { 43, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(915), "ETB" },
                    { 44, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(918), "EUR" },
                    { 45, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(921), "FJD" },
                    { 46, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(924), "FKP" },
                    { 47, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(927), "GBP" },
                    { 48, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(930), "GEL" },
                    { 49, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(932), "GGP" },
                    { 50, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(935), "GHS" },
                    { 51, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(938), "GIP" },
                    { 52, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(941), "GMD" },
                    { 53, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(945), "GNF" },
                    { 54, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(948), "GTQ" },
                    { 40, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(905), "DZD" },
                    { 56, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(954), "HKD" },
                    { 57, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(956), "HNL" },
                    { 58, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(959), "HRK" },
                    { 78, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 566, DateTimeKind.Local).AddTicks(1022), "KWD" }
                });

            migrationBuilder.InsertData(
                table: "CustomSettingTypes",
                columns: new[] { "CustomSettingTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 3, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 575, DateTimeKind.Local).AddTicks(8261), "All" },
                    { 4, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 575, DateTimeKind.Local).AddTicks(8266), "Email" },
                    { 1, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 575, DateTimeKind.Local).AddTicks(8105), "BackEnd" },
                    { 2, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 575, DateTimeKind.Local).AddTicks(8254), "Portal" }
                });

            migrationBuilder.InsertData(
                table: "DocumentFormats",
                columns: new[] { "DocumentFormatID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 6, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 591, DateTimeKind.Local).AddTicks(6839), "ppt" },
                    { 5, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 591, DateTimeKind.Local).AddTicks(6827), "rtf" },
                    { 4, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 591, DateTimeKind.Local).AddTicks(6825), "txt" },
                    { 1, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 591, DateTimeKind.Local).AddTicks(6473), "pdf" },
                    { 2, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 591, DateTimeKind.Local).AddTicks(6814), "doc" },
                    { 3, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 591, DateTimeKind.Local).AddTicks(6821), "xlsx" }
                });

            migrationBuilder.InsertData(
                table: "EmailTypes",
                columns: new[] { "EmailTypeID", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 4, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 602, DateTimeKind.Local).AddTicks(6805), "New User Account Created" },
                    { 3, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 602, DateTimeKind.Local).AddTicks(6800), "Invoice" },
                    { 2, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 602, DateTimeKind.Local).AddTicks(6794), "Proof Of Payment" },
                    { 1, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 602, DateTimeKind.Local).AddTicks(6448), "Client Statement" }
                });

            migrationBuilder.InsertData(
                table: "FeatureFlags",
                columns: new[] { "FeatureFlagID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 3, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 589, DateTimeKind.Local).AddTicks(2887), "Enable Document Emailing Functionality" },
                    { 2, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 589, DateTimeKind.Local).AddTicks(2876), "CC Client On Error" },
                    { 1, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 589, DateTimeKind.Local).AddTicks(2419), "Send Email On Error" }
                });

            migrationBuilder.InsertData(
                table: "Frequencies",
                columns: new[] { "FrequencyID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 2, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 569, DateTimeKind.Local).AddTicks(9210), "Monthly" },
                    { 1, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 569, DateTimeKind.Local).AddTicks(8716), "Once Off" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 2, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 578, DateTimeKind.Local).AddTicks(1198), "Male" },
                    { 1, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 578, DateTimeKind.Local).AddTicks(983), "Female" }
                });

            migrationBuilder.InsertData(
                table: "MenuGroups",
                columns: new[] { "MenuGroupID", "ActionName", "CSSClass", "ControllerName", "DisplayName", "IsActive", "IsActiveMenu", "LastChangedBy", "LastChangedDate", "OrderNo" },
                values: new object[,]
                {
                    { 2, null, "fa fa-users", null, "Employees", true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 595, DateTimeKind.Local).AddTicks(9802), 2 },
                    { 3, null, "fa fa-money", null, "Product And Services", true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 595, DateTimeKind.Local).AddTicks(9814), 3 },
                    { 9998, null, "fa fa-university", null, "Menu", true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 595, DateTimeKind.Local).AddTicks(9831), 9998 },
                    { 1, "Dashboard", "fa fa-umbrella", "Home", "DashBoard", true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 595, DateTimeKind.Local).AddTicks(9681), 1 },
                    { 999, null, "fa fa-desktop", null, "Developer Menu", true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 595, DateTimeKind.Local).AddTicks(9837), 9999 },
                    { 4, null, "fa fa-area-chart", null, "Reporting", true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 595, DateTimeKind.Local).AddTicks(9819), 6 },
                    { 5, null, "fa fa-wrench", null, "Custom Settings", true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 595, DateTimeKind.Local).AddTicks(9824), 7 }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "PaymentStatusID", "Description", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, null, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 558, DateTimeKind.Local).AddTicks(1095), "Paid" },
                    { 2, null, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 558, DateTimeKind.Local).AddTicks(1485), "Reversed" },
                    { 3, null, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 558, DateTimeKind.Local).AddTicks(1493), "Pending" },
                    { 4, null, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 558, DateTimeKind.Local).AddTicks(1497), "Refunded" },
                    { 5, null, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 558, DateTimeKind.Local).AddTicks(1500), "Discounted" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "Description", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 75, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(123), "Add Course Fee" },
                    { 74, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(118), "View Course Fee" },
                    { 84, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(171), "Add Company" },
                    { 73, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(114), "View Course" },
                    { 82, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(163), "Delete Document Type" },
                    { 81, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(158), "Update Document Type" },
                    { 80, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(154), "Add Document Type" },
                    { 79, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(150), "View Custom Setting" },
                    { 78, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(146), "Update Custom Setting" },
                    { 77, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(142), "Delete Course Fee" },
                    { 83, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(167), "View Document Type" },
                    { 76, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(137), "Update Course Fee" },
                    { 72, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(110), "Delete Course" },
                    { 65, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(80), "Update Menu" },
                    { 70, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(103), "Add Course" },
                    { 69, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(99), "View Menu" },
                    { 68, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(95), "Delete Menu" },
                    { 67, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(91), "Deactivate Menu" },
                    { 66, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(87), "Activate Menu" },
                    { 64, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(77), "Add Menu" },
                    { 63, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(73), "Override Payment" },
                    { 62, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(69), "View Client Deductions" },
                    { 61, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(64), "Remove Invoice Entries" },
                    { 60, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(60), "Generate Invoices" },
                    { 59, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(56), "View Client Outstanding Payments" },
                    { 58, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(51), "View Payment" },
                    { 85, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(174), "Update Company" },
                    { 57, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(47), "Reverse Payment" },
                    { 71, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(107), "Update Course" },
                    { 86, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(178), "Delete Company" },
                    { 112, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(284), "View Product Assert" },
                    { 88, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(186), "Add Bank Account" },
                    { 116, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(300), "View Assert" },
                    { 115, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(296), "Delete Assert" },
                    { 114, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(292), "Update Assert" },
                    { 113, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(288), "Add Assert" },
                    { 56, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(43), "Capture Payment" },
                    { 111, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(281), "Update Product Assert" },
                    { 110, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(277), "Add Product Assert" },
                    { 109, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(272), "View Product Fee" },
                    { 108, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(268), "Delete Product Fee" },
                    { 107, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(264), "Update Product Fee" },
                    { 106, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(260), "Add Product Fee" },
                    { 105, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(256), "View Transaction Type" },
                    { 104, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(251), "Update Transaction Type" },
                    { 87, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(182), "View Company" },
                    { 103, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(247), "Client Update Personal Details" },
                    { 101, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(237), "Update Currency" },
                    { 100, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(234), "Update Country" },
                    { 99, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(230), "View Notice" },
                    { 98, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(226), "Delete Notice" },
                    { 97, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(223), "Update Notice" },
                    { 96, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(219), "Add Notice" },
                    { 95, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(215), "View Email Template" },
                    { 94, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(210), "Delete Email Template" },
                    { 93, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(207), "Update Email Template" },
                    { 92, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(203), "Add Email Template" },
                    { 91, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(199), "View Bank Account" },
                    { 90, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(194), "Delete Bank Account" },
                    { 89, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(191), "Update Bank Account" },
                    { 102, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(242), "View Dashboard Notices" },
                    { 55, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(39), "View Department" },
                    { 11, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9832), "Add Client Note" },
                    { 53, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(31), "Update Department" },
                    { 24, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9888), "Update Client Dependent" },
                    { 23, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9883), "Add Client Dependent" },
                    { 22, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9879), "View Client Product" },
                    { 21, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9875), "Delete Client Product" },
                    { 20, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9871), "Update Client Product" },
                    { 19, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9867), "Add Client Product" },
                    { 18, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9863), "View Client Contact" },
                    { 17, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9857), "Delete Client Contact" },
                    { 16, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9853), "Update Client Contact" },
                    { 15, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9849), "Add Client Contact" },
                    { 14, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9844), "View Client Note" },
                    { 13, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9840), "Delete Client Note" },
                    { 12, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9836), "Update Client Note" },
                    { 10, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9827), "Change Client Password" },
                    { 9, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9821), "View Client" },
                    { 54, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(35), "Delete Department" },
                    { 7, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9812), "Update Client" },
                    { 6, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9808), "Add Client" },
                    { 5, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9799), "Change User Password" },
                    { 4, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9794), "View User" },
                    { 3, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9790), "Delete User" },
                    { 2, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9779), "Update User" },
                    { 1, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9353), "Add User" },
                    { 25, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9893), "Delete Client Dependent" },
                    { 26, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9897), "View Client Dependent" },
                    { 8, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9816), "Delete Client" },
                    { 28, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9906), "Update Client Course" },
                    { 27, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9902), "Add Client Course" },
                    { 52, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(26), "Add Department" },
                    { 51, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(22), "View Product" },
                    { 50, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(18), "Delete Product" },
                    { 49, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(15), "Update Product" },
                    { 47, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7), "Remove Menu From Role" },
                    { 46, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(2), "Add Menu To Role" },
                    { 45, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9997), "View Permissions" },
                    { 44, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9993), "Remove Permissions" },
                    { 43, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9989), "Add Permissions" },
                    { 42, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9984), "View Role" },
                    { 41, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9980), "Delete Role" },
                    { 48, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(11), "Add Product" },
                    { 39, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9972), "Add Role" },
                    { 40, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9977), "Update Role" },
                    { 30, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9916), "View Client Course" },
                    { 31, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9921), "Add Client Medical Details" },
                    { 29, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9911), "Delete Client Course" },
                    { 33, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9930), "Delete Client Medical Details" },
                    { 32, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9926), "Update Client Medical Details" },
                    { 34, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9937), "View Client Medical Details" },
                    { 35, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9941), "View Client Payments" },
                    { 36, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9959), "Generate Client Statement" },
                    { 37, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9963), "Client Upload Document" },
                    { 38, null, true, false, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 554, DateTimeKind.Local).AddTicks(9968), "Client View Document" }
                });

            migrationBuilder.InsertData(
                table: "PriorityRanks",
                columns: new[] { "PriorityRankID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 3, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 582, DateTimeKind.Local).AddTicks(8632), "Medium" },
                    { 2, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 582, DateTimeKind.Local).AddTicks(8626), "High" },
                    { 1, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 582, DateTimeKind.Local).AddTicks(8472), "Critical" },
                    { 4, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 582, DateTimeKind.Local).AddTicks(8636), "Low" }
                });

            migrationBuilder.InsertData(
                table: "RelationshipTypes",
                columns: new[] { "RelationshipTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 3, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 574, DateTimeKind.Local).AddTicks(8501), "Father" },
                    { 4, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 574, DateTimeKind.Local).AddTicks(8504), "Sibling" },
                    { 2, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 574, DateTimeKind.Local).AddTicks(8498), "Mother" },
                    { 6, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 574, DateTimeKind.Local).AddTicks(8515), "Other" },
                    { 1, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 574, DateTimeKind.Local).AddTicks(8310), "Self" },
                    { 5, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 574, DateTimeKind.Local).AddTicks(8506), "Spouse" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "Description", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, null, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 549, DateTimeKind.Local).AddTicks(20), "Super Admin" },
                    { 2, null, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 550, DateTimeKind.Local).AddTicks(3846), "Employee" },
                    { 3, null, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 550, DateTimeKind.Local).AddTicks(3904), "Administrator" }
                });

            migrationBuilder.InsertData(
                table: "StatementLists",
                columns: new[] { "StatementID", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 612, DateTimeKind.Local).AddTicks(9336), "Product Based Statement" },
                    { 2, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 612, DateTimeKind.Local).AddTicks(9673), "Transaction List" }
                });

            migrationBuilder.InsertData(
                table: "SystemVariableTypes",
                columns: new[] { "CustomVariableTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 3, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 577, DateTimeKind.Local).AddTicks(2675), "Long" },
                    { 1, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 577, DateTimeKind.Local).AddTicks(2514), "Boolean" },
                    { 5, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 577, DateTimeKind.Local).AddTicks(2664), "Double" },
                    { 4, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 577, DateTimeKind.Local).AddTicks(2671), "Integer" },
                    { 2, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 577, DateTimeKind.Local).AddTicks(2680), "String" },
                    { 6, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 577, DateTimeKind.Local).AddTicks(2691), "Decimal" },
                    { 7, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 577, DateTimeKind.Local).AddTicks(2700), "Date Time" },
                    { 8, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 577, DateTimeKind.Local).AddTicks(2705), "Password" },
                    { 9, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 577, DateTimeKind.Local).AddTicks(2709), "Percentage" }
                });

            migrationBuilder.InsertData(
                table: "TransactionStatus",
                columns: new[] { "TransactionStatusID", "Name" },
                values: new object[,]
                {
                    { 2, "Negative" },
                    { 1, "Positive" }
                });

            migrationBuilder.InsertData(
                table: "UserTypes",
                columns: new[] { "UserTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 572, DateTimeKind.Local).AddTicks(8406), "Administrator" },
                    { 2, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 572, DateTimeKind.Local).AddTicks(8828), "Employer" },
                    { 3, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 572, DateTimeKind.Local).AddTicks(8838), "Employee" }
                });

            migrationBuilder.InsertData(
                table: "WeekDays",
                columns: new[] { "WeekDayID", "Name" },
                values: new object[,]
                {
                    { 6, "Friday" },
                    { 1, "Sunday" },
                    { 2, "Monday" },
                    { 3, "Tuesday" },
                    { 4, "Wednesday" },
                    { 5, "Thursday" },
                    { 7, "Saturday" }
                });

            migrationBuilder.InsertData(
                table: "CustomSettings",
                columns: new[] { "CustomSettingID", "CustomSettingTypeID", "CustomVariableTypeID", "Description", "IsActive", "LastChangedBy", "LastChangedDate", "Name", "Value" },
                values: new object[,]
                {
                    { 3, 3, 1, "Allows system to hide exceptions and show custom error page to user", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(5903), "Show Custom Exceptions To Users", "true" },
                    { 12, 4, 2, "Display Sender Name As", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(5998), "Mail Display Name", "Smart Admin" },
                    { 17, 3, 2, "First Line on the Report Footer", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(6013), "Report Footer 1", "W. Guri Mrs. (Chairman), *E. Guri (Managing)" },
                    { 18, 3, 2, "Additional Line on the Report Footer (can be blank)", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(6018), "Report Footer 2", "*Executive." },
                    { 19, 3, 2, "Foot notes that you would like to include on your statement (not mandatory)", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(6023), "Report FootNotes", "" },
                    { 24, 3, 2, "Password Used to Open Password Protected Statement By System Administrators", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(6033), "Statement Password For Admin", "123456" },
                    { 28, 3, 2, "Site URL", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(6063), "Site URL", "https://localhost:5001" },
                    { 29, 3, 2, "Site Reset Password URL", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(6068), "Site Reset Password URL", "https://localhost:5001/Login/ForgotPasswordConfirmation" },
                    { 10, 4, 2, "Email Address used to email", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(5938), "Mail Credential User Name", "carolinesolutions89@gmail.com" },
                    { 30, 3, 2, "Customer Support Email", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(6072), "Site Customer Service Email", "carochire@gmail.com" },
                    { 32, 3, 2, "Default Email Addresss that overrides Client Email Address in a Test Environment ", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(6081), "Site Test Email Account", "carochire@gmail.com" },
                    { 35, 3, 2, "Site Client Create Account URL", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(6097), "Site Create Account URL", "https://localhost:5001/Login/CreateAccountConfirmation" },
                    { 14, 3, 6, "Maximum file size that can be uploaded to the System", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(6007), "File Maximum UpLoadable Size", "5" },
                    { 5, 3, 7, "Format Used to display date", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(5908), "Date Format", "yyyy-MMM-dd" },
                    { 39, 3, 7, "Format Used to display date time", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(5912), "Date Format", "yyyy-MMM-dd HH:mm" },
                    { 11, 4, 8, "Email Password", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(5993), "Mail Credential Password", "ZGNvaXpoeGlxenZ3dnphaw==" },
                    { 13, 3, 9, "Percentage To Which VAT is calculated on ", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(6002), "VAT Percentage", "0.14" },
                    { 31, 3, 2, "Customer Support Number", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(6076), "Site Customer Service Number", "0731143168" },
                    { 7, 4, 2, "Host used to Send Emails", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(5923), "Mail SMTP Host", "smtp.gmail.com" },
                    { 22, 3, 2, "Default Email Subject Name Used By Auto-Generated Emails", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(6047), "Mail Default Subject", "Smart Save  Admin" },
                    { 2, 3, 2, "Displays Current Version of the System", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(5858), "System Version", "1.0.0.0" },
                    { 8, 4, 1, "Enable SSL", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(5928), "Mail Enable SSL", "true" },
                    { 15, 3, 2, "Account Number Prefix if Any", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(5868), "Account Number Prefix", "SS" },
                    { 20, 3, 1, "Instructs the System to Advise User to Capture VAT inclusive amounts and calculate breakdown accordingly", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(6028), "Capture VAT Inclusive Payments", "true" },
                    { 23, 3, 1, "Allows to password protect statements being sent by Email", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(6038), "Statement Password Protect", "true" },
                    { 25, 3, 1, "Determines if table borders will be shown on the report ", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(6043), "Statement Show Table Boarders", "true" },
                    { 34, 3, 1, "Display menus based on User Role", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(6092), "Application Role Based Menus", "false" },
                    { 37, 3, 1, "Auto Generate Account Numbers", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(6106), "Account Number Auto Generate", "true" },
                    { 38, 3, 1, "Allows System To Be VAT Compliant and Show calculated VAT Amounts ", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(6112), "Application Is VAT Compliant", "false" },
                    { 9, 4, 1, "Use Default Mail Credentials", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(5933), "Mail Use Default Credentials", "false" },
                    { 6, 4, 4, "Port used to Send Emails", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(5917), "Mail SMTP Port", "587" },
                    { 26, 3, 4, "Password Reset Pin Code Length", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(6053), "Password Reset Pin Code Length", "5" },
                    { 4, 3, 4, "Limit Account Number Size", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(5864), "Account Number Length", "9" },
                    { 27, 3, 4, "Password Reset Pin Code Validity Period in Days", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(6058), "Password Reset Pin Validity", "2" },
                    { 33, 3, 4, "Current System Environment Set it to 1 For Test Environment  or 2 for Production Environment if no value has been set System defaults to Test Environment ", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(6086), "Site Default Environment", "1" },
                    { 36, 3, 4, "Password Validity Period in Days", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(6102), "Password Validity Period", "30" },
                    { 1, 3, 2, "Displayed as the Application Name", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(5662), "Application Name", "Smart Save" },
                    { 16, 3, 2, "Short Name for Application", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 607, DateTimeKind.Local).AddTicks(5851), "Application Name Prefix", "SS" }
                });

            migrationBuilder.InsertData(
                table: "DocumentTypes",
                columns: new[] { "DocumentTypeID", "DocumentFormatID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 3, 1, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 594, DateTimeKind.Local).AddTicks(618), "Proof Of Address" },
                    { 4, 1, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 594, DateTimeKind.Local).AddTicks(622), "Payslips" },
                    { 1, 1, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 593, DateTimeKind.Local).AddTicks(9796), "Identity Document" },
                    { 2, 1, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 594, DateTimeKind.Local).AddTicks(596), "Birth Certificate" }
                });

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "EmailTemplateID", "Body", "EmailTypeID", "LastChangedBy", "LastChangedDate", "PriorityRankID", "Subject" },
                values: new object[] { 1, @"Dear Customer, 

                        Attached is your Account statement. To view it you will need to open the PDF attachment and insert your password. Your password is your ID number. To view your statement you need to have Adobe PDF Reader installed. If you do not have it, you will need to do the following: - Copy and paste this URL into your browser: www.get.adobe.com/reader/?promoid=BUIGO - Go to the website - Click the download button and follow the easy instructions.


                        Regards,

                        Smart Saver", 1, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 603, DateTimeKind.Local).AddTicks(3036), 2, "Account Statement" });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuID", "ActionName", "CSSClass", "ControllerName", "DisplayName", "IsActive", "LastChangedBy", "LastChangedDate", "MenuGroupID", "OrderNo" },
                values: new object[,]
                {
                    { 13, "Assert", "fa fa-lightbulb-o", "Assert", "Asserts", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 598, DateTimeKind.Local).AddTicks(415), 5, 13 },
                    { 9999, "FeatureFlag", "fa fa-building", "FeatureFlag", "Feature Flags", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 598, DateTimeKind.Local).AddTicks(447), 999, 9999 },
                    { 9998, "MainMenu", "fa fa-book", "Menus", "Menu", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 598, DateTimeKind.Local).AddTicks(444), 9998, 9998 },
                    { 19, "Currency", "fa fa-money", "Currency", "Currency", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 598, DateTimeKind.Local).AddTicks(437), 5, 19 },
                    { 18, "DocumentTypes", "fa fa-file", "DocumentType", "Document Types", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 598, DateTimeKind.Local).AddTicks(434), 5, 18 },
                    { 17, "Department", "fa fa-building", "Department", "Departments", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 598, DateTimeKind.Local).AddTicks(429), 5, 17 },
                    { 16, "EmailTemplate", "fa fa-envelope-o", "EmailTemplate", "Email Templates", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 598, DateTimeKind.Local).AddTicks(426), 5, 16 },
                    { 15, "NoticeBoard", "fa broadcast-tower", "NoticeBoard", "Notice Board", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 598, DateTimeKind.Local).AddTicks(422), 5, 15 },
                    { 14, "BankAccounts", "fa fa-university", "BankAccounts", "Banks", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 598, DateTimeKind.Local).AddTicks(419), 5, 14 },
                    { 12, "TransactionType", "fa fa-money", "TransactionType", "Transaction Types", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 598, DateTimeKind.Local).AddTicks(412), 5, 12 },
                    { 20, "Country", "fa fa-globe", "Country", "Country", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 598, DateTimeKind.Local).AddTicks(440), 5, 20 },
                    { 10, "Courses", "fa fa-university", "Courses", "Coaching Programmes", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 598, DateTimeKind.Local).AddTicks(405), 5, 10 },
                    { 9, "Roles", "fa fa-asterisk", "Roles", "Roles & Permissions", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 598, DateTimeKind.Local).AddTicks(401), 5, 9 },
                    { 8, "Users", "fa fa-users", "User", "User Management", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 598, DateTimeKind.Local).AddTicks(397), 5, 8 },
                    { 7, "CustomSettings", "fa fa-spinner", "CustomSettings", "Application Settings", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 598, DateTimeKind.Local).AddTicks(393), 5, 7 },
                    { 6, "Product", "fa fa-star", "Product", "Products", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 598, DateTimeKind.Local).AddTicks(389), 3, 6 },
                    { 5, "ScheduleReport", "fa fa-file", "Transactions", "Generated Invoices", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 598, DateTimeKind.Local).AddTicks(381), 3, 5 },
                    { 4, "Schedule", "fa fa-gear", "Transactions", "Generate Bulk Invoice", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 598, DateTimeKind.Local).AddTicks(377), 3, 4 },
                    { 3, "Transactions", "fa fa-money", "Transactions", "Transactions", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 598, DateTimeKind.Local).AddTicks(374), 3, 2 },
                    { 2, "MyAccount", "fa fa-heart", "Client", "My Account", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 598, DateTimeKind.Local).AddTicks(369), 2, 0 },
                    { 1, "Clients", "fa fa-users", "Client", "Employees", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 598, DateTimeKind.Local).AddTicks(203), 2, 1 },
                    { 11, "Companies", "fa fa-building", "Company", "Companies", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 598, DateTimeKind.Local).AddTicks(409), 5, 11 }
                });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "RolePermissionID", "LastChangedBy", "LastChangedDate", "PermissionID", "RoleID" },
                values: new object[,]
                {
                    { 77, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7143), 77, 1 },
                    { 78, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7144), 78, 1 },
                    { 79, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7146), 79, 1 },
                    { 80, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7148), 80, 1 },
                    { 81, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7149), 81, 1 },
                    { 85, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7156), 85, 1 },
                    { 83, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7153), 83, 1 },
                    { 84, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7154), 84, 1 },
                    { 76, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7141), 76, 1 },
                    { 86, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7158), 86, 1 },
                    { 82, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7151), 82, 1 },
                    { 75, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7139), 75, 1 },
                    { 70, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7131), 70, 1 },
                    { 73, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7136), 73, 1 },
                    { 72, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7134), 72, 1 },
                    { 71, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7132), 71, 1 },
                    { 87, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7159), 87, 1 },
                    { 69, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7129), 69, 1 },
                    { 68, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7127), 68, 1 },
                    { 67, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7126), 67, 1 },
                    { 66, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7124), 66, 1 },
                    { 65, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7121), 65, 1 },
                    { 64, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7119), 64, 1 },
                    { 63, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7117), 63, 1 },
                    { 62, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7116), 62, 1 },
                    { 61, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7114), 61, 1 },
                    { 74, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7138), 74, 1 },
                    { 88, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7161), 88, 1 },
                    { 93, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7169), 93, 1 },
                    { 90, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7164), 90, 1 },
                    { 60, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7112), 60, 1 },
                    { 116, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7208), 116, 1 },
                    { 115, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7206), 115, 1 },
                    { 114, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7204), 114, 1 },
                    { 113, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7203), 113, 1 },
                    { 112, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7201), 112, 1 },
                    { 111, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7199), 111, 1 },
                    { 110, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7198), 110, 1 },
                    { 109, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7196), 109, 1 },
                    { 108, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7194), 108, 1 },
                    { 107, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7193), 107, 1 },
                    { 106, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7191), 106, 1 },
                    { 89, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7163), 89, 1 },
                    { 105, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7189), 105, 1 },
                    { 103, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7186), 103, 1 },
                    { 102, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7184), 102, 1 },
                    { 101, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7183), 101, 1 },
                    { 100, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7181), 100, 1 },
                    { 99, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7179), 99, 1 },
                    { 98, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7178), 98, 1 },
                    { 97, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7176), 97, 1 },
                    { 96, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7174), 96, 1 },
                    { 95, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7173), 95, 1 },
                    { 94, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7171), 94, 1 },
                    { 92, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7168), 92, 1 },
                    { 91, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7166), 91, 1 },
                    { 104, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7188), 104, 1 },
                    { 59, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7111), 59, 1 },
                    { 31, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7059), 31, 1 },
                    { 57, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7107), 57, 1 },
                    { 26, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6948), 26, 1 },
                    { 25, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6947), 25, 1 },
                    { 58, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7109), 58, 1 },
                    { 23, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6943), 23, 1 },
                    { 22, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6942), 22, 1 },
                    { 21, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6940), 21, 1 },
                    { 20, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6938), 20, 1 },
                    { 19, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6937), 19, 1 },
                    { 18, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6935), 18, 1 },
                    { 17, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6932), 17, 1 },
                    { 16, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6930), 16, 1 },
                    { 15, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6929), 15, 1 },
                    { 27, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6950), 27, 1 },
                    { 14, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6927), 14, 1 },
                    { 12, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6924), 12, 1 },
                    { 11, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6922), 11, 1 },
                    { 10, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6920), 10, 1 },
                    { 9, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6918), 9, 1 },
                    { 8, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6916), 8, 1 },
                    { 7, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6914), 7, 1 },
                    { 6, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6913), 6, 1 },
                    { 5, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6908), 5, 1 },
                    { 4, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6906), 4, 1 },
                    { 3, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6905), 3, 1 },
                    { 2, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6902), 2, 1 },
                    { 1, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6791), 1, 1 },
                    { 13, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6925), 13, 1 },
                    { 28, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6952), 28, 1 },
                    { 24, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6945), 24, 1 },
                    { 30, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6955), 30, 1 },
                    { 56, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7106), 56, 1 },
                    { 55, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7104), 55, 1 },
                    { 54, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7102), 54, 1 },
                    { 53, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7100), 53, 1 },
                    { 52, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7098), 52, 1 },
                    { 51, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7097), 51, 1 },
                    { 50, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7095), 50, 1 },
                    { 49, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7093), 49, 1 },
                    { 29, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(6953), 29, 1 },
                    { 47, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7090), 47, 1 },
                    { 46, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7088), 46, 1 },
                    { 45, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7087), 45, 1 },
                    { 44, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7085), 44, 1 },
                    { 48, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7092), 48, 1 },
                    { 42, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7082), 42, 1 },
                    { 43, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7083), 43, 1 },
                    { 32, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7062), 32, 1 },
                    { 34, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7068), 34, 1 },
                    { 35, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7070), 35, 1 },
                    { 36, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7071), 36, 1 },
                    { 33, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7064), 33, 1 },
                    { 38, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7075), 38, 1 },
                    { 39, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7076), 39, 1 },
                    { 40, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7078), 40, 1 },
                    { 41, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7080), 41, 1 },
                    { 37, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 555, DateTimeKind.Local).AddTicks(7073), 37, 1 }
                });

            migrationBuilder.InsertData(
                table: "TransactionType",
                columns: new[] { "TransactionTypeID", "Code", "Description", "IsActive", "LastChangedBy", "LastChangedDate", "Name", "TransactionStatusID" },
                values: new object[,]
                {
                    { 7, "DEP", null, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 561, DateTimeKind.Local).AddTicks(1363), "Deposit", 1 },
                    { 1, "PAY", null, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 561, DateTimeKind.Local).AddTicks(166), "Payment", 1 },
                    { 2, "(R)", null, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 561, DateTimeKind.Local).AddTicks(915), "Reversal", 1 },
                    { 3, "PURCH", null, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 561, DateTimeKind.Local).AddTicks(1005), "Purchase", 1 },
                    { 4, "SALE", null, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 561, DateTimeKind.Local).AddTicks(1152), "Sales", 1 },
                    { 5, "RPT", null, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 561, DateTimeKind.Local).AddTicks(1230), "Receipts", 1 },
                    { 6, "RECON", null, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 561, DateTimeKind.Local).AddTicks(1302), "Recon", 1 },
                    { 8, "FEE", null, true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 561, DateTimeKind.Local).AddTicks(1422), "Fee", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "EmailAddress", "FirstName", "IDNumber", "IsActive", "LastChangedBy", "LastChangedDate", "LastName", "Password", "PasswordExpiryDate", "UserName", "UserTypeID" },
                values: new object[,]
                {
                    { 2, "carochire89@gmail.com", "John", "0000000000000", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 586, DateTimeKind.Local).AddTicks(4104), "Jarani", "YWRtaW4=", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employer", 2 },
                    { 1, "carochire@gmail.com", "Wadzanai", "8904161200188", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 583, DateTimeKind.Local).AddTicks(6824), "Chirenje", "YWRtaW4=", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SuperUser", 1 },
                    { 3, "carolinesolutions89@gmail.com", "Ndini", "1111111111111", true, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 586, DateTimeKind.Local).AddTicks(4754), "Ndadaro", "YWRtaW4=", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee", 3 }
                });

            migrationBuilder.InsertData(
                table: "RoleMenus",
                columns: new[] { "RoleMenuID", "LastChangedBy", "LastChangedDate", "MenuID", "RoleID" },
                values: new object[,]
                {
                    { 1, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 608, DateTimeKind.Local).AddTicks(1857), 1, 1 },
                    { 22, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 608, DateTimeKind.Local).AddTicks(1965), 9999, 1 },
                    { 21, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 608, DateTimeKind.Local).AddTicks(1963), 9998, 1 },
                    { 20, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 608, DateTimeKind.Local).AddTicks(1962), 20, 1 },
                    { 19, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 608, DateTimeKind.Local).AddTicks(1960), 19, 1 },
                    { 18, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 608, DateTimeKind.Local).AddTicks(1959), 18, 1 },
                    { 17, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 608, DateTimeKind.Local).AddTicks(1956), 17, 1 },
                    { 16, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 608, DateTimeKind.Local).AddTicks(1955), 16, 1 },
                    { 15, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 608, DateTimeKind.Local).AddTicks(1953), 15, 1 },
                    { 14, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 608, DateTimeKind.Local).AddTicks(1952), 14, 1 },
                    { 13, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 608, DateTimeKind.Local).AddTicks(1950), 13, 1 },
                    { 12, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 608, DateTimeKind.Local).AddTicks(1949), 12, 1 },
                    { 11, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 608, DateTimeKind.Local).AddTicks(1947), 11, 1 },
                    { 10, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 608, DateTimeKind.Local).AddTicks(1946), 10, 1 },
                    { 9, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 608, DateTimeKind.Local).AddTicks(1943), 9, 1 },
                    { 8, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 608, DateTimeKind.Local).AddTicks(1942), 8, 1 },
                    { 7, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 608, DateTimeKind.Local).AddTicks(1940), 7, 1 },
                    { 6, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 608, DateTimeKind.Local).AddTicks(1939), 6, 1 },
                    { 5, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 608, DateTimeKind.Local).AddTicks(1935), 5, 1 },
                    { 4, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 608, DateTimeKind.Local).AddTicks(1933), 4, 1 },
                    { 3, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 608, DateTimeKind.Local).AddTicks(1932), 3, 1 },
                    { 2, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 608, DateTimeKind.Local).AddTicks(1929), 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserID", "RoleID", "LastChangedBy", "LastChangedDate", "UserRoleID" },
                values: new object[,]
                {
                    { 1, 1, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 594, DateTimeKind.Local).AddTicks(5184), 1 },
                    { 2, 3, "SuperUser", new DateTime(2020, 10, 15, 21, 46, 30, 594, DateTimeKind.Local).AddTicks(5248), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssertCategories_AssertID",
                table: "AssertCategories",
                column: "AssertID");

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_BankAccountTypeID",
                table: "BankAccounts",
                column: "BankAccountTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_CurrencyID",
                table: "BankAccounts",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientContacts_ClientID",
                table: "ClientContacts",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientContacts_ContactTypeID",
                table: "ClientContacts",
                column: "ContactTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientContacts_RelationshipTypeID",
                table: "ClientContacts",
                column: "RelationshipTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientCourses_ClientID",
                table: "ClientCourses",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientCourses_CourseID",
                table: "ClientCourses",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientDeductions_ClientID",
                table: "ClientDeductions",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientDeductions_ProductID",
                table: "ClientDeductions",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientDependents_ClientID",
                table: "ClientDependents",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientDocuments_ClientID",
                table: "ClientDocuments",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientDocuments_DocumentTypeID",
                table: "ClientDocuments",
                column: "DocumentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientFees_ClientID",
                table: "ClientFees",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientFees_CourseFeeID",
                table: "ClientFees",
                column: "CourseFeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientFees_ProductFeeID",
                table: "ClientFees",
                column: "ProductFeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientMedicalDetails_ClientID",
                table: "ClientMedicalDetails",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientNotes_ClientID",
                table: "ClientNotes",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientNotes_UserTypeID",
                table: "ClientNotes",
                column: "UserTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientOccupationHistory_ClientID",
                table: "ClientOccupationHistory",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientProducts_ClientID",
                table: "ClientProducts",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientProducts_ProductID",
                table: "ClientProducts",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_CountryID",
                table: "Clients",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_DepartmentID",
                table: "Clients",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_GenderID",
                table: "Clients",
                column: "GenderID");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ProductID1",
                table: "Clients",
                column: "ProductID1");

            migrationBuilder.CreateIndex(
                name: "IX_ClientTranscripts_ClientCourseID",
                table: "ClientTranscripts",
                column: "ClientCourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CountryID",
                table: "Companies",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseFeeHistory_CourseID",
                table: "CourseFeeHistory",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseFeeHistory_FrequencyID",
                table: "CourseFeeHistory",
                column: "FrequencyID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseFees_CourseID",
                table: "CourseFees",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseFees_FrequencyID",
                table: "CourseFees",
                column: "FrequencyID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseOutlines_CourseID",
                table: "CourseOutlines",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomSettings_CustomSettingTypeID",
                table: "CustomSettings",
                column: "CustomSettingTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomSettings_CustomVariableTypeID",
                table: "CustomSettings",
                column: "CustomVariableTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentTypes_DocumentFormatID",
                table: "DocumentTypes",
                column: "DocumentFormatID");

            migrationBuilder.CreateIndex(
                name: "IX_EmailTemplates_EmailTypeID",
                table: "EmailTemplates",
                column: "EmailTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmailTemplates_PriorityRankID",
                table: "EmailTemplates",
                column: "PriorityRankID");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_MenuGroupID",
                table: "Menus",
                column: "MenuGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_NoticeBoard_PriorityRankID",
                table: "NoticeBoard",
                column: "PriorityRankID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAssertCategory_AssertCategoryID",
                table: "ProductAssertCategory",
                column: "AssertCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAssertCategory_ProductID",
                table: "ProductAssertCategory",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAsserts_AssertID",
                table: "ProductAsserts",
                column: "AssertID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAsserts_ProductID",
                table: "ProductAsserts",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeeHistory_FrequencyID",
                table: "ProductFeeHistory",
                column: "FrequencyID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeeHistory_ProductID",
                table: "ProductFeeHistory",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFees_FrequencyID",
                table: "ProductFees",
                column: "FrequencyID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFees_ProductID",
                table: "ProductFees",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductHistory_ProductID",
                table: "ProductHistory",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CompanyID",
                table: "Products",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CountryID",
                table: "Products",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_RoleMenus_MenuID",
                table: "RoleMenus",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_RoleMenus_RoleID",
                table: "RoleMenus",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_PermissionID",
                table: "RolePermissions",
                column: "PermissionID");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_RoleID",
                table: "RolePermissions",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_BankAccountID",
                table: "Transactions",
                column: "BankAccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ClientID",
                table: "Transactions",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CourseID",
                table: "Transactions",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_PaymentStatusID",
                table: "Transactions",
                column: "PaymentStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ProductID",
                table: "Transactions",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_TransactionTypeID",
                table: "Transactions",
                column: "TransactionTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionType_TransactionStatusID",
                table: "TransactionType",
                column: "TransactionStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_UserAuthenticationCodes_UserID",
                table: "UserAuthenticationCodes",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleID",
                table: "UserRoles",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserTypeID",
                table: "Users",
                column: "UserTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientContacts");

            migrationBuilder.DropTable(
                name: "ClientDeductions");

            migrationBuilder.DropTable(
                name: "ClientDependents");

            migrationBuilder.DropTable(
                name: "ClientDocuments");

            migrationBuilder.DropTable(
                name: "ClientFees");

            migrationBuilder.DropTable(
                name: "ClientMedicalDetails");

            migrationBuilder.DropTable(
                name: "ClientNotes");

            migrationBuilder.DropTable(
                name: "ClientOccupationHistory");

            migrationBuilder.DropTable(
                name: "ClientProducts");

            migrationBuilder.DropTable(
                name: "ClientTranscripts");

            migrationBuilder.DropTable(
                name: "CourseFeeHistory");

            migrationBuilder.DropTable(
                name: "CourseOutlines");

            migrationBuilder.DropTable(
                name: "CustomSettings");

            migrationBuilder.DropTable(
                name: "EmailTemplates");

            migrationBuilder.DropTable(
                name: "ErrorLogging");

            migrationBuilder.DropTable(
                name: "FeatureFlags");

            migrationBuilder.DropTable(
                name: "NoticeBoard");

            migrationBuilder.DropTable(
                name: "ProductAssertCategory");

            migrationBuilder.DropTable(
                name: "ProductAsserts");

            migrationBuilder.DropTable(
                name: "ProductFeeHistory");

            migrationBuilder.DropTable(
                name: "ProductHistory");

            migrationBuilder.DropTable(
                name: "RoleMenus");

            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "StatementLists");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "UserAuthenticationCodes");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "WeekDays");

            migrationBuilder.DropTable(
                name: "ContactTypes");

            migrationBuilder.DropTable(
                name: "RelationshipTypes");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "CourseFees");

            migrationBuilder.DropTable(
                name: "ProductFees");

            migrationBuilder.DropTable(
                name: "ClientCourses");

            migrationBuilder.DropTable(
                name: "CustomSettingTypes");

            migrationBuilder.DropTable(
                name: "SystemVariableTypes");

            migrationBuilder.DropTable(
                name: "EmailTypes");

            migrationBuilder.DropTable(
                name: "PriorityRanks");

            migrationBuilder.DropTable(
                name: "AssertCategories");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "BankAccounts");

            migrationBuilder.DropTable(
                name: "PaymentStatus");

            migrationBuilder.DropTable(
                name: "TransactionType");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "DocumentFormats");

            migrationBuilder.DropTable(
                name: "Frequencies");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Asserts");

            migrationBuilder.DropTable(
                name: "MenuGroups");

            migrationBuilder.DropTable(
                name: "BankAccountTypes");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "TransactionStatus");

            migrationBuilder.DropTable(
                name: "UserTypes");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
