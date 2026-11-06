using System;

namespace CadastroPessoas
{
    public class Funcionario : Pessoa
    {
        public decimal Salario;

        public decimal CalcularBonus()
        {
            return Salario * 0.10m;
        }

        public void ExibirDadosFuncionario()
        {
            Console.WriteLine("Salário: " + Salario);
            Console.WriteLine("Bônus: " + CalcularBonus());
            Apresentar();
        }
    }
}
