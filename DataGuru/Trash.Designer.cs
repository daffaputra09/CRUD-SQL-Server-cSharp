﻿namespace DataGuru
{
    partial class Trash
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataviewtrash = new System.Windows.Forms.DataGridView();
            this.nip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mapel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gaji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restore = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelRestore = new System.Windows.Forms.Label();
            this.LabelBerhasil = new System.Windows.Forms.Label();
            this.LabelGagal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewtrash)).BeginInit();
            this.SuspendLayout();
            // 
            // dataviewtrash
            // 
            this.dataviewtrash.AllowUserToAddRows = false;
            this.dataviewtrash.AllowUserToDeleteRows = false;
            this.dataviewtrash.BackgroundColor = System.Drawing.Color.White;
            this.dataviewtrash.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataviewtrash.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataviewtrash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataviewtrash.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nip,
            this.nama,
            this.JK,
            this.TL,
            this.Mapel,
            this.Gaji});
            this.dataviewtrash.Location = new System.Drawing.Point(24, 65);
            this.dataviewtrash.Margin = new System.Windows.Forms.Padding(2);
            this.dataviewtrash.Name = "dataviewtrash";
            this.dataviewtrash.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataviewtrash.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataviewtrash.RowHeadersVisible = false;
            this.dataviewtrash.RowHeadersWidth = 20;
            this.dataviewtrash.RowTemplate.Height = 24;
            this.dataviewtrash.Size = new System.Drawing.Size(790, 264);
            this.dataviewtrash.TabIndex = 1;
            this.dataviewtrash.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataviewtrash_CellContentClick);
            // 
            // nip
            // 
            this.nip.DataPropertyName = "nip";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nip.DefaultCellStyle = dataGridViewCellStyle10;
            this.nip.HeaderText = "NIP";
            this.nip.MinimumWidth = 6;
            this.nip.Name = "nip";
            this.nip.ReadOnly = true;
            this.nip.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nip.Width = 150;
            // 
            // nama
            // 
            this.nama.DataPropertyName = "nama";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nama.DefaultCellStyle = dataGridViewCellStyle11;
            this.nama.HeaderText = "Nama";
            this.nama.MinimumWidth = 6;
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            this.nama.Width = 125;
            // 
            // JK
            // 
            this.JK.DataPropertyName = "jenis_kelamin";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.JK.DefaultCellStyle = dataGridViewCellStyle12;
            this.JK.HeaderText = "Jenis Kelamin";
            this.JK.MinimumWidth = 6;
            this.JK.Name = "JK";
            this.JK.ReadOnly = true;
            this.JK.Width = 116;
            // 
            // TL
            // 
            this.TL.DataPropertyName = "tanggal_lahir";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TL.DefaultCellStyle = dataGridViewCellStyle13;
            this.TL.HeaderText = "Tanggal Lahir";
            this.TL.MinimumWidth = 6;
            this.TL.Name = "TL";
            this.TL.ReadOnly = true;
            this.TL.Width = 150;
            // 
            // Mapel
            // 
            this.Mapel.DataPropertyName = "mata_pelajaran";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Mapel.DefaultCellStyle = dataGridViewCellStyle14;
            this.Mapel.HeaderText = "Mata Pelajaran";
            this.Mapel.MinimumWidth = 6;
            this.Mapel.Name = "Mapel";
            this.Mapel.ReadOnly = true;
            this.Mapel.Width = 125;
            // 
            // Gaji
            // 
            this.Gaji.DataPropertyName = "gaji";
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gaji.DefaultCellStyle = dataGridViewCellStyle15;
            this.Gaji.HeaderText = "Gaji";
            this.Gaji.MinimumWidth = 6;
            this.Gaji.Name = "Gaji";
            this.Gaji.ReadOnly = true;
            this.Gaji.Width = 125;
            // 
            // Restore
            // 
            this.Restore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Restore.Location = new System.Drawing.Point(737, 29);
            this.Restore.Margin = new System.Windows.Forms.Padding(2);
            this.Restore.Name = "Restore";
            this.Restore.Size = new System.Drawing.Size(77, 32);
            this.Restore.TabIndex = 3;
            this.Restore.Text = "Restore All";
            this.Restore.UseVisualStyleBackColor = true;
            this.Restore.Click += new System.EventHandler(this.Restore_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(658, 336);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Delete All Permanently";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Sampah";
            // 
            // LabelRestore
            // 
            this.LabelRestore.AutoSize = true;
            this.LabelRestore.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRestore.ForeColor = System.Drawing.Color.Black;
            this.LabelRestore.Location = new System.Drawing.Point(168, 39);
            this.LabelRestore.Name = "LabelRestore";
            this.LabelRestore.Size = new System.Drawing.Size(0, 13);
            this.LabelRestore.TabIndex = 6;
            // 
            // LabelBerhasil
            // 
            this.LabelBerhasil.AutoSize = true;
            this.LabelBerhasil.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.LabelBerhasil.ForeColor = System.Drawing.Color.Green;
            this.LabelBerhasil.Location = new System.Drawing.Point(244, 39);
            this.LabelBerhasil.Name = "LabelBerhasil";
            this.LabelBerhasil.Size = new System.Drawing.Size(0, 13);
            this.LabelBerhasil.TabIndex = 7;
            // 
            // LabelGagal
            // 
            this.LabelGagal.AutoSize = true;
            this.LabelGagal.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.LabelGagal.ForeColor = System.Drawing.Color.Red;
            this.LabelGagal.Location = new System.Drawing.Point(347, 39);
            this.LabelGagal.Name = "LabelGagal";
            this.LabelGagal.Size = new System.Drawing.Size(0, 13);
            this.LabelGagal.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(21, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "*Data akan otomatis terhapus setelah 30 hari";
            // 
            // Trash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 394);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelGagal);
            this.Controls.Add(this.LabelBerhasil);
            this.Controls.Add(this.LabelRestore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Restore);
            this.Controls.Add(this.dataviewtrash);
            this.Name = "Trash";
            this.Text = "Trash";
            this.Load += new System.EventHandler(this.Trash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataviewtrash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataviewtrash;
        private System.Windows.Forms.DataGridViewTextBoxColumn nip;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn JK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mapel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gaji;
        private System.Windows.Forms.Button Restore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelRestore;
        private System.Windows.Forms.Label LabelBerhasil;
        private System.Windows.Forms.Label LabelGagal;
        private System.Windows.Forms.Label label2;
    }
}