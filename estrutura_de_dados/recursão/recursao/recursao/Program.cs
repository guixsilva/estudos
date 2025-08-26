using static System.Console;

class Program
{
static void Main(string[] args)
{
    Console.Write("Digite o valor de n: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine($"{n}! = {fatorial(n)}");
}

static int fatorial(int n)
{
    if(n == 0)
    {
        return 1;
    }
    return n * (fatorial(n - 1));
}
}