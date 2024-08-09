using ConsoleApp1.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.classes
{
    public class TratadorMamiferos : Tratador, ICuidavel
    {
        public TratadorMamiferos(string nome, string especialidade) : base(nome, especialidade) { }

        public override void Cuidar()
        {
            Console.WriteLine($"{Nome} está cuidado do mamífero");
        }

    }
}
