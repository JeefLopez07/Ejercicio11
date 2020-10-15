using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1_Herencia
{
   abstract class Persona
   {
        public Persona(string strNombre,string strDomicilio)
        {
            _strNombre = strNombre;
            _strDomicilio = strDomicilio;
        }

        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        private string  _strDomicilio;

        public string  Domicilio
        {
            get { return _strDomicilio; }
            set { _strDomicilio = value; }
        }

        public override string ToString()
        {
            return $"Nombre de la Persona es: {Nombre}\n El Domicilio de la Persona es: {Domicilio} ";
        }
    }
}   
