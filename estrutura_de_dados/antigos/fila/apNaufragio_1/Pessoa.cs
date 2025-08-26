
using System;

public class Pessoa : IComparable<Pessoa>
{
  private string nome;
  private int idade;
  private char genero;
  
  public string Nome { get => nome; set => nome = value; }
  public int Idade { get => idade; set => idade = value; }
  public char Genero { get => genero; set => genero = value; }
  
  public Pessoa(string dados)
  {
    Nome   = dados.Substring(0, 30);
    Idade  = int.Parse(dados.Substring(30, 3));
    Genero = dados.Substring(33, 1)[0];
  }
  public override string ToString()
  {
    return Nome + " " + Idade + " " + Genero;
  }

  public int CompareTo(Pessoa outra)
  {
    return Nome.CompareTo(outra.Nome);
  }
}
