using ProjetoExemplo.Series.Enum;

namespace ProjetoExemplo.Series.Domain.Entities
{
    public class Serie : BaseEntity
    {
        private Genero Genero { get; set; }

        private string Titulo { get; set; }

        private string  Descricao { get; set; }

        private int Ano { get; set; }
    }
}