using SistemadeCadastrodeFuncionarios.SistemadeCadastrodeFuncionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeCadastrodeFuncionarios
{
    class FuncionarioEstagiario : Funcionario
    {
        public double BolsaAuxilio { get; set; }
        public double ValeTransporte { get; set; }

        public override double CalcularSalario()
        {
            return BolsaAuxilio + ValeTransporte;
        }
    }
}
