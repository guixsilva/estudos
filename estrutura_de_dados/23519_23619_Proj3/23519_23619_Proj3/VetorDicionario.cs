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

    //
    //
    // FUNÇÕES DE CRUD
    //
    //
    public void InserirNovaPalavra(Dicionario novoRegistro) // insere uma nova palavra em ordem alfabética
    {
        if (novoRegistro == null)
        {
            throw new Exception("A palavra não pode ser nula.");
        }

        if (Existe(novoRegistro))
        {
            throw new Exception("Essa palavra já existe no dicionário.");
        }

        int posicaoInsercao = 0;

        while (posicaoInsercao < qtosDados &&
               novoRegistro.CompareTo(dados[posicaoInsercao]) > 0)
        {
            posicaoInsercao++;
        }

        for (int i = qtosDados; i > posicaoInsercao; i--)
        {
            dados[i] = dados[i - 1];
        }

        dados[posicaoInsercao] = novoRegistro;
        qtosDados++;
    }

    public void ExcluirPalavra(Dicionario palavraParaRemover) // Exclui palavras de dentro da lista ligada USANDO BUSCA BINÁRIA
    {
        if (EstaVazia)
        {
            throw new Exception("A lista está vazia");
        }

        int inicio = 0;
        int fim = qtosDados - 1;
        int meio = -1;
        bool encontrado = false;

        while (inicio <= fim) // busca binária
        {
            meio = (inicio + fim) / 2; // função que define o meio do dicionário
            int comparacao = palavraParaRemover.CompareTo(dados[meio]); // compara a palavra com o meio

            if (comparacao == 0) // encontrou
            {
                encontrado = true;
                break;
            }
            else if (comparacao < 0) // palavra menor que o meio - anda para a esquerda
            {
                fim = meio - 1;
            }
            else // palavra maior que o meio - anda para a direita
            {
                inicio = meio + 1;
            }
        }

        if (!encontrado)
        {
            throw new Exception("Palavra não existe na lista");
        }

        for (int i = meio; i < qtosDados - 1; i++) // desloca tudo da direita para a esquerda
        {
            dados[i] = dados[i + 1];
        }

        dados[qtosDados - 1] = default;
        qtosDados--;
    }


    public bool Existe(Dicionario palavraBuscada) // verifica se existe uma palavra ESPECÍFICA no dicionário - sem usar busca binária
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
                    posicaoAtual++; // define o ponteiro para o elemento encontrado
                    atual = dados[posicaoAtual];
                }
            }
        }

        return achou;
    }


    public void EditarPalavra(Dicionario palavraModificada) // função que edita uma palavra dentro do dicionário 
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
            if (!Existe(palavraModificada)) // função existe define o ponteiro no elemento encontrado
            {
                dados[posicaoAtualBackup] = palavraModificada;
            }
            else
            {
                throw new Exception("Dado já existe na lista.");
            }
        }
    }

    //
    //
    // FUNÇÕES PARA NAVEGAÇÃO DENTRO DA LISTA LIGADA
    //
    //
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

    //
    //
    // FUNÇÕES PARA TRATAMENTO DE DADOS (LISTAGEM, GRAVAR DADOS)
    //
    //
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

