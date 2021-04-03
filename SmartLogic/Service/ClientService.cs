
using SmartLogic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartDomain;
using SmartHelper;
using SmartDataAccess;
using CustomSetting = SmartDomain.CustomSetting;
using System.Net;
using Microsoft.VisualBasic;

namespace SmartLogic
{
    public class ClientService : IClientService
    {
        private readonly DatabaseContext _context;
        public ClientService(DatabaseContext context) => _context = context;
        ICustomSettingsService _settingService = new CustomSettingsService();
        ITransactionService _transactionService = new TransactionService();
        public async Task<int> ActionClientStatus(int id, DatabaseAction action)
        {

            Client Client = await FindClient(id);

            if (DatabaseAction.Remove == action)
                _context.Clients.Remove(Client);
            else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
            {
                Client.IsActive = DatabaseAction.Deactivate == action ? false : true;
                Client.LastChangedBy = UtilityService.CurrentUserName;
                Client.LastChangedDate = DateTime.Now;
                _context.Update(Client);
            }

            return (await _context.SaveChangesAsync());
        }

        public async Task<int> Delete(int id)
        {
            var Client = await _context.Clients.FindAsync(id);
            _context.Clients.Remove(Client);
            return (await _context.SaveChangesAsync());
        }

        public async Task<Client> ClientDetails(string emailAddress, string idnumber)
        {
            var Client = await _context.Clients.Where(c => c.EmailAddress.Equals(emailAddress) && c.IDNumber.Equals(idnumber)).FirstOrDefaultAsync();
            return Client;
        }


        public async Task<Client> FindClient(int Clientid = 0, string accountNumber = null)
        {

            Client Client = new Client();

            if (String.IsNullOrEmpty(accountNumber?.Trim()))
                Client = _context.Clients.Find(Clientid);
            else
                Client = _context.Clients.Where(r => r.AccountNumber.Equals(accountNumber.Trim())).FirstOrDefault();

            if (UtilityService.IsNotNull(Client))
            {

                Task<Client> ClientResults = _context.Clients.
                            Include(c => c.ClientContacts).
                            Include(payments => payments.ClientPayments).ThenInclude(trans => trans.TransactionType).
                            Include(payments => payments.ClientPayments).ThenInclude(trans => trans.Product).
                            Include(payments => payments.ClientPayments).ThenInclude(trans => trans.PaymentStatus).
                            Include(n => n.ClientNotes).
                            ThenInclude(ut => ut.UserType).
                            Include(d => d.ClientDocuments).
                            ThenInclude(document => document.DocumentType).
                            ThenInclude(docFormat => docFormat.DocumentFormat).
                            Include(sm => sm.ClientMedicalDetails).
                            Include(p => p.ClientProducts).ThenInclude(p => p.Product).
                            Include(p => p.ClientFees).ThenInclude(p => p.ProductFee).ThenInclude(p => p.Product).
                            Include(p => p.ClientFees).ThenInclude(p => p.ProductFee).ThenInclude(p => p.Frequency).
                            Include(p => p.ClientFees).ThenInclude(p => p.CourseFee).ThenInclude(p => p.Frequency).
                            Include(d => d.ClientDependents).
                            Include(c => c.ClientCourses).
                            ThenInclude(c => c.Course).
                            ThenInclude(c => c.CourseOutlines).
                            Include(c => c.ClientCourses).
                            ThenInclude(c => c.Course).
                            ThenInclude(c => c.CourseIntakes).
                            Include(c => c.ClientDeductions).
                            ThenInclude(c => c.Product).
                             Include(c => c.ClientOccupationHistory).
                             Include(c => c.JointApplicant).ThenInclude(r => r.RecordStatus).
                             Include(c => c.JointApplicant).ThenInclude(ct => ct.Title).
                             Include(c => c.Title).
                             Include(at => at.ClientAccountType).
                             Where(r => r.ClientID == Client.ClientID).FirstOrDefaultAsync();
                return await ClientResults;

            }

            return Client;
        }


        public async Task<int> Save(Client Client)
        {
            if (UtilityService.AutoGenerateAccountNumber)
                Client.AccountNumber = NewClientAccountNumber;

            Client.UserName = UtilityService.GenerateUserName(Client.FirstName, Client.LastName);
            Client.LastChangedBy = UtilityService.CurrentUserName;
            Client.LastChangedDate = DateTime.Now;
            Client.RegistrationDate = DateTime.Now;
            Client.IsActive = true;
            _context.Add(Client);
            await _context.SaveChangesAsync();
            if (Client.ClientAccountTypeID == (int)Client_AccountType.Joint)
            {
                if (UtilityService.IsNotNull(Client.JointApplicant))
                {
                    Client.JointApplicant.ClientID = Client.ClientID;
                    await Save(Client.JointApplicant);
                }
            }
            return Client.ClientID;
        }
        public async Task<int> Update(Client Client)
        {
            Client updateClient = await _context.Clients.FindAsync(Client.ClientID);
            string oldIDNumber = updateClient.IDNumber;
            string oldEmailAddress = updateClient.EmailAddress;
            Decimal oldSalary = updateClient.Salary;
            if (oldSalary != Client.Salary)
            {

                ClientOccupationHistory clientOccupationHistory = new ClientOccupationHistory();
                clientOccupationHistory.ClientID = updateClient.ClientID;
                clientOccupationHistory.Salary = oldSalary;
                clientOccupationHistory.Occupation = updateClient.Occupation;
                clientOccupationHistory.LastChangedDate = updateClient.LastChangedDate;
                clientOccupationHistory.LastChangedBy = updateClient.LastChangedBy;
                _context.Add(clientOccupationHistory);
            }
            if (UtilityService.IsNotNull(updateClient))
            {
                updateClient.FirstName = Client.FirstName;
                updateClient.TitleID = Client.TitleID;
                updateClient.Initials = Client.Initials;
                updateClient.LastName = Client.LastName;
                updateClient.IsActive = Client.IsActive;
                updateClient.EmailAddress = Client.EmailAddress;
                updateClient.IDNumber = Client.IDNumber;
                updateClient.AddressLine1 = Client.AddressLine1;
                updateClient.AddressLine2 = Client.AddressLine2;
                updateClient.City = Client.City;
                updateClient.CountryID = Client.CountryID;
                updateClient.MobileNumber = Client.MobileNumber;
                updateClient.DateOfBirth = Client.DateOfBirth;
                updateClient.DepartmentID = Client.DepartmentID;
                updateClient.GenderID = Client.GenderID;
                updateClient.LastChangedBy = UtilityService.CurrentUserName;
                updateClient.LastChangedDate = DateTime.Now;
                updateClient.Salary = Client.Salary;
                updateClient.Occupation = Client.Occupation;
                updateClient.ClientAccountTypeID = Client.ClientAccountTypeID;
                _context.Update(updateClient);
            }
            int result = await _context.SaveChangesAsync();
            if (result > 0)
            {  // also need to update id number and email address on user account 
                User user = _context.Users.FirstOrDefault(u => u.IDNumber.Equals(oldIDNumber) && u.EmailAddress.Equals(oldEmailAddress));
                if (UtilityService.IsNotNull(user))
                {
                    user.EmailAddress = Client.EmailAddress;
                    user.IDNumber = Client.IDNumber;
                    user.LastChangedBy = UtilityService.CurrentUserName;
                    user.LastChangedDate = DateTime.Now;
                    _context.Update(user);
                    result = await _context.SaveChangesAsync();

                }

                if (Client.ClientAccountTypeID == (int)Client_AccountType.Joint)
                {
                    if (UtilityService.IsNotNull(Client.JointApplicant))
                    {
                        Client.JointApplicant.ClientID = Client.ClientID;
                        await Update(Client.JointApplicant);
                    }
                }

            }


            return result;
        }

        public async Task<int> Save(JointApplicant applicant)
        {
            applicant.LastChangedBy = UtilityService.CurrentUserName;
            applicant.LastChangedDate = DateTime.Now;
            _context.Add(applicant);
            await _context.SaveChangesAsync();

            return applicant.JointApplicantID;
        }

        public async Task<int> Update(JointApplicant applicant)
        {
            JointApplicant updateApplicant = await _context.JointApplicants.FindAsync(applicant.JointApplicantID);
            if (UtilityService.IsNull(updateApplicant))
                updateApplicant = await _context.JointApplicants.Where(ja => ja.ClientID == applicant.ClientID).FirstOrDefaultAsync();

            if (UtilityService.IsNotNull(updateApplicant))
            {
                updateApplicant.ApplicantTitleID = applicant.ApplicantTitleID;

                updateApplicant.FirstName = applicant.FirstName;
                updateApplicant.LastName = applicant.LastName;
                updateApplicant.Initials = applicant.Initials;
                updateApplicant.EmailAddress = applicant.EmailAddress;
                updateApplicant.IDNumber = applicant.IDNumber;
                updateApplicant.AddressLine1 = applicant.AddressLine1;
                updateApplicant.AddressLine2 = applicant.AddressLine2;
                updateApplicant.City = applicant.City;
                updateApplicant.CountryID = applicant.CountryID;
                updateApplicant.RelationshipTypeID = applicant.RelationshipTypeID;
                updateApplicant.MobileNumber = applicant.MobileNumber;
                updateApplicant.DateOfBirth = applicant.DateOfBirth;
                updateApplicant.ApplicantGenderID = applicant.ApplicantGenderID;
                updateApplicant.LastChangedBy = UtilityService.CurrentUserName;
                updateApplicant.LastChangedDate = DateTime.Now;
                updateApplicant.RelationshipTypeID = applicant.RelationshipTypeID;
                _context.Update(updateApplicant);
                int result = await _context.SaveChangesAsync();
                return result;
            }
            else
            {
                return await Save(applicant);
            }

        }
        public async Task<List<AttendanceRegisterDetail>> AttendanceRegisters(int clientID)
        {
            return await _context.AttendanceRegisterDetails.
                Include(c => c.AttendanceRegister).
                  ThenInclude(c => c.CourseIntake).
                    ThenInclude(c => c.Course).
                Include(c => c.Client).
                Where(c => c.ClientID == clientID).
                OrderByDescending(c => c.AttendanceRegister.AttendanceDate).ToListAsync();
        }
        public async Task<List<Client>> Clients()
        {
            return await _context.Clients.
                Include(c => c.ClientContacts).
                Include(p => p.ClientPayments).
                Include(n => n.ClientNotes).
                ThenInclude(ut => ut.UserType).
                Include(d => d.ClientDocuments).
                ThenInclude(document => document.DocumentType).
                ThenInclude(docFormat => docFormat.DocumentFormat).
                Include(sa => sa.ClientMedicalDetails).
                Include(at => at.ClientAccountType).
                Include(c => c.JointApplicant).ThenInclude(r => r.RecordStatus).
                Include(c => c.JointApplicant).ThenInclude(ct => ct.Title).
                Include(c => c.Title).
                Include(at => at.ClientAccountType).
                OrderByDescending(c => c.RegistrationDate)
                .ToListAsync();
        }


        public async Task<List<string>> ClientAccountNumbers(string account)
        {
            return await _context.Clients.
            Where(s => s.AccountNumber.ToString()
            .Contains(account)).Select(s => s.AccountNumber.ToString())
            .ToListAsync();
        }
        public async Task<List<Client>> NewClients()
        {

            return await _context.Clients.
                Include(c => c.ClientContacts).
                Include(p => p.ClientPayments).
                ThenInclude(p => p.TransactionType).
                Include(n => n.ClientNotes).
                ThenInclude(ut => ut.UserType).
                Include(d => d.ClientDocuments).
                ThenInclude(document => document.DocumentType).
                ThenInclude(docFormat => docFormat.DocumentFormat).
                Include(sa => sa.ClientMedicalDetails).
                Include(at => at.ClientAccountType).
                Where(rp => rp.RegistrationDate.Date >= DateTime.Now.AddDays(-1).Date && rp.RegistrationDate.Date <= DateTime.Now.Date).ToListAsync();
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
            return _context.Clients.Any(m => m.AccountNumber.Equals(accountNumber));
        }

        string GenerateAccountNumber()
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
        #endregion Client Account No



        public async Task<int> ActionClient(int id, DatabaseAction action)
        {

            Client Client = await FindClient(id);

            if (DatabaseAction.Remove == action)
                _context.Clients.Remove(Client);
            else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
            {
                Client.IsActive = DatabaseAction.Deactivate == action ? false : true;
                Client.LastChangedBy = UtilityService.CurrentUserName;
                Client.LastChangedDate = DateTime.Now;
                _context.Update(Client);
            }

            return (await _context.SaveChangesAsync());
        }


        //Notes
        public async Task<ClientNote> FindNote(int id)
        {
            return await _context.ClientNotes.
             Include(ut => ut.UserType).
             Include(c => c.Client).ThenInclude(c => c.Title).
             Include(c => c.Client).ThenInclude(c => c.JointApplicant).ThenInclude(ct => ct.Title).
             Include(c => c.Client).ThenInclude(at => at.ClientAccountType).
            Where(t => t.ClientNoteID == id).FirstOrDefaultAsync();
        }
        public async Task<int> Save(ClientNote ClientNote)
        {
            if (!UtilityService.IsNotNull(ClientNote.DueDate))
                ClientNote.DueDate = DateTime.Now.AddDays(5);
            if (!UtilityService.IsNotNull(ClientNote.DateClosed))
                ClientNote.DateClosed = DateTime.MinValue;
            ClientNote.UserTypeID = UtilityService.CurrentUserTypeID;
            ClientNote.UploadedBy = ClientNote.LastChangedBy = UtilityService.CurrentUserName;
            ClientNote.LastChangedDate = DateTime.Now;
            ClientNote.DateUploaded = DateTime.Now;

            _context.Add(ClientNote);
            return (await _context.SaveChangesAsync());

        }
        public async Task<int> Update(ClientNote ClientNote)
        {

            ClientNote cn = _context.ClientNotes.Find(ClientNote.ClientNoteID);
            cn.Comment = ClientNote.Comment;
            cn.DateClosed = ClientNote.DateClosed;
            if (!UtilityService.IsNotNull(cn.DueDate))
                cn.DueDate = DateTime.Now.AddDays(5);
            if (!UtilityService.IsNotNull(cn.DateClosed))
                cn.DateClosed = DateTime.MinValue;
            cn.VisibleToAdminOnly = ClientNote.VisibleToAdminOnly;
            cn.UserTypeID = UtilityService.CurrentUserTypeID;
            cn.LastChangedBy = UtilityService.CurrentUserName;
            cn.LastChangedDate = DateTime.Now;
            _context.Update(cn);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> ActionNote(int id, DatabaseAction action)
        {

            ClientNote ClientNote = await FindNote(id);

            if (DatabaseAction.Remove == action)
                _context.ClientNotes.Remove(ClientNote);

            if (DatabaseAction.Close == action)
            {
                ClientNote.DateClosed = DateTime.Now;
                ClientNote.LastChangedBy = UtilityService.CurrentUserName;
                ClientNote.LastChangedDate = DateTime.Now;
                _context.ClientNotes.Update(ClientNote);
            }

            return (await _context.SaveChangesAsync());
        }

        //Contact
        public async Task<ClientContact> FindContact(int id)
        {
            return await _context.ClientContacts.
             Include(c => c.Client).ThenInclude(c => c.Title).
             Include(c => c.Client).ThenInclude(c => c.JointApplicant).ThenInclude(ct => ct.Title).
             Include(c => c.Client).ThenInclude(at => at.ClientAccountType).
             Include(ct => ct.RelationshipType).
             Include(ct => ct.ContactType).
             Where(t => t.ClientContactID == id).FirstOrDefaultAsync();
        }
        public async Task<int> Save(ClientContact ClientContact)
        {

            ClientContact.LastChangedBy = UtilityService.CurrentUserName;
            ClientContact.LastChangedDate = DateTime.Now;
            _context.Add(ClientContact);
            return (await _context.SaveChangesAsync());

        }
        public async Task<int> Update(ClientContact Clientcontact)
        {
            ClientContact update = _context.ClientContacts.
            Where(t => t.ClientContactID == Clientcontact.ClientContactID).FirstOrDefault();

            update.RelationshipTypeID = Clientcontact.RelationshipTypeID;
            update.ContactTypeID = Clientcontact.ContactTypeID;
            update.ContactPerson = Clientcontact.ContactPerson;
            update.Contact = Clientcontact.Contact;
            update.LastChangedBy = UtilityService.CurrentUserName;
            update.LastChangedDate = DateTime.Now;
            _context.Entry(update).State = EntityState.Modified;
            return await _context.SaveChangesAsync();
        }

        public async Task<int> ActionContact(int id, DatabaseAction action)
        {

            ClientContact ClientContact = await FindContact(id);

            if (DatabaseAction.Remove == action)
                _context.ClientContacts.Remove(ClientContact);
            else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
            {
                ClientContact.LastChangedBy = UtilityService.CurrentUserName;
                ClientContact.LastChangedDate = DateTime.Now;
                _context.Update(ClientContact);
            }

            return (await _context.SaveChangesAsync());
        }


        //Document
        public async Task<ClientDocument> FindDocument(int id)
        {
            return await _context.ClientDocuments.
             Include(dt => dt.DocumentType).
             Include(c => c.Client).ThenInclude(c => c.Title).
             Include(c => c.Client).ThenInclude(c => c.JointApplicant).ThenInclude(ct => ct.Title).
             Include(c => c.Client).ThenInclude(at => at.ClientAccountType).
             Where(t => t.ClientDocumentID == id).FirstOrDefaultAsync();
        }


        public async Task<int> Save(ClientDocument ClientDocument)
        {
            ClientDocument.UploadedBy = ClientDocument.LastChangedBy = UtilityService.CurrentUserName;
            ClientDocument.DateUploaded = ClientDocument.LastChangedDate = DateTime.Now;
            _context.Add(ClientDocument);
            return (await _context.SaveChangesAsync());

        }
        public async Task<int> Update(ClientDocument document)
        {
            document.LastChangedBy = UtilityService.CurrentUserName;
            document.LastChangedDate = DateTime.Now;
            _context.Update(document);
            await _context.SaveChangesAsync();
            return await _context.SaveChangesAsync();
        }

        public async Task<int> ActionDocument(int id, DatabaseAction action)
        {

            ClientDocument ClientDocument = await FindDocument(id);

            if (DatabaseAction.Remove == action)
                _context.ClientDocuments.Remove(ClientDocument);

            return (await _context.SaveChangesAsync());
        }

        //MedicalDetail
        public async Task<ClientMedicalDetail> FindMedicalDetail(int id)
        {
            return await _context.ClientMedicalDetails.
             Include(c => c.Client).ThenInclude(c => c.Title).
             Include(c => c.Client).ThenInclude(c => c.JointApplicant).ThenInclude(ct => ct.Title).
             Include(c => c.Client).ThenInclude(at => at.ClientAccountType).
            Where(t => t.ClientMedicalID == id).FirstOrDefaultAsync();
        }
        public async Task<int> Save(ClientMedicalDetail ClientMedicalDetail)
        {

            ClientMedicalDetail.LastChangedBy = UtilityService.CurrentUserName;
            ClientMedicalDetail.LastChangedDate = DateTime.Now;
            _context.Add(ClientMedicalDetail);
            return (await _context.SaveChangesAsync());

        }
        public async Task<int> Update(ClientMedicalDetail MedicalDetail)
        {
            ClientMedicalDetail medicalDetail = _context.ClientMedicalDetails.Find(MedicalDetail.ClientMedicalID);
            medicalDetail.MedicalAid = MedicalDetail.MedicalAid;
            medicalDetail.MedicalAidNo = MedicalDetail.MedicalAidNo;
            medicalDetail.Allergies = MedicalDetail.Allergies;
            medicalDetail.Doctor = MedicalDetail.Doctor;
            medicalDetail.Hospital = MedicalDetail.Doctor;
            medicalDetail.Other = MedicalDetail.Other;
            medicalDetail.Telephone = MedicalDetail.Telephone;
            medicalDetail.LastChangedBy = UtilityService.CurrentUserName;
            medicalDetail.LastChangedDate = DateTime.Now;
            medicalDetail.PrescribedMedication = MedicalDetail.PrescribedMedication;
            _context.Update(medicalDetail);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> ActionMedicalDetail(int id, DatabaseAction action)
        {

            ClientMedicalDetail ClientMedicalDetail = await FindMedicalDetail(id);

            if (DatabaseAction.Remove == action)
                _context.ClientMedicalDetails.Remove(ClientMedicalDetail);
            else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
            {
                ClientMedicalDetail.LastChangedBy = UtilityService.CurrentUserName;
                ClientMedicalDetail.LastChangedDate = DateTime.Now;
                _context.Update(ClientMedicalDetail);
            }

            return (await _context.SaveChangesAsync());
        }

        public async Task<ClientDependent> FindDependent(int id)
        {
            return await _context.ClientDependents.
            Include(c => c.Client).ThenInclude(c => c.Title).
             Include(c => c.Client).ThenInclude(c => c.JointApplicant).ThenInclude(ct => ct.Title).
             Include(c => c.Client).ThenInclude(at => at.ClientAccountType).
             Where(t => t.ClientDependentID == id).FirstOrDefaultAsync();
        }

        public async Task<int> Save(ClientDependent ClientDependent)
        {
            ClientDependent.RegistrationDate = DateTime.Now;
            ClientDependent.LastChangedBy = UtilityService.CurrentUserName;
            ClientDependent.LastChangedDate = DateTime.Now;
            _context.Add(ClientDependent);
            return (await _context.SaveChangesAsync());

        }
        public async Task<int> Update(ClientDependent ClientDependent)
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
            dependent.LastChangedBy = UtilityService.CurrentUserName;
            dependent.LastChangedDate = DateTime.Now;
            _context.Update(dependent);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> ActionDependent(int id, DatabaseAction action)
        {
            ClientDependent clientDependent = await FindDependent(id);
            if (DatabaseAction.Remove == action)
                _context.ClientDependents.Remove(clientDependent);
            return (await _context.SaveChangesAsync());
        }

        // Client Product
        public async Task<ClientProduct> FindProduct(int id)
        {
            return await _context.ClientProducts.
            Include(c => c.Product).
            Include(c => c.Client).ThenInclude(c => c.Title).
            Include(c => c.Client).ThenInclude(c => c.JointApplicant).ThenInclude(ct => ct.Title).
            Include(c => c.Client).ThenInclude(at => at.ClientAccountType).
            Where(t => t.ClientProductID == id).FirstOrDefaultAsync();
        }

        public async Task<int> Save(ClientProduct clientProduct)
        {
            int result = 0;
            clientProduct.LastChangedBy = UtilityService.CurrentUserName;
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
                        ClientFee clientFee = new ClientFee();
                        clientFee.ClientID = clientProduct.ClientID;
                        clientFee.ProductFeeID = productFee.ProductFeeID;
                        clientFee.Amount = productFee.Amount;
                        clientFee.LastChangedBy = UtilityService.CurrentUserName;
                        clientFee.LastChangedDate = DateTime.Now;
                        clientFee.ClientProductID = clientProduct.ClientProductID;
                        clientFee.DueDate = dueDate;
                        _context.Add(clientFee);
                    }

                    if (frequencyList == FrequencyList.Monthly)
                    {
                        for (int i = 1; i < 13; i++)
                        {
                            ClientFee clientFee = new ClientFee();
                            clientFee.ClientID = clientProduct.ClientID;
                            clientFee.ProductFeeID = productFee.ProductFeeID;
                            clientFee.Amount = productFee.Amount;
                            clientFee.LastChangedBy = UtilityService.CurrentUserName;
                            clientFee.LastChangedDate = DateTime.Now;
                            clientFee.ClientProductID = clientProduct.ClientProductID;
                            clientFee.DueDate = dueDate;
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
        public async Task<int> Update(ClientProduct clientProduct)
        {


            ClientProduct ClientProduct = _context.ClientProducts.Find(clientProduct.ClientProductID);
            ClientProduct.IsActive = clientProduct.IsActive;
            ClientProduct.LastChangedBy = UtilityService.CurrentUserName;
            ClientProduct.LastChangedDate = DateTime.Now;
            _context.Update(ClientProduct);
            int _result = await _context.SaveChangesAsync();
            return _result;
        }

        public async Task<int> ActionProduct(int id, DatabaseAction action)
        {
            ClientProduct ClientProduct = _context.ClientProducts.Find(id);
            if (DatabaseAction.Remove == action)
                _context.ClientProducts.Remove(ClientProduct);
            return (await _context.SaveChangesAsync());
        }


        public List<ClientProduct> GetClientProducts(int id)
        {
            return _context.ClientProducts.
            Include(s => s.Client).
            Include(p => p.Product).
            Where(t => t.ClientID == id && t.IsActive).ToList();
        }

        public List<Product> GetClientRegisteredProducts(int id)
        {
            var productids = _context.ClientProducts.
                       Where(t => t.ClientID == id).Select(p => p.ProductID);

            return _context.Products.
            Where(t => productids.Contains(t.ProductID)).ToList();
        }



        //Client Course
        public async Task<ClientCourse> FindCourse(int id)
        {
            return await _context.ClientCourses.
            Include(c => c.Client).ThenInclude(c => c.Title).
             Include(c => c.Client).ThenInclude(c => c.JointApplicant).ThenInclude(ct => ct.Title).
             Include(c => c.Client).ThenInclude(at => at.ClientAccountType).
             Include(c => c.Course).
             ThenInclude(c => c.CourseOutlines).
             Include(c => c.Course).
             ThenInclude(c=>c.CourseIntakes).
            Where(t => t.ClientCourseID == id).FirstOrDefaultAsync();
        }
        public async Task<int> Save(ClientCourse ClientCourse)
        {
            ClientCourse.DateRegistered = DateTime.Now;
            ClientCourse.LastChangedBy = UtilityService.CurrentUserName;
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
                        ClientFee clientFee = new ClientFee();
                        clientFee.ClientID = ClientCourse.ClientID;
                        clientFee.CourseFeeID = courseFee.CourseFeeID;
                        clientFee.Amount = courseFee.Amount;
                        clientFee.LastChangedBy = UtilityService.CurrentUserName;
                        clientFee.LastChangedDate = DateTime.Now;
                        clientFee.ClientCourseID = ClientCourse.ClientCourseID;
                        clientFee.DueDate = dueDate;
                        _context.Add(clientFee);
                    }

                    if (frequencyList == FrequencyList.Monthly)
                    {
                        for (int i = 1; i < 13; i++)
                        {
                            ClientFee clientFee = new ClientFee();
                            clientFee.ClientID = ClientCourse.ClientID;
                            clientFee.CourseFeeID = courseFee.CourseFeeID;
                            clientFee.Amount = courseFee.Amount;
                            clientFee.LastChangedBy = UtilityService.CurrentUserName;
                            clientFee.LastChangedDate = DateTime.Now;
                            clientFee.ClientCourseID = ClientCourse.ClientCourseID;
                            clientFee.DueDate = dueDate;
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

        public async Task<int> Update(ClientCourse Course)
        {
            ClientCourse course = _context.ClientCourses.Find(Course.ClientCourseID);
            course.CourseID = Course.CourseID;
            course.DateCompleted = Course.DateCompleted;
            course.IsDeRegistered = Course.IsDeRegistered;
            course.LastChangedBy = UtilityService.CurrentUserName;
            course.LastChangedDate = DateTime.Now;
            _context.Update(course);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> ActionCourse(int id)
        {
            ClientCourse course = _context.ClientCourses.Find(id);
            course.IsDeRegistered = true;
            course.LastChangedBy = UtilityService.CurrentUserName;
            course.LastChangedDate = DateTime.Now;
            _context.Update(course);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateSessions(int clientCourseID, string[] selectedSessions)
        {
            int result = 0;
            try
            {
                IEnumerable<int> courseOutlines = from c in _context.ClientTranscripts
                                                  where c.ClientCourseID == clientCourseID
                                                  select c.CourseOutlineID;
                List<int> old_sessions = courseOutlines.ToList();
                List<int> add_sessions = new List<int>();
                List<int> remove_sessions = new List<int>();
                int[] updated_Details = selectedSessions == null ? null : Array.ConvertAll(selectedSessions, s => int.Parse(s));


                if (old_sessions == null && old_sessions.Count == 0)
                {
                    add_sessions = updated_Details.ToList();
                    return await AddSessions(clientCourseID, add_sessions);
                }
                foreach (var courseOutline in _context.CourseOutlines)
                {
                    if (selectedSessions.Contains(courseOutline.CourseOutlineID.ToString()))
                    {
                        if (!old_sessions.Contains(courseOutline.CourseOutlineID))
                        {
                            add_sessions.Add(courseOutline.CourseOutlineID);
                        }
                    }
                    else
                    {
                        if (old_sessions.Contains(courseOutline.CourseOutlineID))
                        {
                            remove_sessions.Add(courseOutline.CourseOutlineID);
                        }
                    }
                }
                int _addResult = await AddSessions(clientCourseID, add_sessions);
                int _removeResult = await RemoveSessions(clientCourseID, remove_sessions);
                result = _addResult + _removeResult;
            }
            catch (Exception ex)
            {
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
                        CourseOutlineID = sessionid,
                        DateRegistered = DateTime.Now,
                        LastChangedBy = UtilityService.CurrentUserName,
                        LastChangedDate = DateTime.Now
                    };
                    _context.Add(transcript);

                }
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public async Task<int> RemoveSessions(int clientCourseID, List<int> sessions)
        {
            List<ClientTranscript> courseTranscripts = await _context.ClientTranscripts.Where(r => r.ClientCourseID == clientCourseID).ToListAsync();
            var transcriptsToBeRemoved = courseTranscripts
                    .Where(x => sessions.Any(y => y == x.CourseOutlineID));
            _context.ClientTranscripts.RemoveRange(transcriptsToBeRemoved);
            return (await _context.SaveChangesAsync());
        }

        public List<ClientSchedule> GetClientsOnProduct(int ProductID, System.DateTime InvoiceDate)
        {
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
               Include(c => c.Client).
                             Where(t => ClientIDs.Contains(t.ClientID)).ToList();



            List<ClientSchedule> schedules = new List<ClientSchedule>();
            foreach (var item in clientProducts)
            {
                schedules.Add(new ClientSchedule
                {
                    ClientProductID = item.ClientProductID,
                    ClientID = item.ClientID,
                    ClientFullName = item.Client.ClientFullName,
                    Occupation = item.Client.Occupation,
                    Salary = item.Client.Salary,
                    ProductID = item.ProductID,
                    ProductName = item.Product.Name,
                    InvoiceDate = InvoiceDate

                });
            }

            return schedules;
        }
        // ClientFees
        public async Task<ClientFee> FindClientFee(int id)
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



        public async Task<int> PayFee(ClientFee clientFee)
        {
            int _TransactionID = 0;
            ClientFee _clientFee = _clientFee = _context.ClientFees.
               Include(c => c.ProductFee).
               ThenInclude(c => c.Product).
                 Include(c => c.CourseFee).
             ThenInclude(c => c.Course).
                          Where(c => c.ClientFeeID == clientFee.ClientFeeID).
               FirstOrDefault();


            if (UtilityService.IsNull(_clientFee))
                return 0;

            Transaction addPaymentsFile = new Transaction()
            {
                Year = DateTime.Now.Year,
                Month = DateTime.Now.Month,
                Amount = UtilityService.HasPermission(Permissions.Override_Payment) ? clientFee.Amount : _clientFee.Amount,
                ClientID = clientFee.ClientID,
                PaymentDate = DateTime.Now,
                PaymentStatusID = (int)PaymentState.Paid,
                TransactionDate = DateTime.Now,
                LastChangedBy = UtilityService.CurrentUserName,
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
                _clientFee.LastChangedBy = UtilityService.CurrentUserName;
                _clientFee.LastChangedDate = DateTime.Now;
                _context.Update(_clientFee);
                await _context.SaveChangesAsync();
            }
            return _TransactionID;
        }
    }
}
