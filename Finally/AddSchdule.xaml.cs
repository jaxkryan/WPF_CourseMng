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
    /// Interaction logic for AddSchdule.xaml
    /// </summary>
    public partial class AddSchdule : Window
    {
        FinallyContext final = new FinallyContext();

        public AddSchdule()
        {
            InitializeComponent();
            var subjects = final.Subjects.Select(x => x.Name).ToList();
            SubjectComboBox.ItemsSource = subjects;
            int[] slot = [1,2,3,4];
            cbxSlot.ItemsSource = slot;
            var classes = final.Classes.Select(x => x.Name).ToList();
            ClassComboBox.ItemsSource = classes;
        }

        private void ClassComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateTeacherComboBox();
        }

        private void SubjectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateClassComboBox();
        }

        

        private void UpdateTeacherComboBox()
        {
            if (ClassComboBox.SelectedItem == null) return;

            var selectedClassName = ClassComboBox.SelectedItem.ToString();
            var selectedClass = final.Classes.FirstOrDefault(c => c.Name == selectedClassName);

            if (selectedClass == null) return;

            var availableTeachers = final.Teachers
                .Where(t => !final.Schedules.Any(s => s.ClassId == selectedClass.Id && s.TeacherId == t.Id))
                .Select(t => t.FullName)
                .ToList();

            TeacherCombobox.ItemsSource = availableTeachers;
        }

        private void UpdateClassComboBox()
        {
            if (SubjectComboBox.SelectedItem == null) return;

            var selectedSubjectName = SubjectComboBox.SelectedItem.ToString();
            var selectedSubject = final.Subjects.FirstOrDefault(s => s.Name == selectedSubjectName);

            if (selectedSubject == null) return;

            var availableClasses = final.Classes
                .Where(c => !final.Schedules.Any(s => s.SubjectId == selectedSubject.Id && s.ClassId == c.Id))
                .Select(c => c.Name)
                .ToList();

            ClassComboBox.ItemsSource = availableClasses;

            // Optionally reset the TeacherComboBox if the available classes change
            TeacherCombobox.ItemsSource = null;
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Check if any of the combo boxes are not selected
                if (SubjectComboBox.SelectedItem == null || ClassComboBox.SelectedItem == null || TeacherCombobox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a subject, class, and teacher.");
                    return;
                }

                // Get the selected items from combo boxes
                string subject = SubjectComboBox.SelectedItem.ToString();
                string clas = ClassComboBox.SelectedItem.ToString();
                string teacher = TeacherCombobox.SelectedItem.ToString();
                int slot =int.Parse( cbxSlot.SelectedItem.ToString());

                // Find the corresponding entities
                var sub = final.Subjects.FirstOrDefault(x => x.Name == subject);
                if (sub == null)
                {
                    MessageBox.Show("Selected subject not found.");
                    return;
                }

                var cl = final.Classes.FirstOrDefault(x => x.Name == clas);
                if (cl == null)
                {
                    MessageBox.Show("Selected class not found.");
                    return;
                }

                var teach = final.Teachers.FirstOrDefault(x => x.FullName == teacher);
                if (teach == null)
                {
                    MessageBox.Show("Selected teacher not found.");
                    return;
                }

                // Check if the date is selected
                if (dpkTimeLearn.SelectedDate == null)
                {
                    MessageBox.Show("Please select a date.");
                    return;
                }

                DateTime d = (DateTime)dpkTimeLearn.SelectedDate;
                List<DateTime> dates = GetWeekdaysOfNextTwoMonths(d);
                string date = "";
                // Add schedules for each date
                foreach (var dateItem in dates)
                {
                    Schedule schn = new Schedule
                    {
                        SubjectId = sub.Id,
                        TeacherId = teach.Id,
                        ClassId = cl.Id,
                        DayOfWeeks = dateItem.ToString("yyyy-MM-dd"), // Use a consistent date format
                        
                        Slot = slot
                    };

                    if (final.Schedules.FirstOrDefault(x => x.DayOfWeeks == schn.DayOfWeeks&& x.Slot==schn.Slot
                    && x.TeacherId==schn.TeacherId )==null)
                    {
                        final.Schedules.Add(schn);
                        final.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Duplicate timetable!"); return;
                    }
                   
                }

                // Check the state of entities before saving
                var schedulesState = final.ChangeTracker.Entries<Schedule>().Select(e => new { e.Entity, e.State }).ToList();
                foreach (var state in schedulesState)
                {
                    Console.WriteLine($"Entity: {state.Entity}, State: {state.State}");
                }

               
                MessageBox.Show("Add successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
        public static List<DateTime> GetWeekdaysOfNextTwoMonths(DateTime currentDate)
        {
            List<DateTime> weekdays = new List<DateTime>();

            // Calculate the start date as two months after the current date
            DateTime startDate = currentDate;

            // Calculate the end date as two months after the start date
            DateTime endDate = startDate.AddMonths(2).AddDays(-1);

            // Loop through the date range from startDate to endDate
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                // Check if the date is a weekday (Monday to Friday)
                if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
                {
                    weekdays.Add(date);
                }
            }

            return weekdays;
        }
        private void TeacherCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
