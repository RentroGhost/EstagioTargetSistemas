using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renato_EstagioTargetSistemas
{
    internal class Fibonacci
    {
        public void FIBONACCI(int numero)
        {

            
            int n1 = 0;
            int n2 = 1;
            int soma = 0;
            List<int> fibonacci = new List<int>() {0, 1};
            

            while (soma < numero) {

                soma = n1 + n2;
                n1 = n2;
                n2 = soma;
                fibonacci.Add(n2);

            }

            if (fibonacci.Contains(numero))
            {
                Console.WriteLine("O número escolhido pertence a sequência de fibonacci");
                Console.WriteLine("Sequência gerada: ");
                foreach (var num in fibonacci) {
                    Console.Write(num + ", ");
                }
            }
            else
            {
                Console.WriteLine("O número escolhido não pertence a sequência de fibonacci");
                Console.WriteLine("Sequência gerada: ");
                foreach (var num in fibonacci)
                {
                    Console.Write(num + ", ");
                }
            }

            
        }
    }
}
