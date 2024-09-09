/*-------------------------------------------------------------------
Questão 10: Informações do Personagem
• Contextualização: Em um jogo de RPG, o jogador precisa inserir as informações básicas do
personagem antes de começar a aventura.
• Comando: Crie um programa que receba o nome, idade, nível inicial, classe, e raça do
personagem e exiba esses dados no console.
@Lista: 01 - Lógica de Programação
@Autor: Arthur Gabriel
@Data: 09/09/2024
---------------------------------------------------------------------*/
 using System;

    class Program
    {
        static void Main()
        {
            
            int pontosVidas, nivel, nivelAlcancado, pontosFinais;
            
            Console.WriteLine("Quantos pontos de vidas iniciadas");
            int.TryParse(Console.ReadLine(), out pontosVidas);
            System.Console.WriteLine("Quanto o seu aumento de nivel");
            int.TryParse(Console.ReadLine(), out nivel);
            System.Console.WriteLine("Maximo de nivel alcançado");
            int.TryParse(Console.ReadLine(), out nivelAlcancado);
            pontosFinais= pontosVidas + (nivel * nivelAlcancado);
            Console.Clear();
            
            System.Console.WriteLine("Seus pontos de vida finais é: " + pontosFinais);
            Console.ReadLine();
            


            

        }
    }