using System;

namespace CadastroPessoas
{
    public class Cliente : Pessoa
    {
        public string CodigoCliente { get; set; }

        public Cliente(string nome, int idade, string codigoCliente)
            : base(nome, idade)
        {
            CodigoCliente = codigoCliente;
        }

        public Cliente(string nome, int idade)
            : this(nome, idade, "SEM-CODIGO")
        {
        }

        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine("Código do cliente: " + CodigoCliente);
        }
    }
}
