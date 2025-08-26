using System;
using System.IO;
using System.Windows.Forms;

public class ListaSimples<Dado> where Dado : IComparable<Dado>, 
        IRegistro
                                             
{
    NoLista<Dado> primeiro, ultimo, atual, anterior;

    int quantosNos;

    public ListaSimples()
    {
        primeiro = ultimo = atual = anterior = null;
        quantosNos = 0;
    }

    public bool EstaVazia
    {
        get => primeiro == null;

        // get 
        // {
        //    if (primeiro == null)
        //       return true;
        //    return false;
        // }
    }
    public NoLista<Dado> Atual { get => atual; }
    public NoLista<Dado> Anterior { get => anterior; }
    public NoLista<Dado> Primeiro 
    { get => primeiro; }
  public NoLista<Dado> Ultimo { get => ultimo;  }

  public void InserirAposFim(Dado novoDado)
    {
        NoLista<Dado> novoNo = new NoLista<Dado>(novoDado);

        if (EstaVazia)              // caso especial
            primeiro = novoNo;
        else
            ultimo.Prox = novoNo;

        ultimo = novoNo;
        quantosNos++;
    }

    public void InserirAposFim(NoLista<Dado> umNo)
    {
        if (EstaVazia)              // caso especial
            primeiro = umNo;
        else
            ultimo.Prox = umNo;

        ultimo = umNo;
        quantosNos++;
    }

    public void InserirAntesDoInicio(Dado novoDado)
    {
        var novoNo = new NoLista<Dado>(novoDado);

        if (EstaVazia)          // se a lista est� vazia, estamos
            ultimo = novoNo;    // incluindo o 1o e o �ltimo n�s!
        else
            novoNo.Prox = primeiro;

        primeiro = novoNo;      // o n� inserido sempre passar� a ser o primeiro n� da lista
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
        oListBox.Items.Clear(); // limpa o conte�do do listBox
        atual = primeiro;       // posiciona ponteiro no 1o n� da lista
        while (atual != null)   // percorre a lista ligada at� seu final
        {
            oListBox.Items.Add(atual.Info); // exibe os itens da lista ligada no listbox
            atual = atual.Prox;             // avan�a para o n� seguinte
        }
    }

    public bool Existe(Dado procurado)
    {
        atual = primeiro;
        anterior = null;

        // Em seguida, � verificado se a lista est� vazia. Caso esteja, �
        // retornado false ao local de chamada, indicando que a chave n�o foi
        // encontrada, e atual e anterior ficam valendo null

        if (EstaVazia)
            return false;

        // aqui o fluxo vem quando a lista n�o est� vazia

        // dado procurado � menor que o primeiro dado da lista:
        // portanto, dado procurado n�o existe

        if (procurado.CompareTo(primeiro.Info) < 0)  // n�o existe
            return false;

        if (procurado.CompareTo(ultimo.Info) > 0)   // n�o existe
        {
            anterior = ultimo;  // �til para incluir e excluir n�s em ordem
            atual = null;
            return false;
        }

        // caso n�o tenha sido definido que a chave est� fora dos limites de 
        // chaves da lista, vamos procurar no seu interior
        // o apontador atual indica o primeiro n� da lista e consideraremos que
        // ainda n�o achou a chave procurada nem chegamos ao final da lista
        bool achou = false;
        bool fim = false;
        // repete os comandos abaixo enquanto n�o achou o RA nem chegou ao
        // final da lista
        while (!achou && !fim)
        {
            // se o apontador atual vale null, indica final da lista
            if (atual == null)
                fim = true;
            // se n�o chegou ao final da lista, verifica o valor da chave atual
            else
            // verifica igualdade entre chave procurada e chave do n� atual
            if (procurado.CompareTo(atual.Info) == 0)
                achou = true;
            else
            // se chave atual � maior que a procurada, significa que
            // a chave procurada n�o existe na lista ordenada e, assim,
            // termina a pesquisa indicando que n�o achou. Anterior
            // aponta o anterior ao atual, que foi acessado por
            // �ltimo
            if (atual.Info.CompareTo(procurado) > 0)
                fim = true;
            else
            {
                // se n�o achou a chave procurada nem uma chave > que ela,
                // ent�o a pesquisa continua, de maneira que o apontador
                // anterior deve apontar o n� atual e o apontador atual
                // deve seguir para o n� seguinte
                anterior = atual;
                atual = atual.Prox;
            }
        }
        // por fim, caso a pesquisa tenha terminado, o apontador atual
        // aponta o n� onde est� a chave procurada, caso ela tenha sido
        // encontrada, ou o n� onde ela deveria estar para manter a
        // ordena��o da lista. O apontador anterior aponta o n� anterior
        // ao atual
        return achou; // devolve o valor da vari�vel achou, que indica
    } // se a chave procurada foi ou n�o encontrado

    public bool InserirEmOrdem(Dado dados)
    {
      if (Existe(dados)) // Existe configura anterior e atual
         return false;   // j� existe, n�o podemos incluir repetido
     
      // aqui temos certeza de que a chave n�o existe
      // guarda dados no novo n�
      
      if (EstaVazia) // se a lista est� vazia, ent�o o 
        InserirAntesDoInicio(dados); // novo n� � o primeiro da lista
      else
      // testa se nova chave < primeira chave
      if (anterior == null && atual != null)
        InserirAntesDoInicio(dados); // liga novo antes do primeiro
      else
      // caso que ocorre se nova chave > �ltima chave
      if (anterior != null && atual == null)
         InserirAposFim(dados);
      else
        InserirNoMeio(dados); // insere entre os n�s anterior e atual
      return true;            // foi inserido na lista, em ordem
    }

    private void InserirNoMeio(Dado dados)
    {
      // Existe() encontrou intervalo de inclus�o do novo n�

    // cria um n� para armazenar a informa��o recebida para incluir
      var novo = new NoLista<Dado>(dados);

      anterior.Prox = novo; // liga anterior ao novo
      novo.Prox = atual;    // e novo no atual

      if (anterior == ultimo) // se incluiu ao final da lista,
         ultimo = novo;       // atualiza o apontador ultimo

      quantosNos++; // incrementa n�mero de n�s da lista }
    }

  public bool Remover(Dado dadoARemover)
  {
    if (!Existe(dadoARemover))
       return false;            // n�o conseguiu excluir porque n�o existe

    // aqui, sabemos que Existe configurou os ponteiros Anterior e Atual
    if (anterior == null && atual == primeiro)
    {
      primeiro = primeiro.Prox;
      if (primeiro == null)   // esvaziou a lista
        ultimo = null;
    }
    else
    if (atual == ultimo)    // � o �ltimo n�
    {
      anterior.Prox = null;
      ultimo = anterior;
    }
    else  // n� interno a excluir
    {
      anterior.Prox = atual.Prox;
    }
    quantosNos--;
    return true;    // indica que excluiu o n� desejado
  }

  public void GravarDados(string nomeDoArquivo)
  {
    var arquivo = new StreamWriter(nomeDoArquivo);
    atual = primeiro;       // posiciona ponteiro no 1o n� da lista
    while (atual != null)   // n�o chegou no final da lista
    {
      arquivo.WriteLine(atual.Info.FormatoDeArquivo());
      atual = atual.Prox;
    }
    arquivo.Close();
  }

  public void Ordenar()
  {
  }

// exerc�cio 1
    public int ContarNos()
    {
        int contador = 0;
        atual = primeiro;               // posiciona no 1o n� da lista
        while (atual != null)
        {
            contador = contador + 1;    // contador++  ou contador += 1
            atual = atual.Prox;         // avan�a para o n� seguinte
        }
        return contador;
    }

    // exercicio 2

    //public void Separar(ref ListaSimples<Dado> par, 
    //                    ref ListaSimples<Dado> impar)
    //{
    //    par = new ListaSimples<Dado>();
    //    impar = new ListaSimples<Dado>();
    //    atual = primeiro;
    //    while (atual != null)
    //    {
    //        var seguinte = atual.Prox;
    //        if (atual.Info.DeveSeparar())
    //            par.InserirAposFim(atual);
    //        else
    //            impar.InserirAposFim(atual);
    //        atual = seguinte;
    //    }
    //    par.ultimo.Prox = null;
    //    impar.ultimo.Prox = null;
    //}

    // exerc�cio 3

    public ListaSimples<Dado> Juntar(ListaSimples<Dado> aOutra)
    {
        var novaLista = new ListaSimples<Dado>();  // jun��o de this com aOutra
        atual = primeiro;  // da lista this
        aOutra.atual = aOutra.primeiro;
        while (atual != null && aOutra.atual != null)
        {
            if (atual.Info.CompareTo(aOutra.atual.Info) < 0)
            {
                novaLista.InserirAposFim(atual.Info);
                atual = atual.Prox;
            }
            else
                if (aOutra.atual.Info.CompareTo(atual.Info) < 0)
                {
                    novaLista.InserirAposFim(aOutra.atual.Info);
                    aOutra.atual = aOutra.atual.Prox;
                }
                else
                {
                    novaLista.InserirAposFim(atual.Info);
                    atual = atual.Prox;
                    aOutra.atual = aOutra.atual.Prox;
                }
        }

        while (atual != null)
        {
            novaLista.InserirAposFim(atual.Info);
            atual = atual.Prox;
        }

        while (aOutra.atual != null)
        {
            novaLista.InserirAposFim(aOutra.atual.Info);
            aOutra.atual = aOutra.atual.Prox;
        }

        return novaLista;
    }

    // exerc�cio 4

    public void Inverter()
    {
        if (!EstaVazia)     // testar os casos lim�trofes ou especiais
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

}