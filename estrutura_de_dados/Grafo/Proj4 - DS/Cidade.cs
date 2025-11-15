using AgendaAlfabetica;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Proj4
{
  public class Cidade : IComparable<Cidade>, IRegistro
  {
    string nome;
    double x, y;
    ListaSimples<Ligacao> ligacoes = new ListaSimples<Ligacao>();

    const int tamanhoNome = 25;
    const int tamanhoRegistro = tamanhoNome+ (2 * sizeof(double));

    public string Nome
    {
      get => nome;
      set => nome = value.PadRight(tamanhoNome, ' ').Substring(0, tamanhoNome);
    }

    public Cidade(string nome, double x, double y)
    {
      this.Nome = nome;
      this.x = x;
      this.y = y;
    }
    public override string ToString()
    {
      return Nome.TrimEnd() + " (" + ligacoes.QuantosNos + ")";
    }

    public Cidade()
    {
      this.Nome = "";
      this.x = 0;
      this.y = 0;
    }

    public Cidade(string nome)
    {
      this.Nome = nome;
    }

    public int CompareTo(Cidade outraCid)
    {
      return Nome.CompareTo(outraCid.Nome);
    }

    public int TamanhoRegistro { get => tamanhoRegistro; }
    public double X { get => x; set => x = value; }
    public double Y { get => y; set => y = value; }

    public void LerRegistro(BinaryReader arquivo, long qualRegistro)
    {
            long posicao = tamanhoRegistro * qualRegistro; // posição que será procurada (para ler a lista toda, o parâmetro será 0)

            arquivo.BaseStream.Seek(posicao, SeekOrigin.Begin); // inicia leitura do arquivo a partir da posição
            char[] nomeBinario = arquivo.ReadChars(tamanhoNome); // Lê o nome da cidade. Ele cria um vetor de chars para cada letra

            string nomeFormatado = "";
            for (int i = 0; i < tamanhoNome; i++)
                nomeFormatado += nomeBinario[i];
            Nome = nomeFormatado;

            double xBinario = arquivo.ReadInt64();
            double yBinario = arquivo.ReadInt64();

            this.nome = nomeFormatado;
            this.y = yBinario;
            this.x = xBinario;
            this.ligacoes = new ListaSimples<Ligacao>();
        }

    public void GravarRegistro(BinaryWriter arquivo)
    {
            if(arquivo != null)
            {
                using (arquivo)
                {
                    char[] umNome = new char[tamanhoNome];
                    for (int i = 0; i < tamanhoNome; i++)
                        umNome[i] = nome[i];
                    arquivo.Write(umNome);
                    arquivo.Write(this.x);
                    arquivo.Write(this.y);
                }
            }

        }

        public void InsereLigacao(Ligacao ligacao)
        {
            ligacoes.InserirAposFim(ligacao);
        }
  }

}
