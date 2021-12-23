using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForDongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Hesaplabtn_Click(object sender, EventArgs e)
        {
            int bsayi = Convert.ToInt32(txtbaslangic.Text);
            int bisayi = Convert.ToInt32(txtBitis.Text);
            int topla=0;
            if (bsayi > bisayi)
            {
                MessageBox.Show("Başlangış değeri bitiş değerinden küçük olamaz");
            }
            else
            for (int i=bsayi; i<bisayi+1; i++)
            {
                topla += i;
            }
            label3.Text = topla.ToString();
            listBox1.Items.Add(label3.Text);
               

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtbaslangic.Clear();
            txtBitis.Clear();
        }

        private void btnkuvvetalma_Click(object sender, EventArgs e)

        {
            double kuvvet;
            for(int j=0; j<21; j++)
            {
                kuvvet = Math.Pow(2, j);
                listBox2.Items.Add(kuvvet);
            }
        }
    }
}
