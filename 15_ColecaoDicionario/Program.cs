using System;
using System.Collections.Generic;

namespace _15_ColecaoDicionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Aluno = new Dictionary<int, string>();

            Console.WriteLine("Digite o RA e o nome de 3 alunos:");

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"\nDigite o RA do aluno {i + 1}: ");
                int ra = int.Parse(Console.ReadLine());

                string nome;

                do
                {
                    Console.Write("Digite o nome do aluno (No minimo 3 letras): ");
                    nome = Console.ReadLine();

                    if (nome.Length < 3)
                    {
                        Console.WriteLine(" Nome muito curto! Digite novamente.");
                    }

                } while (nome.Length < 3);

                Aluno.Add(ra, nome);
            }

            Console.WriteLine("\nAlunos Cadastrados:");
            foreach (var aluno in Aluno)
            {
                Console.WriteLine($"RA: {aluno.Key} - Nome: {aluno.Value}");
            }
        }
    }
}
