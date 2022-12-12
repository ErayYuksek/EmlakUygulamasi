using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak_Uygulaması_Proje
{
    public partial class Time : Form
    {
        public Time()
        {
            InitializeComponent();
        }
        int sayı = 0;
        private void btnSol_Click(object sender, EventArgs e)
        {
            sayı--;

            if (sayı == 1)
            {
                
                Pcr2.Visible = true;
                Pcr3.Visible = false;
                Pcr5.Visible = false;
                Pcr6.Visible = false;
                label1.Text = " 1. Resmi Görüntülüyorsunuz ";

            }
            if (sayı == 2)
            {
                Pcr2.Visible = false;
                Pcr3.Visible = true;
                Pcr5.Visible = false;
                Pcr6.Visible = false;
                label1.Text = " 2. Resmi Görüntülüyorsunuz ";

            }
            if (sayı == 3)
            {
                Pcr2.Visible = false;
                Pcr3.Visible = false;
                Pcr5.Visible = true;
                Pcr6.Visible = false;

                label1.Text = " 3. Resmi Görüntülüyorsunuz ";

            }
            if (sayı == 4)
            {
                Pcr2.Visible = false;
                Pcr3.Visible = false;
                Pcr5.Visible = false;
                Pcr6.Visible = true;

                label1.Text = " 4. Resmi Görüntülüyorsunuz ";
            }
            
        }

        private void btnSag_Click(object sender, EventArgs e)
        {

            sayı++;

            if (sayı == 1)
            {

                Pcr2.Visible = true;
                Pcr3.Visible = false;
                Pcr5.Visible = false;
                Pcr6.Visible = false;
                label1.Text = " 1. Resmi Görüntülüyorsunuz ";

            }
            if (sayı == 2)
            {
                Pcr2.Visible = false;
                Pcr3.Visible = true;
                Pcr5.Visible = false;
                Pcr6.Visible = false;
                label1.Text = " 2. Resmi Görüntülüyorsunuz ";

            }
            if (sayı == 3)
            {
                Pcr2.Visible = false;
                Pcr3.Visible = false;
                Pcr5.Visible = true;
                Pcr6.Visible = false;

                label1.Text = " 3. Resmi Görüntülüyorsunuz ";

            }
            if (sayı == 4)
            {
                Pcr2.Visible = false;
                Pcr3.Visible = false;
                Pcr5.Visible = false;
                Pcr6.Visible = true;

                label1.Text = " 4. Resmi Görüntülüyorsunuz ";
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Time_Load(object sender, EventArgs e)
        {
            label1.Text = "Ok Yönleri İle Resim Degiştirebilirsiniz ";
        }
    }
    }

