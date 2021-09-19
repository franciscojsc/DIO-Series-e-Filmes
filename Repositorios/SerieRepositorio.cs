using System.Collections.Generic;
using DIO.Interfaces;
using DIO.Series;

namespace DIO.Reposistorios.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private readonly List<Serie> _listaSeries = new();

        public void Atualiza(int id, Serie entidade)
        {
            _listaSeries[id] = entidade;
        }

        public void Exclui(int id)
        {
            _listaSeries[id].Excluir();
        }

        public void Insere(Serie entidade)
        {
            _listaSeries.Add(entidade);
        }

        public List<Serie> Lista()
        {
            return _listaSeries;
        }

        public int ProximoId()
        {
            return _listaSeries.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return _listaSeries[id];
        }
    }
}
