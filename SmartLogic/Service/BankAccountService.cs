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

namespace SmartLogic
{
    public class BankAccountService : IBankAccountservice
    {
        private readonly DatabaseContext _context;

        public BankAccountService(DatabaseContext context) => _context = context;
        public async Task<int> ActionBank(int id, DatabaseAction action)
        {
            BankAccount Bank = await FindBank(id);

            if (DatabaseAction.Remove == action)
                _context.BankAccounts.Remove(Bank);
            else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
            {
                Bank.IsActive = DatabaseAction.Deactivate == action ? false : true;
                Bank.LastChangedBy = UtilityService.CurrentUserName;
                Bank.LastChangedDate = DateTime.Now;
                _context.Update(Bank);
            }

            return (await _context.SaveChangesAsync());
        }

       public async Task<bool> IsDuplicate(BankAccount bank)
       {
            BankAccount bankAccount = await _context.BankAccounts.Where(b => b.AccountName.Equals(bank.AccountName) && b.AccountNumber.Equals(bank.AccountNumber)).FirstOrDefaultAsync();
            return  UtilityService.IsNotNull(bankAccount);
            }
        public async Task<List<BankAccount>> Banks()
        {
            return await _context.BankAccounts
             .Include(p => p.BankAccountType)
            .AsNoTracking()
            .ToListAsync();
        }

        public async Task<int> Delete(int id)
        {
            var course = await _context.BankAccounts.FindAsync(id);
            _context.BankAccounts.Remove(course);
            return (await _context.SaveChangesAsync());
        }

        public async Task<BankAccount> FindBank(int id)
        {
            return await _context.BankAccounts.Where(r => r.BankAccountID == id)
 .Include(p => p.BankAccountType)
 .AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<int> Save(BankAccount Bank)
        {
            Bank.LastChangedBy = UtilityService.CurrentUserName;
            Bank.LastChangedDate = DateTime.Now;
            _context.Add(Bank);
            await _context.SaveChangesAsync();

            return Bank.BankAccountID;
        }


        public async Task<int> Update(BankAccount Bank)
        {
            BankAccount update = _context.BankAccounts.Where(r => r.BankAccountID == Bank.BankAccountID).FirstOrDefault();
            update.AccountNumber = Bank.AccountNumber;
            update.AccountCode = Bank.AccountCode;
            update.AccountName = Bank.AccountName;
            update.BankAccountTypeID = Bank.BankAccountTypeID;
            update.CurrencyID = Bank.CurrencyID;
            update.IsActive = Bank.IsActive;
            update.LastChangedBy = UtilityService.CurrentUserName;
            update.LastChangedDate = DateTime.Now;
            _context.Update(update);
            return await _context.SaveChangesAsync();
        }
        }
    }
