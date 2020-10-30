using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProxy_P4_20180140072_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int hasil;
            hasil = 1 + 2;
            label2.Text = hasil.ToString();
            hasil = 3 - 2;
            label4.Text = hasil.ToString();
            hasil = 2 * 2;
            label6.Text = hasil.ToString();
            hasil = 2 / 2;
            label8.Text = hasil.ToString();

            double aX = 7;
            double aY = 8;

            double bX = 5;
            double bY = 6;
            double selisihX = aX - bX;
            double selisihY = aY - bY;
            double jarak = Math.Sqrt(Math.Pow(selisihX, 2) + Math.Pow(selisihY, 2));
            label10.Text = jarak.ToString();

        }
    }
}
