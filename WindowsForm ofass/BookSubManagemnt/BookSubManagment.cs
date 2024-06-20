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

namespace WindowsForm_ofass.BookSubManagemnt
{
    public partial class BookSubManagment : Form
    {
        readonly BookLibraryContext _context;
        public BookSubManagment()
        {
            _context = new BookLibraryContext();
            InitializeComponent();
        }

        private void AuthorManagment_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 0, 0);

        }
        private void AddAuthor(string authorName)
        {
            // Add logic to add the author to the database
            var newAuthor = new Author { AuthorName = authorName,Bio = BioInput.Text };
            _context.Authors.Add(newAuthor);
            _context.SaveChanges(); // Save changes to the database

            MessageBox.Show("تم إضافة المؤلف بنجاح");
        }

        private void AddAuthorInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddAuthorBtn_Click(object sender, EventArgs e)
        {
            string authorName = AddAuthorInput.Text.Trim();
            var existingAuthor = _context.Authors.FirstOrDefault(x => x.AuthorName.ToLower() == authorName.ToLower());

            if (string.IsNullOrWhiteSpace(authorName))
            {
                MessageBox.Show("اسم المؤلف مطلوب");
                return;
            }

            if (existingAuthor != null)
            {
               MessageBox.Show("اسم المؤلف موجود بالفعل");
                return;
              
            }
            else
            {
                
                AddAuthor(authorName);
            }
        }

        private void BioInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddLangBtn_Click(object sender, EventArgs e)
        {
            string langName = AddLangInput.Text.Trim();
            var existingAuthor = _context.BookLanguages.FirstOrDefault(x => x.LanguageName.ToLower() == AddLangInput.Text.ToLower());

            if (string.IsNullOrWhiteSpace(langName))
            {
                MessageBox.Show("اسم اللغة مطلوب");
                return;
            }

            if (existingAuthor != null)
            {
                MessageBox.Show("هذه اللغة موجودة بالفعل");
                return;

            }
            else
            {

                AddLang(langName);
            }
        }
        private void   AddLang(string langName)
        {
            // Add logic to add the author to the database
            var newAuthor = new BookLanguage { LanguageName = langName };
            _context.BookLanguages.Add(newAuthor);
            _context.SaveChanges(); // Save changes to the database

            MessageBox.Show("تم إضافة اللغة بنجاح");
        }

        private void AddPublishingHouseBtn_Click(object sender, EventArgs e)
        {
            string publishingHouseName = AddPublishingHouseInput.Text.Trim();
            var existingAuthor = _context.PublishingHouses.FirstOrDefault(x => x.PublishingHouseName.ToLower() == AddPublishingHouseInput.Text.ToLower());

            if (string.IsNullOrWhiteSpace(publishingHouseName))
            {
                MessageBox.Show("اسم دار النشر مطلوب");
                return;
            }

            if (existingAuthor != null)
            {
                MessageBox.Show(" دار النشر موجودة بالفعل");
                return;

            }
            else
            {

                AddPublishingHouse(publishingHouseName);
            }
        }
        private void AddPublishingHouse(string publishingHouseName)
        {
            var publishingHouse = new PublishingHouse { PublishingHouseName = publishingHouseName };
            _context.PublishingHouses.Add(publishingHouse);
            _context.SaveChanges(); 

            MessageBox.Show("تم  بنجاح");
        }

        private void AddBookCatBtn_Click(object sender, EventArgs e)
        {
            string bookCat = BookCatInput.Text.Trim();
            var existingAuthor = _context.BookCategories.FirstOrDefault(x => x.CategoryName.ToLower() == BookCatInput.Text.ToLower());

            if (string.IsNullOrWhiteSpace(bookCat))
            {
                MessageBox.Show("اسم  فئة الكتاب  مطلوبة");
                return;
            }

            if (existingAuthor != null)
            {
                MessageBox.Show(" فئة الكتاب موجودة بالفعل");
                return;

            }
            else
            {

                AddBookCat(bookCat);
            }
        }
        private void AddBookCat(string publishingHouseName)
        {
            var publishingHouse = new BookCategory { CategoryName = publishingHouseName };
            _context.BookCategories.Add(publishingHouse);
            _context.SaveChanges();

            MessageBox.Show("تم  بنجاح");
        }

        private void BookCatInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
