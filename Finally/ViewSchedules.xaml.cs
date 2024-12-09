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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Finally
{
    /// <summary>
    /// Interaction logic for ViewSchedules.xaml
    /// </summary>
    public partial class ViewSchedules : Window
    {
        FinallyContext context = new FinallyContext();

        private int ClassID;
        private int roleID;
        public ViewSchedules()
        {
            DateTime today = DateTime.Today;
            InitializeComponent();
           AddWeekComboBoxes(today);
            AddRecentYears();
         
           
           

        
        // Calculate the start and end of the week
        DateTime startOfWeek = GetStartOfWeek(today);
        DateTime endOfWeek = GetEndOfWeek(today);
            load(startOfWeek, endOfWeek);
        }
            private void AddWeekComboBoxes(DateTime today)
            {
                
                int year = today.Year;
                int month = today.Month;

                DateTime firstDayOfMonth = new DateTime(year, month, 1);
                DateTime firstMonday = GetFirstMonday(firstDayOfMonth);
                int weeksInMonth = GetWeeksInMonth(year, month);



            

                for (int j = 0; j < weeksInMonth && j < 4; j++)
                {
                    DateTime startOfWeek = firstMonday.AddDays(7 * j);
                    DateTime endOfWeek = startOfWeek.AddDays(6);
                    if (startOfWeek.Month != month)
                    {
                        startOfWeek = firstDayOfMonth;
                    }
                    if (endOfWeek.Month != month)
                    {
                        endOfWeek = new DateTime(year, month, DateTime.DaysInMonth(year, month));
                    }
                    string weekRange = $"{startOfWeek.ToString("dd/MM")} To {endOfWeek.ToString("dd/MM")}";
                ComboBoxItem comboBoxItem = new ComboBoxItem { Content = weekRange };
                comboBoxItem.Tag = new Tuple<DateTime, DateTime>(startOfWeek, endOfWeek); // Store week range
                cbxWeek.Items.Add(comboBoxItem);
            }

            // Select the ComboBoxItem that contains the current date
            foreach (ComboBoxItem item in cbxWeek.Items)
            {
                var (startOfWeek, endOfWeek) = (Tuple<DateTime, DateTime>)item.Tag;
                if (today >= startOfWeek && today <= endOfWeek)
                {
                    cbxWeek.SelectedItem = item;
                    break;
                }
            }



        }

        private DateTime GetFirstMonday(DateTime date)
        {
            while (date.DayOfWeek != DayOfWeek.Monday)
            {
                date = date.AddDays(1);
            }
            return date;
        }

        private int GetWeeksInMonth(int year, int month)
        {
            DateTime firstDay = new DateTime(year, month, 1);
            DateTime lastDay = firstDay.AddMonths(1).AddDays(-1);
            int daysInMonth = (lastDay - firstDay).Days + 1;
            return (int)Math.Ceiling(daysInMonth / 7.0);
        }
    
    public static DateTime GetStartOfWeek(DateTime date)
        {
            int diff = date.DayOfWeek - DayOfWeek.Monday;
            if (diff < 0)
            {
                diff += 7;
            }
            return date.AddDays(-1 * diff).Date;
        }

        public static DateTime GetEndOfWeek(DateTime date)
        {
            int diff = DayOfWeek.Sunday - date.DayOfWeek;
            if (diff < 0)
            {
                diff += 7;
            }
            return date.AddDays(diff).Date;
        }
        private void AddRecentYears()
        {
            // Get the current year
            int currentYear = DateTime.Today.Year;

            // Add the current year and the two previous years to the ComboBox
            for (int i = 0; i < 3; i++)
            {
                int year = currentYear - i;
                ComboBoxItem comboBoxItem = new ComboBoxItem { Content = year.ToString() };
                YearComboBox.Items.Add(comboBoxItem);
            }

            // Optionally, select the current year
            YearComboBox.SelectedIndex = 0;
        }
        public void load(DateTime startDate, DateTime endDate)
        {
            

            // Truy vấn với điều kiện ngày trong khoảng
            var schedules = from schedule in context.Schedules
                            join schedustu in context.ScheduleStus on schedule.ScheduleId equals schedustu.ScheduleId
                            join schedustu2 in context.Students on schedustu.StudentId equals schedustu2.Id
                            where schedustu2.AccountId == GetAccountID.Instance.ID
                                 
                            select new ViewSchedule
                            {
                                Slot = schedule.Slot,
                                DayOfWeeks = schedule.DayOfWeeks,
                                Subject = schedule.Subject,
                                Class = schedule.Class,
                                status = schedustu.Status,
                                slot = "Slot " + schedule.Slot
                            };
            var schlist = schedules
     .AsEnumerable() // Chuyển đổi sang IEnumerable để lọc trong bộ nhớ
     .Where(s => DateTime.TryParse(s.DayOfWeeks, out DateTime dayOfWeek) &&
                 dayOfWeek >= startDate && dayOfWeek <= endDate)
     .Select(s => new ViewSchedule
     {
         Slot = s.Slot,
         DayOfWeeks = s.DayOfWeeks,
         Subject = s.Subject,
         Class = s.Class,
         status = s.status,
         slot = s.slot
     })
     .ToList();
            for (int i=0;i< schlist.Count();i++)
            {
                string status = "";
                if (schlist[i].status==1)
                {
                    status = "Present";
                }else if (schlist[i].status==2)
                {
                    status = "Absent";
                }
                else
                {
                    status = "Not yet";
                }
                load2(schlist[i].Slot-1, DayOfWeekToInt(DateTime.Parse(schlist[i].DayOfWeeks)), schlist[i].Subject.Name, schlist[i].Class.Name, status);
            }
            DateTime d = DateTime.Now;
            

        }
        public int DayOfWeekToInt(DateTime dateTime)
        {
            // Lấy ngày trong tuần từ đối tượng DateTime
            // DayOfWeek trả về giá trị Enum từ 0 (Sunday) đến 6 (Saturday)
            // Chúng ta cần ánh xạ giá trị này thành 0 (Monday) đến 6 (Sunday)
            int dayOfWeek = (int)dateTime.DayOfWeek;

            // Chuyển đổi để Monday là 0, Sunday là 6
            int result = (dayOfWeek + 6) % 7;

            return result;
        }
        public void load2(int? slot, int _Day,string sub,string clas, string status)
        {
           if(slot == 0 && _Day == 0)
            {
                slot1.Text = "Slot1";
                Subject1.Text = sub;
                Class1.Content = clas;
                status1.Text = status;
                hour1.Text = "7:00-9:50";
            }else if(slot == 0 && _Day == 1)
            {
                slot2.Text = "Slot1";
                Subject2.Text = sub;
                Class2.Content = clas;
                status2.Text = status;
                hour2.Text = "7:00-9:50";
            }
            else if (slot == 0 && _Day == 2)
            {
                slot3.Text = "Slot1";
                Subject3.Text = sub;
                Class3.Content = clas;
                status3.Text = status;
                hour3.Text = "7:00-9:50";
            }
            else if (slot == 0 && _Day == 3)
            {
                slot4.Text = "Slot1";
                Subject4.Text = sub;
                Class4.Content = clas;
                status4.Text = status;
                hour4.Text = "7:00-9:50";
            }
            else if (slot == 0 && _Day == 4)
            {
                slot5.Text = "Slot1";
                Subject5.Text = sub;
                Class5.Content = clas;
                status5.Text = status;
                hour5.Text = "7:00-9:50";
            }
            else if (slot == 0 && _Day == 5)
            {
                slot6.Text = "Slot1";
                Subject6.Text = sub;
                Class6.Content = clas;
                status6.Text = status;
                hour6.Text = "7:00-9:50";
            }
            else if (slot == 0 && _Day == 6)
            {
                slot7.Text = "Slot2";
                Subject7.Text = sub;
                Class7.Content = clas;
                status7.Text = status;
                hour7.Text = "10:00-12:50";
            }
            else if (slot == 1 && _Day == 0)
            {
                slot8.Text = "Slot2";
                Subject8.Text = sub;
                Class8.Content = clas;
                status8.Text = status;
                hour8.Text = "10:00-12:50";
            }
            else if (slot == 1 && _Day == 1)
            {
                slot9.Text = "Slot2";
                Subject9.Text = sub;
                Class9.Content = clas;
                status9.Text = status;
                hour9.Text = "10:00-12:50";
            }
            else if (slot == 1 && _Day == 2)
            {
                slot10.Text = "Slot2";
                Subject10.Text = sub;
                Class10.Content = clas;
                status10.Text = status;
                hour10.Text = "10:00-12:50";
            }
            else if (slot == 1 && _Day == 3)
            {
                slot11.Text = "Slot2";
                Subject11.Text = sub;
                Class11.Content = clas;
                status11.Text = status;
                hour11.Text = "10:00-12:50";
            }
            else if (slot == 1 && _Day == 4)
            {
                slot12.Text = "Slot2";
                Subject12.Text = sub;
                Class12.Content = clas;
                status12.Text = status;
                hour12.Text = "10:00-12:50";
            }
            else if (slot == 1 && _Day == 5)
            {
                slot13.Text = "Slot2";
                Subject13.Text = sub;
                Class13.Content = clas;
                status13.Text = status;
                hour13.Text = "10:00-12:50";
            }
            else if (slot == 1 && _Day == 6)
            {
                slot14.Text = "Slot3";
                Subject14.Text = sub;
                Class14.Content = clas;
                status14.Text = status;
                hour14.Text = "13:00-15:50";
            }
            else if (slot == 2 && _Day == 0)
            {
                slot15.Text = "Slot3";
                Subject15.Text = sub;
                Class15.Content = clas;
                status15.Text = status;
                hour15.Text = "13:00-15:50";
            }
            else if (slot == 2 && _Day == 1)
            {
                slot16.Text = "Slot3";
                Subject16.Text = sub;
                Class16.Content = clas;
                status16.Text = status;
                hour16.Text = "13:00-15:50";
            }
            else if (slot == 2 && _Day == 2)
            {
                slot17.Text = "Slot3";
                Subject17.Text = sub;
                Class17.Content = clas;
                status17.Text = status;
                hour17.Text = "13:00-15:50";
            }
            else if (slot == 2 && _Day == 3)
            {
                slot18.Text = "Slot3";
                Subject18.Text = sub;
                Class18.Content = clas;
                status18.Text = status;
                hour18.Text = "13:00-15:50";
            }
            else if (slot == 2 && _Day == 4)
            {
                slot19.Text = "Slot3";
                Subject19.Text = sub;
                Class19.Content = clas;
                status19.Text = status;
                hour19.Text = "13:00-15:50";
            }
            else if (slot ==2 && _Day == 5)
            {
                slot20.Text = "Slot3";
                Subject20.Text = sub;
                Class20.Content = clas;
                status20.Text = status;
                hour20.Text = "13:00-15:50";
            }
            else if (slot ==2 && _Day == 6)
            {
                slot21.Text = "Slot4";
                Subject21.Text = sub;
                Class21.Content = clas;
                status21.Text = status;
                hour21.Text = "16:00-18:50";
            }
            else if (slot == 3 && _Day == 0)
            {
                slot22.Text = "Slot4";
                Subject22.Text = sub;
                Class22.Content = clas;
                status22.Text = status;
                hour22.Text = "16:00-18:50";
            }
            else if (slot == 3 && _Day == 1)
            {
                slot23.Text = "Slot4";
                Subject23.Text = sub;
                Class23.Content = clas;
                status23.Text = status;
                hour23.Text = "16:00-18:50";
            }
            else if (slot == 3 && _Day == 2)
            {
                slot24.Text = "Slot4";
                Subject24.Text = sub;
                Class24.Content = clas;
                status24.Text = status;
                hour24.Text = "16:00-18:50";
            }
            else if (slot == 3 && _Day == 3)
            {
                slot25.Text = "Slot4";
                Subject25.Text = sub;
                Class25.Content = clas;
                status25.Text = status;
                hour25.Text = "16:00-18:50";
            }
            else if (slot == 3 && _Day == 4)
            {
                slot26.Text = "Slot4";
                Subject26.Text = sub;
                Class26.Content = clas;
                status26.Text = status;
                hour26.Text = "16:00-18:50";
            }
            else if (slot == 3 && _Day == 5)
            {
                slot27.Text = "Slot4";
                Subject27.Text = sub;
                Class27.Content = clas;
                status27.Text = status;
                hour27.Text = "16:00-18:50";
            }
            else if (slot == 3 && _Day == 6)
            {
                slot28.Text = "Slot4";
                Subject28.Text = sub;
                Class28.Content = clas;
                status28.Text = status;
                hour28.Text = "16:00-18:50";
            }
        }
        public void clear()
        {
            
                slot1.Text = "";
                Subject1.Text = "";
                Class1.Content = "";
                status1.Text = "";
                hour1.Text = "";
            
                slot2.Text = "";
                Subject2.Text = "";
                Class2.Content = "";
                status2.Text = "";
                hour2.Text = "";
           
                slot3.Text = "";
                Subject3.Text = "";
                Class3.Content = "";
                status3.Text = "";
                hour3.Text = "";
            
                slot4.Text = "";
                Subject4.Text = "";
                Class4.Content = "";
                status4.Text = "";
                hour4.Text = "";
           
                slot5.Text = "";
                Subject5.Text = "";
                Class5.Content = "";
                status5.Text = "";
                hour5.Text = "";
            
                slot6.Text = "";
                Subject6.Text = "";
                Class6.Content = "";
                status6.Text = "";
                hour6.Text = "";
            
                slot7.Text = "";
                Subject7.Text = "";
                Class7.Content = "";
                status7.Text = "";
                hour7.Text = "";
           
                slot8.Text = "";
                Subject8.Text = "";
                Class8.Content = "";
                status8.Text = "";
                hour8.Text = "";
           
                slot9.Text = "";
                Subject9.Text = "";
                Class9.Content = "";
                status9.Text = "";
                hour9.Text = "";
            
                slot10.Text = "";
                Subject10.Text = "";
                Class10.Content = "";
                status10.Text = "";
                hour10.Text = "";
            
                slot11.Text = "";
                Subject11.Text = "";
                Class11.Content = "";
                status11.Text = "";
                hour11.Text = "";
            
                slot12.Text = "";
                Subject12.Text = "";
                Class12.Content = "";
                status12.Text = "";
                hour12.Text = "";
            
                slot13.Text = "";
                Subject13.Text = "";
                Class13.Content = "";
                status13.Text = "";
                hour13.Text = "";
           
                slot14.Text = "";
                Subject14.Text = "";
                Class14.Content = "";
                status14.Text = "";
                hour14.Text = "";
            
                slot15.Text = "";
                Subject15.Text = "";
                Class15.Content = "";
                status15.Text = "";
                hour15.Text = "";
            
                slot16.Text = "";
                Subject16.Text = "";
                Class16.Content = "";
                status16.Text = "";
                hour16.Text = "";
            
                slot17.Text = "";
                Subject17.Text = "";
                Class17.Content = "";
                status17.Text = "";
                hour17.Text = "";
            
                slot18.Text = "";
                Subject18.Text = "";
                Class18.Content = "";
                status18.Text = "";
                hour18.Text = "";
            
                slot19.Text = "";
                Subject19.Text = "";
                Class19.Content = "";
                status19.Text = "";
                hour19.Text = "";
            
                slot20.Text = "";
                Subject20.Text = "";
                Class20.Content = "";
                status20.Text = "";
                hour20.Text = "";
           
                slot21.Text = "";
                Subject21.Text = "";
                Class21.Content = "";
                status21.Text = "";
                hour21.Text = "";
           
                slot22.Text = "";
                Subject22.Text = "";
                Class22.Content = "";
                status22.Text = "";
                hour22.Text = "";
           
                slot23.Text = "";
                Subject23.Text = "";
                Class23.Content = "";
                status23.Text = "";
                hour23.Text = "";
           
                slot24.Text = "";
                Subject24.Text = "";
                Class24.Content = "";
                status24.Text = "";
                hour24.Text = "";
           
                slot25.Text = "";
                Subject25.Text = "";
                Class25.Content = "";
                status25.Text = "";
                hour25.Text = "";
           
                slot26.Text = "";
                Subject26.Text = "";
                Class26.Content = "";
                status26.Text = "";
                hour26.Text = "";
           
                slot27.Text = "";
                Subject27.Text = "";
                Class27.Content = "";
                status27.Text = "";
                hour27.Text = "";
            
                slot28.Text = "";
                Subject28.Text = "";
                Class28.Content = "";
                status28.Text = "";
                hour28.Text = "";
            
        }
        
        
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            StudentHome studentHome = new StudentHome();
            studentHome.Show();
            this.Close();
        }



        private void YearComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (YearComboBox.SelectedItem is ComboBoxItem selectedItem)
            //{
            //    // Lấy năm từ nội dung của mục được chọn
            //    if (int.TryParse(selectedItem.Content.ToString(), out int selectedYear))
            //    {
            //        // Tìm ngày đầu tiên của tuần đầu tiên trong năm được chọn
            //        DateTime firstDayOfYear = new DateTime(selectedYear, 1, 1);
            //        DateTime firstWeekStart = GetFirstWeekStart(firstDayOfYear);

            //        // Hiển thị thông báo với ngày đầu tiên của tuần đầu tiên
            //        load(firstDayOfYear, firstWeekStart);
            //        AddWeekComboBoxes(firstDayOfYear);

            //        // Thực hiện các hành động khác với ngày đầu tiên của tuần đầu tiên
            //        // Ví dụ: Cập nhật dữ liệu, thay đổi giao diện, v.v.
            //    }
            //}
        }
        private DateTime GetFirstWeekStart(DateTime date)
        {
            // Lấy ngày đầu tiên của tuần theo chuẩn ISO (tuần bắt đầu từ thứ Hai)
            DateTime jan1 = new DateTime(date.Year, 1, 1);
            int daysOffset = (int)DayOfWeek.Monday - (int)jan1.DayOfWeek;
            DateTime firstMonday = jan1.AddDays(daysOffset);

            // Nếu ngày 1 tháng 1 là sau thứ Hai, tuần đầu tiên sẽ bắt đầu vào tuần tiếp theo
            if (jan1.DayOfWeek > DayOfWeek.Monday)
            {
                firstMonday = firstMonday.AddDays(7);
            }

            return firstMonday;
        }

        private void cbxWeek_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            clear();
            if (cbxWeek.SelectedItem is ComboBoxItem selectedItem)
            {
                
                // Lấy nội dung của mục được chọn
                string weekRange = selectedItem.Content.ToString();

                // Hiển thị thông báo với tuần được chọn

                // Lấy thông tin tuần từ thuộc tính Tag nếu cần
                if (selectedItem.Tag is Tuple<DateTime, DateTime> weekDates)
                {
                    DateTime startOfWeek = weekDates.Item1;
                    DateTime endOfWeek = weekDates.Item2;
                    load(startOfWeek, endOfWeek);

                    // Thực hiện các hành động khác với thông tin tuần
                    // Ví dụ: Cập nhật dữ liệu, thay đổi giao diện, v.v.
                    // Cập nhật UI hoặc thực hiện hành động khác
                }
            }
        }

        private void Class1_Click(object sender, RoutedEventArgs e)
        {
            string clas = Class1.Content.ToString();
            int id =context.Classes.FirstOrDefault(x=>x.Name==clas).Id;
            ViewClass viewClass = new ViewClass(id);
            viewClass.Show();
            this.Close();
    }

        private void Class2_Click(object sender, RoutedEventArgs e)
        {
            string clas = Class2.Content.ToString();
            int id = context.Classes.FirstOrDefault(x => x.Name == clas).Id;
            ViewClass viewClass = new ViewClass(id);
            viewClass.Show();
            this.Close();
        }

        private void Class3_Click(object sender, RoutedEventArgs e)
        {
            string clas = Class3.Content.ToString();
            int id = context.Classes.FirstOrDefault(x => x.Name == clas).Id;
            ViewClass viewClass = new ViewClass(id);
            viewClass.Show();
            this.Close();
        }

        private void Class4_Click(object sender, RoutedEventArgs e)
        {
            string clas = Class4.Content.ToString();
            int id = context.Classes.FirstOrDefault(x => x.Name == clas).Id;
            ViewClass viewClass = new ViewClass(id);
            viewClass.Show();
            this.Close();
        }

        private void Class5_Click(object sender, RoutedEventArgs e)
        {
            string clas = Class5.Content.ToString();
            int id = context.Classes.FirstOrDefault(x => x.Name == clas).Id;
            ViewClass viewClass = new ViewClass(id);
            viewClass.Show();
            this.Close();
        }

        private void Class6_Click(object sender, RoutedEventArgs e)
        {
            string clas = Class6.Content.ToString();
            int id = context.Classes.FirstOrDefault(x => x.Name == clas).Id;
            ViewClass viewClass = new ViewClass(id);
            viewClass.Show();
            this.Close();
        }

        private void Class7_Click(object sender, RoutedEventArgs e)
        {
            string clas = Class7.Content.ToString();
            int id = context.Classes.FirstOrDefault(x => x.Name == clas).Id;
            ViewClass viewClass = new ViewClass(id);
            viewClass.Show();
            this.Close();
        }

        private void Class8_Click(object sender, RoutedEventArgs e)
        {
            string clas = Class8.Content.ToString();
            int id = context.Classes.FirstOrDefault(x => x.Name == clas).Id;
            ViewClass viewClass = new ViewClass(id);
            viewClass.Show();
            this.Close();
        }

        private void Class9_Click(object sender, RoutedEventArgs e)
        {
            string clas = Class9.Content.ToString();
            int id = context.Classes.FirstOrDefault(x => x.Name == clas).Id;
            ViewClass viewClass = new ViewClass(id);
            viewClass.Show();
            this.Close();
        }

        private void Class10_Click(object sender, RoutedEventArgs e)
        {
            string clas = Class10.Content.ToString();
            int id = context.Classes.FirstOrDefault(x => x.Name == clas).Id;
            ViewClass viewClass = new ViewClass(id);
            viewClass.Show();
            this.Close();
        }

        private void Class11_Click(object sender, RoutedEventArgs e)
        {
            string clas = Class11.Content.ToString();
            int id = context.Classes.FirstOrDefault(x => x.Name == clas).Id;
            ViewClass viewClass = new ViewClass(id);
            viewClass.Show();
            this.Close();
        }

        private void Class12_Click(object sender, RoutedEventArgs e)
        {
            string clas = Class12.Content.ToString();
            int id = context.Classes.FirstOrDefault(x => x.Name == clas).Id;
            ViewClass viewClass = new ViewClass(id);
            viewClass.Show();
            this.Close();
        }

        private void Class13_Click(object sender, RoutedEventArgs e)
        {
            string clas = Class13.Content.ToString();
            int id = context.Classes.FirstOrDefault(x => x.Name == clas).Id;
            ViewClass viewClass = new ViewClass(id);
            viewClass.Show();
            this.Close();
        }

        private void Class14_Click(object sender, RoutedEventArgs e)
        {
            string clas = Class14.Content.ToString();
            int id = context.Classes.FirstOrDefault(x => x.Name == clas).Id;
            ViewClass viewClass = new ViewClass(id);
            viewClass.Show();
            this.Close();
        }

        private void Class15_Click(object sender, RoutedEventArgs e)
        {
            string clas = Class15.Content.ToString();
            int id = context.Classes.FirstOrDefault(x => x.Name == clas).Id;
            ViewClass viewClass = new ViewClass(id);
            viewClass.Show();
            this.Close();
        }

        private void Class16_Click(object sender, RoutedEventArgs e)
        {
            string clas = Class16.Content.ToString();
            int id = context.Classes.FirstOrDefault(x => x.Name == clas).Id;
            ViewClass viewClass = new ViewClass(id);
            viewClass.Show();
            this.Close();
        }

        private void Class17_Click(object sender, RoutedEventArgs e)
        {
            string clas = Class17.Content.ToString();
            int id = context.Classes.FirstOrDefault(x => x.Name == clas).Id;
            ViewClass viewClass = new ViewClass(id);
            viewClass.Show();
            this.Close();
        }

        private void Class18_Click(object sender, RoutedEventArgs e)
        {
            string clas = Class18.Content.ToString();
            int id = context.Classes.FirstOrDefault(x => x.Name == clas).Id;
            ViewClass viewClass = new ViewClass(id);
            viewClass.Show();
            this.Close();
        }

        private void Class19_Click(object sender, RoutedEventArgs e)
        {
            string clas = Class19.Content.ToString();
            int id = context.Classes.FirstOrDefault(x => x.Name == clas).Id;
            ViewClass viewClass = new ViewClass(id);
            viewClass.Show();
            this.Close();
        }

        private void Class20_Click(object sender, RoutedEventArgs e)
        {
            string clas = Class20.Content.ToString();
            int id = context.Classes.FirstOrDefault(x => x.Name == clas).Id;
            ViewClass viewClass = new ViewClass(id);
            viewClass.Show();
            this.Close();
        }

        private void Class21_Click(object sender, RoutedEventArgs e)
        {
            string clas = Class21.Content.ToString();
            int id = context.Classes.FirstOrDefault(x => x.Name == clas).Id;
            ViewClass viewClass = new ViewClass(id);
            viewClass.Show();
            this.Close();
        }

        private void Class22_Click(object sender, RoutedEventArgs e)
        {
            string clas = Class22.Content.ToString();
            int id = context.Classes.FirstOrDefault(x => x.Name == clas).Id;
            ViewClass viewClass = new ViewClass(id);
            viewClass.Show();
            this.Close();
        }

        private void Class23_Click(object sender, RoutedEventArgs e)
        {
            string clas = Class23.Content.ToString();
            int id = context.Classes.FirstOrDefault(x => x.Name == clas).Id;
            ViewClass viewClass = new ViewClass(id);
            viewClass.Show();
            this.Close();
        }

        private void Class24_Click(object sender, RoutedEventArgs e)
        {
            string clas = Class24.Content.ToString();
            int id = context.Classes.FirstOrDefault(x => x.Name == clas).Id;
            ViewClass viewClass = new ViewClass(id);
            viewClass.Show();
            this.Close();
        }

        private void Class25_Click(object sender, RoutedEventArgs e)
        {
            string clas = Class25.Content.ToString();
            int id = context.Classes.FirstOrDefault(x => x.Name == clas).Id;
            ViewClass viewClass = new ViewClass(id);
            viewClass.Show();
            this.Close();
        }

        private void Class26_Click(object sender, RoutedEventArgs e)
        {
            string clas = Class26.Content.ToString();
            int id = context.Classes.FirstOrDefault(x => x.Name == clas).Id;
            ViewClass viewClass = new ViewClass(id);
            viewClass.Show();
            this.Close();
        }

        private void Class27_Click(object sender, RoutedEventArgs e)
        {
            string clas = Class27.Content.ToString();
            int id = context.Classes.FirstOrDefault(x => x.Name == clas).Id;
            ViewClass viewClass = new ViewClass(id);
            viewClass.Show();
            this.Close();
        }

        private void Class28_Click(object sender, RoutedEventArgs e)
        {
            string clas = Class28.Content.ToString();
            int id = context.Classes.FirstOrDefault(x => x.Name == clas).Id;
            ViewClass viewClass = new ViewClass(id);
            viewClass.Show();
            this.Close();
        }
    }
}
