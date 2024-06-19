namespace WindowsForm_ofass
{
    partial class LibraryUsers
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
            this.UserName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(446, 51);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(179, 20);
            this.UserName.TabIndex = 10;
            this.UserName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(771, 160);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.Gold;
            this.Update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Update.Location = new System.Drawing.Point(552, 266);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(186, 32);
            this.Update.TabIndex = 16;
            this.Update.Text = "تعديل";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(631, 49);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(89, 23);
            this.Display.TabIndex = 17;
            this.Display.Text = "عرض";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // LibraryUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UserName);
            this.Name = "LibraryUsers";
            this.Text = "LibraryUsers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Display;
    }
}