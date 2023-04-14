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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataGuru
{
    public partial class TambahGuru : Form
    {
        private SqlCommand cmd;

        Koneksi a = new Koneksi();

        string gender;

        public TambahGuru()
        {
            InitializeComponent();
        }

        private void TambahGuru_Load(object sender, EventArgs e)
        {

        }

        private void ActionTambah_Click(object sender, EventArgs e)
        {
            if (FormNip.Text == "" || FormNama.Text == "" || laki.Checked == false && perempuan.Checked == false || FormGaji.Text == "" || FormTL.Text == "" || FormMapel.Text == "")
            {
                MessageBox.Show("Data Belum Lengkap");
            }
            else
            {
                SqlConnection conn = a.GetConn();
                string nip = FormNip.Text;
                string CekNip = $"SELECT COUNT(*) FROM tb_guru WHERE nip = '{nip}'";
                if(laki.Checked == true)
                {
                    gender = "L";
                }
                else if (perempuan.Checked == true)
                {
                    gender = "P";
                }
                try
                {
                    conn.Open();
                    SqlCommand cek = new SqlCommand(CekNip, conn);
                    int count = (int)cek.ExecuteScalar();
                    if(count == 0)
                    {
                        SqlCommand cmd = new SqlCommand("insert into tb_guru (nip, nama, jenis_kelamin, tanggal_lahir, mata_pelajaran, gaji, is_deleted, created_at) values (@nip, @nama, @jenis_kelamin, @tanggal_lahir, @mata_pelajaran, @gaji, @is_deleted, @created_at);", conn);
                        cmd.Parameters.AddWithValue("@nip", FormNip.Text);
                        cmd.Parameters.AddWithValue("@nama", FormNama.Text);
                        cmd.Parameters.AddWithValue("@jenis_kelamin", gender);
                        cmd.Parameters.AddWithValue("@tanggal_lahir", FormTL.Text);
                        cmd.Parameters.AddWithValue("@mata_pelajaran", FormMapel.Text);
                        cmd.Parameters.AddWithValue("@gaji", FormGaji.Text);
                        cmd.Parameters.AddWithValue("@is_deleted", 0);
                        cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Tambah data berhasil");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("NIP yang dimasukkan sudah ada", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void FormNip_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
