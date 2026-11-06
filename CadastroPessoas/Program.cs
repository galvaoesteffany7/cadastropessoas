using System;

namespace CadastroPessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente(
                "Ana Souza",
                28,
                "CLI-001");

            Funcionario funcionario = new Funcionario(
                "Carlos Lima",
                35,
                4500.00m);

            Gerente gerente = new Gerente(
                "Marina Alves",
                42,
                7000.00m,
                "Tecnologia");

            Console.WriteLine("=== ENCAPSULAMENTO ===");
            cliente.SetNome("Ana Souza Lima");
            cliente.SetIdade(29);
            Console.WriteLine("Nome: " + cliente.GetNome());
            Console.WriteLine("Idade: " + cliente.GetIdade());

            Console.WriteLine();
            Console.WriteLine("=== CLIENTE ===");
            cliente.ExibirDadosCliente();

            Console.WriteLine();
            Console.WriteLine("=== FUNCIONÁRIO ===");
            funcionario.ExibirDadosFuncionario();

            Console.WriteLine();
            Console.WriteLine("=== GERENTE ===");
            gerente.ExibirDadosGerente();

            Console.ReadKey();
        }
    }
}
