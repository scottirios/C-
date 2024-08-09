using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.classes
{
    public abstract class Tratador
    {
        public string Nome { get; set; }
        public string Especialidade { get; set; }

        public Tratador(String nome, string especialidade)
        {
            Nome = nome;
            Especialidade = especialidade;

        }

        public abstract void Cuidar();

    }
}
