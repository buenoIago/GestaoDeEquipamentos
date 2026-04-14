using GestaoDeEquipamentos.ConsoleApp.Dominio;
using GestaoDeEquipamentos.ConsoleApp.Infraestrutura;

namespace GestaoDeEquipamento.ConsoleApp.Apresentacao;

public class TelaEquipamento
{
    public RepositorioEquipamento repositorioEquipamento;
    public string? ObterEscolhaDoMenuPrincipal()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Gestão de Equipamentos");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("1 - Cadastrar equipamento");
        Console.WriteLine("2 - Editar equipamento");
        Console.WriteLine("3 - Excluir equipamento");
        Console.WriteLine("4 - Visualizar equipamentos");
        Console.WriteLine("S - Sair");
        Console.WriteLine("---------------------------------");
        Console.Write("> ");
        string? opcaoMenu = Console.ReadLine()?.ToUpper();

        return opcaoMenu;
    }
    public void Cadastrar()
    {
        ExibirCabecalho("Cadastro de Equipamento");

        Equipamento novoEquipamento = ObterDadosCadastrais();

        repositorioEquipamento.Cadastrar(novoEquipamento);

        Console.WriteLine("---------------------------------");
        Console.WriteLine($"O registro \"{novoEquipamento.id}\" foi cadastrado com sucesso.");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Digite ENTER para continuar...");
        Console.ReadLine();
    }

    public void Editar()
    {
        ExibirCabecalho("Edição de Equipamentos");

        VisualizarTodos(false);
        
        string? idSelecionado;

        do
        {
            System.Console.Write("Digite o id do equipamento que deseja editar: ");
            idSelecionado = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(idSelecionado) && idSelecionado.Length == 7)
                break;
            
        } while (true);
 
        Equipamento novoEquipamento = new Equipamento();

        do
        {
            System.Console.WriteLine("Digite o nome do equipamento: ");
            novoEquipamento.nome = Console.ReadLine();
    
            if (string.IsNullOrWhiteSpace(novoEquipamento.nome) && novoEquipamento.nome.Length > 3)
            {
                break;
            }
        } while (true);

        do
        {
            System.Console.WriteLine("Digite o fabricante do equipamento: ");
            novoEquipamento.fabricante = Console.ReadLine();
    
            if (!string.IsNullOrWhiteSpace(novoEquipamento.fabricante) && novoEquipamento.fabricante.Length >= 2)
            {
                break;
            }
        } while (true);

        System.Console.WriteLine("Digite o preço de aquisição do equipamento: ");
        novoEquipamento.precoAquisicao = Convert.ToDecimal(Console.ReadLine());

        System.Console.WriteLine("Digite a data de fabricação do equipamento: ");
        novoEquipamento.dataFabricacao = Convert.ToDateTime(Console.ReadLine());

        bool conseguiuEditar = repositorioEquipamento.Editar(idSelecionado, novoEquipamento);

        
        if(!conseguiuEditar)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Não foi possível encontrar o equipamento selecionado");
            Console.WriteLine("---------------------------------");
            Console.Write($"Digite ENTER para continuar...");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("---------------------------------");
        Console.WriteLine($"O registro \"{idSelecionado}\" foi editado com sucesso!");
        Console.WriteLine("---------------------------------");
        Console.Write($"Digite ENTER para continuar...");
        Console.ReadLine();
    }
    public void Excluir()
    {
        ExibirCabecalho("Exclusão de Equipamentos");

        VisualizarTodos(false);
        
        string? idSelecionado;

        do
        {
            System.Console.Write("Digite o id do equipamento que deseja excluir: ");
            idSelecionado = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(idSelecionado) && idSelecionado.Length == 7)
                break;
            
        } while (true);

            bool conseguiuExcluir = repositorioEquipamento.Excluir(idSelecionado);

            if (conseguiuExcluir)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine($"O registro \"{idSelecionado}\" foi excluído com sucesso!");
                Console.WriteLine("---------------------------------");
                Console.Write($"Digite ENTER para continuar...");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Não foi possível encontrar o registro \"{idSelecionado}\".");
                Console.WriteLine("---------------------------------");
                Console.Write($"Digite ENTER para continuar...");
                Console.ReadLine();
        }
    }
    
    public void VisualizarTodos(bool deveExibirCabecalho)
    {
        if (deveExibirCabecalho)
            ExibirCabecalho("Vizualização de Equipamentos");

        System.Console.WriteLine(
            "{0, -7} | {1, -15} | {2, -15} | {3, -22} | {4, 10}",
            "Id", "Nome", "Fabricante", "Preço de Aquisição", "Data de Fabricação"
        );

        Equipamento?[] equipamentos = repositorioEquipamento.SelecionarTodos();

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

        if (deveExibirCabecalho)
        {
        Console.WriteLine("---------------------------------");
        Console.Write($"Digite ENTER para continuar...");
        Console.ReadLine();
        }   
        
        Console.WriteLine("---------------------------------");
    }
    
    public void ExibirCabecalho(string titulo)
    {
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Gestão de Equipamentos");
        Console.WriteLine("---------------------------------");
        Console.WriteLine(titulo);
        Console.WriteLine("---------------------------------");
    }

    public Equipamento ObterDadosCadastrais()
    {
        Equipamento novoEquipamento = new Equipamento();

        do
        {
            Console.Write("Digite o nome do equipamento: ");
            novoEquipamento.nome = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(novoEquipamento.nome) &&
                novoEquipamento.nome.Length >= 3)
            {
                break;
            }

        } while (true);

        do
        {
            Console.Write("Digite o fabricante do equipamento: ");
            novoEquipamento.fabricante = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(novoEquipamento.fabricante) &&
                novoEquipamento.fabricante.Length > 2)
            {
                break;
            }

        } while (true);

        Console.Write("Digite o preço de aquisição do equipamento: ");
        novoEquipamento.precoAquisicao = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite a data de fabricação do equipamento: ");
        novoEquipamento.dataFabricacao = Convert.ToDateTime(Console.ReadLine());

        return novoEquipamento;
    }
}
