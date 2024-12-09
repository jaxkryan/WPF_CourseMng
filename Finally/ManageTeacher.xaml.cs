using Finally.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client.NativeInterop;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Finally
{
    /// <summary>
    /// Interaction logic for ManageTeacher.xaml
    /// </summary>
    public partial class ManageTeacher : Window
    {
        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                Regex regex = new Regex(pattern);
                return regex.IsMatch(email);
            }
            catch (Exception)
            {
                return false;
            }
        }

        FinallyContext final = new FinallyContext();

        public int Id { get; set; }

        private int ID;
        private int roleID;
        public ManageTeacher(int Id, int role)
        {
                InitializeComponent();
                load(Id);
                ID = Id;
            roleID = role;
        }

        public void load(int Id)
        {
            if (GetAccountID.Instance.Role == 3)
            {
                ViewForAdmin.Visibility = Visibility.Visible;
                ViewForTeacher.Visibility = Visibility.Collapsed;
                ButtonForAdmin.Visibility = Visibility.Visible;
                ButtonForTeacher.Visibility = Visibility.Collapsed;

                txtAccountID.Visibility = Visibility.Visible;
                txtUsername.Visibility = Visibility.Visible;
                txtPassword.Visibility = Visibility.Visible;
                txtEmail.Visibility = Visibility.Visible;   

            }
            else
            {
                ViewForAdmin.Visibility = Visibility.Collapsed;
                ViewForTeacher.Visibility = Visibility.Visible;
                ButtonForTeacher.Visibility = Visibility.Visible;
                ButtonForAdmin.Visibility = Visibility.Collapsed;

                txtAccountID.Visibility = Visibility.Collapsed;
                lblAccountID.Visibility = Visibility.Collapsed;

                txtUsername.Visibility = Visibility.Collapsed;
                lblUsername.Visibility = Visibility.Collapsed;

                txtPassword.Visibility = Visibility.Collapsed;
                lblPassword.Visibility = Visibility.Collapsed;

                txtEmail.Visibility = Visibility.Collapsed;
                lblEmail.Visibility = Visibility.Collapsed;
                ButtonForTeacher.Visibility = Visibility.Collapsed;
            }

            var combo = final.Teachers.Select(x => x.Address).Distinct().ToList();
            combo.Insert(0, "All");

            AddressComboBox.ItemsSource = combo;

            TeacherDataGrid.ItemsSource = final.Teachers.Include(t => t.Department).Where(t => t.DepartmentId == Id).ToList();
        }

        private bool isAscending = false;

        private void SortButton_Click(object sender, RoutedEventArgs e)
        {

            if (isAscending)
            {

                load(ID);

                SortButton.Content = "SortDesc";
            }
            else
            {
                TeacherDataGrid.ItemsSource = final.Teachers
                                          .Where(x => x.DepartmentId == ID)
                                          .OrderByDescending(x => x.Id)
                                          .ToList();

                SortButton.Content = "SortAsc";
            }

            isAscending = !isAscending;
        }

        private void TeacherDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TeacherDataGrid.SelectedItem is Teacher selected)
            {
                DateTime.TryParse(selected.DateOfBirth.ToString(), out DateTime date);
                txtID.Text = selected.Id.ToString();
                txtName.Text = selected.FullName;
                dpDOB.SelectedDate = date;
                rbMale.IsChecked = true;
                rbFemale.IsChecked = selected.Gender == 0;
                txtPhone.Text = selected.PhoneNumber;
                txtAddress.Text = selected.Address;
                txtDepartmentName.Text = selected.Department.Name;
                txtAccountID.Text = selected.AccountId.ToString();
                Models.Account account = final.Accounts.FirstOrDefault(t => t.Id == selected.AccountId);
                txtUsername.Text = account.Username;
                txtPassword.Text = account.Password;
                txtEmail.Text = account.Email;
            }
        }

        private void clear()
        {
            txtID.Text = "";
            txtName.Text = "";
            dpDOB.SelectedDate = null;
            rbMale.IsChecked = false;
            rbFemale.IsChecked = false;
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtSubject.Text = "";
            txtDepartmentName.Text = "";
            txtAccountID.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            ManageDepartment manageDepartment = new ManageDepartment(3);
            manageDepartment.Show();
            this.Close();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            TeacherDataGrid.ItemsSource = final.Teachers.Where(t => t.FullName.Contains(txtSearch.Text) && t.DepartmentId == ID).ToList();
        }

        private void AddressComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            string selectedAddress = AddressComboBox.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedAddress))
            {
                if (selectedAddress.Equals("All"))
                {
                    load(ID);
                }
                else
                {
                    TeacherDataGrid.ItemsSource = final.Teachers.Where(x => x.Address == selectedAddress && x.DepartmentId == ID).ToList();
                }

            }

        }

        private void ViewButton_Click(object sender, RoutedEventArgs e)
        {
            TeacherProfile teacher = new TeacherProfile();
            teacher.Show();
            this.Close();
        }

        private void SaveFileButton_Click(object sender, RoutedEventArgs e)
        {
            // Save file chọn json
            //SaveFileDialog saveFileDialog = new SaveFileDialog();

            //saveFileDialog.DefaultExt = ".json";
            //saveFileDialog.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
            //if (saveFileDialog.ShowDialog() == true)
            //{
            //    var jsonOptions = new JsonSerializerOptions
            //    {
            //        WriteIndented = true,
            //    };

            //    List<Employee> employees = con.Employees
            //                                  .Include(emp => emp.Department) // Ensure Department is loaded
            //                                  .ToList();

            //    var employeeData = employees.Select(x => new
            //    {
            //        x.EmployeeId,
            //        x.FirstName,
            //        x.LastName,
            //        x.BirthDate,
            //        DepartmentName = x.Department.DepartmentName // Preserve the Department Name
            //    }).ToList();

            //    string jsonContent = JsonSerializer.Serialize(employeeData, jsonOptions);
            //    File.WriteAllText(saveFileDialog.FileName, jsonContent);
            //    MessageBox.Show("Save successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            //}

            // Save file có sẵn json
            List<Teacher> teacher = final.Teachers.Include(x => x.Department).Where(t => t.DepartmentId == ID).ToList();
            var employeeData = teacher.Select(x => new
            {
                x.FullName,
                x.DateOfBirth,
                Gender = x.Gender,
                x.PhoneNumber,
                x.Address,
                x.AccountId,
                DepartmentName = x.Department.Name,
            }).ToList();
            teacher.AddRange(final.Teachers);
            string currentDirectory = System.IO.Directory.GetCurrentDirectory();
            string parentDirectory = Directory.GetParent(currentDirectory).FullName;
            string parent2Directory = Directory.GetParent(parentDirectory).FullName;
            string parent3Directory = Directory.GetParent(parent2Directory).FullName;
            // Tạo đường dẫn tệp tin bằng cách kết hợp đường dẫn thư mục với tên tệp
            System.Windows.MessageBox.Show(parent3Directory);
            string filePath = System.IO.Path.Combine(parent3Directory, "Teacher.json");
            System.Windows.MessageBox.Show(filePath);
            try
            {
                if (File.Exists(filePath))
                {
                    string jsonString = JsonSerializer.Serialize(employeeData, new JsonSerializerOptions
                    {
                        WriteIndented = true
                    });
                    File.WriteAllText(filePath, jsonString);
                }
                else
                {
                    System.Windows.MessageBox.Show("File not found!");
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error reading JSON file: " + ex.Message);
            }
        }

        private void LoadFileButton_Click(object sender, RoutedEventArgs e)
        {
            string currentDirectory = System.IO.Directory.GetCurrentDirectory();
            string parentDirectory = Directory.GetParent(currentDirectory).FullName;
            string parent2Directory = Directory.GetParent(parentDirectory).FullName;
            string parent3Directory = Directory.GetParent(parent2Directory).FullName;

            // Create the file path by combining the directory path with the file name
            string filePath = System.IO.Path.Combine(parent3Directory, "Teacher.json");

            try
            {
                if (File.Exists(filePath))
                {
                    string jsonContent = File.ReadAllText(filePath);
                    var employeeData = JsonSerializer.Deserialize<List<Teacher>>(jsonContent, new JsonSerializerOptions
                    {
                        WriteIndented = true
                    });

                    using (var context = new FinallyContext())
                    {
                        List<Teacher> teachers = new List<Teacher>();

                        foreach (var item in employeeData)
                        {
                            Department department = context.Departments
                                .FirstOrDefault(d => d.Id == item.DepartmentId);

                            Teacher teacher = new Teacher
                            {
                                FullName = item.FullName,
                                DateOfBirth = item.DateOfBirth,
                                Gender = item.Gender,
                                PhoneNumber = item.PhoneNumber,
                                Address = item.Address,
                                AccountId = item.AccountId,
                                Department = department,
                            };

                            teachers.Add(teacher);
                            context.Teachers.Add(teacher);
                        }

                        context.SaveChanges();
                        TeacherDataGrid.ItemsSource = teachers;
                        MessageBox.Show("Data loaded and saved to database successfully.");
                    }
                }
                else
                {
                    MessageBox.Show("File not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data from JSON file: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Teacher teacher = new Teacher();
            Models.Account account = new Models.Account();
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Id is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (dpDOB.SelectedDate == null)
            {
                MessageBox.Show("Date is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (rbFemale.IsChecked == false && rbMale.IsChecked == false)
            {
                MessageBox.Show("Gender is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("PhoneNumber is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Address is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtSubject.Text))
            {
                MessageBox.Show("Subject is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtDepartmentName.Text))
            {
                MessageBox.Show("DepartmentName is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtAccountID.Text))
            {
                MessageBox.Show("AccountId is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Username is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text) || IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email must be follow format abc@example.com", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            teacher.FullName = txtName.Text;
            DateOnly.TryParse(dpDOB.Text, out DateOnly date);
            teacher.DateOfBirth = date;
            teacher.Gender = rbMale.IsChecked == true ? 1 : (rbFemale.IsChecked == true ? 0 : 2);
            teacher.PhoneNumber = txtPhone.Text;
            teacher.Address = txtAddress.Text;
            teacher.DepartmentId = ID;
            account.Username = txtUsername.Text;
            account.Password = txtPassword.Text;
            account.Email = txtEmail.Text;
            account.RoleId = 1;
            final.Accounts.Add(account);
            final.SaveChanges();
            Models.Account account1 = final.Accounts.FirstOrDefault(t => t.Username.Equals(txtUsername.Text));
            teacher.AccountId = account1.Id;
            final.Teachers.Add(teacher);
            final.SaveChanges();
            MessageBox.Show("Add successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            load(ID);
            clear();

        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Id is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (dpDOB.SelectedDate == null)
            {
                MessageBox.Show("Date is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (rbFemale.IsChecked == false && rbMale.IsChecked == false)
            {
                MessageBox.Show("Gender is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("PhoneNumber is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Address is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtSubject.Text))
            {
                MessageBox.Show("Subject is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtDepartmentName.Text))
            {
                MessageBox.Show("DepartmentName is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtAccountID.Text))
            {
                MessageBox.Show("AccountId is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Username is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text) || IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email must be follow format abc@example.com", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Teacher teacher = final.Teachers.FirstOrDefault(t => t.Id == int.Parse(txtID.Text));
            Models.Account account = final.Accounts.FirstOrDefault(t => t.Id == int.Parse(txtAccountID.Text));
            teacher.FullName = txtName.Text;
            DateOnly.TryParse(dpDOB.Text, out DateOnly date);
            teacher.DateOfBirth = date;
            teacher.Gender = rbMale.IsChecked == true ? 1 : (rbFemale.IsChecked == true ? 0 : 2);
            teacher.PhoneNumber = txtPhone.Text;
            teacher.Address = txtAddress.Text;
            teacher.DepartmentId = ID;
            account.Username = txtUsername.Text;
            account.Password = txtPassword.Text;
            account.Email = txtEmail.Text;
            account.RoleId = 2;
            final.Accounts.Update(account);
            final.Teachers.Update(teacher);
            if (final.SaveChanges() > 0)
            {
                MessageBox.Show("Update successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                load(ID);
                clear();
            }
            else
            {
                MessageBox.Show("Product not found!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Id Invalid!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Teacher teacher = final.Teachers.Include(t => t.Account).FirstOrDefault(x => x.Id == int.Parse(txtID.Text));
            if (teacher != null)
            {
                if (teacher.Account != null)
                {
                    final.Accounts.RemoveRange(teacher.Account);
                }
                final.Teachers.Remove(teacher);
                if (final.SaveChanges() > 0)
                {
                    MessageBox.Show("Delete successfully!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                    load(ID);
                    clear();
                }
                else
                {
                    MessageBox.Show("Delete failed!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }


        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            clear();
        }

        private void ViewButton1_Click(object sender, RoutedEventArgs e)
        {
            AdminProfile adminProfile = new AdminProfile(ID);
            adminProfile.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtAccountID.Text != null)
            {
                Models.Account a = final.Accounts.FirstOrDefault(x => x.Id == int.Parse(txtAccountID.Text));
                a.Status = a.Status == 1 ? 0 : 1;
                final.Accounts.Update(a);
                final.SaveChanges();
                load(ID);
                clear();
            }
            else
            {
                MessageBox.Show("Choose an account!");
            }
        }
    }
}
