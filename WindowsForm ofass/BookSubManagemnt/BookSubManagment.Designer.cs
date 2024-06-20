namespace WindowsForm_ofass.BookSubManagemnt
{
    partial class BookSubManagment
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
            this.AddAuthorBtn = new System.Windows.Forms.Button();
            this.AddAuthorInput = new System.Windows.Forms.TextBox();
            this.AddLangInput = new System.Windows.Forms.TextBox();
            this.AddLangBtn = new System.Windows.Forms.Button();
            this.AddPublishingHouseInput = new System.Windows.Forms.TextBox();
            this.AddPublishingHouseBtn = new System.Windows.Forms.Button();
            this.BookCatInput = new System.Windows.Forms.TextBox();
            this.AddBookCatBtn = new System.Windows.Forms.Button();
            this.BioInput = new System.Windows.Forms.TextBox();
            this.BioLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddAuthorBtn
            // 
            this.AddAuthorBtn.Location = new System.Drawing.Point(698, 53);
            this.AddAuthorBtn.Name = "AddAuthorBtn";
            this.AddAuthorBtn.Size = new System.Drawing.Size(75, 23);
            this.AddAuthorBtn.TabIndex = 0;
            this.AddAuthorBtn.Text = "اضافة مؤلف";
            this.AddAuthorBtn.UseVisualStyleBackColor = true;
            this.AddAuthorBtn.Click += new System.EventHandler(this.AddAuthorBtn_Click);
            // 
            // AddAuthorInput
            // 
            this.AddAuthorInput.Location = new System.Drawing.Point(513, 55);
            this.AddAuthorInput.Name = "AddAuthorInput";
            this.AddAuthorInput.Size = new System.Drawing.Size(179, 20);
            this.AddAuthorInput.TabIndex = 5;
            this.AddAuthorInput.TextChanged += new System.EventHandler(this.AddAuthorInput_TextChanged);
            // 
            // AddLangInput
            // 
            this.AddLangInput.Location = new System.Drawing.Point(513, 109);
            this.AddLangInput.Name = "AddLangInput";
            this.AddLangInput.Size = new System.Drawing.Size(179, 20);
            this.AddLangInput.TabIndex = 7;
            // 
            // AddLangBtn
            // 
            this.AddLangBtn.Location = new System.Drawing.Point(698, 107);
            this.AddLangBtn.Name = "AddLangBtn";
            this.AddLangBtn.Size = new System.Drawing.Size(75, 23);
            this.AddLangBtn.TabIndex = 6;
            this.AddLangBtn.Text = "اضافة لغة";
            this.AddLangBtn.UseVisualStyleBackColor = true;
            this.AddLangBtn.Click += new System.EventHandler(this.AddLangBtn_Click);
            // 
            // AddPublishingHouseInput
            // 
            this.AddPublishingHouseInput.Location = new System.Drawing.Point(513, 157);
            this.AddPublishingHouseInput.Name = "AddPublishingHouseInput";
            this.AddPublishingHouseInput.Size = new System.Drawing.Size(179, 20);
            this.AddPublishingHouseInput.TabIndex = 9;
            // 
            // AddPublishingHouseBtn
            // 
            this.AddPublishingHouseBtn.Location = new System.Drawing.Point(698, 155);
            this.AddPublishingHouseBtn.Name = "AddPublishingHouseBtn";
            this.AddPublishingHouseBtn.Size = new System.Drawing.Size(75, 23);
            this.AddPublishingHouseBtn.TabIndex = 8;
            this.AddPublishingHouseBtn.Text = "اضافة دار نشر";
            this.AddPublishingHouseBtn.UseVisualStyleBackColor = true;
            this.AddPublishingHouseBtn.Click += new System.EventHandler(this.AddPublishingHouseBtn_Click);
            // 
            // BookCatInput
            // 
            this.BookCatInput.Location = new System.Drawing.Point(513, 206);
            this.BookCatInput.Name = "BookCatInput";
            this.BookCatInput.Size = new System.Drawing.Size(179, 20);
            this.BookCatInput.TabIndex = 11;
            this.BookCatInput.TextChanged += new System.EventHandler(this.BookCatInput_TextChanged);
            // 
            // AddBookCatBtn
            // 
            this.AddBookCatBtn.Location = new System.Drawing.Point(698, 204);
            this.AddBookCatBtn.Name = "AddBookCatBtn";
            this.AddBookCatBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBookCatBtn.TabIndex = 10;
            this.AddBookCatBtn.Text = "اضافة فئة كتاب";
            this.AddBookCatBtn.UseVisualStyleBackColor = true;
            this.AddBookCatBtn.Click += new System.EventHandler(this.AddBookCatBtn_Click);
            // 
            // BioInput
            // 
            this.BioInput.Location = new System.Drawing.Point(249, 56);
            this.BioInput.Name = "BioInput";
            this.BioInput.Size = new System.Drawing.Size(179, 20);
            this.BioInput.TabIndex = 12;
            this.BioInput.TextChanged += new System.EventHandler(this.BioInput_TextChanged);
            // 
            // BioLabel
            // 
            this.BioLabel.AutoSize = true;
            this.BioLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BioLabel.Location = new System.Drawing.Point(434, 58);
            this.BioLabel.Name = "BioLabel";
            this.BioLabel.Size = new System.Drawing.Size(67, 13);
            this.BioLabel.TabIndex = 13;
            this.BioLabel.Text = "السيرة الذاتية";
            // 
            // BookSubManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.BioLabel);
            this.Controls.Add(this.BioInput);
            this.Controls.Add(this.BookCatInput);
            this.Controls.Add(this.AddBookCatBtn);
            this.Controls.Add(this.AddPublishingHouseInput);
            this.Controls.Add(this.AddPublishingHouseBtn);
            this.Controls.Add(this.AddLangInput);
            this.Controls.Add(this.AddLangBtn);
            this.Controls.Add(this.AddAuthorInput);
            this.Controls.Add(this.AddAuthorBtn);
            this.Name = "BookSubManagment";
            this.Text = "AuthorManagment";
            this.Load += new System.EventHandler(this.AuthorManagment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddAuthorBtn;
        private System.Windows.Forms.TextBox AddAuthorInput;
        private System.Windows.Forms.TextBox AddLangInput;
        private System.Windows.Forms.Button AddLangBtn;
        private System.Windows.Forms.TextBox AddPublishingHouseInput;
        private System.Windows.Forms.Button AddPublishingHouseBtn;
        private System.Windows.Forms.TextBox BookCatInput;
        private System.Windows.Forms.Button AddBookCatBtn;
        private System.Windows.Forms.TextBox BioInput;
        private System.Windows.Forms.Label BioLabel;
    }
}