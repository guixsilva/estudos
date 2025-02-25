using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoListaLigada
{
    internal class ManterAlunos
    {
        static ListaLigada<Aluno> aLista;
        public static void Main(string[] args)
        {
            aLista = new ListaLigada<Aluno>();
            Aluno umAluno = new Aluno("23519", "Guilherme Pereira", 59, 10);
        }
    }
}
