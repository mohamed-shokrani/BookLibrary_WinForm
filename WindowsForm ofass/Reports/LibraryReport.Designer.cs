namespace WindowsForm_ofass
{
    partial class LibraryReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShowBookGeneralReportBtn = new System.Windows.Forms.Button();
            this.BorrowedBooksBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowBookGeneralReportBtn
            // 
            this.ShowBookGeneralReportBtn.Location = new System.Drawing.Point(537, 108);
            this.ShowBookGeneralReportBtn.Name = "ShowBookGeneralReportBtn";
            this.ShowBookGeneralReportBtn.Size = new System.Drawing.Size(147, 23);
            this.ShowBookGeneralReportBtn.TabIndex = 0;
            this.ShowBookGeneralReportBtn.Text = "تقرير حول الكتب بالكامل";
            this.ShowBookGeneralReportBtn.UseVisualStyleBackColor = true;
            this.ShowBookGeneralReportBtn.Click += new System.EventHandler(this.ShowBookGeneralReportBtn_Click);
            // 
            // BorrowedBooksBtn
            // 
            this.BorrowedBooksBtn.Location = new System.Drawing.Point(333, 108);
            this.BorrowedBooksBtn.Name = "BorrowedBooksBtn";
            this.BorrowedBooksBtn.Size = new System.Drawing.Size(164, 23);
            this.BorrowedBooksBtn.TabIndex = 1;
            this.BorrowedBooksBtn.Text = "تقرير الكتب المستعارة";
            this.BorrowedBooksBtn.UseVisualStyleBackColor = true;
            this.BorrowedBooksBtn.Click += new System.EventHandler(this.BorrowedBooksBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(119, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "تقرير حول الكتب المحجوزة";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(537, 147);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "تقرير حول المؤلف";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(333, 147);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "تقرير حول دار النشر";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(119, 147);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(159, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "تقرير الكتب والمستعيرين";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(537, 190);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(147, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "المستعيرون والمتاخرون";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(333, 190);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(164, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "المستعيرين والمحرومين ";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(119, 190);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(159, 23);
            this.button9.TabIndex = 8;
            this.button9.Text = "المستعيرين";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.Highlight;
            this.button10.Location = new System.Drawing.Point(361, 230);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(90, 23);
            this.button10.TabIndex = 13;
            this.button10.Text = "عودة";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(704, 101);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LibraryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(754, 372);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BorrowedBooksBtn);
            this.Controls.Add(this.ShowBookGeneralReportBtn);
            this.Name = "LibraryReport";
            this.Text = "شــــاشــــة التـــــقـــاريــــر";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowBookGeneralReportBtn;
        private System.Windows.Forms.Button BorrowedBooksBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}