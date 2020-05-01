using System;

namespace ExercicioFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("O que vc deseja fazer");
                Console.WriteLine("1 - Cadastrar funcionário");
                Console.WriteLine("2 - Listar funcionário");
                Console.WriteLine("3 - Mostrar folha de pagamento");
                Console.WriteLine("4 - Sair");

                bool sair = false;

                try
                {
                    var item = Convert.ToInt32(Console.ReadLine());
                    switch (item)
                    {
                        case 1:
                            CadastarFuncionario();
                            break;
                        case 2:
                            ListaFuncionario();
                            break;
                        case 3:
                            MostrarFolha();
                            break;
                        case 4:
                            sair = true;
                            break;
                    }

                    if (sair) break;
                }
                catch
                {
                    Console.WriteLine("Opção inválida");
                }

            }
        }

        private static void MostrarFolha()
        {
            Console.WriteLine($"João sua folha de pagamento é {Funcionario.FolhaPagamento()}");
        }

        private static void CadastarFuncionario()
        {
            var fun = new Funcionario();

            Console.WriteLine("Digite o nome");
            fun.Nome = Console.ReadLine();

            Console.WriteLine("Digite o matricula");
            fun.Matricula = Console.ReadLine();

            Console.WriteLine("Digite o Salario");
            fun.Salario = Convert.ToDouble(Console.ReadLine());

            fun.Salvar();
        }

        private static void ListaFuncionario()
        {
            foreach(var fun in Funcionario.BancoDeDadosEmMemoriaFuncionarios)
            {
                Console.WriteLine("==========");
                Console.WriteLine($"Nome: {fun.Nome}");
                Console.WriteLine($"Salario: {fun.Salario}");
            }
        }
    }
}
