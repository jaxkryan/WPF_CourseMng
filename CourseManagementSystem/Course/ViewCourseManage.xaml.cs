using BusinessObjects;
using DataAccessLayer;
using Services;
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

namespace CourseManagementSystem.Course
{
    /// <summary>
    /// Interaction logic for ViewCourseManage.xaml
    /// </summary>
    public partial class ViewCourseManage : Window
    {
        private readonly CourseManagementDbContext _context;
        private readonly ICourseService courseService;
        public ViewCourseManage()
        {
            InitializeComponent();
            _context = new CourseManagementDbContext();
            courseService = new CourseService();
            LoadComboBoxes();
            LoadCourse();
        }

        public void LoadComboBoxes()
        {
            var course = courseService.GetCourses();
            var titles = course.Select(x => x.Title).Distinct().ToList();
            var credits = courseService.GetCredits().OrderBy(c => c).ToList();

            cbFilterTitle.ItemsSource = titles;
            cboFilterCredits.ItemsSource = credits;
        }
        public void LoadCourse()
        {
            dgCourses.ItemsSource = courseService.GetCourses();
            LoadComboBoxes();
        }
        private void FilterCourses(object sender, SelectionChangedEventArgs e)
        {
            string titleFilter = cbFilterTitle.SelectedItem?.ToString().ToLower();
            int? creditFilter = cboFilterCredits.SelectedItem as int?;

            var filterCourse = courseService.GetCourses()
                .Where(c => (string.IsNullOrEmpty(titleFilter) || c.Title.ToLower().Contains(titleFilter)) &&
                            (!creditFilter.HasValue || c.Credits == creditFilter))
                .ToList();
            dgCourses.ItemsSource = filterCourse;
        }
        private void btnClearFilter_Click(object sender, RoutedEventArgs e)
        {
            cboFilterCredits.SelectedItem = null;
            cbFilterTitle.SelectedItem = null;
            dgCourses.ItemsSource = courseService.GetCourses();
        }

        private void btnAddCourse_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new AddCourse();
            if (dialog.ShowDialog() == true)
            {
                courseService.CreateCourse(dialog.NewCourse);
                dgCourses.ItemsSource = courseService.GetCourses();
                LoadComboBoxes();
            }

        }

        private void btnUpdateCourse_Click(object sender, RoutedEventArgs e)
        {
            if (dgCourses.SelectedItem is BusinessObjects.Course selectedCourse) 
            {
                var dialog = new EditCourse(selectedCourse);
                if (dialog.ShowDialog() == true)
                {
                    courseService.UpdateCourse(dialog.ExistingCourse);
                    dgCourses.ItemsSource = courseService.GetCourses();
                    LoadComboBoxes();
                }
            }
            else
            {
                MessageBox.Show("Please select a course to update.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private void btnChangeStatus_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to change status?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                CourseDAO courseDAO = new CourseDAO();
                if (dgCourses.SelectedItem is BusinessObjects.Course selectedCourse)
                {
                    int newStatus = selectedCourse.Status == 1 ? 0 : 1;
                    courseDAO.UpdateCourseStatus(selectedCourse.Id, newStatus);
                    LoadCourse();
                }
                else
                {
                    MessageBox.Show("Please select a course to change its status.", "No Course Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }
        private void btnViewAssessments_Click(object sender, RoutedEventArgs e)
        {
            if (dgCourses.SelectedItem is BusinessObjects.Course selectedCourse) 
            {
                var assessmentWindow = new ViewAssessment(selectedCourse.Id);
                assessmentWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a course to update.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
