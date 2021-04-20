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
using System.IO;

using SmartReporting;

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
            return await _context.Courses.
                Include(c => c.CourseOutlines).
                Include(c => c.CourseIntakes).
                AsNoTracking().
                ToListAsync();
        }
        public async Task<List<Course>> NewCourses()
        {
            return await _context.Courses.
                Include(c => c.CourseOutlines).
                Include(c => c.CourseIntakes).
                Where(c => c.DateCreated.Date >= DateTime.Now.AddDays(-1).Date && c.DateCreated.Date <= DateTime.Now.Date).ToListAsync();
        }


        public async Task<bool> IsDuplicate(Course _course)
        {
            Course course = await _context.Courses.Where(b => b.Title.Equals(_course.Title)).FirstOrDefaultAsync();
            return UtilityService.IsNotNull(course);
        }
        public async Task<int> Delete(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            _context.Courses.Remove(course);
            return (await _context.SaveChangesAsync());
        }

        public async Task<Course> FindCourse(int id)
        {
            return await _context.Courses.
            Include(c => c.CourseOutlines).
            Include(c => c.CourseIntakes).
            Include(c => c.CourseFees).
            ThenInclude(c => c.Frequency).
            Where(r => r.CourseID == id)
               .AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<int> Save(Course Course)
        {
            Course.LastChangedBy = UtilityService.CurrentUserName;
            Course.DateCreated = DateTime.Now;
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
        public async Task<int> Save(CourseOutline courseOutline)
        {

            courseOutline.LastChangedBy = UtilityService.CurrentUserName;
            courseOutline.LastChangedDate = DateTime.Now;
            _context.Add(courseOutline);
            return (await _context.SaveChangesAsync());
        }
        public async Task<int> Update(CourseOutline outline)
        {

            CourseOutline courseOutline = _context.CourseOutlines.Find(outline.CourseOutlineID);
            courseOutline.IsActive = outline.IsActive;
            courseOutline.Name = outline.Name;
            courseOutline.LastChangedBy = UtilityService.CurrentUserName;
            courseOutline.LastChangedDate = DateTime.Now;
            _context.Update(courseOutline);
            return (await _context.SaveChangesAsync());
        }
        public List<CourseOutline> GetCourseOutlines(int courseID)
        {
            return _context.CourseOutlines
           .Where(c => c.CourseID == courseID).ToList();

        }

        public async Task<CourseOutline> FindCourseOutline(int id)
        {
            return await _context.CourseOutlines.
                 Include(c => c.Course).
                Where(c => c.CourseOutlineID == id).FirstOrDefaultAsync();
        }

        // Course Fee

        public async Task<CourseFee> FindCourseFee(int id)
        {
            return await _context.CourseFees.
                 Include(c => c.Course).
                Where(c => c.CourseFeeID == id).FirstOrDefaultAsync();
        }
        public async Task<int> Save(CourseFee courseFee)
        {
            courseFee.LastChangedBy = UtilityService.CurrentUserName;
            courseFee.LastChangedDate = DateTime.Now;
            _context.Add(courseFee);
            return (await _context.SaveChangesAsync());

        }
        public async Task<int> Update(CourseFee courseFee)
        {
            CourseFee update = _context.CourseFees.
            Where(t => t.CourseFeeID == courseFee.CourseFeeID).FirstOrDefault();

            update.Name = courseFee.Name;
            update.FrequencyID = courseFee.FrequencyID;
            update.IsActive = courseFee.IsActive;
            update.Amount = courseFee.Amount;
            update.Description = courseFee.Description;
            update.LastChangedBy = UtilityService.CurrentUserName;
            update.LastChangedDate = DateTime.Now;
            _context.Entry(update).State = EntityState.Modified;

            AddCourseFeeHistory(courseFee);
            return await _context.SaveChangesAsync();
        }


        void AddCourseFeeHistory(CourseFee courseFee)

        {  //Fee History
            CourseFeeHistory feeHistory = new CourseFeeHistory();
            feeHistory.Amount = courseFee.Amount;
            feeHistory.Description = courseFee.Description;
            feeHistory.IsActive = courseFee.IsActive;
            feeHistory.FrequencyID = courseFee.FrequencyID;
            feeHistory.Name = courseFee.Name;
            feeHistory.CourseID = courseFee.CourseID;
            feeHistory.CourseFeeID = courseFee.CourseFeeID;
            feeHistory.LastChangedBy = courseFee.LastChangedBy;
            feeHistory.LastChangedDate = courseFee.LastChangedDate;
            _context.Add(feeHistory);

        }
        public async Task<int> ActionCourseFee(int id, DatabaseAction action)
        {

            CourseFee courseFee = await FindCourseFee(id);
            AddCourseFeeHistory(courseFee);
            if (DatabaseAction.Remove == action)
            {

                _context.CourseFees.Remove(courseFee);

            }
            else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
            {
                courseFee.LastChangedBy = UtilityService.CurrentUserName;
                courseFee.LastChangedDate = DateTime.Now;
                _context.Update(courseFee);
            }

            return (await _context.SaveChangesAsync());
        }
        //Course Intakes
        public async Task<int> ActionCourseIntake(int id, DatabaseAction action)
        {
            CourseIntake intake = await FindCourseIntake(id);

            if (DatabaseAction.Remove == action)
                _context.CourseIntakes.Remove(intake);
            else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
            {
                intake.IsActive = DatabaseAction.Deactivate == action ? false : true;
                intake.LastChangedBy = UtilityService.CurrentUserName;
                intake.LastChangedDate = DateTime.Now;
                _context.Update(intake);
            }

            return (await _context.SaveChangesAsync());
        }
        public async Task<int> Save(CourseIntake intake)
        {

            intake.LastChangedBy = UtilityService.CurrentUserName;
            intake.LastChangedDate = DateTime.Now;
            _context.Add(intake);
            return (await _context.SaveChangesAsync());
        }
        public async Task<int> Update(CourseIntake intake)
        {

            CourseIntake courseIntake = _context.CourseIntakes.Find(intake.CourseIntakeID);
            courseIntake.IsActive = intake.IsActive;
            courseIntake.Name = intake.Name;
            courseIntake.LastChangedBy = UtilityService.CurrentUserName;
            courseIntake.LastChangedDate = DateTime.Now;
            _context.Update(courseIntake);
            return (await _context.SaveChangesAsync());
        }
        public List<CourseIntake> GetCourseIntakes(int courseID)
        {
            return _context.CourseIntakes.
             Include(c => c.Course).
                 Include(c => c.AttendanceRegisters).
                 ThenInclude(c => c.AttendanceRegisterDetails).
                      Where(c => c.CourseID == courseID).ToList();
        }
        public async Task<CourseIntake> FindCourseIntake(int id)
        {
            return await _context.CourseIntakes.
                 Include(c => c.Course).
                 Include(c=>c.AttendanceRegisters).
                 ThenInclude(c=>c.AttendanceRegisterDetails).
                Where(c => c.CourseIntakeID == id).FirstOrDefaultAsync();
        }

        public List<Client> GetEnrollmentList(int courseIntakeID)
        {
            var clients = _context.ClientCourses.
           Include(c => c.Client).
           ThenInclude(c => c.Title).
           Include(c => c.Client).
           ThenInclude(c => c.JointApplicant).
           ThenInclude(c => c.Title)
           .Where(c => c.CourseIntakeID == courseIntakeID).Select(c => c.Client).ToList();
            return clients;
        }
        public bool RegisterExist(int courseIntakeID, string dateMarked)
        {
            var exists = _context.AttendanceRegisters
                      .Any(c => c.CourseIntakeID == courseIntakeID && c.AttendanceDate.Equals(dateMarked));
            return exists;
        }
        public async Task<int> MarkRegister(CourseIntake courseIntake, string[] present)
        {
            try
            {
                int result = 0;
                // Create Attendace Register Record
                AttendanceRegister attendanceRegister = new AttendanceRegister();
                attendanceRegister.AttendanceDate = courseIntake.AttendanceDate.ToString("yyyy-MMM-dd");
                attendanceRegister.RequestedBy = UtilityService.CurrentUserName;
                attendanceRegister.CourseIntakeID = courseIntake.CourseIntakeID;
                attendanceRegister.LastChangedBy = UtilityService.CurrentUserName;
                if (courseIntake.CourseOutLine > 0)
                    attendanceRegister.CourseOutlineID = courseIntake.CourseOutLine;
                attendanceRegister.LastChangedDate = DateTime.Now;
                _context.AttendanceRegisters.Add(attendanceRegister);
                result = _context.SaveChanges();
                if (result > 0)
                {
                    List<int> enrolmentList = GetEnrollmentList(courseIntake.CourseIntakeID).Select(c => c.ClientID).ToList();
                                      int[] presentList = enrolmentList == null ? null : Array.ConvertAll(present, s => int.Parse(s));
                    var absentList = enrolmentList.Where(p => !presentList.Any(p2 => p2 == p)).ToList();
                    List<AttendanceRegisterDetail> enrolment = new List<AttendanceRegisterDetail>();

                    //Mark those where were present as present
                    foreach (var clientID in presentList)
                    {
                        enrolment.Add(new AttendanceRegisterDetail()
                        {   AttendanceRegisterID=attendanceRegister.AttendanceRegisterID,
                            ClientID = clientID,
                            Present = true,
                            LastChangedBy = UtilityService.CurrentUserName,
                            LastChangedDate = DateTime.Now
                        });
                    }

                    //Mark those who were abasent as absent
                    foreach (var clientID in absentList)
                    {
                        enrolment.Add(new AttendanceRegisterDetail()
                        {
                            AttendanceRegisterID = attendanceRegister.AttendanceRegisterID,
                            ClientID = clientID,
                            Present = false,
                            LastChangedBy = UtilityService.CurrentUserName,
                            LastChangedDate = DateTime.Now
                        });
                    }
                    _context.AttendanceRegisterDetails.AddRange(enrolment);
                    result = await _context.SaveChangesAsync();
                }
                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
        public async Task<AttendanceRegister> FindRegister(int id)
        {
            return await _context.AttendanceRegisters.
                 Include(c => c.AttendanceRegisterDetails).
                 ThenInclude(c=>c.Client).
                 Include(c=>c.CourseIntake).
                 ThenInclude(c=>c.Course).ThenInclude(c=>c.CourseOutlines).
                Where(c => c.AttendanceRegisterID == id).FirstOrDefaultAsync();
        }


    }
}
