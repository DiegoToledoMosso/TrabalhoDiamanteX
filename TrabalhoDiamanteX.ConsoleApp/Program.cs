using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TrabalhoDiamanteX.ConsoleApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Menu();

            int numero = 0;

            while (true)
            {
                do
                {
                    Console.WriteLine("Forneça um número impar.");
                    Console.WriteLine();
                    numero = Convert.ToInt32(Console.ReadLine());

                    if (numero % 2 == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Número inválido! Por favor, digite um número ímpar.");
                        Console.WriteLine();
                    }

                } while (numero % 2 == 0);

                DesenharDiamante(numero);

                string opcaoContinuar = MenuContinuar();
                if (opcaoContinuar != "S")
                    break;

            }

        }


        static void Menu()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Olá, Bem-vindo ao Diamante de X");
            Console.WriteLine("---------------------------------");
        }

        static void DesenharDiamante(int tamanho)
        {
            int meio = tamanho / 2;

            for (int i = 0; i < tamanho; i++)
            {
                int distancia = Math.Abs(meio - i);
                int xis = tamanho - (distancia * 2);
                int espacos = distancia;


                Console.Write(new string(' ', espacos));
                Console.Write(new string('X', xis));
                Console.WriteLine();
            }
        }

        static string MenuContinuar()
        {
            Console.WriteLine();
            Console.WriteLine("Deseja continuar? (S/N) ");
            string opcaoContinuar = Console.ReadLine()!.ToUpper();
            Console.WriteLine();

            return opcaoContinuar;
        }



    }
}