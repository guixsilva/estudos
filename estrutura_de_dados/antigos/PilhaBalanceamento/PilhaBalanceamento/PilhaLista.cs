using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class PilhaLista<Dado> : iPilha<Dado> where Dado : IComparable<Dado>
    {

    NoLista<Dado> topo;
    int tamanho;

    public PilhaLista()
    {
        topo = null;
        tamanho = 0;
    }

    public bool EstaVazia => topo == null;

    public int Tamanho => tamanho;

    public bool Combinam(char x, char y)
    {
        throw new NotImplementedException();
    }

    public List<Dado> Conteudo()
    {
        var dadosEmpilhados = new List<Dado>();
        NoLista<Dado> atual = topo;

        while(atual != null)
        {
            dadosEmpilhados.Add(atual.Info);
            atual = atual.Prox;
        }

        return dadosEmpilhados;
    }

    public Dado Desempilhar()
    {
        if (EstaVazia)
        {
            throw new Exception("Pilha Vazia");
        }

        var dadoDesempilhado = topo.Info;
        topo = topo.Prox;
        tamanho--;
        return dadoDesempilhado;
    }

    public void Empilhar(Dado dado)
    {
        NoLista<Dado> novoNo = new NoLista<Dado>(dado, topo);
        topo = novoNo;
        tamanho++;
    }

    public Dado OTopo()
    {
        if (EstaVazia)
        {
            throw new Exception("Pilha Vazia");
        }

        return topo.Info;
    }
}

