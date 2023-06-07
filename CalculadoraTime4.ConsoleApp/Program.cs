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