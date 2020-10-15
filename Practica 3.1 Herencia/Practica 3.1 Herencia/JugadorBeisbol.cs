using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3._1_Herencia
{
    class JugadorBeisbol
    {
        public JugadorBeisbol (int intNumeroJugador, string strNombre)
        {
            _intNumeroJugador = intNumeroJugador;
            _strNombre = strNombre;
        }

        private int _intNumeroJugador;

        public int NumeroJugador
        {
            get { return _intNumeroJugador; }
            set { _intNumeroJugador = value; }
        }

        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        public override string ToString()
        {
            return $"El Numero del Jugador es: {NumeroJugador}\n El Nombre del Jugador es: {Nombre}";
        }
    }
}
