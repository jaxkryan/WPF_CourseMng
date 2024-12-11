using BusinessObjects;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing.IndexedProperties;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Input.Manipulations;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CourseManagementSystem.StudentManagement
{
    /// <summary>
    /// Interaction logic for AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Window
    {
        private readonly CourseManagementDbContext _context;
        public Student NewStudent { get; private set; }
        public AddStudent()
        {
            InitializeComponent();
            _context = new CourseManagementDbContext();
            LoadGender();
            LoadDepartment();
            LoadCountries();
            NewStudent = new Student();
        }
        public void LoadGender()
        {
            var listGender = new List<string>
            {
                "Male",
                "Female"
            };
            cboGender.ItemsSource = listGender;
        }
        public void LoadDepartment()
        {
            cboDepartment.ItemsSource = _context.Departments.Select(x => x.Name).ToList();
        }
        public void LoadCountries()
        {
            var listCountries = _context.Students.Select(c  => c.Country).ToList();
            cboCountry.ItemsSource = listCountries;
        }
        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateInputs(out string name, out DateOnly? birthDate, out string gender, out string address, out string city, out string country, out string departmentName))
            {
                return;
            }

            string departmentCode = _context.Departments
                .Where(d => d.Name == departmentName)
                .Select(d => d.Code)
                .FirstOrDefault();

            if (departmentCode == null)
            {
                MessageBox.Show("Selected department does not exist.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            NewStudent.Id = _context.Students.Any() ? _context.Students.Max(std => std.Id) + 1 : 1;
            NewStudent.Name = name;
            NewStudent.Birthdate = birthDate;
            NewStudent.Gender = gender;
            NewStudent.Address = address;
            NewStudent.City = city;
            NewStudent.Country = country;
            NewStudent.Department = departmentCode;

            MessageBox.Show("Student added successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            DialogResult = true;
            Close();
        }

        private bool ValidateInputs(out string name, out DateOnly? birthDate, out string gender, out string address, out string city, out string country, out string departmentName)
        {
            name = txtName.Text;
            birthDate = txtBirthDate.SelectedDate.HasValue ? DateOnly.FromDateTime(txtBirthDate.SelectedDate.Value) : (DateOnly?)null;
            gender = cboGender.Text;
            address = txtAddress.Text;
            city = txtCity.Text;
            country = cboCountry.SelectedItem?.ToString(); 
            departmentName = cboDepartment.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(gender) || string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(city) || string.IsNullOrWhiteSpace(country) || string.IsNullOrWhiteSpace(departmentName))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if (!IsValidText(name) || !IsValidText(gender) || !IsValidText(address) || !IsValidText(city) || !IsValidText(country) || !IsValidText(departmentName))
            {
                MessageBox.Show("Fields cannot contain special characters.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if (birthDate == null)
            {
                MessageBox.Show("Birthdate is required.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            return true;
        }

        private bool IsValidText(string input)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9 ]+$");
            return regex.IsMatch(input);
        }
    }
}
