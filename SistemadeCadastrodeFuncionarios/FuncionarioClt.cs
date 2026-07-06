using SistemadeCadastrodeFuncionarios.SistemadeCadastrodeFuncionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeCadastrodeFuncionarios
{
    class FuncionarioClt : Funcionario
    {
        public double SalarioBase { get; set; }

        public override double CalcularSalario()
        {
            return SalarioBase;
        }
    }
}
