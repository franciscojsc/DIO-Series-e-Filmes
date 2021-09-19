using System.Collections.Generic;
using DIO.Filmes;
using DIO.Interfaces;

namespace DIO.Reposistorios.Filmes
{
    public class FilmeRepositorio : IRepositorio<Filme>
    {
        private readonly List<Filme> _listaFilmes = new();

        public void Atualiza(int id, Filme entidade)
        {
            _listaFilmes[id] = entidade;
        }

        public void Exclui(int id)
        {
            _listaFilmes[id].Excluir();
        }

        public void Insere(Filme entidade)
        {
            _listaFilmes.Add(entidade);
        }

        public List<Filme> Lista()
        {
            return _listaFilmes;
        }

        public int ProximoId()
        {
            return _listaFilmes.Count;
        }

        public Filme RetornaPorId(int id)
        {
            return _listaFilmes[id];
        }
    }
}
