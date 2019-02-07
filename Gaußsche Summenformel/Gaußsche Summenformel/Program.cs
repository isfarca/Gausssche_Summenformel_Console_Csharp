using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaußsche_Summenformel
{
    class Program
    {
        static void Main(string[] args)
        {
            string Eingabe;
            int MinZahl;
            int MaxZahl;
            int n = 0;
            int Ergebnis;

            Console.Write("Minimum: ");
            Eingabe = Console.ReadLine();
            MinZahl = Convert.ToInt32(Eingabe);

            Console.Write("Maximum: ");
            Eingabe = Console.ReadLine();
            MaxZahl = Convert.ToInt32(Eingabe);

            for (int i = MinZahl; i <= MaxZahl; i++)
                n++;

            Ergebnis = n * (n + 1) / 2;

            Console.WriteLine("\n {0}", Ergebnis);
            Console.ReadKey();
        }
    }
}
