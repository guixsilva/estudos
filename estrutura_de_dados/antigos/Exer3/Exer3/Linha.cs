using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer3
{
    internal class Linha : IComparable<Linha>
    {

        public int linha;

        public Linha(int linha)
        {
            this.linha = linha;
        }

        public int CompareTo(Linha? other)
        {
            throw new NotImplementedException();
        }


    }
}
