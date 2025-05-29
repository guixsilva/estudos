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
    bool estaVazia;

    public Dicionario[] Dados { get => dados;}
    public int QtosDados { get => qtosDados; 
        set {
            for(int i = 0; i < dados.Length; i++)
            {
                if(dados[i] != null)
                {
                    qtosDados++;
                }
            }

        }
    }
    public int PosicaoAtual { get => posicaoAtual; set => posicaoAtual = value; }

    public bool EstaVazia { 
        get => estaVazia;
        set{
            if(dados[0] != null)
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
                    for (int i = 0; i < qtosDados; i++)
                    {
                        if (novoRegistro.CompareTo(dados[i]) < 0)
                        {
                            posicaoAtual = i;
                            break;
                        }
                        posicaoAtual = i + 1;
                    }
                    
                    for(int i = qtosDados; i > posicaoAtual; i--)
                    {
                        dados[i] = dados[i - 1];
                    }
                    dados[posicaoAtual] = novoRegistro;
                    
                }
                qtosDados++;
            }
            else
            {
                throw new Exception("A palavra não pode ser inserida na lista.");
            }
        }

    }

    public void ExcluirPalavra(Dicionario palavraParaRemover)
    {
        if (EstaVazia)
        {
            throw new Exception("A lista está vazia");
        }
        if (!Existe(palavraParaRemover))
        {
            throw new Exception("Palavra não existe na lista");
        }
        else
        {
            for (int i = posicaoAtual; i < qtosDados - 1; i++)
            {
                dados[i] = dados[i + 1];
            }
            dados[qtosDados - 1] = default;
            qtosDados--;
        }
    }

    public bool Existe(Dicionario palavraBuscada)
    {
        posicaoAtual = 0;
        atual = dados[posicaoAtual];
        bool achou = false;
        bool fim = false;

        while(!achou && !fim)
        {
            if(atual == null)
            {
                fim = true;
            }
            else
            {
                if(atual.CompareTo(palavraBuscada) == 0)
                {
                    achou = true;
                }
                else
                {
                    posicaoAtual++;
                    atual = dados[posicaoAtual];
                }
            }
        }

        return achou;
    }


    public void EditarPalavra(Dicionario palavraModificada)
    {

        if (EstaVazia)
        {
            throw new Exception("Lista Vazia");
        }
        else if (palavraModificada == null)
        {
            throw new Exception("Dado Vazio");
        }
        else
        {
            int posicaoAtualBackup = posicaoAtual;
            if (!Existe(palavraModificada))
            {
                dados[posicaoAtualBackup] = palavraModificada;
            }
            else
            {
                throw new Exception("Dado já existe na lista.");
            }
        }
    }

    public void PosicionarNoInicio()
    {
        if (EstaVazia)
        {
            throw new Exception("lISTA VAZIA");
        }
        else
        {
            posicaoAtual = 0;
            atual = dados[posicaoAtual];
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
            posicaoAtual = qtosDados -1;
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
        else
        {
            PosicionarNoFinal();
        }
    }

    public void Retroceder()
    {
        if (EstaVazia)
        {
            throw new Exception("lISTA VAZIA");
        }
        if (posicaoAtual > 0)
        {
            atual = dados[posicaoAtual - 1];
            posicaoAtual--;
        }
        else
        {
            PosicionarNoInicio();
        }
    }

    public void GravarDados(string nomeArq)
    {
        try
        {
            using (var arquivo = new StreamWriter(nomeArq))
            {
                for (int i = 0; i < qtosDados; i++)
                {
                    if (dados[i] != null)
                    {
                        arquivo.WriteLine(dados[i].ToString());
                    }
                }
            } 
        }
        catch
        {
            throw new Exception("Erro");
        }
    }

    public List<Dicionario> Listagem()
    {
        var dadosEmLista = new List<Dicionario>();

        for (int i = 0; i < qtosDados; i++)
        {
            if (dados[i] != null)
            {
                dadosEmLista.Add(dados[i]);
            }
        }
        return dadosEmLista;
    }
}

