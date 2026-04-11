using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using GestaoDeEquipamentos.ConsoleApp;
using GestaoDeEquipamentos.ConsoleApp.Dominio;
using GestaoDeEquipamento.ConsoleApp.Apresentacao;

// Arquitetura 3 camadas
// Apresentação / Interface
// Infraestrura 
// Domínio / Regra do negócio

Equipamento?[] equipamentos =  new Equipamento[100];
TelaEquipamento telaEquipamento = new TelaEquipamento();

while (true)
{
    string? opcaoMenu = telaEquipamento.ObterEscolhaDoMenuPrincipal();

    if (opcaoMenu == "S")
    {
        Console.Clear();
        break;
    }

    if (opcaoMenu == "1")
    {
        telaEquipamento.Cadastrar(equipamentos);
    }

    else if (opcaoMenu == "2")
    {
        telaEquipamento.Editar(equipamentos);
    }

    else if (opcaoMenu == "3")
    {
        telaEquipamento.Excluir(equipamentos);
    }

    else if (opcaoMenu == "4")
    {
        telaEquipamento.VisualizarTodos(equipamentos);
    }
}