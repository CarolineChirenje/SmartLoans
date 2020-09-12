using SmartDomain;
using SmartHelper;
using SmartLogic;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SmartLogic
{
    public interface IClientService
    {

        Task<int> Delete(int id);


        Task<int> ActionClient(int id, DatabaseAction action);
        Task<int> Save(Client Client);
        Task<int> Update(Client Client);
        Task<Client> FindClient(int Clientid = 0, string accountNumber = null);
        Task<List<Client>> Clients();
        Task<List<Client>> NewClients();
        Task<List<string>> ClientAccountNumbers(string account);



        //Notes
        Task<ClientNote> FindNote(int id);
        Task<int> Save(ClientNote note);
        Task<int> Update(ClientNote note);
        Task<int> ActionNote(int id, DatabaseAction action);


        //Contact
        Task<ClientContact> FindContact(int id);
        Task<int> Save(ClientContact contact);
        Task<int> Update(ClientContact contact);
        Task<int> ActionContact(int id, DatabaseAction action);


        //Document
        Task<ClientDocument> FindDocument(int id);
        Task<int> Save(ClientDocument document);
        Task<int> Update(ClientDocument document);
        Task<int> ActionDocument(int id, DatabaseAction action);

       
        //Medical Details
        Task<ClientMedicalDetail> FindMedicalDetail(int id);
        Task<int> Save(ClientMedicalDetail ClientMedicalDetail);
        Task<int> Update(ClientMedicalDetail ClientMedicalDetail);
        Task<int> ActionMedicalDetail(int id, DatabaseAction action);


        //Guarantor
        Task<ClientGuarantor> FindGuarantor(int id);
        Task<int> Save(ClientGuarantor ClientGuarantor);
        Task<int> Update(ClientGuarantor ClientGuarantor);
        Task<int> ActionGuarantor(int id, DatabaseAction action);

        //Dependent
        Task<ClientDependent> FindDependent(int id);
        Task<int> Save(ClientDependent ClientDependent);
        Task<int> Update(ClientDependent ClientDependent);
        Task<int> ActionDependent(int id, DatabaseAction action);

        //Product
        Task<ClientProduct> FindProduct(int id);
        Task<int> Save(ClientProduct ClientProduct);
        Task<int> Update(ClientProduct ClientProduct);
        Task<int> ActionProduct(int id, DatabaseAction action);
        List<ClientProduct> GetClientProducts(int id);
        List<Product> GetClientRegisteredProducts(int id);
    }
}
