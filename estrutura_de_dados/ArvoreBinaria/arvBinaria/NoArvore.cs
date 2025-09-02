using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class NoArvore<T> where T : IComparable<T>
    {
    T info;
    NoArvore<T> esquerda, direita;
    int altura;

    public NoArvore(T dados, NoArvore<T> esquerdo, NoArvore<T> direita)
    {
        this.Info = dados;
        this.Esquerda = esquerdo;
        this.Direita = direita;
    }

    public NoArvore(T informacao)
    {
        info = informacao;
        esquerda = direita = null;
    }



    public T Info { get => info; set => info = value; }
    public NoArvore<T> Esquerda { get => esquerda; set => esquerda = value; }
    public NoArvore<T> Direita { get => direita; set => direita = value; }


}
