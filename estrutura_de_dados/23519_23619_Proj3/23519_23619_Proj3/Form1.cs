using System.Collections.Generic;

namespace _23519_23619_Proj3
{
    public partial class Form1 : Form
    {
        VetorDicionario<Dicionario> dicionario;
        bool modoDeInclusão = false;
        bool modoDeEdicao = false;
        public Form1()
        {
            InitializeComponent();
            FazerLeitura(ref dicionario);
        }

        private void FazerLeitura(ref VetorDicionario<Dicionario> qualLista)
        {
            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                qualLista = new VetorDicionario<Dicionario>();
                var arquivo = new StreamReader(dlgAbrir.FileName);
                while (!arquivo.EndOfStream)
                {
                    var linhaLida = arquivo.ReadLine();
                    var novaForca = new Dicionario(linhaLida);
                    qualLista.InserirNovaPalavra(novaForca);
                }
                arquivo.Close();
            }

            ExibirDados(dicionario, dataDicionario);
            statusText.Text = $"Foram encontrados {dicionario.QtosDados} registros";
        }

        private void ExibirDados(VetorDicionario<Dicionario> dicionario, DataGridView data)
        {
            data.DataSource = null;
            List<Dicionario> lista = dicionario.Listagem();

            data.AutoGenerateColumns = false;
            if (!data.Columns.Contains("palavra"))
            {
                data.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Palavra", HeaderText = "Palavra", Name = "palavra" });
                data.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Dica", HeaderText = "Dica", Name = "dica" });
            }

            data.DataSource = lista;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtPalavra.Text != null)
            {
                Dicionario palavraProcurada = new Dicionario(txtPalavra.Text, txtDica.Text);
                if (dicionario.Existe(palavraProcurada))
                {
                    ExibirRegistroAtual();
                }
                else
                {
                    MessageBox.Show("Essa palavra não foi encontrada na lista.");
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            statusText.Text = $"Modo de criação de novas palavras.";

            txtPalavra.Clear();
            txtDica.Clear();

            modoDeInclusão = true;

            txtPalavra.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            modoDeEdicao = true;
            txtPalavra.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtPalavra.Text != null)
            {
                Dicionario palavraParaSerExcluida = new Dicionario(txtPalavra.Text, txtDica.Text);

                try
                {
                    DialogResult result = MessageBox.Show("Deseja confirmar a ação?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    // cria uma caixa de diálogo para confirmar a ação.
                    if (result == DialogResult.Yes) // se o usuário responder "sim", ele remove a palavra e limpa os campos.
                    {
                        dicionario.ExcluirPalavra(palavraParaSerExcluida);
                        txtPalavra.Clear();
                        txtDica.Clear();
                        ExibirDados(dicionario, dataDicionario);
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExibirRegistroAtual()
        {
            int posicaoAtual = dicionario.PosicaoAtual;
            if (dicionario.EstaVazia)
            {
                MessageBox.Show("Lista Vazia.");
            }
            else
            {
                txtPalavra.Text = dicionario.Dados[posicaoAtual].Palavra;
                txtDica.Text = dicionario.Dados[posicaoAtual].Dica;
                statusText.Text = $"Registro {posicaoAtual + 1}/{dicionario.QtosDados}";
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            dicionario.PosicionarNoInicio();
            ExibirRegistroAtual();// exibe na tela
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            dicionario.Retroceder();
            ExibirRegistroAtual();// exibe na tela
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            dicionario.Avancar();
            ExibirRegistroAtual();// exibe na tela
        }

        private void btnFim_Click(object sender, EventArgs e)
        {
            dicionario.PosicionarNoFinal();
            ExibirRegistroAtual();// exibe na tela
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dicionario.GravarDados(dlgAbrir.FileName);
        }

        private void txtPalavra_Leave(object sender, EventArgs e)
        {
            if (txtPalavra.Text == null)
            {
                statusText.Text = "Não é aceito palavras vazias.";
            }
            else
            {
                Dicionario novaPalavra = new Dicionario(txtPalavra.Text, txtDica.Text);
                if (dicionario.Existe(novaPalavra))
                {
                    statusText.Text = "Elemento repetido. Modo de inclusão interrompido.";
                    txtPalavra.Clear();
                    txtDica.Clear();
                    modoDeInclusão = false;
                }
            }
        }

        private void txtDica_Leave(object sender, EventArgs e)
        {
            if (txtDica.Text != null && modoDeInclusão == true)
            {
                Dicionario novaPalavra = new Dicionario(txtPalavra.Text, txtDica.Text);

                try
                {
                    dicionario.InserirNovaPalavra(novaPalavra);
                    ExibirDados(dicionario, dataDicionario);
                    modoDeInclusão = false;
                    statusText.Text = "Palavra cadastrada.";
                }
                catch
                {
                    statusText.Text = "Não é aceito palavras vazias.";
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (modoDeInclusão == true)
            {
                if (txtDica.Text != null && txtDica.Text != null)
                {
                    Dicionario novaPalavra = new Dicionario(txtPalavra.Text, txtDica.Text);

                    try
                    {
                        dicionario.InserirNovaPalavra(novaPalavra);
                        ExibirDados(dicionario, dataDicionario);
                        modoDeInclusão = false;
                        statusText.Text = "Palavra cadastrada. Saiu do modo de Inclusão.";
                    }
                    catch
                    {
                        statusText.Text = "Não é aceito palavras vazias.";
                    }
                }
            }
            if (modoDeEdicao == true)
            {
                if (txtPalavra.Text != null && txtDica.Text != null) 
                {
                    Dicionario palavraParaSerEditada = new Dicionario(txtPalavra.Text, txtDica.Text);

                    try
                    {
                        dicionario.EditarPalavra(palavraParaSerEditada); 
                        ExibirDados(dicionario, dataDicionario);
                        modoDeEdicao = false;
                        statusText.Text = $"Registro editado. Saiu do modo de Edição.";
                    }
                    catch
                    {
                        MessageBox.Show("Essa palavra não foi encontrada na lista.");
                    }
                }
            }
        }
    }
}
