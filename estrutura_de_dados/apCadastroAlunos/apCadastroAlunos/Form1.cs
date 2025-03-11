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

        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            lista1 = new ListaSimples<Aluno>();
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
    }
}
