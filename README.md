# Controle de Equipamentos

## Projeto

Este projeto foi desenvolvido em C# com execução via Console, com o objetivo de simular um sistema de gerenciamento de equipamentos.

O sistema permite realizar operações como cadastro, edição, exclusão e visualização de equipamentos e chamados de manutenções, aplicando conceitos fundamentais de programação orientada a objetos e regras de negócio para controle de inventário.

Desenvolvido por **Iago** durante o curso Fullstack da [Academia do Programador](https://www.academiadoprogramador.net) 2026.

## Introdução:

**O projeto foi separado em 3 partes, com 4 requisitos cada.**

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

#### Requisito 2.1:

Como funcionário, Junior deseja ter a opção de cadastrar chamados de manutenção para os equipamentos.

Deve possuir um identificador único (id);
Deve conter um título para o chamado;
Deve conter uma descrição do chamado;
Deve estar vinculado a um equipamento cadastrado;
Deve registrar a data de abertura;

#### Requisito 2.2:

Como funcionário, Junior deseja poder visualizar todos os chamados cadastrados no sistema.

Deve exibir o título do chamado;
Deve exibir o equipamento vinculado;
Deve exibir a data de abertura;
Deve exibir a quantidade de dias que o chamado está em aberto;

#### Requisito 2.3:

Como funcionário, Junior deseja poder editar um chamado cadastrado, podendo alterar todos os seus dados.

Deve permitir a edição de todos os campos;
Deve seguir os mesmos critérios definidos no Requisito 2.1;

#### Requisito 2.4:

Como funcionário, Junior deseja ter a opção de remover um chamado cadastrado.

Deve permitir a exclusão do chamado pelo identificador (id);
Deve remover o chamado da lista de registros;

📌 Controle de Fabricantes
#### Requisito 3.1:

Como funcionário, Junior deseja ter a opção de cadastrar fabricantes dos equipamentos.

Deve possuir um identificador único (id);
Deve conter o nome do fabricante;
Deve conter o email do fabricante;
Deve conter o telefone do fabricante;

#### Requisito 3.2:

Como funcionário, Junior deseja poder visualizar todos os fabricantes cadastrados no sistema.

Deve exibir o nome do fabricante;
Deve exibir o email do fabricante;
Deve exibir o telefone do fabricante;
Deve exibir a quantidade de equipamentos vinculados ao fabricante;

#### Requisito 3.3:

Como funcionário, Junior deseja poder editar um fabricante cadastrado, podendo alterar todos os seus dados.

Deve permitir a edição de todos os campos;
Deve seguir os mesmos critérios definidos no Requisito 3.1;

#### Requisito 3.4:

Como funcionário, Junior deseja ter a opção de remover um fabricante cadastrado.

Deve permitir a exclusão do fabricante pelo identificador (id);
Deve remover o fabricante da lista de registros;

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