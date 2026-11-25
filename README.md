# Clínica Médica Sinergia

## Resumo do projeto

A Clínica Médica Sinergia é um projeto acadêmico desenvolvido em **C# com a plataforma .NET 10**, para a disciplina de Algoritmos e Estrutura de Dados II, do curso de Engenharia de Software.

O sistema funciona pelo terminal e simula o gerenciamento de consultas médicas, permitindo visualizar especialidades, buscar consultas, ordenar preços, selecionar consultas e realizar agendamentos demonstrativos.

O projeto utiliza uma estrutura de dados linear (`List<Consulta>`) e aplica três algoritmos: **Busca Linear**, **Selection Sort** e **Seleção por Comparação**, cada um com dois parâmetros, conforme os requisitos da disciplina.

## Funcionalidades

- Listagem das consultas e seus preços.
- Busca de consultas por especialidade.
- Ordenação das consultas por preço.
- Seleção da consulta mais barata ou mais cara.
- Agendamento simplificado com escolha de especialidade e horário.
- Validação das opções informadas pelo usuário.

## Algoritmos utilizados

Os algoritmos foram implementados sobre a estrutura de dados linear `List<Consulta>`:

- **Busca Linear:** pesquisa consultas pelo nome da especialidade.
- **Selection Sort:** organiza as consultas por preço, em ordem crescente ou decrescente.
- **Seleção por Comparação:** identifica a consulta de menor ou maior preço.

Cada algoritmo recebe dois parâmetros, conforme solicitado na disciplina.

## Tecnologias utilizadas

- C#
- .NET 10
- Aplicação Console

## Como executar

Com o SDK do .NET 10 instalado, abra o terminal na pasta do projeto e execute:

`dotnet run`

## Integrantes

- Layra Vitória Mota Leal
- Sarah Patez Gonçalves dos Santos
