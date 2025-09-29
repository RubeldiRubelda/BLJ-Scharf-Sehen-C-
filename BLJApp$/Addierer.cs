using System;
namespace Addierer
{
    internal class AddiererProgram
    {
        public static void Addiere()
        {
            int number1;
            int number2;
            int summe;

            Console.Write("Geben Sie die erste Zahl ein: ");
            number1 = Convert.ToInt32(Console.ReadLine()); 


            Console.Write("Geben Sie die zweite Zahl ein: ");
            number2 = Convert.ToInt32(Console.ReadLine());


            summe = number1 + number2;
            Console.WriteLine("Die Summe der beiden Zahlen ist: " + summe);
        }
    }
}