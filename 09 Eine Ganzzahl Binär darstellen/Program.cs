using System;
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib eine Ganzzahl ein:");
            int number = Convert.ToInt32(Console.ReadLine());
            string binary = "";
            for (int i = 31; i >= 0; i--)
            {
                int k = number >> i;
                if ((k & 1) > 0)
                {
                    binary += "1";
                }
                else
                {
                    binary += "0";
                }
            }
            Console.WriteLine("Die Binärdarstellung von " + number + " ist: " + binary);
        }
    }
}