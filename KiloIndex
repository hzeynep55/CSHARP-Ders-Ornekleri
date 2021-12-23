using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double  kilo, boy, indeks;
            kilo = Convert.ToDouble(txtkilo.Text);
            boy = Convert.ToDouble(txtboy.Text);
            indeks = kilo / (boy * boy);

            if (indeks < 18.5)
            {
                MessageBox.Show("Düşük Kilolusunuz.");

            }
            else if (indeks >= 18.5 || indeks <= 24.9)
            {
                MessageBox.Show("Normal Kilodasınıız.");

            }
            else if (indeks > 24.9 || indeks < 30)
            {
                MessageBox.Show("Fazla kilolusunuz.");

            }
            else if (indeks > 29.9 || indeks < 40)
            {
                MessageBox.Show("Obezsiniz.");

            }
            else
            {
                MessageBox.Show("Aşırı obezsiniz");

            }
            lblindeks.Text = "Kilo-boy indeksiniz" + " " + indeks;
        }
    }
}
