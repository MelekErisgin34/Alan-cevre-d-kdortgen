using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dikdörtgen_Alan_Çevre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            float kısakenar, uzunkenar, cevre,alan;
            kısakenar=Convert.ToSingle(txtKısakenar.Text);
            uzunkenar=Convert.ToSingle(txtUzunkenar.Text);
            cevre = (kısakenar + uzunkenar)*2;
            txtCevre.Text = cevre.ToString();
            alan = kısakenar * uzunkenar;
            textBox2.Text = alan.ToString();

        }

    }
}
