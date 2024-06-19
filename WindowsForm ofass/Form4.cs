using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForm_ofass
{
    public partial class Form4 : Form
    {
        readonly BookLibraryContext _context;
        public Form4()


        {
            _context = new BookLibraryContext();
           
            InitializeComponent();
            this.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Insert(0, "اختر");
            comboBox1.SelectedIndex = 0;

        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }





        private void RadioBtnStartsWith_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioBtnContains_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SearchInput_TextChanged(object sender, EventArgs e)//
        {

        }


        private void SearchBtn_Click(object sender, EventArgs e)//
        {
            if (string.IsNullOrWhiteSpace(SearchInput.Text))
            {
                MessageBox.Show("الرجاء إدخال بيانات صحيحة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            List<string> arabicTerms = new List<string>
                                                        {
                                                            "الاسم",
                                                            "الرقم",
                                                            "درا النشر",
                                                            "الرقم التسلسلى",
                                                            "اسم المؤلف",
                                                            "اسم مشترك"
                                                        };
            if (comboBox1.Text != null && comboBox1.Text is string selectedValue)
                if (arabicTerms.Contains(selectedValue))
                  PublishDataToGridView(selectedValue);
                

            
        }

        private DataGridView PublishDataToGridView(string selectedValue)
        {
            dataGridView1.AutoGenerateColumns = true; 
            var list = _context.BookDetails.AsQueryable();
            var libUsers = _context.LibraryUsers.AsQueryable();
            var authorList = _context.Authors.AsQueryable();
            var publishingHouseList = _context.PublishingHouses.AsQueryable();

            switch (selectedValue)
            {
                case "الاسم":
                    if (RadioBtnContains.Checked)
                    {
                        list = list.Where(x => x.Name.ToLower().Contains(SearchInput.Text.ToLower())); ;
                       
                    }
                    if (RadioBtnStartsWith.Checked)
                    {
                        list = list.Where(x => x.Name.ToLower().StartsWith(SearchInput.Text.ToLower()));
                       
                    }
                    dataGridView1.DataSource = list.ToList();

                    return dataGridView1;

                case "الرقم":
                    if (int.TryParse(SearchInput.Text,out int number))
                    {
                        if (RadioBtnContains.Checked)

                            list = list.Where(x => x.PrintNumber.HasValue.Equals(number));

                        if (RadioBtnStartsWith.Checked)
                            list = list.Where(x => x.PrintNumber.HasValue.Equals(number));


                        dataGridView1.DataSource = list.ToList();

                        break;
                    }
                    
                    MessageBox.Show("خطا");
                    break ;
                case "الرقم التسلسلى":
                    
                        if (RadioBtnContains.Checked)

                            list = list.Where(x => x.SerialNumber.ToLower().Contains(SearchInput.Text.ToLower()));

                        if (RadioBtnStartsWith.Checked)
                            list = list.Where(x => x.SerialNumber.ToLower().Contains(SearchInput.Text.ToLower()));
                        dataGridView1.DataSource = list.ToList();

                        break;       
                   
                case "درا النشر":
                    if (RadioBtnContains.Checked)

                        publishingHouseList = publishingHouseList.Where(x => x.PublishingHouseName.ToLower().Contains(SearchInput.Text.ToLower()));

                    if (RadioBtnStartsWith.Checked)
                        publishingHouseList = publishingHouseList.Where(x => x.PublishingHouseName.ToLower().StartsWith(SearchInput.Text.ToLower()));
                    dataGridView1.DataSource = list.ToList();
                    break;
              
                case "اسم المؤلف":
                    if (RadioBtnContains.Checked)

                        authorList = authorList.Where(x => x.AuthorName.ToLower().Contains(SearchInput.Text.ToLower()));

                    if (RadioBtnStartsWith.Checked)
                        authorList = authorList.Where(x => x.AuthorName.ToLower().StartsWith(SearchInput.Text.ToLower()));
                    dataGridView1.DataSource = authorList.ToList();
                    break;
                case "اسم مشترك":
                    if (RadioBtnContains.Checked)
                        libUsers = _context.LibraryUsers.Where(x => x.LibraryUserName.ToLower().Contains(SearchInput.Text.ToLower()));

                    if (RadioBtnStartsWith.Checked)
                        libUsers = _context.LibraryUsers.Where(x => x.LibraryUserName.ToLower().StartsWith(SearchInput.Text.ToLower()));

                    dataGridView1.DataSource = libUsers.ToList();
                    break;
                default:
                    Console.WriteLine("Search term not recognized");
                    break;
            }
            return dataGridView1;
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private DataGridView CreateDataGridViewWithData()
        { 

        return new DataGridView();
        }
            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
