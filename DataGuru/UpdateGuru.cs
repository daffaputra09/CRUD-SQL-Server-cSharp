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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataGuru
{
    public partial class UpdateGuru : Form
    {
        Koneksi a = new Koneksi();

        
        public UpdateGuru(string nip, string nama, string jenis_kelamin, string tanggal_lahir, string mata_pelajaran,string gaji, string id)
        {
            InitializeComponent();
            FormNip.Text = nip;
            FormNama.Text = nama;
            if(jenis_kelamin == "L")
            {
                laki.Checked= true;

            }
            else if (jenis_kelamin == "P")
            {
                perempuan.Checked = true;
            }
            FormTL.Text = tanggal_lahir;
            FormMapel.Text = mata_pelajaran;
            FormGaji.Text = gaji; 
            Formid.Text = id;
        }
        
            

        private void UpdateGuru_Load(object sender, EventArgs e)
        {

        }

        private void ActionSimpan_Click(object sender, EventArgs e)
        {
            if (FormNip.Text == "" || FormNama.Text == "" || FormGaji.Text == "" || FormTL.Text == "" || FormMapel.Text == "")
            {
                MessageBox.Show("Data Belum Lengkap");
            }
            else
            {
                string nip = FormNip.Text;
                string CekNip = $"SELECT COUNT(*) FROM tb_guru WHERE nip = '{nip}'";
                SqlConnection conn = a.GetConn();
                try
                {
                    conn.Open();
                    SqlCommand cek = new SqlCommand(CekNip, conn);
                    int count = (int)cek.ExecuteScalar();
                    if (count == 0)
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE tb_guru SET nip=@nip, nama=@nama, jenis_kelamin=@jenis_kelamin, tanggal_lahir=@tanggal_lahir, mata_pelajaran=@mata_pelajaran, Gaji=@gaji, updated_at=@updated_at WHERE id=@id ", conn);
                        cmd.Parameters.AddWithValue("@id", Formid.Text);
                        cmd.Parameters.AddWithValue("@nip", FormNip.Text);
                        cmd.Parameters.AddWithValue("@nama", FormNama.Text);
                        if(laki.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@jenis_kelamin", laki.Text);
                        }
                        if (perempuan.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@jenis_kelamin", perempuan.Text);
                        }
                        cmd.Parameters.AddWithValue("@tanggal_lahir", FormTL.Text);
                        cmd.Parameters.AddWithValue("@mata_pelajaran", FormMapel.Text);
                        cmd.Parameters.AddWithValue("@gaji", FormGaji.Text);
                        cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Diubah");
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
    }
}
