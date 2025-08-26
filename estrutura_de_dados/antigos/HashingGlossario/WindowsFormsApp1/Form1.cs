using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Hashtable glossario = new Hashtable();
        public Form1()
        {
            InitializeComponent();
        }
        private void ConstruirGlossario(Hashtable tabela, string nomeArquivo)
        {
            StreamReader arq = new StreamReader(nomeArquivo,
            System.Text.Encoding.UTF7);
            string[] cadeiasLidas;
            char[] delimitador = new char[] { ',' };
            while (!arq.EndOfStream)
            {
                string linha = arq.ReadLine();
                cadeiasLidas = linha.Split(delimitador);
                tabela.Add(cadeiasLidas[0], cadeiasLidas[1]);
            }
            arq.Close();
        }
        private void buttonLerArquivo_Click(object sender, EventArgs e)
        {
            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                ConstruirGlossario(glossario, dlgAbrir.FileName);
                listBoxPalavras.Enabled = true;
                ExibirPalavras(glossario, listBoxPalavras);
            }
        }
        private void ExibirPalavras(Hashtable tabela, ListBox lista)
        {
            Object[] palavras = new Object[1000];
            tabela.Keys.CopyTo(palavras, 0);
            for (int i = 0; i < palavras.Length; i++)
                if (palavras[i] != null)
                    lista.Items.Add(palavras[i]);
        }
        private void listBoxPalavras_Click(object sender, EventArgs e)
        {
            Object palavra = listBoxPalavras.SelectedItem;
            listBoxDefinicoes.Text = glossario[palavra].ToString();
        }
    }
}
