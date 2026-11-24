
using System;
using System.Collections.Generic;

List<Consulta> consultas = new()
{
    new Consulta("Clínica Geral", 120m),
    new Consulta("Cardiologia", 220m),
    new Consulta("Dermatologia", 180m),
    new Consulta("Pediatria", 150m)
};

LimparTela();
Console.WriteLine("Bem-vindo à Clínica Médica Sinergia!");
Pausar();

while (true)
{
    LimparTela();

    Console.WriteLine("===== CLÍNICA SINERGIA =====");
    Console.WriteLine("1 - Início");
    Console.WriteLine("2 - Consultas");
    Console.WriteLine("3 - Agendamento");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha: ");

    string? opcao = Console.ReadLine();
    LimparTela();

    switch (opcao)
    {
        case "1":
            break;

        case "2":
            MenuConsultas();
            break;

        case "3":
            Console.WriteLine("===== AGENDAMENTO =====\n");

            Agendamento.Agendar(consultas);

            Pausar();
            LimparTela();
            break;

        case "0":
            return;

        default:
            Console.WriteLine("Opção inválida.");
            Pausar();
            break;
    }
}

void MostrarConsultas()
{
    foreach (Consulta consulta in consultas)
    {
        Console.WriteLine(
            $"{consulta.Especialidade} - R$ {consulta.Preco:F2}");
    }
}

void MenuConsultas()
{
    while (true)
    {
        LimparTela();

        Console.WriteLine("===== CONSULTAS =====");
        Console.WriteLine("1 - Listar consultas");
        Console.WriteLine("2 - Buscar consulta");
        Console.WriteLine("3 - Ordenar por preço");
        Console.WriteLine("4 - Selecionar consulta");
        Console.WriteLine("0 - Voltar");
        Console.Write("Escolha: ");

        string? opcao = Console.ReadLine();
        LimparTela();

        switch (opcao)
        {
            case "1":
            {
                Console.WriteLine("===== CONSULTAS DISPONÍVEIS =====");
                Console.WriteLine();

                MostrarConsultas();

                Console.WriteLine();
                Console.WriteLine("1 - Agendar consulta");
                Console.WriteLine("0 - Voltar ao menu principal");
                Console.Write("Escolha: ");

                string? escolhaLista = Console.ReadLine();

                if (escolhaLista == "1")
                {
                    LimparTela();

                    Console.WriteLine("===== AGENDAMENTO =====\n");

                    Agendamento.Agendar(consultas);

                    Pausar();
                    LimparTela();
                    return;
                }

                if (escolhaLista == "0")
                {
                    return;
                }

                Console.WriteLine("Opção inválida.");
                break;
            }

            case "2":
            {
                Console.WriteLine("===== BUSCAR CONSULTA =====");
                Console.WriteLine();

                Console.Write("Especialidade para buscar: ");
                string nome = Console.ReadLine()?.Trim() ?? "";

                Consulta? resultado = Busca.Buscar(consultas, nome);

                if (resultado == null)
                {
                    Console.WriteLine("Consulta não encontrada.");
                    break;
                }

                LimparTela();

                Console.WriteLine("===== CONSULTA ENCONTRADA =====");
                Console.WriteLine();

                Console.WriteLine(
                    $"{resultado.Especialidade} - R$ {resultado.Preco:F2}");

                Console.WriteLine();

                while (true)
                {
                    Console.WriteLine("1 - Agendar consulta");
                    Console.WriteLine("0 - Voltar ao menu principal");
                    Console.WriteLine();

                    Console.Write("Escolha: ");
                    string? escolha = Console.ReadLine();

                    if (escolha == "1")
                    {
                        LimparTela();

                        Console.WriteLine("===== AGENDAMENTO =====");
                        Console.WriteLine();

                        Agendamento.Agendar(consultas, resultado);

                        Pausar();
                        LimparTela();
                        return;
                    }

                    if (escolha == "0")
                    {
                        LimparTela();
                        return;
                    }

                    Console.WriteLine("Opção inválida. Tente novamente.");
                    Console.WriteLine();
                }
            }

            case "3":
            {
                Console.WriteLine("===== ORDENAR CONSULTAS =====");
                Console.WriteLine();

                Console.WriteLine("Qual ordem você deseja ver?");
                Console.WriteLine("1 - Menor preço");
                Console.WriteLine("2 - Maior preço");
                Console.WriteLine();

                Console.Write("Escolha: ");
                string? ordem = Console.ReadLine();

                if (ordem != "1" && ordem != "2")
                {
                    Console.WriteLine("Opção inválida.");
                    break;
                }

                Ordenacao.Ordenar(consultas, ordem == "1");

                LimparTela();

                Console.WriteLine("===== CONSULTAS ORDENADAS =====");
                Console.WriteLine();

                MostrarConsultas();
                break;
            }

            case "4":
            {
                Console.WriteLine("===== SELECIONAR CONSULTA =====");
                Console.WriteLine();

                Console.WriteLine("Qual consulta deseja selecionar?");
                Console.WriteLine();
                Console.WriteLine("1 - Mais barata");
                Console.WriteLine("2 - Mais cara");
                Console.WriteLine();

                Console.Write("Escolha: ");
                string? tipo = Console.ReadLine();

                if (tipo != "1" && tipo != "2")
                {
                    Console.WriteLine("Opção inválida.");
                    break;
                }

                Consulta? selecionada =
                    Selecao.Selecionar(consultas, tipo == "1");

                if (selecionada == null)
                {
                    Console.WriteLine("Nenhuma consulta disponível.");
                    break;
                }

                LimparTela();

                Console.WriteLine("===== CONSULTA SELECIONADA =====");
                Console.WriteLine();

                Console.WriteLine(
                    $"{selecionada.Especialidade} - R$ {selecionada.Preco:F2}");

                Console.WriteLine();

                while (true)
                {
                    Console.WriteLine("1 - Agendar consulta");
                    Console.WriteLine("0 - Voltar ao menu principal");
                    Console.WriteLine();

                    Console.Write("Escolha: ");
                    string? escolha = Console.ReadLine();

                    if (escolha == "1")
                    {
                        LimparTela();

                        Console.WriteLine("===== AGENDAMENTO =====");
                        Console.WriteLine();

                        Agendamento.Agendar(consultas, selecionada);

                        Pausar();
                        LimparTela();

                        return;
                    }

                    if (escolha == "0")
                    {
                        LimparTela();
                        return;
                    }

                    Console.WriteLine();
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    Console.WriteLine();
                }
            }

            case "0":
                return;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }

        Pausar();
    }
}

void Pausar()
{
    Console.Write("\nPressione ENTER para continuar...");
    Console.ReadLine();
}

void LimparTela()
{
    if (!Console.IsOutputRedirected)
    {
        Console.Clear();
    }
}
