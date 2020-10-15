using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1_Herencia
{
    abstract class Publicacion
    {
        private string _strTitulo;

        public string Titulo
        {
            get { return _strTitulo; }
            set { _strTitulo = value; }
        }

        private double _dblPrecio;

        public double Precio
        {
            get { return _dblPrecio; }
            set { _dblPrecio = value; }
        }

        public override string ToString()
        {
            return $"Titulo{Titulo} \nPrecio: {Precio}\nVenta 1: {this[0]} \nVenta 2: {this[1]}\nVenta 3: {this[2]}";
        }

        double[] ventas = new double[3];

        public double this[int intCelda] 
        {
            get { return ventas[intCelda]; }
            set { ventas[intCelda] = value; }
        }

    }
}
