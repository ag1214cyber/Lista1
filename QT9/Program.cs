/*-------------------------------------------------------------------
Questão 9: Informações do Personagem
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
            
            double forca, forcaArma, bonusHab, modificadorCri, modificadorTipoArma, totalAtaque;
            Console.WriteLine("Qual a sua força");
            double.TryParse(Console.ReadLine(), out forca);
            System.Console.WriteLine("Qual a força da sua arma");
            double.TryParse(Console.ReadLine(), out forcaArma);
            System.Console.WriteLine("Seu bonus de habilidade");
            double.TryParse(Console.ReadLine(), out bonusHab);
            System.Console.WriteLine("Seu modificador crítico");
            double.TryParse(Console.ReadLine(), out modificadorCri);
            System.Console.WriteLine("Seu modificador do tipo de arma");
            double.TryParse(Console.ReadLine(), out modificadorTipoArma);
            totalAtaque = forca + (forcaArma * bonusHab * modificadorCri * modificadorTipoArma);
            Console.Clear();
            
            System.Console.WriteLine("Seu total de ataque é: " + totalAtaque);
            Console.ReadLine();
            


            

        }
    }