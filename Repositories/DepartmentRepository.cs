using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
    
        public void CreateDepartment(Department department) => DepartmentDAO.CreateDepartment(department);


        public List<Department> GetDepartment() => DepartmentDAO.GetDepartment();

        public void UpdateDepartment(Department department) => DepartmentDAO.UpdateDepartment(department);

        public Department? GetDepartmentByCode(string Code) => DepartmentDAO.GetDepartmentByCode(Code);
    }
}