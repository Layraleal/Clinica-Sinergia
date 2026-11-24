
using System;
using System.Collections.Generic;

public static class Agendamento
{
    public static void Agendar(
        List<Consulta> consultas,
        Consulta? consultaSelecionada = null)
    {
        Consulta? consulta = consultaSelecionada;

        // Se não veio da busca, solicita a especialidade
        if (consulta == null)
        {
            Console.WriteLine("Especialidades disponíveis:");

            foreach (Consulta c in consultas)
            {
                Console.WriteLine($"- {c.Especialidade}");
            }

            Console.WriteLine();

            while (consulta == null)
            {
                Console.Write("Especialidade: ");
                string especialidade = Console.ReadLine()?.Trim() ?? "";

                consulta = Busca.Buscar(consultas, especialidade);

                if (consulta == null)
                {
                    Console.WriteLine(
                        "Especialidade não encontrada. Tente novamente.");
                }
            }
        }
        else
        {
            // Especialidade já encontrada na busca
            Console.WriteLine(
                $"Especialidade: {consulta.Especialidade}");
        }

        Console.WriteLine();

        // Nome do paciente
        Console.Write("Nome do paciente: ");
        string nome = Console.ReadLine()?.Trim() ?? "";

        if (nome == "")
        {
            Console.WriteLine("Nome obrigatório.");
            return;
        }

        // Horários disponíveis
        string[] horarios = { "08:00", "09:00", "10:00" };

        Console.WriteLine();
        Console.WriteLine("Horários disponíveis:");

        for (int i = 0; i < horarios.Length; i++)
        {
            Console.WriteLine($"{i + 1} - {horarios[i]}");
        }

        Console.WriteLine();

        // Repete até escolher um horário válido
        int opcao = 0;

        while (opcao < 1 || opcao > horarios.Length)
        {
            Console.Write("Escolha um horário: ");

            if (!int.TryParse(Console.ReadLine(), out opcao)
                || opcao < 1
                || opcao > horarios.Length)
            {
                Console.WriteLine(
                    "Horário inválido. Tente novamente.");
            }
        }

        // Limpa a tela e mostra a confirmação
        Console.Clear();

        Console.WriteLine("===== AGENDAMENTO REALIZADO =====");
        Console.WriteLine();
        Console.WriteLine($"Paciente: {nome}");
        Console.WriteLine($"Especialidade: {consulta.Especialidade}");
        Console.WriteLine($"Horário: {horarios[opcao - 1]}");

        Console.WriteLine();
        Console.WriteLine("Agendamento realizado con sucesso!");
    }
}
