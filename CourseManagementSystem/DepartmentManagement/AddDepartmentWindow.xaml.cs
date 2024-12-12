using BusinessObjects;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;

namespace CourseManagementSystem.DepartmentManagement
{
    /// <summary>
    /// Interaction logic for AddDepartmentWindow.xaml
    /// </summary>
    public partial class AddDepartmentWindow : Window
    {
        private readonly CourseManagementDbContext _context;

        public Department NewDepartment { get; private set; }

        public AddDepartmentWindow()
        {
            InitializeComponent();
            _context = new CourseManagementDbContext();
            NewDepartment = new Department();
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

            // Validation: Code uniqueness
            if (_context.Departments.Any(d => d.Code == code))
            {
                MessageBox.Show("The department code already exists in the database.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Assign values to the NewDepartment object
            NewDepartment.Code = code;
            NewDepartment.Name = name;

            // Save message and close the dialog
            MessageBox.Show("Department added successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

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
