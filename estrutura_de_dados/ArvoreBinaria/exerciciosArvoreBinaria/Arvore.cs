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

    public bool ComparaNo(NoArvore<T> atualA, NoArvore<T> atualB)
    {
        if (atualA == null && atualB == null)
        {
            return true;
        }
        if ((atualA == null) != (atualB == null))
        {
            return false;
        }
        if (atualA.Info.CompareTo(atualB.Info) != 0)
        {
            return false;
        }
        else
        {
            return ComparaNo(atualA.Esquerda, atualB.Esquerda) && ComparaNo(atualA.Direita, atualB.Direita);
        }
    }

    public bool Equivalente(Arvore<T> arvoreB)
    {
        return ComparaNo(this.raiz, arvoreB.raiz);
    }

    public int ContaNo(NoArvore<T> noArvore)
    {
        if(noArvore == null)
        {
            return 0;
        }
        else
        {
            return 1 + ContaNo(noArvore.Esquerda) + ContaNo(noArvore.Direita);
        }
    }


    public int ContaFolhas(NoArvore<T> noAtual)
    {
        if(noAtual == null)
        {
            return 0;
        }

        if(noAtual.Esquerda == null &&  noAtual.Direita == null)
        {
            return 1;
        }

        return ContaFolhas(noAtual.Esquerda) + ContaFolhas(noAtual.Direita);
    }

    public bool EExtritamenteBinaria(NoArvore<T> raiz)
    {
        if(raiz == null)
        {
            return false;
        }
        if (raiz.Esquerda == null && raiz.Direita != null)
        {
            return false;
        }
        if (raiz.Esquerda != null && raiz.Direita == null)
        {
            return false;
        }
        if (raiz.Esquerda == null || raiz.Direita == null)
        {
            return true;
        }
        return EExtritamenteBinaria(raiz.Esquerda) && EExtritamenteBinaria(raiz.Direita);
    }

    public int Altura(NoArvore<T> raiz) {
        int alturaDireita, alturaEsquerda;

        if(raiz == null)
        {
            return 0;
        }

        alturaDireita = Altura(raiz.Direita);
        alturaEsquerda = Altura(raiz.Esquerda);

        if(alturaDireita >= alturaEsquerda)
        {
            return 1 + alturaDireita;
        }
        else
        {
            return 1 + alturaEsquerda;
        }

    }

    public string EscreveArvore(NoArvore<T> atual)
    {
        string retorno = "(";
        if(atual == null)
        {
            return ")";
        }
        else
        {
            return retorno += $"{atual.Info}: {EscreveArvore(atual.Esquerda)}, {EscreveArvore(atual.Direita)})";
        }
    }

    public void InverteArvores(NoArvore<T> atual)
    {
        NoArvore<T> backup;

        if(atual == null)
        {
            return;
        }

        backup = atual.Esquerda;
        atual.Esquerda = atual.Direita;
        atual.Direita = backup;
        InverteArvores(atual.Direita);
        InverteArvores(atual.Esquerda);
    }


    /*    int[] quantosNoNivel = new int[1000];
        public int Largura(NoArvore<T> noAtual)
        {
            for (int i = 0; i < 1000; i++)
                quantosNoNivel[i] = 0;
            ContarNosNosNiveis(noAtual, 0);
            return MaiorValorDe(quantosNoNivel);
        }

        public void ContarNosNosNiveis(NoArvore<T> noAtual, int qualNivel)
        {
            if (noAtual != null)
            {
                ++quantosNoNivel[qualNivel];
                ContarNosNosNiveis(noAtual.Esquerda, qualNivel + 1);
                ContarNosNosNiveis(noAtual.Direita, qualNivel + 1);
            }
        }*/


    bool achou;
    public string PreparaAntecessores(T dado)
    {
        achou = false;
        return Antecessores(this.raiz, dado);
        
        
    }

    public string Antecessores(NoArvore<T> no, T dado)
    {
        string retorno = "";
        if (atual != null)
        {
            while (!achou)
            {
                if(atual.Info.CompareTo(dado) == 0)
                {
                    achou = true;
                    retorno += " " + atual.Info;
                }
                else
                {
                    Antecessores(no.Direita, dado);
                    Antecessores(no.Esquerda, dado);
                }
            }
        }

        return retorno;
    }

}
