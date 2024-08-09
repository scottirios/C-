using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.classes
{
    public class Reptil : Animal
    {
        public string tipoEscama { get; set; }

        public Reptil(string nome, int idade, string tipoEscama) : base(nome, idade)
        {
            tipoEscama = tipoEscama;
        }

        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} faz som de reptil");
        }
    }


}
