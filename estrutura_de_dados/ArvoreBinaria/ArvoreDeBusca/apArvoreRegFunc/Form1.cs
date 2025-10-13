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
  public partial class FrmFuncionario : Form
  {
    public FrmFuncionario()
    {
      InitializeComponent();
    }

    Arvore<Funcionario> arvore, arvoreB;



    private void button1_Click(object sender, EventArgs e)
    {
      lsbDados.Items.Clear();
      arvore.VisitarPreOrdem(lsbDados);  // chamada 0
      pnlArvore.Invalidate();  // chama o evento Paint do pbArvore
    }

    private void FrmArvore_Load(object sender, EventArgs e)
    {
      arvore = new Arvore<Funcionario>();
      arvore.LerArquivoDeRegistros("c:\\temp\\func.dat");
    }

    private void btnEm_Ordem_Click(object sender, EventArgs e)
    {
      lsbDados.Items.Clear();
      arvore.VisitarEmOrdem(lsbDados);
      pnlArvore.Invalidate();
    }

    private void btnPos_Ordem_Click(object sender, EventArgs e)
    {
      lsbDados.Items.Clear();
      arvore.VisitarPosOrdem(lsbDados);
      pnlArvore.Invalidate();
    }

    private void pbArvore_Paint(object sender, PaintEventArgs e)
    {

    }

    private void button7_Click(object sender, EventArgs e)
    {
      arvore.Espelhar();    // exercício 7
      pnlArvore.Invalidate();  // redesenha a árvore chamando evento Paint
    }

    private void button2_Click(object sender, EventArgs e)
    {
      int quantos = arvore.QuantosNos();
      lbQuantosNos.Text = quantos.ToString()+" nós";
    }

    private void button3_Click(object sender, EventArgs e)
    {
      int quantasFolhas = arvore.QuantasFolhas();
      lbQuantasFolhas.Text = quantasFolhas.ToString() + " folhas";
    }

    private void button4_Click(object sender, EventArgs e)
    {
      if (arvore.EstritamenteBinaria())
        MessageBox.Show("É estritamente binária!");
      else
        MessageBox.Show("Não é estritamente binária!");
    }

    private void button5_Click(object sender, EventArgs e)
    {
      lbAltura.Text = "Altura: " + arvore.Altura();
    }

    private void button6_Click(object sender, EventArgs e)
    {
      MessageBox.Show(arvore.EntreParenteses());
    }

    private void btnPorNiveis_Click(object sender, EventArgs e)
    {
      MessageBox.Show(arvore.PercursoPorNiveis());
    }

    private void btnLargura_Click(object sender, EventArgs e)
    {
      lbLargura.Text = "Largura: "+arvore.Largura();
    }

    private void btnAntecessores_Click(object sender, EventArgs e)
    {
      MessageBox.Show(arvore.preparaEscritaDosAntecessores(new Funcionario(int.Parse(txtMatricula.Text))));
    }

    private void pnlArvore_Paint(object sender, PaintEventArgs e)
    {
      arvore.Desenhar(pnlArvore);
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void btnExibir_Click(object sender, EventArgs e)
    {
      if (txtMatricula.Text != "")
      {
        var proc = new Funcionario(int.Parse(txtMatricula.Text));
        if (arvore.Existe(proc))  // Existe ajusta o ponteiro "atual" da árvore
        {
          var func = arvore.Atual.Info; // funcionário apontado por "atual"
          txtNome.Text = func.Nome;
          dtpNascimento.Value = func.Nascimento;
          txtCodigoSecao.Text = func.CodigoSecao.ToString();
          txtMatriculaChefe.Text = func.MatriculaChefe.ToString();
          txtSalario.Text = func.Salario.ToString();
          udDependentes.Value = func.QuantosDependentes;
          chkAfastado.Checked = func.Afastado;
        }
        else
          MessageBox.Show("Não encontrou essa matrícula!");
        pnlArvore.Invalidate();
      }
    }

    private void btnIncluir_Click(object sender, EventArgs e)
    {
      if (txtMatricula.Text != "" /* e os demais campos também */)
      {
        var func = new Funcionario(int.Parse(txtMatricula.Text),
                        txtNome.Text, dtpNascimento.Value,
                        int.Parse(txtCodigoSecao.Text),
                        int.Parse(txtMatriculaChefe.Text),
                        (int)udDependentes.Value,
                        double.Parse(txtSalario.Text),
                        chkAfastado.Checked);
        try
        {
          arvore.Incluir(func);
          MessageBox.Show("Funcionário incluído!");
        }
        catch {
          MessageBox.Show("Funcionário já existe, não incluiu!");
        }
        pnlArvore.Invalidate();
      }
    }

    private void button8_Click(object sender, EventArgs e)
    {
      if (txtMatricula.Text != "" /* e os demais campos também */)
      {
        var func = new Funcionario(int.Parse(txtMatricula.Text),
                        txtNome.Text, dtpNascimento.Value,
                        int.Parse(txtCodigoSecao.Text),
                        int.Parse(txtMatriculaChefe.Text),
                        (int)udDependentes.Value,
                        double.Parse(txtSalario.Text),
                        chkAfastado.Checked);

        if (arvore.IncluirNovoDado(func))
          MessageBox.Show("Funcionário incluído!");
        else
          MessageBox.Show("Funcionário já existe, não incluiu!");
        pnlArvore.Invalidate();
      }
    }

    private void FrmFuncionario_FormClosing(object sender, FormClosingEventArgs e)
    {
      arvore.GravarArquivoDeRegistros("c:\\temp\\func.dat");
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
      if (txtMatricula.Text != "")
      {
        var funcAExcluir = new Funcionario(int.Parse(txtMatricula.Text));
        if (arvore.Excluir(funcAExcluir))
          MessageBox.Show("Funcionário excluído");
        else
          MessageBox.Show("Matrícula não encontrada, não excluído");
        pnlArvore.Invalidate();
      }
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      bool equivalem = arvore.EquivaleA(arvoreB);
      if (equivalem)
        MessageBox.Show("São equivalentes.");
      else
        MessageBox.Show("Não equivalem.");
      chkEquivalem.Checked = equivalem;
    }
  }
}
