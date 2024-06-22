using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WindowsForm_ofass.Models;

namespace WindowsForm_ofass
{
    public partial class BookUpdateAndCreate : Form
    {
        byte[] _photo = null;
        readonly BookLibraryContext _context;
        int  _bookUpdateObjID;
        BookDetail _bookUpdateObj;
        public BookUpdateAndCreate(int id )
        {
            
            _bookUpdateObjID = id;
            _context = new BookLibraryContext();
            _bookUpdateObj = _context.BookDetails.Where( x => x.Id == id &&!x.IsDeleted).FirstOrDefault();
            InitializeComponent();
        }



        private void Form5_Load(object sender, EventArgs e)
        {
            SerialNum.Enabled = false;
            SerialNum.BackColor = Color.White;
            pictureBox1.BackColor = Color.Gray;
            PopulateAuthorList(0);
            PopulateBookCatList(0);
            PopulateBookLangList(0);
            PopulatePublishingHouseList(0);
            
            if (_bookUpdateObj !=null)
            {
                SerialNum.Text = _bookUpdateObj.SerialNumber;
                BookName.Text = _bookUpdateObj.Name;
                BookPagesNum.Text = _bookUpdateObj.NumberOfPages.ToString();
                PrintNumber.Text = _bookUpdateObj.PrintNumber.ToString();
                TotalQuntity.Text = _bookUpdateObj.Quantity.ToString();
                BookValue.Text = _bookUpdateObj.Value.ToString();
               
                if (_bookUpdateObj.Photo !=null)
                    using (var ms = new MemoryStream(_bookUpdateObj.Photo))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                PopulateAuthorList(_bookUpdateObj.Id);
                PopulateBookCatList(_bookUpdateObj.Id);
                PopulateBookLangList(_bookUpdateObj.Id);
                PopulatePublishingHouseList(_bookUpdateObj.Id);
            }

        }

        private void PopulateBookLangList(int id)
        {
            var categories = _context.BookLanguages.OrderBy(n => n.LanguageName).ToList();

            CB_BookLang.DataSource = new BindingSource(categories, null);
            CB_BookLang.DisplayMember = "LanguageName";  // Property to display
            CB_BookLang.ValueMember = "LanguageId";     // Property to use as the value

            if (_bookUpdateObj?.LanguageId >0)
            {
                CB_BookLang.SelectedText = _bookUpdateObj.Language.LanguageName;
                CB_BookLang.SelectedValue = _bookUpdateObj?.Language?.LanguageId;
            }
           

        }
        private void PopulatePublishingHouseList(int id)
        {
            var categories = _context.PublishingHouses.OrderBy(n => n.PublishingHouseName).ToList();

        
                CB_PublishingHouse.DataSource = new BindingSource(categories, null);
                CB_PublishingHouse.DisplayMember = "PublishingHouseName";  // Property to display
                CB_PublishingHouse.ValueMember = "PublishingHouseId";     // Property to use as the value
            

            if (_bookUpdateObj?.PublishingHouseId > 0)
            {
                CB_PublishingHouse.SelectedText = _bookUpdateObj.PublishingHouse.PublishingHouseName;
                CB_PublishingHouse.SelectedValue = _bookUpdateObj?.PublishingHouse?.PublishingHouseId;
            }
            // Optionally select the first item in the ComboBox
          
        }

        private void PopulateBookCatList(int id)
        {
            var categories = _context.BookCategories.OrderBy(n => n.CategoryName).ToList();
          
                CB_BookCategory.DataSource = new BindingSource(categories, null);
                CB_BookCategory.DisplayMember = "CategoryName";  // Property to display
                CB_BookCategory.ValueMember = "CategoryId";     // Property to use as the value
            
            // Clear existing items (if any)

            if (_bookUpdateObj?.CategoryId > 0)
            {
                CB_BookCategory.SelectedText = _bookUpdateObj.Category.CategoryName;
                CB_BookCategory.SelectedValue = _bookUpdateObj?.Category?.CategoryId;
            }
            // Optionally select the first item in the ComboBox
          
        }

        private void PopulateAuthorList(int id)
        {
             var authors = _context.Authors.ToList();

          
                CB_AuthorName.DataSource = new BindingSource(authors, null);
                CB_AuthorName.DisplayMember = "AuthorName";  // Property to display
                CB_AuthorName.ValueMember = "AuthorId";     // Property to use as the value


            // Clear existing items (if any)
            var ele = CB_AuthorName.SelectedIndex;
            if (_bookUpdateObj?.AuthorId > 0)
            {
                var index = authors.FindIndex(a => a.AuthorId == _bookUpdateObj.AuthorId);

                // Set the selected value based on _bookUpdateObj
                CB_AuthorName.SelectedIndex = index;
              //  CB_AuthorName.SelectedText = _bookUpdateObj.Author.AuthorName;

            }
            // Optionally select the first item in the ComboBox
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
        private void TotalQuntity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        public void CreateNewBook()
        {
            // Check if any required value is null or empty
            if (IsAnyNullOrEmpty(CB_AuthorName.SelectedValue , CB_BookCategory.SelectedValue, CB_BookLang.SelectedValue,
                                 CB_PublishingHouse.SelectedValue, BookName.Text,
                                 BookPagesNum.Text, PrintNumber.Text, TotalQuntity.Text, BookValue.Text, pictureBox1.Image))
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
             //   SerialNumber = SerialNum.Text,
                Name = BookName.Text,
                NumberOfPages = int.Parse(BookPagesNum.Text),
                PrintNumber = int.Parse(PrintNumber.Text),
                Quantity = int.Parse(TotalQuntity.Text),
                Value = decimal.Parse(BookValue.Text),
                Photo = _photo,
                CreatedAt = DateTime.Now,

            };

            // Add the new book to the context and save changes
            _context.BookDetails.Add(book);
            _context.SaveChanges();

            MessageBox.Show("تم إضافة الكتاب بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool CheckIFBookNameExistsOrSerialNum()
        {
            var checkBookName = _context.BookDetails.Any(x => x.Name == BookName.Text);
           // var checkSerialNum = _context.BookDetails.Any(x => x.SerialNumber == SerialNum.Text);
            if (_bookUpdateObj !=null)
            {
                var checkBookNameEdit = _context.BookDetails.Any(x => x.Name == BookName.Text && x.Id != _bookUpdateObj.Id);
                // var checkSerialNumEdit = _context.BookDetails.Any(x => x.SerialNumber == SerialNum.Text && x.Id != _bookUpdateObj.Id);
                return checkBookNameEdit;//|| checkSerialNumEdit;
            }

            return checkBookName;//|| checkBookName;
           
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
        public void UpdateBook()
        {
            // Check if any required value is null or empty
            if (IsAnyNullOrEmpty(CB_AuthorName.SelectedValue, CB_BookCategory.SelectedValue, CB_BookLang.SelectedValue,
                                 CB_PublishingHouse.SelectedValue, SerialNum.Text, BookName.Text,
                                 BookPagesNum.Text, PrintNumber.Text, TotalQuntity.Text, BookValue.Text,pictureBox1.Image))
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

            _bookUpdateObj.AuthorId = (int)CB_AuthorName.SelectedValue;
            _bookUpdateObj.CategoryId = (int)CB_BookCategory.SelectedValue;
            _bookUpdateObj.LanguageId = (int)CB_BookLang.SelectedValue;
            _bookUpdateObj.PublishingHouseId = (int)CB_PublishingHouse.SelectedValue;
            _bookUpdateObj.SerialNumber = SerialNum.Text;
            _bookUpdateObj.Name = BookName.Text;
            _bookUpdateObj.NumberOfPages = int.Parse(BookPagesNum.Text);
            _bookUpdateObj.PrintNumber = int.Parse(PrintNumber.Text);
            _bookUpdateObj.Quantity = int.Parse(TotalQuntity.Text);
            _bookUpdateObj.Value = decimal.Parse(BookValue.Text);
            _bookUpdateObj.Photo = _photo;
            _bookUpdateObj.UpdatedAt = DateTime.Now;
            // Add the new book to the context and save changes
            _context.BookDetails.Update(_bookUpdateObj);
            _context.SaveChanges();

            MessageBox.Show("تم تعديل الكتاب بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Create_Click(object sender, EventArgs e)
        {
            if (_bookUpdateObjID == 0)
            {
                CreateNewBook();
            }
            else
            {
                UpdateBook();
            }
           
        }
  
        private void UploadPhotoBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    // Load the selected image into the PictureBox for preview
                    pictureBox1.Image = Image.FromFile(filePath);

                    // Convert the image to a byte array to store it in the database
                    byte[] photoBytes = File.ReadAllBytes(filePath);
                    _photo = photoBytes;
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SerialNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
