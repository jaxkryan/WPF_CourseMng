using Finally.Models;
using System;
using System.Collections.Generic;
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

namespace Finally
{
    /// <summary>
    /// Interaction logic for Signup.xaml
    /// </summary>
    public partial class Signup : Window
    {
        FinallyContext filnal = new FinallyContext();
        public Signup()
        {
            InitializeComponent();
        }
        DateTime codeGenerationTime;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string fullName = FullName.Text.Trim();
            string role = RoleStudent.IsChecked == true ? "Student" : RoleTeacher.IsChecked == true ? "Teacher" : "";
            string email = Email.Text.Trim();
            string password = Password.Password.Trim();
            string repassword = Repassword.Password.Trim();
            string username = Username.Text.Trim();

            // Validation
            if (string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("Full Name is required.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            

            

            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Role is required.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email is required.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid Email format.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if(filnal.Accounts.FirstOrDefault(x=> x.Email==email && x.Status==1)!=null)
            {
                MessageBox.Show("This email is already exist!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username is required.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password is required.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
           

            if (password != repassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // If all validations pass, proceed with further processing
            if (role == "Student")
            {
                Account acc = new Account();
                acc.Username = username;
                acc.Password = password;
                acc.RoleId = 2;
                acc.Email = email;
                acc.Status = 0;
                filnal.Accounts.Add(acc);
                filnal.SaveChanges();
                Student stu = new Student();
                stu.FullName = fullName;
                stu.AccountId = filnal.Accounts.Max(x => x.Id);
                filnal.Students.Add(stu);
                filnal.SaveChanges();
                GetAccountID.Instance.ID = filnal.Accounts.Max(y => y.Id);
                GetAccountID.Instance.Role = acc.RoleId;
                GetAccountID.Instance.Password = acc.Password;
                string code = GenerateCode();
                codeGenerationTime = DateTime.Now;
                SendCodeEmail(email, code);
                ConfirmCode dialog = new ConfirmCode(code, codeGenerationTime);
                if (dialog.ShowDialog() == true)
                {
                    ViewGrades viewGrades = new ViewGrades(2);
                    viewGrades.Show();
                    this.Close();
                }
               

            }
            else if(role == "Teacher")
            {
                Account acc = new Account();
                acc.Username = username;
                acc.Password = password;
                acc.RoleId = 3;
                acc.Status = 0;
                filnal.Accounts.Add(acc);
                filnal.SaveChanges();
                Teacher teacher = new Teacher();
                teacher.FullName = fullName;
                teacher.AccountId= filnal.Accounts.Max(y => y.Id);
                filnal.Teachers.Add(teacher);
                filnal.SaveChanges();
                GetAccountID.Instance.ID = filnal.Accounts.Max(y => y.Id);
                GetAccountID.Instance.Role = acc.RoleId;
                GetAccountID.Instance.Password = acc.Password;
                string code = GenerateCode();
                codeGenerationTime = DateTime.Now;
                SendCodeEmail(email, code);
                ConfirmCode dialog = new ConfirmCode(code, codeGenerationTime);
                if (dialog.ShowDialog() == true)
                {
                    ManageDepartment department = new ManageDepartment(1);
                    department.Show();
                    this.Close();
                }
                
            }

        }
        public string GenerateCode()
        {
            string rs = "";
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                rs += random.Next(0, 9);
            }
            return rs;
        }
        public void SendCodeEmail(string email, string code)
        {
            try
            {
                EmailUtil.SendEmail(email, "Email confirmation code", code);
                MessageBox.Show("Email sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email. Error: " + ex.Message);
            }
        }
       
        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
