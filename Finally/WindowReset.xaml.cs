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
    /// Interaction logic for WindowReset.xaml
    /// </summary>
    public partial class WindowReset : Window
    {
        FinallyContext final = new FinallyContext();
        public WindowReset()
        {
            InitializeComponent();
        }
        public string GenerateCode()
        {
            string rs = "";
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                rs += random.Next(0, 9);
            }
            return rs;
        }
        public void SendCodeEmail(string email, string code)
        {
            try
            {
                EmailUtil.SendEmail(email, "Email confirmation code", code);
                changePass(email, code);
                MessageBox.Show("Email sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email. Error: " + ex.Message);
            }
        }
        public void changePass(string email, string pass)
        {
            var x = final.Accounts.FirstOrDefault(c => c.Email == email);
            if (x != null)
            {
                x.Password = pass;
                final.Accounts.Update(x);
                final.SaveChanges();
            }
        }


            DateTime codeGenerationTime;
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string email = txtEmail.Text;
            var existEmail =final.Accounts.FirstOrDefault(x => x.Email == email);
            if (existEmail == null)
            {
                MessageBox.Show("Email not existed");
                return;
            }
            else
            {
                string code = GenerateCode();
                codeGenerationTime = DateTime.Now;
                SendCodeEmail(email, code);
                ConfirmCode dialog = new ConfirmCode(code, codeGenerationTime);
                if (dialog.ShowDialog() == true)
                {
                    RequestEmail(existEmail.Email);
                }

            }


        }
        private void RequestEmail(string recipientEmail)
        {
            try
            {
                string pass = generatePassword();
                EmailUtil.SendEmail(recipientEmail, "Password Recovery", pass);
                changePass(recipientEmail, pass);
                MessageBox.Show("Email sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email. Error: " + ex.Message);
            }
        }
        private string generatePassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%&*()";

            Random random = new Random();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 8; i++)
            {
                int index = random.Next(chars.Length);
                result.Append(chars[index]);
            }

            return result.ToString();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
