using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;


namespace Services
{
    public class SemesterSevice : ISemesterSevice
    {
        private readonly ISemesterRepository _irepository;
        public SemesterSevice()
        {
            _irepository = new SemesterRepository();
        }

        public void CreateSemester(Semester semester)
        {
             _irepository.CreateSemester(semester);
        }
        public void UpdateSemester(Semester semester)
        {
            _irepository.UpdateSemester(semester);  
        }
        public Semester GetSemesterById(int id) 
        {
            return _irepository.GetSemesterById(id);
        }
        public List<Semester> GetSemesters()
        {
            return _irepository.GetSemesters();
        }
        public List<int?> GetYear()
        {
            return _irepository.GetYear();
        }
        public bool GetSemesterByCode(string code)
        {
            return _irepository.GetSemesterByCode(code);
        }               
        public int GetNextSemesterId()
        {
            return _irepository.GetNextSemesterId();
        }
    }
}
