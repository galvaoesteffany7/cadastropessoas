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

            // ENCAPSULAMENTO: campos privados, acesso por métodos e propriedades
            Console.WriteLine("=== ENCAPSULAMENTO ===");
            cliente.SetNome("Ana Souza Lima");
            cliente.Idade = 29;
            Console.WriteLine("Nome: " + cliente.GetNome());
            Console.WriteLine("Idade: " + cliente.Idade);

            cliente.Idade = -5; // valor inválido: a validação ignora
            Console.WriteLine("Idade após tentar -5: " + cliente.Idade);

            // SOBRECARGA DE MÉTODO: mesmo nome, parâmetros diferentes
            Console.WriteLine();
            Console.WriteLine("=== SOBRECARGA DE MÉTODO ===");
            cliente.Apresentar();
            Console.WriteLine();
            cliente.Apresentar(true);

            // SOBRECARGA DE CONSTRUTOR
            Console.WriteLine();
            Console.WriteLine("=== SOBRECARGA DE CONSTRUTOR ===");
            Cliente clienteSemCodigo = new Cliente("Bruno Lima", 31);
            clienteSemCodigo.Apresentar();

            // POLIMORFISMO: a mesma chamada executa o método de cada classe
            Console.WriteLine();
            Console.WriteLine("=== POLIMORFISMO ===");
            Pessoa[] pessoas = { cliente, funcionario, gerente };

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine("--- " + pessoa.GetType().Name + " ---");
                pessoa.Apresentar();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
