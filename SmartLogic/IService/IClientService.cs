using SmartDomain;
using SmartHelper;
using SmartInterfaces;
using SmartLogic;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Product = SmartDomain.Product;

namespace SmartLogic
{
    public interface IClientService
    {

        Task<int> Delete(int id);


        Task<int> ActionClient(int id, DatabaseAction action);
        Task<int> Save(ClientForm client);
        Task<int> Update(ClientForm client);
        string GetClientRef(int clientID);
        Task<ClientForm> FindClient(int Clientid = 0, string accountNumber = null);
        List<ClientList> Clients(string accountNumber = null, bool newClientsOnly = false, int productID = 0);
        Task<List<string>> ClientAccountNumbers(string account);
        Task<ClientPeek> GetClient(string emailAddress=null, string idnumber=null,int? clientID=null);
        Register AttendanceRegisters(int clientID);
        Task<bool> ClientExists(int Clientid = 0);

        Task<ClientKonapoFunds> GetClientKonapoFunds(int clientID);

        //Notes
        Comments ClientNotes(int clientID);
        Task<ClientNote> FindNote(int id);
        Task<int> Save(ClientNote note);
        Task<int> Update(ClientNote note);
        Task<int> ActionNote(int id, DatabaseAction action);


        //Contact
        Contacts ClientContacts(int clientID);
        Task<ClientContact> FindContact(int id);
        Task<int> Save(ClientContact contact);
        Task<int> Update(ClientContact contact);
        Task<int> ActionContact(int id, DatabaseAction action);


        //Document
        Docs ClientDocuments(int clientID);
        Task<ClientDocument> FindDocument(int id);
        Task<int> Save(ClientDocument document);
        Task<int> Update(ClientDocument document);
        Task<int> ActionDocument(int id, DatabaseAction action);
        Task<bool> DocumentUploaded(int clientID, int documentTypeID);

        //Medical Details
        Medical MedicalFiles(int clientID);
        Task<ClientMedicalDetail> FindMedicalDetail(int id);
        Task<int> Save(ClientMedicalDetail ClientMedicalDetail);
        Task<int> Update(ClientMedicalDetail ClientMedicalDetail);
        Task<int> ActionMedicalDetail(int id, DatabaseAction action);

        //Dependent
        
         Dependents ClientDependents(int clientID);
        Task<ClientDependent> FindDependent(int id);
        Task<int> Save(ClientDependent ClientDependent);
        Task<int> Update(ClientDependent ClientDependent);
        Task<int> ActionDependent(int id, DatabaseAction action);

        //Product
        Task<ClientProduct> FindProduct(int id);
        Task<int> Save(ClientProduct ClientProduct);
        Task<int> Update(ClientProduct ClientProduct);
        Task<int> ActionProduct(int id, DatabaseAction action);
       ClientPackages GetClientProducts(int clientID);
        List<Product> GetClientRegisteredProducts(int id);
        InvoicePackage GetPotentialInvoiceEntries(int InvoiceID, int ProductID, DateTime InvoiceDate);
        //Course
        CoachingProgrammes Courses(int clientID);
        Task<ClientCourse> FindCourse(int id);
        Task<int> Save(ClientCourse ClientCourse);
        Task<bool> HasActiveEnrollement(int clientID, int courseID);

        Task<bool> MaximumCourseLimitReached(int courseIntakeID);
        Task<int> Update(ClientCourse ClientCourse);
        Task<int> ActionCourse(int id);

        Transactions PaidTransactions(int clientID);
        PendingTransactions PendingTransactions(int clientID, DateTime cutoffDate);
        Deductions GetClientDeductions(int clientID);
        List<ClientFee> ClientFees(int clientID);
        Task<ClientFee> FindClientFee(int id);
        Task<int> PayFee(ClientFee clientFee);
        Task<Company> GetClientCompany(int clientID);

        Task<int> UpdateSessions(int clientCourseID, string[] selectedSessions);

        SalaryHistory SalaryHistory(int clientID);

        Statement ClientStatements(int clientID);

    }
}
