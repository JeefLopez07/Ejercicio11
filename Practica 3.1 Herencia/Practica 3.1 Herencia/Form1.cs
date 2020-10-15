using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3._1_Herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ejer1 problema1 = new Ejer1();
           
            problema1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEjer5_Click(object sender, EventArgs e)
        {
            Ejer5 problema5 = new Ejer5();
            problema5.Show();
        }

        private void btnEjer6_Click(object sender, EventArgs e)
        {
            Ejer6 problema6 = new Ejer6();
            problema6.Show();
        }

        private void btnEjer7_Click(object sender, EventArgs e)
        {
            Ejer7 problema7 = new Ejer7();
            problema7.Show();
        }

        private void btnEjer8_Click(object sender, EventArgs e)
        {
            Ejer8 problema8 =new Ejer8();
            problema8.Show();
        }

        private void btnEjer11_Click(object sender, EventArgs e)
        {
            Ejer11 problema11 = new Ejer11();
            problema11.Show();
        }
    }
}
