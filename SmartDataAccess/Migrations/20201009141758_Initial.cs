using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class Initial : Migration
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
                    Description = table.Column<string>(nullable: true),
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
                    ResidentialAddress = table.Column<string>(nullable: true),
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
                name: "ClientGuarantors",
                columns: table => new
                {
                    ClientGuarantorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    ClientID = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    IDNumber = table.Column<string>(nullable: false),
                    IsMainGuarantor = table.Column<bool>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    PhysicalAddress = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientGuarantors", x => x.ClientGuarantorID);
                    table.ForeignKey(
                        name: "FK_ClientGuarantors_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
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
                    ProductID = table.Column<int>(nullable: false),
                    AssertID = table.Column<int>(nullable: false),
                    AssertCategoryID = table.Column<int>(nullable: false),
                    BankAccountID = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Month = table.Column<int>(nullable: false),
                    TransactionTypeID = table.Column<int>(nullable: false),
                    PaymentStatusID = table.Column<int>(nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
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
                    ClientProductID = table.Column<int>(nullable: false),
                    ProductFeeID = table.Column<int>(nullable: false),
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
                        name: "FK_ClientFees_ProductFees_ProductFeeID",
                        column: x => x.ProductFeeID,
                        principalTable: "ProductFees",
                        principalColumn: "ProductFeeID",
                        onDelete: ReferentialAction.Cascade);
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
                    { 1, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 191, DateTimeKind.Local).AddTicks(1246), "Savings" },
                    { 2, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 191, DateTimeKind.Local).AddTicks(1889), "Cheque" },
                    { 3, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 191, DateTimeKind.Local).AddTicks(1899), "Credit" },
                    { 4, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 191, DateTimeKind.Local).AddTicks(1902), "Cash" }
                });

            migrationBuilder.InsertData(
                table: "ContactTypes",
                columns: new[] { "ContactTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 4, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 200, DateTimeKind.Local).AddTicks(1452), "Cell Phone" },
                    { 3, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 200, DateTimeKind.Local).AddTicks(1573), "Email Address" },
                    { 2, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 200, DateTimeKind.Local).AddTicks(1580), "Postal Address" },
                    { 1, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 200, DateTimeKind.Local).AddTicks(1584), "Residential Address" },
                    { 5, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 200, DateTimeKind.Local).AddTicks(1588), "Telephone" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 156, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9721), "Norway" },
                    { 155, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9718), "N Mariana Islands" },
                    { 154, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9714), "Nigeria" },
                    { 153, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9711), "Niger" },
                    { 152, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9707), "Nicaragua" },
                    { 147, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9688), "Nepal" },
                    { 149, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9696), "Netherlands Antilles" },
                    { 148, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9692), "Netherlands" },
                    { 157, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9725), "Oman" },
                    { 146, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9685), "Nauru" },
                    { 151, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9704), "New Zealand" },
                    { 158, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9728), "Pakistan" },
                    { 162, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9743), "Paraguay" },
                    { 160, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9735), "Panama" },
                    { 161, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9739), "Papua New Guinea" },
                    { 145, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9682), "Namibia" },
                    { 163, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9746), "Peru" },
                    { 164, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9749), "Philippines" },
                    { 165, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9753), "Poland" },
                    { 166, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9756), "Portugal" },
                    { 167, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9760), "Puerto Rico" },
                    { 168, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9763), "Qatar" },
                    { 169, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9766), "Reunion" },
                    { 170, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9770), "Romania" },
                    { 159, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9732), "Palau" },
                    { 144, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9678), "Mozambique" },
                    { 139, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9653), "Moldova" },
                    { 142, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9663), "Montserrat" },
                    { 117, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9575), "Lebanon" },
                    { 118, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9578), "Lesotho" },
                    { 119, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9582), "Liberia" },
                    { 120, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9585), "Libya" },
                    { 121, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9588), "Liechtenstein" },
                    { 122, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9592), "Lithuania" },
                    { 123, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9595), "Luxembourg" },
                    { 124, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9598), "Macau" },
                    { 125, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9602), "Macedonia" },
                    { 126, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9605), "Madagascar" },
                    { 127, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9608), "Malawi" },
                    { 128, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9612), "Malaysia" },
                    { 129, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9616), "Maldives" },
                    { 130, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9621), "Mali" },
                    { 131, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9624), "Malta" },
                    { 132, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9629), "Marshall Islands" },
                    { 133, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9632), "Martinique" },
                    { 134, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9635), "Mauritania" },
                    { 135, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9638), "Mauritius" },
                    { 136, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9642), "Mayotte" },
                    { 137, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9645), "Mexico" },
                    { 138, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9650), "Micronesia Fed St" },
                    { 171, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9776), "Russia" },
                    { 140, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9657), "Monaco" },
                    { 141, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9660), "Mongolia" },
                    { 143, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9675), "Morocco" },
                    { 172, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9780), "Rwanda" },
                    { 177, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9802), "Saint Vincent and the Grenadines" },
                    { 174, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9788), "Saint Kitts Nevis" },
                    { 204, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9897), "Togo" },
                    { 205, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9900), "Tonga" },
                    { 206, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9904), "Trinidad Tobago" },
                    { 207, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9907), "Tunisia" },
                    { 208, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9911), "Turkey" },
                    { 209, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9914), "Turkmenistan" },
                    { 210, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9918), "Turks Caicos Is" },
                    { 211, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9929), "Tuvalu" },
                    { 212, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9932), "Uganda" },
                    { 213, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9936), "Ukraine" },
                    { 214, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9940), "United Arab Emirates" },
                    { 215, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9944), "United Kingdom" },
                    { 216, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9948), "United States" },
                    { 217, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9951), "Uruguay" },
                    { 218, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9955), "Uzbekistan" },
                    { 219, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9958), "Vanuatu" },
                    { 220, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9961), "Venezuela" },
                    { 221, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9964), "Vietnam" },
                    { 222, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9968), "Virgin Islands" },
                    { 223, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9972), "Wallis Futuna" },
                    { 224, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9976), "West Bank" },
                    { 225, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9979), "Western Sahara" },
                    { 226, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9983), "Yemen" },
                    { 227, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9986), "Zambia" },
                    { 228, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9990), "Zimbabwe" },
                    { 203, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9894), "Thailand" },
                    { 173, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9784), "Saint Helena" },
                    { 202, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9890), "Tanzania" },
                    { 200, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9883), "Taiwan" },
                    { 175, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9792), "Saint Lucia" },
                    { 176, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9797), "St Pierre Miquelon" },
                    { 116, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9571), "Latvia" },
                    { 178, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9805), "Samoa" },
                    { 179, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9809), "San Marino" },
                    { 180, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9813), "Sao Tome Principe" },
                    { 181, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9817), "Saudi Arabia" },
                    { 182, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9821), "Senegal" },
                    { 183, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9824), "Serbia" },
                    { 184, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9827), "Seychelles" },
                    { 185, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9831), "Sierra Leone" },
                    { 186, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9834), "Singapore" },
                    { 187, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9838), "Slovakia" },
                    { 188, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9841), "Slovenia" },
                    { 189, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9845), "Solomon Islands" },
                    { 190, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9848), "Somalia" },
                    { 191, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9852), "South Africa" },
                    { 192, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9856), "Spain" },
                    { 193, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9860), "Sri Lanka" },
                    { 194, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9864), "Sudan" },
                    { 195, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9867), "Suriname" },
                    { 196, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9870), "Swaziland" },
                    { 197, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9873), "Sweden" },
                    { 198, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9877), "Switzerland" },
                    { 199, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9880), "Syria" },
                    { 201, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9887), "Tajikistan" },
                    { 115, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9568), "Laos" },
                    { 150, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9700), "New Caledonia" },
                    { 113, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9561), "Kuwait" },
                    { 30, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9243), "British Virgin Is" },
                    { 31, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9246), "Brunei" },
                    { 32, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9250), "Bulgaria" },
                    { 33, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9265), "Burkina Faso" },
                    { 34, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9271), "Burma" },
                    { 35, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9274), "Burundi" },
                    { 36, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9278), "Cambodia" },
                    { 37, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9281), "Cameroon" },
                    { 38, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9284), "Canada" },
                    { 39, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9288), "Cape Verde" },
                    { 40, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9292), "Cayman Islands" },
                    { 41, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9297), "Central African Rep" },
                    { 42, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9300), "Chad" },
                    { 43, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9304), "Chile" },
                    { 44, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9307), "China" },
                    { 45, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9310), "Colombia" },
                    { 46, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9314), "Comoros" },
                    { 47, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9318), "Congo Dem Rep" },
                    { 48, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9323), "Congo Repub of the" },
                    { 49, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9327), "Cook Islands" },
                    { 50, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9331), "Costa Rica" },
                    { 51, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9335), "Cote dIvoire" },
                    { 52, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9338), "Croatia" },
                    { 53, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9341), "Cuba" },
                    { 54, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9345), "Cyprus" },
                    { 29, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9238), "Brazil" },
                    { 55, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9349), "Czech Republic" },
                    { 28, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9234), "Botswana" },
                    { 26, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9226), "Bolivia" },
                    { 1, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(8717), "Afghanistan" },
                    { 2, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9122), "Albania" },
                    { 3, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9129), "Algeria" },
                    { 4, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9138), "American Samoa" },
                    { 5, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9142), "Andorra" },
                    { 6, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9152), "Angola" },
                    { 7, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9155), "Anguilla" },
                    { 8, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9159), "Antigua Barbuda" },
                    { 9, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9163), "Argentina" },
                    { 10, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9168), "Armenia" },
                    { 11, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9172), "Aruba" },
                    { 12, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9176), "Australia" },
                    { 13, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9179), "Austria" },
                    { 14, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9182), "Azerbaijan" },
                    { 15, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9186), "Bahamas" },
                    { 16, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9190), " The" },
                    { 114, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9564), "Kyrgyzstan" },
                    { 18, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9200), "Bangladesh" },
                    { 19, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9203), "Barbados" },
                    { 20, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9206), "Belarus" },
                    { 21, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9210), "Belgium" },
                    { 22, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9213), "Belize" },
                    { 23, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9216), "Benin" },
                    { 24, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9219), "Bermuda" },
                    { 25, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9223), "Bhutan" },
                    { 27, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9231), "Bosnia Herzegovina" },
                    { 56, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9352), "Denmark" },
                    { 17, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9194), "Bahrain" },
                    { 58, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9359), "Dominica" },
                    { 88, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9475), "Guinea" },
                    { 89, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9480), "Guinea Bissau" },
                    { 90, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9483), "Guyana" },
                    { 91, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9486), "Haiti" },
                    { 92, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9489), "Honduras" },
                    { 93, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9493), "Hong Kong" },
                    { 94, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9496), "Hungary" },
                    { 95, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9500), "Iceland" },
                    { 96, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9503), "India" },
                    { 97, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9506), "Indonesia" },
                    { 98, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9509), "Iran" },
                    { 99, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9512), "Iraq" },
                    { 100, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9516), "Ireland" },
                    { 101, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9520), "Isle of Man" },
                    { 102, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9523), "Israel" },
                    { 103, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9527), "Italy" },
                    { 105, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9533), "Japan" },
                    { 106, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9537), "Jersey" },
                    { 107, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9540), "Jordan" },
                    { 108, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9543), "Kazakhstan" },
                    { 109, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9547), "Kenya" },
                    { 110, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9550), "Kiribati" },
                    { 111, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9553), "Korea North" },
                    { 112, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9557), "Korea South" },
                    { 57, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9355), "Djibouti" },
                    { 87, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9472), "Guernsey" },
                    { 86, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9460), "Guatemala" },
                    { 104, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9530), "Jamaica" },
                    { 84, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9454), "Guadeloupe" },
                    { 59, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9363), "Dominican Republic" },
                    { 85, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9457), "Guam" },
                    { 60, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9367), "East Timor" },
                    { 61, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9371), "Ecuador" },
                    { 62, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9374), "Egypt" },
                    { 63, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9378), "El Salvador" },
                    { 65, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9385), "Eritrea" },
                    { 66, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9390), "Estonia" },
                    { 67, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9394), "Ethiopia" },
                    { 68, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9398), "Faroe Islands" },
                    { 69, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9401), "Fiji" },
                    { 70, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9404), "Finland" },
                    { 71, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9407), "France" },
                    { 64, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9382), "Equatorial Guinea" },
                    { 73, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9416), "French Polynesia" },
                    { 72, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9412), "French Guiana" },
                    { 83, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9450), "Grenada" },
                    { 81, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9444), "Greece" },
                    { 80, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9440), "Gibraltar" },
                    { 82, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9447), "Greenland" },
                    { 79, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9437), "Ghana" },
                    { 77, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9430), "Georgia" },
                    { 76, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9427), "Gaza Strip" },
                    { 75, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9423), "Gambia The" },
                    { 74, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9419), "Gabon" },
                    { 78, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 206, DateTimeKind.Local).AddTicks(9434), "Germany" }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "CurrencyID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 106, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8463), "NZD" },
                    { 107, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8466), "OMR" },
                    { 105, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8460), "NPR" },
                    { 108, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8469), "PAB" },
                    { 109, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8472), "PEN" },
                    { 110, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8475), "PGK" },
                    { 111, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8478), "PHP" },
                    { 116, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8493), "RON" },
                    { 113, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8484), "PLN" },
                    { 114, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8487), "PYG" },
                    { 115, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8490), "QAR" },
                    { 117, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8496), "RSD" },
                    { 118, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8499), "RUB" },
                    { 120, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8505), "SAR" },
                    { 104, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8457), "NOK" },
                    { 119, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8502), "RWF" },
                    { 112, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8481), "PKR" },
                    { 103, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8454), "NIO" },
                    { 90, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8416), "MKD" },
                    { 101, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8448), "NAD" },
                    { 84, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8398), "LRD" },
                    { 121, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8507), "SBD" },
                    { 85, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8402), "LSL" },
                    { 86, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8404), "LYD" },
                    { 87, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8407), "MAD" },
                    { 88, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8410), "MDL" },
                    { 89, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8413), "MGA" },
                    { 91, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8419), "MMK" },
                    { 92, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8422), "MNT" },
                    { 93, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8425), "MOP" },
                    { 94, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8428), "MRU" },
                    { 95, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8431), "MUR" },
                    { 96, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8433), "MVR" },
                    { 97, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8436), "MWK" },
                    { 98, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8439), "MXN" },
                    { 99, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8442), "MYR" },
                    { 100, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8445), "MZN" },
                    { 102, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8451), "NGN" },
                    { 122, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8510), "SCR" },
                    { 150, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8606), "VEF" },
                    { 124, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8518), "SEK" },
                    { 146, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8594), "UGX" },
                    { 147, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8597), "USD" },
                    { 148, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8600), "UYU" },
                    { 149, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8603), "UZS" },
                    { 151, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8609), "VND" },
                    { 152, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8611), "VUV" },
                    { 153, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8614), "WST" },
                    { 154, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8617), "XAF" },
                    { 155, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8620), "XCD" },
                    { 156, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8623), "XDR" },
                    { 157, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8626), "XOF" },
                    { 158, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8629), "XPF" },
                    { 159, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8632), "YER" },
                    { 160, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8635), "ZAR" },
                    { 161, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8638), "ZMW" },
                    { 162, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8641), "ZWD" },
                    { 83, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8395), "LKR" },
                    { 145, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8591), "UAH" },
                    { 123, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8515), "SDG" },
                    { 144, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8588), "TZS" },
                    { 142, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8582), "TVD" },
                    { 125, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8530), "SGD" },
                    { 126, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8533), "SHP" },
                    { 127, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8536), "SLL" },
                    { 128, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8539), "SOS" },
                    { 129, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8542), "SPL" },
                    { 130, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8547), "SRD" },
                    { 131, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8550), "STN" },
                    { 132, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8553), "SVC" },
                    { 133, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8556), "SYP" },
                    { 134, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8559), "SZL" },
                    { 135, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8562), "THB" },
                    { 136, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8565), "TJS" },
                    { 137, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8568), "TMT" },
                    { 138, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8571), "TND" },
                    { 139, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8573), "TOP" },
                    { 140, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8576), "TRY" },
                    { 141, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8579), "TTD" },
                    { 143, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8585), "TWD" },
                    { 82, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8392), "LBP" },
                    { 56, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8241), "HKD" },
                    { 80, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8386), "KZT" },
                    { 22, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8137), "BTN" },
                    { 23, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8140), "BWP" },
                    { 24, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8143), "BYN" },
                    { 25, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8146), "BZD" },
                    { 26, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8149), "CAD" },
                    { 27, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8152), "CDF" },
                    { 28, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8155), "CHF" },
                    { 21, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8134), "BSD" },
                    { 29, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8158), "CLP" },
                    { 31, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8164), "COP" },
                    { 32, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8167), "CRC" },
                    { 33, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8170), "CUC" },
                    { 34, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8175), "CUP" },
                    { 35, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8178), "CVE" },
                    { 36, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8181), "CZK" },
                    { 37, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8184), "DJF" },
                    { 30, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8160), "CNY" },
                    { 20, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8131), "BRL" },
                    { 19, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8128), "BOB" },
                    { 18, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8125), "BND" },
                    { 81, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8389), "LAK" },
                    { 1, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(7628), "AED" },
                    { 2, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8060), "AFN" },
                    { 3, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8067), "ALL" },
                    { 4, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8071), "AMD" },
                    { 5, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8075), "ANG" },
                    { 6, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8084), "AOA" },
                    { 7, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8088), "ARS" },
                    { 8, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8091), "AUD" },
                    { 10, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8099), "AZN" },
                    { 11, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8102), "BAM" },
                    { 12, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8105), "BBD" },
                    { 13, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8108), "BDT" },
                    { 14, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8111), "BGN" },
                    { 15, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8114), "BHD" },
                    { 16, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8117), "BIF" },
                    { 17, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8120), "BMD" },
                    { 38, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8187), "DKK" },
                    { 39, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8190), "DOP" },
                    { 9, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8094), "AWG" },
                    { 41, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8197), "EGP" },
                    { 63, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8333), "IMP" },
                    { 64, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8336), "INR" },
                    { 65, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8339), "IQD" },
                    { 66, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8345), "IRR" },
                    { 67, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8348), "ISK" },
                    { 68, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8351), "JEP" },
                    { 69, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8354), "JMD" },
                    { 62, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8330), "ILS" },
                    { 70, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8356), "JOD" },
                    { 71, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8359), "JPY" },
                    { 72, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8362), "KES" },
                    { 73, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8365), "KGS" },
                    { 74, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8368), "KHR" },
                    { 75, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8371), "KMF" },
                    { 76, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8374), "KPW" },
                    { 77, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8377), "KRW" },
                    { 79, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8383), "KYD" },
                    { 61, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8327), "IDR" },
                    { 60, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8324), "HUF" },
                    { 59, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8321), "HTG" },
                    { 42, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8200), "ERN" },
                    { 43, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8203), "ETB" },
                    { 44, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8206), "EUR" },
                    { 45, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8209), "FJD" },
                    { 46, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8212), "FKP" },
                    { 47, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8215), "GBP" },
                    { 48, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8218), "GEL" },
                    { 49, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8221), "GGP" },
                    { 50, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8223), "GHS" },
                    { 51, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8226), "GIP" },
                    { 52, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8229), "GMD" },
                    { 53, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8232), "GNF" },
                    { 54, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8235), "GTQ" },
                    { 55, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8238), "GYD" },
                    { 40, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8192), "DZD" },
                    { 57, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8314), "HNL" },
                    { 58, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8318), "HRK" },
                    { 78, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 193, DateTimeKind.Local).AddTicks(8380), "KWD" }
                });

            migrationBuilder.InsertData(
                table: "CustomSettingTypes",
                columns: new[] { "CustomSettingTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 3, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 202, DateTimeKind.Local).AddTicks(1307), "All" },
                    { 4, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 202, DateTimeKind.Local).AddTicks(1310), "Email" },
                    { 1, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 202, DateTimeKind.Local).AddTicks(1183), "BackEnd" },
                    { 2, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 202, DateTimeKind.Local).AddTicks(1302), "Portal" }
                });

            migrationBuilder.InsertData(
                table: "DocumentFormats",
                columns: new[] { "DocumentFormatID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 6, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 216, DateTimeKind.Local).AddTicks(2891), "ppt" },
                    { 5, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 216, DateTimeKind.Local).AddTicks(2882), "rtf" },
                    { 4, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 216, DateTimeKind.Local).AddTicks(2879), "txt" },
                    { 1, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 216, DateTimeKind.Local).AddTicks(2424), "pdf" },
                    { 2, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 216, DateTimeKind.Local).AddTicks(2846), "doc" },
                    { 3, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 216, DateTimeKind.Local).AddTicks(2852), "xlsx" }
                });

            migrationBuilder.InsertData(
                table: "EmailTypes",
                columns: new[] { "EmailTypeID", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 4, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 228, DateTimeKind.Local).AddTicks(6915), "New User Account Created" },
                    { 3, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 228, DateTimeKind.Local).AddTicks(6909), "Invoice" },
                    { 2, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 228, DateTimeKind.Local).AddTicks(6900), "Proof Of Payment" },
                    { 1, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 228, DateTimeKind.Local).AddTicks(6508), "Client Statement" }
                });

            migrationBuilder.InsertData(
                table: "FeatureFlags",
                columns: new[] { "FeatureFlagID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 3, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 213, DateTimeKind.Local).AddTicks(5568), "Enable Document Emailing Functionality" },
                    { 1, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 213, DateTimeKind.Local).AddTicks(5077), "Send Email On Error" },
                    { 2, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 213, DateTimeKind.Local).AddTicks(5558), "CC Client On Error" }
                });

            migrationBuilder.InsertData(
                table: "Frequencies",
                columns: new[] { "FrequencyID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 196, DateTimeKind.Local).AddTicks(4527), "Once Off" },
                    { 2, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 196, DateTimeKind.Local).AddTicks(4970), "Monthly" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 2, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 204, DateTimeKind.Local).AddTicks(782), "Male" },
                    { 1, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 204, DateTimeKind.Local).AddTicks(672), "Female" }
                });

            migrationBuilder.InsertData(
                table: "MenuGroups",
                columns: new[] { "MenuGroupID", "CSSClass", "Description", "DisplayName", "IsActive", "IsActiveMenu", "LastChangedBy", "LastChangedDate", "OrderNo" },
                values: new object[,]
                {
                    { 4, "fa fa-chart-bar", null, "Reporting", true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 220, DateTimeKind.Local).AddTicks(9885), 6 },
                    { 3, "fa fa-money", null, "Product And Services", true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 220, DateTimeKind.Local).AddTicks(9879), 3 },
                    { 999, "fa fa - laptop", null, "Developer Menu", true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 220, DateTimeKind.Local).AddTicks(9910), 9999 },
                    { 1, "fa fa-umbrella", null, "DashBoard", true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 220, DateTimeKind.Local).AddTicks(9675), 1 },
                    { 5, "fa fa-tools", null, "Custom Settings", true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 220, DateTimeKind.Local).AddTicks(9892), 7 },
                    { 2, "fa-users", null, "Employees", true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 220, DateTimeKind.Local).AddTicks(9862), 2 },
                    { 9998, "fa fa-university", null, "Menu", true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 220, DateTimeKind.Local).AddTicks(9904), 9998 }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "PaymentStatusID", "Description", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 2, null, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 184, DateTimeKind.Local).AddTicks(7417), "Reversed" },
                    { 3, null, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 184, DateTimeKind.Local).AddTicks(7424), "Pending" },
                    { 4, null, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 184, DateTimeKind.Local).AddTicks(7428), "Refunded" },
                    { 5, null, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 184, DateTimeKind.Local).AddTicks(7431), "Discounted" },
                    { 1, null, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 184, DateTimeKind.Local).AddTicks(6957), "Paid" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "Description", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 78, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3427), "Delete Course" },
                    { 77, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3423), "Update Course" },
                    { 76, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3419), "Add Course" },
                    { 86, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3461), "Add Company" },
                    { 75, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3414), "View Menu" },
                    { 85, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3457), "View Document Type" },
                    { 84, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3453), "Delete Document Type" },
                    { 83, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3449), "Update Document Type" },
                    { 82, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3444), "Add Document Type" },
                    { 81, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3439), "View Custom Setting" },
                    { 80, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3435), "Update Custom Setting" },
                    { 79, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3431), "View Course" },
                    { 87, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3465), "Update Company" },
                    { 74, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3410), "Delete Menu" },
                    { 68, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3385), "View Payment" },
                    { 72, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3402), "Activate Menu" },
                    { 71, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3398), "Update Menu" },
                    { 70, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3393), "Add Menu" },
                    { 69, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3389), "Make Payment" },
                    { 67, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3381), "Void Payment" },
                    { 66, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3377), "Reverse Payment" },
                    { 65, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3371), "Refund Payment" },
                    { 64, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3367), "Capture Payment" },
                    { 63, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3362), "Close Enquiry" },
                    { 62, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3358), "Suspend Enquiry" },
                    { 61, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3354), "Route Enquiry" },
                    { 60, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3349), "Respond To Enquiry" },
                    { 88, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3469), "Delete Company" },
                    { 59, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3345), "View Department" },
                    { 73, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3406), "Deactivate Menu" },
                    { 89, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3473), "View Company" },
                    { 115, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3596), "Add Assert" },
                    { 91, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3482), "Update Bank Account" },
                    { 120, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3618), "Generate Schedules" },
                    { 119, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3614), "View Client Outstanding Payments" },
                    { 118, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3609), "View Assert" },
                    { 117, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3604), "Delete Assert" },
                    { 116, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3600), "Update Assert" },
                    { 58, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3340), "Delete Department" },
                    { 114, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3592), "View Product Assert" },
                    { 113, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3588), "Update Product Assert" },
                    { 112, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3583), "Add Product Assert" },
                    { 111, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3579), "View Product Fee" },
                    { 110, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3575), "Delete Product Fee" },
                    { 109, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3570), "Update Product Fee" },
                    { 108, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3566), "Add Product Fee" },
                    { 107, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3561), "View Transaction Type" },
                    { 106, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3557), "Update Transaction Type" },
                    { 105, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3552), "Client Update Personal Details" },
                    { 104, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3547), "View Dashboard Notices" },
                    { 103, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3543), "Update Currency" },
                    { 102, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3539), "Update Country" },
                    { 101, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3535), "View Notice" },
                    { 100, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3531), "Delete Notice" },
                    { 99, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3527), "Update Notice" },
                    { 98, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3522), "Add Notice" },
                    { 97, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3509), "View Email Template" },
                    { 96, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3505), "Delete Email Template" },
                    { 95, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3500), "Update Email Template" },
                    { 94, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3496), "Add Email Template" },
                    { 93, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3491), "View Bank Account" },
                    { 92, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3487), "Delete Bank Account" },
                    { 90, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3478), "Add Bank Account" },
                    { 57, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3336), "Update Department" },
                    { 11, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3100), "Add Client Note" },
                    { 55, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3315), "View Product" },
                    { 25, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3181), "Delete Client Dependent" },
                    { 24, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3176), "Update Client Dependent" },
                    { 23, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3171), "Add Client Dependent" },
                    { 22, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3166), "View Client Product" },
                    { 21, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3162), "Delete Client Product" },
                    { 20, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3157), "Update Client Product" },
                    { 19, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3153), "Add Client Product" },
                    { 18, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3148), "View Client Contact" },
                    { 17, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3141), "Delete Client Contact" },
                    { 16, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3122), "Update Client Contact" },
                    { 15, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3117), "Add Client Contact" },
                    { 26, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3185), "View Client Dependent" },
                    { 14, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3113), "View Client Note" },
                    { 56, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3320), "Add Department" },
                    { 10, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3095), "Change Client Password" },
                    { 9, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3088), "View Client" },
                    { 8, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3084), "Delete Client" },
                    { 7, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3080), "Update Client" },
                    { 6, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3076), "Add Client" },
                    { 5, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3065), "Change User Password" },
                    { 4, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3060), "View User" },
                    { 3, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3055), "Delete User" },
                    { 2, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3046), "Update User" },
                    { 1, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(2630), "Add User" },
                    { 13, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3108), "Delete Client Note" },
                    { 27, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3190), "Add Client Guarantor" },
                    { 12, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3104), "Update Client Note" },
                    { 29, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3199), "Delete Client Guarantor" },
                    { 28, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3194), "Update Client Guarantor" },
                    { 54, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3311), "Delete Product" },
                    { 53, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3307), "Update Product" },
                    { 52, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3303), "Add Product" },
                    { 51, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3299), "Remove Menu From Role" },
                    { 50, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3294), "Add Menu To Role" },
                    { 49, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3289), "View Permissions" },
                    { 47, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3281), "Add Permissions" },
                    { 46, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3276), "View Role" },
                    { 45, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3271), "Delete Role" },
                    { 44, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3268), "Update Role" },
                    { 43, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3263), "Add Role" },
                    { 48, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3285), "Remove Permissions" },
                    { 41, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3255), "Client Upload Document" },
                    { 40, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3250), "Generate Client Statement" },
                    { 39, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3246), "View Client Payments" },
                    { 38, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3241), "View Client Medical Details" },
                    { 37, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3237), "Delete Client Medical Details" },
                    { 36, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3232), "Update Client Medical Details" },
                    { 35, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3228), "Add Client Medical Details" },
                    { 34, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3223), "View Client Course" },
                    { 33, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3216), "Delete Client Course" },
                    { 32, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3212), "Update Client Course" },
                    { 31, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3208), "Add Client Course" },
                    { 42, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3259), "Client View Document" },
                    { 30, null, true, false, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 181, DateTimeKind.Local).AddTicks(3203), "View Client Guarantor" }
                });

            migrationBuilder.InsertData(
                table: "PriorityRanks",
                columns: new[] { "PriorityRankID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 207, DateTimeKind.Local).AddTicks(8934), "Critical" },
                    { 4, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 207, DateTimeKind.Local).AddTicks(9039), "Low" },
                    { 3, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 207, DateTimeKind.Local).AddTicks(9036), "Medium" },
                    { 2, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 207, DateTimeKind.Local).AddTicks(9030), "High" }
                });

            migrationBuilder.InsertData(
                table: "RelationshipTypes",
                columns: new[] { "RelationshipTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 5, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 201, DateTimeKind.Local).AddTicks(861), "Other" },
                    { 4, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 201, DateTimeKind.Local).AddTicks(856), "Spouse" },
                    { 3, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 201, DateTimeKind.Local).AddTicks(842), "Sibling" },
                    { 2, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 201, DateTimeKind.Local).AddTicks(831), "Father" },
                    { 1, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 201, DateTimeKind.Local).AddTicks(563), "Mother" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "Description", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 2, null, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 176, DateTimeKind.Local).AddTicks(7717), "Employee" },
                    { 1, null, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 175, DateTimeKind.Local).AddTicks(3346), "Super Admin" },
                    { 3, null, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 176, DateTimeKind.Local).AddTicks(7780), "Administrator" }
                });

            migrationBuilder.InsertData(
                table: "SystemVariableTypes",
                columns: new[] { "CustomVariableTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 6, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 203, DateTimeKind.Local).AddTicks(3367), "Decimal" },
                    { 1, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 203, DateTimeKind.Local).AddTicks(3226), "Boolean" },
                    { 5, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 203, DateTimeKind.Local).AddTicks(3345), "Double" },
                    { 4, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 203, DateTimeKind.Local).AddTicks(3350), "Integer" },
                    { 3, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 203, DateTimeKind.Local).AddTicks(3354), "Long" },
                    { 2, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 203, DateTimeKind.Local).AddTicks(3358), "String" },
                    { 7, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 203, DateTimeKind.Local).AddTicks(3377), "Date Time" },
                    { 8, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 203, DateTimeKind.Local).AddTicks(3381), "Password" },
                    { 9, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 203, DateTimeKind.Local).AddTicks(3386), "Percentage" }
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
                    { 1, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 199, DateTimeKind.Local).AddTicks(1044), "Administrator" },
                    { 2, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 199, DateTimeKind.Local).AddTicks(1434), "Employer" },
                    { 3, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 199, DateTimeKind.Local).AddTicks(1442), "Employee" }
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
                    { 4, 3, 1, "Allows system to BroadCast System Messages", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(552), "BroadCast Messages", "true" },
                    { 14, 4, 2, "Display Sender Name As", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(667), "Mail Display Name", "Smart Admin" },
                    { 19, 3, 2, "First Line on the Report Footer", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(708), "Report Footer 1", "W. Guri Mrs. (Chairman), *E. Guri (Managing)" },
                    { 20, 3, 2, "Additional Line on the Report Footer (can be blank)", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(713), "Report Footer 2", "*Executive." },
                    { 21, 3, 2, "Physical Location of Logo that is to be used on Reports", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(718), "Report Logo Path", "D:\\Dev Projects\\SmartSave\\SmartSave\\SmartResources\\SmartLogo.png" },
                    { 27, 3, 2, "Physical Location on the Server where  Statements Are Generated", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(741), "Statement Save To Physical Location", "C:\\SmartApp\\Statements" },
                    { 29, 3, 2, "Password Used to Open Password Protected Statement By System Administrators", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(747), "Statement Password For Admin", "123456" },
                    { 25, 3, 2, "Default Email Subject Name Used By Auto-Generated Emails", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(765), "Mail Default Subject", "Smart Save  Admin" },
                    { 33, 3, 2, "Site URL", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(783), "Site URL", "https://localhost:5001" },
                    { 12, 4, 2, "Email Address used to email", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(600), "Mail Credential User Name", "carolinesolutions89@gmail.com" },
                    { 34, 3, 2, "Site Reset Password URL", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(791), "Site Reset Password URL", "https://localhost:5001/Login/ForgotPasswordConfirmation" },
                    { 36, 3, 2, "Customer Support Number", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(802), "Site Customer Service Number", "0731143168" },
                    { 37, 3, 2, "Default Email Addresss that overrides Client Email Address in a Test Environment ", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(808), "Site Test Email Account", "carochire@gmail.com" },
                    { 40, 3, 2, "Site Client Create Account URL", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(826), "Site Create Account URL", "https://localhost:5001/Login/CreateAccountConfirmation" },
                    { 16, 3, 6, "Maximum file size that can be uploaded to the System", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(680), "File Maximum UpLoadable Size", "5" },
                    { 7, 3, 7, "Format Used to display date", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(564), "Date Format", "yyyy-MMM-dd" },
                    { 44, 3, 7, "Format Used to display date time", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(571), "Date Format", "yyyy-MMM-dd HH:mm" },
                    { 13, 4, 8, "Email Password", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(660), "Mail Credential Password", "ZGNvaXpoeGlxenZ3dnphaw==" },
                    { 15, 3, 9, "Percentage To Which VAT is calculated on ", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(674), "VAT Percentage", "0.14" },
                    { 35, 3, 2, "Customer Support Email", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(797), "Site Customer Service Email", "carochire@gmail.com" },
                    { 9, 4, 2, "Host used to Send Emails", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(581), "Mail SMTP Host", "smtp.gmail.com" },
                    { 22, 3, 2, "Foot notes that you would like to include on your statement (not mandatory)", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(724), "Report FootNotes", "" },
                    { 2, 3, 2, "Displays Current Version of the System", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(514), "System Version", "1.0.0.0" },
                    { 5, 3, 1, "Allows system to hide exceptions and show custom error page to user", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(558), "Show Custom Exceptions To Users", "true" },
                    { 10, 4, 1, "Enable SSL", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(586), "Mail Enable SSL", "true" },
                    { 11, 4, 1, "Use Default Mail Credentials", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(593), "Mail Use Default Credentials", "false" },
                    { 17, 3, 2, "Account Number Prefix if Any", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(529), "Account Number Prefix", "SS" },
                    { 26, 3, 1, "Option to Save Generated Statement To A physical Location on the Server", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(735), "Statement Save To Folder", "false" },
                    { 28, 3, 1, "Allows to password protect statements being sent by Email", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(753), "Statement Password Protect", "true" },
                    { 30, 3, 1, "Determines if table borders will be shown on the report ", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(759), "Statement Show Table Boarders", "true" },
                    { 39, 3, 1, "Display menus based on User Role", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(820), "Application Role Based Menus", "false" },
                    { 42, 3, 1, "Auto Generate Account Numbers", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(836), "Account Number Auto Generate", "true" },
                    { 43, 3, 1, "Allows System To Be VAT Compliant and Show calculated VAT Amounts ", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(842), "Application Is VAT Compliant", "true" },
                    { 23, 3, 1, "Instructs the System to Advise User to Capture VAT inclusive amounts and calculate breakdown accordingly", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(729), "Capture VAT Inclusive Payments", "true" },
                    { 3, 3, 4, "Displays the minimum year that can be selected  from the system", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(544), "Minimum Year", "2000" },
                    { 8, 4, 4, "Port used to Send Emails", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(576), "Mail SMTP Port", "587" },
                    { 31, 3, 4, "Password Reset Pin Code Length", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(771), "Password Reset Pin Code Length", "5" },
                    { 32, 3, 4, "Password Reset Pin Code Validity Period in Days", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(778), "Password Reset Pin Validity", "2" },
                    { 38, 3, 4, "Current System Environment Set it to 1 For Test Environment  or 2 for Production Environment if no value has been set System defaults to Test Environment ", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(814), "Site Default Environment", "1" },
                    { 41, 3, 4, "Password Validity Period in Days", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(831), "Password Validity Period", "30" },
                    { 1, 3, 2, "Displayed as the Application Name", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(316), "Application Name", "Smart Save" },
                    { 18, 3, 2, "Short Name for Application", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(506), "Application Name Prefix", "SS" },
                    { 6, 3, 4, "Limit Account Number Size", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(522), "Account Number Length", "9" }
                });

            migrationBuilder.InsertData(
                table: "DocumentTypes",
                columns: new[] { "DocumentTypeID", "DocumentFormatID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 4, 1, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 218, DateTimeKind.Local).AddTicks(9684), "Payslips" },
                    { 3, 1, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 218, DateTimeKind.Local).AddTicks(9679), "Proof Of Address" },
                    { 1, 1, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 218, DateTimeKind.Local).AddTicks(8705), "Identity Document" },
                    { 2, 1, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 218, DateTimeKind.Local).AddTicks(9656), "Birth Certificate" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuID", "ActionName", "CSSClass", "ControllerName", "DisplayName", "IsActive", "LastChangedBy", "LastChangedDate", "MenuGroupID", "OrderNo" },
                values: new object[,]
                {
                    { 13, "Assert", "fa fa-lightbulb-o", "Assert", "Asserts", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 223, DateTimeKind.Local).AddTicks(3767), 5, 13 },
                    { 9999, "FeatureFlag", "fa fa-building", "FeatureFlag", "Feature Flags", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 223, DateTimeKind.Local).AddTicks(3805), 999, 9999 },
                    { 9998, "MainMenu", "fa fa-book", "Menus", "Menu", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 223, DateTimeKind.Local).AddTicks(3801), 9998, 9998 },
                    { 20, "Country", "fa fa-globe", "Country", "Country", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 223, DateTimeKind.Local).AddTicks(3798), 5, 20 },
                    { 19, "Currency", "fa fa-money", "Currency", "Currency", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 223, DateTimeKind.Local).AddTicks(3794), 5, 19 },
                    { 17, "Department", "fa fa-building", "Department", "Departments", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 223, DateTimeKind.Local).AddTicks(3785), 5, 17 },
                    { 16, "EmailTemplate", "fa fa-envelope-o", "EmailTemplate", "Email Templates", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 223, DateTimeKind.Local).AddTicks(3778), 5, 16 },
                    { 15, "NoticeBoard", "fa broadcast-tower", "NoticeBoard", "Notice Board", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 223, DateTimeKind.Local).AddTicks(3774), 5, 15 },
                    { 14, "BankAccounts", "fa fa-university", "BankAccounts", "Banks", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 223, DateTimeKind.Local).AddTicks(3771), 5, 14 },
                    { 12, "TransactionType", "fa fa-money", "TransactionType", "Transaction Types", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 223, DateTimeKind.Local).AddTicks(3763), 5, 12 },
                    { 18, "DocumentTypes", "fa fa-file", "DocumentType", "Document Types", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 223, DateTimeKind.Local).AddTicks(3791), 5, 18 },
                    { 10, "Courses", "fa fa-university", "Courses", "Coaching Programmes", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 223, DateTimeKind.Local).AddTicks(3751), 5, 10 },
                    { 9, "Roles", "fa fa-asterisk", "Roles", "Roles & Permissions", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 223, DateTimeKind.Local).AddTicks(3743), 5, 9 },
                    { 8, "Users", "fa fa-user", "User", "User Management", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 223, DateTimeKind.Local).AddTicks(3739), 5, 8 },
                    { 7, "CustomSettings", "fa fa-spinner", "CustomSettings", "Application Settings", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 223, DateTimeKind.Local).AddTicks(3735), 5, 7 },
                    { 6, "Product", "fa fa-product-hunt", "Product", "Products", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 223, DateTimeKind.Local).AddTicks(3732), 3, 6 },
                    { 5, "ScheduleReport", "fa fa-file", "Transactions", "Generated Invoices", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 223, DateTimeKind.Local).AddTicks(3719), 3, 5 },
                    { 4, "Schedule", "fa fa-gear", "Transactions", "Generate Bulk Invoice", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 223, DateTimeKind.Local).AddTicks(3713), 3, 4 },
                    { 3, "Transactions", "fa fa-money", "Transactions", "Transactions", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 223, DateTimeKind.Local).AddTicks(3708), 3, 2 },
                    { 2, "MyAccount", "fa fa-users-user", "Client", "My Account", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 223, DateTimeKind.Local).AddTicks(3701), 2, 0 },
                    { 1, "Clients", "fa fa-users-cog", "Client", "Employees", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 223, DateTimeKind.Local).AddTicks(3495), 2, 1 },
                    { 11, "Companies", "fa-building-o", "Company", "Companies", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 223, DateTimeKind.Local).AddTicks(3760), 5, 11 }
                });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "RolePermissionID", "LastChangedBy", "LastChangedDate", "PermissionID", "RoleID" },
                values: new object[,]
                {
                    { 79, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(320), 79, 1 },
                    { 80, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(321), 80, 1 },
                    { 81, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(323), 81, 1 },
                    { 82, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(325), 82, 1 },
                    { 83, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(326), 83, 1 },
                    { 88, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(334), 88, 1 },
                    { 85, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(329), 85, 1 },
                    { 86, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(331), 86, 1 },
                    { 87, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(333), 87, 1 },
                    { 78, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(318), 78, 1 },
                    { 89, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(336), 89, 1 },
                    { 84, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(328), 84, 1 },
                    { 77, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(317), 77, 1 },
                    { 72, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(309), 72, 1 },
                    { 75, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(313), 75, 1 },
                    { 74, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(312), 74, 1 },
                    { 73, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(310), 73, 1 },
                    { 90, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(338), 90, 1 },
                    { 71, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(307), 71, 1 },
                    { 70, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(305), 70, 1 },
                    { 69, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(304), 69, 1 },
                    { 68, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(302), 68, 1 },
                    { 67, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(301), 67, 1 },
                    { 66, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(299), 66, 1 },
                    { 65, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(287), 65, 1 },
                    { 64, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(286), 64, 1 },
                    { 63, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(284), 63, 1 },
                    { 76, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(315), 76, 1 },
                    { 91, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(339), 91, 1 },
                    { 96, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(347), 96, 1 },
                    { 93, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(342), 93, 1 },
                    { 62, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(282), 62, 1 },
                    { 120, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(386), 120, 1 },
                    { 119, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(384), 119, 1 },
                    { 118, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(383), 118, 1 },
                    { 117, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(381), 117, 1 },
                    { 116, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(379), 116, 1 },
                    { 115, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(378), 115, 1 },
                    { 114, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(376), 114, 1 },
                    { 113, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(375), 113, 1 },
                    { 112, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(373), 112, 1 },
                    { 111, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(371), 111, 1 },
                    { 110, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(370), 110, 1 },
                    { 109, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(368), 109, 1 },
                    { 108, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(366), 108, 1 },
                    { 107, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(365), 107, 1 },
                    { 106, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(363), 106, 1 },
                    { 105, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(362), 105, 1 },
                    { 104, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(360), 104, 1 },
                    { 103, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(358), 103, 1 },
                    { 102, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(357), 102, 1 },
                    { 101, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(355), 101, 1 },
                    { 100, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(354), 100, 1 },
                    { 99, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(352), 99, 1 },
                    { 98, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(350), 98, 1 },
                    { 97, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(349), 97, 1 },
                    { 95, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(346), 95, 1 },
                    { 94, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(344), 94, 1 },
                    { 92, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(341), 92, 1 },
                    { 61, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(281), 61, 1 },
                    { 31, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(231), 31, 1 },
                    { 59, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(278), 59, 1 },
                    { 27, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(224), 27, 1 },
                    { 26, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(223), 26, 1 },
                    { 60, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(279), 60, 1 },
                    { 24, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(219), 24, 1 },
                    { 23, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(218), 23, 1 },
                    { 22, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(216), 22, 1 },
                    { 21, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(215), 21, 1 },
                    { 20, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(213), 20, 1 },
                    { 19, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(211), 19, 1 },
                    { 18, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(210), 18, 1 },
                    { 17, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(207), 17, 1 },
                    { 16, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(205), 16, 1 },
                    { 15, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(204), 15, 1 },
                    { 14, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(202), 14, 1 },
                    { 13, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(200), 13, 1 },
                    { 12, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(199), 12, 1 },
                    { 11, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(197), 11, 1 },
                    { 10, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(196), 10, 1 },
                    { 9, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(193), 9, 1 },
                    { 8, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(191), 8, 1 },
                    { 7, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(190), 7, 1 },
                    { 6, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(188), 6, 1 },
                    { 5, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(183), 5, 1 },
                    { 4, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(181), 4, 1 },
                    { 3, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(180), 3, 1 },
                    { 2, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(177), 2, 1 },
                    { 1, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(76), 1, 1 },
                    { 28, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(226), 28, 1 },
                    { 29, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(228), 29, 1 },
                    { 25, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(221), 25, 1 },
                    { 50, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(263), 50, 1 },
                    { 58, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(276), 58, 1 },
                    { 57, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(274), 57, 1 },
                    { 56, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(273), 56, 1 },
                    { 55, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(271), 55, 1 },
                    { 54, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(269), 54, 1 },
                    { 53, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(268), 53, 1 },
                    { 52, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(266), 52, 1 },
                    { 51, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(265), 51, 1 },
                    { 30, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(229), 30, 1 },
                    { 49, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(261), 49, 1 },
                    { 47, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(258), 47, 1 },
                    { 46, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(256), 46, 1 },
                    { 45, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(255), 45, 1 },
                    { 48, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(260), 48, 1 },
                    { 43, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(252), 43, 1 },
                    { 32, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(232), 32, 1 },
                    { 33, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(234), 33, 1 },
                    { 44, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(253), 44, 1 },
                    { 35, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(239), 35, 1 },
                    { 36, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(240), 36, 1 },
                    { 37, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(242), 37, 1 },
                    { 34, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(237), 34, 1 },
                    { 39, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(245), 39, 1 },
                    { 40, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(247), 40, 1 },
                    { 41, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(248), 41, 1 },
                    { 42, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(250), 42, 1 },
                    { 38, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 182, DateTimeKind.Local).AddTicks(244), 38, 1 }
                });

            migrationBuilder.InsertData(
                table: "TransactionType",
                columns: new[] { "TransactionTypeID", "Code", "Description", "IsActive", "LastChangedBy", "LastChangedDate", "Name", "TransactionStatusID" },
                values: new object[,]
                {
                    { 7, "DEP", null, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 187, DateTimeKind.Local).AddTicks(7176), "Deposit", 1 },
                    { 1, "PAY", null, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 187, DateTimeKind.Local).AddTicks(6038), "Payment", 1 },
                    { 2, "(R)", null, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 187, DateTimeKind.Local).AddTicks(6768), "Reversal", 1 },
                    { 3, "PURCH", null, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 187, DateTimeKind.Local).AddTicks(6856), "Purchase", 1 },
                    { 4, "SALE", null, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 187, DateTimeKind.Local).AddTicks(6937), "Sales", 1 },
                    { 5, "RPT", null, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 187, DateTimeKind.Local).AddTicks(7016), "Receipts", 1 },
                    { 6, "RECON", null, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 187, DateTimeKind.Local).AddTicks(7087), "Recon", 1 },
                    { 8, "FEE", null, true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 187, DateTimeKind.Local).AddTicks(7236), "Fee", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "EmailAddress", "FirstName", "IDNumber", "IsActive", "LastChangedBy", "LastChangedDate", "LastName", "Password", "PasswordExpiryDate", "UserName", "UserTypeID" },
                values: new object[,]
                {
                    { 2, "carochire89@gmail.com", "John", "0000000000000", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 210, DateTimeKind.Local).AddTicks(9685), "Jarani", "YWRtaW4=", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employer", 2 },
                    { 1, "carochire@gmail.com", "Wadzanai", "8904161200188", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 208, DateTimeKind.Local).AddTicks(5557), "Chirenje", "YWRtaW4=", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SuperUser", 1 },
                    { 3, "carolinesolutions89@gmail.com", "Ndini", "1111111111111", true, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 211, DateTimeKind.Local).AddTicks(458), "Ndadaro", "YWRtaW4=", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee", 3 }
                });

            migrationBuilder.InsertData(
                table: "RoleMenus",
                columns: new[] { "RoleMenuID", "LastChangedBy", "LastChangedDate", "MenuID", "RoleID" },
                values: new object[,]
                {
                    { 1, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(6766), 1, 1 },
                    { 22, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(6889), 9999, 1 },
                    { 21, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(6887), 9998, 1 },
                    { 20, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(6886), 20, 1 },
                    { 19, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(6884), 19, 1 },
                    { 18, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(6882), 18, 1 },
                    { 17, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(6879), 17, 1 },
                    { 16, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(6878), 16, 1 },
                    { 15, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(6876), 15, 1 },
                    { 14, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(6875), 14, 1 },
                    { 13, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(6873), 13, 1 },
                    { 12, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(6871), 12, 1 },
                    { 11, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(6870), 11, 1 },
                    { 10, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(6868), 10, 1 },
                    { 9, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(6865), 9, 1 },
                    { 8, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(6864), 8, 1 },
                    { 7, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(6862), 7, 1 },
                    { 6, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(6860), 6, 1 },
                    { 5, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(6855), 5, 1 },
                    { 4, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(6853), 4, 1 },
                    { 3, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(6852), 3, 1 },
                    { 2, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 233, DateTimeKind.Local).AddTicks(6849), 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserID", "RoleID", "LastChangedBy", "LastChangedDate", "UserRoleID" },
                values: new object[,]
                {
                    { 1, 1, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 219, DateTimeKind.Local).AddTicks(4549), 1 },
                    { 2, 3, "SuperUser", new DateTime(2020, 10, 9, 16, 17, 57, 219, DateTimeKind.Local).AddTicks(4640), 2 }
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
                name: "IX_ClientFees_ProductFeeID",
                table: "ClientFees",
                column: "ProductFeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientGuarantors_ClientID",
                table: "ClientGuarantors",
                column: "ClientID");

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
                name: "ClientGuarantors");

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
