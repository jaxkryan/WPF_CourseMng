using Finally.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static Azure.Core.HttpHeader;

namespace Finally
{
    /// <summary>
    /// Interaction logic for ViewGrades.xaml
    /// </summary>
    public partial class ViewGrades : Window
    {
        FinallyContext final = new FinallyContext();

        private int classId;
        private int roleID;
        public ViewGrades(int role)
        {
            InitializeComponent();
            load();
            roleID = role;
        }

        public void load()
        {
            var combo = from subject in final.Subjects
                        join grade in final.Grades on subject.Id equals grade.Subject
                        join st in final.Students on grade.StudentId equals st.Id
                        where st.AccountId== GetAccountID.Instance.ID
                        select subject.Name;
            SubjectComboBox.ItemsSource = combo.ToList();
            SubjectComboBox.SelectedIndex = 0;
            string selectedSubject = SubjectComboBox.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedSubject))
            {

                var grd = from sb in final.Subjects
                          join gr in final.Grades on sb.Id equals gr.Subject
                          join gr2 in final.GradeDetails on gr.Grade1 equals gr2.GradeId
                          join st in final.Students on gr.StudentId equals st.Id
                          where sb.Name == selectedSubject && st.AccountId == GetAccountID.Instance.ID
                          select gr2;
                if (grd == null)
                {
                    System.Windows.MessageBox.Show("You do not learn any subject! Let's join new subject!");
                    return;
                }
                GradesDataGrid.ItemsSource = grd.ToList();

            }



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
        private string GetSubject(int? id)
        {
            var check = final.Teachers.ToList();
            foreach (var t in check)
            {
                if (t.Id == id)
                {
                    return t.Address;
                }
            }
            return "";
        }

        private string GetClassName(int? id)
        {
            var check = final.Classes.ToList();
            foreach (var x in check)
            {
                if(x.Id == id)
                {
                    classId =x.Id;
                    return x.Name;
                }    
            }
            return "";
        }

        private bool isAscending = false;

       

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            StudentHome studentHome = new StudentHome();
            studentHome.Show();
            this.Close();
        }

        private void SubjectComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            string selectedSubject = SubjectComboBox.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedSubject))
            {

                var grd = from sb in final.Subjects
                          join gr in final.Grades on sb.Id equals gr.Subject
                          join gr2 in final.GradeDetails on gr.Grade1 equals gr2.GradeId    
                          join st in final.Students on gr.StudentId equals st.Id
                          where sb.Name == selectedSubject && st.AccountId == GetAccountID.Instance.ID
                          select gr2;
                if (grd == null)
                {
                    System.Windows.MessageBox.Show("You do not learn any subject! Let's join new subject!");
                    return;
                }
                GradesDataGrid.ItemsSource = grd.ToList();

            }

        }

        private void ViewButton_Click(object sender, RoutedEventArgs e)
        {
            StudentProfile studentProfile = new StudentProfile();
            studentProfile.Show();
            this.Close();

        }

        private void ViewButton1_Click(object sender, RoutedEventArgs e)
        {
                ViewSchedules viewSchedules = new ViewSchedules();
                viewSchedules.Show();
                this.Close();
        }
    }

   
}

