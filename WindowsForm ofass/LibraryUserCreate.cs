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
                var isNotAllowedToBorrow = bool.Parse(row.Cells["غير مسموح له بالاستعارة"].FormattedValue.ToString());
                var reasonNotAllowed = row.Cells["السبب"].FormattedValue.ToString();
                
                // Validate required fields
                if (isNotAllowedToBorrow && string.IsNullOrWhiteSpace(reasonNotAllowed))
                {
                    MessageBox.Show("الرجاء إدخال سبب عدم الاستعارة في كل الصفوف.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (int.TryParse(row.Cells["رقم التليفون"].FormattedValue.ToString(), out int phone) && !string.IsNullOrWhiteSpace(libraryUserName))
                {
                    
                    var newLibUser = new LibraryUser
                    {
                        LibraryUserName = libraryUserName,
                        PhoneNumber = phone,
                        IsNotAllowedToBorrow = isNotAllowedToBorrow,
                        ReasonNotAllowed = reasonNotAllowed
                    };

                    newUsers.Add(newLibUser);
                   continue;
                }
                MessageBox.Show("الرجاء إدخال بيانات صحيحة  اسم المستخدم ورقم التليفون مطلوب.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (newUsers.Any())
            {
                // Add all new users to the context and save changes
                _context.LibraryUsers.AddRange(newUsers);
                _context.SaveChanges();

                MessageBox.Show("تمت إضافة جميع السجلات بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("الرجاء إدخال بيانات صحيحة لإضافة سجلات جديدة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
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
