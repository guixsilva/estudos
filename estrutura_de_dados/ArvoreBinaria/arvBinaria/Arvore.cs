using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Arvore<T> where T : IComparable<T>
    {
    private NoArvore<T> raiz, atual, antecessor;

    public NoArvore<T> Raiz { get => raiz; set => raiz = value; }
    public NoArvore<T> Atual { get => atual; set => atual = value; }
    public NoArvore<T> Antecessor { get => antecessor; set => antecessor = value; }

    public Arvore()
    {
        raiz = atual = antecessor = null;
    }

    public void Visitar(NoArvore<T> atual)
    {
        if (atual != null)
        {
            Console.WriteLine(atual.Info);
        }
        if (atual.Direita != null)
        {
            Visitar(atual.Direita);
        }
        if(atual.Esquerda != null)
        {
            Visitar(atual.Esquerda);
        }
        else
        {
            return;
        }

    }
}
