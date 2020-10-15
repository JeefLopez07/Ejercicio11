using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1_Herencia
{
    class Bateador : JugadorBeisbol
    {
        public Bateador(int intNumeroJugador, string strNombre,int intHits) : base(intNumeroJugador, strNombre)
        {
            this.intNumeroJugador = intNumeroJugador;
            this.strNombre = strNombre;
            _intHits = intHits;
        }

        private int _intHits;
        private int intNumeroJugador;
        private string strNombre;

        public int Hits
        {
            get { return _intHits; }
            set { _intHits = value; }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n La cantidad de Hits son: {Hits}";
        }

    }
}
