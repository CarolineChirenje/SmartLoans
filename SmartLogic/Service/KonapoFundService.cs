

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using SmartDataAccess;
using SmartDomain;
using SmartHelper;
using SmartLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace SmartLogic
{
    public class KonapoFundService : IKonapoFundService
    {
        private readonly DatabaseContext _context;
        ICustomSettingsService _settingService = new CustomSettingsService();
        public KonapoFundService(DatabaseContext context) => _context = context;

        #region KonapoRef
        public string NewKonapoRef
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
                return _context.KonapoFunds.Any(m => m.KonapoRef.Equals(accountNumber));
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
                string accNumberPrefix = "KNP";
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
        #region KonapoFund
        public async Task<List<KonapoFund>> GetClientKonapoFunds(int clientID)
        {
            try
            {
                return await _context.KonapoFunds.Where(p => p.ClientID == clientID)
               .Include(m => m.Client)
                               .Include(p => p.Fund)
                .ThenInclude(p => p.FundCategories)
                .ThenInclude(p => p.FundCategoryItems)
             .AsNoTracking()
             .ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public async Task<KonapoFund> GetKonapoFund(int KonapoFundID)
        {
            try
            {

                KonapoFund KonapoFund = await _context.KonapoFunds
                   .Where(r => r.KonapoFundID == KonapoFundID)
                           .Include(m => m.Client)
                      .Include(p => p.KonapoFundDetails)
                      .Include(p => p.Fund)
                      .ThenInclude(p => p.FundCategories)
                      .ThenInclude(p => p.FundCategoryItems)
                   .AsNoTracking().FirstOrDefaultAsync();

                return KonapoFund;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<KonapoFund> GetKonapoFund(string name)
        {
            try
            {
                return await _context.KonapoFunds.Where(r => r.Fund.Name.ToUpper() == name.Trim().ToUpper())
                              .Include(m => m.Client)
                      .Include(p => p.KonapoFundDetails)
                      .Include(p => p.Fund)
                      .ThenInclude(p => p.FundCategories)
                      .ThenInclude(p => p.FundCategoryItems)
                               .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<List<KonapoFund>> GetKonapoFunds(string refNumber = null, bool newfundsOnly = false)
        {
            try
            {

                var funds = await _context.KonapoFunds
                  .Include(m => m.Client)
                 .Include(p => p.Fund)
                   .ThenInclude(p => p.FundCategories)
                   .ThenInclude(p => p.FundCategoryItems)
                .AsNoTracking()
                .ToListAsync();
                if (funds == null)
                    return null;

                if (!String.IsNullOrEmpty(refNumber))
                    funds = funds.Where(m => m.KonapoRef.Contains(refNumber.Trim())).ToList();

                if (newfundsOnly)
                    funds = funds.Where(rp => rp.RegistrationDate.Date >= DateTime.Now.AddDays(-1).Date && rp.RegistrationDate.Date <= DateTime.Now.Date).ToList();
                return funds;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public async Task<int> Update(KonapoFund update)
        {
            try
            {

                KonapoFund KonapoFund = _context.KonapoFunds.Find(update.KonapoFundID);
                KonapoFund old_KonapoFund = KonapoFund;
                KonapoFund.IsActive = update.IsActive;
                KonapoFund.LastChangedBy = UtilityService.CurrentUserName;
                KonapoFund.LastChangedDate = DateTime.Now;
                _context.Update(KonapoFund);

                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        public async Task<int> Save(KonapoFund KonapoFund)
        {
            try
            {
                KonapoFund.KonapoRef = NewKonapoRef;
                KonapoFund.LastChangedBy = UtilityService.CurrentUserName;
                KonapoFund.LastChangedDate = DateTime.Now;
                _context.Add(KonapoFund);
                await _context.SaveChangesAsync();
                return KonapoFund.KonapoFundID;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public async Task<int> DeleteKonapoFund(int id)
        {
            try
            {
                var KonapoFund = await _context.KonapoFunds.FindAsync(id);
                _context.KonapoFunds.Remove(KonapoFund);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> ActionKonapoFund(int KonapoFundID, DatabaseAction action)
        {
            try
            {

                KonapoFund KonapoFund = await GetKonapoFund(KonapoFundID);
                if (DatabaseAction.Remove == action)
                    _context.KonapoFunds.Remove(KonapoFund);
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    KonapoFund.IsActive = DatabaseAction.Deactivate == action ? false : true;
                    KonapoFund.LastChangedBy = UtilityService.CurrentUserName;
                    KonapoFund.LastChangedDate = DateTime.Now;
                    _context.Update(KonapoFund);
                }
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<bool> IsDuplicate(KonapoFund KonapoFund)
        {
            try
            {
                KonapoFund Fund = await _context.KonapoFunds.Where(b => b.ClientID == KonapoFund.ClientID && b.FundID == KonapoFund.FundID).FirstOrDefaultAsync();
                return UtilityService.IsNotNull(Fund);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> Save(KonapoFundDetail konapoFundDetail)
        {
            try
            {

                konapoFundDetail.LastChangedBy = UtilityService.CurrentUserName;
                konapoFundDetail.LastChangedDate = DateTime.Now;
                _context.Add(konapoFundDetail);
                await _context.SaveChangesAsync();
                return konapoFundDetail.KonapoFundDetailID;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<bool> IsDuplicate(KonapoFundDetail KonapoFund)
        {
            try
            {
                KonapoFundDetail Fund = await _context.KonapoFundDetails.Where(b => b.FundCategoryItemID == KonapoFund.FundCategoryItemID && b.KFundID == KonapoFund.KFundID).FirstOrDefaultAsync();
                return UtilityService.IsNotNull(Fund);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Update(KonapoFundDetail update)
        {
            try
            {

                KonapoFundDetail KonapoFund = _context.KonapoFundDetails.Find(update.KonapoFundDetailID);
                KonapoFundDetail old_KonapoFund = KonapoFund;
                KonapoFund.ProjectedCost = update.ProjectedCost;
                KonapoFund.KonapoAmount = update.KonapoAmount;
                KonapoFund.FundSourceID = update.FundSourceID;
                KonapoFund.LastChangedBy = UtilityService.CurrentUserName;
                KonapoFund.LastChangedDate = DateTime.Now;
                _context.Update(KonapoFund);

                // save history
                KonapoFundDetailHistory KonapoFundHistory = new KonapoFundDetailHistory();
                KonapoFundHistory.KonapoFundDetailID = old_KonapoFund.KonapoFundDetailID;
                KonapoFundHistory.FundSourceID = old_KonapoFund.FundSourceID;
                KonapoFundHistory.ProjectedCost = old_KonapoFund.ProjectedCost;
                KonapoFundHistory.KonapoAmount = old_KonapoFund.KonapoAmount;
                KonapoFundHistory.LastChangedBy = old_KonapoFund.LastChangedBy;
                KonapoFundHistory.LastChangedDate = old_KonapoFund.LastChangedDate;
                _context.Add(KonapoFundHistory);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        public async Task<int> DeleteKonapoFundDetail(int id)
        {
            try
            {
                var KonapoFund = await _context.KonapoFundDetails.FindAsync(id);
                _context.KonapoFundDetails.Remove(KonapoFund);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<List<KonapoFundDetail>> GetKonapoFundDetails(int id)
        {
            try
            {
                return await _context.KonapoFundDetails.Where(p => p.KFundID == id)
               .Include(m => m.FundSource)
                .Include(p => p.FundCategoryItem)
                .ThenInclude(p => p.FundCategory)
                .ThenInclude(p => p.Fund)
               
             .AsNoTracking()
             .ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        #endregion KonapoFund

        #region Fund
        public async Task<Fund> FindFund(int FundID)
        {
            try
            {
                return await _context.Funds.Where(a => a.FundID == FundID)
                            .Include(a => a.FundCategories)
                .ThenInclude(a => a.FundCategoryItems)
                .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Save(Fund Fund)
        {
            try
            {
                Fund.LastChangedBy = UtilityService.CurrentUserName;
                Fund.LastChangedDate = DateTime.Now;
                _context.Add(Fund);
                await _context.SaveChangesAsync();
                return Fund.FundID;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<bool> IsDuplicate(Fund fund)
        {
            try
            {
                Fund Fund = await _context.Funds.Where(b => b.Name.Equals(fund.Name)).FirstOrDefaultAsync();
                return UtilityService.IsNotNull(Fund);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Update(Fund fund)
        {
            try
            {
                Fund Fund = _context.Funds.Find(fund.FundID);
                Fund.IsActive = Fund.IsActive;
                Fund.Name = Fund.Name;
                Fund.Description = Fund.Description;
                Fund.LastChangedBy = UtilityService.CurrentUserName;
                Fund.LastChangedDate = DateTime.Now;
                _context.Update(Fund);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> ActionFund(int FundID, DatabaseAction action)
        {
            try
            {
                Fund Fund = await FindFund(FundID);
                if (DatabaseAction.Remove == action)
                    _context.Funds.Remove(Fund);
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    Fund.IsActive = DatabaseAction.Deactivate == action ? false : true;
                    Fund.LastChangedBy = UtilityService.CurrentUserName;
                    Fund.LastChangedDate = DateTime.Now;
                    _context.Update(Fund);
                }
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<List<Fund>> Funds()
        {
            try
            {
                return await _context.Funds
                .Include(a => a.FundCategories)
                .ThenInclude(a => a.FundCategoryItems)
                .ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        #endregion Fund
        #region Fund Item
        public async Task<FundItem> FindFundItem(int FundItemID)
        {
            try
            {
                return await _context.FundItems.Where(a => a.FundItemID == FundItemID)
                   .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Save(FundItem FundItem)
        {
            try
            {
                FundItem.LastChangedBy = UtilityService.CurrentUserName;
                FundItem.LastChangedDate = DateTime.Now;
                _context.Add(FundItem);
                await _context.SaveChangesAsync();
                return FundItem.FundItemID;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<bool> IsDuplicate(FundItem fundItem)
        {
            try
            {
                FundItem FundItem = await _context.FundItems.Where(b => b.Name.Equals(fundItem.Name)).FirstOrDefaultAsync();
                return UtilityService.IsNotNull(FundItem);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Update(FundItem fundItem)
        {
            try
            {
                FundItem FundItem = _context.FundItems.Find(fundItem.FundItemID);
                FundItem.IsActive = fundItem.IsActive;
                FundItem.Name = fundItem.Name;
                FundItem.LastChangedBy = UtilityService.CurrentUserName;
                FundItem.LastChangedDate = DateTime.Now;
                _context.Update(FundItem);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> ActionFundItem(int FundItemID, DatabaseAction action)
        {
            try
            {
                FundItem FundItem = await FindFundItem(FundItemID);
                if (DatabaseAction.Remove == action)
                    _context.FundItems.Remove(FundItem);
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    FundItem.IsActive = DatabaseAction.Deactivate == action ? false : true;
                    FundItem.LastChangedBy = UtilityService.CurrentUserName;
                    FundItem.LastChangedDate = DateTime.Now;
                    _context.Update(FundItem);
                }
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<List<FundItem>> FundItems()
        {
            try
            {
                return await _context.FundItems
                                .ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> DeleteFundItem(int id)
        {
            try
            {
                var fundItem = await _context.FundItems.FindAsync(id);
                _context.FundItems.Remove(fundItem);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        #endregion Fund  Item

        #region FundCategories
        public List<FundCategory> GetFundCategories(int Fundid)
        {
            try
            {
                return _context.FundCategories
             .Where(c => c.FundID == Fundid).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<List<FundItem>> GetFundItemNotInCategory(int fundCategoryID)
        {
            try
            {
                var fundItemsInCategory = _context.FundCategoryItems.Where(fc => fc.FundCategoryID == fundCategoryID).ToList();
                var fundItems = await FundItems();
                if (fundItemsInCategory == null || fundItemsInCategory.Count() == 0)
                    return fundItems;

                var result = fundItems.Where(item =>
   !fundItemsInCategory.Any(category => category.FundItemID.Equals(item.FundItemID)));
                return result.ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<FundCategory> FindFundCategory(int id)
        {
            try
            {
                return await _context.FundCategories.
                    Include(c => c.Fund).
                    Include(c => c.FundCategoryItems).
                   ThenInclude(c => c.FundItem).
                  Where(r => r.FundCategoryID == id)
                     .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Save(FundCategory FundCategory)
        {
            try
            {
                FundCategory.LastChangedBy = UtilityService.CurrentUserName;
                FundCategory.LastChangedDate = DateTime.Now;
                _context.Add(FundCategory);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Update(FundCategory fundCategory)
        {
            try
            {

                FundCategory FundCategory = _context.FundCategories.Find(fundCategory.FundCategoryID);
                FundCategory.IsActive = fundCategory.IsActive;
                FundCategory.Name = fundCategory.Name;
                FundCategory.LastChangedBy = UtilityService.CurrentUserName;
                FundCategory.LastChangedDate = DateTime.Now;
                _context.Update(FundCategory);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> ActionFundCategory(int id, DatabaseAction action)
        {
            try
            {
                FundCategory FundCategory = await FindFundCategory(id);
                if (DatabaseAction.Remove == action)
                    _context.FundCategories.Remove(FundCategory);
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    FundCategory.IsActive = DatabaseAction.Deactivate == action ? false : true;
                    FundCategory.LastChangedBy = UtilityService.CurrentUserName;
                    FundCategory.LastChangedDate = DateTime.Now;
                    _context.Update(FundCategory);
                }
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<bool> IsDuplicate(FundCategory FundCategory)
        {
            try
            {
                FundCategory _FundCategory = await _context.FundCategories.Where(b => b.Name.Equals(FundCategory.Name)).FirstOrDefaultAsync();
                return UtilityService.IsNotNull(_FundCategory);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }

        #endregion FundCategories

        #region FundCategoryItem
        public async Task<FundCategoryItem> FindFundCategoryItem(int id)
        {
            try
            {
                return await _context.FundCategoryItems.
                    Include(c => c.FundCategory).
                  Where(r => r.FundCategoryItemID == id)
                     .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<FundCategoryItem> GetFundCategoryItem(int id)
        {
            try
            {
                return await _context.FundCategoryItems.
                    Include(c => c.FundCategory).
                     Where(r => r.FundCategoryItemID == id)
                     .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Save(FundCategoryItem fundCategoryItem)
        {
            try
            {
                fundCategoryItem.LastChangedBy = UtilityService.CurrentUserName;
                fundCategoryItem.LastChangedDate = DateTime.Now;
                _context.Add(fundCategoryItem);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Update(FundCategoryItem fundCategoryItem)
        {
            try
            {

                FundCategoryItem fundCategoryItem1 = _context.FundCategoryItems.Find(fundCategoryItem.FundCategoryID);
                fundCategoryItem1.IsActive = fundCategoryItem.IsActive;
                fundCategoryItem1.LastChangedBy = UtilityService.CurrentUserName;
                fundCategoryItem1.LastChangedDate = DateTime.Now;
                _context.Update(fundCategoryItem1);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> ActionFundCategoryItem(int id, DatabaseAction action)
        {
            try
            {
                FundCategoryItem FundCategory = await FindFundCategoryItem(id);
                if (DatabaseAction.Remove == action)
                    _context.FundCategoryItems.Remove(FundCategory);
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    FundCategory.IsActive = DatabaseAction.Deactivate == action ? false : true;
                    FundCategory.LastChangedBy = UtilityService.CurrentUserName;
                    FundCategory.LastChangedDate = DateTime.Now;
                    _context.Update(FundCategory);
                }
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public async Task<bool> IsDuplicate(FundCategoryItem fundCategoryItem)
        {
            try
            {
                FundCategoryItem fundCategoryItem1 = await _context.FundCategoryItems.Where(b => b.FundCategoryID == fundCategoryItem.FundCategoryID && b.FundItemID == fundCategoryItem.FundItemID).FirstOrDefaultAsync();
                return UtilityService.IsNotNull(fundCategoryItem1);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }

        #endregion FundCategoryItem
    }
}

