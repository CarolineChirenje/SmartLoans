using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace SmartLogic
{
    public interface ICompanyService
    {

       
        Task<int> Save(Company company);
        Task<bool> IsDuplicate(Company company);
        Task<int> Update(Company company);
        Task<int> ActionCompany(int id, DatabaseAction action);
        Task<Company> FindCompany(int id);
        Task<List<Company>> Companies();
        List<Company> GetActiveCompanies();
    }
}
