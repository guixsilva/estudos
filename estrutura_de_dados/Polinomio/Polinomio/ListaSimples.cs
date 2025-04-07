using apCadastroAlunos;
using Polinomio;
using System;
using System.IO;
using System.Windows.Forms;

public class ListaSimples<Dado> where Dado : IComparable<Dado>, IcriterioDeSeparacao
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

    public void SomarPolinômios(ListaSimples<Dado> lista, ListaSimples<Dado> lista2)
    {
        ListaSimples<Dado> resultado = new ListaSimples<Dado>();
        NoLista<Dado> atual1 = lista.primeiro;
        NoLista<Dado> atual2 = lista2.primeiro;

        while(atual1 != null && atual2 != null)
        {
            if (atual1.Info.CompareTo(atual2.Info) > 0)
            {
                resultado.InserirAposFim(new Dado(atual.Info.));
            }
        }

        

    }

    //public Boolean Buscar(Dado dadoprocurado)
    //{        
        
    //    bool elemento_encontrado = false;
    //    bool fim = false;

    //    if (EstaVazia || primeiro.Prox == null)
    //    {
    //        return fim;
    //    }

    //    if(dadoprocurado.CompareTo(ultimo.Info) < 0)
    //    {
    //        return fim;
    //    }

    //    if (dadoprocurado.CompareTo(primeiro.Info) > 0)
    //    {
    //        return fim;
    //    }

    //    anterior = null;
    //    atual = primeiro;

    //    do
    //    {
    //        if(atual == null)
    //        {
    //            fim = true;
    //        }
    //        else
    //        {
    //            if(dadoprocurado.CompareTo(atual.Info) == 0)
    //            {
    //                elemento_encontrado = true;
    //            }
    //            else
    //            {
    //                if(dadoprocurado.CompareTo(atual.Info) > 0)
    //                {
    //                    fim = true;
    //                }
    //                else
    //                {
    //                    anterior = atual;
    //                    atual = atual.Prox;
    //                }
    //                return elemento_encontrado;
    //            }
    //        }
    //        return fim;
    //    } while (!elemento_encontrado || !fim);
    //}



    //public ListaSimples<Dado> Juntar(ListaSimples<Dado> aOutra)
    //{
    //    var novaLista = new ListaSimples<Dado>();
    //    atual = primeiro;
    //    aOutra.atual = aOutra.primeiro;

    //    while (atual != null && aOutra.atual != null)
    //    {
    //        if (atual.Info.CompareTo(aOutra.atual.Info) < 0)
    //        {
    //            novaLista.InserirAposFim(atual.Info);
    //            atual = atual.Prox;
    //        }
    //        else if (aOutra.atual.Info.CompareTo(atual.Info) < 0)
    //        {
    //            novaLista.InserirAposFim(aOutra.atual.Info);
    //            aOutra.atual = aOutra.atual.Prox;
    //        }
    //        else
    //        {
    //            novaLista.InserirAposFim(atual.Info);
    //            atual = atual.Prox;
    //            aOutra.atual = aOutra.atual.Prox;
    //        }
    //    }

    //    while (atual != null)
    //    {
    //        novaLista.InserirAposFim(atual.Info);
    //        atual = atual.Prox;
    //    }

    //    while (aOutra.atual != null)
    //    {
    //        novaLista.InserirAposFim(aOutra.atual.Info);
    //        aOutra.atual = aOutra.atual.Prox;
    //    }

    //    return novaLista;
    //}

    //public void SepararListas(ref ListaSimples<Dado> par, ref ListaSimples<Dado> impar)
    //{
    //    par = new ListaSimples<Dado>();
    //    impar = new ListaSimples<Dado>();

    //    atual = primeiro;
    //    while (atual != null)
    //    {
    //        var seguinte = atual.Prox;
    //        if (atual.Info.DeveSeparar())
    //        {
    //            par.InserirAposFim(atual);
    //        }
    //        else
    //        {
    //            impar.InserirAposFim(atual);
    //        }
    //        atual = seguinte;
    //    }

    //    par.ultimo.Prox = null;
    //    impar.ultimo.Prox = null;
    //}

    //public void Ordenar()
    //{
    //    if (EstaVazia || primeiro.Prox == null)
    //    {
    //        return;
    //    }

    //    bool trocado;

    //    do
    //    {
    //        trocado = false;
    //        NoLista<Dado> atual = primeiro;
    //        NoLista<Dado> proximo = atual.Prox;

    //        while (proximo != null)
    //        {
    //            if (atual.Info.CompareTo(proximo.Info) > 0)
    //            {
    //                Dado backup = atual.Info;
    //                atual.Info = proximo.Info;
    //                proximo.Info = backup;

    //                trocado = true;
    //            }

    //            atual = proximo;
    //            proximo = proximo.Prox;
    //        }
    //    } while (trocado);
    //}

    //public void Excluir(Dado dado)
    //{
    //    // Implementação pendente
    //}

    //public void GravarEmArquivo(string nomeArquivo)
    //{
    //    try
    //    {
    //        using (StreamWriter escritor = new StreamWriter(nomeArquivo))
    //        {
    //            NoLista<Dado> atual = primeiro;
    //            while (atual != null)
    //            {
    //                if (atual.Info != null)
    //                {
    //                    escritor.WriteLine(atual.Info.ToString());
    //                }
    //                atual = atual.Prox;
    //            }
    //        }
    //        Console.WriteLine($"Dados gravados com sucesso em {nomeArquivo}");
    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine($"Erro ao gravar no arquivo: {ex.Message}");
    //    }
    //}


}
