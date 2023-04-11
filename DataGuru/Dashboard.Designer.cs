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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.dataview = new System.Windows.Forms.DataGridView();
            this.nip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenis_kelamin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal_lahir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mata_pelajaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gaji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.trash = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchBuutton = new System.Windows.Forms.Button();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).BeginInit();
            this.SuspendLayout();
            // 
            // dataview
            // 
            this.dataview.AllowUserToAddRows = false;
            this.dataview.AllowUserToDeleteRows = false;
            this.dataview.BackgroundColor = System.Drawing.Color.White;
            this.dataview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nip,
            this.nama,
            this.jenis_kelamin,
            this.tanggal_lahir,
            this.mata_pelajaran,
            this.Gaji,
            this.delete,
            this.Update,
            this.id});
            this.dataview.Location = new System.Drawing.Point(28, 112);
            this.dataview.Margin = new System.Windows.Forms.Padding(2);
            this.dataview.Name = "dataview";
            this.dataview.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataview.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataview.RowHeadersVisible = false;
            this.dataview.RowHeadersWidth = 20;
            this.dataview.RowTemplate.Height = 24;
            this.dataview.Size = new System.Drawing.Size(1045, 264);
            this.dataview.TabIndex = 0;
            this.dataview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataview_CellContentClick);
            // 
            // nip
            // 
            this.nip.DataPropertyName = "nip";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nip.DefaultCellStyle = dataGridViewCellStyle2;
            this.nip.Frozen = true;
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nama.DefaultCellStyle = dataGridViewCellStyle3;
            this.nama.Frozen = true;
            this.nama.HeaderText = "Nama";
            this.nama.MinimumWidth = 6;
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            this.nama.Width = 125;
            // 
            // jenis_kelamin
            // 
            this.jenis_kelamin.DataPropertyName = "jenis_kelamin";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jenis_kelamin.DefaultCellStyle = dataGridViewCellStyle4;
            this.jenis_kelamin.Frozen = true;
            this.jenis_kelamin.HeaderText = "Jenis Kelamin";
            this.jenis_kelamin.MinimumWidth = 6;
            this.jenis_kelamin.Name = "jenis_kelamin";
            this.jenis_kelamin.ReadOnly = true;
            this.jenis_kelamin.Width = 116;
            // 
            // tanggal_lahir
            // 
            this.tanggal_lahir.DataPropertyName = "tanggal_lahir";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tanggal_lahir.DefaultCellStyle = dataGridViewCellStyle5;
            this.tanggal_lahir.Frozen = true;
            this.tanggal_lahir.HeaderText = "Tanggal Lahir";
            this.tanggal_lahir.MinimumWidth = 6;
            this.tanggal_lahir.Name = "tanggal_lahir";
            this.tanggal_lahir.ReadOnly = true;
            this.tanggal_lahir.Width = 150;
            // 
            // mata_pelajaran
            // 
            this.mata_pelajaran.DataPropertyName = "mata_pelajaran";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mata_pelajaran.DefaultCellStyle = dataGridViewCellStyle6;
            this.mata_pelajaran.Frozen = true;
            this.mata_pelajaran.HeaderText = "Mata Pelajaran";
            this.mata_pelajaran.MinimumWidth = 6;
            this.mata_pelajaran.Name = "mata_pelajaran";
            this.mata_pelajaran.ReadOnly = true;
            this.mata_pelajaran.Width = 125;
            // 
            // Gaji
            // 
            this.Gaji.DataPropertyName = "gaji";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gaji.DefaultCellStyle = dataGridViewCellStyle7;
            this.Gaji.Frozen = true;
            this.Gaji.HeaderText = "Gaji";
            this.Gaji.MinimumWidth = 6;
            this.Gaji.Name = "Gaji";
            this.Gaji.ReadOnly = true;
            this.Gaji.Width = 125;
            // 
            // delete
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.DefaultCellStyle = dataGridViewCellStyle8;
            this.delete.Frozen = true;
            this.delete.HeaderText = "Delete";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.delete.Text = "Delete";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 125;
            // 
            // Update
            // 
            this.Update.Frozen = true;
            this.Update.HeaderText = "Update";
            this.Update.MinimumWidth = 6;
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            this.Update.Width = 125;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 6;
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
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.refresh.Location = new System.Drawing.Point(109, 76);
            this.refresh.Margin = new System.Windows.Forms.Padding(2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(77, 32);
            this.refresh.TabIndex = 3;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // trash
            // 
            this.trash.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.trash.Location = new System.Drawing.Point(988, 381);
            this.trash.MaximumSize = new System.Drawing.Size(85, 33);
            this.trash.Name = "trash";
            this.trash.Size = new System.Drawing.Size(85, 33);
            this.trash.TabIndex = 4;
            this.trash.Text = "Trash";
            this.trash.UseVisualStyleBackColor = true;
            this.trash.Click += new System.EventHandler(this.trash_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.SearchBox.Location = new System.Drawing.Point(818, 76);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(173, 30);
            this.SearchBox.TabIndex = 5;
            // 
            // SearchBuutton
            // 
            this.SearchBuutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchBuutton.Location = new System.Drawing.Point(996, 76);
            this.SearchBuutton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBuutton.Name = "SearchBuutton";
            this.SearchBuutton.Size = new System.Drawing.Size(77, 32);
            this.SearchBuutton.TabIndex = 6;
            this.SearchBuutton.Text = "Search";
            this.SearchBuutton.UseVisualStyleBackColor = true;
            this.SearchBuutton.Click += new System.EventHandler(this.SearchBuutton_Click);
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelTotal.Location = new System.Drawing.Point(259, 85);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(0, 15);
            this.LabelTotal.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(191, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total Data:";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1103, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.SearchBuutton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.trash);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "Data Guru";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button trash;
        private System.Windows.Forms.DataGridViewTextBoxColumn nip;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenis_kelamin;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal_lahir;
        private System.Windows.Forms.DataGridViewTextBoxColumn mata_pelajaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gaji;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button SearchBuutton;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label label2;
    }
}

