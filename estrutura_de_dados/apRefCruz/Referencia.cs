using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apRefCruz
{
  public class Referencia : IComparable<Referencia>, IRegistro
  {
    string palavra;
    ListaSimples<Linha> linhas;

    public ListaSimples<Linha> Linhas 
    { get => linhas; 
      set => linhas = value; 
    }
    public string Palavra { get => palavra; }

    public Referencia(string palavra, int linha)
    {
      this.palavra = palavra;
      linhas = new ListaSimples<Linha>();
      this.linhas.InserirAposFim(new Linha(linha));
    }

    public Referencia(string palavraLida)
    {
      this.palavra = palavraLida;
      linhas = null;
    }

    public int CompareTo(Referencia outraReferencia)
    {
      return this.palavra.CompareTo(outraReferencia.palavra);
    }

    public string FormatoDeArquivo()
    { return this.palavra; }
  }
}
