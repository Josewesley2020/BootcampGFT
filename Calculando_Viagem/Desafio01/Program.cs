using System;
using System.Collections.Generic;

namespace Desafio01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] viagem = Console.ReadLine().Split(' ');
            int hour = Int32.Parse(viagem[0]);
            int velocidade = Int32.Parse(viagem[1]);

            double kmRodado = hour * velocidade;
            double litrosCombustivel = kmRodado/12;

            Console.WriteLine(litrosCombustivel.ToString("f3"));
  
        }
    }
}
