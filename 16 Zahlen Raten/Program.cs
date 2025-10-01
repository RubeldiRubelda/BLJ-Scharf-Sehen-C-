using System;
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (int.TryParse(input, out int number))
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 3); // Zufallszahl zwischen 1 und 2


                    
            while (true)
            {
                Console.WriteLine("Geben Sie eine Zahl ein:");
                string input = Console.ReadLine();

                if (number == randomNumber)
                {
                    Console.WriteLine("Glückwunsch! Sie haben die richtige Zahl erraten!");
                }
                else // zu klein oder zu gross
                {
                        if (number < randomNumber)
                        {
                            Console.WriteLine("Die Zahl ist zu klein.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Die Zahl ist zu gross.");
                            break;
                        }
                }

                }
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Zahl ein.");
            }
            
        }
    }
}


