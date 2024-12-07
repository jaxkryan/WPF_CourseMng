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
    /// Interaction logic for ViewClass2.xaml
    /// </summary>
    public partial class ViewClass2 : Window
    {
        int ID;
        int _scheID;
        FinallyContext final = new FinallyContext();
        public ViewClass2(int classID,int scheID)
        {
            InitializeComponent();
            ID = classID;
            _scheID = scheID;
            load();

        }
        public void load()
        {
            var combo = final.Students.Select(x => x.Address).Distinct().ToList();
            combo.Insert(0, "All");

            AddressComboBox.ItemsSource = combo;
            var studentIds = final.ClassStus
     .Where(x => x.ClassId == ID)
     .Select(x => x.StudentId)
     .ToList();

            // Retrieve the student details for the filtered student IDs
            var students = final.Students
                .Where(x => studentIds.Contains(x.Id))
                .ToList();

            // Map the students to a new list if necessary
            List<Student> st2 = students
                .Select(st => new Student
                {
                    Id = st.Id,
                    Address = st.Address,
                    DateOfBirth = st.DateOfBirth,
                    PhoneNumber = st.PhoneNumber,
                    FullName = st.FullName
                })
                .ToList();

            // Set the ItemsSource of the DataGrid
            StudentDataGrid2.ItemsSource = st2;
        }
        private bool isAscending = false;
        private void SortButton_Click(object sender, RoutedEventArgs e)
        {

            if (isAscending)
            {

                load();

                SortButton.Content = "SortDesc";
            }
            else
            {
                var students = final.ClassStus.Where(x => x.ClassId == ID).ToList();
                List<Student> st2 = new List<Student>();
                foreach (var student in students)
                {
                    var st3 = final.Students.Where(x => x.Id == student.StudentId).ToList();
                    foreach (var student2 in st3)
                    {
                        st2.Add(final.Students.FirstOrDefault(x => x.Id == student2.Id));
                    }
                }
                StudentDataGrid2.ItemsSource = st2
                                          .OrderByDescending(x => x.Id)
                                          .ToList();

                SortButton.Content = "SortAsc";
            }

            isAscending = !isAscending;
        }
        private void StudentDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (StudentDataGrid2.SelectedItem is Student selected)
            {
                DateTime.TryParse(selected.DateOfBirth.ToString(), out DateTime date);
                txtName.Text = selected.FullName;
                dpDOB.SelectedDate = date;
                txtID.Text = selected.Id.ToString();


            }
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            ViewSchedule2 viewSchedule2 = new ViewSchedule2();
            viewSchedule2.Show();
            this.Close();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var students = final.ClassStus.Where(x => x.ClassId == ID).ToList();
            List<Student> st2 = new List<Student>();
            foreach (var student in students)
            {
                var st3 = final.Students.Where(x => x.Id == student.StudentId).ToList();
                foreach (var student2 in st3)
                {
                    st2.Add(final.Students.FirstOrDefault(x => x.Id == student2.Id));
                }
            }
            StudentDataGrid2.ItemsSource = st2.Where(t => t.FullName.Contains(txtSearch.Text)).ToList();
        }

        private void AddressComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            string selectedAddress = AddressComboBox.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedAddress))
            {
                if (selectedAddress.Equals("All"))
                {
                    load();
                }
                else
                {
                    var students = final.ClassStus.Where(x => x.ClassId == ID).ToList();
                    List<Student> st2 = new List<Student>();
                    foreach (var student in students)
                    {
                        var st3 = final.Students.Where(x => x.Id == student.StudentId).ToList();
                        foreach (var student2 in st3)
                        {
                            st2.Add(final.Students.FirstOrDefault(x => x.Id == student2.Id));
                        }
                    }
                    StudentDataGrid2.ItemsSource = st2.Where(x => x.Address == selectedAddress).ToList();
                }

            }

        }

        private void btnAttend_Click(object sender, RoutedEventArgs e)
        {
            if (txtID.Text != null)
            {
                int idstudent = int.Parse(txtID.Text);
               ScheduleStu sc= final.ScheduleStus.FirstOrDefault(x => x.ScheduleId == _scheID && x.StudentId == idstudent);
                if (sc != null)
                {
                    sc.Status = 1;
                    final.ScheduleStus.Update(sc);
                    final.SaveChanges();
                    MessageBox.Show("Attend successful!");
                }
                else
                {
                    MessageBox.Show("Student  does not exist!  "+_scheID+"&"+txtID.Text);
                }
               
            }
           

        }
    }
}
