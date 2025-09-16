using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Aluno
{
    internal class Aluno
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            double nota1, nota2;
            double media;
            string situacao;

            Console.WriteLine("Digite seu nome:");
           nome = Console.ReadLine();
          
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite sua primeira Nota: ");
            nota1 = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Digite sua Segunda Nota: ");
            nota2 = int.Parse(Console.ReadLine());
        }
    }
}
