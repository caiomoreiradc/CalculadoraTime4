namespace CalculadoraTime4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string opcao = MostrarMenu();

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    break;

                if (opcao == "1")
                    Adicao();

                if (opcao == "2")
                    Subtrair();

                else if (opcao == "3")
                    Multiplicar();

                //if (funçãodaopçãoinvalida(opcao))
                    //cw "opção invalida"

                //else if (opcao == "5")
                    //TABUADA

                //else if (opcao == "6")
                    //VISUALIZAR OPERAÇÕES

                //else
                    //FunçãodeFazerOperação(opcao);
            }

            //teste
        }

        static void Adicao()
        {
            Console.Clear();

            Console.Write("Digite o primeiro número: ");
            double primeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double segundoNumero = Convert.ToDouble(Console.ReadLine());

            double result = primeiroNumero + segundoNumero;

            Console.WriteLine($"O resultado da soma é: {result}");

            Console.ReadKey();
        }        
        
        static void Subtrair()
        {
            Console.Clear();

            Console.Write("Digite o primeiro número: ");
            double primeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double segundoNumero = Convert.ToDouble(Console.ReadLine());

            double result = primeiroNumero - segundoNumero;

            Console.WriteLine($"O resultado da subtração é: {result}");

            Console.ReadKey();
        }

        static void Multiplicar()
        {
            Console.Clear();

            Console.Write("Digite o primeiro número: ");
            double primeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double segundoNumero = Convert.ToDouble(Console.ReadLine());

            double result = primeiroNumero * segundoNumero;

            Console.WriteLine($"O resultado da multiplicação é: {result}");

            Console.ReadKey();
        }

        static string MostrarMenu()
        {
            Console.Clear();

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