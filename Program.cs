using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Renato_EstagioTargetSistemas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha = 1;

            while (escolha != 6) { 

            Console.WriteLine("Este executável foi criado para o processo seletivo para estágio na empresa Target Sistemas");
            Console.WriteLine("Por favor selecione qual etapa deseja verificar:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Fibonacci");
            Console.WriteLine("3 - Lógica");
            Console.WriteLine("4 - Interruptores");
            Console.WriteLine("5 - String");
            Console.WriteLine("6 - Sair");

                
                if (int.TryParse(Console.ReadLine(), out escolha))
               
               
                switch (escolha) {
                case 1:
                    Console.Clear();
                    Soma soma = new Soma();
                    int resultado = soma.SOMA();
                    Console.WriteLine("O valor da variável soma será de: " + resultado);
                break;

                case 2:
                    Console.Clear();
                    Fibonacci fibonacci = new Fibonacci();
                    Console.WriteLine("Digite o número que deseja procurar dentro da sequência de fibonacci");
                    if (int.TryParse(Console.ReadLine(), out int numero))
                    {
                        fibonacci.FIBONACCI(numero);
                    }
                    else { 
                        Console.WriteLine("Por favor digite um valor válido!");
                    }
                    break;

                case 3:
                    Console.Clear();
                    Logica logica = new Logica();
                    logica.LOGICA();
                break;
                case 4:
                    Console.Clear();
                    Interruptores interruptores = new Interruptores();
                    interruptores.INTERRUPTORES();
                break;
                case 5:
                    Console.Clear();
                    String inverter = new String();
                    Console.WriteLine("Digite um texto para ser invertido");
                    string texto = Console.ReadLine();
                    inverter.STRING(texto);
                break;


            }

                Console.WriteLine();

            }
                
        }
    }
}
