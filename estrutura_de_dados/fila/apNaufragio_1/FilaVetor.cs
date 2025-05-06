using System;
using System.Collections.Generic;

public class FilaVetor<Tipo> : IQueue<Tipo>
{
  public const int MAXIMO = 500;  // tamanho default
  int posicoes;                   // tamanho dado na aplicação
  Tipo[] fila;                    // vetor de objetos Tipo
  int inicio, fim;                // índices da fila

  public FilaVetor(int tamanhoDesejado)
  {
    fila = new Tipo[tamanhoDesejado];
    posicoes = tamanhoDesejado;
    inicio = fim = 0;       // indica fila vazia
  }

  public FilaVetor() : this(MAXIMO)
  {
  }

  public int Tamanho => (posicoes - inicio + fim) % posicoes; 

  public bool EstaVazia => inicio == fim;

  public void Enfileirar(Tipo elemento)
  {
    if (Tamanho == posicoes - 1)
       throw new FilaCheiaException("Fila cheia (overflow)");
    fila[fim] = elemento;       // inclui elemento na primeira posição livre
    fim = (fim + 1) % posicoes; // calcula próxima posição livre
  }

  public Tipo OFim()
  {
    if (EstaVazia)
       throw new FilaVaziaException("Underflow da fila");
    Tipo ultimo;
    if (fim == 0)
       ultimo = fila[posicoes - 1]; // devolve o objeto do final da fila
    else                            // sem retirá-lo da fila
      ultimo = fila[fim - 1];
    return ultimo;
  }

  public Tipo OInicio()
  {
    if (EstaVazia)
      throw new FilaVaziaException("Esvaziamento (underflow) da fila");
    Tipo primeiro = fila[inicio];	// devolve o objeto do início da fila
    return primeiro; 		         	// sem retirá-lo da fila

  }

  public Tipo Retirar()
  {
    if (EstaVazia)
       throw new FilaVaziaException("Underflow da fila");
    Tipo primeiro = fila[inicio];  		// copia o elemento inicial da fila
    fila[inicio] = default(Tipo);   	// libera memória
    inicio = (inicio + 1) % posicoes; // calcula novo inicio da fila
    return primeiro;
  }

  public List<Tipo> Conteudo()
  {
    var saida = new List<Tipo>();
    var outraFila = new FilaVetor<Tipo>(posicoes);
    while (! this.EstaVazia)
    {
      var dadoDoInicio = this.Retirar();
      saida.Add(dadoDoInicio);
      outraFila.Enfileirar(dadoDoInicio);
    }

    while (! outraFila.EstaVazia)
      this.Enfileirar(outraFila.Retirar());

    return saida;
  }
}

