using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Windows.Forms;
using WindowsForm_ofass.Models;

namespace WindowsForm_ofass
{
    public partial class Form5 : Form
    {
        readonly BookLibraryContext _context;
        public Form5()
        {
            _context = new BookLibraryContext();
            InitializeComponent();
        }



        private void Form5_Load(object sender, EventArgs e)
        {
            PopulateAuthorList();
            PopulateBookCatList();
            PopulateBookLangList();
            PopulatePublishingHouseList();
        }

        private void PopulateBookLangList()
        {
            var categories = _context.BookLanguages.OrderBy(n => n.LanguageName).ToList();

            // Clear existing items (if any)
            CB_BookLang.DataSource = new BindingSource(categories, null);
            CB_BookLang.DisplayMember = "LanguageName";  // Property to display
            CB_BookLang.ValueMember = "LanguageId";     // Property to use as the value

          

        }
        private void PopulatePublishingHouseList()
        {
            var categories = _context.PublishingHouses.OrderBy(n => n.PublishingHouseName).ToList();

            // Clear existing items (if any)
            CB_PublishingHouse.DataSource = new BindingSource(categories, null);
            CB_PublishingHouse.DisplayMember = "PublishingHouseName";  // Property to display
            CB_PublishingHouse.ValueMember = "PublishingHouseId";     // Property to use as the value

            // Optionally select the first item in the ComboBox
            if (CB_PublishingHouse.Items.Count > 0)
            {
                CB_PublishingHouse.SelectedIndex = 0;
            }
        }

        private void PopulateBookCatList()
        {
            var categories = _context.BookCategories.OrderBy(n => n.CategoryName).ToList();

            // Clear existing items (if any)
            CB_BookCategory.DataSource = new BindingSource(categories, null);
            CB_BookCategory.DisplayMember = "CategoryName";  // Property to display
            CB_BookCategory.ValueMember = "CategoryId";     // Property to use as the value

            // Optionally select the first item in the ComboBox
            if (CB_BookCategory.Items.Count > 0)
            {
                CB_BookCategory.SelectedIndex = 0;
            }
        }

        private void PopulateAuthorList()
        {
            var authors = _context.Authors.OrderBy(n => n.AuthorName).ToList();

            // Clear existing items (if any)
            CB_AuthorName.DataSource = new BindingSource(authors, null);
            CB_AuthorName.DisplayMember = "AuthorName";  // Property to display
            CB_AuthorName.ValueMember = "AuthorId";     // Property to use as the value

            // Optionally select the first item in the ComboBox
            if (CB_AuthorName.Items.Count > 0)
            {
                CB_AuthorName.SelectedIndex = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SerialNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookName_TextChanged(object sender, EventArgs e)
        {

        }

        private void PublishingHouse_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookPagesNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void CB_AuthorName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CB_BookCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TotalQuntity_TextChanged(object sender, EventArgs e)
        {

        }
        private void TotalQuntity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        public void CreateNewBook()
        {
            // Check if any required value is null or empty
            if (IsAnyNullOrEmpty(CB_AuthorName.SelectedValue , CB_BookCategory.SelectedValue, CB_BookLang.SelectedValue,
                                 CB_PublishingHouse.SelectedValue, SerialNum.Text, BookName.Text,
                                 BookPagesNum.Text, PrintNumber.Text, TotalQuntity.Text, BookValue.Text))
            {
                MessageBox.Show("يرجى ملء جميع الحقول المطلوبة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CheckIFBookNameExistsOrSerialNum())
            {
                MessageBox.Show("اسم الكتاب أو الرقم التسلسلي موجود بالفعل.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            // If all required values are provided, create a new BookDetail object
            var book = new BookDetail
            {
                AuthorId = (int)CB_AuthorName.SelectedValue,
                CategoryId = (int)CB_BookCategory.SelectedValue,
                LanguageId = (int)CB_BookLang.SelectedValue,
                PublishingHouseId = (int)CB_PublishingHouse.SelectedValue,
                SerialNumber = SerialNum.Text,
                Name = BookName.Text,
                NumberOfPages = int.Parse(BookPagesNum.Text),
                PrintNumber = int.Parse(PrintNumber.Text),
                Quantity = int.Parse(TotalQuntity.Text),
                Value = decimal.Parse(BookValue.Text)
            };

            // Add the new book to the context and save changes
            _context.BookDetails.Add(book);
            _context.SaveChanges();

            MessageBox.Show("تم إضافة الكتاب بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool CheckIFBookNameExistsOrSerialNum()
        {
            var checkBookName = _context.BookDetails.Any(x => x.Name == BookName.Text);
            var checkSerialNum = _context.BookDetails.Any(x => x.SerialNumber == SerialNum.Text);
            return checkBookName || checkBookName;
           
        }

        // Helper function to check if any object or string is null or empty
        private bool IsAnyNullOrEmpty(params object[] values)
        {
            foreach (var value in values)
            {
                if (value == null  || (value is string str && string.IsNullOrEmpty(str)) )
                {
                    return true;
                }
            }
            return false;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            CreateNewBook();
        }
    }
}
