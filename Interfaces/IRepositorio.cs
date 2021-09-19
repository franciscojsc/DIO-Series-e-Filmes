using System.Collections.Generic;

namespace DIO.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Exclui(int id);
        void Insere(T entidade);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}
