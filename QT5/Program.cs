/*-------------------------------------------------------------------
Questão 5: Informações do Personagem
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
        int tempo, velocidade;
        double mC, mEv, total;

        Console.WriteLine("Diga a velocidade do veiculo");
        int.TryParse(Console.ReadLine(), out velocidade);
        System.Console.WriteLine("Diga o tempo de viagem");
        int.TryParse(Console.ReadLine(), out tempo);
        System.Console.WriteLine("Diga o multiplicador climatico");
        double.TryParse(Console.ReadLine(), out mC);
        System.Console.WriteLine("Diga o multiplicador do estado do veiculo");
        double.TryParse(Console.ReadLine(), out mEv);
        total= tempo* velocidade* mC* mEv;
        Console.WriteLine("A velocidade do veiculo é" + total);
        Console.ReadLine();
    }
}