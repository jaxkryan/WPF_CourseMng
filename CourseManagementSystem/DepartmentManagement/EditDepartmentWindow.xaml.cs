using BusinessObjects;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;

namespace CourseManagementSystem.DepartmentManagement
{
    /// <summary>
    /// Interaction logic for EditDepartmentWindow.xaml
    /// </summary>
    public partial class EditDepartmentWindow : Window
    {
        private readonly CourseManagementDbContext _context;
        private readonly Department _departmentToEdit;

        public EditDepartmentWindow(Department department)
        {
            InitializeComponent();
            _context = new CourseManagementDbContext();
            _departmentToEdit = department;

            // Pre-populate the form with department data
            txtCode.Text = _departmentToEdit.Code;
            txtName.Text = _departmentToEdit.Name;
        }

        // Save Button Click
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string code = txtCode.Text;
            string name = txtName.Text;

            // Validation: Required fields
            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Validation: Trim and check for empty input
            if (code.Trim().Length == 0 || name.Trim().Length == 0)
            {
                MessageBox.Show("Fields cannot be empty or contain only white spaces.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Validation: No special characters
            if (!IsValidInput(code) || !IsValidInput(name))
            {
                MessageBox.Show("Code and Name cannot contain special characters.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Validation: Check if the code is being changed to an already existing code
            if (_context.Departments.Any(d => d.Code == code && d.Code != _departmentToEdit.Code))
            {
                MessageBox.Show("The department code already exists in the database.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Update department details
            _departmentToEdit.Code = code;
            _departmentToEdit.Name = name;

            // Save changes to the database
            _context.Departments.Update(_departmentToEdit);
            _context.SaveChanges();

            MessageBox.Show("Department updated successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            DialogResult = true;
            Close();
        }

        // Cancel Button Click
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        // Input Validation: Allow only letters, numbers, and spaces
        private bool IsValidInput(string input)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9 ]+$");
            return regex.IsMatch(input);
        }
    }
}
