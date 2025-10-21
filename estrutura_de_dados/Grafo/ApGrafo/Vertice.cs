using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Vertice
{
  string rotulo;      // identificação do vértice
  bool foiVisitado;   // informa se o vértice foi ou não visitado
                      // durante um percurso no grafo

  public Vertice(string rotulo)
  {
    this.rotulo = rotulo;   // nome da cidade, por exemplo
    foiVisitado = false;    // acabou de criar, não foi visitado ainda
  }

  public string Rotulo    { get => rotulo; set => rotulo = value; }
  public bool FoiVisitado { get => foiVisitado; set => foiVisitado = value; }
}

