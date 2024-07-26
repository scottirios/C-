using System; 

namespace OlaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Lucas";
            pessoa.Idade = 22;

            pessoa.Apresentar();

            Console.WriteLine("Olá Mundo C#");
        }
    }

    class Pessoa
    {
        public string Nome;
        public int Idade;

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos.");
        }
    }

    

    
}