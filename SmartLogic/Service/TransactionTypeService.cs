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

namespace SmartLogic
{
    public class TransactionTypeService : ITransactionTypeService
    {
        private readonly DatabaseContext _context;

        public TransactionTypeService(DatabaseContext context) => _context = context;
        public async Task<int> ActionTransactionType(int id, DatabaseAction action)
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

        public async Task<List<TransactionType>> TransactionType()
        {
            return await _context.TransactionType.
             Include(t => t.TransactionStatus).
             AsNoTracking().
            ToListAsync();
        }

        public async Task<List<TransactionStatus>> TransactionStatus()
        {
            return await _context.TransactionStatus.
                        AsNoTracking().
            ToListAsync();
        }
        public async Task<int> Delete(int id)
        {
            var transactionType = await _context.TransactionType.FindAsync(id);
            _context.TransactionType.Remove(transactionType);
            return (await _context.SaveChangesAsync());
        }

        public async Task<TransactionType> FindTransactionType(int id)
        {
            return await _context.TransactionType.
            Include(t=>t.TransactionStatus).
            Where(r => r.TransactionTypeID == id).
            AsNoTracking().
            FirstOrDefaultAsync();
        }
        public async Task<TransactionStatus> FindTransactionStatus(int id)
        {
            return await _context.TransactionStatus.
                    Where(r => r.TransactionStatusID == id).
            AsNoTracking().
            FirstOrDefaultAsync();
        }
        
        public async Task<int> Save(TransactionType TransactionType)
        {
            TransactionType.LastChangedBy = UtilityService.CurrentUserName;
            TransactionType.LastChangedDate = DateTime.Now;
            _context.Add(TransactionType);
            return (await _context.SaveChangesAsync());
        }


        public async Task<int> Update(TransactionType TransactionType)
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
    }
}
