namespace WindowsForm_ofass
{
    partial class LibraryUserManagement
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
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.AddNew = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Dsiplay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(624, 363);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(164, 36);
            this.Delete.TabIndex = 0;
            this.Delete.Text = "حذف ";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(575, 29);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(111, 23);
            this.Update.TabIndex = 1;
            this.Update.Text = "تعديل";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // AddNew
            // 
            this.AddNew.Location = new System.Drawing.Point(702, 29);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(75, 23);
            this.AddNew.TabIndex = 2;
            this.AddNew.Text = "اضافة ";
            this.AddNew.UseVisualStyleBackColor = true;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(596, 128);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(100, 20);
            this.UserName.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(758, 194);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Dsiplay
            // 
            this.Dsiplay.Location = new System.Drawing.Point(702, 125);
            this.Dsiplay.Name = "Dsiplay";
            this.Dsiplay.Size = new System.Drawing.Size(86, 23);
            this.Dsiplay.TabIndex = 5;
            this.Dsiplay.Text = "عرض";
            this.Dsiplay.UseVisualStyleBackColor = true;
            this.Dsiplay.Click += new System.EventHandler(this.Dsiplay_Click);
            // 
            // LibraryUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dsiplay);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.AddNew);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Name = "LibraryUserManagement";
            this.Text = "LibraryUserManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button AddNew;
        private System.Windows.Forms.MaskedTextBox UserName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Dsiplay;
    }
}