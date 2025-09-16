using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _07_CalendarioComFeriado
{
    internal class progam
    {
        static void Main(string[] args)

        {

            //Console.Write("Digite o Mês (1 a 12): ");
           // int mes = int.Parse(Console.ReadLine());

            Console.Write("Digite o Ano (ex: 2023)");
            int ano = int.Parse(Console.ReadLine());

            Calendario calendario;
            for (int mes = 1; mes <= 12; mes++)
            {
                calendario = new Calendario(ano, mes);
                calendario.ImprimirCalendario();
            

            Console.WriteLine("\n\n");

            }
            Console.ReadKey();
       }

    }
}