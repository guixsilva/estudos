using System;

public class Carro : IComparable<Carro>, IEquatable<Carro>
{
  string placa;
  int numeroDeManobras;

  public Carro(string placa)
  {
    this.placa = placa;
    numeroDeManobras = 0;
  }

  public string Placa 
  { 
    get => placa; 
    set => placa = value; 
  }
  public int NumeroDeManobras 
  { 
    get => numeroDeManobras; 
    set => numeroDeManobras = value; 
  }

  public int CompareTo(Carro other)
  {
    return this.placa.CompareTo(other.placa);
  }

  public bool Equals(Carro other)
  {
    return this.placa.Equals(other.placa);
  }
}

