using System;
using System.Data.SqlTypes;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;


public class Arvore<Dado> where Dado : IComparable<Dado>
{
  private NoArvore<Dado> raiz, atual, antecessor;

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

  public void Desenhar(Graphics g, int x, int y)
  {
    Desenhar(true, this.raiz, x, y, Math.PI / 2, 1, 300, g);
  }

  private void Desenhar(bool primeiraVez, NoArvore<Dado> atual,
    int x, int y, double angulo, double incremento,
    double comprimento, Graphics g)
  {
    if (atual != null)
    {
      int xf, yf;   // ponto final de uma linha reta (ramo da árvore)
      Pen caneta = new Pen(Color.Red);
      xf = (int)Math.Round(x + Math.Cos(angulo) * comprimento);
      yf = (int)Math.Round(y + Math.Sin(angulo) * comprimento);
      if (primeiraVez)
        yf = 25;

      g.DrawLine(caneta, x, y, xf, yf);

      Desenhar(false, atual.Esq, xf, yf, Math.PI / 2 + incremento,
       incremento * 0.60, comprimento * 0.8, g);

      Desenhar(false, atual.Dir, xf, yf, Math.PI / 2 - incremento,
      incremento * 0.60, comprimento * 0.8, g);

      // Desenhar o nó da árvore

      SolidBrush preenchimento = new SolidBrush(Color.Blue);
      g.FillEllipse(preenchimento, xf - 25, yf - 15, 42, 30);
      g.DrawString(Convert.ToString(atual.Info), 
        new Font("Comic Sans", 10),
        new SolidBrush(Color.Yellow), xf - 23, yf - 7);
    }
  }

  // Exercício 1

  public bool Eq(Arvore<Dado> b)
  {
    return Eq(this.raiz, b.raiz); // Árvore A é a this
  }

  private bool Eq(NoArvore<Dado> atualA, NoArvore<Dado> atualB)
  {
    return false;
  }

  // Exercício 2

  public int QuantosNos()
  {
    return QuantosNos(raiz);
  }

  private int QuantosNos(NoArvore<Dado> atual)
  {
    // aqui faz o percurso e contagem recursivos
  }

  // exercício 7

  public void Espelhar()
  {

  }
}

