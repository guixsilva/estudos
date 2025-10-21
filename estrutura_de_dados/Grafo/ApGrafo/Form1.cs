namespace ApGrafo
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnCriarEOrdenar_Click(object sender, EventArgs e)
    {
      Grafo oGrafo = new Grafo(dgvGrafo);
      oGrafo.NovoVertice("CS1"); // 0
      oGrafo.NovoVertice("CS2"); // 1
      oGrafo.NovoVertice("DS");  // 2
      oGrafo.NovoVertice("OS");  // 3
      oGrafo.NovoVertice("ALG"); // 4
      oGrafo.NovoVertice("ASM"); // 5
      oGrafo.NovoVertice("TOO"); // 6
      oGrafo.NovoVertice("TED"); // 6
      oGrafo.NovaAresta(0, 1, false);
      oGrafo.NovaAresta(1, 2, false);
      oGrafo.NovaAresta(1, 5, false);
      oGrafo.NovaAresta(2, 3, false);
      oGrafo.NovaAresta(2, 4, false);
      oGrafo.NovaAresta(2, 6, false);
      oGrafo.NovaAresta(2, 7, false);
      txtResultado.Text = oGrafo.OrdenacaoTopologica();
    }

    private void btnOrdenarRoupas_Click(object sender, EventArgs e)
    {

    }
  }
}
