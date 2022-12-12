using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak_Uygulaması_Proje
{
    public partial class Telefon : Form
    {
        public Telefon()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Server=ERAY\SQLEXPRESS;Database=Emlakcım; Integrated Security=True");
        private void Telefon_Load(object sender, EventArgs e)
        {
            MüsterileriListele();
            MüsteriTablosunuDüzenle();
        }

        private void MüsteriTablosunuDüzenle()
        {
            dataMüsteri.RowHeadersVisible = true;
            dataMüsteri.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;
            dataMüsteri.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataMüsteri.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataMüsteri.EnableHeadersVisualStyles = false;
            dataMüsteri.ColumnHeadersDefaultCellStyle.BackColor = Color.SandyBrown;
            dataMüsteri.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        private void MüsterileriListele()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * From Müsteri";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataMüsteri.DataSource = dt;
                dataMüsteri.Columns[0].Visible = false;
                dataMüsteri.Columns[4].Visible = false;
                dataMüsteri.Columns[5].Visible = false;
                dataMüsteri.Columns[6].Visible = false;
                dataMüsteri.Columns[7].Visible = false;
                dataMüsteri.Columns[8].Visible = false;
                dataMüsteri.Columns[9].Visible = false;
                dataMüsteri.Columns[10].Visible = false;
                dataMüsteri.Columns[11].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void dataMüsteri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text=dataMüsteri.
        }
    }
}
