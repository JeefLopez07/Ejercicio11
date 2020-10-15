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
    public partial class Ejer11 : Form
    {
        public Ejer11()
        {
            InitializeComponent();
        }

        Platillo miPlatilloFuerte;
        Platillo miEnsalada;
        Platillo miSopa;
        Platillo miPostre;
        Platillo miBebida;

            bool Carne;
        

        private void Ejer11_Load(object sender, EventArgs e)
        {
            chkCarne.Enabled = false;
            chkCuchillo.Enabled = false;
            chkSalero.Enabled = false;
            chkPollo.Enabled = false;
            chkCuchara.Enabled = false;
            chkTenedor.Enabled = false;

            chkCocaPopote.Enabled = false;
            chkAzucar.Enabled = false;
            chkCocaVaso.Enabled = false;


         
        }

        private void rdbPlatilloFuerte_CheckedChanged(object sender, EventArgs e)
        {
            chkPollo.Enabled = true;
            chkCarne.Enabled = true;
            chkSalero.Enabled = true;
            chkTenedor.Enabled = true;
            chkCuchillo.Enabled = true;
            chkCuchara.Enabled = false;
            chkAzucar.Enabled = false;
            chkCocaPopote.Enabled = false;
            chkCocaVaso.Enabled = false;
        }

        private void rdbEnsalada_CheckedChanged(object sender, EventArgs e)
        {
            chkPollo.Enabled = true;
            chkSalero.Enabled = true;
            chkTenedor.Enabled = true;
            chkCuchillo.Enabled = true;
            chkCuchara.Enabled = false;
            chkAzucar.Enabled = false;
            chkCocaPopote.Enabled = false;
            chkCocaVaso.Enabled = false;
            chkCarne.Enabled = false;
        }

        private void rdbSopa_CheckedChanged(object sender, EventArgs e)
        {
            chkPollo.Enabled = true;
            chkSalero.Enabled = true;
            chkCuchara.Enabled = true;
            chkAzucar.Enabled = false;
            chkCocaPopote.Enabled = false;
            chkCocaVaso.Enabled = false;
            chkCarne.Enabled = false;
            chkCuchillo.Enabled = false;
            chkTenedor.Enabled = false;
        }

        private void rdbPostres_CheckedChanged(object sender, EventArgs e)
        {
            chkAzucar.Enabled = true;
            chkTenedor.Enabled = true;
            chkCuchara.Checked = true;
            chkCocaPopote.Enabled = false;
            chkCocaVaso.Enabled = false;
            chkCarne.Enabled = false;
            chkCuchillo.Enabled = false;
            chkSalero.Enabled = false;
            chkPollo.Enabled = false;
        }

        private void rdbBedida_CheckedChanged(object sender, EventArgs e)
        {
            chkAzucar.Enabled = true;
            chkCocaVaso.Enabled = true;
            chkCocaPopote.Enabled = true;
            chkCarne.Enabled = false;
            chkCuchillo.Enabled = false;
            chkSalero.Enabled = false;
            chkPollo.Enabled = false;
            chkCuchara.Enabled = false;
            chkTenedor.Enabled = false;
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {

            if (rdbPlatilloFuerte.Checked)
            {
                miPlatilloFuerte = new Platillo(txtNombre.Text, double.Parse(txtPrecio.Text));
                miPlatilloFuerte.Carne = chkCarne.Checked;
            }
            if (rdbEnsalada.Checked)
            {
                miEnsalada = new Platillo(txtNombre.Text, double.Parse(txtPrecio.Text));
            }
            if (rdbSopa.Checked)
            {
                miSopa = new Platillo(txtNombre.Text, double.Parse(txtPrecio.Text));
            }
            if (rdbPostres.Checked)
            {
                miPostre = new Platillo(txtNombre.Text, double.Parse(txtPrecio.Text));

            }
            if (rdbBedida.Checked)
            {
                miBebida = new Platillo(txtNombre.Text, double.Parse(txtPrecio.Text));
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (rdbPlatilloFuerte.Checked)
            {
              MessageBox.Show(miPlatilloFuerte.ToString(),"Platillo Fuerte",MessageBoxButtons.OK,MessageBoxIcon.Information);
                MessageBox.Show(chkCarne.Text);
            }
            if (rdbEnsalada.Checked)
            {
                MessageBox.Show(miEnsalada.ToString(), "Ensalada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rdbSopa.Checked)
            {
                MessageBox.Show(miSopa.ToString(), "Sopa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rdbPostres.Checked)
            {
                MessageBox.Show(miPostre.ToString(), "Postre", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rdbBedida.Checked)
            {
                MessageBox.Show(miBebida.ToString(), "Bebida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
