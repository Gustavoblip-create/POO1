using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int>numeros = new HashSet<int>();
            Console.WriteLine("Digite 10 numeros(Esse numeros não podem ser repetidos)");
            
            for (int i = 0; i < 10; i++)
               
            {
                Console.WriteLine($"numeros {i +1}");
                int num = int.Parse( Console.ReadLine() );
                numeros.Add(num);
            }
            Console.WriteLine("===========================================");
            Console.WriteLine("\nNumeros Digitados");
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
           
            }
            Console.WriteLine("============================================");

            
        }
    }
}
