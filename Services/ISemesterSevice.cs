using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ISemesterSevice
    {
        public void CreateSemester(Semester semester);
        public void UpdateSemester(Semester semester);
        public Semester? GetSemesterById(int id);
        public List<int?> GetYear();
        public int GetNextSemesterId();
        public List<Semester> GetSemesters();
        public bool GetSemesterByCode(string code);
    }
}
