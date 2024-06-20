using System.Windows.Forms;

namespace WindowsForm_ofass
{
    partial class BookUpdateAndCreate
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PrintNumber = new System.Windows.Forms.TextBox();
            this.BookName = new System.Windows.Forms.TextBox();
            this.SerialNum = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BookPagesNum = new System.Windows.Forms.TextBox();
            this.BookValue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TotalQuntity0 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_BookCategory = new System.Windows.Forms.ComboBox();
            this.CB_AuthorName = new System.Windows.Forms.ComboBox();
            this.CB_BookLang = new System.Windows.Forms.ComboBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.TotalQuntity = new System.Windows.Forms.TextBox();
            this.CB_PublishingHouse = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(281, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "رقم الطبعة";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(757, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "اللغة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(717, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "اسم دار النشر";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(728, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "اسم المؤلف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(281, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "اسم الكتاب";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(261, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "الرقم التسلسلي";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Highlight;
            this.button5.Location = new System.Drawing.Point(377, 296);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 29;
            this.button5.Text = "حفظ";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.SystemColors.Highlight;
            this.Create.Location = new System.Drawing.Point(595, 296);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 28;
            this.Create.Text = "إضافة";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(972, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "الاعادة";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(114, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "اضافة كتاب";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(582, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "اضافة مستخدم ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // PrintNumber
            // 
            this.PrintNumber.Location = new System.Drawing.Point(137, 207);
            this.PrintNumber.Name = "PrintNumber";
            this.PrintNumber.Size = new System.Drawing.Size(100, 20);
            this.PrintNumber.TabIndex = 24;
            this.PrintNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TotalQuntity_KeyPress);
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(137, 149);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(100, 20);
            this.BookName.TabIndex = 22;
            // 
            // SerialNum
            // 
            this.SerialNum.Location = new System.Drawing.Point(137, 123);
            this.SerialNum.Name = "SerialNum";
            this.SerialNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SerialNum.Size = new System.Drawing.Size(100, 20);
            this.SerialNum.TabIndex = 20;
            this.SerialNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TotalQuntity_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(447, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 21);
            this.comboBox1.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(626, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "اختر رقم المجموعه";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(272, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "عدد الصفحات";
            // 
            // BookPagesNum
            // 
            this.BookPagesNum.Location = new System.Drawing.Point(137, 182);
            this.BookPagesNum.Name = "BookPagesNum";
            this.BookPagesNum.Size = new System.Drawing.Size(100, 20);
            this.BookPagesNum.TabIndex = 41;
            this.BookPagesNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TotalQuntity_KeyPress);
            // 
            // BookValue
            // 
            this.BookValue.Location = new System.Drawing.Point(137, 233);
            this.BookValue.Name = "BookValue";
            this.BookValue.Size = new System.Drawing.Size(100, 20);
            this.BookValue.TabIndex = 42;
            this.BookValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TotalQuntity_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(303, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "القيمة";
            // 
            // TotalQuntity0
            // 
            this.TotalQuntity0.Location = new System.Drawing.Point(147, 70);
            this.TotalQuntity0.Name = "TotalQuntity0";
            this.TotalQuntity0.Size = new System.Drawing.Size(191, 20);
            this.TotalQuntity0.TabIndex = 44;
            this.TotalQuntity0.Text = " مجموعة الكتب";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Highlight;
            this.button6.Location = new System.Drawing.Point(153, 296);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 45;
            this.button6.Text = "الغاء";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(757, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "الفئة";
            // 
            // CB_BookCategory
            // 
            this.CB_BookCategory.FormattingEnabled = true;
            this.CB_BookCategory.Location = new System.Drawing.Point(561, 119);
            this.CB_BookCategory.Name = "CB_BookCategory";
            this.CB_BookCategory.Size = new System.Drawing.Size(121, 21);
            this.CB_BookCategory.TabIndex = 48;
            // 
            // CB_AuthorName
            // 
            this.CB_AuthorName.FormattingEnabled = true;
            this.CB_AuthorName.Location = new System.Drawing.Point(561, 151);
            this.CB_AuthorName.Name = "CB_AuthorName";
            this.CB_AuthorName.Size = new System.Drawing.Size(121, 21);
            this.CB_AuthorName.TabIndex = 49;
            // 
            // CB_BookLang
            // 
            this.CB_BookLang.FormattingEnabled = true;
            this.CB_BookLang.Location = new System.Drawing.Point(561, 210);
            this.CB_BookLang.Name = "CB_BookLang";
            this.CB_BookLang.Size = new System.Drawing.Size(121, 21);
            this.CB_BookLang.TabIndex = 50;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.BackColor = System.Drawing.SystemColors.Highlight;
            this.Quantity.Location = new System.Drawing.Point(301, 262);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(34, 13);
            this.Quantity.TabIndex = 52;
            this.Quantity.Text = "الكمية";
            // 
            // TotalQuntity
            // 
            this.TotalQuntity.Location = new System.Drawing.Point(137, 259);
            this.TotalQuntity.Name = "TotalQuntity";
            this.TotalQuntity.Size = new System.Drawing.Size(100, 20);
            this.TotalQuntity.TabIndex = 51;
            this.TotalQuntity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TotalQuntity_KeyPress);
            // 
            // CB_PublishingHouse
            // 
            this.CB_PublishingHouse.FormattingEnabled = true;
            this.CB_PublishingHouse.Location = new System.Drawing.Point(561, 181);
            this.CB_PublishingHouse.Name = "CB_PublishingHouse";
            this.CB_PublishingHouse.Size = new System.Drawing.Size(121, 21);
            this.CB_PublishingHouse.TabIndex = 53;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(894, 410);
            this.Controls.Add(this.CB_PublishingHouse);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.TotalQuntity);
            this.Controls.Add(this.CB_BookLang);
            this.Controls.Add(this.CB_AuthorName);
            this.Controls.Add(this.CB_BookCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.TotalQuntity0);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BookValue);
            this.Controls.Add(this.BookPagesNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PrintNumber);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.SerialNum);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form5";
            this.Text = "شـــاشـــة إضـــافـــة كــــتـــاب";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PrintNumber;
        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.TextBox SerialNum;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BookPagesNum;
        private System.Windows.Forms.TextBox BookValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TotalQuntity0;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_BookCategory;
        private System.Windows.Forms.ComboBox CB_AuthorName;
        private System.Windows.Forms.ComboBox CB_BookLang;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox TotalQuntity;
        private ComboBox CB_PublishingHouse;
    }
}