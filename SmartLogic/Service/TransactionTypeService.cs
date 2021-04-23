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
using SmartLog;

namespace SmartLogic
{
    public class TransactionTypeService : ITransactionTypeService
    {
        private readonly DatabaseContext _context;

        public TransactionTypeService(DatabaseContext context) => _context = context;
        public async Task<int> ActionTransactionType(int id, DatabaseAction action)
        {
            try
            {
            TransactionType TransactionType = await FindTransactionType(id);

            if (DatabaseAction.Remove == action)
                _context.TransactionType.Remove(TransactionType);
            else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
            {
                TransactionType.IsActive = DatabaseAction.Deactivate == action ? false : true;
                TransactionType.LastChangedBy = UtilityService.CurrentUserName;
                TransactionType.LastChangedDate = DateTime.Now;
                _context.Update(TransactionType);
            }
            return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<List<TransactionType>> TransactionType()
        {
            try
            {

            return await _context.TransactionType.
             Include(t => t.TransactionStatus).
             AsNoTracking().
            ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<List<TransactionStatus>> TransactionStatus()
        {
            try
            {
            return await _context.TransactionStatus.
                        AsNoTracking().
            ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Delete(int id)
        {
            try
            {

            var transactionType = await _context.TransactionType.FindAsync(id);
            _context.TransactionType.Remove(transactionType);
            return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<TransactionType> FindTransactionType(int id)
        {
            try
            {
            return await _context.TransactionType.
            Include(t=>t.TransactionStatus).
            Where(r => r.TransactionTypeID == id).
            AsNoTracking().
            FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<TransactionStatus> FindTransactionStatus(int id)
        {
            try
            {
            return await _context.TransactionStatus.
                    Where(r => r.TransactionStatusID == id).
            AsNoTracking().
            FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        
        public async Task<int> Save(TransactionType TransactionType)
        {
            try
            {
                      TransactionType.LastChangedBy = UtilityService.CurrentUserName;
            TransactionType.LastChangedDate = DateTime.Now;
            _context.Add(TransactionType);
            return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public async Task<int> Update(TransactionType TransactionType)
        {
            try
            {

            TransactionType update = await FindTransactionType(TransactionType.TransactionTypeID);
            update.Code = TransactionType.Code;
            update.TransactionStatusID = TransactionType.TransactionStatusID;
            update.TransactionStatus = TransactionType.TransactionStatus;
            update.Description = TransactionType.Description;
            update.IsActive = TransactionType.IsActive;
            update.LastChangedBy = UtilityService.CurrentUserName;
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
    }
}
