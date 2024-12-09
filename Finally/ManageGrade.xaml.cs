using Finally.Models;
using Microsoft.Win32;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for ManageGrade.xaml
    /// </summary>
    public partial class ManageGrade : Window
    {
        FinallyContext final = new FinallyContext();
        public ManageGrade()
        {
            InitializeComponent();
        }

      

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TeacherHome teacherHome = new TeacherHome();    
            teacherHome.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                DefaultExt = ".xlsx",
                Filter = "Excel Files|*.xlsx;*.xls"
            };

            var browseFile = openFile.ShowDialog();
            if (browseFile == true)
            {
                string filepath = openFile.FileName;
               

                DataTable dt = new DataTable();
                dt.Columns.Add("gradeID");
                dt.Columns.Add("PresentScore");
                dt.Columns.Add("LabScore");
                dt.Columns.Add("PTScore");
                dt.Columns.Add("FEScore");
                dt.Columns.Add("OverallScore");
                dt.Columns.Add("Studentid");
                dt.Columns.Add("Subjectid");
                dt.Columns.Add("Classid");
                try
                {
                    var package = new ExcelPackage(new System.IO.FileInfo(filepath));
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    for(int i=worksheet.Dimension.Start.Row; i <= worksheet.Dimension.End.Row; i++)
                    {
                        try
                        {
                            int j = 1;
                            double gradeID = (double)worksheet.Cells[i, j++].Value;
                            double PresentScore = (double)worksheet.Cells[i, j++].Value;
                            double LabScore = (double)worksheet.Cells[i, j++].Value;
                            double PTScore = (double)worksheet.Cells[i, j++].Value;
                            double FEScore = (double)worksheet.Cells[i, j++].Value;
                            double OverallScore = (double)worksheet.Cells[i, j++].Value;
                            double Studentid = (double)worksheet.Cells[i, j++].Value;
                            double Subjectid = (double)worksheet.Cells[i, j++].Value;
                            double Classid = (double)worksheet.Cells[i, j++].Value;
                           
                            
                            dt.Rows.Add(gradeID, PresentScore, LabScore, PTScore, FEScore, OverallScore, Studentid, Subjectid, Classid);
                        }catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }catch(Exception ex2)
                {
                    MessageBox.Show(ex2.ToString());
                }
                GradesDataGrid.ItemsSource=dt.DefaultView;


            }
        }

       


        private void btnImport_Click(object sender, RoutedEventArgs e)
        {
            DateOnly? date = DateOnly.FromDateTime(DateTime.Now);
            DataTable dt = ((DataView)GradesDataGrid.ItemsSource).ToTable();
            
            var teacherID = final.Teachers.FirstOrDefault(x => x.AccountId == GetAccountID.Instance.ID).Id;
            using (var context = new FinallyContext())
            {
                foreach (DataRow row in dt.Rows)
                {
                    var gradeID = final.GradeDetails.Max(x => x.GradeId);
                    var grade = new GradeDetail()
                    {

                        GradeId = gradeID+1,
                        PresentScore = Convert.ToDecimal(row["PresentScore"]),
                        LabScore = Convert.ToDecimal(row["LabScore"]),
                        Ptscore = Convert.ToDecimal(row["PTScore"]),
                        Fescore = Convert.ToDecimal(row["FEScore"]),
                        OverallScore = Convert.ToDecimal(row["OverallScore"]),
                      
                    };

                    context.GradeDetails.Add(grade);
                    context.SaveChanges();
                    var grade1 = final.GradeDetails.Max(x=>x.GradeId);
                    var grade2 = new Grade()
                    {
                        StudentId = Convert.ToInt32(row["Studentid"]),
                        Subject = Convert.ToInt32(row["Subjectid"]),
                        TeacherId = teacherID,
                        Grade1 = grade1,
                        DayOfGrade = date,
                        ClassId= Convert.ToInt32(row["Classid"])
                    };
                    context.Grades.Add(grade2 );
                    context.SaveChanges();
                }
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Data imported successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting data: " + ex.Message);
                }
            }
        }

        private void GradesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
