using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apCadastroAlunos
{
    public class Aluno : IComparable<Aluno>, IcriterioDeSeparacao
    {
        const int tamanhoRA = 5;
        const int tamanhoNome = 30;
        const int tamanhoNota = 4;
        const int inicioRA = 0;
        const int inicioNome = inicioRA + tamanhoRA;
        const int inicioNota = inicioNome + tamanhoNome;

        string ra, nome;
        double nota;

        public string Ra
        {
            get => ra;
            set
            {
                if (value != "")
                    ra = value.Substring(0, tamanhoRA).PadLeft(tamanhoRA, '0');
                else
                    throw new Exception("RA vazio é inválido");
            }
        }

        public string Nome
        {
            get => nome;
            set
            {
                if (value != "")
                    nome = value.Substring(0, value.Length > tamanhoNome ? tamanhoNome : value.Length).PadRight(tamanhoNome, ' ');
                else
                    throw new Exception("Nome vazio é inválido");
            }
        }

        public double Nota
        {
            get => nota;
            set
            {
                if (value < 0 || value > 10)
                    throw new Exception("Nota inválida");
                else
                    nota = value;
            }
        }


        public Aluno(string linhaDeDados)
        {
            Ra = linhaDeDados.Substring(inicioRA, tamanhoRA);
            Nome = linhaDeDados.Substring(inicioNome, tamanhoNome);
            Nota = double.Parse(linhaDeDados.Substring(inicioNota, tamanhoNota));
        }
        public Aluno(string ra, string nome, float nota)
        {
            Ra = ra;
            Nome = nome;
            Nota = nota;
        }

        public int CompareTo(Aluno outroAluno)
        {
            return ra.CompareTo(outroAluno.ra);
        }
        public override string ToString()
        {
            return ra + nome + nota;
        }

        public bool DeveSeparar()
        {
            int raInteiro = Convert.ToInt32(ra);
            return raInteiro % 2 == 0;
        }
    }
}
