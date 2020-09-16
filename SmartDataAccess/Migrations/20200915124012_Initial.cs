using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditActions",
                columns: table => new
                {
                    AuditActionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditActions", x => x.AuditActionID);
                });

            migrationBuilder.CreateTable(
                name: "AuditEntries",
                columns: table => new
                {
                    AuditEntryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    AuditActionID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditEntries", x => x.AuditEntryID);
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
                name: "BroadCasts",
                columns: table => new
                {
                    BroadCastID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    DisplaySite = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    EffectiveFrom = table.Column<DateTime>(nullable: false),
                    EffectiveTo = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BroadCasts", x => x.BroadCastID);
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
                    IsDefault = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyID);
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
                    Credits = table.Column<int>(nullable: false),
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
                    DateLogged = table.Column<DateTime>(nullable: false)
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
                name: "ProductFrequencies",
                columns: table => new
                {
                    ProductFrequencyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFrequencies", x => x.ProductFrequencyID);
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
                name: "TransactionType",
                columns: table => new
                {
                    TransactionTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionType", x => x.TransactionTypeID);
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
                    IsActive = table.Column<bool>(nullable: false),
                    SendToGuardian = table.Column<bool>(nullable: false),
                    SendToClient = table.Column<bool>(nullable: false)
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
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ProductCode = table.Column<string>(nullable: true),
                    ProductFrequencyID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CompanyID = table.Column<int>(nullable: false)
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
                        name: "FK_Products_ProductFrequencies_ProductFrequencyID",
                        column: x => x.ProductFrequencyID,
                        principalTable: "ProductFrequencies",
                        principalColumn: "ProductFrequencyID",
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
                    RoleID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
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
                    LastName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
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
                name: "ProductNotes",
                columns: table => new
                {
                    ProductNoteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: false),
                    UserTypeID = table.Column<int>(nullable: false),
                    DateUploaded = table.Column<DateTime>(nullable: false),
                    DateClosed = table.Column<DateTime>(nullable: true),
                    DueDate = table.Column<DateTime>(nullable: false),
                    UploadedBy = table.Column<string>(nullable: true),
                    ProductID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductNotes", x => x.ProductNoteID);
                    table.ForeignKey(
                        name: "FK_ProductNotes_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductNotes_UserTypes_UserTypeID",
                        column: x => x.UserTypeID,
                        principalTable: "UserTypes",
                        principalColumn: "UserTypeID",
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
                    UserRoleID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
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
                name: "ClientBoard",
                columns: table => new
                {
                    ClientBoardID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    ClientID = table.Column<int>(nullable: false),
                    Details = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    SendToParent = table.Column<bool>(nullable: false),
                    SendToClient = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientBoard", x => x.ClientBoardID);
                    table.ForeignKey(
                        name: "FK_ClientBoard_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
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
                    ClientID = table.Column<int>(nullable: false)
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
                    ClientID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    BankAccountID = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Month = table.Column<int>(nullable: false),
                    TransactionTypeID = table.Column<int>(nullable: false),
                    TransactionTypesTransactionTypeID = table.Column<int>(nullable: true),
                    PaymentStatusID = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountExclVAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                        name: "FK_Transactions_TransactionType_TransactionTypesTransactionTypeID",
                        column: x => x.TransactionTypesTransactionTypeID,
                        principalTable: "TransactionType",
                        principalColumn: "TransactionTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "BankAccountTypes",
                columns: new[] { "BankAccountTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 727, DateTimeKind.Local).AddTicks(6954), "Savings" },
                    { 2, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 727, DateTimeKind.Local).AddTicks(7735), "Cheque" },
                    { 3, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 727, DateTimeKind.Local).AddTicks(7752), "Credit" },
                    { 4, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 727, DateTimeKind.Local).AddTicks(7757), "Cash" }
                });

            migrationBuilder.InsertData(
                table: "ContactTypes",
                columns: new[] { "ContactTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 4, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 741, DateTimeKind.Local).AddTicks(7974), "Cell Phone" },
                    { 3, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 741, DateTimeKind.Local).AddTicks(8139), "Email Address" },
                    { 2, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 741, DateTimeKind.Local).AddTicks(8148), "Postal Address" },
                    { 1, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 741, DateTimeKind.Local).AddTicks(8155), "Residential Address" },
                    { 5, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 741, DateTimeKind.Local).AddTicks(8161), "Telephone" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 156, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2978), "Norway" },
                    { 155, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2974), "N Mariana Islands" },
                    { 154, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2969), "Nigeria" },
                    { 153, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2966), "Niger" },
                    { 152, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2962), "Nicaragua" },
                    { 147, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2941), "Nepal" },
                    { 149, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2949), "Netherlands Antilles" },
                    { 148, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2945), "Netherlands" },
                    { 157, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2982), "Oman" },
                    { 146, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2937), "Nauru" },
                    { 151, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2958), "New Zealand" },
                    { 158, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2986), "Pakistan" },
                    { 162, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3002), "Paraguay" },
                    { 160, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2994), "Panama" },
                    { 161, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2999), "Papua New Guinea" },
                    { 145, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2933), "Namibia" },
                    { 163, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3006), "Peru" },
                    { 164, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3010), "Philippines" },
                    { 165, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3013), "Poland" },
                    { 166, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3017), "Portugal" },
                    { 167, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3022), "Puerto Rico" },
                    { 168, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3025), "Qatar" },
                    { 169, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3029), "Reunion" },
                    { 170, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3033), "Romania" },
                    { 159, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2990), "Palau" },
                    { 144, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2929), "Mozambique" },
                    { 139, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2910), "Moldova" },
                    { 142, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2921), "Montserrat" },
                    { 117, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2812), "Lebanon" },
                    { 118, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2825), "Lesotho" },
                    { 119, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2829), "Liberia" },
                    { 120, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2833), "Libya" },
                    { 121, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2836), "Liechtenstein" },
                    { 122, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2840), "Lithuania" },
                    { 123, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2844), "Luxembourg" },
                    { 124, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2848), "Macau" },
                    { 125, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2852), "Macedonia" },
                    { 126, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2856), "Madagascar" },
                    { 127, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2860), "Malawi" },
                    { 128, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2863), "Malaysia" },
                    { 129, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2867), "Maldives" },
                    { 130, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2874), "Mali" },
                    { 131, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2877), "Malta" },
                    { 132, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2882), "Marshall Islands" },
                    { 133, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2886), "Martinique" },
                    { 134, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2890), "Mauritania" },
                    { 135, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2893), "Mauritius" },
                    { 136, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2897), "Mayotte" },
                    { 137, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2901), "Mexico" },
                    { 138, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2906), "Micronesia Fed St" },
                    { 171, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3036), "Russia" },
                    { 140, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2913), "Monaco" },
                    { 141, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2917), "Mongolia" },
                    { 143, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2925), "Morocco" },
                    { 172, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3049), "Rwanda" },
                    { 177, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3075), "Saint Vincent and the Grenadines" },
                    { 174, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3059), "Saint Kitts Nevis" },
                    { 204, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3181), "Togo" },
                    { 205, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3185), "Tonga" },
                    { 206, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3189), "Trinidad Tobago" },
                    { 207, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3193), "Tunisia" },
                    { 208, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3197), "Turkey" },
                    { 209, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3201), "Turkmenistan" },
                    { 210, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3205), "Turks Caicos Is" },
                    { 211, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3209), "Tuvalu" },
                    { 212, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3213), "Uganda" },
                    { 213, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3217), "Ukraine" },
                    { 214, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3221), "United Arab Emirates" },
                    { 215, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3226), "United Kingdom" },
                    { 216, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3230), "United States" },
                    { 217, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3234), "Uruguay" },
                    { 218, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3237), "Uzbekistan" },
                    { 219, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3241), "Vanuatu" },
                    { 220, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3245), "Venezuela" },
                    { 221, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3249), "Vietnam" },
                    { 222, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3253), "Virgin Islands" },
                    { 223, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3257), "Wallis Futuna" },
                    { 224, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3262), "West Bank" },
                    { 225, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3266), "Western Sahara" },
                    { 226, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3270), "Yemen" },
                    { 227, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3274), "Zambia" },
                    { 228, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3277), "Zimbabwe" },
                    { 203, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3177), "Thailand" },
                    { 173, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3054), "Saint Helena" },
                    { 202, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3174), "Tanzania" },
                    { 200, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3166), "Taiwan" },
                    { 175, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3063), "Saint Lucia" },
                    { 176, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3068), "St Pierre Miquelon" },
                    { 116, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2809), "Latvia" },
                    { 178, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3078), "Samoa" },
                    { 179, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3082), "San Marino" },
                    { 180, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3087), "Sao Tome Principe" },
                    { 181, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3091), "Saudi Arabia" },
                    { 182, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3095), "Senegal" },
                    { 183, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3099), "Serbia" },
                    { 184, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3103), "Seychelles" },
                    { 185, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3107), "Sierra Leone" },
                    { 186, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3112), "Singapore" },
                    { 187, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3116), "Slovakia" },
                    { 188, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3119), "Slovenia" },
                    { 189, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3124), "Solomon Islands" },
                    { 190, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3127), "Somalia" },
                    { 191, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3131), "South Africa" },
                    { 192, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3135), "Spain" },
                    { 193, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3139), "Sri Lanka" },
                    { 194, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3143), "Sudan" },
                    { 195, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3147), "Suriname" },
                    { 196, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3151), "Swaziland" },
                    { 197, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3154), "Sweden" },
                    { 198, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3158), "Switzerland" },
                    { 199, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3162), "Syria" },
                    { 201, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(3170), "Tajikistan" },
                    { 115, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2805), "Laos" },
                    { 150, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2954), "New Caledonia" },
                    { 113, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2797), "Kuwait" },
                    { 30, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2428), "British Virgin Is" },
                    { 31, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2433), "Brunei" },
                    { 32, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2437), "Bulgaria" },
                    { 33, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2441), "Burkina Faso" },
                    { 34, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2447), "Burma" },
                    { 35, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2451), "Burundi" },
                    { 36, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2454), "Cambodia" },
                    { 37, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2458), "Cameroon" },
                    { 38, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2462), "Canada" },
                    { 39, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2467), "Cape Verde" },
                    { 40, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2472), "Cayman Islands" },
                    { 41, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2477), "Central African Rep" },
                    { 42, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2480), "Chad" },
                    { 43, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2484), "Chile" },
                    { 44, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2488), "China" },
                    { 45, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2492), "Colombia" },
                    { 46, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2496), "Comoros" },
                    { 47, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2501), "Congo Dem Rep" },
                    { 48, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2506), "Congo Repub of the" },
                    { 49, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2511), "Cook Islands" },
                    { 50, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2516), "Costa Rica" },
                    { 51, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2520), "Cote dIvoire" },
                    { 52, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2524), "Croatia" },
                    { 53, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2528), "Cuba" },
                    { 54, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2532), "Cyprus" },
                    { 29, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2422), "Brazil" },
                    { 55, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2536), "Czech Republic" },
                    { 28, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2418), "Botswana" },
                    { 26, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2409), "Bolivia" },
                    { 1, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(1719), "Afghanistan" },
                    { 2, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2292), "Albania" },
                    { 3, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2300), "Algeria" },
                    { 4, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2311), "American Samoa" },
                    { 5, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2315), "Andorra" },
                    { 6, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2326), "Angola" },
                    { 7, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2330), "Anguilla" },
                    { 8, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2335), "Antigua Barbuda" },
                    { 9, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2339), "Argentina" },
                    { 10, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2345), "Armenia" },
                    { 11, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2348), "Aruba" },
                    { 12, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2352), "Australia" },
                    { 13, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2356), "Austria" },
                    { 14, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2360), "Azerbaijan" },
                    { 15, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2364), "Bahamas" },
                    { 16, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2369), " The" },
                    { 114, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2800), "Kyrgyzstan" },
                    { 18, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2379), "Bangladesh" },
                    { 19, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2383), "Barbados" },
                    { 20, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2387), "Belarus" },
                    { 21, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2390), "Belgium" },
                    { 22, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2394), "Belize" },
                    { 23, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2398), "Benin" },
                    { 24, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2402), "Bermuda" },
                    { 25, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2406), "Bhutan" },
                    { 27, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2415), "Bosnia Herzegovina" },
                    { 56, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2567), "Denmark" },
                    { 17, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2373), "Bahrain" },
                    { 58, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2575), "Dominica" },
                    { 88, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2699), "Guinea" },
                    { 89, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2704), "Guinea Bissau" },
                    { 90, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2707), "Guyana" },
                    { 91, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2711), "Haiti" },
                    { 92, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2715), "Honduras" },
                    { 93, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2719), "Hong Kong" },
                    { 94, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2723), "Hungary" },
                    { 95, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2727), "Iceland" },
                    { 96, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2730), "India" },
                    { 97, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2734), "Indonesia" },
                    { 98, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2738), "Iran" },
                    { 99, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2741), "Iraq" },
                    { 100, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2745), "Ireland" },
                    { 101, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2750), "Isle of Man" },
                    { 102, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2754), "Israel" },
                    { 103, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2758), "Italy" },
                    { 105, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2765), "Japan" },
                    { 106, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2769), "Jersey" },
                    { 107, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2773), "Jordan" },
                    { 108, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2777), "Kazakhstan" },
                    { 109, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2781), "Kenya" },
                    { 110, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2784), "Kiribati" },
                    { 111, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2789), "Korea North" },
                    { 112, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2793), "Korea South" },
                    { 57, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2571), "Djibouti" },
                    { 87, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2695), "Guernsey" },
                    { 86, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2691), "Guatemala" },
                    { 104, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2761), "Jamaica" },
                    { 84, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2683), "Guadeloupe" },
                    { 59, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2580), "Dominican Republic" },
                    { 85, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2687), "Guam" },
                    { 60, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2585), "East Timor" },
                    { 61, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2589), "Ecuador" },
                    { 62, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2593), "Egypt" },
                    { 63, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2597), "El Salvador" },
                    { 65, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2606), "Eritrea" },
                    { 66, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2612), "Estonia" },
                    { 67, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2616), "Ethiopia" },
                    { 68, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2621), "Faroe Islands" },
                    { 69, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2624), "Fiji" },
                    { 70, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2628), "Finland" },
                    { 71, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2632), "France" },
                    { 64, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2602), "Equatorial Guinea" },
                    { 73, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2641), "French Polynesia" },
                    { 72, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2636), "French Guiana" },
                    { 83, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2679), "Grenada" },
                    { 81, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2672), "Greece" },
                    { 80, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2668), "Gibraltar" },
                    { 82, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2676), "Greenland" },
                    { 79, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2664), "Ghana" },
                    { 77, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2657), "Georgia" },
                    { 76, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2653), "Gaza Strip" },
                    { 75, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2649), "Gambia The" },
                    { 74, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2645), "Gabon" },
                    { 78, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 751, DateTimeKind.Local).AddTicks(2661), "Germany" }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "CurrencyID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 106, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5469), "NZD" },
                    { 107, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5476), "OMR" },
                    { 105, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5456), "NPR" },
                    { 108, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5482), "PAB" },
                    { 109, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5489), "PEN" },
                    { 110, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5494), "PGK" },
                    { 111, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5499), "PHP" },
                    { 116, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5539), "RON" },
                    { 113, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5520), "PLN" },
                    { 114, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5526), "PYG" },
                    { 115, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5532), "QAR" },
                    { 117, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5549), "RSD" },
                    { 118, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5557), "RUB" },
                    { 120, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5570), "SAR" },
                    { 104, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5449), "NOK" },
                    { 119, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5563), "RWF" },
                    { 112, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5510), "PKR" },
                    { 103, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5444), "NIO" },
                    { 90, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5342), "MKD" },
                    { 101, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5430), "NAD" },
                    { 84, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5286), "LRD" },
                    { 121, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5578), "SBD" },
                    { 85, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5291), "LSL" },
                    { 86, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5296), "LYD" },
                    { 87, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5305), "MAD" },
                    { 88, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5311), "MDL" },
                    { 89, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5320), "MGA" },
                    { 91, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5353), "MMK" },
                    { 92, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5362), "MNT" },
                    { 93, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5368), "MOP" },
                    { 94, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5383), "MRU" },
                    { 95, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5392), "MUR" },
                    { 96, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5396), "MVR" },
                    { 97, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5404), "MWK" },
                    { 98, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5411), "MXN" },
                    { 99, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5419), "MYR" },
                    { 100, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5425), "MZN" },
                    { 102, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5435), "NGN" },
                    { 122, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5585), "SCR" },
                    { 150, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5794), "VEF" },
                    { 124, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5606), "SEK" },
                    { 146, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5761), "UGX" },
                    { 147, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5767), "USD" },
                    { 148, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5772), "UYU" },
                    { 149, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5789), "UZS" },
                    { 151, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5801), "VND" },
                    { 152, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5807), "VUV" },
                    { 153, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5811), "WST" },
                    { 154, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5816), "XAF" },
                    { 155, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5821), "XCD" },
                    { 156, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5827), "XDR" },
                    { 157, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5831), "XOF" },
                    { 158, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5837), "XPF" },
                    { 159, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5845), "YER" },
                    { 160, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5850), "ZAR" },
                    { 161, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5857), "ZMW" },
                    { 162, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5863), "ZWD" },
                    { 83, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5277), "LKR" },
                    { 145, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5756), "UAH" },
                    { 123, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5599), "SDG" },
                    { 144, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5750), "TZS" },
                    { 142, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5733), "TVD" },
                    { 125, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5614), "SGD" },
                    { 126, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5620), "SHP" },
                    { 127, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5628), "SLL" },
                    { 128, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5633), "SOS" },
                    { 129, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5637), "SPL" },
                    { 130, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5650), "SRD" },
                    { 131, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5657), "STN" },
                    { 132, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5663), "SVC" },
                    { 133, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5669), "SYP" },
                    { 134, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5680), "SZL" },
                    { 135, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5686), "THB" },
                    { 136, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5693), "TJS" },
                    { 137, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5700), "TMT" },
                    { 138, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5706), "TND" },
                    { 139, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5712), "TOP" },
                    { 140, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5719), "TRY" },
                    { 141, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5726), "TTD" },
                    { 143, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5744), "TWD" },
                    { 82, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5268), "LBP" },
                    { 26, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4834), "CAD" },
                    { 80, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5251), "KZT" },
                    { 21, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4795), "BSD" },
                    { 22, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4802), "BTN" },
                    { 23, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4812), "BWP" },
                    { 24, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4819), "BYN" },
                    { 25, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4827), "BZD" },
                    { 27, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4876), "CDF" },
                    { 28, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4885), "CHF" },
                    { 20, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4785), "BRL" },
                    { 29, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4890), "CLP" },
                    { 31, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4906), "COP" },
                    { 32, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4918), "CRC" },
                    { 34, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4943), "CUP" },
                    { 35, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4950), "CVE" },
                    { 36, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4955), "CZK" },
                    { 37, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4966), "DJF" },
                    { 38, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4972), "DKK" },
                    { 30, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4897), "CNY" },
                    { 19, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4777), "BOB" },
                    { 18, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4768), "BND" },
                    { 17, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4755), "BMD" },
                    { 81, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5258), "LAK" },
                    { 1, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(3840), "AED" },
                    { 2, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4637), "AFN" },
                    { 3, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4647), "ALL" },
                    { 4, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4653), "AMD" },
                    { 5, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4657), "ANG" },
                    { 6, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4675), "AOA" },
                    { 7, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4680), "ARS" },
                    { 8, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4684), "AUD" },
                    { 9, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4689), "AWG" },
                    { 10, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4696), "AZN" },
                    { 11, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4701), "BAM" },
                    { 12, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4706), "BBD" },
                    { 13, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4716), "BDT" },
                    { 14, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4729), "BGN" },
                    { 15, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4737), "BHD" },
                    { 16, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4748), "BIF" },
                    { 39, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4978), "DOP" },
                    { 40, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4985), "DZD" },
                    { 33, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4930), "CUC" },
                    { 42, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4997), "ERN" },
                    { 63, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5127), "IMP" },
                    { 64, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5134), "INR" },
                    { 65, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5141), "IQD" },
                    { 41, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(4992), "EGP" },
                    { 67, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5161), "ISK" },
                    { 68, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5167), "JEP" },
                    { 69, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5174), "JMD" },
                    { 70, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5179), "JOD" },
                    { 71, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5187), "JPY" },
                    { 72, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5195), "KES" },
                    { 73, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5202), "KGS" },
                    { 74, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5207), "KHR" },
                    { 75, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5215), "KMF" },
                    { 76, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5222), "KPW" },
                    { 77, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5229), "KRW" },
                    { 78, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5235), "KWD" },
                    { 79, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5244), "KYD" },
                    { 62, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5121), "ILS" },
                    { 61, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5114), "IDR" },
                    { 66, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5151), "IRR" },
                    { 59, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5102), "HTG" },
                    { 43, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5005), "ETB" },
                    { 44, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5011), "EUR" },
                    { 60, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5106), "HUF" },
                    { 46, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5027), "FKP" },
                    { 47, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5032), "GBP" },
                    { 48, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5038), "GEL" },
                    { 49, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5045), "GGP" },
                    { 50, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5051), "GHS" },
                    { 45, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5018), "FJD" },
                    { 52, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5065), "GMD" },
                    { 53, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5070), "GNF" },
                    { 58, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5097), "HRK" },
                    { 51, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5058), "GIP" },
                    { 54, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5074), "GTQ" },
                    { 55, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5078), "GYD" },
                    { 56, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5086), "HKD" },
                    { 57, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 732, DateTimeKind.Local).AddTicks(5090), "HNL" }
                });

            migrationBuilder.InsertData(
                table: "CustomSettingTypes",
                columns: new[] { "CustomSettingTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 3, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 744, DateTimeKind.Local).AddTicks(3073), "All" },
                    { 4, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 744, DateTimeKind.Local).AddTicks(3079), "Email" },
                    { 1, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 744, DateTimeKind.Local).AddTicks(2885), "BackEnd" },
                    { 2, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 744, DateTimeKind.Local).AddTicks(3065), "Portal" }
                });

            migrationBuilder.InsertData(
                table: "DocumentFormats",
                columns: new[] { "DocumentFormatID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 766, DateTimeKind.Local).AddTicks(9121), "pdf" },
                    { 6, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 767, DateTimeKind.Local).AddTicks(668), "ppt" },
                    { 5, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 767, DateTimeKind.Local).AddTicks(652), "rtf" },
                    { 4, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 767, DateTimeKind.Local).AddTicks(648), "txt" },
                    { 3, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 767, DateTimeKind.Local).AddTicks(642), "xlsx" },
                    { 2, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 767, DateTimeKind.Local).AddTicks(617), "doc" }
                });

            migrationBuilder.InsertData(
                table: "EmailTypes",
                columns: new[] { "EmailTypeID", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 3, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 782, DateTimeKind.Local).AddTicks(3683), "Invoice" },
                    { 2, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 782, DateTimeKind.Local).AddTicks(3675), "Proof Of Payment" },
                    { 1, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 782, DateTimeKind.Local).AddTicks(3107), "Client Statement" }
                });

            migrationBuilder.InsertData(
                table: "FeatureFlags",
                columns: new[] { "FeatureFlagID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 2, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 763, DateTimeKind.Local).AddTicks(8504), "CC Client On Error" },
                    { 3, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 763, DateTimeKind.Local).AddTicks(8514), "Enable Document Emailing Functionality" },
                    { 1, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 763, DateTimeKind.Local).AddTicks(8028), "Send Email On Error" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 747, DateTimeKind.Local).AddTicks(2633), "Female" },
                    { 2, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 747, DateTimeKind.Local).AddTicks(2881), "Male" }
                });

            migrationBuilder.InsertData(
                table: "MenuGroups",
                columns: new[] { "MenuGroupID", "CSSClass", "Description", "DisplayName", "IsActive", "IsActiveMenu", "LastChangedBy", "LastChangedDate", "OrderNo" },
                values: new object[] { 5, "fa fa-tools", null, "Administration", true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 774, DateTimeKind.Local).AddTicks(93), 4 });

            migrationBuilder.InsertData(
                table: "MenuGroups",
                columns: new[] { "MenuGroupID", "CSSClass", "Description", "DisplayName", "IsActive", "IsActiveMenu", "LastChangedBy", "LastChangedDate", "OrderNo" },
                values: new object[,]
                {
                    { 999, "fa fa - laptop", null, "Developer Menu", true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 774, DateTimeKind.Local).AddTicks(127), 7 },
                    { 9998, "fa fa-university", null, "Menu", true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 774, DateTimeKind.Local).AddTicks(114), 6 },
                    { 4, "fa fa-wrench", null, "Settings", true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 774, DateTimeKind.Local).AddTicks(98), 5 },
                    { 3, "fa fa-money", null, "Accounting", true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 774, DateTimeKind.Local).AddTicks(87), 3 },
                    { 1, "fa fa-umbrella", null, "DashBoard", true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 773, DateTimeKind.Local).AddTicks(9856), 1 },
                    { 2, "fa-user-circle", null, "Clients", true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 774, DateTimeKind.Local).AddTicks(78), 2 }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "PaymentStatusID", "Description", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 4, null, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 719, DateTimeKind.Local).AddTicks(9261), "Refunded" },
                    { 3, null, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 719, DateTimeKind.Local).AddTicks(9255), "Pending" },
                    { 2, null, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 719, DateTimeKind.Local).AddTicks(9242), "Reversed" },
                    { 1, null, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 719, DateTimeKind.Local).AddTicks(8441), "Paid" },
                    { 5, null, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 719, DateTimeKind.Local).AddTicks(9268), "Discounted" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "Description", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 41, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9411), "Add Menu" },
                    { 34, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9332), "Route Enquiry" },
                    { 33, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9322), "Respond To Enquiry" },
                    { 31, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9306), "Delete Department" },
                    { 30, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9298), "Deactivate Department" },
                    { 29, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9289), "Activate Department" },
                    { 28, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9281), "Update Department" },
                    { 27, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9274), "Add Department" },
                    { 36, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9347), "Close Enquiry" },
                    { 37, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9353), "Capture Payment" },
                    { 38, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9360), "Refund Payment" },
                    { 39, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9398), "Reverse Payment" },
                    { 40, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9405), "Void Payment" },
                    { 35, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9340), "Suspend Enquiry" },
                    { 42, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9418), "Update Menu" },
                    { 32, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9314), "View Department" },
                    { 44, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9433), "Deactivate Menu" },
                    { 45, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9444), "Delete Menu" },
                    { 46, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9451), "View Menu" },
                    { 47, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9459), "Add Course" },
                    { 48, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9467), "Update Course" },
                    { 26, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9265), "View Product" },
                    { 49, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9474), "Delete Course" },
                    { 50, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9481), "View Course" },
                    { 51, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9488), "Update Custom Setting" },
                    { 52, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9495), "View Custom Setting" },
                    { 53, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9502), "Add Document Type" },
                    { 54, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9509), "Update Document Type" },
                    { 55, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9516), "Delete Document Type" },
                    { 56, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9526), "View Document Type" },
                    { 43, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9425), "Activate Menu" },
                    { 25, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9258), "Delete Product" },
                    { 20, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9222), "View Role" },
                    { 23, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9244), "Activate Product" },
                    { 1, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(8221), "Add User" },
                    { 2, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9042), "Update User" },
                    { 3, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9065), "Activate User" },
                    { 4, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9075), "Deactivate User" },
                    { 5, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9083), "Delete User" },
                    { 24, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9251), "Deactivate Product" },
                    { 7, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9111), "Change User Password" },
                    { 8, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9120), "Add Client" },
                    { 9, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9129), "Update Client" },
                    { 10, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9140), "Activate Client" },
                    { 11, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9149), "Deactivate Client" },
                    { 6, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9102), "View User" },
                    { 13, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9165), "View Client" },
                    { 14, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9173), "Change Client Password" },
                    { 15, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9182), "Add Role" },
                    { 16, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9191), "Update Role" },
                    { 17, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9198), "Activate Role" },
                    { 18, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9208), "Deactivate Role" },
                    { 19, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9216), "Delete Role" },
                    { 21, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9230), "Add Product" },
                    { 22, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9237), "Update Product" },
                    { 12, null, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 713, DateTimeKind.Local).AddTicks(9157), "Delete Client" }
                });

            migrationBuilder.InsertData(
                table: "PriorityRanks",
                columns: new[] { "PriorityRankID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 4, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 752, DateTimeKind.Local).AddTicks(9766), "Low" },
                    { 3, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 752, DateTimeKind.Local).AddTicks(9761), "Medium" },
                    { 2, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 752, DateTimeKind.Local).AddTicks(9753), "High" },
                    { 1, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 752, DateTimeKind.Local).AddTicks(9528), "Critical" }
                });

            migrationBuilder.InsertData(
                table: "ProductFrequencies",
                columns: new[] { "ProductFrequencyID", "Description", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 5, null, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 736, DateTimeKind.Local).AddTicks(4988), "Yearly" },
                    { 4, null, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 736, DateTimeKind.Local).AddTicks(4982), "Bi Annually" },
                    { 1, null, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 736, DateTimeKind.Local).AddTicks(4194), "Weekly" },
                    { 3, null, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 736, DateTimeKind.Local).AddTicks(4968), "Quaterly" },
                    { 2, null, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 736, DateTimeKind.Local).AddTicks(4952), "Monthly" }
                });

            migrationBuilder.InsertData(
                table: "RelationshipTypes",
                columns: new[] { "RelationshipTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 3, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 742, DateTimeKind.Local).AddTicks(9549), "Sibling" },
                    { 4, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 742, DateTimeKind.Local).AddTicks(9552), "Spouse" },
                    { 5, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 742, DateTimeKind.Local).AddTicks(9554), "Other" },
                    { 1, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 742, DateTimeKind.Local).AddTicks(9355), "Mother" },
                    { 2, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 742, DateTimeKind.Local).AddTicks(9543), "Father" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "Description", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[] { 1, null, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 706, DateTimeKind.Local).AddTicks(311), "Super-Admin" });

            migrationBuilder.InsertData(
                table: "SystemVariableTypes",
                columns: new[] { "CustomVariableTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 8, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 746, DateTimeKind.Local).AddTicks(2207), "Password" },
                    { 1, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 746, DateTimeKind.Local).AddTicks(1166), "Boolean" },
                    { 5, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 746, DateTimeKind.Local).AddTicks(2138), "Double" },
                    { 4, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 746, DateTimeKind.Local).AddTicks(2152), "Integer" },
                    { 3, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 746, DateTimeKind.Local).AddTicks(2159), "Long" },
                    { 2, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 746, DateTimeKind.Local).AddTicks(2166), "String" },
                    { 6, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 746, DateTimeKind.Local).AddTicks(2185), "Decimal" },
                    { 7, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 746, DateTimeKind.Local).AddTicks(2200), "Date Time" },
                    { 9, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 746, DateTimeKind.Local).AddTicks(2213), "Percentage" }
                });

            migrationBuilder.InsertData(
                table: "TransactionType",
                columns: new[] { "TransactionTypeID", "Description", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 4, null, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 723, DateTimeKind.Local).AddTicks(8788), "Void" },
                    { 5, null, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 723, DateTimeKind.Local).AddTicks(8793), "Discount" },
                    { 2, null, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 723, DateTimeKind.Local).AddTicks(8775), "Reversal" },
                    { 1, null, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 723, DateTimeKind.Local).AddTicks(7974), "Payment" },
                    { 3, null, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 723, DateTimeKind.Local).AddTicks(8783), "Refund" }
                });

            migrationBuilder.InsertData(
                table: "UserTypes",
                columns: new[] { "UserTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 740, DateTimeKind.Local).AddTicks(2915), "Administrator" },
                    { 2, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 740, DateTimeKind.Local).AddTicks(3578), "Employer" },
                    { 3, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 740, DateTimeKind.Local).AddTicks(3594), "Client" },
                    { 4, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 740, DateTimeKind.Local).AddTicks(3600), "Visitor" }
                });

            migrationBuilder.InsertData(
                table: "WeekDays",
                columns: new[] { "WeekDayID", "Name" },
                values: new object[,]
                {
                    { 5, "Thursday" },
                    { 4, "Wednesday" },
                    { 6, "Friday" },
                    { 2, "Monday" },
                    { 1, "Sunday" },
                    { 3, "Tuesday" },
                    { 7, "Saturday" }
                });

            migrationBuilder.InsertData(
                table: "CustomSettings",
                columns: new[] { "CustomSettingID", "CustomSettingTypeID", "CustomVariableTypeID", "Description", "IsActive", "LastChangedBy", "LastChangedDate", "Name", "Value" },
                values: new object[,]
                {
                    { 4, 3, 1, "Allows system to BroadCast System Messages", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(3207), "BroadCast Messages", "true" },
                    { 15, 3, 9, "Percentage To Which VAT is calculated on ", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(3266), "VAT Percentage", "0.14" },
                    { 13, 4, 8, "Email Password", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(3256), "Mail Credential Password", "" },
                    { 7, 3, 7, "Format Used to display date", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(3219), "Date Format", "yyyy-MMM-dd HH:mm" },
                    { 16, 3, 6, "Maximum file size that can be uploaded to the System", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(3275), "File Maximum UpLoadable Size", "5" },
                    { 25, 3, 2, "Default Email Subject Name Used By Auto-Generated Emails", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(3366), "Mail Default Subject", "Smart Save  Admin" },
                    { 29, 3, 2, "Password Used to Open Password Protected Statement By System Administrators", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(3350), "Statement Password For Admin", "123456" },
                    { 27, 3, 2, "Physical Location on the Server where  Statements Are Generated", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(3344), "Statement Save To Physical Location", "C:\\SmartApp\\Statements" },
                    { 22, 3, 2, "Foot notes that you would like to include on your statement (not mandatory)", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(3297), "Report FootNotes", "" },
                    { 20, 3, 2, "Additional Line on the Report Footer (can be blank)", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(3286), "Report Footer 2", "*Executive." },
                    { 19, 3, 2, "First Line on the Report Footer", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(3280), "Report Footer 1", "W. Guri Mrs. (Chairman), *E. Guri (Managing)" },
                    { 14, 4, 2, "Display Sender Name As", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(3261), "Mail Display Name", "Smart Admin" },
                    { 12, 4, 2, "Email Address used to email", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(3250), "Mail Credential User Name", "carolinesolutions89@gmail.com" },
                    { 9, 4, 2, "Host used to Send Emails", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(3233), "Mail SMTP Host", "smtp.gmail.com" },
                    { 21, 3, 2, "Physical Location of Logo that is to be used on Reports", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(3291), "Report Logo Path", "D:\\Dev Projects\\SmartSave\\SmartSave\\SmartResources\\SmartLogo.png" },
                    { 2, 3, 2, "Displays Current Version of the System", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(3172), "System Version", "1.0.0.0" },
                    { 5, 3, 1, "Allows system to hide exceptions and show custom error page to user", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(3214), "Show Custom Exceptions To Users", "true" },
                    { 17, 3, 2, "Account Number Prefix if Any", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(3189), "Account Number Prefix", "" },
                    { 11, 4, 1, "Use Default Mail Credentials", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(3244), "Mail Use Default Credentials", "false" },
                    { 23, 3, 1, "Instructs the System to Advise User to Capture VAT inclusive amounts and calculate breakdown accordingly", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(3303), "Capture VAT Inclusive Payments", "true" },
                    { 26, 3, 1, "Option to Save Generated Statement To A physical Location on the Server", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(3336), "Statement Save To Folder", "true" },
                    { 28, 3, 1, "Allows to password protect statements being sent by Email", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(3355), "Statement Password Protect", "true" },
                    { 10, 4, 1, "Enable SSL", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(3238), "Mail Enable SSL", "true" },
                    { 6, 3, 4, "Limit Account Number Size", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(3182), "Account Number Length", "9" },
                    { 30, 3, 1, "Determines if table borders will be shown on the report ", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(3361), "Statement Hide Table Boarders", "true" },
                    { 3, 3, 4, "Displays the minimum year that can be selected  from the system", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(3201), "Minimum Year", "2000" },
                    { 8, 4, 4, "Port used to Send Emails", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(3227), "Mail SMTP Port", "587" },
                    { 1, 3, 2, "Displayed as the Application Name", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(2715), "Application Name", "Smart Save" },
                    { 18, 3, 2, "Short Name for Application", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 786, DateTimeKind.Local).AddTicks(3164), "Application Name Prefix", "SS" }
                });

            migrationBuilder.InsertData(
                table: "DocumentTypes",
                columns: new[] { "DocumentTypeID", "DocumentFormatID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 2, 1, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 771, DateTimeKind.Local).AddTicks(1613), "Birth Certificate" },
                    { 3, 1, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 771, DateTimeKind.Local).AddTicks(1645), "Proof Of Address" },
                    { 1, 1, true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 771, DateTimeKind.Local).AddTicks(374), "Assignment" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuID", "ActionName", "CSSClass", "ControllerName", "DisplayName", "IsActive", "LastChangedBy", "LastChangedDate", "MenuGroupID", "OrderNo" },
                values: new object[,]
                {
                    { 15, "Country", "fa fa-globe", "Country", "Country", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 776, DateTimeKind.Local).AddTicks(2777), 5, 15 },
                    { 16, "FeatureFlag", "fa fa-building", "FeatureFlag", "Feature Flags", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 776, DateTimeKind.Local).AddTicks(2781), 999, 16 },
                    { 8, "MainMenu", "fa fa-university", "Menus", "Menu", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 776, DateTimeKind.Local).AddTicks(2742), 9998, 8 },
                    { 12, "CustomSettings", "fa fa-spinner", "CustomSettings", "Custom Settings", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 776, DateTimeKind.Local).AddTicks(2762), 4, 13 },
                    { 6, "Roles", "fa fa-asterisk", "Roles", "Roles & Permissions", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 776, DateTimeKind.Local).AddTicks(2734), 4, 6 },
                    { 5, "Users", "fa fa-user", "User", "Users", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 776, DateTimeKind.Local).AddTicks(2723), 4, 5 },
                    { 18, "EmailTemplate", "fa fa-envelope-o", "EmailTemplate", "Email Templates", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 776, DateTimeKind.Local).AddTicks(2792), 5, 18 },
                    { 17, "Companies", "fa-building-o", "Company", "Companies", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 776, DateTimeKind.Local).AddTicks(2786), 5, 17 },
                    { 14, "Currency", "fa fa-money", "Currency", "Currency", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 776, DateTimeKind.Local).AddTicks(2773), 5, 14 },
                    { 10, "NoticeBoard", "fa broadcast-tower", "NoticeBoard", "Notice Board", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 776, DateTimeKind.Local).AddTicks(2753), 5, 10 },
                    { 11, "DocumentTypes", "fa fa-file", "DocumentType", "Documents", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 776, DateTimeKind.Local).AddTicks(2758), 5, 11 },
                    { 9, "Courses", "fa fa-university", "Courses", "Courses", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 776, DateTimeKind.Local).AddTicks(2747), 5, 9 },
                    { 7, "Department", "fa fa-building", "Department", "Departments", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 776, DateTimeKind.Local).AddTicks(2738), 5, 7 },
                    { 4, "Product", "fa fa-product-hunt", "Product", "Products", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 776, DateTimeKind.Local).AddTicks(2719), 3, 4 },
                    { 3, "Transactions", "fa fa-user", "Transactions", "Payments", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 776, DateTimeKind.Local).AddTicks(2714), 3, 3 },
                    { 2, "Enquiries", "fa fa-question-circle", "Enquiries", "Enquiries", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 776, DateTimeKind.Local).AddTicks(2708), 2, 2 },
                    { 1, "Clients", "fa fa-users-cog", "Client", "Clients", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 776, DateTimeKind.Local).AddTicks(2498), 2, 1 },
                    { 13, "BankAccounts", "fa fa-university", "BankAccounts", "Banks", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 776, DateTimeKind.Local).AddTicks(2766), 5, 13 }
                });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "RolePermissionID", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "PermissionID", "RoleID" },
                values: new object[,]
                {
                    { 41, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2580), 41, 1 },
                    { 40, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2577), 40, 1 },
                    { 39, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2574), 39, 1 },
                    { 38, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2571), 38, 1 },
                    { 37, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2569), 37, 1 },
                    { 34, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2559), 34, 1 },
                    { 35, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2563), 35, 1 },
                    { 42, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2583), 42, 1 },
                    { 33, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2552), 33, 1 },
                    { 32, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2549), 32, 1 },
                    { 31, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2546), 31, 1 },
                    { 36, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2566), 36, 1 },
                    { 43, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2586), 43, 1 },
                    { 47, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2597), 47, 1 },
                    { 45, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2591), 45, 1 },
                    { 46, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2594), 46, 1 },
                    { 48, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2600), 48, 1 },
                    { 49, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2604), 49, 1 },
                    { 50, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2607), 50, 1 },
                    { 51, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2611), 51, 1 },
                    { 52, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2614), 52, 1 },
                    { 53, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2616), 53, 1 },
                    { 54, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2619), 54, 1 },
                    { 55, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2622), 55, 1 },
                    { 56, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2625), 56, 1 },
                    { 30, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2544), 30, 1 },
                    { 44, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2589), 44, 1 },
                    { 29, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2540), 29, 1 },
                    { 5, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2441), 5, 1 },
                    { 27, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2530), 27, 1 },
                    { 1, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2219), 1, 1 },
                    { 2, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2428), 2, 1 },
                    { 3, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2434), 3, 1 },
                    { 4, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2438), 4, 1 },
                    { 6, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2452), 6, 1 },
                    { 7, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2456), 7, 1 },
                    { 8, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2460), 8, 1 },
                    { 9, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2464), 9, 1 },
                    { 10, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2470), 10, 1 },
                    { 11, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2474), 11, 1 },
                    { 28, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2535), 28, 1 },
                    { 13, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2480), 13, 1 },
                    { 12, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2477), 12, 1 },
                    { 15, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2487), 15, 1 },
                    { 16, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2490), 16, 1 },
                    { 17, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2493), 17, 1 },
                    { 18, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2498), 18, 1 },
                    { 19, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2501), 19, 1 },
                    { 20, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2504), 20, 1 },
                    { 21, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2507), 21, 1 },
                    { 22, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2510), 22, 1 },
                    { 14, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2483), 14, 1 },
                    { 23, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2515), 23, 1 },
                    { 24, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2519), 24, 1 },
                    { 25, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2523), 25, 1 },
                    { 26, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 715, DateTimeKind.Local).AddTicks(2526), 26, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "EmailAddress", "FirstName", "IsActive", "LastChangedBy", "LastChangedDate", "LastName", "Password", "UserName", "UserTypeID" },
                values: new object[,]
                {
                    { 2, "carochire@gmail.com", "Employer", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 758, DateTimeKind.Local).AddTicks(7862), "Employer", "YWRtaW4=", "Emp1", 2 },
                    { 3, "carochire@gmail.com", "Client", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 758, DateTimeKind.Local).AddTicks(8254), "Client", "YWRtaW4=", "Client", 3 },
                    { 1, "carochire@gmail.com", "User", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 754, DateTimeKind.Local).AddTicks(2231), "Super", "YWRtaW4=", "SuperUser", 1 },
                    { 4, "carochire@gmail.com", "Visitor", true, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 758, DateTimeKind.Local).AddTicks(8277), "Visitor", "YWRtaW4=", "Visitor", 4 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserID", "RoleID", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "UserRoleID" },
                values: new object[] { 1, 1, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 771, DateTimeKind.Local).AddTicks(9333), 1 });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserID", "RoleID", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "UserRoleID" },
                values: new object[] { 2, 1, true, false, "SuperUser", new DateTime(2020, 9, 15, 14, 40, 11, 771, DateTimeKind.Local).AddTicks(9490), 2 });

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_BankAccountTypeID",
                table: "BankAccounts",
                column: "BankAccountTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_CurrencyID",
                table: "BankAccounts",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientBoard_ClientID",
                table: "ClientBoard",
                column: "ClientID");

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
                name: "IX_ProductNotes_ProductID",
                table: "ProductNotes",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductNotes_UserTypeID",
                table: "ProductNotes",
                column: "UserTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CompanyID",
                table: "Products",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductFrequencyID",
                table: "Products",
                column: "ProductFrequencyID");

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
                name: "IX_Transactions_TransactionTypesTransactionTypeID",
                table: "Transactions",
                column: "TransactionTypesTransactionTypeID");

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
                name: "AuditActions");

            migrationBuilder.DropTable(
                name: "AuditEntries");

            migrationBuilder.DropTable(
                name: "BroadCasts");

            migrationBuilder.DropTable(
                name: "ClientBoard");

            migrationBuilder.DropTable(
                name: "ClientContacts");

            migrationBuilder.DropTable(
                name: "ClientDependents");

            migrationBuilder.DropTable(
                name: "ClientDocuments");

            migrationBuilder.DropTable(
                name: "ClientGuarantors");

            migrationBuilder.DropTable(
                name: "ClientMedicalDetails");

            migrationBuilder.DropTable(
                name: "ClientNotes");

            migrationBuilder.DropTable(
                name: "ClientProducts");

            migrationBuilder.DropTable(
                name: "Countries");

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
                name: "Menus");

            migrationBuilder.DropTable(
                name: "NoticeBoard");

            migrationBuilder.DropTable(
                name: "ProductNotes");

            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "Transactions");

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
                name: "Courses");

            migrationBuilder.DropTable(
                name: "CustomSettingTypes");

            migrationBuilder.DropTable(
                name: "SystemVariableTypes");

            migrationBuilder.DropTable(
                name: "EmailTypes");

            migrationBuilder.DropTable(
                name: "MenuGroups");

            migrationBuilder.DropTable(
                name: "PriorityRanks");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "BankAccounts");

            migrationBuilder.DropTable(
                name: "Clients");

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
                name: "BankAccountTypes");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "UserTypes");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "ProductFrequencies");
        }
    }
}
