using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apArvore
{
  public partial class FrmArvoreBinaria : Form
  {
    public FrmArvoreBinaria()
    {
      InitializeComponent();
    }

    Arvore<String> arvore;



    private void button1_Click(object sender, EventArgs e)
    {
      lsbDados.Items.Clear();
      arvore.VisitarPreOrdem(lsbDados);  // chamada 0
      pbArvore.Invalidate();  // chama o evento Paint do pbArvore
    }

    private void FrmArvore_Load(object sender, EventArgs e)
    {
      arvore = new Arvore<String>();
      arvore.Raiz = new NoArvore<string>("A");      // nivel 0
      arvore.Raiz.Esq = new NoArvore<string>("B");  // nivel 1
      arvore.Raiz.Dir = new NoArvore<string>("C");

      arvore.Raiz.Esq.Esq = new NoArvore<string>("D");  // nivel 2
      arvore.Raiz.Esq.Dir = new NoArvore<string>("E");
      arvore.Raiz.Dir.Dir = new NoArvore<string>("F");

      arvore.Raiz.Dir.Dir.Esq = new NoArvore<string>("G"); // nivel 3
    }

    private void btnEm_Ordem_Click(object sender, EventArgs e)
    {
      lsbDados.Items.Clear();
      arvore.VisitarEmOrdem(lsbDados);
      pbArvore.Invalidate();
    }

    private void btnPos_Ordem_Click(object sender, EventArgs e)
    {
      lsbDados.Items.Clear();
      arvore.VisitarPosOrdem(lsbDados);
      pbArvore.Invalidate();
    }

    private void pbArvore_Paint(object sender, PaintEventArgs e)
    {
      arvore.Desenhar(pbArvore.CreateGraphics(), pbArvore.Width / 2, 0);
    }

    private void button7_Click(object sender, EventArgs e)
    {
      arvore.Espelhar();    // exercício 7
      pbArvore.Invalidate();  // redesenha a árvore chamando evento Paint
    }

    private void button2_Click(object sender, EventArgs e)
    {
      int quantos = arvore.QuantosNos();
      lbQuantosNos.Text = quantos.ToString()+" nós";
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      bool equivalem = arvore.EquivaleA(arvore);
      chkEquivalem.checked = equivalem;
    }
  }
}
