using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_ofass
{
    public partial class DataGridSearchCriteria : Form
    {
        public DataGridSearchCriteria()
        {
            InitializeComponent();
        }

        private void DataGridSearchCriteria_Load(object sender, EventArgs e)
        {

        }
        public void LoadDataToDataGridView(DataGridView dataGridView, DataTable dataSource)
        {
            dataGridView.DataSource = dataSource;
        }
    }
}
