using Finally.Models;
using Microsoft.Identity.Client.NativeInterop;
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
    /// Interaction logic for TeacherProfile.xaml
    /// </summary>
    public partial class TeacherProfile : Window
    {
        FinallyContext final =  new FinallyContext();

        private int ID { get; set; }

        public TeacherProfile()
        {
            InitializeComponent();
            
            load();
        }

        public void load()
        {
            Teacher teacher = final.Teachers.FirstOrDefault(x => x.AccountId == GetAccountID.ID);
            if (teacher != null)
            {
                DateTime.TryParse(teacher.DateOfBirth.ToString(), out DateTime date);
                txtFullName.Text = teacher.FullName;
                dpDateOfBirth.SelectedDate = date;
                rbMale.IsChecked = true;
                rbFemale.IsChecked = teacher.Gender == 0;
                txtPhoneNumber.Text = teacher.PhoneNumber;
                txtAddress.Text = teacher.Address;
                txtPassword.Text = GetAccountID.Password;
            }
        }
        public void changePass(int? email, string pass)
        {
            var x = final.Accounts.FirstOrDefault(c => c.Id == email);
            if (x != null)
            {
                x.Password = pass;
                final.Accounts.Update(x);
                final.SaveChanges();
            }
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            TeacherHome teacher = new TeacherHome();
            teacher.Show();
            this.Close();
        }

        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            Teacher teacher = final.Teachers.FirstOrDefault(x => x.AccountId == GetAccountID.ID);
            if (teacher != null)
            {
                DateOnly.TryParse(dpDateOfBirth.Text, out DateOnly date);
                teacher.FullName = txtFullName.Text;
                teacher.DateOfBirth = date;
                teacher.Gender = rbMale.IsChecked == true ? 1 : (rbFemale.IsChecked == true ? 0 : -1);
                teacher.PhoneNumber = txtPhoneNumber.Text;
                teacher.Address = txtAddress.Text;
                changePass(GetAccountID.ID, txtPassword.Text);
                final.Teachers.Update(teacher);
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
