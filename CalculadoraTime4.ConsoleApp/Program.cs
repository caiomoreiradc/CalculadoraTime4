using System;
using System.Collections.Generic;

namespace CalculadoraTime4.ConsoleApp
{
    internal class Program
    {
        static List<string> historico = new List<string>();

        static void Main(string[] args)
        {
            while (true)
            {
                string opcao = MostrarMenu();

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    break;

                if (opcao == "1")
                    Adicao();

                else if (opcao == "2")
                    Subtrair();

                else if (opcao == "3")
                    Multiplicar();

                else if (opcao == "4")
                    Dividir();

                else if (opcao == "5")
                    Tabuada();

                else if (opcao == "6")
                    MostrarHistorico();

                else
                    Console.WriteLine("Opção inválida!");

                Console.ReadKey();
            }
        }

        static void Adicao()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Digite o primeiro número: ");
            double primeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double segundoNumero = Convert.ToDouble(Console.ReadLine());

            double result = primeiroNumero + segundoNumero;
            string operation = $"{primeiroNumero} + {segundoNumero} = {result}";

            historico.Add(operation);

            Console.WriteLine($"O resultado da soma é: {result}");
        }
        static void Subtrair()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Digite o primeiro número: ");
            double primeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double segundoNumero = Convert.ToDouble(Console.ReadLine());

            double result = primeiroNumero - segundoNumero;
            string operation = $"{primeiroNumero} - {segundoNumero} = {result}";

            historico.Add(operation);

            Console.WriteLine($"O resultado da subtração é: {result}");
        }
        static void Multiplicar()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Digite o primeiro número: ");
            double primeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double segundoNumero = Convert.ToDouble(Console.ReadLine());

            double result = primeiroNumero * segundoNumero;
            string operation = $"{primeiroNumero} * {segundoNumero} = {result}";

            historico.Add(operation);

            Console.WriteLine($"O resultado da multiplicação é: {result}");
        }
        static void Dividir()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Digite o primeiro número: ");
            double primeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double segundoNumero = Convert.ToDouble(Console.ReadLine());

            double result = primeiroNumero / segundoNumero;
            string operation = $"{primeiroNumero} / {segundoNumero} = {result}";

            historico.Add(operation);

            Console.WriteLine($"O resultado da divisão é: {result}");
        }
        static void Tabuada()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Digite um número para gerar a tabuada: ");
            int tabuada = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int multiplicacao = tabuada * i;

                Console.WriteLine($"{tabuada} x {i} = {multiplicacao}");
            }
        }
        static void MostrarHistorico()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Histórico de operações:");

            foreach (string operation in historico)
            {
                Console.WriteLine(operation);
            }
        }
        static string MostrarMenu()
        {
            Console.Title = "Calculadora do Grupo 4 - https://github.com/caiomoreiradc/CalculadoraTime4/";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("==========================");
            Console.WriteLine("    Calculadora Time 4");
            Console.WriteLine("==========================");

            Console.WriteLine("1-ADIÇÃO");
            Console.WriteLine("2-SUBTRAÇÃO");
            Console.WriteLine("3-MULTIPLICAÇÃO");
            Console.WriteLine("4-DIVISÃO");
            Console.WriteLine("5-TABUADA");
            Console.WriteLine("6-HISTÓRICO DE OPERAÇÕES");
            Console.WriteLine("S-SAIR");
            Console.WriteLine("==========================");

            string operacao = Console.ReadLine();

            return operacao;
        }
    }
}
