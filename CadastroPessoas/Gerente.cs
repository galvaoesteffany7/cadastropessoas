using System;

namespace CadastroPessoas
{
    public class Gerente : Funcionario
    {
        public string Departamento;

        public Gerente(
            string nome,
            int idade,
            decimal salario,
            string departamento)
            : base(nome, idade, salario)
        {
            Departamento = departamento;
        }

        public void ExibirDadosGerente()
        {
            Console.WriteLine("Departamento: " + Departamento);
            ExibirDadosFuncionario();
        }
    }
}
