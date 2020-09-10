using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace SmartLogic
{
    public interface ICourseService
    {

        Task<int> Delete(int id);
        Task<int> Save(Course Course);
        Task<int> Update(Course Course);
        Task<int> ActionCourse(int id, DatabaseAction action);
               Task<Course> FindCourse(int id);
        Task<List<Course>> Courses();
       

    }
}
