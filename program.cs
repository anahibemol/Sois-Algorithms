using System;
using System.Linq;
using System.Collections;

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

            public static void TwoSum()
            {
                Console.WriteLine("Problem extracted from this site https://www.shorturl.at/uvX38 ");

                Console.WriteLine(@"
                Problem:
                
                Find all the pairs of two integers in an unsorted array that sum up to a given S");

                Console.WriteLine(@"For this problem, we will use Lists instead of arrays since they
                work much better for C# and make the problem more customizable");

                List<int> initialList = new List<int>{};

                Console.WriteLine("How many elements will your two sum List have ?");
                int limiter = Convert.ToInt32(Console.ReadLine());
                
                for (int i = 1; limiter+1 > i; i++)
                {
                    Console.WriteLine($"({limiter - i} remaining!) Write the next number");
                    int a = Convert.ToInt32(Console.ReadLine());
                    initialList.Add(a);
                }

                Console.WriteLine("Now write the S (value that will be the result of the sum)");
                int S = Convert.ToInt32(Console.ReadLine());

                List<string> sumList = new List<string>{};
                for (int i = 0; limiter > i; i++)
                {
                    if (initialList[i] + initialList[^(1+i)] == S)
                    {
                    string match = $"{initialList[i]} + {initialList[^(i+1)]} is equal to {S}";
                    sumList.Add(match);
                    }
                }
                Console.WriteLine("The inputted array (list):");
                Console.WriteLine(string.Join(" ", initialList));

                Console.WriteLine("The sums that give the result:");
                Console.WriteLine(string.Join("\n", sumList));
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
        
            public static void Roman()
            {
                Console.WriteLine("Write your Roman Numeral");

                string roman = Console.ReadLine() ?? "UNSET";
                int Number = 0;
                int size = roman.Length;
                roman = roman.ToUpper();
                if (roman != "UNSET")             
                {
                    char[] characters = roman.ToCharArray();
                    Console.WriteLine(characters);
                    foreach(char c in roman)
                    {
                        Console.WriteLine(c);
                        if (c=='I')
                        {
                            Number = Number+1;
                        }
                        if (c=='V')
                        {
                            Number = Number+5;
                        }
                        if (c=='X')
                        {
                            Number = Number+10;
                        }
                        if (c=='L')
                        {
                            Number = Number+50;
                        }
                        if (c=='C')
                        {
                            Number = Number+100;
                        }
                        if (c=='D')
                        {
                            Number = Number+500;
                        }
                        if (c=='M')
                        {
                            Number = Number+1000;
                        }
                    }

                    Console.WriteLine(Number);
                }
                else
                {
                    Console.WriteLine("Please write something");
                }
                
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
             |2         - Two Sum
             |3         - Extense Text
             |4         - Roman Numerals
             |5 or EXIT - Exits the program.
             |_____________________________________________________________
            ");
                string MS = Console.ReadLine() ?? "BLANK";
                
                if (MS == "1") { MS = "FIZZ";    }
                if (MS == "2") { MS = "TWOSUM"; }
                if (MS == "3") { MS = "EXTENSE"; }
                if (MS == "4") { MS = "ROMAN"; }
                if (MS == "5") { MS = "EXIT";    }
                MS = MS.ToUpper();
                switch (MS)
                {
                    case "FIZZ":
                        Algorithms.FizzBuzz();
                    break;

                    case "TWOSUM":
                        Algorithms.TwoSum();
                    break;

                    case "EXTENSE":
                        Algorithms.Extense();
                    break;

                    case "ROMAN":
                        Algorithms.Roman();
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
    

