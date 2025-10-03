using System;
using _08_ValidaCPF;
using _18_ValidaCpf;

namespace _08_ValidaCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o CPF: ");
            string cpf = Console.ReadLine();

            IDocumento documento = new CPF(cpf);

            if (documento.Validar())
            {
                Console.WriteLine("CPF VÁLIDO!");
            }
            else
            {
                Console.WriteLine("CPF INVÁLIDO!");
            }

            Console.ReadLine();
        }
    }
}
