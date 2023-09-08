using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> CEPs = new List<int>();
        List<double> orcamentos = new List<double>();
        List<int> status = new List<int>();

        for (int a = 0; a < 3; a++)
        {
            Console.WriteLine("Digite o CEP da casa a ser atendida:");
            int CEP = Convert.ToInt32(Console.ReadLine());
            CEPs.Add(CEP);

            Console.WriteLine("Digite o valor do orçamento:");
            double orcamento = Convert.ToDouble(Console.ReadLine());
            orcamentos.Add(orcamento);

            Console.WriteLine("Digite o status do atendimento (0 - Não realizado, 1 - Realizado):");
            int statusAtendimento = Convert.ToInt32(Console.ReadLine());
            status.Add(statusAtendimento);
        }

        int opcao = 0;
        while (opcao != 4)
        {
            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Listar atendimentos agendados");
            Console.WriteLine("2. Calcular a soma do dinheiro recebido pelo chaveiro");
            Console.WriteLine("3. Encontrar o CEP do orçamento mais caro e o mais barato");
            Console.WriteLine("4. Sair do programa");

            Console.WriteLine("Digite a opção:");
            opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
                for (int a = 0; a < 3; a++)
                {
                    Console.WriteLine($"CEP: {CEPs[a]}, Orçamento: {orcamentos[a]}");
                }
            }
            else if (opcao == 2)
            {
                double total = 0;
                for (int a = 0; a < 3; a++)
                {
                    if (status[a] == 1)
                    {
                        total += orcamentos[a];
                    }
                }
                Console.WriteLine($"A soma do dinheiro recebido pelo chaveiro é: {total}");
            }
            else if (opcao == 3)
            {
                double orcamentoMin = orcamentos[0];
                double orcamentoMax = orcamentos[0];
                int cepMin = CEPs[0];
                int cepMax = CEPs[0];

                for (int a = 1; a < 3; a++)
                {
                    if (orcamentos[a] < orcamentoMin)
                    {
                        orcamentoMin = orcamentos[a];
                        cepMin = CEPs[a];
                    }
                    if (orcamentos[a] > orcamentoMax)
                    {
                        orcamentoMax = orcamentos[a];
                        cepMax = CEPs[a];
                    }
                }

                Console.WriteLine($"CEP do orçamento mais barato: {cepMin}, valor: {orcamentoMin}");
                Console.WriteLine($"CEP do orçamento mais caro: {cepMax}, valor: {orcamentoMax}");
            }
            else if (opcao == 4)
            {
                Console.WriteLine("Programa encerrado.");
            }
        }
    }
}