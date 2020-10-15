using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1_Herencia
{
    class JugadorPosicion : Bateador
    {
       

        public JugadorPosicion(int intNumeroJugador, string strNombre, int intErrores, int intHits) : base(intNumeroJugador, strNombre,intHits)
        {
            
            _intErrores = intErrores;
        }

        private int _intErrores;
        private int intNumeroJugador;
        private string strNombre;

        public int Errores
        {
            get { return _intErrores; }
            set { _intErrores = value; }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n La Cantidad de Errores son: {Errores}";
        }

    }
}
