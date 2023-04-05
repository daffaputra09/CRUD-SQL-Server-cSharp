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
    public partial class Dashboard : Form
    {
        Koneksi a = new Koneksi();

        public Dashboard()
        {
            InitializeComponent();
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

        }

    }
}
