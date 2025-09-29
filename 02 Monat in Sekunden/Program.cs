namespace Aufgabe2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen zum Monats-Programm!");
            Console.WriteLine("Bitte geben Sie eine Zahl ein.");
            string input = Console.ReadLine();

            int daysInMonth = 0;
            // TryParse ergibt True wenn Konvertierung geklappt hat 
            // und das Resultate der Konvertierung wird in den out-Parameter "zahl" geschrieben
            if (int.TryParse(input, out daysInMonth) == true)
            {
                if (daysInMonth < 28 || daysInMonth > 31)
                {
                    Console.WriteLine("Auf unserem Planeten gibt es keinen Monat mit so vielen Tagen ");
                }
                else
                {
                    int seconds = daysInMonth * 24 * 60 * 60;
                    Console.WriteLine("Der Monat hat " + seconds + " Sekunden.");
                }
            }
            else
            {
                Console.WriteLine("Eingabefehler. Bitte geben Sie eine Zahl ein.");
            }
        }
    }
}
