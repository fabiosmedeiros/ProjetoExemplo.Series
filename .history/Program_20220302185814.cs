using ProjetoExemplo.Series.Domain.Entities;
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
            System.Console.WriteLine("Inserir nova Série");

            foreach(int i in System.Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("{0}-{1}", i, System.Enum.GetName(typeof(Genero), i));
            }

            System.Console.WriteLine("Digite o gênero entre as opções acima: ");
            
            int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o título da Série: ");
            
            string entradaTitulo = Console.ReadLine();

            System.Console.WriteLine("Digite o ano de início da Série: ");
            
            int entradaAno = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a descrição da Série: ");

            string entradaDescricao = Console.ReadLine();
            Serie novaSerie = new Serie(serieRepository.proximoId(),
                                        (Genero)entradaGenero,
                                        entradaTitulo,
                                        entradaAno,
                                        entradaDescricao);

            serieRepository.Add(novaSerie);
        }
    }
}