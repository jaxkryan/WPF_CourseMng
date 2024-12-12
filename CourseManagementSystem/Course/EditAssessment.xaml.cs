using DataAccessLayer;
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
    /// Interaction logic for EditAssessment.xaml
    /// </summary>
    public partial class EditAssessment : Window
    {
        public EditAssessment()
        {
            InitializeComponent();
        }

        private int assessmentId;
        private AssessmentsDAO assessmentsDAO;

        public EditAssessment(int assessmentId)
        {
            InitializeComponent();
            this.assessmentId = assessmentId;
            assessmentsDAO = new AssessmentsDAO();
            LoadAssessment();
        }

        private void LoadAssessment()
        {
            var assessment = assessmentsDAO.GetAssessmentById(assessmentId);
            if (assessment != null)
            {
                txtType.Text = assessment.Type;
                txtName.Text = assessment.Name;
                txtPercent.Text = assessment.Percent.ToString();
                txtStatus.Text = assessment.Status.ToString();
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var assessment = assessmentsDAO.GetAssessmentById(assessmentId);
            if (assessment != null)
            {
                assessment.Type = txtType.Text;
                assessment.Name = txtName.Text;
                if (double.TryParse(txtPercent.Text, out double percent))
                {
                    assessment.Percent = percent;
                }
                if (int.TryParse(txtStatus.Text, out int status))
                {
                    assessment.Status = status;
                }

                assessmentsDAO.UpdateAssessment(assessment);
                DialogResult = true;
                Close();
            }
            else
            {
                MessageBox.Show("Assessment not found.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
