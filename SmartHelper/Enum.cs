using System.ComponentModel;

namespace SmartHelper
{
    public enum MenuGroups
    {
        DashBoard = 1,
        Clients,
        Transactions,
        Reporting,
        Settings,
        Invoicing,
        Loans,

        //
        Menu = 9998,
        Developer_Menu = 999,
    }
    public enum LayoutComponent
    {
        Client = 1,
        Loan_Manager,
        Developer_Menu,
        Settings,
        Reporting,
        Employees,
        Employers
    }
    public enum Menu_Component
    {//Name must the same with ComponentList
        MenuList = 1,
        ClientMenuList,
        LoanMenuList,
        DeveloperMenuList,
        SettingsMenuList,
        ReportingMenuList,
        NoMenuList,
        EmployeeMenuList,
        EmployerMenuList
    }
    public enum DaysOfTheWeek
    {
        Sunday = 1,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public enum TransactionState
    {
        Positive = 1,
        Negative,

    }
    public enum DatabaseAction
    {
        Remove = 1,
        Deactivate,
        Reactivate,
        Open,
        Close,
        IsDefault
    }
    public enum EmailStatus
    {
        Pending, // has been generated by the System
        DelayedSending,// attempted but failed
        Sent// sent
    }
    public enum MessageDisplayType
    {
        Success = 1,
        Warning,
        Error
    }

    public enum VariableType
    {
        Boolean = 1,
        String = 2,
        Long = 3,
        Integer = 4,
        Double = 5,
        Decimal,
        Date_Time,
        Password,
        Percentage

    }
    public enum TransactionTypeList
    {
        //      https://study.com/academy/lesson/financial-transactions-types-lesson-quiz.html#:~:text=There%20are%20four%20main%20types,purchases%2C%20receipts%2C%20and%20payments.&text=The%20receipt%20transaction%20is%20recorded,a%20credit%20to%20accounts%20receivable. 

        //There are four main types of financial transactions that occur in a business. These four types of financial transactions are sales, purchases, receipts, and payments. Let's take a minute to learn about each one:

        //Sales are the transactions in which property is transferred from buyer to seller for money or credit. Sales transactions are recorded in the accounting journal for the seller as a debit to cash or accounts receivable and a credit to the sales account.
        //Purchases are the transactions that are required by a business in order to obtain the goods or services needed to accomplish the goals of the organization. Purchases made in cash result in a debit to the inventory account and a credit to cash. If the purchase is made with a credit account, the debit entry would still be to the inventory account and the credit entry would be to the accounts payable account.
        //Receipts are the transactions that refer to a business getting paid for delivering goods or services to another business. The receipt transaction is recorded in the journal for the seller as a debit to cash and a credit to accounts receivable.
        //Payments are the transactions that refer to a business receiving money for a good or service. They are recorded in the accounting journal of the business issuing the payment as a credit to cash and a debit to accounts payable.

        [Description("PAY")]
        Payment = 1,
        [Description("(R)")]
        Reversal,
        [Description("PURCH")]
        Purchase,
        [Description("SALE")]
        Sales,
        [Description("RPT")]
        Receipts,
        [Description("RECON")]
        Recon,
        [Description("DEP")]
        Deposit,
        [Description("FEE")]
        Fee,
    }

    public enum AccountType
    {
        Savings = 1,
        Cheque,
        Credit,
        Cash,

    }

    public enum CurrencyList

    {

        AED = 1
, AFN
, ALL
, AMD
, ANG
, AOA
, ARS
, AUD
, AWG
, AZN
, BAM
, BBD
, BDT
, BGN
, BHD
, BIF
, BMD
, BND
, BOB
, BRL
, BSD
, BTN
, BWP
, BYN
, BZD
, CAD
, CDF
, CHF
, CLP
, CNY
, COP
, CRC
, CUC
, CUP
, CVE
, CZK
, DJF
, DKK
, DOP
, DZD
, EGP
, ERN
, ETB
, EUR
, FJD
, FKP
, GBP
, GEL
, GGP
, GHS
, GIP
, GMD
, GNF
, GTQ
, GYD
, HKD
, HNL
, HRK
, HTG
, HUF
, IDR
, ILS
, IMP
, INR
, IQD
, IRR
, ISK
, JEP
, JMD
, JOD
, JPY
, KES
, KGS
, KHR
, KMF
, KPW
, KRW
, KWD
, KYD
, KZT
, LAK
, LBP
, LKR
, LRD
, LSL
, LYD
, MAD
, MDL
, MGA
, MKD
, MMK
, MNT
, MOP
, MRU
, MUR
, MVR
, MWK
, MXN
, MYR
, MZN
, NAD
, NGN
, NIO
, NOK
, NPR
, NZD
, OMR
, PAB
, PEN
, PGK
, PHP
, PKR
, PLN
, PYG
, QAR
, RON
, RSD
, RUB
, RWF
, SAR
, SBD
, SCR
, SDG
, SEK
, SGD
, SHP
, SLL
, SOS
, SPL
, SRD
, STN
, SVC
, SYP
, SZL
, THB
, TJS
, TMT
, TND
, TOP
, TRY
, TTD
, TVD
, TWD
, TZS
, UAH
, UGX
, USD
, UYU
, UZS
, VEF
, VND
, VUV
, WST
, XAF
, XCD
, XDR
, XOF
, XPF
, YER
, ZAR
, ZMW
, ZWD



    }


    public enum CountryList

    {
        Afghanistan = 1
, Albania
, Algeria
, American_Samoa
, Andorra
, Angola
, Anguilla
, Antigua_Barbuda
, Argentina
, Armenia
, Aruba
, Australia
, Austria
, Azerbaijan
, Bahamas, _The
, Bahrain
, Bangladesh
, Barbados
, Belarus
, Belgium
, Belize
, Benin
, Bermuda
, Bhutan
, Bolivia
, Bosnia_Herzegovina
, Botswana
, Brazil
, British_Virgin_Is
, Brunei
, Bulgaria
, Burkina_Faso
, Burma
, Burundi
, Cambodia
, Cameroon
, Canada
, Cape_Verde
, Cayman_Islands
, Central_African_Rep
, Chad
, Chile
, China
, Colombia
, Comoros
, Congo_Dem_Rep
, Congo_Repub_of_the
, Cook_Islands
, Costa_Rica
, Cote_dIvoire
, Croatia
, Cuba
, Cyprus
, Czech_Republic
, Denmark
, Djibouti
, Dominica
, Dominican_Republic
, East_Timor
, Ecuador
, Egypt
, El_Salvador
, Equatorial_Guinea
, Eritrea
, Estonia
, Ethiopia
, Faroe_Islands
, Fiji
, Finland
, France
, French_Guiana
, French_Polynesia
, Gabon
, Gambia_The
, Gaza_Strip
, Georgia
, Germany
, Ghana
, Gibraltar
, Greece
, Greenland
, Grenada
, Guadeloupe
, Guam
, Guatemala
, Guernsey
, Guinea
, Guinea_Bissau
, Guyana
, Haiti
, Honduras
, Hong_Kong
, Hungary
, Iceland
, India
, Indonesia
, Iran
, Iraq
, Ireland
, Isle_of_Man
, Israel
, Italy
, Jamaica
, Japan
, Jersey
, Jordan
, Kazakhstan
, Kenya
, Kiribati
, Korea_North
, Korea_South
, Kuwait
, Kyrgyzstan
, Laos
, Latvia
, Lebanon
, Lesotho
, Liberia
, Libya
, Liechtenstein
, Lithuania
, Luxembourg
, Macau
, Macedonia
, Madagascar
, Malawi
, Malaysia
, Maldives
, Mali
, Malta
, Marshall_Islands
, Martinique
, Mauritania
, Mauritius
, Mayotte
, Mexico
, Micronesia_Fed_St
, Moldova
, Monaco
, Mongolia
, Montserrat
, Morocco
, Mozambique
, Namibia
, Nauru
, Nepal
, Netherlands
, Netherlands_Antilles
, New_Caledonia
, New_Zealand
, Nicaragua
, Niger
, Nigeria
, N_Mariana_Islands
, Norway
, Oman
, Pakistan
, Palau
, Panama
, Papua_New_Guinea
, Paraguay
, Peru
, Philippines
, Poland
, Portugal
, Puerto_Rico
, Qatar
, Reunion
, Romania
, Russia
, Rwanda
, Saint_Helena
, Saint_Kitts_Nevis
, Saint_Lucia
, St_Pierre_Miquelon
, Saint_Vincent_and_the_Grenadines
, Samoa
, San_Marino
, Sao_Tome_Principe
, Saudi_Arabia
, Senegal
, Serbia
, Seychelles
, Sierra_Leone
, Singapore
, Slovakia
, Slovenia
, Solomon_Islands
, Somalia
, South_Africa
, Spain
, Sri_Lanka
, Sudan
, Suriname
, Swaziland
, Sweden
, Switzerland
, Syria
, Taiwan
, Tajikistan
, Tanzania
, Thailand
, Togo
, Tonga
, Trinidad_Tobago
, Tunisia
, Turkey
, Turkmenistan
, Turks_Caicos_Is
, Tuvalu
, Uganda
, Ukraine
, United_Arab_Emirates
, United_Kingdom
, United_States
, Uruguay
, Uzbekistan
, Vanuatu
, Venezuela
, Vietnam
, Virgin_Islands
, Wallis_Futuna
, West_Bank
, Western_Sahara
, Yemen
, Zambia
, Zimbabwe
    }
    public enum FeatureFlagList
    {
        Send_Email_On_Error = 1,
        CC_Client_On_Error,
        Enable_Document_Emailing_Functionality
    }
    public enum DocumentFormatList
    {
        pdf = 1,
        doc,
        xlsx,
        txt,
        rtf,
        ppt
    }

    public enum DocumentTypeList
    {
        Identity_Document = 1,
        Birth_Certificate,
        Proof_Of_Address,
        Payslips
    }

    public enum EmailTypeList
    {
        Client_Statement = 1,
        Proof_Of_Payment,
        Invoice,
        New_User_Account_Created,

    }
    public enum AppSetting
    {
        Application_Name = 1,
        System_Version,
        Show_Custom_Exceptions_To_Users,
        Account_Number_Length,
        Date_Format,
        Mail_SMTP_Port,
        Mail_SMTP_Host,
        Mail_Enable_SSL,
        Mail_Use_Default_Credentials,
        Mail_Credential_User_Name,
        Mail_Credential_Password,
        Mail_Display_Name,
        VAT_Percentage,
        File_Maximum_UpLoadable_Size,
        Account_Number_Prefix,
        Application_Name_Prefix,
        Report_Footer_1,
        Report_Footer_2,
        Report_FootNotes,
        Capture_VAT_Inclusive_Payments,
        Default_Company_ID,
        Mail_Default_Subject,
        Statement_Password_Protect,
        Statement_Password_For_Admin,
        Statement_Show_Table_Boarders,
        Pin_Code_Length,
        Password_Reset_Pin_Validity,
        Site_URL,
        Site_Reset_Password_URL,
        Site_Customer_Service_Email,
        Site_Customer_Service_Number,
        Site_Test_Email_Account,
        Site_Default_Environment,
        Application_Role_Based_Menus,
        Site_Create_Account_URL,
        Password_Validity_Period,
        Account_Number_Auto_Generate,
        Application_Is_VAT_Compliant,
        Date_Time_Format,
        Client_Notes_Default_Due_Date_Interval,
        Report_Body_Font_Name,
        Report_Body_Font_Size,
        Report_Footer_Font_Name,
        Report_Footer_Font_Size,
        Allow_Two_Factor_Authentication,
        Pass_Code_Validity_Period,
        Loan_Number_Prefix,

    }

    public enum DefaultRoles
    {
        Super_Admin = 1,
        Employee,
        Administrator,
    }
    public enum TypeOfUser
    {
        Administrator = 1,
        Employer,
        Employee,

    }


    public enum PaymentState
    {
        Paid = 1,
        Reversed,
        Pending,
        Refunded,
        Discounted
    }
    public enum Permissions
    {  //User Module
        Add_User = 1,
        Update_User = 2,
        Delete_User,
        View_User,
        Change_User_Password,

        // Client Module
        Add_Client,
        Update_Client,
        Delete_Client,
        View_Client,
        Change_Client_Password,
        Add_Client_Note,
        Update_Client_Note,
        Delete_Client_Note,
        View_Client_Note,
        Add_Client_Contact,
        Update_Client_Contact,
        Delete_Client_Contact,
        View_Client_Contact,

        Add_Client_Loan,
        Update_Client_Loan,
        Delete_Client_Loan,
        View_Client_Loan,

        Add_Client_Dependent,
        Update_Client_Dependent,
        Delete_Client_Dependent,
        View_Client_Dependent,

        View_Client_Payments,
        Generate_Client_Statement,
        Client_Upload_Document,
        Client_View_Document,


        // Role Module
        Add_Role,
        Update_Role,
        Delete_Role,
        View_Role,
        Add_Permissions,
        Remove_Permissions,
        View_Permissions,
        Add_Menu_To_Role,
        Remove_Menu_From_Role,

        // Product Module
        Add_Product,
        Update_Product,
        Delete_Product,
        View_Product,


        // Department Module
        Add_Department,
        Update_Department,
        Delete_Department,
        View_Department,


        // Payment/Transactions
        Capture_Payment,
        Reverse_Payment,
        View_Payment,
        View_Client_Outstanding_Payments,
        Generate_Invoices,
        Remove_Invoice_Entries,
        View_Client_Deductions,
        Override_Payment,
        View_Invoice,
        Delete_Invoice,
        Finalise_Invoice,
        Process_Invoice,


        // Menus
        Add_Menu,
        Update_Menu,
        Activate_Menu,
        Deactivate_Menu,
        Delete_Menu,
        View_Menu,



        // Custom Setting
        Update_Custom_Setting,
        View_Custom_Setting,


        // Document Types
        Add_Document_Type,
        Update_Document_Type,
        Delete_Document_Type,
        View_Document_Type,

        //Company
        Add_Company,
        Update_Company,
        Delete_Company,
        View_Company,

        //Bank Account
        Add_Bank_Account,
        Update_Bank_Account,
        Delete_Bank_Account,
        View_Bank_Account,

        //Email Templates
        Add_Email_Template,
        Update_Email_Template,
        Delete_Email_Template,
        View_Email_Template,


        //Notice Board
        Add_Notice,
        Update_Notice,
        Delete_Notice,
        View_Notice,

        Update_Country,
        Update_Currency,


        View_Dashboard_Notices,
        Client_Update_Personal_Details,


        Update_Transaction_Type,
        View_Transaction_Type,

        Add_Product_Fee,
        Update_Product_Fee,
        Delete_Product_Fee,
        View_Product_Fee,


        View_Invoice_Details,
        Print_Statement_With_No_Reversals,
        Auto_Generate_Receipt,
        Email_Receipt_To_Client,
        Add_Maintanance_Notification,
        View_Country,
        View_Currency,
        View_Feature_Flag,
        View_Layouts,
        View_Licences,
        View_Maintanances,
        View_Technical_Support_Settings,

        Add_Loan_Use,
        Update_Loan_Use,
        Delete_Loan_Use,
        View_Loan_Use,

        Add_Loan_Type,
        Update_Loan_Type,
        Delete_Loan_Type,
        View_Loan_Type,

      
        Update_Fee,
        View_Fee,
       
        Add_Loan_Status,
        Update_Loan_Status,
        Delete_Loan_Status,
        View_Loan_Status,
        Add_Category,
        Update_Category,
        Delete_Category,
        View_Category,


        Add_Loan,
        Update_Loan,
        Delete_Loan,
        View_Loan,
        Finalise_Loan,
        Un_Finalise_Loan,

        Add_Loan_Beneficiary,
        Update_Loan_Beneficiary,
        View_Loan_Beneficiary,
        Delete_Loan_Beneficiary,

       
        Update_Product_Computation,
        View_Product_Computation,
       

        Loan_Upload_Document,
        Loan_View_Document,

        Add_Loan_Note,
        Update_Loan_Note,
        View_Loan_Note,
        Delete_Loan_Note,


        Add_Fiscal_Year,
        Update_Fiscal_Year,
        View_Fiscal_Year,
        Delete_Fiscal_Year,

        Add_To_Do,
        Update_To_Do,
        View_To_Do,
        Delete_To_Do,

        Generate_Loan_Statement,


    }
    public enum InvoiceState
    {
        Created = 1,
        Processed = 2,
        Finalised,
        Unknown
    }
    public enum SiteEnvironment
    {
        Test = 1,
        Production = 2,
        Development
    }
    public enum QueryType
    {
        Sales = 1,
        Technical = 2,
        Other = 3,
    }
    public enum ContactTypeValues
    {
        Residential_Address = 1,
        Postal_Address = 2,
        Email_Address = 3,
        Cell_Phone = 4,
        Telephone
    }
    public enum AuditActionEnum
    {
        Logged_In,
        Logged_Out,
        Locked_Out,
        Password_Reset_Request,
        Removed_Permission
    }
    public enum ExceptionType
    {
        Logged_In,
        Logged_Out,
        Locked_Out,
        Password_Reset_Request,
    }
    public enum TaskRunType
    {
        Daily = 1,
        Weekly = 2,
        FortNight = 3,
        Monthly = 4,
        Quaterly = 5,
        Bi_Annualy = 6,
        Annualy = 7,
    }
    public enum LogSource
    {
        GUI = 1,
        Data_Access = 2,
        Logic_Base = 3,
        Reporting = 4,
        Helper = 5,
        Mail,
        Error_Log,
        Uknown,
        Base_Controller,
        Rabbit_MQ

    }
    public enum Queues
    {
        Emails = 1,
        Log = 2,
    }
    public enum Support
    {
        CompanyName = 1,
        Company_Registration_Link,
        Mobile_Number,
        Website,
        Whatsapp_Support_Message,
        Database_Server_IP,
        Support_Email_Address

    }
    public enum DeductionApplied
    {
        Product = 1,
        Individual,
        Do_Not_Deduct,
    }
    public enum GenderOrientation
    {
        Female = 1,
        Male = 2
    }
    public enum TaskRunStatus
    {
        New = 1,
        In_Queue = 2,
        In_Progress = 3,
        Completed = 4
    }



    public enum Priority
    {
        Critical = 1,
        High = 2,
        Medium = 3,
        Low = 4,
    }

    public enum Statements
    {
        Product_Based_Statement = 1,
        Transaction_List = 2,
        Outstanding_Payments = 3,
        Deductions

    }

    public enum Title
    {
        Mr = 1,
        Mrs = 2,
        Miss,
        Ms,
        Dr,
        Prof
    }

    public enum Client_AccountType
    {
        Individual = 1,
        Joint = 2,
    }
    public enum RecordState
    {
        Active = 1,
        Deleted = 2,
        History
    }

    public enum Affiliation
    {
        Company = 1,
        Individual = 2,
    }


    public enum CodeType
    {
        Password_Reset = 1,
        Multi_Factor_Authenticator = 2,
        Account_Creation
    }

    public enum Product_Computation
    {
        Type_1 = 1,
        Type_2= 2,
        
    }

    public enum PenaltyMarkers
    {
        X_Days = 1,
        Y_Days,
        X_Days_More,
        Y_Days_More,
        X_Days_Less,
        Y_Days_Less

    }

    public enum LoanState
    {
        Created = 1,
        Awaiting_Approval = 2,
        Active = 3,
        Rejected

    }
    public enum Calculation_Type
    {
        Flat_Rate = 1,
        Percentage_Of = 2,
   }
    public enum LoanFees
    {
        Deposit= 1,
        Interest_Rate = 2,
        Minimum_Charge,
        Documentation_Fee,
        Fixed_Rate,
        Principal,
        Discount,
        Principal_Measure

    }
}

