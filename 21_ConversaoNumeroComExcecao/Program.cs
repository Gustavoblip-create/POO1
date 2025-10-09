using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_ConversaoNumeroComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool NumeroValido = false;
            int num;

            while(!NumeroValido)


            try
            {

                Console.WriteLine("Digite um Numero Inteiro: ");
                num = int.Parse(Console.ReadLine());

                Console.WriteLine($"Parabéns, o Dobro do seu numero é:{num + num} ");
                NumeroValido = true;
            }
            catch (Exception)
            {
                Console.WriteLine("ERRO! Você digitou um numero invalido, vamos tentar de novo!");
               
            }


        }
    }
}
