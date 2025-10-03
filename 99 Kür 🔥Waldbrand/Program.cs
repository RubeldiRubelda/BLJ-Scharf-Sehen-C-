using System;
using System.Threading;
using System.Diagnostics;
using System.Text;
namespace Program

{
    internal class Program
    {


        static void Main(string[] args)
        {

            //////////// VARIABLEN ////////////
            int width = 50;  //Grösse
            int height = 25; //Grösse
            int z = 1; ///// Wahrscheindlichkeit Funkenentzündung
            int w = 2; //// Wachstum
            int t = 250; //// Zeit
            string input;
            //////////// VARIABLEN ////////////





            //////////// SPINNER ////////////
            Console.OutputEncoding = Encoding.UTF8;
            // Example usage of ConsoleSpinner
            ConsoleSpinner spinner = new ConsoleSpinner();
            Console.Write("   Lädt...");
            for (int i = 0; i < 1000 / 24 * 0.6; i++)
            {
                spinner.Turn();
            }
            Console.Clear();
            //////////// SPINNER ////////////






            string[,] forest = new string[height, width];

            GeneratingForest(forest, width, height);

            while (!Console.Keyavailable)
            {
                Render(forest, width, height);
                forest = (string[,])TreeGrow(forest, width, height, w).Clone();
                forest = (string[,])FireSpread(forest, width, height, z).Clone();
                forest = (string[,])Firextinguish(forest, width, height).Clone();
                forest = (string[,])CatchFire(forest, width, height, z).Clone();
            }
        }




        static void GeneratingForest(string[,] forest, int width, int height)
        {
            Random rand = new Random();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int r = rand.Next(0, 100);
                    if (r < 70)
                    {
                        forest[y, x] = "🌲"; // Baum
                    }
                    else
                    {
                        forest[y, x] = "  "; // Leerer Platz
                    }
                }
            }
        }

        static string[,] CatchFire(string[,] forest, int width, int height, int z)
        {
            Random rand = new Random();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (forest[y, x] == "🌲")
                    {
                        int r = rand.Next(0, 1000);
                        if (r < z)
                        {
                            forest[y, x] = "🔥"; // Baum fängt Feuer
                        }
                    }
                }
            }
            return forest;
        }











        //////////// SPINNER ////////////
        public class ConsoleSpinner
        {
            int counter;
            public void Turn()
            {
                Console.SetCursorPosition(0, 0);

                counter++;
                switch (counter % 11)
                {
                    case 0: Console.WriteLine("🕐"); counter = 0; break;
                    case 1: Console.WriteLine("🕑"); break;
                    case 2: Console.WriteLine("🕒"); break;
                    case 3: Console.WriteLine("🕓"); break;
                    case 4: Console.WriteLine("🕔"); break;
                    case 5: Console.WriteLine("🕕"); break;
                    case 6: Console.WriteLine("🕖"); break;
                    case 7: Console.WriteLine("🕗"); break;
                    case 8: Console.WriteLine("🕘"); break;
                    case 9: Console.WriteLine("🕙"); break;
                    case 10: Console.WriteLine("🕚"); break;
                    case 11: Console.WriteLine("🕛"); break;
                }
                Thread.Sleep(24);
                //////////// SPINNER ////////////


            }
        }
    }
}
