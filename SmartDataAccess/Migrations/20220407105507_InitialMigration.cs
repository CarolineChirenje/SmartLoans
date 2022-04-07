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
                name: "FundItems",
                columns: table => new
                {
                    FundItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundItems", x => x.FundItemID);
                });

            migrationBuilder.CreateTable(
                name: "Funds",
                columns: table => new
                {
                    FundID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funds", x => x.FundID);
                });

            migrationBuilder.CreateTable(
                name: "FundSources",
                columns: table => new
                {
                    FundSourceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundSources", x => x.FundSourceID);
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
                name: "KonapoFundCTIHistories",
                columns: table => new
                {
                    KonapoFundCTIHistoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    KonapoFundCTIID = table.Column<int>(nullable: false),
                    FundSourceID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ProjectedCost = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    KonapoAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KonapoFundCTIHistories", x => x.KonapoFundCTIHistoryID);
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
                name: "FundCategories",
                columns: table => new
                {
                    FundCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    FundID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundCategories", x => x.FundCategoryID);
                    table.ForeignKey(
                        name: "FK_FundCategories_Funds_FundID",
                        column: x => x.FundID,
                        principalTable: "Funds",
                        principalColumn: "FundID",
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
                name: "FundCategoryItems",
                columns: table => new
                {
                    FundCategoryItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    FundItemID = table.Column<int>(nullable: false),
                    FundCategoryID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundCategoryItems", x => x.FundCategoryItemID);
                    table.ForeignKey(
                        name: "FK_FundCategoryItems_FundCategories_FundCategoryID",
                        column: x => x.FundCategoryID,
                        principalTable: "FundCategories",
                        principalColumn: "FundCategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FundCategoryItems_FundItems_FundItemID",
                        column: x => x.FundItemID,
                        principalTable: "FundItems",
                        principalColumn: "FundItemID",
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
                name: "KonapoFunds",
                columns: table => new
                {
                    KonapoFundID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    KonapoRef = table.Column<string>(nullable: true),
                    ClientID = table.Column<int>(nullable: false),
                    FundID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KonapoFunds", x => x.KonapoFundID);
                    table.ForeignKey(
                        name: "FK_KonapoFunds_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KonapoFunds_Funds_FundID",
                        column: x => x.FundID,
                        principalTable: "Funds",
                        principalColumn: "FundID",
                        onDelete: ReferentialAction.Cascade);
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
                name: "KonapoFundCTs",
                columns: table => new
                {
                    KonapoFundCTID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    KonapoFundID = table.Column<int>(nullable: false),
                    FundCategoryID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    KonapoFundID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KonapoFundCTs", x => x.KonapoFundCTID);
                    table.ForeignKey(
                        name: "FK_KonapoFundCTs_FundCategories_FundCategoryID",
                        column: x => x.FundCategoryID,
                        principalTable: "FundCategories",
                        principalColumn: "FundCategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KonapoFundCTs_KonapoFunds_KonapoFundID",
                        column: x => x.KonapoFundID,
                        principalTable: "KonapoFunds",
                        principalColumn: "KonapoFundID");
                    table.ForeignKey(
                        name: "FK_KonapoFundCTs_KonapoFunds_KonapoFundID1",
                        column: x => x.KonapoFundID1,
                        principalTable: "KonapoFunds",
                        principalColumn: "KonapoFundID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KonapoFundReports",
                columns: table => new
                {
                    KonapoFundReportID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    KonapoFundID = table.Column<int>(nullable: false),
                    JsonData = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    QRCodeURL = table.Column<string>(nullable: true),
                    Report = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KonapoFundReports", x => x.KonapoFundReportID);
                    table.ForeignKey(
                        name: "FK_KonapoFundReports_KonapoFunds_KonapoFundID",
                        column: x => x.KonapoFundID,
                        principalTable: "KonapoFunds",
                        principalColumn: "KonapoFundID",
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
                    RelationshipTypeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanBeneficiaries", x => x.LoanBeneficiaryID);
                    table.ForeignKey(
                        name: "FK_LoanBeneficiaries_Loans_LoanID",
                        column: x => x.LoanID,
                        principalTable: "Loans",
                        principalColumn: "LoanID",
                        onDelete: ReferentialAction.Cascade);
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
                name: "KonapoFundCTIs",
                columns: table => new
                {
                    KonapoFundCTIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    KonapoFundCTID = table.Column<int>(nullable: false),
                    FundCategoryItemID = table.Column<int>(nullable: false),
                    FundSourceID = table.Column<int>(nullable: false),
                    ProjectedCost = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    KonapoAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    KonapoFundCTID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KonapoFundCTIs", x => x.KonapoFundCTIID);
                    table.ForeignKey(
                        name: "FK_KonapoFundCTIs_FundCategoryItems_FundCategoryItemID",
                        column: x => x.FundCategoryItemID,
                        principalTable: "FundCategoryItems",
                        principalColumn: "FundCategoryItemID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KonapoFundCTIs_FundSources_FundSourceID",
                        column: x => x.FundSourceID,
                        principalTable: "FundSources",
                        principalColumn: "FundSourceID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KonapoFundCTIs_KonapoFundCTs_KonapoFundCTID",
                        column: x => x.KonapoFundCTID,
                        principalTable: "KonapoFundCTs",
                        principalColumn: "KonapoFundCTID");
                    table.ForeignKey(
                        name: "FK_KonapoFundCTIs_KonapoFundCTs_KonapoFundCTID1",
                        column: x => x.KonapoFundCTID1,
                        principalTable: "KonapoFundCTs",
                        principalColumn: "KonapoFundCTID",
                        onDelete: ReferentialAction.Restrict);
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
                    { 1, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 529, DateTimeKind.Local).AddTicks(2400), "Savings" },
                    { 2, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 529, DateTimeKind.Local).AddTicks(3011), "Cheque" },
                    { 3, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 529, DateTimeKind.Local).AddTicks(3030), "Credit" },
                    { 4, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 529, DateTimeKind.Local).AddTicks(3040), "Cash" }
                });

            migrationBuilder.InsertData(
                table: "ClientAccountTypes",
                columns: new[] { "ID", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 591, DateTimeKind.Local).AddTicks(1348), "Individual" },
                    { 2, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 591, DateTimeKind.Local).AddTicks(1826), "Joint" }
                });

            migrationBuilder.InsertData(
                table: "ClientGroups",
                columns: new[] { "ClientGroupID", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 597, DateTimeKind.Local).AddTicks(2126), "Company" },
                    { 2, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 597, DateTimeKind.Local).AddTicks(2750), "Individual" }
                });

            migrationBuilder.InsertData(
                table: "ContactTypes",
                columns: new[] { "ContactTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 539, DateTimeKind.Local).AddTicks(4279), "Residential Address" },
                    { 2, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 539, DateTimeKind.Local).AddTicks(4268), "Postal Address" },
                    { 5, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 539, DateTimeKind.Local).AddTicks(4321), "Telephone" },
                    { 4, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 539, DateTimeKind.Local).AddTicks(4074), "Cell Phone" },
                    { 3, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 539, DateTimeKind.Local).AddTicks(4255), "Email Address" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 157, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9947), "Oman" },
                    { 146, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9795), "Nauru" },
                    { 147, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9846), "Nepal" },
                    { 149, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9867), "Netherlands Antilles" },
                    { 150, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9878), "New Caledonia" },
                    { 151, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9889), "New Zealand" },
                    { 152, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9898), "Nicaragua" },
                    { 153, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9908), "Niger" },
                    { 154, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9918), "Nigeria" },
                    { 155, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9928), "N Mariana Islands" },
                    { 156, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9937), "Norway" },
                    { 158, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9957), "Pakistan" },
                    { 164, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(13), "Philippines" },
                    { 160, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9976), "Panama" },
                    { 161, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9988), "Papua New Guinea" },
                    { 162, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9997), "Paraguay" },
                    { 163, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(5), "Peru" },
                    { 145, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9786), "Namibia" },
                    { 165, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(22), "Poland" },
                    { 166, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(31), "Portugal" },
                    { 167, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(41), "Puerto Rico" },
                    { 168, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(50), "Qatar" },
                    { 169, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(59), "Reunion" },
                    { 170, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(68), "Romania" },
                    { 159, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9967), "Palau" },
                    { 144, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9777), "Mozambique" },
                    { 137, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9710), "Mexico" },
                    { 142, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9758), "Montserrat" },
                    { 117, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9526), "Lebanon" },
                    { 118, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9534), "Lesotho" },
                    { 119, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9543), "Liberia" },
                    { 120, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9552), "Libya" },
                    { 121, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9562), "Liechtenstein" },
                    { 122, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9571), "Lithuania" },
                    { 123, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9580), "Luxembourg" },
                    { 124, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9588), "Macau" },
                    { 125, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9597), "Macedonia" },
                    { 126, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9606), "Madagascar" },
                    { 127, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9615), "Malawi" },
                    { 128, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9624), "Malaysia" },
                    { 129, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9635), "Maldives" },
                    { 130, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9646), "Mali" },
                    { 131, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9656), "Malta" },
                    { 132, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9666), "Marshall Islands" },
                    { 133, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9675), "Martinique" },
                    { 134, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9684), "Mauritania" },
                    { 135, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9693), "Mauritius" },
                    { 136, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9701), "Mayotte" },
                    { 171, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(76), "Russia" },
                    { 138, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9721), "Micronesia Fed St" },
                    { 139, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9730), "Moldova" },
                    { 140, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9739), "Monaco" },
                    { 141, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9749), "Mongolia" },
                    { 143, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9768), "Morocco" },
                    { 172, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(88), "Rwanda" },
                    { 179, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(164), "San Marino" },
                    { 174, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(109), "Saint Kitts Nevis" },
                    { 204, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(402), "Togo" },
                    { 205, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(411), "Tonga" },
                    { 206, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(420), "Trinidad Tobago" },
                    { 207, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(428), "Tunisia" },
                    { 208, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(438), "Turkey" },
                    { 209, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(447), "Turkmenistan" },
                    { 210, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(458), "Turks Caicos Is" },
                    { 211, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(467), "Tuvalu" },
                    { 212, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(475), "Uganda" },
                    { 213, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(483), "Ukraine" },
                    { 214, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(536), "United Arab Emirates" },
                    { 215, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(549), "United Kingdom" },
                    { 216, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(558), "United States" },
                    { 217, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(567), "Uruguay" },
                    { 218, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(576), "Uzbekistan" },
                    { 219, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(585), "Vanuatu" },
                    { 220, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(594), "Venezuela" },
                    { 221, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(603), "Vietnam" },
                    { 222, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(613), "Virgin Islands" },
                    { 223, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(622), "Wallis Futuna" },
                    { 224, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(631), "West Bank" },
                    { 225, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(641), "Western Sahara" },
                    { 226, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(650), "Yemen" },
                    { 227, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(658), "Zambia" },
                    { 228, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(668), "Zimbabwe" },
                    { 203, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(393), "Thailand" },
                    { 173, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(98), "Saint Helena" },
                    { 202, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(385), "Tanzania" },
                    { 200, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(366), "Taiwan" },
                    { 175, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(120), "Saint Lucia" },
                    { 176, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(132), "St Pierre Miquelon" },
                    { 177, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(146), "Saint Vincent and the Grenadines" },
                    { 178, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(154), "Samoa" },
                    { 116, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9516), "Latvia" },
                    { 180, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(176), "Sao Tome Principe" },
                    { 181, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(186), "Saudi Arabia" },
                    { 182, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(195), "Senegal" },
                    { 183, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(205), "Serbia" },
                    { 184, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(214), "Seychelles" },
                    { 185, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(224), "Sierra Leone" },
                    { 186, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(234), "Singapore" },
                    { 187, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(243), "Slovakia" },
                    { 188, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(252), "Slovenia" },
                    { 189, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(262), "Solomon Islands" },
                    { 190, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(272), "Somalia" },
                    { 191, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(282), "South Africa" },
                    { 192, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(291), "Spain" },
                    { 193, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(302), "Sri Lanka" },
                    { 194, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(311), "Sudan" },
                    { 195, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(320), "Suriname" },
                    { 196, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(329), "Swaziland" },
                    { 197, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(338), "Sweden" },
                    { 198, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(348), "Switzerland" },
                    { 199, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(357), "Syria" },
                    { 201, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 548, DateTimeKind.Local).AddTicks(376), "Tajikistan" },
                    { 115, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9507), "Laos" },
                    { 148, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9856), "Netherlands" },
                    { 113, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9486), "Kuwait" },
                    { 30, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8501), "British Virgin Is" },
                    { 31, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8510), "Brunei" },
                    { 32, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8520), "Bulgaria" },
                    { 33, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8528), "Burkina Faso" },
                    { 34, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8609), "Burma" },
                    { 35, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8619), "Burundi" },
                    { 36, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8628), "Cambodia" },
                    { 37, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8637), "Cameroon" },
                    { 38, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8646), "Canada" },
                    { 39, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8656), "Cape Verde" },
                    { 40, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8668), "Cayman Islands" },
                    { 41, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8678), "Central African Rep" },
                    { 42, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8686), "Chad" },
                    { 43, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8696), "Chile" },
                    { 44, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8705), "China" },
                    { 45, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8714), "Colombia" },
                    { 46, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8723), "Comoros" },
                    { 47, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8734), "Congo Dem Rep" },
                    { 48, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8745), "Congo Repub of the" },
                    { 49, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8755), "Cook Islands" },
                    { 50, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8765), "Costa Rica" },
                    { 51, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8775), "Cote dIvoire" },
                    { 52, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8784), "Croatia" },
                    { 53, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8793), "Cuba" },
                    { 54, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8802), "Cyprus" },
                    { 29, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8490), "Brazil" },
                    { 55, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8813), "Czech Republic" },
                    { 28, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8481), "Botswana" },
                    { 26, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8462), "Bolivia" },
                    { 1, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(7604), "Afghanistan" },
                    { 2, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8210), "Albania" },
                    { 3, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8230), "Algeria" },
                    { 4, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8249), "American Samoa" },
                    { 5, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8259), "Andorra" },
                    { 6, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8275), "Angola" },
                    { 7, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8285), "Anguilla" },
                    { 8, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8297), "Antigua Barbuda" },
                    { 9, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8305), "Argentina" },
                    { 10, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8317), "Armenia" },
                    { 11, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8327), "Aruba" },
                    { 12, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8336), "Australia" },
                    { 13, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8344), "Austria" },
                    { 14, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8353), "Azerbaijan" },
                    { 15, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8361), "Bahamas" },
                    { 16, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8370), " The" },
                    { 17, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8379), "Bahrain" },
                    { 114, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9495), "Kyrgyzstan" },
                    { 19, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8400), "Barbados" },
                    { 20, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8409), "Belarus" },
                    { 21, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8418), "Belgium" },
                    { 22, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8427), "Belize" },
                    { 23, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8435), "Benin" },
                    { 24, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8444), "Bermuda" },
                    { 25, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8453), "Bhutan" },
                    { 27, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8472), "Bosnia Herzegovina" },
                    { 56, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8822), "Denmark" },
                    { 18, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8391), "Bangladesh" },
                    { 58, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8839), "Dominica" },
                    { 88, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9121), "Guinea" },
                    { 89, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9131), "Guinea Bissau" },
                    { 90, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9140), "Guyana" },
                    { 91, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9269), "Haiti" },
                    { 92, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9301), "Honduras" },
                    { 93, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9315), "Hong Kong" },
                    { 94, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9324), "Hungary" },
                    { 95, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9333), "Iceland" },
                    { 96, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9342), "India" },
                    { 97, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9351), "Indonesia" },
                    { 98, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9359), "Iran" },
                    { 99, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9368), "Iraq" },
                    { 100, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9378), "Ireland" },
                    { 101, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9386), "Isle of Man" },
                    { 102, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9393), "Israel" },
                    { 103, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9401), "Italy" },
                    { 105, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9415), "Japan" },
                    { 106, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9422), "Jersey" },
                    { 107, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9431), "Jordan" },
                    { 108, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9440), "Kazakhstan" },
                    { 109, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9449), "Kenya" },
                    { 110, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9458), "Kiribati" },
                    { 111, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9467), "Korea North" },
                    { 112, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9477), "Korea South" },
                    { 57, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8830), "Djibouti" },
                    { 87, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9113), "Guernsey" },
                    { 86, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9104), "Guatemala" },
                    { 104, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9408), "Jamaica" },
                    { 84, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9086), "Guadeloupe" },
                    { 59, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8850), "Dominican Republic" },
                    { 85, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9095), "Guam" },
                    { 60, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8860), "East Timor" },
                    { 61, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8869), "Ecuador" },
                    { 62, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8878), "Egypt" },
                    { 63, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8888), "El Salvador" },
                    { 65, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8907), "Eritrea" },
                    { 66, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8920), "Estonia" },
                    { 67, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8929), "Ethiopia" },
                    { 68, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8939), "Faroe Islands" },
                    { 69, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8948), "Fiji" },
                    { 70, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8957), "Finland" },
                    { 71, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8966), "France" },
                    { 64, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8898), "Equatorial Guinea" },
                    { 73, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8987), "French Polynesia" },
                    { 72, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8976), "French Guiana" },
                    { 83, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9077), "Grenada" },
                    { 81, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9059), "Greece" },
                    { 82, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9068), "Greenland" },
                    { 79, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9041), "Ghana" },
                    { 80, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9050), "Gibraltar" },
                    { 77, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9023), "Georgia" },
                    { 76, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9015), "Gaza Strip" },
                    { 75, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9006), "Gambia The" },
                    { 74, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(8995), "Gabon" },
                    { 78, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 547, DateTimeKind.Local).AddTicks(9032), "Germany" }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "CurrencyID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 107, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3978), "OMR" },
                    { 108, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3986), "PAB" },
                    { 106, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3969), "NZD" },
                    { 109, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3994), "PEN" },
                    { 110, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4002), "PGK" },
                    { 111, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4010), "PHP" },
                    { 112, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4019), "PKR" },
                    { 117, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4058), "RSD" },
                    { 114, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4033), "PYG" },
                    { 115, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4042), "QAR" },
                    { 116, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4050), "RON" },
                    { 118, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4067), "RUB" },
                    { 119, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4075), "RWF" },
                    { 121, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4090), "SBD" },
                    { 105, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3961), "NPR" },
                    { 120, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4082), "SAR" },
                    { 113, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4027), "PLN" },
                    { 104, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3954), "NOK" },
                    { 91, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3847), "MMK" },
                    { 102, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3939), "NGN" },
                    { 84, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3793), "LRD" },
                    { 122, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4099), "SCR" },
                    { 86, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3808), "LYD" },
                    { 87, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3816), "MAD" },
                    { 88, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3824), "MDL" },
                    { 89, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3831), "MGA" },
                    { 90, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3839), "MKD" },
                    { 92, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3856), "MNT" },
                    { 93, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3865), "MOP" },
                    { 94, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3872), "MRU" },
                    { 95, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3881), "MUR" },
                    { 96, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3890), "MVR" },
                    { 97, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3898), "MWK" },
                    { 98, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3907), "MXN" },
                    { 99, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3915), "MYR" },
                    { 100, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3923), "MZN" },
                    { 101, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3930), "NAD" },
                    { 103, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3947), "NIO" },
                    { 123, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4107), "SDG" },
                    { 151, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4409), "VND" },
                    { 125, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4122), "SGD" },
                    { 147, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4378), "USD" },
                    { 148, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4386), "UYU" },
                    { 149, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4394), "UZS" },
                    { 150, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4401), "VEF" },
                    { 152, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4416), "VUV" },
                    { 153, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4425), "WST" },
                    { 154, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4472), "XAF" },
                    { 146, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4370), "UGX" },
                    { 155, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4481), "XCD" },
                    { 157, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4497), "XOF" },
                    { 158, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4504), "XPF" },
                    { 159, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4511), "YER" },
                    { 160, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4518), "ZAR" },
                    { 161, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4526), "ZMW" },
                    { 162, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4534), "ZWD" },
                    { 83, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3785), "LKR" },
                    { 156, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4489), "XDR" },
                    { 145, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4363), "UAH" },
                    { 144, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4355), "TZS" },
                    { 143, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4348), "TWD" },
                    { 126, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4208), "SHP" },
                    { 127, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4217), "SLL" },
                    { 128, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4226), "SOS" },
                    { 129, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4234), "SPL" },
                    { 130, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4245), "SRD" },
                    { 131, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4254), "STN" },
                    { 132, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4262), "SVC" },
                    { 133, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4270), "SYP" },
                    { 134, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4277), "SZL" },
                    { 135, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4285), "THB" },
                    { 136, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4293), "TJS" },
                    { 137, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4300), "TMT" },
                    { 138, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4309), "TND" },
                    { 139, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4316), "TOP" },
                    { 140, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4324), "TRY" },
                    { 141, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4332), "TTD" },
                    { 142, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4340), "TVD" },
                    { 124, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(4115), "SEK" },
                    { 82, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3777), "LBP" },
                    { 85, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3800), "LSL" },
                    { 80, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3759), "KZT" },
                    { 22, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3120), "BTN" },
                    { 23, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3127), "BWP" },
                    { 24, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3135), "BYN" },
                    { 25, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3143), "BZD" },
                    { 26, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3151), "CAD" },
                    { 27, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3159), "CDF" },
                    { 28, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3167), "CHF" },
                    { 21, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3111), "BSD" },
                    { 29, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3177), "CLP" },
                    { 31, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3194), "COP" },
                    { 32, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3201), "CRC" },
                    { 33, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3209), "CUC" },
                    { 34, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3221), "CUP" },
                    { 36, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3236), "CZK" },
                    { 37, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3244), "DJF" },
                    { 38, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3251), "DKK" },
                    { 30, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3184), "CNY" },
                    { 20, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3102), "BRL" },
                    { 19, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3093), "BOB" },
                    { 18, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3085), "BND" },
                    { 1, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(2178), "AED" },
                    { 2, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(2933), "AFN" },
                    { 3, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(2949), "ALL" },
                    { 4, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(2958), "AMD" },
                    { 5, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(2968), "ANG" },
                    { 6, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(2984), "AOA" },
                    { 7, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(2993), "ARS" },
                    { 8, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3000), "AUD" },
                    { 9, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3008), "AWG" },
                    { 10, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3018), "AZN" },
                    { 11, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3026), "BAM" },
                    { 12, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3034), "BBD" },
                    { 13, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3043), "BDT" },
                    { 14, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3051), "BGN" },
                    { 15, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3058), "BHD" },
                    { 16, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3066), "BIF" },
                    { 17, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3073), "BMD" },
                    { 39, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3258), "DOP" },
                    { 40, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3266), "DZD" },
                    { 35, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3228), "CVE" },
                    { 42, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3283), "ERN" },
                    { 64, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3624), "INR" },
                    { 65, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3632), "IQD" },
                    { 41, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3275), "EGP" },
                    { 67, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3652), "ISK" },
                    { 68, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3660), "JEP" },
                    { 69, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3668), "JMD" },
                    { 70, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3676), "JOD" },
                    { 71, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3685), "JPY" },
                    { 72, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3693), "KES" },
                    { 73, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3701), "KGS" },
                    { 74, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3709), "KHR" },
                    { 75, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3718), "KMF" },
                    { 76, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3725), "KPW" },
                    { 77, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3734), "KRW" },
                    { 81, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3767), "LAK" },
                    { 78, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3743), "KWD" },
                    { 79, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3751), "KYD" },
                    { 63, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3616), "IMP" },
                    { 62, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3607), "ILS" },
                    { 66, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3644), "IRR" },
                    { 60, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3590), "HUF" },
                    { 43, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3291), "ETB" },
                    { 44, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3299), "EUR" },
                    { 45, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3306), "FJD" },
                    { 61, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3599), "IDR" },
                    { 47, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3323), "GBP" },
                    { 48, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3331), "GEL" },
                    { 49, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3339), "GGP" },
                    { 50, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3347), "GHS" },
                    { 46, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3315), "FKP" },
                    { 52, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3363), "GMD" },
                    { 53, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3371), "GNF" },
                    { 54, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3379), "GTQ" },
                    { 55, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3387), "GYD" },
                    { 56, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3395), "HKD" },
                    { 57, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3563), "HNL" },
                    { 58, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3574), "HRK" },
                    { 59, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3582), "HTG" },
                    { 51, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 532, DateTimeKind.Local).AddTicks(3355), "GIP" }
                });

            migrationBuilder.InsertData(
                table: "DeductionTypes",
                columns: new[] { "DeductionTypeID", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 610, DateTimeKind.Local).AddTicks(3078), "Product" },
                    { 3, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 610, DateTimeKind.Local).AddTicks(3775), "Do Not Deduct" },
                    { 2, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 610, DateTimeKind.Local).AddTicks(3751), "Individual" }
                });

            migrationBuilder.InsertData(
                table: "DocumentFormats",
                columns: new[] { "DocumentFormatID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 6, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 559, DateTimeKind.Local).AddTicks(6498), "ppt" },
                    { 5, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 559, DateTimeKind.Local).AddTicks(6482), "rtf" },
                    { 4, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 559, DateTimeKind.Local).AddTicks(6473), "txt" },
                    { 3, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 559, DateTimeKind.Local).AddTicks(6462), "xlsx" },
                    { 2, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 559, DateTimeKind.Local).AddTicks(6438), "doc" },
                    { 1, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 559, DateTimeKind.Local).AddTicks(5842), "pdf" }
                });

            migrationBuilder.InsertData(
                table: "EmailTypes",
                columns: new[] { "EmailTypeID", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 572, DateTimeKind.Local).AddTicks(8356), "Client Statement" },
                    { 3, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 572, DateTimeKind.Local).AddTicks(8876), "Invoice" },
                    { 2, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 572, DateTimeKind.Local).AddTicks(8859), "Proof Of Payment" },
                    { 4, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 572, DateTimeKind.Local).AddTicks(8886), "New User Account Created" }
                });

            migrationBuilder.InsertData(
                table: "FeatureFlags",
                columns: new[] { "FeatureFlagID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 556, DateTimeKind.Local).AddTicks(7556), "Send Email On Error" },
                    { 3, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 556, DateTimeKind.Local).AddTicks(8143), "Enable Document Emailing Functionality" },
                    { 2, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 556, DateTimeKind.Local).AddTicks(8117), "CC Client On Error" }
                });

            migrationBuilder.InsertData(
                table: "Frequencies",
                columns: new[] { "FrequencyID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 2, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 535, DateTimeKind.Local).AddTicks(4298), "Monthly" },
                    { 1, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 535, DateTimeKind.Local).AddTicks(3783), "Once Off" }
                });

            migrationBuilder.InsertData(
                table: "FundSources",
                columns: new[] { "FundSourceID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 3, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 616, DateTimeKind.Local).AddTicks(4693), "Not Specified" },
                    { 1, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 616, DateTimeKind.Local).AddTicks(3929), "Bank" },
                    { 2, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 616, DateTimeKind.Local).AddTicks(4656), "Cash" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 544, DateTimeKind.Local).AddTicks(4160), "Female" },
                    { 2, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 544, DateTimeKind.Local).AddTicks(4324), "Male" }
                });

            migrationBuilder.InsertData(
                table: "InvoiceStatuses",
                columns: new[] { "InvoiceStatusID", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 2, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 600, DateTimeKind.Local).AddTicks(4889), "Processed" },
                    { 4, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 600, DateTimeKind.Local).AddTicks(4915), "Unknown" },
                    { 1, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 600, DateTimeKind.Local).AddTicks(4334), "Created" },
                    { 3, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 600, DateTimeKind.Local).AddTicks(4906), "Finalised" }
                });

            migrationBuilder.InsertData(
                table: "Layouts",
                columns: new[] { "LayoutID", "DisplayName", "LastChangedBy", "LastChangedDate" },
                values: new object[,]
                {
                    { 1, "Client", "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 603, DateTimeKind.Local).AddTicks(3632) },
                    { 2, "Products", "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 603, DateTimeKind.Local).AddTicks(4185) },
                    { 3, "Khonapo Fund", "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 603, DateTimeKind.Local).AddTicks(4218) },
                    { 5, "Settings", "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 603, DateTimeKind.Local).AddTicks(4241) },
                    { 6, "Reporting", "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 603, DateTimeKind.Local).AddTicks(4259) },
                    { 4, "Developer Menu", "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 603, DateTimeKind.Local).AddTicks(4230) },
                    { 7, "Employees", "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 603, DateTimeKind.Local).AddTicks(4270) },
                    { 8, "Employers", "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 603, DateTimeKind.Local).AddTicks(4279) }
                });

            migrationBuilder.InsertData(
                table: "MenuGroups",
                columns: new[] { "MenuGroupID", "ActionName", "CSSClass", "ControllerName", "DisplayName", "IsActive", "IsActiveMenu", "LastChangedBy", "LastChangedDate", "OrderNo" },
                values: new object[,]
                {
                    { 2, null, "fa fa-users", null, "Clients", true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 565, DateTimeKind.Local).AddTicks(2263), 2 },
                    { 3, null, "fa fa-money", null, "Transactions", true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 565, DateTimeKind.Local).AddTicks(2285), 3 },
                    { 4, null, "fa fa-area-chart", null, "Reporting", true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 565, DateTimeKind.Local).AddTicks(2299), 6 },
                    { 5, null, "fa fa-wrench", null, "Settings", true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 565, DateTimeKind.Local).AddTicks(2310), 7 },
                    { 8, null, "fa fa-line-chart", null, "Loans", true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 565, DateTimeKind.Local).AddTicks(2341), 5 },
                    { 9998, null, "fa fa-university", null, "Menu", true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 565, DateTimeKind.Local).AddTicks(2354), 9998 },
                    { 1, "Dashboard", "fa fa-umbrella", "Home", "DashBoard", true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 565, DateTimeKind.Local).AddTicks(1967), 1 },
                    { 999, null, "fa fa-desktop", null, "Developer Menu", true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 565, DateTimeKind.Local).AddTicks(2371), 9999 },
                    { 6, null, "fa fa-bullseye", null, "Invoicing", true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 565, DateTimeKind.Local).AddTicks(2391), 4 },
                    { 7, null, "fa fa-graduation-cap", null, "Products", true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 565, DateTimeKind.Local).AddTicks(2329), 8 }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "PaymentStatusID", "Description", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 2, null, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 522, DateTimeKind.Local).AddTicks(7884), "Reversed" },
                    { 5, null, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 522, DateTimeKind.Local).AddTicks(7935), "Discounted" },
                    { 4, null, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 522, DateTimeKind.Local).AddTicks(7924), "Refunded" },
                    { 1, null, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 522, DateTimeKind.Local).AddTicks(7264), "Paid" },
                    { 3, null, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 522, DateTimeKind.Local).AddTicks(7914), "Pending" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "Description", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 87, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5651), "View Notice" },
                    { 88, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5662), "Update Country" },
                    { 89, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5672), "Update Currency" },
                    { 90, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5684), "View Dashboard Notices" },
                    { 91, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5695), "Client Update Personal Details" },
                    { 92, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5706), "Update Transaction Type" },
                    { 94, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5728), "Add Product Fee" },
                    { 101, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5805), "Add Assert" },
                    { 100, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5794), "View Product Assert" },
                    { 99, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5784), "Update Product Assert" },
                    { 98, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5772), "Add Product Assert" },
                    { 93, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5717), "View Transaction Type" },
                    { 97, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5761), "View Product Fee" },
                    { 96, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5750), "Delete Product Fee" },
                    { 95, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5739), "Update Product Fee" },
                    { 86, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5641), "Delete Notice" },
                    { 85, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5631), "Update Notice" },
                    { 132, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(6188), "View Fund" },
                    { 83, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5610), "View Email Template" },
                    { 69, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5408), "Update Document Type" },
                    { 70, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5418), "Delete Document Type" },
                    { 71, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5430), "View Document Type" },
                    { 72, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5440), "Add Company" },
                    { 73, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5450), "Update Company" },
                    { 74, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5508), "Delete Company" },
                    { 75, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5521), "View Company" },
                    { 76, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5533), "Add Bank Account" },
                    { 102, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5814), "Update Assert" },
                    { 77, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5544), "Update Bank Account" },
                    { 78, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5555), "Delete Bank Account" },
                    { 79, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5566), "View Bank Account" },
                    { 80, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5578), "Add Email Template" },
                    { 81, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5589), "Update Email Template" },
                    { 82, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5599), "Delete Email Template" },
                    { 84, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5621), "Add Notice" },
                    { 103, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5824), "Delete Assert" },
                    { 121, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(6067), "Add Loan Type" },
                    { 105, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5845), "View Invoice Details" },
                    { 124, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(6100), "View Loan Type" },
                    { 125, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(6111), "Add Loan Status" },
                    { 126, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(6122), "Update Loan Status" },
                    { 127, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(6131), "Delete Loan Status" },
                    { 128, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(6142), "View Loan Status" },
                    { 129, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(6153), "Add Fund" },
                    { 130, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(6166), "Update Fund" },
                    { 68, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5396), "Add Document Type" },
                    { 139, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(6263), "Delete Konapo Fund" },
                    { 138, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(6252), "Update Konapo Fund" },
                    { 137, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(6241), "Add Konapo Fund" },
                    { 136, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(6231), "View Fund Item" },
                    { 135, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(6220), "Delete Fund Item" },
                    { 134, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(6210), "Update Fund Item" },
                    { 133, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(6199), "Add Fund Item" },
                    { 123, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(6089), "Delete Loan Type" },
                    { 104, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5834), "View Assert" },
                    { 122, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(6079), "Update Loan Type" },
                    { 120, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(6055), "View Loan Use" },
                    { 106, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5859), "Print Statement With No Reversals" },
                    { 140, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(6274), "View Konapo Fund" },
                    { 107, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5870), "Auto Generate Receipt" },
                    { 108, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5882), "Email Receipt To Client" },
                    { 109, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5894), "Add Maintanance Notification" },
                    { 110, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5904), "View Country" },
                    { 111, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5915), "View Currency" },
                    { 112, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5925), "View Feature Flag" },
                    { 113, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5936), "View Layouts" },
                    { 114, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5945), "View Licences" },
                    { 115, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5956), "View Maintanances" },
                    { 116, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5968), "View Technical Support Settings" },
                    { 117, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5979), "Add Loan Use" },
                    { 118, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5990), "Update Loan Use" },
                    { 119, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(6001), "Delete Loan Use" },
                    { 131, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(6177), "Delete Fund" },
                    { 67, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5384), "View Custom Setting" },
                    { 25, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4873), "Delete Client Dependent" },
                    { 65, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5358), "View Menu" },
                    { 30, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4923), "Client View Document" },
                    { 29, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4914), "Client Upload Document" },
                    { 28, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4903), "Generate Client Statement" },
                    { 27, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4894), "View Client Payments" },
                    { 26, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4883), "View Client Dependent" },
                    { 24, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4864), "Update Client Dependent" },
                    { 23, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4852), "Add Client Dependent" },
                    { 22, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4841), "View Client Loan" },
                    { 21, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4830), "Delete Client Loan" },
                    { 20, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4820), "Update Client Loan" },
                    { 19, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4810), "Add Client Loan" },
                    { 18, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4799), "View Client Contact" },
                    { 17, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4783), "Delete Client Contact" },
                    { 16, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4773), "Update Client Contact" },
                    { 15, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4761), "Add Client Contact" },
                    { 14, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4750), "View Client Note" },
                    { 13, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4739), "Delete Client Note" },
                    { 12, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4729), "Update Client Note" },
                    { 11, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4719), "Add Client Note" },
                    { 10, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4707), "Change Client Password" },
                    { 9, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4693), "View Client" },
                    { 8, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4682), "Delete Client" },
                    { 7, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4671), "Update Client" },
                    { 6, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4658), "Add Client" },
                    { 5, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4639), "Change User Password" },
                    { 4, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4625), "View User" },
                    { 66, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5375), "Update Custom Setting" },
                    { 2, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4591), "Update User" },
                    { 1, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(3977), "Add User" },
                    { 31, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4932), "Add Role" },
                    { 32, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4941), "Update Role" },
                    { 3, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4613), "Delete User" },
                    { 34, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5041), "View Role" },
                    { 33, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(4950), "Delete Role" },
                    { 64, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5348), "Delete Menu" },
                    { 63, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5338), "Deactivate Menu" },
                    { 62, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5327), "Activate Menu" },
                    { 61, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5316), "Update Menu" },
                    { 60, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5307), "Add Menu" },
                    { 59, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5297), "Process Invoice" },
                    { 58, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5288), "Finalise Invoice" },
                    { 57, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5277), "Delete Invoice" },
                    { 56, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5266), "View Invoice" },
                    { 55, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5257), "Override Payment" },
                    { 54, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5247), "View Client Deductions" },
                    { 53, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5237), "Remove Invoice Entries" },
                    { 51, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5216), "View Client Outstanding Payments" },
                    { 50, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5205), "View Payment" },
                    { 52, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5227), "Generate Invoices" },
                    { 48, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5185), "Capture Payment" },
                    { 35, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5054), "Add Permissions" },
                    { 36, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5065), "Remove Permissions" },
                    { 37, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5075), "View Permissions" },
                    { 38, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5086), "Add Menu To Role" },
                    { 49, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5194), "Reverse Payment" },
                    { 40, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5107), "Add Product" },
                    { 41, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5117), "Update Product" },
                    { 39, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5097), "Remove Menu From Role" },
                    { 43, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5134), "View Product" },
                    { 44, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5144), "Add Department" },
                    { 45, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5154), "Update Department" },
                    { 46, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5165), "Delete Department" },
                    { 47, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5175), "View Department" },
                    { 42, null, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 518, DateTimeKind.Local).AddTicks(5126), "Delete Product" }
                });

            migrationBuilder.InsertData(
                table: "PinCodeTypes",
                columns: new[] { "PinCodeTypeID", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 2, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 619, DateTimeKind.Local).AddTicks(8769), "Multi Factor Authenticator" },
                    { 3, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 619, DateTimeKind.Local).AddTicks(8803), "Account Creation" },
                    { 1, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 619, DateTimeKind.Local).AddTicks(8009), "Password Reset" }
                });

            migrationBuilder.InsertData(
                table: "PriorityRanks",
                columns: new[] { "PriorityRankID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 4, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 551, DateTimeKind.Local).AddTicks(9873), "Low" },
                    { 3, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 551, DateTimeKind.Local).AddTicks(9864), "Medium" },
                    { 2, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 551, DateTimeKind.Local).AddTicks(9843), "High" },
                    { 1, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 551, DateTimeKind.Local).AddTicks(9037), "Critical" }
                });

            migrationBuilder.InsertData(
                table: "RecordStatus",
                columns: new[] { "RecordStatusID", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 593, DateTimeKind.Local).AddTicks(9766), "Active" },
                    { 2, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 594, DateTimeKind.Local).AddTicks(404), "Deleted" },
                    { 3, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 594, DateTimeKind.Local).AddTicks(441), "History" }
                });

            migrationBuilder.InsertData(
                table: "RelationshipTypes",
                columns: new[] { "RelationshipTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 6, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 540, DateTimeKind.Local).AddTicks(3687), "Business Partner" },
                    { 7, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 540, DateTimeKind.Local).AddTicks(3693), "Other" },
                    { 5, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 540, DateTimeKind.Local).AddTicks(3676), "Spouse" },
                    { 1, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 540, DateTimeKind.Local).AddTicks(3443), "Self" },
                    { 2, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 540, DateTimeKind.Local).AddTicks(3653), "Mother" },
                    { 3, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 540, DateTimeKind.Local).AddTicks(3664), "Father" },
                    { 4, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 540, DateTimeKind.Local).AddTicks(3670), "Sibling" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "Description", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 3, null, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 513, DateTimeKind.Local).AddTicks(3321), "Administrator" },
                    { 2, null, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 513, DateTimeKind.Local).AddTicks(3220), "Employee" },
                    { 1, null, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 509, DateTimeKind.Local).AddTicks(209), "Super Admin" }
                });

            migrationBuilder.InsertData(
                table: "StatementLists",
                columns: new[] { "StatementID", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 3, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 586, DateTimeKind.Local).AddTicks(2905), "Outstanding Payments" },
                    { 2, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 586, DateTimeKind.Local).AddTicks(2884), "Transaction List" },
                    { 1, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 585, DateTimeKind.Local).AddTicks(8173), "Product Based Statement" },
                    { 4, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 586, DateTimeKind.Local).AddTicks(2915), "Deductions" }
                });

            migrationBuilder.InsertData(
                table: "TechnicalSupport",
                columns: new[] { "TechnicalSupportID", "LastChangedBy", "LastChangedDate", "Name", "Value" },
                values: new object[,]
                {
                    { 7, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 613, DateTimeKind.Local).AddTicks(3343), "Support Email Address", "" },
                    { 6, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 613, DateTimeKind.Local).AddTicks(3334), "Database Server IP", "" },
                    { 5, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 613, DateTimeKind.Local).AddTicks(3319), "Whatsapp Support Message", "" },
                    { 4, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 613, DateTimeKind.Local).AddTicks(3309), "Website", "" },
                    { 3, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 613, DateTimeKind.Local).AddTicks(3300), "Mobile Number", "" },
                    { 2, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 613, DateTimeKind.Local).AddTicks(3282), "Company Registration Link", "" },
                    { 1, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 613, DateTimeKind.Local).AddTicks(2763), "CompanyName", "" }
                });

            migrationBuilder.InsertData(
                table: "Titles",
                columns: new[] { "TitleID", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 588, DateTimeKind.Local).AddTicks(6416), "Mr" },
                    { 3, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 588, DateTimeKind.Local).AddTicks(6982), "Miss" },
                    { 6, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 588, DateTimeKind.Local).AddTicks(7012), "Prof" },
                    { 5, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 588, DateTimeKind.Local).AddTicks(6998), "Dr" },
                    { 4, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 588, DateTimeKind.Local).AddTicks(6991), "Ms" },
                    { 2, true, false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 588, DateTimeKind.Local).AddTicks(6966), "Mrs" }
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
                    { 3, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 538, DateTimeKind.Local).AddTicks(3564), "Employee" },
                    { 2, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 538, DateTimeKind.Local).AddTicks(3545), "Employer" },
                    { 1, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 538, DateTimeKind.Local).AddTicks(2970), "Administrator" }
                });

            migrationBuilder.InsertData(
                table: "VariableTypes",
                columns: new[] { "CustomVariableTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 543, DateTimeKind.Local).AddTicks(5931), "Boolean" },
                    { 9, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 543, DateTimeKind.Local).AddTicks(6589), "Percentage" },
                    { 8, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 543, DateTimeKind.Local).AddTicks(6581), "Password" },
                    { 7, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 543, DateTimeKind.Local).AddTicks(6572), "Date Time" },
                    { 6, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 543, DateTimeKind.Local).AddTicks(6558), "Decimal" },
                    { 5, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 543, DateTimeKind.Local).AddTicks(6541), "Double" },
                    { 4, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 543, DateTimeKind.Local).AddTicks(6533), "Integer" },
                    { 3, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 543, DateTimeKind.Local).AddTicks(6523), "Long" },
                    { 2, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 543, DateTimeKind.Local).AddTicks(6496), "String" }
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
                    { 3, 1, "Allows system to hide exceptions and show custom error page to user", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4498), "Show Custom Exceptions To Users", "true" },
                    { 31, 2, "Customer Support Number", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(5004), "Site Customer Service Number", "+61411629968" },
                    { 32, 2, "Default Email Addresss that overrides Client Email Address in a Test Environment ", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(5013), "Site Test Email Account", "carochire@gmail.com" },
                    { 41, 2, "Sets the Font Name for PDF Reports Body Section", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(5085), "Report Body Font Name", "Arial" },
                    { 43, 2, "Sets the Font Name for PDF Reports Footer Section", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(5104), "Report Footer Font Name", "Arial" },
                    { 4, 4, "Limit Account Number Size", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4463), "Account Number Length", "9" },
                    { 6, 4, "Port used to Send Emails", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4537), "Mail SMTP Port", "587" },
                    { 26, 4, "Pin Code Length", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4832), "Pin Code Length", "6" },
                    { 27, 4, "Password Reset Pin Code Validity Period in Days", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4845), "Password Reset Pin Validity", "2" },
                    { 30, 2, "Customer Support Email", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4992), "Site Customer Service Email", "welovecoding@elroitec.co.za" },
                    { 33, 4, "Current System Environment Set it to 1 For Test Environment  or 2 for Production Environment if no value has been set System defaults to Test Environment ", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(5023), "Site Default Environment", "1" },
                    { 40, 4, "Default Due date for note if not set by person who created it", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(5076), "Client Notes Default Due Date Interval", "5" },
                    { 42, 4, "Sets the Font Size for PDF Reports Body Section", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(5095), "Report Body Font Size", "9" },
                    { 44, 4, "Sets the Font Size for PDF Reports Footer Section", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(5113), "Report Footer Font Size", "8" },
                    { 46, 4, "Passcode Validity Period in Minutes", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(5133), "Pass Code Validity Period", "60" },
                    { 14, 6, "Maximum file size that can be uploaded to the System", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4725), "File Maximum UpLoadable Size", "5" },
                    { 5, 7, "Format Used to display date", false, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4510), "Date Format", "yyyy-MMM-dd" },
                    { 39, 7, "Format Used to display date time", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4525), "Date Time Format", "yyyy-MMM-dd HH:mm" },
                    { 11, 8, "Email Password", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4687), "Mail Credential Password", "ZGNvaXpoeGlxenZ3dnphaw==" },
                    { 36, 4, "Password Validity Period in Days", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(5045), "Password Validity Period", "30" },
                    { 28, 2, "Site URL", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4855), "Site URL", "http://smartloan.elroitec.com/" },
                    { 13, 9, "Percentage To Which VAT is calculated on ", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4712), "VAT Percentage", "0.14" },
                    { 24, 2, "Password Used to Open Password Protected Statement By System Administrators", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4787), "Statement Password For Admin", "123456" },
                    { 22, 2, "Default Email Subject Name Used By Auto-Generated Emails", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4821), "Mail Default Subject", "Smart Loan  Admin" },
                    { 8, 1, "Enable SSL", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4562), "Mail Enable SSL", "true" },
                    { 9, 1, "Use Default Mail Credentials", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4576), "Mail Use Default Credentials", "false" },
                    { 20, 1, "Instructs the System to Advise User to Capture VAT inclusive amounts and calculate breakdown accordingly", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4773), "Capture VAT Inclusive Payments", "true" },
                    { 23, 1, "Allows to password protect statements being sent by Email", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4798), "Statement Password Protect", "true" },
                    { 25, 1, "Determines if table borders will be shown on the report ", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4811), "Statement Show Table Boarders", "true" },
                    { 34, 1, "Display menus based on User Role", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(5032), "Application Role Based Menus", "false" },
                    { 37, 1, "Auto Generate Account Numbers", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(5055), "Account Number Auto Generate", "true" },
                    { 45, 1, "Increases System Security by Allowing Users to Authenticate Themselves Twice", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(5124), "Allow Two Factor Authentication", "true" },
                    { 38, 1, "Allows System To Be VAT Compliant and Show calculated VAT Amounts ", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(5065), "Application Is VAT Compliant", "false" },
                    { 16, 2, "Short Name for Application", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4431), "Application Name Prefix", "SL" },
                    { 2, 2, "Displays Current Version of the System", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4449), "System Version", "1.0.0.0" },
                    { 15, 2, "Account Number Prefix if Any", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4474), "Account Number Prefix", "SL" },
                    { 7, 2, "Host used to Send Emails", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4550), "Mail SMTP Host", "smtp.gmail.com" },
                    { 10, 2, "Email Address used to email", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4594), "Mail Credential User Name", "carolinesolutions89@gmail.com" },
                    { 12, 2, "Display Sender Name As", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4701), "Mail Display Name", "Smart Admin" },
                    { 17, 2, "First Line on the Report Footer", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4740), "Report Footer 1", "W. Guri Mrs. (Chairman), *E. Guri (Managing)" },
                    { 18, 2, "Additional Line on the Report Footer (can be blank)", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4752), "Report Footer 2", "*Executive." },
                    { 19, 2, "Foot notes that you would like to include on your statement (not mandatory)", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4763), "Report FootNotes", "" },
                    { 1, 2, "Displayed as the Application Name", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 579, DateTimeKind.Local).AddTicks(4078), "Application Name", "Smart Loans" }
                });

            migrationBuilder.InsertData(
                table: "DocumentTypes",
                columns: new[] { "DocumentTypeID", "DocumentFormatID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 3, 1, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 562, DateTimeKind.Local).AddTicks(5477), "Proof Of Address" },
                    { 1, 1, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 562, DateTimeKind.Local).AddTicks(4418), "Identity Document" },
                    { 2, 1, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 562, DateTimeKind.Local).AddTicks(5429), "Birth Certificate" },
                    { 4, 1, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 562, DateTimeKind.Local).AddTicks(5489), "Payslips" }
                });

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "EmailTemplateID", "Body", "EmailTypeID", "LastChangedBy", "LastChangedDate", "PriorityRankID", "Subject" },
                values: new object[] { 1, @"Dear Customer, 

                        Attached is your Account statement. To view it you will need to open the PDF attachment and insert your password. Your password is your ID number. To view your statement you need to have Adobe PDF Reader installed. If you do not have it, you will need to do the following: - Copy and paste this URL into your browser: www.get.adobe.com/reader/?promoid=BUIGO - Go to the website - Click the download button and follow the easy instructions.


                        Regards,

                        Smart Saver", 1, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 573, DateTimeKind.Local).AddTicks(3577), 2, "Account Statement" });

            migrationBuilder.InsertData(
                table: "LayoutMenus",
                columns: new[] { "LayoutMenuID", "ActionName", "CSSClass", "ControllerName", "DisplayName", "IsActive", "LastChangedBy", "LastChangedDate", "LayoutID", "LinkRequiresID", "OrderNo" },
                values: new object[,]
                {
                    { 29, "MyAccount", "fa fa-heart", "Client", "My Account", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(6090), 7, true, 29 },
                    { 32, "LoanStatus", "fa fa-lightbulb-o", "LoanStatus", "Loan Status", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(6112), 5, true, 32 },
                    { 31, "LoanType", "fa fa-lightbulb-o", "LoanType", "Loan Types", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(6105), 5, true, 31 },
                    { 28, "Country", "fa fa-globe", "Country", "Country", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(6084), 5, true, 28 },
                    { 27, "Currency", "fa fa-money", "Currency", "Currency", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(6077), 5, true, 27 },
                    { 19, "Companies", "fa fa-building", "Company", "Companies", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(6019), 5, true, 19 },
                    { 26, "DocumentTypes", "fa fa-file", "DocumentType", "Document Types", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(6070), 5, true, 26 },
                    { 25, "Department", "fa fa-building", "Department", "Departments", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(6063), 5, true, 25 },
                    { 24, "EmailTemplate", "fa fa-envelope-o", "EmailTemplate", "Email Templates", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(6056), 5, true, 24 },
                    { 23, "NoticeBoard", "fa fa-bell", "NoticeBoard", "Notice Board", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(6049), 5, true, 23 },
                    { 22, "BankAccounts", "fa fa-university", "BankAccounts", "Banks", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(6042), 5, true, 22 },
                    { 21, "LoanUse", "fa fa-lightbulb-o", "LoanUse", "Loan Uses", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(6034), 5, true, 21 },
                    { 20, "TransactionType", "fa fa-money", "TransactionType", "Transaction Types", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(6027), 5, true, 20 },
                    { 30, "Clients", "fa fa-users", "Client", "Employees", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(6097), 8, true, 30 },
                    { 18, "Roles", "fa fa-asterisk", "Roles", "Roles & Permissions", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(6012), 5, true, 18 },
                    { 7, "Dependents", "fa fa-child", "Client", "Dependents", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(5609), 1, true, 7 },
                    { 16, "CustomSettings", "fa fa-spinner", "CustomSettings", "Application Settings", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(5992), 5, true, 16 },
                    { 1, "Loans", "fa fa-bomb", "Client", "Loans", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(5284), 1, true, 1 },
                    { 2, "PaidTransactions", "fa fa-cc-mastercard", "Client", "Payments File", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(5560), 1, true, 2 },
                    { 3, "PendingTransactions", "fa fa-credit-card", "Client", "Outstanding Payments", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(5572), 1, true, 3 },
                    { 4, "Statements", "fa fa-file", "Client", "Statements", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(5580), 1, true, 4 },
                    { 17, "Users", "fa fa-users", "User", "User Management", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(6002), 5, true, 17 },
                    { 6, "Documents", "fa fa-book", "Client", "Documents", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(5601), 1, true, 6 },
                    { 8, "Contacts", "glyphicon glyphicon-envelope", "Client", "Contacts", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(5617), 1, true, 8 },
                    { 5, "Notes", "fa fa-comments", "Client", "Notes", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(5587), 1, true, 5 },
                    { 10, "FundItems", "fa fa-navicon", "FundItem", "Fund Items", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(5917), 3, false, 10 },
                    { 11, "KonapoFunds", "fa fa-line-chart", "KonapoFund", "Konapo Funds", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(5954), 3, false, 0 },
                    { 12, "Support", "fa fa-anchor", "Support", "Support", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(5962), 4, true, 12 },
                    { 13, "Licence", "fa  fa-key", "Licence", "Licence", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(5969), 4, true, 13 },
                    { 14, "Maintanance", "fa fa-wrench", "Maintanance", "Maintanance", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(5977), 4, true, 14 },
                    { 15, "FeatureFlag", "fa fa-building", "FeatureFlag", "Feature Flags", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(5985), 4, true, 15 },
                    { 9, "Fund", "fa fa-calculator", "Fund", "Fund Set Up", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 607, DateTimeKind.Local).AddTicks(5624), 3, false, 9 }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuID", "ActionName", "CSSClass", "ControllerName", "DisplayName", "IsActive", "LastChangedBy", "LastChangedDate", "MenuGroupID", "OrderNo" },
                values: new object[,]
                {
                    { 9995, "Layouts", "fa fa-bars", "Layouts", "Layout", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 566, DateTimeKind.Local).AddTicks(9318), 9998, 9995 },
                    { 5, "Invoices", "fa fa-gear", "Transactions", "Invoices", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 566, DateTimeKind.Local).AddTicks(9262), 6, 5 },
                    { 9994, "Dashboard", "fa fa-desktop", "FeatureFlag", "Technical Menu", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 566, DateTimeKind.Local).AddTicks(9305), 999, 9994 },
                    { 9996, "MainMenu", "fa fa-book", "Menus", "Main Menu", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 566, DateTimeKind.Local).AddTicks(9328), 9998, 9996 },
                    { 3, "KonapoFunds", "fa fa-calculator", "KonapoFund", "Loans", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 566, DateTimeKind.Local).AddTicks(9243), 8, 3 },
                    { 2, "MyAccount", "fa fa-heart", "Client", "My Account", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 566, DateTimeKind.Local).AddTicks(9230), 2, 0 },
                    { 9, "Dashboard", "fa fa-gear", "CustomSettings", "Parameters", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 566, DateTimeKind.Local).AddTicks(9295), 5, 9 },
                    { 8, "DashBoard", "fas fa-registered", "Reporting", "Reports", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 566, DateTimeKind.Local).AddTicks(9286), 4, 8 },
                    { 4, "Transactions", "fa fa-money", "Transactions", "Transactions", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 566, DateTimeKind.Local).AddTicks(9253), 3, 4 },
                    { 1, "Clients", "fa fa-users", "Client", "Clients", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 566, DateTimeKind.Local).AddTicks(8987), 2, 1 },
                    { 6, "Product", "fa fa-bomb", "Product", "Products", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 566, DateTimeKind.Local).AddTicks(9276), 7, 6 }
                });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "RolePermissionID", "LastChangedBy", "LastChangedDate", "PermissionID", "RoleID" },
                values: new object[,]
                {
                    { 91, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6792), 91, 1 },
                    { 92, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6798), 92, 1 },
                    { 93, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6805), 93, 1 },
                    { 94, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6812), 94, 1 },
                    { 95, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6819), 95, 1 },
                    { 96, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6825), 96, 1 },
                    { 97, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6830), 97, 1 },
                    { 99, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6844), 99, 1 },
                    { 100, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6850), 100, 1 },
                    { 101, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6858), 101, 1 },
                    { 102, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6865), 102, 1 },
                    { 103, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6872), 103, 1 },
                    { 104, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6878), 104, 1 },
                    { 105, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6884), 105, 1 },
                    { 98, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6836), 98, 1 },
                    { 90, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6785), 90, 1 },
                    { 88, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6773), 88, 1 },
                    { 87, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6766), 87, 1 },
                    { 73, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6675), 73, 1 },
                    { 74, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6680), 74, 1 },
                    { 75, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6685), 75, 1 },
                    { 76, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6692), 76, 1 },
                    { 77, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6698), 77, 1 },
                    { 78, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6704), 78, 1 },
                    { 89, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6779), 89, 1 },
                    { 79, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6711), 79, 1 },
                    { 81, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6726), 81, 1 },
                    { 82, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6732), 82, 1 },
                    { 83, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6738), 83, 1 },
                    { 84, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6744), 84, 1 },
                    { 85, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6750), 85, 1 },
                    { 86, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6758), 86, 1 },
                    { 80, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6718), 80, 1 },
                    { 106, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6891), 106, 1 },
                    { 108, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6905), 108, 1 },
                    { 109, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6910), 109, 1 },
                    { 128, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(7041), 128, 1 },
                    { 129, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(7047), 129, 1 },
                    { 130, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(7109), 130, 1 },
                    { 131, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(7117), 131, 1 },
                    { 132, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(7124), 132, 1 },
                    { 133, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(7131), 133, 1 },
                    { 127, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(7035), 127, 1 },
                    { 134, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(7138), 134, 1 },
                    { 136, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(7152), 136, 1 },
                    { 137, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(7160), 137, 1 },
                    { 138, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(7166), 138, 1 },
                    { 139, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(7174), 139, 1 },
                    { 140, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(7179), 140, 1 },
                    { 72, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6667), 72, 1 },
                    { 135, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(7146), 135, 1 },
                    { 107, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6898), 107, 1 },
                    { 126, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(7027), 126, 1 },
                    { 124, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(7015), 124, 1 },
                    { 110, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6918), 110, 1 },
                    { 111, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6925), 111, 1 },
                    { 112, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6933), 112, 1 },
                    { 113, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6939), 113, 1 },
                    { 114, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6945), 114, 1 },
                    { 115, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6952), 115, 1 },
                    { 125, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(7022), 125, 1 },
                    { 116, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6959), 116, 1 },
                    { 118, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6974), 118, 1 },
                    { 119, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6980), 119, 1 },
                    { 120, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6987), 120, 1 },
                    { 121, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6993), 121, 1 },
                    { 122, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(7000), 122, 1 },
                    { 123, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(7008), 123, 1 },
                    { 117, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6966), 117, 1 },
                    { 71, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6660), 71, 1 },
                    { 30, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6334), 30, 1 },
                    { 69, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6647), 69, 1 },
                    { 32, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6345), 32, 1 },
                    { 70, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6653), 70, 1 },
                    { 29, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6328), 29, 1 },
                    { 28, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6321), 28, 1 },
                    { 27, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6315), 27, 1 },
                    { 26, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6308), 26, 1 },
                    { 25, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6301), 25, 1 },
                    { 24, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6295), 24, 1 },
                    { 23, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6289), 23, 1 },
                    { 22, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6284), 22, 1 },
                    { 21, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6277), 21, 1 },
                    { 20, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6246), 20, 1 },
                    { 19, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6240), 19, 1 },
                    { 18, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6232), 18, 1 },
                    { 17, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6223), 17, 1 },
                    { 16, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6217), 16, 1 },
                    { 15, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6212), 15, 1 },
                    { 1, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(5920), 1, 1 },
                    { 2, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6115), 2, 1 },
                    { 3, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6125), 3, 1 },
                    { 4, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6129), 4, 1 },
                    { 5, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6136), 5, 1 },
                    { 6, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6148), 6, 1 },
                    { 33, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6352), 33, 1 },
                    { 7, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6157), 7, 1 },
                    { 9, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6169), 9, 1 },
                    { 10, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6178), 10, 1 },
                    { 11, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6186), 11, 1 },
                    { 12, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6193), 12, 1 },
                    { 13, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6200), 13, 1 },
                    { 14, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6207), 14, 1 },
                    { 8, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6162), 8, 1 },
                    { 34, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6410), 34, 1 },
                    { 31, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6340), 31, 1 },
                    { 36, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6424), 36, 1 },
                    { 35, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6418), 35, 1 },
                    { 56, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6557), 56, 1 },
                    { 57, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6564), 57, 1 },
                    { 58, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6571), 58, 1 },
                    { 59, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6578), 59, 1 },
                    { 60, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6583), 60, 1 },
                    { 54, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6545), 54, 1 },
                    { 61, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6590), 61, 1 },
                    { 63, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6603), 63, 1 },
                    { 64, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6610), 64, 1 },
                    { 65, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6617), 65, 1 },
                    { 66, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6628), 66, 1 },
                    { 67, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6634), 67, 1 },
                    { 68, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6641), 68, 1 },
                    { 62, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6596), 62, 1 },
                    { 53, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6538), 53, 1 },
                    { 55, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6550), 55, 1 },
                    { 51, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6526), 51, 1 },
                    { 37, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6430), 37, 1 },
                    { 38, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6438), 38, 1 },
                    { 39, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6446), 39, 1 },
                    { 52, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6531), 52, 1 },
                    { 41, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6460), 41, 1 },
                    { 42, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6468), 42, 1 },
                    { 43, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6474), 43, 1 },
                    { 40, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6453), 40, 1 },
                    { 45, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6487), 45, 1 },
                    { 46, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6492), 46, 1 },
                    { 47, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6500), 47, 1 },
                    { 48, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6507), 48, 1 },
                    { 49, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6513), 49, 1 },
                    { 50, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6518), 50, 1 },
                    { 44, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 519, DateTimeKind.Local).AddTicks(6480), 44, 1 }
                });

            migrationBuilder.InsertData(
                table: "TransactionType",
                columns: new[] { "TransactionTypeID", "Code", "Description", "IsActive", "LastChangedBy", "LastChangedDate", "Name", "TransactionStatusID" },
                values: new object[,]
                {
                    { 7, "DEP", null, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 526, DateTimeKind.Local).AddTicks(4351), "Deposit", 1 },
                    { 1, "PAY", null, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 526, DateTimeKind.Local).AddTicks(2332), "Payment", 1 },
                    { 2, "(R)", null, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 526, DateTimeKind.Local).AddTicks(3534), "Reversal", 1 },
                    { 3, "PURCH", null, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 526, DateTimeKind.Local).AddTicks(3679), "Purchase", 1 },
                    { 4, "SALE", null, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 526, DateTimeKind.Local).AddTicks(3818), "Sales", 1 },
                    { 5, "RPT", null, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 526, DateTimeKind.Local).AddTicks(3938), "Receipts", 1 },
                    { 6, "RECON", null, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 526, DateTimeKind.Local).AddTicks(4160), "Recon", 1 },
                    { 8, "FEE", null, true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 526, DateTimeKind.Local).AddTicks(4448), "Fee", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "CanOverrideMaintananceMode", "CompanyID", "EmailAddress", "FirstName", "GrantAccessToTestEnvironment", "IDNumber", "IsActive", "LastChangedBy", "LastChangedDate", "LastName", "Password", "PasswordExpiryDate", "ProfileImage", "UserTypeID" },
                values: new object[,]
                {
                    { 2, false, null, "carochire89@gmail.com", "Elroitec", false, "201703232441609", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 553, DateTimeKind.Local).AddTicks(9425), "Employer", "YWRtaW4=", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2 },
                    { 1, true, null, "carochire@gmail.com", "Wadzanai Caroline", true, "8904161200188", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 553, DateTimeKind.Local).AddTicks(2367), "Chirenje", "YWRtaW4=", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1 },
                    { 3, false, null, "carolinesolutions89@gmail.com", "Elroitec", false, "20200716041609", true, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 553, DateTimeKind.Local).AddTicks(9705), "Employee", "YWRtaW4=", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3 }
                });

            migrationBuilder.InsertData(
                table: "RoleMenus",
                columns: new[] { "RoleMenuID", "LastChangedBy", "LastChangedDate", "MenuID", "RoleID" },
                values: new object[,]
                {
                    { 1, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 580, DateTimeKind.Local).AddTicks(2218), 1, 1 },
                    { 2, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 580, DateTimeKind.Local).AddTicks(2358), 2, 1 },
                    { 4, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 580, DateTimeKind.Local).AddTicks(2376), 4, 1 },
                    { 7, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 580, DateTimeKind.Local).AddTicks(2402), 8, 1 },
                    { 8, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 580, DateTimeKind.Local).AddTicks(2410), 9, 1 },
                    { 6, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 580, DateTimeKind.Local).AddTicks(2394), 6, 1 },
                    { 3, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 580, DateTimeKind.Local).AddTicks(2370), 3, 1 },
                    { 10, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 580, DateTimeKind.Local).AddTicks(2427), 9995, 1 },
                    { 11, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 580, DateTimeKind.Local).AddTicks(2434), 9996, 1 },
                    { 9, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 580, DateTimeKind.Local).AddTicks(2417), 9994, 1 },
                    { 5, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 580, DateTimeKind.Local).AddTicks(2382), 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserID", "RoleID", "LastChangedBy", "LastChangedDate", "UserRoleID" },
                values: new object[,]
                {
                    { 1, 1, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 563, DateTimeKind.Local).AddTicks(257), 1 },
                    { 2, 3, "SuperUser", new DateTime(2022, 4, 7, 20, 55, 5, 563, DateTimeKind.Local).AddTicks(384), 2 }
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
                name: "IX_FundCategories_FundID",
                table: "FundCategories",
                column: "FundID");

            migrationBuilder.CreateIndex(
                name: "IX_FundCategoryItems_FundCategoryID",
                table: "FundCategoryItems",
                column: "FundCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_FundCategoryItems_FundItemID",
                table: "FundCategoryItems",
                column: "FundItemID");

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
                name: "IX_KonapoFundCTIs_FundCategoryItemID",
                table: "KonapoFundCTIs",
                column: "FundCategoryItemID");

            migrationBuilder.CreateIndex(
                name: "IX_KonapoFundCTIs_FundSourceID",
                table: "KonapoFundCTIs",
                column: "FundSourceID");

            migrationBuilder.CreateIndex(
                name: "IX_KonapoFundCTIs_KonapoFundCTID",
                table: "KonapoFundCTIs",
                column: "KonapoFundCTID");

            migrationBuilder.CreateIndex(
                name: "IX_KonapoFundCTIs_KonapoFundCTID1",
                table: "KonapoFundCTIs",
                column: "KonapoFundCTID1");

            migrationBuilder.CreateIndex(
                name: "IX_KonapoFundCTs_FundCategoryID",
                table: "KonapoFundCTs",
                column: "FundCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_KonapoFundCTs_KonapoFundID",
                table: "KonapoFundCTs",
                column: "KonapoFundID");

            migrationBuilder.CreateIndex(
                name: "IX_KonapoFundCTs_KonapoFundID1",
                table: "KonapoFundCTs",
                column: "KonapoFundID1");

            migrationBuilder.CreateIndex(
                name: "IX_KonapoFundReports_KonapoFundID",
                table: "KonapoFundReports",
                column: "KonapoFundID");

            migrationBuilder.CreateIndex(
                name: "IX_KonapoFunds_ClientID",
                table: "KonapoFunds",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_KonapoFunds_FundID",
                table: "KonapoFunds",
                column: "FundID");

            migrationBuilder.CreateIndex(
                name: "IX_LayoutMenus_LayoutID",
                table: "LayoutMenus",
                column: "LayoutID");

            migrationBuilder.CreateIndex(
                name: "IX_LoanBeneficiaries_LoanID",
                table: "LoanBeneficiaries",
                column: "LoanID");

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
                name: "IX_Loans_ClientID",
                table: "Loans",
                column: "ClientID");

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
                name: "KonapoFundCTIHistories");

            migrationBuilder.DropTable(
                name: "KonapoFundCTIs");

            migrationBuilder.DropTable(
                name: "KonapoFundReports");

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
                name: "LoanSchedules");

            migrationBuilder.DropTable(
                name: "LoanSectors");

            migrationBuilder.DropTable(
                name: "LoanStatus");

            migrationBuilder.DropTable(
                name: "LoanTypes");

            migrationBuilder.DropTable(
                name: "LoanUses");

            migrationBuilder.DropTable(
                name: "Maintanances");

            migrationBuilder.DropTable(
                name: "NoticeBoard");

            migrationBuilder.DropTable(
                name: "ProductFeeHistory");

            migrationBuilder.DropTable(
                name: "ProductFees");

            migrationBuilder.DropTable(
                name: "ProductHistory");

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
                name: "FundCategoryItems");

            migrationBuilder.DropTable(
                name: "FundSources");

            migrationBuilder.DropTable(
                name: "KonapoFundCTs");

            migrationBuilder.DropTable(
                name: "Layouts");

            migrationBuilder.DropTable(
                name: "RelationshipTypes");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "PriorityRanks");

            migrationBuilder.DropTable(
                name: "Frequencies");

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
                name: "FundItems");

            migrationBuilder.DropTable(
                name: "FundCategories");

            migrationBuilder.DropTable(
                name: "KonapoFunds");

            migrationBuilder.DropTable(
                name: "DocumentFormats");

            migrationBuilder.DropTable(
                name: "MenuGroups");

            migrationBuilder.DropTable(
                name: "BankAccountTypes");

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
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Funds");

            migrationBuilder.DropTable(
                name: "InvoiceStatuses");

            migrationBuilder.DropTable(
                name: "Products");

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
