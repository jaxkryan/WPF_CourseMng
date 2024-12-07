using Finally.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client.NativeInterop;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
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
using System.Windows.Xps;

namespace Finally
{
    /// <summary>
    /// Interaction logic for ManageStudent.xaml
    /// </summary>
    public partial class ManageStudent : Window
    {
        FinallyContext final = new FinallyContext();

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

        public int Id { get; set; }
        public int roldID;

        private int ID;
        public ManageStudent(int id)
        {
            InitializeComponent();
            load();
            
           
        }

        public void load()
        {
            var combo = final.Students.Select(x => x.Address).Distinct().ToList();
            combo.Insert(0, "All");
            
            AddressComboBox.ItemsSource = combo;
            var st2 = final.Students;
            StudentDataGrid.ItemsSource = st2.ToList();
        }

        private bool isAscending = false;

        private void SortButton_Click(object sender, RoutedEventArgs e)
        {

            if (isAscending)
            {

                load();

                SortButton.Content = "SortDesc";
            }
            else
            {
                var students = final.ClassStus.Where(x => x.ClassId == ID).ToList();
                List<Student> st2 = new List<Student>();
                foreach (var student in students)
                {
                    var st3 = final.Students.Where(x => x.Id == student.StudentId).ToList();
                    foreach (var student2 in st3)
                    {
                        st2.Add(final.Students.FirstOrDefault(x => x.Id == student2.Id));
                    }
                }
                StudentDataGrid.ItemsSource = st2
                                          .OrderByDescending(x => x.Id)
                                          .ToList();

                SortButton.Content = "SortAsc";
            }

            isAscending = !isAscending;
        }

        private void StudentDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (StudentDataGrid.SelectedItem is Student selected)
            {
                DateTime.TryParse(selected.DateOfBirth.ToString(), out DateTime date);
                txtID.Text = selected.Id.ToString();
                txtName.Text = selected.FullName;
                dpDOB.SelectedDate = date;
                rbMale.IsChecked = true;
                rbFemale.IsChecked = selected.Gender == 0;
                txtPhone.Text = selected.PhoneNumber;
                txtAddress.Text = selected.Address;
                txtAccountID.Text = selected.AccountId.ToString();
                Models.Account account = final.Accounts.FirstOrDefault(t  => t.Id == selected.AccountId);
                txtUsername.Text = account.Username;
                txtPassword.Text = account.Password;
                txtEmail.Text = account.Email;
                txtStatus.Text = account.Status.ToString();
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
            txtAccountID.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtStatus.Text = "";
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            ManageClass manageClass = new ManageClass(3);
            manageClass.Show();
            this.Close();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var students = final.ClassStus.Where(x => x.ClassId == ID).ToList();
            List<Student> st2 = new List<Student>();
            foreach (var student in students)
            {
                var st3 = final.Students.Where(x => x.Id == student.StudentId).ToList();
                foreach (var student2 in st3)
                {
                    st2.Add(final.Students.FirstOrDefault(x => x.Id == student2.Id));
                }
            }
            StudentDataGrid.ItemsSource = st2.Where(t => t.FullName.Contains(txtSearch.Text)).ToList();
        }

        private void AddressComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            string selectedAddress = AddressComboBox.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedAddress))
            {
                if (selectedAddress.Equals("All"))
                {
                    load();
                }
                else
                {
                    var students = final.ClassStus.Where(x => x.ClassId == ID).ToList();
                    List<Student> st2 = new List<Student>();
                    foreach (var student in students)
                    {
                        var st3 = final.Students.Where(x => x.Id == student.StudentId).ToList();
                        foreach (var student2 in st3)
                        {
                            st2.Add(final.Students.FirstOrDefault(x => x.Id == student2.Id));
                        }
                    }
                    StudentDataGrid.ItemsSource = st2.Where(x => x.Address == selectedAddress ).ToList();
                }

            }

        }

        private void ViewButton_Click(object sender, RoutedEventArgs e)
        {
            ManageGrade grades = new ManageGrade();
            grades.Show();
            this.Close();

        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student();
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
            student.FullName = txtName.Text;
            DateOnly.TryParse(dpDOB.Text, out DateOnly date);
            student.DateOfBirth = date;
            student.Gender = rbMale.IsChecked == true ? 1 : (rbFemale.IsChecked == true ? 0 : 2);
            student.PhoneNumber = txtPhone.Text;
            student.Address = txtAddress.Text;
            account.Username = txtUsername.Text;
            account.Password = txtPassword.Text;
            account.Email = txtEmail.Text;
            account.RoleId = 2;
            final.Accounts.Add(account);
            final.SaveChanges();
            Models.Account account1 = final.Accounts.FirstOrDefault(t => t.Username.Equals(txtUsername.Text));
            student.AccountId = account1.Id;
            final.Students.Add(student);
            final.SaveChanges();
            MessageBox.Show("Add successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            load();
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
            Student student = final.Students.FirstOrDefault(t => t.Id == int.Parse(txtID.Text));
            Models.Account account = final.Accounts.FirstOrDefault(t => t.Id == int.Parse(txtAccountID.Text));
            student.FullName = txtName.Text;
            DateOnly.TryParse(dpDOB.Text, out DateOnly date);
            student.DateOfBirth = date;
            student.Gender = rbMale.IsChecked == true ? 1 : (rbFemale.IsChecked == true ? 0 : 2);
            student.PhoneNumber = txtPhone.Text;
            student.Address = txtAddress.Text;
            account.Username = txtUsername.Text;
            account.Password = txtPassword.Text;
            account.Email = txtEmail.Text;
            account.RoleId = 2;
            final.Accounts.Update(account);
            final.Students.Update(student);
            if (final.SaveChanges() > 0)
            {
                MessageBox.Show("Update successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                load();
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
                Student student = final.Students.Include(t => t.Account).FirstOrDefault(x => x.Id == int.Parse(txtID.Text));
                if (student != null)
                {
                    if (student.Account !=null)
                    {
                        final.Accounts.RemoveRange(student.Account);
                    }
                    final.Students.Remove(student);
                    if (final.SaveChanges() > 0)
                    {
                        MessageBox.Show("Delete successfully!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                        load();
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtAccountID.Text != null)
            {
              Models.Account a =   final.Accounts.FirstOrDefault(x=>x.Id==int.Parse(txtAccountID.Text));
                a.Status = a.Status == 1 ? 0 : 1;
                final.Accounts.Update(a);
                final.SaveChanges();
                load();
                clear();
            }
            else
            {
                MessageBox.Show("Choose an account!");
            }
        }
    }
}
