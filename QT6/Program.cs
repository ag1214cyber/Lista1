/*-------------------------------------------------------------------
Questão 6: Informações do Personagem
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
        double  bonEvento, bonHab, moedas, taxas, cristais;
        Console.WriteLine("Quantas moedas voce quer converter");
        double.TryParse(Console.ReadLine(), out moedas);
        System.Console.WriteLine("Qual a taxa de conversao");
        double.TryParse(Console.ReadLine(), out taxas);
        System.Console.WriteLine("Bonus do evento");
        double.TryParse(Console.ReadLine(), out bonEvento);
        System.Console.WriteLine("Bonus de habilidade");
        double.TryParse(Console.ReadLine(), out bonHab);
        cristais = (moedas / taxas) * bonEvento * bonHab;
        Console.Clear();
        System.Console.WriteLine("Os Cristais obtidos é:" + cristais );

        System.Console.WriteLine("Clique enter para fechar");
        Console.ReadLine();

        
    }
}