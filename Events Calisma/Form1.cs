using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events_Calisma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBirimFiyati.Text ="0" ;
            rdbBeyazEsya.Checked = true;
            txtKdv.Enabled = false;
            txtTutar.Enabled = false;

        }
        private void txtBirimFiyati_TextChanged(object sender, EventArgs e)
        {
            
                double birimFiyati = Convert.ToDouble(txtBirimFiyati.Text);
                double adet = Convert.ToDouble(nudAdet.Value);
                double tutar = birimFiyati * adet;
                double kdv = 0;
                if (rdbBeyazEsya.Checked == true)
                {
                    kdv = tutar * 0.25;
                }
                else if (rdbKirtsasiye.Checked == true)
                {
                    kdv = tutar * 0.18;
                }
                else
                {
                    kdv = tutar * 0.08;
                }
                tutar = tutar + kdv;
                if (chkBayi.Checked == true)
                {
                    tutar = tutar - (tutar * 0.1);

                }
                txtKdv.Text = kdv.ToString();
                txtTutar.Text = tutar.ToString();


            


        }
    }
}
