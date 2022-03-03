using ProjetoExemplo.Series.Domain.Entities;

public class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Series");

        

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
}