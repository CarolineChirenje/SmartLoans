

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using SmartDataAccess;
using SmartDomain;
using SmartExtensions;
using SmartHelper;
using SmartInterfaces;
using SmartLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace SmartLogic
{
    public class ManageLoanService : IManageLoanService
    {
        private readonly DatabaseContext _context;
        private readonly IClientService clientService=new ClientService();
        readonly ICustomSettingsService _settingService = new CustomSettingsService();
        public ManageLoanService(DatabaseContext context) => _context = context;
        public async Task<Loan> FindLoan(int loanid)
        {
            try
            {

                Loan loan = await _context.Loans
                   .Where(r => r.LoanID == loanid)
                    .Include(c => c.Client)
                   .Include(m => m.LoanSector)
                   .Include(p => p.LoanType)
                   .Include(p => p.LoanStatus)
                   .Include(p => p.LoanUse)
                  
                   .AsNoTracking().FirstOrDefaultAsync();

                return loan;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public LoanForm GetLoanForm(Loan loan)
        {
            try
            {
                if (loan.IsNull())
                    return null;
                LoanForm loanForm = new LoanForm()
                {
                    ClientID = loan.ClientID,
                    LoanID = loan.LoanID,
                    LoanStatus = loan.LoanStatus.Name,
                    LoanType = loan.LoanType.Name,
                    LoanRef = loan.LoanRef,
                    RegistrationDate = loan.RegistrationDate,
                    Applicant = clientService.GetClientRef(loan.ClientID)
                };
                return loanForm;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public LoanForm GetLoanForm(int loanid)
        {
            try
            {
                var loan = _context.Loans
                           .Include(l => l.LoanStatus)
             .Include(l => l.LoanType)
             .Include(l => l.LoanUse)
             .Where(l => l.LoanID == loanid)
                .AsNoTracking()
               .FirstOrDefault();
                if (loan.IsNull())
                    return null;

                LoanForm loanForm = GetLoanForm(loan);
                return loanForm;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<List<LoanForm>> GetLoans(string loanref = null, bool newLoansOnly = false, int companyID = 0)
        {
            try
            {

                var loans = await _context.Loans
                           .Include(l => l.LoanStatus)
             .Include(l => l.LoanType)
             .Include(l => l.LoanUse)
                .AsNoTracking()
               .ToListAsync();
                if (loans == null)
                    return null;
                if (!String.IsNullOrEmpty(loanref))
                    loans = loans.Where(m => m.LoanRef.Contains(loanref.Trim())).ToList();
                if (companyID > 0)
                    loans = loans.Where(c => c.Client.CompanyID == companyID).ToList();

                if (newLoansOnly)
                    loans = loans.Where(rp => rp.RegistrationDate.Date >= DateTime.Now.AddDays(-1).Date && rp.RegistrationDate.Date <= DateTime.Now.Date).ToList();
                //if (productID > 0)
                //    loans = loans.Where(c => c.ProductID == productID).ToList();


                List<LoanForm> loanLists = new List<LoanForm>();
                foreach (var loan in loans)
                {

                    loanLists.Add(GetLoanForm(loan));
                }
                return loanLists.ToList();


            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<List<Loan>> Loans()
        {
            try
            {

                return await _context.Loans
               .Include(c => c.Client)
               .Include(m => m.LoanBeneficiaries)
               .Include(p => p.LoanDocuments)
              .Include(l => l.LoanFinance)
              .Include(l => l.LoanStatus)
              .Include(l => l.LoanType)
              .Include(l => l.LoanUse)
                            .AsNoTracking()
                .ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }



        public async Task<int> Update(Loan update)
        {
            try
            {

                Loan loan = _context.Loans.Find(update.LoanID);
                //               loan.IsActive = update.IsActive;
                //loan.CountryID = update.CountryID;
                //loan.CompanyID = update.CompanyID;
                //loan.Name = update.Name;
                //loan.CurrencyID = update.CurrencyID;
                //loan.IsLegibleForPenalties = update.IsLegibleForPenalties;
                //loan.ProductComputationID = update.ProductComputationID;
                //loan.ProductCode = update.ProductCode;
                loan.LastChangedBy = UserAppData.CurrentUserName;
                loan.LastChangedDate = DateTime.Now;
                _context.Update(loan);


                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        public string NewLoanNumber
        {
            get
            {
                return GenerateLoanNumber();
            }
        }



        private bool LoanNumberExists(string loanNumber)
        {
            try
            {
                return _context.Loans.Any(m => m.LoanRef.Equals(loanNumber));
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        string GenerateLoanNumber()
        {
            try
            {
                string _accountNumber;
                string randNum = UtilityService.GenerateRandomNumbers(Convert.ToInt32(_settingService.GetSettingValue(AppSetting.Account_Number_Length))).ToString();
                string accountNum = $"{randNum}";
                long accountNumber = Convert.ToInt64(accountNum);
                string accNumberPrefix = _settingService.GetSettingValue(AppSetting.Loan_Number_Prefix);
                if (String.IsNullOrEmpty(accNumberPrefix))
                    _accountNumber = accountNumber.ToString();
                else
                    _accountNumber = accNumberPrefix + accountNumber.ToString();
                if (LoanNumberExists(accountNumber.ToString()))
                    return GenerateLoanNumber();

                else
                    return _accountNumber;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Save(Loan loan)
        {
            try
            {
                if (UtilityService.AutoGenerateAccountNumber)
                    loan.LoanRef = NewLoanNumber;
                else
                    loan.LoanRef = loan.LoanRef;
                loan.LoanStatusID = (int)LoanState.Created;
                loan.LastChangedBy = UserAppData.CurrentUserName;
                loan.LastChangedDate = DateTime.Now;
                loan.RegistrationDate = DateTime.Now;
                _context.Add(loan);
                await _context.SaveChangesAsync();
                return loan.LoanID;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> FinaliseLoan(int LoanID)
        {
            try
            {

                Loan loan = _context.Loans
                .Include(l => l.LoanFinance)
                .Where(l => l.LoanID == LoanID).FirstOrDefault();
                if (loan.IsNull())
                    return 0;
                loan.LoanStatusID = (int)LoanState.Active;
                loan.LastChangedBy = UserAppData.CurrentUserName;
                loan.LastChangedDate = DateTime.Now;
                _context.Update(loan);
              int result= await _context.SaveChangesAsync();
                // Create LoanSchedule based on  duration 
                if (loan.LoanFinance.IsNull())
                    return result;
                LoanSchedule(loan);
                return result; 
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }

        public void LoanSchedule(Loan loan)
        {
            try
            {
                if (loan.LoanFinance.Duration > 0)
                {
                    for (int scheduleCount = 1; scheduleCount <= loan.LoanFinance.Duration; scheduleCount++)
                    {
                        LoanSchedule schedule = new LoanSchedule()
                        {
                            CreatedBy = UserAppData.CurrentUserName,
                            DateCreated = DateTime.Now,
                            LoanID = loan.LoanID,
                            DueDate = loan.LoanFinance.StartDate.AddMonths(scheduleCount).ToString("yyyy-MM-dd"),
                            LastChangedBy = UserAppData.CurrentUserName,
                            LastChangedDate = DateTime.Now,
                            LedgerNo = scheduleCount,

                        };
                        _context.Add(schedule);

                    }

                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }


        }

        public async Task<int> ChangeLoanStatus(int LoanID, int StatusID)
        {
            try
            {
                Loan loan = _context.Loans.Find(LoanID);
                if (loan.IsNull())
                    return loan.LoanID;
                loan.LoanStatusID = StatusID;
                loan.LastChangedBy = UserAppData.CurrentUserName;
                loan.LastChangedDate = DateTime.Now;
                _context.Update(loan);
                await _context.SaveChangesAsync();
                return loan.LoanID;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Delete(int id)
        {
            try
            {
                var loan = await _context.Loans.FindAsync(id);
                _context.Loans.Remove(loan);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> ActionLoan(int loanid, DatabaseAction action)
        {
            try
            {

                Loan loan = await FindLoan(loanid);
                if (DatabaseAction.Remove == action)
                    _context.Loans.Remove(loan);
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    loan.IsActive = DatabaseAction.Deactivate == action ? false : true;
                    loan.LastChangedBy = UserAppData.CurrentUserName;
                    loan.LastChangedDate = DateTime.Now;
                    _context.Update(loan);
                }
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public List<Company> Companies()
        {
            try
            {

                return _context.Companies.Where(c => c.IsActive)
               .AsNoTracking()
                 .ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        //Product 
        public async Task<ProductFee> FindProductFee(int id)
        {
            try
            {
                return await _context.ProductFees.
                     Include(p => p.Product).
                    Where(p => p.ProductFeeID == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Save(ProductFee ProductFee)
        {
            try
            {

                ProductFee.LastChangedBy = UserAppData.CurrentUserName;
                ProductFee.LastChangedDate = DateTime.Now;
                _context.Add(ProductFee);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        public async Task<int> Update(ProductFee ProductFee)
        {
            try
            {
                ProductFee update = _context.ProductFees.
                Where(t => t.ProductFeeID == ProductFee.ProductFeeID).FirstOrDefault();
                update.FeeID = ProductFee.FeeID;
                update.IsActive = ProductFee.IsActive;
                update.Amount = ProductFee.Amount;
                update.CalculationTypeID = ProductFee.CalculationTypeID;
                update.LastChangedBy = UserAppData.CurrentUserName;
                update.LastChangedDate = DateTime.Now;
                _context.Entry(update).State = EntityState.Modified;
                AddProductHistory(ProductFee);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        void AddProductHistory(ProductFee productFee)
        {
            try
            {

                //Fee History
                ProductFeeHistory feeHistory = new ProductFeeHistory();
                feeHistory.Amount = productFee.Amount;
                feeHistory.CalculationTypeID = productFee.CalculationTypeID;
                feeHistory.IsActive = productFee.IsActive;
                feeHistory.FeeID = productFee.FeeID;
                feeHistory.ProductID = productFee.ProductID;
                feeHistory.ProductFeeID = productFee.ProductFeeID;
                feeHistory.LastChangedBy = productFee.LastChangedBy;
                feeHistory.LastChangedDate = productFee.LastChangedDate;
                _context.Add(feeHistory);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        public async Task<int> ActionProductFee(int id, DatabaseAction action)
        {
            try
            {

                ProductFee productFee = await FindProductFee(id);
                AddProductHistory(productFee);
                if (DatabaseAction.Remove == action)
                {

                    _context.ProductFees.Remove(productFee);

                }
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    productFee.LastChangedBy = UserAppData.CurrentUserName;
                    productFee.LastChangedDate = DateTime.Now;
                    _context.Update(productFee);
                }

                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        //Loan Beneficiaries
        public Beneficiaries LoanBeneficiaries(int loanID)
        {
            try
            {
                var loanBeneficiary = _context.LoanBeneficiaries.
                  Include(l => l.Loan).
                    Include(c => c.RelationshipType).
                      Include(c => c.Gender).
                      Include(c => c.Loan).
                      Include(c => c.CategoryItem).ThenInclude(at => at.SubCategory).ThenInclude(at => at.Category).
                  Where(c => c.LoanID == loanID).ToList();
                var loan = loanBeneficiary.FirstOrDefault();
                if (loan.IsNull())
                    return null;
                Beneficiaries beneficiaries = new Beneficiaries
                {
                    LoanForm = GetLoanForm(loan.Loan),
                };
                if (loanBeneficiary.IsNull())
                    return beneficiaries;


                List<BeneficiaryList> result = new List<BeneficiaryList>();

                foreach (var beneficiary in loanBeneficiary)
                {
                    result.Add(new BeneficiaryList
                    {
                        BeneficiaryID = beneficiary.LoanBeneficiaryID,
                        Name = beneficiary.Name,
                        Surname = beneficiary.Surname,
                        Age = beneficiary.Age,
                        IDNumber = beneficiary.IDNumber,
                        CategoryItemID = beneficiary.CategoryItemID,
                        RelationshipTypeID = beneficiary.RelationshipTypeID,
                        GenderID = beneficiary.GenderID,
                        SubCategoryID = beneficiary.CategoryItem.SubCategoryID,
                        CategoryID = beneficiary.CategoryItem.SubCategory.CategoryID,
                        Gender = beneficiary?.Name,
                        FullName = beneficiary.FullName
                    });
                }
                beneficiaries.BeneficiaryList = result;
                return beneficiaries;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<Beneficiary> FindLoanBeneficiary(int id)
        {
            try
            {
                var benefic = await _context.LoanBeneficiaries.
                     Include(c => c.RelationshipType).
                      Include(c => c.Gender).
                      Include(c => c.Loan).
                      Include(c => c.CategoryItem).ThenInclude(at => at.SubCategory).ThenInclude(at => at.Category).
                      Where(t => t.LoanBeneficiaryID == id).FirstOrDefaultAsync();


                if (benefic.IsNull())
                    return null;

                Beneficiary beneficiary = new Beneficiary();
                beneficiary.LoanForm = GetLoanForm(benefic.Loan);
                beneficiary.BeneficiaryDetail = new BeneficiaryList()
                {
                    BeneficiaryID = benefic.LoanBeneficiaryID,
                    Name = benefic.Name,
                    Surname = benefic.Surname,
                    Age = benefic.Age,
                    IDNumber = benefic.IDNumber,
                    CategoryItemID = benefic.CategoryItemID,
                    RelationshipTypeID = benefic.RelationshipTypeID,
                    GenderID = benefic.GenderID,
                    SubCategoryID = benefic.CategoryItem.SubCategoryID,
                    LastChangedBy = benefic.LastChangedBy,
                    LastChangedDate = benefic.LastChangedDate,
                    CategoryID = benefic.CategoryItem.SubCategory.CategoryID,
                    Gender = benefic?.Name,
                    FullName = benefic.FullName
                };

                return beneficiary;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }



        public async Task<int> Save(LoanBeneficiary beneficiary)
        {
            try
            {

                beneficiary.LastChangedBy = UserAppData.CurrentUserName;
                beneficiary.LastChangedDate = DateTime.Now;
                _context.Add(beneficiary);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        public async Task<int> Update(LoanBeneficiary beneficiary)
        {
            try
            {

                LoanBeneficiary dependent = _context.LoanBeneficiaries.Find(beneficiary.LoanBeneficiaryID);
                dependent.DateOfBirth = beneficiary.DateOfBirth;
                dependent.IDNumber = beneficiary.IDNumber;
                dependent.Name = beneficiary.Name;
                dependent.Surname = beneficiary.Surname;
                dependent.CategoryItemID = beneficiary.CategoryItemID;
                dependent.GenderID = beneficiary.GenderID;
                dependent.LastChangedBy = UserAppData.CurrentUserName;
                dependent.LastChangedDate = DateTime.Now;
                _context.Update(dependent);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> ActionDependent(int id, DatabaseAction action)
        {
            try
            {

                LoanBeneficiary beneficiaries = _context.LoanBeneficiaries.Find(id);
                if (DatabaseAction.Remove == action)
                    _context.LoanBeneficiaries.Remove(beneficiaries);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        //Document
        public LoanDocs LoanDocuments(int loanid)
        {
            try
            {
                var loanDocs = _context.LoanDocuments.
                Include(cd => cd.DocumentType).
                Where(c => c.LoanID == loanid).ToList();
                LoanDocs docs = new LoanDocs
                {
                    LoanID = loanid,
                    LoanForm = GetLoanForm(loanid)
                };
                if (loanDocs.ListIsEmpty())
                    return docs;

                List<LoanDocumentList> result = new List<LoanDocumentList>();

                foreach (var document in loanDocs)
                {
                    result.Add(new LoanDocumentList
                    {
                        LoanDocumentID = document.LoanDocumentID,
                        LoanID = document.LoanID,
                        DocumentTitle = document.DocumentType.Name,
                        DateUploaded = UtilityService.ShowDateTime(document.DateUploaded),
                        FileName = document.FileName,
                        FileBytes = document.FileBytes,
                        UploadedBy = document.UploadedBy,
                        FileFullName = document.FileFullName
                    });
                }
                docs.DocumentList = result;
                return docs;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<LoanDocument> FindDocument(int id)
        {
            try
            {
                return await _context.LoanDocuments.
                 Include(dt => dt.DocumentType).
                 Include(c => c.Loan).
                 Where(t => t.LoanDocumentID == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> Save(LoanDocument loanDocument)
        {
            try
            {
                loanDocument.UploadedBy = loanDocument.LastChangedBy = UserAppData.CurrentUserName;
                loanDocument.DateUploaded = loanDocument.LastChangedDate = DateTime.Now;
                _context.Add(loanDocument);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        public async Task<int> Update(LoanDocument document)
        {
            try
            {

                document.LastChangedBy = UserAppData.CurrentUserName;
                document.LastChangedDate = DateTime.Now;
                _context.Update(document);
                await _context.SaveChangesAsync();
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> ActionDocument(int id, DatabaseAction action)
        {
            try
            {
                LoanDocument loanDocument = await FindDocument(id);
                if (DatabaseAction.Remove == action)
                    _context.LoanDocuments.Remove(loanDocument);

                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<bool> DocumentUploaded(int loanid, int documentTypeID)
        {
            try
            {


                LoanDocument loanDocument = await _context.LoanDocuments.Where(c => c.LoanID == loanid && c.DocumentTypeID == documentTypeID).FirstOrDefaultAsync();
                bool result = loanDocument.IsNotNull();

                return result;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        //Notes
        public LoanComments LoanNotes(int loanid)
        {
            try
            {
                var loanNotes = _context.LoanNotes.
                                Include(ut => ut.UserType).
                     Where(c => c.LoanID == loanid).ToList();

                LoanComments comments = new LoanComments
                {
                    LoanID = loanid,
                    LoanForm = GetLoanForm(loanid)
                };
                if (loanNotes.ListIsEmpty())
                    return comments;

                List<LoanCommentsList> result = new List<LoanCommentsList>();

                foreach (var loanNote in loanNotes)
                {
                    result.Add(new LoanCommentsList
                    {
                        LoanNoteID = loanNote.LoanNoteID,
                        LoanID = loanNote.LoanID,
                        Comment = loanNote.Comment,
                        DateClosed = UtilityService.ShowDateTime(loanNote.DateClosed),
                        DateUploaded = UtilityService.ShowDateTime(loanNote.DateUploaded),
                        DueDate = UtilityService.ShowDateTime(loanNote.DueDate),
                        UploadedBy = loanNote.UploadedBy,
                        VisibleToAdminOnly = loanNote.VisibleToAdminOnly,
                        LastChangedDate = UtilityService.ShowDateTime(loanNote.LastChangedDate),
                        LastChangedBy = loanNote.LastChangedBy,
                        UserTypeName = loanNote.UserType?.Name

                    });
                }
                comments.CommentsList = result;
                return comments;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<LoanNote> FindNote(int id)
        {
            try
            {
                return await _context.LoanNotes.
            Include(ut => ut.UserType).
            Include(c => c.Loan).
           Where(t => t.LoanNoteID == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Save(LoanNote loanNote)
        {
            try
            {
                if (!loanNote.DueDate.IsNotNull())
                    loanNote.DueDate = DateTime.Now.AddDays(5);
                if (!loanNote.DateClosed.IsNotNull())
                    loanNote.DateClosed = DateTime.MinValue;
                loanNote.UserTypeID = UserAppData.CurrentUserTypeID;
                loanNote.UploadedBy = loanNote.LastChangedBy = UserAppData.CurrentUserName;
                loanNote.LastChangedDate = DateTime.Now;
                loanNote.DateUploaded = DateTime.Now;

                _context.Add(loanNote);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        public async Task<int> Update(LoanNote note)
        {
            try
            {
                LoanNote loanNote = _context.LoanNotes.Find(note.LoanNoteID);
                loanNote.Comment = note.Comment;
                loanNote.DateClosed = note.DateClosed;
                if (note.DueDate.IsNull())
                    loanNote.DueDate = DateTime.Now.AddDays(UtilityService.ClientNotesDefaultDueDateInterval.IsNull() ? 5 : UtilityService.ClientNotesDefaultDueDateInterval);
                else
                    loanNote.DueDate = note.DueDate;
                if (note.DateClosed.IsNull())
                    loanNote.DateClosed = DateTime.MinValue;
                else
                    loanNote.DateClosed = note.DateClosed;
                loanNote.UserTypeID = UserAppData.CurrentUserTypeID;
                loanNote.LastChangedBy = UserAppData.CurrentUserName;
                loanNote.LastChangedDate = DateTime.Now;
                _context.Update(loanNote);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> ActionNote(int id, DatabaseAction action)
        {
            try
            {
                LoanNote LoanNote = await FindNote(id);
                if (DatabaseAction.Remove == action)
                    _context.LoanNotes.Remove(LoanNote);
                if (DatabaseAction.Close == action)
                {
                    LoanNote.DateClosed = DateTime.Now;
                    LoanNote.LastChangedBy = UserAppData.CurrentUserName;
                    LoanNote.LastChangedDate = DateTime.Now;
                    _context.LoanNotes.Update(LoanNote);
                }
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

    }
}

