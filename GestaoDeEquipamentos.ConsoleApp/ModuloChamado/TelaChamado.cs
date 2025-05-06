
namespace GestaoDeEquipamentos.ConsoleApp.ModuloChamado;

public class TelaChamado
{
    public void ExibirCabecalho()
    {
        Console.Clear();
        Console.WriteLine("Gestão de Chamados");
        Console.WriteLine();
    }

    public char ApresentarMenu()
    {
        ExibirCabecalho();

        Console.WriteLine("1 - Cadastro de Chamado");
        Console.WriteLine("2 - Visualizar Chamados");
        Console.WriteLine("3 - Editar Chamado");
        Console.WriteLine("4 - Excluir Chamado");
        Console.WriteLine("S - Sair");

        Console.WriteLine();

        Console.Write("Digite uma opção válida: ");
        char opcaoEscolhida = Console.ReadLine().ToUpper()[0];

        return opcaoEscolhida;
    }

    public void CadastrarRegistro()
    {
        throw new NotImplementedException();
    }

    public void EditarRegistro()
    {
        throw new NotImplementedException();
    }

    public void ExcluirRegistro()
    {
        throw new NotImplementedException();
    }

    public void VisualizarRegistros(bool exibirCabecalho)
    {
        throw new NotImplementedException();
    }
}
