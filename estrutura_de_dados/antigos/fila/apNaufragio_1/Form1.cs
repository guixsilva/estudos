using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace apNaufragio_1
{
  public partial class FrmTitanic : Form
  {
    public FrmTitanic()
    {
      InitializeComponent();
    }

    private void FrmTitanic_Load(object sender, EventArgs e)
    {
      lsbSalvos.Items.Clear();
      lsbSalvos.Items.Add("Salvos - Clique duplo para iniciar o processo");
    }

    private void lsbSalvos_DoubleClick(object sender, EventArgs e)
    {
      IQueue<Pessoa>[] filas = null; 
      lsbNaoSalvos.Items.Clear();
      lsbSalvos.Items.Clear();
      if (dlgAbrir.ShowDialog() == DialogResult.OK)
      {
        if (rbVetor.Checked)
        {
          filas = new FilaVetor<Pessoa>[5];  // 5 prioridades
          for (int ind = 0; ind < 5; ind++)
            filas[ind] = new FilaVetor<Pessoa>();
        }
        else
          if (rbLista.Checked)
          {
            filas = new FilaLista<Pessoa>[5];  // 5 prioridades
            for (int ind = 0; ind < 5; ind++)
              filas[ind] = new FilaLista<Pessoa>();
          }

        var arquivo = new StreamReader(dlgAbrir.FileName);

        MessageBox.Show("Iniciando a leitura do arquivo.");
        int qualFila = 0;
        while (!arquivo.EndOfStream)
        {
          var linha = arquivo.ReadLine();
          var umaPessoa = new Pessoa(linha);
          if (umaPessoa.Genero == 'F')
            if (umaPessoa.Idade <= 15)
              qualFila = 1;
            else
              if (umaPessoa.Idade <= 35)
              qualFila = 3;
            else
              qualFila = 4;
          else
            if (umaPessoa.Idade <= 15)
              qualFila = 2;
            else
              qualFila = 5;
          filas[qualFila - 1].Enfileirar(umaPessoa);
        }
        arquivo.Close();
        MessageBox.Show("Iniciando a distribuição nos botes.");
        int qualBote = 1,           // bote inicial de desembarque
            qualLugarNoBote = 1;    // lugar inicial nesse bote
        qualFila = 0; // fila das meninas at� 15 anos
        bool fim = false;
        while (!fim)  // deixamos as filas fluirem pelos lugares dos botes
        {
          if (filas[qualFila].EstaVazia)
             qualFila++;
          if (qualFila == 5)  // acabaram as filas
             fim = true;
          else
            if (qualLugarNoBote > 10) // bote encheu
            {
              qualBote++;             // próximo bote
              qualLugarNoBote = 1;    // reinicia no 1o lugar do próximo bote
              if (qualBote > 10) // acabaram os botes
                 fim = true;
            }
            else    // ainda temos pessoas nas filas e botes a encher
              {
                var salvo = filas[qualFila].Retirar();
                lsbSalvos.Items.Add($"Bote {qualBote:00} lugar {qualLugarNoBote:00} " + salvo);
                qualLugarNoBote++;  // mais um lugar foi ocupado nesse bote
              }
          lsbSalvos.SelectedIndex = lsbSalvos.Items.Count - 1; // rola a lista
          Application.DoEvents();   // atualiza a tela
          Thread.Sleep(100);       // espera 100 milissegundos (1/10 segundo)
        }
        MessageBox.Show("Iniciando o obituário naval 8-( ");
        int numeroNaoSalvos = 1;
        for (; qualFila < 5; qualFila++)
          while (!filas[qualFila].EstaVazia)
          {
            var naoSalvo = filas[qualFila].Retirar();
            lsbNaoSalvos.Items.Add(numeroNaoSalvos.ToString()+' '+naoSalvo);
            numeroNaoSalvos++;
            lsbNaoSalvos.SelectedIndex = lsbNaoSalvos.Items.Count - 1; // rola a lista
            Application.DoEvents();
            Thread.Sleep(100);
          }
      }
    }
  }
}
