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
    public partial class Ejer1 : Form
    {
        Libro unLibro;
        CD unCD;
        public Ejer1()
        {
            InitializeComponent();
        }

        private void radLibroImpreso_CheckedChanged(object sender, EventArgs e)
        {
            if (radLibroImpreso.Checked)
            {
                txtPaginas.Enabled = true;
                txtTiempo.Enabled = false;
                lbVentasLibro.Visible = true;
                lbVentasCD.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RadAudioLibro_CheckedChanged(object sender, EventArgs e)
        {
            if (RadAudioLibro.Checked)
            {
                txtTiempo.Enabled = true;
                txtPaginas.Enabled = false;
                lbVentasCD.Visible = true;
                lbVentasLibro.Visible = false;
            }
        }

        private void Ejercicio_1_Load(object sender, EventArgs e)
        {
            txtPaginas.Enabled = false;
            txtTiempo.Enabled = false;
        }

        private void btnCapturarDatos_Click(object sender, EventArgs e)
        {
            if (radLibroImpreso.Checked)
            {
                unLibro = new Libro();
                unLibro.Titulo = txtTitulo.Text;
                unLibro.Precio = double.Parse(txtPrecio.Text);
                unLibro.Paginas = int.Parse(txtPaginas.Text);
            }
            if (RadAudioLibro.Checked)
            {
                unCD = new CD();
                unCD.Titulo = txtTitulo.Text;
                unCD.Precio = double.Parse(txtPrecio.Text);
                unCD.Tiempo = double.Parse(txtTiempo.Text);
            }
            foreach (Control x in gpbDatos.Controls)
                if (x is TextBox)
                    x.Text = "";
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            if (radLibroImpreso.Checked)
            {
                for (int i = 0; i < 3; i++)
                {
                    unLibro[i] = double.Parse(lbVentasLibro.Items[i].ToString());
                }
                 MessageBox.Show(unLibro.ToString(), "Libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (RadAudioLibro.Checked)
            {
                for (int i = 0; i < 3; i++)
                {
                    unLibro[i] = double.Parse(lbVentasCD.Items[i].ToString());
                }

                MessageBox.Show(unLibro.ToString(),"CD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCapturarVenta_Click(object sender, EventArgs e)
        {
            if (radLibroImpreso.Checked)
            {
                lbVentasLibro.Items.Add(txtVenta.Text);
                
            }

            if (RadAudioLibro.Checked)
            {
                lbVentasCD.Items.Add(txtVenta.Text);
                
            }
            txtVenta.Clear();
        }
    }
}
