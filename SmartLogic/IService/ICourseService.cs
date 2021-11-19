﻿using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace SmartLogic
{
    public interface ICourseService
    {

       
        Task<int> Save(Course Course);
        Task<bool> IsDuplicate(Course course);
        Task<int> Update(Course Course);
        Task<int> ActionCourse(int id, DatabaseAction action);
        Task<Course> FindCourse(int id);
        Task<List<Course>> Courses();
        Task<List<Course>> NewCourses();

        // Course Topic
        Task<int> Save(CourseTopic CourseTopic);
        Task<int> Update(CourseTopic CourseTopic);
        Task<int> ActionCourseTopic(int id, DatabaseAction action);
        Task<CourseTopic> FindCourseTopic(int id);
        List<CourseTopic> GetCourseTopics(int courseID);

        // Course Session
        Task<int> Save(CourseSession courseSession);
        Task<int> Update(CourseSession courseSession);
        Task<int> ActionCourseSession(int id, DatabaseAction action);
        Task<CourseSession> FindCourseSession(int id);
        List<CourseSession> GetCourseSessions(int courseTopicID);

        // Course Intake
        Task<int> Save(CourseIntake courseIntake);
        Task<int> Update(CourseIntake courseIntake);
        Task<int> ActionCourseIntake(int id, DatabaseAction action);
        Task<CourseIntake> FindCourseIntake(int id);
        List<CourseIntake> GetCourseIntakes(int courseID);
        List<Client> GetEnrollmentList(int intakeID);
        Task<int> MarkRegister(CourseIntake courseIntake, string[] enrolmentList);
        bool RegisterExist(int courseIntakeID, string dateMarked,int courseTopicID);
        Task<AttendanceRegister> FindRegister(int id);
        Task<int> DeleteRegister(int id);

        //Course Fee
        Task<CourseFee> FindCourseFee(int id);
        Task<int> Save(CourseFee courseFee);
        Task<int> Update(CourseFee courseFee);
        Task<int> ActionCourseFee(int id, DatabaseAction action);
    }
}
