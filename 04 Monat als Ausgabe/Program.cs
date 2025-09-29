namespace _04_Monat_als_Ausgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ---------------- Array mit Monatsnamen ---------------- //
            string[] month = new string[13];
            
            month[0] = "January";
            month[1] = "February";
            month[2] = "March";
            month[3] = "April";
            month[4] = "May";
            month[5] = "June";
            month[6] = "July";
            month[7] = "August";
            month[8] = "September";
            month[9] = "October";
            month[10] = "November";
            month[11] = "December";
            

            // ---------------- Code oder so, isch das ned GRANDIOS??? ---------------- //

            Console.WriteLine("Willkommen zum Monats-Programm!");
            Console.WriteLine("Bitte geben Sie eine Zahl ein. um den entsprechenden Monat zu erhalten.");
            string input = Console.ReadLine();

            int daysInMonth = 0;

            if (int.TryParse(input, out daysInMonth) == true)
            {
                if (daysInMonth < 1 || daysInMonth > 12)
                {
                    Console.WriteLine("Auf unserem Planeten gibt es diesen Montat nicht. ");
                }
                else
                {

                    Console.WriteLine("Der Monat lautet " + month[daysInMonth - 1]); // -1 weil der Array bei 0 beginnt. allenfalls könnte man aber auch den Array mit 0 Leer lassen               
                }
            }
            else
            {
                Console.WriteLine("Eingabefehler. Bitte geben Sie eine Zahl ein.");
            }

        }
    }
}
