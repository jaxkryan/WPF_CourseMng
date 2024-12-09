using Finally.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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
    /// Interaction logic for ManageDepartment.xaml
    /// </summary>
    public partial class ManageDepartment : Window
    {
        FinallyContext final = new FinallyContext();
        private int roleId;
        
        public ManageDepartment(int role)
        {
            InitializeComponent();
            loadDepartment();
            roleId=role;
        }
        

        public void loadDepartment()
        {
            if (GetAccountID.Instance.Role == 3)
            {
                ButtonForAdmin.Visibility = Visibility.Visible;
                TxtForAdmin.Visibility = Visibility.Visible;
                viewlist.Visibility= Visibility.Visible;
            }
            else
            {
                ButtonForAdmin.Visibility = Visibility.Collapsed;
                TxtForAdmin.Visibility = Visibility.Collapsed;
                viewlist.Visibility = Visibility.Collapsed;
            }

            var load = final.Departments.ToList();

            ListDepartment.ItemsSource = load.Select(d => new
            {
                d.Id,
                d.Name,
                Subject = d.Id == 1 ? "Biology,Chemistry,Mathematics,Physics" : (d.Id == 2 ? "English,Civic education,Literature,Geography,History" : "None")
            }).ToList();
        }

        private void DetailsButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is System.Windows.Controls.Button button && button.CommandParameter is int Id)
            {
                ManageTeacher teacher = new ManageTeacher(Id, roleId);
                Department department = final.Departments.FirstOrDefault(d => d.Id == Id);
                teacher.Title = "Teacher of Department: " + department.Name;
                teacher.Show();
                this.Close();
            }
        }

        private void clear()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtSubject.Text = "";
        }
        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }

        private void ViewButton_Click(object sender, RoutedEventArgs e)
        {
           ManageStudent manageStudent = new ManageStudent(1);
            manageStudent.Show();
            this.Close();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Department department = new Department();
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Id is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtSubject.Text))
            {
                MessageBox.Show("Subject is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            department.Id = int.Parse(txtId.Text);
            department.Name = txtName.Text;
            var check = final.Departments.Select(t => t.Id).ToList();
            foreach (var c in check)
            {
                if (int.Parse(txtId.Text) == c)
                {
                    MessageBox.Show("You can add the same ID!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
            }
            final.Departments.Add(department);
            final.SaveChanges();
            MessageBox.Show("Add successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            loadDepartment();
            clear();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("TxtId is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtSubject.Text))
            {
                MessageBox.Show("Subject is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Department department = final.Departments.FirstOrDefault(t => t.Id == int.Parse(txtId.Text));
            department.Id = int.Parse(txtId.Text);
            department.Name = txtName.Text;
            if(int.Parse(txtId.Text) <= 0)
            {
                MessageBox.Show("Id must be greater than 0", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var check = final.Departments.Select(t => t.Id).ToList();
            foreach (var c in check)
            {
                if (int.Parse(txtId.Text) == c)
                {
                    MessageBox.Show("You can add the same ID!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
            }
            final.Departments.Update(department);
            if (final.SaveChanges() > 0)
            {
                MessageBox.Show("Update successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                loadDepartment();
                clear();
            }
            else
            {
                MessageBox.Show("Product not found!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("TxtId is empty!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                Department department = final.Departments.FirstOrDefault(t => t.Id == int.Parse(txtId.Text));
                var check = final.Teachers.Select(t => t.DepartmentId == int.Parse(txtId.Text)).ToList();
                if (department != null)
                {
                    if (check == null)
                    {
                        MessageBox.Show("You can delete Department have many teacher in there!", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }

                    final.Departments.Remove(department);
                    if (final.SaveChanges() > 0)
                    {
                        MessageBox.Show("Delete successfully!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                        loadDepartment();
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Delete failed!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid ID!", "Allert", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ManageSchedule manageSchedule = new ManageSchedule(3);
            manageSchedule.Show();
            this.Close();
        }
    }
}
