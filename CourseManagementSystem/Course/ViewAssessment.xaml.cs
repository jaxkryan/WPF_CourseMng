﻿using BusinessObjects;
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
    /// Interaction logic for ViewAssessment.xaml
    /// </summary>
    public partial class ViewAssessment : Window
    {
        private int courseId;
        public ViewAssessment(int courseId)
        {
            InitializeComponent();
            this.courseId = courseId;
            LoadAssessment();
        }
        private void LoadAssessment()
        {
            using (var context = new CourseManagementDbContext())
            {
                var assessments = context.Assessments.Where(a => a.CourseId == courseId).ToList();
                dgAssessments.ItemsSource = assessments;
            }
        }
        private void btnEditAssessment_Click(object sender, RoutedEventArgs e)
        {
            if (dgAssessments.SelectedItem is Assessment selectedAssessment)
            {
                var editAssessmentWindow = new EditAssessment(selectedAssessment.Id);
                if (editAssessmentWindow.ShowDialog() == true)
                {
                    LoadAssessment();
                }
            }
            else
            {
                MessageBox.Show("Please select an assessment to edit.", "No Selection", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnAddAssessment_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new CourseManagementDbContext())
            {
                var totalPercent = context.Assessments
                                          .Where(a => a.CourseId == courseId)
                                          .Sum(a => a.Percent);

                if (totalPercent >= 1)
                {
                    MessageBox.Show("The total percentage of assessments for this course is already 100%. You cannot add more assessments.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    var addAssessmentWindow = new AddAssessment(courseId);
                    addAssessmentWindow.ShowDialog();
                    LoadAssessment();
                }
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
