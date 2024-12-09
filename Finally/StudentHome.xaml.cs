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
    public partial class StudentHome : Window
    {
        FinallyContext final = new FinallyContext();
        public StudentHome()
        {
             InitializeComponent();

            Hellost.Content = "Hello " + final.Students.FirstOrDefault(x => x.AccountId == GetAccountID.Instance.ID).FullName;
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            JoinSubject joinSubject = new JoinSubject();
            joinSubject.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ViewGrades viewGrades = new ViewGrades(2);
            viewGrades.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ViewSchedules viewSchedules = new ViewSchedules();
            viewSchedules.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            StudentProfile studentProfile = new StudentProfile();
            studentProfile.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
