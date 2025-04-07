using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polinomio
{
    class Termo : IComparable<Termo>
    {

        private double coeficiente;
        private byte expoente;

        public Termo(double coeficiente, byte expoente)
        {
            this.coeficiente = coeficiente;
            this.expoente = expoente;
        }

        public int CompareTo(Termo obj)
        {
            return expoente.CompareTo(obj.expoente);
        }


    }
}
