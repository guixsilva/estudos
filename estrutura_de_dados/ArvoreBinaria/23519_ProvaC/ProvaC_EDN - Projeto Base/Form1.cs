using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaC_ED
{
  public partial class Form1 : Form
  {
    Arvore<string> arvore = new Arvore<string>(); 
    String[] vetor = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O" };


    
    private void pbArvore_Paint(object sender, PaintEventArgs e)
    {
      arvore.Desenhar(pbArvore);
    }

    public Form1()
    {
      InitializeComponent();
            pbArvore.Invalidate();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            bool esquerda;

            if (rbDireito.Checked) {
                esquerda = false;
            }
            else
            {
                esquerda= true;
            }
            arvore.Inserir(txtNovoDado.Text, txtDadoAnterior.Text, esquerda);

            pbArvore.Invalidate();
        }
        private void btnCaminho_Click(object sender, EventArgs e)
        {
            List<NoArvore<string>> lista = new List<NoArvore<string>>();
            arvore.CaminhoAte(txtDadoABuscar.Text, ref lista);
            for(int i = 0; i < lista.Count; i++)
            {
                txtResultado.Clear();
                txtResultado.Text += lista[i].Info.ToString();
            }
            pbArvore.Invalidate();

        }
        private void btnBalanceada_Click(object sender, EventArgs e)
        {
            bool balanceada = arvore.EstaBalanceada();
            if (balanceada)
            {
                txtResultado.Clear();
                txtResultado.Text = "A árvore está balanceada";
            }
            else
            {
                txtResultado.Clear();
                txtResultado.Text = "A árvore NÃO está balanceada";
            }

            pbArvore.Invalidate();
        }

        private void btnNosInternos_Click(object sender, EventArgs e)
        {
            int quantNos = arvore.ContaNosInternos();
            txtResultado.Clear();
            txtResultado.Text = $"Existem {quantNos} Nós internos nessa árvore.";

            pbArvore.Invalidate();
        }

        private void btnSomarDados_Click(object sender, EventArgs e)
        {
            int qtsSoma = arvore.SomaDosDados();
            txtResultado.Clear();
            txtResultado.Text = $"A soma de dados resultou em : {qtsSoma}";

            pbArvore.Invalidate();
        }
    }
}
