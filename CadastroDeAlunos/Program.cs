namespace CadastroDeAlunos
{
    internal class Program
    {
            static void Main(string[] args)
            {
                List<string> alunos = new List<string>();

                string opcao;

                do
                {
                    Console.Clear();

                    Console.WriteLine("===== CADASTRO DE ALUNOS =====");
                    Console.WriteLine("1 - Adicionar aluno");
                    Console.WriteLine("2 - Remover aluno");
                    Console.WriteLine("3 - Listar alunos");
                    Console.WriteLine("4 - Encerrar");
                    Console.Write("Escolha uma opção: ");

                    

                    opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":

                            Console.Write("Digite o nome do aluno: ");
                            string nome = Console.ReadLine();

                            alunos.Add(nome);

                            Console.WriteLine("Aluno cadastrado com sucesso!");
                            Console.ReadKey();
                            break;

                        case "2":

                            Console.Write("Digite o nome do aluno para remover: ");
                            nome = Console.ReadLine();

                            if (alunos.Remove(nome))
                            {
                                Console.WriteLine("Aluno removido!");
                            }
                            else
                            {
                                Console.WriteLine("Aluno não encontrado!");
                            }

                            Console.ReadKey();
                            break;

                        case "3":

                            Console.WriteLine("\nAlunos cadastrados:");

                            if (alunos.Count == 0)
                            {
                                Console.WriteLine("Nenhum aluno cadastrado.");
                            }
                            else
                            {
                                foreach (string aluno in alunos)
                                {
                                    Console.WriteLine(aluno);
                                }
                            }

                            Console.ReadKey();
                            break;

                        case "4":

                            Console.WriteLine("Programa encerrado.");
                            break;

                        default:

                            Console.WriteLine("Opção inválida!");
                            Console.ReadKey();
                            break;
                    }

                } while (opcao != "4");
            }
        }
    }



