namespace _04_Monat_als_Ausgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ---------------- Array mit Monatsnamen ---------------- //
            string[] month = new string[13];
            month[0] = "";
            month[1] = "January";
            month[2] = "February";
            month[3] = "March";
            month[4] = "April";
            month[5] = "May";
            month[6] = "June";
            month[7] = "July";
            month[8] = "August";
            month[9] = "September";
            month[10] = "October";
            month[11] = "November";
            month[12] = "December";
            

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
                   
                    Console.WriteLine("Der Monat lautet " + month[daysInMonth]);
                }
            }
            else
            {
                Console.WriteLine("Eingabefehler. Bitte geben Sie eine Zahl ein.");
            }

        }
    }
}
