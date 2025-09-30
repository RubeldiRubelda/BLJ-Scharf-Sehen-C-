using System;
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DATENBANK GRANDIOS 
            string[] forbiddenWords = { "viagra", "sex", "porno", "fick", "schlampe", "arsch", "hure", "nutte", "bordell", "schlechter Unterricht", "dumm", "blöd", "idiot", "stupid", "dumb", "idiotic", "foolish", "fool", "bastard", "BBZW"};
            Console.WriteLine("");
            Console.WriteLine("==================================================");
            Console.WriteLine("Anti Ragequit Simulator 3000! Google Maps Edition!");
            Console.WriteLine("==================================================");
            Console.WriteLine("");
Console.WriteLine("____ ____ _  _ ____    ____ ____ ____ _    ____ ____    ____ ____ _  _ ____   /");
Console.WriteLine("[__  |___ |__| |__/    |    |  | |  | |    |___ [__     | __ |__| |\\/| |___  / ");
Console.WriteLine("___] |___ |  | |  \\    |___ |__| |__| |___ |___ ___]    |__] |  | |  | |___ .  ");
                                                                               
            Console.WriteLine("");
            Console.WriteLine("Bitte ein Review schreiben:");

            string review = Console.ReadLine();
            bool forbiddenFound = false;
            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                if (review.ToLower().Contains(forbiddenWords[i].ToLower()))
                {
                    Console.WriteLine("Dein Review enthält verbotene Wörter. Bitte ändere dein Review.");
                    forbiddenFound = true;
                    break;
                }
            }
            if (!forbiddenFound)
            {
                Console.WriteLine("Danke für dein Review!");
            }
        }
    }
}