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
    public class BankAccountService : IBankAccountservice
    {
        private readonly DatabaseContext _context;
        public BankAccountService(DatabaseContext context) => _context = context;
        public async Task<int> ActionBank(int id, DatabaseAction action)
        {
            int result = 0;
            try
            {
                BankAccount Bank = await FindBank(id);

                if (DatabaseAction.Remove == action)
                    _context.BankAccounts.Remove(Bank);
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    Bank.IsActive = DatabaseAction.Deactivate == action ? false : true;
                    Bank.LastChangedBy = UserAppData.CurrentUserName;
                    Bank.LastChangedDate = DateTime.Now;
                    _context.Update(Bank);
                }

                result = await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }

        public async Task<bool> IsDuplicate(BankAccount bank)
        {
            bool result = false;
            try
            {
                BankAccount bankAccount = await _context.BankAccounts.Where(b => b.AccountName.Equals(bank.AccountName) && b.AccountNumber.Equals(bank.AccountNumber)).FirstOrDefaultAsync();
                result = bankAccount.IsNotNull();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }
        public async Task<List<BankAccount>> Banks()
        {
            List<BankAccount> result = null;
            try
            {
                result = await _context.BankAccounts
                .Include(p => p.BankAccountType)
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

        public async Task<int> Delete(int id)
        {
            int result = 0;
            try
            {
                var course = await _context.BankAccounts.FindAsync(id);
                _context.BankAccounts.Remove(course);
                result = await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }

        public async Task<BankAccount> FindBank(int id)
        {
            BankAccount result = null;
            try
            {
                result = await _context.BankAccounts.Where(r => r.BankAccountID == id)
                 .Include(p => p.BankAccountType)
                 .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }

        public async Task<int> Save(BankAccount Bank)
        {

            try
            {
                Bank.LastChangedBy = UserAppData.CurrentUserName;
                Bank.LastChangedDate = DateTime.Now;
                _context.Add(Bank);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return Bank.BankAccountID;
        }


        public async Task<int> Update(BankAccount Bank)
        {
            try
            {

                BankAccount update = _context.BankAccounts.Where(r => r.BankAccountID == Bank.BankAccountID).FirstOrDefault();
                update.AccountNumber = Bank.AccountNumber;
                update.AccountCode = Bank.AccountCode;
                update.AccountName = Bank.AccountName;
                update.BankAccountTypeID = Bank.BankAccountTypeID;
                update.CurrencyID = Bank.CurrencyID;
                update.IsActive = Bank.IsActive;
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
    }
}
