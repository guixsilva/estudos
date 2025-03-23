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

namespace apCadastroAlunos
{
    public partial class FrmCadastro : Form
    {

        ListaSimples<Aluno> lista1;

        ListaSimples<int> lista2;

        ListaSimples<int> lista3;

        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            lista1 = new ListaSimples<Aluno>();
            lista2 = new ListaSimples<int>();
            lista3 = new ListaSimples<int>();
            lista2.InserirAposFim(1);
            lista2.InserirAposFim(2);
            lista2.InserirAposFim(3);
            lista2.InserirAposFim(4);
            lista2.InserirAposFim(5);
            lista2.InserirAposFim(6);
            lista2.InserirAposFim(7);
            lista2.InserirAposFim(8);
            lista2.InserirAposFim(9);
            lista2.InserirAposFim(10);
            lista2.Listar(lsb2);
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
                qualLista.Listar(qualListBox);
                arquivo.Close();
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
            NoLista<Aluno> alunoencontrado = null;
            var atual = lista1.Primeiro;

            if(dlgAbrir.FileName != "")
            {
            if(txtRA.Text != null)
            {
                while (atual != null)
                {
                    if(atual.Info.Ra == txtRA.Text)
                    {
                        alunoencontrado = atual;
                        break;
                    }

                    atual = atual.Prox;
                }

                if(alunoencontrado != null)
                {
                    MessageBox.Show("Encontrado");
                }
            }
            }
            else
            {
                MessageBox.Show("Primeiro, escaneie um arquivo .txt");
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

        }

        private void FazerLeitura2(ref ListaSimples<int> novaLista, ListBox qualListBox)
        {
            novaLista = new ListaSimples<int>();
            if (dlgAbrir2.ShowDialog() == DialogResult.OK)
            {
                StreamReader arquivo2 = new StreamReader(dlgAbrir2.FileName);
                while (!arquivo2.EndOfStream)
                {
                    string linha = arquivo2.ReadLine();
                    if (int.TryParse(linha, out int valor))
                    {
                        novaLista.InserirAposFim(valor);
                    }
                }
                novaLista.Listar(qualListBox);
                arquivo2.Close();
            }
        }

        private void btnArquivo2_Click(object sender, EventArgs e)
        {
            FazerLeitura2(ref lista3, lsb3);
        }

        private ListaSimples<int> JuntarListas(ListaSimples<int> param1, ListaSimples<int> param2)
        {
            NoLista<int> atual1 = param1.Primeiro;
            NoLista<int> atual2 = param2.Primeiro;
            ListaSimples<int> listaConcatenada = new  ListaSimples<int>();

            while (atual1 != null)
            {
                if (listaConcatenada.Buscar(atual1.Info) == false)
                {
                    listaConcatenada.InserirAposFim(atual1.Info);
                }
                atual1 = atual1.Prox;
            }

            while (atual2 != null)
            {
                if (listaConcatenada.Buscar(atual2.Info) == false)
                {
                    listaConcatenada.InserirAposFim(atual2.Info);
                }
                atual2 = atual2.Prox;
            }

            return listaConcatenada;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            ListaSimples<int> listaJuntada = JuntarListas(lista2, lista3);
            lsb3.Items.Clear();
            listaJuntada.Listar(lsb3);
        }
    }
}
