using BusinessObjects;
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

namespace CourseManagementSystem.SemeterManagement
{
    /// <summary>
    /// Interaction logic for SemesterManagement.xaml
    /// </summary>
    public partial class SemesterManagement : Window
    {
        private readonly ISemesterSevice iSemesterSevice;
        private readonly CourseManagementDbContext _context;
        public SemesterManagement()
        {
            InitializeComponent();
            iSemesterSevice = new SemesterSevice();
            _context = new CourseManagementDbContext();
            LoadSemesters();
            LoadYear();
        }

        public void LoadSemesters()
        {
            dgSemester.ItemsSource = iSemesterSevice.GetSemesters();
            LoadYear();
        }
        public void LoadYear()
        {
            var year = iSemesterSevice.GetYear();
            YearComboBox.ItemsSource = year;
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnClearFilter_Click(object sender, RoutedEventArgs e)
        {
            YearComboBox.ItemsSource = null;
            dgSemester.ItemsSource = iSemesterSevice.GetSemesters();
        }

        private void YearComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (YearComboBox.SelectedItem != null)
            {
                int selectedYear = (int)YearComboBox.SelectedItem;
                dgSemester.ItemsSource = iSemesterSevice.GetSemesters().Where(x => x.Year == selectedYear).ToList();
            }

        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var addSemesterWindow = new AddSemester();
            if (addSemesterWindow.ShowDialog() == true)
            {
                Semester newSemester = addSemesterWindow.NewSemester;
                iSemesterSevice.CreateSemester(newSemester);
                LoadSemesters();
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (dgSemester.SelectedItem is Semester selectedSemester)
            {        
                var editSemester = new EditSemester(selectedSemester);
                if (editSemester.ShowDialog() == true)
                {                    
                    iSemesterSevice.UpdateSemester(editSemester.UpdateSemester);
                    dgSemester.ItemsSource = iSemesterSevice.GetSemesters();
                }
            }
            else
            {
                MessageBox.Show("Please select a semester to edit.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
