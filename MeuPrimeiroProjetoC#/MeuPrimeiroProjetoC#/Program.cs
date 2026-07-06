namespace MeuPrimeiroProjetoC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Meu nome é Nathaly!");

            int idade = 17;
            string nome = "Nathaly";
            string sobrenome = "Sisnande";
            bool ehaluno = true;
            double altura = 1.64;

            //Console.WriteLine($"Meu nome é {nome} {sobrenome}.");
            //Console.WriteLine($"Tenho {idade} anos de idade. ");
            //Console.WriteLine($"Sou aluno: {ehaluno}");
            // Console.WriteLine($"Tenho {altura} de altura");

            string nomeCompleto = ObterNomeCompleto(nome, sobrenome);
            Console.WriteLine($"Meu nome é {nomeCompleto}");
        }

        static string ObterNomeCompleto(string nome, string sobrenome)
        {
            return $"{nome} {sobrenome}";
        }

        static voi
    }
}