using System;
using System.Linq;

namespace SoisAlgorithms
{
    public static class Program
    {
        public static class Algorithms
        {
            public static void FizzBuzz()
            {
                Console.WriteLine("Problem extracted from this video https://www.youtube.com/watch?v=1t1_a1BZ04o ");

                Console.WriteLine(@"
                Problem:
                For 1 to 100
                
                print 'Fizz'     if a number is divisible by 3
                print 'Buzz'     if a number is divisible by 5
                print 'FizzBuzz' if a number is divisible by both
                print 'Bazz'     if a number is divisible by 7
                print the number if it is anything else");
                
                for (int i = 1;i < 100; i++)
                {
                    Console.WriteLine();
                         if (i % 3 == 0) { Console.Write("Fizz"); }
                         if (i % 5 == 0) { Console.Write("Buzz"); }
                         if (i % 7 == 0) { Console.Write("Bazz"); }
                    else if (i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
                                         { Console.Write(i); }
                    
                }
            }
            public static void Extense()
            {
                /*
                Console.WriteLine("Problem taken from this tweet https://twitter.com/MyNickIsNick_/status/1554513876284313601?t=enAJiS9_TporKHyUocsXhw&s=19");
                Console.WriteLine("For now, it only works from 1 to 20");

                Console.WriteLine(@"
                Problem:
                For 1 to ?? (still undefined)
                
                print number in extense by algorithm");
                */
                Console.WriteLine("WIP");
                
            }
        }

        static void MainMenu()
        {
            bool whiler = true;

            while (whiler is true)
            {
             Console.WriteLine(@"
             Write the following commands for the wanted algorithm.

             |1         - FizzBuzz
             |2         - Extense Text
             |3 or EXIT - Exits the program.
             |_____________________________________________________________
            ");
                string MS = Console.ReadLine() ?? "BLANK";
                
                if (MS == "1") {MS = "FIZZ";}
                if (MS == "2") {MS = "EXTENSE";}
                if (MS == "3") {MS = "EXIT";}
                MS = MS.ToUpper();
                switch (MS)
                {
                    case "FIZZ":
                        Algorithms.FizzBuzz();
                    break;

                    case "EXTENSE":
                        Algorithms.Extense();
                    break;

                    case "EXIT":
                        whiler = false;
                    break;

                    default:
                        Console.WriteLine("Invalid Command");
                    break;
                }
                            
            }
        }
        static void Main(string[] args)
        {
            Program.MainMenu();
        }
    }
}
    

