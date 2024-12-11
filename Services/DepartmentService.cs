using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DepartmentService : IDepartmentService
    { 
        private readonly IDepartmentRepository departmentRepository;
        public DepartmentService()
        {
            departmentRepository = new DepartmentRepository();
        }
        public void UpdateDepartment(Department department)
        {
            departmentRepository.UpdateDepartment(department);
        }
        public void CreateDepartment(Department department)
        {
            departmentRepository.CreateDepartment(department);
        }
        public List<Department> GetDepartment()
        {
            return departmentRepository.GetDepartment();
        }
        public Department? GetDepartmentByCode(string code)
        {
            return departmentRepository.GetDepartmentByCode(code);
        }
    }
}
