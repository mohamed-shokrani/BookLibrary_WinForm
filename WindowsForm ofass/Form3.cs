using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WindowsForm_ofass.Models;

namespace WindowsForm_ofass
{
    public partial class Form3 : Form
    {
        private readonly BookLibraryContext _context;
        private List<LibraryUser> allLibraryUsers;

        public Form3()
        {
            _context = new BookLibraryContext();
            InitializeComponent();
            this.BackColor = Color.FromArgb(0, 0, 0);
            InitializeCustomComboBox(); ;

    }
        private void InitializeCustomComboBox()
        {
            allLibraryUsers = _context.LibraryUsers.ToList();
            CB_BorrowerName.DataSource = new BindingSource(allLibraryUsers, null);
            CB_BorrowerName.DisplayMember = "LibraryUserName";  // Property to display
            CB_BorrowerName.ValueMember = "LibraryUserId";     // Property to use as the value
            CB_BorrowerName.DropDownStyle = ComboBoxStyle.DropDown;
            CB_BorrowerName.KeyDown += CB_BorrowerName_KeyDown;
        }

        private void CB_BorrowerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FilterComboBoxItems();
                e.Handled = true;
                e.SuppressKeyPress = true; // Prevent the 'ding' sound on Enter key press
            }
        }

        private void FilterComboBoxItems()
        {
            string filterText = CB_BorrowerName.Text;

            if (string.IsNullOrEmpty(filterText))
            {
                CB_BorrowerName.DataSource = new BindingSource(allLibraryUsers, null);
                return;
            }

            // Filter the items based on the input text
            var filteredItems = allLibraryUsers
                .Where(item => item.LibraryUserName.ToLower().Contains(filterText.ToLower()))
                .ToList();

            // Temporarily detach the TextChanged event handler
            CB_BorrowerName.TextChanged -= CB_BorrowerName_TextChanged;

            // Update the ComboBox data source with filtered items
            CB_BorrowerName.DataSource = new BindingSource(filteredItems, null);
            CB_BorrowerName.DisplayMember = "LibraryUserName";  // Property to display
            CB_BorrowerName.ValueMember = "LibraryUserId";     // Property to use as the value
            CB_BorrowerName.DroppedDown = true;

            // Preserve the user's text input
            CB_BorrowerName.Text = filterText;
            CB_BorrowerName.SelectionStart = filterText.Length;
            CB_BorrowerName.SelectionLength = 0;

            // Reattach the TextChanged event handler
            CB_BorrowerName.TextChanged += CB_BorrowerName_TextChanged;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
      
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

       

       

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BorrowerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateBorrowing_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateOfReturn_TextChanged(object sender, EventArgs e)
        {

        }

        private void PenaltyValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CannotBeReturned_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RefusalReason_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DateOfBorrowing_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DateOfReturn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           var selectedItem = comboBox1.SelectedItem.ToString();
            if (selectedItem != "اختر نوع المستعير")
            {

                this.button1.BackColor = System.Drawing.Color.LightGray;
                this.button1.Enabled = false;
            }
            if (selectedItem == "اختر نوع المستعير")
            {



                this.button1.Enabled = true;
                this.button1.BackColor = System.Drawing.SystemColors.Highlight;
                this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            }
            if (selectedItem == "اختر نوع الاعادة")
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CB_BorrowerName.SelectedValue is null)
            {
                MessageBox.Show("الرجاء ادخال اسم المستعير");
                return;
            }
            if (string.IsNullOrWhiteSpace( SerialNumber.Text ))
            {
                MessageBox.Show("الرجاء ادخال  رقم الكتاب");
                return;
            }
            DateTime dateOfBorrowing = DateOfBorrowing.Value;
            DateTime dateOfReturn = DateOfReturn.Value;
            if (dateOfBorrowing >= dateOfReturn)
            {
                MessageBox.Show("تاريخ الاستعارة يجب أن يكون قبل تاريخ الإرجاع");
                return;
            }
            var book = _context.BookDetails.FirstOrDefault(x => x.SerialNumber == SerialNumber.Text);
            if (book ==null)
            {
                MessageBox.Show(" رقم الكتاب المدخل غير صحيح ");
                ;

                return;
            }
            var borrowedBook = new BorrowedBook();
            borrowedBook.BorrowDate = dateOfBorrowing;
            borrowedBook.ReturnDate = dateOfReturn;
            borrowedBook.BookId = book.Id;
            book.Quantity -= 1;
           borrowedBook.LibraryUserId = int.Parse(CB_BorrowerName.SelectedValue.ToString());
            _context.Add(borrowedBook);
            _context.SaveChanges();
            MessageBox.Show(" تم الحفظ ");
            
        }
        private void CB_BorrowerName_TextChanged(object sender, EventArgs e)
        {
            string filterText = CB_BorrowerName.Text;

            // Filter the items based on the input text
            if (string.IsNullOrEmpty(filterText))
            {
                
                return;
            }

            // Filter the items based on the input text
            var filteredItems = _context.LibraryUsers
                .Where(item => item.LibraryUserName.ToLower().Contains(filterText.ToLower()))
                .ToList();

            if (filteredItems.Any())
            {
               
                CB_BorrowerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
                CB_BorrowerName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                CB_BorrowerName.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
         
        }
        private void CB_BorrowerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filterText = CB_BorrowerName.Text;

            // Filter the items based on the input text
            if (string.IsNullOrEmpty(filterText))
            {

                return;
            }
            var filteredItems = _context.LibraryUsers
                .Where(item => item.LibraryUserName.ToLower().Contains(filterText.ToLower()))
                .ToList();

            // Update the ComboBox data source only if there are results
            if (filteredItems.Any())
            {
                CB_BorrowerName.DataSource = new BindingSource(filteredItems, null);
                CB_BorrowerName.DroppedDown = true;
            }
        }

        private void SerialNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void CB_BorrowerName_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
