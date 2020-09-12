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

//Course Outline

        public async Task<int> ActionCourseOutline(int id, DatabaseAction action)
        {
            CourseOutline outline = await FindCourseOutline(id);

            if (DatabaseAction.Remove == action)
                _context.CourseOutlines.Remove(outline);
            else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
            {
                outline.IsActive = DatabaseAction.Deactivate == action ? false : true;
                outline.LastChangedBy = UtilityService.CurrentUserName;
                outline.LastChangedDate = DateTime.Now;
                _context.Update(outline);
            }

            return (await _context.SaveChangesAsync());
        }

       

        public async Task<CourseOutline> FindCourseOutline(int id)
        {
            return await _context.CourseOutlines.Where(r => r.CourseOutlineID == id)
               .AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<int> Save(CourseOutline courseOutline)
        {
            
            courseOutline.LastChangedBy = UtilityService.CurrentUserName;
            courseOutline.LastChangedDate = DateTime.Now;
            _context.Add(courseOutline);
            return (await _context.SaveChangesAsync());
        }

        public async Task<int> Update(CourseOutline outline)
        {

            CourseOutline courseOutline = await FindCourseOutline(outline.CourseOutlineID);
            courseOutline.IsActive = outline.IsActive;
            courseOutline.Name = outline.Name;
            courseOutline.LastChangedBy = UtilityService.CurrentUserName;
            courseOutline.LastChangedDate = DateTime.Now;
            _context.Update(courseOutline);
            return (await _context.SaveChangesAsync());
        }
    }
}
