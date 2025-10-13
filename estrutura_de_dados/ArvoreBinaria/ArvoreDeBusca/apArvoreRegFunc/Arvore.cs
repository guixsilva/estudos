using System;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;


public class Arvore<Dado> 
             where Dado : IComparable<Dado>, IRegistro, new()
{
  private NoArvore<Dado>  raiz,   // raiz da árvore; nó principal
                          atual,  // ponteiro para o nó visitado atualmente
                          antecessor;  // ponteiro para o "pai" do nó noAtual

  public NoArvore<Dado> Raiz { get => raiz; set => raiz = value; }
  public NoArvore<Dado> Atual { get => atual; }
  public NoArvore<Dado> Antecessor { get => antecessor; }

  public Arvore()
  {
    raiz = atual = antecessor = null;
  }

  public void VisitarPreOrdem(ListBox lsb)
  {
    VisitarPreOrdem(raiz, lsb);
  }

  private void VisitarPreOrdem(NoArvore<Dado> atual, ListBox lsb)
  {
    if (atual != null)    // se existe um nó
    {
      lsb.Items.Add(atual.Info);  // seu dado é exibido
      VisitarPreOrdem(atual.Esq, lsb);             // chamada 1
      VisitarPreOrdem(atual.Dir, lsb);             // chamada 2
    }
  }

  public void VisitarEmOrdem(ListBox lsb)
  {
    VisitarEmOrdem(raiz, lsb);
  }

  private void VisitarEmOrdem(NoArvore<Dado> atual, ListBox lsb)
  {
    if (atual != null)    // se existe um nó
    {
      VisitarEmOrdem(atual.Esq, lsb);             // chamada 1
      lsb.Items.Add(atual.Info);  // seu dado é exibido
      VisitarEmOrdem(atual.Dir, lsb);             // chamada 2
    }
  }

  public void VisitarPosOrdem(ListBox lsb)
  {
    VisitarPosOrdem(raiz, lsb);
  }

  private void VisitarPosOrdem(NoArvore<Dado> atual, ListBox lsb)
  {
    if (atual != null)    // se existe um nó
    {
      VisitarPosOrdem(atual.Esq, lsb);             // chamada 1
      VisitarPosOrdem(atual.Dir, lsb);             // chamada 2
      lsb.Items.Add(atual.Info);  // seu dado é exibido
    }
  }

  public void Desenhar(Control tela)
  {
     if (Raiz == null) return;
     
     Graphics g = tela.CreateGraphics();
     g.Clear(Color.White);
     DesenharNo(g, Raiz, tela.Width / 2, 20, tela.Width / 4, 50);
  }

  private void DesenharNo(Graphics g, NoArvore<Dado> no, int x, int y, int deslocamentoX, int deslocamentoY)
  {
    if (no == null) return;

    Rectangle rect = new Rectangle(x - 15, y - 15, 40, 30);
    g.FillEllipse(Brushes.LightBlue, rect);
    g.DrawEllipse(Pens.Black, rect);
    g.DrawString(no.Info.ToString(), new Font("Arial", 10), Brushes.Black, x - 10, y - 10);

    if (no.Esq != null)
    {
      g.DrawLine(Pens.Black, x, y + 15, x - deslocamentoX, y + deslocamentoY);
      DesenharNo(g, no.Esq, x - deslocamentoX, y + deslocamentoY, deslocamentoX / 2, deslocamentoY);
    }

    if (no.Dir != null)
    {
      g.DrawLine(Pens.Black, x, y + 15, x + deslocamentoX, y + deslocamentoY);
      DesenharNo(g, no.Dir, x + deslocamentoX, y + deslocamentoY, deslocamentoX / 2, deslocamentoY);
    }
  }

  public bool ExisteUsandoRecursao(Dado procurado)
  {
    return ExisteRecursivo(raiz, procurado);
  }

  private bool ExisteRecursivo(NoArvore<Dado> local, Dado procurado)
  {
    if (local == null)    /// não existe o procurado nessa árvore
      return false;

    if (local.Info.CompareTo(procurado) == 0) // achamos o procurado
    {
      atual = local;    // noAtual é o atributo da árvore que aponta
                        // o nó que nos interessa no momento
      return true;      // achamos o procurado e noAtual aponta seu nó!
    }
    else
      {
        antecessor = local; // guardamos o pai do nó abaixo de local
        if (procurado.CompareTo(local.Info) < 0)  // proc < chave noAtual
          return ExisteRecursivo(local.Esq, procurado);
        else
          return ExisteRecursivo(local.Dir, procurado);
      }
  }


  public bool Existe(Dado procurado)
  {
    antecessor = null;    // a raiz não tem um antecessor
    atual = raiz;         // posiciona ponteiro de percurso no 1o nó da árvore
    while (atual != null)
    {
      if (procurado.CompareTo(atual.Info) == 0)
        return true;    // achamos e noAtual aponta o nó do procurado

      antecessor = atual; // mudaremos para o nível debaixo deste
      if (procurado.CompareTo(atual.Info) < 0)
        atual = atual.Esq;  // à esquerda, ficam os menores que noAtual
      else
        atual = atual.Dir;  // à direita, ficam os maiores que noAtual
    }
    return false;
  }

  public void Incluir(Dado novoDado)
  {
    IncluirRec(ref raiz, novoDado);
  }

  private void IncluirRec(ref NoArvore<Dado> local, Dado novoDado)
  {
    if (local == null)
    {
      local = new NoArvore<Dado>(novoDado);
    }
    else
      if (local.Info.CompareTo(novoDado) == 0)
        throw new Exception("Já existe");   // já existe o dado a incluir, não inclui.
    else
      if (novoDado.CompareTo(local.Info) < 0)
      {
        NoArvore<Dado> descendente = local.Esq;
        IncluirRec(ref descendente, novoDado);
        local.Esq = descendente;
      }
      else
      {
        NoArvore<Dado> descendente = local.Dir;
        IncluirRec(ref descendente, novoDado);
        local.Dir = descendente;
      }
  }


  public void Inserir(Dado novoDado)
  {
    bool achou = false, fim = false;
    NoArvore<Dado> novoNo = new NoArvore<Dado>(novoDado);
    if (raiz == null) // árvore vazia
      raiz = novoNo;  // inclui o 1o nó nessa árvore
    else // árvore não-vazia
    {
      antecessor = null;
      atual = raiz;
      while (!achou && !fim)
      {
        antecessor = atual;
        if (novoDado.CompareTo(atual.Info) < 0)
        {
          atual = atual.Esq;
          if (atual == null)
          {
            antecessor.Esq = novoNo;
            fim = true;
          }
        }
        else
         if (novoDado.CompareTo(atual.Info) == 0)
            achou = true; // pode-se disparar uma exceção neste caso
         else
         {
            atual = atual.Dir;
            if (atual == null)
            {
              antecessor.Dir = novoNo;
              fim = true;
            }
         }
      }
    }
  }

  public bool IncluirNovoDado(Dado novoDado)
  {
    if (Existe(novoDado)) // achou!
      return false;       // não incluiu pois já existe

    if (raiz == null)
      raiz = new NoArvore<Dado>(novoDado);
    else
      // não achou, mas o método Existe() ajustou antecessor e noAtual
      // antecessor é o pai do novo nó a incluir, decidimos para que
      // lado será feita a ligação com o nó antecessor
      if (novoDado.CompareTo(antecessor.Info) < 0)
        antecessor.Esq = new NoArvore<Dado>(novoDado);  // liga à esquerda
      else
        antecessor.Dir = new NoArvore<Dado>(novoDado);  // liga à direita
    return true;    // feita a inclusão
  }

  public bool Excluir(Dado dadoAExcluir)
  {
    if (Existe(dadoAExcluir)) // ajusta os ponteiros atual e antecessor
    {
      // se atual (nó procurado e encontrado) é a raiz, e a raiz
      // não tem filhos, simplesmente removemos essa raiz colocando
      // null no seu ponteiro (atributo raiz)
      if (atual == raiz && raiz.Esq == null && raiz.Dir == null)
      { 
        raiz = null;    // removemos o único nó dessa árvore
        return true;
      }

      // atual não é a raiz 
      // se o nó a excluir é uma folha:
      if (atual.Esq == null && atual.Dir == null)
      {
        // descobrimos de que lado do antecessor o atual está
        if (atual.Info.CompareTo(antecessor.Info) < 0)
           antecessor.Esq = null;  // filho esquerdo é desligado do pai
        else
          antecessor.Dir = null;  // filho direito é desligado do pai
        
        return true;  // nó desejado foi removido
      }

      // se o fluxo de execução chegar aqui, é porque o nó atual
      // tem, pelo menos, um filho

      // 2o caso: nó a excluir com um único filho
      if ((atual.Esq != null) != (atual.Dir != null))
      {
        // descobrir de que lado o atual (filho) é apontado pelo
        // antecessor (pai do nó a excluir)
        if (atual.Info.CompareTo(antecessor.Info) < 0)  // atual à esquerda do seu pai
        { 
          if (atual.Esq == null)
            antecessor.Esq = atual.Dir;
          else
            antecessor.Esq = atual.Esq;
        }
        else   // pai aponta o atual (filho) à direita
        {                                 // e terá de apontar o neto
          if (atual.Esq == null)
            antecessor.Dir = atual.Dir;
          else
            antecessor.Dir = atual.Esq;
        }
        return true;  // excluiu nó com um único filho
      }

      // 3o caso: nó a excluir tem os dois filhos (Esq e Dir)
      // apontamos o filho esquerdo do nó a excluir:
      NoArvore<Dado> antMaior = atual;
      var maiorDosMenores = atual.Esq;

      // agora vamos todo o possível para a direita para acharmos
      // a maior das chaves menores que a do nó a excluir (atual)
      while (maiorDosMenores.Dir != null)
      {
        antMaior = maiorDosMenores;
        maiorDosMenores = maiorDosMenores.Dir;  // à direita estão as maiores chaves
      }

      // substitui a informação do atual pela informação do nó com
      // a maior das menores chaves em relação ao atual
      atual.Info = maiorDosMenores.Info;
      if (antMaior.Esq == maiorDosMenores)
        antMaior.Esq = null;  // quando há só um nó à esquerda do nó a excluir
      else
        antMaior.Dir = maiorDosMenores.Esq;   // neto do pai do nó excluído
      return true;
    }
    return false;
  }

  public void LerArquivoDeRegistros(string nomeArquivo)
  {
    raiz = null;    // arvore fica vazia
    Dado dado = new Dado();
    var origem = new FileStream(nomeArquivo, FileMode.OpenOrCreate);
    var arquivo = new BinaryReader(origem);
    int posicaoFinal = (int)origem.Length / dado.TamanhoRegistro - 1;
    Particionar(0, posicaoFinal, ref raiz);
    origem.Close();
    void Particionar(long inicio, long fim, ref NoArvore<Dado> noAtual)
    {
      if (inicio <= fim)
      {
        long meio = (inicio + fim) / 2;
        dado = new Dado(); // cria um objeto para armazenar os dados
        dado.LerRegistro(arquivo, meio); // 
        noAtual = new NoArvore<Dado>(dado);
        var novoEsq = noAtual.Esq;
        Particionar(inicio, meio - 1, ref novoEsq); // Particiona à esquerda 
        noAtual.Esq = novoEsq;
        var novoDir = noAtual.Dir;
        Particionar(meio + 1, fim, ref novoDir); // Particiona à direita 
        noAtual.Dir = novoDir;
      }
    }
  }

  public void GravarArquivoDeRegistros(string nomeArquivo)
  {
    var destino = new FileStream(nomeArquivo, FileMode.Create);
    var arquivo = new BinaryWriter(destino);
    GravarInOrdem(raiz);
    arquivo.Close();

    void GravarInOrdem(NoArvore<Dado> noAtual)
    {
      if (noAtual != null)
      {
        GravarInOrdem(noAtual.Esq);
        noAtual.Info.GravarRegistro(arquivo);
        GravarInOrdem(noAtual.Dir);
      }
    }
  }


  // Exercício 1

  public bool EquivaleA(Arvore<Dado> b)
  {
    if (b == null)
      return false;

    return Equivalente(this.raiz, b.raiz); // Árvore A é a this

    // na aplicação, temos duas árvores instanciadas
    // if (arvA.Equivalente(arvB))
    //    chkEquivalentes.checked = true;
    // else
    //    chkEquivalentes.checked = false;

    // ou
    //    chkEquivalentes.checked = arvA.Equivalente(arvB);
  }

  private bool Equivalente(NoArvore<Dado> atualA, NoArvore<Dado> atualB)
  {
    if (atualA == null && atualB == null)
      return true;

    if ((atualA == null) != (atualB == null))
      return false;  // uma é nula e outra não é

    // ambas são não nulas

    if (atualA.Info.CompareTo(atualB.Info) != 0)  // dados diferentes em nós correspondente
      return false;

    // infos das duas são iguais até aqui
    return Equivalente(atualA.Esq, atualB.Esq) &&
           Equivalente(atualA.Dir, atualB.Dir);
  }

  // Exercício 2

  public int QuantosNos()
  {
    return QuantosNos(raiz);
  }

  private int QuantosNos(NoArvore<Dado> atual)
  {
    // aqui faz o percurso e contagem recursivos
    if (atual == null) return 0;

    int quantosAEsquerda = QuantosNos(atual.Esq);
    int quantosADireita = QuantosNos(atual.Dir);
    return 1 +                // conta o nó noAtual
       +quantosAEsquerda     // conta nós da subárvore esquerda
       + quantosADireita;     // conta nós da subárvore direita
  }

  // Exercício 3

  public int QuantasFolhas()    // chamado pela aplicação
  {
    return QuantasFolhas(this.raiz);  // chamada 0

    // na aplicação:
    //
    // txtQuantasFolhas.Text = minhaArvore.QuantasFolhas()+"";
  }


  private int QuantasFolhas(NoArvore<Dado> noAtual)
  {
    if (noAtual == null)
      return 0;

    if (noAtual.Esq == null && noAtual.Dir == null) // noAtual é folha
      return 1;

    // noAtual não é folha, portanto procuramos as folhas de cada ramo e as contamos
    return QuantasFolhas(noAtual.Esq) + // conta folhas da subárvore esquerda - chamada 1
           QuantasFolhas(noAtual.Dir);  // conta folhas da subárvore direita  - chamada 2
  }

  // Exercício 4

  public bool EstritamenteBinaria()
  {
    return EstritamenteBinaria(this.raiz);
  }

  private bool EstritamenteBinaria(NoArvore<Dado> noAtual)
  {
    if (noAtual == null)
      return true;

    // noAtual não é nulo
    if (noAtual.Esq == null && noAtual.Dir == null)
      return true;

    // um dos descendentes é nulo e o outro não é
    if ((noAtual.Esq != null) != (noAtual.Dir != null))
      return false;

    // se chegamos aqui, nenhum dos descendentes é nulo, dai testamos a
    // "estrita binariedade" das duas subárvores descendentes do nó noAtual
    return EstritamenteBinaria(noAtual.Esq) && EstritamenteBinaria(noAtual.Dir);
  }


  // Exercício 5

  public int Altura()
  {
    return Altura(this.Raiz);   // chamada 0
  }

  private int Altura(NoArvore<Dado> noAtual)
  {
    int alturaEsquerda,
        alturaDireita;

    if (noAtual == null)
      return 0;

    alturaEsquerda = Altura(noAtual.Esq); // chamada 1
    alturaDireita = Altura(noAtual.Dir);  // chamada 2

    if (alturaEsquerda >= alturaDireita)
      return 1 + alturaEsquerda;

    return 1 + alturaDireita;
  }

  private int Altura2(NoArvore<Dado> noAtual)
  {
    int alturaEsquerda,
        alturaDireita;

    if (noAtual == null)
      return 0;

    alturaEsquerda = Altura2(noAtual.Esq);
    alturaDireita = Altura2(noAtual.Dir);

    return 1 + Math.Max(Altura2(noAtual.Esq), Altura2(noAtual.Dir));
  }

  private int Altura3(NoArvore<Dado> noAtual)
  {
    if (noAtual == null)
      return 0;

    return 1 +
      Math.Max(Altura3(noAtual.Esq), Altura3(noAtual.Dir));
  }

  // Exercício 6 – Escrever a estrutura da árvore no formato ( Chave : AE, AD )

  public string EntreParenteses()
  {
    return EntreParenteses(this.raiz);
  }

  private string EntreParenteses(NoArvore<Dado> noAtual)
  {
    string saida = "(";
    if (noAtual != null)
      saida += noAtual.Info + ":" +
      EntreParenteses(noAtual.Esq) +
      "," +
      EntreParenteses(noAtual.Dir);
    saida += ")";
    return saida;
  }

  // Exercício 7 – Trocar ramos esquerdo e direito entre si
  public void Espelhar()
  {
    Espelhar(this.raiz);
  }

  private void Espelhar(NoArvore<Dado> noAtual)
  {
    if (noAtual != null)
    {
      NoArvore<Dado> auxiliar = noAtual.Esq;
      noAtual.Esq = noAtual.Dir;
      noAtual.Dir = auxiliar;
      Espelhar(noAtual.Esq);
      Espelhar(noAtual.Dir);
    }
  }

  // Exercício 8 – Percurso por níveis
  public string PercursoPorNiveis()   // chamado pela aplicação
  {
    return PercursoPorNiveis(this.raiz);
  }

  private string PercursoPorNiveis(NoArvore<Dado> noAtual)
  {
    string saida = "";
    var umaFila = new FilaLista<NoArvore<Dado>>();
    while (noAtual != null)
    {
      saida += " " + noAtual.Info;

      if (noAtual.Esq != null)
        umaFila.Enfileirar(noAtual.Esq);

      if (noAtual.Dir != null)
        umaFila.Enfileirar(noAtual.Dir);

      if (umaFila.EstaVazia)
        noAtual = null;      // para terminar o while
      else
        noAtual = umaFila.Retirar();
    }
    return saida;
  }

  // exercicio 9
  int[] quantosNoNivel = new int[1000];

  public int Largura()
  {
    for (int i = 0; i < 1000; i++)
       quantosNoNivel[i] = 0;
    ContarNosNosNiveis(this.Raiz, 0);
    int indMaior = 0;
    for (int indNivel = 1; indNivel < 1000; indNivel++)
      if (quantosNoNivel[indNivel] > quantosNoNivel[indMaior])
         indMaior = indNivel;
    return quantosNoNivel[indMaior];
  }

  private void ContarNosNosNiveis(NoArvore<Dado> noAtual, 
                                  int qualNivel)
  {
    if (noAtual != null)
    {
      ++quantosNoNivel[qualNivel];
      ContarNosNosNiveis(noAtual.Esq, qualNivel + 1);
      ContarNosNosNiveis(noAtual.Dir, qualNivel + 1);
    }
  }

  // exercício 10
  bool achou = false; // GLOBAL NA CLASSE
  string saida = "";
  private string EscreverAntecessores(NoArvore<Dado> atual, 
                                      Dado procurado)
  {
    if (atual != null)
    {
      if (!achou)
         EscreverAntecessores(atual.Esq, procurado);
      if (!achou)
        EscreverAntecessores(atual.Dir, procurado);
      if (atual.Info.CompareTo(procurado) == 0)
         achou = true;
      if (achou && atual.Info.CompareTo(procurado) != 0)
        saida +=" "+atual.Info;
    }
    return saida;
  }

  public string preparaEscritaDosAntecessores(Dado procurado)
  {
    achou = false;
    saida = "";
    return EscreverAntecessores(Raiz, procurado);
  }

  // Exercícios 13 - página 177

  // 13.1

  public Arvore<Dado> CopiaInvertida()
  {

    Arvore<Dado> invertida = new Arvore<Dado>();
    CopiarInvertida(this.raiz, ref invertida.raiz);
    return invertida;
  }

  private void CopiarInvertida(NoArvore<Dado> noAtual,
                               ref NoArvore<Dado> novo)
  {
    if (noAtual == null)
      novo = null;
    else
    {
      novo = new NoArvore<Dado>(noAtual.Info);
      NoArvore<Dado> novoDir = novo.Dir, novoEsq = novo.Esq;
      CopiarInvertida(noAtual.Esq, ref novoDir);  // chamada 1
      novo.Dir = novoDir;
      CopiarInvertida(noAtual.Dir, ref novoEsq);  // chamada 2
      novo.Esq = novoEsq;
    }
  }


  // 13.2

  public double Calculo()
  {
    return Calculo(raiz);
  }

  double[] valorDe = { 4.8, -2.7, 6.1, 17, 3.0, -2, 5, 2, 18.87, 10.05 };

  private char ConverterParaLetra(Dado info)
  {
    if (info is char)
      return info.ToString().ToUpper()[0];
    return 'A';
  }

  private bool EhLetra(char simbolo)
  {
    return simbolo >= 'A' && simbolo <= 'Z' || simbolo >= 'a' && simbolo <= 'z';
  }

  private double Calculo(NoArvore<Dado> noAtual)
  {
    if (noAtual == null)
      return 0;

    char oSimbolo = ConverterParaLetra(noAtual.Info);
    if (EhLetra(oSimbolo))
      return valorDe[oSimbolo - 'A'];

    switch (oSimbolo)
    {
      case '@': return -Calculo(noAtual.Dir); 
      case '+': return Calculo(noAtual.Esq) + Calculo(noAtual.Dir); 
      case '-': return Calculo(noAtual.Esq) + Calculo(noAtual.Dir); 
      case '*': return Calculo(noAtual.Esq) + Calculo(noAtual.Dir);
      case '/': return Calculo(noAtual.Esq) + Calculo(noAtual.Dir); 
      case '^': return Math.Pow(Calculo(noAtual.Esq), Calculo(noAtual.Dir)); 
      default: return 0;
    }
  }
}

