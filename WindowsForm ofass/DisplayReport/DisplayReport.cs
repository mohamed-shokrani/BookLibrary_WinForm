using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_ofass.NewFolder1
{
    public partial class DisplayReport : Form
    {
        DataGridView dataGridView;
        public DisplayReport(DataGridView dataGrid)
        {
            dataGridView = dataGrid;
            InitializeComponent();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            dataGridView1.Dock = DockStyle.Fill;
            this.StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.DataSource = dataGridView.DataSource;
        }
    }
}
