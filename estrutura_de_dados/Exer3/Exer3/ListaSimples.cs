
using System;
using System.IO;
using System.Windows.Forms;

public class ListaSimples<Dado> where Dado : IComparable<Dado>
{
    NoLista<Dado> primeiro, ultimo, atual, anterior;
    int quantosNos;

    public ListaSimples()
    {
        primeiro = ultimo = null;
        quantosNos = 0;
    }

    public bool EstaVazia => primeiro == null;

    public NoLista<Dado> Primeiro { get => primeiro; set => primeiro = value; }

    public void InserirAposFim(Dado novoDado)
    {
        NoLista<Dado> novoNo = new NoLista<Dado>(novoDado);

        if (EstaVazia)
            primeiro = novoNo;
        else
            ultimo.Prox = novoNo;

        ultimo = novoNo;
        quantosNos++;
    }

    public void InserirAposFim(NoLista<Dado> novoNo)
    {

        if (EstaVazia)
            primeiro = novoNo;
        else
            ultimo.Prox = novoNo;

        ultimo = novoNo;
        quantosNos++;
    }

    public void InserirAntesDoInicio(Dado novoDado)
    {
        var novoNo = new NoLista<Dado>(novoDado);

        if (EstaVazia)
            ultimo = novoNo;
        else
            novoNo.Prox = primeiro;

        primeiro = novoNo;
        quantosNos++;
    }

    public void ExibirNaTela()
    {
        atual = primeiro;
        while (atual != null)
        {
            Console.WriteLine(atual.Info);
            atual = atual.Prox;
        }
    }

    public void Listar(ListBox oListBox)
    {
        oListBox.Items.Clear();
        atual = primeiro;
        while (atual != null)
        {
            oListBox.Items.Add(atual.Info);
            atual = atual.Prox;
        }
    }

    public int ContarNos()
    {
        int numerodenos = 0;
        atual = primeiro;
        while (atual != null)
        {
            numerodenos++;
            atual = atual.Prox;
        }
        return numerodenos;
    }

    public void Inverter()
    {
        NoLista<Dado> anterior = null;
        NoLista<Dado> atual = primeiro;
        NoLista<Dado> proximo = null;

        while (atual != null)
        {
            proximo = atual.Prox;
            atual.Prox = anterior;
            anterior = atual;
            atual = proximo;
        }

        ultimo = primeiro;
        primeiro = anterior;
    }

    public void InverterChico()
    {
        if (!EstaVazia)
        {
            var um = primeiro;
            var dois = primeiro.Prox;
            while (dois != null)
            {
                var tres = dois.Prox;
                dois.Prox = um;
                um = dois;
                dois = tres;
            }
            ultimo = primeiro;
            primeiro.Prox = null;
            primeiro = um;
        }
    }

    public Boolean Buscar(Dado dadoprocurado)
    {        
        
        bool elemento_encontrado = false;
        bool fim = false;

        if (EstaVazia || primeiro.Prox == null)
        {
            return fim;
        }

        if(dadoprocurado.CompareTo(ultimo.Info) < 0)
        {
            return fim;
        }

        if (dadoprocurado.CompareTo(primeiro.Info) > 0)
        {
            return fim;
        }

        anterior = null;
        atual = primeiro;

        do
        {
            if(atual == null)
            {
                fim = true;
            }
            else
            {
                if(dadoprocurado.CompareTo(atual.Info) == 0)
                {
                    elemento_encontrado = true;
                }
                else
                {
                    if(dadoprocurado.CompareTo(atual.Info) > 0)
                    {
                        fim = true;
                    }
                    else
                    {
                        anterior = atual;
                        atual = atual.Prox;
                    }
                    return elemento_encontrado;
                }
            }
            return fim;
        } while (!elemento_encontrado || !fim);
    }



    public void Ordenar()
    {
        if (EstaVazia || primeiro.Prox == null)
        {
            return;
        }

        bool trocado;

        do
        {
            trocado = false;
            NoLista<Dado> atual = primeiro;
            NoLista<Dado> proximo = atual.Prox;

            while (proximo != null)
            {
                if (atual.Info.CompareTo(proximo.Info) > 0)
                {
                    Dado backup = atual.Info;
                    atual.Info = proximo.Info;
                    proximo.Info = backup;

                    trocado = true;
                }

                atual = proximo;
                proximo = proximo.Prox;
            }
        } while (trocado);
    }

    public void Excluir(Dado dado)
    {
        // Implementação pendente
    }

    public void GravarEmArquivo(string nomeArquivo)
    {
        try
        {
            using (StreamWriter escritor = new StreamWriter(nomeArquivo))
            {
                NoLista<Dado> atual = primeiro;
                while (atual != null)
                {
                    if (atual.Info != null)
                    {
                        escritor.WriteLine(atual.Info.ToString());
                    }
                    atual = atual.Prox;
                }
            }
            Console.WriteLine($"Dados gravados com sucesso em {nomeArquivo}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao gravar no arquivo: {ex.Message}");
        }
    }

    public bool Existe(Dado procurado)
    {
        atual = primeiro;
        anterior = null;

        // Em seguida,   verificado se a lista est  vazia. Caso esteja,  
        // retornado false ao local de chamada, indicando que a chave n o foi
        // encontrada, e atual e anterior ficam valendo null

        if (EstaVazia)
            return false;

        // aqui o fluxo vem quando a lista n o est  vazia

        // dado procurado   menor que o primeiro dado da lista:
        // portanto, dado procurado n o existe

        if (procurado.CompareTo(primeiro.Info) < 0)  // n o existe
            return false;

        if (procurado.CompareTo(ultimo.Info) > 0)   // n o existe
        {
            anterior = ultimo;  //  til para incluir e excluir n s em ordem
            atual = null;
            return false;
        }

        // caso n o tenha sido definido que a chave est  fora dos limites de 
        // chaves da lista, vamos procurar no seu interior
        // o apontador atual indica o primeiro n  da lista e consideraremos que
        // ainda n o achou a chave procurada nem chegamos ao final da lista
        bool achou = false;
        bool fim = false;
        // repete os comandos abaixo enquanto n o achou o RA nem chegou ao
        // final da lista
        while (!achou && !fim)
        {
            // se o apontador atual vale null, indica final da lista
            if (atual == null)
                fim = true;
            // se n o chegou ao final da lista, verifica o valor da chave atual
            else
            // verifica igualdade entre chave procurada e chave do n  atual
            if (procurado.CompareTo(atual.Info) == 0)
                achou = true;
            else
            // se chave atual   maior que a procurada, significa que
            // a chave procurada n o existe na lista ordenada e, assim,
            // termina a pesquisa indicando que n o achou. Anterior
            // aponta o anterior ao atual, que foi acessado por
            //  ltimo
            if (atual.Info.CompareTo(procurado) > 0)
                fim = true;
            else
            {

                // se n o achou a chave procurada nem uma chave > que ela,
                // ent o a pesquisa continua, de maneira que o apontador
                // anterior deve apontar o n  atual e o apontador atual
                // deve seguir para o n  seguinte
                anterior = atual;
                atual = atual.Prox;
            }
        }
        // por fim, caso a pesquisa tenha terminado, o apontador atual
        // aponta o n  onde est  a chave procurada, caso ela tenha sido
        // encontrada, ou o n  onde ela deveria estar para manter a
        // ordena  o da lista. O apontador anterior aponta o n  anterior
        // ao atual
        return achou; // devolve o valor da vari vel achou, que indica
    } // se a chave procurada foi ou n o encontrado


    public void InsereEmOrdemAlfabetica(Dado novoDado)
    {
        if (Existe(novoDado))
        {
            return;
        }
        else
        {
            if (EstaVazia)
            {
                InserirAntesDoInicio(novoDado);
            }else if(ultimo == null)
            {
                InserirAntesDoInicio(novoDado);
            }
            else
            {
                anterior = primeiro;
                atual = primeiro.Prox;
                while(atual != null)
                {
                if (String.Compare(anterior.Info.ToString(), atual.Info.ToString()) > 0){
                    NoLista<Dado> backup = anterior;
                    atual.Prox = new NoLista<Dado>(novoDado);
                    anterior.Prox = backup;
                    atual = atual.Prox;
                }else if(String.Compare(anterior.Info.ToString(), atual.Info.ToString()) < 0)
                {
                    NoLista<Dado> backup = atual;
                    anterior.Prox = new NoLista<Dado>(novoDado);
                    atual.Prox = backup;
                    atual = atual.Prox;
                }
                quantosNos++;
                }

            }
        }
    }



}
