﻿using Microsoft.EntityFrameworkCore;
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
        public async Task<ClientKonapoFunds> GetClientKonapoFunds(int clientID)
        {
            try
            {
             var konapo = await _context.KonapoFunds.Where(p => p.ClientID == clientID)
               .Include(m => m.Client)
                               .Include(p => p.Fund)
                .ThenInclude(p => p.FundCategories)
                .ThenInclude(p => p.FundCategoryItems)
             .AsNoTracking()
             .ToListAsync();

                ClientKonapoFunds clientKonapoFunds = new ClientKonapoFunds
                {
                    ClientID = clientID,
                    KonapoFunds = konapo
                };
             return clientKonapoFunds;
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

                client.UserName = UtilityService.GenerateUserName(clientForm.FirstName, clientForm.LastName);
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

        public Register AttendanceRegisters(int clientID)
        {
            try
            {
                var registers = _context.AttendanceRegisterDetails.
                   Include(c => c.AttendanceRegister).
                   ThenInclude(c => c.CourseTopic).
                   ThenInclude(c => c.CourseSessions).
                                     Include(c => c.AttendanceRegister).
                                       ThenInclude(c => c.CourseIntake).
                       ThenInclude(c => c.Course).
                   Include(c => c.Client).
                   Where(c => c.ClientID == clientID).
                   OrderByDescending(c => c.AttendanceRegister.AttendanceDate).ToList();

                if (registers.IsNotNull())
                    return null;
                Register register = new Register
                {
                    ClientID = clientID,
                    ClientForm = FindClient(clientID).Result
                };
                List<RegisterList> result = new List<RegisterList>();

                foreach (var registerDetail in registers)
                {
                    result.Add(new RegisterList
                    {
                        AttendanceRegisterDetailID = registerDetail.AttendanceRegisterDetailID,
                        ClientID = registerDetail.ClientID,
                        AttendanceDate = registerDetail.AttendanceRegister.AttendanceDate,
                        Intake = registerDetail.AttendanceRegister.CourseIntake.Duration,
                        Status = registerDetail.AttendanceStatus,
                        Course = registerDetail.AttendanceRegister.CourseTopic.Course?.Title,
                        CourseTopic = $"{registerDetail.AttendanceRegister.CourseTopic.Course?.Title} - {registerDetail.AttendanceRegister.CourseTopic?.Name}",

                    });
                }
                register.RegisterList = result;
                return register;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);

                throw;
            }

        }
        public List<ClientList> Clients(string accountNumber = null, bool newClientsOnly = false, int productID = 0)
        {
            try
            {
                List<int> ClientIDs = new List<int>();
                if (productID > 0)
                    ClientIDs = ClientProductIDs(productID);
                var clients = (from c in _context.Clients
                               join t in _context.Titles on c.TitleID equals t.TitleID
                               join cg in _context.ClientGroups on c.ClientGroupID equals cg.ClientGroupID
                               join cat in _context.ClientAccountTypes on c.ClientAccountTypeID equals cat.ID
                               select c).ToList();
                if (clients == null)
                    return null;
                if (!String.IsNullOrEmpty(accountNumber))
                    clients = clients.Where(m => m.AccountNumber.Contains(accountNumber.Trim())).ToList();

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
        private List<int> ClientProductIDs(int productID)
        {
            try
            {
                var clients = _context.ClientProducts.
        Where(p => p.ProductID == productID).Select(c => c.ClientID).ToList();
                return clients;
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
                if (clientNotes.ListIsEmpty())
                    return null;
                Comments comments = new Comments
                {
                    ClientID = clientID,
                    ClientForm = FindClient(clientID).Result
                };
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
                if (clientContacts.ListIsEmpty())
                    return null;
                Contacts contacts = new Contacts
                {
                    ClientID = clientID,
                    ClientForm = FindClient(clientID).Result
                };
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
                if (clientDocs.ListIsEmpty())
                    return null;
                Docs docs = new Docs
                {
                    ClientID = clientID,
                    ClientForm = FindClient(clientID).Result
                };
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

        //MedicalDetail
        public Medical MedicalFiles(int clientID)
        {
            try
            {
                var medicalDetails = _context.ClientMedicalDetails.
                               Where(c => c.ClientID == clientID).ToList();
                if (medicalDetails.ListIsEmpty())
                    return null;
                Medical medical = new Medical
                {
                    ClientID = clientID,
                    ClientForm = FindClient(clientID).Result
                };
                List<MedicalList> result = new List<MedicalList>();

                foreach (var medicalDetail in medicalDetails)
                {
                    result.Add(new MedicalList
                    {
                        ClientMedicalID = medicalDetail.ClientMedicalID,
                        ClientID = medicalDetail.ClientID,
                        Telephone = medicalDetail.Telephone,
                        MedicalAid = medicalDetail.MedicalAid,
                        MedicalAidNo = medicalDetail.MedicalAidNo,
                        Hospital = medicalDetail.Hospital,
                        Doctor = medicalDetail.Doctor
                    });
                }
                medical.MedicalList = result;
                return medical;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<ClientMedicalDetail> FindMedicalDetail(int id)
        {
            try
            {
                return await _context.ClientMedicalDetails.
                 Include(c => c.Client).ThenInclude(c => c.Title).
                 Include(c => c.Client).ThenInclude(c => c.JointApplicant).ThenInclude(ct => ct.Title).
                 Include(c => c.Client).ThenInclude(at => at.ClientAccountType).
                Where(t => t.ClientMedicalID == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Save(ClientMedicalDetail ClientMedicalDetail)
        {
            try
            {

                ClientMedicalDetail.LastChangedBy = UserAppData.CurrentUserName;
                ClientMedicalDetail.LastChangedDate = DateTime.Now;
                _context.Add(ClientMedicalDetail);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        public async Task<int> Update(ClientMedicalDetail MedicalDetail)
        {
            try
            {
                ClientMedicalDetail medicalDetail = _context.ClientMedicalDetails.Find(MedicalDetail.ClientMedicalID);
                medicalDetail.MedicalAid = MedicalDetail.MedicalAid;
                medicalDetail.MedicalAidNo = MedicalDetail.MedicalAidNo;
                medicalDetail.Allergies = MedicalDetail.Allergies;
                medicalDetail.Doctor = MedicalDetail.Doctor;
                medicalDetail.Hospital = MedicalDetail.Doctor;
                medicalDetail.Other = MedicalDetail.Other;
                medicalDetail.Telephone = MedicalDetail.Telephone;
                medicalDetail.LastChangedBy = UserAppData.CurrentUserName;
                medicalDetail.LastChangedDate = DateTime.Now;
                medicalDetail.PrescribedMedication = MedicalDetail.PrescribedMedication;
                _context.Update(medicalDetail);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> ActionMedicalDetail(int id, DatabaseAction action)
        {
            try
            {
                ClientMedicalDetail ClientMedicalDetail = await FindMedicalDetail(id);
                if (DatabaseAction.Remove == action)
                    _context.ClientMedicalDetails.Remove(ClientMedicalDetail);
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    ClientMedicalDetail.LastChangedBy = UserAppData.CurrentUserName;
                    ClientMedicalDetail.LastChangedDate = DateTime.Now;
                    _context.Update(ClientMedicalDetail);
                }
                return (await _context.SaveChangesAsync());
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

        // Client Product
        public async Task<ClientProduct> FindProduct(int id)
        {
            try
            {

                return await _context.ClientProducts.
                Include(c => c.Product).
                Include(c => c.Client).ThenInclude(c => c.Title).
                Include(c => c.Client).ThenInclude(c => c.JointApplicant).ThenInclude(ct => ct.Title).
                Include(c => c.Client).ThenInclude(at => at.ClientAccountType).
                Where(t => t.ClientProductID == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> Save(ClientProduct clientProduct)
        {
            try
            {
                int result = 0;
                clientProduct.LastChangedBy = UserAppData.CurrentUserName;
                clientProduct.LastChangedDate = DateTime.Now;
                _context.Add(clientProduct);
                result = await _context.SaveChangesAsync();
                if (result > 0)
                {
                    //Add Fees to client
                    var productFees = _context.ProductFees.Where(p => p.ProductID == clientProduct.ProductID);
                    foreach (var productFee in productFees)
                    {
                        DateTime dueDate = DateTime.Now;
                        FrequencyList frequencyList = (FrequencyList)productFee.FrequencyID;
                        if (frequencyList == FrequencyList.Once_Off)
                        {
                            ClientFee clientFee = new ClientFee
                            {
                                ClientID = clientProduct.ClientID,
                                ProductFeeID = productFee.ProductFeeID,
                                Amount = productFee.Amount,
                                LastChangedBy = UserAppData.CurrentUserName,
                                LastChangedDate = DateTime.Now,
                                ClientProductID = clientProduct.ClientProductID,
                                DueDate = dueDate
                            };
                            _context.Add(clientFee);
                        }

                        if (frequencyList == FrequencyList.Monthly)
                        {
                            for (int i = 1; i < 13; i++)
                            {
                                ClientFee clientFee = new ClientFee
                                {
                                    ClientID = clientProduct.ClientID,
                                    ProductFeeID = productFee.ProductFeeID,
                                    Amount = productFee.Amount,
                                    LastChangedBy = UserAppData.CurrentUserName,
                                    LastChangedDate = DateTime.Now,
                                    ClientProductID = clientProduct.ClientProductID,
                                    DueDate = dueDate
                                };
                                _context.Add(clientFee);

                                dueDate = dueDate.AddMonths(i);
                            }
                        }
                    }
                    if (productFees.Count() > 0)
                        result = await _context.SaveChangesAsync();
                }
                return result;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Update(ClientProduct clientProduct)
        {
            try
            {
                ClientProduct ClientProduct = _context.ClientProducts.Find(clientProduct.ClientProductID);
                ClientProduct.IncreamentPercentage = clientProduct.IncreamentPercentage;
                ClientProduct.DeductionPercentage = clientProduct.DeductionPercentage;
                ClientProduct.IsActive = clientProduct.IsActive;
                ClientProduct.DoNotDeduct = clientProduct.DoNotDeduct;
                ClientProduct.LastChangedBy = UserAppData.CurrentUserName;
                ClientProduct.LastChangedDate = DateTime.Now;
                _context.Update(ClientProduct);
                int _result = await _context.SaveChangesAsync();
                return _result;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> ActionProduct(int id, DatabaseAction action)
        {
            try
            {
                ClientProduct ClientProduct = _context.ClientProducts.Find(id);
                if (DatabaseAction.Remove == action)
                    _context.ClientProducts.Remove(ClientProduct);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public ClientPackages GetClientProducts(int clientID)
        {
            try
            {
                var products = _context.ClientProducts.
                              Include(p => p.Product).
                Where(t => t.ClientID == clientID).ToList();
                if (products.ListIsEmpty())
                    return null;
                ClientPackages packages = new ClientPackages
                {
                    ClientID = clientID,
                    ClientForm = FindClient(clientID).Result
                };
                List<ProductList> result = new List<ProductList>();

                foreach (var product in products)
                {
                    result.Add(new ProductList
                    {
                        ClientProductID = product.ClientProductID,
                        ClientID = product.ClientID,
                        Status = UtilityService.ShowActiveStatus(product.IsActive),
                        ProductName = product.Product.Name,
                        DateRegistered = product.DateRegistered,
                        RegistrationDate = UtilityService.ShowDateTime(product.DateRegistered),
                        LastChangedBy = product.LastChangedBy,
                        LastChangedDate = UtilityService.ShowDateTime(product.LastChangedDate),
                        DeductionToBeApplied = product.DeductionToBeApplied
                    });
                }
                packages.ProductList = result;
                return packages;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<Product> GetClientRegisteredProducts(int id)
        {
            try
            {
                var productids = _context.ClientProducts.
             Where(t => t.ClientID == id).Select(p => p.ProductID);
                return _context.Products.
                Where(t => productids.Contains(t.ProductID)).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        //Client Course
        public int AttendedSessions(int clientCourseID)
        {
            try
            {
                var result = _context.ClientTranscripts.Where(ct => ct.ClientCourseID == clientCourseID).ToList();
                if (result == null)
                    return 0;
                return result.Count();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public int GetCourseSessions(int courseTopicID)
        {
            try
            {
                var result = _context.CourseSessions.Where(ct => ct.CourseTopicID == courseTopicID).ToList();
                if (result == null)
                    return 0;
                return result.Count();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public CoachingProgrammes Courses(int clientID)
        {
            try
            {
                var transactions = _context.ClientCourses.
                 Include(c => c.CourseIntake).
                Include(c => c.Course).
                ThenInclude(c => c.CourseTopics).
                ThenInclude(c => c.CourseSessions).
                 Where(c => c.ClientID == clientID).ToList();
                if (transactions.ListIsEmpty())
                    return null;
                CoachingProgrammes course = new CoachingProgrammes
                {
                    ClientID = clientID,
                    ClientForm = FindClient(clientID).Result
                };
                List<CourseList> result = new List<CourseList>();

                foreach (var transaction in transactions.Distinct())
                {
                    result.Add(new CourseList
                    {

                        CourseID = transaction.CourseID,
                        ClientID = transaction.ClientID,
                        ClientCourseID = transaction.ClientCourseID,
                        CourseIntakeID = transaction.CourseIntakeID,
                        DateCompleted = transaction.DateCompleted.HasValue ? UtilityService.ShowDateTime(transaction.DateCompleted.Value) : "Not Complete",
                        Intake = transaction.CourseIntake?.Duration,
                        Topics = transaction.Course.CourseTopics == null ? 0 : transaction.Course.CourseTopics.Count(),
                        Sessions = (transaction.Course.CourseTopics == null && transaction.Course.CourseTopics.Select(c => c.CourseSessions) == null) ? 0 : transaction.Course.CourseTopics.Sum(c => c.CourseSessions.Count),
                        CompletedSessions = transaction.Course.CourseTopics == null ? 0 : AttendedSessions(transaction.ClientCourseID),
                        Status = UtilityService.ShowYesOrNo(transaction.IsDeRegistered),
                        CourseName = transaction.Course.Title,
                        RegistrationDate = UtilityService.ShowDateTime(transaction.DateRegistered),
                        DateRegistered = transaction.DateRegistered,

                    });
                }
                course.CourseList = result;
                return course;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<ClientCourse> FindCourse(int id)
        {
            try
            {
                return await _context.ClientCourses.
                 Include(c => c.Client).ThenInclude(c => c.Title).
                  Include(c => c.Client).ThenInclude(c => c.JointApplicant).ThenInclude(ct => ct.Title).
                  Include(c => c.Client).ThenInclude(at => at.ClientAccountType).
                  Include(c => c.Course).
                  ThenInclude(c => c.CourseTopics).
                  Include(c => c.Course).
                  ThenInclude(c => c.CourseIntakes).
                 Where(t => t.ClientCourseID == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Save(ClientCourse ClientCourse)
        {
            try
            {
                ClientCourse.DateRegistered = DateTime.Now;
                ClientCourse.LastChangedBy = UserAppData.CurrentUserName;
                ClientCourse.LastChangedDate = DateTime.Now;
                _context.Add(ClientCourse);
                int _result = await _context.SaveChangesAsync();
                if (_result > 0)
                {
                    //Add Fees to client
                    var courseFees = _context.CourseFees.Where(c => c.CourseID == ClientCourse.CourseID);
                    foreach (var courseFee in courseFees)
                    {
                        DateTime dueDate = DateTime.Now;
                        FrequencyList frequencyList = (FrequencyList)courseFee.FrequencyID;
                        if (frequencyList == FrequencyList.Once_Off)
                        {
                            ClientFee clientFee = new ClientFee
                            {
                                ClientID = ClientCourse.ClientID,
                                CourseFeeID = courseFee.CourseFeeID,
                                Amount = courseFee.Amount,
                                LastChangedBy = UserAppData.CurrentUserName,
                                LastChangedDate = DateTime.Now,
                                ClientCourseID = ClientCourse.ClientCourseID,
                                DueDate = dueDate
                            };
                            _context.Add(clientFee);
                        }

                        if (frequencyList == FrequencyList.Monthly)
                        {
                            for (int i = 1; i < 13; i++)
                            {
                                ClientFee clientFee = new ClientFee
                                {
                                    ClientID = ClientCourse.ClientID,
                                    CourseFeeID = courseFee.CourseFeeID,
                                    Amount = courseFee.Amount,
                                    LastChangedBy = UserAppData.CurrentUserName,
                                    LastChangedDate = DateTime.Now,
                                    ClientCourseID = ClientCourse.ClientCourseID,
                                    DueDate = dueDate
                                };
                                _context.Add(clientFee);
                                dueDate = dueDate.AddMonths(i);
                            }
                        }
                    }
                    if (courseFees.Count() > 0)
                        _result = await _context.SaveChangesAsync();
                }
                return _result;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> Update(ClientCourse Course)
        {
            try
            {
                ClientCourse course = _context.ClientCourses.Find(Course.ClientCourseID);
                course.CourseID = Course.CourseID;
                course.DateCompleted = Course.DateCompleted;
                course.IsDeRegistered = Course.IsDeRegistered;
                course.LastChangedBy = UserAppData.CurrentUserName;
                course.LastChangedDate = DateTime.Now;
                _context.Update(course);

                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

      
        public async Task<bool> MaximumCourseLimitReached(int courseIntakeID)
        {
            try
            {

                //1.Same course is still not completed or not deregistered
                var students = await _context.ClientCourses.Where(c => c.CourseIntakeID == courseIntakeID).ToListAsync();
                int studentCount = 0;
                if (students != null)
                    studentCount = students.Count();
                int courseCapacity = 0;
                var courseLimit = await _context.CourseIntakes.Where(c => c.CourseIntakeID == courseIntakeID).FirstOrDefaultAsync();
                if (courseLimit != null)
                    courseCapacity = courseLimit.MaximumCapacity;
                bool result =(studentCount>=courseCapacity);
                return result;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<bool> HasActiveEnrollement(int clientID, int courseID)
        {
            try
            {

                //1.Same course is still not completed or not deregistered
                ClientCourse course = await _context.ClientCourses.Where(c => c.ClientID == clientID && c.CourseID == courseID && !c.DateCompleted.HasValue && !c.IsDeRegistered).FirstOrDefaultAsync();
                bool result = course.IsNotNull();

                return result;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public async Task<int> ActionCourse(int id)
        {
            try
            {

                ClientCourse course = _context.ClientCourses.Find(id);
                course.IsDeRegistered = true;
                course.LastChangedBy = UserAppData.CurrentUserName;
                course.LastChangedDate = DateTime.Now;
                _context.Update(course);

                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> UpdateSessions(int clientCourseID, string[] selectedSessions)
        {
            int result = 0;
            try
            {
                IEnumerable<int> courseOutlines = from c in _context.ClientTranscripts
                                                  where c.ClientCourseID == clientCourseID
                                                  select c.CourseSessionID;
                List<int> old_sessions = courseOutlines.ToList();
                List<int> add_sessions = new List<int>();
                List<int> remove_sessions = new List<int>();
                int[] updated_Details = selectedSessions == null ? null : Array.ConvertAll(selectedSessions, s => int.Parse(s));


                if (old_sessions == null && old_sessions.Count == 0)
                {
                    add_sessions = updated_Details.ToList();
                    return await AddSessions(clientCourseID, add_sessions);
                }
                foreach (var courseSession in _context.CourseSessions)
                {
                    if (selectedSessions.Contains(courseSession.CourseSessionID.ToString()))
                    {
                        if (!old_sessions.Contains(courseSession.CourseSessionID))
                        {
                            add_sessions.Add(courseSession.CourseSessionID);
                        }
                    }
                    else
                    {
                        if (old_sessions.Contains(courseSession.CourseSessionID))
                        {
                            remove_sessions.Add(courseSession.CourseSessionID);
                        }
                    }
                }
                int _addResult = await AddSessions(clientCourseID, add_sessions);
                int _removeResult = await RemoveSessions(clientCourseID, remove_sessions);
                result = _addResult + _removeResult;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                return 0;
            }
            return result;
        }

        public async Task<int> AddSessions(int clientCourseID, List<int> sessions)
        {
            try
            {
                foreach (int sessionid in sessions)
                {
                    ClientTranscript transcript = new ClientTranscript
                    {
                        ClientCourseID = clientCourseID,
                        CourseSessionID = sessionid,
                        DateCompleted = DateTime.Now,
                        LastChangedBy = UserAppData.CurrentUserName,
                        LastChangedDate = DateTime.Now
                    };
                    _context.Add(transcript);

                }
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                return 0;
            }
        }
        public async Task<int> RemoveSessions(int clientCourseID, List<int> sessions)
        {
            try
            {

                List<ClientTranscript> courseTranscripts = await _context.ClientTranscripts.Where(r => r.ClientCourseID == clientCourseID).ToListAsync();
                var transcriptsToBeRemoved = courseTranscripts
                        .Where(x => sessions.Any(y => y == x.CourseSessionID));
                _context.ClientTranscripts.RemoveRange(transcriptsToBeRemoved);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public InvoicePackage GetPotentialInvoiceEntries(int InvoiceID, int ProductID, DateTime InvoiceDate)
        {
            try
            {

                var invoice = _context.Invoices.Find(InvoiceID);
                if (invoice.IsNull())
                    return null;

                InvoicePackage invoicePackage = new InvoicePackage
                {
                    InvoiceDetail = invoice
                };
                List<InvoiceEntries> invoiceEntries = new List<InvoiceEntries>();

                IEnumerable<int> ClientIDs;
                if (ProductID == 0)
                {
                    ClientIDs = from c in _context.ClientProducts
                                select c.ClientID;
                }
                else
                {
                    ClientIDs = from c in _context.ClientProducts
                                where c.ProductID == ProductID
                                select c.ClientID;
                }
                var clientProducts = _context.ClientProducts.
                Include(c => c.Product).
                Where(t => ClientIDs.Contains(t.ClientID)).ToList();

                foreach (var item in clientProducts)
                {

                    ClientForm client = FindClient(item.ClientID).Result;
                    invoiceEntries.Add(new InvoiceEntries
                    {
                        ClientProductID = item.ClientProductID,
                        ClientID = item.ClientID,
                        ClientFullName = client.ClientFullName,
                        Occupation = client.Occupation,
                        Salary = client.Salary,
                        ProductID = item.ProductID,
                        ProductName = item.Product.Name,
                        InvoiceDate = InvoiceDate,
                        DeductionToBeApplied = item.DoNotDeduct ? "Do Not Deduct" : (!item.DoNotDeduct && item.DeductionPercentage.HasValue ? "Deduct At Individual Level" : "Deduct At Product Level")

                    });
                }
                invoicePackage.Entries = invoiceEntries;
                return invoicePackage;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        // ClientFees
        public async Task<ClientFee> FindClientFee(int id)
        {
            try
            {
                return await _context.ClientFees.
                 Include(c => c.Client).ThenInclude(c => c.Title).
                 Include(c => c.Client).ThenInclude(c => c.JointApplicant).ThenInclude(ct => ct.Title).
                 Include(c => c.Client).ThenInclude(at => at.ClientAccountType).
                 Include(c => c.ProductFee).
                 ThenInclude(c => c.Product).
                 Include(c => c.CourseFee).
                 ThenInclude(c => c.Course).
                Where(t => t.ClientFeeID == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<ClientFee> ClientFees(int clientID)
        {
            try
            {

                return _context.ClientFees.
                 Include(c => c.Client).ThenInclude(c => c.Title).
                 Include(c => c.Client).ThenInclude(c => c.JointApplicant).ThenInclude(ct => ct.Title).
                 Include(c => c.Client).ThenInclude(at => at.ClientAccountType).
                 Include(c => c.ProductFee).
                  ThenInclude(c => c.Frequency).
                  Include(c => c.ProductFee).
                 ThenInclude(c => c.Product).
                 Include(c => c.CourseFee).
                 ThenInclude(c => c.Course).
                 AsNoTracking().
                Where(t => t.ClientID == clientID).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        // ClientFees
        public async Task<int> PayFee(ClientFee clientFee)
        {
            try
            {

                int _TransactionID = 0;
                ClientFee _clientFee = _clientFee = _context.ClientFees.
                   Include(c => c.ProductFee).
                   ThenInclude(c => c.Product).
                     Include(c => c.CourseFee).
                 ThenInclude(c => c.Course).
                              Where(c => c.ClientFeeID == clientFee.ClientFeeID).
                   FirstOrDefault();


                if (_clientFee.IsNull())
                    return 0;

                Transaction addPaymentsFile = new Transaction()
                {
                    Year = DateTime.Now.Year,
                    Month = DateTime.Now.Month,
                    Amount = UserAppData.HasPermission(Permissions.Override_Payment) ? clientFee.Amount : _clientFee.Amount,
                    ClientID = clientFee.ClientID,
                    PaymentDate = DateTime.Now,
                    PaymentStatusID = (int)PaymentState.Paid,
                    TransactionDate = DateTime.Now,
                    LastChangedBy = UserAppData.CurrentUserName,
                    LastChangedDate = DateTime.Now,
                    BankAccountID = clientFee.BankAccountID,
                    TransactionTypeID = (int)TransactionTypeList.Fee,
                    ClientFeeID = _clientFee.ClientFeeID,
                };
                if (clientFee.ProductFeeID.HasValue)
                {
                    addPaymentsFile.ProductID = clientFee.ProductID;
                    addPaymentsFile.Narration = _clientFee.ProductFee.Name;
                }
                if (clientFee.CourseFeeID.HasValue)
                {
                    addPaymentsFile.CourseID = clientFee.CourseID;
                    addPaymentsFile.Narration = _clientFee.CourseFee.Name;
                }
                _TransactionID = await _transactionService.CreatePayment(addPaymentsFile, TransactionTypeList.Fee);
                if (_TransactionID > 0)
                {

                    _clientFee.DatePaid = DateTime.Now;
                    _clientFee.LastChangedBy = UserAppData.CurrentUserName;
                    _clientFee.LastChangedDate = DateTime.Now;
                    _context.Update(_clientFee);
                    await _context.SaveChangesAsync();
                }
                return _TransactionID;
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
                Include(t => t.Course).
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

        public PendingTransactions PendingTransactions(int clientID, DateTime cutoffDate)
        {
            try
            {
                var transactions = _context.ClientFees.
                                //  Include(p => p.ClientProducts).ThenInclude(p => p.Product).
                                Include(p => p.ProductFee).ThenInclude(p => p.Product).
                                Include(p => p.ProductFee).ThenInclude(p => p.Frequency).
                                Include(p => p.CourseFee).ThenInclude(p => p.Course).
                                Include(p => p.CourseFee).ThenInclude(p => p.Frequency).

                Where(c => c.ClientID == clientID && !c.DatePaid.HasValue && c.DueDate.Date < cutoffDate.Date).ToList();
                if (transactions.ListIsEmpty())
                    return null;
                PendingTransactions trans = new PendingTransactions
                {
                    ClientID = clientID,
                    ClientForm = FindClient(clientID).Result,
                    CutOffDate = UtilityService.ShowDateTime(cutoffDate)
                };

                var outstandingCoursePayments = transactions.Where(c => c.CourseFeeID.HasValue).Distinct().ToList();
                var outstandingProductPayments = transactions.Where(p => p.ProductFeeID.HasValue).Distinct().ToList();
                List<PendingTransactionList> courseFees = new List<PendingTransactionList>();
                foreach (var coursePayments in outstandingCoursePayments)
                {
                    courseFees.Add(new PendingTransactionList
                    {

                        ClientID = coursePayments.ClientID,
                        ClientFeeID = coursePayments.ClientFeeID,
                        Amount = coursePayments.Amount,
                        DueDate = UtilityService.ShowDateTime(coursePayments.DueDate),
                        ClientCourseID = coursePayments.ClientCourseID.Value,
                        CourseFeeID = coursePayments.CourseFeeID.Value,
                        CourseID = coursePayments.CourseID,
                        FeeName = coursePayments.CourseFee.Name,
                        PaymentTerms = coursePayments.CourseFee.Frequency.Name,
                        Entity = "Course - " + coursePayments.CourseFee.Course.Title
                    });
                }
                trans.CoursePayments = courseFees;

                List<PendingTransactionList> productFees = new List<PendingTransactionList>();
                foreach (var fee in outstandingProductPayments)
                {
                    productFees.Add(new PendingTransactionList
                    {

                        ClientID = fee.ClientID,
                        ClientFeeID = fee.ClientFeeID,
                        Amount = fee.Amount,
                        DueDate = UtilityService.ShowDateTime(fee.DueDate),
                        ClientProductID = fee.ClientProductID.Value,
                        ProductFeeID = fee.ProductFeeID.Value,
                        ProductID = fee.ProductID,
                        FeeName = fee.ProductFee.Name,
                        PaymentTerms = fee.ProductFee.Frequency.Name,
                        Entity = "Product - " + fee.ProductFee.Product.Name
                    });
                }
                trans.ProductPayments = productFees;
                return trans;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public Deductions GetClientDeductions(int clientID)
        {
            try
            {
                int invoiceStatusID = (int)InvoiceState.Finalised;
                var transactions = _context.InvoiceDetails.
                Include(i => i.Invoice).
                Include(c => c.Client).
                 Include(p => p.PaymentStatus).
                Where(c => c.ClientID == clientID && c.Invoice.InvoiceStatusID == invoiceStatusID).ToList();
                if (transactions.ListIsEmpty())
                    return null;
                Deductions trans = new Deductions
                {
                    ClientID = clientID,
                    ClientForm = FindClient(clientID).Result
                };
                List<InvoiceList> result = new List<InvoiceList>();

                foreach (var transaction in transactions)
                {
                    result.Add(new InvoiceList
                    {
                        InvoiceDetailID = transaction.InvoiceDetailID,
                        InvoiceID = transaction.InvoiceID,
                        ClientID = transaction.ClientID,
                        Amount = transaction.DeductedAmount,
                        DueDate = UtilityService.ShowDate(transaction.Invoice.DueDate),
                        InvoiceDate = UtilityService.ShowDate(transaction.Invoice.InvoiceDate),
                        ProductName = transaction.Product.Name,
                        ProductID = transaction.ProductID,
                        Occupation = transaction.Client.Occupation,
                        InvoiceNumber = transaction.InvoiceNumber,
                        Salary = transaction.Salary,
                        Status = transaction.PaymentStatus.Name

                    });
                }
                trans.Invoice = result;
                return trans;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public Statement ClientStatements(int clientID)
        {
            try
            {
                var transactions = _context.ClientProducts.
                Include(c => c.Product).
                               Where(c => c.ClientID == clientID).ToList();
                if (transactions.ListIsEmpty())
                    return null;
                Statement statement = new Statement
                {
                    ClientID = clientID,
                    Client = FindClient(clientID).Result
                };
                List<ProdList> result = new List<ProdList>();

                foreach (var transaction in transactions)
                {
                    result.Add(new ProdList
                    {

                        ProductID = transaction.ProductID,
                        Name = transaction.Product.Name,

                    });
                }
                statement.ProductList = result;
                return statement;
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
                    UserName = result.UserName,
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
                    UserName = result.UserName,
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
