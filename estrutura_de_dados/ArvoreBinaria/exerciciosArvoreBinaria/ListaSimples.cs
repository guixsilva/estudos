using System;
using System.Collections.Generic;

public class ListaSimples<Dado> 
             where Dado : IComparable<Dado>, 
                          IEquatable<Dado>
{
  public bool Igual(ListaSimples<Dado> outraLista)
  {
    if (QuantosNos != outraLista.QuantosNos)
      return false;

    var atualThis = this.primeiro;
    var atualOutra = outraLista.primeiro;

    while (atualThis != null)
    {
      if (!atualThis.Info.Equals(atualOutra.Info))
        return false;

      atualThis = atualThis.Prox;
      atualOutra = atualOutra.Prox;
    }

    return true;
  }

  public void Ordenar()
  {
    var listaOrdenada = new ListaSimples<Dado>();

    while (!this.EstaVazia)
    {
      NoLista<Dado> menor = primeiro, 
                    anteriorMenor = null;
      this.atual = this.primeiro;
      this.anterior = null;

      while (this.atual != null)
      {
        if (this.atual.Info.CompareTo(menor.Info) < 0)
        {
          menor = this.atual;
          anteriorMenor = this.anterior;
        }
        this.anterior = this.atual;
        this.atual = this.atual.Prox;
      }

      if (anteriorMenor != null)
        anteriorMenor.Prox = menor.Prox;
      else
        this.primeiro = menor.Prox;

      if (menor == this.ultimo)         // PODE NÃO SER NECESSÁRIO,
        this.ultimo = anteriorMenor;    // POIS ESTÁ DESTRUINDO A LISTA ORIGINAL
            
      menor.Prox = null;                // DESNECESSÁRIO
      listaOrdenada.InserirAposFim(menor);
    }

    this.primeiro = listaOrdenada.primeiro;
    this.ultimo = listaOrdenada.ultimo;
  }

  public ListaSimples<Dado> Copiar()
  {
    var copia = new ListaSimples<Dado>();
    this.atual = this.primeiro;

    while (this.atual != null)
    {
      copia.InserirAposFim(this.atual.Info);
      this.atual = this.atual.Prox;
    }

    return copia;
  }

  NoLista<Dado> primeiro, ultimo, anterior, atual;
  int quantosNos;
  bool primeiroAcessoDoPercurso;

  public List<Dado> Listar()
  {
    var dados = new List<Dado>();
    atual = primeiro;     // posiciona ponteiro de percurso no 1o nó
    while (atual != null) // enquanto houver nós a visitar
    {
      dados.Add(atual.Info);  // inclui no vetor os dados do nó visitado agora
      atual = atual.Prox;     // avança o ponteiro de percurso para o nó seguinte
    }
    return dados;
  }

  public ListaSimples()
  {
    primeiro = ultimo = anterior = atual = null;
    quantosNos = 0;
    primeiroAcessoDoPercurso = false;
  }

  public bool EstaVazia
  {
    get => primeiro == null;
  }
  public NoLista<Dado> Primeiro
  {
    get => primeiro;
  }
  public NoLista<Dado> Ultimo
  {
    get => ultimo;
  }
  public int QuantosNos
  {
    get => quantosNos;
  }

  public void InserirAntesDoInicio(Dado novoDado)
  {
    var novoNo = new NoLista<Dado>(novoDado);

    if (EstaVazia)
       ultimo = novoNo;

    novoNo.Prox = primeiro;
    primeiro    = novoNo;
    quantosNos++;
  }

  public void InserirAposFim(Dado novoDado)
  {
    var novoNo = new NoLista<Dado>(novoDado);

    if (EstaVazia)
      primeiro = novoNo;
    else
      ultimo.Prox = novoNo;

    ultimo = novoNo;
    quantosNos++;
  }

  public void InserirAposFim(NoLista<Dado> noExistente)
  {
    if (noExistente != null)
    {
      if (EstaVazia)
        primeiro = noExistente;
      else
        ultimo.Prox = noExistente;

      ultimo = noExistente;
      noExistente.Prox = null;
      quantosNos++;
    }
  }

  public bool Existe(Dado outroProcurado)
  {
    anterior = null;
    atual = primeiro;

    //	Em seguida, é verificado se a lista está vazia. Caso esteja, é
    //	retornado false ao local de chamada, indicando que a chave não foi
    //	encontrada, e atual e anterior ficam valendo null
    if (EstaVazia)
       return false;
 
    // a lista não está vazia, possui nós
    // dado procurado é menor que o primeiro dado da lista:
    // portanto, dado procurado não existe
    if (outroProcurado.CompareTo(primeiro.Info) < 0)
       return false;

    // dado procurado é maior que o último dado da lista:
    // portanto, dado procurado não existe
    if (outroProcurado.CompareTo(ultimo.Info) > 0)
    {
      anterior = ultimo;
      atual = null;
      return false;
    }

    //	caso não tenha sido definido que a chave está fora dos limites de 
    //	chaves da lista, vamos procurar no seu interior
    //	o apontador atual indica o primeiro nó da lista e consideraremos que
    //	ainda não achou a chave procurada nem chegamos ao final da lista
    bool achou = false;
    bool fim = false;

    //	repete os comandos abaixo enquanto não achou o RA nem chegou ao
    //	final da pesquisa
    while (!achou && !fim)
      // se o apontador atual vale null, indica final físico da lista
      if (atual == null)
         fim = true;
      // se não chegou ao final da lista, verifica o valor da chave atual
      else
        // verifica igualdade entre chave procurada e chave do nó atual
        if (outroProcurado.CompareTo(atual.Info) == 0)
           achou = true;
        else
          // se chave atual é maior que a procurada, significa que
          // a chave procurada não existe na lista ordenada e, assim,
          // termina a pesquisa indicando que não achou. Anterior
          // aponta o nó anterior ao atual, que foi acessado na
          // última repetição
          if (atual.Info.CompareTo(outroProcurado) > 0)
             fim = true;
          else
          {
            // se não achou a chave procurada nem uma chave > que ela,
            // então a pesquisa continua, de maneira que o apontador
            // anterior deve apontar o nó atual e o apontador atual
            // deve seguir para o nó seguinte
            anterior = atual;
            atual = atual.Prox;
          }

    // por fim, caso a pesquisa tenha terminado, o apontador atual
    // aponta o nó onde está a chave procurada, caso ela tenha sido
    // encontrada, ou aponta o nó onde ela deveria estar para manter a
    // ordenação da lista. O apontador anterior aponta o nó anterior
    // ao atual
    return achou;   // devolve o valor da variável achou, que indica
  }

  public NoLista<Dado> Atual => atual;

  public void InserirEmOrdem(Dado dados)
  {
    if (!Existe(dados))     // Existe() configura anterior e atual
    {                       // aqui temos certeza de que a chave não existe
                            // guarda dados no novo nó
      if (EstaVazia)        // se a lista está vazia, então o 	
        InserirAntesDoInicio(dados);  // dado ficará como primeiro da lista
      else
         // testa se nova chave < primeira chave
         if (anterior == null && atual != null)
            InserirAntesDoInicio(dados); // liga novo nó antes do primeiro
         else
           // testa se nova chave > última chave
           if (anterior != null && atual == null)
              InserirAposFim(dados);
           else
             InserirNoMeio(dados);  // insere entre os nós anterior e atual
    }
  }

  private void InserirNoMeio(Dado dados)
  {
    // Existe() encontrou intervalo de inclusão do novo nó

    var novo = new NoLista<Dado>(dados);
    anterior.Prox = novo;   // liga anterior ao novo
    novo.Prox = atual;      // e novo no atual

    if (anterior == ultimo)  // se incluiu ao final da lista,
       ultimo = novo;        // atualiza o apontador ultimo
    quantosNos++;            // incrementa número de nós da lista     	}	
  }

  public Dado RemoverOPrimeiro()
  {
    if (EstaVazia)
      throw new Exception("Sem dados para remover.");

    var dado = primeiro.Info;
    primeiro = primeiro.Prox;
    if (primeiro == null)       // esvaziou a lista
      ultimo = null;
    quantosNos--;

    return dado;
  }
}
