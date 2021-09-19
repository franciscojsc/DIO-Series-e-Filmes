using DIO.Enums;

namespace DIO.Base
{
    public abstract class EntidadeBase
    {
        protected EntidadeBase(int id, Genero genero, string titulo, string descricao, int ano, bool excluido = false)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = excluido;
        }

        protected int Id { get; set; }
        protected Genero Genero { get; }
        protected string Titulo { get; }
        protected string Descricao { get; }
        protected int Ano { get; }
        protected bool Excluido { get; set; }
    }
}
