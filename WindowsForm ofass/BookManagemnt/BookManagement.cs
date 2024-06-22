using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_ofass.BookManagemnt
{
    public partial class BookManagement : Form
    {
        readonly BookLibraryContext _context;
        public BookManagement()
        {
            _context = new BookLibraryContext();
            InitializeComponent();
        }

        private void BookManagemnt_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void SerialNumInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditBookBtn_Click(object sender, EventArgs e)
        {
            var serialNum = SerialNumInput.Text;
            if (string.IsNullOrWhiteSpace( SerialNumInput.Text))
            {
                MessageBox.Show("من فضلك ادخل كود الرقم التسلسى للتعديل");
                return;
            }
            var getBookDetails = _context.BookDetails.Where(x => x.SerialNumber == serialNum && !x.IsDeleted)
                                                     .FirstOrDefault();
            if (getBookDetails != null)
            {

                var form = new BookUpdateAndCreate(getBookDetails.Id);
                form.Show();
                return;
            }
            MessageBox.Show("من فضلك ادخل كود الرقم التسلسى الصحيح");
        }

        private void AddNewBookBtn_Click(object sender, EventArgs e)
        {
            new BookUpdateAndCreate(0).Show();
          
            return;
        }

        private void DeleteBookBtn_Click(object sender, EventArgs e)
        {
            var serialNum = SerialNumberForDelete.Text;
            if (string.IsNullOrWhiteSpace(serialNum))
            {
                MessageBox.Show("من فضلك ادخل كود الرقم التسلسى للحذف");
                return;
            }
            var bookToDelete = _context.BookDetails.Where(x => x.SerialNumber == serialNum && !x.IsDeleted)
                                                     .FirstOrDefault();
            if (bookToDelete != null)
            {
                var confirmationMessage = $"هل أنت متأكد من حذف الكتاب \"{bookToDelete.Name}\"؟";
                var confirmResult = MessageBox.Show(confirmationMessage, "تأكيد الحذف", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    bookToDelete.IsDeleted = true;
                    _context.BookDetails.Update(bookToDelete);
                    _context.SaveChanges();
                    MessageBox.Show($"تم حذف الكتاب \"{bookToDelete.Name}\" بنجاح.");
                }
                else
                
                    MessageBox.Show("تم إلغاء حذف الكتاب.");
                
              
            }
            else
            
                MessageBox.Show("لم يتم العثور على الكتاب بالكود الرقمي المدخل.");
            

        }
    }
}
