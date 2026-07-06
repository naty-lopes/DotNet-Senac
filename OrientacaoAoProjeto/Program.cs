namespace OrientacaoAoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa(
                "Jae",
               new DateTime (2000, 7, 20),
                1.75,
                "06657253045",
                true );

            Console.WriteLine("Informações da Pessoa 1");
            Console.WriteLine($"Nome {pessoa1.Nome}");
            Console.WriteLine($"Data de Nascimento {pessoa1.DataDeNascimento}");
            Console.WriteLine($"Altura {pessoa1.Altura}");
            Console.WriteLine($"Cpf {pessoa1.CPF}");
            Console.WriteLine($"Está ativo {pessoa1.IsAtivo}");
            pessoa1.SeComunicar();

            Console.WriteLine($"Novo nome pessoa 1 {pessoa1.Nome}");

            Pessoa pessoa2 = new Pessoa(
                "Nathaly",
                new DateTime(2008, 10, 31),
                1.64,
                "03890096031",
                true);

            Console.WriteLine("Informações da Pessoa 2");
            Console.WriteLine($"Nome {pessoa2.Nome}");
            Console.WriteLine($"Data de Nascimento {pessoa2.DataDeNascimento}");
            Console.WriteLine($"Altura {pessoa2.Altura}");
            Console.WriteLine($"Cpf {pessoa2.CPF}");
            Console.WriteLine($"Está ativo {pessoa2.IsAtivo}");

            pessoa2.SeComunicar();


            Cachorro cachorro1  = new Cachorro(
                "Bili",
               new DateTime(2026, 3, 15),
                0.15,
                "Salcicha",
                true );

            Console.WriteLine("Informações do Cachorro 1");
            Console.WriteLine($"Nome {cachorro1.Nome}");
            Console.WriteLine($"Data de Nascimento {cachorro1.DataDeNascimento}");
            Console.WriteLine($"Altura {cachorro1.Altura}");
            Console.WriteLine($"Raca {cachorro1.Raca}");
            Console.WriteLine($"Está ativo {cachorro1.IsAtivo}");
            cachorro1.SeComunicar();

            Console.WriteLine($"Novo nome pessoa 1 {cachorro1.Nome}");

            Cachorro cachorro2 = new Cachorro(
                "Luna",
                new DateTime(2026, 04, 15),
                0.30,
                "Vira-Lata",
                true);

            Console.WriteLine("Informações do Cachorro 2");
            Console.WriteLine($"Nome {cachorro2.Nome}");
            Console.WriteLine($"Data de Nascimento {cachorro2.DataDeNascimento}");
            Console.WriteLine($"Altura {cachorro2.Altura}");
            Console.WriteLine($"Raca {cachorro2.Raca}");
            Console.WriteLine($"Está ativo {cachorro2.IsAtivo}");

            cachorro2.SeComunicar();








        }

    }
}
