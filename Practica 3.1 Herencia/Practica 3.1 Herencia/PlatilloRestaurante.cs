using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1_Herencia
{
    class PlatilloRestaurante
    {
        public PlatilloRestaurante(string strNombre)
        {
            _strNombre = strNombre;
        }

        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        public override string ToString()
        {
            return $"EL nombre del Platillo es: {Nombre}";
        }

    }
}
