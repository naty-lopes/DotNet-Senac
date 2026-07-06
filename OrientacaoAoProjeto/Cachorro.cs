using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAoProjeto
{
    public class Cachorro
    {
        public Cachorro(
        string nome,
        DateTime dataDeNascimento,
        double altura,
        string raca,
        bool isAtivo)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Altura = altura;
            Raca = raca;
            IsAtivo = isAtivo;
        }




        public string Nome { get; private set; }

        public string Raca { get; private set; }

        public double Altura { get; set; }

        public double Peso { get; set; }

        public DateTime DataDeNascimento { get; private set; }

        public bool Adestrado { get; set; }

        public bool IsVacinado { get; set; }

        public bool IsAtivo { get; set; }

        public void SeComunicar()
        {
            Console.WriteLine($"Au au");
        }

        public void Caminhar()
        {
            Console.WriteLine("Cachorro caminhando...");
        }

        public void FazerTruque(string truque)
        {
            Console.WriteLine($"Truque: {truque}");
        }
    }
}


