using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Emlak_Uygulaması_Proje
{
    public partial class FormMusteri : Form
    {
        public FormMusteri()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Server=ERAY\SQLEXPRESS;Database=Emlakcım; Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {

                MusteriBilgileriniListele();
                ListeyiDüzenle();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void ListeyiDüzenle()
        {
            try
            {

                dataGridViewMüsteri.RowHeadersVisible = true;
                dataGridViewMüsteri.AlternatingRowsDefaultCellStyle.BackColor = Color.RosyBrown;
                dataGridViewMüsteri.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
                dataGridViewMüsteri.DefaultCellStyle.SelectionForeColor = Color.Black;
                dataGridViewMüsteri.EnableHeadersVisualStyles = false;
                dataGridViewMüsteri.ColumnHeadersDefaultCellStyle.BackColor = Color.SandyBrown;
                dataGridViewMüsteri.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MusteriBilgileriniListele()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from Müsteri";
                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                Da.Fill(dt);
                dataGridViewMüsteri.DataSource = dt;
                dataGridViewMüsteri.Columns[0].Visible = false;
                dataGridViewMüsteri.Columns[4].Visible = false;
                dataGridViewMüsteri.Columns[1].Width = 60;
                dataGridViewMüsteri.Columns[2].Width = 60;
                dataGridViewMüsteri.Columns[3].Width = 60;
                dataGridViewMüsteri.Columns[5].Width = 60;
                dataGridViewMüsteri.Columns[6].Width = 60;
                dataGridViewMüsteri.Columns[7].Width = 60;
                dataGridViewMüsteri.Columns[8].Width = 60;
                dataGridViewMüsteri.Columns[9].Width = 60;
                dataGridViewMüsteri.Columns[10].Width = 70;
                dataGridViewMüsteri.Columns[11].Width = 50;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); ;
            }
        }



        private void MüsteriResimYükle()
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                file.ShowDialog();
                pcrResim.ImageLocation = file.FileName;
                textBox1.Text = file.FileName;
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
                txtID.Clear();
                txtAd.Clear();
                txtSoyad.Clear();
                txtOdaSayısı.Text = "";
                txtkat.Text = "";
                txtFiyat.Text = "";
                txtCınsıyet.Text = "";
                txtCephe.Text = "";
                txtSiteAdı.Text = "";
                textBox1.Clear();
                txtAd.Focus();
                pcrResim.Image = null;
                txtBlok.Text = "";
                txtMetre.Text = "";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void YeniMüsteri()
        {
            try
            {
                if (pcrResim.Image == null)
                {
                    if (txtAd.Text == "" && txtBlok.Text == "" && txtCephe.Text == "" && txtCınsıyet.Text == "" && txtFiyat.Text == "" && txtkat.Text == "" && txtMetre.Text == "" && txtOdaSayısı.Text == "" && txtSiteAdı.Text == "" && txtSoyad.Text == "")
                    {
                        MessageBox.Show("Boş Alan Bırakmayınız Lütfen", "Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Insert Into Müsteri(Ad,Soyad,Cinsiyet,Foto,SiteAdı,OdaSayısı,KatSayısı,Cephe,Blok,MetreKare,Fiyat) values (@ad,@soy,@cins,@foto,@site,@oda,@kat,@cephe,@Blok,@MetreKare,@fiyat)";
                    cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                    cmd.Parameters.AddWithValue("@soy", txtSoyad.Text);
                    cmd.Parameters.AddWithValue("@cins", txtCınsıyet.Text);
                    cmd.Parameters.AddWithValue("@foto", textBox1.Text);
                    cmd.Parameters.AddWithValue("@site", txtSiteAdı.Text);
                    cmd.Parameters.AddWithValue("@oda", txtOdaSayısı.Text);
                    cmd.Parameters.AddWithValue("@kat", txtkat.Text);
                    cmd.Parameters.AddWithValue("@cephe", txtCephe.Text);
                    cmd.Parameters.AddWithValue("@Blok", txtBlok.Text);
                    cmd.Parameters.AddWithValue("@MetreKare", txtMetre.Text);
                    cmd.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
                    conn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Müşteri Ekleme İşlemi Başarılı", "Müşteri Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Müşteri Ekleme İşlemi Başarısız", "Müşteri Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void MüsteriSil()
        {
            try
            {
                DialogResult cevap = MessageBox.Show("Silmek İstediginizden Eminmisiniz", "Müşteri Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == cevap)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Delete from Müsteri Where ID=@id";
                    cmd.Parameters.AddWithValue("@id", txtID.Text);
                    conn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Silme işlemi Başarılı", "Kayıt Sil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridViewMüsteri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MüsteriBilgileriniGetir();
            ListeyiDüzenle();
            // data grid view aldıklarını textboxlarına yerleştirir
        }

        private void MüsteriBilgileriniGetir()
        {
            try
            {
                txtID.Text = dataGridViewMüsteri.CurrentRow.Cells[0].Value.ToString();
                txtAd.Text = dataGridViewMüsteri.CurrentRow.Cells[1].Value.ToString();
                txtSoyad.Text = dataGridViewMüsteri.CurrentRow.Cells[2].Value.ToString();
                txtCınsıyet.Text = dataGridViewMüsteri.CurrentRow.Cells[3].Value.ToString();
                textBox1.Text = dataGridViewMüsteri.CurrentRow.Cells[4].Value.ToString();
                txtSiteAdı.Text = dataGridViewMüsteri.CurrentRow.Cells[5].Value.ToString();
                txtOdaSayısı.Text = dataGridViewMüsteri.CurrentRow.Cells[6].Value.ToString();
                txtkat.Text = dataGridViewMüsteri.CurrentRow.Cells[7].Value.ToString();
                txtCephe.Text = dataGridViewMüsteri.CurrentRow.Cells[8].Value.ToString();
                txtBlok.Text = dataGridViewMüsteri.CurrentRow.Cells[9].Value.ToString();
                txtMetre.Text = dataGridViewMüsteri.CurrentRow.Cells[10].Value.ToString();
                txtFiyat.Text = dataGridViewMüsteri.CurrentRow.Cells[11].Value.ToString();

                pcrResim.Image = Image.FromFile(textBox1.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            try
            {
                YeniMüsteri();
                MusteriBilgileriniListele();
                AlanlarıTemizle();
                MusteriBilgileriniListele();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }



        private void MusteriBilgileriGüncele()
        {
            try
            {
                DialogResult cevap = MessageBox.Show("Güncellemek İstediginizden Eminmisiniz", "Kayıt Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == cevap)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Update Müsteri set Ad=@ad ,Soyad=@soy,Cinsiyet=@cins,Foto=@foto,SiteAdı=@site,OdaSayısı=@oda,KatSayısı=@kat,Cephe=@cephe,MetreKare=@metre,Fiyat=@fiyat Where ID=@id";
                    cmd.Parameters.AddWithValue("@id", txtID.Text);
                    cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                    cmd.Parameters.AddWithValue("@soy", txtSoyad.Text);
                    cmd.Parameters.AddWithValue("@cins", txtCınsıyet.Text);
                    cmd.Parameters.AddWithValue("@foto", textBox1.Text);
                    cmd.Parameters.AddWithValue("@site", txtSiteAdı.Text);
                    cmd.Parameters.AddWithValue("@oda", txtOdaSayısı.Text);
                    cmd.Parameters.AddWithValue("@kat", txtkat.Text);
                    cmd.Parameters.AddWithValue("@cephe", txtCephe.Text);
                    cmd.Parameters.AddWithValue("@Blok", txtBlok.Text);
                    cmd.Parameters.AddWithValue("@Metre", txtMetre.Text);
                    cmd.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
                    conn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Müşteri Güncelleme Başarılı", "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Müşteri Güncelleme Başarısız", "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }



        private void BilgileriGöster()
        {
            try
            {
                if (btnKayıtGöster.Text == ">>")
                {
                    groupBox1.Visible = true;
                    this.Width = 1075;


                    btnKayıtGöster.Text = "<<";

                }
                else
                {
                    BilgileriGizle();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void BilgileriGizle()
        {
            try
            {
                groupBox1.Visible = false;
                this.Width = 420;
                btnKayıtGöster.Text = ">>";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnYeni_Click_1(object sender, EventArgs e)
        {
            try
            {
                AlanlarıTemizle();
                MusteriBilgileriniListele();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            try
            {
                MüsteriResimYükle();
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
                YeniMüsteri();
                AlanlarıTemizle();
                MusteriBilgileriniListele();
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
                MüsteriSil();
                MusteriBilgileriniListele();
                AlanlarıTemizle();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                MusteriBilgileriGüncele();
                MusteriBilgileriniListele();
                AlanlarıTemizle();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnKayıtGöster_Click(object sender, EventArgs e)
        {
            try
            {
                BilgileriGöster();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewMüsteri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MüsteriBilgileriniGetir();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnTlfon_Click(object sender, EventArgs e)
        {
            try
            {
                KonutResimleri frmKonut = new KonutResimleri();
                frmKonut.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtSiteAdı_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEposta_Click(object sender, EventArgs e)
        {
            try
            {
                İletisim frmiletisim = new İletisim();
                frmiletisim.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnHakkında_Click(object sender, EventArgs e)
        {
            try
            {
                Hakkında frmHakkında = new Hakkında();
                frmHakkında.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Kartvizit frmkartvizit = new Kartvizit();
                frmkartvizit.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }

}
