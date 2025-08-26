using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Pilha<Dado> : iPilha<Dado> where Dado : IComparable<Dado>
{
    const int tamanhoPadrao = 15;
    private Dado[] p;
    int topo;

    public Pilha(int TamanhoFisico)
    {
        p = new Dado[TamanhoFisico];
        topo = -1;
    }

    public Pilha() : this(tamanhoPadrao) { }

    public bool EstaVazia => topo < 0;

    public bool EstaCheia => topo >= p.Length;

    public int Tamanho => topo + 1;

    public List<Dado> Conteudo()
    {
        var dadosNaPilha = new List<Dado>();

        for (int i = 0; i < topo; i++)
        {
            dadosNaPilha.Add(p[i]);
        }

        return dadosNaPilha;
    }

    public Dado Desempilhar()
    {
        if (EstaCheia)
        {
            throw new Exception("Pilha cheia");
        }

        var dadoDesempilhado =p[topo];
        p[topo--] = default;
        return dadoDesempilhado;
    }

    public void Empilhar(Dado dado)
    {
        if (EstaCheia)
        {
            throw new Exception("Pilha cheia");
        }
        p[++topo] = dado;
    }

    public Dado OTopo()
    {
        if (EstaVazia)
        {
            throw new Exception("Pilha Vazia");
        }

        return p[topo];
    }

    public bool Combinam(char x, char y)
    {
        return (x == '{' && y == '}') || (x == '[' && y == ']' || x == '(' && y == ')');
    }
}

