using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apRefCruz
{
  public class Linha : IComparable<Linha>, IRegistro
  {
    int linha;

    public Linha(int linha)
    {
      this.linha = linha;
    }

    public int numLinha { get => linha; }

    public int CompareTo(Linha outra)
    {
      return this.linha - outra.linha;  // valor negativo, 0, positivo
    }

    public string FormatoDeArquivo()
    {
      return linha.ToString();
    }
  }
}
