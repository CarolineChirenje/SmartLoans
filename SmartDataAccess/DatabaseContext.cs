using Microsoft.EntityFrameworkCore;
using SmartDomain;
using SmartHelper;

namespace SmartDataAccess
{

    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity(typeof(KonapoFundCT))
                 .HasOne(typeof(KonapoFund), "KonapoFund")
                 .WithMany()
                 .HasForeignKey("KonapoFundID")
                 .OnDelete(DeleteBehavior.NoAction); // no ON DELETE

            modelBuilder.Entity(typeof(KonapoFundCTI))
                 .HasOne(typeof(KonapoFundCT), "KonapoFundCT")
                 .WithMany()
                 .HasForeignKey("KonapoFundCTID")
                 .OnDelete(DeleteBehavior.NoAction); // no ON DELETE
            modelBuilder.Entity<UserRole>().HasKey(sc => new { sc.UserID, sc.RoleID });

            //System Roles
            modelBuilder.Entity<Role>().HasData(
                Data.GetRoles());
            // permissions
            modelBuilder.Entity<Permission>().HasData(
            Data.GetPermissions());

            // rolePermissions
            modelBuilder.Entity<RolePermission>().HasData(
          Data.GetPermissionsForSuperUserRole());
            // paymentstatus
            modelBuilder.Entity<PaymentStatus>().HasData(
          Data.GetPaymentStatuses());
            // transaction type
            modelBuilder.Entity<TransactionType>().HasData(
              Data.GetTransactionTypes());

            // bank account types
            modelBuilder.Entity<BankAccountType>().HasData(
             Data.GetBankAccountTypes());

            // currencies
            modelBuilder.Entity<Currency>().HasData(
             Data.GetCurrencies());

            //// product Frequencies
            modelBuilder.Entity<Frequency>().HasData(
                Data.GetFrequencies());
            //   user types
            modelBuilder.Entity<UserType>().HasData(
             Data.GetUserTypes());
            //   contact types
            modelBuilder.Entity<ContactType>().HasData(
           Data.GetContactTypes());

            //   relationship types
            modelBuilder.Entity<RelationshipType>().HasData(
             Data.GetRelationshipTypes());

            //   custom variable types
            modelBuilder.Entity<CustomVariableType>().HasData(
           Data.GetCustomVariableTypes());

            //gender
            modelBuilder.Entity<Gender>().HasData(
                     Data.GetGenders());
            // country
            modelBuilder.Entity<Country>().HasData(
                    Data.GetCountries());
            //   priority
            modelBuilder.Entity<PriorityRank>().HasData(
              Data.GetPriorityRanks());

            //users
            modelBuilder.Entity<User>().HasData(
                     Data.GetUsers());

            // feature flags
            modelBuilder.Entity<FeatureFlag>().HasData(
                  Data.GetFeatureFlags());

            // document format and document types
            modelBuilder.Entity<DocumentFormat>().HasData(
                  Data.GetDocumentFormats());

            modelBuilder.Entity<DocumentType>().HasData(
                  Data.GetDocumentTypes());
            //roles
            modelBuilder.Entity<UserRole>().HasData(Data.GetUserRoles());

            // parentMenu
            modelBuilder.Entity<MenuGroup>().HasData(
            MenuData.GetMenuGroups());

            // Menu
            modelBuilder.Entity<Menu>().HasData(
            MenuData.GetMenus());

            // WeekDays
            modelBuilder.Entity<WeekDay>().HasData(
            Data.GetWeekDays());

            // email types
            modelBuilder.Entity<EmailType>().HasData(
            Data.GetEmailTypes());


            modelBuilder.Entity<EmailTemplate>().HasData(
           Data.GetEmailTemplates());

            //custom settings
            modelBuilder.Entity<SmartDomain.CustomSetting>().HasData(
              Data.GetApplicationSettings());

            modelBuilder.Entity<RoleMenu>().HasData(
           Data.GetRoleMenus());

            modelBuilder.Entity<TransactionStatus>().HasData(
             Data.GetTransactionStatus());

            modelBuilder.Entity<StatementList>().HasData(
         Data.GetStatementList());

            modelBuilder.Entity<Titles>().HasData(
           Data.GetTitles());

            modelBuilder.Entity<ClientAccountType>().HasData(
          Data.GetClientAccountTypes());

            modelBuilder.Entity<RecordStatus>().HasData(
           Data.GetRecordStatuses());

            modelBuilder.Entity<ClientGroup>().HasData(
         Data.GetClientGroups());
            modelBuilder.Entity<InvoiceStatus>().HasData(
          Data.GetInvoiceStatuses());

            modelBuilder.Entity<Layout>().HasData(
            LayoutData.GetLayouts());

            modelBuilder.Entity<LayoutMenu>().HasData(
           LayoutData.GetLayoutMenus());

            modelBuilder.Entity<DeductionType>().HasData(
          Data.GetDeductionTypes());
            modelBuilder.Entity<TechnicalSupport>().HasData(
           Data.GetSupportInformation());
            modelBuilder.Entity<FundSource>().HasData(
          Data.GetFundSources());
            modelBuilder.Entity<PinCodeType>().HasData(
          Data.GetPinCodeTypes());
            //modelBuilder.Entity<UserAuthenticationCode>()
            // .Property(p => p.PinCodeTypeID)
            // .HasDefaultValue((int)CodeType.Password_Reset);


        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAccessGrant> UserAccessGrants { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<RecordStatus> RecordStatus { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<BankAccountType> BankAccountTypes { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<PaymentStatus> PaymentStatus { get; set; }
        public DbSet<TransactionType> TransactionType { get; set; }
        public DbSet<TransactionStatus> TransactionStatus { get; set; }

        public DbSet<Client> Clients { get; set; }
        public DbSet<JointApplicant> JointApplicants { get; set; }
        public DbSet<ClientCourse> ClientCourses { get; set; }
        public DbSet<ClientTranscript> ClientTranscripts { get; set; }
        public DbSet<ClientContact> ClientContacts { get; set; }
        public DbSet<ClientDocument> ClientDocuments { get; set; }
        public DbSet<ClientNote> ClientNotes { get; set; }
        public DbSet<ClientDependent> ClientDependents { get; set; }
        public DbSet<ClientProduct> ClientProducts { get; set; }
        public DbSet<ClientFee> ClientFees { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetails> InvoiceDetails { get; set; }
        public DbSet<ClientOccupationHistory> ClientOccupationHistory { get; set; }
        public DbSet<ClientAccountType> ClientAccountTypes { get; set; }
        public DbSet<ClientGroup> ClientGroups { get; set; }
        public DbSet<UserAuthenticationCode> UserAuthenticationCodes { get; set; }
        public DbSet<PinCodeType> PinCodeTypes { get; set; }
        public DbSet<ClientMedicalDetail> ClientMedicalDetails { get; set; }
        public DbSet<NoticeBoard> NoticeBoard { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductHistory> ProductHistory { get; set; }
        public DbSet<ProductFee> ProductFees { get; set; }
        public DbSet<ProductFeeHistory> ProductFeeHistory { get; set; }
        public DbSet<ProductAssert> ProductAsserts { get; set; }
        public DbSet<AssertCategory> AssertCategories { get; set; }
        public DbSet<Assert> Asserts { get; set; }
        public DbSet<InvoiceStatus> InvoiceStatuses { get; set; }
        public DbSet<DeductionType> DeductionTypes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseTopic> CourseTopics { get; set; }
        public DbSet<CourseSession> CourseSessions { get; set; }
        public DbSet<CourseFee> CourseFees { get; set; }
        public DbSet<CourseFeeHistory> CourseFeeHistory { get; set; }
        public DbSet<CourseIntake> CourseIntakes { get; set; }
        public DbSet<AttendanceRegisterDetail> AttendanceRegisterDetails { get; set; }
        public DbSet<AttendanceRegister> AttendanceRegisters { get; set; }

        public DbSet<Department> Department { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<PriorityRank> PriorityRanks { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }
        public DbSet<WeekDay> WeekDays { get; set; }
        public DbSet<Frequency> Frequencies { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<StatementList> StatementLists { get; set; }
        public DbSet<RelationshipType> RelationshipTypes { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<RoleMenu> RoleMenus { get; set; }
        public DbSet<Titles> Titles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<CustomVariableType> VariableTypes { get; set; }
        public DbSet<SmartDomain.CustomSetting> CustomSettings { get; set; }
        public DbSet<Maintanance> Maintanances { get; set; }
        public DbSet<Licence> Licences { get; set; }
        public DbSet<TechnicalSupport> TechnicalSupports { get; set; }
        public DbSet<ErrorLog> ErrorLogging { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<DocumentFormat> DocumentFormats { get; set; }

        public DbSet<Country> Countries { get; set; }
        public DbSet<FeatureFlag> FeatureFlags { get; set; }

        public DbSet<EmailTemplate> EmailTemplates { get; set; }
        public DbSet<EmailType> EmailTypes { get; set; }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuGroup> MenuGroups { get; set; }

        public DbSet<Layout> Layouts { get; set; }
        public DbSet<LayoutMenu> LayoutMenus { get; set; }
        public DbSet<UserAccessRestriction> UserAccessRestrictions { get; set; }


        public DbSet<Fund> Funds { get; set; }
        public DbSet<FundItem> FundItems { get; set; }
        public DbSet<FundCategory> FundCategories { get; set; }
        public DbSet<FundCategoryItem> FundCategoryItems { get; set; }
        public DbSet<FundSource> FundSources { get; set; }
        public DbSet<KonapoFund> KonapoFunds { get; set; }
        public DbSet<KonapoFundCT> KonapoFundCTs { get; set; }
        public DbSet<KonapoFundCTI> KonapoFundCTIs { get; set; }
        public DbSet<KonapoFundReport> KonapoFundReports { get; set; }
        public DbSet<KonapoFundCTIHistory> KonapoFundCTIHistories { get; set; }
        // The following example creates a script for all migrations after the InitialCreate migration, using the migration ID.
        // Script-Migration -From 20180904195021_InitialCreate
    }
}

