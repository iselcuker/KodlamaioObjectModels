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
    public class InMemoryInstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;

        public InMemoryInstructorDal()
        {
            _instructors = new List<Instructor>
            {
                new Instructor{Id=1,FirstName="Engin",LastName="Demiroğ"},
                new Instructor{Id=2,FirstName="Halit Enes",LastName="Kalaycı"},
            };
        }

        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            Instructor instructorToDelete = _instructors.SingleOrDefault(i => i.Id == instructor.Id);
            _instructors.Remove(instructorToDelete);
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public void Update(Instructor instructor)
        {
            Instructor instructorToUpdate = _instructors.SingleOrDefault(i => i.Id == instructor.Id);
            instructorToUpdate.Id = instructor.Id;
            instructorToUpdate.FirstName = instructor.FirstName;
            instructorToUpdate.LastName = instructor.LastName;
        }
    }
}
