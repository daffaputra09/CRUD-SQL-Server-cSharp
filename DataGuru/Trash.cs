using System;
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
    public partial class Trash : Form
    {
        Koneksi a = new Koneksi();
        public Trash()
        {
            InitializeComponent();
        }

        public void TampilTrash()
        {
            SqlConnection conn = a.GetConn();
            try
            {
                conn.Open();
                SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM tb_guru WHERE is_deleted='True';", conn);
                DataTable table = new DataTable();
                data.Fill(table);
                dataviewtrash.RowTemplate.Height = 30;
                dataviewtrash.AutoGenerateColumns = false;
                dataviewtrash.DataSource = table;
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
        public void RefreshTrash()
        {
            SqlConnection conn = a.GetConn();
            try
            {
                conn.Open();
                SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM tb_guru WHERE is_deleted='True';", conn);
                DataTable table = new DataTable();
                data.Fill(table);

                dataviewtrash.AutoGenerateColumns = false;
                dataviewtrash.DataSource = table;
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
        private void RestoreTrash()
        {
            SqlConnection conn = a.GetConn();
            string query = "UPDATE tb_guru SET is_deleted = 0  WHERE is_deleted='True' AND NOT nip IN (SELECT nip FROM tb_guru WHERE is_deleted='False');";
            int trash = dataviewtrash.Rows.Count;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                RefreshTrash();
                int RestoreGagal = dataviewtrash.Rows.Count;
                int RestoreBerhasil = trash - RestoreGagal;
                LabelRestore.Text = "Hasil Restore:";
                LabelBerhasil.Text = RestoreBerhasil + " Data Berhasil";
                LabelGagal.Text = RestoreGagal + " Data Gagal";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DeletePermanently()
        {
            SqlConnection conn = a.GetConn();
            string query = "DELETE FROM tb_guru WHERE is_deleted='True';";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                RefreshTrash();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Trash_Load(object sender, EventArgs e)
        {
            TampilTrash();
        }



        private void Restore_Click(object sender, EventArgs e)
        {
            RestoreTrash();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (MessageBox.Show(string.Format("Apakah anda yakin ingin menghapus data secara PERMANEN?"), "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeletePermanently();
                RefreshTrash();

                MessageBox.Show("Data berhasil dihapus");
            }
        }

        private void dataviewtrash_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
