using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace apListaLigada
{
  public partial class FrmAlunos : Form
  {
    ListaDupla<DicionarioForca> lista1;
    public FrmAlunos()
    {
      InitializeComponent();
      FazerLeitura(ref lista1);
      lista1.PosicionarNoInicio();
      ExibirRegistroAtual();
        }

    private void btnLerArquivo1_Click(object sender, EventArgs e)
    {
            FazerLeitura(ref lista1);
    }

    private void FazerLeitura(ref ListaDupla<DicionarioForca> qualLista)
    {
         if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                qualLista = new ListaDupla<DicionarioForca>();
                var arquivo = new StreamReader(dlgAbrir.FileName);
                while (!arquivo.EndOfStream)
                {
                    var linhaLida = arquivo.ReadLine();
                    string[] palavrasLidas = linhaLida.Split(' ');
                    var novaForca = new DicionarioForca(linhaLida);
                    qualLista.InserirAposFim(novaForca);
                }
                arquivo.Close();
            }
            // instanciar a lista de palavras e dicas
            // pedir ao usuário o nome do arquivo de entrada
            // abrir esse arquivo e lê-lo linha a linha
            // para cada linha, criar um objeto da classe de Palavra e Dica
            // e inseri-0lo no final da lista duplamente ligada
        }

    private void btnIncluir_Click(object sender, EventArgs e)
    {

        if(txtPalavra.Text !=null  &&  txtPalavra.Text != null)
            {
                DicionarioForca novaPalavra = new DicionarioForca(txtPalavra.Text, txtDica.Text);

                try
                {
                    lista1.InserirEmOrdem(novaPalavra);
                    slRegistro.Text = $"Registro {lista1.QuantosNos}/{lista1.QuantosNos} - Novo item cadastrado";
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro ao incluir essa palavra na lista.");
                }
            }
      // se o usuário digitou palavra e dica:
      // criar objeto da classe Palavra e Dica para busca
      // tentar incluir em ordem esse objeto na lista1
      // se não incluiu (já existe) avisar o usuário
    }


    private void btnBuscar_Click(object sender, EventArgs e)
    {
        if(txtPalavra.Text != null)
            {
                DicionarioForca palavraProcurada = new DicionarioForca(txtPalavra.Text, txtDica.Text);
                if (lista1.Existe(palavraProcurada))
                {
                    ExibirRegistroAtual();
                }
                else
                {
                    MessageBox.Show("Essa palavra não foi encontrada na lista.");
                }
            }      

        
        // se a palavra digitada não é vazia:
      // criar um objeto da classe de Palavra e Dica para busca
      // se a palavra existe na lista1, posicionar o ponteiro atual nesse nó e exibir o registro atual
      // senão, avisar usuário que a palavra não existe
      // exibir o nó atual
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
            if (txtPalavra.Text != null)
            {
                DicionarioForca palavraParaSerExcluida = new DicionarioForca(txtPalavra.Text, txtDica.Text);

                try
                {
                    DialogResult result = MessageBox.Show("Deseja confirmar a ação?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        lista1.Remover(palavraParaSerExcluida);
                        txtPalavra.Clear();
                        txtDica.Clear();
                        slRegistro.Text = $"Registro excluído.";
                    }
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("Ação cancelada");
                    }
                }
                catch
                {
                    MessageBox.Show("Essa palavra não foi encontrada na lista.");
                }
            }
                
      // para o nó atualmente visitado e exibido na tela:
      // perguntar ao usuário se realmente deseja excluir essa palavra e dica
      // se sim, remover o nó atual da lista duplamente ligada e exibir o próximo nó
      // se não, manter como está
    }

    private void FrmAlunos_FormClosing(object sender, FormClosingEventArgs e)
    {
            if (dlgSalvar.ShowDialog() == DialogResult.OK)
            {
                lista1.GravarDados(dlgSalvar.FileName);
            }
        }
      // solicitar ao usuário que escolha o arquivo de saída
      // percorrer a lista ligada e gravar seus dados no arquivo de saída

    private void ExibirDados(ListaDupla<DicionarioForca> aLista, ListBox lsb, Direcao qualDirecao)
    {
      lsb.Items.Clear();
      var dadosDaLista = aLista.Listagem(qualDirecao);
      foreach (DicionarioForca palavra in dadosDaLista)
        lsb.Items.Add(palavra);
    }

    private void tabControl1_Enter(object sender, EventArgs e)
    {
      rbFrente.PerformClick();
    }

    private void rbFrente_Click(object sender, EventArgs e)
    {
      ExibirDados(lista1, lsbDados, Direcao.paraFrente);
    }

    private void rbTras_Click(object sender, EventArgs e)
    {
      ExibirDados(lista1, lsbDados, Direcao.paraTras);
    }

    private void btnInicio_Click(object sender, EventArgs e)
    {
            lista1.PosicionarNoInicio();
            ExibirRegistroAtual();
    }

    private void btnAnterior_Click(object sender, EventArgs e)
    {
            lista1.Retroceder();
            ExibirRegistroAtual();
    }

    private void btnProximo_Click(object sender, EventArgs e)
    {
            lista1.Avancar();
            ExibirRegistroAtual();
        }

    private void btnFim_Click(object sender, EventArgs e)
    {
            lista1.PosicionarNoFinal();
            ExibirRegistroAtual();
        }

    private void ExibirRegistroAtual()
    {
            NoDuplo<DicionarioForca> noatual = lista1.Atual;
            if (lista1.EstaVazia)
            {
                MessageBox.Show("Lista Vazia.");
            }
            else
            {
                txtPalavra.Text = lista1.Atual.Info.Palavra;
                txtDica.Text = lista1.Atual.Info.Dica;
                slRegistro.Text = $"Registro {lista1.NumeroDoNoAtual}/{lista1.QuantosNos}";
            }

            // se a lista não está vazia:
            // acessar o nó atual e exibir seus campos em txtDica e txtPalavra
            // atualizar no status bar o número do registro atual / quantos nós na lista
        }

    private void btnEditar_Click(object sender, EventArgs e)
    {
            if (txtPalavra.Text != null && txtDica.Text != null)
            {
                DicionarioForca palavraParaSerEditada = new DicionarioForca(txtPalavra.Text, txtDica.Text);

                try
                {
                    lista1.Editar(palavraParaSerEditada);
                    txtPalavra.Clear();
                    txtDica.Clear();
                    slRegistro.Text = $"Registro excluído.";

                }
                catch
                {
                    MessageBox.Show("Essa palavra não foi encontrada na lista.");
                }
            }
    }

    private void btnSair_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {

    }
  }
}
