using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAoProjeto
{

    public class Pedido
    {
        public Pessoa Cliente { get; set; }

        public IList<string> Produto { get; set; }

        public double ValorTotal { get; set; }

        public DateTime DataDoServico { get; set; }

        public bool IsPago { get; set; }

        public string Observacao { get; set; }
    }
}
