using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using _23519_23619_Proj3.Properties;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _23519_23619_Proj3
{
    public partial class Form1 : Form
    {
        VetorDicionario<Dicionario> dicionario;
        bool modoDeInclusão = false;
        bool modoDeEdicao = false;
        bool modoDeJogo = false;
        PictureBox[] partesEnforcado;
        PictureBox[] partesLiberto;
        Dicionario palavraSorteada;
        int erros;
        int pontos = 0;
        int tempolimite;



        public Form1()
        {
            InitializeComponent();
            FazerLeitura(ref dicionario);
            timer.Enabled = false;

            partesEnforcado = new PictureBox[]
            {
            cabecaEnforcado,
            pescocoEnforcado,
            corpoEnforcado,
            mao1Enforcado,
            mao2Enforcado,
            pernaEnforcado,
            pe1Enforcado,
            pe2Enforcado
            };

            partesLiberto = new PictureBox[]
{
            bandeira1Ganhou,
            bandeira2Ganhou,
            cabecaGanhou,
            pescocoGanhou,
            corpoGanhou,
            mao1Ganhou,
            mao2Ganhou,
            pernaGanhou,
            pe1Ganhou,
            pe2Ganhou
};
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
                Dicionario palavraProcurada = new Dicionario(txtPalavra.Text.ToUpper(), txtDica.Text);
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
                Dicionario palavraParaSerExcluida = new Dicionario(txtPalavra.Text.ToUpper(), txtDica.Text);

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
                Dicionario novaPalavra = new Dicionario(txtPalavra.Text.ToUpper(), txtDica.Text);
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
                Dicionario novaPalavra = new Dicionario(txtPalavra.Text.ToUpper(), txtDica.Text);

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
                    Dicionario novaPalavra = new Dicionario(txtPalavra.Text.ToUpper(), txtDica.Text);

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
                    Dicionario palavraParaSerEditada = new Dicionario(txtPalavra.Text.ToUpper(), txtDica.Text);

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

        private void btnIniciarJogo_Click(object sender, EventArgs e)
        {
            labelDica.Text = "Dica: ___________________________________________________________";
            labelErros.Text = "Erros ---";
            labelPontos.Text = "Pontos: ---";
            labelTempo.Text = "Tempo: ---";
            checkBoxDica.Enabled = false;
            RetiraImagens();
            pontos = 0;
            erros = 0;

            if (txtNome.Text != "")
            {
                modoDeJogo = true;

                if (checkBoxDica.Checked)
                {
                    tempolimite = 600;
                    timer.Start();
                }

                Random random = new Random();
                int indiceSorteado = random.Next(dicionario.QtosDados - 1);

                palavraSorteada = dicionario.Dados[indiceSorteado];

                if (checkBoxDica.Checked)
                {
                    labelDica.Text = $"Dica: {palavraSorteada.Dica}";
                }

                dataLetras.DataSource = null;
                dataLetras.Columns.Clear();
                dataLetras.AutoGenerateColumns = false;

                int tamanhoPalavra = palavraSorteada.Palavra.TrimEnd().Length;

                for (int i = 0; i < tamanhoPalavra; i++)
                {
                    dataLetras.Columns.Add(" ", "");
                    dataLetras.Columns[i].Width = 30;
                }

                labelErros.Text = $"Erros: 0";
                labelPontos.Text = $"Pontos: 0";
            }
            else
            {
                StatusLabelForca.Text = "Insira seu nome antes de iniciar um novo jogo";
            }


        }

        private void tabControlForca_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabControlForca.SelectedIndex == 0)
            {
                if (modoDeJogo == true)
                {
                    tabControlForca.SelectedIndex = 1;
                    StatusLabelForca.Text = "Você está jogando. Não é permitido ir para a aba de cadastros.";
                }
            }
        }

        private void CliqueDosBotoes(object sender, EventArgs e)
        {
            if (modoDeJogo == true)
            {

                Button botaoClicado = sender as Button;

                if (palavraSorteada.Tentativa(char.Parse(botaoClicado.Text)))
                {
                    pontos = pontos + 1;
                    labelPontos.Text = $"Pontos: {pontos}";
                    dataLetras.Rows[0].Cells[0].Value = botaoClicado.Text;
                }
                else
                {
                    erros = erros + 1;
                    pontos = pontos - 1;
                    labelPontos.Text = $"Pontos: {pontos}";
                    labelErros.Text = $"Erros: {erros}";

                    for (int i = 0; i <= erros - 1; i++)
                    {
                        partesEnforcado[i].Visible = true;
                    }
                }

                string palavraLimpa = palavraSorteada.Palavra.Trim();
                int tamanhoPalavra = palavraLimpa.Length;

                for (int i = 0; i < tamanhoPalavra; i++)
                {
                    if (palavraSorteada.Acertou[i] == true)
                    {
                        dataLetras.Rows[0].Cells[i].Value = palavraLimpa[i].ToString().ToUpper();
                    }
                    else
                    {
                        dataLetras.Rows[0].Cells[i].Value = " ";
                    }
                }

                if (palavraSorteada.FimDeGame() == true)
                {
                    Ganhou();

                    timer.Stop();
                    modoDeJogo = false;
                }

                if (erros == 8)
                {
                    Perdeu();
                    timer.Stop();
                    modoDeJogo = false;
                }
            }

        }

        public void RetiraImagens()
        {
            for (int i = 0; i < partesEnforcado.Length; i++)
            {
                partesEnforcado[i].Visible = false;
            }

            for (int i = 0; i < partesLiberto.Length; i++)
            {
                partesLiberto[i].Visible = false;
            }

            enforcadoFim.Visible = false;
            enforcadoMorto.Visible = false;
        }

        public void Perdeu()
        {
            for (int i = 0; i < partesEnforcado.Length; i++)
            {
                partesEnforcado[i].Visible = true;
            }

            for (int i = 0; i < partesLiberto.Length; i++)
            {
                partesLiberto[i].Visible = false;
            }
            timer.Stop();
            enforcadoFim.Visible = true;
            enforcadoMorto.Visible = true;
            checkBoxDica.Enabled = true;
            StatusLabelForca.Text = $"Você perdeu. A palavra correta era {palavraSorteada.Palavra.TrimEnd()} Tente novamente.";
        }

        public void Ganhou()
        {
            for (int i = 0; i < partesEnforcado.Length; i++)
            {
                partesEnforcado[i].Visible = false;
            }

            for (int i = 0; i < partesLiberto.Length; i++)
            {
                partesLiberto[i].Visible = true;
            }
            timer.Stop();
            StatusLabelForca.Text = "Você ganhou! Parabéns!";
            checkBoxDica.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tempolimite--;

            labelTempo.Text = $"Tempo: {tempolimite.ToString()}";

            if (tempolimite <= 0)
            {
                timer.Stop();

                erros = partesEnforcado.Length;
                labelErros.Text = $"Erros: {erros}";


                for (int i = 0; i < partesEnforcado.Length; i++)
                {
                    partesEnforcado[i].Visible = true;
                }

                enforcadoFim.Visible = true;
                enforcadoMorto.Visible = true;

                modoDeJogo = false;

                string palavraLimpa = palavraSorteada.Palavra.TrimEnd();
                int tamanhoPalavra = palavraLimpa.Length;
                for (int i = 0; i < tamanhoPalavra; i++)
                {
                    dataLetras.Rows[0].Cells[i].Value = palavraLimpa[i].ToString().ToUpper();
                }

                StatusLabelForca.Text = $"Tempo esgotado. A palavra correta era {palavraLimpa}";
            }
        }
    }
}
