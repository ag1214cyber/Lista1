/*-------------------------------------------------------------------
Questão 4: Informações do Personagem
• Contextualização: Em um jogo de RPG, o jogador precisa inserir as informações básicas do
personagem antes de começar a aventura.
• Comando: Crie um programa que receba o nome, idade, nível inicial, classe, e raça do
personagem e exiba esses dados no console.
@Lista: 01 - Lógica de Programação
@Autor: Arthur Gabriel
@Data: 03/09/2024
---------------------------------------------------------------------*/
using System;
using Microsoft.Extensions.Options;

class Program
{
    static void Main()
    {
         int primeiro, segundo, terceiro, quarto, quinto, total;        
        Console.WriteLine("Digite o primeiro numero da moeda coletada");
        int.TryParse(Console.ReadLine(), out primeiro);
        System.Console.WriteLine("Digite o segundo numero da moeda coletada");
        int.TryParse(Console.ReadLine(), out segundo);
        System.Console.WriteLine("Digite o terceiro numero da moeda coletada");
        int.TryParse(Console.ReadLine(), out terceiro);
        System.Console.WriteLine("Digite o quarto numero da moeda coletada");
        int.TryParse(Console.ReadLine(), out quarto);
        System.Console.WriteLine("Digite o quinto numero da moeda coletada");
        int.TryParse(Console.ReadLine(), out quinto);
        total = primeiro + segundo + terceiro + quarto + quinto;
        Console.Clear();
        System.Console.Write("Total da moeda:" + total);
        System.Console.WriteLine("Digite enter para fechar");
        Console.ReadLine();
         

    }
}
