using Microsoft.EntityFrameworkCore;
using SmartDomain;

namespace SmartDataAccess
{

    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //  optionsBuilder.();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
            modelBuilder.Entity<TransactionTypes>().HasData(
              Data.GetTransactionTypes());

            // bank account types
            modelBuilder.Entity<BankAccountType>().HasData(
             Data.GetBankAccountTypes());

            // currencies
            modelBuilder.Entity<Currency>().HasData(
             Data.GetCurrencies());


            // product Frequencies
            modelBuilder.Entity<ProductFrequency>().HasData(
                Data.GetProductFrequencies());


            //   user types
            modelBuilder.Entity<UserType>().HasData(
             Data.GetUserTypes());
            //   contact types
            modelBuilder.Entity<ContactType>().HasData(
           Data.GetContactTypes());

            //   relationship types
            modelBuilder.Entity<RelationshipType>().HasData(
              Data.GetRelationshipTypes());

            //  custom  setting types
            modelBuilder.Entity<CustomSettingType>().HasData(
                Data.GetCustomSettingTypes());

            //   custom variable types
            modelBuilder.Entity<CustomVariableType>().HasData(
           Data.GetCustomVariableTypes());

            //   custom settings
            modelBuilder.Entity<CustomSetting>().HasData(
              Data.GetApplicationSettings());

            //default company
            modelBuilder.Entity<Company>().HasData(
              Data.GetDefaultCompany());

            //   priority
            modelBuilder.Entity<PriorityRank>().HasData(
              Data.GetPriorityRanks());
            //users
            modelBuilder.Entity<User>().HasData(
                     Data.GetUsers());


            //gender
            modelBuilder.Entity<Gender>().HasData(
                     Data.GetGenders());

            // country
            modelBuilder.Entity<Country>().HasData(
                    Data.GetCountries());

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
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<BankAccountType> BankAccountTypes { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<PaymentStatus> PaymentStatus { get; set; }
        public DbSet<TransactionTypes> TransactionType { get; set; }
        public DbSet<Client> Clients { get; set; }


        public DbSet<ClientContact> ClientContacts { get; set; }
        public DbSet<ClientDocument> ClientDocuments { get; set; }
        public DbSet<ClientGuarantor> ClientGuarantors { get; set; }
        public DbSet<ClientBoard> ClientBoard { get; set; }
        public DbSet<ClientNote> ClientNotes { get; set; }
        public DbSet<ClientDependent> ClientDependents { get; set; }
        public DbSet<ClientProduct> ClientProducts { get; set; }
        public DbSet<ClientMedicalDetail> ClientMedicalDetails { get; set; }
        public DbSet<NoticeBoard> NoticeBoard { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductNote> ProductNotes { get; set; }
        public DbSet<ProductFrequency> ProductFrequencies { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseOutline> CourseOutlines { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<PriorityRank> PriorityRanks { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }
        public DbSet<WeekDay> WeekDays { get; set; }
        public DbSet<Gender> Genders { get; set; }

        public DbSet<RelationshipType> RelationshipTypes { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<CustomVariableType> SystemVariableTypes { get; set; }
        public DbSet<CustomSettingType> CustomSettingTypes { get; set; }
        public DbSet<CustomSetting> CustomSettings { get; set; }
        public DbSet<ErrorLog> ErrorLogging { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<DocumentFormat> DocumentFormats { get; set; }

        public DbSet<BroadCast> BroadCasts { get; set; }
        public DbSet<AuditAction> AuditActions { get; set; }
        public DbSet<AuditEntry> AuditEntries { get; set; }
                public DbSet<Country> Countries { get; set; }
        public DbSet<FeatureFlag> FeatureFlags { get; set; }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuGroup> MenuGroups { get; set; }
    }
}

