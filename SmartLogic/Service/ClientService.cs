using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartDomain;
using SmartHelper;
using SmartDataAccess;
using SmartLog;
using SmartInterfaces;
using SmartExtensions;

namespace SmartLogic
{
    public class ClientService : IClientService
    {
        private readonly DatabaseContext _context;
        public ClientService()
        {
            if (_context == null)
            {
                var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
                optionsBuilder.UseSqlServer(GetData.SSDBConnection);
                _context = new DatabaseContext(optionsBuilder.Options);
            }
        }
        public ClientService(DatabaseContext context) => _context = context;

        readonly ICustomSettingsService _settingService = new CustomSettingsService();
        readonly ITransactionService _transactionService = new TransactionService();
        public async Task<int> ActionClientStatus(int id, DatabaseAction action)
        {
            int result;
            try
            {
                Client Client = _context.Clients.Find(id);

                if (DatabaseAction.Remove == action)
                    _context.Clients.Remove(Client);
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    Client.IsActive = DatabaseAction.Deactivate != action;
                    Client.LastChangedBy = UserAppData.CurrentUserName;
                    Client.LastChangedDate = DateTime.Now;
                    _context.Update(Client);
                }
                result = await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;

        }

        public async Task<int> Delete(int id)
        {
            int result;
            try
            {
                var Client = await _context.Clients.FindAsync(id);
                _context.Clients.Remove(Client);
                result = await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;

        }
        public async Task<ClientLoans> GetClientLoans(int clientID)
        {
            try
            {
                var loans = await _context.Loans.Where(p => p.ClientID == clientID)
                  .Include(m => m.Client)
                                    .Include(p => p.LoanFinance)
                   .Include(p => p.LoanStatus)
                   .AsNoTracking()
                   .ToListAsync();

                ClientLoans clientLoans = new ClientLoans
                {
                    ClientID = clientID,
                    Loans = loans
                };
                return clientLoans;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<ClientPeek> GetClient(string emailAddress = null, string idnumber = null, int? clientID = null)
        {
            try
            {
                Client result;
                if (clientID.HasValue)
                    result = _context.Clients.Find(clientID.Value);
                else
                    result = await _context.Clients.Where(c => c.EmailAddress.Equals(emailAddress) && c.IDNumber.Equals(idnumber)).FirstOrDefaultAsync();

                if (result.IsNotNull())
                {
                    ClientPeek peek = PeekClient(result);
                    return peek;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        public async Task<bool> ClientExists(int clientID)
        {
            try
            {
                return await _context.Clients.AnyAsync(c => c.ClientID == clientID);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw ex;
            }
        }

        public async Task<ClientForm> FindClient(int Clientid = 0, string accountNumber = null)
        {
            Client Client = new Client();
            try
            {
                if (String.IsNullOrEmpty(accountNumber?.Trim()))
                    Client = await _context.Clients.FindAsync(Clientid);
                else
                    Client = await _context.Clients.Where(r => r.AccountNumber.Equals(accountNumber.Trim())).FirstOrDefaultAsync();
                if (Client.IsNotNull())
                {
                    Client result = await _context.Clients.AsNoTracking().
                                Include(c => c.JointApplicant).ThenInclude(r => r.RecordStatus).
                                Include(c => c.JointApplicant).ThenInclude(ct => ct.Title).
                                Include(c => c.Title).
                                Include(at => at.ClientAccountType).
                                 Include(at => at.ClientGroup).
                                 Include(at => at.Company).
                                 AsNoTracking().
                                Where(r => r.ClientID == Client.ClientID).FirstOrDefaultAsync();
                    ClientForm clientForm = GetClient(result);
                    return clientForm;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw ex;
            }

        }
        public JointApplicantForm GetJointApplicant(JointApplicant result)
        {
            try
            {
                if (result.IsNotNull())
                    return null;
                JointApplicantForm jointApplicant = new JointApplicantForm
                {
                    JointApplicantID = result.JointApplicantID,
                    ApplicantTitleID = result.ApplicantTitleID,
                    ApplicantGenderID = result.ApplicantGenderID,
                    RelationshipTypeID = result.RelationshipTypeID,
                    DateOfBirth = result.DateOfBirth,
                    Initials = result.Initials,
                    FirstName = result.FirstName,
                    LastName = result.LastName,
                    IDNumber = result.IDNumber,
                    EmailAddress = result.EmailAddress,
                    MobileNumber = result.MobileNumber,
                    AddressLine1 = result.AddressLine1,
                    AddressLine2 = result.AddressLine2,
                    City = result.City,
                    CountryID = result.CountryID,

                };
                return jointApplicant;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw ex;
            }

        }

        public string GetClientRef(int clientID)
        {
            try
            {
                var ClientForm = FindClient(clientID).Result;
                if (ClientForm.IsNull())
                    return "Uknown";
                else
                    return ClientForm.ClientFullName;

            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                return "Uknown";
            }
            
        }
        public async Task<int> Save(ClientForm clientForm)
        {
            try
            {
                Client client = new Client
                {
                    IDNumber = clientForm.IDNumber,
                    Initials = clientForm.Initials,
                    FirstName = clientForm.FirstName,
                    LastName = clientForm.LastName,
                    GenderID = clientForm.GenderID,
                    TitleID = clientForm.TitleID,
                    ClientAccountTypeID = clientForm.ClientAccountTypeID,
                    ClientGroupID = clientForm.ClientGroupID,
                    CompanyID = clientForm.CompanyID,
                    EmailAddress = clientForm.EmailAddress,
                    DateOfBirth = clientForm.DateOfBirth,
                    CountryID = clientForm.CountryID,
                    City = clientForm.City,
                    MobileNumber = clientForm.MobileNumber,
                    Occupation = clientForm.Occupation,
                    DepartmentID = clientForm.DepartmentID,
                    AddressLine1 = clientForm.AddressLine1,
                    AddressLine2 = clientForm.AddressLine2
                };
                if (UtilityService.AutoGenerateAccountNumber)
                    client.AccountNumber = NewClientAccountNumber;
                else
                    client.AccountNumber = clientForm.AccountNumber;
                client.LastChangedBy = UserAppData.CurrentUserName;
                client.LastChangedDate = DateTime.Now;
                client.RegistrationDate = DateTime.Now;
                client.IsActive = clientForm.IsActive;

                if (clientForm.ClientAccountTypeID == (int)Client_AccountType.Joint)
                {
                    if (clientForm.JointApplicant.IsNotNull())
                    {
                        client.JointApplicant = new JointApplicant
                        {
                            IDNumber = clientForm.JointApplicant.IDNumber,
                            Initials = clientForm.JointApplicant.Initials,
                            FirstName = clientForm.JointApplicant.FirstName,
                            LastName = clientForm.JointApplicant.LastName,
                            ApplicantTitleID = clientForm.JointApplicant.ApplicantTitleID,
                            ApplicantGenderID = clientForm.JointApplicant.ApplicantGenderID,
                            RelationshipTypeID = clientForm.JointApplicant.RelationshipTypeID,
                            EmailAddress = clientForm.JointApplicant.EmailAddress,
                            DateOfBirth = clientForm.JointApplicant.DateOfBirth,
                            CountryID = clientForm.JointApplicant.CountryID,
                            City = clientForm.JointApplicant.City,
                            MobileNumber = clientForm.JointApplicant.MobileNumber,
                            AddressLine1 = clientForm.JointApplicant.AddressLine1,
                            AddressLine2 = clientForm.JointApplicant.AddressLine2,
                            RecordStatusID = (int)RecordState.Active,
                            LastChangedBy = UserAppData.CurrentUserName,
                            LastChangedDate = DateTime.Now
                        };

                    }
                }
                _context.Add(client);
                await _context.SaveChangesAsync();
                return client.ClientID;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        public async Task<int> Update(ClientForm clientForm)
        {
            int result = 0;
            try
            {
                Client updateClient = await _context.Clients.FindAsync(clientForm.ClientID);
                string oldIDNumber = updateClient.IDNumber;
                string oldEmailAddress = updateClient.EmailAddress;
                Decimal oldSalary = updateClient.Salary;
                if (oldSalary != clientForm.Salary)
                {

                    ClientOccupationHistory clientOccupationHistory = new ClientOccupationHistory
                    {
                        ClientID = updateClient.ClientID,
                        Salary = oldSalary,
                        Occupation = updateClient.Occupation,
                        LastChangedDate = updateClient.LastChangedDate,
                        LastChangedBy = updateClient.LastChangedBy
                    };
                    _context.Add(clientOccupationHistory);
                }
                if (updateClient.IsNotNull())
                {
                    updateClient.FirstName = clientForm.FirstName;
                    updateClient.TitleID = clientForm.TitleID;
                    updateClient.Initials = clientForm.Initials;
                    updateClient.LastName = clientForm.LastName;
                    updateClient.IsActive = clientForm.IsActive;
                    updateClient.EmailAddress = clientForm.EmailAddress;
                    updateClient.IDNumber = clientForm.IDNumber;
                    updateClient.AddressLine1 = clientForm.AddressLine1;
                    updateClient.AddressLine2 = clientForm.AddressLine2;
                    updateClient.City = clientForm.City;
                    updateClient.CountryID = clientForm.CountryID;
                    updateClient.MobileNumber = clientForm.MobileNumber;
                    updateClient.DateOfBirth = clientForm.DateOfBirth;
                    updateClient.DepartmentID = clientForm.DepartmentID;
                    updateClient.GenderID = clientForm.GenderID;
                    updateClient.LastChangedBy = UserAppData.CurrentUserName;
                    updateClient.LastChangedDate = DateTime.Now;
                    updateClient.Salary = clientForm.Salary;
                    updateClient.Occupation = clientForm.Occupation;
                    updateClient.ClientAccountTypeID = clientForm.ClientAccountTypeID;
                    updateClient.CompanyID = clientForm.CompanyID;
                    updateClient.ClientGroupID = clientForm.ClientGroupID;
                    _context.Update(updateClient);
                }
                result = await _context.SaveChangesAsync();
                if (result > 0)
                {  // also need to update id number and email address on user account 
                    User user = _context.Users.FirstOrDefault(u => u.IDNumber.Equals(oldIDNumber) && u.EmailAddress.Equals(oldEmailAddress));
                    if (user.IsNotNull())
                    {
                        user.EmailAddress = clientForm.EmailAddress;
                        user.IDNumber = clientForm.IDNumber;
                        user.LastChangedBy = UserAppData.CurrentUserName;
                        user.LastChangedDate = DateTime.Now;
                        _context.Update(user);
                        result = await _context.SaveChangesAsync();

                    }

                    if (clientForm.ClientAccountTypeID == (int)Client_AccountType.Joint)
                    {
                        if (clientForm.JointApplicant.IsNotNull())
                        {
                            clientForm.JointApplicant.ClientID = clientForm.ClientID;
                            await Update(clientForm.JointApplicant);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }
        public async Task<int> Save(JointApplicantForm applicantForm)
        {
            try
            {
                JointApplicant updateApplicant = await _context.JointApplicants.FindAsync(applicantForm.JointApplicantID);
                if (updateApplicant.IsNotNull())
                    updateApplicant = await _context.JointApplicants.Where(ja => ja.ClientID == applicantForm.ClientID).FirstOrDefaultAsync();

                if (updateApplicant.IsNotNull())
                    return await Update(applicantForm);

                applicantForm.RecordStatusID = (int)RecordState.Active;
                applicantForm.LastChangedBy = UserAppData.CurrentUserName;
                applicantForm.LastChangedDate = DateTime.Now;
                _context.Add(applicantForm);
                await _context.SaveChangesAsync();

                return applicantForm.JointApplicantID;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        public async Task<int> Update(JointApplicantForm applicant)
        {
            int result = 0;
            try
            {
                JointApplicant jointApplicant = await _context.JointApplicants.FindAsync(applicant.JointApplicantID);
                if (jointApplicant.IsNotNull())
                    jointApplicant = await _context.JointApplicants.Where(ja => ja.ClientID == applicant.ClientID).FirstOrDefaultAsync();

                if (jointApplicant.IsNotNull())
                {
                    jointApplicant.ApplicantTitleID = applicant.ApplicantTitleID;

                    jointApplicant.FirstName = applicant.FirstName;
                    jointApplicant.LastName = applicant.LastName;
                    jointApplicant.Initials = applicant.Initials;
                    jointApplicant.EmailAddress = applicant.EmailAddress;
                    jointApplicant.IDNumber = applicant.IDNumber;
                    jointApplicant.AddressLine1 = applicant.AddressLine1;
                    jointApplicant.AddressLine2 = applicant.AddressLine2;
                    jointApplicant.City = applicant.City;
                    jointApplicant.CountryID = applicant.CountryID;
                    jointApplicant.RelationshipTypeID = applicant.RelationshipTypeID;
                    jointApplicant.MobileNumber = applicant.MobileNumber;
                    jointApplicant.DateOfBirth = applicant.DateOfBirth;
                    jointApplicant.ApplicantGenderID = applicant.ApplicantGenderID;
                    jointApplicant.LastChangedBy = UserAppData.CurrentUserName;
                    jointApplicant.LastChangedDate = DateTime.Now;
                    jointApplicant.RelationshipTypeID = applicant.RelationshipTypeID;
                    _context.Update(jointApplicant);
                    result = await _context.SaveChangesAsync();
                    return result;
                }
                else
                {
                    return await Save(applicant);
                }
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }

        
        public List<ClientList> Clients(string accountNumber = null, bool newClientsOnly = false, int productID = 0, int companyID = 0)
        {
            try
            {
                List<int> ClientIDs = new List<int>();
             
              
                var clients = (from c in _context.Clients
                               join t in _context.Titles on c.TitleID equals t.TitleID
                               join cg in _context.ClientGroups on c.ClientGroupID equals cg.ClientGroupID
                               join cat in _context.ClientAccountTypes on c.ClientAccountTypeID equals cat.ID
                               select c).ToList();
                if (clients == null)
                    return null;
                if (!String.IsNullOrEmpty(accountNumber))
                    clients = clients.Where(m => m.AccountNumber.Contains(accountNumber.Trim())).ToList();
                if (companyID>0)
                    clients = clients.Where(c => c.CompanyID==companyID).ToList();

                if (newClientsOnly)
                    clients = clients.Where(rp => rp.RegistrationDate.Date >= DateTime.Now.AddDays(-1).Date && rp.RegistrationDate.Date <= DateTime.Now.Date).ToList();
                if (productID > 0 && (ClientIDs != null && ClientIDs.Count() > 0))
                    clients = clients.Where(c => ClientIDs.Contains(c.ClientID)).ToList();
                List<ClientList> list = new List<ClientList>();
                foreach (var client in clients)
                {
                    var record = new ClientList
                    {
                        ClientID = client.ClientID,
                        TitleID = client.TitleID,
                        Status = UtilityService.ShowActiveStatus(client.IsActive),
                        AccountType = _context.ClientGroups.Find(client.ClientGroupID)?.Name,
                        Initials = client.Initials,
                        LastName = client.LastName,
                        AccountNumber = client.AccountNumber,
                        IsJointAccount = ((Client_AccountType)client.ClientAccountTypeID == Client_AccountType.Joint),
                        Affiliation = ((Affiliation)client.ClientGroupID == Affiliation.Individual ? Affiliation.Individual.ToString() : (_context.Companies.Find(client.CompanyID)?.Name))
                    };

                    if (record.IsJointAccount)
                    {
                        var jointApplicant = _context.JointApplicants.Where(c => c.ClientID == client.ClientID).FirstOrDefault();
                        if (jointApplicant.IsNotNull())
                        {
                            record.ApplicantTitleID = jointApplicant.ApplicantTitleID;
                            record.JointApplicantInitials = jointApplicant.Initials;
                            record.JointApplicantLastName = jointApplicant.LastName;
                        }
                    }
                    list.Add(record);
                }
                return list.ToList();

            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);

                throw;
            }
        }
       
        public async Task<List<string>> ClientAccountNumbers(string account)
        {
            try
            {
                return await _context.Clients.
            Where(s => s.AccountNumber.ToString()
            .Contains(account)).Select(s => s.AccountNumber.ToString())
            .ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);

                throw;
            }
        }

        #region Client Account No
        public string NewClientAccountNumber
        {
            get
            {
                return GenerateAccountNumber();
            }
        }



        private bool AccountNumberExists(long accountNumber)
        {
            try
            {
                return _context.Clients.Any(m => m.AccountNumber.Equals(accountNumber));
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        string GenerateAccountNumber()
        {
            try
            {
                string _accountNumber;
                string randNum = UtilityService.GenerateRandomNumbers(Convert.ToInt32(_settingService.GetSettingValue(AppSetting.Account_Number_Length))).ToString();
                string accountNum = $"{randNum}";
                long accountNumber = Convert.ToInt64(accountNum);
                string accNumberPrefix = _settingService.GetSettingValue(AppSetting.Account_Number_Prefix);
                if (String.IsNullOrEmpty(accNumberPrefix))
                    _accountNumber = accountNumber.ToString();
                else
                    _accountNumber = accNumberPrefix + accountNumber.ToString();
                if (AccountNumberExists(accountNumber))
                    return GenerateAccountNumber();

                else
                    return _accountNumber;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        #endregion Client Account No

        public async Task<int> ActionClient(int id, DatabaseAction action)
        {
            try
            {
                Client Client = _context.Clients.Find(id);
                if (DatabaseAction.Remove == action)
                    _context.Clients.Remove(Client);
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    Client.IsActive = DatabaseAction.Deactivate != action;
                    Client.LastChangedBy = UserAppData.CurrentUserName;
                    Client.LastChangedDate = DateTime.Now;
                    _context.Update(Client);
                }
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<Company> GetClientCompany(int clientID)
        {
            try
            {

                var client = await _context.Clients.
                 Include(c => c.Company).
                Where(c => c.ClientID == clientID).FirstOrDefaultAsync();
                if (client.IsNull())
                    return null;
                var company = client.Company;
                return company;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        //Notes
        public Comments ClientNotes(int clientID)
        {
            try
            {
                var clientNotes = _context.ClientNotes.
                                Include(ut => ut.UserType).
                     Where(c => c.ClientID == clientID).ToList();

                Comments comments = new Comments
                {
                    ClientID = clientID,
                    ClientForm = FindClient(clientID).Result
                };
                if (clientNotes.ListIsEmpty())
                    return comments;
              
                List<CommentsList> result = new List<CommentsList>();

                foreach (var clientNote in clientNotes)
                {
                    result.Add(new CommentsList
                    {
                        ClientNoteID = clientNote.ClientNoteID,
                        ClientID = clientNote.ClientID,
                        Comment = clientNote.Comment,
                        DateClosed = UtilityService.ShowDateTime(clientNote.DateClosed),
                        DateUploaded = UtilityService.ShowDateTime(clientNote.DateUploaded),
                        DueDate = UtilityService.ShowDateTime(clientNote.DueDate),
                        UploadedBy = clientNote.UploadedBy,
                        VisibleToAdminOnly = clientNote.VisibleToAdminOnly,
                        LastChangedDate = UtilityService.ShowDateTime(clientNote.LastChangedDate),
                        LastChangedBy = clientNote.LastChangedBy,
                        UserTypeName = clientNote.UserType?.Name

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
        public async Task<ClientNote> FindNote(int id)
        {
            try
            {
                return await _context.ClientNotes.
            Include(ut => ut.UserType).
            Include(c => c.Client).ThenInclude(c => c.Title).
            Include(c => c.Client).ThenInclude(c => c.JointApplicant).ThenInclude(ct => ct.Title).
            Include(c => c.Client).ThenInclude(at => at.ClientAccountType).
           Where(t => t.ClientNoteID == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Save(ClientNote ClientNote)
        {
            try
            {
                if (!ClientNote.DueDate.IsNotNull())
                    ClientNote.DueDate = DateTime.Now.AddDays(5);
                if (!ClientNote.DateClosed.IsNotNull())
                    ClientNote.DateClosed = DateTime.MinValue;
                ClientNote.UserTypeID = UserAppData.CurrentUserTypeID;
                ClientNote.UploadedBy = ClientNote.LastChangedBy = UserAppData.CurrentUserName;
                ClientNote.LastChangedDate = DateTime.Now;
                ClientNote.DateUploaded = DateTime.Now;

                _context.Add(ClientNote);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        public async Task<int> Update(ClientNote note)
        {
            try
            {
                ClientNote clientNote = _context.ClientNotes.Find(note.ClientNoteID);
                clientNote.Comment = note.Comment;
                clientNote.DateClosed = note.DateClosed;
                if (note.DueDate.IsNull())
                    clientNote.DueDate = DateTime.Now.AddDays(UtilityService.ClientNotesDefaultDueDateInterval.IsNull() ? 5 : UtilityService.ClientNotesDefaultDueDateInterval);
                else
                    clientNote.DueDate = note.DueDate;
                if (note.DateClosed.IsNull())
                    clientNote.DateClosed = DateTime.MinValue;
                else
                    clientNote.DateClosed = note.DateClosed;
                clientNote.UserTypeID = UserAppData.CurrentUserTypeID;
                clientNote.LastChangedBy = UserAppData.CurrentUserName;
                clientNote.LastChangedDate = DateTime.Now;
                _context.Update(clientNote);
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
                ClientNote ClientNote = await FindNote(id);
                if (DatabaseAction.Remove == action)
                    _context.ClientNotes.Remove(ClientNote);
                if (DatabaseAction.Close == action)
                {
                    ClientNote.DateClosed = DateTime.Now;
                    ClientNote.LastChangedBy = UserAppData.CurrentUserName;
                    ClientNote.LastChangedDate = DateTime.Now;
                    _context.ClientNotes.Update(ClientNote);
                }
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        //Contact
        public Contacts ClientContacts(int clientID)
        {
            try
            {
                var clientContacts = _context.ClientContacts.
                                Include(ct => ct.RelationshipType).
                 Include(ct => ct.ContactType).
                 Where(c => c.ClientID == clientID).ToList();
               
                Contacts contacts = new Contacts
                {
                    ClientID = clientID,
                    ClientForm = FindClient(clientID).Result
                };
                if (clientContacts.ListIsEmpty())
                    return contacts;
                List<ContactList> result = new List<ContactList>();

                foreach (var clientContact in clientContacts)
                {
                    result.Add(new ContactList
                    {
                        ClientID = clientID,
                        ClientContactID = clientContact.ClientContactID,
                        Relationship = clientContact.RelationshipType?.Name,
                        ContactType = clientContact.ContactType.Name,
                        ContactPerson = clientContact.ContactPerson,
                        Information = clientContact.Contact

                    });
                }
                contacts.ContactLists = result;
                return contacts;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<ClientContact> FindContact(int id)
        {
            try
            {
                var clientContact = await _context.ClientContacts.
            Include(c => c.Client).ThenInclude(c => c.Title).
        Include(c => c.Client).ThenInclude(c => c.JointApplicant).ThenInclude(ct => ct.Title).
        Where(t => t.ClientContactID == id).FirstOrDefaultAsync();
                if (clientContact.IsNull())
                    return null;
                return clientContact;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Save(ClientContact ClientContact)
        {
            try
            {

                ClientContact.LastChangedBy = UserAppData.CurrentUserName;
                ClientContact.LastChangedDate = DateTime.Now;
                _context.Add(ClientContact);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        public async Task<int> Update(ClientContact Clientcontact)
        {
            try
            {
                ClientContact update = _context.ClientContacts.
                Where(t => t.ClientContactID == Clientcontact.ClientContactID).FirstOrDefault();

                update.RelationshipTypeID = Clientcontact.RelationshipTypeID;
                update.ContactTypeID = Clientcontact.ContactTypeID;
                update.ContactPerson = Clientcontact.ContactPerson;
                update.Contact = Clientcontact.Contact;
                update.LastChangedBy = UserAppData.CurrentUserName;
                update.LastChangedDate = DateTime.Now;
                _context.Entry(update).State = EntityState.Modified;
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> ActionContact(int id, DatabaseAction action)
        {
            try
            {
                ClientContact contact = await FindContact(id);
                if (DatabaseAction.Remove == action)
                    _context.ClientContacts.Remove(contact);
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    contact.LastChangedBy = UserAppData.CurrentUserName;
                    contact.LastChangedDate = DateTime.Now;
                    _context.Update(contact);
                }
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        //Document
        public Docs ClientDocuments(int clientID)
        {
            try
            {
                var clientDocs = _context.ClientDocuments.
                Include(cd => cd.DocumentType).
                Where(c => c.ClientID == clientID).ToList();
                Docs docs = new Docs
                {
                    ClientID = clientID,
                    ClientForm = FindClient(clientID).Result
                };
                if (clientDocs.ListIsEmpty())
                 
                return docs;
               
                List<DocumentList> result = new List<DocumentList>();

                foreach (var document in clientDocs)
                {
                    result.Add(new DocumentList
                    {
                        ClientDocumentID = document.ClientDocumentID,
                        ClientID = document.ClientID,
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
        public async Task<ClientDocument> FindDocument(int id)
        {
            try
            {
                return await _context.ClientDocuments.
                 Include(dt => dt.DocumentType).
                 Include(c => c.Client).ThenInclude(c => c.Title).
                 Include(c => c.Client).ThenInclude(c => c.JointApplicant).ThenInclude(ct => ct.Title).
                 Include(c => c.Client).ThenInclude(at => at.ClientAccountType).
                 Where(t => t.ClientDocumentID == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> Save(ClientDocument ClientDocument)
        {
            try
            {
                ClientDocument.UploadedBy = ClientDocument.LastChangedBy = UserAppData.CurrentUserName;
                ClientDocument.DateUploaded = ClientDocument.LastChangedDate = DateTime.Now;
                _context.Add(ClientDocument);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        public async Task<int> Update(ClientDocument document)
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

                ClientDocument ClientDocument = await FindDocument(id);
                if (DatabaseAction.Remove == action)
                    _context.ClientDocuments.Remove(ClientDocument);

                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<bool> DocumentUploaded(int clientID, int documentTypeID)
        {
            try
            {


                ClientDocument clientDocument = await _context.ClientDocuments.Where(c => c.ClientID == clientID && c.DocumentTypeID == documentTypeID).FirstOrDefaultAsync();
                bool result = clientDocument.IsNotNull();

                return result;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public SalaryHistory SalaryHistory(int clientID)
        {
            try
            {
                var transactions = _context.ClientOccupationHistory.
                               Where(c => c.ClientID == clientID).ToList();
                if (transactions.ListIsEmpty())
                    return null;
                SalaryHistory history = new SalaryHistory
                {
                    ClientID = clientID,
                    ClientForm = FindClient(clientID).Result
                };
                List<SalaryHistoryList> result = new List<SalaryHistoryList>();

                foreach (var transaction in transactions)
                {
                    result.Add(new SalaryHistoryList
                    {

                        Occupation = transaction.Occupation,
                        Salary = transaction.Salary,
                        LastChangedDate = UtilityService.ShowDateTime(transaction.LastChangedDate),
                        LastChangedBy = transaction.LastChangedBy,
                    });
                }
                history.SalaryHistoryList = result;
                return history;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public Dependents ClientDependents(int clientID)
        {
            try
            {
                var clientDependents = _context.ClientDependents.
                                                     Where(c => c.ClientID == clientID).ToList();
                if (clientDependents.IsNull())
                    return null;
                Dependents dependents = new Dependents
                {
                    ClientID = clientID,
                    ClientForm = FindClient(clientID).Result
                };
                List<DependentsList> result = new List<DependentsList>();

                foreach (var clientDependent in clientDependents)
                {
                    result.Add(new DependentsList
                    {
                        ClientDependentID = clientDependent.ClientDependentID,
                        ClientID = clientDependent.ClientID,
                        FullName = clientDependent.FullName,
                        Age = clientDependent.Age.ToString(),
                        IDNumber = clientDependent.IDNumber,
                        Gender = ((GenderOrientation)clientDependent.GenderID).ToString(),
                        Occupation = clientDependent.Occupation
                    });
                }
                dependents.DependentsList = result;
                return dependents;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<ClientDependent> FindDependent(int id)
        {
            try
            {
                return await _context.ClientDependents.
                 Include(c => c.Client).ThenInclude(c => c.Title).
                  Include(c => c.Client).ThenInclude(c => c.JointApplicant).ThenInclude(ct => ct.Title).
                  Include(c => c.Client).ThenInclude(at => at.ClientAccountType).
                  Where(t => t.ClientDependentID == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> Save(ClientDependent ClientDependent)
        {
            try
            {
                ClientDependent.RegistrationDate = DateTime.Now;
                ClientDependent.LastChangedBy = UserAppData.CurrentUserName;
                ClientDependent.LastChangedDate = DateTime.Now;
                _context.Add(ClientDependent);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        public async Task<int> Update(ClientDependent ClientDependent)
        {
            try
            {

                ClientDependent dependent = _context.ClientDependents.Find(ClientDependent.ClientDependentID);
                dependent.DateOfBirth = ClientDependent.DateOfBirth;
                dependent.IDNumber = ClientDependent.IDNumber;
                dependent.FirstName = ClientDependent.FirstName;
                dependent.Occupation = ClientDependent.Occupation;
                dependent.IsActive = ClientDependent.IsActive;
                dependent.ClientID = ClientDependent.ClientID;
                dependent.LastName = ClientDependent.LastName;
                dependent.GenderID = ClientDependent.GenderID;
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

                ClientDependent clientDependent = await FindDependent(id);
                if (DatabaseAction.Remove == action)
                    _context.ClientDependents.Remove(clientDependent);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

  

        public Transactions PaidTransactions(int clientID)
        {
            try
            {
                var transactions = _context.Transactions.
                Include(t => t.PaymentStatus).
                Include(t => t.Product).
                //Include(t => t.Course).
                 Where(c => c.ClientID == clientID).ToList();
                if (transactions.ListIsEmpty())
                    return null;
                Transactions trans = new Transactions
                {
                    ClientID = clientID,
                    ClientForm = FindClient(clientID).Result
                };
                List<TransactionList> result = new List<TransactionList>();

                foreach (var transaction in transactions)
                {
                    result.Add(new TransactionList
                    {
                        TransactionID = transaction.TransactionID,
                        ClientID = transaction.ClientID,
                        Amount = transaction.TotalPaid,
                        TransactionDatePaid = UtilityService.ShowDateTime(transaction.TransactionDate),
                        PaymentDate = UtilityService.ShowDateTime(transaction.PaymentDate),
                        PaymentStatus = transaction.PaymentStatus.Name,
                        TransactionDate = transaction.TransactionDate,
                        TransRef = transaction.TransRef,
                        TransType = transaction.TransactionType.Name,
                        Entity = transaction.Entity
                    });
                }
                trans.TransactionList = result;
                return trans;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

     

        #region Helpers
        ClientForm GetClient(Client result)
        {
            try
            {
                ClientForm clientForm = new ClientForm
                {
                    ClientID = result.ClientID,
                    TitleID = result.TitleID,
                    GenderID = result.GenderID,
                    AccountNumber = result.AccountNumber,
                    DateOfBirth = result.DateOfBirth,
                    Initials = result.Initials,
                    FirstName = result.FirstName,
                    LastName = result.LastName,
                    IDNumber = result.IDNumber,
                    EmailAddress = result.EmailAddress,
                    MobileNumber = result.MobileNumber,
                    AddressLine1 = result.AddressLine1,
                    AddressLine2 = result.AddressLine2,
                    City = result.City,
                    CountryID = result.CountryID,
                    Country = result.CountryID.HasValue ? GetCountryName(result.CountryID.Value) : null,
                    Occupation = result.Occupation,
                    Salary = result.Salary,
                    ClientAccountTypeID = result.ClientAccountTypeID,
                    ClientGroupID = result.ClientGroupID,
                    CompanyID = result.CompanyID,
                    DepartmentID = result.DepartmentID,
                    IsActive = result.IsActive,
                    RegistrationDate = result.RegistrationDate,
                                        LastChangedBy = result.LastChangedBy,
                    LastChangedDate = result.LastChangedDate,
                    IsJointAccount = result.ClientAccountTypeID == (int)Client_AccountType.Joint
                };

                if (clientForm.IsJointAccount)
                    clientForm.JointApplicant = GetJointApplicant(result.JointApplicant);
                return clientForm;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }

        private string GetCountryName(int countryID)
        {
            try
            {
                var country = _context.Countries.Find(countryID);
                return country?.Name;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        ClientPeek PeekClient(Client result)
        {
            try
            {
                ClientPeek clientPeek = new ClientPeek
                {
                    ClientID = result.ClientID,
                    DateOfBirth = result.DateOfBirth,
                    Initials = result.Initials,
                    FirstName = result.FirstName,
                    LastName = result.LastName,
                    IDNumber = result.IDNumber,
                    EmailAddress = result.EmailAddress,
                                       AccountNumber = result.AccountNumber
                };
                return clientPeek;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        #endregion Helpers
    }
}
