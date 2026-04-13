using System;
using System.Security.Cryptography;
using GestaoDeEquipamentos.ConsoleApp.Dominio;

namespace GestaoDeEquipamentos.ConsoleApp.Infraestrutura;

public class repositorioFabricante
{
    public Fabricante?[] fabricantes = new Fabricante[100];

    public void Cadastrar(Fabricante novoFabricante)
    {
        novoFabricante.id = 
        Convert.ToHexString(RandomNumberGenerator.GetBytes(20))
        .ToLower()
        .Substring(0,7);
        
        for (int i = 0; i < fabricantes.Length; i++)
        {
            Fabricante? f = fabricantes[i];
            
            if(f == null)
            {
                fabricantes[i] = novoFabricante;
                break;
            }
        }
    }
    
    public Fabricante? SelecionarPorId(string idSelecionado)
    {
        Fabricante? fabricanteSelecionado = null;

        for(int i = 0; i < fabricantes.Length; i++)
        {
            Fabricante? f = fabricantes[i];

            if (f == null)
                continue;

            if (f.id == idSelecionado)
            {
                fabricanteSelecionado = f;
                break;
            }
        }

        return fabricanteSelecionado;
    }
    public Fabricante?[] SelecionarTodos()
    {
        return fabricantes;
    }
}
