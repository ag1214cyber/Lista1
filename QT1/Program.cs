
/*-------------------------------------------------------------------
Questão 1: Informações do Personagem
• Contextualização: Em um jogo de RPG, o jogador precisa inserir as informações básicas do
personagem antes de começar a aventura.
• Comando: Crie um programa que receba o nome, idade, nível inicial, classe, e raça do
personagem e exiba esses dados no console.
@Lista: 01 - Lógica de Programação
@Autor: Arthur Gabriel
@Data: 19/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main(string[] args)
    {
        string?  nome, classe, raça;
        int idade, nivel;
        Console.WriteLine("Nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Classe: ");
        classe = Console.ReadLine();
        Console.WriteLine("Raça: ");
        raça = Console.ReadLine();
        Console.WriteLine("Idade: ");
        int.TryParse(Console.ReadLine(), out idade);
        Console.WriteLine("Nivel: ");
       int.TryParse(Console.ReadLine(), out nivel);
        System.Console.WriteLine("JOGADOR:");
        System.Console.WriteLine(nome);
        System.Console.WriteLine(classe);
        System.Console.WriteLine(raça);
        System.Console.WriteLine(idade);
        System.Console.WriteLine(nivel);
        Console.WriteLine("PRESSIONE ENTER PARA FECHAR");
        Console.ReadLine();
        }
}