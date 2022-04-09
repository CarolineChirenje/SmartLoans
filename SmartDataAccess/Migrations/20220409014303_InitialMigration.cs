using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "ClientAccountTypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientAccountTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ClientGroups",
                columns: table => new
                {
                    ClientGroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientGroups", x => x.ClientGroupID);
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
                name: "DeductionTypes",
                columns: table => new
                {
                    DeductionTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeductionTypes", x => x.DeductionTypeID);
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
                    LogTypeID = table.Column<int>(nullable: false),
                    Error = table.Column<string>(nullable: true),
                    Exception = table.Column<string>(nullable: true),
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
                name: "Fees",
                columns: table => new
                {
                    FeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fees", x => x.FeeID);
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
                name: "InvoiceStatuses",
                columns: table => new
                {
                    InvoiceStatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceStatuses", x => x.InvoiceStatusID);
                });

            migrationBuilder.CreateTable(
                name: "Layouts",
                columns: table => new
                {
                    LayoutID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    DisplayName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Layouts", x => x.LayoutID);
                });

            migrationBuilder.CreateTable(
                name: "Licences",
                columns: table => new
                {
                    LicenceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Reason = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licences", x => x.LicenceID);
                });

            migrationBuilder.CreateTable(
                name: "LoanFiscals",
                columns: table => new
                {
                    LoanFiscalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanFiscals", x => x.LoanFiscalID);
                });

            migrationBuilder.CreateTable(
                name: "LoanSectors",
                columns: table => new
                {
                    LoanSectorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanSectors", x => x.LoanSectorID);
                });

            migrationBuilder.CreateTable(
                name: "LoanStatus",
                columns: table => new
                {
                    LoanStatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanStatus", x => x.LoanStatusID);
                });

            migrationBuilder.CreateTable(
                name: "LoanTypes",
                columns: table => new
                {
                    LoanTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanTypes", x => x.LoanTypeID);
                });

            migrationBuilder.CreateTable(
                name: "LoanUses",
                columns: table => new
                {
                    LoanUseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanUses", x => x.LoanUseID);
                });

            migrationBuilder.CreateTable(
                name: "Maintanances",
                columns: table => new
                {
                    MaintananceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Reason = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maintanances", x => x.MaintananceID);
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
                name: "PenaltyTypes",
                columns: table => new
                {
                    PenaltyTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PenaltyTypes", x => x.PenaltyTypeID);
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
                name: "PinCodeTypes",
                columns: table => new
                {
                    PinCodeTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PinCodeTypes", x => x.PinCodeTypeID);
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
                name: "ProductComputations",
                columns: table => new
                {
                    ProductComputationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    PluginName = table.Column<string>(maxLength: 50, nullable: false),
                    Method = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductComputations", x => x.ProductComputationID);
                });

            migrationBuilder.CreateTable(
                name: "RecordStatus",
                columns: table => new
                {
                    RecordStatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordStatus", x => x.RecordStatusID);
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
                name: "TechnicalSupport",
                columns: table => new
                {
                    TechnicalSupportID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnicalSupport", x => x.TechnicalSupportID);
                });

            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    TitleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.TitleID);
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
                name: "VariableTypes",
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
                    table.PrimaryKey("PK_VariableTypes", x => x.CustomVariableTypeID);
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
                name: "SubCategories",
                columns: table => new
                {
                    SubCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    CategoryID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.SubCategoryID);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
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
                name: "LayoutMenus",
                columns: table => new
                {
                    LayoutMenuID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    LayoutID = table.Column<int>(nullable: false),
                    DisplayName = table.Column<string>(nullable: true),
                    ControllerName = table.Column<string>(nullable: true),
                    ActionName = table.Column<string>(nullable: true),
                    CSSClass = table.Column<string>(nullable: true),
                    OrderNo = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    LinkRequiresID = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LayoutMenus", x => x.LayoutMenuID);
                    table.ForeignKey(
                        name: "FK_LayoutMenus_Layouts_LayoutID",
                        column: x => x.LayoutID,
                        principalTable: "Layouts",
                        principalColumn: "LayoutID",
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
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomSettings", x => x.CustomSettingID);
                    table.ForeignKey(
                        name: "FK_CustomSettings_VariableTypes_CustomVariableTypeID",
                        column: x => x.CustomVariableTypeID,
                        principalTable: "VariableTypes",
                        principalColumn: "CustomVariableTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryItems",
                columns: table => new
                {
                    CategoryItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    SubCategoryID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryItems", x => x.CategoryItemID);
                    table.ForeignKey(
                        name: "FK_CategoryItems_SubCategories_SubCategoryID",
                        column: x => x.SubCategoryID,
                        principalTable: "SubCategories",
                        principalColumn: "SubCategoryID",
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
                    Initials = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    IDNumber = table.Column<string>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    CountryID = table.Column<int>(nullable: true),
                    AccountNumber = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    GenderID = table.Column<int>(nullable: false),
                    TitleID = table.Column<int>(nullable: false),
                    DepartmentID = table.Column<int>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ClientAccountTypeID = table.Column<int>(nullable: false),
                    CompanyID = table.Column<int>(nullable: true),
                    ClientGroupID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientID);
                    table.ForeignKey(
                        name: "FK_Clients_ClientAccountTypes_ClientAccountTypeID",
                        column: x => x.ClientAccountTypeID,
                        principalTable: "ClientAccountTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_ClientGroups_ClientGroupID",
                        column: x => x.ClientGroupID,
                        principalTable: "ClientGroups",
                        principalColumn: "ClientGroupID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
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
                        name: "FK_Clients_Titles_TitleID",
                        column: x => x.TitleID,
                        principalTable: "Titles",
                        principalColumn: "TitleID",
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
                    IsLegibleForPenalties = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ProductComputationID = table.Column<int>(nullable: false),
                    CompanyID = table.Column<int>(nullable: false),
                    CountryID = table.Column<int>(nullable: false),
                    CurrencyID = table.Column<int>(nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Products_Currencies_CurrencyID",
                        column: x => x.CurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "CurrencyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProductComputations_ProductComputationID",
                        column: x => x.ProductComputationID,
                        principalTable: "ProductComputations",
                        principalColumn: "ProductComputationID",
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
                    Password = table.Column<string>(nullable: true),
                    PasswordExpiryDate = table.Column<DateTime>(nullable: false),
                    GrantAccessToTestEnvironment = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CanOverrideMaintananceMode = table.Column<bool>(nullable: false),
                    ProfileImage = table.Column<byte[]>(nullable: true),
                    CompanyID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Users_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_UserTypes_UserTypeID",
                        column: x => x.UserTypeID,
                        principalTable: "UserTypes",
                        principalColumn: "UserTypeID",
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
                name: "JointApplicants",
                columns: table => new
                {
                    JointApplicantID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Initials = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    IDNumber = table.Column<string>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    CountryID = table.Column<int>(nullable: true),
                    ClientID = table.Column<int>(nullable: false),
                    ApplicantGenderID = table.Column<int>(nullable: false),
                    GenderID = table.Column<int>(nullable: true),
                    RelationshipTypeID = table.Column<int>(nullable: false),
                    ApplicantTitleID = table.Column<int>(nullable: false),
                    TitleID = table.Column<int>(nullable: true),
                    RecordStatusID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JointApplicants", x => x.JointApplicantID);
                    table.ForeignKey(
                        name: "FK_JointApplicants_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JointApplicants_Countries_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JointApplicants_Genders_GenderID",
                        column: x => x.GenderID,
                        principalTable: "Genders",
                        principalColumn: "GenderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JointApplicants_RecordStatus_RecordStatusID",
                        column: x => x.RecordStatusID,
                        principalTable: "RecordStatus",
                        principalColumn: "RecordStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JointApplicants_RelationshipTypes_RelationshipTypeID",
                        column: x => x.RelationshipTypeID,
                        principalTable: "RelationshipTypes",
                        principalColumn: "RelationshipTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JointApplicants_Titles_TitleID",
                        column: x => x.TitleID,
                        principalTable: "Titles",
                        principalColumn: "TitleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    InvoiceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    InvoiceDate = table.Column<DateTime>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    InvoiceStatusID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.InvoiceID);
                    table.ForeignKey(
                        name: "FK_Invoices_InvoiceStatuses_InvoiceStatusID",
                        column: x => x.InvoiceStatusID,
                        principalTable: "InvoiceStatuses",
                        principalColumn: "InvoiceStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoices_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    LoanID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    LoanRef = table.Column<string>(nullable: true),
                    ClientID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    LoanStatusID = table.Column<int>(nullable: false),
                    LoanTypeID = table.Column<int>(nullable: false),
                    LoanSectorID = table.Column<int>(nullable: false),
                    LoanUseID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.LoanID);
                    table.ForeignKey(
                        name: "FK_Loans_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loans_LoanSectors_LoanSectorID",
                        column: x => x.LoanSectorID,
                        principalTable: "LoanSectors",
                        principalColumn: "LoanSectorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loans_LoanStatus_LoanStatusID",
                        column: x => x.LoanStatusID,
                        principalTable: "LoanStatus",
                        principalColumn: "LoanStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loans_LoanTypes_LoanTypeID",
                        column: x => x.LoanTypeID,
                        principalTable: "LoanTypes",
                        principalColumn: "LoanTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loans_LoanUses_LoanUseID",
                        column: x => x.LoanUseID,
                        principalTable: "LoanUses",
                        principalColumn: "LoanUseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loans_Products_ProductID",
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
                    TreatAsPercentage = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProductFeeID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    FeeID = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeeHistory", x => x.ProductFeeHistoryID);
                    table.ForeignKey(
                        name: "FK_ProductFeeHistory_Fees_FeeID",
                        column: x => x.FeeID,
                        principalTable: "Fees",
                        principalColumn: "FeeID",
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
                    ProductID = table.Column<int>(nullable: false),
                    FeeID = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    TreatAsPercentage = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFees", x => x.ProductFeeID);
                    table.ForeignKey(
                        name: "FK_ProductFees_Fees_FeeID",
                        column: x => x.FeeID,
                        principalTable: "Fees",
                        principalColumn: "FeeID",
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
                    ProductComputationID = table.Column<int>(nullable: false),
                    IsLegibleForPenalties = table.Column<bool>(nullable: false),
                    CurrencyID = table.Column<int>(nullable: true)
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
                name: "ProductPenalties",
                columns: table => new
                {
                    ProductPenaltyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    ProductID = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPenalties", x => x.ProductPenaltyID);
                    table.ForeignKey(
                        name: "FK_ProductPenalties_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAccessGrants",
                columns: table => new
                {
                    UserAccessGrantID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: false),
                    AllowUntil = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccessGrants", x => x.UserAccessGrantID);
                    table.ForeignKey(
                        name: "FK_UserAccessGrants_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAccessRestrictions",
                columns: table => new
                {
                    UserAccessRestrictionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: false),
                    RestrictFrom = table.Column<DateTime>(nullable: false),
                    RestrictUntil = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccessRestrictions", x => x.UserAccessRestrictionID);
                    table.ForeignKey(
                        name: "FK_UserAccessRestrictions_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAuthenticationCodes",
                columns: table => new
                {
                    UserAuthenticationCodeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(nullable: true),
                    ClientID = table.Column<int>(nullable: true),
                    PinCode = table.Column<string>(nullable: true),
                    DateRequested = table.Column<DateTime>(nullable: false),
                    ExpiryDate = table.Column<DateTime>(nullable: false),
                    IsAccountCreation = table.Column<bool>(nullable: false),
                    PinCodeTypeID = table.Column<int>(nullable: false),
                    IsValid = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAuthenticationCodes", x => x.UserAuthenticationCodeID);
                    table.ForeignKey(
                        name: "FK_UserAuthenticationCodes_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserAuthenticationCodes_PinCodeTypes_PinCodeTypeID",
                        column: x => x.PinCodeTypeID,
                        principalTable: "PinCodeTypes",
                        principalColumn: "PinCodeTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAuthenticationCodes_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
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
                name: "InvoiceDetails",
                columns: table => new
                {
                    InvoiceDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    InvoiceID = table.Column<int>(nullable: false),
                    ClientID = table.Column<int>(nullable: false),
                    ClientProductID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    InvoiceNumber = table.Column<string>(nullable: true),
                    DeductionTypeID = table.Column<int>(nullable: true),
                    PaymentStatusID = table.Column<int>(nullable: false),
                    DeductedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeductionPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AdditionalDeductionPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalDeductionPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DatePaid = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceDetails", x => x.InvoiceDetailID);
                    table.ForeignKey(
                        name: "FK_InvoiceDetails_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceDetails_DeductionTypes_DeductionTypeID",
                        column: x => x.DeductionTypeID,
                        principalTable: "DeductionTypes",
                        principalColumn: "DeductionTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceDetails_Invoices_InvoiceID",
                        column: x => x.InvoiceID,
                        principalTable: "Invoices",
                        principalColumn: "InvoiceID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceDetails_PaymentStatus_PaymentStatusID",
                        column: x => x.PaymentStatusID,
                        principalTable: "PaymentStatus",
                        principalColumn: "PaymentStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoanBeneficiaries",
                columns: table => new
                {
                    LoanBeneficiaryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    LoanID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Surname = table.Column<string>(maxLength: 100, nullable: false),
                    IDNumber = table.Column<string>(maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    GenderID = table.Column<int>(nullable: false),
                    RelationshipTypeID = table.Column<int>(nullable: false),
                    CategoryItemID = table.Column<int>(nullable: false),
                    LoanID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanBeneficiaries", x => x.LoanBeneficiaryID);
                    table.ForeignKey(
                        name: "FK_LoanBeneficiaries_CategoryItems_CategoryItemID",
                        column: x => x.CategoryItemID,
                        principalTable: "CategoryItems",
                        principalColumn: "CategoryItemID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanBeneficiaries_Genders_GenderID",
                        column: x => x.GenderID,
                        principalTable: "Genders",
                        principalColumn: "GenderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanBeneficiaries_Loans_LoanID",
                        column: x => x.LoanID,
                        principalTable: "Loans",
                        principalColumn: "LoanID");
                    table.ForeignKey(
                        name: "FK_LoanBeneficiaries_Loans_LoanID1",
                        column: x => x.LoanID1,
                        principalTable: "Loans",
                        principalColumn: "LoanID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LoanBeneficiaries_RelationshipTypes_RelationshipTypeID",
                        column: x => x.RelationshipTypeID,
                        principalTable: "RelationshipTypes",
                        principalColumn: "RelationshipTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoanDocuments",
                columns: table => new
                {
                    LoanDocumentID = table.Column<int>(nullable: false)
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
                    LoanID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanDocuments", x => x.LoanDocumentID);
                    table.ForeignKey(
                        name: "FK_LoanDocuments_DocumentTypes_DocumentTypeID",
                        column: x => x.DocumentTypeID,
                        principalTable: "DocumentTypes",
                        principalColumn: "DocumentTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanDocuments_Loans_LoanID",
                        column: x => x.LoanID,
                        principalTable: "Loans",
                        principalColumn: "LoanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoanFinances",
                columns: table => new
                {
                    LoanFinanceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    LoanID = table.Column<int>(nullable: false),
                    MaturityDate = table.Column<DateTime>(nullable: false),
                    ValueDate = table.Column<DateTime>(nullable: false),
                    ApplicationFee = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    Deposit = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    EffectiveDeposit = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    FeesReq = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    FinanceAmount = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    FxFixing = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    Installment = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    InterestRate = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    MinimumUpfront = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    Upfront = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanFinances", x => x.LoanFinanceID);
                    table.ForeignKey(
                        name: "FK_LoanFinances_Loans_LoanID",
                        column: x => x.LoanID,
                        principalTable: "Loans",
                        principalColumn: "LoanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoanNotes",
                columns: table => new
                {
                    LoanNoteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: false),
                    UserTypeID = table.Column<int>(nullable: false),
                    DateUploaded = table.Column<DateTime>(nullable: false),
                    DateClosed = table.Column<DateTime>(nullable: true),
                    DueDate = table.Column<DateTime>(nullable: false),
                    UploadedBy = table.Column<string>(nullable: true),
                    LoanID = table.Column<int>(nullable: false),
                    VisibleToAdminOnly = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanNotes", x => x.LoanNoteID);
                    table.ForeignKey(
                        name: "FK_LoanNotes_Loans_LoanID",
                        column: x => x.LoanID,
                        principalTable: "Loans",
                        principalColumn: "LoanID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanNotes_UserTypes_UserTypeID",
                        column: x => x.UserTypeID,
                        principalTable: "UserTypes",
                        principalColumn: "UserTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoanSchedules",
                columns: table => new
                {
                    LoanScheduleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    LoanID = table.Column<int>(nullable: false),
                    LedgerNo = table.Column<int>(nullable: false),
                    IsPaid = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanSchedules", x => x.LoanScheduleID);
                    table.ForeignKey(
                        name: "FK_LoanSchedules_Loans_LoanID",
                        column: x => x.LoanID,
                        principalTable: "Loans",
                        principalColumn: "LoanID",
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
                    AssertID = table.Column<int>(nullable: false),
                    AssertCategoryID = table.Column<int>(nullable: false),
                    BankAccountID = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Month = table.Column<int>(nullable: false),
                    TransactionTypeID = table.Column<int>(nullable: false),
                    PaymentStatusID = table.Column<int>(nullable: false),
                    ClientFeeID = table.Column<int>(nullable: true),
                    Units = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountExclVAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransactionFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransactionRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(nullable: false),
                    TransactionDate = table.Column<DateTime>(nullable: false),
                    ParentPaymentID = table.Column<int>(nullable: true),
                    ReversalPaymentID = table.Column<int>(nullable: true),
                    InvoiceDetailID = table.Column<int>(nullable: true),
                    InvoiceDetailsInvoiceDetailID = table.Column<int>(nullable: true)
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
                        name: "FK_Transactions_InvoiceDetails_InvoiceDetailsInvoiceDetailID",
                        column: x => x.InvoiceDetailsInvoiceDetailID,
                        principalTable: "InvoiceDetails",
                        principalColumn: "InvoiceDetailID",
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

            migrationBuilder.InsertData(
                table: "BankAccountTypes",
                columns: new[] { "BankAccountTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 792, DateTimeKind.Local).AddTicks(5312), "Savings" },
                    { 2, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 792, DateTimeKind.Local).AddTicks(5788), "Cheque" },
                    { 3, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 792, DateTimeKind.Local).AddTicks(5810), "Credit" },
                    { 4, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 792, DateTimeKind.Local).AddTicks(5821), "Cash" }
                });

            migrationBuilder.InsertData(
                table: "ClientAccountTypes",
                columns: new[] { "ID", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 837, DateTimeKind.Local).AddTicks(5178), "Individual" },
                    { 2, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 837, DateTimeKind.Local).AddTicks(5600), "Joint" }
                });

            migrationBuilder.InsertData(
                table: "ClientGroups",
                columns: new[] { "ClientGroupID", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 842, DateTimeKind.Local).AddTicks(803), "Company" },
                    { 2, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 842, DateTimeKind.Local).AddTicks(4773), "Individual" }
                });

            migrationBuilder.InsertData(
                table: "ContactTypes",
                columns: new[] { "ContactTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 799, DateTimeKind.Local).AddTicks(4114), "Residential Address" },
                    { 2, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 799, DateTimeKind.Local).AddTicks(4105), "Postal Address" },
                    { 5, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 799, DateTimeKind.Local).AddTicks(4122), "Telephone" },
                    { 4, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 799, DateTimeKind.Local).AddTicks(3970), "Cell Phone" },
                    { 3, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 799, DateTimeKind.Local).AddTicks(4094), "Email Address" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 157, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7475), "Oman" },
                    { 146, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7387), "Nauru" },
                    { 147, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7395), "Nepal" },
                    { 149, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7411), "Netherlands Antilles" },
                    { 150, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7420), "New Caledonia" },
                    { 151, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7428), "New Zealand" },
                    { 152, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7436), "Nicaragua" },
                    { 153, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7443), "Niger" },
                    { 154, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7450), "Nigeria" },
                    { 155, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7460), "N Mariana Islands" },
                    { 156, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7467), "Norway" },
                    { 158, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7482), "Pakistan" },
                    { 164, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7529), "Philippines" },
                    { 160, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7497), "Panama" },
                    { 161, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7506), "Papua New Guinea" },
                    { 162, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7513), "Paraguay" },
                    { 163, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7521), "Peru" },
                    { 145, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7380), "Namibia" },
                    { 165, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7537), "Poland" },
                    { 166, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7544), "Portugal" },
                    { 167, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7552), "Puerto Rico" },
                    { 168, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7559), "Qatar" },
                    { 169, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7566), "Reunion" },
                    { 170, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7573), "Romania" },
                    { 159, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7489), "Palau" },
                    { 144, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7372), "Mozambique" },
                    { 137, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7318), "Mexico" },
                    { 142, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7356), "Montserrat" },
                    { 117, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7090), "Lebanon" },
                    { 118, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7098), "Lesotho" },
                    { 119, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7106), "Liberia" },
                    { 120, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7114), "Libya" },
                    { 121, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7121), "Liechtenstein" },
                    { 122, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7129), "Lithuania" },
                    { 123, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7136), "Luxembourg" },
                    { 124, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7213), "Macau" },
                    { 125, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7222), "Macedonia" },
                    { 126, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7229), "Madagascar" },
                    { 127, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7238), "Malawi" },
                    { 128, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7246), "Malaysia" },
                    { 129, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7253), "Maldives" },
                    { 130, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7265), "Mali" },
                    { 131, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7272), "Malta" },
                    { 132, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7281), "Marshall Islands" },
                    { 133, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7289), "Martinique" },
                    { 134, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7296), "Mauritania" },
                    { 135, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7303), "Mauritius" },
                    { 136, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7310), "Mayotte" },
                    { 171, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7581), "Russia" },
                    { 138, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7327), "Micronesia Fed St" },
                    { 139, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7334), "Moldova" },
                    { 140, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7341), "Monaco" },
                    { 141, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7349), "Mongolia" },
                    { 143, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7364), "Morocco" },
                    { 172, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7590), "Rwanda" },
                    { 179, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7711), "San Marino" },
                    { 174, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7608), "Saint Kitts Nevis" },
                    { 204, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7920), "Togo" },
                    { 205, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7929), "Tonga" },
                    { 206, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7940), "Trinidad Tobago" },
                    { 207, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7948), "Tunisia" },
                    { 208, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7956), "Turkey" },
                    { 209, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7966), "Turkmenistan" },
                    { 210, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7976), "Turks Caicos Is" },
                    { 211, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7986), "Tuvalu" },
                    { 212, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7994), "Uganda" },
                    { 213, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(8002), "Ukraine" },
                    { 214, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(8015), "United Arab Emirates" },
                    { 215, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(8022), "United Kingdom" },
                    { 216, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(8029), "United States" },
                    { 217, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(8034), "Uruguay" },
                    { 218, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(8040), "Uzbekistan" },
                    { 219, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(8046), "Vanuatu" },
                    { 220, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(8052), "Venezuela" },
                    { 221, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(8057), "Vietnam" },
                    { 222, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(8064), "Virgin Islands" },
                    { 223, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(8071), "Wallis Futuna" },
                    { 224, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(8076), "West Bank" },
                    { 225, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(8082), "Western Sahara" },
                    { 226, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(8088), "Yemen" },
                    { 227, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(8094), "Zambia" },
                    { 228, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(8100), "Zimbabwe" },
                    { 203, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7911), "Thailand" },
                    { 173, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7599), "Saint Helena" },
                    { 202, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7903), "Tanzania" },
                    { 200, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7882), "Taiwan" },
                    { 175, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7617), "Saint Lucia" },
                    { 176, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7679), "St Pierre Miquelon" },
                    { 177, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7695), "Saint Vincent and the Grenadines" },
                    { 178, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7703), "Samoa" },
                    { 116, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7083), "Latvia" },
                    { 180, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7720), "Sao Tome Principe" },
                    { 181, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7729), "Saudi Arabia" },
                    { 182, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7736), "Senegal" },
                    { 183, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7744), "Serbia" },
                    { 184, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7752), "Seychelles" },
                    { 185, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7759), "Sierra Leone" },
                    { 186, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7767), "Singapore" },
                    { 187, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7775), "Slovakia" },
                    { 188, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7783), "Slovenia" },
                    { 189, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7791), "Solomon Islands" },
                    { 190, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7799), "Somalia" },
                    { 191, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7807), "South Africa" },
                    { 192, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7814), "Spain" },
                    { 193, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7823), "Sri Lanka" },
                    { 194, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7830), "Sudan" },
                    { 195, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7838), "Suriname" },
                    { 196, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7847), "Swaziland" },
                    { 197, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7855), "Sweden" },
                    { 198, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7864), "Switzerland" },
                    { 199, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7873), "Syria" },
                    { 201, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7892), "Tajikistan" },
                    { 115, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7076), "Laos" },
                    { 148, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7402), "Netherlands" },
                    { 113, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7059), "Kuwait" },
                    { 30, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6301), "British Virgin Is" },
                    { 31, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6308), "Brunei" },
                    { 32, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6315), "Bulgaria" },
                    { 33, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6324), "Burkina Faso" },
                    { 34, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6335), "Burma" },
                    { 35, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6343), "Burundi" },
                    { 36, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6350), "Cambodia" },
                    { 37, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6358), "Cameroon" },
                    { 38, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6365), "Canada" },
                    { 39, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6373), "Cape Verde" },
                    { 40, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6381), "Cayman Islands" },
                    { 41, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6391), "Central African Rep" },
                    { 42, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6398), "Chad" },
                    { 43, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6406), "Chile" },
                    { 44, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6413), "China" },
                    { 45, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6421), "Colombia" },
                    { 46, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6429), "Comoros" },
                    { 47, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6438), "Congo Dem Rep" },
                    { 48, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6447), "Congo Repub of the" },
                    { 49, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6456), "Cook Islands" },
                    { 50, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6464), "Costa Rica" },
                    { 51, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6472), "Cote dIvoire" },
                    { 52, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6480), "Croatia" },
                    { 53, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6488), "Cuba" },
                    { 54, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6495), "Cyprus" },
                    { 29, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6291), "Brazil" },
                    { 55, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6504), "Czech Republic" },
                    { 28, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6284), "Botswana" },
                    { 26, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6266), "Bolivia" },
                    { 1, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(5481), "Afghanistan" },
                    { 2, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6048), "Albania" },
                    { 3, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6064), "Algeria" },
                    { 4, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6079), "American Samoa" },
                    { 5, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6087), "Andorra" },
                    { 6, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6105), "Angola" },
                    { 7, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6113), "Anguilla" },
                    { 8, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6122), "Antigua Barbuda" },
                    { 9, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6130), "Argentina" },
                    { 10, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6140), "Armenia" },
                    { 11, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6149), "Aruba" },
                    { 12, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6156), "Australia" },
                    { 13, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6164), "Austria" },
                    { 14, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6171), "Azerbaijan" },
                    { 15, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6179), "Bahamas" },
                    { 16, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6188), " The" },
                    { 17, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6195), "Bahrain" },
                    { 114, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7066), "Kyrgyzstan" },
                    { 19, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6214), "Barbados" },
                    { 20, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6221), "Belarus" },
                    { 21, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6229), "Belgium" },
                    { 22, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6237), "Belize" },
                    { 23, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6245), "Benin" },
                    { 24, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6252), "Bermuda" },
                    { 25, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6259), "Bhutan" },
                    { 27, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6276), "Bosnia Herzegovina" },
                    { 56, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6511), "Denmark" },
                    { 18, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6206), "Bangladesh" },
                    { 58, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6526), "Dominica" },
                    { 88, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6868), "Guinea" },
                    { 89, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6877), "Guinea Bissau" },
                    { 90, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6885), "Guyana" },
                    { 91, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6892), "Haiti" },
                    { 92, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6899), "Honduras" },
                    { 93, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6907), "Hong Kong" },
                    { 94, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6914), "Hungary" },
                    { 95, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6922), "Iceland" },
                    { 96, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6930), "India" },
                    { 97, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6937), "Indonesia" },
                    { 98, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6945), "Iran" },
                    { 99, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6952), "Iraq" },
                    { 100, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6959), "Ireland" },
                    { 101, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6968), "Isle of Man" },
                    { 102, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6975), "Israel" },
                    { 103, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6983), "Italy" },
                    { 105, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6998), "Japan" },
                    { 106, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7005), "Jersey" },
                    { 107, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7013), "Jordan" },
                    { 108, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7020), "Kazakhstan" },
                    { 109, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7028), "Kenya" },
                    { 110, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7035), "Kiribati" },
                    { 111, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7043), "Korea North" },
                    { 112, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(7051), "Korea South" },
                    { 57, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6518), "Djibouti" },
                    { 87, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6861), "Guernsey" },
                    { 86, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6853), "Guatemala" },
                    { 104, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6991), "Jamaica" },
                    { 84, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6837), "Guadeloupe" },
                    { 59, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6535), "Dominican Republic" },
                    { 85, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6845), "Guam" },
                    { 60, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6543), "East Timor" },
                    { 61, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6650), "Ecuador" },
                    { 62, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6661), "Egypt" },
                    { 63, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6669), "El Salvador" },
                    { 65, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6686), "Eritrea" },
                    { 66, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6697), "Estonia" },
                    { 67, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6705), "Ethiopia" },
                    { 68, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6713), "Faroe Islands" },
                    { 69, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6720), "Fiji" },
                    { 70, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6728), "Finland" },
                    { 71, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6736), "France" },
                    { 64, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6679), "Equatorial Guinea" },
                    { 73, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6753), "French Polynesia" },
                    { 72, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6744), "French Guiana" },
                    { 83, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6829), "Grenada" },
                    { 81, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6814), "Greece" },
                    { 82, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6821), "Greenland" },
                    { 79, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6799), "Ghana" },
                    { 80, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6806), "Gibraltar" },
                    { 77, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6784), "Georgia" },
                    { 76, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6777), "Gaza Strip" },
                    { 75, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6769), "Gambia The" },
                    { 74, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6760), "Gabon" },
                    { 78, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 806, DateTimeKind.Local).AddTicks(6791), "Germany" }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "CurrencyID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 107, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8874), "OMR" },
                    { 108, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8883), "PAB" },
                    { 106, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8865), "NZD" },
                    { 109, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8893), "PEN" },
                    { 110, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8903), "PGK" },
                    { 111, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8912), "PHP" },
                    { 112, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8923), "PKR" },
                    { 117, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8969), "RSD" },
                    { 114, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8940), "PYG" },
                    { 115, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8950), "QAR" },
                    { 116, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8959), "RON" },
                    { 118, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8980), "RUB" },
                    { 119, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8989), "RWF" },
                    { 121, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9009), "SBD" },
                    { 105, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8855), "NPR" },
                    { 120, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8998), "SAR" },
                    { 113, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8931), "PLN" },
                    { 104, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8846), "NOK" },
                    { 90, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8691), "MKD" },
                    { 102, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8826), "NGN" },
                    { 84, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8633), "LRD" },
                    { 122, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9018), "SCR" },
                    { 85, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8643), "LSL" },
                    { 86, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8653), "LYD" },
                    { 87, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8663), "MAD" },
                    { 88, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8673), "MDL" },
                    { 89, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8682), "MGA" },
                    { 92, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8709), "MNT" },
                    { 93, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8718), "MOP" },
                    { 94, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8727), "MRU" },
                    { 95, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8761), "MUR" },
                    { 96, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8769), "MVR" },
                    { 97, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8779), "MWK" },
                    { 98, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8788), "MXN" },
                    { 99, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8798), "MYR" },
                    { 100, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8807), "MZN" },
                    { 101, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8816), "NAD" },
                    { 103, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8836), "NIO" },
                    { 123, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9028), "SDG" },
                    { 151, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9561), "VND" },
                    { 125, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9046), "SGD" },
                    { 147, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9302), "USD" },
                    { 148, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9309), "UYU" },
                    { 149, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9367), "UZS" },
                    { 150, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9550), "VEF" },
                    { 152, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9570), "VUV" },
                    { 153, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9579), "WST" },
                    { 154, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9589), "XAF" },
                    { 146, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9295), "UGX" },
                    { 155, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9597), "XCD" },
                    { 157, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9615), "XOF" },
                    { 158, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9624), "XPF" },
                    { 159, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9632), "YER" },
                    { 160, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9641), "ZAR" },
                    { 161, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9650), "ZMW" },
                    { 162, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9659), "ZWD" },
                    { 83, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8623), "LKR" },
                    { 156, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9606), "XDR" },
                    { 145, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9286), "UAH" },
                    { 144, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9279), "TZS" },
                    { 143, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9270), "TWD" },
                    { 126, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9055), "SHP" },
                    { 127, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9064), "SLL" },
                    { 128, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9074), "SOS" },
                    { 129, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9083), "SPL" },
                    { 130, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9144), "SRD" },
                    { 131, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9154), "STN" },
                    { 132, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9164), "SVC" },
                    { 133, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9173), "SYP" },
                    { 134, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9183), "SZL" },
                    { 135, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9193), "THB" },
                    { 136, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9204), "TJS" },
                    { 137, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9213), "TMT" },
                    { 138, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9223), "TND" },
                    { 139, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9233), "TOP" },
                    { 140, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9242), "TRY" },
                    { 141, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9252), "TTD" },
                    { 142, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9261), "TVD" },
                    { 124, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(9036), "SEK" },
                    { 82, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8614), "LBP" },
                    { 91, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8700), "MMK" },
                    { 80, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8593), "KZT" },
                    { 22, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7916), "BTN" },
                    { 23, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7925), "BWP" },
                    { 24, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7934), "BYN" },
                    { 25, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7943), "BZD" },
                    { 26, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7953), "CAD" },
                    { 27, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7963), "CDF" },
                    { 28, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7972), "CHF" },
                    { 21, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7907), "BSD" },
                    { 29, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7983), "CLP" },
                    { 31, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8002), "COP" },
                    { 32, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8011), "CRC" },
                    { 33, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8021), "CUC" },
                    { 35, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8045), "CVE" },
                    { 36, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8056), "CZK" },
                    { 37, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8065), "DJF" },
                    { 38, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8073), "DKK" },
                    { 30, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7992), "CNY" },
                    { 20, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7895), "BRL" },
                    { 19, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7886), "BOB" },
                    { 18, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7876), "BND" },
                    { 1, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(6897), "AED" },
                    { 2, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7470), "AFN" },
                    { 3, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7500), "ALL" },
                    { 4, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7511), "AMD" },
                    { 5, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7537), "ANG" },
                    { 6, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7556), "AOA" },
                    { 7, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7566), "ARS" },
                    { 8, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7575), "AUD" },
                    { 9, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7772), "AWG" },
                    { 10, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7789), "AZN" },
                    { 11, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7801), "BAM" },
                    { 12, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7811), "BBD" },
                    { 13, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7821), "BDT" },
                    { 14, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7830), "BGN" },
                    { 15, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7839), "BHD" },
                    { 16, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7850), "BIF" },
                    { 17, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(7861), "BMD" },
                    { 39, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8082), "DOP" },
                    { 40, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8091), "DZD" },
                    { 34, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8034), "CUP" },
                    { 42, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8111), "ERN" },
                    { 64, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8332), "INR" },
                    { 65, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8341), "IQD" },
                    { 66, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8356), "IRR" },
                    { 67, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8366), "ISK" },
                    { 41, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8101), "EGP" },
                    { 69, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8435), "JMD" },
                    { 70, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8445), "JOD" },
                    { 71, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8455), "JPY" },
                    { 81, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8603), "LAK" },
                    { 72, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8464), "KES" },
                    { 73, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8474), "KGS" },
                    { 74, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8483), "KHR" },
                    { 75, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8494), "KMF" },
                    { 76, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8503), "KPW" },
                    { 77, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8513), "KRW" },
                    { 78, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8521), "KWD" },
                    { 79, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8584), "KYD" },
                    { 63, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8322), "IMP" },
                    { 62, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8311), "ILS" },
                    { 68, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8423), "JEP" },
                    { 60, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8290), "HUF" },
                    { 43, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8121), "ETB" },
                    { 44, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8130), "EUR" },
                    { 61, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8301), "IDR" },
                    { 46, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8150), "FKP" },
                    { 47, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8160), "GBP" },
                    { 48, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8170), "GEL" },
                    { 49, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8180), "GGP" },
                    { 50, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8191), "GHS" },
                    { 45, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8139), "FJD" },
                    { 52, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8211), "GMD" },
                    { 53, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8221), "GNF" },
                    { 54, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8230), "GTQ" },
                    { 55, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8239), "GYD" },
                    { 56, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8250), "HKD" },
                    { 57, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8260), "HNL" },
                    { 58, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8270), "HRK" },
                    { 59, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8281), "HTG" },
                    { 51, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 795, DateTimeKind.Local).AddTicks(8201), "GIP" }
                });

            migrationBuilder.InsertData(
                table: "DeductionTypes",
                columns: new[] { "DeductionTypeID", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 3, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 850, DateTimeKind.Local).AddTicks(9748), "Do Not Deduct" },
                    { 2, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 850, DateTimeKind.Local).AddTicks(9732), "Individual" },
                    { 1, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 850, DateTimeKind.Local).AddTicks(9437), "Product" }
                });

            migrationBuilder.InsertData(
                table: "DocumentFormats",
                columns: new[] { "DocumentFormatID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 813, DateTimeKind.Local).AddTicks(7310), "pdf" },
                    { 4, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 813, DateTimeKind.Local).AddTicks(7610), "txt" },
                    { 5, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 813, DateTimeKind.Local).AddTicks(7615), "rtf" },
                    { 3, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 813, DateTimeKind.Local).AddTicks(7604), "xlsx" },
                    { 2, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 813, DateTimeKind.Local).AddTicks(7592), "doc" },
                    { 6, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 813, DateTimeKind.Local).AddTicks(7624), "ppt" }
                });

            migrationBuilder.InsertData(
                table: "EmailTypes",
                columns: new[] { "EmailTypeID", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 824, DateTimeKind.Local).AddTicks(9799), "Client Statement" },
                    { 2, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 825, DateTimeKind.Local).AddTicks(352), "Proof Of Payment" },
                    { 3, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 825, DateTimeKind.Local).AddTicks(380), "Invoice" },
                    { 4, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 825, DateTimeKind.Local).AddTicks(393), "New User Account Created" }
                });

            migrationBuilder.InsertData(
                table: "FeatureFlags",
                columns: new[] { "FeatureFlagID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 811, DateTimeKind.Local).AddTicks(8795), "Send Email On Error" },
                    { 2, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 811, DateTimeKind.Local).AddTicks(9108), "CC Client On Error" },
                    { 3, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 811, DateTimeKind.Local).AddTicks(9123), "Enable Document Emailing Functionality" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 803, DateTimeKind.Local).AddTicks(3200), "Female" },
                    { 2, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 803, DateTimeKind.Local).AddTicks(3381), "Male" }
                });

            migrationBuilder.InsertData(
                table: "InvoiceStatuses",
                columns: new[] { "InvoiceStatusID", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 4, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 844, DateTimeKind.Local).AddTicks(7055), "Unknown" },
                    { 3, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 844, DateTimeKind.Local).AddTicks(7049), "Finalised" },
                    { 2, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 844, DateTimeKind.Local).AddTicks(7037), "Processed" },
                    { 1, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 844, DateTimeKind.Local).AddTicks(6706), "Created" }
                });

            migrationBuilder.InsertData(
                table: "Layouts",
                columns: new[] { "LayoutID", "DisplayName", "LastChangedBy", "LastChangedDate" },
                values: new object[,]
                {
                    { 3, "Developer Menu", "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 846, DateTimeKind.Local).AddTicks(6839) },
                    { 2, "Loan Manager", "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 846, DateTimeKind.Local).AddTicks(6827) },
                    { 6, "Employees", "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 846, DateTimeKind.Local).AddTicks(6861) },
                    { 1, "Client", "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 846, DateTimeKind.Local).AddTicks(6558) },
                    { 7, "Employers", "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 846, DateTimeKind.Local).AddTicks(6867) },
                    { 4, "Settings", "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 846, DateTimeKind.Local).AddTicks(6846) },
                    { 5, "Reporting", "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 846, DateTimeKind.Local).AddTicks(6852) }
                });

            migrationBuilder.InsertData(
                table: "MenuGroups",
                columns: new[] { "MenuGroupID", "ActionName", "CSSClass", "ControllerName", "DisplayName", "IsActive", "IsActiveMenu", "LastChangedBy", "LastChangedDate", "OrderNo" },
                values: new object[,]
                {
                    { 1, "Dashboard", "fa fa-umbrella", "Home", "DashBoard", true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 817, DateTimeKind.Local).AddTicks(7375), 1 },
                    { 2, null, "fa fa-users", null, "Clients", true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 817, DateTimeKind.Local).AddTicks(7653), 2 },
                    { 3, null, "fa fa-money", null, "Transactions", true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 817, DateTimeKind.Local).AddTicks(7673), 3 },
                    { 5, null, "fa fa-wrench", null, "Settings", true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 817, DateTimeKind.Local).AddTicks(7700), 7 },
                    { 7, null, "fa fa-line-chart", null, "Loans", true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 817, DateTimeKind.Local).AddTicks(7719), 5 },
                    { 9998, null, "fa fa-university", null, "Menu", true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 817, DateTimeKind.Local).AddTicks(7732), 9998 },
                    { 999, null, "fa fa-desktop", null, "Developer Menu", true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 817, DateTimeKind.Local).AddTicks(7751), 9999 },
                    { 4, null, "fa fa-area-chart", null, "Reporting", true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 817, DateTimeKind.Local).AddTicks(7687), 6 },
                    { 6, null, "fa fa-bullseye", null, "Invoicing", true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 817, DateTimeKind.Local).AddTicks(7764), 4 }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "PaymentStatusID", "Description", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 3, null, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 785, DateTimeKind.Local).AddTicks(4821), "Pending" },
                    { 4, null, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 785, DateTimeKind.Local).AddTicks(4833), "Refunded" },
                    { 5, null, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 785, DateTimeKind.Local).AddTicks(4844), "Discounted" },
                    { 2, null, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 785, DateTimeKind.Local).AddTicks(4801), "Reversed" },
                    { 1, null, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 785, DateTimeKind.Local).AddTicks(4225), "Paid" }
                });

            migrationBuilder.InsertData(
                table: "PenaltyTypes",
                columns: new[] { "PenaltyTypeID", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 2, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 861, DateTimeKind.Local).AddTicks(8653), "Y Days" },
                    { 3, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 861, DateTimeKind.Local).AddTicks(8670), "X Days More" },
                    { 4, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 861, DateTimeKind.Local).AddTicks(8681), "Y Days More" },
                    { 5, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 861, DateTimeKind.Local).AddTicks(8691), "X Days Less" },
                    { 6, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 861, DateTimeKind.Local).AddTicks(8708), "Y Days Less" },
                    { 1, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 861, DateTimeKind.Local).AddTicks(8157), "X Days" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "Description", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 105, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(448), "View Invoice Details" },
                    { 96, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(352), "Delete Product Fee" },
                    { 97, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(363), "View Product Fee" },
                    { 98, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(374), "Add Product Assert" },
                    { 99, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(386), "Update Product Assert" },
                    { 100, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(398), "View Product Assert" },
                    { 101, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(408), "Add Assert" },
                    { 102, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(420), "Update Assert" },
                    { 95, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(341), "Update Product Fee" },
                    { 103, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(429), "Delete Assert" },
                    { 111, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(515), "View Currency" },
                    { 110, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(505), "View Country" },
                    { 109, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(495), "Add Maintanance Notification" },
                    { 108, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(484), "Email Receipt To Client" },
                    { 104, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(439), "View Assert" },
                    { 107, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(473), "Auto Generate Receipt" },
                    { 106, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(461), "Print Statement With No Reversals" },
                    { 112, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(527), "View Feature Flag" },
                    { 94, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(329), "Add Product Fee" },
                    { 146, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(972), "Update Product Computation" },
                    { 92, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(310), "Update Transaction Type" },
                    { 76, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(18), "Add Bank Account" },
                    { 77, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(29), "Update Bank Account" },
                    { 78, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(148), "Delete Bank Account" },
                    { 79, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(162), "View Bank Account" },
                    { 80, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(175), "Add Email Template" },
                    { 81, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(186), "Update Email Template" },
                    { 82, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(197), "Delete Email Template" },
                    { 83, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(208), "View Email Template" },
                    { 113, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(538), "View Layouts" },
                    { 84, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(219), "Add Notice" },
                    { 85, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(229), "Update Notice" },
                    { 86, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(240), "Delete Notice" },
                    { 87, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(251), "View Notice" },
                    { 88, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(262), "Update Country" },
                    { 89, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(274), "Update Currency" },
                    { 90, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(286), "View Dashboard Notices" },
                    { 91, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(299), "Client Update Personal Details" },
                    { 93, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(319), "View Transaction Type" },
                    { 154, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(1062), "Delete Loan Note" },
                    { 130, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(790), "Update Loan Status" },
                    { 115, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(559), "View Maintanances" },
                    { 137, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(868), "Add Loan" },
                    { 138, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(880), "Update Loan" },
                    { 139, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(891), "Delete Loan" },
                    { 140, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(901), "View Loan" },
                    { 141, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(914), "Add Loan Beneficiary" },
                    { 142, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(925), "Update Loan Beneficiary" },
                    { 143, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(938), "View Loan Beneficiary" },
                    { 136, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(858), "View Category" },
                    { 144, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(950), "Delete Loan Beneficiary" },
                    { 153, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(1051), "View Loan Note" },
                    { 152, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(1039), "Update Loan Note" },
                    { 151, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(1028), "Add Loan Note" },
                    { 150, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(1017), "Loan View Document" },
                    { 149, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(1006), "Loan Upload Document" },
                    { 148, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(996), "Delete Product Computation" },
                    { 147, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(984), "View Product Computation" },
                    { 75, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(7), "View Company" },
                    { 135, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(846), "Delete Category" },
                    { 134, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(836), "Update Category" },
                    { 133, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(825), "Add Category" },
                    { 116, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(573), "View Technical Support Settings" },
                    { 117, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(589), "Add Loan Use" },
                    { 118, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(600), "Update Loan Use" },
                    { 119, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(611), "Delete Loan Use" },
                    { 120, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(621), "View Loan Use" },
                    { 121, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(633), "Add Loan Type" },
                    { 122, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(644), "Update Loan Type" },
                    { 123, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(655), "Delete Loan Type" },
                    { 124, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(715), "View Loan Type" },
                    { 125, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(728), "Add Fee" },
                    { 126, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(740), "Update Fee" },
                    { 127, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(750), "Delete Fee" },
                    { 128, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(761), "View Fee" },
                    { 129, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(772), "Add Loan Status" },
                    { 145, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(961), "Add Product Computation" },
                    { 131, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(801), "Delete Loan Status" },
                    { 132, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(813), "View Loan Status" },
                    { 114, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 781, DateTimeKind.Local).AddTicks(549), "View Licences" },
                    { 74, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9997), "Delete Company" },
                    { 32, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9386), "Update Role" },
                    { 72, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9959), "Add Company" },
                    { 20, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9249), "Update Client Loan" },
                    { 21, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9258), "Delete Client Loan" },
                    { 22, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9268), "View Client Loan" },
                    { 23, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9280), "Add Client Dependent" },
                    { 24, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9293), "Update Client Dependent" },
                    { 25, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9304), "Delete Client Dependent" },
                    { 19, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9237), "Add Client Loan" },
                    { 26, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9316), "View Client Dependent" },
                    { 28, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9339), "Generate Client Statement" },
                    { 29, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9352), "Client Upload Document" },
                    { 30, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9363), "Client View Document" },
                    { 31, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9375), "Add Role" },
                    { 33, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9396), "Delete Role" },
                    { 34, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9411), "View Role" },
                    { 27, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9328), "View Client Payments" },
                    { 18, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9227), "View Client Contact" },
                    { 17, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9212), "Delete Client Contact" },
                    { 16, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9200), "Update Client Contact" },
                    { 1, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(8361), "Add User" },
                    { 2, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9005), "Update User" },
                    { 3, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9037), "Delete User" },
                    { 4, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9049), "View User" },
                    { 5, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9063), "Change User Password" },
                    { 6, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9081), "Add Client" },
                    { 73, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9987), "Update Company" },
                    { 8, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9105), "Delete Client" },
                    { 9, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9115), "View Client" },
                    { 10, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9132), "Change Client Password" },
                    { 11, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9144), "Add Client Note" },
                    { 12, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9155), "Update Client Note" },
                    { 13, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9166), "Delete Client Note" },
                    { 14, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9176), "View Client Note" },
                    { 15, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9188), "Add Client Contact" },
                    { 35, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9422), "Add Permissions" },
                    { 36, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9434), "Remove Permissions" },
                    { 7, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9094), "Update Client" },
                    { 38, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9573), "Add Menu To Role" },
                    { 59, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9810), "Process Invoice" },
                    { 60, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9819), "Add Menu" },
                    { 61, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9829), "Update Menu" },
                    { 62, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9840), "Activate Menu" },
                    { 63, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9852), "Deactivate Menu" },
                    { 64, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9864), "Delete Menu" },
                    { 58, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9800), "Finalise Invoice" },
                    { 65, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9874), "View Menu" },
                    { 67, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9902), "View Custom Setting" },
                    { 68, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9914), "Add Document Type" },
                    { 69, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9926), "Update Document Type" },
                    { 70, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9937), "Delete Document Type" },
                    { 71, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9948), "View Document Type" },
                    { 37, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9445), "View Permissions" },
                    { 66, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9890), "Update Custom Setting" },
                    { 57, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9787), "Delete Invoice" },
                    { 56, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9777), "View Invoice" },
                    { 46, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9668), "Delete Department" },
                    { 41, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9611), "Update Product" },
                    { 42, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9623), "Delete Product" },
                    { 43, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9634), "View Product" },
                    { 44, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9645), "Add Department" },
                    { 45, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9657), "Update Department" },
                    { 55, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9767), "Override Payment" },
                    { 40, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9600), "Add Product" },
                    { 47, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9678), "View Department" },
                    { 49, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9698), "Reverse Payment" },
                    { 50, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9709), "View Payment" },
                    { 51, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9721), "View Client Outstanding Payments" },
                    { 52, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9733), "Generate Invoices" },
                    { 53, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9744), "Remove Invoice Entries" },
                    { 54, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9756), "View Client Deductions" },
                    { 48, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9689), "Capture Payment" },
                    { 39, null, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 780, DateTimeKind.Local).AddTicks(9589), "Remove Menu From Role" }
                });

            migrationBuilder.InsertData(
                table: "PinCodeTypes",
                columns: new[] { "PinCodeTypeID", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 2, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 854, DateTimeKind.Local).AddTicks(6075), "Multi Factor Authenticator" },
                    { 1, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 854, DateTimeKind.Local).AddTicks(5817), "Password Reset" },
                    { 3, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 854, DateTimeKind.Local).AddTicks(6086), "Account Creation" }
                });

            migrationBuilder.InsertData(
                table: "PriorityRanks",
                columns: new[] { "PriorityRankID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 808, DateTimeKind.Local).AddTicks(8932), "Critical" },
                    { 4, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 808, DateTimeKind.Local).AddTicks(9307), "Low" },
                    { 3, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 808, DateTimeKind.Local).AddTicks(9301), "Medium" },
                    { 2, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 808, DateTimeKind.Local).AddTicks(9285), "High" }
                });

            migrationBuilder.InsertData(
                table: "RecordStatus",
                columns: new[] { "RecordStatusID", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 3, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 839, DateTimeKind.Local).AddTicks(8430), "History" },
                    { 2, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 839, DateTimeKind.Local).AddTicks(8411), "Deleted" },
                    { 1, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 839, DateTimeKind.Local).AddTicks(7953), "Active" }
                });

            migrationBuilder.InsertData(
                table: "RelationshipTypes",
                columns: new[] { "RelationshipTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 2, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 800, DateTimeKind.Local).AddTicks(1082), "Mother" },
                    { 1, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 800, DateTimeKind.Local).AddTicks(964), "Self" },
                    { 4, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 800, DateTimeKind.Local).AddTicks(1095), "Sibling" },
                    { 6, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 800, DateTimeKind.Local).AddTicks(1109), "Business Partner" },
                    { 7, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 800, DateTimeKind.Local).AddTicks(1115), "Other" },
                    { 3, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 800, DateTimeKind.Local).AddTicks(1089), "Father" },
                    { 5, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 800, DateTimeKind.Local).AddTicks(1100), "Spouse" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "Description", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, null, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 770, DateTimeKind.Local).AddTicks(7172), "Super Admin" },
                    { 2, null, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 775, DateTimeKind.Local).AddTicks(4166), "Employee" },
                    { 3, null, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 775, DateTimeKind.Local).AddTicks(4273), "Administrator" }
                });

            migrationBuilder.InsertData(
                table: "StatementLists",
                columns: new[] { "StatementID", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 833, DateTimeKind.Local).AddTicks(7273), "Product Based Statement" },
                    { 3, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 833, DateTimeKind.Local).AddTicks(7743), "Outstanding Payments" },
                    { 4, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 833, DateTimeKind.Local).AddTicks(7748), "Deductions" },
                    { 2, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 833, DateTimeKind.Local).AddTicks(7730), "Transaction List" }
                });

            migrationBuilder.InsertData(
                table: "TechnicalSupport",
                columns: new[] { "TechnicalSupportID", "LastChangedBy", "LastChangedDate", "Name", "Value" },
                values: new object[,]
                {
                    { 7, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 852, DateTimeKind.Local).AddTicks(8222), "Support Email Address", "" },
                    { 6, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 852, DateTimeKind.Local).AddTicks(8215), "Database Server IP", "" },
                    { 5, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 852, DateTimeKind.Local).AddTicks(8139), "Whatsapp Support Message", "" },
                    { 4, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 852, DateTimeKind.Local).AddTicks(8132), "Website", "" },
                    { 3, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 852, DateTimeKind.Local).AddTicks(8126), "Mobile Number", "" },
                    { 2, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 852, DateTimeKind.Local).AddTicks(8113), "Company Registration Link", "" },
                    { 1, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 852, DateTimeKind.Local).AddTicks(7806), "CompanyName", "" }
                });

            migrationBuilder.InsertData(
                table: "Titles",
                columns: new[] { "TitleID", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 4, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 835, DateTimeKind.Local).AddTicks(6818), "Ms" },
                    { 2, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 835, DateTimeKind.Local).AddTicks(6801), "Mrs" },
                    { 3, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 835, DateTimeKind.Local).AddTicks(6812), "Miss" },
                    { 6, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 835, DateTimeKind.Local).AddTicks(6831), "Prof" },
                    { 5, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 835, DateTimeKind.Local).AddTicks(6822), "Dr" },
                    { 1, true, false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 835, DateTimeKind.Local).AddTicks(6503), "Mr" }
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
                    { 2, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 798, DateTimeKind.Local).AddTicks(5386), "Employer" },
                    { 1, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 798, DateTimeKind.Local).AddTicks(4900), "Administrator" },
                    { 3, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 798, DateTimeKind.Local).AddTicks(5403), "Employee" }
                });

            migrationBuilder.InsertData(
                table: "VariableTypes",
                columns: new[] { "CustomVariableTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 5, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 802, DateTimeKind.Local).AddTicks(5665), "Double" },
                    { 9, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 802, DateTimeKind.Local).AddTicks(5806), "Percentage" },
                    { 8, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 802, DateTimeKind.Local).AddTicks(5797), "Password" },
                    { 7, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 802, DateTimeKind.Local).AddTicks(5788), "Date Time" },
                    { 1, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 802, DateTimeKind.Local).AddTicks(5126), "Boolean" },
                    { 2, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 802, DateTimeKind.Local).AddTicks(5628), "String" },
                    { 3, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 802, DateTimeKind.Local).AddTicks(5648), "Long" },
                    { 4, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 802, DateTimeKind.Local).AddTicks(5657), "Integer" },
                    { 6, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 802, DateTimeKind.Local).AddTicks(5773), "Decimal" }
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
                columns: new[] { "CustomSettingID", "CustomVariableTypeID", "Description", "IsActive", "LastChangedBy", "LastChangedDate", "Name", "Value" },
                values: new object[,]
                {
                    { 3, 1, "Allows system to hide exceptions and show custom error page to user", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5180), "Show Custom Exceptions To Users", "true" },
                    { 31, 2, "Customer Support Number", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5483), "Site Customer Service Number", "+61411629968" },
                    { 32, 2, "Default Email Addresss that overrides Client Email Address in a Test Environment ", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5489), "Site Test Email Account", "carochire@gmail.com" },
                    { 41, 2, "Sets the Font Name for PDF Reports Body Section", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5543), "Report Body Font Name", "Arial" },
                    { 43, 2, "Sets the Font Name for PDF Reports Footer Section", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5556), "Report Footer Font Name", "Arial" },
                    { 4, 4, "Limit Account Number Size", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5158), "Account Number Length", "9" },
                    { 6, 4, "Port used to Send Emails", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5272), "Mail SMTP Port", "587" },
                    { 26, 4, "Pin Code Length", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5455), "Pin Code Length", "6" },
                    { 27, 4, "Password Reset Pin Code Validity Period in Days", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5462), "Password Reset Pin Validity", "2" },
                    { 30, 2, "Customer Support Email", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5476), "Site Customer Service Email", "welovecoding@elroitec.co.za" },
                    { 33, 4, "Current System Environment Set it to 1 For Test Environment  or 2 for Production Environment if no value has been set System defaults to Test Environment ", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5497), "Site Default Environment", "1" },
                    { 40, 4, "Default Due date for note if not set by person who created it", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5536), "Client Notes Default Due Date Interval", "5" },
                    { 42, 4, "Sets the Font Size for PDF Reports Body Section", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5549), "Report Body Font Size", "9" },
                    { 44, 4, "Sets the Font Size for PDF Reports Footer Section", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5562), "Report Footer Font Size", "8" },
                    { 46, 4, "Passcode Validity Period in Minutes", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5576), "Pass Code Validity Period", "60" },
                    { 14, 6, "Maximum file size that can be uploaded to the System", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5389), "File Maximum UpLoadable Size", "5" },
                    { 5, 7, "Format Used to display date", false, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5187), "Date Format", "yyyy-MMM-dd" },
                    { 39, 7, "Format Used to display date time", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5194), "Date Time Format", "yyyy-MMM-dd HH:mm" },
                    { 11, 8, "Email Password", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5363), "Mail Credential Password", "ZGNvaXpoeGlxenZ3dnphaw==" },
                    { 36, 4, "Password Validity Period in Days", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5514), "Password Validity Period", "30" },
                    { 28, 2, "Site URL", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5469), "Site URL", "http://smartloan.elroitec.com/" },
                    { 13, 9, "Percentage To Which VAT is calculated on ", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5379), "VAT Percentage", "0.14" },
                    { 24, 2, "Password Used to Open Password Protected Statement By System Administrators", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5427), "Statement Password For Admin", "123456" },
                    { 22, 2, "Default Email Subject Name Used By Auto-Generated Emails", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5448), "Mail Default Subject", "Smart Loan  Admin" },
                    { 8, 1, "Enable SSL", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5288), "Mail Enable SSL", "true" },
                    { 9, 1, "Use Default Mail Credentials", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5296), "Mail Use Default Credentials", "false" },
                    { 20, 1, "Instructs the System to Advise User to Capture VAT inclusive amounts and calculate breakdown accordingly", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5419), "Capture VAT Inclusive Payments", "true" },
                    { 23, 1, "Allows to password protect statements being sent by Email", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5434), "Statement Password Protect", "true" },
                    { 25, 1, "Determines if table borders will be shown on the report ", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5442), "Statement Show Table Boarders", "true" },
                    { 34, 1, "Display menus based on User Role", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5505), "Application Role Based Menus", "false" },
                    { 37, 1, "Auto Generate Account Numbers", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5521), "Account Number Auto Generate", "true" },
                    { 45, 1, "Increases System Security by Allowing Users to Authenticate Themselves Twice", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5569), "Allow Two Factor Authentication", "true" },
                    { 38, 1, "Allows System To Be VAT Compliant and Show calculated VAT Amounts ", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5528), "Application Is VAT Compliant", "false" },
                    { 16, 2, "Short Name for Application", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5141), "Application Name Prefix", "SL" },
                    { 2, 2, "Displays Current Version of the System", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5151), "System Version", "1.0.0.0" },
                    { 15, 2, "Account Number Prefix if Any", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5165), "Account Number Prefix", "SL" },
                    { 7, 2, "Host used to Send Emails", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5280), "Mail SMTP Host", "smtp.gmail.com" },
                    { 10, 2, "Email Address used to email", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5304), "Mail Credential User Name", "carolinesolutions89@gmail.com" },
                    { 12, 2, "Display Sender Name As", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5371), "Mail Display Name", "Smart Admin" },
                    { 17, 2, "First Line on the Report Footer", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5398), "Report Footer 1", "W. Guri Mrs. (Chairman), *E. Guri (Managing)" },
                    { 18, 2, "Additional Line on the Report Footer (can be blank)", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5406), "Report Footer 2", "*Executive." },
                    { 19, 2, "Foot notes that you would like to include on your statement (not mandatory)", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5412), "Report FootNotes", "" },
                    { 1, 2, "Displayed as the Application Name", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(5003), "Application Name", "Smart Loans" }
                });

            migrationBuilder.InsertData(
                table: "DocumentTypes",
                columns: new[] { "DocumentTypeID", "DocumentFormatID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 3, 1, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 815, DateTimeKind.Local).AddTicks(6782), "Proof Of Address" },
                    { 1, 1, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 815, DateTimeKind.Local).AddTicks(6235), "Identity Document" },
                    { 2, 1, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 815, DateTimeKind.Local).AddTicks(6753), "Birth Certificate" },
                    { 4, 1, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 815, DateTimeKind.Local).AddTicks(6789), "Payslips" }
                });

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "EmailTemplateID", "Body", "EmailTypeID", "LastChangedBy", "LastChangedDate", "PriorityRankID", "Subject" },
                values: new object[] { 1, @"Dear Customer, 

                        Attached is your Account statement. To view it you will need to open the PDF attachment and insert your password. Your password is your ID number. To view your statement you need to have Adobe PDF Reader installed. If you do not have it, you will need to do the following: - Copy and paste this URL into your browser: www.get.adobe.com/reader/?promoid=BUIGO - Go to the website - Click the download button and follow the easy instructions.


                        Regards,

                        Smart Saver", 1, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 825, DateTimeKind.Local).AddTicks(6115), 2, "Account Statement" });

            migrationBuilder.InsertData(
                table: "LayoutMenus",
                columns: new[] { "LayoutMenuID", "ActionName", "CSSClass", "ControllerName", "DisplayName", "IsActive", "LastChangedBy", "LastChangedDate", "LayoutID", "LinkRequiresID", "OrderNo" },
                values: new object[,]
                {
                    { 29, "MyAccount", "fa fa-heart", "Client", "My Account", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(575), 6, true, 29 },
                    { 28, "Country", "fa fa-globe", "Country", "Country", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(570), 4, true, 28 },
                    { 27, "Currency", "fa fa-money", "Currency", "Currency", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(565), 4, true, 27 },
                    { 26, "DocumentTypes", "fa fa-file", "DocumentType", "Document Types", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(560), 4, true, 26 },
                    { 25, "Department", "fa fa-building", "Department", "Departments", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(556), 4, true, 25 },
                    { 15, "FeatureFlag", "fa fa-building", "FeatureFlag", "Feature Flags", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(503), 3, true, 15 },
                    { 24, "EmailTemplate", "fa fa-envelope-o", "EmailTemplate", "Email Templates", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(551), 4, true, 24 },
                    { 23, "NoticeBoard", "fa fa-bell", "NoticeBoard", "Notice Board", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(546), 4, true, 23 },
                    { 22, "BankAccounts", "fa fa-university", "BankAccounts", "Banks", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(541), 4, true, 22 },
                    { 20, "TransactionType", "fa fa-money", "TransactionType", "Transaction Types", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(530), 4, true, 20 },
                    { 19, "Companies", "fa fa-building", "Company", "Companies", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(525), 4, true, 19 },
                    { 18, "Roles", "fa fa-asterisk", "Roles", "Roles & Permissions", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(519), 4, true, 18 },
                    { 17, "Users", "fa fa-users", "User", "User Management", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(514), 4, true, 17 },
                    { 16, "CustomSettings", "fa fa-spinner", "CustomSettings", "Application Settings", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(509), 4, true, 16 },
                    { 30, "Clients", "fa fa-users", "Client", "Employees", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(580), 7, true, 30 },
                    { 14, "Maintanance", "fa fa-wrench", "Maintanance", "Maintanance", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(453), 3, true, 14 },
                    { 7, "Dependents", "fa fa-child", "Client", "Dependents", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(155), 1, true, 7 },
                    { 12, "Support", "fa fa-anchor", "Support", "Support", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(442), 3, true, 12 },
                    { 1, "Loans", "fa fa-bomb", "Client", "Loans", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 848, DateTimeKind.Local).AddTicks(9953), 1, true, 1 },
                    { 2, "PaidTransactions", "fa fa-cc-mastercard", "Client", "Payments File", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(123), 1, true, 2 },
                    { 3, "PendingTransactions", "fa fa-credit-card", "Client", "Outstanding Payments", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(130), 1, true, 3 },
                    { 4, "Statements", "fa fa-file", "Client", "Statements", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(135), 1, true, 4 },
                    { 5, "Notes", "fa fa-comments", "Client", "Notes", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(140), 1, true, 5 },
                    { 13, "Licence", "fa  fa-key", "Licence", "Licence", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(448), 3, true, 13 },
                    { 8, "Contacts", "glyphicon glyphicon-envelope", "Client", "Contacts", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(160), 1, true, 8 },
                    { 6, "Documents", "fa fa-book", "Client", "Documents", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(150), 1, true, 6 },
                    { 11, "Loans", "fa fa-line-chart", "LoanManager", "Manager Loans", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(419), 2, false, 0 },
                    { 21, "LoanUse", "fa fa-american-sign-language-interpreting", "LoanUse", "Loan Uses", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(536), 2, true, 21 },
                    { 31, "LoanType", "fa fa-cog", "LoanType", "Loan Types", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(585), 2, true, 31 },
                    { 32, "LoanStatus", "fa fa-cogs", "LoanStatus", "Loan Status", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(590), 2, true, 32 },
                    { 33, "Fee", "fa fa fa-fax", "Fee", "Fees", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(595), 2, true, 33 },
                    { 34, "Product", "fa fa-bomb", "Product", "Products", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(600), 2, true, 34 },
                    { 35, "ProductComputation", "fa fa-hdd-o", "ProductComputation", "Product Computing", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(607), 2, true, 35 },
                    { 9, "Category", "fa fa-calculator", "Category", "Category", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 849, DateTimeKind.Local).AddTicks(166), 2, false, 9 }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuID", "ActionName", "CSSClass", "ControllerName", "DisplayName", "IsActive", "LastChangedBy", "LastChangedDate", "MenuGroupID", "OrderNo" },
                values: new object[,]
                {
                    { 9996, "MainMenu", "fa fa-book", "Menus", "Main Menu", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 819, DateTimeKind.Local).AddTicks(5227), 9998, 9996 },
                    { 5, "Invoices", "fa fa-gear", "Transactions", "Invoices", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 819, DateTimeKind.Local).AddTicks(5174), 6, 5 },
                    { 9994, "Dashboard", "fa fa-desktop", "FeatureFlag", "Technical Menu", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 819, DateTimeKind.Local).AddTicks(5207), 999, 9994 },
                    { 9995, "Layouts", "fa fa-bars", "Layouts", "Layout", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 819, DateTimeKind.Local).AddTicks(5215), 9998, 9995 },
                    { 8, "DashBoard", "fas fa-registered", "Reporting", "Reports", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 819, DateTimeKind.Local).AddTicks(5190), 4, 8 },
                    { 9, "Dashboard", "fa fa-gear", "CustomSettings", "Parameters", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 819, DateTimeKind.Local).AddTicks(5199), 5, 9 },
                    { 4, "Transactions", "fa fa-money", "Transactions", "Transactions", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 819, DateTimeKind.Local).AddTicks(5165), 3, 4 },
                    { 2, "MyAccount", "fa fa-heart", "Client", "My Account", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 819, DateTimeKind.Local).AddTicks(5143), 2, 0 },
                    { 1, "Clients", "fa fa-users", "Client", "Clients", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 819, DateTimeKind.Local).AddTicks(4843), 2, 1 },
                    { 3, "Dashboard", "fa fa-calculator", "Loan", "Loans", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 819, DateTimeKind.Local).AddTicks(5157), 7, 3 }
                });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "RolePermissionID", "LastChangedBy", "LastChangedDate", "PermissionID", "RoleID" },
                values: new object[,]
                {
                    { 100, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1976), 100, 1 },
                    { 101, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1982), 101, 1 },
                    { 102, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1988), 102, 1 },
                    { 103, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1994), 103, 1 },
                    { 104, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2000), 104, 1 },
                    { 105, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2006), 105, 1 },
                    { 106, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2012), 106, 1 },
                    { 109, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2032), 109, 1 },
                    { 108, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2025), 108, 1 },
                    { 110, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2039), 110, 1 },
                    { 111, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2046), 111, 1 },
                    { 112, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2053), 112, 1 },
                    { 113, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2061), 113, 1 },
                    { 114, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2069), 114, 1 },
                    { 115, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2075), 115, 1 },
                    { 107, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2019), 107, 1 },
                    { 99, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1969), 99, 1 },
                    { 96, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1949), 96, 1 },
                    { 97, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1956), 97, 1 },
                    { 80, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1839), 80, 1 },
                    { 81, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1846), 81, 1 },
                    { 82, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1853), 82, 1 },
                    { 83, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1860), 83, 1 },
                    { 84, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1867), 84, 1 },
                    { 85, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1874), 85, 1 },
                    { 86, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1882), 86, 1 },
                    { 98, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1963), 98, 1 },
                    { 87, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1889), 87, 1 },
                    { 89, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1903), 89, 1 },
                    { 90, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1909), 90, 1 },
                    { 91, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1917), 91, 1 },
                    { 92, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1922), 92, 1 },
                    { 93, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1930), 93, 1 },
                    { 94, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1936), 94, 1 },
                    { 95, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1943), 95, 1 },
                    { 88, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1896), 88, 1 },
                    { 116, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2082), 116, 1 },
                    { 119, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2102), 119, 1 },
                    { 118, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2096), 118, 1 },
                    { 140, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2259), 140, 1 },
                    { 141, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2266), 141, 1 },
                    { 142, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2273), 142, 1 },
                    { 143, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2280), 143, 1 },
                    { 144, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2287), 144, 1 },
                    { 145, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2297), 145, 1 },
                    { 146, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2333), 146, 1 },
                    { 139, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2252), 139, 1 },
                    { 147, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2340), 147, 1 },
                    { 149, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2352), 149, 1 },
                    { 150, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2358), 150, 1 },
                    { 151, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2365), 151, 1 },
                    { 152, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2371), 152, 1 },
                    { 153, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2379), 153, 1 },
                    { 154, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2385), 154, 1 },
                    { 79, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1832), 79, 1 },
                    { 148, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2346), 148, 1 },
                    { 117, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2088), 117, 1 },
                    { 138, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2245), 138, 1 },
                    { 136, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2231), 136, 1 },
                    { 120, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2109), 120, 1 },
                    { 121, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2117), 121, 1 },
                    { 122, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2123), 122, 1 },
                    { 123, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2130), 123, 1 },
                    { 124, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2138), 124, 1 },
                    { 125, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2146), 125, 1 },
                    { 126, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2153), 126, 1 },
                    { 137, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2238), 137, 1 },
                    { 127, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2161), 127, 1 },
                    { 129, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2176), 129, 1 },
                    { 130, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2188), 130, 1 },
                    { 131, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2196), 131, 1 },
                    { 132, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2203), 132, 1 },
                    { 133, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2211), 133, 1 },
                    { 134, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2218), 134, 1 },
                    { 135, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2225), 135, 1 },
                    { 128, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(2169), 128, 1 },
                    { 78, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1826), 78, 1 },
                    { 37, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1464), 37, 1 },
                    { 76, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1812), 76, 1 },
                    { 21, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1312), 21, 1 },
                    { 22, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1319), 22, 1 },
                    { 23, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1326), 23, 1 },
                    { 24, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1333), 24, 1 },
                    { 25, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1341), 25, 1 },
                    { 26, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1349), 26, 1 },
                    { 27, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1358), 27, 1 },
                    { 28, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1365), 28, 1 },
                    { 29, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1373), 29, 1 },
                    { 30, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1379), 30, 1 },
                    { 31, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1386), 31, 1 },
                    { 32, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1394), 32, 1 },
                    { 77, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1819), 77, 1 },
                    { 34, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1440), 34, 1 },
                    { 35, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1448), 35, 1 },
                    { 20, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1305), 20, 1 },
                    { 19, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1298), 19, 1 },
                    { 18, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1290), 18, 1 },
                    { 17, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1281), 17, 1 },
                    { 1, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(948), 1, 1 },
                    { 2, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1162), 2, 1 },
                    { 3, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1175), 3, 1 },
                    { 4, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1182), 4, 1 },
                    { 5, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1189), 5, 1 },
                    { 6, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1201), 6, 1 },
                    { 7, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1209), 7, 1 },
                    { 36, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1455), 36, 1 },
                    { 8, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1215), 8, 1 },
                    { 10, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1230), 10, 1 },
                    { 11, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1236), 11, 1 },
                    { 12, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1244), 12, 1 },
                    { 13, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1250), 13, 1 },
                    { 14, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1258), 14, 1 },
                    { 15, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1265), 15, 1 },
                    { 16, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1273), 16, 1 },
                    { 9, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1221), 9, 1 },
                    { 38, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1471), 38, 1 },
                    { 33, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1401), 33, 1 },
                    { 62, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1631), 62, 1 },
                    { 60, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1617), 60, 1 },
                    { 39, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1479), 39, 1 },
                    { 63, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1639), 63, 1 },
                    { 64, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1645), 64, 1 },
                    { 65, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1652), 65, 1 },
                    { 66, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1735), 66, 1 },
                    { 67, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1744), 67, 1 },
                    { 68, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1752), 68, 1 },
                    { 69, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1760), 69, 1 },
                    { 70, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1769), 70, 1 },
                    { 71, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1775), 71, 1 },
                    { 72, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1782), 72, 1 },
                    { 73, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1789), 73, 1 },
                    { 74, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1798), 74, 1 },
                    { 75, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1805), 75, 1 },
                    { 59, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1610), 59, 1 },
                    { 58, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1603), 58, 1 },
                    { 61, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1625), 61, 1 },
                    { 56, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1590), 56, 1 },
                    { 40, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1486), 40, 1 },
                    { 41, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1493), 41, 1 },
                    { 42, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1500), 42, 1 },
                    { 43, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1506), 43, 1 },
                    { 44, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1512), 44, 1 },
                    { 57, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1596), 57, 1 },
                    { 46, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1523), 46, 1 },
                    { 47, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1530), 47, 1 },
                    { 45, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1518), 45, 1 },
                    { 49, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1542), 49, 1 },
                    { 50, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1548), 50, 1 },
                    { 51, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1556), 51, 1 },
                    { 52, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1563), 52, 1 },
                    { 53, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1570), 53, 1 },
                    { 54, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1577), 54, 1 },
                    { 55, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1584), 55, 1 },
                    { 48, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 782, DateTimeKind.Local).AddTicks(1536), 48, 1 }
                });

            migrationBuilder.InsertData(
                table: "TransactionType",
                columns: new[] { "TransactionTypeID", "Code", "Description", "IsActive", "LastChangedBy", "LastChangedDate", "Name", "TransactionStatusID" },
                values: new object[,]
                {
                    { 7, "DEP", null, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 789, DateTimeKind.Local).AddTicks(5212), "Deposit", 1 },
                    { 1, "PAY", null, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 789, DateTimeKind.Local).AddTicks(2709), "Payment", 1 },
                    { 2, "(R)", null, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 789, DateTimeKind.Local).AddTicks(4429), "Reversal", 1 },
                    { 3, "PURCH", null, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 789, DateTimeKind.Local).AddTicks(4656), "Purchase", 1 },
                    { 4, "SALE", null, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 789, DateTimeKind.Local).AddTicks(4812), "Sales", 1 },
                    { 5, "RPT", null, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 789, DateTimeKind.Local).AddTicks(4951), "Receipts", 1 },
                    { 6, "RECON", null, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 789, DateTimeKind.Local).AddTicks(5094), "Recon", 1 },
                    { 8, "FEE", null, true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 789, DateTimeKind.Local).AddTicks(5326), "Fee", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "CanOverrideMaintananceMode", "CompanyID", "EmailAddress", "FirstName", "GrantAccessToTestEnvironment", "IDNumber", "IsActive", "LastChangedBy", "LastChangedDate", "LastName", "Password", "PasswordExpiryDate", "ProfileImage", "UserTypeID" },
                values: new object[,]
                {
                    { 2, false, null, "carochire89@gmail.com", "Elroitec", false, "201703232441609", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 809, DateTimeKind.Local).AddTicks(9721), "Employer", "YWRtaW4=", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2 },
                    { 1, true, null, "carochire@gmail.com", "Wadzanai Caroline", true, "8904161200188", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 809, DateTimeKind.Local).AddTicks(4736), "Chirenje", "YWRtaW4=", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1 },
                    { 3, false, null, "carolinesolutions89@gmail.com", "Elroitec", false, "20200716041609", true, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 809, DateTimeKind.Local).AddTicks(9864), "Employee", "YWRtaW4=", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3 }
                });

            migrationBuilder.InsertData(
                table: "RoleMenus",
                columns: new[] { "RoleMenuID", "LastChangedBy", "LastChangedDate", "MenuID", "RoleID" },
                values: new object[,]
                {
                    { 1, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(9319), 1, 1 },
                    { 2, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(9402), 2, 1 },
                    { 4, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(9411), 4, 1 },
                    { 6, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(9420), 8, 1 },
                    { 7, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(9423), 9, 1 },
                    { 3, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(9407), 3, 1 },
                    { 9, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(9430), 9995, 1 },
                    { 10, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(9436), 9996, 1 },
                    { 8, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(9427), 9994, 1 },
                    { 5, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 829, DateTimeKind.Local).AddTicks(9414), 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserID", "RoleID", "LastChangedBy", "LastChangedDate", "UserRoleID" },
                values: new object[,]
                {
                    { 1, 1, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 815, DateTimeKind.Local).AddTicks(9996), 1 },
                    { 2, 3, "SuperUser", new DateTime(2022, 4, 9, 11, 43, 1, 816, DateTimeKind.Local).AddTicks(75), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_BankAccountTypeID",
                table: "BankAccounts",
                column: "BankAccountTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_CurrencyID",
                table: "BankAccounts",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryItems_SubCategoryID",
                table: "CategoryItems",
                column: "SubCategoryID");

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
                name: "IX_Clients_ClientAccountTypeID",
                table: "Clients",
                column: "ClientAccountTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ClientGroupID",
                table: "Clients",
                column: "ClientGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_CompanyID",
                table: "Clients",
                column: "CompanyID");

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
                name: "IX_Clients_TitleID",
                table: "Clients",
                column: "TitleID");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CountryID",
                table: "Companies",
                column: "CountryID");

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
                name: "IX_InvoiceDetails_ClientID",
                table: "InvoiceDetails",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetails_DeductionTypeID",
                table: "InvoiceDetails",
                column: "DeductionTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetails_InvoiceID",
                table: "InvoiceDetails",
                column: "InvoiceID");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetails_PaymentStatusID",
                table: "InvoiceDetails",
                column: "PaymentStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetails_ProductID",
                table: "InvoiceDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_InvoiceStatusID",
                table: "Invoices",
                column: "InvoiceStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ProductID",
                table: "Invoices",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_JointApplicants_ClientID",
                table: "JointApplicants",
                column: "ClientID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_JointApplicants_CountryID",
                table: "JointApplicants",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_JointApplicants_GenderID",
                table: "JointApplicants",
                column: "GenderID");

            migrationBuilder.CreateIndex(
                name: "IX_JointApplicants_RecordStatusID",
                table: "JointApplicants",
                column: "RecordStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_JointApplicants_RelationshipTypeID",
                table: "JointApplicants",
                column: "RelationshipTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_JointApplicants_TitleID",
                table: "JointApplicants",
                column: "TitleID");

            migrationBuilder.CreateIndex(
                name: "IX_LayoutMenus_LayoutID",
                table: "LayoutMenus",
                column: "LayoutID");

            migrationBuilder.CreateIndex(
                name: "IX_LoanBeneficiaries_CategoryItemID",
                table: "LoanBeneficiaries",
                column: "CategoryItemID");

            migrationBuilder.CreateIndex(
                name: "IX_LoanBeneficiaries_GenderID",
                table: "LoanBeneficiaries",
                column: "GenderID");

            migrationBuilder.CreateIndex(
                name: "IX_LoanBeneficiaries_LoanID",
                table: "LoanBeneficiaries",
                column: "LoanID");

            migrationBuilder.CreateIndex(
                name: "IX_LoanBeneficiaries_LoanID1",
                table: "LoanBeneficiaries",
                column: "LoanID1");

            migrationBuilder.CreateIndex(
                name: "IX_LoanBeneficiaries_RelationshipTypeID",
                table: "LoanBeneficiaries",
                column: "RelationshipTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_LoanDocuments_DocumentTypeID",
                table: "LoanDocuments",
                column: "DocumentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_LoanDocuments_LoanID",
                table: "LoanDocuments",
                column: "LoanID");

            migrationBuilder.CreateIndex(
                name: "IX_LoanFinances_LoanID",
                table: "LoanFinances",
                column: "LoanID");

            migrationBuilder.CreateIndex(
                name: "IX_LoanNotes_LoanID",
                table: "LoanNotes",
                column: "LoanID");

            migrationBuilder.CreateIndex(
                name: "IX_LoanNotes_UserTypeID",
                table: "LoanNotes",
                column: "UserTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_ClientID",
                table: "Loans",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_LoanSectorID",
                table: "Loans",
                column: "LoanSectorID");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_LoanStatusID",
                table: "Loans",
                column: "LoanStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_LoanTypeID",
                table: "Loans",
                column: "LoanTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_LoanUseID",
                table: "Loans",
                column: "LoanUseID");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_ProductID",
                table: "Loans",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_LoanSchedules_LoanID",
                table: "LoanSchedules",
                column: "LoanID");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_MenuGroupID",
                table: "Menus",
                column: "MenuGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_NoticeBoard_PriorityRankID",
                table: "NoticeBoard",
                column: "PriorityRankID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeeHistory_FeeID",
                table: "ProductFeeHistory",
                column: "FeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeeHistory_ProductID",
                table: "ProductFeeHistory",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFees_FeeID",
                table: "ProductFees",
                column: "FeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFees_ProductID",
                table: "ProductFees",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductHistory_ProductID",
                table: "ProductHistory",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPenalties_ProductID",
                table: "ProductPenalties",
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
                name: "IX_Products_CurrencyID",
                table: "Products",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductComputationID",
                table: "Products",
                column: "ProductComputationID");

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
                name: "IX_SubCategories_CategoryID",
                table: "SubCategories",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_BankAccountID",
                table: "Transactions",
                column: "BankAccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ClientID",
                table: "Transactions",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_InvoiceDetailsInvoiceDetailID",
                table: "Transactions",
                column: "InvoiceDetailsInvoiceDetailID");

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
                name: "IX_UserAccessGrants_UserID",
                table: "UserAccessGrants",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserAccessRestrictions_UserID",
                table: "UserAccessRestrictions",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserAuthenticationCodes_ClientID",
                table: "UserAuthenticationCodes",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_UserAuthenticationCodes_PinCodeTypeID",
                table: "UserAuthenticationCodes",
                column: "PinCodeTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_UserAuthenticationCodes_UserID",
                table: "UserAuthenticationCodes",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleID",
                table: "UserRoles",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CompanyID",
                table: "Users",
                column: "CompanyID");

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
                name: "ClientDependents");

            migrationBuilder.DropTable(
                name: "ClientDocuments");

            migrationBuilder.DropTable(
                name: "ClientNotes");

            migrationBuilder.DropTable(
                name: "ClientOccupationHistory");

            migrationBuilder.DropTable(
                name: "CustomSettings");

            migrationBuilder.DropTable(
                name: "EmailTemplates");

            migrationBuilder.DropTable(
                name: "ErrorLogging");

            migrationBuilder.DropTable(
                name: "FeatureFlags");

            migrationBuilder.DropTable(
                name: "JointApplicants");

            migrationBuilder.DropTable(
                name: "LayoutMenus");

            migrationBuilder.DropTable(
                name: "Licences");

            migrationBuilder.DropTable(
                name: "LoanBeneficiaries");

            migrationBuilder.DropTable(
                name: "LoanDocuments");

            migrationBuilder.DropTable(
                name: "LoanFinances");

            migrationBuilder.DropTable(
                name: "LoanFiscals");

            migrationBuilder.DropTable(
                name: "LoanNotes");

            migrationBuilder.DropTable(
                name: "LoanSchedules");

            migrationBuilder.DropTable(
                name: "Maintanances");

            migrationBuilder.DropTable(
                name: "NoticeBoard");

            migrationBuilder.DropTable(
                name: "PenaltyTypes");

            migrationBuilder.DropTable(
                name: "ProductFeeHistory");

            migrationBuilder.DropTable(
                name: "ProductFees");

            migrationBuilder.DropTable(
                name: "ProductHistory");

            migrationBuilder.DropTable(
                name: "ProductPenalties");

            migrationBuilder.DropTable(
                name: "RoleMenus");

            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "StatementLists");

            migrationBuilder.DropTable(
                name: "TechnicalSupport");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "UserAccessGrants");

            migrationBuilder.DropTable(
                name: "UserAccessRestrictions");

            migrationBuilder.DropTable(
                name: "UserAuthenticationCodes");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "WeekDays");

            migrationBuilder.DropTable(
                name: "ContactTypes");

            migrationBuilder.DropTable(
                name: "VariableTypes");

            migrationBuilder.DropTable(
                name: "EmailTypes");

            migrationBuilder.DropTable(
                name: "RecordStatus");

            migrationBuilder.DropTable(
                name: "Layouts");

            migrationBuilder.DropTable(
                name: "CategoryItems");

            migrationBuilder.DropTable(
                name: "RelationshipTypes");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "PriorityRanks");

            migrationBuilder.DropTable(
                name: "Fees");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "BankAccounts");

            migrationBuilder.DropTable(
                name: "InvoiceDetails");

            migrationBuilder.DropTable(
                name: "TransactionType");

            migrationBuilder.DropTable(
                name: "PinCodeTypes");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "DocumentFormats");

            migrationBuilder.DropTable(
                name: "LoanSectors");

            migrationBuilder.DropTable(
                name: "LoanStatus");

            migrationBuilder.DropTable(
                name: "LoanTypes");

            migrationBuilder.DropTable(
                name: "LoanUses");

            migrationBuilder.DropTable(
                name: "MenuGroups");

            migrationBuilder.DropTable(
                name: "BankAccountTypes");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "DeductionTypes");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "PaymentStatus");

            migrationBuilder.DropTable(
                name: "TransactionStatus");

            migrationBuilder.DropTable(
                name: "UserTypes");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "ClientAccountTypes");

            migrationBuilder.DropTable(
                name: "ClientGroups");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Titles");

            migrationBuilder.DropTable(
                name: "InvoiceStatuses");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "ProductComputations");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
