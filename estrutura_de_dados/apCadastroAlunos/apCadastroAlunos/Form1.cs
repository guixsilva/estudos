using System;
using System.IO;
using System.Windows.Forms;

namespace apCadastroAlunos
{
    public partial class FrmCadastro : Form
    {

        ListaSimples<Aluno> lista1;

        ListaSimples<Aluno> lista2;

        ListaSimples<Aluno> lista3;

        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            lista1 = new ListaSimples<Aluno>();
            lista2 = new ListaSimples<Aluno>();
            lista3 = new ListaSimples<Aluno>();
        }

        private void btnArquivo1_Click(object sender, EventArgs e)
        {
            FazerLeitura(ref lista1,lsb1);

        }

        private void FazerLeitura(ref ListaSimples<Aluno> qualLista, ListBox qualListBox)
        {
            qualLista = new ListaSimples<Aluno>(); // recria a lista a ser lida
            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                StreamReader arquivo = new StreamReader(dlgAbrir.FileName);
                string linha = "";
                while (!arquivo.EndOfStream)
                {
                    linha = arquivo.ReadLine();
                    qualLista.InserirAposFim(new Aluno(linha));
                }
                qualLista.Ordenar();
                qualLista.ExibirNaTela();
                qualLista.Listar(qualListBox);
                arquivo.Close();
                qualLista.GravarEmArquivo(dlgAbrir.FileName);
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            string linha = $"{txtRA.Text.PadLeft(5, '0')}{txtNome.Text.PadRight(30, ' ')}{txtNota.Text.PadLeft(4, '0')}";
            Aluno novoAluno = new Aluno(linha);
            lista1.InserirAposFim(novoAluno);

            txtRA.Text = "";
            txtNome.Text = "";
            txtNota.Text = "";

            IncluiNoArquivo(novoAluno, lsb1);
            lista1.Listar(lsb1);

        }

        private void IncluiNoArquivo(Aluno aluno, ListBox qualListBox)
        {
            if (dlgAbrir.FileName != "")
            {
                try
                {
                    using(StreamWriter writer = new StreamWriter(dlgAbrir.FileName, append: true))
                    {
                        writer.WriteLine(
                            aluno.ToString()
                        );
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " +  ex.Message );
                }
                    
            }
            else
            {
                MessageBox.Show("Primeiro, escaneie um arquivo .txt");
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
               Aluno aluno = new Aluno(txtRA.Text);
               Boolean retorno = lista1.Buscar(aluno);
                if (retorno)
                {
                MessageBox.Show("Encontrado");
                } 
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            if (dlgAbrir.FileName != "")
            {
                int numerodenos = lista1.ContarNos();
                labelNos.Text = $"Qntd Nós: {numerodenos.ToString()}";
            }
            else
            {
                MessageBox.Show("Primeiro, escaneie um arquivo .txt");
            }
        }

        private void Inverter_Click(object sender, EventArgs e)
        {
            if (dlgAbrir.FileName != "")
            {
                lista1.Inverter();
                lista1.Listar(lsb4);
            }
            else
            {
                MessageBox.Show("Primeiro, escaneie um arquivo .txt");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            lista1.Listar(lsb1);
            ListaSimples<Aluno> pares=null, impares = null;
            lista1.SepararListas(ref pares, ref impares);
            pares.Listar(lsb2);
            impares.Listar(lsb3);
        }

        private void btnArquivo2_Click(object sender, EventArgs e)
        {
            FazerLeitura(ref lista2, lsb2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var lista3 = lista1.Juntar(lista2);
            lista3.Listar(lsb3);
        }
    }
}
