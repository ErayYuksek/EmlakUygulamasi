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
    public partial class İletisim : Form
    {
        public İletisim()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Server=ERAY\SQLEXPRESS;Database=Emlakcım; Integrated Security=True");
        private void İletisim_Load(object sender, EventArgs e)
        {
            try
            {
                MüsterileriListele();
                MüsteriTablosunuDüzenle();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void MüsteriTablosunuDüzenle()
        {
            try
            {
                dataMüsteri.RowHeadersVisible = true;
                dataMüsteri.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
                dataMüsteri.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
                dataMüsteri.DefaultCellStyle.SelectionForeColor = Color.Black;
                dataMüsteri.EnableHeadersVisualStyles = false;
                dataMüsteri.ColumnHeadersDefaultCellStyle.BackColor = Color.SandyBrown;
                dataMüsteri.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;



                dataTelefon.RowHeadersVisible = true;
                dataTelefon.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
                dataTelefon.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
                dataTelefon.DefaultCellStyle.SelectionForeColor = Color.Black;
                dataTelefon.EnableHeadersVisualStyles = false;
                dataTelefon.ColumnHeadersDefaultCellStyle.BackColor = Color.SandyBrown;
                dataTelefon.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


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
                dataMüsteri.Columns[5].Visible = false;
                dataMüsteri.Columns[6].Visible = false;
                dataMüsteri.Columns[6].Visible = false;
                dataMüsteri.Columns[7].Visible = false;
                dataMüsteri.Columns[8].Visible = false;
                dataMüsteri.Columns[9].Visible = false;
                dataMüsteri.Columns[10].Visible = false;
                dataMüsteri.Columns[11].Visible = false;
                dataMüsteri.Columns[4].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void dataMüsteri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MüsteriBilgileriniGetir();
                TelefonBilgileriniGetir();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void MüsteriBilgileriniGetir()
        {
            try
            {
                txtId.Text = dataMüsteri.CurrentRow.Cells[0].Value.ToString();
                txtAd.Text = dataMüsteri.CurrentRow.Cells[1].Value.ToString();
                txtSoyad.Text = dataMüsteri.CurrentRow.Cells[2].Value.ToString();
                txtCinsiyet.Text = dataMüsteri.CurrentRow.Cells[3].Value.ToString();
                txtResim.Text = dataMüsteri.CurrentRow.Cells[4].Value.ToString();
                pcrResim.Image = Image.FromFile(txtResim.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                AktifMüsteriyetelefonEkle();
                AlanlarıTemizle();
                TelefonlarıListele();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void TelefonlarıListele()
        {

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM İletisim where OGRENCIID = @id";
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataTelefon.DataSource = dt;
                dataTelefon.Columns[0].Visible = false;
                dataTelefon.Columns[1].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void AlanlarıTemizle()
        {
            try
            {
                txtTelefon.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void AktifMüsteriyetelefonEkle()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO İletisim(OGRENCIID,TELEFON) VALUES(@oid,@tel)";
                cmd.Parameters.AddWithValue("@oid", txtId.Text);
                cmd.Parameters.AddWithValue("@tel", txtTelefon.Text);
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Telefon ekleme işlemi başarılı", "Eposta Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Telefon ekleme işlemi başarısız!...", "Eposta Ekle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void dataTelefon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // TelefonBilgileriniGetir();
                lblTelId.Text = dataTelefon.CurrentRow.Cells[0].Value.ToString();
                txtTelefon.Text = dataTelefon.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void TelefonBilgileriniGetir()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * From İletisim Where  OGRENCIID=@id";
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataTelefon.DataSource = dt;
                dataTelefon.Columns[0].Visible = false;
                dataTelefon.Columns[1].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap = MessageBox.Show(" MÜsteriyi silmek istedigine eminmisiniz  ", "Müsteri Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (cevap == DialogResult.Yes)
                {
                    MüsteriTelefonSil();
                }
                TelefonlarıListele();
            }
            catch (Exception ex) 
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void MüsteriTelefonSil()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM İletisim  WHERE ID=@id";
                cmd.Parameters.AddWithValue("@id", lblTelId.Text);
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Telefon silme işlemi başarılı", "Telefon Sil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Telefon silme işlemi başarısız!...", "Telefon Sil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap = MessageBox.Show("Güncellemek istiyormusunuz", " Telefon Güncelle", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (cevap == DialogResult.Yes)
                {
                    TelefonGüncelle();
                }
                TelefonlarıListele();
            }
            catch (Exception  ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void TelefonGüncelle()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE İletisim SET OGRENCIID = @oid,TELEFON = @tel   WHERE ID=@id";
                cmd.Parameters.AddWithValue("@oid", txtId.Text);
                cmd.Parameters.AddWithValue("@tel", txtTelefon.Text);
                cmd.Parameters.AddWithValue("@id", lblTelId.Text);
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Telefon güncelleme işlemi başarılı", "Telefon Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Telefon güncelleme işlemi başarısız!...", "Telefon Ekle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }



    }
}
