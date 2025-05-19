using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecBacktracking
{
    public class GrafoBacktracking
    {

        int qtasCidades;
        int[,] matriz;

        public GrafoBacktracking(string nomeDoArquivo)
        {
            var arquivo = new StreamReader(nomeDoArquivo);
            qtasCidades = int.Parse(arquivo.ReadLine());
            matriz = new int[qtasCidades, qtasCidades];
            for (int linha = 0; linha < qtasCidades; linha++)
            {
                for (int coluna = 0; coluna < qtasCidades; coluna++)
                {
                    matriz[linha, coluna] = -1;
                }
            }

            while (!arquivo.EndOfStream)
            {
                string[] linha = arquivo.ReadLine().Split(' ');
                int origem = int.Parse(linha[0]);
                int destino = int.Parse(linha[1]);
                int custo = int.Parse(linha[2]);
                matriz[origem, destino] = custo;
            }

            arquivo.Close();
        }

        public int QtasCidades { get => qtasCidades; set => qtasCidades = value; }
        public int[,] Matriz { get => matriz; set => matriz = value; }

        public void Exibir (DataGridView tabela)
        {
            tabela.RowCount = tabela.ColumnCount = qtasCidades;
            for(int coluna = 0; coluna < qtasCidades; coluna++)
            {
                tabela.Columns[coluna].HeaderText = coluna.ToString();
                tabela.Rows[coluna].HeaderCell.Value = coluna.ToString();
                tabela.Columns[coluna].Width = 30;
            }
            for(int linha = 0; linha < qtasCidades; linha++)
            {
                for(int coluna = 0; coluna < qtasCidades; coluna++)
                {
                    if (matriz[linha, coluna] != 0)
                    {
                        tabela[coluna, linha].Value = matriz[linha, coluna];
                    }
                }
            }
        }
    }
}
