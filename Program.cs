using System;
using DIO.Classes.Opcoes;

namespace DIO
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Você deseja series ou filmes?");
            Console.WriteLine("1 - Séries");
            Console.WriteLine("2 - Filmes");

            var opcaoUsuario = Console.ReadLine().ToUpper();

            if (opcaoUsuario.Equals("1") || opcaoUsuario.Equals("Séries"))
            {
                OpcaoSerie opcaoSerie = new();
                opcaoSerie.Menu();
            }
            else if (opcaoUsuario.Equals("2") || opcaoUsuario.Equals("Filmes"))
            {
                OpcaoFilme opcaoFilme = new();
                opcaoFilme.Menu();
            }

            Console.WriteLine("Até mais!!!");
        }
    }
}
