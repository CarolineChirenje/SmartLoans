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
    public class CurrencyService : ICurrencyService
    {
        private readonly DatabaseContext _context;

        public CurrencyService(DatabaseContext context) => _context = context;
        public async Task<int> ActionCurrency(int id, DatabaseAction action)
        {
            Currency Currency = await FindCurrency(id);

            if (DatabaseAction.Remove == action)
                _context.Currencies.Remove(Currency);
            else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
            {
                Currency.IsActive = DatabaseAction.Deactivate == action ? false : true;
                Currency.LastChangedBy = UtilityService.CurrentUserName;
                Currency.LastChangedDate = DateTime.Now;
                _context.Update(Currency);
            }

            return (await _context.SaveChangesAsync());
        }

        public async Task<List<Currency>> Currency()
        {
            return await _context.Currencies
                        .AsNoTracking()
            .ToListAsync();
        }

        public async Task<int> Delete(int id)
        {
            var course = await _context.Currencies.FindAsync(id);
            _context.Currencies.Remove(course);
            return (await _context.SaveChangesAsync());
        }

        public async Task<Currency> FindCurrency(int id)
        {
            return await _context.Currencies.Where(r => r.CurrencyID == id)
 .AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<int> Save(Currency Currency)
        {
            Currency.LastChangedBy = UtilityService.CurrentUserName;
            Currency.LastChangedDate = DateTime.Now;
            _context.Add(Currency);
            return (await _context.SaveChangesAsync());
        }

      
        public async Task<int> Update(Currency Currency)
        {
            Currency update = await FindCurrency(Currency.CurrencyID);
             if (UtilityService.IsNotNull(update))
            {
                update.Name = Currency.Name;
                update.IsActive = Currency.IsActive;
                update.LastChangedBy = UtilityService.CurrentUserName;
                update.LastChangedDate = DateTime.Now;
                _context.Update(update);

            }
           
            return await _context.SaveChangesAsync();
        }
    }
}
