using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_ofass
{
    public partial class LibraryUsers : Form
    {
        private readonly BookLibraryContext _context;
        DataTable table = new DataTable("table");
        public LibraryUsers()
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserName_TextChanged(object sender, EventArgs e)//
        {

        }





        private void Update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                DataGridViewRow firstRow = dataGridView1.Rows[0];
                var id = int.Parse(firstRow.Cells["الرقم"].FormattedValue.ToString());
                var IsNotAllowedToBorrow = bool.Parse(firstRow.Cells["غير مسموح له بالاستعارة"].FormattedValue.ToString());
                var reasonNotAllowed = firstRow.Cells["السبب"].FormattedValue.ToString();
                if (IsNotAllowedToBorrow && string.IsNullOrWhiteSpace(reasonNotAllowed))
                {
                    MessageBox.Show(" الرجاء ادخل سبب عدم الاستعارة");
                    return;
                }

                var libraryUserName = firstRow.Cells["الاسم"].FormattedValue.ToString();
                var libUser = _context.LibraryUsers.FirstOrDefault(x => x.LibraryUserId == id);
                libUser.LibraryUserName = libraryUserName;
                libUser.PhoneNumber = int.Parse(firstRow.Cells["رقم التليفون"].FormattedValue.ToString());
                libUser.IsNotAllowedToBorrow = IsNotAllowedToBorrow;
                libUser.ReasonNotAllowed = reasonNotAllowed;
                _context.LibraryUsers.Update(libUser);
                _context.SaveChanges();
                MessageBox.Show("تم التعديل");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Display_Click(object sender, EventArgs e)
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

       
    }
}

