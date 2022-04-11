using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace SmartLogic
{

    public interface IDepartmentService
    {

        Task<int> Delete(int id);
        Task<int> Save(Department department);
        Task<int> Update(Department department);
        Task<int> ActionDepartment(int departmentId, DatabaseAction action);
        Task<int> ActionUserAccess(int id, int clientid, DatabaseAction action);
              Task<Department> FindDepartment(int departmentId);
        Task<List<Department>> Departments();
        List<Department> GetDepartments();
        Task<bool> IsDuplicate(Department _department);

    }


}
