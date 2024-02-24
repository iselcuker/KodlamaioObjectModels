using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.InMemory
{
    public class InMemoryCourseDal : ICourseDal
    {
        List<Course> _courses;

        public InMemoryCourseDal()
        {
            _courses = new List<Course>
            {
            new Course{Id=1,CategoryId=1,InstructorId=1,CourseDescription="Yazılımda bir üst seviyeye geçiş",Name="Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)"},
            new Course{Id=2,CategoryId=2,InstructorId=1,CourseDescription="Frontend dünyasına giriş",Name="Yazılım Geliştirici Yetiştirme Kampı (Angular)"},
            new Course{Id=3,CategoryId=1,InstructorId=2,CourseDescription="Web Uygulamalarınızı test edin",Name="(2023) Yazılım Geliştirici Yetiştirme Kampı – Python & Selenium"},

            };
        }

        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(Course course)
        {
            Course courseToDelete = _courses.SingleOrDefault(c => c.Id == course.Id);
            _courses.Remove(courseToDelete);
        }

        public Course Get(Expression<Func<Course, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public List<Course> GetAll(Expression<Func<Course, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAllByCategory(int categoryId)
        {
            return _courses.Where(c => c.CategoryId == categoryId).ToList();
        }

        public List<Course> GetAllByInstructor(int insturctorId)
        {
            return _courses.Where(c => c.InstructorId == insturctorId).ToList();
        }

        public void Update(Course course)
        {
            Course courseToUpdate = _courses.SingleOrDefault(c => c.Id == course.Id);
            courseToUpdate.Id = course.Id;
            courseToUpdate.CategoryId = course.CategoryId;
            courseToUpdate.InstructorId = course.InstructorId;
            courseToUpdate.Name = course.Name;
            courseToUpdate.CourseDescription = course.CourseDescription;
        }
    }
}
