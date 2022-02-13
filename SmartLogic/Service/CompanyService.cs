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
using SmartLog;
using SmartExtensions;

namespace SmartLogic
{
    public class CompanyService : ICompanyService
    {
        private readonly DatabaseContext _context;

        public CompanyService(DatabaseContext context) => _context = context;
        public async Task<int> ActionCompany(int id, DatabaseAction action)
        {
            try
            {
                Company Company = await FindCompany(id);

                if (DatabaseAction.Remove == action)
                {
                    if (Company.IsDefault)
                    {
                        var companies = _context.Companies.Where(c => c.CompanyID != id);
                        var newDefaultCompany = companies.FirstOrDefault();
                        newDefaultCompany.IsDefault = true;
                        _context.SaveChanges();

                    }
                    _context.Companies.Remove(Company);

                }
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    Company.IsActive = DatabaseAction.Deactivate != action;
                    Company.LastChangedBy = UserAppData.CurrentUserName;
                    Company.LastChangedDate = DateTime.Now;
                    _context.Update(Company);
                }

                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<Company> GetActiveCompanies()
        {
            try
            {
                return _context.Companies.Where(c => c.IsActive)
                            .AsNoTracking()
                .ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<List<Company>> Companies()
        {
            try
            {

                return await _context.Companies
                            .AsNoTracking()
                .ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<bool> IsDuplicate(Company _company)
        {
            try
            {

                Company company = await _context.Companies.Where(b => b.Name.Equals(_company.Name)).FirstOrDefaultAsync();
                return company.IsNotNull();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<Company> FindCompany(int id)
        {
            try
            {

                return await _context.Companies.Where(r => r.CompanyID == id)
                 .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> Save(Company Company)
        {
            try
            {
                Company company = _context.Companies.Where(r => r.IsDefault)
         .AsNoTracking().FirstOrDefault();
                if (company.IsNull())
                    Company.IsDefault = true;

                else
                {
                    if (Company.IsDefault)
                    {
                        try
                        {
                            // if this has been set as the main guarator then all the gurantors already in the DB  should have that column set to false
                            var companies = _context.Companies.Where(s => s.IsDefault).ToList();
                            companies.ForEach(a => a.IsDefault = false);
                            _context.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            CustomLog.Log(LogSource.Logic_Base, ex);
                        }
                    }
                }
                Company.LastChangedBy = UserAppData.CurrentUserName;
                Company.LastChangedDate = DateTime.Now;
                _context.Add(Company);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Update(Company Company)
        {
            try
            {

                Company company = _context.Companies.Find(Company.CompanyID);
                List<Company> Companies = _context.Companies.ToList();
                if (Companies == null || Companies.Count() == 0)
                    company.IsDefault = true;

                else
                {
                    if (Company.IsDefault)
                    {
                        try
                        {

                            var defaultCompany = _context.Companies.Where(s => s.IsDefault && s.CompanyID != Company.CompanyID).FirstOrDefault();
                            if (defaultCompany.IsNotNull())
                            {
                                defaultCompany.IsDefault = false;
                                _context.Update(defaultCompany);
                            }
                        }
                        catch
                        {                            //throw;
                        }

                    }
                }
                company.CompanyLogo = Company.CompanyLogo;
                company.Code = Company.Code;
                company.IsActive = Company.IsActive;
                company.Name = Company.Name;
                company.AddressLine1 = Company.AddressLine1;
                company.AddressLine2 = Company.AddressLine2;
                company.City = Company.City;
                company.Phone = Company.Phone;
                company.Mobile = Company.Mobile;
                company.Website = Company.Website;
                company.CountryID = Company.CountryID;
                company.Fax = Company.Fax;
                company.LastChangedBy = UserAppData.CurrentUserName;
                company.LastChangedDate = DateTime.Now;
                _context.Update(company);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


    }
}
