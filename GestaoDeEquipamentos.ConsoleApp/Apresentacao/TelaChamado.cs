using GestaoDeEquipamentos.ConsoleApp.Dominio;
using GestaoDeEquipamentos.ConsoleApp.Infraestrutura;

namespace GestaoDeEquipamentos.ConsoleApp.Apresentacao;

public class TelaChamado
{
    public RepositorioChamado repositoriochamado;
    public RepositorioEquipamento repositorioEquipamento;
    public string? ObterEscolhaDoMenuPrincipal()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Gestão de Chamados");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("1 - Cadastrar chamado");
        Console.WriteLine("2 - Editar chamado");
        Console.WriteLine("3 - Excluir chamado");
        Console.WriteLine("4 - Visualizar chamado");
        Console.WriteLine("S - Sair");
        Console.WriteLine("---------------------------------");
        Console.Write("> ");
        string? opcaoMenu = Console.ReadLine()?.ToUpper();

        return opcaoMenu;
    }

    public void Cadastrar()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Gestão de Chamados");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Cadastro de Chamado");
        Console.WriteLine("---------------------------------");

        System.Console.WriteLine(
            "{0, -7} | {1, -15} | {2, -15} | {3, -22} | {4, 10}",
            "Id", "Nome", "Fabricante", "Preço de Aquisição", "Data de Fabricação"
        );

        Equipamento?[] equipamentos = repositorioEquipamento.equipamentos;

        for (int i = 0; i < equipamentos.Length; i++)
        {
            Equipamento? e = equipamentos[i];
            
            if(e == null) 
                continue;
            
            System.Console.WriteLine(
            "{0, -7} | {1, -15} | {2, -15} | {3, -22} | {4, 10}",
            e.id, e.nome, e.fabricante, e.precoAquisicao.ToString("C2"), e.dataFabricacao.ToShortDateString()
            );
        }

        string? idSelecionado;

        do
        {
            System.Console.WriteLine("Digite o id do equipamento que deseja selecionar");
            idSelecionado = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(idSelecionado) && idSelecionado.Length == 7)
                break;
            
        } while (true);

        Equipamento? equipamentoSelecionado = repositorioEquipamento.SelecionarPorId(idSelecionado);

        if (equipamentoSelecionado == null)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Não foi possível encontrar o equipamento selecionado");
            Console.WriteLine("---------------------------------");
            Console.Write($"Digite ENTER para continuar...");
            Console.ReadLine();
            return;
        }

        Chamado novoChamado = new Chamado();

        novoChamado.equipamento = equipamentoSelecionado;

        do
        {
            System.Console.WriteLine("Digite o nome do equipamento: ");
            novoChamado.titulo = Console.ReadLine();
    
            if (string.IsNullOrWhiteSpace(novoChamado.titulo) && novoChamado.titulo.Length >= 3)
            {
                break;
            }
        } while (true);

        System.Console.WriteLine("Digite a descrição do chamado");
        novoChamado.descricao = Console.ReadLine();

        novoChamado.dataAbertura = DateTime.Now;

        repositoriochamado.Cadastrar(novoChamado);

        Console.WriteLine("---------------------------------");
        Console.WriteLine($"O registro \"{novoChamado.id}\" foi editado com sucesso!");
        Console.WriteLine("---------------------------------");
        Console.Write($"Digite ENTER para continuar...");
        Console.ReadLine();
    }

    public void Editar()
    {
        
    }

    public void Excluir()
    {
        
    }

    public void VisualizarTodos()
    {
        
    }
}
