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
        PictureBox[] partesBonecoEnforcado;
        PictureBox[] partesBonecoLiberto;
        Dicionario palavraSorteada;
        int erros;
        int pontos = 0;
        int tempolimite;



        public Form1()
        {
            InitializeComponent();
            FazerLeitura(ref dicionario);
            timer.Enabled = false; // timer desatualizado quando o formulário for lançado

            partesBonecoEnforcado = new PictureBox[] // vetor de imagens com as partes do boneco quando o usuário erra.
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

            partesBonecoLiberto = new PictureBox[] // vetor de imagens com as partes do boneco quando o usuário acerta.
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

        //
        //
        // TELA DE CRUD
        //
        //

        private void FazerLeitura(ref VetorDicionario<Dicionario> qualLista) // faz leitura do arquivo
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

        private void ExibirDados(VetorDicionario<Dicionario> dicionario, DataGridView data)  // exibe os dados da lista ligada dicionaário
        {
            data.DataSource = null; // limpa datagridview
            List<Dicionario> listaDicionario = dicionario.Listagem(); 

            data.AutoGenerateColumns = false;
            if (!data.Columns.Contains("palavra")) // cria colunas da tabela
            {
                data.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Palavra", HeaderText = "Palavra", Name = "palavra" });
                data.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Dica", HeaderText = "Dica", Name = "dica" });
            }

            data.DataSource = listaDicionario; // insere as linhas da tabela
        }


        //
        //
        // EVENTOS DOS BOTÕES CRUD DA TELA DE CADASTROS
        //
        //

        private void btnBuscar_Click(object sender, EventArgs e) // evento click de Buscar
        {
            if (txtPalavra.Text != null)
            {
                Dicionario palavraProcurada = new Dicionario(txtPalavra.Text.ToUpper(), txtDica.Text); // cria objeto de Dicionario com a palavra a ser buscada
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


        //CRIAÇÃO DE NOVAS PALAVRAS 

        //PARTE 1
        private void btnNovo_Click(object sender, EventArgs e) // evento click para cadastrar novas palavras
        {
            txtPalavra.Clear();
            txtDica.Clear();

            modoDeInclusão = true; // modo de inclusão iniciado.
            statusText.Text = $"Modo de criação de novas palavras."; // Informa que o modo de criação foi iniciado.

            txtPalavra.Focus(); // o campo de Pálavra é focado.
        }

        //PARTE 2
        private void txtPalavra_Leave(object sender, EventArgs e) // evento leave de criação de palavras.
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

        //PARTE 3
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

        private void btnEditar_Click(object sender, EventArgs e) // evento click para editar palavras
        {
            modoDeEdicao = true; // modo de edição iniciado
            txtPalavra.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e) // evento click de exclusão
        {
            if (txtPalavra.Text != null)
            {
                Dicionario palavraParaSerExcluida = new Dicionario(txtPalavra.Text.ToUpper(), txtDica.Text); // cria objeto de Dicionario com a palavra a ser excluida

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

        private void btnSalvar_Click(object sender, EventArgs e) // evento click de salvar (ele pode criar registros e edita-los)
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

        //
        //
        // EVENTO CLICK DOS BOTÕES DE NAVEGAÇÃO DOS DADOS DO DICIONÁRIO - EXIBIR O DADO NA TELA
        //
        //

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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExibirRegistroAtual() // exibe os dados do registro (ponteiro) atual nos componentes do formulário.
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) // SALVA OS DADOS NO ARQUIVO TXT
        {
            dicionario.GravarDados(dlgAbrir.FileName);
        }



        //
        //
        // TELA DO JOGO DA FORCA
        //
        //


        //
        //
        // EVENTOS CLICK DA TELA DO JOGO DA FORCA
        //
        //

        private void btnIniciarJogo_Click(object sender, EventArgs e) // Evento click para iniciar o jogo
        {
            labelDica.Text = "Dica: ___________________________________________________________";
            btnIniciarJogo.Enabled = false;
            labelErros.Text = "Erros ---";
            labelPontos.Text = "Pontos: ---";
            labelTempo.Text = "Tempo: ---";
            checkBoxDica.Enabled = false;
            RetiraImagens();
            pontos = 0;
            erros = 0;

            if (txtNome.Text != "")
            {
                modoDeJogo = true; // inicia modo de jogo (impossibilita acessar a aba de cadastros)

                if (checkBoxDica.Checked) // verifica se checkbox de dica está marcado. Se sim, inicia temporizador
                {
                    tempolimite = 600;
                    timer.Start();
                }

                Random random = new Random(); // sorteia índice da palavra
                int indiceSorteado = random.Next(dicionario.QtosDados - 1);

                palavraSorteada = dicionario.Dados[indiceSorteado]; // palavra sorteada

                if (checkBoxDica.Checked) // preenche com a dica
                {
                    labelDica.Text = $"Dica: {palavraSorteada.Dica}";
                }

                dataLetras.DataSource = null;
                dataLetras.Columns.Clear();
                dataLetras.AutoGenerateColumns = false;

                int tamanhoPalavra = palavraSorteada.Palavra.TrimEnd().Length; // vetor dividido da palavra sorteada (ex: G, U, I, L, H, E, R, ME)

                for (int i = 0; i < tamanhoPalavra; i++) // inicia datagridview vazio com o número de letras da palavra sorteada
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

        private void tabControlForca_Selecting(object sender, TabControlCancelEventArgs e) // evento selecting na aba de cadastros:
                                                                                           // impossibilita com que o usuário inicie um jogo e veja o dicionário
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


        //
        //
        // FUNÇÕES DE FUNCIONAMENTO DO JOGO DA FORCA
        //
        //

        private void CliqueDosBotoes(object sender, EventArgs e) // evento de click nos botões alfabéticos
        {
            if (modoDeJogo == true) // se o modo de jogo estiver ativo
            {

                Button botaoClicado = sender as Button; // cria componente com o botão clicado

                if (palavraSorteada.Tentativa(char.Parse(botaoClicado.Text))) // envia uma tentativa 
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

                    for (int i = 0; i <= erros - 1; i++) // para cada erro, mostra uma imagem do boneco
                    {
                        partesBonecoEnforcado[i].Visible = true;
                    }
                }

                string palavraLimpa = palavraSorteada.Palavra.Trim();
                int tamanhoPalavra = palavraLimpa.Length;

                for (int i = 0; i < tamanhoPalavra; i++) // preenche o datagridview com as letras acertadas pelo usuário
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

                if (palavraSorteada.FimDeGame() == true) // o jogo terminou? Palavra correta? Se sim, jogador ganha o jogo
                {
                    Ganhou();

                    timer.Stop();
                    modoDeJogo = false; // sai do modo de jogo
                }

                if (erros == 8) // 8 erros? jogador perde.
                {
                    Perdeu();
                    timer.Stop();
                    modoDeJogo = false; // sai do modo de jogo
                }
            }

        }

        private void timer_Tick(object sender, EventArgs e) // evento tick (temporizador) do cronômetro
        {
            tempolimite--; // relógio anda para trás.

            labelTempo.Text = $"Tempo: {tempolimite.ToString()}";

            if (tempolimite <= 0) // fim de jogo, jogador perde por tempo esgotado
            {
                timer.Stop();

                erros = partesBonecoEnforcado.Length;
                labelErros.Text = $"Erros: {erros}";


                for (int i = 0; i < partesBonecoEnforcado.Length; i++)
                {
                    partesBonecoEnforcado[i].Visible = true;
                }

                enforcadoFim.Visible = true;
                enforcadoMorto.Visible = true;

                modoDeJogo = false;

                string palavraLimpa = palavraSorteada.Palavra.TrimEnd();
                int tamanhoPalavra = palavraLimpa.Length;
                for (int i = 0; i < tamanhoPalavra; i++) // revela a palavra sorteada/ da forca
                {
                    dataLetras.Rows[0].Cells[i].Value = palavraLimpa[i].ToString().ToUpper();
                }

                StatusLabelForca.Text = $"Tempo esgotado. A palavra correta era {palavraLimpa}";
                btnIniciarJogo.Enabled = true;
            }
        }

        public void Perdeu() // Função dederrota
        {
            for (int i = 0; i < partesBonecoEnforcado.Length; i++) // exibe todas as imagens do boneco MORTO, além do gif do fantasma
            {
                partesBonecoEnforcado[i].Visible = true;
            }

            for (int i = 0; i < partesBonecoLiberto.Length; i++) // retira todas as imagens do boneco vivo (se houver).
            {
                partesBonecoLiberto[i].Visible = false;
            }
            timer.Stop();
            enforcadoFim.Visible = true;
            enforcadoMorto.Visible = true;
            checkBoxDica.Enabled = true;
            StatusLabelForca.Text = $"Você perdeu. A palavra correta era {palavraSorteada.Palavra.TrimEnd()} Tente novamente.";
            btnIniciarJogo.Enabled = true;
        }

        public void Ganhou() // função Vitória
        {
            for (int i = 0; i < partesBonecoEnforcado.Length; i++)  // retira todas as imagens do boneco MORTO, além do gif do fantasma
            {
                partesBonecoEnforcado[i].Visible = false;
            }

            for (int i = 0; i < partesBonecoLiberto.Length; i++) // exibe todas as imagens do boneco VIVO, além das bandeiras do Brasil
            {
                partesBonecoLiberto[i].Visible = true;
            }
            timer.Stop();
            StatusLabelForca.Text = "Você ganhou! Parabéns!";
            checkBoxDica.Enabled = true;
            btnIniciarJogo.Enabled = true;
        }

        public void RetiraImagens() // função que retira todas as imagens. Usada no começo do jogo de forca.
        {
            for (int i = 0; i < partesBonecoEnforcado.Length; i++)
            {
                partesBonecoEnforcado[i].Visible = false;
            }

            for (int i = 0; i < partesBonecoLiberto.Length; i++)
            {
                partesBonecoLiberto[i].Visible = false;
            }

            enforcadoFim.Visible = false;
            enforcadoMorto.Visible = false;
        }

    }
}
