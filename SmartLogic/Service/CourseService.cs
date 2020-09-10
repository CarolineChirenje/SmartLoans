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
    public class CourseService : ICourseService
    {
        private readonly DatabaseContext _context;

        public CourseService(DatabaseContext context) => _context = context;
        public async Task<int> ActionCourse(int id, DatabaseAction action)
        {
            Course Course = await FindCourse(id);

            if (DatabaseAction.Remove == action)
                _context.Courses.Remove(Course);
            else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
            {
                Course.IsActive = DatabaseAction.Deactivate == action ? false : true;
                Course.LastChangedBy = UtilityService.CurrentUserName;
                Course.LastChangedDate = DateTime.Now;
                _context.Update(Course);
            }

            return (await _context.SaveChangesAsync());
        }

        public async Task<List<Course>> Courses()
        {
            return await _context.Courses
                        .AsNoTracking()
            .ToListAsync();
        }

        public async Task<int> Delete(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            _context.Courses.Remove(course);
            return (await _context.SaveChangesAsync());
        }

        public async Task<Course> FindCourse(int id)
        {
            return await _context.Courses.Where(r => r.CourseID == id)
               .AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<int> Save(Course Course)
        {
            Course.LastChangedBy = UtilityService.CurrentUserName;
            Course.LastChangedDate = DateTime.Now;
            _context.Add(Course);
            return (await _context.SaveChangesAsync());
        }

      
        public async Task<int> Update(Course Course)
        {
           
            Course.LastChangedBy = UtilityService.CurrentUserName;
            Course.LastChangedDate = DateTime.Now;
            _context.Update(Course);
            return await _context.SaveChangesAsync();
        }
    }
}
