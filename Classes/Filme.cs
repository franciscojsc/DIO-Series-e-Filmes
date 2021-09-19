using System;
using DIO.Base;
using DIO.Enums;

namespace DIO.Filmes
{
    public class Filme : EntidadeBase
    {
        public Filme(int id, Genero genero, string titulo, string descricao, int ano, bool excluido = false) : base(id, genero, titulo, descricao, ano, excluido)
        {
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + Genero + Environment.NewLine;
            retorno += "Titulo: " + Titulo + Environment.NewLine;
            retorno += "Descrição: " + Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + Ano + Environment.NewLine;
            retorno += "Excluido: " + Excluido;
            return retorno;
        }

        public string RetornaTitulo()
        {
            return Titulo;
        }

        public int RetornaId()
        {
            return Id;
        }

        public bool RetornaExcluido()
        {
            return Excluido;
        }

        public void Excluir()
        {
            Excluido = true;
        }
    }
}
