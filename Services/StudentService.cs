using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository studentRepository;
        public StudentService()
        {
            studentRepository = new StudentRepository();
        }
        public void AddStudent(Student student)
        {
            studentRepository.AddStudent(student);
        }
        public void UpdateStudent(Student student)
        {
            studentRepository.UpdateStudent(student);
        }
        public List<Student> GetAllStudents()
        {
            return studentRepository.GetAllStudents();
        }
        public Student GetStudentById(int id)
        {
            return studentRepository.GetStudentById(id);
        }
    }
}
