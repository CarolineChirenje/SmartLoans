
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

namespace SmartLogic
{
    public class ClientService : IClientService
    {
        private readonly DatabaseContext _context;
        public ClientService(DatabaseContext context) => _context = context;
        ICustomSettingsService _settingService = new CustomSettingsService();
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
            var Client = await _context.Clients.Where(c=>c.EmailAddress.Equals(emailAddress) && c.IDNumber.Equals(idnumber)).FirstOrDefaultAsync();
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
                            Include(sg => sg.ClientGuarantors).
                            Include(p => p.ClientProducts).
                            ThenInclude(p => p.Product).
                            Include(d => d.ClientDependents).
                            Include(c => c.ClientCourses).
                            ThenInclude(c=>c.Course).
                             ThenInclude(c => c.CourseOutlines).
                            Where(r => r.ClientID == Client.ClientID).FirstOrDefaultAsync();
                return await ClientResults;

            }

            return Client;
        }


        public async Task<int> Save(Client Client)
        {
            Client.AccountNumber = NewClientAccountNumber;
            Client.UserName = UtilityService.GenerateUserName(Client.FirstName, Client.LastName);
            Client.LastChangedBy = UtilityService.CurrentUserName;
            Client.LastChangedDate = DateTime.Now;
            Client.RegistrationDate = DateTime.Now;
            Client.IsActive = true;
            _context.Add(Client);
            await _context.SaveChangesAsync();
           return Client.ClientID; 
        }

        public async Task<int> Update(Client Client)
        {
            Client updateClient = await _context.Clients.FindAsync(Client.ClientID);
            if (UtilityService.IsNotNull(updateClient))
            {
                updateClient.FirstName = Client.FirstName;
                updateClient.LastName = Client.LastName;
                updateClient.IsActive = Client.IsActive;
                updateClient.EmailAddress = Client.EmailAddress;
                updateClient.ResidentialAddress = Client.ResidentialAddress;
                updateClient.MobileNumber = Client.MobileNumber;
                updateClient.DateOfBirth = Client.DateOfBirth;

                updateClient.LastChangedBy = UtilityService.CurrentUserName;
                updateClient.LastChangedDate = DateTime.Now;
                _context.Update(updateClient);
            }

            return await _context.SaveChangesAsync();
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
                Include(sa => sa.ClientMedicalDetails)
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
                 Include(s => s.Client).
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
                 Include(ct => ct.Client).
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
            await _context.SaveChangesAsync();
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
                 Include(s => s.Client).
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
             Include(s => s.Client).
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
        // Client Guarantor
        public async Task<ClientGuarantor> FindGuarantor(int id)
        {
            return await _context.ClientGuarantors.
            Include(s => s.Client).
            Where(t => t.ClientGuarantorID == id).FirstOrDefaultAsync();
        }
        public async Task<List<ClientGuarantor>> FindGuarantors(int ClientID)
        {
            return await _context.ClientGuarantors.Where(t => t.ClientID == ClientID).ToListAsync();
        }
        public async Task<int> Save(ClientGuarantor ClientGuarantor)
        {
            List<ClientGuarantor> ClientGuarantors = await FindGuarantors(ClientGuarantor.ClientID);
            if (ClientGuarantors == null || ClientGuarantors.Count() == 0)
                ClientGuarantor.IsMainGuarantor = true;

            else
            {
                if (ClientGuarantor.IsMainGuarantor)
                {
                    try
                    {
                        // if this has been set as the main guarator then all the gurantors already in the DB  should have that column set to false
                        var guarantors = _context.ClientGuarantors.Where(s => s.ClientID == ClientGuarantor.ClientID).ToList();
                        guarantors.ForEach(a => a.IsMainGuarantor = false);
                        _context.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                        //throw;
                    }

                }
            }
            ClientGuarantor.LastChangedBy = UtilityService.CurrentUserName;
            ClientGuarantor.LastChangedDate = DateTime.Now;
            _context.Add(ClientGuarantor);
            return (await _context.SaveChangesAsync());

        }
        public async Task<int> Update(ClientGuarantor ClientGuarantor)
        {
            ClientGuarantor mainGuarantor = _context.ClientGuarantors.Where(s => s.ClientID == ClientGuarantor.ClientID && s.IsMainGuarantor).FirstOrDefault();
            if (UtilityService.IsNull(mainGuarantor))
                ClientGuarantor.IsMainGuarantor = true;

            else
            {
                if (ClientGuarantor.IsMainGuarantor)
                {
                    try
                    {
                        if (UtilityService.IsNotNull(mainGuarantor))
                            mainGuarantor.IsMainGuarantor = false;
                        _context.Update(mainGuarantor);
                        _context.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                        //throw;
                    }


                }

            }
            ClientGuarantor guarantor = _context.ClientGuarantors.Find(ClientGuarantor.ClientGuarantorID);
            guarantor.MobileNumber = ClientGuarantor.MobileNumber;
            guarantor.IDNumber = ClientGuarantor.IDNumber;
            guarantor.EmailAddress = ClientGuarantor.EmailAddress;
            guarantor.FirstName = ClientGuarantor.FirstName;
            guarantor.IsMainGuarantor = ClientGuarantor.IsMainGuarantor;
            guarantor.PhysicalAddress = ClientGuarantor.PhysicalAddress;
            guarantor.ClientID = ClientGuarantor.ClientID;
            guarantor.LastName = ClientGuarantor.LastName;
            guarantor.LastChangedBy = UtilityService.CurrentUserName;
            guarantor.LastChangedDate = DateTime.Now;
            _context.Update(guarantor);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> ActionGuarantor(int id, DatabaseAction action)
        {

            ClientGuarantor ClientGuarantor = await FindGuarantor(id);

            if (DatabaseAction.Remove == action)
                _context.ClientGuarantors.Remove(ClientGuarantor);
            else if (DatabaseAction.IsDefault == action)
            {
                // TODO: Make additional changes to guarantor logic 
                // need to remove default on the one who is recently default; if its the first  then make the person maingurantor
                ClientGuarantor.IsMainGuarantor = true;
                ClientGuarantor.LastChangedBy = UtilityService.CurrentUserName;
                ClientGuarantor.LastChangedDate = DateTime.Now;
                _context.Update(ClientGuarantor);
            }

            return (await _context.SaveChangesAsync());
        }


        // Client Dependent
        public async Task<ClientDependent> FindDependent(int id)
        {
            return await _context.ClientDependents.
            Include(s => s.Client).
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
            Include(s => s.Client).
            Where(t => t.ClientProductID == id).FirstOrDefaultAsync();
        }

        public async Task<int> Save(ClientProduct clientProduct)
        {

            clientProduct.LastChangedBy = UtilityService.CurrentUserName;
            clientProduct.LastChangedDate = DateTime.Now;
            _context.Add(clientProduct);
            return (await _context.SaveChangesAsync());

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
             Include(c => c.Client).
             Include(c => c.Course).
             ThenInclude(c => c.CourseOutlines).
            Where(t => t.ClientCourseID == id).FirstOrDefaultAsync();
        }
        public async Task<int> Save(ClientCourse ClientCourse)
        {
            ClientCourse.DateRegistered = DateTime.Now;
            ClientCourse.LastChangedBy = UtilityService.CurrentUserName;
            ClientCourse.LastChangedDate = DateTime.Now;
            _context.Add(ClientCourse);
            int _result = await _context.SaveChangesAsync();
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
                IEnumerable<int> courseOutlines = from c in _context.CourseTranscripts
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
                    CourseTranscript  transcript = new CourseTranscript
                    {
                        ClientCourseID = clientCourseID,
                        CourseOutlineID = sessionid,
                        DateRegistered=DateTime.Now,
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
            List<CourseTranscript> courseTranscripts = await _context.CourseTranscripts.Where(r => r.ClientCourseID == clientCourseID).ToListAsync();
            var transcriptsToBeRemoved = courseTranscripts
                    .Where(x => sessions.Any(y => y == x.CourseOutlineID));
            _context.CourseTranscripts.RemoveRange(transcriptsToBeRemoved);
            return (await _context.SaveChangesAsync());
        }


    }
}
