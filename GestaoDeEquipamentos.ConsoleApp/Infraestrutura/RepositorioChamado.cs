using System;
using System.Security.Cryptography;
using GestaoDeEquipamentos.ConsoleApp.Dominio;

namespace GestaoDeEquipamentos.ConsoleApp.Infraestrutura;

public class RepositorioChamado
{
    public Chamado?[] chamados =  new Chamado[100];

    public void Cadastrar(Chamado novoChamado)
    {
        novoChamado.id = 
        Convert.ToHexString(RandomNumberGenerator.GetBytes(20))
        .ToLower()
        .Substring(0,7);
        
        for (int i = 0; i < chamados.Length; i++)
        {
            Chamado? c = chamados[i];
            
            if(c == null)
            {
                chamados[i] = novoChamado;
                break;
            }
        }
    }
    public bool Editar(string idSelecionado, Chamado novoChamado)
    {
        Chamado? chamadoSelecionado = SelecionarPorId(idSelecionado);

        if(chamadoSelecionado == null)
        return false;

        chamadoSelecionado.titulo = novoChamado.titulo;
        chamadoSelecionado.equipamento = novoChamado.equipamento;
        chamadoSelecionado.descricao = novoChamado.descricao;
        chamadoSelecionado.dataAbertura = novoChamado.dataAbertura;

        return true;
    }
    public Chamado? SelecionarPorId(string idSelecionado)
    {
        Chamado? chamadoSelecionado = null;

        for(int i = 0; i < chamados.Length; i++)
        {
            Chamado? c = chamados[i];

            if (c == null)
                continue;

            if (c.id == idSelecionado)
            {
                chamadoSelecionado = c;
                break;
            }
        }

        return chamadoSelecionado;
    }

    public Chamado?[] SelecionarTodos()
    {
        return chamados;
    }
}