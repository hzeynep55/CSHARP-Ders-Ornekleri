using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SesSeviyesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int ses = trackBar1.Value;


            if (ses == 0) {

                label1.Text = "Ses Yok!";
                label1.ForeColor = Color.Blue;
                label1.BackColor = Color.Gray;
            }
            else if (ses > 0 && ses < 11) {
                label1.Text = "Normal Ses Düzeyinde";
                label1.ForeColor = Color.Green;
                label1.BackColor = Color.Gray;

            }
            else 
            {
                label1.Text = "Yüksek Ses Düzeyinde";
                label1.ForeColor = Color.Red;
                label1.BackColor = Color.Gray;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            label1.Text = "Ses Yok";

        }
    }
}
