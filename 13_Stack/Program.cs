using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> Numeros = new Stack<int>();
             
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite 5 numeros");
                int numero = int.Parse(Console.ReadLine());
                Numeros.Push(numero);
            }
            Console.WriteLine("\nPilha de numeros  Decrescente");
            foreach (int n in Numeros)
            {
                Console.WriteLine(n);
            }

           
        }
    }
}
