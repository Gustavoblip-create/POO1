using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_DivisaoComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, num2;
           // bool dadosValidos = false;

            //while (!dadosValidos)

                try
                {

                    Console.WriteLine("Digite um numero Inteiro: ");
                    num = int.Parse(Console.ReadLine());

                    Console.WriteLine("Dividido por outro numero inteiro : ");
                    num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine($" A divisão dos dois numeros é: {num / num2}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor digite numeros inteiros");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Não Divida por zero, Engraçadinho");
                }
                finally
                {
                    Console.WriteLine("\nOperação finalizada. Obrigado por utilizar o programa!");
                }
        }
    }
}
