# Controle de Equipamentos

## Projeto

Este projeto foi desenvolvido em C# com execução via Console, com o objetivo de simular um sistema de gerenciamento de equipamentos.

O sistema permite realizar operações como cadastro, edição, exclusão e visualização de equipamentos e chamados de manutenções, aplicando conceitos fundamentais de programação orientada a objetos e regras de negócio para controle de inventário.

Desenvolvido por **Iago** durante o curso Fullstack da [Academia do Programador](https://www.academiadoprogramador.net) 2026

## Introdução:

**O projeto foi separado em 4 requisitos**

#### Requisito 1.1:

Como funcionário, Junior deseja ter a opção de cadastrar equipamentos.

Deve possuir um identificador único (id);
Deve conter um nome com no mínimo 6 caracteres;
Deve incluir o preço de aquisição;
Deve conter o nome da fabricante;
Deve registrar a data de fabricação;

#### Requisito 1.2:

Como funcionário, Junior deseja poder visualizar todos os equipamentos cadastrados no inventário.

Deve exibir o id;
Deve exibir o nome;
Deve exibir o preço de aquisição;
Deve exibir a fabricante;
Deve exibir a data de fabricação;

#### Requisito 1.3:

Como funcionário, Junior deseja poder editar um equipamento, tendo a possibilidade de alterar todos os seus dados.

Deve seguir os mesmos critérios definidos no Requisito 1.1.

#### Requisito 1.4:

Como funcionário, Junior deseja ter a opção de remover um equipamento cadastrado.

A listagem de equipamentos deve ser atualizada após a exclusão.

## Como utilizar

1. Clone o repositório ou baixe o código fonte.
2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as dependências do projeto.

   ```bash
   dotnet restore
   ```

4. Para executar o projeto compilando em tempo real

   ```bash
   dotnet run --project GestaoDeEquipamentos.ConsoleApp
   ```

## Requisitos

- .NET 10.0 SDK