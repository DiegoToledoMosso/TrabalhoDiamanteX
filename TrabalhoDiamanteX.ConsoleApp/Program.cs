using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TrabalhoDiamanteX.ConsoleApp
{
    internal class Program
    {
        /* Versão 1
         * O programa deve solicitar ao usuário um número inteiro. x
         * O número deve ser ímpar. Caso contrário, o programa deve informar que a entrada é inválida e solicitar um novo número. x
         * O número de linhas e colunas deve ser igual ao número ímpar fornecido.
         * A linha central do diamante deve conter o número máximo de Xs.
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Diamante de X");

            int numero = 0;

            do
            {
                Console.WriteLine("Forneça um número impar.");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("Número inválido! Por favor, digite um número ímpar.");
                }

            } while (numero % 2 == 0);


        }
    }
}
