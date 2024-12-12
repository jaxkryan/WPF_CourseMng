using BusinessObjects;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;
using Microsoft.Win32;
using System.Data;
using System.Globalization;

namespace CourseManagementSystem.StudentManagement
{
    /// <summary>
    /// Interaction logic for ViewStudentManagement.xaml
    /// </summary>
    public partial class ViewStudentManagement : Window
    {
        private readonly IStudentService studentService;
        private readonly CourseManagementDbContext _context;
        public ViewStudentManagement()
        {
            InitializeComponent();
            studentService = new StudentService();
            _context = new CourseManagementDbContext();
            LoadStudent();
            LoadGender();
            LoadDepartment();
            LoadCountry();
        }
        public void LoadStudent()
        {
            dgData.ItemsSource = studentService.GetAllStudents();
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

        public void LoadCountry()
        {
            cboCountry.ItemsSource = _context.Students.Select(s => s.Country).ToList();
        }
        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            cboGender.SelectedItem = null;
            cboDepartment.SelectedItem = null;
            cboCountry.SelectedItem = null;
            dgData.ItemsSource = studentService.GetAllStudents();
        }

        private void txtSearchName_TextChanged(object sender, TextChangedEventArgs e)
        {
            FilterData();
        }
        public void filter(object sender, SelectionChangedEventArgs e)
        {
            FilterData();

        }
        public void FilterData()
        {
            var filteredList = studentService.GetAllStudents().AsQueryable();

            if (!string.IsNullOrEmpty(txtSearchName.Text))
            {
                filteredList = filteredList.Where(s => s.Name.ToLower().Contains(txtSearchName.Text.ToLower()));
            }

            if (cboGender.SelectedItem != null)
            {
                filteredList = filteredList.Where(s => s.Gender == cboGender.SelectedItem.ToString());
            }

            if (cboCountry.SelectedItem != null)
            {
                filteredList = filteredList.Where(s => s.Country == cboCountry.SelectedItem.ToString());
            }

            if (cboDepartment.SelectedItem != null)
            {
                filteredList = filteredList.Where(s => s.Department == cboDepartment.SelectedItem.ToString());
            }

            dgData.ItemsSource = filteredList.ToList();
        }
        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new AddStudent();
            if (dialog.ShowDialog() == true)
            {
                studentService.AddStudent(dialog.NewStudent);
                dgData.ItemsSource = studentService.GetAllStudents();
            }
        }

        private void ExportBtn_Click(object sender, RoutedEventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Save an Excel File"
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Students");

                    // Add headers
                    for (int i = 0; i < dgData.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1].Value = dgData.Columns[i].Header;
                        worksheet.Cells[1, i + 1].Style.Font.Bold = true;
                    }

                    // Add data from the underlying data source
                    var itemsSource = dgData.ItemsSource as IEnumerable<Student>; // Replace Student with your model
                    int row = 2;
                    foreach (var item in itemsSource)
                    {
                        worksheet.Cells[row, 1].Value = item.Id;
                        worksheet.Cells[row, 2].Value = item.Name;
                        worksheet.Cells[row, 3].Value = item.Birthdate.ToString();
                        worksheet.Cells[row, 4].Value = item.Gender;
                        worksheet.Cells[row, 5].Value = item.Address;
                        worksheet.Cells[row, 6].Value = item.City;
                        worksheet.Cells[row, 7].Value = item.Country;
                        worksheet.Cells[row, 8].Value = item.Department;
                        row++;
                    }

                    // Adjust columns width
                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    // Save file
                    File.WriteAllBytes(saveFileDialog.FileName, package.GetAsByteArray());
                }
                MessageBox.Show("Data has been successfully exported to Excel!", "Export Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ImportBtn_Click(object sender, RoutedEventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Select Excel File"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                using (ExcelPackage package = new ExcelPackage(new FileInfo(openFileDialog.FileName)))
                {
                    if (package.Workbook.Worksheets.Count > 0)
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                        // Get the data from the Excel file
                        DataTable dataTable = new DataTable();
                        for (int j = 1; j <= worksheet.Dimension.End.Column; j++)
                        {
                            dataTable.Columns.Add($"Column{j}");
                        }

                        for (int i = 1; i <= worksheet.Dimension.End.Row; i++)
                        {
                            DataRow dataRow = dataTable.NewRow();
                            for (int j = 1; j <= worksheet.Dimension.End.Column; j++)
                            {
                                dataRow[j - 1] = worksheet.Cells[i, j].Value;
                            }
                            dataTable.Rows.Add(dataRow);
                        }

                        // Add the data to the database
                        using (CourseManagementDbContext context = new CourseManagementDbContext())
                        {
                            foreach (DataRow row in dataTable.Rows)
                            {
                                Student student = new Student();
                                student.Name = row[1]?.ToString();
                                if (DateOnly.TryParseExact(row[2]?.ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateOnly birthDate))
                                {
                                    student.Birthdate = birthDate;
                                }
                                else
                                {
                                    student.Birthdate = null; // or handle the error as needed
                                }
                                student.Gender = row[3]?.ToString();
                                student.Address = row[4]?.ToString();
                                student.City = row[5]?.ToString();
                                student.Country = row[6]?.ToString();
                                student.Department = row[7]?.ToString();

                                context.Students.Add(student);
                            }
                            context.SaveChanges();
                        }

                        // Refresh the DataGrid
                        LoadStudent();
                    }
                    else
                    {
                        MessageBox.Show("The selected file does not contain any worksheets.");
                    }
                }
            }
        }
    }
    }

