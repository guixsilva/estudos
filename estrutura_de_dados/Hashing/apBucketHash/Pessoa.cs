using System;
using System.Collections.Generic;
using System.IO;

public class Pessoa : IRegistro<Pessoa>
{
  public string nome;
  public int inteiro;

  public Pessoa() 
  {
    nome = "";
    inteiro = 0;
  }

  public Pessoa(string nome, int inteiro)
  {
    this.nome = nome;
    this.inteiro = inteiro;
  }

  public string Chave => nome;    // get

  public void LerRegistro(StreamReader arquivo)
  {
    string linha = arquivo.ReadLine();
    nome = linha.Substring(0, 30);
    inteiro = int.Parse(linha.Substring(30));
  }

  public void EscreverRegistro(StreamWriter arquivo)
  {
    arquivo.WriteLine($"{nome}{inteiro}");
  }

  public bool Equals(Pessoa outroRegistro)
  {
    return outroRegistro != null && 
            nome.Equals(outroRegistro.nome);
  }

  public override bool Equals(object obj) => 
                          Equals(obj as Pessoa);

  public override string ToString()
  {
    return $"[{nome}, {inteiro}]";
  }

  public int CompareTo(Pessoa outroRegistro)
  {
    return nome.CompareTo(outroRegistro.nome);
  }
}
