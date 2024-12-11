using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        Student GetStudentById(int id);
    }
}
