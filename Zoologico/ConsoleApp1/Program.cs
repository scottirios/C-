using ConsoleApp1.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoologico zoologico = new Zoologico();

            while (true) 
            {
                Console.WriteLine("Selecione uma Opção:");
                Console.WriteLine("1- Adicionar Mamífero:");
                Console.WriteLine("2- Adicionar Ave:");
                Console.WriteLine("3- Adicionar Reptil:");
                Console.WriteLine("4- Listar Animais:");
                Console.WriteLine("5- Alimentar Animais:");
                Console.WriteLine("6- Cuidar dos Animais");
                Console.WriteLine("7- Adicionar Tratador de Mamíferos");
                Console.WriteLine("8- Adicionar Tratador de Aves");
                Console.WriteLine("9- Listar Tratadores");
                Console.WriteLine("10- Sair");
                


                string opcao = Console.ReadLine();

                if(opcao == "10")
                {
                    break;
                }

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite o nome do mamífero: ");
                        string nomeMamifero = Console.ReadLine(); //le o valor do imput e armazena na variavel

                        Console.WriteLine("Digite a idade do mamífero: ");
                        int idadeMamifero = int.Parse (Console.ReadLine());

                        Console.WriteLine("Digite o tipo de pelo do mamífero: ");
                        string tipoDePelo = Console.ReadLine();

                        Mamifero mamifero = new Mamifero(nomeMamifero, idadeMamifero, tipoDePelo);

                        zoologico.AdicionarAnimal(mamifero);
                        break;

                    case "2":

                        Console.WriteLine("Digite o nome da ave: ");
                        string nomeAve = Console.ReadLine(); //le o valor do imput e armazena na variavel

                        Console.WriteLine("Digite a idade da ave: ");
                        int idadeAve = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a envergadura das asas: ");
                        double envergadura = double.Parse(Console.ReadLine());

                        Ave ave = new Ave(nomeAve, idadeAve, envergadura);

                        zoologico.AdicionarAnimal(ave);
                        break;


                case "4":
                        zoologico.ListarAnimais();
                        break;

                case "5":
                        zoologico.AlimentarAnimais();
                        break;

                case "3":
                        Console.WriteLine("Digite o nome do reptil: ");
                        string nomeReptil = Console.ReadLine(); //le o valor do imput e armazena na variavel

                        Console.WriteLine("Digite a idade do reptil: ");
                        int idadeReptil = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o tipo de escama do reptil: ");
                        string tipoDeEscama = Console.ReadLine();

                        Reptil reptil = new Reptil(nomeReptil, idadeReptil, tipoDeEscama);

                        zoologico.AdicionarAnimal(reptil);
                        break;

                    default:
                        Console.WriteLine("Opção desconhecida");
                        break;

                case "7":
                        Console.WriteLine("Digite o nome do tratador de mamífero: ");
                        string nomeTratadorMamifero = Console.ReadLine();

                        Console.WriteLine("Digite a especialidade do tratador de mamífero: ");
                        string especialidadeTratadorMamifero = Console.ReadLine();


                        Tratador tratador = new TratadorMamiferos(nomeTratadorMamifero, especialidadeTratadorMamifero);

                        zoologico.AdicionarTratador(tratador);
                        break;

                case "8":
                        Console.WriteLine("Digite o nome do tratador de aves: ");
                        string nomeTratadorAve = Console.ReadLine();

                        Console.WriteLine("Digite a especialidade do tratador de aves: ");
                        string especialidadeTratadorAve = Console.ReadLine();


                        Tratador tratadorAve = new TratadorMamiferos(nomeTratadorAve, especialidadeTratadorAve);

                        zoologico.AdicionarTratador(tratadorAve);
                        break;

                case "9":
                        zoologico.ListarTratadores();
                        break;

                case "6":
                        zoologico.CuidarAnimais();
                        break;
                }
            }
        }
    }
}
