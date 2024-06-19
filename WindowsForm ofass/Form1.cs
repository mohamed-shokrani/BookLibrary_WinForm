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

namespace WindowsForm_ofass
{
    public partial class Form1 : Form
    {

        private readonly BookLibraryContext _context;


        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(0, 0, 0);
            _context = new BookLibraryContext();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = UserName.Text;
            string password = Password.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("  الرجاء ادخال اسم المستخدم و كلمة المرور ");
                return;
            }
            else if (ValidateCredentials(username, password))
            {
              
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide(); // Hide the login form

            }
            else
                MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة");
                return;

        }

        private bool ValidateCredentials(string username, string password)
        {
            try
            {

                var user = _context.Users.FirstOrDefault(x => x.UserName == username && x.Password == password);
                if (user != null)
                    return true;
                return false;
              
            }
            catch (Exception ex)
            {
              
                return false;
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
