using ConsoleApp1.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.classes
{
    public class Ave : Animal, IAlimentavel
    {
        public double EnvergaduraAsas { get; set; }

        public Ave(string nome, int idade, double envergaduraAsas) 
            : base(nome, idade)
        {
            EnvergaduraAsas = envergaduraAsas;
        }

        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} faz som de ave");
        }

        public void Alimentar()
        {
            Console.WriteLine($"{Nome} é ave está sendo alimentada");
        }

        public void Cuidavel()
        {
            Console.WriteLine($"{Nome} é ave e está sendo cuidado");
        }

    }
}
