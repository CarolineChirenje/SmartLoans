using SmartLogic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartDomain;
using SmartDataAccess;
using SmartHelper;
using SmartLogic.IService;
using SmartLog;
using SmartExtensions;

namespace SmartLogic
{
    public class LoanService : ILoanService
    {
        private readonly DatabaseContext _context;
        public LoanService(DatabaseContext context) => _context = context;


        #region LoanSector
        public async Task<bool> IsDuplicate(LoanSector sector)
        {
            bool result = false;
            try
            {
                LoanSector loanSector = await _context.LoanSectors.Where(b => b.Name.Equals(sector.Name)).FirstOrDefaultAsync();
                result = sector.IsNotNull();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }
        public async Task<List<LoanSector>> LoanSectors()
        {
            List<LoanSector> result = null;
            try
            {
                result = await _context.LoanSectors
                              .AsNoTracking()
               .ToListAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;

        }

        public async Task<int> DeleteLoanSector(int id)
        {
            int result = 0;
            try
            {
                var _result = await _context.LoanSectors.FindAsync(id);
                _context.LoanSectors.Remove(_result);
                result = await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }

        public async Task<LoanSector> FindSector(int id)
        {
            LoanSector result = null;
            try
            {
                result = await _context.LoanSectors.Where(r => r.LoanSectorID == id)
                                 .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }

        public async Task<int> Save(LoanSector Sector)
        {

            try
            {
                Sector.LastChangedBy = UserAppData.CurrentUserName;
                Sector.LastChangedDate = DateTime.Now;
                _context.Add(Sector);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return Sector.LoanSectorID;
        }


        public async Task<int> Update(LoanSector sector)
        {
            try
            {

                LoanSector update = _context.LoanSectors.Where(r => r.LoanSectorID == sector.LoanSectorID).FirstOrDefault();
                update.IsActive = sector.IsActive;
                update.LastChangedBy = UserAppData.CurrentUserName;
                update.LastChangedDate = DateTime.Now;
                _context.Update(update);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        #endregion LoanSector


        #region LoanType
        public async Task<bool> IsDuplicate(LoanType type)
        {
            bool result = false;
            try
            {
                LoanType loanTypes = await _context.LoanTypes.Where(b => b.Name.Equals(type.Name)).FirstOrDefaultAsync();
                result = loanTypes.IsNotNull();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }
        public async Task<List<LoanType>> LoanTypes()
        {
            List<LoanType> result = null;
            try
            {
                result = await _context.LoanTypes
                              .AsNoTracking()
               .ToListAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;

        }

        public async Task<int> DeleteLoanType(int id)
        {
            int result = 0;
            try
            {
                var _result = await _context.LoanTypes.FindAsync(id);
                _context.LoanTypes.Remove(_result);
                result = await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }

        public async Task<LoanType> FindLoanType(int id)
        {
            LoanType result = null;
            try
            {
                result = await _context.LoanTypes.Where(r => r.LoanTypeID == id)
                                 .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }

        public async Task<int> Save(LoanType loanType)
        {

            try
            {
                loanType.LastChangedBy = UserAppData.CurrentUserName;
                loanType.LastChangedDate = DateTime.Now;
                _context.Add(loanType);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return loanType.LoanTypeID;
        }


        public async Task<int> Update(LoanType loanType)
        {
            try
            {

                LoanType update = _context.LoanTypes.Where(r => r.LoanTypeID == loanType.LoanTypeID).FirstOrDefault();
                update.IsActive = loanType.IsActive;
                update.LastChangedBy = UserAppData.CurrentUserName;
                update.LastChangedDate = DateTime.Now;
                _context.Update(update);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        #endregion LoanType



        #region LoanUse
        public async Task<bool> IsDuplicate(LoanUse loanUse)
        {
            bool result = false;
            try
            {
                LoanUse use = await _context.LoanUses.Where(b => b.Name.Equals(loanUse.Name)).FirstOrDefaultAsync();
                result = use.IsNotNull();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }
        public async Task<List<LoanUse>> LoanUses()
        {
            List<LoanUse> result = null;
            try
            {
                result = await _context.LoanUses
                              .AsNoTracking()
               .ToListAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;

        }

        public async Task<int> DeleteLoanUse(int id)
        {
            int result = 0;
            try
            {
                var _result = await _context.LoanUses.FindAsync(id);
                _context.LoanUses.Remove(_result);
                result = await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }

        public async Task<LoanUse> FindLoanUse(int id)
        {
            LoanUse result = null;
            try
            {
                result = await _context.LoanUses.Where(r => r.LoanUseID == id)
                                 .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }

        public async Task<int> Save(LoanUse loanUse)
        {

            try
            {
                loanUse.LastChangedBy = UserAppData.CurrentUserName;
                loanUse.LastChangedDate = DateTime.Now;
                _context.Add(loanUse);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return loanUse.LoanUseID;
        }


        public async Task<int> Update(LoanUse loanUse)
        {
            try
            {

                LoanUse update = _context.LoanUses.Where(r => r.LoanUseID == loanUse.LoanUseID).FirstOrDefault();
                update.IsActive = loanUse.IsActive;
                update.LastChangedBy = UserAppData.CurrentUserName;
                update.LastChangedDate = DateTime.Now;
                _context.Update(update);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        #endregion LoanUse


        #region LoanStatus
        public async Task<bool> IsDuplicate(LoanStatus loanStatus)
        {
            bool result = false;
            try
            {
                LoanStatus use = await _context.LoanStatus.Where(b => b.Name.Equals(loanStatus.Name)).FirstOrDefaultAsync();
                result = use.IsNotNull();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }
        public async Task<List<LoanStatus>> LoanStatuses()
        {
            List<LoanStatus> result = null;
            try
            {
                result = await _context.LoanStatus
                              .AsNoTracking()
               .ToListAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;

        }

        public async Task<int> DeleteLoanStatus(int id)
        {
            int result = 0;
            try
            {
                
                var _result = await _context.LoanStatus.FindAsync(id);
                if (_result.LoanStatusID <= (Enum.GetNames(typeof(LoanState)).Length))
                    return 0;
                _context.LoanStatus.Remove(_result);
                result = await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }

        public async Task<LoanStatus> FindLoanStatus(int id)
        {
            LoanStatus result = null;
            try
            {
                result = await _context.LoanStatus.Where(r => r.LoanStatusID == id)
                                 .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }

        public async Task<int> Save(LoanStatus loanStatus)
        {

            try
            {
                loanStatus.LastChangedBy = UserAppData.CurrentUserName;
                loanStatus.LastChangedDate = DateTime.Now;
                _context.Add(loanStatus);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return loanStatus.LoanStatusID;
        }


        public async Task<int> Update(LoanStatus loanStatus)
        {
            try
            {
                if (loanStatus.LoanStatusID <= (Enum.GetNames(typeof(LoanState)).Length))
                    return 1;

                LoanStatus update = _context.LoanStatus.Where(r => r.LoanStatusID == loanStatus.LoanStatusID).FirstOrDefault();
                update.IsActive = loanStatus.IsActive;
                update.LastChangedBy = UserAppData.CurrentUserName;
                update.LastChangedDate = DateTime.Now;
                _context.Update(update);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        #endregion LoanUse


        #region Fiscal
        public async Task<bool> IsDuplicate(FiscalYear fiscalYear)
        {
            bool result = false;
            try
            {
                FiscalYear use = await _context.FiscalYears.Where(b => b.Name.Equals(fiscalYear.Name)).FirstOrDefaultAsync();
                result = use.IsNotNull();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }
        public async Task<List<FiscalYear>> FiscalYears()
        {
            List<FiscalYear> result = null;
            try
            {
                result = await _context.FiscalYears
                              .AsNoTracking()
               .ToListAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;

        }

        public async Task<int> DeleteFiscal(int id)
        {
            int result = 0;
            try
            {
                var _result = await _context.FiscalYears.FindAsync(id);
                _context.FiscalYears.Remove(_result);
                result = await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }

        public async Task<FiscalYear> FindFiscalYear(int id)
        {
            FiscalYear result = null;
            try
            {
                result = await _context.FiscalYears.Where(r => r.FiscalYearID == id)
                                 .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }

        public async Task<int> Save(FiscalYear fiscal)
        {

            try
            {
                fiscal.LastChangedBy = UserAppData.CurrentUserName;
                fiscal.LastChangedDate = DateTime.Now;
                _context.Add(fiscal);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return fiscal.FiscalYearID;
        }


        public async Task<int> Update(FiscalYear fiscal)
        {
            try
            {

                FiscalYear update = _context.FiscalYears.Where(r => r.FiscalYearID == fiscal.FiscalYearID).FirstOrDefault();
                update.IsCurrent = fiscal.IsCurrent;
                update.LastChangedBy = UserAppData.CurrentUserName;
                update.LastChangedDate = DateTime.Now;
                _context.Update(update);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        #endregion Fiscal


        #region Category
        public async Task<Category> FindCategory(int categoryID)
        {
            try
            {
                return await _context.Categories.Where(a => a.CategoryID == categoryID)
                 .Include(a => a.SubCategories)
                .ThenInclude(a => a.CategoryItems)
                .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Save(Category category)
        {
            try
            {
                category.LastChangedBy = UserAppData.CurrentUserName;
                category.LastChangedDate = DateTime.Now;
                _context.Add(category);
                await _context.SaveChangesAsync();
                return category.CategoryID;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<bool> IsDuplicate(Category category)
        {
            try
            {
                Category category1 = await _context.Categories.Where(b => b.Name.Equals(category.Name)).FirstOrDefaultAsync();
                return category1.IsNotNull();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Update(Category category)
        {
            try
            {
                Category category1 = _context.Categories.Find(category.CategoryID);
                category1.IsActive = category.IsActive;
                category1.Name = category.Name;
                category1.Description = category.Description;
                category1.LastChangedBy = UserAppData.CurrentUserName;
                category1.LastChangedDate = DateTime.Now;
                _context.Update(category1);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> ActionCategory(int CategoryID, DatabaseAction action)
        {
            try
            {
                Category cat = await FindCategory(CategoryID);
                if (DatabaseAction.Remove == action)
                    _context.Categories.Remove(cat);
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    cat.IsActive = DatabaseAction.Deactivate != action;
                    cat.LastChangedBy = UserAppData.CurrentUserName;
                    cat.LastChangedDate = DateTime.Now;
                    _context.Update(cat);
                }
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<List<Category>> Categories()
        {
            try
            {
                return await _context.Categories
                .Include(a => a.SubCategories)
                .ThenInclude(a => a.CategoryItems)
                .ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        #endregion Categories


        #region SubCategories
        public List<SubCategory> GetSubCategories(int categoryID)
        {
            try
            {
                return _context.SubCategories
             .Where(c => c.CategoryID == categoryID).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public async Task<SubCategory> FindSubCategory(int id)
        {
            try
            {
                return await _context.SubCategories
                .Include(c => c.Category)
                    .Include(c => c.CategoryItems).
                  Where(r => r.SubCategoryID == id)
                     .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Save(SubCategory subCategory)
        {
            try
            {
                subCategory.LastChangedBy = UserAppData.CurrentUserName;
                subCategory.LastChangedDate = DateTime.Now;
                _context.Add(subCategory);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Update(SubCategory subCategory)
        {
            try
            {

                SubCategory sub = _context.SubCategories.Find(subCategory.CategoryID);
                sub.IsActive = subCategory.IsActive;
                sub.Name = subCategory.Name;
                sub.LastChangedBy = UserAppData.CurrentUserName;
                sub.LastChangedDate = DateTime.Now;
                _context.Update(sub);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> ActionSubCategory(int id, DatabaseAction action)
        {
            try
            {
                SubCategory subCategory = await FindSubCategory(id);
                if (DatabaseAction.Remove == action)
                    _context.SubCategories.Remove(subCategory);
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    subCategory.IsActive = DatabaseAction.Deactivate != action;
                    subCategory.LastChangedBy = UserAppData.CurrentUserName;
                    subCategory.LastChangedDate = DateTime.Now;
                    _context.Update(subCategory);
                }
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<bool> IsDuplicate(SubCategory subCategory)
        {
            try
            {
                SubCategory _subCategory = await _context.SubCategories.Where(b => b.Name.Equals(subCategory.Name)).FirstOrDefaultAsync();
                return _subCategory.IsNotNull();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }

        #endregion SubCategories

        #region CategoryItem
        public async Task<CategoryItem> FindCategoryItem(int id)
        {
            try
            {
                return await _context.CategoryItems.
                    Include(c => c.SubCategory).
                  Where(r => r.CategoryItemID == id)
                     .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<CategoryItem> GetCategoryItem(int id)
        {
            try
            {
                return await _context.CategoryItems.
                    Include(c => c.SubCategory).
                     Where(r => r.CategoryItemID == id)
                     .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Save(CategoryItem categoryItem)
        {
            try
            {
                categoryItem.LastChangedBy = UserAppData.CurrentUserName;
                categoryItem.LastChangedDate = DateTime.Now;
                _context.Add(categoryItem);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Update(CategoryItem categoryItem)
        {
            try
            {

                CategoryItem categoryItem1 = _context.CategoryItems.Find(categoryItem.CategoryItemID);
                categoryItem1.IsActive = categoryItem.IsActive;
                categoryItem1.LastChangedBy = UserAppData.CurrentUserName;
                categoryItem1.LastChangedDate = DateTime.Now;
                _context.Update(categoryItem1);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> ActionCategoryItem(int id, DatabaseAction action)
        {
            try
            {
                CategoryItem categoryItem = await FindCategoryItem(id);
                if (DatabaseAction.Remove == action)
                    _context.CategoryItems.Remove(categoryItem);
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    categoryItem.IsActive = DatabaseAction.Deactivate != action;
                    categoryItem.LastChangedBy = UserAppData.CurrentUserName;
                    categoryItem.LastChangedDate = DateTime.Now;
                    _context.Update(categoryItem);
                }
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<bool> IsDuplicate(CategoryItem categoryItem)
        {
            try
            {
                CategoryItem categoryItem1 = await _context.CategoryItems.Where(b => b.Name == categoryItem.Name && b.SubCategoryID == categoryItem.SubCategoryID).FirstOrDefaultAsync();
                return categoryItem1.IsNotNull();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }

        #endregion FundCategoryItem


        #region LoanSector
        public async Task<bool> IsDuplicate(Fee fee)
        {
            bool result = false;
            try
            {
                Fee _fee = await _context.Fees.Where(b => b.Name.Equals(fee.Name)).FirstOrDefaultAsync();
                result = _fee.IsNotNull();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }
        public async Task<List<Fee>> Fees()
        {
            List<Fee> result = null;
            try
            {
                result = await _context.Fees
                .AsNoTracking()
               .ToListAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;

        }

        public async Task<int> DeleteFee(int id)
        {
            int result = 0;
            try
            {
                var _result = await _context.Fees.FindAsync(id);
                _context.Fees.Remove(_result);
                result = await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }

        public async Task<Fee> FindFee(int id)
        {
            Fee result = null;
            try
            {
                result = await _context.Fees.Where(r => r.FeeID == id)
                                 .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }

        public async Task<int> Save(Fee fee)
        {

            try
            {
                fee.LastChangedBy = UserAppData.CurrentUserName;
                fee.LastChangedDate = DateTime.Now;
                _context.Add(fee);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return fee.FeeID;
        }


        public async Task<int> Update(Fee fee)
        {
            try
            {

                Fee update = _context.Fees.Where(r => r.FeeID == fee.FeeID).FirstOrDefault();
                update.IsActive = fee.IsActive;
                update.LastChangedBy = UserAppData.CurrentUserName;
                update.LastChangedDate = DateTime.Now;
                _context.Update(update);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        #endregion Fees

        #region ProductComputations
        public async Task<int> Save(ProductComputation productComputation)
        {

            try
            {

                productComputation.CreatedBy = UserAppData.CurrentUserName;
                productComputation.DateCreated = DateTime.Now;
                productComputation.LastChangedBy = UserAppData.CurrentUserName;
                productComputation.LastChangedDate = DateTime.Now;
                _context.Add(productComputation);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return productComputation.ProductComputationID;
        }
        public async Task<int> DeleteProductComputation(int id)
        {
            int result = 0;
            try
            {
                var _result = await _context.ProductComputations.FindAsync(id);
                _context.ProductComputations.Remove(_result);
                result = await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }

        public async Task<bool> IsDuplicate(ProductComputation computation)
        {
            bool result = false;
            try
            {
                ProductComputation productComputation = await _context.ProductComputations.Where(b => b.PluginName.Equals(computation.PluginName)).FirstOrDefaultAsync();
                result = productComputation.IsNotNull();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }
        public async Task<List<ProductComputation>> ProductComputations()
        {
            try
            {


                var plugins = await _context.ProductComputations
                .AsNoTracking()
                .ToListAsync();

                                return plugins;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> Update(ProductComputation computation)
        {
            try
            {
                var _plugin = await _context.ProductComputations.FindAsync(computation.ProductComputationID);
                if (_plugin.IsNull())
                    return 0;
                _plugin.PluginName = computation.PluginName;
                _plugin.Method = computation.Method;
                _plugin.IsActive = computation.IsActive;
                _plugin.LastChangedBy = UserAppData.CurrentUserName;
                _plugin.LastChangedDate = DateTime.Now;
                _context.Update(_plugin);
                await _context.SaveChangesAsync();
                return _plugin.ProductComputationID;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<ProductComputation> FindProductComputation(int id)
        {
            ProductComputation result = null;
            try
            {
                result = await _context.ProductComputations.Where(r => r.ProductComputationID == id)
                                 .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }
        #endregion ProductComputations


    }
}
