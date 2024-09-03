/*-------------------------------------------------------------------
Questão 2: Informações do Personagem
• Contextualização: Em um jogo de RPG, o jogador precisa inserir as informações básicas do
personagem antes de começar a aventura.
• Comando: Crie um programa que receba o nome, idade, nível inicial, classe, e raça do
personagem e exiba esses dados no console.
@Lista: 01 - Lógica de Programação
@Autor: Arthur Gabriel
@Data: 02/09/2024
---------------------------------------------------------------------*/
using System;

class Program 

{
    static void Main()
    {
        int inimigos, pontosInimigos, missao;
        double pontosFinais, multDif, multBonus;

            Console.WriteLine("Quantos inimigos foram derrotados:");
            int.TryParse(Console.ReadLine(), out inimigos);
            Console.WriteLine("Quantos pontos por inimigos:");
            int.TryParse(Console.ReadLine(), out pontosInimigos);
            Console.WriteLine("Quanto foi o bonus da missao:");
            int.TryParse(Console.ReadLine(), out missao);

            Console.WriteLine("Quanto foi o multiplicador de bonus");
            double.TryParse(Console.ReadLine(), out multBonus);
            Console.WriteLine("Qual foi o multiplicador de dificuldade");
            double.TryParse(Console.ReadLine(), out multDif);
            pontosFinais = inimigos * pontosInimigos * multBonus * multDif + missao;
            Console.WriteLine("Sua pontuação final é:"  + pontosFinais);
            Console.WriteLine("Clique no enter para fechar");
            Console.ReadLine();
    }
}