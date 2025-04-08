using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apRefCruz
{
  public partial class FrmRefCruzada : Form
  {
    public FrmRefCruzada()
    {
      InitializeComponent();
    }

    ListaSimples<Referencia> referencias;

    private void FrmRefCruzada_Load(object sender, EventArgs e)
    {
      referencias = new ListaSimples<Referencia>();
    }

    private void btnProcessar_Click(object sender, EventArgs e)
    {
      // pedir nome do arquivo a ser processado, usando o dlgAbrir
      if (dlgAbrir.ShowDialog() == DialogResult.OK)
      {
        // abrir o arquivo selecionado para entrada de dados
        var arquivo = new StreamReader(dlgAbrir.FileName);
        int numLinha = 0;
        while (!arquivo.EndOfStream)
        {
          // ler uma linha do arquivo
          string linha = arquivo.ReadLine();
          numLinha++;   // número da linha lida agora

          // separar palavra por palavra da linha lida
          string[] palavras = linha.Split(' ');
          // percorrer o vetor de palavras e, para cada palavra:
          foreach (string palavra in palavras)
          {
            string palavraMai = palavra.ToUpper();    // maiúsculo
            // verificar se essa palavra já existe na lista referencias
            var umaRefer = new Referencia(palavraMai, numLinha);
            if (!referencias.Existe(umaRefer))
            {
              // se não existir, incluí-la em ordem com o número da linha em que foi encontrada
              referencias.InserirEmOrdem(umaRefer);
            }
            else  // existe já a palavra lida (achou em outro lugar)
            {
              if (referencias.Atual.Info.Linhas.Ultimo.Info.numLinha != numLinha)
                  referencias.Atual.Info.Linhas.InserirAposFim(new Linha(numLinha));
              // se existir, incluir apenas a linha em que ela está no fim da lista Linhas
              // do nó dessa palavra
            }
          }
        }
        // ao final do arquivo:
        arquivo.Close();
        lsbSaida.Items.Clear();
            // percorrer a lista ligada referencias sequencialmente
            //    listar a palavra de cada nó
            //    listar os números de linha de cada palavra
            //    avançar para a palavra seguinte
        NoLista<Referencia> noAtual = referencias.Primeiro;
        while (noAtual != null)
        {
          string saida = noAtual.Info.Palavra;
          NoLista<Linha> linhaAtual = noAtual.Info.Linhas.Primeiro;
          while (linhaAtual != null)
          {
            saida += " " + linhaAtual.Info.numLinha;
            linhaAtual = linhaAtual.Prox;
          }
          lsbSaida.Items.Add(saida);
          noAtual = noAtual.Prox;
        }
      }
    }
  }
}
