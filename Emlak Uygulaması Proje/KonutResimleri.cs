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
    public partial class KonutResimleri : Form
    {
        public KonutResimleri()
        {
            InitializeComponent();
        }

        private void btnArnova_Click(object sender, EventArgs e)
        {
            try
            {
                Arnova frmArnova = new Arnova();
                frmArnova.ShowDialog();
            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.Message); MessageBox.Show(ex.Message);
            }
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            try
            {
                Time frmTime = new Time();
                frmTime.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCold_Click(object sender, EventArgs e)
        {
            try
            {
                Cold frmCold = new Cold();
                frmCold.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
