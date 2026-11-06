using System;

namespace CadastroPessoas
{
    public class Funcionario : Pessoa
    {
        public decimal Salario;

        public Funcionario(string nome, int idade, decimal salario)
            : base(nome, idade)
        {
            Salario = salario;
        }

        public decimal CalcularBonus()
        {
            return Salario * 0.10m;
        }

        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine("Salário: " + Salario);
            Console.WriteLine("Bônus: " + CalcularBonus());
        }
    }
}
