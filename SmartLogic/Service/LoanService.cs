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
                LoanSector loanSector = await _context.LoanSectors.Where(b => b.Name.Equals(type.Name)).FirstOrDefaultAsync();
                result = type.IsNotNull();
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


        #region LoanFiscal
        public async Task<bool> IsDuplicate(LoanFiscal  loanFiscal)
        {
            bool result = false;
            try
            {
                LoanFiscal use = await _context.LoanFiscals.Where(b => b.Name.Equals(loanFiscal.Name)).FirstOrDefaultAsync();
                result = use.IsNotNull();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }
        public async Task<List<LoanFiscal>> LoanFiscals()
        {
            List<LoanFiscal> result = null;
            try
            {
                result = await _context.LoanFiscals
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

        public async Task<int> DeleteLoanFiscal(int id)
        {
            int result = 0;
            try
            {
                var _result = await _context.LoanFiscals.FindAsync(id);
                _context.LoanFiscals.Remove(_result);
                result = await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }

        public async Task<LoanFiscal> FindLoanFiscal(int id)
        {
            LoanFiscal result = null;
            try
            {
                result = await _context.LoanFiscals.Where(r => r.LoanFiscalID == id)
                                 .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }

        public async Task<int> Save(LoanFiscal loanFiscal)
        {

            try
            {
                loanFiscal.LastChangedBy = UserAppData.CurrentUserName;
                loanFiscal.LastChangedDate = DateTime.Now;
                _context.Add(loanFiscal);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return loanFiscal.LoanFiscalID;
        }


        public async Task<int> Update(LoanFiscal loanFiscal)
        {
            try
            {

                LoanFiscal update = _context.LoanFiscals.Where(r => r.LoanFiscalID == loanFiscal.LoanFiscalID).FirstOrDefault();
                update.IsActive = loanFiscal.IsActive;
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
        #endregion LoanFiscal
    }
}
