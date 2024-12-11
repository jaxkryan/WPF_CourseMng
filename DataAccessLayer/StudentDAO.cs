using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class StudentDAO
    {
        public static void AddStudent(Student NewStudent)
        {
            CourseManagementDbContext _context = new CourseManagementDbContext();
            _context.Students.Add(NewStudent);
            _context.SaveChanges();
        }
        public static void UpdateStudent(Student student)
        {
            CourseManagementDbContext _context = new CourseManagementDbContext();
            _context.Students.Update(student);
            _context.SaveChanges();
        }
        public static Student GetStudentById(int id)
        {
            CourseManagementDbContext _context = new CourseManagementDbContext();
            return _context.Students.Find(id);
        }
        public static List<Student> GetAllStudents() 
        {
            List<Student> students = new List<Student>();
            CourseManagementDbContext _context = new CourseManagementDbContext();
            students = _context.Students.Include(s => s.DepartmentNavigation)
                .Select(s => new Student
                {
                    Id = s.Id,
                    Name = s.Name,
                    Birthdate = s.Birthdate,
                    Gender = s.Gender,
                    Address = s.Address,    
                    City = s.City,
                    Country = s.Country,
                    Department = s.DepartmentNavigation.Name
                }).ToList();
            return students;
        }
    }
}
