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
    /// Interaction logic for TeacherHome.xaml
    /// </summary>
    public partial class TeacherHome : Window
    {
        readonly FinallyContext final = new FinallyContext();
        public TeacherHome()
        {
            InitializeComponent();
            Hellost.Content = "Hello " + final.Teachers.FirstOrDefault(x => x.AccountId == GetAccountID.ID).FullName;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ManageDepartment department = new ManageDepartment(1);
            department.Show();


            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ManageGrade degrade = new ManageGrade();
            degrade.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ViewSchedule2 viewSchedule2 = new ViewSchedule2();
            viewSchedule2.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            TeacherProfile teacherProfile = new TeacherProfile();
            teacherProfile.Show();
            this.Close();
        }
    }
}
