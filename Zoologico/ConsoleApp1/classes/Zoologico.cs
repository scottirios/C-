using ConsoleApp1.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.classes
{
    public class Zoologico
    {
        private List<Animal> animais = new List<Animal>();
        private List<Tratador> tratadores = new List<Tratador>();

        public void AdicionarAnimal(Animal animal)
        {
            animais.Add(animal);
            Console.WriteLine($"O {animal.Nome} foi adicionado");
        }

        public void AdicionarTratador(Tratador tratador)
        {
            tratadores.Add(tratador);
            Console.WriteLine($"O tratador {tratador.Nome} foi adicionado");
        }

        public void ListarAnimais() 
        {
            if (animais.Count > 0 )
            {
                Console.WriteLine("Animais no Zoológico");
                foreach (Animal animal in animais)
                {
                    animal.EmitirSom();
                   
                    Console.WriteLine($"Nome: {animal.Nome}, Idade: {animal.Idade}");

                    if (animal is Mamifero mamifero)
                    {
                        Console.WriteLine($"Tipo do pelo: {mamifero.TipoDePelo}");
                    }
                }
            }
            else
            {
                Console.WriteLine("A lista está vazia");
            }
        }

        public void ListarTratadores()
        {
            if (tratadores.Count > 0)
            {
                Console.WriteLine("Tratadores no Zoológico");
                foreach (Tratador tratador in tratadores)
                {
                    tratador.Cuidar();
                    Console.WriteLine($"Nome: {tratador.Nome}, Especialidade: {tratador.Especialidade}");
                }
            }
            else
            {
                Console.WriteLine("A lista está vazia");
            }
        }

        public void AlimentarAnimais()
        {
            Console.WriteLine("Alimentando os animais...");
            foreach(Animal animal in animais)
            {
                if(animal is IAlimentavel alimentavel)
                {
                    alimentavel.Alimentar();
                }
            }
        }


        public void CuidarAnimais()
        {
            Console.WriteLine("Cuidando dos animais...");
            foreach (Animal animal in animais)
            {
                if (animal is ICuidavel cuidavel)
                {
                    cuidavel.Cuidar();
                }
            }
        }
    }
}
