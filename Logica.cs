using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renato_EstagioTargetSistemas
{
    internal class Logica
    {
        public void LOGICA()
        {

            int n1 = 0;
            int n2 = 1;
            int calculo = 0;
            int k = 0;
            List<int> logica = new List<int>() {};


           
            // Lógica A
            Console.WriteLine("A lógica 'A' tem seu valor aumentado de 2 em 2, sendo assim ela poderia ser continuada com 5 valores extras da seguinte maneira:");

            n1 = 1;
            while (k < 9)
            {
                k++;
                logica.Add(n1);
                calculo = n1 + 2;
                n1 = calculo;
                
            }

            Console.WriteLine("Sequência gerada: ");
            foreach (var num in logica)
            {
                Console.Write(num + ", ");
            }

            Console.WriteLine();

            // Lógica B
            Console.WriteLine("A lógica 'B' tem seu valor anterior multiplicado por 2, sendo assim ela poderia ser continuada com 5 valores extras da seguinte maneira:");

            n1 = 2;
            k = 0;
            logica.Clear();
            while (k < 11)
            {
                k++;
                logica.Add(n1);
                calculo = n1 * 2;
                n1 = calculo;

            }

            Console.WriteLine("Sequência gerada: ");
            foreach (var num in logica)
            {
                Console.Write(num + ", ");
            }

            Console.WriteLine();

            // Lógica C
            Console.WriteLine("A lógica 'C' tem seu valor igual ao quadrado de seu indice, sendo assim ela poderia ser continuada com 5 valores extras da seguinte maneira:");

            n1 = 0;
            k = 0;
            logica.Clear();
            while (k < 12)
            {
                
                n1 = k;
                calculo = n1 * n1;
                n1 = calculo;
                logica.Add(n1);
                k++;

            }

            Console.WriteLine("Sequência gerada: ");
            foreach (var num in logica)
            {
                Console.Write(num + ", ");
            }

            Console.WriteLine();

            // Lógica D
            Console.WriteLine("A lógica 'D' possui apenas quadrados de numeros pares, sendo assim ela poderia ser continuada com 5 valores extras da seguinte maneira:");

            n1 = 2;
            k = 0;
            logica.Clear();
            while (k < 9)
            {
                k++;
                calculo = n1 * n1;
                n1 += 2;
                logica.Add(calculo);

            }

            Console.WriteLine("Sequência gerada: ");
            foreach (var num in logica)
            {
                Console.Write(num + ", ");
            }

            Console.WriteLine();

            // Lógica E
            Console.WriteLine("A lógica 'E' representa a sequência de fibonacci, sendo assim ela poderia ser continuada com 5 valores extras da seguinte maneira:");

            n1 = 0;
            n2 = 1;
            calculo = 0;
            k = 0;
            logica.Clear();
            logica.Add(n2);
            while (k < 10)
            {
                k++;
                calculo = n1 + n2;
                n1 = n2;
                n2 = calculo;
                logica.Add(n2);

            }

            Console.WriteLine("Sequência gerada: ");
            foreach (var num in logica)
            {
                Console.Write(num + ", ");
            }

            Console.WriteLine();

            // Lógica F
            Console.WriteLine("A lógica 'F' Apresenta apenas números que comecem com a letra 'D', sendo assim ela poderia ser continuada com 5 valores extras da seguinte maneira:");

     

            Console.WriteLine("Sequência: 2, 10, 12,16 ,17 ,18, 19, 200, 201, 202, 203, 204, 205");

            Console.WriteLine();

        }
    }
}
