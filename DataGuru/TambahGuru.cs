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
            if (FormNip.Text == "" || FormNama.Text == "" || FormGaji.Text == "" || FormTL.Text == "" || FormMapel.Text == "")
            {
                MessageBox.Show("Data Belum Lengkap");
            }
            else
            {
                SqlConnection conn = a.GetConn();
                if(laki.Checked == true)
                {
                    gender = "L";
                }
                else
                {
                    gender = "P";
                }
                try
                {
                    cmd = new SqlCommand("insert into tb_guru values('" + FormNip.Text + "','" + FormNama.Text + "','" + gender + "','" + FormTL.Text + "','" + FormMapel.Text + "','" + FormGaji.Text + "','" + 0 + "','" + DateTime.Now + "','" + DateTime.Now + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tambah data berhasil");
                    this.Close();
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
