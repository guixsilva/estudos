using System;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using static System.Console;

namespace apHashSimples
{
  class Program
  {
    static Pessoa[] algunsNomes = new Pessoa[]
    { new Pessoa("David",1), new Pessoa("Jennifer",2),
      new Pessoa("Donnie",3), new Pessoa("Mayo",4),
      new Pessoa("Raymond",5), new Pessoa("Bernica",6),
      new Pessoa("Mike",7), new Pessoa("Clayton",8),
      new Pessoa("Beata",9), new Pessoa("Michael",10),
      new Pessoa("Felipe",11), new Pessoa("Silvana",12),
      new Pessoa("Igor",13), new Pessoa("Lucia", 14),
      new Pessoa("Guilherme",15), new Pessoa("Monica",16)
      //, new Pessoa("Amélia",17), new Pessoa("Francisco",18)
    };
    static void Main(string[] args)
    {
      int onde;
      string resultado;
      ForegroundColor = ConsoleColor.White;
      BackgroundColor = ConsoleColor.Blue;
      Clear();

      WriteLine("Teste com tamanhos primo e não primo. Exemplo: 100, 131, 10007.");
      WriteLine($"Há {algunsNomes.Length} nomes no conjunto de testes.\nVocê pode " +
      "digitar um valor menor que esse, forçando colisões.");
      Write("\nQual o número de posições da Tabela de Hash?");
      int tamanho = int.Parse(ReadLine());

      var tabela1 = new HashSimples<Pessoa>(tamanho);

      WriteLine("\n-------------------------------------------------------------");
      WriteLine("Teste com hash inicial, sem uso da regra de Horner no cálculo");
      for (int i = 0; i < algunsNomes.Length; i++)
        if ((resultado = tabela1.Incluir(algunsNomes[i])) != "")
          WriteLine(resultado);

      WriteLine("Conteúdo da tabela");
      foreach (string item in tabela1.Conteudo())
        WriteLine(item);
      EsperarEnter();
      if (tabela1.Existe(new Pessoa("Amélia", 0), out onde))
        WriteLine($"Achou Amélia na posição {onde}");
      else
        WriteLine($"Não achou Amélia mas deveria estar na posição {onde}");
      if (tabela1.Existe(new Pessoa("Clayton", 0), out onde))
        WriteLine($"Achou Clayton na posição {onde}");
      else
        WriteLine($"Não achou Clayton mas deveria estar na posição {onde}");
      EsperarEnter();

    }

    static void EsperarEnter()
    {
      Write("\nPressione [Enter]");
      ReadLine();
    }

  }
}
