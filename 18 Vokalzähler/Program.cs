using System;
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte einen Satz eingeben:");
            string eingabe = Console.ReadLine();
            int vokalAnzahl = 0;
            for (int i = 0; i < eingabe.Length; i++)
            {
                char buchstabe = char.ToLower(eingabe[i]);
                if (buchstabe == 'a' || buchstabe == 'e' || buchstabe == 'i' || buchstabe == 'o' || buchstabe == 'u' || buchstabe == 'ä' || buchstabe == 'ö' || buchstabe == 'ü')
                {
                    vokalAnzahl++;
                }
            }
            Console.WriteLine("Der Satz enthält " + vokalAnzahl + " Vokale.");
        }
    }
}