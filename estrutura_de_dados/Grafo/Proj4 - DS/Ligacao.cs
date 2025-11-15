using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj4
{
  public class Ligacao : IComparable<Ligacao>
  {
    string origem, destino;
    int distancia;


    public Ligacao(string linhalida)
    {
            string[] partes = linhalida.Split(';');
            this.origem = partes[0];
            this.destino = partes[1];
            this.distancia = int.Parse(partes[2]);
    }

        public Ligacao(string origem, string destino, int distancia)
        {
            this.origem = origem;
            this.destino = destino;
            this.distancia = distancia;
        }


        public int CompareTo(Ligacao other)
    {
      return (origem+destino).CompareTo(other.origem+other.destino);
    }

  }
}
