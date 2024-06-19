using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsForm_ofass
{
    public partial class LibraryUserManagement : Form
    {
        private readonly BookLibraryContext _context;
        DataTable table = new DataTable("table");
        public LibraryUserManagement()
        {
            this.BackColor = Color.FromArgb(0, 0, 0);
            _context = new BookLibraryContext();


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
            table.Columns.Add("الرقم", typeof(int)); // Add Id column
            // Set the DataSource of the DataGridView
            dataGridView1.DataSource = table;

            // Add the DataGridView to the form's controls if not added through designer
            if (!Controls.Contains(dataGridView1))
            {
                Controls.Add(dataGridView1);
            }


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false; // Disable adding new rows
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Name == "Id")
                {
                    column.ReadOnly = true; // Make Id column read-only
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Dsiplay_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(UserName.Text, out int id))
            {
                MessageBox.Show(" يجب ادخال رقم فقط");
                return;
            }
            var libUser = _context.LibraryUsers.FirstOrDefault(u => u.LibraryUserId == int.Parse(UserName.Text));
            if (libUser != null && table.Rows.Any())
            {
                table.Rows.Clear();


                table.Rows.Add(libUser.ReasonNotAllowed, libUser.IsNotAllowedToBorrow, libUser.PhoneNumber, libUser.LibraryUserName, libUser.LibraryUserId);
                return;

            }
            if (libUser != null)
            {
                table.Rows.Add(libUser.ReasonNotAllowed, libUser.IsNotAllowedToBorrow, libUser.PhoneNumber, libUser.LibraryUserName, libUser.LibraryUserId);
                return;
            }
            MessageBox.Show("الرجاء إدخال رقم مستخدم صحيح.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (table.Rows.Any())
            {
                DataGridViewRow firstRow = dataGridView1.Rows[0];
                var id = int.Parse(firstRow.Cells["الرقم"].FormattedValue.ToString());
                var checkHasBorrowedBooks = _context.LibraryUsers.Any(a=>a.LibraryUserId ==id && a.BorrowedBooks.Any());
               
                if (checkHasBorrowedBooks)
                {
                    MessageBox.Show("  عفوا لا يمكن حذف المستخدم مستعير كتب مسبقا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                var libUser = _context.LibraryUsers.FirstOrDefault(y=>y.LibraryUserId == id);
                if (libUser !=null)
                {
                    DialogResult result = MessageBox.Show("هل أنت متأكد من حذف السجل؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        _context.LibraryUsers.Remove(libUser);
                        _context.SaveChanges();
                        MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    return;
                }

            }
            MessageBox.Show("الرجاء إدخال رقم مستخدم صحيح.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Update_Click(object sender, EventArgs e)
        {
            LibraryUsers form2 = new LibraryUsers();
            form2.Show();
            this.Hide(); // Hide the login form
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide(); // Hide the login form
        }
    }
}
