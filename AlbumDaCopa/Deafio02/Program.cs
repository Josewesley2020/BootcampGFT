using System;
using System.Collections.Generic;
using System.Linq;

namespace Deafio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDeFigurinhas = Int32.Parse(Console.ReadLine());
            int numeroDeFigurinhasCompradas = Int32.Parse(Console.ReadLine());
            int totalDeFigurinhas = 0;

            // Substitui o array por uma lista para facilitar a manipulação
            List <int> album = new List<int>();

            for(int i = 0; i < numeroDeFigurinhasCompradas; i++){
            album.Add(Int32.Parse(Console.ReadLine()));
            }
            // Separei em uma variável as figurinhas que não repetem
            var diferentes = album.Distinct().ToList();

            totalDeFigurinhas = numeroDeFigurinhas - diferentes.Count;

            Console.WriteLine(totalDeFigurinhas);

        }
    }
}
