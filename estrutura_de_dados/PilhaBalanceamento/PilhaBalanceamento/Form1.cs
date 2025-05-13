using System.Windows.Forms;

namespace PilhaBalanceamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripProgressBar1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool balanceada;
            toolStripProgressBar1.Visible = true;
            iPilha<char> pilha = null;
            pilha = new Pilha<char>(15);
            if (txtExpressao.Text == "")
            {
                statusBar.Text = "Expressão Vazia";
            }
            else
            {
                string expressao = txtExpressao.Text;
                for (int i = 0; i < expressao.Length; i++)
                {
                    toolStripProgressBar1.Value = i;
                    char caractere = expressao[i];
                    if ("{[(".Contains(caractere))
                    {
                        pilha.Empilhar(caractere);
                    }
                    else
                    {
                        if ("})]".Contains(caractere))
                        {
                            try
                            {
                                char desempilhado = pilha.Desempilhar();
                                if (!pilha.Combinam(desempilhado, caractere))
                                {
                                    balanceada = false;
                                }
                            }
                            catch
                            {
                                balanceada = false;
                            }
                        }
                    }

                }

                if (!pilha.EstaVazia)
                {
                    balanceada = false;
                }

                balanceada = true;
                statusBar.Text = "Expressão Balanceada";
                toolStripProgressBar1.Value = 100;
            }
        }
    }
}
