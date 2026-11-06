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
            SetIdade(idade);
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string novoNome)
        {
            nome = novoNome;
        }

        public int GetIdade()
        {
            return idade;
        }

        public void SetIdade(int novaIdade)
        {
            idade = novaIdade;
        }

        public void Apresentar()
        {
            Console.WriteLine("Nome: " + GetNome());
            Console.WriteLine("Idade: " + GetIdade());
        }
    }
}
