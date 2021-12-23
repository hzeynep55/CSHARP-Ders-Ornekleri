using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasHarf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Kelime sesli harf ile başlıyorsa listbox1'e eklenecek. Sessiz harf ile başlıyorsa listbox2'te eklenecek.
        private void button1_Click(object sender, EventArgs e)
        {
            string isim = textBox1.Text;
            string basharf = isim.Substring(0,1);
            if (basharf=="A"|| basharf=="a"||
                basharf == "E" || basharf == "e" ||
                basharf == "I" || basharf == "ı" ||
                basharf == "İ" || basharf == "i" ||
                basharf == "O" || basharf == "o" ||
                basharf == "Ö" || basharf == "ö" ||
                basharf == "U" || basharf == "u" ||
                basharf == "Ü" || basharf == "ü" )
            {
                listBox1.Items.Add(isim);
                textBox1.Clear();
            }
            else
            {
                listBox2.Items.Add(isim);
                textBox1.Clear();
            }
        }
    }
}
