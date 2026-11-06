using System;

namespace CadastroPessoas
{
    public abstract class Pessoa
    {
        private string nome;
        private int idade;

        public Pessoa(string nome, int idade)
        {
            SetNome(nome);
            Idade = idade;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string novoNome)
        {
            nome = novoNome;
        }

        public int Idade
        {
            get { return idade; }
            set
            {
                if (value >= 0)
                {
                    idade = value;
                }
            }
        }

        public void Apresentar()
        {
            Console.WriteLine("Nome: " + GetNome());
            Console.WriteLine("Idade: " + Idade);
        }

        public void Apresentar(bool mostrarTipo)
        {
            Apresentar();

            if (mostrarTipo)
            {
                Console.WriteLine("Tipo: " + GetType().Name);
            }
        }
    }
}
