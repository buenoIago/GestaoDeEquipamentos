using System;

namespace GestaoDeEquipamentos.ConsoleApp.Dominio;

/*
• Deve ter um identificador único (id);
• Deve ter o nome do fabricante;
• Deve ter o email do fabricante;
• Deve ter o telefone do fabricante;
*/

public class Fabricante
{
    public string id;
    public string nome;
    public string email;
    public decimal telefone;
    public Equipamento equipamento;
    public Equipamento fabricante;
}
