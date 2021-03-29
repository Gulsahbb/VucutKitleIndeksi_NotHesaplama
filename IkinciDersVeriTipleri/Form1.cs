using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IkinciDersVeriTipleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vize = Convert.ToInt32(textBox1.Text);
            int final = Convert.ToInt32(textBox2.Text);
            int ortalama = (vize*40/100 + final*60/100);

            textBox3.Text = ortalama.ToString();

            if (ortalama >= 89.5 && ortalama <= 100)
            {
                textBox4.Text = "AA";
            }
            else if (ortalama >= 79.5 && ortalama <= 89.4)
            {
                textBox4.Text = "BA";
            }
            else if (ortalama >= 69.5 && ortalama <= 79.4)
            {
                textBox4.Text = "BB";
            }
            else if (ortalama >= 59.5  && ortalama <= 69.4 )
            {
                textBox4.Text = "BC";
            }
            else if (ortalama >= 49.5 && ortalama <= 59.4)
            {
                textBox4.Text = "CC";
            }
            else if (ortalama >= 39.5 && ortalama <= 49.4)
            {
                textBox4.Text = "DC";
            }
            else if (ortalama >= 0 && ortalama <= 39.4)
            {
                textBox4.Text = "FF";
            }
            else
            {
                textBox4.Text = "HATA";
            }





        }
    }
}
