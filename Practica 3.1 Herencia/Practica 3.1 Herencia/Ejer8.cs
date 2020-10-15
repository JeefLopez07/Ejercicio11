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
    
    public partial class Ejer8 : Form
    {
        Empleado UnEmpleado;
        Cliente unCliente;

        public Ejer8()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rdbCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCliente.Checked)
            {
                txtSalario.Enabled = false;
                txtLimiteCredito.Enabled = true;
            }
        }

        private void rdbEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEmpleado.Checked)
            {
                txtSalario.Enabled = true;
                txtLimiteCredito.Enabled = false;
            }
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (rdbCliente.Checked)
            {
                unCliente = new Cliente(int.Parse(txtLimiteCredito.Text),txtNombre.Text,txtDireccion.Text);
            }
            if (rdbEmpleado.Checked)
            {
                UnEmpleado = new Empleado(double.Parse(txtSalario.Text), txtNombre.Text,txtDireccion.Text);
            }

            MessageBox.Show("Los datos fueron capturados correctamente", "Datos"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
        
            clear();
        }

       public void clear()
       {
            foreach (Control x in gbDatos.Controls)
            {
                if (x is TextBox)
                {
                    x.Text = "";
                }
            }
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            if (rdbCliente.Checked)
            {
                MessageBox.Show(unCliente.ToString(),"Cliente",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if (rdbEmpleado.Checked)
            {
                MessageBox.Show(UnEmpleado.ToString(),"Empleado",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void gbDatos_Enter(object sender, EventArgs e)
        {

        }

        private void Ejer8_Load(object sender, EventArgs e)
        {

        }
    }
}
