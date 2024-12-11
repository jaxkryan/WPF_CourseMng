using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public void AddStudent(Student student) => StudentDAO.AddStudent(student);

        public void UpdateStudent(Student student) => StudentDAO.UpdateStudent(student);

        public List<Student> GetAllStudents() => StudentDAO.GetAllStudents();

        public Student GetStudentById(int id) => StudentDAO.GetStudentById(id);
    }
}
