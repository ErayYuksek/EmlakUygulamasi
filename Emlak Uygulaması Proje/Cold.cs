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
    public partial class Cold : Form
    {
        public Cold()
        {
            InitializeComponent();
            label1.Text = "Ok Yönleri İle Resim Degiştirebilirsiniz";
        }

        private void btnSag_Click(object sender, EventArgs e)
        {
            sayı++;

            if (sayı == 1)
            {
                pcr1.Visible = true;
                Pcr2.Visible = false;
                Pcr3.Visible = false;
                Pcr4.Visible = false;
                Pcr5.Visible = false;

                label1.Text = " 1. Resmi Görüntülüyorsunuz ";

            }
            if (sayı == 2)
            {
                pcr1.Visible = false;
                Pcr2.Visible = true;
                Pcr3.Visible = false;
                Pcr4.Visible = false;
                Pcr5.Visible = false;

                label1.Text = " 2. Resmi Görüntülüyorsunuz ";

            }
            if (sayı == 3)
            {
                pcr1.Visible = false;
                Pcr2.Visible = false;
                Pcr3.Visible = true;
                Pcr4.Visible = false;
                Pcr5.Visible = false;

                label1.Text = " 3. Resmi Görüntülüyorsunuz ";

            }
            if (sayı == 4)
            {

                pcr1.Visible = false;
                Pcr2.Visible = false;
                Pcr3.Visible = false;
                Pcr4.Visible = true;
                Pcr5.Visible = false;

                label1.Text = " 4. Resmi Görüntülüyorsunuz ";
            }
            if (sayı == 5)
            {
                pcr1.Visible = false;
                Pcr2.Visible = false;
                Pcr3.Visible = false;
                Pcr4.Visible = false;
                Pcr5.Visible = true;

                label1.Text = " 5. Resmi Görüntülüyorsunuz ";
            }
        }
        int sayı = 0;

        private void Cold_Load(object sender, EventArgs e)
        {
          
           
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            sayı--;

            if (sayı == 1)
            {
                pcr1.Visible = true;
                Pcr2.Visible = false;
                Pcr3.Visible = false;
                Pcr4.Visible = false;
                Pcr5.Visible = false;
            
                label1.Text = " 1. Resmi Görüntülüyorsunuz ";

            }
            if (sayı == 2)
            {
                pcr1.Visible = false;
                Pcr2.Visible = true;
                Pcr3.Visible = false;
                Pcr4.Visible = false;
                Pcr5.Visible = false;
              
                label1.Text = " 2. Resmi Görüntülüyorsunuz ";

            }
            if (sayı == 3)
            {
                pcr1.Visible = false;
                Pcr2.Visible = false;
                Pcr3.Visible = true;
                Pcr4.Visible = false;
                Pcr5.Visible = false;
          
                label1.Text = " 3. Resmi Görüntülüyorsunuz ";

            }
            if (sayı == 4)
            {

                pcr1.Visible = false;
                Pcr2.Visible = false;
                Pcr3.Visible = false;
                Pcr4.Visible = true;
                Pcr5.Visible = false;

                label1.Text = " 4. Resmi Görüntülüyorsunuz ";
            }
            if (sayı == 5)
            {
                pcr1.Visible = false;
                Pcr2.Visible = false;
                Pcr3.Visible = false;
                Pcr4.Visible = false;
                Pcr5.Visible = true;
       
                label1.Text = " 5. Resmi Görüntülüyorsunuz ";
            }
           
        }
    }
}
