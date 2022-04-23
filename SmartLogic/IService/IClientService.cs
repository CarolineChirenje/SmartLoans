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
        List<ClientList> Clients(string accountNumber = null, bool newClientsOnly = false, int productID = 0, int companyID=0);

        List<ClientList> Birthdays();
        Task<List<string>> ClientAccountNumbers(string account);
        Task<ClientPeek> GetClient(string emailAddress=null, string idnumber=null,int? clientID=null);
       
        Task<bool> ClientExists(int Clientid = 0);

       Task<ClientLoans> GetClientLoans(int clientID);

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

        
        //Dependent
        
         Dependents ClientDependents(int clientID);
        Task<ClientDependent> FindDependent(int id);
        Task<int> Save(ClientDependent ClientDependent);
        Task<int> Update(ClientDependent ClientDependent);
        Task<int> ActionDependent(int id, DatabaseAction action);

     
        Task<Company> GetClientCompany(int clientID);
        SalaryHistory SalaryHistory(int clientID);


    }
}
