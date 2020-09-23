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
        return await _context.Department.Where(r => r.DepartmentID == department)

        .Include(c =>c.Clients ).AsNoTracking().FirstOrDefaultAsync();
    }
    public async Task<Department> GetDepartment(string name)
    {
        return await _context.Department.Where(r => r.Name.ToUpper() == name.Trim().ToUpper()).
            Include(c => c.Clients).AsNoTracking().FirstOrDefaultAsync();
    }


    public async Task<List<Department>> Departments()
    {
        return await _context.Department.Include(c => c.Clients).ToListAsync();
    }


    public List<Department> GetDepartments()
    {
        return _context.Department.ToList();
    }


    public async Task<int> Update(Department Department)
    {
        Department update = await FindDepartment(Department.DepartmentID);
        update.Name = Department.Name;
        update.IsActive = Department.IsActive;
        update.LastChangedBy = UtilityService.CurrentUserName;
        update.LastChangedDate = DateTime.Now;
        _context.Update(update);
        return await _context.SaveChangesAsync();
    }
    public async Task<int> Save(Department Department)
    {
            Department.IsActive = true;
        Department.LastChangedBy = UtilityService.CurrentUserName;
        Department.LastChangedDate = DateTime.Now;
        _context.Add(Department);
        return (await _context.SaveChangesAsync());
    }

        public async Task<bool> IsDuplicate(Department _department)
        {
            Department department = await _context.Department.Where(b => b.Name.Equals(_department.Name)).FirstOrDefaultAsync();
            return UtilityService.IsNotNull(department);
        }
        public async Task<int> Delete(int id)
    {
        var Department = await _context.Department.FindAsync(id);
        _context.Department.Remove(Department);
        return (await _context.SaveChangesAsync());
    }

    public async Task<int> ActionDepartment(int departmentId, DatabaseAction action)
    {
        Department Department = await FindDepartment(departmentId);
        if (DatabaseAction.Remove == action)
            _context.Department.Remove(Department);
        else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
        {
            Department.IsActive = DatabaseAction.Deactivate == action ? false : true;
            Department.LastChangedBy = UtilityService.CurrentUserName;
            Department.LastChangedDate = DateTime.Now;
            _context.Update(Department);
        }

        return (await _context.SaveChangesAsync());
    }

        public Task<int> ActionUserAccess(int id,int userId, DatabaseAction action)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Client>> DepartmentClients(int id) => await _context.Clients.Where(c => c.DepartmentID == id).ToListAsync();
    }
}
