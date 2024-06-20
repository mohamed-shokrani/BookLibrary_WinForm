namespace WindowsForm_ofass
{
    partial class LibraryGeneralSerach
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SearchInput = new System.Windows.Forms.TextBox();
            this.RadioBtnStartsWith = new System.Windows.Forms.RadioButton();
            this.RadioBtnContains = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(477, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "البحث عن مشترك";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(284, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "الـــــبــــحـــث عـــن كـــتاب";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(613, 87);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 7;
            this.SearchBtn.Text = "بحث";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Highlight;
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(128, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(130, 23);
            this.button9.TabIndex = 8;
            this.button9.Text = "البجث عن كتاب";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // SearchInput
            // 
            this.SearchInput.Location = new System.Drawing.Point(443, 89);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(155, 20);
            this.SearchInput.TabIndex = 9;
            this.SearchInput.TextChanged += new System.EventHandler(this.SearchInput_TextChanged);
            // 
            // RadioBtnStartsWith
            // 
            this.RadioBtnStartsWith.AutoSize = true;
            this.RadioBtnStartsWith.Location = new System.Drawing.Point(443, 61);
            this.RadioBtnStartsWith.Name = "RadioBtnStartsWith";
            this.RadioBtnStartsWith.Size = new System.Drawing.Size(65, 17);
            this.RadioBtnStartsWith.TabIndex = 11;
            this.RadioBtnStartsWith.Text = "يبدئ بي";
            this.RadioBtnStartsWith.UseVisualStyleBackColor = true;
            this.RadioBtnStartsWith.CheckedChanged += new System.EventHandler(this.RadioBtnStartsWith_CheckedChanged);
            // 
            // RadioBtnContains
            // 
            this.RadioBtnContains.AutoSize = true;
            this.RadioBtnContains.Checked = true;
            this.RadioBtnContains.Location = new System.Drawing.Point(340, 60);
            this.RadioBtnContains.Name = "RadioBtnContains";
            this.RadioBtnContains.Size = new System.Drawing.Size(79, 17);
            this.RadioBtnContains.TabIndex = 12;
            this.RadioBtnContains.TabStop = true;
            this.RadioBtnContains.Text = "يحتوي على";
            this.RadioBtnContains.UseVisualStyleBackColor = true;
            this.RadioBtnContains.CheckedChanged += new System.EventHandler(this.RadioBtnContains_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "الاسم",
            "الرقم",
            "درا النشر",
            "الرقم التسلسلى",
            "اسم المؤلف",
            "اسم مشترك"});
            this.comboBox1.Location = new System.Drawing.Point(514, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 47;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(703, 150);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form4
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 301);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.RadioBtnContains);
            this.Controls.Add(this.RadioBtnStartsWith);
            this.Controls.Add(this.SearchInput);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "Form4";
            this.Text = "    شـــاشـــة الـــبــحـــث             ";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox SearchInput;
        private System.Windows.Forms.RadioButton RadioBtnStartsWith;
        private System.Windows.Forms.RadioButton RadioBtnContains;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}