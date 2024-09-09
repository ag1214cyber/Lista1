 /*-------------------------------------------------------------------
Questão 8: Informações do Personagem
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
            int forca, agilidade, inteligencia, destreza, vitalidade, totalPontos;
            
            Console.WriteLine("Qual sua força");
            int.TryParse(Console.ReadLine(), out forca);
            System.Console.WriteLine("Qual a sua agilidade");
            int.TryParse(Console.ReadLine(), out agilidade);
            System.Console.WriteLine("Qual o seu nivel de inteligência");
            int.TryParse(Console.ReadLine(), out inteligencia);
            System.Console.WriteLine("Qual seu nivel de destreza");
            int.TryParse(Console.ReadLine(), out destreza);
            System.Console.WriteLine("Qual é seu nivel de vitalidade");
            int.TryParse(Console.ReadLine(), out vitalidade);
            

            totalPontos= forca + agilidade + inteligencia + destreza + vitalidade;

            Console.WriteLine("Seu total de pontos é: " + totalPontos);
            Console.ReadLine();
            

        }
    }