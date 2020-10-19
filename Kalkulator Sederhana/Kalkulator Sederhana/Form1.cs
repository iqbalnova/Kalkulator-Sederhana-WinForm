using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_Sederhana
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btambah_Click(object sender, EventArgs e)
        {
            double nilai1, nilai2, hasil;
            nilai1 = double.Parse(tnilai1.Text);
            nilai2 = double.Parse(tnilai2.Text);
            hasil = nilai1 + nilai2;
            thasil.Text = hasil.ToString();
          
        }

        private void bkurang_Click(object sender, EventArgs e)
        {
            double nilai1, nilai2, hasil;
            nilai1 = double.Parse(tnilai1.Text);
            nilai2 = double.Parse(tnilai2.Text);
            hasil = nilai1 - nilai2;
            thasil.Text = hasil.ToString();
        }

        private void hasil_TextChanged(object sender, EventArgs e)
        {

        }

        private void bkali_Click(object sender, EventArgs e)
        {
            double nilai1, nilai2, hasil;
            nilai1 = double.Parse(tnilai1.Text);
            nilai2 = double.Parse(tnilai2.Text);
            hasil = nilai1 * nilai2;
            thasil.Text = hasil.ToString();
        }

        private void bbagi_Click(object sender, EventArgs e)
        {
            double nilai1, nilai2, hasil;
            nilai1 = double.Parse(tnilai1.Text);
            nilai2 = double.Parse(tnilai2.Text);
            hasil = nilai1 / nilai2;
            thasil.Text = hasil.ToString();
        }

        private void kosongkan_Click(object sender, EventArgs e)
        {
            tnilai1.Clear();
            tnilai2.Clear();
            thasil.Text = " ";
        }

        private void keluar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
