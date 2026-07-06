namespace LaçoDeRepetição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Exemplo FOR ----");
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine($"Numero {i}");
            }

            Console.WriteLine("----- Exemplo de WHILE -----");
            int contador = 1;
            while (contador <= 10) ;
            {
                Console.WriteLine($"Contador {contador}");
                contador++;
            }
            Console.WriteLine("");

            Console.WriteLine("---- Exemplo do DO WHILE ----");
            int contadorDoWhile = 1;

            do
            {
                Console.WriteLine($"contadorDoWhile {contadorDoWhile}");
                contadorDoWhile++;
            }
            while (contadorDoWhile <= 15);
        }
    }
}
