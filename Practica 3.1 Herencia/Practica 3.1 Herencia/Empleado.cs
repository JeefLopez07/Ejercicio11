using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1_Herencia
{
    class Empleado : Persona
    {

        public Empleado(double dblSalario, string strNombre,string strDomicilio) : base(strNombre,strDomicilio)
        {
            _dblSalario = dblSalario;
        }
        private double _dblSalario;

        public double Salario
        {
            get { return _dblSalario; }
            set { _dblSalario = value; }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n El Salario del Empleado es : {Salario}";
        }

    }
}
