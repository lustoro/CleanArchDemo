using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanArch.Infra.Data.Repositories
{
   public class CourseRepository: ICourseRepository
    {
        private readonly UniversityDBContext _ctx;

        public CourseRepository(UniversityDBContext ctx)
        {
            this._ctx = ctx;
        }

        public void Add(Course course)
        {
            _ctx.Courses.Add(course);
            _ctx.SaveChanges();
        }
        public IQueryable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
