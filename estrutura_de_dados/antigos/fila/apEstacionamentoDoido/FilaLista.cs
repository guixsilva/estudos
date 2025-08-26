using System;
using System.Collections.Generic;

public class FilaLista<Tipo> : ListaSimples<Tipo>, IQueue<Tipo>
              where Tipo : IComparable<Tipo>, IEquatable<Tipo>
{
  public int Tamanho => base.QuantosNos;

  public void Enfileirar(Tipo elemento) // inclui objeto “elemento”
  {
    base.InserirAposFim(elemento);
  }

  public Tipo Retirar() // devolve objeto do início e o 
  {                     // retira da fila 
    if (!EstaVazia)
       return base.RemoverOPrimeiro();

    throw new FilaVaziaException("Fila vazia");
  }

  public Tipo OInicio() // devolve objeto do início
  {                     // sem retirá-lo da fila
    if (EstaVazia)
       throw new FilaVaziaException("Fila vazia");
    return base.Primeiro.Info; // acessa o 1o objeto genérico da lista
  }

  public Tipo OFim()  // devolve objeto do fim
  {                   // sem retirá-lo da fila 
    if (EstaVazia)
       throw new FilaVaziaException("Fila vazia");

    return base.Ultimo.Info; // acessa o 1o objeto genérico
  }

  public List<Tipo> Conteudo()
  {
    return base.Listar();
  }

}

