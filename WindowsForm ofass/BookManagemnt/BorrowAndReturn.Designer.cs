﻿using System.Drawing;
using System.Windows.Forms;

namespace WindowsForm_ofass
{
    partial class BorrowAndReturn
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.returnBookBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SerialNumber = new System.Windows.Forms.TextBox();
            this.DateOfBorrowing = new System.Windows.Forms.DateTimePicker();
            this.DateOfReturn = new System.Windows.Forms.DateTimePicker();
            this.CB_BorrowerName = new System.Windows.Forms.ComboBox();
            this.QuantityNeeded_Input = new System.Windows.Forms.TextBox();
            this.QuantityNeeded_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(0, 0);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Enabled = false;
            this.button1.ForeColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(487, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "الأعــــارة";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(113, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "الأعـــــادة";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(916, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "الاعادة";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // returnBookBtn
            // 
            this.returnBookBtn.BackColor = System.Drawing.Color.LightGray;
            this.returnBookBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.returnBookBtn.Location = new System.Drawing.Point(511, 282);
            this.returnBookBtn.Name = "returnBookBtn";
            this.returnBookBtn.Size = new System.Drawing.Size(115, 29);
            this.returnBookBtn.TabIndex = 9;
            this.returnBookBtn.Text = "الأعـــــــادة";
            this.returnBookBtn.UseVisualStyleBackColor = false;
            this.returnBookBtn.Click += new System.EventHandler(this.returnBookBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(646, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "اسم المستعير";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(658, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "رقم الكتاب";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(634, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "تاريخ الأستعارة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(647, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "تاريخ الاعادة";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "اختر نوع المستعير",
            "اختر نوع الاعادة"});
            this.comboBox1.Location = new System.Drawing.Point(309, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Highlight;
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(275, 282);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(135, 29);
            this.button6.TabIndex = 20;
            this.button6.Text = "الـــــغـــاء الـــــغـــرامـــة";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Highlight;
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Location = new System.Drawing.Point(80, 282);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(115, 29);
            this.button7.TabIndex = 21;
            this.button7.Text = "خروج";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // SerialNumber
            // 
            this.SerialNumber.Location = new System.Drawing.Point(487, 160);
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Size = new System.Drawing.Size(139, 20);
            this.SerialNumber.TabIndex = 25;
            this.SerialNumber.TextChanged += new System.EventHandler(this.SerialNumber_TextChanged);
            // 
            // DateOfBorrowing
            // 
            this.DateOfBorrowing.Location = new System.Drawing.Point(440, 187);
            this.DateOfBorrowing.Name = "DateOfBorrowing";
            this.DateOfBorrowing.Size = new System.Drawing.Size(188, 20);
            this.DateOfBorrowing.TabIndex = 30;
            this.DateOfBorrowing.ValueChanged += new System.EventHandler(this.DateOfBorrowing_ValueChanged);
            // 
            // DateOfReturn
            // 
            this.DateOfReturn.Location = new System.Drawing.Point(440, 219);
            this.DateOfReturn.Name = "DateOfReturn";
            this.DateOfReturn.Size = new System.Drawing.Size(188, 20);
            this.DateOfReturn.TabIndex = 31;
            this.DateOfReturn.ValueChanged += new System.EventHandler(this.DateOfReturn_ValueChanged);
            // 
            // CB_BorrowerName
            // 
            this.CB_BorrowerName.FormattingEnabled = true;
            this.CB_BorrowerName.Location = new System.Drawing.Point(496, 126);
            this.CB_BorrowerName.Name = "CB_BorrowerName";
            this.CB_BorrowerName.Size = new System.Drawing.Size(121, 21);
            this.CB_BorrowerName.TabIndex = 32;
            this.CB_BorrowerName.SelectedIndexChanged += new System.EventHandler(this.CB_BorrowerName_SelectedIndexChanged_1);
            // 
            // QuantityNeeded_Input
            // 
            this.QuantityNeeded_Input.Location = new System.Drawing.Point(89, 118);
            this.QuantityNeeded_Input.Name = "QuantityNeeded_Input";
            this.QuantityNeeded_Input.Size = new System.Drawing.Size(139, 20);
            this.QuantityNeeded_Input.TabIndex = 33;
            this.QuantityNeeded_Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityNeeded_Input_KeyPress);
            // 
            // QuantityNeeded_Label
            // 
            this.QuantityNeeded_Label.AutoSize = true;
            this.QuantityNeeded_Label.BackColor = System.Drawing.SystemColors.Highlight;
            this.QuantityNeeded_Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.QuantityNeeded_Label.Location = new System.Drawing.Point(252, 121);
            this.QuantityNeeded_Label.Name = "QuantityNeeded_Label";
            this.QuantityNeeded_Label.Size = new System.Drawing.Size(73, 13);
            this.QuantityNeeded_Label.TabIndex = 34;
            this.QuantityNeeded_Label.Text = "الكمية المطلوبة";
            // 
            // BorrowAndReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 351);
            this.Controls.Add(this.QuantityNeeded_Label);
            this.Controls.Add(this.QuantityNeeded_Input);
            this.Controls.Add(this.CB_BorrowerName);
            this.Controls.Add(this.DateOfReturn);
            this.Controls.Add(this.DateOfBorrowing);
            this.Controls.Add(this.SerialNumber);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnBookBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Name = "BorrowAndReturn";
            this.Text = "شـــاشــة الأعــارة والأعــادة";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button returnBookBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox SerialNumber;
        private System.Windows.Forms.DateTimePicker DateOfBorrowing;
        private System.Windows.Forms.DateTimePicker DateOfReturn;
        private System.Windows.Forms.ComboBox CB_BorrowerName;
        private TextBox QuantityNeeded_Input;
        private Label QuantityNeeded_Label;
    }
}