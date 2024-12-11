using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class SemesterRepository : ISemesterRepository
    {
      
        public void CreateSemester(Semester semester) => SemestersDAO.CreateSemester(semester);

        public bool GetSemesterByCode(string code) => SemestersDAO.GetSemesterByCode(code);        

        public Semester? GetSemesterById(int id) => SemestersDAO.GetSemesterById(id);

        public List<Semester> GetSemesters() => SemestersDAO.GetSemesters();

        public int GetNextSemesterId() => SemestersDAO.GetNextSemesterId();

        public List<int?> GetYear() => SemestersDAO.GetYear();
       
        public void UpdateSemester(Semester semester) => SemestersDAO.UpdateSemester(semester);
    }
}
