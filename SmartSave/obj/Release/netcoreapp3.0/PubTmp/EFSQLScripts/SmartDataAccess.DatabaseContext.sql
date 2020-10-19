﻿IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [Asserts] (
        [AssertID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_Asserts] PRIMARY KEY ([AssertID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [BankAccountTypes] (
        [BankAccountTypeID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_BankAccountTypes] PRIMARY KEY ([BankAccountTypeID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [ContactTypes] (
        [ContactTypeID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_ContactTypes] PRIMARY KEY ([ContactTypeID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [Countries] (
        [CountryID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_Countries] PRIMARY KEY ([CountryID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [Courses] (
        [CourseID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [DateCreated] datetime2 NOT NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_Courses] PRIMARY KEY ([CourseID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [Currencies] (
        [CurrencyID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_Currencies] PRIMARY KEY ([CurrencyID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [CustomSettingTypes] (
        [CustomSettingTypeID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_CustomSettingTypes] PRIMARY KEY ([CustomSettingTypeID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [Department] (
        [DepartmentID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_Department] PRIMARY KEY ([DepartmentID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [DocumentFormats] (
        [DocumentFormatID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_DocumentFormats] PRIMARY KEY ([DocumentFormatID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [EmailTypes] (
        [EmailTypeID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        CONSTRAINT [PK_EmailTypes] PRIMARY KEY ([EmailTypeID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [ErrorLogging] (
        [ErrorLogID] int NOT NULL IDENTITY,
        [SourceID] int NOT NULL,
        [StackTrace] nvarchar(max) NULL,
        [Message] nvarchar(max) NULL,
        [LoggedBy] nvarchar(max) NULL,
        [DateGenerated] datetime2 NOT NULL,
        CONSTRAINT [PK_ErrorLogging] PRIMARY KEY ([ErrorLogID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [FeatureFlags] (
        [FeatureFlagID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_FeatureFlags] PRIMARY KEY ([FeatureFlagID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [Frequencies] (
        [FrequencyID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_Frequencies] PRIMARY KEY ([FrequencyID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [Genders] (
        [GenderID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_Genders] PRIMARY KEY ([GenderID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [MenuGroups] (
        [MenuGroupID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [DisplayName] nvarchar(max) NULL,
        [ControllerName] nvarchar(max) NULL,
        [ActionName] nvarchar(max) NULL,
        [CSSClass] nvarchar(max) NULL,
        [OrderNo] int NOT NULL,
        [IsActive] bit NOT NULL,
        [IsActiveMenu] bit NOT NULL,
        CONSTRAINT [PK_MenuGroups] PRIMARY KEY ([MenuGroupID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [PaymentStatus] (
        [PaymentStatusID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_PaymentStatus] PRIMARY KEY ([PaymentStatusID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [Permissions] (
        [PermissionID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        [IsDeleted] bit NOT NULL,
        CONSTRAINT [PK_Permissions] PRIMARY KEY ([PermissionID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [PriorityRanks] (
        [PriorityRankID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_PriorityRanks] PRIMARY KEY ([PriorityRankID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [RelationshipTypes] (
        [RelationshipTypeID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_RelationshipTypes] PRIMARY KEY ([RelationshipTypeID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [Roles] (
        [RoleID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_Roles] PRIMARY KEY ([RoleID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [StatementLists] (
        [StatementID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        CONSTRAINT [PK_StatementLists] PRIMARY KEY ([StatementID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [SystemVariableTypes] (
        [CustomVariableTypeID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_SystemVariableTypes] PRIMARY KEY ([CustomVariableTypeID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [TransactionStatus] (
        [TransactionStatusID] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        CONSTRAINT [PK_TransactionStatus] PRIMARY KEY ([TransactionStatusID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [UserTypes] (
        [UserTypeID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_UserTypes] PRIMARY KEY ([UserTypeID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [WeekDays] (
        [WeekDayID] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        CONSTRAINT [PK_WeekDays] PRIMARY KEY ([WeekDayID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [AssertCategories] (
        [AssertCategoryID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [AssertID] int NOT NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_AssertCategories] PRIMARY KEY ([AssertCategoryID]),
        CONSTRAINT [FK_AssertCategories_Asserts_AssertID] FOREIGN KEY ([AssertID]) REFERENCES [Asserts] ([AssertID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [Companies] (
        [CompanyID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Code] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [AddressLine1] nvarchar(max) NULL,
        [AddressLine2] nvarchar(max) NULL,
        [City] nvarchar(max) NULL,
        [CountryID] int NULL,
        [Phone] nvarchar(max) NULL,
        [Fax] nvarchar(max) NULL,
        [Mobile] nvarchar(max) NULL,
        [Website] nvarchar(max) NULL,
        [IsDefault] bit NOT NULL,
        [IsActive] bit NOT NULL,
        [CompanyLogo] varbinary(max) NULL,
        CONSTRAINT [PK_Companies] PRIMARY KEY ([CompanyID]),
        CONSTRAINT [FK_Companies_Countries_CountryID] FOREIGN KEY ([CountryID]) REFERENCES [Countries] ([CountryID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [CourseOutlines] (
        [CourseOutlineID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [CourseID] int NOT NULL,
        [Name] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_CourseOutlines] PRIMARY KEY ([CourseOutlineID]),
        CONSTRAINT [FK_CourseOutlines_Courses_CourseID] FOREIGN KEY ([CourseID]) REFERENCES [Courses] ([CourseID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [BankAccounts] (
        [BankAccountID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [BankAccountTypeID] int NOT NULL,
        [AccountCode] nvarchar(max) NULL,
        [AccountName] nvarchar(max) NULL,
        [AccountNumber] nvarchar(max) NULL,
        [CurrencyID] int NOT NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_BankAccounts] PRIMARY KEY ([BankAccountID]),
        CONSTRAINT [FK_BankAccounts_BankAccountTypes_BankAccountTypeID] FOREIGN KEY ([BankAccountTypeID]) REFERENCES [BankAccountTypes] ([BankAccountTypeID]) ON DELETE CASCADE,
        CONSTRAINT [FK_BankAccounts_Currencies_CurrencyID] FOREIGN KEY ([CurrencyID]) REFERENCES [Currencies] ([CurrencyID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [DocumentTypes] (
        [DocumentTypeID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [DocumentFormatID] int NOT NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_DocumentTypes] PRIMARY KEY ([DocumentTypeID]),
        CONSTRAINT [FK_DocumentTypes_DocumentFormats_DocumentFormatID] FOREIGN KEY ([DocumentFormatID]) REFERENCES [DocumentFormats] ([DocumentFormatID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [CourseFeeHistory] (
        [CourseFeeHistoryID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [CourseFeeID] int NOT NULL,
        [CourseID] int NOT NULL,
        [FrequencyID] int NOT NULL,
        [Amount] decimal(18,2) NOT NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_CourseFeeHistory] PRIMARY KEY ([CourseFeeHistoryID]),
        CONSTRAINT [FK_CourseFeeHistory_Courses_CourseID] FOREIGN KEY ([CourseID]) REFERENCES [Courses] ([CourseID]) ON DELETE CASCADE,
        CONSTRAINT [FK_CourseFeeHistory_Frequencies_FrequencyID] FOREIGN KEY ([FrequencyID]) REFERENCES [Frequencies] ([FrequencyID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [CourseFees] (
        [CourseFeeID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [CourseID] int NOT NULL,
        [FrequencyID] int NOT NULL,
        [Amount] decimal(18,2) NOT NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_CourseFees] PRIMARY KEY ([CourseFeeID]),
        CONSTRAINT [FK_CourseFees_Courses_CourseID] FOREIGN KEY ([CourseID]) REFERENCES [Courses] ([CourseID]) ON DELETE CASCADE,
        CONSTRAINT [FK_CourseFees_Frequencies_FrequencyID] FOREIGN KEY ([FrequencyID]) REFERENCES [Frequencies] ([FrequencyID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [Menus] (
        [MenuID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [MenuGroupID] int NOT NULL,
        [DisplayName] nvarchar(max) NULL,
        [ControllerName] nvarchar(max) NULL,
        [ActionName] nvarchar(max) NULL,
        [CSSClass] nvarchar(max) NULL,
        [OrderNo] int NOT NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_Menus] PRIMARY KEY ([MenuID]),
        CONSTRAINT [FK_Menus_MenuGroups_MenuGroupID] FOREIGN KEY ([MenuGroupID]) REFERENCES [MenuGroups] ([MenuGroupID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [EmailTemplates] (
        [EmailTemplateID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [EmailTypeID] int NOT NULL,
        [Subject] nvarchar(max) NULL,
        [Body] nvarchar(max) NULL,
        [PriorityRankID] int NOT NULL,
        CONSTRAINT [PK_EmailTemplates] PRIMARY KEY ([EmailTemplateID]),
        CONSTRAINT [FK_EmailTemplates_EmailTypes_EmailTypeID] FOREIGN KEY ([EmailTypeID]) REFERENCES [EmailTypes] ([EmailTypeID]) ON DELETE CASCADE,
        CONSTRAINT [FK_EmailTemplates_PriorityRanks_PriorityRankID] FOREIGN KEY ([PriorityRankID]) REFERENCES [PriorityRanks] ([PriorityRankID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [NoticeBoard] (
        [NoticeID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Title] nvarchar(max) NOT NULL,
        [Details] nvarchar(max) NULL,
        [StartDate] datetime2 NOT NULL,
        [EndDate] datetime2 NOT NULL,
        [PriorityRankID] int NOT NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_NoticeBoard] PRIMARY KEY ([NoticeID]),
        CONSTRAINT [FK_NoticeBoard_PriorityRanks_PriorityRankID] FOREIGN KEY ([PriorityRankID]) REFERENCES [PriorityRanks] ([PriorityRankID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [RolePermissions] (
        [RolePermissionID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [PermissionID] int NOT NULL,
        [RoleID] int NOT NULL,
        CONSTRAINT [PK_RolePermissions] PRIMARY KEY ([RolePermissionID]),
        CONSTRAINT [FK_RolePermissions_Permissions_PermissionID] FOREIGN KEY ([PermissionID]) REFERENCES [Permissions] ([PermissionID]) ON DELETE CASCADE,
        CONSTRAINT [FK_RolePermissions_Roles_RoleID] FOREIGN KEY ([RoleID]) REFERENCES [Roles] ([RoleID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [CustomSettings] (
        [CustomSettingID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [Value] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [CustomVariableTypeID] int NOT NULL,
        [CustomSettingTypeID] int NOT NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_CustomSettings] PRIMARY KEY ([CustomSettingID]),
        CONSTRAINT [FK_CustomSettings_CustomSettingTypes_CustomSettingTypeID] FOREIGN KEY ([CustomSettingTypeID]) REFERENCES [CustomSettingTypes] ([CustomSettingTypeID]) ON DELETE CASCADE,
        CONSTRAINT [FK_CustomSettings_SystemVariableTypes_CustomVariableTypeID] FOREIGN KEY ([CustomVariableTypeID]) REFERENCES [SystemVariableTypes] ([CustomVariableTypeID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [TransactionType] (
        [TransactionTypeID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [TransactionStatusID] int NOT NULL,
        [Code] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_TransactionType] PRIMARY KEY ([TransactionTypeID]),
        CONSTRAINT [FK_TransactionType_TransactionStatus_TransactionStatusID] FOREIGN KEY ([TransactionStatusID]) REFERENCES [TransactionStatus] ([TransactionStatusID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [Users] (
        [UserID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [UserTypeID] int NOT NULL,
        [EmailAddress] nvarchar(max) NULL,
        [FirstName] nvarchar(250) NOT NULL,
        [IDNumber] nvarchar(max) NOT NULL,
        [LastName] nvarchar(250) NOT NULL,
        [UserName] nvarchar(max) NULL,
        [Password] nvarchar(max) NULL,
        [PasswordExpiryDate] datetime2 NOT NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_Users] PRIMARY KEY ([UserID]),
        CONSTRAINT [FK_Users_UserTypes_UserTypeID] FOREIGN KEY ([UserTypeID]) REFERENCES [UserTypes] ([UserTypeID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [Products] (
        [ProductID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [ProductCode] nvarchar(max) NULL,
        [DeductionPercentage] decimal(18,2) NOT NULL,
        [IncreamentPercentage] decimal(18,2) NOT NULL,
        [IsActive] bit NOT NULL,
        [CompanyID] int NOT NULL,
        [CountryID] int NOT NULL,
        CONSTRAINT [PK_Products] PRIMARY KEY ([ProductID]),
        CONSTRAINT [FK_Products_Companies_CompanyID] FOREIGN KEY ([CompanyID]) REFERENCES [Companies] ([CompanyID]) ON DELETE CASCADE,
        CONSTRAINT [FK_Products_Countries_CountryID] FOREIGN KEY ([CountryID]) REFERENCES [Countries] ([CountryID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [RoleMenus] (
        [RoleMenuID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [MenuID] int NOT NULL,
        [RoleID] int NOT NULL,
        CONSTRAINT [PK_RoleMenus] PRIMARY KEY ([RoleMenuID]),
        CONSTRAINT [FK_RoleMenus_Menus_MenuID] FOREIGN KEY ([MenuID]) REFERENCES [Menus] ([MenuID]) ON DELETE CASCADE,
        CONSTRAINT [FK_RoleMenus_Roles_RoleID] FOREIGN KEY ([RoleID]) REFERENCES [Roles] ([RoleID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [UserAuthenticationCodes] (
        [UserPinID] int NOT NULL IDENTITY,
        [UserID] int NOT NULL,
        [PinCode] nvarchar(max) NULL,
        [DateRequested] datetime2 NOT NULL,
        [ExpiryDate] datetime2 NOT NULL,
        [IsAccountCreation] bit NOT NULL,
        CONSTRAINT [PK_UserAuthenticationCodes] PRIMARY KEY ([UserPinID]),
        CONSTRAINT [FK_UserAuthenticationCodes_Users_UserID] FOREIGN KEY ([UserID]) REFERENCES [Users] ([UserID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [UserRoles] (
        [UserID] int NOT NULL,
        [RoleID] int NOT NULL,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [UserRoleID] int NOT NULL,
        CONSTRAINT [PK_UserRoles] PRIMARY KEY ([UserID], [RoleID]),
        CONSTRAINT [FK_UserRoles_Roles_RoleID] FOREIGN KEY ([RoleID]) REFERENCES [Roles] ([RoleID]) ON DELETE CASCADE,
        CONSTRAINT [FK_UserRoles_Users_UserID] FOREIGN KEY ([UserID]) REFERENCES [Users] ([UserID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [Clients] (
        [ClientID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [AccountNumber] nvarchar(max) NULL,
        [FirstName] nvarchar(max) NOT NULL,
        [DateOfBirth] datetime2 NOT NULL,
        [LastName] nvarchar(max) NOT NULL,
        [IDNumber] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        [UserName] nvarchar(max) NULL,
        [EmailAddress] nvarchar(max) NULL,
        [MobileNumber] nvarchar(max) NULL,
        [AddressLine1] nvarchar(max) NULL,
        [AddressLine2] nvarchar(max) NULL,
        [City] nvarchar(max) NULL,
        [CountryID] int NULL,
        [RegistrationDate] datetime2 NOT NULL,
        [GenderID] int NOT NULL,
        [DepartmentID] int NULL,
        [Occupation] nvarchar(max) NULL,
        [Salary] decimal(18,2) NOT NULL,
        [ProductID1] int NULL,
        CONSTRAINT [PK_Clients] PRIMARY KEY ([ClientID]),
        CONSTRAINT [FK_Clients_Countries_CountryID] FOREIGN KEY ([CountryID]) REFERENCES [Countries] ([CountryID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Clients_Department_DepartmentID] FOREIGN KEY ([DepartmentID]) REFERENCES [Department] ([DepartmentID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Clients_Genders_GenderID] FOREIGN KEY ([GenderID]) REFERENCES [Genders] ([GenderID]) ON DELETE CASCADE,
        CONSTRAINT [FK_Clients_Products_ProductID1] FOREIGN KEY ([ProductID1]) REFERENCES [Products] ([ProductID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [ProductAssertCategory] (
        [ID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [ProductID] int NOT NULL,
        [AssertCategoryID] int NOT NULL,
        [DateRegistered] datetime2 NOT NULL,
        CONSTRAINT [PK_ProductAssertCategory] PRIMARY KEY ([ID]),
        CONSTRAINT [FK_ProductAssertCategory_AssertCategories_AssertCategoryID] FOREIGN KEY ([AssertCategoryID]) REFERENCES [AssertCategories] ([AssertCategoryID]) ON DELETE CASCADE,
        CONSTRAINT [FK_ProductAssertCategory_Products_ProductID] FOREIGN KEY ([ProductID]) REFERENCES [Products] ([ProductID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [ProductAsserts] (
        [ID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [ProductID] int NOT NULL,
        [AssertID] int NOT NULL,
        CONSTRAINT [PK_ProductAsserts] PRIMARY KEY ([ID]),
        CONSTRAINT [FK_ProductAsserts_Asserts_AssertID] FOREIGN KEY ([AssertID]) REFERENCES [Asserts] ([AssertID]) ON DELETE CASCADE,
        CONSTRAINT [FK_ProductAsserts_Products_ProductID] FOREIGN KEY ([ProductID]) REFERENCES [Products] ([ProductID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [ProductFeeHistory] (
        [ProductFeeHistoryID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [ProductFeeID] int NOT NULL,
        [ProductID] int NOT NULL,
        [FrequencyID] int NOT NULL,
        [Amount] decimal(18,2) NOT NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_ProductFeeHistory] PRIMARY KEY ([ProductFeeHistoryID]),
        CONSTRAINT [FK_ProductFeeHistory_Frequencies_FrequencyID] FOREIGN KEY ([FrequencyID]) REFERENCES [Frequencies] ([FrequencyID]) ON DELETE CASCADE,
        CONSTRAINT [FK_ProductFeeHistory_Products_ProductID] FOREIGN KEY ([ProductID]) REFERENCES [Products] ([ProductID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [ProductFees] (
        [ProductFeeID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [ProductID] int NOT NULL,
        [FrequencyID] int NOT NULL,
        [Amount] decimal(18,2) NOT NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_ProductFees] PRIMARY KEY ([ProductFeeID]),
        CONSTRAINT [FK_ProductFees_Frequencies_FrequencyID] FOREIGN KEY ([FrequencyID]) REFERENCES [Frequencies] ([FrequencyID]) ON DELETE CASCADE,
        CONSTRAINT [FK_ProductFees_Products_ProductID] FOREIGN KEY ([ProductID]) REFERENCES [Products] ([ProductID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [ProductHistory] (
        [ProductHistoryID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [ProductID] int NOT NULL,
        [DeductionPercentage] decimal(18,2) NOT NULL,
        [IncreamentPercentage] decimal(18,2) NOT NULL,
        CONSTRAINT [PK_ProductHistory] PRIMARY KEY ([ProductHistoryID]),
        CONSTRAINT [FK_ProductHistory_Products_ProductID] FOREIGN KEY ([ProductID]) REFERENCES [Products] ([ProductID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [ClientContacts] (
        [ClientContactID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [ClientID] int NOT NULL,
        [ContactTypeID] int NOT NULL,
        [ContactPerson] nvarchar(max) NULL,
        [Contact] nvarchar(max) NULL,
        [RelationshipTypeID] int NOT NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_ClientContacts] PRIMARY KEY ([ClientContactID]),
        CONSTRAINT [FK_ClientContacts_Clients_ClientID] FOREIGN KEY ([ClientID]) REFERENCES [Clients] ([ClientID]) ON DELETE CASCADE,
        CONSTRAINT [FK_ClientContacts_ContactTypes_ContactTypeID] FOREIGN KEY ([ContactTypeID]) REFERENCES [ContactTypes] ([ContactTypeID]) ON DELETE CASCADE,
        CONSTRAINT [FK_ClientContacts_RelationshipTypes_RelationshipTypeID] FOREIGN KEY ([RelationshipTypeID]) REFERENCES [RelationshipTypes] ([RelationshipTypeID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [ClientCourses] (
        [ClientCourseID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [ClientID] int NOT NULL,
        [CourseID] int NOT NULL,
        [DateRegistered] datetime2 NOT NULL,
        [DateCompleted] datetime2 NULL,
        [IsDeRegistered] bit NOT NULL,
        CONSTRAINT [PK_ClientCourses] PRIMARY KEY ([ClientCourseID]),
        CONSTRAINT [FK_ClientCourses_Clients_ClientID] FOREIGN KEY ([ClientID]) REFERENCES [Clients] ([ClientID]) ON DELETE CASCADE,
        CONSTRAINT [FK_ClientCourses_Courses_CourseID] FOREIGN KEY ([CourseID]) REFERENCES [Courses] ([CourseID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [ClientDeductions] (
        [ClientDeductionID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [ClientID] int NOT NULL,
        [InvoiceNumber] int NOT NULL,
        [ClientProductID] int NOT NULL,
        [ProductID] int NOT NULL,
        [DeductedAmount] decimal(18,2) NOT NULL,
        [Salary] decimal(18,2) NOT NULL,
        [DeductionPercentage] decimal(18,2) NOT NULL,
        [AdditionalDeductionPercentage] decimal(18,2) NOT NULL,
        [TotalDeductionPercentage] decimal(18,2) NOT NULL,
        [InvoiceDate] datetime2 NOT NULL,
        [DueDate] datetime2 NOT NULL,
        [DatePaid] datetime2 NULL,
        CONSTRAINT [PK_ClientDeductions] PRIMARY KEY ([ClientDeductionID]),
        CONSTRAINT [FK_ClientDeductions_Clients_ClientID] FOREIGN KEY ([ClientID]) REFERENCES [Clients] ([ClientID]) ON DELETE CASCADE,
        CONSTRAINT [FK_ClientDeductions_Products_ProductID] FOREIGN KEY ([ProductID]) REFERENCES [Products] ([ProductID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [ClientDependents] (
        [ClientDependentID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [ClientID] int NOT NULL,
        [FirstName] nvarchar(max) NOT NULL,
        [DateOfBirth] datetime2 NOT NULL,
        [LastName] nvarchar(max) NOT NULL,
        [IDNumber] nvarchar(max) NULL,
        [Occupation] nvarchar(max) NULL,
        [GenderID] int NOT NULL,
        [IsActive] bit NOT NULL,
        [RegistrationDate] datetime2 NOT NULL,
        CONSTRAINT [PK_ClientDependents] PRIMARY KEY ([ClientDependentID]),
        CONSTRAINT [FK_ClientDependents_Clients_ClientID] FOREIGN KEY ([ClientID]) REFERENCES [Clients] ([ClientID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [ClientDocuments] (
        [ClientDocumentID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [DocumentTypeID] int NOT NULL,
        [Comment] nvarchar(max) NULL,
        [DateUploaded] datetime2 NOT NULL,
        [UploadedBy] nvarchar(max) NULL,
        [FileBytes] varbinary(max) NULL,
        [FileType] nvarchar(max) NULL,
        [FileName] nvarchar(max) NULL,
        [ClientID] int NOT NULL,
        CONSTRAINT [PK_ClientDocuments] PRIMARY KEY ([ClientDocumentID]),
        CONSTRAINT [FK_ClientDocuments_Clients_ClientID] FOREIGN KEY ([ClientID]) REFERENCES [Clients] ([ClientID]) ON DELETE CASCADE,
        CONSTRAINT [FK_ClientDocuments_DocumentTypes_DocumentTypeID] FOREIGN KEY ([DocumentTypeID]) REFERENCES [DocumentTypes] ([DocumentTypeID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [ClientMedicalDetails] (
        [ClientMedicalID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [ClientID] int NOT NULL,
        [Doctor] nvarchar(max) NULL,
        [Telephone] nvarchar(max) NULL,
        [MedicalAid] nvarchar(max) NULL,
        [MedicalAidNo] nvarchar(max) NULL,
        [Allergies] nvarchar(max) NULL,
        [PrescribedMedication] nvarchar(max) NULL,
        [Other] nvarchar(max) NULL,
        [Hospital] nvarchar(max) NULL,
        CONSTRAINT [PK_ClientMedicalDetails] PRIMARY KEY ([ClientMedicalID]),
        CONSTRAINT [FK_ClientMedicalDetails_Clients_ClientID] FOREIGN KEY ([ClientID]) REFERENCES [Clients] ([ClientID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [ClientNotes] (
        [ClientNoteID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [Comment] nvarchar(max) NOT NULL,
        [UserTypeID] int NOT NULL,
        [DateUploaded] datetime2 NOT NULL,
        [DateClosed] datetime2 NULL,
        [DueDate] datetime2 NOT NULL,
        [UploadedBy] nvarchar(max) NULL,
        [ClientID] int NOT NULL,
        [VisibleToAdminOnly] bit NOT NULL,
        CONSTRAINT [PK_ClientNotes] PRIMARY KEY ([ClientNoteID]),
        CONSTRAINT [FK_ClientNotes_Clients_ClientID] FOREIGN KEY ([ClientID]) REFERENCES [Clients] ([ClientID]) ON DELETE CASCADE,
        CONSTRAINT [FK_ClientNotes_UserTypes_UserTypeID] FOREIGN KEY ([UserTypeID]) REFERENCES [UserTypes] ([UserTypeID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [ClientOccupationHistory] (
        [ClientOccupationID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [ClientID] int NOT NULL,
        [Occupation] nvarchar(max) NULL,
        [Salary] decimal(18,2) NOT NULL,
        CONSTRAINT [PK_ClientOccupationHistory] PRIMARY KEY ([ClientOccupationID]),
        CONSTRAINT [FK_ClientOccupationHistory_Clients_ClientID] FOREIGN KEY ([ClientID]) REFERENCES [Clients] ([ClientID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [ClientProducts] (
        [ClientProductID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [ClientID] int NOT NULL,
        [ProductID] int NOT NULL,
        [IsActive] bit NOT NULL,
        CONSTRAINT [PK_ClientProducts] PRIMARY KEY ([ClientProductID]),
        CONSTRAINT [FK_ClientProducts_Clients_ClientID] FOREIGN KEY ([ClientID]) REFERENCES [Clients] ([ClientID]) ON DELETE CASCADE,
        CONSTRAINT [FK_ClientProducts_Products_ProductID] FOREIGN KEY ([ProductID]) REFERENCES [Products] ([ProductID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [Transactions] (
        [TransactionID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [TransRef] nvarchar(max) NULL,
        [Narration] nvarchar(max) NULL,
        [ClientID] int NOT NULL,
        [ProductID] int NULL,
        [CourseID] int NULL,
        [AssertID] int NOT NULL,
        [AssertCategoryID] int NOT NULL,
        [BankAccountID] int NOT NULL,
        [Year] int NOT NULL,
        [Month] int NOT NULL,
        [TransactionTypeID] int NOT NULL,
        [PaymentStatusID] int NOT NULL,
        [ClientFeeID] int NULL,
        [Amount] decimal(18,2) NOT NULL,
        [AmountExclVAT] decimal(18,2) NOT NULL,
        [VAT] decimal(18,2) NOT NULL,
        [PaymentDate] datetime2 NOT NULL,
        [TransactionDate] datetime2 NOT NULL,
        [ParentPaymentID] int NULL,
        [Reason] nvarchar(max) NULL,
        CONSTRAINT [PK_Transactions] PRIMARY KEY ([TransactionID]),
        CONSTRAINT [FK_Transactions_BankAccounts_BankAccountID] FOREIGN KEY ([BankAccountID]) REFERENCES [BankAccounts] ([BankAccountID]) ON DELETE CASCADE,
        CONSTRAINT [FK_Transactions_Clients_ClientID] FOREIGN KEY ([ClientID]) REFERENCES [Clients] ([ClientID]) ON DELETE CASCADE,
        CONSTRAINT [FK_Transactions_Courses_CourseID] FOREIGN KEY ([CourseID]) REFERENCES [Courses] ([CourseID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Transactions_PaymentStatus_PaymentStatusID] FOREIGN KEY ([PaymentStatusID]) REFERENCES [PaymentStatus] ([PaymentStatusID]) ON DELETE CASCADE,
        CONSTRAINT [FK_Transactions_Products_ProductID] FOREIGN KEY ([ProductID]) REFERENCES [Products] ([ProductID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Transactions_TransactionType_TransactionTypeID] FOREIGN KEY ([TransactionTypeID]) REFERENCES [TransactionType] ([TransactionTypeID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [ClientFees] (
        [ClientFeeID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [ClientID] int NOT NULL,
        [ClientProductID] int NULL,
        [ProductFeeID] int NULL,
        [ClientCourseID] int NULL,
        [CourseFeeID] int NULL,
        [Amount] decimal(18,2) NOT NULL,
        [DueDate] datetime2 NOT NULL,
        [DatePaid] datetime2 NULL,
        CONSTRAINT [PK_ClientFees] PRIMARY KEY ([ClientFeeID]),
        CONSTRAINT [FK_ClientFees_Clients_ClientID] FOREIGN KEY ([ClientID]) REFERENCES [Clients] ([ClientID]) ON DELETE CASCADE,
        CONSTRAINT [FK_ClientFees_CourseFees_CourseFeeID] FOREIGN KEY ([CourseFeeID]) REFERENCES [CourseFees] ([CourseFeeID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_ClientFees_ProductFees_ProductFeeID] FOREIGN KEY ([ProductFeeID]) REFERENCES [ProductFees] ([ProductFeeID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE TABLE [ClientTranscripts] (
        [ClientTranscriptID] int NOT NULL IDENTITY,
        [LastChangedDate] datetime2 NOT NULL,
        [LastChangedBy] nvarchar(max) NULL,
        [ClientCourseID] int NOT NULL,
        [CourseOutlineID] int NOT NULL,
        [DateRegistered] datetime2 NOT NULL,
        CONSTRAINT [PK_ClientTranscripts] PRIMARY KEY ([ClientTranscriptID]),
        CONSTRAINT [FK_ClientTranscripts_ClientCourses_ClientCourseID] FOREIGN KEY ([ClientCourseID]) REFERENCES [ClientCourses] ([ClientCourseID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'BankAccountTypeID', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[BankAccountTypes]'))
        SET IDENTITY_INSERT [BankAccountTypes] ON;
    INSERT INTO [BankAccountTypes] ([BankAccountTypeID], [IsActive], [LastChangedBy], [LastChangedDate], [Name])
    VALUES (1, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5635482+02:00', N'Savings'),
    (2, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5635875+02:00', N'Cheque'),
    (3, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5635883+02:00', N'Credit'),
    (4, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5635886+02:00', N'Cash');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'BankAccountTypeID', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[BankAccountTypes]'))
        SET IDENTITY_INSERT [BankAccountTypes] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ContactTypeID', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[ContactTypes]'))
        SET IDENTITY_INSERT [ContactTypes] ON;
    INSERT INTO [ContactTypes] ([ContactTypeID], [IsActive], [LastChangedBy], [LastChangedDate], [Name])
    VALUES (4, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5740045+02:00', N'Cell Phone'),
    (3, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5740171+02:00', N'Email Address'),
    (2, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5740179+02:00', N'Postal Address'),
    (1, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5740184+02:00', N'Residential Address'),
    (5, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5740189+02:00', N'Telephone');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ContactTypeID', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[ContactTypes]'))
        SET IDENTITY_INSERT [ContactTypes] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CountryID', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[Countries]'))
        SET IDENTITY_INSERT [Countries] ON;
    INSERT INTO [Countries] ([CountryID], [IsActive], [LastChangedBy], [LastChangedDate], [Name])
    VALUES (156, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817149+02:00', N'Norway'),
    (155, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817145+02:00', N'N Mariana Islands'),
    (154, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817140+02:00', N'Nigeria'),
    (153, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817137+02:00', N'Niger'),
    (152, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817133+02:00', N'Nicaragua'),
    (147, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817111+02:00', N'Nepal'),
    (149, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817120+02:00', N'Netherlands Antilles'),
    (148, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817115+02:00', N'Netherlands'),
    (157, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817153+02:00', N'Oman'),
    (146, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817107+02:00', N'Nauru'),
    (151, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817129+02:00', N'New Zealand'),
    (158, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817157+02:00', N'Pakistan'),
    (162, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817173+02:00', N'Paraguay'),
    (160, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817164+02:00', N'Panama'),
    (161, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817169+02:00', N'Papua New Guinea'),
    (145, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817104+02:00', N'Namibia'),
    (163, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817176+02:00', N'Peru'),
    (164, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817180+02:00', N'Philippines'),
    (165, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817184+02:00', N'Poland'),
    (166, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817187+02:00', N'Portugal'),
    (167, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817191+02:00', N'Puerto Rico'),
    (168, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817195+02:00', N'Qatar'),
    (169, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817199+02:00', N'Reunion'),
    (170, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817203+02:00', N'Romania'),
    (159, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817160+02:00', N'Palau'),
    (144, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817100+02:00', N'Mozambique'),
    (139, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817079+02:00', N'Moldova'),
    (142, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817089+02:00', N'Montserrat'),
    (117, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816984+02:00', N'Lebanon'),
    (118, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816988+02:00', N'Lesotho'),
    (119, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816991+02:00', N'Liberia'),
    (120, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816995+02:00', N'Libya'),
    (121, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816998+02:00', N'Liechtenstein'),
    (122, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817002+02:00', N'Lithuania'),
    (123, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817006+02:00', N'Luxembourg'),
    (124, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817010+02:00', N'Macau'),
    (125, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817014+02:00', N'Macedonia'),
    (126, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817017+02:00', N'Madagascar'),
    (127, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817021+02:00', N'Malawi'),
    (128, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817025+02:00', N'Malaysia'),
    (129, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817028+02:00', N'Maldives'),
    (130, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817042+02:00', N'Mali'),
    (131, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817046+02:00', N'Malta'),
    (132, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817051+02:00', N'Marshall Islands'),
    (133, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817055+02:00', N'Martinique'),
    (134, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817058+02:00', N'Mauritania'),
    (135, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817062+02:00', N'Mauritius'),
    (136, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817066+02:00', N'Mayotte'),
    (137, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817070+02:00', N'Mexico'),
    (138, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817075+02:00', N'Micronesia Fed St'),
    (171, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817206+02:00', N'Russia'),
    (140, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817082+02:00', N'Monaco'),
    (141, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817086+02:00', N'Mongolia'),
    (143, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817095+02:00', N'Morocco'),
    (172, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817210+02:00', N'Rwanda'),
    (177, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817235+02:00', N'Saint Vincent and the Grenadines'),
    (174, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817220+02:00', N'Saint Kitts Nevis'),
    (204, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817434+02:00', N'Togo'),
    (205, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817438+02:00', N'Tonga'),
    (206, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817443+02:00', N'Trinidad Tobago'),
    (207, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817446+02:00', N'Tunisia'),
    (208, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817450+02:00', N'Turkey'),
    (209, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817454+02:00', N'Turkmenistan'),
    (210, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817459+02:00', N'Turks Caicos Is'),
    (211, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817462+02:00', N'Tuvalu'),
    (212, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817466+02:00', N'Uganda'),
    (213, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817470+02:00', N'Ukraine'),
    (214, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817474+02:00', N'United Arab Emirates'),
    (215, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817479+02:00', N'United Kingdom'),
    (216, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817483+02:00', N'United States'),
    (217, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817487+02:00', N'Uruguay'),
    (218, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817491+02:00', N'Uzbekistan'),
    (219, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817495+02:00', N'Vanuatu'),
    (220, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817498+02:00', N'Venezuela'),
    (221, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817502+02:00', N'Vietnam'),
    (222, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817506+02:00', N'Virgin Islands'),
    (223, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817511+02:00', N'Wallis Futuna'),
    (224, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817515+02:00', N'West Bank'),
    (225, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817519+02:00', N'Western Sahara'),
    (226, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817523+02:00', N'Yemen'),
    (227, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817527+02:00', N'Zambia'),
    (228, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817530+02:00', N'Zimbabwe'),
    (203, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817431+02:00', N'Thailand'),
    (173, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817215+02:00', N'Saint Helena'),
    (202, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817427+02:00', N'Tanzania'),
    (200, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817419+02:00', N'Taiwan'),
    (175, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817224+02:00', N'Saint Lucia'),
    (176, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817229+02:00', N'St Pierre Miquelon'),
    (116, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816980+02:00', N'Latvia'),
    (178, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817239+02:00', N'Samoa'),
    (179, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817243+02:00', N'San Marino'),
    (180, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817248+02:00', N'Sao Tome Principe'),
    (181, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817252+02:00', N'Saudi Arabia'),
    (182, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817256+02:00', N'Senegal'),
    (183, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817260+02:00', N'Serbia'),
    (184, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817264+02:00', N'Seychelles'),
    (185, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817268+02:00', N'Sierra Leone'),
    (186, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817272+02:00', N'Singapore'),
    (187, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817276+02:00', N'Slovakia'),
    (188, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817371+02:00', N'Slovenia'),
    (189, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817377+02:00', N'Solomon Islands'),
    (190, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817380+02:00', N'Somalia'),
    (191, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817385+02:00', N'South Africa'),
    (192, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817388+02:00', N'Spain'),
    (193, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817393+02:00', N'Sri Lanka'),
    (194, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817397+02:00', N'Sudan'),
    (195, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817400+02:00', N'Suriname'),
    (196, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817404+02:00', N'Swaziland'),
    (197, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817408+02:00', N'Sweden'),
    (198, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817412+02:00', N'Switzerland'),
    (199, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817415+02:00', N'Syria'),
    (201, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817423+02:00', N'Tajikistan'),
    (115, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816976+02:00', N'Laos'),
    (150, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5817124+02:00', N'New Caledonia'),
    (113, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816968+02:00', N'Kuwait'),
    (30, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816623+02:00', N'British Virgin Is'),
    (31, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816626+02:00', N'Brunei'),
    (32, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816630+02:00', N'Bulgaria'),
    (33, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816635+02:00', N'Burkina Faso'),
    (34, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816641+02:00', N'Burma'),
    (35, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816645+02:00', N'Burundi'),
    (36, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816648+02:00', N'Cambodia'),
    (37, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816652+02:00', N'Cameroon'),
    (38, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816656+02:00', N'Canada'),
    (39, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816661+02:00', N'Cape Verde'),
    (40, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816665+02:00', N'Cayman Islands'),
    (41, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816670+02:00', N'Central African Rep'),
    (42, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816674+02:00', N'Chad'),
    (43, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816678+02:00', N'Chile'),
    (44, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816682+02:00', N'China'),
    (45, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816686+02:00', N'Colombia'),
    (46, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816689+02:00', N'Comoros'),
    (47, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816694+02:00', N'Congo Dem Rep'),
    (48, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816700+02:00', N'Congo Repub of the'),
    (49, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816704+02:00', N'Cook Islands'),
    (50, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816709+02:00', N'Costa Rica'),
    (51, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816713+02:00', N'Cote dIvoire'),
    (52, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816717+02:00', N'Croatia'),
    (53, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816721+02:00', N'Cuba'),
    (54, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816724+02:00', N'Cyprus'),
    (29, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816617+02:00', N'Brazil'),
    (55, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816730+02:00', N'Czech Republic'),
    (28, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816613+02:00', N'Botswana'),
    (26, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816604+02:00', N'Bolivia'),
    (1, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816012+02:00', N'Afghanistan'),
    (2, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816471+02:00', N'Albania'),
    (3, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816480+02:00', N'Algeria'),
    (4, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816491+02:00', N'American Samoa'),
    (5, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816496+02:00', N'Andorra'),
    (6, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816506+02:00', N'Angola'),
    (7, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816510+02:00', N'Anguilla'),
    (8, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816515+02:00', N'Antigua Barbuda'),
    (9, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816519+02:00', N'Argentina'),
    (10, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816524+02:00', N'Armenia'),
    (11, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816527+02:00', N'Aruba'),
    (12, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816547+02:00', N'Australia'),
    (13, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816552+02:00', N'Austria'),
    (14, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816555+02:00', N'Azerbaijan'),
    (15, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816559+02:00', N'Bahamas'),
    (16, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816564+02:00', N' The'),
    (114, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816972+02:00', N'Kyrgyzstan'),
    (18, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816574+02:00', N'Bangladesh'),
    (19, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816578+02:00', N'Barbados'),
    (20, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816582+02:00', N'Belarus'),
    (21, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816586+02:00', N'Belgium'),
    (22, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816590+02:00', N'Belize'),
    (23, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816593+02:00', N'Benin'),
    (24, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816597+02:00', N'Bermuda'),
    (25, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816601+02:00', N'Bhutan'),
    (27, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816609+02:00', N'Bosnia Herzegovina'),
    (56, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816734+02:00', N'Denmark'),
    (17, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816568+02:00', N'Bahrain'),
    (58, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816742+02:00', N'Dominica'),
    (88, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816873+02:00', N'Guinea'),
    (89, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816878+02:00', N'Guinea Bissau'),
    (90, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816881+02:00', N'Guyana'),
    (91, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816885+02:00', N'Haiti'),
    (92, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816888+02:00', N'Honduras'),
    (93, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816893+02:00', N'Hong Kong'),
    (94, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816896+02:00', N'Hungary'),
    (95, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816900+02:00', N'Iceland'),
    (96, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816903+02:00', N'India'),
    (97, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816907+02:00', N'Indonesia'),
    (98, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816911+02:00', N'Iran'),
    (99, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816914+02:00', N'Iraq'),
    (100, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816918+02:00', N'Ireland'),
    (101, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816923+02:00', N'Isle of Man'),
    (102, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816927+02:00', N'Israel'),
    (103, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816930+02:00', N'Italy'),
    (105, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816937+02:00', N'Japan'),
    (106, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816941+02:00', N'Jersey'),
    (107, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816945+02:00', N'Jordan'),
    (108, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816949+02:00', N'Kazakhstan'),
    (109, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816952+02:00', N'Kenya'),
    (110, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816956+02:00', N'Kiribati'),
    (111, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816960+02:00', N'Korea North'),
    (112, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816965+02:00', N'Korea South'),
    (57, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816737+02:00', N'Djibouti'),
    (87, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816869+02:00', N'Guernsey'),
    (86, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816866+02:00', N'Guatemala'),
    (104, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816934+02:00', N'Jamaica'),
    (84, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816858+02:00', N'Guadeloupe'),
    (59, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816747+02:00', N'Dominican Republic'),
    (85, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816861+02:00', N'Guam'),
    (60, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816751+02:00', N'East Timor'),
    (61, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816755+02:00', N'Ecuador'),
    (62, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816759+02:00', N'Egypt'),
    (63, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816764+02:00', N'El Salvador'),
    (65, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816772+02:00', N'Eritrea'),
    (66, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816788+02:00', N'Estonia'),
    (67, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816791+02:00', N'Ethiopia'),
    (68, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816796+02:00', N'Faroe Islands'),
    (69, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816800+02:00', N'Fiji'),
    (70, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816803+02:00', N'Finland'),
    (71, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816807+02:00', N'France'),
    (64, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816768+02:00', N'Equatorial Guinea'),
    (73, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816817+02:00', N'French Polynesia'),
    (72, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816812+02:00', N'French Guiana'),
    (83, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816854+02:00', N'Grenada'),
    (81, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816847+02:00', N'Greece'),
    (80, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816843+02:00', N'Gibraltar'),
    (82, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816851+02:00', N'Greenland'),
    (79, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816840+02:00', N'Ghana'),
    (77, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816833+02:00', N'Georgia'),
    (76, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816829+02:00', N'Gaza Strip'),
    (75, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816825+02:00', N'Gambia The'),
    (74, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816820+02:00', N'Gabon'),
    (78, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5816836+02:00', N'Germany');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CountryID', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[Countries]'))
        SET IDENTITY_INSERT [Countries] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CurrencyID', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[Currencies]'))
        SET IDENTITY_INSERT [Currencies] ON;
    INSERT INTO [Currencies] ([CurrencyID], [IsActive], [LastChangedBy], [LastChangedDate], [Name])
    VALUES (106, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661140+02:00', N'NZD'),
    (107, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661143+02:00', N'OMR'),
    (105, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661137+02:00', N'NPR'),
    (108, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661146+02:00', N'PAB'),
    (109, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661149+02:00', N'PEN'),
    (110, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661151+02:00', N'PGK'),
    (111, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661154+02:00', N'PHP'),
    (116, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661169+02:00', N'RON'),
    (113, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661160+02:00', N'PLN'),
    (114, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661164+02:00', N'PYG'),
    (115, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661167+02:00', N'QAR'),
    (117, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661173+02:00', N'RSD'),
    (118, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661176+02:00', N'RUB'),
    (120, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661181+02:00', N'SAR'),
    (104, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661134+02:00', N'NOK'),
    (119, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661178+02:00', N'RWF'),
    (112, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661157+02:00', N'PKR'),
    (103, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661130+02:00', N'NIO'),
    (90, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661058+02:00', N'MKD'),
    (101, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661123+02:00', N'NAD'),
    (84, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661040+02:00', N'LRD'),
    (121, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661185+02:00', N'SBD'),
    (85, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661043+02:00', N'LSL'),
    (86, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661046+02:00', N'LYD'),
    (87, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661049+02:00', N'MAD'),
    (88, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661052+02:00', N'MDL'),
    (89, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661055+02:00', N'MGA'),
    (91, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661061+02:00', N'MMK'),
    (92, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661064+02:00', N'MNT'),
    (93, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661067+02:00', N'MOP'),
    (94, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661070+02:00', N'MRU'),
    (95, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661073+02:00', N'MUR'),
    (96, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661076+02:00', N'MVR'),
    (97, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661079+02:00', N'MWK'),
    (98, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661082+02:00', N'MXN'),
    (99, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661085+02:00', N'MYR'),
    (100, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661088+02:00', N'MZN'),
    (102, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661127+02:00', N'NGN'),
    (122, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661187+02:00', N'SCR'),
    (150, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661275+02:00', N'VEF'),
    (124, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661194+02:00', N'SEK'),
    (146, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661263+02:00', N'UGX'),
    (147, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661265+02:00', N'USD'),
    (148, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661269+02:00', N'UYU'),
    (149, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661271+02:00', N'UZS'),
    (151, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661278+02:00', N'VND'),
    (152, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661280+02:00', N'VUV'),
    (153, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661283+02:00', N'WST'),
    (154, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661286+02:00', N'XAF'),
    (155, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661289+02:00', N'XCD'),
    (156, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661292+02:00', N'XDR'),
    (157, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661295+02:00', N'XOF'),
    (158, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661298+02:00', N'XPF'),
    (159, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661301+02:00', N'YER'),
    (160, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661339+02:00', N'ZAR'),
    (161, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661342+02:00', N'ZMW'),
    (162, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661345+02:00', N'ZWD'),
    (83, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661037+02:00', N'LKR'),
    (145, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661260+02:00', N'UAH'),
    (123, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661191+02:00', N'SDG'),
    (144, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661256+02:00', N'TZS'),
    (142, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661250+02:00', N'TVD'),
    (125, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661197+02:00', N'SGD'),
    (126, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661200+02:00', N'SHP'),
    (127, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661203+02:00', N'SLL'),
    (128, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661206+02:00', N'SOS'),
    (129, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661209+02:00', N'SPL'),
    (130, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661215+02:00', N'SRD'),
    (131, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661218+02:00', N'STN'),
    (132, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661221+02:00', N'SVC'),
    (133, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661224+02:00', N'SYP'),
    (134, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661227+02:00', N'SZL'),
    (135, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661230+02:00', N'THB'),
    (136, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661232+02:00', N'TJS'),
    (137, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661235+02:00', N'TMT'),
    (138, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661238+02:00', N'TND'),
    (139, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661241+02:00', N'TOP'),
    (140, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661244+02:00', N'TRY'),
    (141, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661247+02:00', N'TTD'),
    (143, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661254+02:00', N'TWD'),
    (82, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661034+02:00', N'LBP'),
    (55, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660950+02:00', N'GYD'),
    (80, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661028+02:00', N'KZT'),
    (22, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660699+02:00', N'BTN'),
    (23, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660702+02:00', N'BWP'),
    (24, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660705+02:00', N'BYN'),
    (25, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660708+02:00', N'BZD'),
    (26, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660711+02:00', N'CAD'),
    (27, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660714+02:00', N'CDF'),
    (28, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660717+02:00', N'CHF'),
    (21, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660696+02:00', N'BSD'),
    (29, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660720+02:00', N'CLP'),
    (31, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660726+02:00', N'COP'),
    (32, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660729+02:00', N'CRC'),
    (33, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660732+02:00', N'CUC'),
    (34, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660887+02:00', N'CUP'),
    (35, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660890+02:00', N'CVE'),
    (36, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660893+02:00', N'CZK'),
    (37, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660896+02:00', N'DJF'),
    (30, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660723+02:00', N'CNY'),
    (20, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660693+02:00', N'BRL'),
    (19, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660690+02:00', N'BOB'),
    (18, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660687+02:00', N'BND'),
    (81, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661030+02:00', N'LAK'),
    (1, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660203+02:00', N'AED'),
    (2, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660623+02:00', N'AFN'),
    (3, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660631+02:00', N'ALL'),
    (4, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660635+02:00', N'AMD'),
    (5, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660638+02:00', N'ANG'),
    (6, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660647+02:00', N'AOA'),
    (7, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660650+02:00', N'ARS'),
    (8, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660653+02:00', N'AUD'),
    (10, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660660+02:00', N'AZN'),
    (11, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660664+02:00', N'BAM'),
    (12, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660667+02:00', N'BBD'),
    (13, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660670+02:00', N'BDT'),
    (14, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660673+02:00', N'BGN'),
    (15, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660676+02:00', N'BHD'),
    (16, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660679+02:00', N'BIF'),
    (17, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660682+02:00', N'BMD'),
    (38, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660899+02:00', N'DKK'),
    (39, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660902+02:00', N'DOP'),
    (9, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660656+02:00', N'AWG'),
    (41, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660908+02:00', N'EGP'),
    (63, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660975+02:00', N'IMP'),
    (64, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660977+02:00', N'INR'),
    (65, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660980+02:00', N'IQD'),
    (66, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660986+02:00', N'IRR'),
    (67, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660989+02:00', N'ISK'),
    (68, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660992+02:00', N'JEP'),
    (69, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660995+02:00', N'JMD'),
    (62, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660972+02:00', N'ILS'),
    (70, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660998+02:00', N'JOD'),
    (71, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661001+02:00', N'JPY'),
    (72, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661004+02:00', N'KES'),
    (73, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661007+02:00', N'KGS'),
    (74, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661010+02:00', N'KHR'),
    (75, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661013+02:00', N'KMF'),
    (76, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661016+02:00', N'KPW'),
    (77, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661019+02:00', N'KRW'),
    (79, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661025+02:00', N'KYD'),
    (61, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660969+02:00', N'IDR'),
    (60, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660965+02:00', N'HUF'),
    (59, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660962+02:00', N'HTG'),
    (42, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660912+02:00', N'ERN'),
    (43, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660915+02:00', N'ETB'),
    (44, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660918+02:00', N'EUR'),
    (45, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660921+02:00', N'FJD'),
    (46, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660924+02:00', N'FKP'),
    (47, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660927+02:00', N'GBP'),
    (48, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660930+02:00', N'GEL'),
    (49, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660932+02:00', N'GGP'),
    (50, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660935+02:00', N'GHS'),
    (51, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660938+02:00', N'GIP'),
    (52, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660941+02:00', N'GMD'),
    (53, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660945+02:00', N'GNF'),
    (54, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660948+02:00', N'GTQ'),
    (40, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660905+02:00', N'DZD'),
    (56, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660954+02:00', N'HKD'),
    (57, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660956+02:00', N'HNL'),
    (58, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5660959+02:00', N'HRK'),
    (78, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5661022+02:00', N'KWD');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CurrencyID', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[Currencies]'))
        SET IDENTITY_INSERT [Currencies] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CustomSettingTypeID', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[CustomSettingTypes]'))
        SET IDENTITY_INSERT [CustomSettingTypes] ON;
    INSERT INTO [CustomSettingTypes] ([CustomSettingTypeID], [IsActive], [LastChangedBy], [LastChangedDate], [Name])
    VALUES (3, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5758261+02:00', N'All'),
    (4, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5758266+02:00', N'Email'),
    (1, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5758105+02:00', N'BackEnd'),
    (2, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5758254+02:00', N'Portal');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CustomSettingTypeID', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[CustomSettingTypes]'))
        SET IDENTITY_INSERT [CustomSettingTypes] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'DocumentFormatID', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[DocumentFormats]'))
        SET IDENTITY_INSERT [DocumentFormats] ON;
    INSERT INTO [DocumentFormats] ([DocumentFormatID], [IsActive], [LastChangedBy], [LastChangedDate], [Name])
    VALUES (6, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5916839+02:00', N'ppt'),
    (5, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5916827+02:00', N'rtf'),
    (4, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5916825+02:00', N'txt'),
    (1, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5916473+02:00', N'pdf'),
    (2, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5916814+02:00', N'doc'),
    (3, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5916821+02:00', N'xlsx');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'DocumentFormatID', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[DocumentFormats]'))
        SET IDENTITY_INSERT [DocumentFormats] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmailTypeID', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[EmailTypes]'))
        SET IDENTITY_INSERT [EmailTypes] ON;
    INSERT INTO [EmailTypes] ([EmailTypeID], [LastChangedBy], [LastChangedDate], [Name])
    VALUES (4, N'SuperUser', '2020-10-15T21:46:30.6026805+02:00', N'New User Account Created'),
    (3, N'SuperUser', '2020-10-15T21:46:30.6026800+02:00', N'Invoice'),
    (2, N'SuperUser', '2020-10-15T21:46:30.6026794+02:00', N'Proof Of Payment'),
    (1, N'SuperUser', '2020-10-15T21:46:30.6026448+02:00', N'Client Statement');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmailTypeID', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[EmailTypes]'))
        SET IDENTITY_INSERT [EmailTypes] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'FeatureFlagID', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[FeatureFlags]'))
        SET IDENTITY_INSERT [FeatureFlags] ON;
    INSERT INTO [FeatureFlags] ([FeatureFlagID], [IsActive], [LastChangedBy], [LastChangedDate], [Name])
    VALUES (3, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5892887+02:00', N'Enable Document Emailing Functionality'),
    (2, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5892876+02:00', N'CC Client On Error'),
    (1, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5892419+02:00', N'Send Email On Error');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'FeatureFlagID', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[FeatureFlags]'))
        SET IDENTITY_INSERT [FeatureFlags] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'FrequencyID', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[Frequencies]'))
        SET IDENTITY_INSERT [Frequencies] ON;
    INSERT INTO [Frequencies] ([FrequencyID], [IsActive], [LastChangedBy], [LastChangedDate], [Name])
    VALUES (2, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5699210+02:00', N'Monthly'),
    (1, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5698716+02:00', N'Once Off');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'FrequencyID', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[Frequencies]'))
        SET IDENTITY_INSERT [Frequencies] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'GenderID', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[Genders]'))
        SET IDENTITY_INSERT [Genders] ON;
    INSERT INTO [Genders] ([GenderID], [IsActive], [LastChangedBy], [LastChangedDate], [Name])
    VALUES (2, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5781198+02:00', N'Male'),
    (1, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5780983+02:00', N'Female');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'GenderID', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[Genders]'))
        SET IDENTITY_INSERT [Genders] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'MenuGroupID', N'ActionName', N'CSSClass', N'ControllerName', N'DisplayName', N'IsActive', N'IsActiveMenu', N'LastChangedBy', N'LastChangedDate', N'OrderNo') AND [object_id] = OBJECT_ID(N'[MenuGroups]'))
        SET IDENTITY_INSERT [MenuGroups] ON;
    INSERT INTO [MenuGroups] ([MenuGroupID], [ActionName], [CSSClass], [ControllerName], [DisplayName], [IsActive], [IsActiveMenu], [LastChangedBy], [LastChangedDate], [OrderNo])
    VALUES (2, NULL, N'fa fa-users', NULL, N'Employees', CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5959802+02:00', 2),
    (3, NULL, N'fa fa-money', NULL, N'Product And Services', CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5959814+02:00', 3),
    (9998, NULL, N'fa fa-university', NULL, N'Menu', CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5959831+02:00', 9998),
    (1, N'Dashboard', N'fa fa-umbrella', N'Home', N'DashBoard', CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5959681+02:00', 1),
    (999, NULL, N'fa fa-desktop', NULL, N'Developer Menu', CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5959837+02:00', 9999),
    (4, NULL, N'fa fa-area-chart', NULL, N'Reporting', CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5959819+02:00', 6),
    (5, NULL, N'fa fa-wrench', NULL, N'Custom Settings', CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5959824+02:00', 7);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'MenuGroupID', N'ActionName', N'CSSClass', N'ControllerName', N'DisplayName', N'IsActive', N'IsActiveMenu', N'LastChangedBy', N'LastChangedDate', N'OrderNo') AND [object_id] = OBJECT_ID(N'[MenuGroups]'))
        SET IDENTITY_INSERT [MenuGroups] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'PaymentStatusID', N'Description', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[PaymentStatus]'))
        SET IDENTITY_INSERT [PaymentStatus] ON;
    INSERT INTO [PaymentStatus] ([PaymentStatusID], [Description], [IsActive], [LastChangedBy], [LastChangedDate], [Name])
    VALUES (1, NULL, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5581095+02:00', N'Paid'),
    (2, NULL, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5581485+02:00', N'Reversed'),
    (3, NULL, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5581493+02:00', N'Pending'),
    (4, NULL, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5581497+02:00', N'Refunded'),
    (5, NULL, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5581500+02:00', N'Discounted');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'PaymentStatusID', N'Description', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[PaymentStatus]'))
        SET IDENTITY_INSERT [PaymentStatus] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'PermissionID', N'Description', N'IsActive', N'IsDeleted', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[Permissions]'))
        SET IDENTITY_INSERT [Permissions] ON;
    INSERT INTO [Permissions] ([PermissionID], [Description], [IsActive], [IsDeleted], [LastChangedBy], [LastChangedDate], [Name])
    VALUES (75, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550123+02:00', N'Add Course Fee'),
    (74, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550118+02:00', N'View Course Fee'),
    (84, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550171+02:00', N'Add Company'),
    (73, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550114+02:00', N'View Course'),
    (82, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550163+02:00', N'Delete Document Type'),
    (81, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550158+02:00', N'Update Document Type'),
    (80, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550154+02:00', N'Add Document Type'),
    (79, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550150+02:00', N'View Custom Setting'),
    (78, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550146+02:00', N'Update Custom Setting'),
    (77, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550142+02:00', N'Delete Course Fee'),
    (83, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550167+02:00', N'View Document Type'),
    (76, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550137+02:00', N'Update Course Fee'),
    (72, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550110+02:00', N'Delete Course'),
    (65, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550080+02:00', N'Update Menu'),
    (70, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550103+02:00', N'Add Course'),
    (69, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550099+02:00', N'View Menu'),
    (68, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550095+02:00', N'Delete Menu'),
    (67, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550091+02:00', N'Deactivate Menu'),
    (66, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550087+02:00', N'Activate Menu'),
    (64, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550077+02:00', N'Add Menu'),
    (63, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550073+02:00', N'Override Payment'),
    (62, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550069+02:00', N'View Client Deductions'),
    (61, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550064+02:00', N'Remove Invoice Entries'),
    (60, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550060+02:00', N'Generate Invoices'),
    (59, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550056+02:00', N'View Client Outstanding Payments'),
    (58, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550051+02:00', N'View Payment'),
    (85, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550174+02:00', N'Update Company'),
    (57, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550047+02:00', N'Reverse Payment'),
    (71, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550107+02:00', N'Update Course'),
    (86, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550178+02:00', N'Delete Company'),
    (112, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550284+02:00', N'View Product Assert'),
    (88, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550186+02:00', N'Add Bank Account'),
    (116, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550300+02:00', N'View Assert'),
    (115, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550296+02:00', N'Delete Assert'),
    (114, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550292+02:00', N'Update Assert'),
    (113, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550288+02:00', N'Add Assert'),
    (56, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550043+02:00', N'Capture Payment'),
    (111, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550281+02:00', N'Update Product Assert'),
    (110, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550277+02:00', N'Add Product Assert'),
    (109, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550272+02:00', N'View Product Fee'),
    (108, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550268+02:00', N'Delete Product Fee'),
    (107, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550264+02:00', N'Update Product Fee'),
    (106, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550260+02:00', N'Add Product Fee'),
    (105, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550256+02:00', N'View Transaction Type'),
    (104, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550251+02:00', N'Update Transaction Type'),
    (87, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550182+02:00', N'View Company'),
    (103, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550247+02:00', N'Client Update Personal Details'),
    (101, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550237+02:00', N'Update Currency'),
    (100, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550234+02:00', N'Update Country'),
    (99, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550230+02:00', N'View Notice'),
    (98, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550226+02:00', N'Delete Notice'),
    (97, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550223+02:00', N'Update Notice'),
    (96, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550219+02:00', N'Add Notice'),
    (95, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550215+02:00', N'View Email Template'),
    (94, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550210+02:00', N'Delete Email Template'),
    (93, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550207+02:00', N'Update Email Template'),
    (92, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550203+02:00', N'Add Email Template'),
    (91, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550199+02:00', N'View Bank Account'),
    (90, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550194+02:00', N'Delete Bank Account'),
    (89, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550191+02:00', N'Update Bank Account'),
    (102, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550242+02:00', N'View Dashboard Notices'),
    (55, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550039+02:00', N'View Department'),
    (11, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549832+02:00', N'Add Client Note'),
    (53, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550031+02:00', N'Update Department'),
    (24, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549888+02:00', N'Update Client Dependent'),
    (23, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549883+02:00', N'Add Client Dependent'),
    (22, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549879+02:00', N'View Client Product'),
    (21, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549875+02:00', N'Delete Client Product'),
    (20, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549871+02:00', N'Update Client Product'),
    (19, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549867+02:00', N'Add Client Product'),
    (18, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549863+02:00', N'View Client Contact'),
    (17, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549857+02:00', N'Delete Client Contact'),
    (16, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549853+02:00', N'Update Client Contact'),
    (15, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549849+02:00', N'Add Client Contact'),
    (14, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549844+02:00', N'View Client Note'),
    (13, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549840+02:00', N'Delete Client Note'),
    (12, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549836+02:00', N'Update Client Note'),
    (10, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549827+02:00', N'Change Client Password'),
    (9, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549821+02:00', N'View Client'),
    (54, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550035+02:00', N'Delete Department'),
    (7, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549812+02:00', N'Update Client'),
    (6, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549808+02:00', N'Add Client'),
    (5, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549799+02:00', N'Change User Password'),
    (4, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549794+02:00', N'View User'),
    (3, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549790+02:00', N'Delete User'),
    (2, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549779+02:00', N'Update User'),
    (1, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549353+02:00', N'Add User'),
    (25, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549893+02:00', N'Delete Client Dependent'),
    (26, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549897+02:00', N'View Client Dependent'),
    (8, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549816+02:00', N'Delete Client'),
    (28, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549906+02:00', N'Update Client Course'),
    (27, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549902+02:00', N'Add Client Course'),
    (52, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550026+02:00', N'Add Department'),
    (51, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550022+02:00', N'View Product'),
    (50, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550018+02:00', N'Delete Product'),
    (49, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550015+02:00', N'Update Product'),
    (47, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550007+02:00', N'Remove Menu From Role'),
    (46, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550002+02:00', N'Add Menu To Role'),
    (45, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549997+02:00', N'View Permissions'),
    (44, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549993+02:00', N'Remove Permissions'),
    (43, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549989+02:00', N'Add Permissions'),
    (42, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549984+02:00', N'View Role'),
    (41, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549980+02:00', N'Delete Role'),
    (48, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5550011+02:00', N'Add Product'),
    (39, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549972+02:00', N'Add Role'),
    (40, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549977+02:00', N'Update Role'),
    (30, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549916+02:00', N'View Client Course'),
    (31, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549921+02:00', N'Add Client Medical Details'),
    (29, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549911+02:00', N'Delete Client Course'),
    (33, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549930+02:00', N'Delete Client Medical Details'),
    (32, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549926+02:00', N'Update Client Medical Details'),
    (34, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549937+02:00', N'View Client Medical Details'),
    (35, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549941+02:00', N'View Client Payments'),
    (36, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549959+02:00', N'Generate Client Statement'),
    (37, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549963+02:00', N'Client Upload Document'),
    (38, NULL, CAST(1 AS bit), CAST(0 AS bit), N'SuperUser', '2020-10-15T21:46:30.5549968+02:00', N'Client View Document');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'PermissionID', N'Description', N'IsActive', N'IsDeleted', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[Permissions]'))
        SET IDENTITY_INSERT [Permissions] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'PriorityRankID', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[PriorityRanks]'))
        SET IDENTITY_INSERT [PriorityRanks] ON;
    INSERT INTO [PriorityRanks] ([PriorityRankID], [IsActive], [LastChangedBy], [LastChangedDate], [Name])
    VALUES (3, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5828632+02:00', N'Medium'),
    (2, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5828626+02:00', N'High'),
    (1, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5828472+02:00', N'Critical'),
    (4, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5828636+02:00', N'Low');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'PriorityRankID', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[PriorityRanks]'))
        SET IDENTITY_INSERT [PriorityRanks] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RelationshipTypeID', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[RelationshipTypes]'))
        SET IDENTITY_INSERT [RelationshipTypes] ON;
    INSERT INTO [RelationshipTypes] ([RelationshipTypeID], [IsActive], [LastChangedBy], [LastChangedDate], [Name])
    VALUES (3, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5748501+02:00', N'Father'),
    (4, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5748504+02:00', N'Sibling'),
    (2, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5748498+02:00', N'Mother'),
    (6, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5748515+02:00', N'Other'),
    (1, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5748310+02:00', N'Self'),
    (5, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5748506+02:00', N'Spouse');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RelationshipTypeID', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[RelationshipTypes]'))
        SET IDENTITY_INSERT [RelationshipTypes] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleID', N'Description', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[Roles]'))
        SET IDENTITY_INSERT [Roles] ON;
    INSERT INTO [Roles] ([RoleID], [Description], [IsActive], [LastChangedBy], [LastChangedDate], [Name])
    VALUES (1, NULL, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5490020+02:00', N'Super Admin'),
    (2, NULL, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5503846+02:00', N'Employee'),
    (3, NULL, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5503904+02:00', N'Administrator');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleID', N'Description', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[Roles]'))
        SET IDENTITY_INSERT [Roles] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StatementID', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[StatementLists]'))
        SET IDENTITY_INSERT [StatementLists] ON;
    INSERT INTO [StatementLists] ([StatementID], [LastChangedBy], [LastChangedDate], [Name])
    VALUES (1, N'SuperUser', '2020-10-15T21:46:30.6129336+02:00', N'Product Based Statement'),
    (2, N'SuperUser', '2020-10-15T21:46:30.6129673+02:00', N'Transaction List');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StatementID', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[StatementLists]'))
        SET IDENTITY_INSERT [StatementLists] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CustomVariableTypeID', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[SystemVariableTypes]'))
        SET IDENTITY_INSERT [SystemVariableTypes] ON;
    INSERT INTO [SystemVariableTypes] ([CustomVariableTypeID], [IsActive], [LastChangedBy], [LastChangedDate], [Name])
    VALUES (3, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5772675+02:00', N'Long'),
    (1, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5772514+02:00', N'Boolean'),
    (5, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5772664+02:00', N'Double'),
    (4, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5772671+02:00', N'Integer'),
    (2, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5772680+02:00', N'String'),
    (6, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5772691+02:00', N'Decimal'),
    (7, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5772700+02:00', N'Date Time'),
    (8, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5772705+02:00', N'Password'),
    (9, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5772709+02:00', N'Percentage');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CustomVariableTypeID', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[SystemVariableTypes]'))
        SET IDENTITY_INSERT [SystemVariableTypes] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'TransactionStatusID', N'Name') AND [object_id] = OBJECT_ID(N'[TransactionStatus]'))
        SET IDENTITY_INSERT [TransactionStatus] ON;
    INSERT INTO [TransactionStatus] ([TransactionStatusID], [Name])
    VALUES (2, N'Negative'),
    (1, N'Positive');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'TransactionStatusID', N'Name') AND [object_id] = OBJECT_ID(N'[TransactionStatus]'))
        SET IDENTITY_INSERT [TransactionStatus] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'UserTypeID', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[UserTypes]'))
        SET IDENTITY_INSERT [UserTypes] ON;
    INSERT INTO [UserTypes] ([UserTypeID], [IsActive], [LastChangedBy], [LastChangedDate], [Name])
    VALUES (1, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5728406+02:00', N'Administrator'),
    (2, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5728828+02:00', N'Employer'),
    (3, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5728838+02:00', N'Employee');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'UserTypeID', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[UserTypes]'))
        SET IDENTITY_INSERT [UserTypes] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'WeekDayID', N'Name') AND [object_id] = OBJECT_ID(N'[WeekDays]'))
        SET IDENTITY_INSERT [WeekDays] ON;
    INSERT INTO [WeekDays] ([WeekDayID], [Name])
    VALUES (6, N'Friday'),
    (1, N'Sunday'),
    (2, N'Monday'),
    (3, N'Tuesday'),
    (4, N'Wednesday'),
    (5, N'Thursday'),
    (7, N'Saturday');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'WeekDayID', N'Name') AND [object_id] = OBJECT_ID(N'[WeekDays]'))
        SET IDENTITY_INSERT [WeekDays] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CustomSettingID', N'CustomSettingTypeID', N'CustomVariableTypeID', N'Description', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name', N'Value') AND [object_id] = OBJECT_ID(N'[CustomSettings]'))
        SET IDENTITY_INSERT [CustomSettings] ON;
    INSERT INTO [CustomSettings] ([CustomSettingID], [CustomSettingTypeID], [CustomVariableTypeID], [Description], [IsActive], [LastChangedBy], [LastChangedDate], [Name], [Value])
    VALUES (3, 3, 1, N'Allows system to hide exceptions and show custom error page to user', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6075903+02:00', N'Show Custom Exceptions To Users', N'true'),
    (12, 4, 2, N'Display Sender Name As', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6075998+02:00', N'Mail Display Name', N'Smart Admin'),
    (17, 3, 2, N'First Line on the Report Footer', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6076013+02:00', N'Report Footer 1', N'W. Guri Mrs. (Chairman), *E. Guri (Managing)'),
    (18, 3, 2, N'Additional Line on the Report Footer (can be blank)', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6076018+02:00', N'Report Footer 2', N'*Executive.'),
    (19, 3, 2, N'Foot notes that you would like to include on your statement (not mandatory)', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6076023+02:00', N'Report FootNotes', N''),
    (24, 3, 2, N'Password Used to Open Password Protected Statement By System Administrators', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6076033+02:00', N'Statement Password For Admin', N'123456'),
    (28, 3, 2, N'Site URL', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6076063+02:00', N'Site URL', N'https://localhost:5001'),
    (29, 3, 2, N'Site Reset Password URL', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6076068+02:00', N'Site Reset Password URL', N'https://localhost:5001/Login/ForgotPasswordConfirmation'),
    (10, 4, 2, N'Email Address used to email', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6075938+02:00', N'Mail Credential User Name', N'carolinesolutions89@gmail.com'),
    (30, 3, 2, N'Customer Support Email', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6076072+02:00', N'Site Customer Service Email', N'carochire@gmail.com'),
    (32, 3, 2, N'Default Email Addresss that overrides Client Email Address in a Test Environment ', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6076081+02:00', N'Site Test Email Account', N'carochire@gmail.com'),
    (35, 3, 2, N'Site Client Create Account URL', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6076097+02:00', N'Site Create Account URL', N'https://localhost:5001/Login/CreateAccountConfirmation'),
    (14, 3, 6, N'Maximum file size that can be uploaded to the System', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6076007+02:00', N'File Maximum UpLoadable Size', N'5'),
    (5, 3, 7, N'Format Used to display date', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6075908+02:00', N'Date Format', N'yyyy-MMM-dd'),
    (39, 3, 7, N'Format Used to display date time', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6075912+02:00', N'Date Format', N'yyyy-MMM-dd HH:mm'),
    (11, 4, 8, N'Email Password', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6075993+02:00', N'Mail Credential Password', N'ZGNvaXpoeGlxenZ3dnphaw=='),
    (13, 3, 9, N'Percentage To Which VAT is calculated on ', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6076002+02:00', N'VAT Percentage', N'0.14'),
    (31, 3, 2, N'Customer Support Number', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6076076+02:00', N'Site Customer Service Number', N'0731143168'),
    (7, 4, 2, N'Host used to Send Emails', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6075923+02:00', N'Mail SMTP Host', N'smtp.gmail.com'),
    (22, 3, 2, N'Default Email Subject Name Used By Auto-Generated Emails', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6076047+02:00', N'Mail Default Subject', N'Smart Save  Admin'),
    (2, 3, 2, N'Displays Current Version of the System', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6075858+02:00', N'System Version', N'1.0.0.0'),
    (8, 4, 1, N'Enable SSL', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6075928+02:00', N'Mail Enable SSL', N'true'),
    (15, 3, 2, N'Account Number Prefix if Any', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6075868+02:00', N'Account Number Prefix', N'SS'),
    (20, 3, 1, N'Instructs the System to Advise User to Capture VAT inclusive amounts and calculate breakdown accordingly', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6076028+02:00', N'Capture VAT Inclusive Payments', N'true'),
    (23, 3, 1, N'Allows to password protect statements being sent by Email', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6076038+02:00', N'Statement Password Protect', N'true'),
    (25, 3, 1, N'Determines if table borders will be shown on the report ', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6076043+02:00', N'Statement Show Table Boarders', N'true'),
    (34, 3, 1, N'Display menus based on User Role', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6076092+02:00', N'Application Role Based Menus', N'false'),
    (37, 3, 1, N'Auto Generate Account Numbers', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6076106+02:00', N'Account Number Auto Generate', N'true'),
    (38, 3, 1, N'Allows System To Be VAT Compliant and Show calculated VAT Amounts ', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6076112+02:00', N'Application Is VAT Compliant', N'false'),
    (9, 4, 1, N'Use Default Mail Credentials', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6075933+02:00', N'Mail Use Default Credentials', N'false'),
    (6, 4, 4, N'Port used to Send Emails', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6075917+02:00', N'Mail SMTP Port', N'587'),
    (26, 3, 4, N'Password Reset Pin Code Length', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6076053+02:00', N'Password Reset Pin Code Length', N'5'),
    (4, 3, 4, N'Limit Account Number Size', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6075864+02:00', N'Account Number Length', N'9'),
    (27, 3, 4, N'Password Reset Pin Code Validity Period in Days', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6076058+02:00', N'Password Reset Pin Validity', N'2'),
    (33, 3, 4, N'Current System Environment Set it to 1 For Test Environment  or 2 for Production Environment if no value has been set System defaults to Test Environment ', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6076086+02:00', N'Site Default Environment', N'1'),
    (36, 3, 4, N'Password Validity Period in Days', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6076102+02:00', N'Password Validity Period', N'30'),
    (1, 3, 2, N'Displayed as the Application Name', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6075662+02:00', N'Application Name', N'Smart Save'),
    (16, 3, 2, N'Short Name for Application', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.6075851+02:00', N'Application Name Prefix', N'SS');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CustomSettingID', N'CustomSettingTypeID', N'CustomVariableTypeID', N'Description', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name', N'Value') AND [object_id] = OBJECT_ID(N'[CustomSettings]'))
        SET IDENTITY_INSERT [CustomSettings] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'DocumentTypeID', N'DocumentFormatID', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[DocumentTypes]'))
        SET IDENTITY_INSERT [DocumentTypes] ON;
    INSERT INTO [DocumentTypes] ([DocumentTypeID], [DocumentFormatID], [IsActive], [LastChangedBy], [LastChangedDate], [Name])
    VALUES (3, 1, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5940618+02:00', N'Proof Of Address'),
    (4, 1, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5940622+02:00', N'Payslips'),
    (1, 1, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5939796+02:00', N'Identity Document'),
    (2, 1, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5940596+02:00', N'Birth Certificate');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'DocumentTypeID', N'DocumentFormatID', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name') AND [object_id] = OBJECT_ID(N'[DocumentTypes]'))
        SET IDENTITY_INSERT [DocumentTypes] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmailTemplateID', N'Body', N'EmailTypeID', N'LastChangedBy', N'LastChangedDate', N'PriorityRankID', N'Subject') AND [object_id] = OBJECT_ID(N'[EmailTemplates]'))
        SET IDENTITY_INSERT [EmailTemplates] ON;
    INSERT INTO [EmailTemplates] ([EmailTemplateID], [Body], [EmailTypeID], [LastChangedBy], [LastChangedDate], [PriorityRankID], [Subject])
    VALUES (1, N'Dear Customer, 

                            Attached is your Account statement. To view it you will need to open the PDF attachment and insert your password. Your password is your ID number. To view your statement you need to have Adobe PDF Reader installed. If you do not have it, you will need to do the following: - Copy and paste this URL into your browser: www.get.adobe.com/reader/?promoid=BUIGO - Go to the website - Click the download button and follow the easy instructions.


                            Regards,

                            Smart Saver', 1, N'SuperUser', '2020-10-15T21:46:30.6033036+02:00', 2, N'Account Statement');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmailTemplateID', N'Body', N'EmailTypeID', N'LastChangedBy', N'LastChangedDate', N'PriorityRankID', N'Subject') AND [object_id] = OBJECT_ID(N'[EmailTemplates]'))
        SET IDENTITY_INSERT [EmailTemplates] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'MenuID', N'ActionName', N'CSSClass', N'ControllerName', N'DisplayName', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'MenuGroupID', N'OrderNo') AND [object_id] = OBJECT_ID(N'[Menus]'))
        SET IDENTITY_INSERT [Menus] ON;
    INSERT INTO [Menus] ([MenuID], [ActionName], [CSSClass], [ControllerName], [DisplayName], [IsActive], [LastChangedBy], [LastChangedDate], [MenuGroupID], [OrderNo])
    VALUES (13, N'Assert', N'fa fa-lightbulb-o', N'Assert', N'Asserts', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5980415+02:00', 5, 13),
    (9999, N'FeatureFlag', N'fa fa-building', N'FeatureFlag', N'Feature Flags', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5980447+02:00', 999, 9999),
    (9998, N'MainMenu', N'fa fa-book', N'Menus', N'Menu', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5980444+02:00', 9998, 9998),
    (19, N'Currency', N'fa fa-money', N'Currency', N'Currency', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5980437+02:00', 5, 19),
    (18, N'DocumentTypes', N'fa fa-file', N'DocumentType', N'Document Types', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5980434+02:00', 5, 18),
    (17, N'Department', N'fa fa-building', N'Department', N'Departments', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5980429+02:00', 5, 17),
    (16, N'EmailTemplate', N'fa fa-envelope-o', N'EmailTemplate', N'Email Templates', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5980426+02:00', 5, 16),
    (15, N'NoticeBoard', N'fa broadcast-tower', N'NoticeBoard', N'Notice Board', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5980422+02:00', 5, 15),
    (14, N'BankAccounts', N'fa fa-university', N'BankAccounts', N'Banks', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5980419+02:00', 5, 14),
    (12, N'TransactionType', N'fa fa-money', N'TransactionType', N'Transaction Types', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5980412+02:00', 5, 12),
    (20, N'Country', N'fa fa-globe', N'Country', N'Country', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5980440+02:00', 5, 20),
    (10, N'Courses', N'fa fa-university', N'Courses', N'Coaching Programmes', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5980405+02:00', 5, 10),
    (9, N'Roles', N'fa fa-asterisk', N'Roles', N'Roles & Permissions', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5980401+02:00', 5, 9),
    (8, N'Users', N'fa fa-users', N'User', N'User Management', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5980397+02:00', 5, 8),
    (7, N'CustomSettings', N'fa fa-spinner', N'CustomSettings', N'Application Settings', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5980393+02:00', 5, 7),
    (6, N'Product', N'fa fa-product-hunt', N'Product', N'Products', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5980389+02:00', 3, 6),
    (5, N'ScheduleReport', N'fa fa-file', N'Transactions', N'Generated Invoices', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5980381+02:00', 3, 5),
    (4, N'Schedule', N'fa fa-gear', N'Transactions', N'Generate Bulk Invoice', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5980377+02:00', 3, 4),
    (3, N'Transactions', N'fa fa-money', N'Transactions', N'Transactions', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5980374+02:00', 3, 2),
    (2, N'MyAccount', N'fa fa-heart', N'Client', N'My Account', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5980369+02:00', 2, 0),
    (1, N'Clients', N'fa fa-users', N'Client', N'Employees', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5980203+02:00', 2, 1),
    (11, N'Companies', N'fa fa-building', N'Company', N'Companies', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5980409+02:00', 5, 11);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'MenuID', N'ActionName', N'CSSClass', N'ControllerName', N'DisplayName', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'MenuGroupID', N'OrderNo') AND [object_id] = OBJECT_ID(N'[Menus]'))
        SET IDENTITY_INSERT [Menus] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RolePermissionID', N'LastChangedBy', N'LastChangedDate', N'PermissionID', N'RoleID') AND [object_id] = OBJECT_ID(N'[RolePermissions]'))
        SET IDENTITY_INSERT [RolePermissions] ON;
    INSERT INTO [RolePermissions] ([RolePermissionID], [LastChangedBy], [LastChangedDate], [PermissionID], [RoleID])
    VALUES (77, N'SuperUser', '2020-10-15T21:46:30.5557143+02:00', 77, 1),
    (78, N'SuperUser', '2020-10-15T21:46:30.5557144+02:00', 78, 1),
    (79, N'SuperUser', '2020-10-15T21:46:30.5557146+02:00', 79, 1),
    (80, N'SuperUser', '2020-10-15T21:46:30.5557148+02:00', 80, 1),
    (81, N'SuperUser', '2020-10-15T21:46:30.5557149+02:00', 81, 1),
    (85, N'SuperUser', '2020-10-15T21:46:30.5557156+02:00', 85, 1),
    (83, N'SuperUser', '2020-10-15T21:46:30.5557153+02:00', 83, 1),
    (84, N'SuperUser', '2020-10-15T21:46:30.5557154+02:00', 84, 1),
    (76, N'SuperUser', '2020-10-15T21:46:30.5557141+02:00', 76, 1),
    (86, N'SuperUser', '2020-10-15T21:46:30.5557158+02:00', 86, 1),
    (82, N'SuperUser', '2020-10-15T21:46:30.5557151+02:00', 82, 1),
    (75, N'SuperUser', '2020-10-15T21:46:30.5557139+02:00', 75, 1),
    (70, N'SuperUser', '2020-10-15T21:46:30.5557131+02:00', 70, 1),
    (73, N'SuperUser', '2020-10-15T21:46:30.5557136+02:00', 73, 1),
    (72, N'SuperUser', '2020-10-15T21:46:30.5557134+02:00', 72, 1),
    (71, N'SuperUser', '2020-10-15T21:46:30.5557132+02:00', 71, 1),
    (87, N'SuperUser', '2020-10-15T21:46:30.5557159+02:00', 87, 1),
    (69, N'SuperUser', '2020-10-15T21:46:30.5557129+02:00', 69, 1),
    (68, N'SuperUser', '2020-10-15T21:46:30.5557127+02:00', 68, 1),
    (67, N'SuperUser', '2020-10-15T21:46:30.5557126+02:00', 67, 1),
    (66, N'SuperUser', '2020-10-15T21:46:30.5557124+02:00', 66, 1),
    (65, N'SuperUser', '2020-10-15T21:46:30.5557121+02:00', 65, 1),
    (64, N'SuperUser', '2020-10-15T21:46:30.5557119+02:00', 64, 1),
    (63, N'SuperUser', '2020-10-15T21:46:30.5557117+02:00', 63, 1),
    (62, N'SuperUser', '2020-10-15T21:46:30.5557116+02:00', 62, 1),
    (61, N'SuperUser', '2020-10-15T21:46:30.5557114+02:00', 61, 1),
    (74, N'SuperUser', '2020-10-15T21:46:30.5557138+02:00', 74, 1),
    (88, N'SuperUser', '2020-10-15T21:46:30.5557161+02:00', 88, 1),
    (93, N'SuperUser', '2020-10-15T21:46:30.5557169+02:00', 93, 1),
    (90, N'SuperUser', '2020-10-15T21:46:30.5557164+02:00', 90, 1),
    (60, N'SuperUser', '2020-10-15T21:46:30.5557112+02:00', 60, 1),
    (116, N'SuperUser', '2020-10-15T21:46:30.5557208+02:00', 116, 1),
    (115, N'SuperUser', '2020-10-15T21:46:30.5557206+02:00', 115, 1),
    (114, N'SuperUser', '2020-10-15T21:46:30.5557204+02:00', 114, 1),
    (113, N'SuperUser', '2020-10-15T21:46:30.5557203+02:00', 113, 1),
    (112, N'SuperUser', '2020-10-15T21:46:30.5557201+02:00', 112, 1),
    (111, N'SuperUser', '2020-10-15T21:46:30.5557199+02:00', 111, 1),
    (110, N'SuperUser', '2020-10-15T21:46:30.5557198+02:00', 110, 1),
    (109, N'SuperUser', '2020-10-15T21:46:30.5557196+02:00', 109, 1),
    (108, N'SuperUser', '2020-10-15T21:46:30.5557194+02:00', 108, 1),
    (107, N'SuperUser', '2020-10-15T21:46:30.5557193+02:00', 107, 1),
    (106, N'SuperUser', '2020-10-15T21:46:30.5557191+02:00', 106, 1),
    (89, N'SuperUser', '2020-10-15T21:46:30.5557163+02:00', 89, 1),
    (105, N'SuperUser', '2020-10-15T21:46:30.5557189+02:00', 105, 1),
    (103, N'SuperUser', '2020-10-15T21:46:30.5557186+02:00', 103, 1),
    (102, N'SuperUser', '2020-10-15T21:46:30.5557184+02:00', 102, 1),
    (101, N'SuperUser', '2020-10-15T21:46:30.5557183+02:00', 101, 1),
    (100, N'SuperUser', '2020-10-15T21:46:30.5557181+02:00', 100, 1),
    (99, N'SuperUser', '2020-10-15T21:46:30.5557179+02:00', 99, 1),
    (98, N'SuperUser', '2020-10-15T21:46:30.5557178+02:00', 98, 1),
    (97, N'SuperUser', '2020-10-15T21:46:30.5557176+02:00', 97, 1),
    (96, N'SuperUser', '2020-10-15T21:46:30.5557174+02:00', 96, 1),
    (95, N'SuperUser', '2020-10-15T21:46:30.5557173+02:00', 95, 1),
    (94, N'SuperUser', '2020-10-15T21:46:30.5557171+02:00', 94, 1),
    (92, N'SuperUser', '2020-10-15T21:46:30.5557168+02:00', 92, 1),
    (91, N'SuperUser', '2020-10-15T21:46:30.5557166+02:00', 91, 1),
    (104, N'SuperUser', '2020-10-15T21:46:30.5557188+02:00', 104, 1),
    (59, N'SuperUser', '2020-10-15T21:46:30.5557111+02:00', 59, 1),
    (31, N'SuperUser', '2020-10-15T21:46:30.5557059+02:00', 31, 1),
    (57, N'SuperUser', '2020-10-15T21:46:30.5557107+02:00', 57, 1),
    (26, N'SuperUser', '2020-10-15T21:46:30.5556948+02:00', 26, 1),
    (25, N'SuperUser', '2020-10-15T21:46:30.5556947+02:00', 25, 1),
    (58, N'SuperUser', '2020-10-15T21:46:30.5557109+02:00', 58, 1),
    (23, N'SuperUser', '2020-10-15T21:46:30.5556943+02:00', 23, 1),
    (22, N'SuperUser', '2020-10-15T21:46:30.5556942+02:00', 22, 1),
    (21, N'SuperUser', '2020-10-15T21:46:30.5556940+02:00', 21, 1),
    (20, N'SuperUser', '2020-10-15T21:46:30.5556938+02:00', 20, 1),
    (19, N'SuperUser', '2020-10-15T21:46:30.5556937+02:00', 19, 1),
    (18, N'SuperUser', '2020-10-15T21:46:30.5556935+02:00', 18, 1),
    (17, N'SuperUser', '2020-10-15T21:46:30.5556932+02:00', 17, 1),
    (16, N'SuperUser', '2020-10-15T21:46:30.5556930+02:00', 16, 1),
    (15, N'SuperUser', '2020-10-15T21:46:30.5556929+02:00', 15, 1),
    (27, N'SuperUser', '2020-10-15T21:46:30.5556950+02:00', 27, 1),
    (14, N'SuperUser', '2020-10-15T21:46:30.5556927+02:00', 14, 1),
    (12, N'SuperUser', '2020-10-15T21:46:30.5556924+02:00', 12, 1),
    (11, N'SuperUser', '2020-10-15T21:46:30.5556922+02:00', 11, 1),
    (10, N'SuperUser', '2020-10-15T21:46:30.5556920+02:00', 10, 1),
    (9, N'SuperUser', '2020-10-15T21:46:30.5556918+02:00', 9, 1),
    (8, N'SuperUser', '2020-10-15T21:46:30.5556916+02:00', 8, 1),
    (7, N'SuperUser', '2020-10-15T21:46:30.5556914+02:00', 7, 1),
    (6, N'SuperUser', '2020-10-15T21:46:30.5556913+02:00', 6, 1),
    (5, N'SuperUser', '2020-10-15T21:46:30.5556908+02:00', 5, 1),
    (4, N'SuperUser', '2020-10-15T21:46:30.5556906+02:00', 4, 1),
    (3, N'SuperUser', '2020-10-15T21:46:30.5556905+02:00', 3, 1),
    (2, N'SuperUser', '2020-10-15T21:46:30.5556902+02:00', 2, 1),
    (1, N'SuperUser', '2020-10-15T21:46:30.5556791+02:00', 1, 1),
    (13, N'SuperUser', '2020-10-15T21:46:30.5556925+02:00', 13, 1),
    (28, N'SuperUser', '2020-10-15T21:46:30.5556952+02:00', 28, 1),
    (24, N'SuperUser', '2020-10-15T21:46:30.5556945+02:00', 24, 1),
    (30, N'SuperUser', '2020-10-15T21:46:30.5556955+02:00', 30, 1),
    (56, N'SuperUser', '2020-10-15T21:46:30.5557106+02:00', 56, 1),
    (55, N'SuperUser', '2020-10-15T21:46:30.5557104+02:00', 55, 1),
    (54, N'SuperUser', '2020-10-15T21:46:30.5557102+02:00', 54, 1),
    (53, N'SuperUser', '2020-10-15T21:46:30.5557100+02:00', 53, 1),
    (52, N'SuperUser', '2020-10-15T21:46:30.5557098+02:00', 52, 1),
    (51, N'SuperUser', '2020-10-15T21:46:30.5557097+02:00', 51, 1),
    (50, N'SuperUser', '2020-10-15T21:46:30.5557095+02:00', 50, 1),
    (49, N'SuperUser', '2020-10-15T21:46:30.5557093+02:00', 49, 1),
    (29, N'SuperUser', '2020-10-15T21:46:30.5556953+02:00', 29, 1),
    (47, N'SuperUser', '2020-10-15T21:46:30.5557090+02:00', 47, 1),
    (46, N'SuperUser', '2020-10-15T21:46:30.5557088+02:00', 46, 1),
    (45, N'SuperUser', '2020-10-15T21:46:30.5557087+02:00', 45, 1),
    (44, N'SuperUser', '2020-10-15T21:46:30.5557085+02:00', 44, 1),
    (48, N'SuperUser', '2020-10-15T21:46:30.5557092+02:00', 48, 1),
    (42, N'SuperUser', '2020-10-15T21:46:30.5557082+02:00', 42, 1),
    (43, N'SuperUser', '2020-10-15T21:46:30.5557083+02:00', 43, 1),
    (32, N'SuperUser', '2020-10-15T21:46:30.5557062+02:00', 32, 1),
    (34, N'SuperUser', '2020-10-15T21:46:30.5557068+02:00', 34, 1),
    (35, N'SuperUser', '2020-10-15T21:46:30.5557070+02:00', 35, 1),
    (36, N'SuperUser', '2020-10-15T21:46:30.5557071+02:00', 36, 1),
    (33, N'SuperUser', '2020-10-15T21:46:30.5557064+02:00', 33, 1),
    (38, N'SuperUser', '2020-10-15T21:46:30.5557075+02:00', 38, 1),
    (39, N'SuperUser', '2020-10-15T21:46:30.5557076+02:00', 39, 1),
    (40, N'SuperUser', '2020-10-15T21:46:30.5557078+02:00', 40, 1),
    (41, N'SuperUser', '2020-10-15T21:46:30.5557080+02:00', 41, 1),
    (37, N'SuperUser', '2020-10-15T21:46:30.5557073+02:00', 37, 1);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RolePermissionID', N'LastChangedBy', N'LastChangedDate', N'PermissionID', N'RoleID') AND [object_id] = OBJECT_ID(N'[RolePermissions]'))
        SET IDENTITY_INSERT [RolePermissions] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'TransactionTypeID', N'Code', N'Description', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name', N'TransactionStatusID') AND [object_id] = OBJECT_ID(N'[TransactionType]'))
        SET IDENTITY_INSERT [TransactionType] ON;
    INSERT INTO [TransactionType] ([TransactionTypeID], [Code], [Description], [IsActive], [LastChangedBy], [LastChangedDate], [Name], [TransactionStatusID])
    VALUES (7, N'DEP', NULL, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5611363+02:00', N'Deposit', 1),
    (1, N'PAY', NULL, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5610166+02:00', N'Payment', 1),
    (2, N'(R)', NULL, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5610915+02:00', N'Reversal', 1),
    (3, N'PURCH', NULL, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5611005+02:00', N'Purchase', 1),
    (4, N'SALE', NULL, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5611152+02:00', N'Sales', 1),
    (5, N'RPT', NULL, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5611230+02:00', N'Receipts', 1),
    (6, N'RECON', NULL, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5611302+02:00', N'Recon', 1),
    (8, N'FEE', NULL, CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5611422+02:00', N'Fee', 1);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'TransactionTypeID', N'Code', N'Description', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'Name', N'TransactionStatusID') AND [object_id] = OBJECT_ID(N'[TransactionType]'))
        SET IDENTITY_INSERT [TransactionType] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'UserID', N'EmailAddress', N'FirstName', N'IDNumber', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'LastName', N'Password', N'PasswordExpiryDate', N'UserName', N'UserTypeID') AND [object_id] = OBJECT_ID(N'[Users]'))
        SET IDENTITY_INSERT [Users] ON;
    INSERT INTO [Users] ([UserID], [EmailAddress], [FirstName], [IDNumber], [IsActive], [LastChangedBy], [LastChangedDate], [LastName], [Password], [PasswordExpiryDate], [UserName], [UserTypeID])
    VALUES (2, N'carochire89@gmail.com', N'John', N'0000000000000', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5864104+02:00', N'Jarani', N'YWRtaW4=', '0001-01-01T00:00:00.0000000', N'Employer', 2),
    (1, N'carochire@gmail.com', N'Wadzanai', N'8904161200188', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5836824+02:00', N'Chirenje', N'YWRtaW4=', '0001-01-01T00:00:00.0000000', N'SuperUser', 1),
    (3, N'carolinesolutions89@gmail.com', N'Ndini', N'1111111111111', CAST(1 AS bit), N'SuperUser', '2020-10-15T21:46:30.5864754+02:00', N'Ndadaro', N'YWRtaW4=', '0001-01-01T00:00:00.0000000', N'Employee', 3);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'UserID', N'EmailAddress', N'FirstName', N'IDNumber', N'IsActive', N'LastChangedBy', N'LastChangedDate', N'LastName', N'Password', N'PasswordExpiryDate', N'UserName', N'UserTypeID') AND [object_id] = OBJECT_ID(N'[Users]'))
        SET IDENTITY_INSERT [Users] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleMenuID', N'LastChangedBy', N'LastChangedDate', N'MenuID', N'RoleID') AND [object_id] = OBJECT_ID(N'[RoleMenus]'))
        SET IDENTITY_INSERT [RoleMenus] ON;
    INSERT INTO [RoleMenus] ([RoleMenuID], [LastChangedBy], [LastChangedDate], [MenuID], [RoleID])
    VALUES (1, N'SuperUser', '2020-10-15T21:46:30.6081857+02:00', 1, 1),
    (22, N'SuperUser', '2020-10-15T21:46:30.6081965+02:00', 9999, 1),
    (21, N'SuperUser', '2020-10-15T21:46:30.6081963+02:00', 9998, 1),
    (20, N'SuperUser', '2020-10-15T21:46:30.6081962+02:00', 20, 1),
    (19, N'SuperUser', '2020-10-15T21:46:30.6081960+02:00', 19, 1),
    (18, N'SuperUser', '2020-10-15T21:46:30.6081959+02:00', 18, 1),
    (17, N'SuperUser', '2020-10-15T21:46:30.6081956+02:00', 17, 1),
    (16, N'SuperUser', '2020-10-15T21:46:30.6081955+02:00', 16, 1),
    (15, N'SuperUser', '2020-10-15T21:46:30.6081953+02:00', 15, 1),
    (14, N'SuperUser', '2020-10-15T21:46:30.6081952+02:00', 14, 1),
    (13, N'SuperUser', '2020-10-15T21:46:30.6081950+02:00', 13, 1),
    (12, N'SuperUser', '2020-10-15T21:46:30.6081949+02:00', 12, 1),
    (11, N'SuperUser', '2020-10-15T21:46:30.6081947+02:00', 11, 1),
    (10, N'SuperUser', '2020-10-15T21:46:30.6081946+02:00', 10, 1),
    (9, N'SuperUser', '2020-10-15T21:46:30.6081943+02:00', 9, 1),
    (8, N'SuperUser', '2020-10-15T21:46:30.6081942+02:00', 8, 1),
    (7, N'SuperUser', '2020-10-15T21:46:30.6081940+02:00', 7, 1),
    (6, N'SuperUser', '2020-10-15T21:46:30.6081939+02:00', 6, 1),
    (5, N'SuperUser', '2020-10-15T21:46:30.6081935+02:00', 5, 1),
    (4, N'SuperUser', '2020-10-15T21:46:30.6081933+02:00', 4, 1),
    (3, N'SuperUser', '2020-10-15T21:46:30.6081932+02:00', 3, 1),
    (2, N'SuperUser', '2020-10-15T21:46:30.6081929+02:00', 2, 1);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleMenuID', N'LastChangedBy', N'LastChangedDate', N'MenuID', N'RoleID') AND [object_id] = OBJECT_ID(N'[RoleMenus]'))
        SET IDENTITY_INSERT [RoleMenus] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'UserID', N'RoleID', N'LastChangedBy', N'LastChangedDate', N'UserRoleID') AND [object_id] = OBJECT_ID(N'[UserRoles]'))
        SET IDENTITY_INSERT [UserRoles] ON;
    INSERT INTO [UserRoles] ([UserID], [RoleID], [LastChangedBy], [LastChangedDate], [UserRoleID])
    VALUES (1, 1, N'SuperUser', '2020-10-15T21:46:30.5945184+02:00', 1),
    (2, 3, N'SuperUser', '2020-10-15T21:46:30.5945248+02:00', 2);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'UserID', N'RoleID', N'LastChangedBy', N'LastChangedDate', N'UserRoleID') AND [object_id] = OBJECT_ID(N'[UserRoles]'))
        SET IDENTITY_INSERT [UserRoles] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_AssertCategories_AssertID] ON [AssertCategories] ([AssertID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_BankAccounts_BankAccountTypeID] ON [BankAccounts] ([BankAccountTypeID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_BankAccounts_CurrencyID] ON [BankAccounts] ([CurrencyID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ClientContacts_ClientID] ON [ClientContacts] ([ClientID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ClientContacts_ContactTypeID] ON [ClientContacts] ([ContactTypeID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ClientContacts_RelationshipTypeID] ON [ClientContacts] ([RelationshipTypeID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ClientCourses_ClientID] ON [ClientCourses] ([ClientID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ClientCourses_CourseID] ON [ClientCourses] ([CourseID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ClientDeductions_ClientID] ON [ClientDeductions] ([ClientID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ClientDeductions_ProductID] ON [ClientDeductions] ([ProductID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ClientDependents_ClientID] ON [ClientDependents] ([ClientID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ClientDocuments_ClientID] ON [ClientDocuments] ([ClientID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ClientDocuments_DocumentTypeID] ON [ClientDocuments] ([DocumentTypeID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ClientFees_ClientID] ON [ClientFees] ([ClientID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ClientFees_CourseFeeID] ON [ClientFees] ([CourseFeeID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ClientFees_ProductFeeID] ON [ClientFees] ([ProductFeeID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ClientMedicalDetails_ClientID] ON [ClientMedicalDetails] ([ClientID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ClientNotes_ClientID] ON [ClientNotes] ([ClientID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ClientNotes_UserTypeID] ON [ClientNotes] ([UserTypeID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ClientOccupationHistory_ClientID] ON [ClientOccupationHistory] ([ClientID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ClientProducts_ClientID] ON [ClientProducts] ([ClientID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ClientProducts_ProductID] ON [ClientProducts] ([ProductID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_Clients_CountryID] ON [Clients] ([CountryID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_Clients_DepartmentID] ON [Clients] ([DepartmentID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_Clients_GenderID] ON [Clients] ([GenderID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_Clients_ProductID1] ON [Clients] ([ProductID1]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ClientTranscripts_ClientCourseID] ON [ClientTranscripts] ([ClientCourseID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_Companies_CountryID] ON [Companies] ([CountryID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_CourseFeeHistory_CourseID] ON [CourseFeeHistory] ([CourseID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_CourseFeeHistory_FrequencyID] ON [CourseFeeHistory] ([FrequencyID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_CourseFees_CourseID] ON [CourseFees] ([CourseID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_CourseFees_FrequencyID] ON [CourseFees] ([FrequencyID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_CourseOutlines_CourseID] ON [CourseOutlines] ([CourseID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_CustomSettings_CustomSettingTypeID] ON [CustomSettings] ([CustomSettingTypeID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_CustomSettings_CustomVariableTypeID] ON [CustomSettings] ([CustomVariableTypeID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_DocumentTypes_DocumentFormatID] ON [DocumentTypes] ([DocumentFormatID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_EmailTemplates_EmailTypeID] ON [EmailTemplates] ([EmailTypeID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_EmailTemplates_PriorityRankID] ON [EmailTemplates] ([PriorityRankID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_Menus_MenuGroupID] ON [Menus] ([MenuGroupID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_NoticeBoard_PriorityRankID] ON [NoticeBoard] ([PriorityRankID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ProductAssertCategory_AssertCategoryID] ON [ProductAssertCategory] ([AssertCategoryID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ProductAssertCategory_ProductID] ON [ProductAssertCategory] ([ProductID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ProductAsserts_AssertID] ON [ProductAsserts] ([AssertID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ProductAsserts_ProductID] ON [ProductAsserts] ([ProductID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ProductFeeHistory_FrequencyID] ON [ProductFeeHistory] ([FrequencyID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ProductFeeHistory_ProductID] ON [ProductFeeHistory] ([ProductID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ProductFees_FrequencyID] ON [ProductFees] ([FrequencyID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ProductFees_ProductID] ON [ProductFees] ([ProductID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_ProductHistory_ProductID] ON [ProductHistory] ([ProductID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_Products_CompanyID] ON [Products] ([CompanyID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_Products_CountryID] ON [Products] ([CountryID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_RoleMenus_MenuID] ON [RoleMenus] ([MenuID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_RoleMenus_RoleID] ON [RoleMenus] ([RoleID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_RolePermissions_PermissionID] ON [RolePermissions] ([PermissionID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_RolePermissions_RoleID] ON [RolePermissions] ([RoleID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_Transactions_BankAccountID] ON [Transactions] ([BankAccountID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_Transactions_ClientID] ON [Transactions] ([ClientID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_Transactions_CourseID] ON [Transactions] ([CourseID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_Transactions_PaymentStatusID] ON [Transactions] ([PaymentStatusID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_Transactions_ProductID] ON [Transactions] ([ProductID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_Transactions_TransactionTypeID] ON [Transactions] ([TransactionTypeID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_TransactionType_TransactionStatusID] ON [TransactionType] ([TransactionStatusID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_UserAuthenticationCodes_UserID] ON [UserAuthenticationCodes] ([UserID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_UserRoles_RoleID] ON [UserRoles] ([RoleID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    CREATE INDEX [IX_Users_UserTypeID] ON [Users] ([UserTypeID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015194631_InitialMigration')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20201015194631_InitialMigration', N'3.1.8');
END;

GO

