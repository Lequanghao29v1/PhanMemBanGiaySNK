﻿namespace PRL.Frm_Main
{
    partial class SoLuongMua_Frm
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
            btnSoLuong = new Button();
            txtSoLuong = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSoLuong
            // 
            btnSoLuong.BackColor = Color.FromArgb(64, 64, 64);
            btnSoLuong.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSoLuong.ForeColor = Color.Yellow;
            btnSoLuong.Location = new Point(119, 60);
            btnSoLuong.Name = "btnSoLuong";
            btnSoLuong.Size = new Size(79, 30);
            btnSoLuong.TabIndex = 5;
            btnSoLuong.Text = "Xác nhận";
            btnSoLuong.UseVisualStyleBackColor = false;
            btnSoLuong.Click += btnSoLuong_Click;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(119, 19);
            txtSoLuong.Multiline = true;
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(124, 23);
            txtSoLuong.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 20);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 3;
            label1.Text = "Số lượng:";
            // 
            // SoLuongMua_Frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 108);
            Controls.Add(btnSoLuong);
            Controls.Add(txtSoLuong);
            Controls.Add(label1);
            Name = "SoLuongMua_Frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SoLuongMua";
            Load += SoLuongMua_Frm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSoLuong;
        private TextBox txtSoLuong;
        private Label label1;
    }
}