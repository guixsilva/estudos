namespace Exer3
{
    public partial class Form1 : Form
    {

        ListaSimples<Palavras> palavras;

        public Form1()
        {
            InitializeComponent();
            lstVisor.Items.Clear();
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            FazerLeitura(ref palavras, lstVisor);
        }

        private void FazerLeitura(ref ListaSimples<Palavras> listainterna, ListBox listBox)
        {
            listainterna = new ListaSimples<Palavras>();
            int numLinha = 0;
            ListaSimples<Linha> listadelinhas = new ListaSimples<Linha>();
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                StreamReader arquivo = new StreamReader(openFileDialog1.FileName);
                while (!arquivo.EndOfStream)
                {
                    string linha = arquivo.ReadLine();
                    string[] vetordepalavras = linha.Split(' ');

                    for (int i = 0; i < vetordepalavras.Length; i++)
                    {

                        if (listainterna.EstaVazia == true)
                        {
                            Linha novaLinha = new Linha(i);
                            listadelinhas.InserirAposFim(novaLinha);
                            Palavras palavra = new Palavras(vetordepalavras[i], numLinha);
                            palavra.Palavra = vetordepalavras[i];
                            palavra.Linha = listadelinhas;
                            listainterna.InserirAntesDoInicio(palavra);
                        }

                        else
                        {
                            Palavras palavra = new Palavras(vetordepalavras[i], numLinha);
                            Linha novaLinha = new Linha(i);
                            listadelinhas.InserirAposFim(novaLinha);
                            palavra.Palavra = vetordepalavras[i];
                            palavra.Linha = listadelinhas;
                            listainterna.InsereEmOrdemAlfabetica(palavra);
                        }
                    }
                }
                arquivo.Close();
                listainterna.Listar(lstVisor);
                Console.WriteLine(listainterna.ToString()); 
            }
        }
    }
}
