using BusinessObjects;
using DataAccessLayer;
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

namespace CourseManagementSystem
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        CourseManagementDbContext _context = new CourseManagementDbContext();

        public Login()
        {
            InitializeComponent();
            Password.Visibility = Visibility.Collapsed;
        }

        public void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if(Username.Text == "" || Password.Password == "")
            {
                MessageBox.Show("Please provide UserName and Password !!!");
                return;
            }
            else
            {
                string username = Username.Text;
                string password = Password.Password;
           
                if (AccountMemberDAO.CheckExist(username, password) == null) 
                {
                    MessageBox.Show("Username or Password incorrect !!!");
                    return;
                }
                else
                {
                    Home home = new Home(AccountMemberDAO.CheckExist(username, password));
                    home.Show();
                    this.Close();
                }
            }
        }

        //public void TogglePasswordVisibility(object sender, RoutedEventArgs e)
        //{
        //    if (Password.Visibility == Visibility.Visible)
        //    {
        //        Password.Visibility = Visibility.Collapsed;
        //        PasswordTextBox.Text = Password.Password;
        //        PasswordTextBox.Visibility = Visibility.Visible;
        //    }
        //    else
        //    {
        //        PasswordTextBox.Visibility = Visibility.Collapsed;
        //        Password.Password = PasswordTextBox.Text;
        //        Password.Visibility = Visibility.Visible;
        //    }
        //}
    }
}
