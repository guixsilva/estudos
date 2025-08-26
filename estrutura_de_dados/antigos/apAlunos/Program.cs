using System;
using static System.Console;
using System.IO;

namespace apAlunos
{
    internal class Program
    {
        static ListaSimples<Aluno> aLista;

        public static void SeletorDeOpcoes()
        {
            int resp = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("0 - Terminar programa");
                Console.WriteLine("1 - Incluir após fim da lista");
                Console.WriteLine("2 - Incluir antes do início da lista");
                Console.WriteLine("3 - Exibir lista na tela");
                Console.Write("\nDigite sua opção:");
                resp = int.Parse(Console.ReadLine());
                switch (resp)
                {
                    case 1: IncluirAposFinal();     break;
                    case 2: IncluirAntesDoInicio(); break;
                    case 3: ExibirDados();          break;
                }
            }
            while (resp != 0);
        }

        public static void IncluirAposFinal()
        {
            string ra = "1";
            // repetir a icnlusão enquanto o RA digitado for != "00000"
            while(ra != "00000")
            {
            Console.Clear();
            Write("RA: ");
            ra = ReadLine();
            if(ra != "00000")
            {
            Write("Nome: "); 
            var nome = ReadLine();
            Write("Curso :");
            var curso = int.Parse(ReadLine());
            Write("Média: ");
            double media = double.Parse(ReadLine());

            aLista.InserirAposFim(new Aluno(ra, nome, curso, media));
            }
            }


        }

        public static void IncluirAntesDoInicio()
        {
            string ra = "1";

            do
            {
                Console.Clear();
                Write("RA: ");
                ra = ReadLine();
                if (ra != "00000")
                {
                    Write("Nome: ");
                    var nome = ReadLine();
                    Write("Curso :");
                    var curso = int.Parse(ReadLine());
                    Write("Média: ");
                    double media = double.Parse(ReadLine());

                    aLista.InserirAntesDoInicio(new Aluno(ra, nome, curso, media));
                }
            }
            while (ra != "00000");

        }
        public static void ExibirDados()
        {
            Console.Clear();
            aLista.ExibirNaTela();

            Console.Write("Tecle [Enter] para continuar");
            var resp = Console.ReadLine();
        }

        public static void Main(string[] args)
        {
            aLista = new ListaSimples<Aluno>();

            SeletorDeOpcoes();

            Console.Write("Tecle [Enter] para terminar");
            var resp = Console.ReadLine();

        }
    }
}
