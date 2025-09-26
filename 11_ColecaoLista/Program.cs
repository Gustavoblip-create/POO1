using System;
using System.Collections.Generic;

namespace ColecaoLista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();

            Console.WriteLine("Digite 5 nomes (cada nome deve ter pelo menos 3 letras):");

            while (nomes.Count < 5)
            {
                Console.Write($"Digite o {nomes.Count + 1}º nome: ");
                string nome = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(nome) && nome.Length >= 3)
                {
                    nomes.Add(nome);
                }
                else
                {
                    Console.WriteLine("Nome inválido. O nome deve conter pelo menos 3 caracteres.\n");
                }
            }

            Console.WriteLine("\nLista de nomes digitados:");
            foreach (string nome in nomes)
            {
                Console.WriteLine($"- {nome}");
            }
        }
    }
}
