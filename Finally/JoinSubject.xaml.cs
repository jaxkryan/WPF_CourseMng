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
    /// Interaction logic for JoinSubject.xaml
    /// </summary>
    public partial class JoinSubject : Window
    {
        FinallyContext final =new FinallyContext();
        public JoinSubject()
        {
            InitializeComponent();
            var student = final.Students.FirstOrDefault(x => x.AccountId == GetAccountID.Instance.ID);

            // Check if student is found
            if (student != null)
            {
                // Get the Schedule IDs associated with the student
                var studentScheduleIds = final.ScheduleStus
                                              .Where(ss => ss.StudentId == student.Id)
                                              .Select(ss => ss.ScheduleId)
                                              .ToList();

                // Get the Class IDs and Subject IDs associated with the student's schedules
                var excludedClassIds = final.Schedules
                                            .Where(sche => studentScheduleIds.Contains(sche.ScheduleId))
                                            .Select(sche => sche.ClassId)
                                            .Distinct()
                                            .ToList();

                var excludedSubjectIds = final.Schedules
                                              .Where(sche => studentScheduleIds.Contains(sche.ScheduleId))
                                              .Select(sche => sche.SubjectId)
                                              .Distinct()
                                              .ToList();

                // Query to get subjects that are not associated with the student's schedule IDs
                var subjects = from sche in final.Schedules
                               join sub in final.Subjects on sche.SubjectId equals sub.Id
                               where !excludedSubjectIds.Contains(sche.SubjectId)
                               select sub.Name;

                // Query to get classes that are not associated with the student's schedule IDs
                var classes = from sche in final.Schedules
                              join cl in final.Classes on sche.ClassId equals cl.Id
                              where !excludedClassIds.Contains(sche.ClassId)
                              select cl.Name;

                // Combine the subjects and classes and remove duplicates
                var allOptions = subjects.Concat(classes).Distinct().ToList();

                // Set the ItemsSource of SubjectComboBox to the combined list
                SubjectComboBox.ItemsSource = allOptions;
            }
        }
        private DateTime? TryParseDate(string dateStr)
        {
            DateTime parsedDate;
            if (DateTime.TryParse(dateStr, out parsedDate))
            {
                return parsedDate;
            }
            else
            {
                // Log or handle the error as needed
                return null;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string selectedSubject = SubjectComboBox.SelectedItem as string;
            if (selectedSubject != null)
            {
                string selectedClass = ClassComboBox.SelectedItem as string;
                if (selectedClass != null)
                {
                    if (dpkTimeLearn.SelectedDate.HasValue)
                    {
                        DateTime selectedDateTime = dpkTimeLearn.SelectedDate.Value;
                        var student = final.Students.FirstOrDefault(x => x.AccountId == GetAccountID.Instance.ID)?.Id;
                        if (student != null)
                        {
                            var schedules = from sch in final.Schedules
                                            join cl in final.Classes on sch.ClassId equals cl.Id
                                            join sub in final.Subjects on sch.SubjectId equals sub.Id
                                            where cl.Name == selectedClass && sub.Name == selectedSubject
                                            select new
                                            {
                                                sch.ScheduleId,
                                                sch.DayOfWeeks,
                                                cl.Id
                                            };

                            // Step 2: Filter and process data in memory
                            var schstu = schedules.AsEnumerable() // Switch to in-memory processing
                                .Where(sch =>
                                {
                                    DateTime schDate;
                                    return DateTime.TryParse(sch.DayOfWeeks, out schDate) && schDate > selectedDateTime;
                                })
                                .Select(sch => new { sch.ScheduleId, sch.Id });
                            int count = 0;
                            foreach (var sctu in schstu)
                            {
                                try
                                {
                                    

                                    ScheduleStu s2 = new ScheduleStu
                                    {
                                        ScheduleId = sctu.ScheduleId,
                                        StudentId = student.Value,
                                        Status = 3
                                    };
                                    final.ScheduleStus.Add(s2);
                                    if (count == 0)
                                    {
                                        ClassStu s3 = new ClassStu()
                                        {
                                            ClassId = sctu.Id,
                                            StudentId = student.Value,
                                            Course = 1
                                        };
                                        final.ClassStus.Add(s3);
                                        count++;
                                    }
                                    
                                   
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Error adding data: {ex.Message}");
                                    return;
                                }
                            }

                            try
                            {
                                final.SaveChanges();
                                MessageBox.Show("Join Successful");
                                StudentHome studentHome = new StudentHome();
                                studentHome.Show();
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error saving changes: {ex.Message}");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Student not found!");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("You must input date!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("You must input class!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("You must input Subject!");
                return;
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            StudentHome studentHome = new StudentHome();
            studentHome.Show();
            this.Close();
        }

        private void SubjectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedSubject = SubjectComboBox.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedSubject))
            {

                var classNames = from sch in final.Schedules
                                 join cl in final.Classes on sch.ClassId equals cl.Id
                                 join sub in final.Subjects on sch.SubjectId equals sub.Id
                                 where sub.Name == selectedSubject
                                 select cl.Name;

                // Set the ItemsSource of ClassComboBox to unique class names
                ClassComboBox.ItemsSource = classNames.Distinct().ToList();

            }
        }
    }
}
