using System;

// Criando o enum
enum Nivel
{
    Facil = 1,
    Medio = 2,
    Dificil = 3
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Escolha o nível de dificuldade ===");
        Console.WriteLine("1 - Fácil");
        Console.WriteLine("2 - Médio");
        Console.WriteLine("3 - Difícil");
        Console.Write("Digite o número da opção: ");

        // Lê a escolha do usuário
        int escolha = int.Parse(Console.ReadLine());

        // Converte o número para o enum
        Nivel nivelEscolhido = (Nivel)escolha;

        // Mostra o que o usuário escolheu
        Console.WriteLine($"\nVocê escolheu o nível: {nivelEscolhido}");

        // Você pode usar em condições também
        if (nivelEscolhido == Nivel.Facil)
        {
            Console.WriteLine("Boa sorte! Começando no modo fácil.");
        }
        else if (nivelEscolhido == Nivel.Medio)
        {
            Console.WriteLine("Modo médio ativado. Prepare-se!");
        }
        else if (nivelEscolhido == Nivel.Dificil)
        {
            Console.WriteLine("Modo difícil! Boa sorte, guerreiro!");
        }
        else
        {
            Console.WriteLine("Opção inválida.");
        }

        Console.ReadLine(); // Mantém o console aberto
    }
}
