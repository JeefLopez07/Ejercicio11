using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1_Herencia
{
    class Platillo: PlatilloRestaurante
    {
        public Platillo(string strNombre, double dblPrecio): base(strNombre)
        {
            _dblPrecio = dblPrecio;
        }

        private double _dblPrecio;

        public double Precio
        {
            get { return _dblPrecio; }
            set { _dblPrecio = value; }
        }

        private bool _boolCarne;

        public bool Carne
        {
            get { return _boolCarne; }
            set { _boolCarne = value; }
        }


        public override string ToString()
        {
            return $"{base.ToString()}\nEl precio del platillo es:{Precio}";
        }

    }
}
