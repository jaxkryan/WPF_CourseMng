using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        Student GetStudentById(int id);

    }
}
