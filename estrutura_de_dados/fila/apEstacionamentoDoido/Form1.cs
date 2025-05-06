using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apEstacionamentoDoido
{
  public partial class FrmEstacionamento : Form
  {
    public FrmEstacionamento()
    {
      InitializeComponent();
    }

    IQueue<Carro> vagas, manobra;

    void ExibirFilas()
    {
      lsbVagas.Items.Clear();
      var carrosEstacionados = vagas.Conteudo();
      foreach (Carro carro in carrosEstacionados)
      {
        lsbVagas.Items.Add(carro.Placa);
        Thread.Sleep(500);
        Application.DoEvents();
      }

      lsbManobras.Items.Clear();
      var carrosEmManobra = manobra.Conteudo();
      foreach (Carro carro in carrosEmManobra)
      {
        lsbManobras.Items.Add(carro.Placa);
        Thread.Sleep(500);
        Application.DoEvents();
      }
    }

    private void btnIniciar_Click(object sender, EventArgs e)
    {
      btnIniciar.Enabled = false;
      gbxTipo.Enabled = false;
      if (dlgAbrir.ShowDialog() == DialogResult.OK)
      {
        var arquivo = new StreamReader(dlgAbrir.FileName);
        while (!arquivo.EndOfStream)
        {
          var dadosLidos = arquivo.ReadLine();
          char operacao = dadosLidos[0];
          string placa = dadosLidos.Substring(1, 7);
          if (operacao == 'C')   // chegou carro com a placa lida
          {
            if (vagas.Tamanho >= 20)
              lsbOcorrencias.Items.Add($"Estacionamento cheio. Carro {placa} vai embora.");
            else
            {
              lsbOcorrencias.Items.Add($"Entrou carro {placa}.");
              Thread.Sleep(50);
              Application.DoEvents();
              vagas.Enfileirar(new Carro(placa));
              ExibirFilas();
            }
          }
          else
            if (operacao == 'P')  // partiu carro com essa placa
          {
            bool achouPlaca = false;
            while (!achouPlaca && !vagas.EstaVazia)
            {
              if (vagas.OInicio().Placa == placa)  // achamos o carro
                achouPlaca = true;
              else    // não achou a placa, tem que manobrar até achá-la
              {
                var carroEmManobra = vagas.Retirar();
                lsbOcorrencias.Items.Add($"Manobrando {carroEmManobra.Placa}");
                Thread.Sleep(50);
                Application.DoEvents();
                carroEmManobra.NumeroDeManobras += 1;  // mais uma manobra
                manobra.Enfileirar(carroEmManobra);
                ExibirFilas();
              }
            }
            if (!achouPlaca)
              lsbOcorrencias.Items.Add($"Carro de placa {placa} n�o foi achado no estacionamento.");
            else
            {
              var carroPartindo = vagas.Retirar();
              lsbOcorrencias.Items.Add($"Carro de placa {placa} saiu do estacionamento após {carroPartindo.NumeroDeManobras} manobras.");
              Thread.Sleep(50);
              Application.DoEvents();
            }

            while (!manobra.EstaVazia)
            {
              var carroRetornandoAFila = manobra.Retirar();
              lsbOcorrencias.Items.Add($"Retorna carro {carroRetornandoAFila.Placa} da fila de manobras para a fila de vagas.");
              vagas.Enfileirar(carroRetornandoAFila);
            }
            ExibirFilas();
          }
        }
        arquivo.Close();
      }
      gbxTipo.Enabled = true;
    }

    private void rbVetor_CheckedChanged(object sender, EventArgs e)
    {
      vagas = new FilaVetor<Carro>();
      manobra = new FilaVetor<Carro>();
      btnIniciar.Enabled = true;
    }

    private void rbLista_CheckedChanged(object sender, EventArgs e)
    {
      vagas = new FilaLista<Carro>();
      manobra = new FilaLista<Carro>();
      btnIniciar.Enabled = true;
    }

    private void FrmEstacionamento_Load(object sender, EventArgs e)
    {
      lsbVagas.Items.Clear();
      lsbManobras.Items.Clear();
      lsbOcorrencias.Items.Clear();
    }
  }
}
