using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Exercise1
{
    public class CourseRepository
    {
        private CourseContext context;

        public CourseRepository(CourseContext context)
        {
            this.context = context;
        }

        public IList<Course> GetCourseList() => this.context.Courses.ToList();

        public Course GetCourseByID(int courseId) => this.context.Courses.Find(courseId);

        public void InsertCourse(Course course)
        {
            this.context.Courses.Add(course);
            this.context.SaveChanges();
        }

        public Course UpdateCourseFee(int id, double fee)
        {
            var course = this.context.Courses.Single(c => c.CourseId == id);
            course.CourseFee = fee;
            this.context.SaveChanges();

            return course;
        }
    }
}
