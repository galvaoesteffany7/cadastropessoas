using System;

namespace CadastroPessoas
{
    public class Cliente : Pessoa
    {
        public string CodigoCliente;

        public void ExibirDadosCliente()
        {
            Console.WriteLine("Código do cliente: " + CodigoCliente);
            Apresentar();
        }
    }
}
