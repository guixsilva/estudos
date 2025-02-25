using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjetoListaLigada
{
    internal class Aluno : IComparable<Aluno>
    {
        string ra;
        string nome;
        int curso;
        float media;

        public string Ra { get => ra; set {
                ra = value.PadLeft(5, '0');
            } }
        public string Nome
        {
            get => nome; set
            {
                if (value.Length > 30)
                {
                    value = value.Substring(30, ' ');
                }
                else
                {
                    value = value.PadRight(30, ' ');
                }
            }
        }
        public int Curso
        {
            get => curso; set
            {
                if (value <= 0)
                {
                    throw new Exception("Código de curso inválido!");
                }
                curso = value;
            }
        }
        public float Media
        {
            get => media; set
            {
                if (value < 0 || value > 10)
                {
                    throw new Exception("Média inválida");
                }
                else
                {
                    media = value;
                }
            }
        }

        public Aluno(string ra)
        {
            this.Ra = ra;
        }

        public Aluno(string ra, string nome, int curso, float media)
        {
            this.Ra = ra;
            this.Nome = nome;
            this.Curso = curso;
            this.Media = media;
        }

        public int CompareTo(Aluno other)
        {
            return this.Ra.CompareTo(other.Ra);
        }


    }
}
