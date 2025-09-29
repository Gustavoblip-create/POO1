using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sem Ultilização de Enum");
           // List<int> diaDasemanaSemenum = new List<int> { 0,1,2,3,4,5,6};
            List<int> diaDasemanaSemenum = new List<int> { 1,2,3,4,5,6,7};
           foreach (var item in diaDasemanaSemenum)
            {
                //if(item == 0) Console.WriteLine("Domingo");
                //else if (item == 1) Console.WriteLine("Segunda");
                //else if (item == 2) Console.WriteLine("Terça");
                //else if (item == 3) Console.WriteLine("Quarta");
                //else if (item == 4) Console.WriteLine("Quinta");
                //else if (item == 5) Console.WriteLine("Sexta");
                //else if (item == 6) Console.WriteLine("Sabado");
                
                if(item == 1) Console.WriteLine("Domingo - Numero: 1");
                else if (item == 2) Console.WriteLine("Segunda - Numero: 2");
                else if (item == 3) Console.WriteLine("Terça - Numero: 3");
                else if (item == 4) Console.WriteLine("Quarta - Numero: 4");
                else if (item == 5) Console.WriteLine("Quinta - Numero: 5");
                else if (item == 6) Console.WriteLine("Sexta - Numero: 6");
                else if (item == 7) Console.WriteLine("Sabado - Numero: 7");
            }

            Console.WriteLine("\n\nCom a ultilização do Enum");
            List <DiadaSemana> diaDaSemanaComEnum = new List<DiadaSemana>()
            {
                DiadaSemana.Domingo,
                 DiadaSemana.Segunda,
                DiadaSemana.Terca,
                DiadaSemana.Quarta,
                DiadaSemana.Quinta,
                DiadaSemana.Sexta,
                DiadaSemana.Sabado
            };

            foreach (var item in diaDaSemanaComEnum)
            {
                Console.WriteLine($"{item} Numero: {(int)item}");
            }
        }
    }
    public enum DiadaSemana
    {
            Domingo = 1,
            Segunda ,
            Terca ,
            Quarta,
            Quinta,
            Sexta,
            Sabado
    }

}
