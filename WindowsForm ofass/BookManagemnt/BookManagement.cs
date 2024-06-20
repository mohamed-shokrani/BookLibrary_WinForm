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
            var getBookDetails = _context.BookDetails.Include(x=>x.Language).Include(x=>x.PublishingHouse)
                                                           .Include(x=>x.Category)
                                                           .Include(x=>x.Author)
                                                           .Where(x=>x.SerialNumber == serialNum).FirstOrDefault();
            if (getBookDetails != null)
            {

                var form = new BookUpdateAndCreate(getBookDetails.Id);
                form.Show();
                return;
            }
            MessageBox.Show("من فضلك ادخل كود الرقم التسلسى الصحيح");
        }
    }
}
