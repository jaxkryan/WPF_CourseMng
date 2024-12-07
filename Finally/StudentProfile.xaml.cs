using Finally.Models;
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

namespace Finally
{
    /// <summary>
    /// Interaction logic for StudentProfile.xaml
    /// </summary>
    public partial class StudentProfile : Window
    {
        FinallyContext final = new FinallyContext();


        public StudentProfile()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            Student student = final.Students.FirstOrDefault(x => x.AccountId == GetAccountID.ID);
            if (student != null)
            {
                DateTime.TryParse(student.DateOfBirth.ToString(), out DateTime date);
                txtFullName.Text = student.FullName;
                dpDateOfBirth.SelectedDate = date;
                rbMale.IsChecked = true;
                rbFemale.IsChecked = student.Gender == 0;
                txtPhoneNumber.Text = student.PhoneNumber;
                txtAddress.Text = student.Address;
                txtPassword.Text = GetAccountID.Password;
            }
        }
        public void changePass(int? id, string pass)
        {
            var x = final.Accounts.FirstOrDefault(c => c.Id == id);
            if (x != null)
            {
                x.Password = pass;
                final.Accounts.Update(x);
                final.SaveChanges();
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            StudentHome studentHome = new StudentHome();
            studentHome.Show();
            this.Close();
        }

        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            Student student = final.Students.FirstOrDefault(x => x.AccountId == GetAccountID.ID);
            if (student != null)
            {
                DateOnly.TryParse(dpDateOfBirth.Text, out DateOnly date);
                student.FullName = txtFullName.Text;
                student.DateOfBirth = date;
                student.Gender = rbMale.IsChecked == true ? 1 : (rbFemale.IsChecked == true ? 0 : -1);
                student.PhoneNumber = txtPhoneNumber.Text;
                student.Address = txtAddress.Text;
                final.Students.Update(student);
                changePass(GetAccountID.ID,txtPassword.Text);
                if (final.SaveChanges() > 0)
                {
                    MessageBox.Show("Update successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                    load();
                }
                else
                {
                    MessageBox.Show("Product not found!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
