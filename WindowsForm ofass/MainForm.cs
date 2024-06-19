using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_ofass
{
    internal class MainForm:Form
    {
        private DateTimePicker dateTimePicker;

        public MainForm()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ar-SA");

            this.dateTimePicker = new DateTimePicker();

            // Set the DateTimePicker properties for Arabic format
            this.dateTimePicker.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker.CustomFormat = "dddd, dd MMMM yyyy"; // Arabic long date format

            // Set the size and position of the DateTimePicker
            this.dateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker.Location = new System.Drawing.Point(10, 10);

            // Add the DateTimePicker to the form
            // Add DateTimePicker to MainForm
            this.Controls.Add(this.dateTimePicker);

            // Set MainForm properties
            this.Text = "DateTimePicker Example - Arabic Format";
            this.Size = new System.Drawing.Size(300, 200);
        }

       
    }
}

