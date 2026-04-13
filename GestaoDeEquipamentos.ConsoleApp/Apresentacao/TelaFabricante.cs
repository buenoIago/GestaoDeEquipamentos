using System;
using GestaoDeEquipamentos.ConsoleApp.Dominio;
using GestaoDeEquipamentos.ConsoleApp.Infraestrutura;

namespace GestaoDeEquipamentos.ConsoleApp.Apresentacao;

public class TelaFabricante
{
    public repositorioFabricante repositorioFabricante;
    public RepositorioEquipamento RepositorioEquipamento;
    public string? ObterEscolhaMenuPrincipal()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Gestão de Fabricante");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("1 - Cadastrar fabricante");
        Console.WriteLine("2 - Editar fabricante");
        Console.WriteLine("3 - Excluir fabricante");
        Console.WriteLine("4 - Visualizar fabricante");
        Console.WriteLine("5 - ");
        Console.WriteLine("S - Sair");
        Console.WriteLine("---------------------------------");
        Console.Write("> ");
        string? opcaoMenu = Console.ReadLine()?.ToUpper();

        return opcaoMenu;
    }
    public void Cadastrar()
    {
        ExibirCabecalho("Cadastro de Fabricante");

         Console.WriteLine(
            "{0, -7} | {1, -15} | {2, -15} | {3, -22} | {4, -10}",
            "Id", "nome", "Fabricante", "Email", "Telefone"
        );

        Equipamento?[] equipamentos = RepositorioEquipamento.SelecionarTodos();

        for (int i = 0; i < equipamentos.Length; i++)
        {
            Equipamento? e = equipamentos[i];

            if (e == null)
                continue;

            Console.WriteLine(
                "{0, -7} | {1, -15} | {2, -15} | {3, -22} | {4, -10}",
                e.id, e.nome, e.fabricante, e.precoAquisicao.ToString("C2"), e.dataFabricacao.ToShortDateString()
                );
        }
        Console.WriteLine("---------------------------------");

        string? idSelecionado;

        do
        {
            Console.Write("Digite o id do equipamento que deseja selecionar: ");
            idSelecionado = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(idSelecionado) && idSelecionado.Length == 7)
                break;
        } while (true);

        Equipamento? equipamentoSelecionado = RepositorioEquipamento.SelecionarPorId(idSelecionado);

        if (equipamentoSelecionado == null)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Não foi possível encontrar o equipamento informado.");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Digite ENTER para continuar...");
            Console.ReadLine();
            return;
        }

        Fabricante novoFabricante = new Fabricante();

        novoFabricante.equipamento = equipamentoSelecionado;

        do
        {
            Console.Write("Digite o nome do fabricante: ");
            novoFabricante.nome = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(novoFabricante.nome) &&
                novoFabricante.nome.Length >= 2)
            {
                break;
            }

        } while (true);

        Console.Write("Digite o Email do Fabricante: ");
        novoFabricante.email = Console.ReadLine();

        Console.Write("Digite o telefone do Fabricante: ");
        novoFabricante.telefone = Console.ReadLine();

        repositorioFabricante.Cadastrar(novoFabricante);

        Console.WriteLine("---------------------------------");
        Console.WriteLine($"O registro \"{novoFabricante.id}\" foi cadastrado com sucesso.");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Digite ENTER para continuar...");
        Console.ReadLine();
    }

    public void Editar()
    {
        ExibirCabecalho("Edição de fabricantes");

        Console.WriteLine(
            "{0, -7} | {1, -15} | {2, -15} | {3, -22} | {4, -10}",
            "Id", "Fabricante", "Nome", "Email", "Telefone"
        );

        Fabricante?[] fabricantes = repositorioFabricante.SelecionarTodos();

        for (int i = 0; i < fabricantes.Length; i++)
        {
            Fabricante? f = fabricantes[i];

            if (f == null)
                continue;

            Console.WriteLine(
                "{0, -7} | {1, -15} | {2, -15} | {3, -22} | {4, -10}",
                f.id, f.nome, f.equipamento.nome, f.email, f.telefone
                );
        }

        string? idSelecionado;

        do
        {
            System.Console.Write("Digite o id do fabricante que deseja editar: ");
            idSelecionado = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(idSelecionado) && idSelecionado.Length == 7)
                break;
            
        } while (true);

        Fabricante novoFabricante = new Fabricante();

        do
        {
            System.Console.Write("Digite o nome do fabricante: ");
            novoFabricante.nome = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(novoFabricante.nome) && novoFabricante.nome.Length > 3)
            {
                break;
            }
        } while (true);

        System.Console.Write("Digite email do fabricante: ");
        novoFabricante.email = Console.ReadLine();

        System.Console.Write("Digite o telefone do fabricante:");
        novoFabricante.telefone = Console.ReadLine();

        bool conseguiuEditar = repositorioFabricante.Editar(idSelecionado, novoFabricante);

        if(!conseguiuEditar)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Não foi possível encontrar o fabricante selecionado");
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
        ExibirCabecalho("Exclusão de Fabricante");

        Console.WriteLine(
            "{0, -7} | {1, -15} | {2, -15} | {3, -22} | {4, -10}",
            "Id", "Fabricante", "Nome", "Email", "Telefone"
        );

        Fabricante?[] fabricantes = repositorioFabricante.SelecionarTodos();

        for (int i = 0; i < fabricantes.Length; i++)
        {
            Fabricante? f = fabricantes[i];

            if (f == null)
                continue;

            Console.WriteLine(
                "{0, -7} | {1, -15} | {2, -15} | {3, -22} | {4, -10}",
                f.id, f.nome, f.equipamento.nome, f.email, f.telefone
                );
        }

        string? idSelecionado;

        do
        {
            System.Console.Write("Digite o id do fabricante que deseja excluir: ");
            idSelecionado = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(idSelecionado) && idSelecionado.Length == 7)
                break;
            
        } while (true);

        bool conseguiuExcluir = repositorioFabricante.Excluir(idSelecionado);

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

    public void VisualizarTodos()
    {
        ExibirCabecalho("Vizualização de Fabricantes");

        Console.WriteLine(
            "{0, -7} | {1, -15} | {2, -15} | {3, -22} | {4, -10}",
            "Id", "Fabricante", "Nome", "Email", "Telefone"
        );

        Fabricante?[] fabricantes = repositorioFabricante.SelecionarTodos();

        for (int i = 0; i < fabricantes.Length; i++)
        {
            Fabricante? f = fabricantes[i];

            if (f == null)
                continue;

            Console.WriteLine(
                "{0, -7} | {1, -15} | {2, -15} | {3, -22} | {4, -10}",
                f.id, f.nome, f.equipamento.nome, f.email, f.telefone
                );
        }

        Console.WriteLine("---------------------------------");
        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
    }

    public void ExibirCabecalho(string titulo)
    {
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Gestão de Fabricantes");
        Console.WriteLine("---------------------------------");
        Console.WriteLine(titulo);
        Console.WriteLine("---------------------------------");
    }
}
