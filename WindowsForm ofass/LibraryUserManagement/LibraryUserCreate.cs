using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm_ofass.Models;

namespace WindowsForm_ofass
{
    public partial class LibraryUserCreate : Form
    {
        private readonly BookLibraryContext _context;
        DataTable table = new DataTable("table");
        public LibraryUserCreate()
        {
            _context = new BookLibraryContext();
            this.BackColor = Color.FromArgb(0, 0, 0);


            InitializeComponent();
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            // Initialize DataTable columns




            table.Columns.Add("السبب", typeof(string));
            table.Columns.Add("غير مسموح له بالاستعارة", typeof(bool));
            table.Columns.Add("رقم التليفون", typeof(string));
            table.Columns.Add("الاسم", typeof(string));
            table.Columns.Add("الرقم السرى", typeof(string));

            // Set the DataSource of the DataGridView
            dataGridView1.DataSource = table;

            // Add the DataGridView to the form's controls if not added through designer
            if (!Controls.Contains(dataGridView1))
            {
                Controls.Add(dataGridView1);
            }


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = true; // Disable adding new rows
            dataGridView1.AllowUserToDeleteRows = true;
            dataGridView1.ReadOnly = false; // Allow editing existing rows
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Name == "Id")
                {
                    column.ReadOnly = true; // Make Id column read-only
                }
            }
        }


        private void Create_Click(object sender, EventArgs e)
        {
            List<LibraryUser> newUsers = new List<LibraryUser>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Skip the last row which is usually the new row for data entry
                if (row.IsNewRow)
                    continue;

                var libraryUserName = row.Cells["الاسم"].FormattedValue.ToString();
                var phoneNumberStr = row.Cells["رقم التليفون"].FormattedValue.ToString();
                var isNotAllowedToBorrowStr = row.Cells["غير مسموح له بالاستعارة"].FormattedValue.ToString();
                var reasonNotAllowed = row.Cells["السبب"].FormattedValue.ToString();
                var password = row.Cells["الرقم السرى"].FormattedValue.ToString(); // Assuming you have a column for password
               
                // Validate required fields
                if (string.IsNullOrWhiteSpace(libraryUserName) || string.IsNullOrWhiteSpace(phoneNumberStr))
                {
                    MessageBox.Show("الرجاء إدخال اسم المستخدم ورقم التليفون في كل الصفوف.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(phoneNumberStr, out int phoneNumber))
                {
                    MessageBox.Show("الرجاء إدخال رقم تليفون صحيح.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool isNotAllowedToBorrow = false;
                if (!string.IsNullOrWhiteSpace(isNotAllowedToBorrowStr))
                {
                    isNotAllowedToBorrow = bool.Parse(isNotAllowedToBorrowStr);
                    if (isNotAllowedToBorrow && string.IsNullOrWhiteSpace(reasonNotAllowed))
                    {
                        MessageBox.Show("الرجاء إدخال سبب عدم الاستعارة في كل الصفوف.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                var userExists = _context.LibraryUsers.Any(u => u.LibraryUserName == libraryUserName && u.PhoneNumber == phoneNumber);
                if (userExists)
                {
                    MessageBox.Show("المستخدم بالفعل موجود في قاعدة البيانات.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate password length
                if (password.Length < 6)
                {
                    MessageBox.Show("يجب أن يكون طول كلمة المرور على الأقل 6 أحرف.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (true)
                {
                    
                }
                var newLibUser = new LibraryUser
                {
                    LibraryUserName = libraryUserName,
                    PhoneNumber = phoneNumber,
                    IsNotAllowedToBorrow = isNotAllowedToBorrow,
                    ReasonNotAllowed = isNotAllowedToBorrow ? reasonNotAllowed : null, // Clear reason if not disallowed
                    Password = password, // Assuming you have a column for password
                    IsAdmin = false // Assuming all new users are not admins by default
                };

                newUsers.Add(newLibUser);
            }

            if (newUsers.Any())
            {
                // Add all new users to the context and save changes
                _context.LibraryUsers.AddRange(newUsers);
                _context.SaveChanges();

                MessageBox.Show("تمت إضافة جميع السجلات بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("الرجاء إدخال بيانات صحيحة لإضافة سجلات جديدة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LibraryUserCreate_Load(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            HomePage form2 = new HomePage();
            form2.Show();
            this.Hide(); // Hide the login form
        }
    }
}
