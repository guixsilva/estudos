using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer3
{
    internal class Palavras: IComparable<Palavras>
    {

        public string palavra;
        public ListaSimples<Linha> linha;

        public Palavras(string palavra, ListaSimples<Linha> linha)
        {
            this.palavra = palavra;
            this.linha = linha;
        }

        public Palavras(string palavra, int linhanova)
        {
            Palavra = palavra;
            linha = new ListaSimples<Linha>();
            if (linha.EstaVazia)
            {
                Linha novo = new Linha(linhanova);
                linha.InserirAntesDoInicio(novo);
            }
            else
            {
                Linha novo = new Linha(linhanova);
                linha.InserirAposFim(novo);
            }
            Linha = null;
        }

        public string Palavra
        {
            get { return palavra; }
            set { palavra = value; }
        }

        public ListaSimples<Linha> Linha
        {
            get { return linha; }
            set { linha = value; }
        }


        public int CompareTo(Palavras other)
        {
            return String.Compare(this.palavra, other.palavra);
        }
    }
}
