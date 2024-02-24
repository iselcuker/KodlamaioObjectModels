// See https://aka.ms/new-console-template for more information

using Business.Concretes;
using DataAccess.Concretes.InMemory;

//CourseManager courseManager = new CourseManager(new InMemoryCourseDal());
//CategoryManager categoryManager = new CategoryManager(new InMemoryCatagoryDal());
InstructorManager instructorManager = new InstructorManager(new InMemoryInstructorDal());

foreach (var instructor in instructorManager.GetAll())
{
    Console.WriteLine("{0} {1}",instructor.FirstName,instructor.LastName);
}


