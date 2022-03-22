// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 6");

            int idade = 32;
            int idadeGustavo = idade;

            idade = 20;

            Console.WriteLine(idade);

            Console.WriteLine(idadeGustavo);

            Console.ReadLine();
        }
    }

}
