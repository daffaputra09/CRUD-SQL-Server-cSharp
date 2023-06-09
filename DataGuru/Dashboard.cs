﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataGuru
{
    public partial class Dashboard : Form
    {
        Koneksi a = new Koneksi();
        bool drag = false;
        Point StartPoint = new Point(0, 0);
        DataTable dataTable;
        int pageNumber = 1;
        int pageSize = 10;
        int totalData;

        public Dashboard()
        {
            InitializeComponent();
        }
        public void TotalData()
        {
            SqlConnection conn = a.GetConn();
            string query = "SELECT total FROM tb_totalguru";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    LabelTotal.Text = dr["total"].ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void Tampil()
        {
            SqlConnection conn = a.GetConn();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tb_guru WHERE is_deleted = 'False'", conn);
                totalData = Convert.ToInt32(cmd.ExecuteScalar());
                cmd = new SqlCommand("SELECT * FROM tb_guru WHERE is_deleted = 'False' ORDER BY id OFFSET (@PageNumber - 1) * @PageSize ROWS FETCH NEXT @PageSize ROWS ONLY;", conn);
                cmd.Parameters.AddWithValue("@PageNumber", pageNumber);
                cmd.Parameters.AddWithValue("@PageSize", pageSize);
                SqlDataReader reader = cmd.ExecuteReader();
                dataTable = new DataTable();
                dataTable.Load(reader);
                dataview.RowTemplate.Height = 40;
                dataview.AutoGenerateColumns = false;
                dataview.DataSource = dataTable;
                dataview.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
                dataview.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;

                int TotalHalaman = (int)Math.Ceiling((double)totalData / pageSize);

                ComboBoxPage.Items.Clear();
                

                for (int i = 1; i <= TotalHalaman; i++)
                {

                    ComboBoxPage.Items.Add(i.ToString());
                    
                    

                }
                


                
                LabelPage.Text =  " of " + Math.Ceiling((double)totalData / pageSize);


                SqlCommand cmdtotal = new SqlCommand("SELECT total FROM tb_totalguru;", conn);
                SqlDataReader dr = cmdtotal.ExecuteReader();
                while (dr.Read())
                {
                    LabelTotal.Text = dr["total"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void DeleteOnView(string id)
        {
            SqlConnection conn = a.GetConn();
            string query = "UPDATE tb_guru SET is_deleted = 1, updated_at = @updated_at  WHERE id = @id";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                cmd.ExecuteNonQuery();
                Tampil();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void SearchData()
        {
            SqlConnection conn = a.GetConn();
            try
            {
                conn.Open();
                SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM tb_guru WHERE (nip like '%" + SearchBox.Text + "%' OR nama like '%" + SearchBox.Text + "%' OR mata_pelajaran like '%" + SearchBox.Text + "%') AND is_deleted='False';", conn);
                DataTable table = new DataTable();
                data.Fill(table);
                dataview.RowTemplate.Height = 40;
                dataview.AutoGenerateColumns = false;
                dataview.DataSource = table;
                int JumlahSearch = dataview.Rows.Count;
                LabelTotal.Text = JumlahSearch.ToString();

                if (SearchBox.Text.Length == 0 || SearchBox.Text == " ")
                {
                    SqlCommand cmd = new SqlCommand("SELECT total FROM tb_totalguru;", conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        LabelTotal.Text = dr["total"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TambahGuru newform = new TambahGuru();
            newform.ShowDialog();
            Tampil();
        }


        private void dataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataview.Columns[e.ColumnIndex].Name == "delete")
                {
                    if (MessageBox.Show(string.Format("Apakah anda yakin ingin menghapus data?"), "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string id = dataview.Rows[e.RowIndex].Cells["id"].Value.ToString();

                        DeleteOnView(id);

                        MessageBox.Show("Data berhasil dihapus");
                    }
                }
                if (dataview.Columns[e.ColumnIndex].Name == "Update")
                {
                    DataGridViewRow selectedRow = dataview.Rows[e.RowIndex];

                    UpdateGuru updateForm = new UpdateGuru(selectedRow.Cells["nip"].Value.ToString(),
                                                           selectedRow.Cells["nama"].Value.ToString(),
                                                           selectedRow.Cells["jenis_kelamin"].Value.ToString(),
                                                           selectedRow.Cells["tanggal_lahir"].Value.ToString(),
                                                           selectedRow.Cells["mata_pelajaran"].Value.ToString(),
                                                           selectedRow.Cells["Gaji"].Value.ToString(),
                                                           selectedRow.Cells["id"].Value.ToString());

                    updateForm.ShowDialog();
                    Tampil();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Tampil();
            SearchBox.Text = "";
        }

        private void trash_Click(object sender, EventArgs e)
        {
            Trash newform = new Trash();
            newform.ShowDialog();
            Tampil();
        }

        private void SearchBuutton_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void PanelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point a = PointToScreen(e.Location);
                this.Location = new Point(a.X - StartPoint.X, a.Y - StartPoint.Y);
            }
        }

        private void PanelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }



        private void ComboBoxPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            pageNumber = ComboBoxPage.SelectedIndex + 1;
            Tampil();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LabelPage_Click(object sender, EventArgs e)
        {

        }
    }
}
