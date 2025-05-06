namespace TrabalhoDiamanteX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static void Menu ()
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
