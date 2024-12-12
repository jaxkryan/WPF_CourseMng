using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using BusinessObjects;
using Microsoft.EntityFrameworkCore;

namespace CourseManagementSystem.DepartmentManagement
{
    public partial class Departments : Window
    {
        private ObservableCollection<Department> _departments;
        private readonly CourseManagementDbContext _context;

        public Departments()
        {
            InitializeComponent();
            _context = new CourseManagementDbContext();
            LoadDepartments();
        }

        // Load Departments into the DataGrid
        private void LoadDepartments()
        {
            _context.Database.EnsureCreated(); // Ensure DB exists
            var departmentList = _context.Departments.ToList();
            foreach (var dept in departmentList)
            {
                if (dept.Status == 0)
                {
                    dept.Name += " (Deleted)";
                    dept.Code += " (Deleted)";
                }
            }
            _departments = new ObservableCollection<Department>(departmentList);
            dgDepartments.ItemsSource = _departments;
        }

        // Add Button Event
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var addWindow = new AddDepartmentWindow();
            if (addWindow.ShowDialog() == true) // If Save clicked
            {
                var newDepartment = addWindow.NewDepartment;

                // Add to Database
                if (!_context.Departments.Any(d => d.Code == newDepartment.Code))
                {
                    _context.Departments.Add(newDepartment);
                    _context.SaveChanges();
                    _departments.Add(newDepartment);
                }
                else
                {
                    MessageBox.Show("Department code already exists.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        // Update Button Event
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (dgDepartments.SelectedItem is Department selectedDept)
            {
                var updateWindow = new EditDepartmentWindow(selectedDept);
                if (updateWindow.ShowDialog() == true)
                {
                    _context.Departments.Update(selectedDept);
                    _context.SaveChanges();
                    LoadDepartments(); // Refresh Grid
                }
            }
            else
            {
                MessageBox.Show("Please select a department to update.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        // Delete Button Event
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (dgDepartments.SelectedItem is Department selectedDept)
            {
                var result = MessageBox.Show($"Are you sure you want to delete '{selectedDept.Name}'?",
                    "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Warning);

                if (result == MessageBoxResult.Yes)
                {
                    selectedDept.Status = 0; // Set status to 0 instead of removing
                    _context.Departments.Update(selectedDept);
                    _context.SaveChanges();
                    LoadDepartments(); // Refresh Grid
                }
            }
            else
            {
                MessageBox.Show("Please select a department to delete.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        // Close Button Event
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
