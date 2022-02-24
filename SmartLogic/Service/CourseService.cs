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
using SmartLog;
using SmartExtensions;

namespace SmartLogic
{
    public class CourseService : ICourseService
    {
        private readonly DatabaseContext _context;

        public CourseService(DatabaseContext context) => _context = context;
        public async Task<int> ActionCourse(int id, DatabaseAction action)
        {
            try
            {

                Course Course = await FindCourse(id);
                if (DatabaseAction.Remove == action)
                    _context.Courses.Remove(Course);
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    Course.IsActive = DatabaseAction.Deactivate != action;
                    Course.LastChangedBy = UserAppData.CurrentUserName;
                    Course.LastChangedDate = DateTime.Now;
                    _context.Update(Course);
                }

                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<List<Course>> Courses()
        {
            try
            {
                return await _context.Courses.
                Include(c => c.CourseTopics).
                Include(c => c.CourseIntakes).
                AsNoTracking().
                ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<List<Course>> NewCourses()
        {
            try
            {
                return await _context.Courses.
                    Include(c => c.CourseTopics).
                    Include(c => c.CourseIntakes).
                    Where(c => c.DateCreated.Date >= DateTime.Now.AddDays(-1).Date && c.DateCreated.Date <= DateTime.Now.Date).ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public async Task<bool> IsDuplicate(Course _course)
        {
            try
            {
                Course course = await _context.Courses.Where(b => b.Title.Equals(_course.Title)).FirstOrDefaultAsync();
                return course.IsNotNull();
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

                var course = await _context.Courses.FindAsync(id);
                _context.Courses.Remove(course);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<Course> FindCourse(int id)
        {
            try
            {

                return await _context.Courses.
                Include(c => c.CourseTopics).
                ThenInclude(c => c.CourseSessions).
                Include(c => c.CourseIntakes).
                Include(c => c.CourseFees).
                ThenInclude(c => c.Frequency).
                Where(r => r.CourseID == id)
                   .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> Save(Course Course)
        {
            try
            {

                Course.LastChangedBy = UserAppData.CurrentUserName;
                Course.DateCreated = DateTime.Now;
                Course.LastChangedDate = DateTime.Now;
                _context.Add(Course);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> Update(Course Course)
        {
            try
            {
                Course.LastChangedBy = UserAppData.CurrentUserName;
                Course.LastChangedDate = DateTime.Now;
                _context.Update(Course);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        //Course Topics
        public async Task<int> ActionCourseTopic(int id, DatabaseAction action)
        {
            try
            {
                CourseTopic outline = await FindCourseTopic(id);
                if (DatabaseAction.Remove == action)
                    _context.CourseTopics.Remove(outline);
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    outline.IsActive = DatabaseAction.Deactivate != action;
                    outline.LastChangedBy = UserAppData.CurrentUserName;
                    outline.LastChangedDate = DateTime.Now;
                    _context.Update(outline);
                }
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Save(CourseTopic courseTopic)
        {
            try
            {
                courseTopic.LastChangedBy = UserAppData.CurrentUserName;
                courseTopic.LastChangedDate = DateTime.Now;
                _context.Add(courseTopic);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Update(CourseTopic courseTopic)
        {
            try
            {
                CourseTopic topic = _context.CourseTopics.Find(courseTopic.CourseTopicID);
                topic.IsActive = courseTopic.IsActive;
                topic.Name = courseTopic.Name;
                topic.LastChangedBy = UserAppData.CurrentUserName;
                topic.LastChangedDate = DateTime.Now;
                _context.Update(topic);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public List<CourseTopic> GetCourseTopics(int courseID)
        {
            try
            {
                return _context.CourseTopics
             .Where(c => c.CourseID == courseID).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }

        public async Task<CourseTopic> FindCourseTopic(int id)
        {
            try
            {
                return await _context.CourseTopics.
                     Include(c => c.Course).
                      Include(c => c.CourseSessions).
                    Where(c => c.CourseTopicID == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        //Course Sessions
        public async Task<int> ActionCourseSession(int id, DatabaseAction action)
        {
            try
            {
                CourseSession session = await FindCourseSession(id);
                if (DatabaseAction.Remove == action)
                    _context.CourseSessions.Remove(session);
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    session.IsActive = DatabaseAction.Deactivate != action;
                    session.LastChangedBy = UserAppData.CurrentUserName;
                    session.LastChangedDate = DateTime.Now;
                    _context.Update(session);
                }
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Save(CourseSession session)
        {
            try
            {
                session.LastChangedBy = UserAppData.CurrentUserName;
                session.LastChangedDate = DateTime.Now;
                _context.Add(session);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Update(CourseSession courseSession)
        {
            try
            {
                CourseSession session = _context.CourseSessions.Find(courseSession.CourseSessionID);
                session.IsActive = courseSession.IsActive;
                session.Name = courseSession.Name;
                session.LastChangedBy = UserAppData.CurrentUserName;
                session.LastChangedDate = DateTime.Now;
                _context.Update(session);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public List<CourseSession> GetCourseSessions(int courseTopicID)
        {
            try
            {
                return _context.CourseSessions
             .Where(c => c.CourseTopicID == courseTopicID).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }

        public async Task<CourseSession> FindCourseSession(int id)
        {
            try
            {
                return await _context.CourseSessions.
                  Include(c => c.CourseTopic).
                     ThenInclude(c => c.Course).
                    Where(c => c.CourseSessionID == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        // Course Fee

        public async Task<CourseFee> FindCourseFee(int id)
        {
            try
            {
                return await _context.CourseFees.
                     Include(c => c.Course).
                    Where(c => c.CourseFeeID == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Save(CourseFee courseFee)
        {
            try
            {

                courseFee.LastChangedBy = UserAppData.CurrentUserName;
                courseFee.LastChangedDate = DateTime.Now;
                _context.Add(courseFee);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        public async Task<int> Update(CourseFee courseFee)
        {
            try
            {
                CourseFee update = _context.CourseFees.
                Where(t => t.CourseFeeID == courseFee.CourseFeeID).FirstOrDefault();
                update.Name = courseFee.Name;
                update.FrequencyID = courseFee.FrequencyID;
                update.IsActive = courseFee.IsActive;
                update.Amount = courseFee.Amount;
                update.Description = courseFee.Description;
                update.LastChangedBy = UserAppData.CurrentUserName;
                update.LastChangedDate = DateTime.Now;
                _context.Entry(update).State = EntityState.Modified;
                AddCourseFeeHistory(courseFee);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        void AddCourseFeeHistory(CourseFee courseFee)

        {
            try
            {
                //Fee History
                CourseFeeHistory feeHistory = new CourseFeeHistory
                {
                    Amount = courseFee.Amount,
                    Description = courseFee.Description,
                    IsActive = courseFee.IsActive,
                    FrequencyID = courseFee.FrequencyID,
                    Name = courseFee.Name,
                    CourseID = courseFee.CourseID,
                    CourseFeeID = courseFee.CourseFeeID,
                    LastChangedBy = courseFee.LastChangedBy,
                    LastChangedDate = courseFee.LastChangedDate
                };
                _context.Add(feeHistory);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        public async Task<int> ActionCourseFee(int id, DatabaseAction action)
        {
            try
            {
                CourseFee courseFee = await FindCourseFee(id);
                AddCourseFeeHistory(courseFee);
                if (DatabaseAction.Remove == action)
                    _context.CourseFees.Remove(courseFee);

                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    courseFee.LastChangedBy = UserAppData.CurrentUserName;
                    courseFee.LastChangedDate = DateTime.Now;
                    _context.Update(courseFee);
                }
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        //Course Intakes
        public async Task<int> ActionCourseIntake(int id, DatabaseAction action)
        {
            try
            {

                CourseIntake intake = await FindCourseIntake(id);
                if (DatabaseAction.Remove == action)
                    _context.CourseIntakes.Remove(intake);
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    intake.IsActive = DatabaseAction.Deactivate != action;
                    intake.LastChangedBy = UserAppData.CurrentUserName;
                    intake.LastChangedDate = DateTime.Now;
                    _context.Update(intake);
                }
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Save(CourseIntake intake)
        {
            try
            {
                intake.LastChangedBy = UserAppData.CurrentUserName;
                intake.LastChangedDate = DateTime.Now;
                _context.Add(intake);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Update(CourseIntake intake)
        {
            try
            {
                CourseIntake courseIntake = _context.CourseIntakes.Find(intake.CourseIntakeID);
                courseIntake.IsActive = intake.IsActive;
                courseIntake.Name = intake.Name;
                courseIntake.LastChangedBy = UserAppData.CurrentUserName;
                courseIntake.LastChangedDate = DateTime.Now;
                _context.Update(courseIntake);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public List<CourseIntake> GetCourseIntakes(int courseID)
        {
            try
            {
                return _context.CourseIntakes.
                 Include(c => c.Course).
                     Include(c => c.AttendanceRegisters).
                     ThenInclude(c => c.AttendanceRegisterDetails).
                          Where(c => c.CourseID == courseID).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<CourseIntake> FindCourseIntake(int id)
        {
            try
            {
                return await _context.CourseIntakes.
           Include(c => c.Course).
           Include(c => c.AttendanceRegisters).
           ThenInclude(c => c.AttendanceRegisterDetails).
          Where(c => c.CourseIntakeID == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<Client> GetEnrollmentList(int courseIntakeID)
        {
            try
            {

                var clients = _context.ClientCourses.
               Include(c => c.Client).
               ThenInclude(c => c.Title).
               Include(c => c.Client).
               ThenInclude(c => c.JointApplicant).
               ThenInclude(c => c.Title)
               .Where(c => c.CourseIntakeID == courseIntakeID).Select(c => c.Client).Distinct().ToList();
                return clients;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public bool RegisterExist(int courseIntakeID, string dateMarked, int courseTopicID)
        {
            try
            {

                var exists = _context.AttendanceRegisters
                          .Any(c => c.CourseIntakeID == courseIntakeID && c.AttendanceDate.Equals(dateMarked) && c.CourseTopicID==courseTopicID);
                return exists;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> MarkRegister(CourseIntake courseIntake, string[] present)
        {
            try
            {
                int result = 0;
                // Create Attendace Register Record
                AttendanceRegister attendanceRegister = new AttendanceRegister
                {
                    AttendanceDate = courseIntake.AttendanceDate.ToString("yyyy-MMM-dd"),
                    RequestedBy = UserAppData.CurrentUserName,
                    CourseIntakeID = courseIntake.CourseIntakeID,
                    LastChangedBy = UserAppData.CurrentUserName
                };
                if (courseIntake.CourseTopic > 0)
                    attendanceRegister.CourseTopicID = courseIntake.CourseTopic;
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
                        {
                            AttendanceRegisterID = attendanceRegister.AttendanceRegisterID,
                            ClientID = clientID,
                            Present = true,
                            LastChangedBy = UserAppData.CurrentUserName,
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
                            LastChangedBy = UserAppData.CurrentUserName,
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
                CustomLog.Log(LogSource.Logic_Base, ex);
                return 0;
            }

        }
        public async Task<int> DeleteRegister(int id)
        {
            int result;
            try
            {
                var registerDetails = await _context.AttendanceRegisterDetails.Where(ar=>ar.AttendanceRegisterID==id).ToListAsync();
                _context.AttendanceRegisterDetails.RemoveRange(registerDetails);

                var register = await _context.AttendanceRegisters.FindAsync(id);
                _context.AttendanceRegisters.Remove(register);

                result = await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;

        }

        public async Task<AttendanceRegister> FindRegister(int id)
        {
            try
            {

                return await _context.AttendanceRegisters.
                     Include(c => c.AttendanceRegisterDetails).
                     ThenInclude(c => c.Client).
                     Include(c => c.CourseIntake).
                     ThenInclude(c => c.Course).ThenInclude(c => c.CourseTopics).
                    Where(c => c.AttendanceRegisterID == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


    }
}
