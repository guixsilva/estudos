using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoListaLigada
{
    internal class NoLista<Dado> where Dado: IComparable<Dado>
    {
        Dado info;
        NoLista<Dado> proximo;

        public NoLista(Dado info)
        {
            this.info = info;
            this.proximo = null;
        }

        public Dado Info { get => info; set => info = value; }
        internal NoLista<Dado> Proximo { get => proximo; set => proximo = value; }
    }
}
