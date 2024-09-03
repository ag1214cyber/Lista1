/*-------------------------------------------------------------------
Questão 3: Informações do Personagem
• Contextualização: Em um jogo de RPG, o jogador precisa inserir as informações básicas do
personagem antes de começar a aventura.
• Comando: Crie um programa que receba o nome, idade, nível inicial, classe, e raça do
personagem e exiba esses dados no console.
@Lista: 01 - Lógica de Programação
@Autor: Arthur Gabriel
@Data: 03/09/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main()
    {
        double vidaInicial, danoRecebido, reg, eq, hab;

        Console.WriteLine("Digite a vida do personagem");
        double.TryParse(Console.ReadLine(), out vidaInicial);
        Console.WriteLine("Digite o dano recebido");
        double.TryParse(Console.ReadLine(), out danoRecebido);
        Console.WriteLine("Digite o bonus de regeneração");
        double.TryParse(Console.ReadLine(), out reg);
        Console.WriteLine("Digite o bonus de equipamento");
        double.TryParse(Console.ReadLine(), out eq);
        Console.WriteLine("Digite o bonus de habilidade");
        double.TryParse(Console.ReadLine(), out hab);
        double danoModificado
        =danoRecebido + eq + hab;
        double vidaRes= vidaInicial + danoModificado + reg;
        Console.WriteLine($"\n A vida restante é: {vidaRes}");
        Console.WriteLine("Aperte no enter para fechar");
        Console.ReadLine();
    }
}
