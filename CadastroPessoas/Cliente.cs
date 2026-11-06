using System;

namespace CadastroPessoas
{
    public class Cliente : Pessoa
    {
        public string CodigoCliente;

        public Cliente(string nome, int idade, string codigoCliente)
            : base(nome, idade)
        {
            CodigoCliente = codigoCliente;
        }

        public void ExibirDadosCliente()
        {
            Console.WriteLine("Código do cliente: " + CodigoCliente);
            Apresentar();
        }
    }
}
