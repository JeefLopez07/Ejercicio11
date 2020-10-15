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
    public partial class Ejer7 : Form
    {
        public Ejer7()
        {
            InitializeComponent();
        }

        Bateador miBateador;
        JugadorPosicion miJugadorPosicion;
        Pitcher miPitcher;

        private void Ejer7_Load(object sender, EventArgs e)
        {
            txtPonches.Enabled = false;
            txtHits.Enabled = false;
            txtErrores.Enabled = false;
        }

        private void rdbPitcher_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPitcher.Checked)
            {
                txtPonches.Enabled = true;
                txtErrores.Enabled = true;
                txtHits.Enabled = false;
            }
        }

        private void rdbJugador_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbJugador.Checked)
            {
                txtHits.Enabled = true;
                txtErrores.Enabled = true;
                txtPonches.Enabled = false;
            }
        }

        private void rdbBateador_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBateador.Checked)
            {
                txtHits.Enabled = true;
                txtErrores.Enabled = false;
                txtPonches.Enabled = false;
            }
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (rdbBateador.Checked)
            {
                miBateador = new Bateador(int.Parse(txtNumeroUniforme.Text),txtNombre.Text,int.Parse(txtHits.Text));
                txtNumeroUniforme.Clear();
                txtNombre.Clear();
                txtErrores.Text = "0";
                txtHits.Text = "0";
                txtPonches.Text="0";
            }
            if (rdbJugador.Checked)
            {
                miJugadorPosicion = new JugadorPosicion(int.Parse(txtNumeroUniforme.Text),txtNombre.Text, int.Parse(txtHits.Text),int.Parse(txtErrores.Text));
                txtNumeroUniforme.Clear();
                txtNombre.Clear();
                txtErrores.Text = "0";
                txtHits.Text = "0";
                txtPonches.Text = "0";
            }
            if (rdbPitcher.Checked)
            {
                miPitcher = new Pitcher(int.Parse(txtNumeroUniforme.Text), txtNombre.Text, int.Parse(txtErrores.Text), int.Parse(txtHits.Text), int.Parse(txtPonches.Text));
                txtNumeroUniforme.Clear();
                txtNombre.Clear();
                txtErrores.Text = "0";
                txtHits.Text = "0";
                txtPonches.Text = "0";
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (rdbBateador.Checked)
            {
                MessageBox.Show(miBateador.ToString(),"Bateador",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if (rdbJugador.Checked)
            {
                MessageBox.Show(miJugadorPosicion.ToString(), "Jugador de Posicion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rdbPitcher.Checked)
            {
                MessageBox.Show(miPitcher.ToString(), "Pitcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
