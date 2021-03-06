USE [master]
GO
/****** Object:  Database [SC_EduCore_V1]    Script Date: 2022/04/09 18:22:53 ******/
CREATE DATABASE [SC_EduCore_V1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SC_EduCore_V1', FILENAME = N'/var/opt/mssql/data/SC_EduCore_V1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SC_EduCore_V1_log', FILENAME = N'/var/opt/mssql/data/SC_EduCore_V1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SC_EduCore_V1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SC_EduCore_V1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SC_EduCore_V1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SC_EduCore_V1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SC_EduCore_V1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SC_EduCore_V1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SC_EduCore_V1] SET ARITHABORT OFF 
GO
ALTER DATABASE [SC_EduCore_V1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SC_EduCore_V1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SC_EduCore_V1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SC_EduCore_V1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SC_EduCore_V1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SC_EduCore_V1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SC_EduCore_V1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SC_EduCore_V1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SC_EduCore_V1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SC_EduCore_V1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SC_EduCore_V1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SC_EduCore_V1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SC_EduCore_V1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SC_EduCore_V1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SC_EduCore_V1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SC_EduCore_V1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SC_EduCore_V1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SC_EduCore_V1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SC_EduCore_V1] SET  MULTI_USER 
GO
ALTER DATABASE [SC_EduCore_V1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SC_EduCore_V1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SC_EduCore_V1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SC_EduCore_V1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SC_EduCore_V1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SC_EduCore_V1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SC_EduCore_V1', N'ON'
GO
ALTER DATABASE [SC_EduCore_V1] SET QUERY_STORE = OFF
GO
USE [SC_EduCore_V1]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 2022/04/09 18:22:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[LastChangedBy] [varchar](50) NULL,
	[LastChangedDate] [datetime] NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fees]    Script Date: 2022/04/09 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fees](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedBy] [varchar](50) NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[LastChangedBy] [varchar](50) NULL,
	[LastChangedDate] [datetime] NULL,
 CONSTRAINT [PK_Fees] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FiscalYears]    Script Date: 2022/04/09 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FiscalYears](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[LastChangedBy] [varchar](50) NULL,
	[LastChangedDate] [datetime] NULL,
 CONSTRAINT [PK_FiscalYears] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoanBeneficiary]    Script Date: 2022/04/09 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoanBeneficiary](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LoanID] [int] NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Surname] [varchar](100) NOT NULL,
	[IDNumber] [varchar](50) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[RelationshipID] [int] NOT NULL,
	[SubEntityID] [int] NOT NULL,
	[CreatedBy] [varchar](50) NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[LastChangedBy] [varchar](50) NULL,
	[LastChangedDate] [datetime] NULL,
 CONSTRAINT [PK_LoanBeneficiary] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoanCollections]    Script Date: 2022/04/09 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoanCollections](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LoanID] [int] NOT NULL,
	[LoanFeeID] [int] NOT NULL,
	[Amount] [decimal](18, 0) NOT NULL,
	[CreatedBy] [varchar](50) NOT NULL,
	[DateCreated] [datetime] NOT NULL,
 CONSTRAINT [PK_LoanCollections] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoanFees]    Script Date: 2022/04/09 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoanFees](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[LastChangedBy] [varchar](50) NULL,
	[LastChangedDate] [datetime] NULL,
 CONSTRAINT [PK_LoanFees] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoanFinances]    Script Date: 2022/04/09 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoanFinances](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LoanID] [int] NOT NULL,
	[MaturityDate] [date] NOT NULL,
	[ValueDate] [date] NOT NULL,
	[ApplicationFee] [decimal](18, 0) NOT NULL,
	[Deposit] [decimal](18, 0) NOT NULL,
	[EffectiveDeposit] [decimal](18, 0) NOT NULL,
	[FeesReq] [decimal](18, 0) NOT NULL,
	[FinanceAmount] [decimal](18, 0) NOT NULL,
	[FxFixing] [decimal](18, 0) NOT NULL,
	[Installment] [decimal](18, 0) NOT NULL,
	[InterestRate] [decimal](18, 0) NULL,
	[MinimumUpfront] [decimal](18, 0) NOT NULL,
	[Upfront] [decimal](18, 0) NOT NULL,
	[CreatedBy] [varchar](50) NOT NULL,
	[DateCreated] [datetime] NOT NULL,
 CONSTRAINT [PK_LoanFinances] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loans]    Script Date: 2022/04/09 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loans](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NOT NULL,
	[LoanNo] [varchar](50) NULL,
	[ContraID] [int] NULL,
	[ProductID] [int] NOT NULL,
	[LoanUseID] [int] NOT NULL,
	[LoanTypeID] [int] NULL,
	[LoanSectorID] [int] NULL,
	[Duration] [int] NOT NULL,
	[FiscalID] [int] NOT NULL,
	[CurrencyID] [int] NOT NULL,
	[LoanStatusID] [int] NOT NULL,
	[RejectionReason] [varchar](500) NULL,
	[CreatedBy] [varchar](50) NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[ApprovedBy] [varchar](50) NULL,
	[DateApproved] [datetime] NULL,
	[LastChangedBy] [varchar](50) NULL,
	[LastChangedDate] [datetime] NULL,
 CONSTRAINT [PK_Loans] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoanSchedules]    Script Date: 2022/04/09 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoanSchedules](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LoanID] [int] NOT NULL,
	[LedgerNo] [int] NOT NULL,
	[IsPaid] [bit] NOT NULL,
	[CreatedBy] [varchar](50) NOT NULL,
	[DateCreated] [datetime] NOT NULL,
 CONSTRAINT [PK_LoanSchedules] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoanStatus]    Script Date: 2022/04/09 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoanStatus](
	[ID] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_LoanStatus] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoanTransactionDetails]    Script Date: 2022/04/09 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoanTransactionDetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LoanTransactionID] [int] NOT NULL,
	[TransactionTypeID] [int] NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_LoanTransactionDetails] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoanTransactions]    Script Date: 2022/04/09 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoanTransactions](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NOT NULL,
	[LoanID] [int] NOT NULL,
	[TransactionStatusID] [int] NOT NULL,
	[FiscalID] [int] NOT NULL,
	[ContraID] [int] NULL,
	[LedgerNo] [int] NOT NULL,
	[LoanTransferID] [int] NULL,
	[DateReceived] [datetime] NOT NULL,
	[CurrencyID] [int] NOT NULL,
	[Remarks] [varchar](50) NULL,
	[CapturedBy] [varchar](50) NOT NULL,
	[TransactionDate] [datetime] NOT NULL,
	[SystemCaptureDate] [datetime] NOT NULL,
 CONSTRAINT [PK_LoanTransactions] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoanTransactionStatus]    Script Date: 2022/04/09 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoanTransactionStatus](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_LoanTransactionStatus] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoanTransactionTypes]    Script Date: 2022/04/09 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoanTransactionTypes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_LoanTransactionTypes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoanTypes]    Script Date: 2022/04/09 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoanTypes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[LastChangedBy] [varchar](50) NULL,
	[LastChangedDate] [datetime] NULL,
 CONSTRAINT [PK_LoanTypes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoanUses]    Script Date: 2022/04/09 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoanUses](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[LastChangedBy] [varchar](50) NULL,
	[LastChangedDate] [datetime] NULL,
 CONSTRAINT [PK_LoanUses] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PenaltyMarkers]    Script Date: 2022/04/09 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PenaltyMarkers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedBy] [varchar](50) NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[LastChangedBy] [varchar](50) NULL,
	[LastChangedDate] [datetime] NULL,
 CONSTRAINT [PK_PenaltyMarkers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductComputations]    Script Date: 2022/04/09 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductComputations](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[PluginName] [varchar](50) NOT NULL,
	[Method] [varchar](50) NOT NULL,
	[CreatedBy] [varchar](50) NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[LastChangedBy] [varchar](50) NULL,
	[LastChangedDate] [datetime] NULL,
 CONSTRAINT [PK_ProductComputations] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductDiscounts]    Script Date: 2022/04/09 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductDiscounts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[DiscountEligibleDays] [int] NOT NULL,
	[DiscountLegibleOnInstalllment] [int] NOT NULL,
	[DiscountPercentage] [decimal](18, 0) NOT NULL,
	[Amount] [decimal](18, 0) NOT NULL,
	[LastChangedBy] [varchar](50) NOT NULL,
	[LastChangedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ProductDiscounts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductFees]    Script Date: 2022/04/09 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductFees](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[FeeID] [int] NOT NULL,
	[Amount] [decimal](18, 0) NOT NULL,
	[LastChangedBy] [varchar](50) NOT NULL,
	[LastChangedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ProductFees] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductPenalties]    Script Date: 2022/04/09 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductPenalties](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[MarkerID] [int] NOT NULL,
	[Amount] [decimal](18, 0) NOT NULL,
	[LastChangedBy] [varchar](50) NOT NULL,
	[LastChangedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ProductPenalties] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 2022/04/09 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[IsLegibleForPenalties] [bit] NOT NULL,
	[ComputationalTypeID] [int] NOT NULL,
	[CurrencyID] [int] NOT NULL,
	[CreatedBy] [varchar](50) NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[LastChangedBy] [varchar](50) NULL,
	[LastChangedDate] [datetime] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sectors]    Script Date: 2022/04/09 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sectors](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Code] [varchar](50) NULL,
	[IsActive] [bit] NOT NULL,
	[LastChangedBy] [varchar](50) NULL,
	[LastChangedDate] [datetime] NULL,
 CONSTRAINT [PK_Sectors] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubCategories]    Script Date: 2022/04/09 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubCategories](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[LastChangedBy] [varchar](50) NULL,
	[LastChangedDate] [datetime] NULL,
 CONSTRAINT [PK_SubCategories] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubEntities]    Script Date: 2022/04/09 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubEntities](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SubCategoryID] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[LastChangedBy] [varchar](50) NULL,
	[LastChangedDate] [datetime] NULL,
 CONSTRAINT [PK_SubEntities] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([ID], [Name], [IsActive], [LastChangedBy], [LastChangedDate]) VALUES (1, N'University', 1, N'test', CAST(N'2021-04-25T20:31:54.560' AS DateTime))
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Fees] ON 

INSERT [dbo].[Fees] ([ID], [Name], [IsActive], [CreatedBy], [DateCreated], [LastChangedBy], [LastChangedDate]) VALUES (1, N'Deposit', 1, N'scSuperUser', CAST(N'2021-04-19T19:29:35.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Fees] ([ID], [Name], [IsActive], [CreatedBy], [DateCreated], [LastChangedBy], [LastChangedDate]) VALUES (2, N'Interest', 1, N'scSuperUser', CAST(N'2021-04-19T19:29:35.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Fees] ([ID], [Name], [IsActive], [CreatedBy], [DateCreated], [LastChangedBy], [LastChangedDate]) VALUES (3, N'Documentation Fee', 1, N'scSuperUser', CAST(N'2021-04-19T19:29:35.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Fees] ([ID], [Name], [IsActive], [CreatedBy], [DateCreated], [LastChangedBy], [LastChangedDate]) VALUES (4, N'Fixed Rate', 1, N'scSuperUser', CAST(N'2021-04-19T19:29:35.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Fees] ([ID], [Name], [IsActive], [CreatedBy], [DateCreated], [LastChangedBy], [LastChangedDate]) VALUES (5, N'Minimum Charge', 1, N'scSuperUser', CAST(N'2021-04-19T19:29:35.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Fees] ([ID], [Name], [IsActive], [CreatedBy], [DateCreated], [LastChangedBy], [LastChangedDate]) VALUES (6, N'Principal', 1, N'scSuperUser', CAST(N'2021-04-19T19:29:35.000' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Fees] OFF
GO
SET IDENTITY_INSERT [dbo].[FiscalYears] ON 

INSERT [dbo].[FiscalYears] ([ID], [Name], [IsActive], [LastChangedBy], [LastChangedDate]) VALUES (1, N'2021', 1, N'sc', CAST(N'2020-01-02T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[FiscalYears] OFF
GO
SET IDENTITY_INSERT [dbo].[LoanBeneficiary] ON 

INSERT [dbo].[LoanBeneficiary] ([ID], [LoanID], [Name], [Surname], [IDNumber], [DateOfBirth], [RelationshipID], [SubEntityID], [CreatedBy], [DateCreated], [LastChangedBy], [LastChangedDate]) VALUES (1, 2, N'ccBeneficiary', N'Beneficiary', N'123456', CAST(N'2020-05-03' AS Date), 1, 1, N'ccTest', CAST(N'2021-06-13T13:13:33.317' AS DateTime), NULL, NULL)
INSERT [dbo].[LoanBeneficiary] ([ID], [LoanID], [Name], [Surname], [IDNumber], [DateOfBirth], [RelationshipID], [SubEntityID], [CreatedBy], [DateCreated], [LastChangedBy], [LastChangedDate]) VALUES (2, 5, N'ccBeneficiary', N'Beneficiary', N'123456', CAST(N'2020-05-03' AS Date), 1, 1, N'ccTest', CAST(N'2021-06-13T13:34:52.370' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[LoanBeneficiary] OFF
GO
SET IDENTITY_INSERT [dbo].[LoanFinances] ON 

INSERT [dbo].[LoanFinances] ([ID], [LoanID], [MaturityDate], [ValueDate], [ApplicationFee], [Deposit], [EffectiveDeposit], [FeesReq], [FinanceAmount], [FxFixing], [Installment], [InterestRate], [MinimumUpfront], [Upfront], [CreatedBy], [DateCreated]) VALUES (1, 2, CAST(N'2021-06-13' AS Date), CAST(N'2021-06-13' AS Date), CAST(20 AS Decimal(18, 0)), CAST(30 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(60 AS Decimal(18, 0)), CAST(70 AS Decimal(18, 0)), CAST(80 AS Decimal(18, 0)), CAST(90 AS Decimal(18, 0)), CAST(100 AS Decimal(18, 0)), CAST(110 AS Decimal(18, 0)), N'ccTest', CAST(N'2021-06-13T13:13:38.210' AS DateTime))
INSERT [dbo].[LoanFinances] ([ID], [LoanID], [MaturityDate], [ValueDate], [ApplicationFee], [Deposit], [EffectiveDeposit], [FeesReq], [FinanceAmount], [FxFixing], [Installment], [InterestRate], [MinimumUpfront], [Upfront], [CreatedBy], [DateCreated]) VALUES (2, 5, CAST(N'2021-06-13' AS Date), CAST(N'2021-06-13' AS Date), CAST(20 AS Decimal(18, 0)), CAST(30 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(60 AS Decimal(18, 0)), CAST(70 AS Decimal(18, 0)), CAST(80 AS Decimal(18, 0)), CAST(90 AS Decimal(18, 0)), CAST(100 AS Decimal(18, 0)), CAST(110 AS Decimal(18, 0)), N'ccTest', CAST(N'2021-06-13T13:34:56.683' AS DateTime))
SET IDENTITY_INSERT [dbo].[LoanFinances] OFF
GO
SET IDENTITY_INSERT [dbo].[Loans] ON 

INSERT [dbo].[Loans] ([ID], [ClientID], [LoanNo], [ContraID], [ProductID], [LoanUseID], [LoanTypeID], [LoanSectorID], [Duration], [FiscalID], [CurrencyID], [LoanStatusID], [RejectionReason], [CreatedBy], [DateCreated], [ApprovedBy], [DateApproved], [LastChangedBy], [LastChangedDate]) VALUES (2, 3, NULL, 0, 3, 1, 1, 1, 3, 1, 1, 1, N'string', N'ccTest', CAST(N'2021-06-13T09:40:58.273' AS DateTime), N'string', CAST(N'2021-06-13T09:40:58.273' AS DateTime), N'string', CAST(N'2021-06-13T13:12:56.083' AS DateTime))
INSERT [dbo].[Loans] ([ID], [ClientID], [LoanNo], [ContraID], [ProductID], [LoanUseID], [LoanTypeID], [LoanSectorID], [Duration], [FiscalID], [CurrencyID], [LoanStatusID], [RejectionReason], [CreatedBy], [DateCreated], [ApprovedBy], [DateApproved], [LastChangedBy], [LastChangedDate]) VALUES (3, 3, NULL, 0, 3, 1, 1, 1, 3, 1, 1, 1, N'string', N'ccTest', CAST(N'2021-06-13T09:40:58.273' AS DateTime), N'string', CAST(N'2021-06-13T09:40:58.273' AS DateTime), N'string', CAST(N'2021-06-13T13:26:45.263' AS DateTime))
INSERT [dbo].[Loans] ([ID], [ClientID], [LoanNo], [ContraID], [ProductID], [LoanUseID], [LoanTypeID], [LoanSectorID], [Duration], [FiscalID], [CurrencyID], [LoanStatusID], [RejectionReason], [CreatedBy], [DateCreated], [ApprovedBy], [DateApproved], [LastChangedBy], [LastChangedDate]) VALUES (4, 3, NULL, 0, 3, 1, 1, 1, 3, 1, 1, 1, N'string', N'ccTest', CAST(N'2021-06-13T09:40:58.273' AS DateTime), N'string', CAST(N'2021-06-13T09:40:58.273' AS DateTime), N'string', CAST(N'2021-06-13T13:28:51.957' AS DateTime))
INSERT [dbo].[Loans] ([ID], [ClientID], [LoanNo], [ContraID], [ProductID], [LoanUseID], [LoanTypeID], [LoanSectorID], [Duration], [FiscalID], [CurrencyID], [LoanStatusID], [RejectionReason], [CreatedBy], [DateCreated], [ApprovedBy], [DateApproved], [LastChangedBy], [LastChangedDate]) VALUES (5, 3, NULL, 0, 3, 1, 1, 1, 3, 1, 1, 1, N'string', N'ccTest', CAST(N'2021-06-13T09:40:58.273' AS DateTime), N'string', CAST(N'2021-06-13T09:40:58.273' AS DateTime), N'string', CAST(N'2021-06-13T13:34:15.893' AS DateTime))
SET IDENTITY_INSERT [dbo].[Loans] OFF
GO
SET IDENTITY_INSERT [dbo].[LoanSchedules] ON 

INSERT [dbo].[LoanSchedules] ([ID], [LoanID], [LedgerNo], [IsPaid], [CreatedBy], [DateCreated]) VALUES (1, 2, 1, 0, N'ccTest', CAST(N'2021-06-13T13:13:40.730' AS DateTime))
INSERT [dbo].[LoanSchedules] ([ID], [LoanID], [LedgerNo], [IsPaid], [CreatedBy], [DateCreated]) VALUES (2, 2, 2, 0, N'ccTest', CAST(N'2021-06-13T13:13:40.760' AS DateTime))
INSERT [dbo].[LoanSchedules] ([ID], [LoanID], [LedgerNo], [IsPaid], [CreatedBy], [DateCreated]) VALUES (3, 2, 3, 0, N'ccTest', CAST(N'2021-06-13T13:13:40.760' AS DateTime))
INSERT [dbo].[LoanSchedules] ([ID], [LoanID], [LedgerNo], [IsPaid], [CreatedBy], [DateCreated]) VALUES (4, 5, 1, 0, N'ccTest', CAST(N'2021-06-13T13:35:14.700' AS DateTime))
INSERT [dbo].[LoanSchedules] ([ID], [LoanID], [LedgerNo], [IsPaid], [CreatedBy], [DateCreated]) VALUES (5, 5, 2, 0, N'ccTest', CAST(N'2021-06-13T13:35:17.323' AS DateTime))
INSERT [dbo].[LoanSchedules] ([ID], [LoanID], [LedgerNo], [IsPaid], [CreatedBy], [DateCreated]) VALUES (6, 5, 3, 0, N'ccTest', CAST(N'2021-06-13T13:35:19.973' AS DateTime))
SET IDENTITY_INSERT [dbo].[LoanSchedules] OFF
GO
INSERT [dbo].[LoanStatus] ([ID], [Name]) VALUES (-11, N'Rejected')
INSERT [dbo].[LoanStatus] ([ID], [Name]) VALUES (0, N'Closed')
INSERT [dbo].[LoanStatus] ([ID], [Name]) VALUES (1, N'Active')
INSERT [dbo].[LoanStatus] ([ID], [Name]) VALUES (10, N'Awaiting Approval')
GO
SET IDENTITY_INSERT [dbo].[LoanTransactionDetails] ON 

INSERT [dbo].[LoanTransactionDetails] ([ID], [LoanTransactionID], [TransactionTypeID], [Amount]) VALUES (1, 1, 1, CAST(400.00 AS Decimal(18, 2)))
INSERT [dbo].[LoanTransactionDetails] ([ID], [LoanTransactionID], [TransactionTypeID], [Amount]) VALUES (2, 2, 1, CAST(600.00 AS Decimal(18, 2)))
INSERT [dbo].[LoanTransactionDetails] ([ID], [LoanTransactionID], [TransactionTypeID], [Amount]) VALUES (3, 3, 1, CAST(7777.77 AS Decimal(18, 2)))
INSERT [dbo].[LoanTransactionDetails] ([ID], [LoanTransactionID], [TransactionTypeID], [Amount]) VALUES (4, 10, 1, CAST(-7777.77 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[LoanTransactionDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[LoanTransactions] ON 

INSERT [dbo].[LoanTransactions] ([ID], [ClientID], [LoanID], [TransactionStatusID], [FiscalID], [ContraID], [LedgerNo], [LoanTransferID], [DateReceived], [CurrencyID], [Remarks], [CapturedBy], [TransactionDate], [SystemCaptureDate]) VALUES (1, 0, 3, 1, 1, NULL, 1, 0, CAST(N'2021-06-13T16:34:45.130' AS DateTime), 144, N'payment', N'cc', CAST(N'2021-06-13T16:34:45.130' AS DateTime), CAST(N'2021-06-13T18:55:54.983' AS DateTime))
INSERT [dbo].[LoanTransactions] ([ID], [ClientID], [LoanID], [TransactionStatusID], [FiscalID], [ContraID], [LedgerNo], [LoanTransferID], [DateReceived], [CurrencyID], [Remarks], [CapturedBy], [TransactionDate], [SystemCaptureDate]) VALUES (2, 0, 3, 1, 1, NULL, 1, 0, CAST(N'2021-06-13T16:34:45.130' AS DateTime), 144, N'payment', N'cc', CAST(N'2021-06-13T16:34:45.130' AS DateTime), CAST(N'2021-06-13T18:56:12.777' AS DateTime))
INSERT [dbo].[LoanTransactions] ([ID], [ClientID], [LoanID], [TransactionStatusID], [FiscalID], [ContraID], [LedgerNo], [LoanTransferID], [DateReceived], [CurrencyID], [Remarks], [CapturedBy], [TransactionDate], [SystemCaptureDate]) VALUES (3, 0, 3, 1, 1, NULL, 1, 0, CAST(N'2021-06-13T18:21:01.457' AS DateTime), 144, N'test', N'CC', CAST(N'2021-06-13T18:21:01.457' AS DateTime), CAST(N'2021-06-13T20:21:59.683' AS DateTime))
INSERT [dbo].[LoanTransactions] ([ID], [ClientID], [LoanID], [TransactionStatusID], [FiscalID], [ContraID], [LedgerNo], [LoanTransferID], [DateReceived], [CurrencyID], [Remarks], [CapturedBy], [TransactionDate], [SystemCaptureDate]) VALUES (5, 0, 3, 2, 1, NULL, 1, 0, CAST(N'2021-06-13T18:21:01.457' AS DateTime), 144, N'test', N'cc', CAST(N'2021-06-13T18:21:01.457' AS DateTime), CAST(N'2021-06-13T20:37:33.753' AS DateTime))
INSERT [dbo].[LoanTransactions] ([ID], [ClientID], [LoanID], [TransactionStatusID], [FiscalID], [ContraID], [LedgerNo], [LoanTransferID], [DateReceived], [CurrencyID], [Remarks], [CapturedBy], [TransactionDate], [SystemCaptureDate]) VALUES (6, 0, 3, 2, 1, NULL, 1, 0, CAST(N'2021-06-13T18:21:01.457' AS DateTime), 144, N'test', N'cc', CAST(N'2021-06-13T18:21:01.457' AS DateTime), CAST(N'2021-06-13T20:40:17.860' AS DateTime))
INSERT [dbo].[LoanTransactions] ([ID], [ClientID], [LoanID], [TransactionStatusID], [FiscalID], [ContraID], [LedgerNo], [LoanTransferID], [DateReceived], [CurrencyID], [Remarks], [CapturedBy], [TransactionDate], [SystemCaptureDate]) VALUES (7, 0, 3, 2, 1, NULL, 1, 0, CAST(N'2021-06-13T18:21:01.457' AS DateTime), 144, N'test', N'cc', CAST(N'2021-06-13T18:21:01.457' AS DateTime), CAST(N'2021-06-13T20:47:26.780' AS DateTime))
INSERT [dbo].[LoanTransactions] ([ID], [ClientID], [LoanID], [TransactionStatusID], [FiscalID], [ContraID], [LedgerNo], [LoanTransferID], [DateReceived], [CurrencyID], [Remarks], [CapturedBy], [TransactionDate], [SystemCaptureDate]) VALUES (8, 0, 3, 2, 1, NULL, 1, 0, CAST(N'2021-06-13T18:21:01.457' AS DateTime), 144, N'test', N'cc', CAST(N'2021-06-13T18:21:01.457' AS DateTime), CAST(N'2021-06-13T20:49:40.567' AS DateTime))
INSERT [dbo].[LoanTransactions] ([ID], [ClientID], [LoanID], [TransactionStatusID], [FiscalID], [ContraID], [LedgerNo], [LoanTransferID], [DateReceived], [CurrencyID], [Remarks], [CapturedBy], [TransactionDate], [SystemCaptureDate]) VALUES (9, 0, 3, 2, 1, NULL, 1, 0, CAST(N'2021-06-13T18:21:01.457' AS DateTime), 144, N'test', N'cc', CAST(N'2021-06-13T18:21:01.457' AS DateTime), CAST(N'2021-06-13T20:50:13.707' AS DateTime))
INSERT [dbo].[LoanTransactions] ([ID], [ClientID], [LoanID], [TransactionStatusID], [FiscalID], [ContraID], [LedgerNo], [LoanTransferID], [DateReceived], [CurrencyID], [Remarks], [CapturedBy], [TransactionDate], [SystemCaptureDate]) VALUES (10, 0, 3, 2, 1, NULL, 1, 0, CAST(N'2021-06-13T18:21:01.457' AS DateTime), 144, N'test', N'cc', CAST(N'2021-06-13T18:21:01.457' AS DateTime), CAST(N'2021-06-13T20:53:05.500' AS DateTime))
SET IDENTITY_INSERT [dbo].[LoanTransactions] OFF
GO
SET IDENTITY_INSERT [dbo].[LoanTransactionStatus] ON 

INSERT [dbo].[LoanTransactionStatus] ([ID], [Name]) VALUES (1, N'Payment')
INSERT [dbo].[LoanTransactionStatus] ([ID], [Name]) VALUES (2, N'Reversal')
SET IDENTITY_INSERT [dbo].[LoanTransactionStatus] OFF
GO
SET IDENTITY_INSERT [dbo].[LoanTransactionTypes] ON 

INSERT [dbo].[LoanTransactionTypes] ([ID], [Name]) VALUES (1, N'Collection Fee')
INSERT [dbo].[LoanTransactionTypes] ([ID], [Name]) VALUES (2, N'Documentation Fee')
INSERT [dbo].[LoanTransactionTypes] ([ID], [Name]) VALUES (3, N'Deposit')
INSERT [dbo].[LoanTransactionTypes] ([ID], [Name]) VALUES (4, N'Remittance')
INSERT [dbo].[LoanTransactionTypes] ([ID], [Name]) VALUES (5, N'Discount Credited')
INSERT [dbo].[LoanTransactionTypes] ([ID], [Name]) VALUES (6, N'Discount Reversal')
INSERT [dbo].[LoanTransactionTypes] ([ID], [Name]) VALUES (7, N'Discount')
INSERT [dbo].[LoanTransactionTypes] ([ID], [Name]) VALUES (8, N'Credit Carry Over To Next Loan')
SET IDENTITY_INSERT [dbo].[LoanTransactionTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[LoanTypes] ON 

INSERT [dbo].[LoanTypes] ([ID], [Name], [IsActive], [LastChangedBy], [LastChangedDate]) VALUES (1, N'Test', 1, N'cc', CAST(N'2021-01-01T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[LoanTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[LoanUses] ON 

INSERT [dbo].[LoanUses] ([ID], [Name], [IsActive], [LastChangedBy], [LastChangedDate]) VALUES (1, N'Agriculture', 0, N'wadza', CAST(N'2021-07-24T12:38:29.220' AS DateTime))
INSERT [dbo].[LoanUses] ([ID], [Name], [IsActive], [LastChangedBy], [LastChangedDate]) VALUES (6, N'Education', 1, N'wadza', CAST(N'2021-07-24T12:41:32.507' AS DateTime))
SET IDENTITY_INSERT [dbo].[LoanUses] OFF
GO
SET IDENTITY_INSERT [dbo].[PenaltyMarkers] ON 

INSERT [dbo].[PenaltyMarkers] ([ID], [Name], [IsActive], [CreatedBy], [DateCreated], [LastChangedBy], [LastChangedDate]) VALUES (1, N'X Days', 1, N'scSuperUser', CAST(N'2021-04-19T19:29:35.000' AS DateTime), NULL, NULL)
INSERT [dbo].[PenaltyMarkers] ([ID], [Name], [IsActive], [CreatedBy], [DateCreated], [LastChangedBy], [LastChangedDate]) VALUES (2, N'Y Days', 1, N'scSuperUser', CAST(N'2021-04-19T19:29:35.000' AS DateTime), NULL, NULL)
INSERT [dbo].[PenaltyMarkers] ([ID], [Name], [IsActive], [CreatedBy], [DateCreated], [LastChangedBy], [LastChangedDate]) VALUES (3, N'X Days More', 1, N'scSuperUser', CAST(N'2021-04-19T19:29:35.000' AS DateTime), NULL, NULL)
INSERT [dbo].[PenaltyMarkers] ([ID], [Name], [IsActive], [CreatedBy], [DateCreated], [LastChangedBy], [LastChangedDate]) VALUES (4, N'Y Days More', 1, N'scSuperUser', CAST(N'2021-04-19T19:29:35.000' AS DateTime), NULL, NULL)
INSERT [dbo].[PenaltyMarkers] ([ID], [Name], [IsActive], [CreatedBy], [DateCreated], [LastChangedBy], [LastChangedDate]) VALUES (5, N'X Days Less', 1, N'scSuperUser', CAST(N'2021-04-19T19:29:35.000' AS DateTime), NULL, NULL)
INSERT [dbo].[PenaltyMarkers] ([ID], [Name], [IsActive], [CreatedBy], [DateCreated], [LastChangedBy], [LastChangedDate]) VALUES (6, N'Y Days Less', 1, N'scSuperUser', CAST(N'2021-04-19T19:29:35.000' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[PenaltyMarkers] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductComputations] ON 

INSERT [dbo].[ProductComputations] ([ID], [Name], [IsActive], [PluginName], [Method], [CreatedBy], [DateCreated], [LastChangedBy], [LastChangedDate]) VALUES (1, N'Type1', 1, N'test', N'test', N'cc', CAST(N'2021-05-01T00:00:00.000' AS DateTime), N'cc', NULL)
SET IDENTITY_INSERT [dbo].[ProductComputations] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ID], [Name], [IsActive], [IsLegibleForPenalties], [ComputationalTypeID], [CurrencyID], [CreatedBy], [DateCreated], [LastChangedBy], [LastChangedDate]) VALUES (3, N'Test Product', 1, 1, 1, 1, N'cc', CAST(N'2020-01-01T00:00:00.000' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Sectors] ON 

INSERT [dbo].[Sectors] ([ID], [Name], [Code], [IsActive], [LastChangedBy], [LastChangedDate]) VALUES (1, N'General farming and ranching', N'110', 1, N'string', CAST(N'2021-04-25T20:24:12.830' AS DateTime))
SET IDENTITY_INSERT [dbo].[Sectors] OFF
GO
SET IDENTITY_INSERT [dbo].[SubCategories] ON 

INSERT [dbo].[SubCategories] ([ID], [CategoryID], [Name], [LastChangedBy], [LastChangedDate]) VALUES (1, 1, N'Chinhoyi University', N'Test', CAST(N'2021-04-25T20:35:22.667' AS DateTime))
SET IDENTITY_INSERT [dbo].[SubCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[SubEntities] ON 

INSERT [dbo].[SubEntities] ([ID], [SubCategoryID], [Name], [LastChangedBy], [LastChangedDate]) VALUES (1, 1, N'BSC Honours in IT', N'TEST', CAST(N'2021-04-25T21:09:39.773' AS DateTime))
SET IDENTITY_INSERT [dbo].[SubEntities] OFF
GO
ALTER TABLE [dbo].[LoanBeneficiary]  WITH CHECK ADD  CONSTRAINT [FK_LoanBeneficiary_Loans] FOREIGN KEY([LoanID])
REFERENCES [dbo].[Loans] ([ID])
GO
ALTER TABLE [dbo].[LoanBeneficiary] CHECK CONSTRAINT [FK_LoanBeneficiary_Loans]
GO
ALTER TABLE [dbo].[LoanBeneficiary]  WITH CHECK ADD  CONSTRAINT [FK_LoanBeneficiary_SubEntities] FOREIGN KEY([SubEntityID])
REFERENCES [dbo].[SubEntities] ([ID])
GO
ALTER TABLE [dbo].[LoanBeneficiary] CHECK CONSTRAINT [FK_LoanBeneficiary_SubEntities]
GO
ALTER TABLE [dbo].[LoanCollections]  WITH CHECK ADD  CONSTRAINT [FK_LoanCollections_LoanFees] FOREIGN KEY([LoanFeeID])
REFERENCES [dbo].[LoanFees] ([ID])
GO
ALTER TABLE [dbo].[LoanCollections] CHECK CONSTRAINT [FK_LoanCollections_LoanFees]
GO
ALTER TABLE [dbo].[LoanCollections]  WITH CHECK ADD  CONSTRAINT [FK_LoanCollections_Loans] FOREIGN KEY([LoanID])
REFERENCES [dbo].[Loans] ([ID])
GO
ALTER TABLE [dbo].[LoanCollections] CHECK CONSTRAINT [FK_LoanCollections_Loans]
GO
ALTER TABLE [dbo].[LoanFinances]  WITH CHECK ADD  CONSTRAINT [FK_LoanFinances_Loans] FOREIGN KEY([LoanID])
REFERENCES [dbo].[Loans] ([ID])
GO
ALTER TABLE [dbo].[LoanFinances] CHECK CONSTRAINT [FK_LoanFinances_Loans]
GO
ALTER TABLE [dbo].[Loans]  WITH CHECK ADD  CONSTRAINT [FK_Loans_FiscalYears] FOREIGN KEY([FiscalID])
REFERENCES [dbo].[FiscalYears] ([ID])
GO
ALTER TABLE [dbo].[Loans] CHECK CONSTRAINT [FK_Loans_FiscalYears]
GO
ALTER TABLE [dbo].[Loans]  WITH CHECK ADD  CONSTRAINT [FK_Loans_LoanStatus] FOREIGN KEY([LoanStatusID])
REFERENCES [dbo].[LoanStatus] ([ID])
GO
ALTER TABLE [dbo].[Loans] CHECK CONSTRAINT [FK_Loans_LoanStatus]
GO
ALTER TABLE [dbo].[Loans]  WITH CHECK ADD  CONSTRAINT [FK_Loans_LoanTypes] FOREIGN KEY([LoanTypeID])
REFERENCES [dbo].[LoanTypes] ([ID])
GO
ALTER TABLE [dbo].[Loans] CHECK CONSTRAINT [FK_Loans_LoanTypes]
GO
ALTER TABLE [dbo].[Loans]  WITH CHECK ADD  CONSTRAINT [FK_Loans_LoanUses] FOREIGN KEY([LoanUseID])
REFERENCES [dbo].[LoanUses] ([ID])
GO
ALTER TABLE [dbo].[Loans] CHECK CONSTRAINT [FK_Loans_LoanUses]
GO
ALTER TABLE [dbo].[Loans]  WITH CHECK ADD  CONSTRAINT [FK_Loans_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ID])
GO
ALTER TABLE [dbo].[Loans] CHECK CONSTRAINT [FK_Loans_Products]
GO
ALTER TABLE [dbo].[Loans]  WITH CHECK ADD  CONSTRAINT [FK_Loans_Sectors] FOREIGN KEY([LoanSectorID])
REFERENCES [dbo].[Sectors] ([ID])
GO
ALTER TABLE [dbo].[Loans] CHECK CONSTRAINT [FK_Loans_Sectors]
GO
ALTER TABLE [dbo].[LoanSchedules]  WITH CHECK ADD  CONSTRAINT [FK_LoanSchedules_Loans] FOREIGN KEY([LoanID])
REFERENCES [dbo].[Loans] ([ID])
GO
ALTER TABLE [dbo].[LoanSchedules] CHECK CONSTRAINT [FK_LoanSchedules_Loans]
GO
ALTER TABLE [dbo].[LoanTransactionDetails]  WITH CHECK ADD  CONSTRAINT [FK_LoanTransactionDetails_LoanTransactions] FOREIGN KEY([LoanTransactionID])
REFERENCES [dbo].[LoanTransactions] ([ID])
GO
ALTER TABLE [dbo].[LoanTransactionDetails] CHECK CONSTRAINT [FK_LoanTransactionDetails_LoanTransactions]
GO
ALTER TABLE [dbo].[LoanTransactionDetails]  WITH CHECK ADD  CONSTRAINT [FK_LoanTransactionDetails_LoanTransactionTypes] FOREIGN KEY([TransactionTypeID])
REFERENCES [dbo].[LoanTransactionTypes] ([ID])
GO
ALTER TABLE [dbo].[LoanTransactionDetails] CHECK CONSTRAINT [FK_LoanTransactionDetails_LoanTransactionTypes]
GO
ALTER TABLE [dbo].[LoanTransactions]  WITH CHECK ADD  CONSTRAINT [FK_LoanTransactions_FiscalYears] FOREIGN KEY([FiscalID])
REFERENCES [dbo].[FiscalYears] ([ID])
GO
ALTER TABLE [dbo].[LoanTransactions] CHECK CONSTRAINT [FK_LoanTransactions_FiscalYears]
GO
ALTER TABLE [dbo].[LoanTransactions]  WITH CHECK ADD  CONSTRAINT [FK_LoanTransactions_Loans] FOREIGN KEY([LoanID])
REFERENCES [dbo].[Loans] ([ID])
GO
ALTER TABLE [dbo].[LoanTransactions] CHECK CONSTRAINT [FK_LoanTransactions_Loans]
GO
ALTER TABLE [dbo].[LoanTransactions]  WITH CHECK ADD  CONSTRAINT [FK_LoanTransactions_LoanTransactionStatus] FOREIGN KEY([TransactionStatusID])
REFERENCES [dbo].[LoanTransactionStatus] ([ID])
GO
ALTER TABLE [dbo].[LoanTransactions] CHECK CONSTRAINT [FK_LoanTransactions_LoanTransactionStatus]
GO
ALTER TABLE [dbo].[ProductDiscounts]  WITH CHECK ADD  CONSTRAINT [FK_ProductDiscounts_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ID])
GO
ALTER TABLE [dbo].[ProductDiscounts] CHECK CONSTRAINT [FK_ProductDiscounts_Products]
GO
ALTER TABLE [dbo].[ProductFees]  WITH CHECK ADD  CONSTRAINT [FK_ProductFees_Fees] FOREIGN KEY([FeeID])
REFERENCES [dbo].[Fees] ([ID])
GO
ALTER TABLE [dbo].[ProductFees] CHECK CONSTRAINT [FK_ProductFees_Fees]
GO
ALTER TABLE [dbo].[ProductFees]  WITH CHECK ADD  CONSTRAINT [FK_ProductFees_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ID])
GO
ALTER TABLE [dbo].[ProductFees] CHECK CONSTRAINT [FK_ProductFees_Products]
GO
ALTER TABLE [dbo].[ProductPenalties]  WITH CHECK ADD  CONSTRAINT [FK_ProductPenalties_PenaltyMarkers] FOREIGN KEY([MarkerID])
REFERENCES [dbo].[PenaltyMarkers] ([ID])
GO
ALTER TABLE [dbo].[ProductPenalties] CHECK CONSTRAINT [FK_ProductPenalties_PenaltyMarkers]
GO
ALTER TABLE [dbo].[ProductPenalties]  WITH CHECK ADD  CONSTRAINT [FK_ProductPenalties_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ID])
GO
ALTER TABLE [dbo].[ProductPenalties] CHECK CONSTRAINT [FK_ProductPenalties_Products]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_ProductComputations] FOREIGN KEY([ComputationalTypeID])
REFERENCES [dbo].[ProductComputations] ([ID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_ProductComputations]
GO
ALTER TABLE [dbo].[SubCategories]  WITH CHECK ADD  CONSTRAINT [FK_SubCategories_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([ID])
GO
ALTER TABLE [dbo].[SubCategories] CHECK CONSTRAINT [FK_SubCategories_Categories]
GO
ALTER TABLE [dbo].[SubEntities]  WITH CHECK ADD  CONSTRAINT [FK_SubEntities_SubCategories] FOREIGN KEY([SubCategoryID])
REFERENCES [dbo].[SubCategories] ([ID])
GO
ALTER TABLE [dbo].[SubEntities] CHECK CONSTRAINT [FK_SubEntities_SubCategories]
GO
USE [master]
GO
ALTER DATABASE [SC_EduCore_V1] SET  READ_WRITE 
GO
