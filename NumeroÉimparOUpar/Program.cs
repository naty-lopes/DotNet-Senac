namespace NumeroÉimparOUpar
{
    internal class Program
    {

        }
     namespace NumeroEImparOuPar
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Digite um número: ");

                try
                {
                    int numero = Convert.ToInt32(Console.ReadLine());

                    if (numero % 2 == 0)
                    {
                        Console.WriteLine("O número é PAR.");
                    }
                    else
                    {
                        Console.WriteLine("O número é ÍMPAR.");
                    }
                }
                catch
                {
                    Console.WriteLine("Valor inválido! Digite apenas números.");
                }

                Console.WriteLine("\nPressione qualquer tecla para sair...");
                Console.ReadKey();
            }
        }
    }
}