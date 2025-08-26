using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

// GUILHERME DA SILVA PEREIRA - 23519
// MARIA EDUARDA CARVALHO PAES - 23619

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
                qualLista = new ListaDupla<DicionarioForca>(); // cria uma referência da lista do parâmetro
                var arquivo = new StreamReader(dlgAbrir.FileName); // instancia o arquivo
                while (!arquivo.EndOfStream) // enquanto o arquivo não terminar
                {
                    var linhaLida = arquivo.ReadLine();  // pega a linha do arquivo
                    string[] palavrasLidas = linhaLida.Split(' '); // separa a linha em um vetor de strings.
                    var novaForca = new DicionarioForca(linhaLida); // cria um objeto de dicionário com a linha lida
                    qualLista.InserirAposFim(novaForca); // insere a linha dentro da lista
                }
                arquivo.Close(); //fecha arquivo
            }
        }

    private void btnIncluir_Click(object sender, EventArgs e)
    {

        if(txtPalavra.Text !=null  &&  txtPalavra.Text != null) // se os campos não estejam vazios...
            {
                DicionarioForca novaPalavra = new DicionarioForca(txtPalavra.Text, txtDica.Text); // cria um objeto para a nova palavra

                try // tenta inserir dentro da lista já criada
                {
                    lista1.InserirEmOrdem(novaPalavra); // esse método já verifica se a palavra já foi criada anteriormente
                    slRegistro.Text = $"Registro {lista1.QuantosNos}/{lista1.QuantosNos} - Novo item cadastrado";
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro ao incluir essa palavra na lista.");
                }
            }
    }


    private void btnBuscar_Click(object sender, EventArgs e)
    {
        if(txtPalavra.Text != null) // se o campo "palavra" não estiver vazio
            {
                DicionarioForca palavraProcurada = new DicionarioForca(txtPalavra.Text, txtDica.Text); // cria objeto para a palavra procurada.
                if (lista1.Existe(palavraProcurada)) // esse método foi alterado para mudar o número da variável NumeroDoNoAtual se achar
                {
                    ExibirRegistroAtual(); // exibe os dados do nó NumeroDoNoAtual dentro do programa
                }
                else
                {
                    MessageBox.Show("Essa palavra não foi encontrada na lista.");
                }
            }      
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
            if (txtPalavra.Text != null) // se o campo "palavra" não estiver vazio
            {
                DicionarioForca palavraParaSerExcluida = new DicionarioForca(txtPalavra.Text, txtDica.Text); // cria objeto para a palavra a ser excluida.

                try
                {
                    DialogResult result = MessageBox.Show("Deseja confirmar a ação?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    // cria uma caixa de diálogo para confirmar a ação.
                    if (result == DialogResult.Yes) // se o usuário responder "sim", ele remove a palavra e limpa os campos.
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
    }

    private void FrmAlunos_FormClosing(object sender, FormClosingEventArgs e)
    {
            if (dlgSalvar.ShowDialog() == DialogResult.OK) // solicita ao usuário para escolher um novo arquivo
            {
                lista1.GravarDados(dlgSalvar.FileName); // grava a lista no novo arquivo
            }
        }

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
            lista1.PosicionarNoInicio(); // método posiciona no início: basicamente puxa a variável "primeiro" e coloca o NumeroDoNoAtual em 1
            ExibirRegistroAtual();// exibe na tela
        }

    private void btnAnterior_Click(object sender, EventArgs e)
    {
            lista1.Retroceder(); // // método pega o próximo do atual: aumenta em 1 a variável NumeroDoNoAtual
            ExibirRegistroAtual(); // exibe na tela
    }

    private void btnProximo_Click(object sender, EventArgs e)
    {
            lista1.Avancar(); // método pega o anterior do atual: diminiu em 1 a variável NumeroDoNoAtual
            ExibirRegistroAtual(); // exibe na tela
        }

    private void btnFim_Click(object sender, EventArgs e)
    {
            lista1.PosicionarNoFinal(); // método posiciona no início: basicamente puxa a variável "primeiro" e coloca o NumeroDoNoAtual em 1
            ExibirRegistroAtual(); // exibe na tela
        }

    private void ExibirRegistroAtual()
    {
            NoDuplo<DicionarioForca> noatual = lista1.Atual; // cria um nó com o atual da lista
            if (lista1.EstaVazia) // se alista está vazia, ignorar
            {
                MessageBox.Show("Lista Vazia.");
            }
            else // exibe os dados do nó atual
            {
                txtPalavra.Text = lista1.Atual.Info.Palavra;
                txtDica.Text = lista1.Atual.Info.Dica;
                slRegistro.Text = $"Registro {lista1.NumeroDoNoAtual}/{lista1.QuantosNos}";
            }
        }

    private void btnEditar_Click(object sender, EventArgs e) 
    {
            if (txtPalavra.Text != null && txtDica.Text != null) // se os campos não estão vazios
            {
                DicionarioForca palavraParaSerEditada = new DicionarioForca(txtPalavra.Text, txtDica.Text); // cria uma nova palavra com os dados editados

                try 
                {
                    lista1.Editar(palavraParaSerEditada); // método encontra o nó (só edita a dica) e edita o nó
                    txtPalavra.Clear();
                    txtDica.Clear();
                    slRegistro.Text = $"Registro editado";

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
