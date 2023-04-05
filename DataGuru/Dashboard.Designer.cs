namespace DataGuru
{
    partial class Dashboard
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
            this.dataview = new System.Windows.Forms.DataGridView();
            this.nip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mapel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gaji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).BeginInit();
            this.SuspendLayout();
            // 
            // dataview
            // 
            this.dataview.AllowUserToAddRows = false;
            this.dataview.AllowUserToDeleteRows = false;
            this.dataview.BackgroundColor = System.Drawing.Color.White;
            this.dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nip,
            this.nama,
            this.JK,
            this.TL,
            this.Mapel,
            this.Gaji});
            this.dataview.Location = new System.Drawing.Point(28, 112);
            this.dataview.Margin = new System.Windows.Forms.Padding(2);
            this.dataview.Name = "dataview";
            this.dataview.ReadOnly = true;
            this.dataview.RowHeadersVisible = false;
            this.dataview.RowHeadersWidth = 20;
            this.dataview.RowTemplate.Height = 24;
            this.dataview.Size = new System.Drawing.Size(604, 264);
            this.dataview.TabIndex = 0;
            this.dataview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataview_CellContentClick);
            // 
            // nip
            // 
            this.nip.DataPropertyName = "nip";
            this.nip.HeaderText = "NIP";
            this.nip.Name = "nip";
            this.nip.ReadOnly = true;
            // 
            // nama
            // 
            this.nama.DataPropertyName = "nama";
            this.nama.HeaderText = "Nama";
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            // 
            // JK
            // 
            this.JK.DataPropertyName = "jenis_kelamin";
            this.JK.HeaderText = "Jenis Kelamin";
            this.JK.Name = "JK";
            this.JK.ReadOnly = true;
            // 
            // TL
            // 
            this.TL.DataPropertyName = "tanggal_lahir";
            this.TL.HeaderText = "Tanggal Lahir";
            this.TL.Name = "TL";
            this.TL.ReadOnly = true;
            // 
            // Mapel
            // 
            this.Mapel.DataPropertyName = "mata_pelajaran";
            this.Mapel.HeaderText = "Mata Pelajaran";
            this.Mapel.Name = "Mapel";
            this.Mapel.ReadOnly = true;
            // 
            // Gaji
            // 
            this.Gaji.DataPropertyName = "gaji";
            this.Gaji.HeaderText = "Gaji";
            this.Gaji.Name = "Gaji";
            this.Gaji.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Guru";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.Location = new System.Drawing.Point(28, 76);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(665, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataview);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nip;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn JK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mapel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gaji;
    }
}

