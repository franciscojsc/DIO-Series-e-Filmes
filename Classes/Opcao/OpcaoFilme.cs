using System;
using System.Collections.Generic;
using DIO.Enums;
using DIO.Filmes;
using DIO.Reposistorios.Filmes;

namespace DIO.Classes.Opcoes
{
    public class OpcaoFilme
    {
        private readonly FilmeRepositorio _repositorio = new();

        public void Menu()
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (!string.Equals(opcaoUsuario, "X", StringComparison.OrdinalIgnoreCase))
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Listar();
                        break;
                    case "2":
                        Inserir();
                        break;
                    case "3":
                        Atualizar();
                        break;
                    case "4":
                        Excluir();
                        break;
                    case "5":
                        Visualizar();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            _ = Console.ReadLine();
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO filmes a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar filmes");
            Console.WriteLine("2- Inserir novo filme");
            Console.WriteLine("3- Atualizar filme");
            Console.WriteLine("4- Excluir filme");
            Console.WriteLine("5- Visualizar filme");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
        private void Listar()
        {
            Console.WriteLine("Listar filmes");

            List<Filme> lista = _repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum filme cadastrado.");
                return;
            }

            foreach (Filme filme in lista)
            {
                bool excluido = filme.RetornaExcluido();

                Console.WriteLine("#ID {0}: - {1} {2}", filme.RetornaId(), filme.RetornaTitulo(), excluido ? "*Excluído*" : "");
            }
        }

        private void Inserir()
        {
            Console.WriteLine("Inserir novo filme");

            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título do Filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início do Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição do Filme: ");
            string entradaDescricao = Console.ReadLine();

            Filme novoFilme = new(id: _repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            _repositorio.Insere(novoFilme);
        }
        private void Atualizar()
        {
            Console.Write("Digite o id do filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título do Filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início do Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição do Filme: ");
            string entradaDescricao = Console.ReadLine();

            Filme atualizaFilme = new(id: indiceFilme,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        descricao: entradaDescricao,
                                        ano: entradaAno);

            _repositorio.Atualiza(indiceFilme, atualizaFilme);
        }

        private void Excluir()
        {
            Console.Write("Digite o id da filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            _repositorio.Exclui(indiceFilme);
        }

        private void Visualizar()
        {
            Console.Write("Digite o id da filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            Filme filme = _repositorio.RetornaPorId(indiceFilme);

            Console.WriteLine(filme);
        }
    }
}

