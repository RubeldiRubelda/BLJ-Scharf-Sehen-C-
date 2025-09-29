using System;
using System.Threading;

class Program
{
    static void Main()
    {
        ShowSpinner(30000); // 3000 ms = 3 Sekunden

        Console.WriteLine("Nächste Aufgabe geht hier weiter...");
        // ab hier dein weiterer Code
    }

    static void ShowSpinner(int durationMs)
    {
        char[] spinner = { '-', '/', '|', '\\' };
        int counter = 0;

        DateTime endTime = DateTime.Now.AddMilliseconds(durationMs);

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[counter % spinner.Length]);
            Thread.Sleep(50); // Geschwindigkeit einstellen
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            counter++;
        }

        // nach der Animation noch ein Leerzeichen, damit der Spinner "verschwindet"
        Console.Write(" ");
        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
    }
}
