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
    /// Interaction logic for AdminProfile.xaml
    /// </summary>
    public partial class AdminProfile : Window
    {
        FinallyContext final = new FinallyContext();

        private int ID;

        public AdminProfile(int Id)
        {
            InitializeComponent();
            ID = Id;
            load();
        }

        public void load()
        {
            Admin admin = final.Admins.FirstOrDefault(x => x.AccountId == GetAccountID.Instance.ID);
            if (admin != null)
            {
                DateTime.TryParse(admin.DateOfBirth.ToString(), out DateTime date);
                txtFullName.Text = admin.FullName;
                dpDateOfBirth.SelectedDate = date;
                rbMale.IsChecked = true;
                rbFemale.IsChecked = admin.Gender == 0;
                txtPhoneNumber.Text = admin.PhoneNumber;
                txtAddress.Text = admin.Address;
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            ManageTeacher teacher = new ManageTeacher(ID,3);
            teacher.Show();
            this.Close();
        }

        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            Admin admin = final.Admins.FirstOrDefault(x => x.AccountId == GetAccountID.Instance.ID);
            if (admin != null)
            {
                DateOnly.TryParse(dpDateOfBirth.Text, out DateOnly date);
                admin.FullName = txtFullName.Text;
                admin.DateOfBirth = date;
                admin.Gender = rbMale.IsChecked == true ? 1 : (rbFemale.IsChecked == true ? 0 : -1);
                admin.PhoneNumber = txtPhoneNumber.Text;
                admin.Address = txtAddress.Text;
                final.Admins.Update(admin);
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
