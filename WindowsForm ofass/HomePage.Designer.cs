namespace WindowsForm_ofass
{
    partial class HomePage
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BookManageBtn = new System.Windows.Forms.Button();
            this.BorrowAndReturnBtn = new System.Windows.Forms.Button();
            this.BookCat = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.LlibUserManagemntBtn = new System.Windows.Forms.Button();
            this.BookSubManagment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "قائـمـة الاوامـر";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(28, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "البحث";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookManageBtn
            // 
            this.BookManageBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BookManageBtn.ForeColor = System.Drawing.Color.Black;
            this.BookManageBtn.Location = new System.Drawing.Point(694, 160);
            this.BookManageBtn.Name = "BookManageBtn";
            this.BookManageBtn.Size = new System.Drawing.Size(91, 27);
            this.BookManageBtn.TabIndex = 4;
            this.BookManageBtn.Text = "أدارة الكتاب";
            this.BookManageBtn.UseVisualStyleBackColor = false;
            this.BookManageBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // BorrowAndReturnBtn
            // 
            this.BorrowAndReturnBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BorrowAndReturnBtn.ForeColor = System.Drawing.Color.Black;
            this.BorrowAndReturnBtn.Location = new System.Drawing.Point(694, 193);
            this.BorrowAndReturnBtn.Name = "BorrowAndReturnBtn";
            this.BorrowAndReturnBtn.Size = new System.Drawing.Size(91, 26);
            this.BorrowAndReturnBtn.TabIndex = 5;
            this.BorrowAndReturnBtn.Text = "الاعارة والاعادة";
            this.BorrowAndReturnBtn.UseVisualStyleBackColor = false;
            this.BorrowAndReturnBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // BookCat
            // 
            this.BookCat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BookCat.ForeColor = System.Drawing.Color.Black;
            this.BookCat.Location = new System.Drawing.Point(694, 225);
            this.BookCat.Name = "BookCat";
            this.BookCat.Size = new System.Drawing.Size(91, 23);
            this.BookCat.TabIndex = 7;
            this.BookCat.Text = "التصنيف";
            this.BookCat.UseVisualStyleBackColor = false;
            this.BookCat.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(28, 130);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "التقارير";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(28, 164);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(91, 23);
            this.button8.TabIndex = 10;
            this.button8.Text = "حول البرنامج";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(28, 204);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(91, 27);
            this.button9.TabIndex = 11;
            this.button9.Text = "أغلاق البرنامج";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(341, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "مـــكـــتـــبـــة الكـــتــــرونـــيــة";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(127, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "                                          التاريخ:11/6/2024م";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ControlText;
            this.button10.Location = new System.Drawing.Point(370, 53);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(253, 23);
            this.button10.TabIndex = 14;
            this.button10.Text = "                                                 الوقت: 11:45م";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // LlibUserManagemntBtn
            // 
            this.LlibUserManagemntBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LlibUserManagemntBtn.ForeColor = System.Drawing.Color.Black;
            this.LlibUserManagemntBtn.Location = new System.Drawing.Point(694, 128);
            this.LlibUserManagemntBtn.Name = "LlibUserManagemntBtn";
            this.LlibUserManagemntBtn.Size = new System.Drawing.Size(91, 26);
            this.LlibUserManagemntBtn.TabIndex = 15;
            this.LlibUserManagemntBtn.Text = "الاعارة والاعادة";
            this.LlibUserManagemntBtn.UseVisualStyleBackColor = false;
            this.LlibUserManagemntBtn.Click += new System.EventHandler(this.button7_Click);
            // 
            // BookSubManagment
            // 
            this.BookSubManagment.ForeColor = System.Drawing.Color.Black;
            this.BookSubManagment.Location = new System.Drawing.Point(658, 98);
            this.BookSubManagment.Name = "BookSubManagment";
            this.BookSubManagment.Size = new System.Drawing.Size(127, 27);
            this.BookSubManagment.TabIndex = 16;
            this.BookSubManagment.Text = "اضافة متعلقات الكتاب";
            this.BookSubManagment.UseVisualStyleBackColor = true;
            this.BookSubManagment.Click += new System.EventHandler(this.BookSubManagment_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(809, 288);
            this.Controls.Add(this.BookSubManagment);
            this.Controls.Add(this.LlibUserManagemntBtn);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.BookCat);
            this.Controls.Add(this.BorrowAndReturnBtn);
            this.Controls.Add(this.BookManageBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "HomePage";
            this.Text = "الــــواجــهــة الرئــيــســيــة";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BookManageBtn;
        private System.Windows.Forms.Button BorrowAndReturnBtn;
        private System.Windows.Forms.Button BookCat;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button LlibUserManagemntBtn;
        private System.Windows.Forms.Button BookSubManagment;
    }
}