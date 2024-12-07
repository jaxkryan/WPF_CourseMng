using Finally.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Interaction logic for ManageSchedule.xaml
    /// </summary>
    public partial class ManageSchedule : Window
    {
        FinallyContext final = new FinallyContext();

        private int ClassID;
        private int roleID;
        public ManageSchedule(int role)
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            var combo = final.Teachers.Select(t => t.Address).ToList();
            combo.Insert(0, "All");
            SubjectComboBox.ItemsSource = combo;
            SubjectComboBox2.ItemsSource = combo;
            var check = final.Schedules.ToList();
            ScheduleDataGrid.ItemsSource = check.Select(t => new
            {
                t.DayOfWeeks,
                t.Slot,
                ClassName = GetClassName(t.ClassId),
                TeacherName = GetTeacherName(t.TeacherId),
                //Subject = GetSubject(t.TeacherId)
            }).ToList();
        }
        private string GetTeacherName(int? id)
        {
            var check = final.Teachers.ToList();
            foreach (var t in check)
            {
                if (t.Id == id)
                {
                    return t.FullName;
                }
            }
            return "";
        }
        //private string GetSubject(int? id)
        //{
        //    var check = final.Teachers.ToList();
        //    foreach (var t in check)
        //    {
        //        if (t.Id == id)
        //        {
        //            return t.Subject;
        //        }
        //    }
        //    return "";
        //}

        private string GetClassName(int? id)
        {
            var check = final.Classes.ToList();
            foreach (var x in check)
            {
                if (x.Id == id)
                {
                    return x.Name;
                }
            }
            return "";
        }
        private void SubjectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedSubject = SubjectComboBox.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedSubject))
            {
                if (selectedSubject.Equals("All"))
                {
                    load();
                }
                else
                {
                    Teacher teacher = final.Teachers.Where(t => t.Address == selectedSubject).FirstOrDefault();
                    if (teacher != null)
                    {
                        var check = final.Schedules.Where(t => t.TeacherId == teacher.Id).ToList();
                        ScheduleDataGrid.ItemsSource = check.Select(t => new
                        {
                            t.DayOfWeeks,
                            t.Slot,
                            ClassName = GetClassName(t.ClassId),
                            TeacherName = GetTeacherName(t.TeacherId),
                            //Subject = GetSubject(t.TeacherId),
                        }).ToList();
                    }
                }

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Schedule s = new Schedule();
            s.Slot = int.Parse(txtID.Text);
            s.DayOfWeeks = dpDOB.Text;
            s.ClassId = getClassID(txtName.Text);
            //s.TeacherId = getTecherID(SubjectComboBox2.Text);
            final.Schedules.Add(s);
            final.SaveChanges();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Schedule s = new Schedule();
            s.Slot = int.Parse(txtID.Text);
            s.DayOfWeeks = dpDOB.Text;
            s.ClassId = getClassID(txtName.Text);
            //s.TeacherId = getTecherID(SubjectComboBox2.Text);
            final.Schedules.Update(s);
            final.SaveChanges();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Schedule s = new Schedule();
            s.Slot = int.Parse(txtID.Text);
            s.DayOfWeeks = dpDOB.Text;
            s.ClassId = getClassID(txtName.Text);
            //s.TeacherId = getTecherID(SubjectComboBox2.Text);
            final.Schedules.Remove(s);
            final.SaveChanges();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            dpDOB.SelectedDate = null;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            ManageDepartment manageDepartment = new ManageDepartment(3);
            manageDepartment.Show();
            this.Close();
        }

        private void ScheduleDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = ScheduleDataGrid.SelectedItem as dynamic;
            if (selected != null)
            {
                txtID.Text = selected.Slot.ToString();
                txtName.Text = selected.ClassName.ToString();
                DateTime.TryParse(selected.DayOfWeeks.ToString(), out DateTime date);
                dpDOB.SelectedDate = date;
                SubjectComboBox2.SelectedValue = selected.Subject.ToString();
            }
        }
       
        public int getClassID(string name)
        {
            return final.Classes.FirstOrDefault(x => x.Name == name).Id;
        }
        //public int getTecherID(string subject)
        //{
        //    return final.Teachers.FirstOrDefault(x => x.Subject == subject).Id;
        //}
        
        private void SubjectComboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedSubject = SubjectComboBox.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedSubject))
            {
                if (selectedSubject.Equals("All"))
                {
                    load();
                }
                else
                {
                    Teacher teacher = final.Teachers.Where(t => t.FullName == selectedSubject).FirstOrDefault();
                    if (teacher != null)
                    {
                        var check = final.Schedules.Where(t => t.TeacherId == teacher.Id).ToList();
                        ScheduleDataGrid.ItemsSource = check.Select(t => new
                        {
                            t.DayOfWeeks,
                            t.Slot,
                            ClassName = GetClassName(t.ClassId),
                            TeacherName = GetTeacherName(t.TeacherId),
                            //Subject = GetSubject(t.TeacherId),
                        }).ToList();
                    }
                }

            }
        }
    }
}
