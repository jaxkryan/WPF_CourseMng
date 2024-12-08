﻿using Finally.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Finally
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        FinallyContext final = new FinallyContext();
        private int roleId;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

            string username = Username.Text;
            string password = Password.Password;

            var check = final.Accounts.FirstOrDefault(p => (p.Username == username || p.Email == username) && p.Password == password&& p.Status==1);

            var role = check?.RoleId;


            if (check != null)
            {
                //MessageBox.Show("Login successful!");
                if ( role == 3)
                {
                    GetAccountID.Instance.ID = check.Id;
                    GetAccountID.Instance.Role = (int)role;
                    GetAccountID.Instance.Password = check.Password;
                    ManageDepartment department = new ManageDepartment(3);

                    department.Show();
                   
                   
                    this.Close();

                }else if (role == 1)
                {
                    GetAccountID.Instance.ID = check.Id;
                    GetAccountID.Instance.Role = (int)role;
                    GetAccountID.Instance.Password = check.Password;
                    TeacherHome teacherHome = new TeacherHome();

                    teacherHome.Show();
                    this.Close();

                }
                else if (role == 2)
                {
                    GetAccountID.Instance.ID = check.Id;
                    GetAccountID.Instance.Role = (int)role;
                    GetAccountID.Instance.Password = check.Password;
                    StudentHome studentHome = new StudentHome();

                    studentHome.Show();
                    this.Close();
                }else if(role == 4)
                {
                    AddSchdule addSchdule = new AddSchdule();
                    addSchdule.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowReset reset = new WindowReset();
            reset.Show();
            this.Close();
        }

        private void Signupbutton_Click(object sender, RoutedEventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Close();
        }
    }
}