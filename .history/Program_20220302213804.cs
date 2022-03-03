using ProjetoExemplo.Series.Domain.Entities;
using ProjetoExemplo.Series.Enum;
using ProjetoExemplo.Series.Infra.Data.Repository;

namespace ProjetoExemplo.Series
{    
    public class Program
    {

        static SerieRepository serieRepository = new SerieRepository();

        static void Main(string[] args)
        {
            string opcao = ObterOpcao();

			while (opcao.ToUpper() != "X")
			{
				switch (opcao)
				{
					case "1":
						ListarSeries();
						break;
					case "2":
						AdicionarSerie();
						break;
					case "3":
						AtualizarSerie();
						break;
					case "4":
						DeletarSerie();
						break;
					case "5":
						ObterSerie();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcao = ObterOpcao();
			}
        }

        private static string ObterOpcao()
		{
			Console.WriteLine("**************************");
			Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("**************************");
			Console.WriteLine("1 -> Listar séries");
			Console.WriteLine("2 -> Inserir nova série");
			Console.WriteLine("3 -> Atualizar série");
			Console.WriteLine("4 -> Excluir série");
			Console.WriteLine("5 -> Visualizar série");
			Console.WriteLine("C -> Limpar Tela");
			Console.WriteLine("X -> Sair");
            Console.WriteLine("**************************");

			string opcao = Console.ReadLine().ToUpper();

			Console.WriteLine();
			return opcao;
		}

        private static void DeletarSerie()
		{
			Console.Write("Digite o Id da série a ser excluída:   ");

			int id = int.Parse(Console.ReadLine());

			serieRepository.Delete(id);
		}

        private static void ObterSerie()
		{
			Console.Write("Digite o Id da série:   ");

			int id = int.Parse(Console.ReadLine());
			var serie = serieRepository.GetById(id);

			Console.WriteLine(serie);
		}

        private static void AtualizarSerie()
		{
			Console.Write("Digite o Id da série:   ");

			int id = int.Parse(Console.ReadLine());

			foreach (int i in System.Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0} - {1}", i, System.Enum.GetName(typeof(Genero), i));
			}
			
            Console.Write("Digite uma opção:   ");
			
            int genero = int.Parse(Console.ReadLine());

			Console.Write("Digite o nome da série: ");
			
            string titulo = Console.ReadLine();

			Console.Write("Digite o ano da série:   ");
			
            int ano = int.Parse(Console.ReadLine());

			Console.Write("Digite uma descrição:   ");

			string descricao = Console.ReadLine();

			Serie atualizaSerie = new Serie(id, (Genero)genero, titulo, ano, descricao);

			serieRepository.Update(id, atualizaSerie);
		}

        private static void ListarSeries()
		{
			Console.WriteLine("Listar séries");
            System.Console.WriteLine("***********************************");
            System.Console.WriteLine("Id     Nome");

			var lista = serieRepository.GetAll();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhuma série cadastrada");
				return;
			}

			foreach (var serie in lista)
			{
                var excluido = serie.RetornaExcluido();
                
				Console.WriteLine("{0}      {1} {2}", serie.RetornaId(), serie.RetornaTitulo(), (excluido ? "-> Série excluída" : ""));
			}
		}

        private static void AdicionarSerie()
		{
            Console.WriteLine("************************");
			Console.WriteLine("Adicionar uma nova série");
            Console.WriteLine("************************");

			foreach (int i in System.Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0} - {1}", i, System.Enum.GetName(typeof(Genero), i));
			}

			Console.Write("Digite o gênero:   ");

			int genero = int.Parse(Console.ReadLine());

			Console.Write("Digite nome:       ");

			string titulo = Console.ReadLine();

			Console.Write("Digite o ano   :   ");
			
            int ano = int.Parse(Console.ReadLine());

			Console.Write("Digite a descrição:");
			
            string descricao = Console.ReadLine();
			Serie umaSerie = new Serie(serieRepository.ProximoId(), (Genero)genero, titulo, ano, descricao);

			serieRepository.Add(umaSerie);
		}

    }
}