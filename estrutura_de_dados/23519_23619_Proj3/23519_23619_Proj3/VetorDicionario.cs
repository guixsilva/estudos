using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class VetorDicionario<Dicionario> where Dicionario : IComparable<Dicionario>
    {

    Dicionario[] dados = new Dicionario[110];
    int qtosDados;
    int posicaoAtual;
    Dicionario atual;
    bool estaVazia = true;

    public Dicionario[] Dados { get => dados;}
    public int QtosDados { get => qtosDados; set => qtosDados = value; }
    public int PosicaoAtual { get => posicaoAtual; set => posicaoAtual = value; }

    public bool EstaVazia { 
        get => estaVazia;
        set{
            if(dados != null)
            {
                estaVazia = false;
            }
            else
            {
                estaVazia=true;
            }
        }
    }

    public void InserirNovaPalavra(Dicionario novoRegistro)
    {
        if (Existe(novoRegistro))
        {
            throw new Exception("Essa palavra já existe no dicionário.");
        }
        else
        {
            if (novoRegistro != null) // COLOCAR EM ORDEM ALFABÉTICA
            {
                if (EstaVazia)
                {
                    dados[0] = novoRegistro;
                }
                else
                {
                    atual = dados[0];
                    
                }
                qtosDados++;
            }
        }

    }

    public void ExcluirPalavra(int Posicao)
    {

    }

    public bool Existe(Dicionario palavraBuscada)
    {
        return false;
    }

    public Dicionario BuscarPalavra(Dicionario palavraBuscada)
    {
        Dicionario palavraAchada;
        for(int i = 0; i< dados.Length; i++)
        {
            if(dados[i].CompareTo(palavraBuscada) == 0)
            {
                palavraAchada = palavraBuscada;
                return palavraAchada;
            }
        }
        return default;
    }

    public Dicionario EditarPalavra(string palavraEditada, string dicaEditada)
    {

        return default;
    }

    public void PosicionarNoInicio()
    {
        if (EstaVazia)
        {
            throw new Exception("lISTA VAZIA");
        }
        else
        {
            atual = dados[0];
            posicaoAtual = 1;
        }
    }

    public void PosicionarNoFinal()
    {
        if (EstaVazia)
        {
            throw new Exception("lISTA VAZIA");
        }
        else
        {
            posicaoAtual = dados.Length;
            atual = dados[posicaoAtual];
        }
    }

    public void Avancar()
    {
        if (EstaVazia)
        {
            throw new Exception("lISTA VAZIA");
        }
        if (dados[posicaoAtual + 1] != null)
        {
            atual = dados[posicaoAtual + 1];
            posicaoAtual++;
        }
    }

    public void Retroceder()
    {
        if (EstaVazia)
        {
            throw new Exception("lISTA VAZIA");
        }
        if (dados[posicaoAtual - 1] != null)
        {
            atual = dados[posicaoAtual - 1];
            posicaoAtual--;
        }
    }


}

