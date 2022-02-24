using SmartLogic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartHelper;
using SmartDomain;
using SmartDataAccess;
using SmartLog;
using SmartExtensions;

namespace SmartLogic
{
    public class DepartmentService : IDepartmentService
    {
        private readonly DatabaseContext _context;

        public DepartmentService(DatabaseContext context)
        {
            _context = context;

        }

    
    public async Task<Department> FindDepartment(int department )
        {
            try
            {

                   return await _context.Department.Where(r => r.DepartmentID == department)
        .Include(c =>c.Clients ).AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
    public async Task<Department> GetDepartment(string name)
        {
            try
            {

                    return await _context.Department.Where(r => r.Name.ToUpper() == name.Trim().ToUpper()).
            Include(c => c.Clients).AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


    public async Task<List<Department>> Departments()
        {
            try
            {

                    return await _context.Department.Include(c => c.Clients).ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


    public List<Department> GetDepartments()
        {
            try
            {

                    return _context.Department.ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


    public async Task<int> Update(Department Department)
        {
            try
            {

                    Department update = await FindDepartment(Department.DepartmentID);
        update.Name = Department.Name;
        update.IsActive = Department.IsActive;
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
    public async Task<int> Save(Department Department)
        {
            try
            {

                       Department.IsActive = true;
        Department.LastChangedBy = UserAppData.CurrentUserName;
        Department.LastChangedDate = DateTime.Now;
        _context.Add(Department);
        return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<bool> IsDuplicate(Department _department)
        {
            try
            {

             Department department = await _context.Department.Where(b => b.Name.Equals(_department.Name)).FirstOrDefaultAsync();
            return department.IsNotNull();
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

                   var Department = await _context.Department.FindAsync(id);
        _context.Department.Remove(Department);
        return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

    public async Task<int> ActionDepartment(int departmentId, DatabaseAction action)
        {
            try
            {

                    Department Department = await FindDepartment(departmentId);
        if (DatabaseAction.Remove == action)
            _context.Department.Remove(Department);
        else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
        {
            Department.IsActive = DatabaseAction.Deactivate == action ? false : true;
            Department.LastChangedBy = UserAppData.CurrentUserName;
            Department.LastChangedDate = DateTime.Now;
            _context.Update(Department);
        }

        return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public Task<int> ActionUserAccess(int id,int userId, DatabaseAction action)
        {
            try
            {

            
            throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<List<Client>> DepartmentClients(int id)
        {
            try
            {

                        return await _context.Clients.Where(c => c.DepartmentID == id).ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
    }
}
