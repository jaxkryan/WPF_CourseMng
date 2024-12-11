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
        public Login()
        {
            InitializeComponent();
            PasswordTextBox.Visibility = Visibility.Collapsed;
        }

        public void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            CourseManagementDbContext _context = new CourseManagementDbContext();
            if(UsernameTextBox.Text == "" ||  PasswordBox.Password == "")
            {
                MessageBox.Show("Please provide UserName and Password !!!");
                return;
            }
            else
            {
                string username = UsernameTextBox.Text;
                string password = PasswordBox.Password;
           
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

        public void TogglePasswordVisibility(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Visibility == Visibility.Visible)
            {
                PasswordBox.Visibility = Visibility.Collapsed;
                PasswordTextBox.Text = PasswordBox.Password;
                PasswordTextBox.Visibility = Visibility.Visible;
            }
            else
            {
                PasswordTextBox.Visibility = Visibility.Collapsed;
                PasswordBox.Password = PasswordTextBox.Text;
                PasswordBox.Visibility = Visibility.Visible;
            }
        }
    }
}
