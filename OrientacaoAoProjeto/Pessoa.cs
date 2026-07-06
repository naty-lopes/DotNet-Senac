using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAoProjeto
{
    public class Pessoa
    {
        public Pessoa(
        string nome,
        DateTime dataDeNascimento,
        double altura,
        string cpf,
        bool isAtivo)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Altura = altura;
            CPF = cpf;
            IsAtivo = isAtivo;
        }

        public string Nome {  get; private set; }

        public DateTime DataDeNascimento { get; private set; }

        public double Altura {  get; set; }

        public string CPF { get; private set; }

        public string RG { get; private set; }

        public string telefone { get; set; }

        public string email { get; set; }

        public bool IsAtivo { get; set; }

        public void SeComunicar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}");
        }

        public void Caminhar()
        {
            Console.WriteLine("Pessoa caminhando...");
        }
    }
}


