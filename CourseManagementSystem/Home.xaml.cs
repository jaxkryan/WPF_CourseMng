using BusinessObjects;
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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }
        public Home(AccountMember accountMember)
        {
            InitializeComponent();
            if (accountMember.Role == 2)
            {
                btnSemester.Visibility = Visibility.Collapsed;
                btnCourse.Visibility = Visibility.Collapsed;
                btnDepartment.Visibility = Visibility.Collapsed;
            }
        }
        private void btnCourse_Click(object sender, RoutedEventArgs e)
        {
            Course.ViewCourseManage viewCourseManage = new Course.ViewCourseManage();
            viewCourseManage.ShowDialog();

        }

        private void btnStudent_Click(object sender, RoutedEventArgs e)
        {
            StudentManagement.ViewStudentManagement viewStudentManagement = new StudentManagement.ViewStudentManagement();
            viewStudentManagement.ShowDialog();
        }

        private void btnDepartment_Click(object sender, RoutedEventArgs e)
        {
            DepartmentManagement.Departments departments = new DepartmentManagement.Departments();
            departments.ShowDialog();
        }

        private void btnSemester_Click(object sender, RoutedEventArgs e)
        {
            SemeterManagement.SemesterManagement semesterManagement = new SemeterManagement.SemesterManagement();       
            semesterManagement.ShowDialog();
        }

        private void btnEnroll_Click(object sender, RoutedEventArgs e)
        {
            EnrollmentManagement.EnrollmentManagement enrollmentManagement = new EnrollmentManagement.EnrollmentManagement();
            enrollmentManagement.ShowDialog();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes) 
            {
                Login login = new Login();
                this.Close();
                login.Show();
            }
        }
    }
}
