using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal interface iPilha<Dado>
    {
    void Empilhar(Dado dado);
    Dado Desempilhar();
    Dado OTopo();
    bool EstaVazia {  get; }
    int Tamanho { get; }
    bool Combinam(char x, char y);
    List<Dado> Conteudo();
    }

