using System;
namespace Addierer
{
    internal class Program
    {
        static void Main()
        {
            int number1;
            int number2;
            int summe;


            Console.Write("Willkommen beim Grandiosen Addierer! Wählen Sie die Zahlen: ");
            Console.Write("Geben Sie die erste Zahl ein: ");
            number1 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Geben Sie die zweite Zahl ein: ");
            number2 = Convert.ToInt32(Console.ReadLine());


            summe = number1 + number2;
            Console.WriteLine("Die Summe der beiden Zahlen ist: " + summe);
        }
    }
}