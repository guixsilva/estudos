
using System;

public class NoArvore<Dado> where Dado : IComparable<Dado>
{
  public Dado Info { get; set; }
  private bool isFolha;
    public NoArvore<Dado> Esq { get; set; }
  public NoArvore<Dado> Dir { get; set; }
  public bool IsFolha { get => isFolha; 
        set {
            if (Esq == null && Dir == null)
            {
                isFolha = true;
            }
            else
            {
                isFolha = false;
            }
        } }

    public NoArvore(Dado info)
  {
      Info = info;
      Esq = null;
      Dir = null;
      
  }

}
