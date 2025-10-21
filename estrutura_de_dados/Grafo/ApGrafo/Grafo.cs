using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;

public class Grafo
{
  private const int NUM_VERTICES = 20;
  private Vertice[] vertices;
  private int[,] adjMatrix;
  int numVerts;
  DataGridView dgv; // para exibir a matriz de adjacência num formulário

  public Grafo(DataGridView dgv)
  {
    this.dgv = dgv;
    vertices = new Vertice[NUM_VERTICES];
    adjMatrix = new int[NUM_VERTICES, NUM_VERTICES];
    numVerts = 0;
    for (int j = 0; j < NUM_VERTICES; j++) // zera toda a matriz
      for (int k = 0; k < NUM_VERTICES; k++)
        adjMatrix[j, k] = 0;
  }

  public void NovoVertice(string label)
  {
    vertices[numVerts] = new Vertice(label);
    numVerts++;
    if (dgv != null) // se foi passado como parâmetro um dataGridView para exibição
    {                // se realiza o seu ajuste para a quantidade de vértices
      dgv.RowCount = numVerts + 1;
      dgv.ColumnCount = numVerts + 1;
      dgv.Columns[numVerts].Width = 45;
    }
  }

  public void NovaAresta(int start, int eend, bool bidirecional)
  {
    if (start != eend)    // Se iguais, PODE GERAR CICLOS!!!
    {
      adjMatrix[start, eend] = 1;       // ida
      if (bidirecional)
         adjMatrix[eend, start] = 1;    // e volta
    }
    else
      adjMatrix[start, eend] = 0; // sem ligação da cidade para ela mesma
  }

  public void ExibirVertice(int v)
  {
    Console.Write(vertices[v].Rotulo + " ");
  }

  public void ExibirVertice(int v, TextBox txt)
  {
    txt.Text += vertices[v].Rotulo + " ";
  }

  public int SemSucessores() // encontra e retorna a linha de um vértice sem sucessores
  {
    bool temAresta;
    for (int linha = 0; linha < numVerts; linha++)
    {
      temAresta = false;
      for (int col = 0; col < numVerts; col++)
        if (adjMatrix[linha, col] > 0)
        {
          temAresta = true;
          break;
        }
      if (!temAresta)
        return linha;
    }
    return -1;
  }

  public void RemoverVertice(int vert)
  {
    if (dgv != null)
    {
      MessageBox.Show($"Matriz de Adjacências antes de remover vértice {vert}");
      ExibirAdjacencias();
    }
    if (vert != numVerts - 1)
    {
      for (int j = vert; j < numVerts - 1; j++)// remove vértice do vetor
        vertices[j] = vertices[j + 1];
      // remove vértice da matriz
      for (int row = vert; row < numVerts; row++)
        MoverLinhas(row, numVerts - 1);
      for (int col = vert; col < numVerts; col++)
        MoverColunas(col, numVerts - 1);
    }
    numVerts--;       // temos um vértice a menos, agora

    if (dgv != null)
    {
      MessageBox.Show($"Matriz de Adjacências após remover vértice {vert}");
      ExibirAdjacencias();
      MessageBox.Show("Retornando à ordenação");
    }
  }

  private void MoverLinhas(int row, int length)
  {
    if (row != numVerts - 1)
      for (int col = 0; col < length; col++)
        adjMatrix[row, col] = adjMatrix[row + 1, col]; // desloca para excluir
  }

  private void MoverColunas(int col, int length)
  {
    if (col != numVerts - 1)
      for (int row = 0; row < length; row++)
        adjMatrix[row, col] = adjMatrix[row, col + 1]; // desloca para excluir
  }

  public void ExibirAdjacencias()
  {
    dgv.RowCount = numVerts + 1;
    dgv.ColumnCount = numVerts + 1;
    for (int j = 0; j < numVerts; j++)
    {
      dgv.Rows[j + 1].Cells[0].Value = vertices[j].Rotulo;
      dgv.Rows[0].Cells[j + 1].Value = vertices[j].Rotulo;
      for (int k = 0; k < numVerts; k++)
        dgv.Rows[j + 1].Cells[k + 1].Value = Convert.ToString(adjMatrix[j, k]);
    }
  }

  public string OrdenacaoTopologica()
  {
    Stack<String> gPilha = new Stack<String>(); //guarda a sequência de vértices
    int origVerts = numVerts;
    while (numVerts > 0)
    {
      int currVertex = SemSucessores();
      if (currVertex == -1)
        return "Erro: grafo possui ciclos.";
      gPilha.Push(vertices[currVertex].Rotulo); // empilha vértice
      RemoverVertice(currVertex);
    }
    String resultado = "Sequência da Ordenação Topológica: ";
    while (gPilha.Count > 0)
      resultado += gPilha.Pop() + " "; // desempilha para exibir
    return resultado;
  }

}
