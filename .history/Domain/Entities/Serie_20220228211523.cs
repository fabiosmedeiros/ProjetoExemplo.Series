using ProjetoExemplo.Series.Enum;

namespace ProjetoExemplo.Series.Domain.Entities
{
    public class Serie : BaseEntity
    {
        private Genero Genero { get; set; }

        private string Titulo { get; set; }

        private string  Descricao { get; set; }

        private int Ano { get; set; }


        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de ìnício: " + this.Ano + Environment.NewLine;
        }
    }
}