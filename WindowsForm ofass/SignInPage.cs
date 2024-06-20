using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Windows.Forms;
using WindowsForm_ofass.Constant;
using WindowsForm_ofass.Models;

namespace WindowsForm_ofass
{
    public partial class SignInPage : Form
    {

        private readonly BookLibraryContext _context;


        public SignInPage()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(0, 0, 0);
            _context = new BookLibraryContext();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = UserName.Text;
            string password = Password.Text;
            var check = ValidateCredentials(username, password);
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("  الرجاء ادخال اسم المستخدم و كلمة المرور ");
                return;
            }
           
            else if (check.Item1)
            {
                // Set CurrentUser properties upon successful authentication
                CurrentUser.UserId = check.Item2.LibraryUserId;
                CurrentUser.UserName = check.Item2.LibraryUserName;
                CurrentUser.IsAdmin = check.Item2.IsAdmin;
                HomePage form2 = new HomePage();
                form2.Show();
                this.Hide(); // Hide the login form

            }
            else
                MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة");
                return;

        }

        private (bool,LibraryUser) ValidateCredentials(string username, string password)
        {
            try
            {

                var user = _context.LibraryUsers.FirstOrDefault(x => x.LibraryUserName == username && x.Password == password);
                if (user != null)
                    return (true,user);
                return (false,null);
              
            }
            catch (Exception ex)
            {

                return (false, null);
            }
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
