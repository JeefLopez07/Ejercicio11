using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1_Herencia
{
    class Libro : Publicacion
    {
        private int _intPaginas;

        public int Paginas
        {
            get { return _intPaginas; }
            set { _intPaginas = value; }
        }

    }
}
