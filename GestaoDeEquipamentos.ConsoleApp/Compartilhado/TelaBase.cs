namespace GestaoDeEquipamentos.ConsoleApp.Compartilhado;

public abstract class TelaBase
{
    private string nomeEntidade;

    protected TelaBase(string nomeEntidade)
    {
        this.nomeEntidade = nomeEntidade;
    }

    public char ApresentarMenu()
    {
        ExibirCabecalho();

        Console.WriteLine($"1 - Cadastro de {nomeEntidade}");
        Console.WriteLine($"2 - Visualizar {nomeEntidade}s");
        Console.WriteLine($"3 - Editar {nomeEntidade}");
        Console.WriteLine($"4 - Excluir {nomeEntidade}");
        Console.WriteLine($"S - Sair");

        Console.WriteLine();

        Console.Write("Digite uma opção válida: ");
        char opcaoEscolhida = Console.ReadLine().ToUpper()[0];

        return opcaoEscolhida;
    }

    protected void ExibirCabecalho()
    {
        Console.Clear();
        Console.WriteLine($"Gestão de {nomeEntidade}");
        Console.WriteLine();
    }
}