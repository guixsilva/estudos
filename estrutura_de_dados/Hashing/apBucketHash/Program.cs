using System;
using System.Collections.Generic;
using static System.Console;
namespace apBucketHash
{
  internal class Program
  {
    static Pessoa[] algunsNomes = new Pessoa[]
    {  new Pessoa("David",1),
       new Pessoa("Jennifer",2),
       new Pessoa("Donnie",3),
       new Pessoa("Mayo",4),
       new Pessoa("Raymond",5),
       new Pessoa("Bernica",6),
       new Pessoa("Mike",7),
       new Pessoa("Clayton",8),
       new Pessoa("Beata",9),
       new Pessoa("Michael",10),
       new Pessoa("Felipe",11),
       new Pessoa("Silvana",12),
       new Pessoa("Igor",13),
       new Pessoa("Lucia", 14),
       new Pessoa("Guilherme",15),
       new Pessoa("Monica",16),
       new Pessoa("Amélia",17),
       new Pessoa("Francisco",18)
    };

    static void Main(string[] args)
    {
      IHashing<Pessoa> tabela;
      WriteLine("1 - Hash Simples\n2 - Bucket Hash");
      Write("Que tipo de hash deseja (1 ou 2) :");
      int tipoHash = int.Parse(ReadLine());
      if (tipoHash == 1)
         tabela = new HashSimples<Pessoa>();
      else
        tabela = new BucketHash<Pessoa>();
      BackgroundColor = ConsoleColor.White;
      ForegroundColor = ConsoleColor.Black;
      Clear();
      WriteLine("Inserindo chaves");
      for (int i = 0; i < algunsNomes.Length; i++)
        if (!tabela.Incluir(algunsNomes[i]))
          WriteLine($"Colisão com {algunsNomes[i]}");
      Exibir(tabela.Conteudo());
      EsperarEnter();

      if (tabela.Excluir(new Pessoa("Bernica", 0)))
        WriteLine("Removeu: Bernica");
      else
        WriteLine("Não achou: Bernica");
      Exibir(tabela.Conteudo());
      EsperarEnter();

      if (tabela.Excluir(new Pessoa("David", 0)))
        WriteLine("Removeu: David");
      else
        WriteLine("Não achou: David");
      Exibir(tabela.Conteudo());
      EsperarEnter();

      if (tabela.Excluir(new Pessoa("Chico", 0)))
        WriteLine("Removeu: Chico");
      else
        WriteLine("Não achou: Chico");
      Exibir(tabela.Conteudo());
      EsperarEnter();
    }

    static void Exibir(List<string> lista)
    {
      foreach (string item in lista)
        WriteLine(item);
    }

    static void EsperarEnter()
    {
      Write("Pressione [Enter]:");
      ReadLine();
      WriteLine();
    }
  }
}
