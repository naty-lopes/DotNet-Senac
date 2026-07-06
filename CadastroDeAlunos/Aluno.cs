using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeAlunos
{
    internal class Aluno
    {
        public Guid Matricula = Guid.NewGuid();
        public string Nome;
        public DateTime DataNascimento;
        public string Cpf;

        public int Idade
        {
            get
            {
                int idade = DateTime.Now.Year - DataNascimento.Year;
                if (DateTime.Now < DataNascimento.AddYears(idade))
                    idade--;
                return idade;
            }

        }

    }
}
