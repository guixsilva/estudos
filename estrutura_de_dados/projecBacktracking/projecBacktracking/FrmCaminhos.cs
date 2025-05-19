namespace projecBacktracking
{
    public partial class FrmCaminhos : Form
    {
        public FrmCaminhos()
        {
            InitializeComponent();
        }

        private void btnAbrirArquivo_Click(object sender, EventArgs e)
        {
            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                oGrafo = new GrafoBacktracking(dlgAbrir.FileName);
                txtOrigem.Maximum = oGrafo.qtasCidades -1;
                txtDestino.Maximum = oGrafo.qtasCidades -1;

            }
        }

    }
}
