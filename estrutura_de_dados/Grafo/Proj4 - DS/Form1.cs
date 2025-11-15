using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AgendaAlfabetica;

namespace Proj4
{
  public partial class Form1 : Form
  {
    Arvore<Cidade>  arvore = new Arvore<Cidade>();
    public Form1()
    {
      InitializeComponent();
    }


    private void Form1_Load(object sender, EventArgs e)
    {

            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                arvore.LerArquivoDeRegistros(dlgAbrir.FileName);
                arvore.Desenhar(pnlArvore);
            }

            LerLigacoes(arvore);
        }

        private void LerLigacoes(Arvore<Cidade> cidades)
        {
            if (dlgAbrir.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Você não selecionou o arquivo corretamete.","",MessageBoxButtons.OK,MessageBoxIcon.Error); 
                return;
            }
            else
            {

                var arquivo = new StreamReader(dlgAbrir.FileName);
                LerLigacoes(cidades, arquivo);
            }


        }


        private void LerLigacoes(Arvore<Cidade> cidades, StreamReader arquivo)
        {
            if (arquivo.EndOfStream)
            {
                return;
            }
            else
            {
                var linhalida = arquivo.ReadLine();
                var partesDivididas = linhalida.Split(';');
                string origem = partesDivididas[0];
                string destino = partesDivididas[1];
                int distancia = int.Parse(partesDivididas[2]);

                Ligacao novaLigacao = new Ligacao(origem, destino, distancia);
                Cidade cidOrigem = new Cidade(origem);

                if (cidades.Existe(cidOrigem))
                {
                    Cidade cidade = cidades.Atual.Info;
                    cidade.InsereLigacao(novaLigacao);

                }
            }

            LerLigacoes(cidades, arquivo);
        }


        // EVENTOS DO FORMULÁRIO

        private void pnlArvore_Paint(object sender, PaintEventArgs e)
        {
            arvore.Desenhar(pnlArvore);
        }

        private void btnIncluirCidade_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCidade_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterarCidade_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirCidade_Click(object sender, EventArgs e)
        {

        }

        private void btnIncluirCaminho_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirCaminho_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCaminho_Click(object sender, EventArgs e)
        {

        }
    }
}
