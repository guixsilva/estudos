using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecBacktracking
{
    public class Movimento: IComparable<Movimento>
    {
        int origem, destino;

        public Movimento(int origem, int destino)
        {
            this.origem = origem;
            this.destino = destino;
        }

        public int Origem { get => origem; set => origem = value; }
        public int Destino { get => destino; set => destino = value; }

        public int CompareTo(Movimento outro)
        {
            return 0;
        }

        public override string ToString()
        {
            return origem + " --> " + destino;
        }
    }
}
