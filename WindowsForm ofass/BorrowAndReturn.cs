using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm_ofass.Constant;
using WindowsForm_ofass.Models;

namespace WindowsForm_ofass
{
    public partial class BorrowAndReturn : Form
    {
        private BookLibraryContext _context;
         private List<LibraryUser> allLibraryUsers;

        public BorrowAndReturn()
        {
           _context = new BookLibraryContext();
            InitializeComponent();
            this.BackColor = Color.FromArgb(0, 0, 0);
            InitializeCustomComboBox(); ;

    }
        private void InitializeCustomComboBox()
        {
            BookLibraryContext context = new BookLibraryContext();
             allLibraryUsers = context.LibraryUsers.OrderBy(x=>x.LibraryUserName).ToList();
            CB_BorrowerName.DataSource = new BindingSource(allLibraryUsers, null);
            CB_BorrowerName.DisplayMember = "LibraryUserName"; 
            CB_BorrowerName.ValueMember = "LibraryUserId";    
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
        private void QuantityNeeded_Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
            if (selectedItem != "اختر نوع الاعادة")
            {

                returnBookBtn.BackColor = System.Drawing.Color.LightGray;
                returnBookBtn.Enabled = false;
            }
            if (selectedItem == "اختر نوع الاعادة")
            {
                returnBookBtn.Enabled = true;
                returnBookBtn.BackColor = System.Drawing.SystemColors.Highlight;
                returnBookBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateOfBorrowing, dateOfReturn;
            int bookId;
            if (ValidateInputs(out dateOfBorrowing, out dateOfReturn, out bookId))
            {
                var borrowedBook = new BorrowedBook();
                borrowedBook.BorrowDate = dateOfBorrowing;
                borrowedBook.DueDate = dateOfReturn;
                borrowedBook.BorrowedQuantity = int.Parse(QuantityNeeded_Input.Text);
                borrowedBook.BookId = bookId;
                borrowedBook.LibraryUserId = int.Parse(CB_BorrowerName.SelectedValue.ToString());
                _context.Add(borrowedBook);
                _context.SaveChanges();
                MessageBox.Show(" تم الحفظ ");
            }

        }

        private bool ValidateInputs(out DateTime dateOfBorrowing, out DateTime dateOfReturn, out int bookId)
        {
            dateOfBorrowing = DateTime.MinValue;
            dateOfReturn = DateTime.MinValue;
            bookId = int.MinValue;
            var book = _context.BookDetails.FirstOrDefault(x => x.SerialNumber == SerialNumber.Text);
            if (book == null)
            {
                MessageBox.Show("رقم الكتاب المدخل غير صحيح");
                return false;
            }

            if (CB_BorrowerName.SelectedValue is null)
            {
                MessageBox.Show("الرجاء ادخال اسم المستعير");
                return false;
            }

            if (string.IsNullOrWhiteSpace(SerialNumber.Text))
            {
                MessageBox.Show("الرجاء ادخال رقم الكتاب");
                return false;
            }

            dateOfBorrowing = DateOfBorrowing.Value;
            dateOfReturn = DateOfReturn.Value;
            if (dateOfBorrowing >= dateOfReturn)
            {
                MessageBox.Show("تاريخ الاستعارة يجب أن يكون قبل تاريخ الإرجاع");
                return false;
            }

            if (string.IsNullOrWhiteSpace(QuantityNeeded_Input.Text))
            {
                MessageBox.Show("الرجاء ادخال الكمية المطلوبة");
                return false;
            }

            int requestedQuantity;
            if (!int.TryParse(QuantityNeeded_Input.Text, out requestedQuantity))
            {
                MessageBox.Show("الكمية المطلوبة غير صحيحة");
                return false;
            }
            bookId = book.Id;
            return GetAvailableQuantity(book, requestedQuantity);
        
           
        }
        private bool ValidateReturnBooksInputs(out DateTime dateOfReturn, out int bookId)
        {
            dateOfReturn = DateTime.MinValue;
            bookId = int.MinValue;

            // Ensure the borrower's name is selected
            if (CB_BorrowerName.SelectedValue == null)
            {
                MessageBox.Show("الرجاء ادخال اسم المستعير");
                return false;
            }
            if (CB_BorrowerName.SelectedValue == null)
            {
                MessageBox.Show("الرجاء ادخال اسم المستعير");
                return false;
            }

            var libUserId = int.Parse(CB_BorrowerName.SelectedValue.ToString());
            var checkIfUserPreventedFromBorrowing = _context.LibraryUsers.Where(u=>u.LibraryUserId == libUserId).FirstOrDefault();
            if (checkIfUserPreventedFromBorrowing.IsNotAllowedToBorrow)
            {
                MessageBox.Show("هذ المستعير غير مسموح له بالاستعارة");
                return false;
            }

            // Ensure the serial number is entered
            if (string.IsNullOrWhiteSpace(SerialNumber.Text))
            {
                MessageBox.Show("الرجاء ادخال رقم الكتاب");
                return false;
            }

            var book = _context.BookDetails.FirstOrDefault(x => x.SerialNumber == SerialNumber.Text);
            if (book == null)
            {
                MessageBox.Show("رقم الكتاب المدخل غير صحيح");
                return false;
            }

            // Check if the user has borrowed the book before
            var borrowedBooks = _context.BorrowedBooks
                .Where(x => x.LibraryUserId == libUserId && x.BookId == book.Id)
                .ToList();

            if (borrowedBooks.Count == 0)
            {
                MessageBox.Show("المستخدم لم يستعير هذا الكتاب من قبل");
                return false;
            }

            // Calculate the total borrowed quantity and the total returned quantity
            var totalBorrowedQuantity = borrowedBooks.Sum(x => x.BorrowedQuantity);
            var totalReturnedQuantity = borrowedBooks.Where(x => x.ReturnDate != null).Sum(x => x.BorrowedQuantity);
            var remainingQuantityToReturn = totalBorrowedQuantity - totalReturnedQuantity;

            // Check if all borrowed books have already been returned
            if (remainingQuantityToReturn == 0)
            {
                MessageBox.Show("تم إرجاع جميع الكمية المستعارة بالفعل");
                return false;
            }

            // Ensure the date of return is entered
            dateOfReturn = DateOfReturn.Value;

            // Ensure the quantity needed is entered and valid
            if (string.IsNullOrWhiteSpace(QuantityNeeded_Input.Text))
            {
                MessageBox.Show("الرجاء ادخال الكمية المطلوبة");
                return false;
            }

            int requestedQuantity;
            if (!int.TryParse(QuantityNeeded_Input.Text, out requestedQuantity))
            {
                MessageBox.Show("الكمية المطلوبة غير صحيحة");
                return false;
            }

            // Check if the requested quantity to return is more than the remaining quantity to return
            if (requestedQuantity > remainingQuantityToReturn)
            {
                MessageBox.Show("لا يمكن إرجاع كمية أكبر من الكمية المستعارة");
                return false;
            }

            bookId = book.Id;
            return true;
        }
        private bool GetAvailableQuantity(BookDetail book, int requestedQuantity)
        {
            // Get total quantity of the book
            var totalQuantity = _context.BookDetails
                                        .Where(b => b.Id == book.Id)
                                        .Select(b => b.Quantity)
                                        .FirstOrDefault();

            // Get total borrowed quantity of the book
            var borrowedQuantity = _context.BorrowedBooks
                                           .Where(b => b.BookId == book.Id)
                                           .Sum(b => b.BorrowedQuantity);

            //   Get total returned quantity of the book
            var returnedQuantity = _context.ReturnedBooks
                                           .Where(r => r.BookId == book.Id)
                                           .Sum(r => r.ReturnedQuantity);

            // Calculate available quantity
            var availableQuantity = totalQuantity - (borrowedQuantity - returnedQuantity);


            if (requestedQuantity > availableQuantity)
            {
                MessageBox.Show($"الكمية المتاحة غير كافية. الكمية المتاحة: {availableQuantity}");
                return false;
            }
            return true;
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

        private void returnBookBtn_Click(object sender, EventArgs e)
        {
            DateTime  dateOfReturn;

            int bookId;
            if (ValidateReturnBooksInputs( out dateOfReturn, out bookId))
            {
                var libUserId = int.Parse(CB_BorrowerName.SelectedValue.ToString());
                var libUser = _context.BorrowedBooks.Where(x=>x.LibraryUserId == libUserId && x.BookId==bookId).FirstOrDefault();
                libUser.ReturnDate = dateOfReturn;
                var returnBook  = new ReturnedBook();
                returnBook.ReturnDate = returnBook.ReturnDate;
                returnBook.BookId = bookId; 
                returnBook.BorrowId = 6;
                returnBook.LibraryUserId = libUserId;
                returnBook.ReturnedQuantity = int.Parse( QuantityNeeded_Input.Text);
                _context.BorrowedBooks.Update(libUser);
                _context.Add(returnBook);
                _context.SaveChanges();
                MessageBox.Show(" تم الحفظ ");
            }
           ;
        }

        private void CB_BorrowerName_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
