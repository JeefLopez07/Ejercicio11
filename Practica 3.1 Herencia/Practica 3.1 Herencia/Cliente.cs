using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1_Herencia
{
    class Cliente :Persona
    {
        public Cliente(int intLimiteCredito, string strNombre, string strDomicilio) : base(strNombre, strDomicilio)
        {
            _intLimiteCredito = intLimiteCredito;
        }

        private int _intLimiteCredito;

        public int LimiteCredito
        {
            get { return _intLimiteCredito; }
            set { _intLimiteCredito = value; }
        }

        public override string ToString()
        {
            return $"{base.ToString()} \n EL Limite de credito del Cliente es: {LimiteCredito}";
        }
    }
}
