using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGuru
{
    public partial class Dashboard : Form
    {
        Koneksi a = new Koneksi();

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
                SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM tb_guru WHERE is_deleted='False';", conn);
                DataTable table = new DataTable();
                data.Fill(table);
                dataview.RowTemplate.Height = 30;
                dataview.AutoGenerateColumns = false;
                dataview.DataSource = table;

                SqlCommand cmd = new SqlCommand("SELECT total FROM tb_totalguru;", conn);
                SqlDataReader dr = cmd.ExecuteReader();
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
            string query = "UPDATE tb_guru SET is_deleted = 1, is_deleted_at = @is_deleted_at  WHERE id = @id";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@is_deleted_at", DateTime.Now);
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
                SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM tb_guru WHERE is_deleted='False' AND nip like '%" + SearchBox.Text + " %' OR nama like '%" + SearchBox.Text + " %' OR mata_pelajaran like '%" + SearchBox.Text + " %';", conn);
                DataTable table = new DataTable();
                data.Fill(table);
                dataview.RowTemplate.Height = 30;
                dataview.AutoGenerateColumns = false;
                dataview.DataSource = table;
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
            newform.Show();
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

                    updateForm.Show();
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
        }

        private void trash_Click(object sender, EventArgs e)
        {
            Trash newform = new Trash();
            newform.Show();
        }

        private void SearchBuutton_Click(object sender, EventArgs e)
        {
            SearchData();
        }

    }
}
