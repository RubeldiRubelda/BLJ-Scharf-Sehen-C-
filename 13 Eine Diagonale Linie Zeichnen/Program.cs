using System;
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
























            string asciiArt = @"                                                                                                                           
                                            @@@  @@                                                          @@@                  
                                            @@@  @@                                                          @@@                  
                                       @@@@@@@@  @@@   @@@@@@     @@@@@@@@   @@@@@@@   @@@@@@@@    @@@@@@@   @@@                  
                    @@@@             :@@@   @@@  @@@  @@@   @@@ @@@@   @@@  @@@   @@@@ @@@   @@@  @@@   @@@  @@@                  
                    @@@@@@@@         @@@    @@@  @@@  =@@@@@@@@ @@@    @@@ @@@     @@@ @@@   @@@   @@@@@@@@  @@@                  
                    @@@@@@@@@@@      @@@    @@@  @@@ @@@    @@@ @@@    @@@ @@@:    @@@ @@@   @@@  @@@   @@@  @@@                  
                    @@@@   @@@@@@@@   @@@@@@@@@  @@@  @@@@@@@@@  @@@@@@@@@  @@@@@@@@@  @@@   @@@  @@@@@@@@@  @@@                  
                    @@@@      +@@@@@@@#                                @@@                                                        
                    @@@@          @@@@@@@@                       @@@@@@@@                                                         
                    @@@@              @@@@@@@@                                                                                    
                    @@@@                 @@@@@@@@@                                                                                
                    @@@@                     @@@@@@@@                                                                             
                    @@@@                        .@@@@@@@@                                                                         
                    @@@@                            @@@@@@@@                                                                      
                    @@@@                                @@@@@@@@                                                                  
                    @@@@                                    @@@@@@@@                                                              
                    @@@@                                       @@@@@@@@*
                    @@@@                                           @@@@@@@@                                                       
                    @@@@                                              -@@@@@@@@                                                   
                    @@@@-                                                 @@@@@@@@                                                
                    @@@@+                                                     @@@@@@@@                                            
                    @@@@#                                                        -@@@@@@@@                                        
                    @@@@@                                                            @@@@@@@@=
                    @@@@@                                                                @@@@@@@@                                 
                    @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#+=:@@@@@@@@@@                             
                    @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                            
                                                                                                               
                                                                                                                                  
                                                                                                                                  
                                                                                                                                                    ";
            Console.WriteLine(asciiArt);


            string input;
            int number;

            do
            {
                Console.Write("Wie lang soll die Linie sein?\nDeine Eingabe: ");
                input = Console.ReadLine();
            } while (int.TryParse(input, out number) == false);

            Console.Write("\n");

            for (int i = 1; i <= number; i++)
            {
                for (int i2 = 1; i2 <= number; i2++)
                {
                    if (i2 == i)
                    {
                        Console.Write("@");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");



                for (int i2 = 1; i2 <= number; i2++)
                {
                    if (i2 == i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("@");
                    }
                }
                Console.Write("\n");
            }
            Console.ReadKey();















        }
    }
}
