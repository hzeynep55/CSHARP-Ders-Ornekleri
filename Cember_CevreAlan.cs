using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace daireninAlani_veCevresi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double piSayisi = 3, yaricap, cemberCevre, cemberAlan;
            yaricap = Convert.ToDouble(textBox1.Text);
            cemberCevre = 2 * piSayisi * yaricap;
            cemberAlan = 2 * piSayisi * (yaricap * yaricap);
            lblCevre.Text = "Çamberin çevresi" + " " + cemberCevre + " " + "dir.";
            lblAlan.Text= "Çamberin alanı" + " " + cemberAlan + " " + "dir.";
        }
    }
}
