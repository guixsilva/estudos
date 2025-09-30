
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public class Arvore<Dado> where Dado : IComparable<Dado>
{
  public NoArvore<Dado> Raiz { get; private set; }

  ////////// CODIFIQUE A PARTIR DAQUI OS MÉTODOS SOLICITADOS ////////// 
    // GUILHERME DA SILVA PEREIRA - 23519

    public void Inserir(Dado novoDado, Dado dadoExistente, bool esquerda)
    {
        InserirRecursivo(Raiz, novoDado, dadoExistente, esquerda);
    }

    private void InserirRecursivo(NoArvore<Dado> atual, Dado novoDado, Dado dadoExistente, bool esquerda)
    {
        NoArvore<Dado> antecessor = atual;
        NoArvore<Dado> backup;
        if (atual == null)
        {
            NoArvore<Dado> noArvore = new NoArvore<Dado>(novoDado);
            Raiz = noArvore;
        }
        ;

        if (dadoExistente == null)
        {

                NoArvore<Dado> noArvore = new NoArvore<Dado>(novoDado);
                if (esquerda)
                {
                    backup = Raiz.Esq;
                    Raiz.Esq = noArvore;
                    noArvore.Esq = backup;
                }
                backup = Raiz.Dir;
                Raiz.Dir = noArvore;
                noArvore.Dir = backup;
        }
        else
        {
            if (Buscar(dadoExistente, out antecessor))
            {
                NoArvore<Dado> noArvore = new NoArvore<Dado>(novoDado);

                if (esquerda)
                {
                    backup = antecessor.Esq;
                    antecessor.Esq = noArvore;
                    noArvore.Esq = backup;
                }
                else
                {
                    backup = antecessor.Dir;
                    antecessor.Dir = noArvore;
                    noArvore.Dir = backup;
                }
            }
        }
        
    }


    public int ContaNosInternos()
    {
        return ContaFolhasRecursivo(Raiz);
    }

    private int ContaFolhasRecursivo(NoArvore<Dado> noAtual)
    {
        if (noAtual == null)
        {
            return 0;
        }

        if (noAtual.IsFolha == false)
        {
            return 1;
        }

        return ContaFolhasRecursivo(noAtual.Esq) + ContaFolhasRecursivo(noAtual.Dir);
    }

    public void CaminhoAte(Dado procurado, ref List<NoArvore<Dado>> lista)
    {
        CaminhoAteRecursivo(Raiz, procurado, ref lista);
    }

    private List<NoArvore<Dado>> CaminhoAteRecursivo(NoArvore<Dado> atual, Dado procurado, ref List<NoArvore<Dado>> lista)
    {
        if(atual == null) return null;
        else
        {
            if(atual.Info.CompareTo(procurado) != 0)
            {
                lista.Add(atual);
                CaminhoAteRecursivo(atual.Esq, procurado, ref lista);
                CaminhoAteRecursivo(atual.Dir, procurado, ref lista);
            }
            else
            {
                return lista;
            }
        }

        return lista;
    }

    public bool EstaBalanceada()
    {
        int alturaEsq = 0, alturaDir = 0;
        EstaBalanceadaRecursivo(Raiz, ref alturaEsq, ref alturaDir);

        if(alturaEsq - alturaDir <= 1 || alturaEsq - alturaDir >= -1)
        {
            return true;
        }

        return false;
    }

    private void EstaBalanceadaRecursivo(NoArvore<Dado> atual, ref int alturaEsq, ref int alturaDir)
    {
        if(atual == null)
        {
            return;
        }
        else
        {
            alturaEsq = Math.Abs(AlturaRecursiva(atual.Esq));
            alturaDir = Math.Abs(AlturaRecursiva(atual.Dir));
        }
    }

   public int SomaDosDados()
   {
        int resultado = 0;
        return SomaRecursiva(Raiz, ref resultado);
   }

    public int SomaRecursiva(NoArvore<Dado> atual,ref int soma)
    {
        if (atual == null)
        {
            return 0;
        }
        else
        {
            try
            {
                int numInt = Convert.ToInt32(atual.Info);
                soma =+ numInt;
                return SomaRecursiva(atual.Esq, ref soma) + SomaRecursiva(atual.Dir, ref soma);
            }
            catch (Exception e)
            {
                return 0;
            }

        }
    }




    ////////////////////////////////////////////////////////
    //// Métodos previamente codificados. Não os modifique.
    ////////////////////////////////////////////////////////

    public int Altura()
  {
    return AlturaRecursiva(Raiz);
  }

  private int AlturaRecursiva(NoArvore<Dado> no)
  {
    if (no == null) return -1;
    return 1 + Math.Max(AlturaRecursiva(no.Esq), AlturaRecursiva(no.Dir));
  }

  public bool Buscar(Dado procurado, out NoArvore<Dado> onde)
  {
    return BuscarRecursivo(Raiz, procurado, out onde);
  }

  private bool BuscarRecursivo(NoArvore<Dado> no, Dado procurado, out NoArvore<Dado> onde)
  {
    if (no == null)
    {
      onde = null;
      return false;
    }

    if (no.Info.Equals(procurado))
    {
      onde = no;
      return true;
    }

    if (BuscarRecursivo(no.Esq, procurado, out onde))
      return true;
    return BuscarRecursivo(no.Dir, procurado, out onde);
  }

  public void Desenhar(PictureBox pictureBox)
  {
    if (Raiz == null) return;

    Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
    using (Graphics g = Graphics.FromImage(bmp))
    {
      g.Clear(Color.White);
      DesenharNo(g, Raiz, pictureBox.Width / 2, 20, pictureBox.Width / 4, 50);
    }
    pictureBox.Image = bmp;
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
}
