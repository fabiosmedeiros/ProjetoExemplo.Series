using ProjetoExemplo.Series.Enum;
using ProjetoExemplo.Series.Infra.Data.Repository;

namespace ProjetoExemplo.Series
{
    public class Program
    {

        static SerieRepository serieRepository = new SerieRepository();

        public static void Main(string[] args)
        {
            Console.WriteLine("***************** Series *****************");

            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        opcaoUsuario = "X";
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    // case "3":
                    //     AtualizarSerie();
                    //     break;
                    // case "4":
                    //     ExcluirSerie();
                    //     break;
                    // case "5":
                    //     VisualizarSerie();
                    //     break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        private static string ObterOpcaoUsuario()
        {
            System.Console.WriteLine("Informe a opção desejada");
            System.Console.WriteLine("1 - Listar séries");
            System.Console.WriteLine("2 - Inserir nova série");
            System.Console.WriteLine("3 - Atualizar série");
            System.Console.WriteLine("4 - Excluir série");
            System.Console.WriteLine("5 - Visualizar série");
            System.Console.WriteLine("C - Limpar tela");
            System.Console.WriteLine("X - Sair");

            string opcaoUsuario = Console.ReadLine().ToUpper();

            Console.WriteLine();
            return opcaoUsuario;
        }

        public static void ListarSeries()
        {
            System.Console.WriteLine("Listar séries");

            var listaDeSeries = serieRepository.GetAll();

            if(listaDeSeries.Count == 0)
            {
                System.Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach(var serie in listaDeSeries)
            {
                System.Console.WriteLine("#ID {0}: - {1}", serie.retornaId(), serie.retornaTitulo());
            }
        }

        public static void InserirSerie()
        {
            System.Console.WriteLine("Inserir nova série");

            foreach(int i in System.Enum.GetValues(typeof(Genero)))
            {

            }
        }
    }
}