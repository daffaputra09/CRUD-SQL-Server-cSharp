﻿namespace DataGuru
{
    partial class TambahGuru
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
            this.FormNip = new System.Windows.Forms.TextBox();
            this.FormNama = new System.Windows.Forms.TextBox();
            this.laki = new System.Windows.Forms.RadioButton();
            this.perempuan = new System.Windows.Forms.RadioButton();
            this.FormTL = new System.Windows.Forms.DateTimePicker();
            this.FormMapel = new System.Windows.Forms.TextBox();
            this.FormGaji = new System.Windows.Forms.TextBox();
            this.NIP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ActionTambah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FormNip
            // 
            this.FormNip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormNip.Location = new System.Drawing.Point(277, 103);
            this.FormNip.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.FormNip.Name = "FormNip";
            this.FormNip.Size = new System.Drawing.Size(265, 29);
            this.FormNip.TabIndex = 0;
            this.FormNip.TextChanged += new System.EventHandler(this.FormNip_TextChanged);
            // 
            // FormNama
            // 
            this.FormNama.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormNama.Location = new System.Drawing.Point(277, 159);
            this.FormNama.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.FormNama.Name = "FormNama";
            this.FormNama.Size = new System.Drawing.Size(265, 29);
            this.FormNama.TabIndex = 1;
            // 
            // laki
            // 
            this.laki.AutoSize = true;
            this.laki.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.laki.Location = new System.Drawing.Point(279, 214);
            this.laki.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.laki.Name = "laki";
            this.laki.Size = new System.Drawing.Size(39, 27);
            this.laki.TabIndex = 2;
            this.laki.TabStop = true;
            this.laki.Text = "L";
            this.laki.UseVisualStyleBackColor = true;
            // 
            // perempuan
            // 
            this.perempuan.AutoSize = true;
            this.perempuan.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.perempuan.Location = new System.Drawing.Point(368, 214);
            this.perempuan.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.perempuan.Name = "perempuan";
            this.perempuan.Size = new System.Drawing.Size(41, 27);
            this.perempuan.TabIndex = 3;
            this.perempuan.TabStop = true;
            this.perempuan.Text = "P";
            this.perempuan.UseVisualStyleBackColor = true;
            // 
            // FormTL
            // 
            this.FormTL.CustomFormat = "yyyy-MM-dd";
            this.FormTL.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormTL.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FormTL.Location = new System.Drawing.Point(277, 265);
            this.FormTL.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.FormTL.Name = "FormTL";
            this.FormTL.Size = new System.Drawing.Size(265, 29);
            this.FormTL.TabIndex = 4;
            // 
            // FormMapel
            // 
            this.FormMapel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormMapel.Location = new System.Drawing.Point(277, 320);
            this.FormMapel.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.FormMapel.Name = "FormMapel";
            this.FormMapel.Size = new System.Drawing.Size(265, 29);
            this.FormMapel.TabIndex = 5;
            // 
            // FormGaji
            // 
            this.FormGaji.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormGaji.Location = new System.Drawing.Point(277, 375);
            this.FormGaji.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.FormGaji.Name = "FormGaji";
            this.FormGaji.Size = new System.Drawing.Size(265, 29);
            this.FormGaji.TabIndex = 6;
            // 
            // NIP
            // 
            this.NIP.AutoSize = true;
            this.NIP.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.NIP.Location = new System.Drawing.Point(69, 107);
            this.NIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NIP.Name = "NIP";
            this.NIP.Size = new System.Drawing.Size(38, 23);
            this.NIP.TabIndex = 7;
            this.NIP.Text = "NIP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(69, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(69, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(69, 272);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tanggal Lahir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.Location = new System.Drawing.Point(69, 324);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mata Pelajaran";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(69, 379);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gaji";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 37);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tambah Guru";
            // 
            // ActionTambah
            // 
            this.ActionTambah.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ActionTambah.Location = new System.Drawing.Point(235, 439);
            this.ActionTambah.Margin = new System.Windows.Forms.Padding(4);
            this.ActionTambah.Name = "ActionTambah";
            this.ActionTambah.Size = new System.Drawing.Size(124, 44);
            this.ActionTambah.TabIndex = 14;
            this.ActionTambah.Text = "Tambah";
            this.ActionTambah.UseVisualStyleBackColor = true;
            this.ActionTambah.Click += new System.EventHandler(this.ActionTambah_Click);
            // 
            // TambahGuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 510);
            this.Controls.Add(this.perempuan);
            this.Controls.Add(this.laki);
            this.Controls.Add(this.ActionTambah);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NIP);
            this.Controls.Add(this.FormGaji);
            this.Controls.Add(this.FormMapel);
            this.Controls.Add(this.FormTL);
            this.Controls.Add(this.FormNama);
            this.Controls.Add(this.FormNip);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TambahGuru";
            this.Text = "TambahGuru";
            this.Load += new System.EventHandler(this.TambahGuru_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FormNip;
        private System.Windows.Forms.TextBox FormNama;
        private System.Windows.Forms.RadioButton laki;
        private System.Windows.Forms.RadioButton perempuan;
        private System.Windows.Forms.DateTimePicker FormTL;
        private System.Windows.Forms.TextBox FormMapel;
        private System.Windows.Forms.TextBox FormGaji;
        private System.Windows.Forms.Label NIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ActionTambah;
    }
}