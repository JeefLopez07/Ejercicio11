﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1_Herencia
{
    class CD : Publicacion
    {
        private double _dblTiempo;

        public double Tiempo
        {
            get { return _dblTiempo; }
            set { _dblTiempo = value; }
        }

    }
}
