using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace apSumerpercado
{
  public partial class FrmSupermercado : Form
  {
    const int quantasFilas = 6;

    // declaramos um vetor de filas 
    FilaVetor<int>[] asFilas;
    public FrmSupermercado()
    {
      InitializeComponent();
    }

    private void FrmSupermercado_Load(object sender, EventArgs e)
    {
      // instanciamos o vetor de filas com tamanho igual a
      // quantasFilas:
      asFilas = new FilaVetor<int>[quantasFilas];

      // percorremos o vetor de filas e instanciamos uma
      // fila em cada uma de suas posições:
      for (int indice = 0; indice < quantasFilas; indice++)
          asFilas[indice] = new FilaVetor<int>(30);

      dgvFilas.ColumnCount = quantasFilas;
      for (int indice = 0; indice < quantasFilas; indice++)
        dgvFilas.Columns[indice].HeaderText = 
                        Convert.ToString(indice + 1);

      lsbMensagens.Items.Clear();
    }

    // retorna o índice de asFilas para a menor fila
    private int MenorFila()
    {
      int filaMaisVazia = 0;  // supomos que é a fila 0
      for (int indice = 1; indice < quantasFilas; indice++)
          if (asFilas[indice].Tamanho < asFilas[filaMaisVazia].Tamanho)
             filaMaisVazia = indice;

      return filaMaisVazia;
    }

    private int MaiorFila()
    {
      int filaMaisCheia = 0;  // supomos que é a fila 0
      for (int indice = 0; indice < quantasFilas; indice++)
        if (asFilas[indice].Tamanho >  asFilas[filaMaisCheia].Tamanho)
           filaMaisCheia = indice;

      return filaMaisCheia;
    }

    private void ExibirFila(int qualFila)
    {
      var clientesDaFila = asFilas[qualFila].Conteudo();
      dgvFilas.RowCount = asFilas[MaiorFila()].Tamanho;
      int linha = 0;
      foreach (int umCliente in clientesDaFila)
      {
        dgvFilas[qualFila, linha++].Value = umCliente;
        Thread.Sleep(10);
        Application.DoEvents();
      }
    }
    private void btnSimular_Click(object sender, EventArgs e)
    {
      int clienteAtual = 0;
      int rodadasSemClientes = 0;
      Random sorteio = new Random();
      lsbMensagens.Items.Clear();
      bool deveContinuar = true;
      while (deveContinuar)
      {
        lbSemClientes.Text = "Sem clientes: " + rodadasSemClientes;
        // tratamos o evento de entrada de cliente
        double valorSorteado = sorteio.NextDouble();
        if ((valorSorteado < 0.8 && clienteAtual < 200) || // apareceu um cliente
            (valorSorteado < 0.4 && clienteAtual >= 200))
        {
          lbValorSorteado.Text = valorSorteado + "";
          clienteAtual++;  // identifica novo cliente
          int menorFila = MenorFila();    // índice da menor fila do vetor asFilas
          asFilas[menorFila].Enfileirar(clienteAtual);
          lsbMensagens.Items.Add($"Cliente {clienteAtual} entrou no caixa {menorFila}");
          ExibirFila(menorFila);
          rodadasSemClientes = 0; // quebra sequência de 
                                  // rodadas sem clientes
        }
        else
          rodadasSemClientes++;   // significa que não apareceu cliente nesta rodada

        // tratamos o evento de saídas de cliente
        valorSorteado = sorteio.NextDouble();
        if (valorSorteado < 0.51)  // um cliente deverá sair
        {
          int qualCaixa = sorteio.Next(quantasFilas); // sorteamos o número do caixa - 0 a quantasFilas
          try
          {
            int clienteSaindo = asFilas[qualCaixa].Retirar();
            lsbMensagens.Items.Add(
     $"Cliente {clienteSaindo} saiu do caixa {qualCaixa}");
            ExibirFila(qualCaixa);
          }
          catch
          {
            lsbMensagens.Items.Add($"{qualCaixa} está vazio");
          }
        }

        lbQuantosClientesAgora.Text = TotalDeClientes().ToString();
        deveContinuar = rodadasSemClientes < 5;
      }
    }
  
    private int TotalDeClientes()
    {
      int total = 0;
      for (int indice = 0; indice < quantasFilas; indice++)
        total += asFilas[indice].Tamanho;

      return total;
    }

    private void lbSemClientes_Click(object sender, EventArgs e)
    {

    }
  }
}
