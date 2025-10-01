using System;
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wann bist du geboren? TT:MM:YYYY");
            string eingabe = Console.ReadLine();
            DateTime geburtstag;
            bool erfolgreich = DateTime.TryParse(eingabe, out geburtstag);
            if (erfolgreich)
            {
                DateTime heute = DateTime.Now;
                int alter = heute.Year - geburtstag.Year;
                if (heute < geburtstag.AddYears(alter)) alter--;
                Console.WriteLine("Du bist " + alter + " Jahre alt.");
            }
            if (erfolgreich)
            {
                DateTime heute = DateTime.Now;
                int alter = heute.Month - geburtstag.Month;
                if (heute < geburtstag.AddMonths(alter)) alter--;
                Console.WriteLine("Und " + alter + " Monate alt.");
            }
            if (erfolgreich)
            {
                DateTime heute = DateTime.Now;
                int alter = heute.Day - geburtstag.Day;
                if (heute < geburtstag.AddDays(alter)) alter--;
                Console.WriteLine("Und " + alter + " Tage alt.");
            }
            else
            {
                Console.WriteLine("Das Datum ist ungültig.");
            }
            Console.WriteLine("==============================================");

            Console.WriteLine("Und jetzt noch alleinstellig in Tagen:");
            if (erfolgreich)
            {
                DateTime heute = DateTime.Now;
                TimeSpan differenz = heute - geburtstag;
                Console.WriteLine("Du bist " + differenz.TotalDays + " Tage alt.");
            }
            else
            {
                Console.WriteLine("Das Datum ist ungültig.");
            }
            if (erfolgreich)
            {
                DateTime heute = DateTime.Now;
                TimeSpan differenz = heute - geburtstag;
                Console.WriteLine("Du bist " + differenz.TotalSeconds + " Sekunden alt.");
            }
            else
            {
                Console.WriteLine("Das Datum ist ungültig.");
            }
            Console.WriteLine("==============================================");
            Console.WriteLine("Drücke eine beliebige Taste zum Beenden.");
        }
    }
}