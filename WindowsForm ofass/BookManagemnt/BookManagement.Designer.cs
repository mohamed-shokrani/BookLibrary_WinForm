namespace WindowsForm_ofass.BookManagemnt
{
    partial class BookManagement
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
            this.AddNewBookBtn = new System.Windows.Forms.Button();
            this.EditBookBtn = new System.Windows.Forms.Button();
            this.SerialNumInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddNewBookBtn
            // 
            this.AddNewBookBtn.Location = new System.Drawing.Point(713, 33);
            this.AddNewBookBtn.Name = "AddNewBookBtn";
            this.AddNewBookBtn.Size = new System.Drawing.Size(75, 23);
            this.AddNewBookBtn.TabIndex = 0;
            this.AddNewBookBtn.Text = "اضافة  كتاب";
            this.AddNewBookBtn.UseVisualStyleBackColor = true;
            // 
            // EditBookBtn
            // 
            this.EditBookBtn.Location = new System.Drawing.Point(713, 150);
            this.EditBookBtn.Name = "EditBookBtn";
            this.EditBookBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBookBtn.TabIndex = 1;
            this.EditBookBtn.Text = "تعديل كتاب";
            this.EditBookBtn.UseVisualStyleBackColor = true;
            this.EditBookBtn.Click += new System.EventHandler(this.EditBookBtn_Click);
            // 
            // SerialNumInput
            // 
            this.SerialNumInput.Location = new System.Drawing.Point(442, 152);
            this.SerialNumInput.Name = "SerialNumInput";
            this.SerialNumInput.Size = new System.Drawing.Size(100, 20);
            this.SerialNumInput.TabIndex = 2;
            this.SerialNumInput.TextChanged += new System.EventHandler(this.SerialNumInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(563, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ادخل الرقم التسلسلى للكتاب";
            // 
            // BookManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SerialNumInput);
            this.Controls.Add(this.EditBookBtn);
            this.Controls.Add(this.AddNewBookBtn);
            this.Name = "BookManagement";
            this.Text = "BookManagemnt";
            this.Load += new System.EventHandler(this.BookManagemnt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewBookBtn;
        private System.Windows.Forms.Button EditBookBtn;
        private System.Windows.Forms.TextBox SerialNumInput;
        private System.Windows.Forms.Label label1;
    }
}