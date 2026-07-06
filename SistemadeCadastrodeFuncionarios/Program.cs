namespace SistemadeCadastrodeFuncionarios
{
    internal class Program;


namespace SistemadeCadastrodeFuncionarios
    {
     
        class Funcionario
        {
            public string Nome { get; set; }
            public string Cpf { get; set; }
            public string Tipo { get; set; }

            public virtual double CalcularSalario()
            {
                return 0;
            }

            public virtual void ExibirDados()
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Nome: " + Nome);
                Console.WriteLine("CPF: " + Cpf);
                Console.WriteLine("Tipo: " + Tipo);
                Console.WriteLine("Salário: R$ " + CalcularSalario().ToString("F2"));
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                List<Funcionario> funcionarios = new List<Funcionario>();

                int opcao = 0;

                while (opcao != 3)
                {
                    Console.WriteLine("\n===== SISTEMA DE RH =====");
                    Console.WriteLine("1 - Cadastrar Funcionário");
                    Console.WriteLine("2 - Listar Funcionários");
                    Console.WriteLine("3 - Sair");
                    Console.Write("Escolha: ");

                    int.TryParse(Console.ReadLine(), out opcao);

                    switch (opcao)
                    {
                        case 1:
                            CadastrarFuncionario(funcionarios);
                            break;

                        case 2:
                            ListarFuncionarios(funcionarios);
                            break;

                        case 3:
                            Console.WriteLine("Sistema encerrado.");
                            break;

                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }
                }
            }

            static void CadastrarFuncionario(List<Funcionario> funcionarios)
            {
                Console.WriteLine("\nTipo de Funcionário:");
                Console.WriteLine("1 - CLT");
                Console.WriteLine("2 - Estagiário");
                Console.WriteLine("3 - Terceirizado");
                Console.Write("Escolha: ");

                int tipo = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("CPF: ");
                string cpf = Console.ReadLine();

                switch (tipo)
                {
                    case 1:
                        try
                        {
                            Console.Write("Salário Base: ");
                            double salario = double.Parse(Console.ReadLine());

                            FuncionarioClt clt = new FuncionarioClt();
                            clt.Nome = nome;
                            clt.Cpf = cpf;
                            clt.Tipo = "CLT";
                            clt.SalarioBase = salario;

                            funcionarios.Add(clt);

                            Console.WriteLine("Funcionário cadastrado!");
                        }
                        catch
                        {
                            Console.WriteLine("Valor inválido.");
                        }
                        break;

                    case 2:
                        try
                        {
                            Console.Write("Bolsa Auxílio: ");
                            double bolsa = double.Parse(Console.ReadLine());

                            Console.Write("Vale Transporte: ");
                            double vt = double.Parse(Console.ReadLine());

                            FuncionarioEstagiario est = new FuncionarioEstagiario();
                            est.Nome = nome;
                            est.Cpf = cpf;
                            est.Tipo = "Estagiário";
                            est.BolsaAuxilio = bolsa;
                            est.ValeTransporte = vt;

                            funcionarios.Add(est);

                            Console.WriteLine("Funcionário cadastrado!");
                        }
                        catch
                        {
                            Console.WriteLine("Valor inválido.");
                        }
                        break;

                    case 3:
                        try
                        {
                            Console.Write("Horas Trabalhadas: ");
                            double horas = double.Parse(Console.ReadLine());

                            Console.Write("Valor da Hora: ");
                            double valorHora = double.Parse(Console.ReadLine());

                            FuncionarioTerceirizado terc = new FuncionarioTerceirizado();
                            terc.Nome = nome;
                            terc.Cpf = cpf;
                            terc.Tipo = "Terceirizado";
                            terc.HorasTrabalhadas = horas;
                            terc.ValorHora = valorHora;

                            funcionarios.Add(terc);

                            Console.WriteLine("Funcionário cadastrado!");
                        }
                        catch
                        {
                            Console.WriteLine("Valor inválido.");
                        }
                        break;

                    default:
                        Console.WriteLine("Tipo inválido.");
                        break;
                }
            }

            static void ListarFuncionarios(List<Funcionario> funcionarios)
            {
                if (funcionarios.Count == 0)
                {
                    Console.WriteLine("Nenhum funcionário cadastrado.");
                    return;
                }

                Console.WriteLine("\n===== FUNCIONÁRIOS =====");

                foreach (Funcionario f in funcionarios)
                {
                    f.ExibirDados();
                }
            }
        }
    }
}
    

