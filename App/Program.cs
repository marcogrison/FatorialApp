class Program
{
    static void Main()
    {
        Console.WriteLine("Bem-vindo ao calculador de fatorial!");

        int numero;
        bool entradaValida = false;

        do
        {
            Console.Write("Digite um número inteiro não negativo: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out numero) && numero >= 0)
            {
                entradaValida = true;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Certifique-se de inserir um número inteiro não negativo.");
            }

        } while (!entradaValida);

        long fatorial = CalcularFatorial(numero);

        Console.WriteLine($"O fatorial de {numero} é {fatorial}.");
    }

    static long CalcularFatorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            long resultado = 1;
            for (int i = 2; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
}
