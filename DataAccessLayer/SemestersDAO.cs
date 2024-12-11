using Azure.Core;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{

    public class SemestersDAO
    {
        public static List<Semester> GetSemesters()
        {
            CourseManagementDbContext _context = new CourseManagementDbContext();
            return _context.Semesters.ToList();
        }
        public static int GetNextSemesterId()
        {
            CourseManagementDbContext _context = new CourseManagementDbContext();
            return _context.Semesters.Any() ? _context.Semesters.Max(x => x.Id) + 1 : 1;
        }
        public static void UpdateSemester(Semester semester)
        {
            CourseManagementDbContext _context = new CourseManagementDbContext();
            _context.Semesters.Update(semester);
            _context.SaveChanges();
        }
        public static void CreateSemester(Semester NewSemester)
        {
            CourseManagementDbContext _context = new CourseManagementDbContext();
            NewSemester.Id = GetNextSemesterId();
            _context.Semesters.Add(NewSemester);
            _context.SaveChanges();
        }
        public static Semester GetSemesterById(int id)
        {
            CourseManagementDbContext _context = new CourseManagementDbContext();
            return _context.Semesters.Find(id);
        }
        public static List<int?> GetYear()
        {
            using (CourseManagementDbContext _context = new CourseManagementDbContext())
            {
                return _context.Semesters.Select(s => s.Year).Distinct().ToList();
            }
        }
        public static bool GetSemesterByCode(string code)
        {
            using (var _context = new CourseManagementDbContext())
            {
                return _context.Semesters.Any(s => s.Code == code);
            }
        }
    }
}
