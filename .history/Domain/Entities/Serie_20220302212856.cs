using ProjetoExemplo.Series.Enum;

namespace ProjetoExemplo.Series.Domain.Entities
{
    public class Serie : BaseEntity
    {
        private Genero Genero { get; set; }

        private string Titulo { get; set; }

        private string  Descricao { get; set; }

        private int Ano { get; set; }

        private bool Excluido { get; set; }


        public Serie(int id, Genero genero, string titulo, int ano, string descricao)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public string RetornaTitulo()
        {
            return this.Titulo;
        }

        public int RetornaId()
        {
            return this.Id;
        }

        public bool RetornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero    : " + this.Genero + Environment.NewLine;
            retorno += "Título    : " + this.Titulo + Environment.NewLine;
            retorno += "Descrição : " + this.Descricao + Environment.NewLine;
            retorno += "Ano       : " + this.Ano + Environment.NewLine;

            return retorno;
        }
    }
}