using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoListaLigada
{
    internal class ListaLigada<Dado> where Dado : IComparable<Dado>
    {
        NoLista<Dado> primeiro;
        NoLista<Dado> ultimo;
        int quantos;

        public ListaLigada()
        {
            primeiro = ultimo = null;
            quantos = 0;
        }

        public bool EstaVazia
        {
            get
            {
                if(primeiro == null)
                {
                    return true;
                }
                return false;
            }
        }

        public void IncluirAposFim(Dado dado)
        {
            NoLista<Dado> novoNo = new NoLista<Dado>(dado);
            if (EstaVazia)
            {
                primeiro = novoNo;
                ultimo = novoNo;
                quantos++;
            }
            else
            {
                ultimo.Proximo = novoNo;
                ultimo =novoNo;
                quantos++;
            }
        }

        public void IncluirAntesDoInicio(Dado dado)
        {
            NoLista<Dado> novoNo = new NoLista<Dado>(dado);

            if (EstaVazia)
            {
                primeiro = novoNo;
                ultimo = novoNo;
                primeiro = novoNo;
                quantos++;
            }
            else
            {
                novoNo.Proximo = primeiro;
                primeiro = novoNo;
                quantos++;
            }
        }

        public void ExibirLista()
        {
            var atual = primeiro;
            while(atual != null)
            {
                Console.Write(atual.Info);
                atual = atual.Proximo;
            }
        }
    }
}
