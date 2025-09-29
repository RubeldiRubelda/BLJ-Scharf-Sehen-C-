using System;
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int makingKilometers;



            Console.WriteLine("Wie viele Kilometer möchtest du rennen?");
            string input = Console.ReadLine();



            if (int.TryParse(input, out makingKilometers) == true)
            {
                if (makingKilometers < 1 || makingKilometers > 42)
                {
                    Console.WriteLine("Das schaffst du nie! ");//42.195 km ist ein Marathon sagt Google (Crazy)
                }
                else
                {

                    Console.WriteLine("Berechne anzahl Bahnrunden... " + makingKilometers);
                }
            }
            else
            {
                Console.WriteLine("Eingabefehler. Bitte geben Sie eine Zahl ein.");
            }
        }
    }
}