using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using GestaoDeEquipamentos.ConsoleApp;
using GestaoDeEquipamentos.ConsoleApp.Dominio;
using GestaoDeEquipamento.ConsoleApp.Apresentacao;
using GestaoDeEquipamentos.ConsoleApp.Apresentacao;
using GestaoDeEquipamentos.ConsoleApp.Infraestrutura;

RepositorioEquipamento repositorioEquipamento =  new RepositorioEquipamento();
RepositorioChamado repositorioChamado = new RepositorioChamado();
repositorioFabricante repositorioFabricante = new repositorioFabricante();

TelaFabricante telaFabricante = new TelaFabricante();
telaFabricante.repositorioFabricante = repositorioFabricante;
telaFabricante.RepositorioEquipamento = repositorioEquipamento;


TelaEquipamento telaEquipamento = new TelaEquipamento();
telaEquipamento.repositorioEquipamento = repositorioEquipamento;

TelaChamado telachamado = new TelaChamado();
telachamado.repositorioChamado = repositorioChamado;
telachamado.repositorioEquipamento = repositorioEquipamento;


while (true)
{
    Console.Clear();
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Gestão de Equipamentos");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("1 - Gerenciar equipamentos");
    Console.WriteLine("2 - Gerenciar chamados");
    Console.WriteLine("3 - Gerenciar fabricantes");
    Console.WriteLine("S - Sair");
    Console.WriteLine("---------------------------------");
    Console.Write("> ");
    string? opcaoMenuPrincipal = Console.ReadLine()?.ToUpper();

    if (opcaoMenuPrincipal == "S")
    {
        Console.Clear();
        break;
    }

    while (true)
    {
        if(opcaoMenuPrincipal == "1")
        {
            string? opcaoMenu = telaEquipamento.ObterEscolhaDoMenuPrincipal();

            if (opcaoMenu == "S")
            {
                Console.Clear();
                break;
            }

            if (opcaoMenu == "1")
                telaEquipamento.Cadastrar();

            else if (opcaoMenu == "2")
                telaEquipamento.Editar();

            else if (opcaoMenu == "3")
                telaEquipamento.Excluir();

            else if (opcaoMenu == "4")
                telaEquipamento.VisualizarTodos(deveExibirCabecalho: true);

        }
        
        else if (opcaoMenuPrincipal == "2")
        {
            string? opcaoMenu = telachamado.ObterEscolhaMenuPrincipal();

            if (opcaoMenu == "S")
            {
                Console.Clear();
                break;
            }

            if (opcaoMenu == "1")
                telachamado.Cadastrar();
            
            else if (opcaoMenu == "2")
                telachamado.Editar();

            else if (opcaoMenu == "3")
                telachamado.Excluir();

            else if (opcaoMenu == "4")
                telachamado.VisualizarTodos(deveExibirCabecalho: true);
        }
        if(opcaoMenuPrincipal == "3")
        {
            string? opcaoMenu = telaFabricante.ObterEscolhaMenuPrincipal();

            if (opcaoMenu == "S")
            {
                Console.Clear();
                break;
            }

            if (opcaoMenu == "1")
                telaFabricante.Cadastrar();

            else if (opcaoMenu == "2")
                telaFabricante.Editar();

            else if (opcaoMenu == "3")
                telaFabricante.Excluir();

            else if (opcaoMenu == "4")
                telaFabricante.VisualizarTodos(deveExibirCabecalho: true);
        }
    }
}
