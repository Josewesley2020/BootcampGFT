using System;

namespace Desafio03
{
    class Program
    {
        static void Main(string[] args)
        {
            String tipo = Console.ReadLine(); 
            String classe = Console.ReadLine();
            String alimentacao = Console.ReadLine();

            if ((tipo == "vertebrado") && (classe == "ave") && (alimentacao == "carnivoro")) {
            Console.WriteLine("aguia\n");
            } else if ((tipo == "vertebrado") && (classe == "ave") && (alimentacao == "onivoro")) {
            Console.WriteLine("pomba\n");
            } else if ((tipo == "vertebrado") && (classe == "mamifero") && (alimentacao == "onivoro")) {
            Console.WriteLine("homem\n");
            } else if ((tipo == "vertebrado") && (classe == "mamifero") && (alimentacao == "herbivoro")) {
            Console.WriteLine("vaca\n");
            } else if ((tipo == "invertebrado") && (classe == "inseto") && (alimentacao == "hematofago")) {
            Console.WriteLine("pulga\n");
            } else if ((tipo == "invertebrado") && (classe == "inseto") && (alimentacao == "herbivoro")) {
            Console.WriteLine("lagarta\n");
            } else if ((tipo == "invertebrado") && (classe == "anelideo") && (alimentacao == "hematofago")) {
            Console.WriteLine("sanguessuga\n");
            } else if ((tipo == "invertebrado") && (classe == "anelideo") && (alimentacao == "onivoro")) {
            Console.WriteLine("minhoca\n");
            } else {
            tipo = Console.ReadLine();
            classe = Console.ReadLine();
            alimentacao = Console.ReadLine();
            }
        }
    }
}
