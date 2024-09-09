/*-------------------------------------------------------------------
Questão 7: Informações do Personagem
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
        int xpA, xpInimigo1, derrotadosInimigo1, xpInimigo2, derrotadosInimigo2, constantes, xpTotal, nivel;
        Console.WriteLine("Quantos xp acumulado");
        int.TryParse(Console.ReadLine(), out xpA);
        System.Console.WriteLine("Quantos xp inimigo1");
        int.TryParse(Console.ReadLine(), out xpInimigo1);
        System.Console.WriteLine("Quantos inimigos 1 derrotados"); 
        int.TryParse(Console.ReadLine(), out derrotadosInimigo1);
        System.Console.WriteLine("Quantos xp inimigo2");
        int.TryParse(Console.ReadLine(), out xpInimigo2);
        System.Console.WriteLine("Quanto inimigos 2 derrotados");
        int.TryParse(Console.ReadLine(), out derrotadosInimigo2);
        System.Console.WriteLine("Quantas Constantes de nivel");
        int.TryParse(Console.ReadLine(), out constantes);
       
        xpTotal= xpA + (xpInimigo1 * derrotadosInimigo1) + (xpInimigo2 * derrotadosInimigo2);
        nivel = (xpTotal / constantes); 

        System.Console.WriteLine("O xp total é:" + xpTotal);
        Console.ReadLine();               
    }
}
