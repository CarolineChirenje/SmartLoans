

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using SmartDataAccess;
using SmartDomain;
using SmartHelper;
using SmartInterfaces;
using SmartLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace SmartLogic
{
    public class KonapoFundService : IKonapoFundService
    {
        private readonly DatabaseContext _context;
        readonly ICustomSettingsService _settingService = new CustomSettingsService();
        readonly IClientService _clientService = new ClientService();
        public KonapoFundService()
        {
            if (_context == null)
            {
                var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
                optionsBuilder.UseSqlServer(GetData.SSDBConnection);
                _context = new DatabaseContext(optionsBuilder.Options);
            }
        }
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
                KonapoFund.RegistrationDate = DateTime.Now;
                KonapoFund.KonapoRef = NewKonapoRef;
                KonapoFund.LastChangedBy = UtilityService.CurrentUserName;
                KonapoFund.LastChangedDate = DateTime.Now;
                _context.Add(KonapoFund);
                int result = await _context.SaveChangesAsync();
                if (result > 0)
                    // create categories linked to fund
                    await SaveActiveKonapoFundCT(KonapoFund.FundID, KonapoFund.KonapoFundID);
                return KonapoFund.KonapoFundID;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<List<KonapoFund>> GetClientKonapoFunds(int clientID)
        {
            try
            {
                return await _context.KonapoFunds.Where(p => p.ClientID == clientID)
                            .Include(p => p.Fund)
                            .Include(p => p.KonapoFundCTs)
                            .ThenInclude(p => p.FundCategory)
                            .Include(p => p.KonapoFundCTs)
                            .ThenInclude(p => p.KonapoFundCTIs)
                            .ThenInclude(p => p.FundCategoryItem)
                            .Include(p => p.KonapoFundCTs)
                            .ThenInclude(p => p.KonapoFundCTIs)
                            .ThenInclude(p => p.FundSource)
                            .Include(m => m.Client)
                            .AsNoTracking()

                            .ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public List<CustomSelectList> GetFunds(string term)
        {
            try
            {
                var funds = (from fund in _context.Funds
                             where fund.IsActive && fund.Name.StartsWith(term)
                             select new CustomSelectList
                             {
                                 Name = fund.Name,
                                 ID = fund.FundID
                             }).ToList();
                return funds;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<ClientKonapoFund> GetKonapoFund(int KonapoFundID)
        {
            try
            {
                KonapoFund KonapoFund = await _context.KonapoFunds
                .Where(p => p.KonapoFundID == KonapoFundID)
                .Include(p => p.Fund)
                 .FirstOrDefaultAsync();
                if (UtilityService.IsNull(KonapoFund))
                    return null;
                ClientKonapoFund fund = new ClientKonapoFund
                {
                    ClientID = KonapoFund.ClientID,
                    FundID = KonapoFund.FundID,
                    KonapoRef = KonapoFund.KonapoRef,
                    KonapoFundID = KonapoFund.KonapoFundID,
                    KonapoFund = KonapoFund
                };

                List<KonapoFundCT> konapoFundCTs =
                _context.KonapoFundCTs.Where(c => c.KonapoFundID == KonapoFund.KonapoFundID)
                .Include(c => c.KonapoFundCTIs)
                .ThenInclude(c => c.FundCategoryItem)
                .ThenInclude(c => c.FundItem)
                .Include(c => c.FundCategory)
                 .AsNoTracking()
                .ToList();

                fund.KonapoFundCTs = konapoFundCTs;
                return fund;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<ClientKonapoFundCalculation> GetKonapoFundCalculation(int KonapoFundID)
        {
            try
            {
                KonapoFund KonapoFund = await _context.KonapoFunds
                .Where(p => p.KonapoFundID == KonapoFundID)
                                .Include(p => p.Fund)
                 .FirstOrDefaultAsync();
                if (UtilityService.IsNull(KonapoFund))
                    return null;
                ClientKonapoFundCalculation fund = new ClientKonapoFundCalculation
                {
                    ClientID = KonapoFund.ClientID,
                    FundID = KonapoFund.FundID,
                    KonapoRef = KonapoFund.KonapoRef,
                    KonapoFundID = KonapoFund.KonapoFundID,
                    KonapoFund = KonapoFund,
                    FundName = KonapoFund.Fund.Name,
                    ClientRef = _clientService.GetClientRef(KonapoFund.ClientID)
                };
                List<KonapoFundCT> konapoFundCTs =
              _context.KonapoFundCTs.Where(c => c.KonapoFundID == KonapoFund.KonapoFundID)
              .Include(c => c.KonapoFundCTIs)
              .ThenInclude(c => c.FundCategoryItem)
              .ThenInclude(c => c.FundItem)
              .Include(c => c.FundCategory)
               .AsNoTracking()
              .ToList();

                fund.KonapoFundCTs = konapoFundCTs;
                decimal kopanoFundResult = 0m;

                try
                {
                    string sqlCustomSetting = @"SELECT SUM(ISNULL(kfci.KonapoAmount,0))
                        FROM KonapoFundCTIs kfci
                        INNER JOIN KonapoFundCTs kfc ON kfci.KonapoFundCTID=kfc.KonapoFundCTID
                        INNER JOIN KonapoFunds kf ON kfc.KonapoFundID=kf.KonapoFundID
                        WHERE kf.KonapoFundID='" + KonapoFundID + "'";
                    string result = GetData.GetStringValue(sqlCustomSetting);
                    if (!String.IsNullOrEmpty(result))
                        kopanoFundResult = Decimal.Parse(result, CultureInfo.InvariantCulture);
                    fund.KhonapoFundAmount = Math.Round(kopanoFundResult, 2);
                }
                catch (Exception ex)
                {
                    CustomLog.Log(LogSource.Logic_Base, ex);
                }

                try
                {
                    string sqlCustomSetting = @$"
                        DROP TABLE IF EXISTS  #TempValues
                        SELECT kfc.FundCategoryID AS CategoryID, fc.Name  AS Category, ISNULL(SUM(ISNULL(kfci.KonapoAmount,0)),0) AS TotalAmount
                        INTO #TempValues
                        FROM KonapoFundCTIs kfci
                        INNER JOIN KonapoFundCTs kfc ON kfci.KonapoFundCTID=kfc.KonapoFundCTID
                        INNER JOIN FundCategories fc ON kfc.FundCategoryID=fc.FundCategoryID
                        INNER JOIN KonapoFunds kf ON kfc.KonapoFundID=kf.KonapoFundID
                        WHERE kf.KonapoFundID={KonapoFundID}
                        GROUP BY kfc.FundCategoryID , fc.Name
                        ORDER BY kfc.FundCategoryID 
                        SELECT * FROM #TempValues WHERE TotalAmount!=0
                        DROP TABLE IF EXISTS  #TempValues
                       ";
                    DataTable result = GetData.GetDataTable(sqlCustomSetting);
                    if (result != null && result.Rows.Count > 0)
                    {
                        List<CategoryAmount> categoryAmounts = new List<CategoryAmount>();
                        categoryAmounts = GetData.ConvertDataTable<CategoryAmount>(result);
                        fund.CategoryAmount = categoryAmounts;
                    }
                }
                catch (Exception ex)
                {
                    CustomLog.Log(LogSource.Logic_Base, ex);
                }

                return fund;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<ClientKonapoFundItems> GetKonapoFundCategory(int KonapoFundCTID)
        {
            try
            {
                KonapoFundCT KonapoFund = await _context.KonapoFundCTs
                .Where(p => p.KonapoFundCTID == KonapoFundCTID)
                .Include(p => p.KonapoFund)
                .ThenInclude(p => p.Fund)
                .Include(p => p.FundCategory)
                 .FirstOrDefaultAsync();
                if (UtilityService.IsNull(KonapoFund))
                    return null;
                ClientKonapoFundItems fund = new ClientKonapoFundItems
                {
                    ClientID = KonapoFund.KonapoFund.ClientID,
                    FundID = KonapoFund.KonapoFund.FundID,
                    KonapoRef = KonapoFund.KonapoFund.KonapoRef,
                    KonapoFundID = KonapoFund.KonapoFundID,
                    CategoryID = KonapoFundCTID,
                    CategoryName = KonapoFund.FundCategory.Name,
                    KonapoFund = KonapoFund.KonapoFund,
                    FundDetails = KonapoFund.KonapoFund.FundDetails,
                    IsActive = KonapoFund.IsActive
                };
                List<KonapoFundCTI> konapoFundCTIs =
                _context.KonapoFundCTIs.Where(p => p.KonapoFundCTID == KonapoFundCTID)
                 .Include(c => c.FundCategoryItem)
                .ThenInclude(c => c.FundItem)
                .Include(c => c.FundSource)
                .AsNoTracking()
                .ToList();
                fund.KonapoFundCTIs = konapoFundCTIs;
                return fund;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<KonapoFund> FindKonapoFund(int konapoFundID)
        {
            try
            {
                return await _context.KonapoFunds.Where(r => r.KonapoFundID == konapoFundID)
                             .AsNoTracking()
                          .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<KonapoFundCTI> FindKonapoFundCTI(int konapoFundCTIID)
        {
            try
            {
                return await _context.KonapoFundCTIs.Where(r => r.KonapoFundCTIID == konapoFundCTIID)
                  .Include(c => c.FundCategoryItem)
                   .ThenInclude(c => c.FundCategory)
                    .Include(c => c.FundCategoryItem)
                   .ThenInclude(c => c.FundItem)
                   .Include(c => c.FundSource)
                  .Include(c => c.KonapoFundCT)
                  .ThenInclude(c => c.KonapoFund)
                   .ThenInclude(c => c.Fund)
                   .AsNoTracking()
                   .FirstOrDefaultAsync();
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
                            .Include(p => p.Fund)
                            .Include(p => p.KonapoFundCTs)
                            .ThenInclude(p => p.FundCategory)
                            .Include(p => p.KonapoFundCTs)
                            .ThenInclude(p => p.KonapoFundCTIs)
                            .ThenInclude(p => p.FundCategoryItem)
                            .Include(p => p.KonapoFundCTs)
                            .ThenInclude(p => p.KonapoFundCTIs)
                            .ThenInclude(p => p.FundSource)
                            .Include(m => m.Client)
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
        public async Task<KonapoFundReport> FindKonapoReport(int konapoFundReportID)
        {
            try
            {
                return await _context.KonapoFundReports.Where(r => r.KonapoFundReportID == konapoFundReportID)
                             .AsNoTracking()
                          .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Update(KonapoFundReport konapoFundReport)
        {
            try
            {

                KonapoFundReport konareport = _context.KonapoFundReports.Find(konapoFundReport.KonapoFundReportID);
                if (UtilityService.IsNotNull(konareport))
                {
                    konareport.Report = konapoFundReport.Report;
                    konareport.LastChangedBy = UtilityService.CurrentUserName;
                    konareport.LastChangedDate = DateTime.Now;
                    _context.Update(konareport);
                    return await _context.SaveChangesAsync();
                }
                return 0;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }

        public async Task<int> Save(KonapoFundReport konapoFundReport)
        {
            try
            {
                konapoFundReport.LastChangedBy = UtilityService.CurrentUserName;
                konapoFundReport.LastChangedDate = DateTime.Now;
                _context.Add(konapoFundReport);
                int result = await _context.SaveChangesAsync();
                return result;
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
                if (UtilityService.IsNull(KonapoFund))
                    return 0;
                var fundCT = _context.KonapoFundCTs.Where(fc => fc.KonapoFundID == id).ToList();
                List<int> fundCTList = fundCT.Select(c => c.KonapoFundCTID).ToList();
                var fundCTI = _context.KonapoFundCTIs.Where(p => fundCTList.Any(p2 => p2 == p.KonapoFundCTIID)).ToList();
                _context.KonapoFundCTIs.RemoveRange(fundCTI);
                _context.KonapoFundCTs.RemoveRange(fundCT);
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

                KonapoFund KonapoFund = _context.KonapoFunds.Find(KonapoFundID);
                if (DatabaseAction.Remove == action)
                    _context.KonapoFunds.Remove(KonapoFund);
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    KonapoFund.IsActive = DatabaseAction.Deactivate != action;
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

        public async Task<int> Save(KonapoFundCTI konapoFundCTI)
        {
            try
            {

                konapoFundCTI.LastChangedBy = UtilityService.CurrentUserName;
                konapoFundCTI.LastChangedDate = DateTime.Now;
                _context.Add(konapoFundCTI);
                await _context.SaveChangesAsync();
                return konapoFundCTI.KonapoFundCTIID;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<bool> IsDuplicate(KonapoFundCTI KonapoFund)
        {
            try
            {
                KonapoFundCTI Fund = await _context.KonapoFundCTIs.Where(b => b.FundCategoryItemID == KonapoFund.FundCategoryItemID && b.KonapoFundCTID == KonapoFund.KonapoFundCTID).FirstOrDefaultAsync();
                return UtilityService.IsNotNull(Fund);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Update(KonapoFundCTI update)
        {
            try
            {

                KonapoFundCTI KonapoFund = _context.KonapoFundCTIs.Find(update.KonapoFundCTIID);
                KonapoFundCTI old_KonapoFund = KonapoFund;
                KonapoFund.ProjectedCost = update.ProjectedCost;
                KonapoFund.KonapoAmount = update.KonapoAmount;
                KonapoFund.FundSourceID = update.FundSourceID;
                KonapoFund.LastChangedBy = UtilityService.CurrentUserName;
                KonapoFund.LastChangedDate = DateTime.Now;
                _context.Update(KonapoFund);

                // save history
                KonapoFundCTIHistory KonapoFundHistory = new KonapoFundCTIHistory
                {
                    KonapoFundCTIID = old_KonapoFund.KonapoFundCTIID,
                    FundSourceID = old_KonapoFund.FundSourceID,
                    ProjectedCost = old_KonapoFund.ProjectedCost,
                    KonapoAmount = old_KonapoFund.KonapoAmount,
                    LastChangedBy = old_KonapoFund.LastChangedBy,
                    LastChangedDate = old_KonapoFund.LastChangedDate
                };
                _context.Add(KonapoFundHistory);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        public async Task<int> DeleteKonapoFundCTI(int id)
        {
            try
            {
                var KonapoFund = await _context.KonapoFundCTIs.FindAsync(id);
                _context.KonapoFundCTIs.Remove(KonapoFund);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<List<KonapoFundCTI>> GetKonapoFundCTIs(int categoryId)
        {
            try
            {
                return await _context.KonapoFundCTIs.Where(p => p.KonapoFundCTID == categoryId)
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
        public async Task<bool> IsDuplicate(KonapoFundCT KonapoFund)
        {
            try
            {
                KonapoFundCT Fund = await _context.KonapoFundCTs.Where(b => b.KonapoFundID == KonapoFund.KonapoFundID && b.FundCategoryID == KonapoFund.FundCategoryID).FirstOrDefaultAsync();
                return UtilityService.IsNotNull(Fund);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> SaveActiveKonapoFundCT(int fundID, int konapoFundID)
        {
            int result = 0;
            try
            {
                var categories = _context.FundCategories.
                 Include(fc => fc.FundCategoryItems).
                 Where(f => f.FundID == fundID && f.IsActive).ToList();
                foreach (var category in categories)
                {
                    KonapoFundCT konapoFundCT = new KonapoFundCT
                    {
                        KonapoFundID = konapoFundID,
                        FundCategoryID = category.FundCategoryID,
                        IsActive = true
                    };

                    if (!IsDuplicate(konapoFundCT).Result)
                        result = await Save(konapoFundCT);

                    if (result > 0) // ID used to save KFCT
                    {
                        var fundItems = category.FundCategoryItems.Where(f => f.IsActive).ToList();
                        if (fundItems != null && fundItems.Count() > 0)
                        {
                            foreach (var fundItem in fundItems)
                            {
                                KonapoFundCTI konapoFundCTI = new KonapoFundCTI
                                {
                                    FundCategoryItemID = fundItem.FundCategoryItemID,
                                    KonapoFundCTID = result,
                                    FundSourceID = (int)Cash_Type.Not_Specified
                                };
                                if (!IsDuplicate(konapoFundCTI).Result)
                                    await Save(konapoFundCTI);
                            }
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



        public async Task<int> Save(KonapoFundCT konapoFundCT)
        {
            try
            {

                konapoFundCT.LastChangedBy = UtilityService.CurrentUserName;
                konapoFundCT.LastChangedDate = DateTime.Now;
                _context.Add(konapoFundCT);
                int result = await _context.SaveChangesAsync();
                return konapoFundCT.KonapoFundCTID;
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
                Fund.IsActive = fund.IsActive;
                Fund.Name = fund.Name;
                Fund.Description = fund.Description;
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
                    Fund.IsActive = DatabaseAction.Deactivate != action;
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
                    FundItem.IsActive = DatabaseAction.Deactivate != action;
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
                    FundCategory.IsActive = DatabaseAction.Deactivate != action;
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
                    FundCategory.IsActive = DatabaseAction.Deactivate != action;
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

