using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAoProjeto
{
    internal class Animal
    {
        public string Nome { get; private set; }
        public DateTime DataDeNascimento { get; private set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public bool IsAtivo { get; set; }

        public void SeComunicar()
        {
            Console.WriteLine("Fala genérica...");
        }

        public void SeAlimentar()
        {
            Console.WriteLine("Animal se alimentando...");
        }


    }
}
