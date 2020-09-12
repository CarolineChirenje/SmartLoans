using SmartLogic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartDomain;
using SmartHelper;
using SmartDataAccess;

namespace SmartLogic
{
    public class CompanyService : ICompanyService
    {
        private readonly DatabaseContext _context;

        public CompanyService(DatabaseContext context) => _context = context;
        public async Task<int> ActionCompany(int id, DatabaseAction action)
        {
            Company Company = await FindCompany(id);

            if (DatabaseAction.Remove == action)
                _context.Companies.Remove(Company);
            else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
            {
                Company.IsActive = DatabaseAction.Deactivate == action ? false : true;
                Company.LastChangedBy = UtilityService.CurrentUserName;
                Company.LastChangedDate = DateTime.Now;
                _context.Update(Company);
            }

            return (await _context.SaveChangesAsync());
        }

        public async Task<List<Company>> Companies()
        {
            return await _context.Companies
                        .AsNoTracking()
            .ToListAsync();
        }

       
        public async Task<Company> FindCompany(int id)
        {
            return await _context.Companies.Where(r => r.CompanyID == id)
               .AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<int> Save(Company Company)
        {
            Company.LastChangedBy = UtilityService.CurrentUserName;
            Company.LastChangedDate = DateTime.Now;
            _context.Add(Company);
            return (await _context.SaveChangesAsync());
        }
        public async Task<int> Update(Company Company)
        {
            Company company = await FindCompany(Company.CompanyID);
            List<Company> Companies = _context.Companies.ToList();
            if (Companies == null || Companies.Count() == 0)
                company.IsDefault = true;

            else
            {
                if (Company.IsDefault)
                {
                    try
                    {
                       
                        var defaultCompany = _context.Companies.Where(s => s.IsDefault).FirstOrDefault();
                        if(UtilityService.IsNotNull(defaultCompany))
                        {

                            defaultCompany.IsDefault = false;
                            _context.Update(defaultCompany);
                        }
                    }
                    catch (Exception ex)
                    {

                        //throw;
                    }

                }
            }
            company.Code = Company.Code;
            company.IsActive = Company.IsActive;
            company.Name = Company.Name;
            company.LastChangedBy = UtilityService.CurrentUserName;
            company.LastChangedDate = DateTime.Now;
            _context.Update(company);
            return (await _context.SaveChangesAsync());
        }


    }
}
