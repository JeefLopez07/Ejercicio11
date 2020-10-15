using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1_Herencia
{
    class Pitcher : JugadorPosicion
    {
        public Pitcher(int intNumeroJugador, string strNombre,int intErrores,int intHits,int intPonches) : base(intNumeroJugador,strNombre,intErrores,intHits)
        {
            this.NumeroJugador = intNumeroJugador;
            this.Nombre = strNombre;
            _intPonches = intPonches;
        }

        private int _intPonches;

        public int Ponches
        {
            get { return _intPonches; }
            set { _intPonches = value; }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n la cantidad de ponches son: {Ponches}";
        }

    }
}
