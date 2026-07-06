using SistemadeCadastrodeFuncionarios.SistemadeCadastrodeFuncionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeCadastrodeFuncionarios
{
    class FuncionarioTerceirizado : Funcionario
    {
        public double HorasTrabalhadas { get; set; }
        public double ValorHora { get; set; }

        public override double CalcularSalario()
        {
            return HorasTrabalhadas * ValorHora;
        }
    }
}
