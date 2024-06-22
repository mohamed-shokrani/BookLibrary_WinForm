using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsForm_ofass.NewFolder1;

namespace WindowsForm_ofass
{
    public partial class LibraryReport : Form
    {
        readonly BookLibraryContext _context;
        public LibraryReport()
        {
            _context = new BookLibraryContext();
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var report = _context.Authors.Include(a => a.BookDetails)
                                           .Select(b => new
                                           {
                                               اسم_المؤلف = b.AuthorName,
                                               السيرة_الذاتية = b.Bio,
                                               عنوان_الكتاب = b.BookDetails.Select(x => x.Name).FirstOrDefault(),

                                           }).ToList();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = report;
            DisplayReport f2 = new DisplayReport(dataGridView1);
            f2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var report = _context.BorrowedBooks.Include(a => a.BookDetail).Include(x => x.LibraryUser)
                                         .Select(b => new
                                         {
                                             تاريخ_الاستعارة = b.BorrowDate,
                                             عدد_الكتب_المستعارة = b.BorrowedQuantity,
                                             عنوان_الكتاب = b.BookDetail.Name,
                                             اسم_المستعير = b.LibraryUser.LibraryUserName,

                                         }).ToList();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = report;
            DisplayReport f2 = new DisplayReport(dataGridView1);
            f2.Show();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }
        private void BorrowedBooksBtn_Click(object sender, EventArgs e)
        {
            var books = _context.BorrowedBooks
                               .Include(b => b.BookDetail)
                               .Include(u => u.LibraryUser)
                               .Select(b => new
                               {
                                   اسم_الكتاب = b.BookDetail.Name,
                                   تاريخ_الاستعارة = b.BorrowDate,
                                   تاريخ_الإرجاع = b.ReturnDate,
                                   الكمية_المستعارة = b.BorrowedQuantity,
                                   اسم_المستعير = b.LibraryUser.LibraryUserName
                               })
                               .ToList();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = books;
            DisplayReport f2 = new DisplayReport(dataGridView1);
            f2.Show();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            var report = _context.PublishingHouses.Include(a => a.Books)
                                          .Select(b => new
                                          {
                                              لغة_الكتاب = b.Books.Select(x => x.Language.LanguageName).FirstOrDefault(),
                                              عنوان_الكتاب = b.Books.Select(x => x.Name).FirstOrDefault(),
                                              اسم_دار_النشر = b.PublishingHouseName,

                                          }).ToList();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = report;
            DisplayReport f2 = new DisplayReport(dataGridView1);
            f2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var report = _context.BorrowedBooks.Include(a => a.LibraryUser)
                                            .Where(d => d.DueDate.Date < DateTime.Now && d.ReturnDate == null)
                                            .Select(b => new
                                            {

                                                عدد_ايام_التاخير = Math.Abs((b.DueDate.Date - DateTime.Now.Date).Days),
                                                تاريخ_الاستعارة = b.BorrowDate,
                                                تاريخ_الارجاع_المفترض = b.DueDate,
                                                الكمية_المستعارة = b.BorrowedQuantity,
                                                اسم_الكتاب = b.BookDetail.Name,

                                                اسم_المستعير = b.LibraryUser.LibraryUserName

                                            }).ToList();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = report;
            DisplayReport f2 = new DisplayReport(dataGridView1);
            f2.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var report = _context.BorrowedBooks.Include(a => a.LibraryUser)
                                            .Select(b => new
                                            {
                                                تاريخ_الاستعارة = b.BorrowDate,
                                                تاريخ_الارجاع_المفترض = b.DueDate,
                                                الكمية_المستعارة = b.BorrowedQuantity,
                                                اسم_الكتاب = b.BookDetail.Name,
                                                اسم_المستعير = b.LibraryUser.LibraryUserName

                                            }).ToList();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = report;
            DisplayReport f2 = new DisplayReport(dataGridView1);
            f2.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowBookGeneralReportBtn_Click(object sender, EventArgs e)
        {
            var bookReport = _context.BookDetails.Select(book => new
            {
                العدد_المتاح_للاستعارة = book.Quantity
                                          - (book.BorrowedBooks.Any()
                                             ? book.BorrowedBooks.Where(b => b.ReturnDate == null)
                                                                .Sum(b => (int?)b.BorrowedQuantity) ?? 0
                                             : 0)
                                          + (book.BorrowedBooks.Any()
                                             ? _context.ReturnedBooks.Where(rb => rb.BookId == book.Id)
                                                                    .Sum(rb => (int?)rb.ReturnedQuantity) ?? 0
                                             : 0),
                عدد_الكتب_المستعارة = book.BorrowedBooks.Sum(x => (int?)x.BorrowedQuantity) ?? 0,
                الكمية_المسترجعة = _context.ReturnedBooks.Where(b => b.BookId == book.Id)
                                                           .Sum(x => (int?)x.ReturnedQuantity) ?? 0,
                عدد_الكتب_الاساسى = book.Quantity,
                القيمة = book.Value,
                اسم_المؤالف = book.Author.AuthorName,
                دار_النشر = book.PublishingHouse.PublishingHouseName,
                لغة_الكتاب = book.Language.LanguageName,
                فئة_الكتب = book.Category.CategoryName,
                عنوان_الكتاب = book.Name
            }).ToList();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = bookReport;
            DisplayReport f2 = new DisplayReport(dataGridView1);
            f2.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var borrowedBooks = _context.BorrowedBooks
                                        .Include(a => a.LibraryUser)
                                        .Include(b => b.BookDetail)
                                        .Where(d => d.DueDate.Date < DateTime.Now && d.ReturnDate == null)
                                        .ToList();

            var returnedBooks = _context.ReturnedBooks.ToList();

            var report = borrowedBooks.GroupJoin(
                              returnedBooks,
                              borrowedBook => borrowedBook.BorrowId,
                              returnedBook => returnedBook.BorrowId,
                              (borrowedBook, returnedBooksGroup) => new
                              {
                                  عدد_ايام_التاخير = Math.Abs((borrowedBook.DueDate.Date - DateTime.Now.Date).Days),
                                  تاريخ_الاستعارة = borrowedBook.BorrowDate,
                                  تاريخ_الارجاع_المفترض = borrowedBook.DueDate,
                                  الكمية_المستعارة = borrowedBook.BorrowedQuantity,
                                  الكمية_المسترجعة = returnedBooksGroup.Count(), // Count of returned books
                                  اسم_الكتاب = borrowedBook.BookDetail.Name,
                                  محروم = borrowedBook.LibraryUser.IsNotAllowedToBorrow ? "نعم" : "لا",
                                  اسم_المستعير = borrowedBook.LibraryUser.LibraryUserName
                              })
                              .ToList();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = report;
            DisplayReport f2 = new DisplayReport(dataGridView1);
            f2.Show();
        }

    }
}
