using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace SmartLogic
{
    public interface IKonapoFundService
    {

        Task<int> DeleteKonapoFund(int id);
        Task<int> Save(KonapoFund KonapoFund);
        Task<int> Update(KonapoFund KonapoFund);
        Task<int> ActionKonapoFund(int KonapoFundId, DatabaseAction action);
        Task<KonapoFund> GetKonapoFund(int KonapoFundId);
        Task<List<KonapoFund>> GetKonapoFunds(string refNumber = null, bool newfundsOnly = false);
        Task<List<KonapoFund>> GetClientKonapoFunds(int clientID);
        Task<bool> IsDuplicate(KonapoFund KonapoFund);
        List<CustomSelectList> GetFunds(string term);
        Task<int> DeleteKonapoFundDetail(int id);
        Task<int> Save(KonapoFundDetail KonapoFund);
        Task<int> Update(KonapoFundDetail KonapoFund);
        Task<bool> IsDuplicate(KonapoFundDetail KonapoFund);
        Task<List<KonapoFundDetail>> GetKonapoFundDetails(int KonapoFundId);

        //Funds
        Task<List<Fund>> Funds();
        Task<Fund> FindFund(int FundID);
        Task<int> Save(Fund Fund);
        Task<bool> IsDuplicate(Fund Fund);
        Task<int> Update(Fund Fund);
        Task<int> ActionFund(int FundID, DatabaseAction action);
      


        //Fund Categories
        List<FundCategory> GetFundCategories(int Fundid);
        Task<FundCategory> FindFundCategory(int id);
        Task<int> Save(FundCategory FundCategory);
        Task<int> Update(FundCategory FundCategory);
        Task<int> ActionFundCategory(int id, DatabaseAction action);
        Task<bool> IsDuplicate(FundCategory FundCategory);


        //Fund Category Items
        Task<FundCategoryItem> GetFundCategoryItem(int id);
        Task<int> Save(FundCategoryItem  fundCategoryItem);
        Task<int> Update(FundCategoryItem fundCategoryItem);
        Task<int> ActionFundCategoryItem(int id, DatabaseAction action);
        Task<bool> IsDuplicate(FundCategoryItem fundCategoryItem);
        Task<List<FundItem>> GetFundItemNotInCategory(int fundCategoryID);

        //Fund Item
        Task<List<FundItem>> FundItems();
        Task<FundItem> FindFundItem(int ID);
        Task<int> Save(FundItem fundItem);
        Task<bool> IsDuplicate(FundItem fundItem);
        Task<int> Update(FundItem fundItem);
        Task<int> ActionFundItem(int id, DatabaseAction action);
        Task<int> DeleteFundItem(int id);

    }
}


